namespace Fanni_Kalkulator
{
    partial class frmUrmertek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrmertek));
            this.lbMennyiseg = new System.Windows.Forms.Label();
            this.lbMertekegyseg = new System.Windows.Forms.Label();
            this.tbMennyiseg = new System.Windows.Forms.TextBox();
            this.cbMertekegyseg = new System.Windows.Forms.ComboBox();
            this.lbml = new System.Windows.Forms.Label();
            this.lbdl = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbcl = new System.Windows.Forms.Label();
            this.tbml = new System.Windows.Forms.TextBox();
            this.tbcl = new System.Windows.Forms.TextBox();
            this.tbdl = new System.Windows.Forms.TextBox();
            this.tbLiter = new System.Windows.Forms.TextBox();
            this.btnInditLiter = new System.Windows.Forms.Button();
            this.btnResetMertek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMennyiseg
            // 
            this.lbMennyiseg.AutoSize = true;
            this.lbMennyiseg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMennyiseg.Location = new System.Drawing.Point(111, 37);
            this.lbMennyiseg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMennyiseg.Name = "lbMennyiseg";
            this.lbMennyiseg.Size = new System.Drawing.Size(76, 15);
            this.lbMennyiseg.TabIndex = 0;
            this.lbMennyiseg.Text = "Mennyiség";
            // 
            // lbMertekegyseg
            // 
            this.lbMertekegyseg.AutoSize = true;
            this.lbMertekegyseg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMertekegyseg.Location = new System.Drawing.Point(312, 37);
            this.lbMertekegyseg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMertekegyseg.Name = "lbMertekegyseg";
            this.lbMertekegyseg.Size = new System.Drawing.Size(98, 15);
            this.lbMertekegyseg.TabIndex = 1;
            this.lbMertekegyseg.Text = "Mértékegység";
            // 
            // tbMennyiseg
            // 
            this.tbMennyiseg.Location = new System.Drawing.Point(77, 78);
            this.tbMennyiseg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMennyiseg.Name = "tbMennyiseg";
            this.tbMennyiseg.Size = new System.Drawing.Size(132, 23);
            this.tbMennyiseg.TabIndex = 2;
            this.tbMennyiseg.TextChanged += new System.EventHandler(this.tbMennyiseg_TextChanged);
            this.tbMennyiseg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMennyiseg_KeyPress);
            // 
            // cbMertekegyseg
            // 
            this.cbMertekegyseg.FormattingEnabled = true;
            this.cbMertekegyseg.Items.AddRange(new object[] {
            "ml",
            "cl",
            "dl",
            "l"});
            this.cbMertekegyseg.Location = new System.Drawing.Point(284, 77);
            this.cbMertekegyseg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMertekegyseg.Name = "cbMertekegyseg";
            this.cbMertekegyseg.Size = new System.Drawing.Size(160, 23);
            this.cbMertekegyseg.TabIndex = 3;
            // 
            // lbml
            // 
            this.lbml.AutoSize = true;
            this.lbml.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbml.Location = new System.Drawing.Point(73, 175);
            this.lbml.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbml.Name = "lbml";
            this.lbml.Size = new System.Drawing.Size(86, 15);
            this.lbml.TabIndex = 4;
            this.lbml.Text = "Mililiter (ml)";
            // 
            // lbdl
            // 
            this.lbdl.AutoSize = true;
            this.lbdl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdl.Location = new System.Drawing.Point(399, 218);
            this.lbdl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdl.Name = "lbdl";
            this.lbdl.Size = new System.Drawing.Size(89, 15);
            this.lbdl.TabIndex = 5;
            this.lbdl.Text = "Deciliter (dl)";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(591, 223);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 15);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Liter (l)";
            // 
            // lbcl
            // 
            this.lbcl.AutoSize = true;
            this.lbcl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcl.Location = new System.Drawing.Point(241, 175);
            this.lbcl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcl.Name = "lbcl";
            this.lbcl.Size = new System.Drawing.Size(94, 15);
            this.lbcl.TabIndex = 7;
            this.lbcl.Text = "Centiliter (cl)";
            // 
            // tbml
            // 
            this.tbml.Location = new System.Drawing.Point(36, 215);
            this.tbml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbml.Name = "tbml";
            this.tbml.ReadOnly = true;
            this.tbml.Size = new System.Drawing.Size(132, 23);
            this.tbml.TabIndex = 8;
            // 
            // tbcl
            // 
            this.tbcl.Location = new System.Drawing.Point(211, 215);
            this.tbcl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbcl.Name = "tbcl";
            this.tbcl.ReadOnly = true;
            this.tbcl.Size = new System.Drawing.Size(132, 23);
            this.tbcl.TabIndex = 9;
            // 
            // tbdl
            // 
            this.tbdl.Location = new System.Drawing.Point(361, 267);
            this.tbdl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbdl.Name = "tbdl";
            this.tbdl.ReadOnly = true;
            this.tbdl.Size = new System.Drawing.Size(132, 23);
            this.tbdl.TabIndex = 10;
            // 
            // tbLiter
            // 
            this.tbLiter.Location = new System.Drawing.Point(545, 267);
            this.tbLiter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLiter.Name = "tbLiter";
            this.tbLiter.ReadOnly = true;
            this.tbLiter.Size = new System.Drawing.Size(132, 23);
            this.tbLiter.TabIndex = 11;
            // 
            // btnInditLiter
            // 
            this.btnInditLiter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInditLiter.Location = new System.Drawing.Point(545, 62);
            this.btnInditLiter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInditLiter.Name = "btnInditLiter";
            this.btnInditLiter.Size = new System.Drawing.Size(117, 76);
            this.btnInditLiter.TabIndex = 12;
            this.btnInditLiter.Text = "Indít";
            this.btnInditLiter.UseVisualStyleBackColor = false;
            this.btnInditLiter.Click += new System.EventHandler(this.btnInditLiter_Click);
            // 
            // btnResetMertek
            // 
            this.btnResetMertek.BackColor = System.Drawing.Color.LightSalmon;
            this.btnResetMertek.Location = new System.Drawing.Point(-1, 1);
            this.btnResetMertek.Name = "btnResetMertek";
            this.btnResetMertek.Size = new System.Drawing.Size(75, 23);
            this.btnResetMertek.TabIndex = 13;
            this.btnResetMertek.Text = "Reset";
            this.btnResetMertek.UseVisualStyleBackColor = false;
            this.btnResetMertek.Click += new System.EventHandler(this.btnResetMertek_Click);
            // 
            // frmUrmertek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 362);
            this.Controls.Add(this.btnResetMertek);
            this.Controls.Add(this.btnInditLiter);
            this.Controls.Add(this.tbLiter);
            this.Controls.Add(this.tbdl);
            this.Controls.Add(this.tbcl);
            this.Controls.Add(this.tbml);
            this.Controls.Add(this.lbcl);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbdl);
            this.Controls.Add(this.lbml);
            this.Controls.Add(this.cbMertekegyseg);
            this.Controls.Add(this.tbMennyiseg);
            this.Controls.Add(this.lbMertekegyseg);
            this.Controls.Add(this.lbMennyiseg);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmUrmertek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Űrmérték Kalkulátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMennyiseg;
        private System.Windows.Forms.Label lbMertekegyseg;
        private System.Windows.Forms.TextBox tbMennyiseg;
        private System.Windows.Forms.ComboBox cbMertekegyseg;
        private System.Windows.Forms.Label lbml;
        private System.Windows.Forms.Label lbdl;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbcl;
        private System.Windows.Forms.TextBox tbml;
        private System.Windows.Forms.TextBox tbcl;
        private System.Windows.Forms.TextBox tbdl;
        private System.Windows.Forms.TextBox tbLiter;
        private System.Windows.Forms.Button btnInditLiter;
        private System.Windows.Forms.Button btnResetMertek;
    }
}