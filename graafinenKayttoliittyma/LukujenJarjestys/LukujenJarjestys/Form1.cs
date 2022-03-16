using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
            alku:
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] arr = jono.ToArray();
                    Array.Sort(arr);
                    foreach (var a in arr)
                    {
                        VastausLB.Text += a + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    try
                    {
                        jono.Add(int.Parse(uusiLukuTB.Text));
                        uusiLukuTB.Text = "";
                    }
                    catch (Exception ex)
                    {
                        uusiLukuTB.Text = "";
                        goto alku;
                    }
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    }
}
