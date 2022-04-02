using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingListViewJardineriadb.GroupListView
{
    public class GruposListView
    {

        internal static void GrupoPorCodigoProducto(ListView lst,ColumnHeader colpedido,ColumnHeader colproducto, ColumnHeader colcantidad, ColumnHeader colnumerolinea,ColumnHeader colprice )
        {
            var pedidosproductoscount = PPedido.listarPorProductoCount();
            lst.ShowItemToolTips = true;
         
            foreach (var item in pedidosproductoscount)
            {

                List<DTPedido> buscaporproducto = null;
              
                buscaporproducto = PPedido.buscarPorProducto(item.CodigoProducto);
                    foreach (var p in buscaporproducto)
                    {
                    var listViewItem = new ListViewItem();
                   

                   listViewItem.SubItems.Add(p.CodigoPedido.ToString());
                   
                    listViewItem.SubItems.Add(p.CodigoProducto.ToString());
                  
                    listViewItem.SubItems.Add(p.Cantidad.ToString());
                  
                    listViewItem.SubItems.Add(p.PrecioUnidad.ToString());
                   
                    listViewItem.SubItems.Add(p.NumeroLinea.ToString());

                    //listViewItem.ToolTipText = "asd";
                    lst.Items.Add(listViewItem);
                    


                }
               
                //Font fontstyle2 = new Font(lst.Font, FontStyle.Bold);
                //var listViewItemtotal = new ListViewItem("");
                ////listViewItemtotal.UseItemStyleForSubItems = false;
                //listViewItemtotal.SubItems.Add("");
                //listViewItemtotal.SubItems.Add("");
                //listViewItemtotal.SubItems.Add("");
                //listViewItemtotal.SubItems.Add(CalcularTotalLista(buscaporproducto).ToString());
                //listViewItemtotal.SubItems.Add("");
                //buscaporproducto = null;
                //listViewItemtotal.SubItems[colpedido.Index].Font = fontstyle2;
                //listViewItemtotal.SubItems[colproducto.Index].Font = fontstyle2;
                //listViewItemtotal.SubItems[colcantidad.Index].Font = fontstyle2;
                //listViewItemtotal.SubItems[colnumerolinea.Index].Font = fontstyle2;
                //listViewItemtotal.SubItems[colprice.Index].Font = fontstyle2;
                //lst.Items.Add(listViewItemtotal);

                //var buscarcodigoproducto = BuscarEnProductosCount(item.CodigoProducto);
                //if (item.CodigoProducto==buscarcodigoproducto.CodigoProducto)
                //{

                //}

            }
           
           
        }
        internal static decimal CalcularTotalLista(List<DTPedido> lista)
        {
            return lista.Sum(x => x.PrecioUnidad);
            
        }


    }
}
