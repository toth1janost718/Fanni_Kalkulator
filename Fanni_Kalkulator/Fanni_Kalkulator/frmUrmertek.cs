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
    public partial class frmUrmertek : Form
    {
        string valuemertek;
        float numbermertek;
        string tbReadMertek;
        float tbReadDoubleMertek;
        public frmUrmertek()
        {
            InitializeComponent();
        }

        private void btnInditLiter_Click(object sender, EventArgs e)
        {
            valuemertek = cbMertekegyseg.SelectedIndex.ToString();
            numbermertek = float.Parse(valuemertek);
            if (numbermertek == 0)
            {
                tbml.Text = "--";
                tbdl.Text = (tbReadDoubleMertek / 100).ToString();
                tbcl.Text = (tbReadDoubleMertek / 10).ToString();
                tbLiter.Text = (tbReadDoubleMertek / 1000).ToString();
            }
            else if (numbermertek == 1) {

                tbml.Text = (tbReadDoubleMertek * 10).ToString(); ;
                tbdl.Text = (tbReadDoubleMertek / 10).ToString();
                tbcl.Text = "--";
                tbLiter.Text = (tbReadDoubleMertek / 100).ToString();

            }
            else if (numbermertek == 2)
            {

                tbml.Text = (tbReadDoubleMertek *100).ToString(); ;
                tbdl.Text = "--";
                tbcl.Text = (tbReadDoubleMertek * 10).ToString();
                tbLiter.Text = (tbReadDoubleMertek / 10).ToString();

            }
            else if (numbermertek == 3)
            {

                tbml.Text = (tbReadDoubleMertek * 1000).ToString(); ;
                tbdl.Text = (tbReadDoubleMertek * 10).ToString();
                tbcl.Text = (tbReadDoubleMertek * 100).ToString();
                tbLiter.Text = "--";

            }

        }

        private void tbMennyiseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbMennyiseg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbReadMertek = tbMennyiseg.Text;
                tbReadDoubleMertek = float.Parse(tbReadMertek);
            }
            catch (Exception ex)
            {
                if (tbMennyiseg.Text=="") { }
                else
                {
                    MessageBox.Show("Csak egész számot tudsz megadni!", "Tájékoztatás", MessageBoxButtons.OK);
                }
            }

        }

        private void btnResetMertek_Click(object sender, EventArgs e)
        {
            tbMennyiseg.Clear();
            tbml.Clear();
            tbcl.Clear();
            tbLiter.Clear();
            tbdl.Clear();
                
        }
    }
}
