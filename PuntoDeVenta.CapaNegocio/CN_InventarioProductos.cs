using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoDeVenta.CapaAccesoDatos;

namespace PuntoDeVenta.CapaNegocio
{
    public class CN_InventarioProductos
    {
        private CAD_InventarioProductos InstanciaCAD_InventarioProductos = new CAD_InventarioProductos();
        private int respuestaCapaAccesoDatos = 0;
        private DataTable ProductosRegistrados;

        public DataTable BuscarProductoEnInventario(string paramCodigoProducto) 
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = InstanciaCAD_InventarioProductos.BuscarProductoEnInventario(paramCodigoProducto);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int InsertarDatosProductos(string NombreProducto, decimal PrecioProducto, int CantidadInventario, string CodigoProducto) 
        {
            try
            {
                respuestaCapaAccesoDatos = InstanciaCAD_InventarioProductos.InsertarInformacionProducto(NombreProducto, PrecioProducto, CantidadInventario, CodigoProducto);
                return respuestaCapaAccesoDatos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DataTable MostrarProductosRegistrados() 
        {
            try
            {
                ProductosRegistrados = InstanciaCAD_InventarioProductos.SeleccionarInformacionProductosRegistrados();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ProductosRegistrados;
        }
        public int ActualizarInformacionProducto(string NombreProducto,decimal PrecioProducto,int CantidadInventario, string CodigoProducto) 
        {
            try
            {
                respuestaCapaAccesoDatos = InstanciaCAD_InventarioProductos.ActualizarInformacionProducto( NombreProducto,PrecioProducto,CantidadInventario, CodigoProducto);
            }
            catch (Exception ex)
            {
                
            }
            return respuestaCapaAccesoDatos;
        }

        public int EliminarProducto(string CodigoProducto) 
        {
            try
            {
                respuestaCapaAccesoDatos = InstanciaCAD_InventarioProductos.EliminarInformacionProducto(CodigoProducto);
            }
            catch (Exception ex)
            {

                throw;
            }
            return respuestaCapaAccesoDatos;
        }
    }
}
