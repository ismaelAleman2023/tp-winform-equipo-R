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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbAdministrar = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.lbAdministrar);
            this.panel1.Controls.Add(this.btnCate);
            this.panel1.Controls.Add(this.btnArt);
            this.panel1.Controls.Add(this.btnMarca);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 129);
            this.panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.Location = new System.Drawing.Point(69, 69);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(133, 43);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lbAdministrar
            // 
            this.lbAdministrar.AutoSize = true;
            this.lbAdministrar.BackColor = System.Drawing.Color.Transparent;
            this.lbAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdministrar.Location = new System.Drawing.Point(328, 21);
            this.lbAdministrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAdministrar.Name = "lbAdministrar";
            this.lbAdministrar.Size = new System.Drawing.Size(255, 39);
            this.lbAdministrar.TabIndex = 2;
            this.lbAdministrar.Text = "ADMINISTRAR";
            // 
            // btnCate
            // 
            this.btnCate.Location = new System.Drawing.Point(736, 69);
            this.btnCate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(133, 43);
            this.btnCate.TabIndex = 2;
            this.btnCate.Text = "Categoria";
            this.btnCate.UseVisualStyleBackColor = true;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnArt
            // 
            this.btnArt.Location = new System.Drawing.Point(291, 69);
            this.btnArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(133, 43);
            this.btnArt.TabIndex = 0;
            this.btnArt.Text = "Articulo";
            this.btnArt.UseVisualStyleBackColor = true;
            this.btnArt.Click += new System.EventHandler(this.btnArt_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(504, 69);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(133, 43);
            this.btnMarca.TabIndex = 1;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // pnlConteCentral
            // 
            this.pnlConteCentral.Location = new System.Drawing.Point(67, 145);
            this.pnlConteCentral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlConteCentral.MaximumSize = new System.Drawing.Size(800, 514);
            this.pnlConteCentral.MinimumSize = new System.Drawing.Size(800, 514);
            this.pnlConteCentral.Name = "pnlConteCentral";
            this.pnlConteCentral.Size = new System.Drawing.Size(800, 514);
            this.pnlConteCentral.TabIndex = 0;
            this.pnlConteCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConteCentral_Paint);
            // 
            // FrmAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 673);
            this.Controls.Add(this.pnlConteCentral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminPrincipal";
            this.Load += new System.EventHandler(this.FrmAdminPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnArt;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbAdministrar;
        public System.Windows.Forms.Panel pnlConteCentral;
    }
}