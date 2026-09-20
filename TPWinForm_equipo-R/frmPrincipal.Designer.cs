namespace TPWinForm_equipo_R
{
    partial class frmPrincipal
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
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rbtnRango = new System.Windows.Forms.RadioButton();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.dtgListar = new System.Windows.Forms.DataGridView();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.rbtnCategoria = new System.Windows.Forms.RadioButton();
            this.comboMostrar = new System.Windows.Forms.ComboBox();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btnSalir);
            this.pnlBtn.Controls.Add(this.btnAdministrar);
            this.pnlBtn.Controls.Add(this.btnFiltrar);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBtn.Location = new System.Drawing.Point(712, 0);
            this.pnlBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(223, 673);
            this.pnlBtn.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Location = new System.Drawing.Point(27, 522);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 53);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Location = new System.Drawing.Point(27, 287);
            this.btnAdministrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(145, 53);
            this.btnAdministrar.TabIndex = 1;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(27, 119);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(145, 53);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rbtnRango
            // 
            this.rbtnRango.AutoSize = true;
            this.rbtnRango.Location = new System.Drawing.Point(80, 105);
            this.rbtnRango.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnRango.Name = "rbtnRango";
            this.rbtnRango.Size = new System.Drawing.Size(93, 20);
            this.rbtnRango.TabIndex = 4;
            this.rbtnRango.TabStop = true;
            this.rbtnRango.Text = "Por Rango";
            this.rbtnRango.UseVisualStyleBackColor = true;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(275, 103);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 22);
            this.txtDesde.TabIndex = 5;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(461, 103);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 22);
            this.txtHasta.TabIndex = 6;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(209, 107);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 16);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(403, 107);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 16);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(204, 575);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(283, 63);
            this.btnDetalle.TabIndex = 7;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dtgListar
            // 
            this.dtgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListar.ColumnHeadersVisible = false;
            this.dtgListar.Location = new System.Drawing.Point(60, 230);
            this.dtgListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgListar.MultiSelect = false;
            this.dtgListar.Name = "dtgListar";
            this.dtgListar.ReadOnly = true;
            this.dtgListar.RowHeadersVisible = false;
            this.dtgListar.RowHeadersWidth = 51;
            this.dtgListar.RowTemplate.Height = 24;
            this.dtgListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListar.Size = new System.Drawing.Size(545, 318);
            this.dtgListar.TabIndex = 9;
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(227, 183);
            this.rbtnMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(66, 20);
            this.rbtnMarca.TabIndex = 1;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // rbtnCategoria
            // 
            this.rbtnCategoria.AutoSize = true;
            this.rbtnCategoria.Location = new System.Drawing.Point(344, 183);
            this.rbtnCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCategoria.Name = "rbtnCategoria";
            this.rbtnCategoria.Size = new System.Drawing.Size(87, 20);
            this.rbtnCategoria.TabIndex = 2;
            this.rbtnCategoria.TabStop = true;
            this.rbtnCategoria.Text = "Categoria";
            this.rbtnCategoria.UseVisualStyleBackColor = true;
            this.rbtnCategoria.CheckedChanged += new System.EventHandler(this.rbtnCategoria_CheckedChanged);
            // 
            // comboMostrar
            // 
            this.comboMostrar.FormattingEnabled = true;
            this.comboMostrar.Location = new System.Drawing.Point(484, 181);
            this.comboMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboMostrar.Name = "comboMostrar";
            this.comboMostrar.Size = new System.Drawing.Size(121, 24);
            this.comboMostrar.TabIndex = 3;
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(81, 183);
            this.rbtnTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(103, 20);
            this.rbtnTodos.TabIndex = 0;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Mostrar todo";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 673);
            this.ControlBox = false;
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.dtgListar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.rbtnRango);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.rbtnTodos);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.comboMostrar);
            this.Controls.Add(this.rbtnCategoria);
            this.Controls.Add(this.rbtnMarca);
            this.Controls.Add(this.pnlBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.RadioButton rbtnRango;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.RadioButton rbtnCategoria;
        private System.Windows.Forms.ComboBox comboMostrar;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.DataGridView dtgListar;
    }
}