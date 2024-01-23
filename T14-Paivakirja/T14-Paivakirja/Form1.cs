using System.IO; 
namespace T14_Paivakirja
{
    public partial class DiaryFM : Form
    {
        public DiaryFM()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\temp\\demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.mm.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\temp\\demo.txt");
            text.WriteLine(teksti);
            text.Close();
            Application.Exit();
        }
    }
}