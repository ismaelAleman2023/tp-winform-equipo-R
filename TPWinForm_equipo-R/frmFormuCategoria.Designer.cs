namespace TPWinForm_equipo_R
{
    partial class frmFormuCategoria
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
            this.lbTituloCate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTituloCate
            // 
            this.lbTituloCate.AutoSize = true;
            this.lbTituloCate.BackColor = System.Drawing.Color.White;
            this.lbTituloCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTituloCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloCate.ForeColor = System.Drawing.Color.Black;
            this.lbTituloCate.Location = new System.Drawing.Point(97, 52);
            this.lbTituloCate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloCate.Name = "lbTituloCate";
            this.lbTituloCate.Size = new System.Drawing.Size(405, 54);
            this.lbTituloCate.TabIndex = 0;
            this.lbTituloCate.Text = "Agregar Categoria";
            this.lbTituloCate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion :";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(229, 196);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(375, 335);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.MaximumSize = new System.Drawing.Size(115, 38);
            this.btnConfirmar.MinimumSize = new System.Drawing.Size(115, 38);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 38);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(117, 336);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(115, 38);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(115, 38);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id :";
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensajes.Location = new System.Drawing.Point(141, 244);
            this.lblMensajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajes.MinimumSize = new System.Drawing.Size(333, 74);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(333, 74);
            this.lblMensajes.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(229, 148);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(205, 22);
            this.txtId.TabIndex = 9;
            // 
            // frmFormuCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 442);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTituloCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(611, 442);
            this.MinimumSize = new System.Drawing.Size(611, 442);
            this.Name = "frmFormuCategoria";
            this.Text = "frmFormuCategoria";
            this.Load += new System.EventHandler(this.frmFormuCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.TextBox txtId;
    }
}