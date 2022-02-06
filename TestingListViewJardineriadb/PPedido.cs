using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingListViewJardineriadb
{
    internal class PPedido
    {
       internal static List<DTPedido> listarDetallePedidos()
        {
            string consulta = "SELECT * FROM detalle_pedido;";
            MySqlConnection cnn = Conexion.conexion();
            MySqlCommand comand = new MySqlCommand(consulta, cnn);
            List<DTPedido> listp = new List<DTPedido>();

            try
            {
                cnn.Open();
                MySqlDataReader _lector = comand.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        int codigopedido = (int)_lector["codigo_pedido"];
                        string codigo_producto = (string)_lector["codigo_producto"];
                        int cantidad = (int)_lector["cantidad"];
                        decimal precio_unidad = (decimal)_lector["precio_unidad"];
                        short numero_linea = (short)_lector["numero_linea"];
                        DTPedido pedido = new DTPedido(codigopedido,cantidad, codigo_producto, precio_unidad,numero_linea);
                        listp.Add(pedido);
                    }

                }
                _lector.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo listar los detalles pedidos "+ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return listp;
        }

        internal static List<DTPedido> listarDetallePedidosOrdenadosProducto()
        {
            string consulta = "SELECT * FROM detalle_pedido order by codigo_producto;";
            MySqlConnection cnn = Conexion.conexion();
            MySqlCommand comand = new MySqlCommand(consulta, cnn);
            List<DTPedido> listp = new List<DTPedido>();

            try
            {
                cnn.Open();
                MySqlDataReader _lector = comand.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        int codigopedido = (int)_lector["codigo_pedido"];
                        string codigo_producto = (string)_lector["codigo_producto"];
                        int cantidad = (int)_lector["cantidad"];
                        decimal precio_unidad = (decimal)_lector["precio_unidad"];
                        short numero_linea = (short)_lector["numero_linea"];
                        DTPedido pedido = new DTPedido(codigopedido, cantidad, codigo_producto, precio_unidad, numero_linea);
                        listp.Add(pedido);
                    }

                }
                _lector.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo listar los detalles pedidos " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return listp;
        }

        internal static List<DTPedido> buscarPorProducto(string codigoproducto)
        {
            string consulta = $"select * from detalle_pedido where codigo_producto='{codigoproducto}'";
            MySqlConnection cnn = Conexion.conexion();
            MySqlCommand comand = new MySqlCommand(consulta, cnn);
            List<DTPedido> listp = new List<DTPedido>();

            try
            {
                cnn.Open();
                MySqlDataReader _lector = comand.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        int codigopedido = (int)_lector["codigo_pedido"];
                        string codigo_producto = (string)_lector["codigo_producto"];
                        int cantidad = (int)_lector["cantidad"];
                        decimal precio_unidad = (decimal)_lector["precio_unidad"];
                        short numero_linea = (short)_lector["numero_linea"];
                        DTPedido pedido = new DTPedido(codigopedido, cantidad, codigo_producto, precio_unidad, numero_linea);
                        listp.Add(pedido);
                    }

                }
                _lector.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo listar los detalles pedidos " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return listp;
        }

        internal static List<DTPedido> listarPorProductoCount()
        {
            string consulta = "SELECT codigo_producto ,count(*) as cantidad FROM detalle_pedido group by codigo_producto order by codigo_producto";
            MySqlConnection cnn = Conexion.conexion();
            MySqlCommand comand = new MySqlCommand(consulta, cnn);
            List<DTPedido> listp = new List<DTPedido>();

            try
            {
                cnn.Open();
                MySqlDataReader _lector = comand.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        string codigoproducto = (string)_lector["codigo_producto"];
                      
                        int cantidad = Convert.ToInt32(_lector["cantidad"]);
                        
                        DTPedido pedido = new DTPedido();
                        pedido.CodigoProducto = codigoproducto;
                        pedido.CountProducto = cantidad;
                        listp.Add(pedido);
                    }

                }
                _lector.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo listar los detalles pedidos " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return listp;
        }
    }
  
}
   

