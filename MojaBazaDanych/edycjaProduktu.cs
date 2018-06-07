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
    public partial class edycjaProduktu : Form
    {
        BDConnect connectionWithDatabase;
        public edycjaProduktu()
        {
            InitializeComponent();
            connectionWithDatabase = new BDConnect();

            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }

                connectionWithDatabase.searchForData(dataGridView1);
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

        private void dodaj_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }
                if (symbolBox.Text == "" || produktBox.Text == "" || opisBox.Text == "" || nettoBox.Text == ""
                    || bruttoBox.Text == "" || stanBox.Text == "")
                {
                    MessageBox.Show("Błąd. Pola nie mogą być puste.", "Informacja");
                    return;
                }
                connectionWithDatabase.dodajProdukt(symbolBox, produktBox, opisBox, nettoBox, bruttoBox, stanBox);
                MessageBox.Show("Produkt " + produktBox.Text + " został dodany do bazy danych.", "Informacja");
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd dodawania producenta. Sprawdź połączenie z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
            finally
            {
                connectionWithDatabase.CloseConnection();
            }
        }

        private void usun_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy na pewno usunąć produkt?", "Informacja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!connectionWithDatabase.isConnected())
                    {
                        connectionWithDatabase.OpenConnection();
                    }
                    connectionWithDatabase.usunProdukt(IDBox1);
                    MessageBox.Show("Wybrany produkt został usunięty z bazy danych.", "Informacja");
                }

            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd usuwania produktu. Sprawdź połączenie z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
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

                connectionWithDatabase.searchForData(dataGridView1);
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

        private void edytuj_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }
                if (IDBox1.Text == "")
                {
                    MessageBox.Show("Błąd. Pole ID nie może być puste.", "Informacja");
                    return;
                }
                connectionWithDatabase.edytujProdukt(symbolBox, produktBox, opisBox, nettoBox, bruttoBox, stanBox, IDBox1);
                MessageBox.Show("Dane dla produktu " + produktBox.Text + " zostały zmienione.", "Informacja");
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd edycji produktu. Sprawdź połączenie z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
            finally
            {
                connectionWithDatabase.CloseConnection();
            }
        }
    }
}
