namespace TPWinForm_equipo_R
{
    partial class frmEliminarArticulo
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
            this.lblEliminarArt = new System.Windows.Forms.Label();
            this.txtidEliminar = new System.Windows.Forms.TextBox();
            this.btnConfirmarEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEliminarArt
            // 
            this.lblEliminarArt.AutoSize = true;
            this.lblEliminarArt.Location = new System.Drawing.Point(41, 103);
            this.lblEliminarArt.Name = "lblEliminarArt";
            this.lblEliminarArt.Size = new System.Drawing.Size(101, 13);
            this.lblEliminarArt.TabIndex = 0;
            this.lblEliminarArt.Text = "Indique Id a eliminar";
            // 
            // txtidEliminar
            // 
            this.txtidEliminar.Location = new System.Drawing.Point(158, 99);
            this.txtidEliminar.Name = "txtidEliminar";
            this.txtidEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtidEliminar.TabIndex = 1;
            // 
            // btnConfirmarEliminar
            // 
            this.btnConfirmarEliminar.Location = new System.Drawing.Point(278, 98);
            this.btnConfirmarEliminar.Name = "btnConfirmarEliminar";
            this.btnConfirmarEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnConfirmarEliminar.TabIndex = 2;
            this.btnConfirmarEliminar.Text = "Confirmar Eliminar";
            this.btnConfirmarEliminar.UseVisualStyleBackColor = true;
            this.btnConfirmarEliminar.Click += new System.EventHandler(this.btnConfirmarEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(170, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 368);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarEliminar);
            this.Controls.Add(this.txtidEliminar);
            this.Controls.Add(this.lblEliminarArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEliminarArticulo";
            this.Text = "frmEliminarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarArt;
        private System.Windows.Forms.TextBox txtidEliminar;
        private System.Windows.Forms.Button btnConfirmarEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}