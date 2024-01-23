namespace T6
{
    partial class SalasanaFM
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
            this.SalasanaOikeinPL = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SalasanaPL = new System.Windows.Forms.Panel();
            this.VirheViestiLB = new System.Windows.Forms.Label();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaOikeinPL.SuspendLayout();
            this.SalasanaPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaOikeinPL
            // 
            this.SalasanaOikeinPL.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPL.Controls.Add(this.label3);
            this.SalasanaOikeinPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPL.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPL.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPL.Name = "SalasanaOikeinPL";
            this.SalasanaOikeinPL.Size = new System.Drawing.Size(584, 195);
            this.SalasanaOikeinPL.TabIndex = 0;
            this.SalasanaOikeinPL.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaPL
            // 
            this.SalasanaPL.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPL.Controls.Add(this.VirheViestiLB);
            this.SalasanaPL.Controls.Add(this.TarkistaBT);
            this.SalasanaPL.Controls.Add(this.SalasanaTB);
            this.SalasanaPL.Controls.Add(this.KayttajaTB);
            this.SalasanaPL.Controls.Add(this.label2);
            this.SalasanaPL.Controls.Add(this.label1);
            this.SalasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaPL.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPL.Name = "SalasanaPL";
            this.SalasanaPL.Size = new System.Drawing.Size(584, 195);
            this.SalasanaPL.TabIndex = 1;
            // 
            // VirheViestiLB
            // 
            this.VirheViestiLB.AutoSize = true;
            this.VirheViestiLB.Location = new System.Drawing.Point(25, 142);
            this.VirheViestiLB.Name = "VirheViestiLB";
            this.VirheViestiLB.Size = new System.Drawing.Size(67, 32);
            this.VirheViestiLB.TabIndex = 5;
            this.VirheViestiLB.Text = "virhe";
            this.VirheViestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TarkistaBT.Location = new System.Drawing.Point(3, 69);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(87, 42);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(217, 79);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.PasswordChar = '*';
            this.SalasanaTB.Size = new System.Drawing.Size(342, 39);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(217, 17);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(342, 39);
            this.KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 195);
            this.Controls.Add(this.SalasanaPL);
            this.Controls.Add(this.SalasanaOikeinPL);
            this.Name = "SalasanaFM";
            this.Text = "Salasanan tarkastus";
            this.SalasanaOikeinPL.ResumeLayout(false);
            this.SalasanaOikeinPL.PerformLayout();
            this.SalasanaPL.ResumeLayout(false);
            this.SalasanaPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalasanaOikeinPL;
        private Panel SalasanaPL;
        private Label VirheViestiLB;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}