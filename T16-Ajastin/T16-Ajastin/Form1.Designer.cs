namespace T16_Ajastin
{
    partial class LaskuriFM
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
            this.MinuutitOtsikkoLB = new System.Windows.Forms.Label();
            this.SekunnitOtsikkoLB = new System.Windows.Forms.Label();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.AikaLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinuutitOtsikkoLB
            // 
            this.MinuutitOtsikkoLB.AutoSize = true;
            this.MinuutitOtsikkoLB.Location = new System.Drawing.Point(18, 17);
            this.MinuutitOtsikkoLB.Name = "MinuutitOtsikkoLB";
            this.MinuutitOtsikkoLB.Size = new System.Drawing.Size(97, 30);
            this.MinuutitOtsikkoLB.TabIndex = 0;
            this.MinuutitOtsikkoLB.Text = "Minuutit:";
            // 
            // SekunnitOtsikkoLB
            // 
            this.SekunnitOtsikkoLB.AutoSize = true;
            this.SekunnitOtsikkoLB.Location = new System.Drawing.Point(184, 17);
            this.SekunnitOtsikkoLB.Name = "SekunnitOtsikkoLB";
            this.SekunnitOtsikkoLB.Size = new System.Drawing.Size(98, 30);
            this.SekunnitOtsikkoLB.TabIndex = 1;
            this.SekunnitOtsikkoLB.Text = "Sekunnit:";
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(12, 57);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.Size = new System.Drawing.Size(121, 38);
            this.MinuutitCB.TabIndex = 2;
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(174, 57);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.Size = new System.Drawing.Size(121, 38);
            this.SekunnitCB.TabIndex = 3;
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(12, 108);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(283, 128);
            this.AikaLB.TabIndex = 4;
            this.AikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(20, 250);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(95, 44);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(190, 250);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(92, 44);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // LaskuriFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 309);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.SekunnitCB);
            this.Controls.Add(this.MinuutitCB);
            this.Controls.Add(this.SekunnitOtsikkoLB);
            this.Controls.Add(this.MinuutitOtsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LaskuriFM";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.LaskuriFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MinuutitOtsikkoLB;
        private Label SekunnitOtsikkoLB;
        private ComboBox MinuutitCB;
        private ComboBox SekunnitCB;
        private Label AikaLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}