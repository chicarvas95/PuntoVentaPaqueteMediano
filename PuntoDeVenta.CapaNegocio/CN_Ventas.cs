using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoDeVenta.CapaAccesoDatos;

namespace PuntoDeVenta.CapaNegocio
{
    public class CN_Ventas
    {
        private CAD_Ventas InstanciaCAD_Ventas = new CAD_Ventas();
        private int resultadoInsertarInformacionVenta = 0;
        public int InsertarDatosVenta(decimal subtotal, decimal iva, decimal total, decimal efectivo, decimal cambio) 
        {
            try
            {
                resultadoInsertarInformacionVenta = InstanciaCAD_Ventas.InsertarDatosVenta(subtotal, iva, total, efectivo, cambio);
                return resultadoInsertarInformacionVenta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int InsetarDetalleVenta(int IdVenta, string DescripcionArticulo, decimal PrecioUnitario, int cantidad, decimal Importe) 
        {
            int resultado = 0;
            try
            {
                resultado = InstanciaCAD_Ventas.InsetarDetalleVenta(IdVenta, DescripcionArticulo, PrecioUnitario, cantidad, Importe);
            }
            catch (Exception ex)
            {

                throw;
            }
            return resultado;
        }
    }
}
