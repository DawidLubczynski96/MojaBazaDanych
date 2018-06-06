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
                MessageBox.Show("Błąd odświeżania tabeli. Brak połączenia z bazą danych. \r\n" + es.Message + "\r\n" + es.InnerException.Message);
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