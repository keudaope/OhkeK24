namespace T5
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void OtsikkoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter)
            {
                if(OtsikkoTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach(int jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible= true;
                }
                else
                {
                    jono.Add(Int32.Parse(OtsikkoTB.Text));
                    OtsikkoTB.Text = "";
                }
            }
            if(e.KeyChar== (char)Keys.Escape) {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            OtsikkoTB.Text = "";
        }
    }
}