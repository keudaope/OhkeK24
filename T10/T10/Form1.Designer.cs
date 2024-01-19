namespace T10
{
    partial class NoppaFM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(26, 19);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(221, 45);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Nopan heitto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NoppaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "NoppaFM";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private PictureBox pictureBox1;
    }
}