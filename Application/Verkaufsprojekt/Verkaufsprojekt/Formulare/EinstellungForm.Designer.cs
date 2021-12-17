
namespace Verkaufsprojekt.Formulare {
    partial class EinstellungForm {
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
            this.label6 = new System.Windows.Forms.Label();
            this.tb_passwort = new System.Windows.Forms.TextBox();
            this.dtp_geburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_aendern = new System.Windows.Forms.Button();
            this.btn_zuruecksetzen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(356, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "Passwort:";
            // 
            // tb_passwort
            // 
            this.tb_passwort.Location = new System.Drawing.Point(361, 342);
            this.tb_passwort.MaxLength = 255;
            this.tb_passwort.Name = "tb_passwort";
            this.tb_passwort.Size = new System.Drawing.Size(325, 37);
            this.tb_passwort.TabIndex = 27;
            this.tb_passwort.TextChanged += new System.EventHandler(this.tb_dtp_valueChanged);
            // 
            // dtp_geburtsdatum
            // 
            this.dtp_geburtsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_geburtsdatum.Location = new System.Drawing.Point(16, 340);
            this.dtp_geburtsdatum.Name = "dtp_geburtsdatum";
            this.dtp_geburtsdatum.Size = new System.Drawing.Size(325, 37);
            this.dtp_geburtsdatum.TabIndex = 26;
            this.dtp_geburtsdatum.ValueChanged += new System.EventHandler(this.tb_dtp_valueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Geburtsdatum:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(16, 249);
            this.tb_email.MaxLength = 255;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(325, 37);
            this.tb_email.TabIndex = 21;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_dtp_valueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(356, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nickname:";
            // 
            // tb_nickname
            // 
            this.tb_nickname.Location = new System.Drawing.Point(361, 249);
            this.tb_nickname.MaxLength = 255;
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(325, 37);
            this.tb_nickname.TabIndex = 23;
            this.tb_nickname.TextChanged += new System.EventHandler(this.tb_dtp_valueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(356, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nachname:";
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(361, 158);
            this.tb_nachname.MaxLength = 255;
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(325, 37);
            this.tb_nachname.TabIndex = 19;
            this.tb_nachname.TextChanged += new System.EventHandler(this.tb_dtp_valueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vorname:";
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(16, 158);
            this.tb_vorname.MaxLength = 255;
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(325, 37);
            this.tb_vorname.TabIndex = 17;
            this.tb_vorname.TextChanged += new System.EventHandler(this.tb_dtp_valueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 30;
            this.label7.Text = "Benutzer ID:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(16, 81);
            this.tb_id.MaxLength = 5;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(149, 37);
            this.tb_id.TabIndex = 29;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_dtp_valueChanged);
            // 
            // btn_aendern
            // 
            this.btn_aendern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aendern.Location = new System.Drawing.Point(16, 415);
            this.btn_aendern.Name = "btn_aendern";
            this.btn_aendern.Size = new System.Drawing.Size(292, 44);
            this.btn_aendern.TabIndex = 31;
            this.btn_aendern.Text = "Änderungen übernehmen";
            this.btn_aendern.UseVisualStyleBackColor = true;
            this.btn_aendern.Click += new System.EventHandler(this.btn_aendern_Click);
            // 
            // btn_zuruecksetzen
            // 
            this.btn_zuruecksetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zuruecksetzen.Location = new System.Drawing.Point(394, 415);
            this.btn_zuruecksetzen.Name = "btn_zuruecksetzen";
            this.btn_zuruecksetzen.Size = new System.Drawing.Size(292, 44);
            this.btn_zuruecksetzen.TabIndex = 32;
            this.btn_zuruecksetzen.Text = "Zurücksetzen";
            this.btn_zuruecksetzen.UseVisualStyleBackColor = true;
            this.btn_zuruecksetzen.Click += new System.EventHandler(this.btn_zuruecksetzen_Click);
            // 
            // EinstellungForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(709, 484);
            this.Controls.Add(this.btn_zuruecksetzen);
            this.Controls.Add(this.btn_aendern);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_passwort);
            this.Controls.Add(this.dtp_geburtsdatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nickname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_vorname);
            this.Name = "EinstellungForm";
            this.Text = "Profil Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EinstellungForm_FormClosing);
            this.Controls.SetChildIndex(this.tb_vorname, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tb_nachname, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tb_nickname, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tb_email, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtp_geburtsdatum, 0);
            this.Controls.SetChildIndex(this.tb_passwort, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tb_id, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btn_aendern, 0);
            this.Controls.SetChildIndex(this.btn_zuruecksetzen, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_passwort;
        private System.Windows.Forms.DateTimePicker dtp_geburtsdatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_aendern;
        private System.Windows.Forms.Button btn_zuruecksetzen;
    }
}