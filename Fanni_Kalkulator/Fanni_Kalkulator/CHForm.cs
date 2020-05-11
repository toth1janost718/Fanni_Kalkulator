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
        float tbRandomValue;
        public CHForm()
        {
            InitializeComponent();
        }

      

        private void tbCh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbReadCh = tbCaloriaCH.Text;
                tbReadFloatCh = float.Parse(tbReadCh);
            }
            catch (Exception ex)
            {
                if (tbCaloriaCH.Text=="")
                {

                }
                else
                    MessageBox.Show("Adj meg értéket!", "Segítség", MessageBoxButtons.OK);
            }
        }

     

        private void tbGrammCh_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
                if (tbGrammCh.Text == "")
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
            
            GrammCHResult= (tbReadFloatCh / tbReadFloatgCh);
                     
            tb1gCH.Text = GrammCHResult.ToString();
            tb10gCH.Text = (GrammCHResult * 10).ToString();
            tb100gCh.Text = (GrammCHResult * 100).ToString();
        }


        private void tbCaloriaCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btStartCH2_Click(object sender, EventArgs e)
        {

            tbRandomValue = tbReadRandomFloatCh * GrammCHResult;
             tbRandomChgramm.Text = tbRandomValue.ToString();
        }

        private void btResetCh_Click(object sender, EventArgs e)
        {
            tbRandomCh.ResetText();
            tbRandomChgramm.ResetText();
            tbCaloriaCH.ResetText();
            tbGrammCh.ResetText();
            tb1gCH.Clear();
            tb100gCh.Clear();
            tb10gCH.Clear();
        }
    }
}
