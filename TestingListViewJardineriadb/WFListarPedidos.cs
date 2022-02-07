using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingListViewJardineriadb
{
    public partial class WFListarPedidos : Form
    {
        public WFListarPedidos()
        {
            InitializeComponent();
        }

        private void WFListarPedidos_Load(object sender, EventArgs e)
        {
            limpiar();
            //lstPedidos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //lstPedidos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            btnListar.Focus();
            lstPedidos.MultiSelect = false;
           
            
          
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            limpiar();
            GroupListView.GruposListView.GrupoPorCodigoProducto(lstPedidos,codigopedido,
                codigoproducto,cantidad,numerolinea,preciounidad);   
        }
        private void AgregarLinea(DTPedido dtp)
        {
        

            var listViewItem = new ListViewItem(dtp.CodigoPedido.ToString());
           
     
            listViewItem.SubItems.Add(dtp.CodigoProducto.ToString());
            listViewItem.SubItems.Add(dtp.Cantidad.ToString());
            listViewItem.SubItems.Add(dtp.PrecioUnidad.ToString());
            listViewItem.SubItems.Add(dtp.NumeroLinea.ToString());

         
            lstPedidos.Items.Add(listViewItem);
        }
       

        private void lstPedidos_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            if (e.Column == codigoproducto.Index)
            {

                limpiar();

                listarDetallePedidosOrderProducto();
            }

        }
        private void listarDetallePedidos()
        {
            //List<DTPedido> listpedido = PPedido.listarDetallePedidos();
            //foreach (DTPedido dTPedido in listpedido)
            //{
            //    AgregarLinea(dTPedido);
            //}
            //List<DTPedido> listpedido = PPedido.buscarPorProducto("11679");
            //foreach (DTPedido dTPedido in listpedido)
            //{
            //    AgregarLinea(dTPedido);
            //}
           /// GroupListView.GruposListView.GrupoPorCodigoProducto();

        }
        private void listarDetallePedidosOrderProducto()
        {
       
            decimal totalpreciounidad = 0;
            decimal totaltotales = 0;
            List<DTPedido> listpedido = PPedido.listarDetallePedidosOrdenadosProducto();
            
            for (int i = 1; i <= listpedido.Count-1; i++)
            {
                AgregarLinea(listpedido[i-1]);
                if (totalpreciounidad == 0)
                {
                    totalpreciounidad = listpedido[i - 1].PrecioUnidad;
                }
                if (listpedido[i] == listpedido[listpedido.Count - 1])
                {
                    AgregarLinea(listpedido[i]);
                   
                    if (listpedido[i].CodigoProducto == listpedido[i - 1].CodigoProducto)
                    {
                        totalpreciounidad = totalpreciounidad + listpedido[i].PrecioUnidad;
                        totaltotales = totaltotales + totalpreciounidad;

                    }
                
                        var listViewItem = new ListViewItem("");
                        listViewItem.UseItemStyleForSubItems = false;
                        Font fontstyle = new Font(Font, FontStyle.Bold);
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");

                        listViewItem.SubItems[codigopedido.Index].Font = fontstyle;
                        listViewItem.SubItems[codigoproducto.Index].Font = fontstyle;
                        listViewItem.SubItems[cantidad.Index].Font = fontstyle;
                        listViewItem.SubItems[numerolinea.Index].Font = fontstyle;
                        listViewItem.SubItems[preciounidad.Index].Font = fontstyle;
                    totaltotales = totaltotales + totalpreciounidad;

                    listViewItem.SubItems[preciounidad.Index].Text = totalpreciounidad.ToString();


                        lstPedidos.Items.Add(listViewItem);
                        totalpreciounidad = 0;
                    

                }
                else {
                 
                    if (listpedido[i].CodigoProducto == listpedido[i-1].CodigoProducto)
                    {
                        totalpreciounidad = totalpreciounidad + listpedido[i].PrecioUnidad;
                      
                    }
                    else
                    {

                        var listViewItem = new ListViewItem("");
                        listViewItem.UseItemStyleForSubItems = false;
                        Font fontstyle = new Font(Font, FontStyle.Bold);
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");
                        listViewItem.SubItems.Add("");

                        listViewItem.SubItems[codigopedido.Index].Font = fontstyle;
                        listViewItem.SubItems[codigoproducto.Index].Font = fontstyle;
                        listViewItem.SubItems[cantidad.Index].Font = fontstyle;
                        listViewItem.SubItems[numerolinea.Index].Font = fontstyle;
                        listViewItem.SubItems[preciounidad.Index].Font = fontstyle;
                        totaltotales = totaltotales + totalpreciounidad;
                        listViewItem.SubItems[preciounidad.Index].Text = totalpreciounidad.ToString();


                        lstPedidos.Items.Add(listViewItem);
                        totalpreciounidad = 0;
                    }
                }
            }
            var listViewItem2 = new ListViewItem("");
            listViewItem2.UseItemStyleForSubItems = false;
            Font fontstyle2 = new Font(Font, FontStyle.Bold);
            listViewItem2.SubItems.Add("");
            listViewItem2.SubItems.Add("");
            listViewItem2.SubItems.Add("");
            listViewItem2.SubItems.Add("");
            listViewItem2.SubItems.Add("");

            listViewItem2.SubItems[codigopedido.Index].Font = fontstyle2;
            listViewItem2.SubItems[codigoproducto.Index].Font = fontstyle2;
            listViewItem2.SubItems[cantidad.Index].Font = fontstyle2;
            listViewItem2.SubItems[numerolinea.Index].Font = fontstyle2;
            listViewItem2.SubItems[preciounidad.Index].Font = fontstyle2;
            listViewItem2.SubItems[preciounidad.Index].Text = totaltotales.ToString();


            lstPedidos.Items.Add(listViewItem2);
            
        }
      
        private void limpiar()
        {
            lstPedidos.Items.Clear();


        }

        private void seleccionarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstPedidos.SelectedItems.Count > 0)
            {
                var valor = lstPedidos.SelectedItems[0];
                //MessageBox.Show(valor);
            }

        }



        private void lstPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            //if (lstPedidos.SelectedItems.Count > 0)
            //{

            //    lstPedidos.SelectedItems[0].BackColor = System.Drawing.Color.Blue;
            //}
            //foreach (ListViewItem item in lstPedidos.Items)
            //    item.BackColor = Color.LightSteelBlue;

        }

        private void lstPedidos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //if (e.IsSelected)
            //{
            //    e.Item.BackColor = SystemColors.Highlight;
            //    e.Item.ForeColor = SystemColors.HighlightText;
            //}
            //else
            //{
            //    e.Item.BackColor = BackColor;
            //    e.Item.ForeColor = ForeColor;
            //}
        }

        private void WFListarPedidos_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lstPedidos_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var scodigoproducto = lstPedidos.SelectedItems[0].SubItems[codigoproducto.Index].Text;
                if (scodigoproducto != "11679")
                {
                    cntMenu.Items[0].Visible = false;
                   
                }
                else 
                {
                    cntMenu.Items[0].Visible = true;
                }
               

            }
        }
    }
}
