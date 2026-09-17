namespace TPWinForm_equipo_R
{
    partial class FrmAdminPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnArt = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.pnlConteCentral = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.btnCate);
            this.panel1.Controls.Add(this.btnArt);
            this.panel1.Controls.Add(this.btnMarca);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 91);
            this.panel1.TabIndex = 0;
            // 
            // btnCate
            // 
            this.btnCate.Location = new System.Drawing.Point(601, 34);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(140, 35);
            this.btnCate.TabIndex = 1;
            this.btnCate.Text = "Categoria";
            this.btnCate.UseVisualStyleBackColor = true;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(122, 34);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(140, 35);
            this.btnArt.TabIndex = 0;
            this.btnArt.Text = "Articulo";
            this.btnArt.UseVisualStyleBackColor = true;
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(350, 34);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(140, 35);
            this.btnMarca.TabIndex = 0;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // pnlConteCentral
            // 
            this.pnlConteCentral.Location = new System.Drawing.Point(22, 105);
            this.pnlConteCentral.MaximumSize = new System.Drawing.Size(800, 550);
            this.pnlConteCentral.MinimumSize = new System.Drawing.Size(800, 550);
            this.pnlConteCentral.Name = "pnlConteCentral";
            this.pnlConteCentral.Size = new System.Drawing.Size(800, 550);
            this.pnlConteCentral.TabIndex = 1;
            // 
            // FrmAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 671);
            this.Controls.Add(this.pnlConteCentral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "FrmAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlConteCentral;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.Button btnMarca;
    }
}