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
    public partial class WFDataGridPedidos : Form
    {
        public WFDataGridPedidos()
        {
            InitializeComponent();
            textBox1.Focus();
            KeyPreview = true;
            MostarProductosEngrilla();
        }

        public double CalcularImporte { get; set; }
        List<DTDetallePedidoEnvase> listaDetallePedidos { get; set; }
        private void WFDataGridPedidos_Load(object sender, EventArgs e)
        {

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
            foreach (var item in listaDetallePedidos)
            {

                mensajeproductos.Append(item.Nombre.ToString()).AppendLine();
            }
            MessageBox.Show(mensajeproductos.ToString());
        }
        private void CargarProductosGrilla()
        {

            listaDetallePedidos = new List<DTDetallePedidoEnvase>();
            var list = dgvProductos.Rows;
            for (int i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = list[i];
                if (row.Cells[colcant.Index].Value != null)
                {
                    var producto = row.Cells[colproducto.Index].Value.ToString();
                    var envase = row.Cells[colenvase.Index].Value.ToString();
                    var codigo = Convert.ToInt32(row.Cells[colcodigo.Index].Value);
                    var precio = Convert.ToDouble(row.Cells[colprecio.Index].Value);
                    var cantidad = Convert.ToInt32(row.Cells[colcant.Index].Value);
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

            if (dgvProductos.CurrentRow.Cells[e.ColumnIndex].ReadOnly)
            {
                SendKeys.Send("{tab}");
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

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            MostrarDetallesConProductos();
        }
        private void MostrarDetallesConProductos()
        {

            dgvProductos.Rows.Clear();
            List<DTDetallePedidoEnvase> list = listaDetallePedidos;
            List<DTProductoEnvase> productos = CargarProductoEnvaseSistema();

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
                if(!dgvProductos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells[colcodigo.Index].Value)==prod.Codigo))
                {
                    List<string> rowgridview = new List<string>() { prod.Nombre.ToString(), prod.Envase.ToString(), prod.Codigo.ToString() };
                    dgvProductos.Rows.Add(rowgridview.ToArray());
                }
               
               


            }


        }

        private void dgvProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (dgvProductos.IsCurrentCellDirty)
            {
                if (e.ColumnIndex == colcant.Index)
                {

                    try
                    {
                        if (Convert.ToInt32(e.FormattedValue.ToString()) == 0)
                        {
                           
                            MessageBox.Show("El Codigo no puede ser 0");
                            e.Cancel = true;


                        }
                    }
                    catch 
                    {

                        
                    }
                   



                }

            }
        }


    }
}

