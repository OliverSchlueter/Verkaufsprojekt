
namespace Verkaufsprojekt.Formulare {
    partial class BaseForm {
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsm_geheZu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_geheZu_startseite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_geheZu_produkte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_profil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_profil_login = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_profil_registieren = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_profil_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_profil_einstellungen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_geheZu,
            this.tsm_profil});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1011, 38);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsm_geheZu
            // 
            this.tsm_geheZu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_geheZu_startseite,
            this.tsm_geheZu_produkte});
            this.tsm_geheZu.Name = "tsm_geheZu";
            this.tsm_geheZu.Size = new System.Drawing.Size(112, 34);
            this.tsm_geheZu.Text = "Gehe zu";
            // 
            // tsm_geheZu_startseite
            // 
            this.tsm_geheZu_startseite.Name = "tsm_geheZu_startseite";
            this.tsm_geheZu_startseite.Size = new System.Drawing.Size(270, 38);
            this.tsm_geheZu_startseite.Text = "Startseite";
            // 
            // tsm_geheZu_produkte
            // 
            this.tsm_geheZu_produkte.Name = "tsm_geheZu_produkte";
            this.tsm_geheZu_produkte.Size = new System.Drawing.Size(270, 38);
            this.tsm_geheZu_produkte.Text = "Produkte";
            // 
            // tsm_profil
            // 
            this.tsm_profil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsm_profil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_profil_login,
            this.tsm_profil_registieren,
            this.tsm_profil_logout,
            this.tsm_profil_einstellungen});
            this.tsm_profil.Name = "tsm_profil";
            this.tsm_profil.Size = new System.Drawing.Size(80, 34);
            this.tsm_profil.Text = "Profil";
            // 
            // tsm_profil_login
            // 
            this.tsm_profil_login.Name = "tsm_profil_login";
            this.tsm_profil_login.Size = new System.Drawing.Size(270, 38);
            this.tsm_profil_login.Text = "Login";
            // 
            // tsm_profil_registieren
            // 
            this.tsm_profil_registieren.Name = "tsm_profil_registieren";
            this.tsm_profil_registieren.Size = new System.Drawing.Size(270, 38);
            this.tsm_profil_registieren.Text = "Registieren";
            // 
            // tsm_profil_logout
            // 
            this.tsm_profil_logout.Name = "tsm_profil_logout";
            this.tsm_profil_logout.Size = new System.Drawing.Size(270, 38);
            this.tsm_profil_logout.Text = "Logout";
            // 
            // tsm_profil_einstellungen
            // 
            this.tsm_profil_einstellungen.Name = "tsm_profil_einstellungen";
            this.tsm_profil_einstellungen.Size = new System.Drawing.Size(270, 38);
            this.tsm_profil_einstellungen.Text = "Einstellungen";
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 602);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsm_geheZu;
        private System.Windows.Forms.ToolStripMenuItem tsm_geheZu_startseite;
        private System.Windows.Forms.ToolStripMenuItem tsm_geheZu_produkte;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_profil;
        private System.Windows.Forms.ToolStripMenuItem tsm_profil_login;
        private System.Windows.Forms.ToolStripMenuItem tsm_profil_registieren;
        private System.Windows.Forms.ToolStripMenuItem tsm_profil_logout;
        private System.Windows.Forms.ToolStripMenuItem tsm_profil_einstellungen;
    }
}