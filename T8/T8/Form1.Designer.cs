namespace T8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            MuutettavaTB = new TextBox();
            MuutaBT = new Button();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(203, 24);
            label1.Name = "label1";
            label1.Size = new Size(644, 86);
            label1.TabIndex = 0;
            label1.Text = "Roomalaiset numerot";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(141, 563);
            label2.Name = "label2";
            label2.Size = new Size(759, 27);
            label2.TabIndex = 1;
            label2.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi: ";
            // 
            // MuutettavaTB
            // 
            MuutettavaTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MuutettavaTB.Location = new Point(910, 560);
            MuutettavaTB.Name = "MuutettavaTB";
            MuutettavaTB.Size = new Size(100, 35);
            MuutettavaTB.TabIndex = 2;
            // 
            // MuutaBT
            // 
            MuutaBT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MuutaBT.Location = new Point(909, 601);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(101, 43);
            MuutaBT.TabIndex = 3;
            MuutaBT.Text = "Muuta";
            MuutaBT.UseVisualStyleBackColor = true;
            MuutaBT.Click += button1_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Lucida Handwriting", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.ForeColor = Color.Gold;
            VastausLB.Location = new Point(141, 611);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(103, 27);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1094, 666);
            Controls.Add(VastausLB);
            Controls.Add(MuutaBT);
            Controls.Add(MuutettavaTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Latinalaisten numeroiden muunto roomalaisiksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox MuutettavaTB;
        private Button MuutaBT;
        private Label VastausLB;
    }
}