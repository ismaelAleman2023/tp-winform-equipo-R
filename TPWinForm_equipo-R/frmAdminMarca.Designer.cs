namespace TPWinForm_equipo_R
{
    partial class frmAdminMarca
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlContenedorMarca = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(79, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Marcas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.AccessibleName = "btnAgregarMarca";
            this.btnAgregarMarca.BackColor = System.Drawing.Color.White;
            this.btnAgregarMarca.Location = new System.Drawing.Point(493, 44);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(86, 31);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "AGREGAR";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.BackColor = System.Drawing.Color.White;
            this.btnEliminarMarca.Location = new System.Drawing.Point(493, 144);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(86, 31);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "ELIMINAR";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.BackColor = System.Drawing.Color.White;
            this.btnModificarMarca.Location = new System.Drawing.Point(493, 254);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(86, 31);
            this.btnModificarMarca.TabIndex = 3;
            this.btnModificarMarca.Text = "MODIFICAR";
            this.btnModificarMarca.UseVisualStyleBackColor = false;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(492, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 31);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlContenedorMarca
            // 
            this.pnlContenedorMarca.Location = new System.Drawing.Point(12, 47);
            this.pnlContenedorMarca.MaximumSize = new System.Drawing.Size(458, 359);
            this.pnlContenedorMarca.MinimumSize = new System.Drawing.Size(458, 359);
            this.pnlContenedorMarca.Name = "pnlContenedorMarca";
            this.pnlContenedorMarca.Size = new System.Drawing.Size(458, 359);
            this.pnlContenedorMarca.TabIndex = 6;
            // 
            // frmAdminMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.pnlContenedorMarca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 418);
            this.MinimumSize = new System.Drawing.Size(600, 418);
            this.Name = "frmAdminMarca";
            this.Text = "frmAdminMarca";
            this.Load += new System.EventHandler(this.frmAdminMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlContenedorMarca;
    }
}