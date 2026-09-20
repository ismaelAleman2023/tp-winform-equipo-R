namespace TPWinForm_equipo_R
{
    partial class frmFormuEliminarCate
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
            this.lbTituloEliCate = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnConfirmarEli = new System.Windows.Forms.Button();
            this.btnCancelarCate = new System.Windows.Forms.Button();
            this.lbMensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTituloEliCate
            // 
            this.lbTituloEliCate.AutoSize = true;
            this.lbTituloEliCate.BackColor = System.Drawing.Color.Red;
            this.lbTituloEliCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTituloEliCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloEliCate.Location = new System.Drawing.Point(84, 60);
            this.lbTituloEliCate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloEliCate.Name = "lbTituloEliCate";
            this.lbTituloEliCate.Size = new System.Drawing.Size(408, 56);
            this.lbTituloEliCate.TabIndex = 1;
            this.lbTituloEliCate.Text = "Eliminar Categoria";
            this.lbTituloEliCate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(88, 149);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(104, 25);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Ingrese Id:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(216, 150);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(228, 22);
            this.txtid.TabIndex = 0;
            // 
            // btnConfirmarEli
            // 
            this.btnConfirmarEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmarEli.Location = new System.Drawing.Point(391, 327);
            this.btnConfirmarEli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmarEli.Name = "btnConfirmarEli";
            this.btnConfirmarEli.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmarEli.TabIndex = 1;
            this.btnConfirmarEli.Text = "Confirmar";
            this.btnConfirmarEli.UseVisualStyleBackColor = true;
            this.btnConfirmarEli.Click += new System.EventHandler(this.btnConfirmarEli_Click);
            // 
            // btnCancelarCate
            // 
            this.btnCancelarCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelarCate.Location = new System.Drawing.Point(117, 327);
            this.btnCancelarCate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarCate.Name = "btnCancelarCate";
            this.btnCancelarCate.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarCate.TabIndex = 2;
            this.btnCancelarCate.Text = "Cancelar";
            this.btnCancelarCate.UseVisualStyleBackColor = true;
            this.btnCancelarCate.Click += new System.EventHandler(this.btnCancelarCate_Click);
            // 
            // lbMensajes
            // 
            this.lbMensajes.AutoSize = true;
            this.lbMensajes.BackColor = System.Drawing.Color.Transparent;
            this.lbMensajes.Location = new System.Drawing.Point(169, 214);
            this.lbMensajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMensajes.MinimumSize = new System.Drawing.Size(333, 74);
            this.lbMensajes.Name = "lbMensajes";
            this.lbMensajes.Size = new System.Drawing.Size(333, 74);
            this.lbMensajes.TabIndex = 6;
            // 
            // frmFormuEliminarCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 442);
            this.Controls.Add(this.lbMensajes);
            this.Controls.Add(this.btnCancelarCate);
            this.Controls.Add(this.btnConfirmarEli);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTituloEliCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(611, 442);
            this.MinimumSize = new System.Drawing.Size(611, 442);
            this.Name = "frmFormuEliminarCate";
            this.Text = "frmFormuEliminarCate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbTituloEliCate;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnConfirmarEli;
        private System.Windows.Forms.Button btnCancelarCate;
        private System.Windows.Forms.Label lbMensajes;
    }
}