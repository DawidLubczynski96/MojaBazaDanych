using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySql.Data;


namespace MojaBazaDanych
{
        class BDConnect
        {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;

            public BDConnect()
            {
                Initialize();
            }

            /*/ Initialize() tworzy połączenie z bazą /*/
            public void Initialize()
            {
                logowanie myLogin = new logowanie();
                server = "localhost";
                database = "produkty";
                uid = "lubo";
                password = "brodnica";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Convert Zero Datetime=True" + ";";

                connection = new MySqlConnection(connectionString);
                OpenConnection();
            }
            /*/ sendCommand(string command, params object[] p) zapytanie z parametrami do bazy danych /*/
            public void sendCommand(string command, params object[] p)
            {
                MySqlCommand Command = new MySqlCommand();
                Command = new MySqlCommand(command, connection);
                foreach (var item in p)
                {
                    Command.Parameters.AddWithValue("", item);
                }

                Command.ExecuteNonQuery();
            }
            /*/ executeScalar(string command, params object[] p) zapytanie zwraca zmienną /*/
            public object executeScalar(string command, params object[] p)
            {
                object variable;
                MySqlCommand Command = new MySqlCommand();
                Command = new MySqlCommand(command, connection);
                foreach (var item in p)
                {
                    Command.Parameters.AddWithValue("", item);
                }
                variable = Command.ExecuteScalar();
                return variable;
            }

            /*/ isConnected() zwraca TRUE/FALSE, czy jestesmy połączeni z bazą /*/
            public bool isConnected()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            /*/ OpenConnection() otwiera połączenie /*/
            public bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    return false;
                }
            }
            /*/ CloseConnection() zamyka połączenie /*/
            public bool CloseConnection()
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    return false;
                }
            }
        public void dodajProducenta(TextBox nazwaBox, TextBox opisBox)
        {
            string Query = "INSERT INTO producent (nazwa, opis) VALUES(?, ?)";

            sendCommand(Query, nazwaBox.Text, opisBox.Text);
        }
        public void dodajProdukt(TextBox symbolBox, TextBox produktBox, TextBox opisBox, TextBox nettoBox, TextBox bruttoBox, TextBox stanBox)
        {
            string Query = "INSERT INTO produkty (symbol, produkt, opis, netto, brutto, stan) VALUES(?, ?, ?, ?, ?, ?); ";
            sendCommand(Query, symbolBox.Text, produktBox.Text, opisBox.Text, nettoBox.Text, bruttoBox.Text, stanBox.Text);
        }
        public void usunProducenta(TextBox IDBox)
        {
            var myID = IDBox.Text;
            string foreign = "SET FOREIGN_KEY_CHECKS = ?;";
            sendCommand(foreign, 0);
            string deleteQuery = "DELETE FROM producent WHERE id = ?;";
            sendCommand(deleteQuery, myID);
            deleteQuery = "DELETE FROM producent WHERE id = ?;";
            sendCommand(deleteQuery, myID);
            sendCommand(foreign, 1);
        }
        public void usunProdukt(TextBox IDBox1)
        {
            var myID = IDBox1.Text;
            string foreign = "SET FOREIGN_KEY_CHECKS = ?;";
            sendCommand(foreign, 0);
            string deleteQuery = "DELETE FROM produkty WHERE id = ?;";
            sendCommand(deleteQuery, myID);
            deleteQuery = "DELETE FROM produkty WHERE id = ?;";
            sendCommand(deleteQuery, myID);
            sendCommand(foreign, 1);
        }
        public void edytujProducenta(TextBox nazwaBox, TextBox opisBox, TextBox IDBox)
        {
            int myID = int.Parse(IDBox.Text.ToString());

            string updateQuery = "UPDATE producent SET nazwa = ?, opis = ? WHERE id = ?;";
            sendCommand(updateQuery, nazwaBox.Text, opisBox.Text, myID);
        }
        public void edytujProdukt(TextBox symbolBox, TextBox produktBox, TextBox opisBox, TextBox nettoBox, TextBox bruttoBox, TextBox stanBox, TextBox IDBox1)
        {
            int myID = int.Parse(IDBox1.Text.ToString());

            string updateQuery = "UPDATE produkty SET symbol = ?, produkt = ?, opis = ?, netto = ?, brutto = ?, stan = ? WHERE id = ?;";
            sendCommand(updateQuery, symbolBox.Text, produktBox.Text, opisBox.Text, nettoBox.Text, bruttoBox.Text, stanBox.Text, myID);
        }
        public void sendQueryDataGridView(DataGridView DataGrid, string Query, params object[] p)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
            foreach (var item in p)
            {
                adapter.SelectCommand.Parameters.AddWithValue("", item);
            }
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGrid.DataSource = table;
            DataGrid.ReadOnly = true;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /*/wyświetlanie tabeli producentów/*/
        public void searchForMaker(DataGridView DataGrid)
        {
            string Query = @"SELECT * FROM producent";
            sendQueryDataGridView(DataGrid, Query);
        }
        /*/wyświetlanie tabeli produktów/*/
        public void searchForData(DataGridView DataGrid)
        {
            string Query = @"SELECT * FROM produkty";
            sendQueryDataGridView(DataGrid, Query);
        }
        /*/sortowanie producenta/*/
        public void searchForMakerByName(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, nazwa, opis FROM producent 
                            WHERE (nazwa = ?) ORDER BY nazwa;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
        public void searchForMakerByDescription(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, nazwa, opis FROM producent 
                            WHERE (opis = ?) ORDER BY opis;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
        /*/sortowanie produktów/*/
        public void searchForDataByCode(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, symbol, produkt, opis, netto, brutto, stan FROM produkty 
                            WHERE (symbol = ?) ORDER BY symbol;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
        public void searchForDataByName(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, symbol, produkt, opis, netto, brutto, stan FROM produkty 
                            WHERE (produkt = ?) ORDER BY produkt;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
        public void searchForDataByDescription(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, symbol, produkt, opis, netto, brutto, stan FROM produkty 
                            WHERE (opis = ?) ORDER BY opis;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
        public void searchForDataByNetto(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, symbol, produkt, opis, netto, brutto, stan FROM produkty 
                            WHERE (netto = ?) ORDER BY netto;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
        public void searchForDataByBrutto(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, symbol, produkt, opis, netto, brutto, stan FROM produkty 
                            WHERE (brutto = ?) ORDER BY brutto;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
        public void searchForDataByAvailability(DataGridView DataGrid, TextBox sortowanieBox)
        {
            string Query = @"SELECT id, symbol, produkt, opis, netto, brutto, stan FROM produkty 
                            WHERE (stan = ?) ORDER BY stan;";
            sendQueryDataGridView(DataGrid, Query, sortowanieBox.Text);
        }
    }
}