namespace T7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = double.Parse(LainaTB.Text);
            nesteet = double.Parse(NesteetTB.Text);
            pesut = double.Parse(PesutTB.Text);
            huollot = double.Parse(HuollotTB.Text);
            renkaat = double.Parse(RenkaatTB.Text);
            muut = double.Parse(MuutTB.Text);
            kilometrit = double.Parse(KilometritCB.Text);
            energia = double.Parse(PolttoaineTB.Text);
            kustannukset = laina + nesteet + pesut + huollot + renkaat + muut + energia;
            kustannukset = kustannukset / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti on " + kustannukset.ToString();
            VastausLB.Visible= true;
        }
    }
}