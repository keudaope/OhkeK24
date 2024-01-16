namespace T3
{
    public partial class LaskinFM : Form
    {
        public LaskinFM()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float luku1, luku2, tulos;
            luku1 = float.Parse(LukuYksiTB.Text);
            luku2 = float.Parse(LukuKaksiTB.Text);
            string merkki = LaskutoimitusCB.Text;
            switch(merkki)
            {
                case "+":
                    tulos = luku1 + luku2;
                    break;
                case "-":
                    tulos= luku1 - luku2;

            }
        }
    }
}