namespace T10
{
    public partial class BMIFM : Form
    {
        public BMIFM()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = double.Parse(painoTB.Text);
            pituus = double.Parse(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            MessageBox.Show(bmi + "");
            if (bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.Text = "Alipaino";
                VastausLB.Visible = true;
                tulosLB.Visible = true;
                VastausLB.ForeColor= Color.Aqua;
                tulosLB.ForeColor= Color.Aqua;
            }
            else if(bmi < 25)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.Text = "Normaalipaino";
                VastausLB.Visible = true;
                tulosLB.Visible = true;
                VastausLB.ForeColor = Color.Green;
                tulosLB.ForeColor = Color.Green;
            }
            else if(bmi < 40)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.Text = "Ylipaino";
                VastausLB.Visible = true;
                tulosLB.Visible = true;
                VastausLB.ForeColor = Color.Gold;
                tulosLB.ForeColor = Color.Gold;
            }
            else
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                tulosLB.Text = "Huomattava ylipaino";
                VastausLB.Visible = true;
                tulosLB.Visible = true;
                VastausLB.ForeColor = Color.Red;
                tulosLB.ForeColor = Color.Red;
            }
        }
    }
}