namespace TPWinForm_equipo_R
{
    partial class frmModificarIdArt
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAeptar = new System.Windows.Forms.Button();
            this.lblartModif = new System.Windows.Forms.Label();
            this.txtArtModifid = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(335, 194);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAeptar
            // 
            this.btnAeptar.Location = new System.Drawing.Point(153, 194);
            this.btnAeptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAeptar.Name = "btnAeptar";
            this.btnAeptar.Size = new System.Drawing.Size(100, 28);
            this.btnAeptar.TabIndex = 1;
            this.btnAeptar.Text = "aceptar";
            this.btnAeptar.UseVisualStyleBackColor = true;
            this.btnAeptar.Click += new System.EventHandler(this.btnAeptar_Click);
            // 
            // lblartModif
            // 
            this.lblartModif.AutoSize = true;
            this.lblartModif.Location = new System.Drawing.Point(149, 128);
            this.lblartModif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblartModif.Name = "lblartModif";
            this.lblartModif.Size = new System.Drawing.Size(66, 16);
            this.lblartModif.TabIndex = 3;
            this.lblartModif.Text = "Ingrese id";
            // 
            // txtArtModifid
            // 
            this.txtArtModifid.Location = new System.Drawing.Point(243, 124);
            this.txtArtModifid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArtModifid.Name = "txtArtModifid";
            this.txtArtModifid.Size = new System.Drawing.Size(132, 22);
            this.txtArtModifid.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(185, 252);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 5;
            // 
            // frmModificarIdArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 453);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtArtModifid);
            this.Controls.Add(this.lblartModif);
            this.Controls.Add(this.btnAeptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmModificarIdArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmModificarIdArt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAeptar;
        private System.Windows.Forms.Label lblartModif;
        private System.Windows.Forms.TextBox txtArtModifid;
        private System.Windows.Forms.Label lblMensaje;
    }
}