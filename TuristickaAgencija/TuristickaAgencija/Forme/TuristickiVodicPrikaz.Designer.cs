
namespace TuristickaAgencija.Forme
{
    partial class TuristickiVodicPrikaz
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblUTurizmu = new System.Windows.Forms.Label();
            this.lblNaDestinaciji = new System.Windows.Forms.Label();
            this.lblJezici = new System.Windows.Forms.Label();
            this.tbJezici = new System.Windows.Forms.TextBox();
            this.btnAzurirajVodica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIme.Location = new System.Drawing.Point(61, 36);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(508, 34);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime vodica";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUTurizmu
            // 
            this.lblUTurizmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUTurizmu.Location = new System.Drawing.Point(16, 70);
            this.lblUTurizmu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUTurizmu.Name = "lblUTurizmu";
            this.lblUTurizmu.Size = new System.Drawing.Size(312, 37);
            this.lblUTurizmu.TabIndex = 1;
            this.lblUTurizmu.Text = "U turizmu";
            this.lblUTurizmu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNaDestinaciji
            // 
            this.lblNaDestinaciji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNaDestinaciji.Location = new System.Drawing.Point(16, 121);
            this.lblNaDestinaciji.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaDestinaciji.Name = "lblNaDestinaciji";
            this.lblNaDestinaciji.Size = new System.Drawing.Size(312, 34);
            this.lblNaDestinaciji.TabIndex = 2;
            this.lblNaDestinaciji.Text = "Na destinaciji";
            this.lblNaDestinaciji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJezici
            // 
            this.lblJezici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblJezici.Location = new System.Drawing.Point(336, 79);
            this.lblJezici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJezici.Name = "lblJezici";
            this.lblJezici.Size = new System.Drawing.Size(259, 28);
            this.lblJezici.TabIndex = 3;
            this.lblJezici.Text = "Govori jezika";
            this.lblJezici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbJezici
            // 
            this.tbJezici.Location = new System.Drawing.Point(340, 111);
            this.tbJezici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJezici.Multiline = true;
            this.tbJezici.Name = "tbJezici";
            this.tbJezici.ReadOnly = true;
            this.tbJezici.Size = new System.Drawing.Size(253, 72);
            this.tbJezici.TabIndex = 4;
            // 
            // btnAzurirajVodica
            // 
            this.btnAzurirajVodica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAzurirajVodica.Location = new System.Drawing.Point(95, 159);
            this.btnAzurirajVodica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzurirajVodica.Name = "btnAzurirajVodica";
            this.btnAzurirajVodica.Size = new System.Drawing.Size(151, 49);
            this.btnAzurirajVodica.TabIndex = 5;
            this.btnAzurirajVodica.Text = "Azuriraj vodica";
            this.btnAzurirajVodica.UseVisualStyleBackColor = true;
            this.btnAzurirajVodica.Click += new System.EventHandler(this.btnAzurirajVodica_Click);
            // 
            // TuristickiVodicPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(620, 234);
            this.Controls.Add(this.btnAzurirajVodica);
            this.Controls.Add(this.tbJezici);
            this.Controls.Add(this.lblJezici);
            this.Controls.Add(this.lblNaDestinaciji);
            this.Controls.Add(this.lblUTurizmu);
            this.Controls.Add(this.lblIme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TuristickiVodicPrikaz";
            this.Text = "TuristickiVodicPrikaz";
            this.Load += new System.EventHandler(this.TuristickiVodicPrikaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblUTurizmu;
        private System.Windows.Forms.Label lblNaDestinaciji;
        private System.Windows.Forms.Label lblJezici;
        private System.Windows.Forms.TextBox tbJezici;
        private System.Windows.Forms.Button btnAzurirajVodica;
    }
}