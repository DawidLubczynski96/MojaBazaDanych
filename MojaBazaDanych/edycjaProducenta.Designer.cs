﻿namespace MojaBazaDanych
{
    partial class edycjaProducenta
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
            this.powrot_button = new System.Windows.Forms.Button();
            this.nazwaBox = new System.Windows.Forms.TextBox();
            this.opisBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodaj_button = new System.Windows.Forms.Button();
            this.usun_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.odswiez_button = new System.Windows.Forms.Button();
            this.edytuj_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sortuj_button = new System.Windows.Forms.Button();
            this.sortowanieBox = new System.Windows.Forms.TextBox();
            this.checkBoxSortowanie1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSortowanie2 = new System.Windows.Forms.CheckBox();
            this.wyczysc_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // powrot_button
            // 
            this.powrot_button.Location = new System.Drawing.Point(572, 500);
            this.powrot_button.Name = "powrot_button";
            this.powrot_button.Size = new System.Drawing.Size(200, 50);
            this.powrot_button.TabIndex = 0;
            this.powrot_button.Text = "Powrót do menu";
            this.powrot_button.UseVisualStyleBackColor = true;
            this.powrot_button.Click += new System.EventHandler(this.powrot_button_Click);
            // 
            // nazwaBox
            // 
            this.nazwaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.nazwaBox.Location = new System.Drawing.Point(301, 82);
            this.nazwaBox.Name = "nazwaBox";
            this.nazwaBox.Size = new System.Drawing.Size(200, 38);
            this.nazwaBox.TabIndex = 1;
            // 
            // opisBox
            // 
            this.opisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.opisBox.Location = new System.Drawing.Point(300, 143);
            this.opisBox.Name = "opisBox";
            this.opisBox.Size = new System.Drawing.Size(200, 38);
            this.opisBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(168, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(196, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 213);
            this.dataGridView1.TabIndex = 5;
            // 
            // dodaj_button
            // 
            this.dodaj_button.Location = new System.Drawing.Point(572, 337);
            this.dodaj_button.Name = "dodaj_button";
            this.dodaj_button.Size = new System.Drawing.Size(200, 50);
            this.dodaj_button.TabIndex = 16;
            this.dodaj_button.Text = "Dodaj producenta";
            this.dodaj_button.UseVisualStyleBackColor = true;
            this.dodaj_button.Click += new System.EventHandler(this.dodaj_button_Click);
            // 
            // usun_button
            // 
            this.usun_button.Location = new System.Drawing.Point(572, 418);
            this.usun_button.Name = "usun_button";
            this.usun_button.Size = new System.Drawing.Size(200, 50);
            this.usun_button.TabIndex = 17;
            this.usun_button.Text = "Usuń producenta";
            this.usun_button.UseVisualStyleBackColor = true;
            this.usun_button.Click += new System.EventHandler(this.usun_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label3.Location = new System.Drawing.Point(224, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dodawanie do bazy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(224, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.IDBox.Location = new System.Drawing.Point(300, 258);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(200, 38);
            this.IDBox.TabIndex = 21;
            // 
            // odswiez_button
            // 
            this.odswiez_button.Location = new System.Drawing.Point(572, 178);
            this.odswiez_button.Name = "odswiez_button";
            this.odswiez_button.Size = new System.Drawing.Size(200, 50);
            this.odswiez_button.TabIndex = 22;
            this.odswiez_button.Text = "Odśwież";
            this.odswiez_button.UseVisualStyleBackColor = true;
            this.odswiez_button.Click += new System.EventHandler(this.odswiez_button_Click);
            // 
            // edytuj_button
            // 
            this.edytuj_button.Location = new System.Drawing.Point(572, 258);
            this.edytuj_button.Name = "edytuj_button";
            this.edytuj_button.Size = new System.Drawing.Size(200, 50);
            this.edytuj_button.TabIndex = 23;
            this.edytuj_button.Text = "Edytuj producenta";
            this.edytuj_button.UseVisualStyleBackColor = true;
            this.edytuj_button.Click += new System.EventHandler(this.edytuj_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label4.Location = new System.Drawing.Point(260, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "Usuwanie z bazy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sortowanie wg:";
            // 
            // sortuj_button
            // 
            this.sortuj_button.Location = new System.Drawing.Point(224, 306);
            this.sortuj_button.Name = "sortuj_button";
            this.sortuj_button.Size = new System.Drawing.Size(87, 23);
            this.sortuj_button.TabIndex = 26;
            this.sortuj_button.Text = "Sortuj";
            this.sortuj_button.UseVisualStyleBackColor = true;
            this.sortuj_button.Click += new System.EventHandler(this.sortuj_button_Click);
            // 
            // sortowanieBox
            // 
            this.sortowanieBox.Location = new System.Drawing.Point(93, 308);
            this.sortowanieBox.Name = "sortowanieBox";
            this.sortowanieBox.Size = new System.Drawing.Size(125, 20);
            this.sortowanieBox.TabIndex = 27;
            // 
            // checkBoxSortowanie1
            // 
            this.checkBoxSortowanie1.AutoSize = true;
            this.checkBoxSortowanie1.Location = new System.Drawing.Point(12, 291);
            this.checkBoxSortowanie1.Name = "checkBoxSortowanie1";
            this.checkBoxSortowanie1.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSortowanie1.TabIndex = 28;
            this.checkBoxSortowanie1.Text = "Producent";
            this.checkBoxSortowanie1.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortowanie2
            // 
            this.checkBoxSortowanie2.AutoSize = true;
            this.checkBoxSortowanie2.Location = new System.Drawing.Point(12, 312);
            this.checkBoxSortowanie2.Name = "checkBoxSortowanie2";
            this.checkBoxSortowanie2.Size = new System.Drawing.Size(47, 17);
            this.checkBoxSortowanie2.TabIndex = 29;
            this.checkBoxSortowanie2.Text = "Opis";
            this.checkBoxSortowanie2.UseVisualStyleBackColor = true;
            // 
            // wyczysc_button
            // 
            this.wyczysc_button.Location = new System.Drawing.Point(572, 98);
            this.wyczysc_button.Name = "wyczysc_button";
            this.wyczysc_button.Size = new System.Drawing.Size(200, 50);
            this.wyczysc_button.TabIndex = 30;
            this.wyczysc_button.Text = "Wyczyść pola";
            this.wyczysc_button.UseVisualStyleBackColor = true;
            this.wyczysc_button.Click += new System.EventHandler(this.wyczysc_button_Click);
            // 
            // edycjaProducenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.wyczysc_button);
            this.Controls.Add(this.checkBoxSortowanie2);
            this.Controls.Add(this.checkBoxSortowanie1);
            this.Controls.Add(this.sortowanieBox);
            this.Controls.Add(this.sortuj_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edytuj_button);
            this.Controls.Add(this.odswiez_button);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usun_button);
            this.Controls.Add(this.dodaj_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opisBox);
            this.Controls.Add(this.nazwaBox);
            this.Controls.Add(this.powrot_button);
            this.Name = "edycjaProducenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja produktu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot_button;
        private System.Windows.Forms.TextBox nazwaBox;
        private System.Windows.Forms.TextBox opisBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodaj_button;
        private System.Windows.Forms.Button usun_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button odswiez_button;
        private System.Windows.Forms.Button edytuj_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sortuj_button;
        private System.Windows.Forms.TextBox sortowanieBox;
        private System.Windows.Forms.CheckBox checkBoxSortowanie1;
        private System.Windows.Forms.CheckBox checkBoxSortowanie2;
        private System.Windows.Forms.Button wyczysc_button;
    }
}