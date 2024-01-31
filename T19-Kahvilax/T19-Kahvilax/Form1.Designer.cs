namespace T19_Kahvilax
{
    partial class Form1
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
            vasenPL = new Panel();
            ylaPL = new Panel();
            meistaPL = new Panel();
            ruoatPL = new Panel();
            juomatPL = new Panel();
            herkutPL = new Panel();
            KoriPL = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            vasenPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // vasenPL
            // 
            vasenPL.BackColor = Color.FromArgb(62, 172, 64);
            vasenPL.Controls.Add(pictureBox1);
            vasenPL.Controls.Add(button1);
            vasenPL.Dock = DockStyle.Left;
            vasenPL.Location = new Point(0, 0);
            vasenPL.Name = "vasenPL";
            vasenPL.Size = new Size(135, 300);
            vasenPL.TabIndex = 0;
            // 
            // ylaPL
            // 
            ylaPL.BackColor = Color.FromArgb(255, 153, 2);
            ylaPL.Dock = DockStyle.Top;
            ylaPL.Location = new Point(135, 0);
            ylaPL.Name = "ylaPL";
            ylaPL.Size = new Size(515, 40);
            ylaPL.TabIndex = 1;
            // 
            // meistaPL
            // 
            meistaPL.Dock = DockStyle.Fill;
            meistaPL.Location = new Point(135, 40);
            meistaPL.Name = "meistaPL";
            meistaPL.Size = new Size(515, 260);
            meistaPL.TabIndex = 2;
            // 
            // ruoatPL
            // 
            ruoatPL.Dock = DockStyle.Fill;
            ruoatPL.Location = new Point(135, 40);
            ruoatPL.Name = "ruoatPL";
            ruoatPL.Size = new Size(515, 260);
            ruoatPL.TabIndex = 3;
            // 
            // juomatPL
            // 
            juomatPL.Dock = DockStyle.Fill;
            juomatPL.Location = new Point(135, 40);
            juomatPL.Name = "juomatPL";
            juomatPL.Size = new Size(515, 260);
            juomatPL.TabIndex = 4;
            // 
            // herkutPL
            // 
            herkutPL.Dock = DockStyle.Fill;
            herkutPL.Location = new Point(135, 40);
            herkutPL.Name = "herkutPL";
            herkutPL.Size = new Size(515, 260);
            herkutPL.TabIndex = 5;
            // 
            // KoriPL
            // 
            KoriPL.Dock = DockStyle.Fill;
            KoriPL.Location = new Point(135, 40);
            KoriPL.Name = "KoriPL";
            KoriPL.Size = new Size(515, 260);
            KoriPL.TabIndex = 6;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 40);
            button1.Name = "button1";
            button1.Size = new Size(135, 42);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.info;
            pictureBox1.Location = new Point(94, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(650, 300);
            Controls.Add(meistaPL);
            Controls.Add(ruoatPL);
            Controls.Add(juomatPL);
            Controls.Add(herkutPL);
            Controls.Add(KoriPL);
            Controls.Add(ylaPL);
            Controls.Add(vasenPL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            vasenPL.ResumeLayout(false);
            vasenPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel vasenPL;
        private Panel ylaPL;
        private Button button1;
        private Panel meistaPL;
        private Panel ruoatPL;
        private Panel juomatPL;
        private Panel herkutPL;
        private Panel KoriPL;
        private PictureBox pictureBox1;
    }
}