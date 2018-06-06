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
    public partial class logowanie : Form
    {
        BDConnect connectionWithDatabase;
        public logowanie()
        {
            InitializeComponent();
        }

        private void logowanie_button_Click(object sender, EventArgs e)
        {
            connectionWithDatabase = new BDConnect();
            if (connectionWithDatabase.isConnected())
            {
                this.Hide();
                MessageBox.Show("Poprawnie połączono z bazą danych.", "Informacja");
                menu form = new menu();
                form.ShowDialog();
                connectionWithDatabase.CloseConnection();
                this.Close();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Błąd połączenia z bazą danych.", "Informacja");
            }
        }
    }
}
