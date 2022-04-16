using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingListViewJardineriadb.Vencimientos;

namespace TestingListViewJardineriadb
{
    public partial class FormSuma10TextBox : Form
    {
        #region Propiedades
        private int[] ValoresTextBoxaEnteros
        {
            get
            {
                int enterotextbox1 = Convert.ToInt32(textBox1.Text);
                int enterotextbox2 = Convert.ToInt32(textBox2.Text);
                int enterotextbox3 = Convert.ToInt32(textBox3.Text);
                int enterotextbox4 = Convert.ToInt32(textBox4.Text);
                int enterotextbox5 = Convert.ToInt32(textBox5.Text);
                int enterotextbox6 = Convert.ToInt32(textBox6.Text);
                int enterotextbox7 = Convert.ToInt32(textBox7.Text);
                int enterotextbox8 = Convert.ToInt32(textBox8.Text);
                int enterotextbox9 = Convert.ToInt32(textBox9.Text);
                int enterotextbox10 = Convert.ToInt32(textBox10.Text);
                int[] arrayenterostextbox = new int[] {enterotextbox1,enterotextbox2,enterotextbox3,
            enterotextbox4,enterotextbox5,enterotextbox6,enterotextbox7,enterotextbox8,enterotextbox9,enterotextbox10};

                return arrayenterostextbox;
            }

        }
        private bool SumaDa100
        {
            get
            {
                bool sumada100 = false;


                int suma = SumaTodoslosTextBox;
                if (suma == 100)
                {
                    sumada100 = true;
                }
                return sumada100;
            }
        }

        private int SumaTodoslosTextBox
        {
            get
            {
                int[] enterostextbox = ValoresTextBoxaEnteros;
                int suma = enterostextbox.Sum(enteros => enteros);

                return suma;
            }
        }

        private decimal ImporteTotal
        {
            get
            {
                return 2000;
            }

        }

        public TextBox[] obtenerTextBoxes
        {
            get
            {
                return new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
            }
        }

        public Label[] obtenerLabelsimporte
        {
            get
            {
                return new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            }
        }
        public DateTimePicker[] obtenerDateTimePicker
        {
            get
            {
                return new DateTimePicker[] { dateTimePicker1, dateTimePicker2, dateTimePicker3, dateTimePicker4, dateTimePicker5, dateTimePicker6, dateTimePicker7, dateTimePicker8, dateTimePicker9, dateTimePicker10 };
            }
        }

        public int[] Porcentajes { get; set; }
        public DateTime?[] Fechas { get; set; }

        #endregion

        public FormSuma10TextBox()
        {
            InitializeComponent();
        }

        private void FormSuma10TextBox_Load(object sender, EventArgs e)
        {
            Porcentajes = new int[10];
            CargarEventoTextBox();
            CargarEventosValidtaing();
            ManejoDateTextBox.TextBoxMinimo0Mayor100(obtenerTextBoxes);
            ManejoDateTextBox.SetearTextBoxVacios(obtenerTextBoxes);
            ManejoDateTextBox.DesabilitarTextBox(obtenerTextBoxes);
            ManejoDateTextBox.DesactivarFechas(obtenerDateTimePicker);
            ManejoDateTextBox.LabelsImporteInvisible(obtenerLabelsimporte);
            ManejoDateTextBox.DefinirTextMaxLength2(obtenerTextBoxes);
        }

        private void CargarEventoTextBox()
        {
            textBox1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox4.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox5.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox6.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox7.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox8.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox9.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textBox10.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txtingvenc.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
           






        }

        #region Acciones
      
        private void SetearImportePorcentaje(Label lbl,TextBox textBox)
        {
            if(Convert.ToInt32(textBox.Text)!=0)
            {
                lbl.Visible = true;
                lbl.Text = "Importe: " + ImporteSegunPorcentaje(Convert.ToInt32(textBox.Text)).ToString();
            }
         
           
        }
        #endregion

        #region Validating

