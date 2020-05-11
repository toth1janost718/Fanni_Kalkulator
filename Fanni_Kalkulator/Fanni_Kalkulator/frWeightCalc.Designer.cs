namespace Fanni_Kalkulator
{
    partial class frWeightCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frWeightCalc));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbweigth = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbGramm = new System.Windows.Forms.TextBox();
            this.lbKg = new System.Windows.Forms.Label();
            this.lbdkg = new System.Windows.Forms.Label();
            this.lbgramm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mennyiség : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Súlymérték";
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Green;
            this.btnResult.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(152, 128);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(95, 40);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Átvált";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(44, 212);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(75, 20);
            this.tbResult.TabIndex = 7;
            // 
            // tbweigth
            // 
            this.tbweigth.Location = new System.Drawing.Point(165, 212);
            this.tbweigth.Name = "tbweigth";
            this.tbweigth.ReadOnly = true;
            this.tbweigth.Size = new System.Drawing.Size(64, 20);
            this.tbweigth.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kg",
            "dkg",
            "gramm"});
            this.comboBox1.Location = new System.Drawing.Point(270, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbGramm
            // 
            this.tbGramm.Location = new System.Drawing.Point(281, 212);
            this.tbGramm.Name = "tbGramm";
            this.tbGramm.ReadOnly = true;
            this.tbGramm.Size = new System.Drawing.Size(63, 20);
            this.tbGramm.TabIndex = 10;
            // 
            // lbKg
            // 
            this.lbKg.AutoSize = true;
            this.lbKg.Location = new System.Drawing.Point(125, 215);
            this.lbKg.Name = "lbKg";
            this.lbKg.Size = new System.Drawing.Size(19, 13);
            this.lbKg.TabIndex = 11;
            this.lbKg.Text = "kg";
            // 
            // lbdkg
            // 
            this.lbdkg.AutoSize = true;
            this.lbdkg.Location = new System.Drawing.Point(235, 215);
            this.lbdkg.Name = "lbdkg";
            this.lbdkg.Size = new System.Drawing.Size(28, 13);
            this.lbdkg.TabIndex = 12;
            this.lbdkg.Text = "dkg.";
            // 
            // lbgramm
            // 
            this.lbgramm.AutoSize = true;
            this.lbgramm.Location = new System.Drawing.Point(350, 219);
            this.lbgramm.Name = "lbgramm";
            this.lbgramm.Size = new System.Drawing.Size(38, 13);
            this.lbgramm.TabIndex = 13;
            this.lbgramm.Text = "gramm";
            // 
            // frWeightCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(419, 306);
            this.Controls.Add(this.lbgramm);
            this.Controls.Add(this.lbdkg);
            this.Controls.Add(this.lbKg);
            this.Controls.Add(this.tbGramm);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbweigth);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frWeightCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SúlyKalkulátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbweigth;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbGramm;
        private System.Windows.Forms.Label lbKg;
        private System.Windows.Forms.Label lbdkg;
        private System.Windows.Forms.Label lbgramm;
    }
}