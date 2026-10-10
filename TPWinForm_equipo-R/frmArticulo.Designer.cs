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
            this.bntAgregarImagen = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.pnlBtnImagenes = new System.Windows.Forms.Panel();
            this.lblImagenActual = new System.Windows.Forms.Label();
            this.lblContadorImg = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.pnlContador = new System.Windows.Forms.Panel();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptBImagen)).BeginInit();
            this.pnlBtnImagenes.SuspendLayout();
            this.pnlContador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 299);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(28, 182);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(28, 143);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(28, 222);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(28, 260);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(52, 16);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(131, 178);
            this.comboMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(203, 24);
            this.comboMarca.TabIndex = 3;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(131, 139);
            this.comboCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(203, 24);
            this.comboCategoria.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(131, 218);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(203, 22);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(131, 256);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(203, 22);
            this.txtImagen.TabIndex = 5;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 100);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(131, 297);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(203, 138);
            this.txtDescripcion.TabIndex = 6;
            // 
            // ptBImagen
            // 
            this.ptBImagen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptBImagen.Location = new System.Drawing.Point(367, 21);
            this.ptBImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptBImagen.Name = "ptBImagen";
            this.ptBImagen.Size = new System.Drawing.Size(216, 209);
            this.ptBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBImagen.TabIndex = 12;
            this.ptBImagen.TabStop = false;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(483, 368);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(117, 46);
            this.btnConfirma.TabIndex = 7;
            this.btnConfirma.Text = "aceptar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(349, 368);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(131, 60);
            this.txtCodArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(203, 22);
            this.txtCodArt.TabIndex = 0;
            // 
            // lblCodArti
            // 
            this.lblCodArti.AutoSize = true;
            this.lblCodArti.Location = new System.Drawing.Point(28, 63);
            this.lblCodArti.Name = "lblCodArti";
            this.lblCodArti.Size = new System.Drawing.Size(79, 16);
            this.lblCodArti.TabIndex = 15;
            this.lblCodArti.Text = "Cod Articulo";
            // 
            // txtIdArt
            // 
            this.txtIdArt.Location = new System.Drawing.Point(131, 21);
            this.txtIdArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdArt.Name = "txtIdArt";
            this.txtIdArt.Size = new System.Drawing.Size(203, 22);
            this.txtIdArt.TabIndex = 18;
            // 
            // lblIdArt
            // 
            this.lblIdArt.AutoSize = true;
            this.lblIdArt.Location = new System.Drawing.Point(28, 23);
            this.lblIdArt.Name = "lblIdArt";
            this.lblIdArt.Size = new System.Drawing.Size(65, 16);
            this.lblIdArt.TabIndex = 17;
            this.lblIdArt.Text = "Id Articulo";
            // 
            // bntAgregarImagen
            // 
            this.bntAgregarImagen.Location = new System.Drawing.Point(357, 252);
            this.bntAgregarImagen.Name = "bntAgregarImagen";
            this.bntAgregarImagen.Size = new System.Drawing.Size(125, 30);
            this.bntAgregarImagen.TabIndex = 19;
            this.bntAgregarImagen.Text = "Agregar imagen";
            this.bntAgregarImagen.UseVisualStyleBackColor = true;
            this.bntAgregarImagen.Click += new System.EventHandler(this.bntAgregarImagen_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(42, 1);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(24, 28);
            this.btnAnterior.TabIndex = 20;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(116, 1);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(24, 28);
            this.btnSiguiente.TabIndex = 21;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.Location = new System.Drawing.Point(105, 35);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(61, 16);
            this.lblSiguiente.TabIndex = 22;
            this.lblSiguiente.Text = "siguiente";
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Location = new System.Drawing.Point(29, 35);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(52, 16);
            this.lblAnterior.TabIndex = 23;
            this.lblAnterior.Text = "anterior";
            // 
            // pnlBtnImagenes
            // 
            this.pnlBtnImagenes.Controls.Add(this.lblImagenActual);
            this.pnlBtnImagenes.Controls.Add(this.btnAnterior);
            this.pnlBtnImagenes.Controls.Add(this.btnSiguiente);
            this.pnlBtnImagenes.Controls.Add(this.lblSiguiente);
            this.pnlBtnImagenes.Controls.Add(this.lblAnterior);
            this.pnlBtnImagenes.Location = new System.Drawing.Point(338, 299);
            this.pnlBtnImagenes.Name = "pnlBtnImagenes";
            this.pnlBtnImagenes.Size = new System.Drawing.Size(185, 54);
            this.pnlBtnImagenes.TabIndex = 24;
            this.pnlBtnImagenes.Visible = false;
            // 
            // lblImagenActual
            // 
            this.lblImagenActual.AutoSize = true;
            this.lblImagenActual.Location = new System.Drawing.Point(82, 8);
            this.lblImagenActual.Name = "lblImagenActual";
            this.lblImagenActual.Size = new System.Drawing.Size(0, 16);
            this.lblImagenActual.TabIndex = 24;
            // 
            // lblContadorImg
            // 
            this.lblContadorImg.AutoSize = true;
            this.lblContadorImg.Location = new System.Drawing.Point(5, 8);
            this.lblContadorImg.Name = "lblContadorImg";
            this.lblContadorImg.Size = new System.Drawing.Size(61, 16);
            this.lblContadorImg.TabIndex = 25;
            this.lblContadorImg.Text = "cargado:";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(66, 9);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(21, 16);
            this.lblCont.TabIndex = 26;
            this.lblCont.Text = "10";
            // 
            // pnlContador
            // 
            this.pnlContador.Controls.Add(this.lblCont);
            this.pnlContador.Controls.Add(this.lblContadorImg);
            this.pnlContador.Location = new System.Drawing.Point(483, 251);
            this.pnlContador.Name = "pnlContador";
            this.pnlContador.Size = new System.Drawing.Size(105, 35);
            this.pnlContador.TabIndex = 27;
            this.pnlContador.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(525, 302);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 47);
            this.btneliminar.TabIndex = 28;
            this.btneliminar.Text = "Eliminar imagen";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.pnlContador);
            this.Controls.Add(this.pnlBtnImagenes);
            this.Controls.Add(this.bntAgregarImagen);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBImagen)).EndInit();
            this.pnlBtnImagenes.ResumeLayout(false);
            this.pnlBtnImagenes.PerformLayout();
            this.pnlContador.ResumeLayout(false);
            this.pnlContador.PerformLayout();
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
        private System.Windows.Forms.Button bntAgregarImagen;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Panel pnlBtnImagenes;
        private System.Windows.Forms.Label lblImagenActual;
        private System.Windows.Forms.Label lblContadorImg;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Panel pnlContador;
        private System.Windows.Forms.Button btneliminar;
    }
}