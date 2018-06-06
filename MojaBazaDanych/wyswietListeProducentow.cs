using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaBazaDanych
{
    public partial class wyswietListeProducentow : Form
    {
        BDConnect connectionWithDatabase;
        public wyswietListeProducentow()
        {
            InitializeComponent();
            connectionWithDatabase = new BDConnect();

            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }

                connectionWithDatabase.searchForMaker(dataGridView1);
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd odświeżania tabeli. Brak połączenia z bazą danych. \r\n" + es.Message + "\r\n" + es.InnerException.Message);
            }
            finally
            {
                connectionWithDatabase.CloseConnection();
            }
        }

        private void odswiez_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }

                connectionWithDatabase.searchForMaker(dataGridView1);
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd odświeżania tabeli. Brak połączenia z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
            finally
            {
                connectionWithDatabase.CloseConnection();
            }
        }

        private void powrot_button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
