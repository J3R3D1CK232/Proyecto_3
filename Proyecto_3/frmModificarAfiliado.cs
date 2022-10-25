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
            frmListaAfiliado listaAfiliado = new frmListaAfiliado();            
            this.Close();
            listaAfiliado.barraSuperior.BackColor = Color.FromArgb(36, 65, 95);
            listaAfiliado.btnCerrar.BackColor = Color.FromArgb(224, 68, 88);
            listaAfiliado.btnMinimizar.BackColor = Color.FromArgb(231, 248, 250);
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
