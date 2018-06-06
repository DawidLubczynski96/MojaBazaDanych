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
    public partial class menu : Form
    {
        BDConnect connectionWithDatabase;

        public menu()
        {
            InitializeComponent();
            connectionWithDatabase = new BDConnect();
        }

        private void wyswietl_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            wyswietListeProducentow form = new wyswietListeProducentow();
            form.ShowDialog();
            connectionWithDatabase.CloseConnection();
            this.Show();
        }

        private void wyswietl_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            wyswietListeProduktow form = new wyswietListeProduktow();
            form.ShowDialog();
            connectionWithDatabase.CloseConnection();
            this.Show();
        }

        private void edycja_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            edycjaProducenta form = new edycjaProducenta();
            form.ShowDialog();
            connectionWithDatabase.CloseConnection();
            this.Show();
        }

        private void edycja_button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            edycjaProduktu form = new edycjaProduktu();
            form.ShowDialog();
            connectionWithDatabase.CloseConnection();
            this.Show();
        }

        private void koniec_button_Click(object sender, EventArgs e)
        {
            connectionWithDatabase.CloseConnection();
            this.Close();
        }
    }
}
