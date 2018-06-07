namespace MojaBazaDanych
{
    partial class wyswietListeProduktow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odswiez_button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // powrot_button
            // 
            this.powrot_button.Location = new System.Drawing.Point(300, 350);
            this.powrot_button.Name = "powrot_button";
            this.powrot_button.Size = new System.Drawing.Size(200, 50);
            this.powrot_button.TabIndex = 2;
            this.powrot_button.Text = "Powrot do menu";
            this.powrot_button.UseVisualStyleBackColor = true;
            this.powrot_button.Click += new System.EventHandler(this.powrot_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // odswiez_button1
            // 
            this.odswiez_button1.Location = new System.Drawing.Point(350, 260);
            this.odswiez_button1.Name = "odswiez_button1";
            this.odswiez_button1.Size = new System.Drawing.Size(100, 50);
            this.odswiez_button1.TabIndex = 4;
            this.odswiez_button1.Text = "Odśwież";
            this.odswiez_button1.UseVisualStyleBackColor = true;
            this.odswiez_button1.Click += new System.EventHandler(this.odswiez_button1_Click);
            // 
            // wyswietListeProduktow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.odswiez_button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.powrot_button);
            this.Name = "wyswietListeProduktow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wyswietListeProduktow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powrot_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button odswiez_button1;
    }
}