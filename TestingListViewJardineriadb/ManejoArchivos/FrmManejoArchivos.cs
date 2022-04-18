using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingListViewJardineriadb.ManejoArchivos
{
    public partial class FrmManejoArchivos : Form
    {
        public FrmManejoArchivos()
        {
            InitializeComponent();
        }

      

        private void btnCopiarArchivo_Click(object sender, EventArgs e)
        {
            string rutainicial = @"C:\Users\Waldemar\Desktop\ADOC#.txt";
            string rutafinal = @"C:\Users\Waldemar\Desktop\Cosas Programacion\base de datos\ADOC#.txt";
            string rutadirectorio = @"C:\Users\Waldemar\Desktop\Cosas Programacion\base de datos";
            if(!Directory.Exists(rutadirectorio))
            {
                Directory.CreateDirectory(rutadirectorio);
            }
            if(File.Exists(rutainicial))
            {
                File.Copy(rutainicial, rutafinal, true);
            }
        }
    }
}
