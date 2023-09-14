
namespace TuristickaAgencija.Forme
{
    partial class DrzavaPrikaz
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
            this.lblDrzava = new System.Windows.Forms.Label();
            this.lblGlavniGrad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIzlazNaMore = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.lbDestinacije = new System.Windows.Forms.ListBox();
            this.btnDestinacija = new System.Windows.Forms.Button();
            this.btnDodajDestinaciju = new System.Windows.Forms.Button();
            this.btnObrisiDestinaciju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAzurirajDrzavu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDrzava
            // 
            this.lblDrzava.BackColor = System.Drawing.Color.Transparent;
            this.lblDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDrzava.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDrzava.Location = new System.Drawing.Point(172, 11);
            this.lblDrzava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(369, 81);
            this.lblDrzava.TabIndex = 0;
            this.lblDrzava.Text = "Drzava";
            this.lblDrzava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGlavniGrad
            // 
            this.lblGlavniGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGlavniGrad.Location = new System.Drawing.Point(16, 134);
            this.lblGlavniGrad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGlavniGrad.Name = "lblGlavniGrad";
            this.lblGlavniGrad.Size = new System.Drawing.Size(241, 41);
            this.lblGlavniGrad.TabIndex = 1;
            this.lblGlavniGrad.Text = "glavni grad";
            this.lblGlavniGrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(16, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "sluzbeni jezik";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIzlazNaMore
            // 
            this.lblIzlazNaMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIzlazNaMore.Location = new System.Drawing.Point(19, 224);
            this.lblIzlazNaMore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIzlazNaMore.Name = "lblIzlazNaMore";
            this.lblIzlazNaMore.Size = new System.Drawing.Size(239, 41);
            this.lblIzlazNaMore.TabIndex = 3;
            this.lblIzlazNaMore.Text = "izlaz na more";
            this.lblIzlazNaMore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOpis
            // 
            this.tbOpis.BackColor = System.Drawing.Color.LightGray;
            this.tbOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbOpis.Location = new System.Drawing.Point(25, 343);
            this.tbOpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.ReadOnly = true;
            this.tbOpis.Size = new System.Drawing.Size(231, 195);
            this.tbOpis.TabIndex = 4;
            // 
            // lbDestinacije
            // 
            this.lbDestinacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDestinacije.FormattingEnabled = true;
            this.lbDestinacije.ItemHeight = 16;
            this.lbDestinacije.Location = new System.Drawing.Point(360, 96);
            this.lbDestinacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbDestinacije.Name = "lbDestinacije";
            this.lbDestinacije.Size = new System.Drawing.Size(360, 212);
            this.lbDestinacije.TabIndex = 5;
            // 
            // btnDestinacija
            // 
            this.btnDestinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDestinacija.Location = new System.Drawing.Point(445, 316);
            this.btnDestinacija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDestinacija.Name = "btnDestinacija";
            this.btnDestinacija.Size = new System.Drawing.Size(219, 43);
            this.btnDestinacija.TabIndex = 6;
            this.btnDestinacija.Text = "Izaberi Destinaciju";
            this.btnDestinacija.UseVisualStyleBackColor = true;
            this.btnDestinacija.Click += new System.EventHandler(this.BtnDestinacija_Click);
            // 
            // btnDodajDestinaciju
            // 
            this.btnDodajDestinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajDestinaciju.Location = new System.Drawing.Point(445, 367);
            this.btnDodajDestinaciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajDestinaciju.Name = "btnDodajDestinaciju";
            this.btnDodajDestinaciju.Size = new System.Drawing.Size(219, 43);
            this.btnDodajDestinaciju.TabIndex = 7;
            this.btnDodajDestinaciju.Text = "Dodaj Destinaciju";
            this.btnDodajDestinaciju.UseVisualStyleBackColor = true;
            this.btnDodajDestinaciju.Click += new System.EventHandler(this.BtnDodajDestinaciju_Click);
            // 
            // btnObrisiDestinaciju
            // 
            this.btnObrisiDestinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnObrisiDestinaciju.Location = new System.Drawing.Point(445, 417);
            this.btnObrisiDestinaciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiDestinaciju.Name = "btnObrisiDestinaciju";
            this.btnObrisiDestinaciju.Size = new System.Drawing.Size(219, 43);
            this.btnObrisiDestinaciju.TabIndex = 8;
            this.btnObrisiDestinaciju.Text = "Obrisi Destinaciju";
            this.btnObrisiDestinaciju.UseVisualStyleBackColor = true;
            this.btnObrisiDestinaciju.Click += new System.EventHandler(this.BtnObrisiDestinaciju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(95, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Opis";
            // 
            // btnAzurirajDrzavu
            // 
            this.btnAzurirajDrzavu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAzurirajDrzavu.Location = new System.Drawing.Point(331, 495);
            this.btnAzurirajDrzavu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzurirajDrzavu.Name = "btnAzurirajDrzavu";
            this.btnAzurirajDrzavu.Size = new System.Drawing.Size(211, 44);
            this.btnAzurirajDrzavu.TabIndex = 10;
            this.btnAzurirajDrzavu.Text = "Azuriraj drzavu";
            this.btnAzurirajDrzavu.UseVisualStyleBackColor = true;
            this.btnAzurirajDrzavu.Click += new System.EventHandler(this.BtnAzurirajDrzavu_Click);
            // 
            // DrzavaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(737, 548);
            this.Controls.Add(this.btnAzurirajDrzavu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiDestinaciju);
            this.Controls.Add(this.btnDodajDestinaciju);
            this.Controls.Add(this.btnDestinacija);
            this.Controls.Add(this.lbDestinacije);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.lblIzlazNaMore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGlavniGrad);
            this.Controls.Add(this.lblDrzava);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DrzavaPrikaz";
            this.Text = "Drzava";
            this.Load += new System.EventHandler(this.DrzavaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.Label lblGlavniGrad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIzlazNaMore;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.ListBox lbDestinacije;
        private System.Windows.Forms.Button btnDestinacija;
        private System.Windows.Forms.Button btnDodajDestinaciju;
        private System.Windows.Forms.Button btnObrisiDestinaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAzurirajDrzavu;
    }
}