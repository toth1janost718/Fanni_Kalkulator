namespace Fanni_Kalkulator
{
    partial class fFanniForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFanniForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKalkulator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWeightCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCaloriaCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.ChKalkulator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmurmertekCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKapcsolat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNevjegy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmKalkulator,
            this.tsmKapcsolat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "Fájl";
            // 
            // tsmExit
            // 
            this.tsmExit.CheckOnClick = true;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(111, 22);
            this.tsmExit.Text = "Kilépés";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmKalkulator
            // 
            this.tsmKalkulator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmWeightCalc,
            this.tsmCaloriaCalc,
            this.ChKalkulator,
            this.tsmurmertekCalculator});
            this.tsmKalkulator.Name = "tsmKalkulator";
            this.tsmKalkulator.Size = new System.Drawing.Size(72, 20);
            this.tsmKalkulator.Text = "Kalkulátor";
            // 
            // tsmWeightCalc
            // 
            this.tsmWeightCalc.Name = "tsmWeightCalc";
            this.tsmWeightCalc.Size = new System.Drawing.Size(184, 22);
            this.tsmWeightCalc.Text = "Súlykalkulátor";
            this.tsmWeightCalc.Click += new System.EventHandler(this.tsmWeightCalc_Click);
            // 
            // tsmCaloriaCalc
            // 
            this.tsmCaloriaCalc.Name = "tsmCaloriaCalc";
            this.tsmCaloriaCalc.Size = new System.Drawing.Size(184, 22);
            this.tsmCaloriaCalc.Text = "Kalória kalkulátor";
            this.tsmCaloriaCalc.Click += new System.EventHandler(this.tsmCaloriaCalc_Click);
            // 
            // ChKalkulator
            // 
            this.ChKalkulator.Name = "ChKalkulator";
            this.ChKalkulator.Size = new System.Drawing.Size(184, 22);
            this.ChKalkulator.Text = "Szénhidrát kalkulátor";
            this.ChKalkulator.Click += new System.EventHandler(this.ChKalkulator_Click);
            // 
            // tsmurmertekCalculator
            // 
            this.tsmurmertekCalculator.Name = "tsmurmertekCalculator";
            this.tsmurmertekCalculator.Size = new System.Drawing.Size(184, 22);
            this.tsmurmertekCalculator.Text = "Űrmérték kalkulátor";
            this.tsmurmertekCalculator.Click += new System.EventHandler(this.tsmurmertekCalculator_Click);
            // 
            // tsmKapcsolat
            // 
            this.tsmKapcsolat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmKapcsolat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNevjegy});
            this.tsmKapcsolat.Name = "tsmKapcsolat";
            this.tsmKapcsolat.Size = new System.Drawing.Size(70, 20);
            this.tsmKapcsolat.Text = "Kapcsolat";
            // 
            // tsmNevjegy
            // 
            this.tsmNevjegy.Name = "tsmNevjegy";
            this.tsmNevjegy.Size = new System.Drawing.Size(117, 22);
            this.tsmNevjegy.Text = "Névjegy";
            this.tsmNevjegy.Click += new System.EventHandler(this.tsmNevjegy_Click);
            // 
            // fFanniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(434, 267);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fFanniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fanni Kalkulátora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmKalkulator;
        private System.Windows.Forms.ToolStripMenuItem tsmWeightCalc;
        private System.Windows.Forms.ToolStripMenuItem tsmCaloriaCalc;
        private System.Windows.Forms.ToolStripMenuItem tsmKapcsolat;
        private System.Windows.Forms.ToolStripMenuItem tsmNevjegy;
        private System.Windows.Forms.ToolStripMenuItem ChKalkulator;
        private System.Windows.Forms.ToolStripMenuItem tsmurmertekCalculator;
    }
}

