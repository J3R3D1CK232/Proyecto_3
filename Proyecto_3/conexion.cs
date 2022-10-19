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

    public string insertarAfiliado(string pNombre, string sNombre, string pApellido, string sApellido, String fechaNacimiento, Int64 telefono, String fechaCobertura, decimal monto ,string estado)
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
}