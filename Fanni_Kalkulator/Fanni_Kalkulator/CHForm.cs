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
    public partial class CHForm : Form
    {

        String tbReadCh;
        float tbReadFloatCh;
        String tbReadGCh;
        float tbReadFloatgCh;
        String tbReadRandomCh1;
        float tbReadRandomFloatCh;
        float GrammCHResult;
        public CHForm()
        {
            InitializeComponent();
        }

      

        private void tbCh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbReadCh = tbCh.Text;
                tbReadFloatCh = float.Parse(tbReadCh);
            }
            catch (Exception ex)
            {
                if (tbCh.Text=="")
                {

                }
                else
                    MessageBox.Show("Adj meg értéket!", "Segítség", MessageBoxButtons.OK);
            }
        }

        private void tbCh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbGrammCh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbRandomCh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbGrammCh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbReadGCh = tbGrammCh.Text;
                tbReadFloatgCh = float.Parse(tbReadGCh);
            }
            catch (Exception ex)
            {
                if (tbCh.Text == "")
                {

                }
                else
                    MessageBox.Show("Adj meg értéket!", "Segítség", MessageBoxButtons.OK);
            }
        }

        private void tbRandomCh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbReadRandomCh1 = tbRandomCh.Text;
                tbReadRandomFloatCh = float.Parse(tbReadRandomCh1);
            }
            catch (Exception ex)
            {
                if (tbRandomCh.Text == "")
                {

                }
                else
                    MessageBox.Show("Adj meg értéket!", "Segítség", MessageBoxButtons.OK);
            }
        }

        private void btStartCh1_Click(object sender, EventArgs e)
        {
            GrammCHResult= (tbReadRandomFloatCh / tbReadFloatgCh);
            Console.WriteLine(tbReadRandomFloatCh);
            Console.WriteLine(tbReadFloatgCh);
            Console.WriteLine(GrammCHResult);
            tb1gCH.Text = GrammCHResult.ToString();
        }
    }
}
