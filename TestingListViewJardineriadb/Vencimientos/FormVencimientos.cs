using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingListViewJardineriadb.Vencimientos
{
    public partial class FormVencimientos : Form
    {
        public  int[] Porcentajes { get; set; }
        public FormVencimientos()
        {
            InitializeComponent();
        }

        private void btnVenc_Click(object sender, EventArgs e)
        {
            FormSuma10TextBox frmsuma10textbox = new FormSuma10TextBox();
            frmsuma10textbox.ShowDialog();
            Porcentajes = frmsuma10textbox.Porcentajes;
        }

        private void FormVencimientos_Load(object sender, EventArgs e)
        {

        }
    }
}
