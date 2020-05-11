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
    public partial class fFanniForm : Form
    {
        public fFanniForm()
        {
            InitializeComponent();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void tsmNevjegy_Click(object sender, EventArgs e)
        {
            AboutBox abBox = new AboutBox();
            abBox.ShowDialog();
        }

        private void tsmWeightCalc_Click(object sender, EventArgs e)
        {
            frWeightCalc weightCalc = new frWeightCalc();
            weightCalc.ShowDialog();
        }

        private void tsmCaloriaCalc_Click(object sender, EventArgs e)
        {
            frmCaloria caloria = new frmCaloria();
            caloria.ShowDialog();
        }

        private void ChKalkulator_Click(object sender, EventArgs e)
        {
            CHForm cH = new CHForm();
            cH.ShowDialog();
        }

        private void tsmurmertekCalculator_Click(object sender, EventArgs e)
        {
            frmUrmertek urmertek = new frmUrmertek();
            urmertek.ShowDialog();
        }
    }
}
