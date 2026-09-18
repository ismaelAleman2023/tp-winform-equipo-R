namespace TPWinForm_equipo_R
{
    partial class frmArticulo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.ptBImagen = new System.Windows.Forms.PictureBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.lblCodArti = new System.Windows.Forms.Label();
            this.txtIdArt = new System.Windows.Forms.TextBox();
            this.lblIdArt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 83);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 243);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(21, 148);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(21, 116);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(21, 180);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(21, 211);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(42, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(98, 145);
            this.comboMarca.Margin = new System.Windows.Forms.Padding(2);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(153, 21);
            this.comboMarca.TabIndex = 3;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(98, 113);
            this.comboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(153, 21);
            this.comboCategoria.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(98, 177);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(153, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(98, 208);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(2);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(153, 20);
            this.txtImagen.TabIndex = 5;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(98, 241);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(153, 113);
            this.txtDescripcion.TabIndex = 6;
            // 
            // ptBImagen
            // 
            this.ptBImagen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptBImagen.Location = new System.Drawing.Point(285, 42);
            this.ptBImagen.Margin = new System.Windows.Forms.Padding(2);
            this.ptBImagen.Name = "ptBImagen";
            this.ptBImagen.Size = new System.Drawing.Size(162, 170);
            this.ptBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBImagen.TabIndex = 12;
            this.ptBImagen.TabStop = false;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(330, 245);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(88, 37);
            this.btnConfirma.TabIndex = 7;
            this.btnConfirma.Text = "aceptar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(330, 306);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(98, 49);
            this.txtCodArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(153, 20);
            this.txtCodArt.TabIndex = 0;
            // 
            // lblCodArti
            // 
            this.lblCodArti.AutoSize = true;
            this.lblCodArti.Location = new System.Drawing.Point(21, 51);
            this.lblCodArti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArti.Name = "lblCodArti";
            this.lblCodArti.Size = new System.Drawing.Size(64, 13);
            this.lblCodArti.TabIndex = 15;
            this.lblCodArti.Text = "Cod Articulo";
            // 
            // txtIdArt
            // 
            this.txtIdArt.Location = new System.Drawing.Point(98, 17);
            this.txtIdArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdArt.Name = "txtIdArt";
            this.txtIdArt.Size = new System.Drawing.Size(153, 20);
            this.txtIdArt.TabIndex = 18;
            // 
            // lblIdArt
            // 
            this.lblIdArt.AutoSize = true;
            this.lblIdArt.Location = new System.Drawing.Point(21, 19);
            this.lblIdArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdArt.Name = "lblIdArt";
            this.lblIdArt.Size = new System.Drawing.Size(54, 13);
            this.lblIdArt.TabIndex = 17;
            this.lblIdArt.Text = "Id Articulo";
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 368);
            this.ControlBox = false;
            this.Controls.Add(this.txtIdArt);
            this.Controls.Add(this.lblIdArt);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.lblCodArti);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.ptBImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox ptBImagen;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.Label lblCodArti;
        private System.Windows.Forms.TextBox txtIdArt;
        private System.Windows.Forms.Label lblIdArt;
    }
}