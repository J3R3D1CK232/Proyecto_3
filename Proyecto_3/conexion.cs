using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

class conexion
{
    SqlConnection cn;
    SqlCommand cmd;

    SqlDataReader dr;
    SqlDataAdapter adaptador;
    DataSet ds;

    public conexion()
    {
        try
        {
            cn = new SqlConnection("Data Source=J4K0232\\SQLEXPRESS;Initial Catalog=Proyecto_3;Integrated Security=True");
            cn.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
        }
    }

    public string insertarAfiliado(string pNombre, string sNombre, string pApellido, string sApellido, string fechaNacimiento, Int64 telefono, string fechaCobertura, decimal monto ,string estado)
    {
        string salida = "Registro Exitoso";
        try
        {
            cmd = new SqlCommand("Insert into afiliado(pNombre,sNombre,pApellido,sApellido,fecha_nacimiento,noTelefono,fechaIniciocobertura,montoCobertura,estado) values ('" + pNombre + "','" + sNombre + "','" + pApellido + "','" + sApellido + "','" + fechaNacimiento + "'," + telefono + ",'" + fechaCobertura + "','" + monto + "','" + estado + "')", cn);
            cmd.ExecuteNonQuery();            
        }
        catch (Exception ex)
        {
            salida = "No se pudo guardar la información: " + ex.ToString();
        }
        return salida;
    }
    public void cargarAfiliado(DataGridView tabla)
    {
        try
        {
            adaptador = new SqlDataAdapter("EXEC sp_afiliado_seleccion;", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "afiliado");
            tabla.DataSource = ds.Tables["afiliado"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No seconsulto la informacion: " + ex.ToString());
        }
    }

    public void buscarAfiliado(DataGridView tabla, string id)
    {
        try
        {
            adaptador = new SqlDataAdapter("Select  *  from afiliado Where id_afiliado like '" + "%" + id + "%" + "'", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "afiliado");
            tabla.DataSource = ds.Tables["afiliado"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se actualizó el registro: " + ex.ToString());
        }
    }
}