        private void textbox1Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label1, textBox1);
        }
        private void textbox2Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label2, textBox2);

        }
        private void textbox3Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label3, textBox3);

        }
        private void textbox4Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label4, textBox4);

        }
        private void textbox5Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label5, textBox5);

        }
        private void textbox6Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label6, textBox6);

        }
        private void textbox7Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label7, textBox7);

        }
        private void textbox8Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label8, textBox8);

        }
        private void textbox9Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label9, textBox9);

        }
        private void textbox10Validating(object sender, CancelEventArgs e)
        {

            SetearImportePorcentaje(label10, textBox10);

        }


        #endregion

        #region Calculos
        private decimal ImporteSegunPorcentaje(int porcentaje)
        {
            return (ImporteTotal * porcentaje) / 100;
        }

        #endregion

        #region Comentarios

        //private bool SumaT1T2
        //{
        //     get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0] + enterostextbox[1];
        //        if (suma==100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        //private bool SumaT1T2T3
        //{
        //    get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0] + enterostextbox[1]+enterostextbox[2];
        //        if (suma == 100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        //private bool SumaT1T2T3T4
        //{
        //    get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0] + enterostextbox[1] + enterostextbox[2]+enterostextbox[3];
        //        if (suma == 100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        //private bool SumaT1T2T3T4T5
        //{
        //    get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0] + enterostextbox[1] + enterostextbox[2] + enterostextbox[3]+ enterostextbox[4];
        //        if (suma == 100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        //private bool SumaT1T2T3T4T5T6
        //{
        //    get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0] + enterostextbox[1] + enterostextbox[2] + enterostextbox[3] + enterostextbox[4]+enterostextbox[5];
        //        if (suma == 100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        //private bool SumaT1T2T3T4T5T6T7
        //{
        //    get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0] 
        //            + enterostextbox[1]
        //            + enterostextbox[2] + 
        //            enterostextbox[3] +
        //            enterostextbox[4] +
        //            enterostextbox[5]+
        //            enterostextbox[6];
        //        if (suma == 100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        //private bool SumaT1T2T3T4T5T6T7T8
        //{
        //    get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0]
        //             + enterostextbox[1]
        //             + enterostextbox[2] +
        //             enterostextbox[3] +
        //             enterostextbox[4] +
        //             enterostextbox[5] +
        //              enterostextbox[6] +
        //             enterostextbox[7];
        //        if (suma == 100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        //private bool SumaT1T2T3T4T5T6T7T8T9
        //{
        //    get
        //    {
        //        bool sumada100 = false;

        //        int[] enterostextbox = ValoresTextBoxaEnteros;
        //        int suma = enterostextbox[0]
        //              + enterostextbox[1]
        //              + enterostextbox[2] +
        //              enterostextbox[3] +
        //              enterostextbox[4] +
        //              enterostextbox[5] +
        //               enterostextbox[6] +
        //              enterostextbox[7]+
        //              enterostextbox[8];
        //        if (suma == 100)
        //        {
        //            sumada100 = true;
        //        }
        //        return sumada100;
        //    }
        //}
        #endregion

        private void txtingvenc_Validating(object sender, CancelEventArgs e)
        {
            ManejoDateTextBox.HabilitarTextDate_Segun_CantVenc(obtenerTextBoxes,obtenerDateTimePicker,txtingvenc);
          //if(txtingvenc.text)
        }
    


        private void AgregarDatos()
        {
            if (SumaDa100)
            {
                int enterocantvenc = Convert.ToInt32(txtingvenc.Text);
                switch (enterocantvenc)
                {
                    case 1:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);

                        break;
                    case 2:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        break;
                    case 3:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);


                        break;
                    case 4:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);
                        Porcentajes[3] = Convert.ToInt32(textBox4.Text);
                        break;
                    case 5:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);
                        Porcentajes[3] = Convert.ToInt32(textBox4.Text);
                        Porcentajes[4] = Convert.ToInt32(textBox5.Text);
                        break;
                    case 6:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);
                        Porcentajes[3] = Convert.ToInt32(textBox4.Text);
                        Porcentajes[4] = Convert.ToInt32(textBox5.Text);
                        Porcentajes[5] = Convert.ToInt32(textBox6.Text);
                        break;
                    case 7:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);
                        Porcentajes[3] = Convert.ToInt32(textBox4.Text);
                        Porcentajes[4] = Convert.ToInt32(textBox5.Text);
                        Porcentajes[5] = Convert.ToInt32(textBox6.Text);
                        Porcentajes[6] = Convert.ToInt32(textBox7.Text);

                        break;
                    case 8:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);
                        Porcentajes[3] = Convert.ToInt32(textBox4.Text);
                        Porcentajes[4] = Convert.ToInt32(textBox5.Text);
                        Porcentajes[5] = Convert.ToInt32(textBox6.Text);
                        Porcentajes[6] = Convert.ToInt32(textBox7.Text);
                        Porcentajes[7] = Convert.ToInt32(textBox8.Text);
                        break;
                    case 9:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);
                        Porcentajes[3] = Convert.ToInt32(textBox4.Text);
                        Porcentajes[4] = Convert.ToInt32(textBox5.Text);
                        Porcentajes[5] = Convert.ToInt32(textBox6.Text);
                        Porcentajes[6] = Convert.ToInt32(textBox7.Text);
                        Porcentajes[7] = Convert.ToInt32(textBox8.Text);
                        Porcentajes[8] = Convert.ToInt32(textBox9.Text);
                        break;
                    case 10:
                        Porcentajes[0] = Convert.ToInt32(textBox1.Text);
                        Porcentajes[1] = Convert.ToInt32(textBox2.Text);
                        Porcentajes[2] = Convert.ToInt32(textBox3.Text);
                        Porcentajes[3] = Convert.ToInt32(textBox4.Text);
                        Porcentajes[4] = Convert.ToInt32(textBox5.Text);
                        Porcentajes[5] = Convert.ToInt32(textBox6.Text);
                        Porcentajes[6] = Convert.ToInt32(textBox7.Text);
                        Porcentajes[7] = Convert.ToInt32(textBox8.Text);
                        Porcentajes[8] = Convert.ToInt32(textBox9.Text);
                        Porcentajes[9] = Convert.ToInt32(textBox10.Text);
                        break;
                }
                Close();
            }
            else
            {
                MessageBox.Show("La suma de los porcentajes debe dar 100");
            }
           
        }

        private void CargarEventosValidtaing()
        {
            textBox1.Validating += new CancelEventHandler(textbox1Validating);
            textBox2.Validating += new CancelEventHandler(textbox2Validating);
            textBox3.Validating += new CancelEventHandler(textbox3Validating);
            textBox4.Validating += new CancelEventHandler(textbox4Validating);
            textBox5.Validating += new CancelEventHandler(textbox5Validating);
            textBox6.Validating += new CancelEventHandler(textbox6Validating);
            textBox7.Validating += new CancelEventHandler(textbox7Validating);
            textBox8.Validating += new CancelEventHandler(textbox8Validating);
            textBox9.Validating += new CancelEventHandler(textbox9Validating);
            textBox10.Validating += new CancelEventHandler(textbox10Validating);

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtingvenc_TextChanged(object sender, EventArgs e)
        {
            ManejoDateTextBox.SetearTextBoxVacios(obtenerTextBoxes);
            ManejoDateTextBox.LabelsImporteInvisible(obtenerLabelsimporte);
        }

        private void btnaceptar_Click_1(object sender, EventArgs e)
        {
            AgregarDatos();
        }
    }
}
