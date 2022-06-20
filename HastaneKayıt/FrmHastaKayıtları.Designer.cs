namespace HastaneKayıt
{
    partial class FrmHastaKayıtları
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
            this.BtnSil = new System.Windows.Forms.Button();
            this.datakayıtlar = new System.Windows.Forms.DataGridView();
            this.doktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrandevu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datakayıtlar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(229, 552);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(216, 49);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // datakayıtlar
            // 
            this.datakayıtlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datakayıtlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datakayıtlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datakayıtlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakayıtlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktor,
            this.tarih,
            this.saat,
            this.tcno});
            this.datakayıtlar.Location = new System.Drawing.Point(80, 31);
            this.datakayıtlar.Name = "datakayıtlar";
            this.datakayıtlar.RowTemplate.Height = 24;
            this.datakayıtlar.Size = new System.Drawing.Size(517, 425);
            this.datakayıtlar.TabIndex = 7;
            this.datakayıtlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datakayıtlar_CellContentClick);
            // 
            // doktor
            // 
            this.doktor.HeaderText = "DOKTOR";
            this.doktor.Name = "doktor";
            // 
            // tarih
            // 
            this.tarih.HeaderText = "TARİH";
            this.tarih.Name = "tarih";
            // 
            // saat
            // 
            this.saat.HeaderText = "SAAT";
            this.saat.Name = "saat";
            // 
            // tcno
            // 
            this.tcno.HeaderText = "TC NO";
            this.tcno.Name = "tcno";
            // 
            // btnrandevu
            // 
            this.btnrandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevu.Location = new System.Drawing.Point(229, 480);
            this.btnrandevu.Name = "btnrandevu";
            this.btnrandevu.Size = new System.Drawing.Size(216, 49);
            this.btnrandevu.TabIndex = 8;
            this.btnrandevu.Text = "Randevu Oluştur";
            this.btnrandevu.UseVisualStyleBackColor = true;
            this.btnrandevu.Click += new System.EventHandler(this.btnrandevu_Click);
            // 
            // FrmHastaKayıtları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(675, 631);
            this.Controls.Add(this.btnrandevu);
            this.Controls.Add(this.datakayıtlar);
            this.Controls.Add(this.BtnSil);
            this.Name = "FrmHastaKayıtları";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA KAYITLARI";
            this.Load += new System.EventHandler(this.FrmHastaKayıtları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datakayıtlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.DataGridView datakayıtlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcno;
        private System.Windows.Forms.Button btnrandevu;
    }
}