namespace Proyecto_3
{
    partial class frmRegistroAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroAfiliado));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.listaProveedor = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnInsertarProveedor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListaAfiliado = new System.Windows.Forms.Button();
            this.btnInsertarAfiliado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpNombre = new System.Windows.Forms.TextBox();
            this.txtsNombre = new System.Windows.Forms.TextBox();
            this.txtpApellido = new System.Windows.Forms.TextBox();
            this.txtsApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDiaFechaNacimiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMesFechaNacimiento = new System.Windows.Forms.ComboBox();
            this.cmbAnoFechaNacimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbAnoFechaCobertura = new System.Windows.Forms.ComboBox();
            this.cmbMesFechaCobertura = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDiaFechaCobertura = new System.Windows.Forms.ComboBox();
            this.txtMontoCobertura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.label8);
            this.panelPrincipal.Controls.Add(this.button1);
            this.panelPrincipal.Controls.Add(this.txtMontoCobertura);
            this.panelPrincipal.Controls.Add(this.label7);
            this.panelPrincipal.Controls.Add(this.cmbAnoFechaCobertura);
            this.panelPrincipal.Controls.Add(this.cmbMesFechaCobertura);
            this.panelPrincipal.Controls.Add(this.label6);
            this.panelPrincipal.Controls.Add(this.cmbDiaFechaCobertura);
            this.panelPrincipal.Controls.Add(this.textBox1);
            this.panelPrincipal.Controls.Add(this.label5);
            this.panelPrincipal.Controls.Add(this.cmbAnoFechaNacimiento);
            this.panelPrincipal.Controls.Add(this.cmbMesFechaNacimiento);
            this.panelPrincipal.Controls.Add(this.label4);
            this.panelPrincipal.Controls.Add(this.cmbDiaFechaNacimiento);
            this.panelPrincipal.Controls.Add(this.label3);
            this.panelPrincipal.Controls.Add(this.txtsApellido);
            this.panelPrincipal.Controls.Add(this.txtpApellido);
            this.panelPrincipal.Controls.Add(this.txtsNombre);
            this.panelPrincipal.Controls.Add(this.txtpNombre);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Controls.Add(this.barraSuperior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1024, 640);
            this.panelPrincipal.TabIndex = 0;
            // 
            // barraSuperior
            // 
            this.barraSuperior.AutoSize = true;
            this.barraSuperior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
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
            this.btnInsertarAfiliado.FlatAppearance.BorderSize = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registro de Afiliado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // txtpNombre
            // 
            this.txtpNombre.BackColor = System.Drawing.Color.White;
            this.txtpNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpNombre.Location = new System.Drawing.Point(50, 109);
            this.txtpNombre.Name = "txtpNombre";
            this.txtpNombre.Size = new System.Drawing.Size(176, 26);
            this.txtpNombre.TabIndex = 2;
            this.txtpNombre.Text = "Primer Nombre";
            // 
            // txtsNombre
            // 
            this.txtsNombre.BackColor = System.Drawing.Color.White;
            this.txtsNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsNombre.Location = new System.Drawing.Point(242, 109);
            this.txtsNombre.Name = "txtsNombre";
            this.txtsNombre.Size = new System.Drawing.Size(176, 26);
            this.txtsNombre.TabIndex = 3;
            this.txtsNombre.Text = "Segundo Nombre";
            // 
            // txtpApellido
            // 
            this.txtpApellido.BackColor = System.Drawing.Color.White;
            this.txtpApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpApellido.Location = new System.Drawing.Point(435, 109);
            this.txtpApellido.Name = "txtpApellido";
            this.txtpApellido.Size = new System.Drawing.Size(176, 26);
            this.txtpApellido.TabIndex = 4;
            this.txtpApellido.Text = "Primer Apellido";
            // 
            // txtsApellido
            // 
            this.txtsApellido.BackColor = System.Drawing.Color.White;
            this.txtsApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsApellido.Location = new System.Drawing.Point(627, 109);
            this.txtsApellido.Name = "txtsApellido";
            this.txtsApellido.Size = new System.Drawing.Size(176, 26);
            this.txtsApellido.TabIndex = 5;
            this.txtsApellido.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informacion Personal";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // cmbDiaFechaNacimiento
            // 
            this.cmbDiaFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiaFechaNacimiento.FormattingEnabled = true;
            this.cmbDiaFechaNacimiento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDiaFechaNacimiento.Location = new System.Drawing.Point(88, 274);
            this.cmbDiaFechaNacimiento.Name = "cmbDiaFechaNacimiento";
            this.cmbDiaFechaNacimiento.Size = new System.Drawing.Size(70, 28);
            this.cmbDiaFechaNacimiento.TabIndex = 7;
            this.cmbDiaFechaNacimiento.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // cmbMesFechaNacimiento
            // 
            this.cmbMesFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesFechaNacimiento.FormattingEnabled = true;
            this.cmbMesFechaNacimiento.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesFechaNacimiento.Location = new System.Drawing.Point(164, 274);
            this.cmbMesFechaNacimiento.Name = "cmbMesFechaNacimiento";
            this.cmbMesFechaNacimiento.Size = new System.Drawing.Size(97, 28);
            this.cmbMesFechaNacimiento.TabIndex = 9;
            this.cmbMesFechaNacimiento.Text = "Mes";
            // 
            // cmbAnoFechaNacimiento
            // 
            this.cmbAnoFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnoFechaNacimiento.FormattingEnabled = true;
            this.cmbAnoFechaNacimiento.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922"});
            this.cmbAnoFechaNacimiento.Location = new System.Drawing.Point(267, 274);
            this.cmbAnoFechaNacimiento.Name = "cmbAnoFechaNacimiento";
            this.cmbAnoFechaNacimiento.Size = new System.Drawing.Size(70, 28);
            this.cmbAnoFechaNacimiento.TabIndex = 10;
            this.cmbAnoFechaNacimiento.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teléfono";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(85, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 12;
            // 
            // cmbAnoFechaCobertura
            // 
            this.cmbAnoFechaCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnoFechaCobertura.FormattingEnabled = true;
            this.cmbAnoFechaCobertura.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922"});
            this.cmbAnoFechaCobertura.Location = new System.Drawing.Point(269, 510);
            this.cmbAnoFechaCobertura.Name = "cmbAnoFechaCobertura";
            this.cmbAnoFechaCobertura.Size = new System.Drawing.Size(70, 28);
            this.cmbAnoFechaCobertura.TabIndex = 16;
            this.cmbAnoFechaCobertura.Text = "Año";
            // 
            // cmbMesFechaCobertura
            // 
            this.cmbMesFechaCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesFechaCobertura.FormattingEnabled = true;
            this.cmbMesFechaCobertura.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesFechaCobertura.Location = new System.Drawing.Point(166, 510);
            this.cmbMesFechaCobertura.Name = "cmbMesFechaCobertura";
            this.cmbMesFechaCobertura.Size = new System.Drawing.Size(97, 28);
            this.cmbMesFechaCobertura.TabIndex = 15;
            this.cmbMesFechaCobertura.Text = "Mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha Inicio de Cobertura";
            // 
            // cmbDiaFechaCobertura
            // 
            this.cmbDiaFechaCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiaFechaCobertura.FormattingEnabled = true;
            this.cmbDiaFechaCobertura.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDiaFechaCobertura.Location = new System.Drawing.Point(90, 510);
            this.cmbDiaFechaCobertura.Name = "cmbDiaFechaCobertura";
            this.cmbDiaFechaCobertura.Size = new System.Drawing.Size(70, 28);
            this.cmbDiaFechaCobertura.TabIndex = 13;
            this.cmbDiaFechaCobertura.Text = "Dia";
            // 
            // txtMontoCobertura
            // 
            this.txtMontoCobertura.BackColor = System.Drawing.Color.White;
            this.txtMontoCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCobertura.Location = new System.Drawing.Point(481, 510);
            this.txtMontoCobertura.Name = "txtMontoCobertura";
            this.txtMontoCobertura.Size = new System.Drawing.Size(176, 26);
            this.txtMontoCobertura.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Monto de Cobertura";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(213)))), ((int)(((byte)(11)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(46)))));
            this.button1.Location = new System.Drawing.Point(889, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Q";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmRegistroAfiliado
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
            this.Name = "frmRegistroAfiliado";
            this.Text = "Registro Afiliado";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpNombre;
        private System.Windows.Forms.TextBox txtsApellido;
        private System.Windows.Forms.TextBox txtpApellido;
        private System.Windows.Forms.TextBox txtsNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAnoFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbMesFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDiaFechaNacimiento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAnoFechaCobertura;
        private System.Windows.Forms.ComboBox cmbMesFechaCobertura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDiaFechaCobertura;
        private System.Windows.Forms.TextBox txtMontoCobertura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

