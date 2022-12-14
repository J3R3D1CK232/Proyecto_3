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
    public partial class frmListaProveedor : Form
    {
        private frmModificarProveedor frmEntra = new frmModificarProveedor();
        public frmListaProveedor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.ttBusqueda.SetToolTip(this.txtBuscar, "Ingresar Código de Proveedor para realizar la busqueda");
            this.frmEntra.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModificarProveedor_FormClosed);
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
            
        }

        private void frmListaProveedor_Load(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarProveedor(dgvListaProveedor);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un valor para realizar la búsqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Int64 buscarId = Convert.ToInt64(txtBuscar.Text);
                conexion obj1 = new conexion();
                obj1.buscarProveedor(dgvListaProveedor, buscarId);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarProveedor(dgvListaProveedor);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();

            if (dgvListaProveedor.SelectedRows.Count > 0)
            {

                int numeroFila = dgvListaProveedor.CurrentRow.Index;
                int numeroColumna = dgvListaProveedor.Columns["Codigo Proveedor"].Index;
                DialogResult resultado = MessageBox.Show("Desea eliminar el dato seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    if (dgvListaProveedor.SelectedRows.Count > 0)
                    {
                        var idSeleccion = dgvListaProveedor.CurrentRow.Cells["Codigo Proveedor"].Value.ToString();
                        obj1.eliminarProveedor(idSeleccion);
                        obj1.cargarProveedor(dgvListaProveedor);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila para realizar la accion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    obj1.cargarAfiliado(dgvListaProveedor);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para realizar la accion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarProveedor modificarProveedor = new frmModificarProveedor();
            if (dgvListaProveedor.SelectedRows.Count > 0)
            {
                modificarProveedor.idAfiliado = dgvListaProveedor.CurrentRow.Cells[0].Value.ToString();
                modificarProveedor.txtNit.Text = dgvListaProveedor.CurrentRow.Cells[1].Value.ToString();
                modificarProveedor.txtRazonSocial.Text = dgvListaProveedor.CurrentRow.Cells[2].Value.ToString();
                modificarProveedor.estadoAfiliado = dgvListaProveedor.CurrentRow.Cells[3].Value.ToString();
                modificarProveedor.Show();
                this.Hide();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void barraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) { 
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            frmListaTransferencia frm = new frmListaTransferencia();
            frm.Show();
            this.Close();
        }

        private void barraSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void frmModificarProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarProveedor(dgvListaProveedor);
        }
    }
}
