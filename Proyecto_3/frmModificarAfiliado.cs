using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    public partial class frmModificarAfiliado : Form
    {
        
        public string idAfiliado,estadoAfiliado;
        public string fechaNacimiento, fechaCobertura;
        public frmModificarAfiliado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;      

        }
        int m, mx, my;
        private void barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            frmListaAfiliado listaAfiliado = new frmListaAfiliado();            
            this.Close();
            obj1.cargarAfiliado(listaAfiliado.dgvListaAfiliado);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarAfiliado_Click(object sender, EventArgs e)
        {
            frmRegistroAfiliado frm = new frmRegistroAfiliado();
            frm.Show();
            this.Hide();
        }

        private void btnListaAfiliado_Click(object sender, EventArgs e)
        {
            frmListaAfiliado frm = new frmListaAfiliado();
            frm.Show();
            this.Hide();
        }

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {
            frmRegistroProveedor frm = new frmRegistroProveedor();
            frm.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            frmListaAfiliado obj2 = new frmListaAfiliado();
            if (txtpNombre.Text == "" || txtsNombre.Text == "" || txtpApellido.Text == "" || txtsApellido.Text == "" || txtTelefono.Text == "" || txtMontoCobertura.Text == "")
            {
                MessageBox.Show("Debe completar la información", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((cmbDiaNacimiento.SelectedIndex == -1) || (cmbMesNacimiento.SelectedIndex == -1) || (cmbAnoNacimiento.SelectedIndex == -1))
            {
                MessageBox.Show("Debe completar la fecha de nacimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((cmbDiaCobertura.SelectedIndex == -1) || (cmbMesCobertura.SelectedIndex == -1) || (cmbAnoCobertura.SelectedIndex == -1))
            {
                MessageBox.Show("Debe completar la fecha de cobertura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbEstado.SelectedIndex == -1 || cmbEstado.SelectedIndex > 1)
            {
                MessageBox.Show("Debe seleccionar un estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            string mesNacimiento = cmbMesNacimiento.SelectedItem.ToString();
            string mesNacimientoNumero = "";
            string mesCobertura = cmbMesCobertura.SelectedItem.ToString();
            string mesCoberturaNumero = "";

            if (mesNacimiento == "Enero")
            {
                mesNacimientoNumero = "01";
            }
            if (mesNacimiento == "Febrero")
            {
                mesNacimientoNumero = "02";
            }
            if (mesNacimiento == "Marzo")
            {
                mesNacimientoNumero = "03";
            }
            if (mesNacimiento == "Abril")
            {
                mesNacimientoNumero = "04";
            }
            if (mesNacimiento == "Mayo")
            {
                mesNacimientoNumero = "05";
            }
            if (mesNacimiento == "Junio")
            {
                mesNacimientoNumero = "06";
            }
            if (mesNacimiento == "Julio")
            {
                mesNacimientoNumero = "07";
            }
            if (mesNacimiento == "Agosto")
            {
                mesNacimientoNumero = "08";
            }
            if (mesNacimiento == "Septiembre")
            {
                mesNacimientoNumero = "09";
            }
            if (mesNacimiento == "Octubre")
            {
                mesNacimientoNumero = "10";
            }
            if (mesNacimiento == "Noviembre")
            {
                mesNacimientoNumero = "11";
            }
            if (mesNacimiento == "Diciembre")
            {
                mesNacimientoNumero = "12";
            }

            //mes cobertura a numeros

            if (mesCobertura == "Enero")
            {
                mesCoberturaNumero = "01";
            }
            if (mesCobertura == "Febrero")
            {
                mesCoberturaNumero = "02";
            }
            if (mesCobertura == "Marzo")
            {
                mesCoberturaNumero = "03";
            }
            if (mesCobertura == "Abril")
            {
                mesCoberturaNumero = "04";
            }
            if (mesCobertura == "Mayo")
            {
                mesCoberturaNumero = "05";
            }
            if (mesCobertura == "Junio")
            {
                mesCoberturaNumero = "06";
            }
            if (mesCobertura == "Julio")
            {
                mesCoberturaNumero = "07";
            }
            if (mesCobertura == "Agosto")
            {
                mesCoberturaNumero = "08";
            }
            if (mesCobertura == "Septiembre")
            {
                mesCoberturaNumero = "09";
            }
            if (mesCobertura == "Octubre")
            {
                mesCoberturaNumero = "10";
            }
            if (mesCobertura == "Noviembre")
            {
                mesCoberturaNumero = "11";
            }
            if (mesCobertura == "Diciembre")
            {
                mesCoberturaNumero = "12";
            }

            string fecha_nacimiento = mesNacimientoNumero + '/' + cmbDiaNacimiento.SelectedItem.ToString() + '/' + cmbAnoNacimiento.SelectedItem.ToString();
            string fecha_cobertura = mesCoberturaNumero + '/' + cmbDiaCobertura.SelectedItem.ToString() + '/' + cmbAnoCobertura.SelectedItem.ToString();

            MessageBox.Show(obj1.modificarAfiliado(Convert.ToInt64(lbid.Text), txtpNombre.Text, txtsNombre.Text, txtpApellido.Text, txtsApellido.Text, fecha_nacimiento, Convert.ToInt64(txtTelefono.Text),fecha_cobertura,Convert.ToDecimal(txtMontoCobertura.Text), cmbEstado.SelectedItem.ToString()));
            obj1.cargarAfiliado(obj2.dgvListaAfiliado);
        }

        private void txtpNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtpApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMontoCobertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permite ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("Solo se permite un numero decimal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permite ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void frmModificarAfiliado_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmListaAfiliado listaAfiliado = new frmListaAfiliado();
            listaAfiliado.Show();
        }

        private void listaProveedor_Click(object sender, EventArgs e)
        {
            frmListaProveedor frm = new frmListaProveedor();
            frm.Show();
            this.Hide();
        }

        private void frmModificarAfiliado_Load(object sender, EventArgs e)
        {
            lbid.Hide();
            lbid.Text = idAfiliado;
            if (estadoAfiliado == "Activo")
            {
                cmbEstado.SelectedItem = "Activo";
            }
            else if (estadoAfiliado == "Inactivo") {

                cmbEstado.SelectedItem = "Inactivo";
            }
            
            
            string cadenaDia = "";
            string cadenaMes = "";
            string cadenaAño = "";
            string hora = "";
            string barraNacimento = "";
            int contador = 0;
            //desglose fecha de nacimiento para pasarlo a un combobox por separado.
            for (int i = 0; i < fechaNacimiento.Length; i++)
            {
                if ((fechaNacimiento[i] != '/') && (contador == 0))
                {
                    cadenaDia += fechaNacimiento[i];
                }
                
                else if ((fechaNacimiento[i] == '/') && (contador == 0)) {
                    contador = 1;
                    barraNacimento += fechaNacimiento[i];
                }
                else if ((fechaNacimiento[i] != '/') && (contador == 1))
                {
                    cadenaMes += fechaNacimiento[i];
                }
                else if ((fechaNacimiento[i] == '/') && (contador == 1))
                {
                    contador = 2;
                    barraNacimento += fechaNacimiento[i];
                }
                else if ((fechaNacimiento[i] != '/') && (contador == 2))
                {
                    contador = 3;
                    cadenaAño += fechaNacimiento[i];
                }
                else if ((fechaNacimiento[i] != '/') && (contador == 3))
                {
                    contador = 4;
                    cadenaAño += fechaNacimiento[i];
                }
                else if ((fechaNacimiento[i] != '/') && (contador == 4))
                {
                    contador = 5;
                    cadenaAño += fechaNacimiento[i];
                }
                else if ((fechaNacimiento[i] != '/') && (contador == 5))
                {
                    contador = 6;
                    cadenaAño += fechaNacimiento[i];
                }
                else if ((fechaNacimiento[i] == ' ') && (contador == 6))
                {
                    contador = 6;
                    hora += fechaNacimiento[i];
                }
            }
            cmbDiaNacimiento.SelectedItem = cadenaDia;
            cmbAnoNacimiento.SelectedItem = cadenaAño;
            // Se selecciona el mes dependiendo del numero recuperado
            if (cadenaMes == "01") {
                cmbMesNacimiento.SelectedItem = "Enero";
            }
            else if (cadenaMes == "02")
            {
                cmbMesNacimiento.SelectedItem = "Febrero";
            }
            else if (cadenaMes == "03")
            {
                cmbMesNacimiento.SelectedItem = "Marzo";
            }
            else if (cadenaMes == "04")
            {
                cmbMesNacimiento.SelectedItem = "Abril";
            }
            else if (cadenaMes == "05")
            {
                cmbMesNacimiento.SelectedItem = "Mayo";
            }
            else if (cadenaMes == "06")
            {
                cmbMesNacimiento.SelectedItem = "Junio";
            }
            else if (cadenaMes == "07")
            {
                cmbMesNacimiento.SelectedItem = "Julio";
            }
            else if (cadenaMes == "08")
            {
                cmbMesNacimiento.SelectedItem = "Agosto";
            }
            else if (cadenaMes == "09")
            {
                cmbMesNacimiento.SelectedItem = "Septiembre";
            }
            else if (cadenaMes == "10")
            {
                cmbMesNacimiento.SelectedItem = "Octubre";
            }
            else if (cadenaMes == "11")
            {
                cmbMesNacimiento.SelectedItem = "Noviembre";
            }
            else if (cadenaMes == "12")
            {
                cmbMesNacimiento.SelectedItem = "Diciembre";
            }
            cadenaDia = "";
            cadenaMes = "";
            cadenaAño = "";
            hora = "";
            barraNacimento = "";
            contador = 0;

            for(int i = 0; i < fechaNacimiento.Length; i++)
            {
                if ((fechaCobertura[i] != '/') && (contador == 0))
                {
                    cadenaDia += fechaCobertura[i];
                }

                else if ((fechaCobertura[i] == '/') && (contador == 0))
                {
                    contador = 1;
                    barraNacimento += fechaCobertura[i];
                }
                else if ((fechaCobertura[i] != '/') && (contador == 1))
                {
                    cadenaMes += fechaCobertura[i];
                }
                else if ((fechaCobertura[i] == '/') && (contador == 1))
                {
                    contador = 2;
                    barraNacimento += fechaCobertura[i];
                }
                else if ((fechaCobertura[i] != '/') && (contador == 2))
                {
                    contador = 3;
                    cadenaAño += fechaCobertura[i];
                }
                else if ((fechaCobertura[i] != '/') && (contador == 3))
                {
                    contador = 4;
                    cadenaAño += fechaCobertura[i];
                }
                else if ((fechaNacimiento[i] != '/') && (contador == 4))
                {
                    contador = 5;
                    cadenaAño += fechaCobertura[i];
                }
                else if ((fechaCobertura[i] != '/') && (contador == 5))
                {
                    contador = 6;
                    cadenaAño += fechaCobertura[i];
                }
                else if ((fechaCobertura[i] == ' ') && (contador == 6))
                {
                    contador = 6;
                    hora += fechaCobertura[i];
                }
            }
            cmbDiaCobertura.SelectedItem = cadenaDia;
            cmbAnoCobertura.SelectedItem = cadenaAño;
            // Se selecciona el mes dependiendo del numero recuperado
            if (cadenaMes == "01")
            {
                cmbMesCobertura.SelectedItem = "Enero";
            }
            else if (cadenaMes == "02")
            {
                cmbMesCobertura.SelectedItem = "Febrero";
            }
            else if (cadenaMes == "03")
            {
                cmbMesCobertura.SelectedItem = "Marzo";
            }
            else if (cadenaMes == "04")
            {
                cmbMesCobertura.SelectedItem = "Abril";
            }
            else if (cadenaMes == "05")
            {
                cmbMesCobertura.SelectedItem = "Mayo";
            }
            else if (cadenaMes == "06")
            {
                cmbMesCobertura.SelectedItem = "Junio";
            }
            else if (cadenaMes == "07")
            {
                cmbMesCobertura.SelectedItem = "Julio";
            }
            else if (cadenaMes == "08")
            {
                cmbMesCobertura.SelectedItem = "Agosto";
            }
            else if (cadenaMes == "09")
            {
                cmbMesCobertura.SelectedItem = "Septiembre";
            }
            else if (cadenaMes == "10")
            {
                cmbMesCobertura.SelectedItem = "Octubre";
            }
            else if (cadenaMes == "11")
            {
                cmbMesCobertura.SelectedItem = "Noviembre";
            }
            else if (cadenaMes == "12")
            {
                cmbMesCobertura.SelectedItem = "Diciembre";
            }

        }

        private void barraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) { 
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void barraSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
