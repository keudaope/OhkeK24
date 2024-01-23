namespace T8
{
    public partial class RoomalaisetFM : Form
    {
        public RoomalaisetFM()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            VastausLB.BackColor = System.Drawing.Color.Transparent;
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            string[] tonnit = new string[] {"", "M", "MM", "MMM" };
            string[] sataset = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] kympit = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ykkoset = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            if (MuutettavaTB.Text.Length > 3)
            {
                luku4 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                luku3 = int.Parse(MuutettavaTB.Text.Substring(1, 1));
                luku2 = int.Parse(MuutettavaTB.Text.Substring(2, 1));
                luku1 = int.Parse(MuutettavaTB.Text.Substring(3, 1));
                if (luku4 > 0)
                {
                    vastaus += tonnit[luku4];
                }
                if(luku3 > 0)
                {
                    vastaus += sataset[luku3];
                }
                if (luku2 > 0)
                {
                    vastaus += kympit[luku2];
                }
                if(luku1 > 0)
                {
                    vastaus += ykkoset[luku1];
                }
            }
            else if(MuutettavaTB.Text.Length > 2)
            {
                luku3 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                luku2 = int.Parse(MuutettavaTB.Text.Substring(1, 1));
                luku1 = int.Parse(MuutettavaTB.Text.Substring(2, 1));
                if (luku3 > 0)
                {
                    vastaus += sataset[luku3];     
                }
                if (luku2 > 0)
                {
                    vastaus += kympit[luku2];
                }
                if (luku1 > 0)
                {
                    vastaus += ykkoset[luku1];
                }
            }
            else if (MuutettavaTB.Text.Length > 1)
            {
                luku2 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                luku1 = int.Parse(MuutettavaTB.Text.Substring(1, 1));
                if (luku2 > 0)
                {
                    vastaus += kympit[luku2];
                }
                if (luku1 > 0)
                {
                    vastaus += ykkoset[luku1];
                }
            }
            else if (MuutettavaTB.Text.Length > 0)
            {
                luku1 = int.Parse(MuutettavaTB.Text.Substring(0, 1));
                if (luku1 > 0)
                {
                    vastaus += ykkoset[luku1];
                }
            }
            VastausLB.Text = vastaus;
            VastausLB.Visible= true;
        }
    }
}