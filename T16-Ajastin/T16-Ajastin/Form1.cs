using System.Diagnostics;
namespace T16_Ajastin
{
    public partial class LaskuriFM : Form
    {
        int kokonaisaika;
        public LaskuriFM()
        {
            InitializeComponent();
        }

        private void LaskuriFM_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for(int i = 0;  i <= 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString()); 
                SekunnitCB.Items.Add(i.ToString()); 
            }
            MinuutitCB.SelectedIndex = 0;
            SekunnitCB.SelectedIndex = 30;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(MinuutitCB.SelectedIndex.ToString());
            int sekunnit = int.Parse(SekunnitCB.SelectedIndex.ToString());
            kokonaisaika = minuutit * 60 + sekunnit;
            AjastinTM.Enabled = true;
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //}

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}