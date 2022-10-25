namespace Proyecto_3
{
    partial class frmModificarAfiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarAfiliado));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.cmbMesCobertura = new System.Windows.Forms.ComboBox();
            this.cmbAnoCobertura = new System.Windows.Forms.ComboBox();
            this.cmbDiaCobertura = new System.Windows.Forms.ComboBox();
            this.cmbMesNacimiento = new System.Windows.Forms.ComboBox();
            this.cmbAnoNacimiento = new System.Windows.Forms.ComboBox();
            this.cmbDiaNacimiento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtMontoCobertura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsApellido = new System.Windows.Forms.TextBox();
            this.txtpApellido = new System.Windows.Forms.TextBox();
            this.txtsNombre = new System.Windows.Forms.TextBox();
            this.txtpNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.barraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.cmbEstado);
            this.panelPrincipal.Controls.Add(this.label9);
            this.panelPrincipal.Controls.Add(this.lbid);
            this.panelPrincipal.Controls.Add(this.cmbMesCobertura);
            this.panelPrincipal.Controls.Add(this.cmbAnoCobertura);
            this.panelPrincipal.Controls.Add(this.cmbDiaCobertura);
            this.panelPrincipal.Controls.Add(this.cmbMesNacimiento);
            this.panelPrincipal.Controls.Add(this.cmbAnoNacimiento);
            this.panelPrincipal.Controls.Add(this.cmbDiaNacimiento);
            this.panelPrincipal.Controls.Add(this.label8);
            this.panelPrincipal.Controls.Add(this.btnRegistrar);
            this.panelPrincipal.Controls.Add(this.txtMontoCobertura);
            this.panelPrincipal.Controls.Add(this.label7);
            this.panelPrincipal.Controls.Add(this.label6);
            this.panelPrincipal.Controls.Add(this.txtTelefono);
            this.panelPrincipal.Controls.Add(this.label5);
            this.panelPrincipal.Controls.Add(this.label4);
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
            this.panelPrincipal.Size = new System.Drawing.Size(603, 640);
            this.panelPrincipal.TabIndex = 0;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(103, 540);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(119, 28);
            this.cmbEstado.TabIndex = 50;
            this.cmbEstado.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Estado";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(13, 46);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(0, 13);
            this.lbid.TabIndex = 48;
            // 
            // cmbMesCobertura
            // 
            this.cmbMesCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesCobertura.FormattingEnabled = true;
            this.cmbMesCobertura.Items.AddRange(new object[] {
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
            this.cmbMesCobertura.Location = new System.Drawing.Point(103, 445);
            this.cmbMesCobertura.Name = "cmbMesCobertura";
            this.cmbMesCobertura.Size = new System.Drawing.Size(130, 28);
            this.cmbMesCobertura.TabIndex = 47;
            this.cmbMesCobertura.Text = "Mes";
            // 
            // cmbAnoCobertura
            // 
            this.cmbAnoCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnoCobertura.FormattingEnabled = true;
            this.cmbAnoCobertura.Items.AddRange(new object[] {
            "2024",
            "2023",
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
            this.cmbAnoCobertura.Location = new System.Drawing.Point(239, 445);
            this.cmbAnoCobertura.Name = "cmbAnoCobertura";
            this.cmbAnoCobertura.Size = new System.Drawing.Size(71, 28);
            this.cmbAnoCobertura.TabIndex = 46;
            this.cmbAnoCobertura.Text = "Año";
            // 
            // cmbDiaCobertura
            // 
            this.cmbDiaCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiaCobertura.FormattingEnabled = true;
            this.cmbDiaCobertura.Items.AddRange(new object[] {
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
            this.cmbDiaCobertura.Location = new System.Drawing.Point(26, 445);
            this.cmbDiaCobertura.Name = "cmbDiaCobertura";
            this.cmbDiaCobertura.Size = new System.Drawing.Size(71, 28);
            this.cmbDiaCobertura.TabIndex = 45;
            this.cmbDiaCobertura.Text = "Dia";
            // 
            // cmbMesNacimiento
            // 
            this.cmbMesNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesNacimiento.FormattingEnabled = true;
            this.cmbMesNacimiento.Items.AddRange(new object[] {
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
            this.cmbMesNacimiento.Location = new System.Drawing.Point(103, 304);
            this.cmbMesNacimiento.Name = "cmbMesNacimiento";
            this.cmbMesNacimiento.Size = new System.Drawing.Size(130, 28);
            this.cmbMesNacimiento.TabIndex = 44;
            this.cmbMesNacimiento.Text = "Mes";
            // 
            // cmbAnoNacimiento
            // 
            this.cmbAnoNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnoNacimiento.FormattingEnabled = true;
            this.cmbAnoNacimiento.Items.AddRange(new object[] {
            "2024",
            "2023",
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
            this.cmbAnoNacimiento.Location = new System.Drawing.Point(239, 304);
            this.cmbAnoNacimiento.Name = "cmbAnoNacimiento";
            this.cmbAnoNacimiento.Size = new System.Drawing.Size(71, 28);
            this.cmbAnoNacimiento.TabIndex = 43;
            this.cmbAnoNacimiento.Text = "Año";
            // 
            // cmbDiaNacimiento
            // 
            this.cmbDiaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiaNacimiento.FormattingEnabled = true;
            this.cmbDiaNacimiento.Items.AddRange(new object[] {
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
            this.cmbDiaNacimiento.Location = new System.Drawing.Point(26, 304);
            this.cmbDiaNacimiento.Name = "cmbDiaNacimiento";
            this.cmbDiaNacimiento.Size = new System.Drawing.Size(71, 28);
            this.cmbDiaNacimiento.TabIndex = 42;
            this.cmbDiaNacimiento.Text = "Dia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Q";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(13)))));
            this.btnRegistrar.Location = new System.Drawing.Point(467, 583);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrar.TabIndex = 35;
            this.btnRegistrar.Text = "Aceptar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtMontoCobertura
            // 
            this.txtMontoCobertura.BackColor = System.Drawing.Color.White;
            this.txtMontoCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCobertura.Location = new System.Drawing.Point(392, 445);
            this.txtMontoCobertura.Name = "txtMontoCobertura";
            this.txtMontoCobertura.Size = new System.Drawing.Size(176, 26);
            this.txtMontoCobertura.TabIndex = 40;
            this.txtMontoCobertura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoCobertura_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Monto de Cobertura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Fecha Inicio de Cobertura";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(382, 304);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 26);
            this.txtTelefono.TabIndex = 37;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Informacion Personal";
            // 
            // txtsApellido
            // 
            this.txtsApellido.BackColor = System.Drawing.Color.White;
            this.txtsApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsApellido.Location = new System.Drawing.Point(354, 155);
            this.txtsApellido.Name = "txtsApellido";
            this.txtsApellido.Size = new System.Drawing.Size(176, 26);
            this.txtsApellido.TabIndex = 32;
            this.txtsApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsApellido_KeyPress);
            // 
            // txtpApellido
            // 
            this.txtpApellido.BackColor = System.Drawing.Color.White;
            this.txtpApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpApellido.Location = new System.Drawing.Point(92, 155);
            this.txtpApellido.Name = "txtpApellido";
            this.txtpApellido.Size = new System.Drawing.Size(176, 26);
            this.txtpApellido.TabIndex = 31;
            this.txtpApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpApellido_KeyPress);
            // 
            // txtsNombre
            // 
            this.txtsNombre.BackColor = System.Drawing.Color.White;
            this.txtsNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsNombre.Location = new System.Drawing.Point(354, 96);
            this.txtsNombre.Name = "txtsNombre";
            this.txtsNombre.Size = new System.Drawing.Size(176, 26);
            this.txtsNombre.TabIndex = 30;
            this.txtsNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsNombre_KeyPress);
            // 
            // txtpNombre
            // 
            this.txtpNombre.BackColor = System.Drawing.Color.White;
            this.txtpNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpNombre.Location = new System.Drawing.Point(92, 96);
            this.txtpNombre.Name = "txtpNombre";
            this.txtpNombre.Size = new System.Drawing.Size(176, 26);
            this.txtpNombre.TabIndex = 29;
            this.txtpNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Completo";
            // 
            // barraSuperior
            // 
            this.barraSuperior.AutoSize = true;
            this.barraSuperior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.barraSuperior.Controls.Add(this.panel1);
            this.barraSuperior.Controls.Add(this.label1);
            this.barraSuperior.Controls.Add(this.btnMinimizar);
            this.barraSuperior.Controls.Add(this.btnCerrar);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(603, 39);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            this.barraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseMove);
            this.barraSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(9, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 32);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Modificar Información de Afiliado";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizar.Location = new System.Drawing.Point(467, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(63, 36);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnCerrar.Location = new System.Drawing.Point(536, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(63, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(603, 640);
            this.Controls.Add(this.panelPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarAfiliado";
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModificarAfiliado_FormClosed);
            this.Load += new System.EventHandler(this.frmModificarAfiliado_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtsNombre;
        public System.Windows.Forms.TextBox txtpNombre;
        public System.Windows.Forms.ComboBox cmbMesCobertura;
        public System.Windows.Forms.ComboBox cmbAnoCobertura;
        public System.Windows.Forms.ComboBox cmbDiaCobertura;
        public System.Windows.Forms.ComboBox cmbMesNacimiento;
        public System.Windows.Forms.ComboBox cmbAnoNacimiento;
        public System.Windows.Forms.ComboBox cmbDiaNacimiento;
        public System.Windows.Forms.TextBox txtMontoCobertura;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtsApellido;
        public System.Windows.Forms.TextBox txtpApellido;
        private System.Windows.Forms.Label lbid;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label9;
    }
}

