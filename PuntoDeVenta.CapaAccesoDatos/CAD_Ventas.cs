using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.CapaAccesoDatos
{
    public class CAD_Ventas
    {
        private CAD_Conexion Conexion = new CAD_Conexion();
        private int resultado = 0;
        SqlCommand Comando = new SqlCommand();


        public int InsertarDatosVenta(decimal subtotal, decimal iva, decimal total, decimal efectivo, decimal cambio)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SpInsDatosVenta";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Subtotal", subtotal);
                Comando.Parameters.AddWithValue("@Iva", iva);
                Comando.Parameters.AddWithValue("@Total", total);
                Comando.Parameters.AddWithValue("@Efectivo", efectivo);
                Comando.Parameters.AddWithValue("@Cambio", cambio);
                SqlParameter outparam = Comando.Parameters.Add("@IdVenta", SqlDbType.Int);
                outparam.Direction = ParameterDirection.Output;
                Comando.ExecuteNonQuery();
                resultado = Convert.ToInt16(Comando.Parameters["@IdVenta"].Value);
                return resultado;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int InsetarDetalleVenta(int IdVenta, string DescripcionArticulo, decimal PrecioUnitario, int cantidad, decimal importe) 
        {
            int resultado = 0;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SpInsDetalleVenta";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@IdVenta", IdVenta);
                Comando.Parameters.AddWithValue("@DescripcionArticulo", DescripcionArticulo);
                Comando.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
                Comando.Parameters.AddWithValue("@Cantidad", cantidad);
                Comando.Parameters.AddWithValue("@Importe", importe);
                if (Comando.ExecuteNonQuery() == 1)
                {
                    resultado = 1;
                }
                else
                {
                    resultado = 0;
                }
                return resultado;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
