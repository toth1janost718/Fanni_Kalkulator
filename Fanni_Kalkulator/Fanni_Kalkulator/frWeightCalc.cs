using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fanni_Kalkulator
{
    public partial class frWeightCalc : Form
    {
        string tbReadSource;
        double tbReadDouble;
        string value;
        int number;

        
       
        
        public frWeightCalc()
        {
            InitializeComponent();
            setTooltip();
        }

       

        private void setTooltip() {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.textBox1, "Add meg a mennyiséget");

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&& e.KeyChar != '.')
            {
                e.Handled = true;
            }

           
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            value = comboBox1.SelectedIndex.ToString();
            number = int.Parse(value);
            if (number == 0)
            {
                tbResult.Text = "--";
                tbweigth.Text = (tbReadDouble * 100).ToString();
                tbGramm.Text = (tbReadDouble * 1000).ToString();

            }
            else if (number == 1)
            {

                tbResult.Text = (tbReadDouble / 100).ToString();
                tbweigth.Text = "--";
                tbGramm.Text = (tbReadDouble * 10).ToString();

            }
            else if (number == 2)
            {

                tbResult.Text = (tbReadDouble / 1000).ToString();
                tbweigth.Text = (tbReadDouble / 10).ToString(); ;
                tbGramm.Text = "--";

            }
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbReadSource = textBox1.Text;
            tbReadDouble = double.Parse(tbReadSource);

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            value = comboBox1.SelectedIndex.ToString();
            number = int.Parse(value);
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox1.BackColor = Color.LightBlue;
            }
            else if (comboBox1.SelectedIndex == 1) {
                comboBox1.BackColor = Color.LimeGreen;
            }
            else if(comboBox1.SelectedIndex==2){
                comboBox1.BackColor = Color.Yellow;
            }
           

        }
    }
}
