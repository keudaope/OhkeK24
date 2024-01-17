namespace T8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            VastausLB.BackColor = System.Drawing.Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            if(MuutettavaTB.Text.Length > 3 ) {
                luku1 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                luku2 = int.Parse(MuutettavaTB.Text.Substring(1, 1));
                luku3 = int.Parse(MuutettavaTB.Text.Substring(2, 1));
                luku4 = int.Parse(MuutettavaTB.Text.Substring(3, 1));
                if(luku1 % 3 == 0 )
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if(luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else 
                { 
                    vastaus += ""; 
                }
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(MuutettavaTB.Text.Length > 2)
            {
                luku2 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                luku3 = int.Parse(MuutettavaTB.Text.Substring(1, 1));
                luku4 = int.Parse(MuutettavaTB.Text.Substring(2, 1));
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(MuutettavaTB.Text.Length > 1)
            {
                luku3 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                luku4 = int.Parse(MuutettavaTB.Text.Substring(1, 1));
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(MuutettavaTB.Text.Length > 0)
            {
                luku4 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                vastaus += ykkoset(luku4, vastaus);
            }
            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }
        private string sataset(int luku2, string vastaus)
        {
            if(luku2 % 9 == 0 && luku2 != 0)
            {
                return "CM";
            }
        }

    }
}
