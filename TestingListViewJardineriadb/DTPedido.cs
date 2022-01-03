using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingListViewJardineriadb
{
    class DTPedido
    {
    
        public int CodigoPedido { get; set; }
        public int Cantidad { get; set; }
        public string CodigoProducto{ get; set; }

         public decimal PrecioUnidad { get; set;}
        public short NumeroLinea { get; set; }
        public DTPedido(int codigoPedido, int cantidad, string codigoProducto, decimal precioUnidad, short numeroLinea)
        {
            CodigoPedido = codigoPedido;
            Cantidad = cantidad;
            CodigoProducto = codigoProducto;
            PrecioUnidad = precioUnidad;
            NumeroLinea = numeroLinea;
        }


    }
}
