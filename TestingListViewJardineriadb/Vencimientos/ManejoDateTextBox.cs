using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingListViewJardineriadb.Vencimientos
{
    internal class ManejoDateTextBox
    {
        #region HabilitarDateTextBoxes
        internal static void HabilitarDateTextVenc10(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;


            textboxes[3].Enabled = true;
            datetimepickers[3].Enabled = true;

            textboxes[4].Enabled = true;
            datetimepickers[4].Enabled = true;

            textboxes[5].Enabled = true;
            datetimepickers[5].Enabled = true;


            textboxes[6].Enabled = true;
            datetimepickers[6].Enabled = true;

            textboxes[7].Enabled = true;
            datetimepickers[7].Enabled = true;

            textboxes[8].Enabled = true;
            datetimepickers[8].Enabled = true;


            textboxes[9].Enabled = true;
            datetimepickers[9].Enabled = true;
        }
        internal static void HabilitarDateTextVenc9(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;


            textboxes[3].Enabled = true;
            datetimepickers[3].Enabled = true;

            textboxes[4].Enabled = true;
            datetimepickers[4].Enabled = true;

            textboxes[5].Enabled = true;
            datetimepickers[5].Enabled = true;


            textboxes[6].Enabled = true;
            datetimepickers[6].Enabled = true;

            textboxes[7].Enabled = true;
            datetimepickers[7].Enabled = true;

            textboxes[8].Enabled = true;
            datetimepickers[8].Enabled = true;
        }

        internal static void HabilitarDateTextVenc8(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;


            textboxes[3].Enabled = true;
            datetimepickers[3].Enabled = true;

            textboxes[4].Enabled = true;
            datetimepickers[4].Enabled = true;

            textboxes[5].Enabled = true;
            datetimepickers[5].Enabled = true;


            textboxes[6].Enabled = true;
            datetimepickers[6].Enabled = true;

            textboxes[7].Enabled = true;
            datetimepickers[7].Enabled = true;

        
        }

        internal static void HabilitarDateTexVenc7(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;


            textboxes[3].Enabled = true;
            datetimepickers[3].Enabled = true;

            textboxes[4].Enabled = true;
            datetimepickers[4].Enabled = true;

            textboxes[5].Enabled = true;
            datetimepickers[5].Enabled = true;


            textboxes[6].Enabled = true;
            datetimepickers[6].Enabled = true;

        }

        internal static void HabilitarDateTextVenc6(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;


            textboxes[3].Enabled = true;
            datetimepickers[3].Enabled = true;

            textboxes[4].Enabled = true;
            datetimepickers[4].Enabled = true;

            textboxes[5].Enabled = true;
            datetimepickers[5].Enabled = true;


        }

        internal static void HabilitarDateTextVenc4(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;


            textboxes[3].Enabled = true;
            datetimepickers[3].Enabled = true;

       
        }

        internal static void HabilitarDateTextVenc3(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;




        }

        internal static void HabilitarDateTextVenc2(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

       



        }

        internal static void HabilitarDateTextVenc5(TextBox[] textboxes, DateTimePicker[] datetimepickers)
        {
            textboxes[0].Enabled = true;
            datetimepickers[0].Enabled = true;

            textboxes[1].Enabled = true;
            datetimepickers[1].Enabled = true;

            textboxes[2].Enabled = true;
            datetimepickers[2].Enabled = true;


            textboxes[3].Enabled = true;
            datetimepickers[3].Enabled = true;

            textboxes[4].Enabled = true;
            datetimepickers[4].Enabled = true;

        }
        #endregion

        internal static void HabilitarTextDate_Segun_CantVenc(TextBox[] textboxes, DateTimePicker[] datetimepickers, TextBox txtingvenc)
        {
            int enterocantvenc = Convert.ToInt32(txtingvenc.Text);
            switch (enterocantvenc)
            {
                case 1:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    textboxes[0].Enabled = true;
                    datetimepickers[0].Enabled = true;
                    textboxes[0].MaxLength = 3;
                    break;
                case 2:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc2(textboxes,datetimepickers);

                    break;
                case 3:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc3(textboxes, datetimepickers);


                    break;
                case 4:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc4(textboxes, datetimepickers);



                    break;
                case 5:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc5(textboxes, datetimepickers);
                    break;
                case 6:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc6(textboxes, datetimepickers);
                    break;
                case 7:

                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTexVenc7(textboxes, datetimepickers);
                    break;
                case 8:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc8(textboxes, datetimepickers);
                    break;
                case 9:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc9(textboxes, datetimepickers);
                    break;
                case 10:
                    DesabilitarTextBox(textboxes);
                    DesactivarFechas(datetimepickers);
                    HabilitarDateTextVenc10(textboxes, datetimepickers);
                    break;
            }
            datetimepickers[0].Focus();
            //if (enterocantvenc == 1)
            //{
            //    textBox1.Enabled = true;
            //    dateTimePicker1.Enabled = true;
            //}
            //else if ()
        }

        internal static void TextBoxMinimo0Mayor100(TextBox[] textboxes)
        {
            textboxes[0].MaxLength = 3;
            textboxes[1].MaxLength = 3;
            textboxes[2].MaxLength = 3;
            textboxes[3].MaxLength = 3;
            textboxes[4].MaxLength = 3;
            textboxes[5].MaxLength = 3;
            textboxes[6].MaxLength = 3;
            textboxes[7].MaxLength = 3;
            textboxes[8].MaxLength = 3;
            textboxes[9].MaxLength = 3;

        }

        internal static void SetearTextBoxVacios(TextBox[] textboxes)
        {
            textboxes[0].Text = "0";
            textboxes[1].Text = "0";
            textboxes[2].Text = "0";
            textboxes[3].Text = "0";
            textboxes[4].Text = "0";
            textboxes[5].Text = "0";
            textboxes[6].Text = "0";
            textboxes[7].Text = "0";
            textboxes[8].Text = "0";
            textboxes[9].Text = "0";

        }

        internal static void DesabilitarTextBox(TextBox[] textboxes)
        {
            textboxes[0].Enabled = false;
            textboxes[1].Enabled = false;
            textboxes[2].Enabled = false;
            textboxes[3].Enabled = false;
            textboxes[4].Enabled = false;
            textboxes[5].Enabled = false;
            textboxes[6].Enabled = false;
            textboxes[7].Enabled = false;
            textboxes[8].Enabled = false;
            textboxes[9].Enabled = false;

        }
        internal static void DefinirTextMaxLength2(TextBox[] textboxes)
        {
            textboxes[0].MaxLength = 2;
            textboxes[1].MaxLength = 2;
            textboxes[2].MaxLength = 2;
            textboxes[3].MaxLength = 2;
            textboxes[4].MaxLength = 2;
            textboxes[5].MaxLength = 2;
            textboxes[6].MaxLength = 2;
            textboxes[7].MaxLength = 2;
            textboxes[8].MaxLength = 2;
            textboxes[9].MaxLength = 2;
        }
        internal static void LabelsImporteInvisible(Label[] label)
        {
            label[0].Visible = false;
            label[1].Visible = false;
            label[2].Visible = false;
            label[3].Visible = false;
            label[4].Visible = false;
            label[5].Visible = false;
            label[6].Visible = false;
            label[7].Visible = false;
            label[8].Visible = false;
            label[9].Visible = false;
        }

        internal static void DesactivarFechas(DateTimePicker[] dateTimePicker)
        {
            dateTimePicker[0].Enabled = false;
            dateTimePicker[1].Enabled = false;
            dateTimePicker[2].Enabled = false;
            dateTimePicker[3].Enabled = false;
            dateTimePicker[4].Enabled = false;
            dateTimePicker[5].Enabled = false;
            dateTimePicker[6].Enabled = false;
            dateTimePicker[7].Enabled = false;
            dateTimePicker[8].Enabled = false;
            dateTimePicker[9].Enabled = false;
        }
    }

}
