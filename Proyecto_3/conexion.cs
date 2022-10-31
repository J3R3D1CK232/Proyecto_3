using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            cn = new SqlConnection("Server=tcp:proyecto3-server.database.windows.net,1433;Initial Catalog=Proyecto_3;Persist Security Info=False;User ID=Administrador;Password=Admin_2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            cn.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
        }
    }

    public string insertarAfiliado(string pNombre, string sNombre, string pApellido, string sApellido, string fechaNacimiento, Int64 telefono, string fechaCobertura, decimal monto, string estado)
    {
        string salida = "Registro Exitoso";
        try
        {
            cmd = new SqlCommand("Insert into afiliado(pNombre,sNombre,pApellido,sApellido,fecha_nacimiento,noTelefono,fechaIniciocobertura,montoCobertura,estado) values ('" + pNombre + "','" + sNombre + "','" + pApellido + "','" + sApellido + "','" + fechaNacimiento + "'," + telefono + ",'" + fechaCobertura + "','" + monto + "','" + estado + "')", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se pudo guardar la información, Error: " + ex.ToString() + " Fin Error";
        }
        return salida;
    }
    public void cargarAfiliado(DataGridView tabla)
    {
        try
        {
            adaptador = new SqlDataAdapter("EXEC sp_afiliado_leer;", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "afiliado");
            tabla.DataSource = ds.Tables["afiliado"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo consultar la información, Error: " + ex.ToString() + " Fin Error");
        }
    }

    public void buscarAfiliado(DataGridView tabla, Int64 id)
    {
        try
        {
            adaptador = new SqlDataAdapter("EXEC sp_afiliado_buscar @IDAFILIADO = " + id + ";", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "afiliado");
            tabla.DataSource = ds.Tables["afiliado"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo realizar la búsqueda, Error: " + ex.ToString() + " Fin Error");
        }
    }

    public string insertarProveedor(Int64 nit, string razonSocial, string Estado) {
        string salida = string.Empty;
        int retorno = 0;
        int retornoT = 0;
        SqlCommand cmdt;
        cmd = new SqlCommand("Select ISNULL(MAX(id_proveedor),0) from proveedor where nit = " + nit + ";", cn);
        cmdt = new SqlCommand("Select ISNULL(MAX(id_proveedor),0) from proveedor where razonSocial ="+ razonSocial + ";",cn);
        retornoT = Convert.ToInt32(cmdt.ExecuteScalar());
        retorno = Convert.ToInt32(cmd.ExecuteScalar());
        if (retorno != 0 && retornoT != 0)
        {
            MessageBox.Show("Ya existe un proveedor registrado con esta información", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            salida = "No se pudo realizar el registro";
            return salida;
        }
        else {
            try
            {
                cmd = new SqlCommand("sp_proveedor_registro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nit", SqlDbType.BigInt).Value = nit;
                cmd.Parameters.AddWithValue("@razonSocial", SqlDbType.NVarChar).Value = razonSocial;
                cmd.Parameters.AddWithValue("@estado", SqlDbType.NVarChar).Value = Estado;
                cmd.ExecuteNonQuery();
                salida = "Registro Exitoso";
            }
            catch (Exception ex)
            {
                salida = "No se pudo realizar el registro" + ex.ToString() + " Fin Error";
            }
            return salida;
        }

    }

    public void cargarProveedor(DataGridView tabla)
    {
        try
        {
            adaptador = new SqlDataAdapter("EXEC sp_proveedor_leer;", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "proveedor");
            tabla.DataSource = ds.Tables["proveedor"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo consultar la información, Error: " + ex.ToString() + " Fin Error");
        }
    }

    public void buscarProveedor(DataGridView tabla, Int64 id)
    {
        try
        {
            adaptador = new SqlDataAdapter("EXEC sp_proveedor_buscar @IDPROVEEDOR = " + id + ";", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "proveedor");
            tabla.DataSource = ds.Tables["proveedor"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo realizar la búsqueda, Error: " + ex.ToString() + " Fin Error");
        }
    }

    public void eliminarAfiliado(string id) {
        
        try {

            cmd = new SqlCommand("DELETE from afiliado WHERE id_afiliado = "+ id + ";", cn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Dato Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else {
                MessageBox.Show("El dato no existe en la tabla afiliado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
                                 
        }
        catch(Exception ex) {
            MessageBox.Show("No se pudo eliminar el dato de la tabla afiliado, Error: " + ex.ToString() + " Fin Error");
        }
        
        
    }

    public void eliminarProveedor(string id)
    {

        try
        {

            cmd = new SqlCommand("EXEC sp_proveedor_borrar @id_proveedor = " + id + ";", cn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Dato Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("El dato no existe en la tabla proveedores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo eliminar el dato de la tabla proveedor, Error: " + ex.ToString() + " Fin Error");
        }


    }

    public string modificarAfiliado(Int64 id_afiliado, string pNombre, string sNombre, string pApellido, string sApellido, string fecha_nacimiento, Int64 telefono, string fecha_cobertura, decimal monto, string estado) {
        string salida;
        try { 
            cmd = new SqlCommand("sp_afiliado_actualizar",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_afiliado", SqlDbType.BigInt).Value = id_afiliado;
            cmd.Parameters.AddWithValue("@pNombre", SqlDbType.NVarChar).Value = pNombre;
            cmd.Parameters.AddWithValue("@sNombre", SqlDbType.NVarChar).Value = sNombre;
            cmd.Parameters.AddWithValue("@pApellido", SqlDbType.NVarChar).Value = pApellido;
            cmd.Parameters.AddWithValue("@sApellido", SqlDbType.NVarChar).Value = sApellido;
            cmd.Parameters.AddWithValue("@fecha_nacimiento", SqlDbType.NVarChar).Value = fecha_nacimiento;
            cmd.Parameters.AddWithValue("@noTelefono", SqlDbType.BigInt).Value = telefono;
            cmd.Parameters.AddWithValue("@fechaIniciocobertura", SqlDbType.NVarChar).Value = fecha_cobertura;
            cmd.Parameters.AddWithValue("@montoCobertura", SqlDbType.Decimal).Value = monto;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.NVarChar).Value = estado;
            cmd.ExecuteNonQuery();
            salida = "Actualizacion Exitosa";
        }
        catch (Exception ex){
            salida = "No se pudo realizar la modificacion del registro : " + ex.ToString() + " Fin Error";
        }
        return salida;
    }

    public string modificarProveedor(Int64 id_proveedor, Int64 nit, string razonSocial,  string estado)
    {
        string salida;
        try
        {
            cmd = new SqlCommand("sp_proveedor_actualizar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_proveedor", SqlDbType.BigInt).Value = id_proveedor;
            cmd.Parameters.AddWithValue("@nit", SqlDbType.BigInt).Value = nit;
            cmd.Parameters.AddWithValue("@razonSocial ", SqlDbType.NVarChar).Value = razonSocial;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.NVarChar).Value = estado;
            cmd.ExecuteNonQuery();
            salida = "Actualizacion Exitosa";
        }
        catch (Exception ex)
        {
            salida = "No se pudo realizar la modificacion del registro : " + ex.ToString() + " Fin Error";
        }
        return salida;
    }

    public void buscarTransaccion(DataGridView tabla, Int64 id)
    {
        try
        {
            adaptador = new SqlDataAdapter("EXEC sp_transaccion_buscar @IDTRANSACCION = " + id + ";", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "transaccion");
            tabla.DataSource = ds.Tables["trasaccion"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo realizar la búsqueda, Error: " + ex.ToString() + " Fin Error");
        }
    }

    public void cargarTransaccion(DataGridView tabla)
    {
        try
        {
            adaptador = new SqlDataAdapter("EXEC sp_transaccion_leer;", cn);
            ds = new DataSet();
            adaptador.Fill(ds, "transaccion");
            tabla.DataSource = ds.Tables["transaccion"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudo consultar la información, Error: " + ex.ToString() + " Fin Error");
        }
    }
}