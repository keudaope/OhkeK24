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
        }   
    }
}
