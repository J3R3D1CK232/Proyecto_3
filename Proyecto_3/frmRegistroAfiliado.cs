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
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Proyecto_3
{
    public partial class frmRegistroAfiliado : Form
    {
        public frmRegistroAfiliado()
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
            Application.Exit();
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

        private void btnListaAfiliado_Click(object sender, EventArgs e)
        {
            frmListaAfiliado frm = new frmListaAfiliado();
            frm.Show();
            this.Close();
        }

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {
            frmRegistroProveedor frm = new frmRegistroProveedor();
            frm.Show();
            this.Close();
        }

        private void listaProveedor_Click(object sender, EventArgs e)
        {
            frmListaProveedor frm = new frmListaProveedor();
            frm.Show();
            this.Close();
        }

        private void txtpNombre_Enter(object sender, EventArgs e)
        {
            txtpNombre.Clear();
        }

        private void txtsNombre_Enter(object sender, EventArgs e)
        {
            txtsNombre.Clear();
        }

        private void txtpApellido_Enter(object sender, EventArgs e)
        {
            txtpApellido.Clear();
        }

        private void txtsApellido_Enter(object sender, EventArgs e)
        {
            txtsApellido.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permite ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
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

        public void limpiarControles() {
            txtpNombre.Clear();
            txtsNombre.Clear();
            txtpApellido.Clear();
            txtsApellido.Clear();
            txtTelefono.Clear();
            txtMontoCobertura.Clear();
            cmbDiaNacimiento.SelectedIndex = -1;
            cmbMesNacimiento.SelectedIndex = -1;
            cmbAnoNacimiento.SelectedIndex = -1;
            cmbDiaCobertura.SelectedIndex = -1;
            cmbMesCobertura.SelectedIndex = -1;
            cmbAnoCobertura.SelectedIndex = -1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion obj2 = new conexion();

            if ((cmbDiaNacimiento.SelectedIndex == -1) || (cmbMesNacimiento.SelectedIndex == -1) || (cmbAnoNacimiento.SelectedIndex == -1))
            {
                MessageBox.Show("Debe completar la fecha de nacimiento","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if ((cmbDiaCobertura.SelectedIndex == -1) || (cmbMesCobertura.SelectedIndex == -1) || (cmbAnoCobertura.SelectedIndex == -1))
            {
                MessageBox.Show("Debe completar la fecha de cobertura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtpNombre.Text == "" || txtsNombre.Text == "" || txtpApellido.Text == "" || txtsApellido.Text == "" || txtTelefono.Text == "" || txtMontoCobertura.Text == "")
            {
                MessageBox.Show("Debe completar la información", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //convertir los meses de letras a numeros 
            string mesNacimiento = cmbMesNacimiento.SelectedItem.ToString();
            string mesNacimientoNumero = "";
            string mesCobertura = cmbMesCobertura.SelectedItem.ToString();
            string mesCoberturaNumero = "";

            if (mesNacimiento == "Enero") {
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



            string fechaNacimiento = /*cmbMesNacimiento.SelectedItem.ToString()*/ mesNacimientoNumero + "/" + cmbDiaNacimiento.SelectedItem.ToString() + "/" + cmbAnoNacimiento.SelectedItem.ToString();
            string fechaCobertura = /*cmbMesCobertura.SelectedItem.ToString()*/ mesCoberturaNumero + "/" + cmbDiaCobertura.SelectedItem.ToString() + "/" + cmbAnoCobertura.SelectedItem.ToString();
            /*String fecha_Nacimiento = DateTime.Parse(fechaNacimiento).ToShortDateString();
            String fecha_Cobertura = DateTime.Parse(fechaCobertura).ToShortDateString();*/
            MessageBox.Show(obj2.insertarAfiliado(txtpNombre.Text,txtsNombre.Text,txtpApellido.Text,txtsApellido.Text,fechaNacimiento,Convert.ToInt32(txtTelefono.Text),fechaCobertura,Convert.ToDecimal(txtMontoCobertura.Text),"Activo"));
            limpiarControles();
        }

        private void frmRegistroAfiliado_Load(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            frmListaTransferencia frm = new frmListaTransferencia();
            frm.Show();
            this.Close();
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
