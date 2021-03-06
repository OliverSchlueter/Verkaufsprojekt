
namespace Verkaufsprojekt.Formulare {
    partial class RegistierenForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_geburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_passwort = new System.Windows.Forms.TextBox();
            this.btn_registieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vorname:";
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(17, 86);
            this.tb_vorname.MaxLength = 255;
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(325, 37);
            this.tb_vorname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(357, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nachname:";
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(362, 86);
            this.tb_nachname.MaxLength = 255;
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(325, 37);
            this.tb_nachname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(357, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nickname:";
            // 
            // tb_nickname
            // 
            this.tb_nickname.Location = new System.Drawing.Point(362, 177);
            this.tb_nickname.MaxLength = 255;
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(325, 37);
            this.tb_nickname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(17, 177);
            this.tb_email.MaxLength = 255;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(325, 37);
            this.tb_email.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Geburtsdatum:";
            // 
            // dtp_geburtsdatum
            // 
            this.dtp_geburtsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_geburtsdatum.Location = new System.Drawing.Point(17, 268);
            this.dtp_geburtsdatum.Name = "dtp_geburtsdatum";
            this.dtp_geburtsdatum.Size = new System.Drawing.Size(325, 37);
            this.dtp_geburtsdatum.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(357, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Passwort:";
            // 
            // tb_passwort
            // 
            this.tb_passwort.Location = new System.Drawing.Point(362, 270);
            this.tb_passwort.MaxLength = 255;
            this.tb_passwort.Name = "tb_passwort";
            this.tb_passwort.Size = new System.Drawing.Size(325, 37);
            this.tb_passwort.TabIndex = 15;
            // 
            // btn_registieren
            // 
            this.btn_registieren.BackColor = System.Drawing.Color.Aqua;
            this.btn_registieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registieren.ForeColor = System.Drawing.Color.Teal;
            this.btn_registieren.Location = new System.Drawing.Point(12, 343);
            this.btn_registieren.Name = "btn_registieren";
            this.btn_registieren.Size = new System.Drawing.Size(161, 44);
            this.btn_registieren.TabIndex = 17;
            this.btn_registieren.Text = "Registieren";
            this.btn_registieren.UseVisualStyleBackColor = false;
            this.btn_registieren.Click += new System.EventHandler(this.btn_registieren_Click);
            // 
            // RegistierenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 429);
            this.Controls.Add(this.btn_registieren);
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
            this.Name = "RegistierenForm";
            this.Text = "Registieren";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistierenForm_FormClosing);
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
            this.Controls.SetChildIndex(this.btn_registieren, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_geburtsdatum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_passwort;
        private System.Windows.Forms.Button btn_registieren;
    }
}