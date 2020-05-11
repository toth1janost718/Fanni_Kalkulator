namespace Fanni_Kalkulator
{
    partial class CHForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHForm));
            this.lbCHEntry = new System.Windows.Forms.Label();
            this.lbgrammCH = new System.Windows.Forms.Label();
            this.btStartCh1 = new System.Windows.Forms.Button();
            this.gbCH = new System.Windows.Forms.GroupBox();
            this.tbRandomChgramm = new System.Windows.Forms.TextBox();
            this.tbRandomCh = new System.Windows.Forms.TextBox();
            this.label10CH = new System.Windows.Forms.Label();
            this.lbAdottCh = new System.Windows.Forms.Label();
            this.btStartCH2 = new System.Windows.Forms.Button();
            this.lb1ch = new System.Windows.Forms.Label();
            this.lb100ch = new System.Windows.Forms.Label();
            this.lb10ch = new System.Windows.Forms.Label();
            this.tbCaloriaCH = new System.Windows.Forms.TextBox();
            this.tbGrammCh = new System.Windows.Forms.TextBox();
            this.tb10gCH = new System.Windows.Forms.TextBox();
            this.tb100gCh = new System.Windows.Forms.TextBox();
            this.tb1gCH = new System.Windows.Forms.TextBox();
            this.btResetCh = new System.Windows.Forms.Button();
            this.gbCH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCHEntry
            // 
            this.lbCHEntry.AutoSize = true;
            this.lbCHEntry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCHEntry.Location = new System.Drawing.Point(44, 36);
            this.lbCHEntry.Name = "lbCHEntry";
            this.lbCHEntry.Size = new System.Drawing.Size(78, 15);
            this.lbCHEntry.TabIndex = 0;
            this.lbCHEntry.Text = "Szénhidrát";
            // 
            // lbgrammCH
            // 
            this.lbgrammCH.AutoSize = true;
            this.lbgrammCH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgrammCH.Location = new System.Drawing.Point(223, 36);
            this.lbgrammCH.Name = "lbgrammCH";
            this.lbgrammCH.Size = new System.Drawing.Size(55, 15);
            this.lbgrammCH.TabIndex = 1;
            this.lbgrammCH.Text = "Gramm";
            // 
            // btStartCh1
            // 
            this.btStartCh1.BackColor = System.Drawing.Color.LimeGreen;
            this.btStartCh1.Location = new System.Drawing.Point(364, 43);
            this.btStartCh1.Name = "btStartCh1";
            this.btStartCh1.Size = new System.Drawing.Size(75, 50);
            this.btStartCh1.TabIndex = 2;
            this.btStartCh1.Text = "Start";
            this.btStartCh1.UseVisualStyleBackColor = false;
            this.btStartCh1.Click += new System.EventHandler(this.btStartCh1_Click);
            // 
            // gbCH
            // 
            this.gbCH.Controls.Add(this.tbRandomChgramm);
            this.gbCH.Controls.Add(this.tbRandomCh);
            this.gbCH.Controls.Add(this.label10CH);
            this.gbCH.Controls.Add(this.lbAdottCh);
            this.gbCH.Controls.Add(this.btStartCH2);
            this.gbCH.Location = new System.Drawing.Point(12, 224);
            this.gbCH.Name = "gbCH";
            this.gbCH.Size = new System.Drawing.Size(534, 149);
            this.gbCH.TabIndex = 3;
            this.gbCH.TabStop = false;
            // 
            // tbRandomChgramm
            // 
            this.tbRandomChgramm.Location = new System.Drawing.Point(139, 106);
            this.tbRandomChgramm.Name = "tbRandomChgramm";
            this.tbRandomChgramm.ReadOnly = true;
            this.tbRandomChgramm.Size = new System.Drawing.Size(91, 20);
            this.tbRandomChgramm.TabIndex = 9;
            // 
            // tbRandomCh
            // 
            this.tbRandomCh.Location = new System.Drawing.Point(139, 63);
            this.tbRandomCh.Name = "tbRandomCh";
            this.tbRandomCh.Size = new System.Drawing.Size(91, 20);
            this.tbRandomCh.TabIndex = 10;
            this.tbRandomCh.TextChanged += new System.EventHandler(this.tbRandomCh_TextChanged);
            this.tbRandomCh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRandomCh_KeyPress);
            // 
            // label10CH
            // 
            this.label10CH.AutoSize = true;
            this.label10CH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10CH.Location = new System.Drawing.Point(11, 111);
            this.label10CH.Name = "label10CH";
            this.label10CH.Size = new System.Drawing.Size(85, 15);
            this.label10CH.TabIndex = 2;
            this.label10CH.Text = "Szénhidrát :";
            // 
            // lbAdottCh
            // 
            this.lbAdottCh.AutoSize = true;
            this.lbAdottCh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdottCh.Location = new System.Drawing.Point(6, 63);
            this.lbAdottCh.Name = "lbAdottCh";
            this.lbAdottCh.Size = new System.Drawing.Size(122, 15);
            this.lbAdottCh.TabIndex = 1;
            this.lbAdottCh.Text = "Adott mennyiség: ";
            // 
            // btStartCH2
            // 
            this.btStartCH2.BackColor = System.Drawing.Color.LimeGreen;
            this.btStartCH2.Location = new System.Drawing.Point(295, 74);
            this.btStartCH2.Name = "btStartCH2";
            this.btStartCH2.Size = new System.Drawing.Size(92, 52);
            this.btStartCH2.TabIndex = 0;
            this.btStartCH2.Text = "Start";
            this.btStartCH2.UseVisualStyleBackColor = false;
            this.btStartCH2.Click += new System.EventHandler(this.btStartCH2_Click);
            // 
            // lb1ch
            // 
            this.lb1ch.AutoSize = true;
            this.lb1ch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1ch.Location = new System.Drawing.Point(44, 130);
            this.lb1ch.Name = "lb1ch";
            this.lb1ch.Size = new System.Drawing.Size(64, 15);
            this.lb1ch.TabIndex = 0;
            this.lb1ch.Text = "1 gramm";
            // 
            // lb100ch
            // 
            this.lb100ch.AutoSize = true;
            this.lb100ch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb100ch.Location = new System.Drawing.Point(380, 130);
            this.lb100ch.Name = "lb100ch";
            this.lb100ch.Size = new System.Drawing.Size(80, 15);
            this.lb100ch.TabIndex = 1;
            this.lb100ch.Text = "100 gramm";
            // 
            // lb10ch
            // 
            this.lb10ch.AutoSize = true;
            this.lb10ch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10ch.Location = new System.Drawing.Point(206, 148);
            this.lb10ch.Name = "lb10ch";
            this.lb10ch.Size = new System.Drawing.Size(72, 15);
            this.lb10ch.TabIndex = 2;
            this.lb10ch.Text = "10 gramm";
            // 
            // tbCaloriaCH
            // 
            this.tbCaloriaCH.Location = new System.Drawing.Point(21, 73);
            this.tbCaloriaCH.Name = "tbCaloriaCH";
            this.tbCaloriaCH.Size = new System.Drawing.Size(100, 20);
            this.tbCaloriaCH.TabIndex = 4;
            this.tbCaloriaCH.TextChanged += new System.EventHandler(this.tbCh_TextChanged);
            this.tbCaloriaCH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCaloriaCH_KeyPress);
            // 
            // tbGrammCh
            // 
            this.tbGrammCh.Location = new System.Drawing.Point(199, 73);
            this.tbGrammCh.Name = "tbGrammCh";
            this.tbGrammCh.Size = new System.Drawing.Size(100, 20);
            this.tbGrammCh.TabIndex = 5;
            this.tbGrammCh.TextChanged += new System.EventHandler(this.tbGrammCh_TextChanged);
            this.tbGrammCh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrammCh_KeyPress);
            // 
            // tb10gCH
            // 
            this.tb10gCH.Location = new System.Drawing.Point(192, 182);
            this.tb10gCH.Name = "tb10gCH";
            this.tb10gCH.ReadOnly = true;
            this.tb10gCH.Size = new System.Drawing.Size(107, 20);
            this.tb10gCH.TabIndex = 6;
            // 
            // tb100gCh
            // 
            this.tb100gCh.Location = new System.Drawing.Point(364, 182);
            this.tb100gCh.Name = "tb100gCh";
            this.tb100gCh.ReadOnly = true;
            this.tb100gCh.Size = new System.Drawing.Size(100, 20);
            this.tb100gCh.TabIndex = 7;
            // 
            // tb1gCH
            // 
            this.tb1gCH.Location = new System.Drawing.Point(21, 182);
            this.tb1gCH.Name = "tb1gCH";
            this.tb1gCH.ReadOnly = true;
            this.tb1gCH.Size = new System.Drawing.Size(100, 20);
            this.tb1gCH.TabIndex = 8;
            // 
            // btResetCh
            // 
            this.btResetCh.BackColor = System.Drawing.Color.Coral;
            this.btResetCh.Location = new System.Drawing.Point(0, -1);
            this.btResetCh.Name = "btResetCh";
            this.btResetCh.Size = new System.Drawing.Size(75, 23);
            this.btResetCh.TabIndex = 9;
            this.btResetCh.Text = "Reset";
            this.btResetCh.UseVisualStyleBackColor = false;
            this.btResetCh.Click += new System.EventHandler(this.btResetCh_Click);
            // 
            // CHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 385);
            this.Controls.Add(this.btResetCh);
            this.Controls.Add(this.tb1gCH);
            this.Controls.Add(this.tb100gCh);
            this.Controls.Add(this.tb10gCH);
            this.Controls.Add(this.tbGrammCh);
            this.Controls.Add(this.tbCaloriaCH);
            this.Controls.Add(this.lb100ch);
            this.Controls.Add(this.lb10ch);
            this.Controls.Add(this.gbCH);
            this.Controls.Add(this.btStartCh1);
            this.Controls.Add(this.lb1ch);
            this.Controls.Add(this.lbgrammCH);
            this.Controls.Add(this.lbCHEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CHForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szénhidrát kalkulátor";
            this.gbCH.ResumeLayout(false);
            this.gbCH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCHEntry;
        private System.Windows.Forms.Label lbgrammCH;
        private System.Windows.Forms.Button btStartCh1;
        private System.Windows.Forms.GroupBox gbCH;
        private System.Windows.Forms.Label label10CH;
        private System.Windows.Forms.Label lbAdottCh;
        private System.Windows.Forms.Button btStartCH2;
        private System.Windows.Forms.Label lb1ch;
        private System.Windows.Forms.Label lb100ch;
        private System.Windows.Forms.Label lb10ch;
        private System.Windows.Forms.TextBox tbCaloriaCH;
        private System.Windows.Forms.TextBox tbRandomChgramm;
        private System.Windows.Forms.TextBox tbRandomCh;
        private System.Windows.Forms.TextBox tbGrammCh;
        private System.Windows.Forms.TextBox tb10gCH;
        private System.Windows.Forms.TextBox tb100gCh;
        private System.Windows.Forms.TextBox tb1gCH;
        private System.Windows.Forms.Button btResetCh;
    }
}