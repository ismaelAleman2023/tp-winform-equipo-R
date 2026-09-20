namespace TPWinForm_equipo_R
{
    partial class frmFormuEliminarMarca
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarEli = new System.Windows.Forms.Button();
            this.lbMensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label1.Location = new System.Drawing.Point(132, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(137, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(253, 158);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 22);
            this.txtid.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 330);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarEli
            // 
            this.btnConfirmarEli.Location = new System.Drawing.Point(323, 330);
            this.btnConfirmarEli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmarEli.Name = "btnConfirmarEli";
            this.btnConfirmarEli.Size = new System.Drawing.Size(112, 28);
            this.btnConfirmarEli.TabIndex = 1;
            this.btnConfirmarEli.Text = "CONFIRMAR";
            this.btnConfirmarEli.UseVisualStyleBackColor = true;
            this.btnConfirmarEli.Click += new System.EventHandler(this.btnConfirmarEli_Click);
            // 
            // lbMensajes
            // 
            this.lbMensajes.AutoSize = true;
            this.lbMensajes.Location = new System.Drawing.Point(103, 186);
            this.lbMensajes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMensajes.MinimumSize = new System.Drawing.Size(400, 123);
            this.lbMensajes.Name = "lbMensajes";
            this.lbMensajes.Size = new System.Drawing.Size(400, 123);
            this.lbMensajes.TabIndex = 10;
            // 
            // frmFormuEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 442);
            this.Controls.Add(this.lbMensajes);
            this.Controls.Add(this.btnConfirmarEli);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(611, 442);
            this.MinimumSize = new System.Drawing.Size(611, 442);
            this.Name = "frmFormuEliminarMarca";
            this.Text = "frmFormuEliminarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEli;
        private System.Windows.Forms.Label lbMensajes;
    }
}