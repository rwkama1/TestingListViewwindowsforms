using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestingListViewJardineriadb
{
    public partial class WFDataGridPedidos : Form
    {
        List<DTProductoEnvase> listaprod { get; set; }
        int ContadorDeNuevasFilasAgregadas { get; set; }
        //public List<DTProductoEnvase> listap
        public WFDataGridPedidos()
        {
            InitializeComponent();
            textBox1.Focus();
            KeyPreview = true;
            dgvProductos.MultiSelect = false;
            CancelButton = btnCancel;
            MostarProductosEngrilla();
        }


        List<DTDetallePedidoEnvase> listaDetallePedidos { get; set; }
        private void WFDataGridPedidos_Load(object sender, EventArgs e)
        {
            ContadorDeNuevasFilasAgregadas = 0;
            dgvProductos.CellEnter += new DataGridViewCellEventHandler(dgvProductos_CellEnter);


        }
        private void MostarProductosEngrilla()
        {
            dgvProductos.Rows.Clear();
            List<DTProductoEnvase> list = CargarProductoEnvaseSistema();
            for (int i = 0; i < list.Count; i++)
            {
                DTProductoEnvase prod = list[i];
                List<string> rowgridview = new List<string>() { prod.Nombre.ToString(), prod.Envase.ToString(), prod.Codigo.ToString() };

                dgvProductos.Rows.Add(rowgridview.ToArray());
            }

        }
        private void AgregarDatos()
        {
            CargarProductosGrilla();
            StringBuilder mensajeproductos = new StringBuilder();
            for (int i = 0; i < listaDetallePedidos.Count; i++)
            {
                DTDetallePedidoEnvase item = listaDetallePedidos[i];
                mensajeproductos.Append(item.Nombre.ToString()).AppendLine();
            }
            MessageBox.Show(mensajeproductos.ToString());
            Limpiar();
        }
        private void CargarProductosGrilla()
        {

            listaDetallePedidos = new List<DTDetallePedidoEnvase>();
            var list = dgvProductos.Rows;
            for (int i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = list[i];

                var producto = Convert.ToString(row.Cells[colproducto.Index].Value);
                var cantidad = Convert.ToInt32(row.Cells[colcant.Index].Value);
                if (row.Cells[colcant.Index].FormattedValue.ToString() != "" && producto != "" && cantidad != 0)
                {

                    // var producto = row.Cells[colproducto.Index].Value.ToString();

                    var envase = row.Cells[colenvase.Index].Value.ToString();
                    var codigo = Convert.ToInt32(row.Cells[colcodigo.Index].Value);
                    var precio = Convert.ToDouble(row.Cells[colprecio.Index].Value);


                    var importe = Convert.ToDouble(row.Cells[colimporte.Index].Value);
                    DTDetallePedidoEnvase dTDetallePedidoEnvase = new DTDetallePedidoEnvase()
                    { Nombre = producto, Envase = envase, Codigo = codigo, Precio = precio, Cantidad = cantidad, Importe = importe };
                    listaDetallePedidos.Add(dTDetallePedidoEnvase);

                    //}
                }
            }

        }
        private List<DTProductoEnvase> CargarProductoEnvaseSistema()
        {
            List<DTProductoEnvase> listaa = new List<DTProductoEnvase>();
            for (int i = 0; i < 50; i++)
            {

                if (i == 0)
                {
                    listaa.Add(new DTProductoEnvase("Producto1", "Envase1", 1));


                }
                else
                {
                    listaa.Add(new DTProductoEnvase($"Producto{i + 1}", $"Envase{i + 1}", i + 1));
                }
            }
            listaprod = listaa;
            return listaa.OrderBy(x => x.Codigo).ToList();
        }

        class DTDetallePedidoEnvase
        {
            public string Nombre { get; set; }
            public string Envase { get; set; }
            public int Codigo { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Importe { get; set; }

            public DTDetallePedidoEnvase()
            {
            }


        }
        class DTProductoEnvase
        {
            public string Nombre { get; set; }
            public string Envase { get; set; }
            public int Codigo { get; set; }


            public DTProductoEnvase()
            {
            }

            public DTProductoEnvase(string nombre, string envase, int codigo)
            {
                Nombre = nombre;
                Envase = envase;
                Codigo = codigo;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDatos();
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var valornombreproducto = Convert.ToString(dgvProductos.CurrentRow.Cells[colproducto.Index].Value);

            if (dgvProductos.CurrentRow.Cells[e.ColumnIndex].ReadOnly)
            {
                SendKeys.Send("{tab}");
            }
            if (dgvProductos.Rows[dgvProductos.Rows.Count - 1].IsNewRow)
            {
                dgvProductos.Rows[dgvProductos.Rows.Count - 1].Cells[colcodigo.Index].ReadOnly = false;
            }

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //if(textBox1.Text=="0")
            //{
            //    MessageBox.Show("No debe ser 0");
            //    e.Cancel = true;
            //}
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox2.Text == "0")
            //{
            //    MessageBox.Show("No debe ser 0");
            //    e.Cancel = true;
            //}
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            //if (textBox3.Text == "0")
            //{
            //    MessageBox.Show("No debe ser 0");
            //    e.Cancel = true;
            //}
        }

        private void WFDataGridPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                AutoValidate = AutoValidate.Disable;
                Close();
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {

        }


        private void MostrarDetallesConProductos()
        {

            dgvProductos.Rows.Clear();
            List<DTDetallePedidoEnvase> list = listaDetallePedidos;
            List<DTProductoEnvase> productos = CargarProductoEnvaseSistema();
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    DTDetallePedidoEnvase prod = list[i];
                    List<string> rowgridview = new List<string>()
                { prod.Nombre.ToString(), prod.Envase.ToString(),
                  prod.Codigo.ToString(),prod.Cantidad.ToString(),
                   prod.Precio.ToString(),prod.Importe.ToString() };

                    dgvProductos.Rows.Add(rowgridview.ToArray());
                }

                for (int i = 0; i < productos.Count; i++)
                {
                    DTProductoEnvase prod = productos[i];
                    if (!dgvProductos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells[colcodigo.Index].Value) == prod.Codigo))
                    {
                        List<string> rowgridview = new List<string>() { prod.Nombre.ToString(), prod.Envase.ToString(), prod.Codigo.ToString() };
                        dgvProductos.Rows.Add(rowgridview.ToArray());
                    }




                }

            }


        }

        private void dgvProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (e.ColumnIndex == colcodigo.Index && dgvProductos.Rows[dgvProductos.Rows.Count - 1].IsNewRow)
            {
             
                var producto = BuscarProducto(Convert.ToInt32(dgvProductos.CurrentRow.Cells[colcodigo.Index].Value));
                if (producto != null)
                {
                    dgvProductos.CurrentRow.Cells[colproducto.Index].Value = producto.Nombre;
                    dgvProductos.CurrentRow.Cells[colenvase.Index].Value = producto.Envase;
                    ContadorDeNuevasFilasAgregadas++;
                }
                else
                {
                    dgvProductos.CurrentRow.Cells[colproducto.Index].Value = null;
                    dgvProductos.CurrentRow.Cells[colenvase.Index].Value = null;
                }
              

            }
            //if (dgvProductos.IsCurrentCellDirty)
            //{
            //    if (e.ColumnIndex == colcant.Index)
            //    {

            //        try
            //        {
            //            if (Convert.ToInt32(e.FormattedValue.ToString()) == 0)
            //            {

            //                MessageBox.Show("El Codigo no puede ser 0");
            //                e.Cancel = true;


            //            }
            //        }
            //        catch
            //        {


            //        }




            //    }

            //}
        }

        private void ModificarDetallePedido()
        {
            CargarProductosGrilla();
            AgregarDatos();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            ModificarDetallePedido();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarDetallesConProductos();

        }
        DTProductoEnvase BuscarProducto(int codigo)
        {
            DTProductoEnvase producto = null;
            List<DTProductoEnvase> list = listaprod;
            for (int i = 0; i < list.Count; i++)
            {
                DTProductoEnvase item = list[i];
                if (item.Codigo == codigo)
                {
                    producto = item;
                }
            }
            return producto;
            // return CargarProductoEnvaseSistema().Single(x => x.Codigo == codigo);
        }

        private void btnCantidaddefilas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CantidadFilasGridView().ToString());
        }
        private int CantidadFilasGridView()
        {
            return dgvProductos.Rows.Count;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }
        void Limpiar()
        {
            dgvProductos.Rows.Clear();
            MostarProductosEngrilla();
            //var list = dgvProductos.Rows;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    DataGridViewRow row = list[i];
              
            //    row.Cells[colprecio.Index].Value = null;
            //    row.Cells[colcant.Index].Value = null;
            //    dgvProductos
            //    //for (int x = 0; x < ContadorDeNuevasFilasAgregadas; x++)
            //    //{
            //        //var cantidaddefilasenos1 = dgvProductos.Rows.Count-2;
            //        //dgvProductos.Rows[cantidaddefilasenos1].Cells[colproducto.Index].Value=null;
            //        //dgvProductos.Rows[cantidaddefilasenos1].Cells[colenvase.Index].Value = null;
            //    //}


            //}
        }
    }
    }


