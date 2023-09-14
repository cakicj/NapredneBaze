
namespace TuristickaAgencija.Forme
{
    partial class DrzavaDodavanje
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
            this.gbImaMore = new System.Windows.Forms.GroupBox();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.btnDodajDrzavu = new System.Windows.Forms.Button();
            this.tbGradovi = new System.Windows.Forms.TextBox();
            this.tbSluzbeniJezik = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.tbGlavniGrad = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblListaGradova = new System.Windows.Forms.Label();
            this.lblSluzbeniJezik = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblGlavniGrad = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.gbImaMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbImaMore
            // 
            this.gbImaMore.Controls.Add(this.rbDa);
            this.gbImaMore.Controls.Add(this.rbNe);
            this.gbImaMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbImaMore.Location = new System.Drawing.Point(580, 175);
            this.gbImaMore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbImaMore.Name = "gbImaMore";
            this.gbImaMore.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbImaMore.Size = new System.Drawing.Size(149, 62);
            this.gbImaMore.TabIndex = 34;
            this.gbImaMore.TabStop = false;
            this.gbImaMore.Text = "Ima more?";
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Checked = true;
            this.rbDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbDa.Location = new System.Drawing.Point(8, 23);
            this.rbDa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(52, 24);
            this.rbDa.TabIndex = 1;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbNe.Location = new System.Drawing.Point(91, 23);
            this.rbNe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(51, 24);
            this.rbNe.TabIndex = 0;
            this.rbNe.Text = "Ne";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // btnDodajDrzavu
            // 
            this.btnDodajDrzavu.Location = new System.Drawing.Point(855, 182);
            this.btnDodajDrzavu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajDrzavu.Name = "btnDodajDrzavu";
            this.btnDodajDrzavu.Size = new System.Drawing.Size(196, 52);
            this.btnDodajDrzavu.TabIndex = 33;
            this.btnDodajDrzavu.Text = "Dodaj drzavu";
            this.btnDodajDrzavu.UseVisualStyleBackColor = true;
            this.btnDodajDrzavu.Click += new System.EventHandler(this.BtnDodajDrzavu_Click);
            // 
            // tbGradovi
            // 
            this.tbGradovi.Location = new System.Drawing.Point(667, 11);
            this.tbGradovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGradovi.Multiline = true;
            this.tbGradovi.Name = "tbGradovi";
            this.tbGradovi.Size = new System.Drawing.Size(383, 142);
            this.tbGradovi.TabIndex = 30;
            // 
            // tbSluzbeniJezik
            // 
            this.tbSluzbeniJezik.Location = new System.Drawing.Point(169, 212);
            this.tbSluzbeniJezik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSluzbeniJezik.Name = "tbSluzbeniJezik";
            this.tbSluzbeniJezik.Size = new System.Drawing.Size(301, 22);
            this.tbSluzbeniJezik.TabIndex = 28;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(132, 85);
            this.tbOpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(307, 98);
            this.tbOpis.TabIndex = 27;
            // 
            // tbGlavniGrad
            // 
            this.tbGlavniGrad.Location = new System.Drawing.Point(137, 53);
            this.tbGlavniGrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGlavniGrad.Name = "tbGlavniGrad";
            this.tbGlavniGrad.Size = new System.Drawing.Size(301, 22);
            this.tbGlavniGrad.TabIndex = 26;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(132, 10);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(307, 22);
            this.tbIme.TabIndex = 25;
            // 
            // lblListaGradova
            // 
            this.lblListaGradova.AutoSize = true;
            this.lblListaGradova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblListaGradova.Location = new System.Drawing.Point(576, 70);
            this.lblListaGradova.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaGradova.Name = "lblListaGradova";
            this.lblListaGradova.Size = new System.Drawing.Size(72, 20);
            this.lblListaGradova.TabIndex = 24;
            this.lblListaGradova.Text = "Gradovi:";
            this.lblListaGradova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSluzbeniJezik
            // 
            this.lblSluzbeniJezik.AutoSize = true;
            this.lblSluzbeniJezik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSluzbeniJezik.Location = new System.Drawing.Point(16, 213);
            this.lblSluzbeniJezik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSluzbeniJezik.Name = "lblSluzbeniJezik";
            this.lblSluzbeniJezik.Size = new System.Drawing.Size(117, 20);
            this.lblSluzbeniJezik.TabIndex = 22;
            this.lblSluzbeniJezik.Text = "Sluzbeni jezik:";
            this.lblSluzbeniJezik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOpis.Location = new System.Drawing.Point(12, 117);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(104, 20);
            this.lblOpis.TabIndex = 21;
            this.lblOpis.Text = "Opis drzave:";
            this.lblOpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGlavniGrad
            // 
            this.lblGlavniGrad.AutoSize = true;
            this.lblGlavniGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGlavniGrad.Location = new System.Drawing.Point(16, 54);
            this.lblGlavniGrad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGlavniGrad.Name = "lblGlavniGrad";
            this.lblGlavniGrad.Size = new System.Drawing.Size(99, 20);
            this.lblGlavniGrad.TabIndex = 20;
            this.lblGlavniGrad.Text = "Glavni grad:";
            this.lblGlavniGrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIme.Location = new System.Drawing.Point(16, 11);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(96, 20);
            this.lblIme.TabIndex = 19;
            this.lblIme.Text = "Ime drzave:";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrzavaDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 255);
            this.Controls.Add(this.gbImaMore);
            this.Controls.Add(this.btnDodajDrzavu);
            this.Controls.Add(this.tbGradovi);
            this.Controls.Add(this.tbSluzbeniJezik);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbGlavniGrad);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lblListaGradova);
            this.Controls.Add(this.lblSluzbeniJezik);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblGlavniGrad);
            this.Controls.Add(this.lblIme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DrzavaDodavanje";
            this.Text = "Drzava Dodavanje";
            this.gbImaMore.ResumeLayout(false);
            this.gbImaMore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbImaMore;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Button btnDodajDrzavu;
        private System.Windows.Forms.TextBox tbGradovi;
        private System.Windows.Forms.TextBox tbSluzbeniJezik;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.TextBox tbGlavniGrad;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lblListaGradova;
        private System.Windows.Forms.Label lblSluzbeniJezik;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblGlavniGrad;
        private System.Windows.Forms.Label lblIme;
    }
}