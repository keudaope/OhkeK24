﻿namespace T3
{
    partial class LaskinFM
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
            this.LukuYksiTB = new System.Windows.Forms.TextBox();
            this.LukuKaksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuYksiTB
            // 
            this.LukuYksiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuYksiTB.Location = new System.Drawing.Point(48, 56);
            this.LukuYksiTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LukuYksiTB.Name = "LukuYksiTB";
            this.LukuYksiTB.Size = new System.Drawing.Size(169, 35);
            this.LukuYksiTB.TabIndex = 0;
            // 
            // LukuKaksiTB
            // 
            this.LukuKaksiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuKaksiTB.Location = new System.Drawing.Point(336, 56);
            this.LukuKaksiTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LukuKaksiTB.Name = "LukuKaksiTB";
            this.LukuKaksiTB.Size = new System.Drawing.Size(169, 35);
            this.LukuKaksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(228, 56);
            this.LaskutoimitusCB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(95, 38);
            this.LaskutoimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(546, 61);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(25, 30);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "X";
            this.VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(588, 54);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(101, 40);
            this.LaskeBT.TabIndex = 5;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // LaskinFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 139);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.LukuKaksiTB);
            this.Controls.Add(this.LukuYksiTB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LaskinFM";
            this.Text = "Yksinkertainen nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LukuYksiTB;
        private TextBox LukuKaksiTB;
        private ComboBox LaskutoimitusCB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}