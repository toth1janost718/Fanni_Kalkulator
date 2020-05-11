namespace Fanni_Kalkulator
{
    partial class frmCaloria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaloria));
            this.lbMennyiseg = new System.Windows.Forms.Label();
            this.lbmgramm = new System.Windows.Forms.Label();
            this.lbCaloria = new System.Windows.Forms.TextBox();
            this.lbGramm = new System.Windows.Forms.TextBox();
            this.lbTextCaloria = new System.Windows.Forms.Label();
            this.gpCaloria = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaloria = new System.Windows.Forms.Button();
            this.lbCal = new System.Windows.Forms.Label();
            this.lbgr = new System.Windows.Forms.Label();
            this.tbKaloria = new System.Windows.Forms.TextBox();
            this.tb100gram = new System.Windows.Forms.TextBox();
            this.tb10gramm = new System.Windows.Forms.TextBox();
            this.tb1gramm = new System.Windows.Forms.TextBox();
            this.lb100 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbGrammAdott = new System.Windows.Forms.TextBox();
            this.lbAdott = new System.Windows.Forms.Label();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.gpCaloria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMennyiseg
            // 
            this.lbMennyiseg.AutoSize = true;
            this.lbMennyiseg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMennyiseg.Location = new System.Drawing.Point(47, 64);
            this.lbMennyiseg.Name = "lbMennyiseg";
            this.lbMennyiseg.Size = new System.Drawing.Size(125, 14);
            this.lbMennyiseg.TabIndex = 0;
            this.lbMennyiseg.Text = "Mennyiség ( Kalória)";
            // 
            // lbmgramm
            // 
            this.lbmgramm.AutoSize = true;
            this.lbmgramm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmgramm.Location = new System.Drawing.Point(371, 64);
            this.lbmgramm.Name = "lbmgramm";
            this.lbmgramm.Size = new System.Drawing.Size(123, 14);
            this.lbmgramm.TabIndex = 1;
            this.lbmgramm.Text = "Mennyiség (gramm)";
            // 
            // lbCaloria
            // 
            this.lbCaloria.Location = new System.Drawing.Point(49, 102);
            this.lbCaloria.Name = "lbCaloria";
            this.lbCaloria.Size = new System.Drawing.Size(100, 20);
            this.lbCaloria.TabIndex = 2;
            this.lbCaloria.TextChanged += new System.EventHandler(this.lbCaloria_TextChanged);
            this.lbCaloria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbCaloria_KeyPress);
            // 
            // lbGramm
            // 
            this.lbGramm.Location = new System.Drawing.Point(369, 102);
            this.lbGramm.Name = "lbGramm";
            this.lbGramm.Size = new System.Drawing.Size(100, 20);
            this.lbGramm.TabIndex = 3;
            this.lbGramm.TextChanged += new System.EventHandler(this.lbGramm_TextChanged);
            // 
            // lbTextCaloria
            // 
            this.lbTextCaloria.AutoSize = true;
            this.lbTextCaloria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextCaloria.Location = new System.Drawing.Point(140, 16);
            this.lbTextCaloria.Name = "lbTextCaloria";
            this.lbTextCaloria.Size = new System.Drawing.Size(208, 22);
            this.lbTextCaloria.TabIndex = 4;
            this.lbTextCaloria.Text = "A Kalória mennyisége";
            // 
            // gpCaloria
            // 
            this.gpCaloria.Controls.Add(this.label3);
            this.gpCaloria.Controls.Add(this.label2);
            this.gpCaloria.Controls.Add(this.label1);
            this.gpCaloria.Controls.Add(this.btnCaloria);
            this.gpCaloria.Controls.Add(this.lbCal);
            this.gpCaloria.Controls.Add(this.lbTextCaloria);
            this.gpCaloria.Controls.Add(this.lbgr);
            this.gpCaloria.Controls.Add(this.tbKaloria);
            this.gpCaloria.Controls.Add(this.tb100gram);
            this.gpCaloria.Controls.Add(this.tb10gramm);
            this.gpCaloria.Controls.Add(this.tb1gramm);
            this.gpCaloria.Controls.Add(this.lb100);
            this.gpCaloria.Controls.Add(this.lb10);
            this.gpCaloria.Controls.Add(this.lb1);
            this.gpCaloria.Controls.Add(this.tbGrammAdott);
            this.gpCaloria.Controls.Add(this.lbAdott);
            this.gpCaloria.Location = new System.Drawing.Point(12, 159);
            this.gpCaloria.Name = "gpCaloria";
            this.gpCaloria.Size = new System.Drawing.Size(548, 205);
            this.gpCaloria.TabIndex = 5;
            this.gpCaloria.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "cal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "cal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "cal";
            // 
            // btnCaloria
            // 
            this.btnCaloria.BackColor = System.Drawing.Color.Lime;
            this.btnCaloria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaloria.Location = new System.Drawing.Point(451, 39);
            this.btnCaloria.Name = "btnCaloria";
            this.btnCaloria.Size = new System.Drawing.Size(80, 40);
            this.btnCaloria.TabIndex = 11;
            this.btnCaloria.Text = "Számol";
            this.btnCaloria.UseVisualStyleBackColor = false;
            this.btnCaloria.Click += new System.EventHandler(this.btnCaloria_Click);
            // 
            // lbCal
            // 
            this.lbCal.AutoSize = true;
            this.lbCal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal.Location = new System.Drawing.Point(374, 65);
            this.lbCal.Name = "lbCal";
            this.lbCal.Size = new System.Drawing.Size(46, 14);
            this.lbCal.TabIndex = 10;
            this.lbCal.Text = "kalória";
            // 
            // lbgr
            // 
            this.lbgr.AutoSize = true;
            this.lbgr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgr.Location = new System.Drawing.Point(223, 62);
            this.lbgr.Name = "lbgr";
            this.lbgr.Size = new System.Drawing.Size(49, 14);
            this.lbgr.TabIndex = 9;
            this.lbgr.Text = "gramm";
            // 
            // tbKaloria
            // 
            this.tbKaloria.Location = new System.Drawing.Point(278, 59);
            this.tbKaloria.Name = "tbKaloria";
            this.tbKaloria.ReadOnly = true;
            this.tbKaloria.Size = new System.Drawing.Size(90, 20);
            this.tbKaloria.TabIndex = 8;
            // 
            // tb100gram
            // 
            this.tb100gram.Location = new System.Drawing.Point(402, 153);
            this.tb100gram.Name = "tb100gram";
            this.tb100gram.ReadOnly = true;
            this.tb100gram.Size = new System.Drawing.Size(85, 20);
            this.tb100gram.TabIndex = 7;
            // 
            // tb10gramm
            // 
            this.tb10gramm.Location = new System.Drawing.Point(212, 153);
            this.tb10gramm.Name = "tb10gramm";
            this.tb10gramm.ReadOnly = true;
            this.tb10gramm.Size = new System.Drawing.Size(88, 20);
            this.tb10gramm.TabIndex = 6;
            // 
            // tb1gramm
            // 
            this.tb1gramm.Location = new System.Drawing.Point(24, 153);
            this.tb1gramm.Name = "tb1gramm";
            this.tb1gramm.ReadOnly = true;
            this.tb1gramm.Size = new System.Drawing.Size(85, 20);
            this.tb1gramm.TabIndex = 5;
            // 
            // lb100
            // 
            this.lb100.AutoSize = true;
            this.lb100.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb100.Location = new System.Drawing.Point(417, 116);
            this.lb100.Name = "lb100";
            this.lb100.Size = new System.Drawing.Size(73, 14);
            this.lb100.TabIndex = 4;
            this.lb100.Text = "100 gramm";
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(232, 116);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(66, 14);
            this.lb10.TabIndex = 3;
            this.lb10.Text = "10 gramm";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(44, 116);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(59, 14);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "1 gramm";
            // 
            // tbGrammAdott
            // 
            this.tbGrammAdott.Location = new System.Drawing.Point(141, 59);
            this.tbGrammAdott.Name = "tbGrammAdott";
            this.tbGrammAdott.Size = new System.Drawing.Size(76, 20);
            this.tbGrammAdott.TabIndex = 1;
            this.tbGrammAdott.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrammAdott_KeyPress);
            // 
            // lbAdott
            // 
            this.lbAdott.AutoSize = true;
            this.lbAdott.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdott.Location = new System.Drawing.Point(6, 65);
            this.lbAdott.Name = "lbAdott";
            this.lbAdott.Size = new System.Drawing.Size(135, 14);
            this.lbAdott.TabIndex = 0;
            this.lbAdott.Text = "Adott mennyiségben: ";
            // 
            // pbStart
            // 
            this.pbStart.Image = ((System.Drawing.Image)(resources.GetObject("pbStart.Image")));
            this.pbStart.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbStart.InitialImage")));
            this.pbStart.Location = new System.Drawing.Point(212, 76);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(100, 64);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStart.TabIndex = 6;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Tomato;
            this.btnReset.Location = new System.Drawing.Point(12, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmCaloria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(572, 376);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.gpCaloria);
            this.Controls.Add(this.lbGramm);
            this.Controls.Add(this.lbCaloria);
            this.Controls.Add(this.lbmgramm);
            this.Controls.Add(this.lbMennyiseg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCaloria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalória Kalkulátor";
            this.gpCaloria.ResumeLayout(false);
            this.gpCaloria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMennyiseg;
        private System.Windows.Forms.Label lbmgramm;
        private System.Windows.Forms.TextBox lbCaloria;
        private System.Windows.Forms.TextBox lbGramm;
        private System.Windows.Forms.Label lbTextCaloria;
        private System.Windows.Forms.GroupBox gpCaloria;
        private System.Windows.Forms.TextBox tb100gram;
        private System.Windows.Forms.TextBox tb10gramm;
        private System.Windows.Forms.TextBox tb1gramm;
        private System.Windows.Forms.Label lb100;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbGrammAdott;
        private System.Windows.Forms.Label lbAdott;
        private System.Windows.Forms.TextBox tbKaloria;
        private System.Windows.Forms.Label lbCal;
        private System.Windows.Forms.Label lbgr;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.Button btnCaloria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
    }
}