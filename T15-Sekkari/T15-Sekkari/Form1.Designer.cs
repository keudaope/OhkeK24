namespace T15_Sekkari
{
    partial class SekkariFM
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
            this.components = new System.ComponentModel.Container();
            this.KelloLB = new System.Windows.Forms.Label();
            this.KaynnistaBT = new System.Windows.Forms.Button();
            this.PysaytaBT = new System.Windows.Forms.Button();
            this.NollaaBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // KelloLB
            // 
            this.KelloLB.AutoSize = true;
            this.KelloLB.Font = new System.Drawing.Font("Segoe UI", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KelloLB.Location = new System.Drawing.Point(12, 18);
            this.KelloLB.Name = "KelloLB";
            this.KelloLB.Size = new System.Drawing.Size(562, 124);
            this.KelloLB.TabIndex = 0;
            this.KelloLB.Text = "00:00:00.000";
            // 
            // KaynnistaBT
            // 
            this.KaynnistaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KaynnistaBT.Location = new System.Drawing.Point(37, 163);
            this.KaynnistaBT.Name = "KaynnistaBT";
            this.KaynnistaBT.Size = new System.Drawing.Size(112, 38);
            this.KaynnistaBT.TabIndex = 1;
            this.KaynnistaBT.Text = "Käynnistä";
            this.KaynnistaBT.UseVisualStyleBackColor = true;
            this.KaynnistaBT.Click += new System.EventHandler(this.KaynnistaBT_Click);
            // 
            // PysaytaBT
            // 
            this.PysaytaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PysaytaBT.Location = new System.Drawing.Point(229, 163);
            this.PysaytaBT.Name = "PysaytaBT";
            this.PysaytaBT.Size = new System.Drawing.Size(112, 38);
            this.PysaytaBT.TabIndex = 2;
            this.PysaytaBT.Text = "Pysäytä";
            this.PysaytaBT.UseVisualStyleBackColor = true;
            this.PysaytaBT.Click += new System.EventHandler(this.PysaytaBT_Click);
            // 
            // NollaaBT
            // 
            this.NollaaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NollaaBT.Location = new System.Drawing.Point(426, 163);
            this.NollaaBT.Name = "NollaaBT";
            this.NollaaBT.Size = new System.Drawing.Size(112, 38);
            this.NollaaBT.TabIndex = 3;
            this.NollaaBT.Text = "Nollaa";
            this.NollaaBT.UseVisualStyleBackColor = true;
            this.NollaaBT.Click += new System.EventHandler(this.NollaaBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Enabled = true;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // SekkariFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 230);
            this.Controls.Add(this.NollaaBT);
            this.Controls.Add(this.PysaytaBT);
            this.Controls.Add(this.KaynnistaBT);
            this.Controls.Add(this.KelloLB);
            this.Name = "SekkariFM";
            this.Text = "Sekuntikello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KelloLB;
        private Button KaynnistaBT;
        private Button PysaytaBT;
        private Button NollaaBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}