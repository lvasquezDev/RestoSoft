using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace RestoSoft
{
    class Consultas
    {
        public static SqlConnection Var_Coneccion = new SqlConnection();
        //Metodos internos para realizar las conecciones necesarias a la bases de datos.
        private static void Abrir()
        {
            Var_Coneccion.ConnectionString = @"Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Var_Coneccion.Open();
        }
        public string NuevaOrden(string Nombre,int NumeroMesa,int NumeroOrden,string fecha,string NombreProducto,int cantidad,double SubTotal,int claveEmpleado)
        {
            Abrir();
            string SqlSentence = "INSERT INTO ordenes VALUES('" + Nombre + "','" + NumeroMesa + "','" + NumeroOrden + "','" + fecha + "','" + NombreProducto + "','" + cantidad + "','" + SubTotal + "','" + claveEmpleado + "')";
            SqlCommand Cmd = new SqlCommand(SqlSentence, Var_Coneccion);
            Cmd.ExecuteNonQuery();
            return "Orden Ingresada";
        }
        public string EliminarOrden(int ID)
        {
            Abrir();
            string SqlSentence = "DELETE FROM ordenes WHERE numeroOrden='"+ID+"'";
            SqlCommand Cmd = new SqlCommand(SqlSentence, Var_Coneccion);
            Cmd.ExecuteNonQuery();
            return "Orden Eliminada";
        }
        //Este Metodo recive como parametro el numero de control o de empleado, del maestro, para poder actualizarlo con el nombre
        //del mismo mediante una busqueda en la base de datos.
        public string ActualizarDatosCliente(string Nombre)
        {
            string Numero="";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            conexion.Open();
            SqlCommand BucarTelefono = new SqlCommand(@"Select telefono from clientes where nombreCliente='" + Nombre+"'", conexion);
            SqlDataReader DataReader = BucarTelefono.ExecuteReader();
            if (DataReader.Read())
            {
                Numero = DataReader.GetString(0);
            }
            conexion.Close();
            return Numero;

        }
        public string ActualizarDatosClienteVisitas(string Nombre)
        {
            string Visitas = "";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            conexion.Open();
            SqlCommand BucarVisitas = new SqlCommand("Select visitas from clientes where nombreCliente='" + Nombre+"'", conexion);
            SqlDataReader DataReader = BucarVisitas.ExecuteReader();
            if (DataReader.Read())
            {
                Visitas = DataReader.GetString(0);
            }
            conexion.Close();
            return Visitas;

        }
        //Usuarios:
        public string ActualizarDatosUsuario(string Nombre)
        {
            string pass = "";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Conexion.Open();
            SqlCommand BuscarPass = new SqlCommand(@"SELECT password FROM usuario where nombreUsuario='"+Nombre+"'",Conexion);
            SqlDataReader DataReader = BuscarPass.ExecuteReader();
            if (DataReader.Read())
            {
                pass = DataReader.GetString(0);
            }
            Conexion.Close();
            return pass;
        }
        public string ActualizarDatosUsuarioPuesto(string Nombre)
        {
            string Puesto = "";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Conexion.Open();
            SqlCommand BuscarPuesto = new SqlCommand(@"SELECT puesto FROM usuario where nombreUsuario='" + Nombre + "'", Conexion);
            SqlDataReader DataReader = BuscarPuesto.ExecuteReader();
            if (DataReader.Read())
            {
                Puesto = DataReader.GetString(0);
            }
            Conexion.Close();
            return Puesto;
        }
        //Reservaciones:
        public string ActualizarDatosReservacionNombre(string ID)
        {
            string Nombre = "";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Conexion.Open();
            SqlCommand BuscarNombre = new SqlCommand(@"SELECT nombreCliente FROM reservacion WHERE idReservacion='" + ID + "'", Conexion);
            SqlDataReader DataReader = BuscarNombre.ExecuteReader();
            if (DataReader.Read())
            {
                Nombre = DataReader.GetString(0);
            }
            Conexion.Close();
            return Nombre;
        }
        public string ActualizarDatosReservacionMesa(string ID)
        {
            string Mesa = "";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Conexion.Open();
            SqlCommand BuscarMesa = new SqlCommand(@"SELECT mesa FROM reservacion WHERE idReservacion='" + ID + "'", Conexion);
            SqlDataReader DataReader = BuscarMesa.ExecuteReader();
            if (DataReader.Read())
            {
                Mesa = DataReader.GetString(0);
            }
            Conexion.Close();
            return Mesa;
        }
        public string ActualizarDatosReservacionFecha(string ID)
        {
            string Fecha="";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Conexion.Open();
            SqlCommand BuscarFecha = new SqlCommand(@"SELECT fechaHora FROM reservacion WHERE idReservacion='" + ID + "'", Conexion);
            SqlDataReader DataReader = BuscarFecha.ExecuteReader();
            if (DataReader.Read())
            {
                Fecha = DataReader.GetSqlValue(0).ToString();
            }
            Conexion.Close();
            return Fecha;
        }
        //Ordenes:
        public string ActualizarPrecios(string NombreProducto)
        {
            string Nombre="";
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = "Data Source=PAULINA-PC;Initial Catalog=Restosoft;Integrated Security=True";
            Conexion.Open();
            SqlCommand BuscarPrecio = new SqlCommand(@"SELECT precio FROM producto WHERE nombreproducto='"+NombreProducto +"'",Conexion);
            SqlDataReader DataReader = BuscarPrecio.ExecuteReader();
            if (DataReader.Read())
            {
                Nombre = DataReader.GetSqlValue(0).ToString();
            }
            Conexion.Close();
            return Nombre;
        }
    }
}
