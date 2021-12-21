
namespace Verkaufsprojekt.Formulare {
    partial class GekaufteProdukteForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GekaufteProdukteForm));
            this.dgv_produkte = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtb_beschreibung = new System.Windows.Forms.RichTextBox();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.lbl_preis = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bewertung_sterne = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtb_bewertung = new System.Windows.Forms.RichTextBox();
            this.btn_bewerten = new System.Windows.Forms.Button();
            this.dgv_bewertungen = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bewertung_sterne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bewertungen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_produkte
            // 
            this.dgv_produkte.AllowUserToAddRows = false;
            this.dgv_produkte.AllowUserToDeleteRows = false;
            this.dgv_produkte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_produkte.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_produkte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_produkte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produkte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_produkte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_produkte.Location = new System.Drawing.Point(0, 41);
            this.dgv_produkte.MultiSelect = false;
            this.dgv_produkte.Name = "dgv_produkte";
            this.dgv_produkte.ReadOnly = true;
            this.dgv_produkte.RowHeadersWidth = 62;
            this.dgv_produkte.RowTemplate.Height = 28;
            this.dgv_produkte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produkte.Size = new System.Drawing.Size(1034, 320);
            this.dgv_produkte.TabIndex = 4;
            this.dgv_produkte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produkte_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "Preis";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // rtb_beschreibung
            // 
            this.rtb_beschreibung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_beschreibung.Location = new System.Drawing.Point(13, 511);
            this.rtb_beschreibung.Name = "rtb_beschreibung";
            this.rtb_beschreibung.ReadOnly = true;
            this.rtb_beschreibung.Size = new System.Drawing.Size(1010, 218);
            this.rtb_beschreibung.TabIndex = 23;
            this.rtb_beschreibung.Text = resources.GetString("rtb_beschreibung.Text");
            // 
            // lbl_datum
            // 
            this.lbl_datum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_datum.Location = new System.Drawing.Point(505, 420);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(203, 42);
            this.lbl_datum.TabIndex = 22;
            this.lbl_datum.Text = "XX.XX.XXXX";
            this.lbl_datum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_preis
            // 
            this.lbl_preis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_preis.Location = new System.Drawing.Point(178, 420);
            this.lbl_preis.Name = "lbl_preis";
            this.lbl_preis.Size = new System.Drawing.Size(144, 42);
            this.lbl_preis.TabIndex = 21;
            this.lbl_preis.Text = "XXX,xx €";
            this.lbl_preis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_name.Location = new System.Drawing.Point(505, 373);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(404, 42);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "XXXXXXXX";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id.Location = new System.Drawing.Point(178, 373);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(83, 42);
            this.lbl_id.TabIndex = 19;
            this.lbl_id.Text = "XXXXX";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "Beschreibung:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(340, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "Preis:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(340, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_bewertung_sterne
            // 
            this.tb_bewertung_sterne.LargeChange = 2;
            this.tb_bewertung_sterne.Location = new System.Drawing.Point(275, 739);
            this.tb_bewertung_sterne.Maximum = 5;
            this.tb_bewertung_sterne.Minimum = 1;
            this.tb_bewertung_sterne.Name = "tb_bewertung_sterne";
            this.tb_bewertung_sterne.Size = new System.Drawing.Size(224, 69);
            this.tb_bewertung_sterne.TabIndex = 24;
            this.tb_bewertung_sterne.Value = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 739);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 42);
            this.label6.TabIndex = 25;
            this.label6.Text = "Bewertung abgeben:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(283, 774);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 34);
            this.label7.TabIndex = 26;
            this.label7.Text = "1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(470, 774);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 34);
            this.label8.TabIndex = 27;
            this.label8.Text = "5";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_bewertung
            // 
            this.rtb_bewertung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_bewertung.DetectUrls = false;
            this.rtb_bewertung.Location = new System.Drawing.Point(13, 811);
            this.rtb_bewertung.Name = "rtb_bewertung";
            this.rtb_bewertung.Size = new System.Drawing.Size(486, 174);
            this.rtb_bewertung.TabIndex = 28;
            this.rtb_bewertung.Text = "Hier Kommentar einfügen.";
            // 
            // btn_bewerten
            // 
            this.btn_bewerten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bewerten.Location = new System.Drawing.Point(516, 811);
            this.btn_bewerten.Name = "btn_bewerten";
            this.btn_bewerten.Size = new System.Drawing.Size(137, 82);
            this.btn_bewerten.TabIndex = 29;
            this.btn_bewerten.Text = "Bewerten";
            this.btn_bewerten.UseVisualStyleBackColor = true;
            this.btn_bewerten.Click += new System.EventHandler(this.btn_bewerten_Click);
            // 
            // dgv_bewertungen
            // 
            this.dgv_bewertungen.AllowUserToAddRows = false;
            this.dgv_bewertungen.AllowUserToDeleteRows = false;
            this.dgv_bewertungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bewertungen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_bewertungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bewertungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bewertungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_bewertungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_bewertungen.Location = new System.Drawing.Point(1083, 669);
            this.dgv_bewertungen.MultiSelect = false;
            this.dgv_bewertungen.Name = "dgv_bewertungen";
            this.dgv_bewertungen.ReadOnly = true;
            this.dgv_bewertungen.RowHeadersWidth = 62;
            this.dgv_bewertungen.RowTemplate.Height = 28;
            this.dgv_bewertungen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bewertungen.Size = new System.Drawing.Size(1034, 320);
            this.dgv_bewertungen.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1078, 624);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 42);
            this.label9.TabIndex = 31;
            this.label9.Text = "Bewertungen:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60F;
            this.Column4.HeaderText = "Benutzer";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "Sterne";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kommentar";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // GekaufteProdukteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2129, 1001);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_bewertungen);
            this.Controls.Add(this.btn_bewerten);
            this.Controls.Add(this.rtb_bewertung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_bewertung_sterne);
            this.Controls.Add(this.rtb_beschreibung);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_preis);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_produkte);
            this.Name = "GekaufteProdukteForm";
            this.Text = "Gekaufte Produkte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GekaufteProdukteForm_FormClosing);
            this.Load += new System.EventHandler(this.GekaufteProdukteForm_Load);
            this.Controls.SetChildIndex(this.dgv_produkte, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lbl_id, 0);
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.lbl_preis, 0);
            this.Controls.SetChildIndex(this.lbl_datum, 0);
            this.Controls.SetChildIndex(this.rtb_beschreibung, 0);
            this.Controls.SetChildIndex(this.tb_bewertung_sterne, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.rtb_bewertung, 0);
            this.Controls.SetChildIndex(this.btn_bewerten, 0);
            this.Controls.SetChildIndex(this.dgv_bewertungen, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bewertung_sterne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bewertungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_produkte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.RichTextBox rtb_beschreibung;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_preis;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_bewertung_sterne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtb_bewertung;
        private System.Windows.Forms.Button btn_bewerten;
        private System.Windows.Forms.DataGridView dgv_bewertungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label9;
    }
}