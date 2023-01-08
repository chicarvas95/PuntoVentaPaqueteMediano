using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Input;
using USB_Barcode_Scanner;
using PuntoDeVenta.CapaNegocio;

namespace CursoPuntoDeVentasTresCapas
{
    public partial class FrmVentas : Form
    {
        private  string descripcion,CodigoProducto,PagoEfectivo,articulo  = "";
        private  decimal precio      = 0;
        private decimal importe = 0;
        private  int inventario,ArticulosVendidos,IdVenta  = 0;
        private  int cantidad = 1;
        
        CN_InventarioProductos InstCapaNegocio = new CN_InventarioProductos();

        public FrmVentas()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(txt_CodigoProducto);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }
        #region Eventos Click Teclado Touch
        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 0;
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 1;
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 2;
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 3;
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 4;
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 5;
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 6;
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 7;
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 8;
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_CodigoProducto.Text += 9;
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CodigoProducto.Text))
            {
                MessageBox.Show("No es posible borrar el dato, debido a que no hay caracteres por eliminar");
            }
            else
            {
                txt_CodigoProducto.Text = txt_CodigoProducto.Text.Substring(0, txt_CodigoProducto.Text.Count() - 1);
            }
            
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_CodigoProducto.Text))
            {
                MessageBox.Show("Favor de introducir el codigo de producto manual, o escanea el producto.");
            }
            else
            {
                try
                {
                    decimal total = 0;
                    cantidad = 1;
                    CodigoProducto = txt_CodigoProducto.Text;
                    DataTable InformacionProducto = BuscarProductoEnInventarioCapaNegocio(CodigoProducto);
                    if (InformacionProducto.Rows.Count == 0)
                    {
                        MessageBox.Show("No fue encontrada información, verificar si el codigo ingresado es correcto");
                        txt_CodigoProducto.Clear();
                        txt_CodigoProducto.Focus();
                        return;
                    }
                    else
                    {
                        foreach (DataRow row in InformacionProducto.Rows)
                        {
                            descripcion = row["NombreProducto"].ToString();
                            precio = Convert.ToDecimal(row["PrecioProducto"].ToString());
                            inventario = int.Parse(row["CantidadInventario"].ToString());
                        }
                        importe = precio * cantidad;
                        string[] row1 = new string[] { cantidad.ToString(), descripcion, precio.ToString(), importe.ToString() };
                        gvProductos.Rows.Add(row1);

                        foreach (DataGridViewRow row in gvProductos.Rows)
                        {
                            precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                            int cantidadColumna = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            decimal t1 = precio * cantidadColumna;
                            total += t1;
                        }
                    }
                    lbl_precio.Text = "$ " + Convert.ToString(total) + " MXN";
                }
                catch (Exception ex)
                {
                    throw;
                }
                txt_CodigoProducto.Clear();
                txt_CodigoProducto.Focus();
            }
            
        }
        #endregion

        #region Botones de acciones
        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            decimal Total = 0;
            try
            {
                if (gvProductos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow Rw in gvProductos.SelectedRows)
                    {
                        gvProductos.Rows.Remove(Rw);
                    }
                    foreach (DataGridViewRow row in gvProductos.Rows)
                    {
                        Total += Convert.ToDecimal(row.Cells[2].Value);
                    }
                    lbl_precio.Text = "$ " + Total.ToString() + " MXN";
                }
                else
                {
                    MessageBox.Show("Favor de seleccionar una fila para poder eliminarla");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        private void Btn_Cobrar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal precio = 0;
                decimal t1 = 0;
                decimal total = 0;
                decimal iva = 0;
                decimal subtotal = 0;
                decimal cambio = 0;
                int cantidadColumna = 0;
                if (gvProductos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay ningun producto registrado en la tabla, favor de escanear o escribir el codigo para buscarlo manualmente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (DataGridViewRow item in gvProductos.Rows)
                {
                    precio = Convert.ToDecimal(item.Cells["Precio"].Value);
                    cantidadColumna = Convert.ToInt32(item.Cells["Cantidad"].Value);
                    t1 = precio * cantidadColumna;
                    total += t1;
                }
                
                PagoEfectivo = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el total de dinero que el cliente pago", "Pago cliente efectivo");
                
                bool isNumeric = PagoEfectivo.All(char.IsDigit);
                if (!isNumeric)
                {
                    MessageBox.Show("Favor de ingresar puros números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Convert.ToDecimal(PagoEfectivo) < total)
                {
                    MessageBox.Show("No se puede cobrar con una cantidad menor al total, favor de ingresar una cantidad correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    cambio = Convert.ToDecimal(PagoEfectivo) - total;
                    iva = Math.Round((decimal)((int)total * 0.16));
                    subtotal = total - iva;
                    IdVenta = InsertarDatosVenta(subtotal, iva, total, Convert.ToDecimal(PagoEfectivo), cambio);
                    CrearTicket ticket = new CrearTicket();
                    //Aqui iva antes el TextoCentro,TextoIzquierda,TextoExtremos,lineasAsteriscos,EncabezadoVenta
                    ticket.TextoCentro("Abarrotes ejemplo");
                    ticket.TextoIzquierda("EXPEDIDO EN: Abarrotes ejemplo, sucursal ejemplo");
                    ticket.TextoIzquierda("DIREC: Monterrey nuevo leon");
                    ticket.TextoIzquierda("TEL: 6563442602");
                    ticket.TextoIzquierda("RFC: ADASDSAD");
                    ticket.TextoIzquierda("EMAIL: prueba@gmail.com");
                    ticket.TextoIzquierda("");
                    ticket.TextoExtremos("No Venta # " + IdVenta);//Anteriormente se pasaban dos parametros.
                    ticket.lineasAstericos();
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("ATENDIO: VENDEDOR");
                    ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("FECHA: " + DateTime.Now.ToShortDateString() + " HORA: " + DateTime.Now.ToShortTimeString());
                    ticket.lineasAstericos();
                    ticket.EncabezadoVenta();
                    ticket.lineasAstericos();
                    //fin de Aqui iva antes el TextoCentro,TextoIzquierda,TextoExtremos,lineasAsteriscos,EncabezadoVenta
                    ArticulosVendidos = Convert.ToInt32(gvProductos.Rows.Count.ToString()) - 1;
                    foreach (DataGridViewRow row in gvProductos.Rows)
                    {
                        decimal t2 = 0;
                        decimal total2 = 0;
                        decimal iva2 = 0;
                        decimal precio2 = 0;
                        decimal importe2 = 0;
                        articulo = Convert.ToString(row.Cells["Descripcion"].Value);
                        cantidadColumna = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        precio2 = Convert.ToDecimal(row.Cells["Precio"].Value);
                        //importe2 = Convert.ToDecimal(row.Cells["Importe"].Value);
                        if (!string.IsNullOrEmpty(articulo))
                        {
                            t2 = precio2 * cantidadColumna;
                            total2 += t2;
                            iva2 = Math.Round((decimal)((int)total * 0.16));
                            ticket.AgregarArticulo(articulo, cantidadColumna, precio2, t2);
                            InsertarDetalleVenta(IdVenta, articulo, precio2, cantidadColumna, t2);
                        }   
                    }
                    ticket.lineasIgual();
                    ticket.AgregarTotales("          SUBTOTAL.....$", subtotal);
                    ticket.AgregarTotales("          IVA..........$", iva);
                    ticket.AgregarTotales("          TOTAL........$", total);
                    ticket.TextoIzquierda("");
                    ticket.AgregarTotales("          EFECTIVO.....$", Convert.ToDecimal(PagoEfectivo));
                    ticket.AgregarTotales("          CAMBIO.......$", cambio);
                    //texto final del ticket
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("ARTICULOS VENDIDOS: " + ArticulosVendidos);
                    ticket.TextoIzquierda("");
                    ticket.TextoCentro("GRACIAS POR SU COMPRA!");
                    ticket.CortaTicket();
                    ticket.AbreCajon();
                    ticket.ImprimirTicket("ImpresoraTicketsPOS");
                    gvProductos.Rows.Clear();
                    txt_CodigoProducto.Focus();
                    lbl_precio.Text = "";
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void btn_AltaProductos_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto frmAgregarProducto = new FrmAgregarProducto();
            frmAgregarProducto.ShowDialog();
        }

        #endregion

        #region Eventos datagridview
        private void gvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string precioActual = "";
            string NuevaCantidad = "";
            int CantidadToDecimal = 0;
            decimal PrecioToDecimal = 0;
            decimal total = 0;
            int ImporteTotal = 0;
            try
            {
                if (e.ColumnIndex == 0)
                {
                    NuevaCantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la cantidad", "Aumentar o disminuir cantidad");
                    bool isNumeric = NuevaCantidad.All(char.IsDigit);
                    if (!isNumeric)
                    {
                        MessageBox.Show("Favor de ingresar puros números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gvProductos.Rows[e.RowIndex].Cells[0].Value = NuevaCantidad;
                        precioActual = gvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                        CantidadToDecimal = Convert.ToInt32(NuevaCantidad);
                        PrecioToDecimal = Convert.ToDecimal(precioActual);
                        ImporteTotal = (int)(PrecioToDecimal * CantidadToDecimal);
                        gvProductos.Rows[e.RowIndex].Cells[3].Value = Convert.ToString(ImporteTotal + ".00");
                        foreach (DataGridViewRow row in gvProductos.Rows)
                        {
                            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                            int cantidadColumna = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            decimal t1 = precio * cantidadColumna;
                            total += t1;
                        }
                        lbl_precio.Text = "$ " + Convert.ToString(total) + " MXN";
                        txt_CodigoProducto.Clear();
                        txt_CodigoProducto.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnReporteDelDia_Click(object sender, EventArgs e)
        {
            FrmReporteVentasDiarias InstanciaFormularioReporteVentasDiarias = new FrmReporteVentasDiarias();
            InstanciaFormularioReporteVentasDiarias.ShowDialog();
        }

        private void btn_EliminarProducto_Click_1(object sender, EventArgs e)
        {
            decimal Total = 0;
            try
            {
                if (gvProductos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow Rw in gvProductos.SelectedRows)
                    {
                        gvProductos.Rows.Remove(Rw);
                    }
                    foreach (DataGridViewRow row in gvProductos.Rows)
                    {
                        Total += Convert.ToDecimal(row.Cells[2].Value);
                    }
                    lbl_precio.Text = "$ " + Total.ToString() + " MXN";
                }
                else
                {
                    MessageBox.Show("Favor de seleccionar una fila para poder eliminarla");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Eventos Formulario Ventas
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            txt_CodigoProducto.Focus();
        }
        #endregion

        #region Eventos Escaner
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            try
            {
                decimal total = 0;
                cantidad = 1;
                txt_CodigoProducto.Text = e.Barcode;
                CodigoProducto = txt_CodigoProducto.Text;
                DataTable InformacionProducto = BuscarProductoEnInventarioCapaNegocio(CodigoProducto);
                if (InformacionProducto.Rows.Count == 0)
                {
                    MessageBox.Show("No fue encontrada información, verificar si el codigo ingresado es correcto");
                    txt_CodigoProducto.Clear();
                    txt_CodigoProducto.Focus();
                    return;
                }
                else
                {
                    foreach (DataRow row in InformacionProducto.Rows)
                    {
                        descripcion = row["NombreProducto"].ToString();
                        precio = Convert.ToDecimal(row["PrecioProducto"].ToString());
                        inventario = int.Parse(row["CantidadInventario"].ToString());
                    }
                    importe = precio * cantidad;
                    string[] row1 = new string[] {cantidad.ToString(), descripcion, precio.ToString(), importe.ToString() };
                    gvProductos.Rows.Add(row1);
                    foreach (DataGridViewRow row in gvProductos.Rows)
                    {
                        precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                        int cantidadColumna = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal t1 = precio * cantidadColumna;
                        total += t1;
                    }
                }
                lbl_precio.Text = "$ " + Convert.ToString(total) + " MXN";
            }
            catch (Exception ex)
            {

            }
            txt_CodigoProducto.Clear();
            txt_CodigoProducto.Focus();
        }
        #endregion

        #region Instancias Metodos CapaNegocio
        private DataTable BuscarProductoEnInventarioCapaNegocio(string paramCodigoProducto) 
        {
            try
            {
                CN_InventarioProductos objetoInstCapaNegocio = new CN_InventarioProductos();
                DataTable informacionProducto = objetoInstCapaNegocio.BuscarProductoEnInventario(paramCodigoProducto);
                return informacionProducto;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private int InsertarDatosVenta(decimal subtotal,decimal iva,decimal total,decimal efectivo,decimal cambio) 
        {
            try
            {
                CN_Ventas objetoInstanciaVentas = new CN_Ventas();
                IdVenta = objetoInstanciaVentas.InsertarDatosVenta(subtotal, iva, total, efectivo, cambio);
            }
            catch (Exception ex)
            {
                throw;
            }
            return IdVenta;
        }

        private int InsertarDetalleVenta(int IdVenta, string DescripcionArticulo, decimal PrecioUnitario, int cantidad, decimal importe) 
        {
            int resultadoInsertarDetalleVenta = 0;
            try
            {
                CN_Ventas objetoInstanciaVentas = new CN_Ventas();
                objetoInstanciaVentas.InsetarDetalleVenta(IdVenta, DescripcionArticulo, PrecioUnitario, cantidad, importe);
            }
            catch (Exception ex)
            {

                throw;
            }
            return resultadoInsertarDetalleVenta;
        }
        #endregion
    }
}
