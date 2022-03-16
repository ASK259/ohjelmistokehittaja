namespace Laskin
{
    public partial class Nelilaskin : Form
    {
        public Nelilaskin()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {   alku:
            float lu1, lu2;
            float va = 0;
            string de = "";
            string me = LaskutoimitusCB.Text;
            try
            {
                lu1 = float.Parse(LukuYksiTB.Text);
                lu2 = float.Parse(LukuKaksiTB.Text);
            }
            catch (Exception ex)
            {
                VastausLB.Text = Convert.ToString("Syötä luku.");
                VastausLB.Visible = true;
                goto alku;
            }
            switch (me)
            {
                case "+":
                    va = lu1 + lu2;
                    break;
                case "-":
                    va = lu1 - lu2;
                    break;
                case "*":
                    va = lu1 * lu2;
                    break;
                case "/":
                    va = lu1 / lu2;
                    break;
                default:
                    de = "Odottamaton virhe. Yritä uudestaan.";
                    VastausLB.Text = de;
                    VastausLB.Visible = true;
                    break;
            }
            VastausLB.Text = Convert.ToString(va);
            VastausLB.Visible = true;
        }
    }
}