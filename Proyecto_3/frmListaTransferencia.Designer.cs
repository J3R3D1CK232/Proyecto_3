namespace Proyecto_3
{
    partial class frmListaTransferencia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaTransferencia));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.dgvListaTransaccion = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listaProveedor = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnInsertarProveedor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListaAfiliado = new System.Windows.Forms.Button();
            this.btnInsertarAfiliado = new System.Windows.Forms.Button();
            this.ttBusqueda = new System.Windows.Forms.ToolTip(this.components);
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTransaccion)).BeginInit();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.dgvListaTransaccion);
            this.panelPrincipal.Controls.Add(this.btnBuscar);
            this.panelPrincipal.Controls.Add(this.txtBuscar);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Controls.Add(this.barraSuperior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1024, 640);
            this.panelPrincipal.TabIndex = 0;
            // 
            // dgvListaTransaccion
            // 
            this.dgvListaTransaccion.AllowUserToAddRows = false;
            this.dgvListaTransaccion.AllowUserToDeleteRows = false;
            this.dgvListaTransaccion.AllowUserToResizeColumns = false;
            this.dgvListaTransaccion.AllowUserToResizeRows = false;
            this.dgvListaTransaccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTransaccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaTransaccion.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaTransaccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListaTransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTransaccion.Location = new System.Drawing.Point(12, 163);
            this.dgvListaTransaccion.MultiSelect = false;
            this.dgvListaTransaccion.Name = "dgvListaTransaccion";
            this.dgvListaTransaccion.ReadOnly = true;
            this.dgvListaTransaccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaTransaccion.Size = new System.Drawing.Size(1000, 465);
            this.dgvListaTransaccion.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(13)))));
            this.btnBuscar.Location = new System.Drawing.Point(255, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 37);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(50, 110);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 26);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar";
            // 
            // barraSuperior
            // 
            this.barraSuperior.AutoSize = true;
            this.barraSuperior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.barraSuperior.Controls.Add(this.btnTransferencia);
            this.barraSuperior.Controls.Add(this.panel1);
            this.barraSuperior.Controls.Add(this.label1);
            this.barraSuperior.Controls.Add(this.listaProveedor);
            this.barraSuperior.Controls.Add(this.btnMinimizar);
            this.barraSuperior.Controls.Add(this.btnInsertarProveedor);
            this.barraSuperior.Controls.Add(this.btnCerrar);
            this.barraSuperior.Controls.Add(this.btnListaAfiliado);
            this.barraSuperior.Controls.Add(this.btnInsertarAfiliado);
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1024, 42);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            this.barraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseMove);
            this.barraSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseUp);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.BackColor = System.Drawing.Color.White;
            this.btnTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransferencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnTransferencia.FlatAppearance.BorderSize = 3;
            this.btnTransferencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTransferencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.ForeColor = System.Drawing.Color.Black;
            this.btnTransferencia.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferencia.Image")));
            this.btnTransferencia.Location = new System.Drawing.Point(164, 4);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(32, 32);
            this.btnTransferencia.TabIndex = 22;
            this.btnTransferencia.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(363, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 32);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listado de Transacciones";
            // 
            // listaProveedor
            // 
            this.listaProveedor.BackColor = System.Drawing.Color.White;
            this.listaProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.listaProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.listaProveedor.FlatAppearance.BorderSize = 0;
            this.listaProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.listaProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.listaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProveedor.ForeColor = System.Drawing.Color.Black;
            this.listaProveedor.Image = ((System.Drawing.Image)(resources.GetObject("listaProveedor.Image")));
            this.listaProveedor.Location = new System.Drawing.Point(126, 5);
            this.listaProveedor.Name = "listaProveedor";
            this.listaProveedor.Size = new System.Drawing.Size(32, 32);
            this.listaProveedor.TabIndex = 6;
            this.listaProveedor.UseVisualStyleBackColor = false;
            this.listaProveedor.Click += new System.EventHandler(this.listaProveedor_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizar.Location = new System.Drawing.Point(889, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(63, 36);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnInsertarProveedor
            // 
            this.btnInsertarProveedor.BackColor = System.Drawing.Color.White;
            this.btnInsertarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnInsertarProveedor.FlatAppearance.BorderSize = 0;
            this.btnInsertarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInsertarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnInsertarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnInsertarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertarProveedor.Image")));
            this.btnInsertarProveedor.Location = new System.Drawing.Point(88, 5);
            this.btnInsertarProveedor.Name = "btnInsertarProveedor";
            this.btnInsertarProveedor.Size = new System.Drawing.Size(32, 32);
            this.btnInsertarProveedor.TabIndex = 5;
            this.btnInsertarProveedor.UseVisualStyleBackColor = false;
            this.btnInsertarProveedor.Click += new System.EventHandler(this.btnInsertarProveedor_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnCerrar.Location = new System.Drawing.Point(958, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(63, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListaAfiliado
            // 
            this.btnListaAfiliado.BackColor = System.Drawing.Color.White;
            this.btnListaAfiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListaAfiliado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnListaAfiliado.FlatAppearance.BorderSize = 0;
            this.btnListaAfiliado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnListaAfiliado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnListaAfiliado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaAfiliado.ForeColor = System.Drawing.Color.Black;
            this.btnListaAfiliado.Image = ((System.Drawing.Image)(resources.GetObject("btnListaAfiliado.Image")));
            this.btnListaAfiliado.Location = new System.Drawing.Point(50, 4);
            this.btnListaAfiliado.Name = "btnListaAfiliado";
            this.btnListaAfiliado.Size = new System.Drawing.Size(32, 32);
            this.btnListaAfiliado.TabIndex = 4;
            this.btnListaAfiliado.UseVisualStyleBackColor = false;
            this.btnListaAfiliado.Click += new System.EventHandler(this.btnListaAfiliado_Click);
            // 
            // btnInsertarAfiliado
            // 
            this.btnInsertarAfiliado.BackColor = System.Drawing.Color.White;
            this.btnInsertarAfiliado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertarAfiliado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnInsertarAfiliado.FlatAppearance.BorderSize = 0;
            this.btnInsertarAfiliado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInsertarAfiliado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnInsertarAfiliado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarAfiliado.ForeColor = System.Drawing.Color.Black;
            this.btnInsertarAfiliado.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertarAfiliado.Image")));
            this.btnInsertarAfiliado.Location = new System.Drawing.Point(12, 4);
            this.btnInsertarAfiliado.Name = "btnInsertarAfiliado";
            this.btnInsertarAfiliado.Size = new System.Drawing.Size(32, 32);
            this.btnInsertarAfiliado.TabIndex = 3;
            this.btnInsertarAfiliado.UseVisualStyleBackColor = false;
            this.btnInsertarAfiliado.Click += new System.EventHandler(this.btnInsertarAfiliado_Click);
            // 
            // ttBusqueda
            // 
            this.ttBusqueda.IsBalloon = true;
            this.ttBusqueda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttBusqueda.ToolTipTitle = "Información";
            // 
            // frmListaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.panelPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaTransferencia";
            this.Text = "Lista Afiliados";
            this.Load += new System.EventHandler(this.frmListaAfiliado_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTransaccion)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnInsertarAfiliado;
        private System.Windows.Forms.Button listaProveedor;
        private System.Windows.Forms.Button btnInsertarProveedor;
        private System.Windows.Forms.Button btnListaAfiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolTip ttBusqueda;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.DataGridView dgvListaTransaccion;
    }
}

