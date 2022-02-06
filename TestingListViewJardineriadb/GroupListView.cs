using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingListViewJardineriadb.GroupListView
{
    public class GruposListView
    {

        internal static void GrupoPorCodigoProducto(ListView lst)
        {
            var pedidosproductoscount = PPedido.listarPorProductoCount();
            foreach (var item in pedidosproductoscount)
            {
                    var buscaporproducto = PPedido.buscarPorProducto(item.CodigoProducto);
                    foreach (var p in buscaporproducto)
                    {
                    var listViewItem = new ListViewItem("");
                    listViewItem.SubItems.Add(p.CodigoPedido.ToString());
                    listViewItem.SubItems.Add(p.CodigoProducto.ToString());
                    listViewItem.SubItems.Add(p.Cantidad.ToString());
                    listViewItem.SubItems.Add(p.PrecioUnidad.ToString());
                    listViewItem.SubItems.Add(p.NumeroLinea.ToString());
                    lst.Items.Add(listViewItem);
                }
                var listViewItemtotal = new ListViewItem("");
                listViewItemtotal.SubItems.Add("");
                listViewItemtotal.SubItems.Add("TOTAL");
                listViewItemtotal.SubItems.Add("");
                listViewItemtotal.SubItems.Add("");
                listViewItemtotal.SubItems.Add("");
                lst.Items.Add(listViewItemtotal);

                //var buscarcodigoproducto = BuscarEnProductosCount(item.CodigoProducto);
                //if (item.CodigoProducto==buscarcodigoproducto.CodigoProducto)
                //{

                //}

            }
           
        }
     
    }
}
