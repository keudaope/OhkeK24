namespace T10
{
    partial class BMIFM
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
            this.PainoLB = new System.Windows.Forms.Label();
            this.PituusLB = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.laskeBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.tulosLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainoLB
            // 
            this.PainoLB.AutoSize = true;
            this.PainoLB.Location = new System.Drawing.Point(20, 29);
            this.PainoLB.Name = "PainoLB";
            this.PainoLB.Size = new System.Drawing.Size(131, 30);
            this.PainoLB.TabIndex = 0;
            this.PainoLB.Text = "Anna paino: ";
            // 
            // PituusLB
            // 
            this.PituusLB.AutoSize = true;
            this.PituusLB.Location = new System.Drawing.Point(20, 79);
            this.PituusLB.Name = "PituusLB";
            this.PituusLB.Size = new System.Drawing.Size(136, 30);
            this.PituusLB.TabIndex = 1;
            this.PituusLB.Text = "Anna pituus: ";
            // 
            // painoTB
            // 
            this.painoTB.Location = new System.Drawing.Point(157, 29);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 35);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Location = new System.Drawing.Point(157, 79);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 35);
            this.pituusTB.TabIndex = 3;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(22, 127);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(235, 39);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske painoindeksi";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(22, 169);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(83, 30);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // tulosLB
            // 
            this.tulosLB.AutoSize = true;
            this.tulosLB.Location = new System.Drawing.Point(20, 214);
            this.tulosLB.Name = "tulosLB";
            this.tulosLB.Size = new System.Drawing.Size(94, 30);
            this.tulosLB.TabIndex = 6;
            this.tulosLB.Text = "Vastaus2";
            this.tulosLB.Visible = false;
            // 
            // BMIFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 249);
            this.Controls.Add(this.tulosLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.PituusLB);
            this.Controls.Add(this.PainoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BMIFM";
            this.Text = "BMI-laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PainoLB;
        private Label PituusLB;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button laskeBT;
        private Label VastausLB;
        private Label tulosLB;
    }
}