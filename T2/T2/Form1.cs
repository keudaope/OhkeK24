namespace T2
{
    public partial class H2FM : Form
    {
        public H2FM()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            TulostusLB.Text = ViestiTB.Text;
            TulostusLB.Visible= true;
        }
    }
}