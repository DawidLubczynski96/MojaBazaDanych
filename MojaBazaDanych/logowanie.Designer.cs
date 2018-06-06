namespace MojaBazaDanych
{
    partial class logowanie
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
            this.logowanie_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logowanie_button
            // 
            this.logowanie_button.Location = new System.Drawing.Point(200, 250);
            this.logowanie_button.Name = "logowanie_button";
            this.logowanie_button.Size = new System.Drawing.Size(400, 100);
            this.logowanie_button.TabIndex = 0;
            this.logowanie_button.Text = "Zaloguj do bazy danych";
            this.logowanie_button.UseVisualStyleBackColor = true;
            this.logowanie_button.Click += new System.EventHandler(this.logowanie_button_Click);
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.logowanie_button);
            this.Name = "logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logowanie_button;
    }
}

