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
    public partial class Suma10TextBox : Form
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
                if(suma==100)
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
       


        #endregion

        public Suma10TextBox()
        {
            InitializeComponent();
        }

        private void FormSuma10TextBox_Load(object sender, EventArgs e)
        {
            CargarEventoTextBox();
            TextBoxMinimo0Mayor100();
            SetearTextBoxVacios();
            DesabilitarTextBox();
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
          
        }
    
        private void TextBoxMinimo0Mayor100()
        {
            textBox1.MaxLength = 3;
            textBox4.MaxLength = 3;
            textBox3.MaxLength = 3;
            textBox2.MaxLength = 3;
            textBox5.MaxLength = 3;
            textBox6.MaxLength = 3;
            textBox7.MaxLength = 3;
            textBox8.MaxLength = 3;
            textBox9.MaxLength = 3;
            textBox10.MaxLength = 3;

        }
      
        private void SetearTextBoxVacios()
        {
            textBox1.Text = "0";
            textBox4.Text = "0";
            textBox3.Text = "0";
            textBox2.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0"; 
            textBox10.Text = "0";
            textBox1.Text = "0";
        }

        private void DesabilitarTextBox()
        {
            textBox4.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
        }

        private void SetearImportePorcentaje(Label lbl,TextBox textBox)
        {
            lbl.Text =ImporteSegunPorcentaje(Convert.ToInt32(textBox.Text)).ToString();
           
        }
        #endregion

        #region Validating
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            SetearImportePorcentaje(label1, textBox1);
            if (!SumaDa100)
            {
               
                //if(SumaT1T2)
                //{
                    
                  
                //}
              
                //else 
                //{
           
                if(SumaTodoslosTextBox>100)
                {
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;


                    textBox2.Text = "0";
                    textBox3.Text = "0";
                    textBox4.Text = "0";
                    textBox5.Text = "0";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {

                    textBox2.ReadOnly = false;
                }
                //}
              
            }
            else 
            {
              

               

                   textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;


                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
               textBox8.Text = "0";
               textBox9.Text = "0";
                textBox10.Text = "0";
                
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            if (!SumaDa100)
            {
                //if (SumaT1T2)
                //{
                //    textBox2.Focus();

                //}
                //else
                //{
               // textBox2.ReadOnly = false;
               
                if (SumaTodoslosTextBox > 100)
                {
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;



                    textBox3.Text = "0";
                    textBox4.Text = "0";
                    textBox5.Text = "0";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";

                }
                else
                {
                    textBox3.ReadOnly = false;
                }

            }
            else
            {
             
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;


              
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                 

            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

            if (!SumaDa100)
            {
              //  textBox4.ReadOnly = false;
                if (SumaTodoslosTextBox > 100)
                {
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;


                    textBox4.Text = "0";
                    textBox5.Text = "0";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {
                    textBox4.ReadOnly = false;
                }
            }
            else
            {

                //if (SumaT1T2T3T4)
                //{
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;


                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                // }
                // }
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!SumaDa100)
            {

              
                if (SumaTodoslosTextBox > 100)
                {
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;


                    textBox5.Text = "0";
                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {
                    textBox5.ReadOnly = false;
                }
            }
            else
            {

                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;


                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (!SumaDa100)
            {
                textBox6.ReadOnly = false;
                if (SumaTodoslosTextBox > 100)
                {

                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;


                    textBox6.Text = "0";
                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {
                    textBox6.ReadOnly = false;
                }
            }
            else
            {

             
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;

             
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (!SumaDa100)
            {
                if (SumaTodoslosTextBox > 100)
                {

                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;


                    textBox7.Text = "0";
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {
                    textBox7.ReadOnly = false;
                }
               
            }
            else
            {

              
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;

               
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (!SumaDa100)
            {
                if (SumaTodoslosTextBox > 100)
                {

                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;


                   
                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {
                    textBox8.ReadOnly = false;
                }
            
            }
            else
            {

              
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (!SumaDa100)
            {
                if (SumaTodoslosTextBox > 100)
                {

                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;



                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {
                    textBox9.ReadOnly = false;
                }
             
            }
            else
            {

             
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
            }
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (!SumaDa100)
            {
                if (SumaTodoslosTextBox > 100)
                {

                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;



                    textBox8.Text = "0";
                    textBox9.Text = "0";
                    textBox10.Text = "0";
                }
                else
                {
                    textBox10.ReadOnly = false;
                }
            }
            else
            {

           
                textBox10.ReadOnly = true;
            }
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (!SumaDa100)
            {
                //textBox11.ReadOnly = false;
            }
            else
            {

                //textBox4.ReadOnly = true;
                //textBox5.ReadOnly = true;
                //textBox6.ReadOnly = true;
                //textBox7.ReadOnly = true;
                //textBox8.ReadOnly = true;
                //textBox9.ReadOnly = true;
                //textBox10.ReadOnly = true;
            }
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

        
    }
}
