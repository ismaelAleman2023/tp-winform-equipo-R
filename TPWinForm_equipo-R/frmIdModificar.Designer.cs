namespace TPWinForm_equipo_R
{
    partial class frmIdModificar
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
            this.txtIdModi = new System.Windows.Forms.TextBox();
            this.btnConfi = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lbIdModificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdModi
            // 
            this.txtIdModi.Location = new System.Drawing.Point(194, 143);
            this.txtIdModi.Name = "txtIdModi";
            this.txtIdModi.Size = new System.Drawing.Size(169, 20);
            this.txtIdModi.TabIndex = 1;
            // 
            // btnConfi
            // 
            this.btnConfi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfi.Location = new System.Drawing.Point(352, 316);
            this.btnConfi.Name = "btnConfi";
            this.btnConfi.Size = new System.Drawing.Size(95, 36);
            this.btnConfi.TabIndex = 2;
            this.btnConfi.Text = "Confirmar";
            this.btnConfi.UseVisualStyleBackColor = true;
            this.btnConfi.Click += new System.EventHandler(this.btnConfi_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(118, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(130, 199);
            this.lblMensajes.MaximumSize = new System.Drawing.Size(300, 100);
            this.lblMensajes.MinimumSize = new System.Drawing.Size(300, 100);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(300, 100);
            this.lblMensajes.TabIndex = 4;
            // 
            // lbIdModificar
            // 
            this.lbIdModificar.AutoSize = true;
            this.lbIdModificar.BackColor = System.Drawing.Color.Transparent;
            this.lbIdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdModificar.ForeColor = System.Drawing.Color.Black;
            this.lbIdModificar.Location = new System.Drawing.Point(112, 52);
            this.lbIdModificar.Name = "lbIdModificar";
            this.lbIdModificar.Size = new System.Drawing.Size(348, 39);
            this.lbIdModificar.TabIndex = 5;
            this.lbIdModificar.Text = "Ingrese Id a Modificar";
            // 
            // frmIdModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 451);
            this.Controls.Add(this.lbIdModificar);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfi);
            this.Controls.Add(this.txtIdModi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(563, 451);
            this.MinimumSize = new System.Drawing.Size(563, 451);
            this.Name = "frmIdModificar";
            this.Text = "frmIdModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdModi;
        private System.Windows.Forms.Button btnConfi;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label lbIdModificar;
    }
}