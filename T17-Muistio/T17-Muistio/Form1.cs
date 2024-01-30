using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace T17_Muistio
{
    public partial class MuistioFM : Form
    {
        string tiedostoPolku = "";
        public MuistioFM()
        {
            InitializeComponent();
            // Määritetään tiedostopolku ja RichTextBox tyhjiksi
            // Ei paras ratkaisu, sillä ei tarkista, onko tiedosto jo tallennettu
            tiedostoPolku = "";
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string teksti = rikasTB.Text;
            if(teksti.Length > 0)
            {
                tallennaToolStripMenuItem_Click(sender, e);
                rikasTB= null;
            }
            else
            {
                rikasTB= null;
            }
            
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

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Voimme kopioida koodin yltä
            using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "Tekstidokumentti|*.txt|Rikastekstiformaatti|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter vk = new StreamWriter(ttk.FileName))
                    {
                        vk.WriteLineAsync(rikasTB.Rtf);
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
            printPreviewDialog1.Document = printDocument1;
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rikasTB.Text, rikasTB.Font, Brushes.Black, 12, 10);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rikasTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void rikasTB_TextChanged(object sender, EventArgs e)
        {
            if(rikasTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled= true;
                leikkaaToolStripMenuItem.Enabled= true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked)
            {
                tekstinRivitysToolStripMenuItem.Checked= false;
                rikasTB.WordWrap= false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                rikasTB.WordWrap = true;
            }
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectionBackColor = Color.Yellow;
        }
    }
}