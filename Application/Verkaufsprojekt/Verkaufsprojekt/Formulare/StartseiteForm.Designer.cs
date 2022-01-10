
namespace Verkaufsprojekt.Formulare {
    partial class StartseiteForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_produkt1 = new System.Windows.Forms.Label();
            this.lbl_neueProdukteHeadline = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_mg_1 = new System.Windows.Forms.Label();
            this.lbl_meistGekauftHeadline = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_produkt1);
            this.panel1.Controls.Add(this.lbl_neueProdukteHeadline);
            this.panel1.Location = new System.Drawing.Point(58, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 304);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_produkt1
            // 
            this.lbl_produkt1.Location = new System.Drawing.Point(-1, 69);
            this.lbl_produkt1.Name = "lbl_produkt1";
            this.lbl_produkt1.Size = new System.Drawing.Size(385, 37);
            this.lbl_produkt1.TabIndex = 1;
            this.lbl_produkt1.Text = "Produkt1";
            this.lbl_produkt1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_neueProdukteHeadline
            // 
            this.lbl_neueProdukteHeadline.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_neueProdukteHeadline.ForeColor = System.Drawing.Color.Teal;
            this.lbl_neueProdukteHeadline.Location = new System.Drawing.Point(3, -1);
            this.lbl_neueProdukteHeadline.Name = "lbl_neueProdukteHeadline";
            this.lbl_neueProdukteHeadline.Size = new System.Drawing.Size(381, 56);
            this.lbl_neueProdukteHeadline.TabIndex = 0;
            this.lbl_neueProdukteHeadline.Text = "Neue Produkte";
            this.lbl_neueProdukteHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_mg_1);
            this.panel2.Controls.Add(this.lbl_meistGekauftHeadline);
            this.panel2.Location = new System.Drawing.Point(565, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 304);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_mg_1
            // 
            this.lbl_mg_1.Location = new System.Drawing.Point(-1, 69);
            this.lbl_mg_1.Name = "lbl_mg_1";
            this.lbl_mg_1.Size = new System.Drawing.Size(385, 37);
            this.lbl_mg_1.TabIndex = 1;
            this.lbl_mg_1.Text = "Produkt1";
            this.lbl_mg_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_meistGekauftHeadline
            // 
            this.lbl_meistGekauftHeadline.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meistGekauftHeadline.ForeColor = System.Drawing.Color.Teal;
            this.lbl_meistGekauftHeadline.Location = new System.Drawing.Point(3, -1);
            this.lbl_meistGekauftHeadline.Name = "lbl_meistGekauftHeadline";
            this.lbl_meistGekauftHeadline.Size = new System.Drawing.Size(381, 56);
            this.lbl_meistGekauftHeadline.TabIndex = 0;
            this.lbl_meistGekauftHeadline.Text = "Meist gekaufte Produkte";
            this.lbl_meistGekauftHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartseiteForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1019, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StartseiteForm";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.StartseiteForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_neueProdukteHeadline;
        private System.Windows.Forms.Label lbl_produkt1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_mg_1;
        private System.Windows.Forms.Label lbl_meistGekauftHeadline;
    }
}