using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace ApiCsharp
{
    public partial class ApiForm : Form
    {
        public ApiForm()
        {
            InitializeComponent();
        }

        private void HaeBT_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            HttpResponseMessage response = client.GetAsync("users").Result;
            var kayttajat = response.Content.ReadAsAsync<IEnumerable<Kayttajat>>().Result;    
            TiedotDGV.DataSource = kayttajat;
            TiedotDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
