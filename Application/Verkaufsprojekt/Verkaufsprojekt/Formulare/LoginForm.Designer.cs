
namespace Verkaufsprojekt.Formulare {
    partial class LoginForm {
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
            this.tb_benutzerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_passwort = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.cb_benutzer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_benutzerID
            // 
            this.tb_benutzerID.Location = new System.Drawing.Point(25, 103);
            this.tb_benutzerID.MaxLength = 5;
            this.tb_benutzerID.Name = "tb_benutzerID";
            this.tb_benutzerID.Size = new System.Drawing.Size(325, 37);
            this.tb_benutzerID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Benutzer ID:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwort:";
            // 
            // tb_passwort
            // 
            this.tb_passwort.Location = new System.Drawing.Point(25, 204);
            this.tb_passwort.Name = "tb_passwort";
            this.tb_passwort.PasswordChar = '*';
            this.tb_passwort.Size = new System.Drawing.Size(325, 37);
            this.tb_passwort.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(25, 292);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(138, 52);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cb_benutzer
            // 
            this.cb_benutzer.FormattingEnabled = true;
            this.cb_benutzer.Items.AddRange(new object[] {
            "Kunde",
            "Gast",
            "Autor",
            "Mitarbeiter"});
            this.cb_benutzer.Location = new System.Drawing.Point(184, 300);
            this.cb_benutzer.Name = "cb_benutzer";
            this.cb_benutzer.Size = new System.Drawing.Size(166, 38);
            this.cb_benutzer.TabIndex = 8;
            this.cb_benutzer.Text = "Kunde";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 370);
            this.Controls.Add(this.cb_benutzer);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_passwort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_benutzerID);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Controls.SetChildIndex(this.tb_benutzerID, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tb_passwort, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_login, 0);
            this.Controls.SetChildIndex(this.cb_benutzer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_benutzerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_passwort;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox cb_benutzer;
    }
}