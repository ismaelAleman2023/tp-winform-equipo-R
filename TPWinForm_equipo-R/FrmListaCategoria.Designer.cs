namespace TPWinForm_equipo_R
{
    partial class FrmListaCategoria
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
            this.dgvCate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCate
            // 
            this.dgvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCate.Location = new System.Drawing.Point(-1, 0);
            this.dgvCate.MaximumSize = new System.Drawing.Size(458, 359);
            this.dgvCate.Name = "dgvCate";
            this.dgvCate.Size = new System.Drawing.Size(458, 359);
            this.dgvCate.TabIndex = 0;
            // 
            // FrmListaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 359);
            this.Controls.Add(this.dgvCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(458, 359);
            this.MinimumSize = new System.Drawing.Size(458, 359);
            this.Name = "FrmListaCategoria";
            this.Text = "FrmListaMarca";
            this.Load += new System.EventHandler(this.FrmListaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvCate;
    }
}