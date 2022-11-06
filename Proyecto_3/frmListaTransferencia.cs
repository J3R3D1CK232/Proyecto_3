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
    public partial class frmListaTransferencia : Form
    {
        
        public frmListaTransferencia()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.ttBusqueda.SetToolTip(this.txtBuscar, "Ingresar Código de Transferencia para realizar la busqueda");
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

        
        private void btnInsertarAfiliado_Click(object sender, EventArgs e)
        {
            frmRegistroAfiliado frm = new frmRegistroAfiliado();
            frm.Show();
            this.Close();
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

        private void frmListaAfiliado_Load(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarTransaccion(dgvListaTransaccion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor para realizar la búsqueda","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Int32 buscarId = Convert.ToInt32(txtBuscar.Text);
                conexion obj1 = new conexion();
                obj1.buscarTransaccion(dgvListaTransaccion, buscarId);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarTransaccion(dgvListaTransaccion);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permite ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
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

