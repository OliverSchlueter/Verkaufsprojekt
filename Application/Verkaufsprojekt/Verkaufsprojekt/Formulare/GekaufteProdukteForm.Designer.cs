
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).BeginInit();
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
            this.dgv_produkte.Size = new System.Drawing.Size(1034, 430);
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
            this.rtb_beschreibung.Location = new System.Drawing.Point(12, 622);
            this.rtb_beschreibung.Name = "rtb_beschreibung";
            this.rtb_beschreibung.ReadOnly = true;
            this.rtb_beschreibung.Size = new System.Drawing.Size(1010, 218);
            this.rtb_beschreibung.TabIndex = 23;
            this.rtb_beschreibung.Text = resources.GetString("rtb_beschreibung.Text");
            // 
            // lbl_datum
            // 
            this.lbl_datum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_datum.Location = new System.Drawing.Point(504, 531);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(203, 42);
            this.lbl_datum.TabIndex = 22;
            this.lbl_datum.Text = "XX.XX.XXXX";
            this.lbl_datum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_preis
            // 
            this.lbl_preis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_preis.Location = new System.Drawing.Point(177, 531);
            this.lbl_preis.Name = "lbl_preis";
            this.lbl_preis.Size = new System.Drawing.Size(144, 42);
            this.lbl_preis.TabIndex = 21;
            this.lbl_preis.Text = "XXX,xx €";
            this.lbl_preis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_name.Location = new System.Drawing.Point(504, 484);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(404, 42);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "XXXXXXXX";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_id
            // 
            this.lbl_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id.Location = new System.Drawing.Point(177, 484);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(83, 42);
            this.lbl_id.TabIndex = 19;
            this.lbl_id.Text = "XXXXX";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "Beschreibung:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(339, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "Datum:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "Preis:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(339, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GekaufteProdukteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 859);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produkte)).EndInit();
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
    }
}