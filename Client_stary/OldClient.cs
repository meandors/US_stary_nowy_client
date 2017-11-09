using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_stary.ClientServiceReference;

namespace Client_stary
{
    public partial class Client_stary : Form
    {
        public Client_stary()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UslugaClient client = new UslugaClient();

            try
            {
                client.Open();
                
                //TODO  ?????
                Client person = client.GetClients();

                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }
    }
}
