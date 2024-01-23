using System.Diagnostics;
namespace T15_Sekkari
{
    public partial class SekkariFM : Form
    {
        private Stopwatch sekkari = new Stopwatch();    

        public SekkariFM()
        {
            InitializeComponent();
        }

        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void PysaytaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void NollaaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            KelloLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}