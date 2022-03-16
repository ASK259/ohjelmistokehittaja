namespace ikalaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime sy = vaPaDT.Value;
            DateTime nyt = DateTime.Now;
            double er = Math.Round((nyt - sy).TotalDays);
            VuLB.Text = Math.Ceiling(er / 365.25) + " Vuotta";
            KkLB.Text = Math.Ceiling(er * 12 / 365.25) + " Kuukautta";
            PaLB.Text = er + " P‰iv‰‰";
            TuLB.Text = (er * 24) + " Tuntia";
            MiLB.Text = (er * 24 * 60) + " Minuuttia";
            SeLB.Text = (er * 24 * 3600) + " Sekuntia";
            TuLB.Visible = true;
            MiLB.Visible = true;
            SeLB.Visible = true;
            PaLB.Visible = true;
            KkLB.Visible = true;
            VuLB.Visible = true;
        }
    }
}