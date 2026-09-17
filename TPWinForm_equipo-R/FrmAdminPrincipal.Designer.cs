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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnCate
            // 
            this.btnCate.Location = new System.Drawing.Point(801, 42);
            this.btnCate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(187, 43);
            this.btnCate.TabIndex = 1;
            this.btnCate.Text = "Categoria";
            this.btnCate.UseVisualStyleBackColor = true;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(163, 42);
            this.btnArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(187, 43);
            this.btnArt.TabIndex = 0;
            this.btnArt.Text = "Articulo";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.btnArt_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(467, 42);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(187, 43);
            this.btnMarca.TabIndex = 0;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // pnlConteCentral
            // 
            this.pnlConteCentral.Location = new System.Drawing.Point(29, 129);
            this.pnlConteCentral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlConteCentral.MaximumSize = new System.Drawing.Size(1067, 677);
            this.pnlConteCentral.MinimumSize = new System.Drawing.Size(1067, 677);
            this.pnlConteCentral.Name = "pnlConteCentral";
            this.pnlConteCentral.Size = new System.Drawing.Size(1067, 677);
            this.pnlConteCentral.TabIndex = 1;
            // 
            // FrmAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 826);
            this.Controls.Add(this.pnlConteCentral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1067, 677);
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