namespace T19_Kahvilax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            meistaPL.BringToFront();
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12:30. \n\nKeudan oppilaskunnan kahvilasta saa lämpimien \n";
            meistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan!";
            meistaLB.Font = new Font("Arial", 12);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void meistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.BringToFront();
        }

        private void ruoatBT_Click(object sender, EventArgs e)
        {
            ruoatPL.BringToFront();
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            juomatPL.BringToFront();
        }

        private void herkutBT_Click(object sender, EventArgs e)
        {
            herkutPL.BringToFront();
        }

        private void koriBT_Click(object sender, EventArgs e)
        {
            KoriPL.BringToFront();
        }
    }
}