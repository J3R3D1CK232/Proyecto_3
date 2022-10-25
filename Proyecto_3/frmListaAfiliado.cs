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
        private frmModificarAfiliado frmEntra = new frmModificarAfiliado();
        public frmListaAfiliado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.ttBusqueda.SetToolTip(this.txtBuscar, "Ingresar Código de Afiliado para realizar la busqueda");
            this.frmEntra.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModificarAfiliado_FormClosed);
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

        private void frmListaAfiliado_Load(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarAfiliado(dgvListaAfiliado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un valor para realizar la búsqueda","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Int64 buscarId = Convert.ToInt64(txtBuscar.Text);
                conexion obj1 = new conexion();
                obj1.buscarAfiliado(dgvListaAfiliado, buscarId);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarAfiliado(dgvListaAfiliado);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permite ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion obj1 = new conexion();

            if (dgvListaAfiliado.SelectedRows.Count > 0)
            {
                
                int numeroFila = dgvListaAfiliado.CurrentRow.Index;
                int numeroColumna = dgvListaAfiliado.Columns["Codigo Afiliado"].Index;
                DialogResult resultado = MessageBox.Show("Desea eliminar el dato seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    if (dgvListaAfiliado.SelectedRows.Count > 0)
                    {
                        var idSeleccion = dgvListaAfiliado.CurrentRow.Cells["Codigo Afiliado"].Value.ToString();
                        obj1.eliminarAfiliado(idSeleccion);
                        obj1.cargarAfiliado(dgvListaAfiliado);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila para realizar la accion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (resultado == DialogResult.No)
                {
                    obj1.cargarAfiliado(dgvListaAfiliado);
                }
            }
            else {
                MessageBox.Show("Seleccione una fila para realizar la accion","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);            
            }            
            
        }

        private void barraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1) { 
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void frmModificarAfiliado_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion obj1 = new conexion();
            obj1.cargarAfiliado(dgvListaAfiliado);
        }

        private void frmListaAfiliado_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void barraSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarAfiliado modificarAfiliado = new frmModificarAfiliado();
            if (dgvListaAfiliado.SelectedRows.Count > 0)
            {
                modificarAfiliado.idAfiliado = dgvListaAfiliado.CurrentRow.Cells[0].Value.ToString();
                modificarAfiliado.txtpNombre.Text = dgvListaAfiliado.CurrentRow.Cells[1].Value.ToString();
                modificarAfiliado.txtsNombre.Text = dgvListaAfiliado.CurrentRow.Cells[2].Value.ToString();
                modificarAfiliado.txtpApellido.Text = dgvListaAfiliado.CurrentRow.Cells[3].Value.ToString();
                modificarAfiliado.txtsApellido.Text = dgvListaAfiliado.CurrentRow.Cells[4].Value.ToString();
                modificarAfiliado.txtTelefono.Text = dgvListaAfiliado.CurrentRow.Cells[6].Value.ToString();
                modificarAfiliado.txtMontoCobertura.Text = dgvListaAfiliado.CurrentRow.Cells[8].Value.ToString();
                modificarAfiliado.estadoAfiliado = dgvListaAfiliado.CurrentRow.Cells[9].Value.ToString();
                modificarAfiliado.fechaNacimiento = dgvListaAfiliado.CurrentRow.Cells[5].Value.ToString();
                modificarAfiliado.fechaCobertura = dgvListaAfiliado.CurrentRow.Cells[7].Value.ToString();
                modificarAfiliado.Show();
                this.Hide();
            }
            else
                MessageBox.Show("seleccione una fila por favor");           

        }
        

    }
}

