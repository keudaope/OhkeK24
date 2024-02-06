using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T20_CRUD
{
    public partial class Form1 : Form
    {
        Opiskelija opiskelija = new Opiskelija();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            this.TietotauluDG.DefaultCellStyle.Font = new Font("Tahoma", 15);
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puh = PuhelinTB.Text;
            String email = EmailTB.Text;
            int onro = Int32.Parse(OpiskelijanumeroTB.Text);
            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - vaaditut kentät: etunimi, sukunimi, puhelin, sähköposti, opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaOpiskelija = opiskelija.lisaaOpiskelija(enimi, snimi, puh, email, onro); ;
                if(lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IDTB.Text = string.Empty;
            EtunimiTB.Text = string.Empty;
            SukunimiTB.Text= string.Empty;
            PuhelinTB.Text = string.Empty;
            EmailTB.Text = string.Empty;
            OpiskelijanumeroTB.Text = string.Empty;
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puh = PuhelinTB.Text;
            String email = EmailTB.Text;
            int onro = Int32.Parse(OpiskelijanumeroTB.Text);
            int oid = Int32.Parse(IDTB.Text);
            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - vaaditut kentät: ID, etunimi, sukunimi, puhelin, sähköposti, opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaOpiskelijaa = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puh, email, onro);
                if(muokkaaOpiskelijaa)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString(); 
            PuhelinTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            EmailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            OpiskelijanumeroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IDTB.Text;
            if(opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }
    }
}
