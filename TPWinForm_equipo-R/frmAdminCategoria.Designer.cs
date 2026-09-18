namespace TPWinForm_equipo_R
{
    partial class fmAdmiCategoria
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
            this.btnAgregarCate = new System.Windows.Forms.Button();
            this.btnEliminarCate = new System.Windows.Forms.Button();
            this.btnModificarCate = new System.Windows.Forms.Button();
            this.btnSalirCate = new System.Windows.Forms.Button();
            this.pnlContenedorCate = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarCate
            // 
            this.btnAgregarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCate.Location = new System.Drawing.Point(496, 43);
            this.btnAgregarCate.Name = "btnAgregarCate";
            this.btnAgregarCate.Size = new System.Drawing.Size(86, 31);
            this.btnAgregarCate.TabIndex = 1;
            this.btnAgregarCate.Text = "Agregar";
            this.btnAgregarCate.UseVisualStyleBackColor = true;
            this.btnAgregarCate.Click += new System.EventHandler(this.btnAgregarCate_Click);
            // 
            // btnEliminarCate
            // 
            this.btnEliminarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCate.Location = new System.Drawing.Point(496, 152);
            this.btnEliminarCate.Name = "btnEliminarCate";
            this.btnEliminarCate.Size = new System.Drawing.Size(86, 31);
            this.btnEliminarCate.TabIndex = 2;
            this.btnEliminarCate.Text = "Eliminar";
            this.btnEliminarCate.UseVisualStyleBackColor = true;
            this.btnEliminarCate.Click += new System.EventHandler(this.btnEliminarCate_Click);
            // 
            // btnModificarCate
            // 
            this.btnModificarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCate.Location = new System.Drawing.Point(496, 263);
            this.btnModificarCate.Name = "btnModificarCate";
            this.btnModificarCate.Size = new System.Drawing.Size(86, 31);
            this.btnModificarCate.TabIndex = 3;
            this.btnModificarCate.Text = "Modificar";
            this.btnModificarCate.UseVisualStyleBackColor = true;
            this.btnModificarCate.Click += new System.EventHandler(this.btnModificarCate_Click);
            // 
            // btnSalirCate
            // 
            this.btnSalirCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCate.Location = new System.Drawing.Point(496, 371);
            this.btnSalirCate.Name = "btnSalirCate";
            this.btnSalirCate.Size = new System.Drawing.Size(86, 31);
            this.btnSalirCate.TabIndex = 4;
            this.btnSalirCate.Text = "Salir";
            this.btnSalirCate.UseVisualStyleBackColor = false;
            this.btnSalirCate.Click += new System.EventHandler(this.btnSalirCate_Click);
            // 
            // pnlContenedorCate
            // 
            this.pnlContenedorCate.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorCate.Location = new System.Drawing.Point(12, 43);
            this.pnlContenedorCate.MaximumSize = new System.Drawing.Size(458, 359);
            this.pnlContenedorCate.MinimumSize = new System.Drawing.Size(458, 359);
            this.pnlContenedorCate.Name = "pnlContenedorCate";
            this.pnlContenedorCate.Size = new System.Drawing.Size(458, 359);
            this.pnlContenedorCate.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(162, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(139, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = " Categoria";
            // 
            // fmAdmiCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlContenedorCate);
            this.Controls.Add(this.btnSalirCate);
            this.Controls.Add(this.btnModificarCate);
            this.Controls.Add(this.btnEliminarCate);
            this.Controls.Add(this.btnAgregarCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 418);
            this.MinimumSize = new System.Drawing.Size(600, 418);
            this.Name = "fmAdmiCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarCate;
        private System.Windows.Forms.Button btnEliminarCate;
        private System.Windows.Forms.Button btnModificarCate;
        private System.Windows.Forms.Button btnSalirCate;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Panel pnlContenedorCate;
    }
}