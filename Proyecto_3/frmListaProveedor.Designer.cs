namespace Proyecto_3
{
    partial class frmListaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaProveedor));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvListaProveedor = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.listaProveedor = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnInsertarProveedor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListaAfiliado = new System.Windows.Forms.Button();
            this.btnInsertarAfiliado = new System.Windows.Forms.Button();
            this.ttBusqueda = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).BeginInit();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.button1);
            this.panelPrincipal.Controls.Add(this.btnModificar);
            this.panelPrincipal.Controls.Add(this.dgvListaProveedor);
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
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(87)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(919, 155);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 37);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // dgvListaProveedor
            // 
            this.dgvListaProveedor.AllowUserToResizeColumns = false;
            this.dgvListaProveedor.AllowUserToResizeRows = false;
            this.dgvListaProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaProveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedor.Location = new System.Drawing.Point(12, 198);
            this.dgvListaProveedor.MultiSelect = false;
            this.dgvListaProveedor.Name = "dgvListaProveedor";
            this.dgvListaProveedor.ReadOnly = true;
            this.dgvListaProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProveedor.Size = new System.Drawing.Size(1000, 430);
            this.dgvListaProveedor.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(257, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 37);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(50, 111);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 26);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar";
            // 
            // barraSuperior
            // 
            this.barraSuperior.AutoSize = true;
            this.barraSuperior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
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
            // listaProveedor
            // 
            this.listaProveedor.BackColor = System.Drawing.Color.White;
            this.listaProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.listaProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.listaProveedor.FlatAppearance.BorderSize = 3;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.button1.Location = new System.Drawing.Point(827, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmListaProveedor
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
            this.Name = "frmListaProveedor";
            this.Text = "Lista Proveedores";
            this.Load += new System.EventHandler(this.frmListaProveedor_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnInsertarAfiliado;
        private System.Windows.Forms.Button listaProveedor;
        private System.Windows.Forms.Button btnInsertarProveedor;
        private System.Windows.Forms.Button btnListaAfiliado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvListaProveedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttBusqueda;
        private System.Windows.Forms.Button button1;
    }
}

