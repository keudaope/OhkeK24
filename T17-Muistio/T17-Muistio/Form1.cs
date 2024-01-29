using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace T17_Muistio
{
    public partial class MuistioFM : Form
    {
        string tiedostoPolku;
        PrintPreviewDialog printPreviewDialog1;
        PrintDocument printDocument1;

        public MuistioFM()
        {
            InitializeComponent();
            // M‰‰ritet‰‰n tiedostopolku ja RichTextBox tyhjiksi
            // Ei paras ratkaisu, sill‰ ei tarkista, onko tiedosto jo tallennettu
            tiedostoPolku = "";
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Koodi txt-tiedoston avaamiseen
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostoPolku))
                {
                    vk.WriteLineAsync(rikasTB.Rtf);
                }
            }
        }

        private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Voimme kopioida koodin ylt‰
            using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "Tekstidokumentti|*.txt|Rikastekstiformaatti|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter vk = new StreamWriter(ttk.FileName))
                    {
                        vk.WriteLineAsync(rikasTB.Text);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}