using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RestoSoft
{
    class Replicacion
    {
        public static int contador=49;
        //En este metodo solo generaremos una base de datosen blanco, la cual nos servira para la generacion de la replica.
        public string GenerarBaseDeDatos()
        {
            contador = contador + 1;
            string Nombre = "Respaldo" + contador.ToString();
            SqlConnection conexion = new SqlConnection(@"Server=(local);Integrated Security=True");
            SqlCommand creacion = new SqlCommand("CREATE DATABASE "+Nombre, conexion);
            try
            {
                conexion.Open();
                creacion.ExecuteNonQuery();
                return Nombre;
            }
            catch (Exception e) { return "Error: " + e.Message; }
            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Close(); }
            }
        }
        //tenemos este metodo el cual regresara un arreglo con los nombres de la base de datos original
        //para esto necesitaremos guardar los nombres de las tablas en el arreglo tablas, y de ahi
        //pasarlas a un segundo arreglo y regresar ese arreglo, recibiendo como parametro (el metodo)
        //el string Conection).
        public string[] BuscarTablas(string Conexion)
        {
            SqlConnection conection = new SqlConnection(Conexion);
            SqlCommand Buscar = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", conection);
            try
            {
                conection.Open();
                SqlDataReader r = Buscar.ExecuteReader();
                string[] Tablas = new string[20];
                if (r.HasRows)
                {
                    int i = 0;
                    while (r.Read())
                    {
                        Tablas[i] = r.GetString(0);
                        i++;
                    }
                }
                string[] Tablas2 = null;
                for (int i = 0; i < Tablas.Length; i++)
                {
                    if (Tablas[i] != null)
                    {
                        Tablas2 = new string[i + 1];
                    }
                }
                for (int i = 0; i < Tablas2.Length; i++)
                {
                    Tablas2[i] = Tablas[i];
                }
                return Tablas2;
            }
            catch (Exception e)
            {
                return new string[] { "ERROR: " + e };
            }
            finally
            {
                if (conection.State == ConnectionState.Open)
                {
                    conection.Close();
                }
            }
        }

        //Metodo muy similar al anterior, solo que este en vez de regresar el nombre de las tablas,
        //regresara los atributos de estas, recibiendo como parametro, el nombre de la tabla de la cual
        //extraera los registros, y de nuevo el string conection.

        public string[] BuscarAtributos(string NombreT, string Conexion)
        {
            SqlConnection conection = new SqlConnection(Conexion);
            SqlCommand Busqueda = new SqlCommand("SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + NombreT + "'", conection);
            try
            {
                conection.Open();
                SqlDataReader r = Busqueda.ExecuteReader();
                string[] Clumnas = new string[20];
                if (r.HasRows)
                {
                    int i = 0;
                    while (r.Read())
                    {
                        Clumnas[i] = r.GetString(1);
                        i++;
                    }
                }
                string[] Columnas2 = null;
                for (int i = 0; i < Clumnas.Length; i++)
                {
                    if (Clumnas[i] != null) { Columnas2 = new string[i + 1]; }
                }
                for (int i = 0; i < Columnas2.Length; i++)
                {
                    Columnas2[i] = Clumnas[i];
                }
                return Columnas2;
            }
            catch (Exception e) { return new string[] { "ERROR: " + e }; }
            finally { if (conection.State == ConnectionState.Open) { conection.Close(); } }
        }

        //es aqui donde se crean las tablas de la replica (osease en la nueva base de datos, creada anteriormente)
        //recibiendo como parametros, el Nombre de la tabla a crear (extraida en el metodo buscar tablas), los atributos
        //que tendra la tabla (Extraidos de buscar atributos), El tipo de datos que seran y por ultimo el 
        //string Conection.
        public string GeneracionTablas(string Nombre, string[] Atributos, string[] Tipos, string conexion)
        {
            SqlConnection conection = new SqlConnection(conexion);
            string cmd = "CREATE TABLE " + Nombre + "(";

            for (int i = 0; i < Atributos.Length - 1; i++)
            {
                cmd += Atributos[i] + " " + Tipos[i] + ",";
            }
            cmd += Atributos[Atributos.Length - 1] + " " + Tipos[Atributos.Length - 1] + ")";

            SqlCommand crear = new SqlCommand(cmd, conection);
            try
            {
                conection.Open();
                crear.ExecuteNonQuery();
                return "Tabla creada.";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
            finally
            {
                if (conection.State == ConnectionState.Open)
                {
                    conection.Close();
                }
            }
        }


    }
}
