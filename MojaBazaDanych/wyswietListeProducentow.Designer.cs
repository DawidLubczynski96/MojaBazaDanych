namespace MojaBazaDanych
{
    partial class wyswietListeProducentow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odswiez_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // powrot_button1
            // 
            this.powrot_button1.Location = new System.Drawing.Point(300, 350);
            this.powrot_button1.Name = "powrot_button1";
            this.powrot_button1.Size = new System.Drawing.Size(200, 50);
            this.powrot_button1.TabIndex = 1;
            this.powrot_button1.Text = "Powrót do menu";
            this.powrot_button1.UseVisualStyleBackColor = true;
            this.powrot_button1.Click += new System.EventHandler(this.powrot_button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // odswiez_button
            // 
            this.odswiez_button.Location = new System.Drawing.Point(350, 260);
            this.odswiez_button.Name = "odswiez_button";
            this.odswiez_button.Size = new System.Drawing.Size(100, 50);
            this.odswiez_button.TabIndex = 3;
            this.odswiez_button.Text = "Odśwież";
            this.odswiez_button.UseVisualStyleBackColor = true;
            this.odswiez_button.Click += new System.EventHandler(this.odswiez_button_Click);
            // 
            // wyswietListeProducentow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.odswiez_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.powrot_button1);
            this.Name = "wyswietListeProducentow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista produktów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powrot_button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button odswiez_button;
    }
}