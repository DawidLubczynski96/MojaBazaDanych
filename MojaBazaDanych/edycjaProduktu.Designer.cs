namespace MojaBazaDanych
{
    partial class edycjaProduktu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.powrot_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.symbolBox = new System.Windows.Forms.TextBox();
            this.produktBox = new System.Windows.Forms.TextBox();
            this.opisBox = new System.Windows.Forms.TextBox();
            this.nettoBox = new System.Windows.Forms.TextBox();
            this.bruttoBox = new System.Windows.Forms.TextBox();
            this.stanBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodaj_button1 = new System.Windows.Forms.Button();
            this.usun_button1 = new System.Windows.Forms.Button();
            this.edytuj_button1 = new System.Windows.Forms.Button();
            this.odswiez_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // powrot_button1
            // 
            this.powrot_button1.Location = new System.Drawing.Point(572, 500);
            this.powrot_button1.Name = "powrot_button1";
            this.powrot_button1.Size = new System.Drawing.Size(200, 50);
            this.powrot_button1.TabIndex = 1;
            this.powrot_button1.Text = "Powrót do menu";
            this.powrot_button1.UseVisualStyleBackColor = true;
            this.powrot_button1.Click += new System.EventHandler(this.powrot_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(90, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(86, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(124, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(47, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cena netto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(38, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cena brutto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Aktualny stan";
            // 
            // symbolBox
            // 
            this.symbolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.symbolBox.Location = new System.Drawing.Point(200, 30);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(366, 38);
            this.symbolBox.TabIndex = 8;
            // 
            // produktBox
            // 
            this.produktBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.produktBox.Location = new System.Drawing.Point(200, 80);
            this.produktBox.Name = "produktBox";
            this.produktBox.Size = new System.Drawing.Size(366, 38);
            this.produktBox.TabIndex = 9;
            // 
            // opisBox
            // 
            this.opisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.opisBox.Location = new System.Drawing.Point(200, 130);
            this.opisBox.Name = "opisBox";
            this.opisBox.Size = new System.Drawing.Size(366, 38);
            this.opisBox.TabIndex = 10;
            // 
            // nettoBox
            // 
            this.nettoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.nettoBox.Location = new System.Drawing.Point(200, 180);
            this.nettoBox.Name = "nettoBox";
            this.nettoBox.Size = new System.Drawing.Size(366, 38);
            this.nettoBox.TabIndex = 11;
            // 
            // bruttoBox
            // 
            this.bruttoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bruttoBox.Location = new System.Drawing.Point(200, 230);
            this.bruttoBox.Name = "bruttoBox";
            this.bruttoBox.Size = new System.Drawing.Size(366, 38);
            this.bruttoBox.TabIndex = 12;
            // 
            // stanBox
            // 
            this.stanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.stanBox.Location = new System.Drawing.Point(200, 280);
            this.stanBox.Name = "stanBox";
            this.stanBox.Size = new System.Drawing.Size(366, 38);
            this.stanBox.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 213);
            this.dataGridView1.TabIndex = 14;
            // 
            // dodaj_button1
            // 
            this.dodaj_button1.Location = new System.Drawing.Point(572, 335);
            this.dodaj_button1.Name = "dodaj_button1";
            this.dodaj_button1.Size = new System.Drawing.Size(200, 50);
            this.dodaj_button1.TabIndex = 15;
            this.dodaj_button1.Text = "Dodaj produkt";
            this.dodaj_button1.UseVisualStyleBackColor = true;
            this.dodaj_button1.Click += new System.EventHandler(this.dodaj_button1_Click);
            // 
            // usun_button1
            // 
            this.usun_button1.Location = new System.Drawing.Point(572, 418);
            this.usun_button1.Name = "usun_button1";
            this.usun_button1.Size = new System.Drawing.Size(200, 50);
            this.usun_button1.TabIndex = 16;
            this.usun_button1.Text = "Usuń produkt";
            this.usun_button1.UseVisualStyleBackColor = true;
            this.usun_button1.Click += new System.EventHandler(this.usun_button1_Click);
            // 
            // edytuj_button1
            // 
            this.edytuj_button1.Location = new System.Drawing.Point(572, 253);
            this.edytuj_button1.Name = "edytuj_button1";
            this.edytuj_button1.Size = new System.Drawing.Size(200, 50);
            this.edytuj_button1.TabIndex = 24;
            this.edytuj_button1.Text = "Edytuj produkt";
            this.edytuj_button1.UseVisualStyleBackColor = true;
            this.edytuj_button1.Click += new System.EventHandler(this.edytuj_button1_Click);
            // 
            // odswiez_button
            // 
            this.odswiez_button.Location = new System.Drawing.Point(572, 171);
            this.odswiez_button.Name = "odswiez_button";
            this.odswiez_button.Size = new System.Drawing.Size(200, 50);
            this.odswiez_button.TabIndex = 25;
            this.odswiez_button.Text = "Odśwież";
            this.odswiez_button.UseVisualStyleBackColor = true;
            this.odswiez_button.Click += new System.EventHandler(this.odswiez_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(601, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID";
            // 
            // IDBox1
            // 
            this.IDBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.IDBox1.Location = new System.Drawing.Point(649, 30);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(123, 38);
            this.IDBox1.TabIndex = 27;
            // 
            // edycjaProduktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.IDBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.odswiez_button);
            this.Controls.Add(this.edytuj_button1);
            this.Controls.Add(this.usun_button1);
            this.Controls.Add(this.dodaj_button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stanBox);
            this.Controls.Add(this.bruttoBox);
            this.Controls.Add(this.nettoBox);
            this.Controls.Add(this.opisBox);
            this.Controls.Add(this.produktBox);
            this.Controls.Add(this.symbolBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powrot_button1);
            this.Name = "edycjaProduktu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edycjaProduktu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox symbolBox;
        private System.Windows.Forms.TextBox produktBox;
        private System.Windows.Forms.TextBox opisBox;
        private System.Windows.Forms.TextBox nettoBox;
        private System.Windows.Forms.TextBox bruttoBox;
        private System.Windows.Forms.TextBox stanBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodaj_button1;
        private System.Windows.Forms.Button usun_button1;
        private System.Windows.Forms.Button edytuj_button1;
        private System.Windows.Forms.Button odswiez_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDBox1;
    }
}