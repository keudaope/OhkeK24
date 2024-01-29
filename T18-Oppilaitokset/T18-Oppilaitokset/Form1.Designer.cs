namespace T18_Oppilaitokset
{
    partial class OppilaitoksetFM
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
            OtsikkoLB = new Label();
            label1 = new Label();
            label2 = new Label();
            OppilaitosCB = new ComboBox();
            VastuuHloCB = new ComboBox();
            OppilaitosOsoiteLB = new Label();
            OppilaitosPnroLB = new Label();
            OppilaitosPtpLB = new Label();
            OppilaitosPuhLB = new Label();
            VastuuhloPuhLB = new Label();
            SahkopostiLB = new Label();
            OsastoLB = new Label();
            VastuutitteliLB = new Label();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(64, 9);
            OtsikkoLB.Margin = new Padding(5, 0, 5, 0);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(443, 47);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 86);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 1;
            label1.Text = "Valitse oppilaitos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 86);
            label2.Name = "label2";
            label2.Size = new Size(211, 30);
            label2.TabIndex = 2;
            label2.Text = "Valitse vastuuhenkilö:";
            // 
            // OppilaitosCB
            // 
            OppilaitosCB.FormattingEnabled = true;
            OppilaitosCB.Location = new Point(25, 133);
            OppilaitosCB.Name = "OppilaitosCB";
            OppilaitosCB.Size = new Size(173, 38);
            OppilaitosCB.TabIndex = 3;
            OppilaitosCB.SelectedIndexChanged += OppilaitosCB_SelectedIndexChanged;
            // 
            // VastuuHloCB
            // 
            VastuuHloCB.FormattingEnabled = true;
            VastuuHloCB.Location = new Point(320, 133);
            VastuuHloCB.Name = "VastuuHloCB";
            VastuuHloCB.Size = new Size(211, 38);
            VastuuHloCB.TabIndex = 4;
            VastuuHloCB.SelectedIndexChanged += VastuuHloCB_SelectedIndexChanged;
            VastuuHloCB.TextChanged += VastuuHloCB_TextChanged;
            // 
            // OppilaitosOsoiteLB
            // 
            OppilaitosOsoiteLB.AutoSize = true;
            OppilaitosOsoiteLB.Location = new Point(25, 211);
            OppilaitosOsoiteLB.Name = "OppilaitosOsoiteLB";
            OppilaitosOsoiteLB.Size = new Size(68, 30);
            OppilaitosOsoiteLB.TabIndex = 5;
            OppilaitosOsoiteLB.Text = "label3";
            // 
            // OppilaitosPnroLB
            // 
            OppilaitosPnroLB.AutoSize = true;
            OppilaitosPnroLB.Location = new Point(25, 278);
            OppilaitosPnroLB.Name = "OppilaitosPnroLB";
            OppilaitosPnroLB.Size = new Size(68, 30);
            OppilaitosPnroLB.TabIndex = 6;
            OppilaitosPnroLB.Text = "label4";
            // 
            // OppilaitosPtpLB
            // 
            OppilaitosPtpLB.AutoSize = true;
            OppilaitosPtpLB.Location = new Point(25, 345);
            OppilaitosPtpLB.Name = "OppilaitosPtpLB";
            OppilaitosPtpLB.Size = new Size(68, 30);
            OppilaitosPtpLB.TabIndex = 7;
            OppilaitosPtpLB.Text = "label5";
            // 
            // OppilaitosPuhLB
            // 
            OppilaitosPuhLB.AutoSize = true;
            OppilaitosPuhLB.Location = new Point(25, 412);
            OppilaitosPuhLB.Name = "OppilaitosPuhLB";
            OppilaitosPuhLB.Size = new Size(68, 30);
            OppilaitosPuhLB.TabIndex = 8;
            OppilaitosPuhLB.Text = "label6";
            // 
            // VastuuhloPuhLB
            // 
            VastuuhloPuhLB.AutoSize = true;
            VastuuhloPuhLB.Location = new Point(320, 412);
            VastuuhloPuhLB.Name = "VastuuhloPuhLB";
            VastuuhloPuhLB.Size = new Size(68, 30);
            VastuuhloPuhLB.TabIndex = 12;
            VastuuhloPuhLB.Text = "label6";
            VastuuhloPuhLB.Visible = false;
            // 
            // SahkopostiLB
            // 
            SahkopostiLB.AutoSize = true;
            SahkopostiLB.Location = new Point(320, 345);
            SahkopostiLB.Name = "SahkopostiLB";
            SahkopostiLB.Size = new Size(68, 30);
            SahkopostiLB.TabIndex = 11;
            SahkopostiLB.Text = "label5";
            SahkopostiLB.Visible = false;
            // 
            // OsastoLB
            // 
            OsastoLB.AutoSize = true;
            OsastoLB.Location = new Point(320, 278);
            OsastoLB.Name = "OsastoLB";
            OsastoLB.Size = new Size(68, 30);
            OsastoLB.TabIndex = 10;
            OsastoLB.Text = "label4";
            OsastoLB.Visible = false;
            // 
            // VastuutitteliLB
            // 
            VastuutitteliLB.AutoSize = true;
            VastuutitteliLB.Location = new Point(320, 211);
            VastuutitteliLB.Name = "VastuutitteliLB";
            VastuutitteliLB.Size = new Size(68, 30);
            VastuutitteliLB.TabIndex = 9;
            VastuutitteliLB.Text = "label3";
            VastuutitteliLB.Visible = false;
            // 
            // OppilaitoksetFM
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 470);
            Controls.Add(VastuuhloPuhLB);
            Controls.Add(SahkopostiLB);
            Controls.Add(OsastoLB);
            Controls.Add(VastuutitteliLB);
            Controls.Add(OppilaitosPuhLB);
            Controls.Add(OppilaitosPtpLB);
            Controls.Add(OppilaitosPnroLB);
            Controls.Add(OppilaitosOsoiteLB);
            Controls.Add(VastuuHloCB);
            Controls.Add(OppilaitosCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OtsikkoLB);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "OppilaitoksetFM";
            Text = "Oppilaitosten avainhenkilöt";
            Load += OppilaitoksetFM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label label1;
        private Label label2;
        private ComboBox OppilaitosCB;
        private ComboBox VastuuHloCB;
        private Label OppilaitosOsoiteLB;
        private Label OppilaitosPnroLB;
        private Label OppilaitosPtpLB;
        private Label OppilaitosPuhLB;
        private Label VastuuhloPuhLB;
        private Label SahkopostiLB;
        private Label OsastoLB;
        private Label VastuutitteliLB;
    }
}