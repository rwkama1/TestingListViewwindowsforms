using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingListViewJardineriadb.GroupListView
{
    public class GruposListView
    {

        internal static List<string> GrupoPorCodigoProducto()
        {
            List<string> listadellistview = new List<string>();
            var pedidosproductoscount = PPedido.listarPorProductoCount();
            foreach (var item in pedidosproductoscount)
            {
                for (int i = 0; i <= item.CountProducto; i++)
                {
                    var buscaporproducto = PPedido.buscarPorProducto(item.CodigoProducto);
                    foreach (var p in buscaporproducto)
                    {
                        listadellistview.Add(p.CodigoPedido.ToString());
                        listadellistview.Add(p.CodigoProducto.ToString());
                        listadellistview.Add(p.Cantidad.ToString());
                        listadellistview.Add(p.PrecioUnidad.ToString());
                        listadellistview.Add(p.NumeroLinea.ToString());
                    }
                }
                listadellistview.Add("");
                listadellistview.Add("TOTAL");
                listadellistview.Add("");
                listadellistview.Add("");
                listadellistview.Add("");

                //var buscarcodigoproducto = BuscarEnProductosCount(item.CodigoProducto);
                //if (item.CodigoProducto==buscarcodigoproducto.CodigoProducto)
                //{

                //}

            }
            return listadellistview;
        }
        //internal static DTPedido BuscarEnProductosCount(string codigo)
        //{

        //    DTPedido objpedido = null;

        //    var pedidosproductoscount = PPedido.listarPorProductoCount();
        //    foreach (var item in pedidosproductoscount)
        //    {
        //        if(item.CodigoProducto==codigo)
        //        {
        //            objpedido = item;
        //        }
        //    }
        //    return objpedido;
        //}
      
    }
}
