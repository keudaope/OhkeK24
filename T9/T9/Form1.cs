namespace T9
{
    public partial class AsteFM : Form
    {
        public AsteFM()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = double.Parse(AsteetTB.Text);
            if(CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
            }
            else
            {
                vastaus = (asteet - 32) / 1.8;
            }
            VastausLB.Text = vastaus + "";
            VastausLB.Visible = true;
        }
    }
}