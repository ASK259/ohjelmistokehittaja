namespace Harjoitus_2
{
    public partial class Harjoitus2 : Form
    {
        public Harjoitus2()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string te = ViestiTB.Text;
            TulostusLB.Text = te;
            TulostusLB.Visible = true;
        }
    }
}