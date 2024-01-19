namespace T8
{
<<<<<<< HEAD
    partial class NumeromuunnosFM
=======
    partial class Form1
>>>>>>> 32f68f07ebb9734c80efaf1553139e3a984723b8
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
<<<<<<< HEAD
            this.SuspendLayout();
            // 
            // NumeromuunnosFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "NumeromuunnosFM";
            this.Text = "Form1";
            this.ResumeLayout(false);
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MuutettavaTB = new System.Windows.Forms.TextBox();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(141, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(759, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi: ";
            // 
            // MuutettavaTB
            // 
            this.MuutettavaTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuutettavaTB.Location = new System.Drawing.Point(910, 560);
            this.MuutettavaTB.Name = "MuutettavaTB";
            this.MuutettavaTB.Size = new System.Drawing.Size(100, 35);
            this.MuutettavaTB.TabIndex = 2;
            // 
            // MuutaBT
            // 
            this.MuutaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuutaBT.Location = new System.Drawing.Point(909, 601);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(101, 43);
            this.MuutaBT.TabIndex = 3;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.ForeColor = System.Drawing.Color.Gold;
            this.VastausLB.Location = new System.Drawing.Point(141, 611);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(103, 27);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1094, 666);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.MuutettavaTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Latinalaisten numeroiden muunto roomalaisiksi";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> 32f68f07ebb9734c80efaf1553139e3a984723b8

        }

        #endregion
<<<<<<< HEAD
=======

        private Label label1;
        private Label label2;
        private TextBox MuutettavaTB;
        private Button MuutaBT;
        private Label VastausLB;
>>>>>>> 32f68f07ebb9734c80efaf1553139e3a984723b8
    }
}