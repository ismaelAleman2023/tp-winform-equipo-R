namespace TPWinForm_equipo_R
{
    partial class frmAdminArticulo
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
            this.pnlconteArti = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModifical = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlconteArti
            // 
            this.pnlconteArti.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlconteArti.Location = new System.Drawing.Point(11, 35);
            this.pnlconteArti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlconteArti.MaximumSize = new System.Drawing.Size(458, 359);
            this.pnlconteArti.MinimumSize = new System.Drawing.Size(458, 359);
            this.pnlconteArti.Name = "pnlconteArti";
            this.pnlconteArti.Size = new System.Drawing.Size(458, 359);
            this.pnlconteArti.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(494, 64);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(494, 150);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 31);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModifical
            // 
            this.btnModifical.Location = new System.Drawing.Point(494, 235);
            this.btnModifical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifical.Name = "btnModifical";
            this.btnModifical.Size = new System.Drawing.Size(86, 31);
            this.btnModifical.TabIndex = 3;
            this.btnModifical.Text = "Modificar";
            this.btnModifical.UseVisualStyleBackColor = true;
            this.btnModifical.Click += new System.EventHandler(this.btnModifical_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(494, 362);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 31);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAdminArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModifical);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlconteArti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(600, 418);
            this.MinimumSize = new System.Drawing.Size(600, 418);
            this.Name = "frmAdminArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminArticulo";
            this.Load += new System.EventHandler(this.frmAdminArticulo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModifical;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Panel pnlconteArti;
    }
}