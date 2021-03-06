﻿using System;
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
    public partial class edycjaProducenta : Form
    {
        BDConnect connectionWithDatabase;
        public edycjaProducenta()
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
                MessageBox.Show("Błąd odświeżania tabeli. Brak połączenia z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
            finally
            {
                connectionWithDatabase.CloseConnection();
            }
        }

        private void powrot_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }
                if (nazwaBox.Text == "" || opisBox.Text == "")
                {
                    MessageBox.Show("Błąd. Pola nie mogą być puste.", "Informacja");
                    return;
                }
                connectionWithDatabase.dodajProducenta(nazwaBox, opisBox);
                MessageBox.Show("Producent " + nazwaBox.Text + " został dodany do bazy danych.", "Informacja");
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd dodawania producenta. Sprawdź połączenie z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
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

        private void usun_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy na pewno usunąć producenta?", "Informacja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!connectionWithDatabase.isConnected())
                    {
                        connectionWithDatabase.OpenConnection();
                    }
                    connectionWithDatabase.usunProducenta(IDBox);
                    MessageBox.Show("Wybrany producent został usunięty z bazy danych.", "Informacja");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd usuwania producenta. Sprawdź połączenie z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
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

        private void edytuj_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }
                if (IDBox.Text == "")
                {
                    MessageBox.Show("Błąd. Pole ID nie może być puste.", "Informacja");
                    return;
                }
                if (nazwaBox.Text == "" && opisBox.Text == "")
                {
                    MessageBox.Show("Błąd. Przynajmniej jedno pole musi być wypełnione.", "Informacja");
                    return;
                }
                connectionWithDatabase.edytujProducenta(nazwaBox, opisBox, IDBox);
                MessageBox.Show("Dane dla producenta " + nazwaBox.Text + " zostały zmienione.", "Informacja");
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd dodawania producenta. Sprawdź połączenie z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
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

        private void sortuj_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connectionWithDatabase.isConnected())
                {
                    connectionWithDatabase.OpenConnection();
                }
                if (checkBoxSortowanie1.Checked)
                {
                    connectionWithDatabase.searchForMakerByName(dataGridView1, sortowanieBox);
                }
                else if (checkBoxSortowanie2.Checked)
                {
                    connectionWithDatabase.searchForMakerByDescription(dataGridView1, sortowanieBox);
                }
                else if (!checkBoxSortowanie1.Checked)
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
                else if (!checkBoxSortowanie2.Checked)
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
            }
            catch (Exception es)
            {
                MessageBox.Show("Błąd sortowania danych. Sprawdź połączenie z bazą danych. \r\n", "Informacja" + es.Message + "\r\n" + es.InnerException.Message);
            }
            finally
            {
                connectionWithDatabase.CloseConnection();
            }
        }

        private void wyczysc_button_Click(object sender, EventArgs e)
        {
            nazwaBox.Text = "";
            opisBox.Text = "";
            IDBox.Text = "";
            sortowanieBox.Text = "";
    
            MessageBox.Show("Pola zostały wyczyszczone.", "Informacja");
        }
    }
}
