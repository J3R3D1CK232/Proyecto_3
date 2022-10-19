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

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion obj2 = new conexion();

            /*String fecha_nacimiento = DateTime.Parse(dtpFechaNacimiento.Value.Date.ToString("MM-dd-yyyy")).ToShortDateString();
            String fecha_cobertura = DateTime.Parse(dtpFechaCobertura.Value.Date.ToString("MM-dd-yyyy")).ToShortDateString();
            DateTime fechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value.Date.ToString("yyyyy-MM-dd"), System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
            DateTime fechaCobertura = Convert.ToDateTime(dtpFechaCobertura.Value.Date.ToString("yyyyy-MM-dd"),System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);*/
            String fechaNacimiento = cmbMesNacimiento.SelectedItem.ToString() + "/" + cmbDiaNacimiento.SelectedItem.ToString() + "/" + cmbAnoNacimiento.SelectedItem.ToString();
            String fechaCobertura = cmbMesCobertura.SelectedItem.ToString() + "/" + cmbDiaCobertura.SelectedItem.ToString() + "/" + cmbAnoCobertura.SelectedItem.ToString();
            String fecha_Nacimiento = DateTime.Parse(fechaNacimiento).ToShortDateString();
            String fecha_Cobertura = DateTime.Parse(fechaNacimiento).ToShortDateString();
            MessageBox.Show(obj2.insertarAfiliado(txtpNombre.Text,txtsNombre.Text,txtpApellido.Text,txtsApellido.Text,fecha_Nacimiento,Convert.ToInt64(txtTelefono.Text),fecha_Cobertura,Convert.ToDecimal(txtMontoCobertura.Text),"Activo"));
        }

        private void frmRegistroAfiliado_Load(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
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
