namespace T12
{
    partial class KymmenenFM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DRB = new System.Windows.Forms.RadioButton();
            this.CRB = new System.Windows.Forms.RadioButton();
            this.BRB = new System.Windows.Forms.RadioButton();
            this.ARB = new System.Windows.Forms.RadioButton();
            this.NollaRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(17, 27);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(90, 30);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Kysymys";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(17, 215);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(83, 30);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DRB);
            this.groupBox1.Controls.Add(this.CRB);
            this.groupBox1.Controls.Add(this.BRB);
            this.groupBox1.Controls.Add(this.ARB);
            this.groupBox1.Controls.Add(this.NollaRB);
            this.groupBox1.Location = new System.Drawing.Point(337, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            // 
            // DRB
            // 
            this.DRB.AutoSize = true;
            this.DRB.Location = new System.Drawing.Point(10, 169);
            this.DRB.Name = "DRB";
            this.DRB.Size = new System.Drawing.Size(46, 34);
            this.DRB.TabIndex = 4;
            this.DRB.TabStop = true;
            this.DRB.Text = "D";
            this.DRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            this.CRB.AutoSize = true;
            this.CRB.Location = new System.Drawing.Point(10, 124);
            this.CRB.Name = "CRB";
            this.CRB.Size = new System.Drawing.Size(44, 34);
            this.CRB.TabIndex = 3;
            this.CRB.TabStop = true;
            this.CRB.Text = "C";
            this.CRB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            this.BRB.AutoSize = true;
            this.BRB.Location = new System.Drawing.Point(10, 79);
            this.BRB.Name = "BRB";
            this.BRB.Size = new System.Drawing.Size(43, 34);
            this.BRB.TabIndex = 2;
            this.BRB.TabStop = true;
            this.BRB.Text = "B";
            this.BRB.UseVisualStyleBackColor = true;
            // 
            // ARB
            // 
            this.ARB.AutoSize = true;
            this.ARB.Location = new System.Drawing.Point(10, 34);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(45, 34);
            this.ARB.TabIndex = 1;
            this.ARB.TabStop = true;
            this.ARB.Text = "A";
            this.ARB.UseVisualStyleBackColor = true;
            // 
            // NollaRB
            // 
            this.NollaRB.AutoCheck = false;
            this.NollaRB.AutoSize = true;
            this.NollaRB.Location = new System.Drawing.Point(10, 45);
            this.NollaRB.Name = "NollaRB";
            this.NollaRB.Size = new System.Drawing.Size(14, 13);
            this.NollaRB.TabIndex = 0;
            this.NollaRB.TabStop = true;
            this.NollaRB.UseVisualStyleBackColor = true;
            this.NollaRB.Visible = false;
            // 
            // KymmenenFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "KymmenenFM";
            this.Text = "10 kysymystä";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox groupBox1;
        private RadioButton DRB;
        private RadioButton CRB;
        private RadioButton BRB;
        private RadioButton ARB;
        private RadioButton NollaRB;
    }
}