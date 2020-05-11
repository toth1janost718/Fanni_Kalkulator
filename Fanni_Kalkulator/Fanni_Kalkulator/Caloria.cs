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
    public partial class frmCaloria : Form
    {

        float tbReadDoubleCaloria;
        string tbReadCaloria;
        string tbReadGramm;
        float tbReadDoubleGramm;
        float GrammCaloriaResult;
        float tbReadRandom;
        string tbReadRandomString;

        public frmCaloria()
        {
            InitializeComponent();
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            GrammCaloriaResult = tbReadDoubleCaloria / tbReadDoubleGramm;
            tb1gramm.Text = GrammCaloriaResult.ToString();
            tb10gramm.Text = (GrammCaloriaResult * 10).ToString();
            tb100gram.Text = (GrammCaloriaResult * 100).ToString();
        }

        private void lbCaloria_TextChanged(object sender, EventArgs e)
        {
            try {
                tbReadCaloria = lbCaloria.Text;
                tbReadDoubleCaloria = float.Parse(tbReadCaloria);
            }
            catch (Exception ex)
            {
                if (lbCaloria.Text == "")
                {

                }
                else
                    MessageBox.Show("Adj meg értéket!", "Segítség", MessageBoxButtons.OK);
            }


        }

        private void lbGramm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbReadGramm = lbGramm.Text;
                tbReadDoubleGramm = float.Parse(tbReadGramm);
            }
            catch (Exception ex)
            {
                if (lbGramm.Text =="") {
                    
                }
                else
                MessageBox.Show("Adj meg értéket!", "Segítség", MessageBoxButtons.OK);
            }

        }

        private void lbCaloria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            
        }

        private void btnCaloria_Click(object sender, EventArgs e)
        {
            tbReadRandomString = tbGrammAdott.Text;
            tbReadRandom = float.Parse(tbReadRandomString);
            tbKaloria.Text =  (GrammCaloriaResult*tbReadRandom).ToString();
        }

        private void tbGrammAdott_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbGramm.ResetText();
            lbCaloria.ResetText();
            tbGrammAdott.Clear();
            tb1gramm.Clear();
            tb100gram.Clear();
            tb10gramm.Clear();
          
            tbKaloria.Clear();
        }
    }
}
