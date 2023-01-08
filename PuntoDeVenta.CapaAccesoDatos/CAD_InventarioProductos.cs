using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.CapaAccesoDatos
{
    public class CAD_InventarioProductos
    {
        private CAD_Conexion Conexion = new CAD_Conexion();
        private int resultado = 0;
        
        SqlDataReader Leer;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        public DataTable BuscarProductoEnInventario(string paramCodigoProducto) 
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SpSelProductoByCodigoProducto";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@CodigoProducto", paramCodigoProducto);
                Leer = Comando.ExecuteReader();
                Tabla.Load(Leer);
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int InsertarInformacionProducto(string NombreProducto, decimal PrecioProducto, int CantidadInventario, string CodigoProducto) 
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SpInsertarNuevoProducto";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@ParamNombreProducto", NombreProducto);
                Comando.Parameters.AddWithValue("@ParamPrecioProducto", PrecioProducto);
                Comando.Parameters.AddWithValue("@ParamCantidadInventario", CantidadInventario);
                Comando.Parameters.AddWithValue("@ParamCodigoProducto", CodigoProducto);
                SqlParameter outparam = Comando.Parameters.Add("@Resultado",SqlDbType.Int);
                outparam.Direction = ParameterDirection.Output;
                Comando.ExecuteNonQuery();
                resultado = Convert.ToInt16(Comando.Parameters["@Resultado"].Value);
                return resultado;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public DataTable SeleccionarInformacionProductosRegistrados() 
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SpSelProductosRegistrados";
                Comando.CommandType = CommandType.StoredProcedure;
                Leer = Comando.ExecuteReader();
                Tabla.Load(Leer);
                Conexion.CerrarConexion();
                return Tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int ActualizarInformacionProducto(string NombreProducto,decimal PrecioProducto,int CantidadInventario,string CodigoProducto) 
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SpUpdInformacionProducto";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@ParamNombreProducto", NombreProducto);
                Comando.Parameters.AddWithValue("@ParamPrecioProducto", PrecioProducto);
                Comando.Parameters.AddWithValue("@ParamCantidadInventario", CantidadInventario);
                Comando.Parameters.AddWithValue("@ParamCodigoProducto", CodigoProducto);
                if (Comando.ExecuteNonQuery() == 1)
                {
                    resultado = 1;
                }
                else
                {
                    resultado = 0;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return resultado;
        }

        public int EliminarInformacionProducto(string CodigoProducto) 
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "SpEliminarProducto";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
                if (Comando.ExecuteNonQuery() == 1)
                {
                    resultado = 1;
                }
                else
                {
                    resultado = 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return resultado;
        }
    }
}
