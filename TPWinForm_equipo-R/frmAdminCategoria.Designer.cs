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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarCate
            // 
            this.btnAgregarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCate.Location = new System.Drawing.Point(617, 100);
            this.btnAgregarCate.Name = "btnAgregarCate";
            this.btnAgregarCate.Size = new System.Drawing.Size(156, 37);
            this.btnAgregarCate.TabIndex = 0;
            this.btnAgregarCate.Text = "Agregar";
            this.btnAgregarCate.UseVisualStyleBackColor = true;
            this.btnAgregarCate.Click += new System.EventHandler(this.btnAgregarCate_Click);
            // 
            // btnEliminarCate
            // 
            this.btnEliminarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCate.Location = new System.Drawing.Point(617, 208);
            this.btnEliminarCate.Name = "btnEliminarCate";
            this.btnEliminarCate.Size = new System.Drawing.Size(156, 40);
            this.btnEliminarCate.TabIndex = 4;
            this.btnEliminarCate.Text = "Eliminar";
            this.btnEliminarCate.UseVisualStyleBackColor = true;
            this.btnEliminarCate.Click += new System.EventHandler(this.btnEliminarCate_Click);
            // 
            // btnModificarCate
            // 
            this.btnModificarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCate.Location = new System.Drawing.Point(617, 319);
            this.btnModificarCate.Name = "btnModificarCate";
            this.btnModificarCate.Size = new System.Drawing.Size(156, 39);
            this.btnModificarCate.TabIndex = 5;
            this.btnModificarCate.Text = "Modificar";
            this.btnModificarCate.UseVisualStyleBackColor = true;
            // 
            // btnSalirCate
            // 
            this.btnSalirCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirCate.Location = new System.Drawing.Point(617, 444);
            this.btnSalirCate.Name = "btnSalirCate";
            this.btnSalirCate.Size = new System.Drawing.Size(156, 42);
            this.btnSalirCate.TabIndex = 6;
            this.btnSalirCate.Text = "Salir";
            this.btnSalirCate.UseVisualStyleBackColor = false;
            this.btnSalirCate.Click += new System.EventHandler(this.btnSalirCate_Click);
            // 
            // pnlContenedorCate
            // 
            this.pnlContenedorCate.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorCate.Location = new System.Drawing.Point(25, 71);
            this.pnlContenedorCate.Name = "pnlContenedorCate";
            this.pnlContenedorCate.Size = new System.Drawing.Size(563, 451);
            this.pnlContenedorCate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(256, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Administrador Categoria";
            // 
            // fmAdmiCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlContenedorCate);
            this.Controls.Add(this.btnSalirCate);
            this.Controls.Add(this.btnModificarCate);
            this.Controls.Add(this.btnEliminarCate);
            this.Controls.Add(this.btnAgregarCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
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
        private System.Windows.Forms.Panel pnlContenedorCate;
        private System.Windows.Forms.Label label1;
    }
}