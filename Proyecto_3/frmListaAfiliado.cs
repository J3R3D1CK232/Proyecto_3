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
    public partial class frmListaAfiliado : Form
    {
        public frmListaAfiliado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.ttBusqueda.SetToolTip(this.txtBuscar, "Ingresar Código de Afiliado para realizar la busqueda");

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarAfiliado_Click(object sender, EventArgs e)
        {
            frmRegistroAfiliado frm = new frmRegistroAfiliado();
            frm.Show();
            this.Close();
        }

        private void btnListaAfiliado_Click(object sender, EventArgs e)
        {
            
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarAfiliado modificarAfiliado = new frmModificarAfiliado();
            modificarAfiliado.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void frmListaAfiliado_Load(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarAfiliado(dgvListaAfiliado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int64 buscarId = Convert.ToInt64(txtBuscar.Text);
            conexion obj1 = new conexion();
            obj1.buscarAfiliado(dgvListaAfiliado,buscarId);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarAfiliado(dgvListaAfiliado);
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
