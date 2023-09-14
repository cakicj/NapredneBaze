
namespace TuristickaAgencija.Forme
{
    partial class DestinacijaPrikaz
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
            this.lblDestinacija = new System.Windows.Forms.Label();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.lblBrStanovnika = new System.Windows.Forms.Label();
            this.lblDuzinaPlaze = new System.Windows.Forms.Label();
            this.lblMore = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.lbHoteli = new System.Windows.Forms.ListBox();
            this.btnIzaberiHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajHotel = new System.Windows.Forms.Button();
            this.btnIzbrisiHotel = new System.Windows.Forms.Button();
            this.btnAzurirajDestinaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDestinacija
            // 
            this.lblDestinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDestinacija.Location = new System.Drawing.Point(323, 34);
            this.lblDestinacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinacija.Name = "lblDestinacija";
            this.lblDestinacija.Size = new System.Drawing.Size(427, 55);
            this.lblDestinacija.TabIndex = 0;
            this.lblDestinacija.Text = "Destinacija";
            this.lblDestinacija.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrzava
            // 
            this.lblDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDrzava.Location = new System.Drawing.Point(43, 94);
            this.lblDrzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(209, 33);
            this.lblDrzava.TabIndex = 1;
            this.lblDrzava.Text = "Drzava";
            this.lblDrzava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrStanovnika
            // 
            this.lblBrStanovnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBrStanovnika.Location = new System.Drawing.Point(43, 146);
            this.lblBrStanovnika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrStanovnika.Name = "lblBrStanovnika";
            this.lblBrStanovnika.Size = new System.Drawing.Size(209, 27);
            this.lblBrStanovnika.TabIndex = 2;
            this.lblBrStanovnika.Text = "broj stanovnika";
            this.lblBrStanovnika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuzinaPlaze
            // 
            this.lblDuzinaPlaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDuzinaPlaze.Location = new System.Drawing.Point(43, 193);
            this.lblDuzinaPlaze.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuzinaPlaze.Name = "lblDuzinaPlaze";
            this.lblDuzinaPlaze.Size = new System.Drawing.Size(209, 28);
            this.lblDuzinaPlaze.TabIndex = 3;
            this.lblDuzinaPlaze.Text = "duzina plaze";
            this.lblDuzinaPlaze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMore
            // 
            this.lblMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMore.Location = new System.Drawing.Point(43, 246);
            this.lblMore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(209, 33);
            this.lblMore.TabIndex = 4;
            this.lblMore.Text = "ima more?";
            this.lblMore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(47, 314);
            this.tbOpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.ReadOnly = true;
            this.tbOpis.Size = new System.Drawing.Size(325, 224);
            this.tbOpis.TabIndex = 5;
            // 
            // lbHoteli
            // 
            this.lbHoteli.FormattingEnabled = true;
            this.lbHoteli.ItemHeight = 16;
            this.lbHoteli.Location = new System.Drawing.Point(739, 94);
            this.lbHoteli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbHoteli.Name = "lbHoteli";
            this.lbHoteli.Size = new System.Drawing.Size(311, 212);
            this.lbHoteli.TabIndex = 6;
            // 
            // btnIzaberiHotel
            // 
            this.btnIzaberiHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIzaberiHotel.Location = new System.Drawing.Point(785, 314);
            this.btnIzaberiHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzaberiHotel.Name = "btnIzaberiHotel";
            this.btnIzaberiHotel.Size = new System.Drawing.Size(247, 50);
            this.btnIzaberiHotel.TabIndex = 7;
            this.btnIzaberiHotel.Text = "Izaberi Hotel";
            this.btnIzaberiHotel.UseVisualStyleBackColor = true;
            this.btnIzaberiHotel.Click += new System.EventHandler(this.BtnIzaberiHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Opis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDodajHotel
            // 
            this.btnDodajHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajHotel.Location = new System.Drawing.Point(785, 384);
            this.btnDodajHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajHotel.Name = "btnDodajHotel";
            this.btnDodajHotel.Size = new System.Drawing.Size(247, 50);
            this.btnDodajHotel.TabIndex = 9;
            this.btnDodajHotel.Text = "Dodaj hotel";
            this.btnDodajHotel.UseVisualStyleBackColor = true;
            this.btnDodajHotel.Click += new System.EventHandler(this.BtnDodajHotel_Click);
            // 
            // btnIzbrisiHotel
            // 
            this.btnIzbrisiHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIzbrisiHotel.Location = new System.Drawing.Point(785, 454);
            this.btnIzbrisiHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzbrisiHotel.Name = "btnIzbrisiHotel";
            this.btnIzbrisiHotel.Size = new System.Drawing.Size(247, 50);
            this.btnIzbrisiHotel.TabIndex = 10;
            this.btnIzbrisiHotel.Text = "Izbrisi Hotel";
            this.btnIzbrisiHotel.UseVisualStyleBackColor = true;
            this.btnIzbrisiHotel.Click += new System.EventHandler(this.BtnIzbrisiHotel_Click);
            // 
            // btnAzurirajDestinaciju
            // 
            this.btnAzurirajDestinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAzurirajDestinaciju.Location = new System.Drawing.Point(457, 489);
            this.btnAzurirajDestinaciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzurirajDestinaciju.Name = "btnAzurirajDestinaciju";
            this.btnAzurirajDestinaciju.Size = new System.Drawing.Size(227, 50);
            this.btnAzurirajDestinaciju.TabIndex = 11;
            this.btnAzurirajDestinaciju.Text = "Azuriraj destinaciju";
            this.btnAzurirajDestinaciju.UseVisualStyleBackColor = true;
            this.btnAzurirajDestinaciju.Click += new System.EventHandler(this.BtnAzurirajDestinaciju_Click);
            // 
            // DestinacijaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAzurirajDestinaciju);
            this.Controls.Add(this.btnIzbrisiHotel);
            this.Controls.Add(this.btnDodajHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzaberiHotel);
            this.Controls.Add(this.lbHoteli);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.lblMore);
            this.Controls.Add(this.lblDuzinaPlaze);
            this.Controls.Add(this.lblBrStanovnika);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.lblDestinacija);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DestinacijaPrikaz";
            this.Text = "Destinacija";
            this.Load += new System.EventHandler(this.DestinacijaPrikaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinacija;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.Label lblBrStanovnika;
        private System.Windows.Forms.Label lblDuzinaPlaze;
        private System.Windows.Forms.Label lblMore;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.ListBox lbHoteli;
        private System.Windows.Forms.Button btnIzaberiHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajHotel;
        private System.Windows.Forms.Button btnIzbrisiHotel;
        private System.Windows.Forms.Button btnAzurirajDestinaciju;
    }
}