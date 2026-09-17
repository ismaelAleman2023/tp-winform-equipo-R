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
            this.pnlContenedorMarca = new System.Windows.Forms.Panel();
            this.btnListarMarca = new System.Windows.Forms.Button();
            this.btnSalirMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(256, 10);
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
            this.btnAgregarMarca.Location = new System.Drawing.Point(612, 93);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(119, 42);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "AGREGAR";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.BackColor = System.Drawing.Color.White;
            this.btnEliminarMarca.Location = new System.Drawing.Point(612, 165);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(119, 47);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "ELIMINAR";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.BackColor = System.Drawing.Color.White;
            this.btnModificarMarca.Location = new System.Drawing.Point(612, 258);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(119, 44);
            this.btnModificarMarca.TabIndex = 3;
            this.btnModificarMarca.Text = "MODIFICAR";
            this.btnModificarMarca.UseVisualStyleBackColor = false;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // pnlContenedorMarca
            // 
            this.pnlContenedorMarca.Location = new System.Drawing.Point(28, 93);
            this.pnlContenedorMarca.Name = "pnlContenedorMarca";
            this.pnlContenedorMarca.Size = new System.Drawing.Size(567, 385);
            this.pnlContenedorMarca.TabIndex = 4;
            // 
            // btnListarMarca
            // 
            this.btnListarMarca.BackColor = System.Drawing.Color.White;
            this.btnListarMarca.Location = new System.Drawing.Point(612, 337);
            this.btnListarMarca.Name = "btnListarMarca";
            this.btnListarMarca.Size = new System.Drawing.Size(119, 47);
            this.btnListarMarca.TabIndex = 5;
            this.btnListarMarca.Text = "LISTAR";
            this.btnListarMarca.UseVisualStyleBackColor = false;
            this.btnListarMarca.Click += new System.EventHandler(this.btnListarMarca_Click);
            // 
            // btnSalirMarca
            // 
            this.btnSalirMarca.BackColor = System.Drawing.Color.White;
            this.btnSalirMarca.Location = new System.Drawing.Point(612, 422);
            this.btnSalirMarca.Name = "btnSalirMarca";
            this.btnSalirMarca.Size = new System.Drawing.Size(119, 47);
            this.btnSalirMarca.TabIndex = 6;
            this.btnSalirMarca.Text = "SALIR";
            this.btnSalirMarca.UseVisualStyleBackColor = true;
            this.btnSalirMarca.Click += new System.EventHandler(this.btnSalirMarca_Click);
            // 
            // frmAdminMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.btnSalirMarca);
            this.Controls.Add(this.btnListarMarca);
            this.Controls.Add(this.pnlContenedorMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmAdminMarca";
            this.Text = "frmAdminMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Panel pnlContenedorMarca;
        private System.Windows.Forms.Button btnListarMarca;
        private System.Windows.Forms.Button btnSalirMarca;
    }
}