namespace T6
{
    public partial class SalasanaFM : Form
    {
        public SalasanaFM()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kkoKu1ta")
            {
                SalasanaPL.Visible= false;
                SalasanaOikeinPL.Visible= true;
            }
            else
            {
                VirheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheViestiLB.Visible= true;
            }
        }
    }
}