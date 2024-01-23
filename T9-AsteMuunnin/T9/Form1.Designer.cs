namespace T9
{
    partial class AsteFM
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.ValintaGB = new System.Windows.Forms.GroupBox();
            this.FahRB = new System.Windows.Forms.RadioButton();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.ValintaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(14, 67);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(135, 30);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Anna asteet: ";
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(144, 67);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(100, 35);
            this.AsteetTB.TabIndex = 1;
            // 
            // ValintaGB
            // 
            this.ValintaGB.Controls.Add(this.FahRB);
            this.ValintaGB.Controls.Add(this.CelsiusRB);
            this.ValintaGB.Location = new System.Drawing.Point(250, 12);
            this.ValintaGB.Name = "ValintaGB";
            this.ValintaGB.Size = new System.Drawing.Size(200, 117);
            this.ValintaGB.TabIndex = 2;
            this.ValintaGB.TabStop = false;
            this.ValintaGB.Text = "Miten muunnat?";
            // 
            // FahRB
            // 
            this.FahRB.AutoSize = true;
            this.FahRB.Location = new System.Drawing.Point(14, 78);
            this.FahRB.Name = "FahRB";
            this.FahRB.Size = new System.Drawing.Size(128, 34);
            this.FahRB.TabIndex = 1;
            this.FahRB.TabStop = true;
            this.FahRB.Text = "Fahrenheit";
            this.FahRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(14, 38);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(95, 34);
            this.CelsiusRB.TabIndex = 0;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            this.CelsiusRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(467, 67);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(106, 47);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(14, 147);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(83, 30);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // AsteFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 200);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.ValintaGB);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AsteFM";
            this.Text = "Astemuunnin";
            this.ValintaGB.ResumeLayout(false);
            this.ValintaGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private TextBox AsteetTB;
        private GroupBox ValintaGB;
        private RadioButton CelsiusRB;
        private RadioButton FahRB;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}