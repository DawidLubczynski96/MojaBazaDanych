namespace MojaBazaDanych
{
    partial class menu
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
            this.wyswietl_button = new System.Windows.Forms.Button();
            this.edycja_button = new System.Windows.Forms.Button();
            this.koniec_button = new System.Windows.Forms.Button();
            this.wyswietl_button1 = new System.Windows.Forms.Button();
            this.edycja_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wyswietl_button
            // 
            this.wyswietl_button.Location = new System.Drawing.Point(150, 100);
            this.wyswietl_button.Name = "wyswietl_button";
            this.wyswietl_button.Size = new System.Drawing.Size(200, 50);
            this.wyswietl_button.TabIndex = 0;
            this.wyswietl_button.Text = "Wyświetl listę producentów";
            this.wyswietl_button.UseVisualStyleBackColor = true;
            this.wyswietl_button.Click += new System.EventHandler(this.wyswietl_button_Click);
            // 
            // edycja_button
            // 
            this.edycja_button.Location = new System.Drawing.Point(150, 250);
            this.edycja_button.Name = "edycja_button";
            this.edycja_button.Size = new System.Drawing.Size(200, 50);
            this.edycja_button.TabIndex = 1;
            this.edycja_button.Text = "Edycja producenta";
            this.edycja_button.UseVisualStyleBackColor = true;
            this.edycja_button.Click += new System.EventHandler(this.edycja_button_Click);
            // 
            // koniec_button
            // 
            this.koniec_button.Location = new System.Drawing.Point(150, 400);
            this.koniec_button.Name = "koniec_button";
            this.koniec_button.Size = new System.Drawing.Size(500, 50);
            this.koniec_button.TabIndex = 4;
            this.koniec_button.Text = "Wyjście z programu";
            this.koniec_button.UseVisualStyleBackColor = true;
            this.koniec_button.Click += new System.EventHandler(this.koniec_button_Click);
            // 
            // wyswietl_button1
            // 
            this.wyswietl_button1.Location = new System.Drawing.Point(450, 100);
            this.wyswietl_button1.Name = "wyswietl_button1";
            this.wyswietl_button1.Size = new System.Drawing.Size(200, 50);
            this.wyswietl_button1.TabIndex = 5;
            this.wyswietl_button1.Text = "Wyświetl listę produktów";
            this.wyswietl_button1.UseVisualStyleBackColor = true;
            this.wyswietl_button1.Click += new System.EventHandler(this.wyswietl_button1_Click);
            // 
            // edycja_button1
            // 
            this.edycja_button1.Location = new System.Drawing.Point(450, 250);
            this.edycja_button1.Name = "edycja_button1";
            this.edycja_button1.Size = new System.Drawing.Size(200, 50);
            this.edycja_button1.TabIndex = 7;
            this.edycja_button1.Text = "Edycja produktu";
            this.edycja_button1.UseVisualStyleBackColor = true;
            this.edycja_button1.Click += new System.EventHandler(this.edycja_button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.edycja_button1);
            this.Controls.Add(this.wyswietl_button1);
            this.Controls.Add(this.koniec_button);
            this.Controls.Add(this.edycja_button);
            this.Controls.Add(this.wyswietl_button);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wyswietl_button;
        private System.Windows.Forms.Button edycja_button;
        private System.Windows.Forms.Button usun_button;
        private System.Windows.Forms.Button edytuj_button;
        private System.Windows.Forms.Button koniec_button;
        private System.Windows.Forms.Button wyswietl_button1;
        private System.Windows.Forms.Button edycja_button1;
        private System.Windows.Forms.Button usun_button1;
        private System.Windows.Forms.Button edytuj_button1;
    }
}