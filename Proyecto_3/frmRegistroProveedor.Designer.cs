namespace Proyecto_3
{
    partial class frmRegistroProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroProveedor));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNitProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listaProveedor = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnInsertarProveedor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListaAfiliado = new System.Windows.Forms.Button();
            this.btnInsertarAfiliado = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.btnRegistrar);
            this.panelPrincipal.Controls.Add(this.label3);
            this.panelPrincipal.Controls.Add(this.txtRazonSocial);
            this.panelPrincipal.Controls.Add(this.txtNitProveedor);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Controls.Add(this.barraSuperior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1024, 640);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(13)))));
            this.btnRegistrar.Location = new System.Drawing.Point(479, 521);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Razón Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(415, 354);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(241, 26);
            this.txtRazonSocial.TabIndex = 6;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNitProveedor
            // 
            this.txtNitProveedor.BackColor = System.Drawing.Color.White;
            this.txtNitProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNitProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNitProveedor.Location = new System.Drawing.Point(415, 240);
            this.txtNitProveedor.MaxLength = 7;
            this.txtNitProveedor.Name = "txtNitProveedor";
            this.txtNitProveedor.Size = new System.Drawing.Size(241, 26);
            this.txtNitProveedor.TabIndex = 5;
            this.txtNitProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNitProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNitProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // barraSuperior
            // 
            this.barraSuperior.AutoSize = true;
            this.barraSuperior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(353, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 32);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Registro de Proveedor";
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
            this.btnInsertarProveedor.FlatAppearance.BorderSize = 3;
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
            // frmRegistroProveedor
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
            this.Name = "frmRegistroProveedor";
            this.Text = "Registro Proveedor";
            this.Load += new System.EventHandler(this.frmRegistroProveedor_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
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
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNitProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

