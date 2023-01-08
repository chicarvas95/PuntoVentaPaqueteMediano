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
using PuntoDeVenta.CapaNegocio;

namespace CursoPuntoDeVentasTresCapas
{
    public partial class FrmAgregarProducto : Form
    {
        private string NombreProducto, CodigoProducto = "";
        private int CantidadInventario,respuestaInsercionProducto = 0;
        private int respuestaActualizacionInformacionProductos = 0;
        private int respuestaEliminacionProducto = 0;
        private decimal PrecioProducto = 0;
        private DataTable ProductosRegistrados;
        private string FechaRegistro = "";
        private string[] row1 = new string[2500];

        public FrmAgregarProducto()
        {
            InitializeComponent();
        }
        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            llenarGridViewProductosRegistrados();
        }

        private void txt_NombreProducto_TextChanged(object sender, EventArgs e)
        {
        }
        #region eventos cajas de texto
        private void txt_CodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_NombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
        private void txt_PrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txt_CantidadInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region eventos de los botones
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_GuardarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                NombreProducto     = txt_NombreProducto.Text;
                PrecioProducto     = Convert.ToDecimal(txt_PrecioUnitario.Text);
                CantidadInventario = Convert.ToInt32(txt_CantidadInventario.Text);
                CodigoProducto     = txt_CodigoProducto.Text;
                respuestaInsercionProducto = InsertarInformacionProducto(NombreProducto, PrecioProducto, CantidadInventario, CodigoProducto); 
                if (respuestaInsercionProducto == 1)
                {
                    MessageBox.Show("Ya existe información de este producto registrado en la base de datos,no se puede registrar este producto.", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarCajasTexto();
                    return;
                }
                else if(respuestaInsercionProducto == 2)
                {
                    MessageBox.Show("Ha excedido la cantidad de registros en la base de datos, favor de comunicarse con la empresa para contratar un paquete con mas capacidad de almacenamiento", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarCajasTexto();
                    return;
                }
                else if (respuestaInsercionProducto == 3)
                {
                    MessageBox.Show("Registro insertado correctamente", "Registro insertado en tu inventario",MessageBoxButtons.OK);
                    LimpiarCajasTexto();
                    return;
                }
                LimpiarCajasTexto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region metodosAuxiliares
        void LimpiarCajasTexto() 
        {
            txt_CodigoProducto.Clear();
            txt_NombreProducto.Clear();
            txt_PrecioUnitario.Clear();
            txt_CantidadInventario.Clear();
            txt_CodigoProducto.Enabled = true;
            txt_CodigoProducto.Focus();
        }
        void HabilitarDeshabilitarComponentes() 
        {
            txt_CodigoProducto.Enabled = false;
            btn_actualizar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_GuardarProductos.Enabled = false;
        }
        void DeshabilitarHabilitarComponentes() 
        {
            txt_CodigoProducto.Enabled = true;
            btn_actualizar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_GuardarProductos.Enabled = true;
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_NombreProducto.Text = dataGridView1.CurrentRow.Cells["ColumNombreProducto"].Value.ToString();
                txt_PrecioUnitario.Text = dataGridView1.CurrentRow.Cells["ColumPrecioProducto"].Value.ToString();
                txt_CantidadInventario.Text = dataGridView1.CurrentRow.Cells["ColumnCantidadInventario"].Value.ToString();
                txt_CodigoProducto.Text = dataGridView1.CurrentRow.Cells["ColumnCodigoProducto"].Value.ToString();
                HabilitarDeshabilitarComponentes();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void llenarGridViewProductosRegistrados() 
        {
            ProductosRegistrados = MostrarInformacionProductosRegistrados();
            foreach (DataRow row in ProductosRegistrados.Rows)
            {
                NombreProducto     = row["NombreProducto"].ToString();
                PrecioProducto     = Convert.ToDecimal(row["PrecioProducto"].ToString());
                CantidadInventario = int.Parse(row["CantidadInventario"].ToString());
                CodigoProducto     = row["CodigoProducto"].ToString();
                FechaRegistro      = row["FechaRegistro"].ToString();
                row1               = new string[] { NombreProducto.ToString(), PrecioProducto.ToString(), CantidadInventario.ToString(), CodigoProducto.ToString(), FechaRegistro.ToString() };
                dataGridView1.Rows.Add(row1);
            }
        }
        #endregion

        #region Instancias Metodos CapaNegocio
        private int InsertarInformacionProducto(string NombreProducto,decimal PrecioProducto,int CantidadInventario,string CodigoProducto) 
        {
            try
            {
                int respuestaCapaNegocio = 0;
                CN_InventarioProductos objetoInstaciaCapaNegocio = new CN_InventarioProductos();
                respuestaCapaNegocio = objetoInstaciaCapaNegocio.InsertarDatosProductos(NombreProducto,PrecioProducto,CantidadInventario,CodigoProducto);
                return respuestaCapaNegocio;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                respuestaActualizacionInformacionProductos = ActualizarInformacionProducto(txt_NombreProducto.Text, Convert.ToDecimal(txt_PrecioUnitario.Text), int.Parse(txt_CantidadInventario.Text), txt_CodigoProducto.Text);
                if (respuestaActualizacionInformacionProductos == 1)
                {
                    MessageBox.Show("El producto se actualizo correctamente","Información");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar actualizar la informacion del producto", "Error");
                }
                LimpiarCajasTexto();
                if (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.Clear();
                    llenarGridViewProductosRegistrados();
                }
                DeshabilitarHabilitarComponentes();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                respuestaEliminacionProducto = EliminarProducto(txt_CodigoProducto.Text);
                if (respuestaEliminacionProducto == 1)
                {
                    MessageBox.Show("El producto eliminado correctamente", "Información");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar la informacion del producto", "Error");
                }
                LimpiarCajasTexto();
                if (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.Clear();
                    llenarGridViewProductosRegistrados();
                }
                DeshabilitarHabilitarComponentes();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable MostrarInformacionProductosRegistrados() 
        {
            try
            {
                CN_InventarioProductos objetoInstanciaCapaNegocio = new CN_InventarioProductos();
                ProductosRegistrados = objetoInstanciaCapaNegocio.MostrarProductosRegistrados();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ProductosRegistrados;
        }
        private int ActualizarInformacionProducto(string NombreProducto, decimal PrecioProducto, int CantidadInventario, string CodigoProducto) 
        {
            try
            {
                int respuestaCapaNegocio = 0;
                CN_InventarioProductos objetoInstaciaCapaNegocio = new CN_InventarioProductos();
                respuestaCapaNegocio = objetoInstaciaCapaNegocio.ActualizarInformacionProducto(NombreProducto, PrecioProducto, CantidadInventario,CodigoProducto);
                return respuestaCapaNegocio;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private int EliminarProducto(string CodigoProducto) 
        {
            try
            {
                int respuestaCapaNegocio = 0;
                CN_InventarioProductos objetoInstaciaCapaNegocio = new CN_InventarioProductos();
                respuestaCapaNegocio = objetoInstaciaCapaNegocio.EliminarProducto(CodigoProducto);
                return respuestaCapaNegocio;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        #endregion
    }
}
