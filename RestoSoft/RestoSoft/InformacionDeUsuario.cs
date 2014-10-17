using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestoSoft
{
    class InformacionDeUsuario
    {
        public static string Nombredeusuario, password, puesto,nombre,direccion,numero;
        
        //Metodo que mandamos a llamar desde la forma de sesion para almacenar los datos del usuario que ya ingreso al sistema.
        public void AlmacenarDatos(string NUsuario, string Pass, string Puesto,string Nombre,string Direccion,string Numero)
        {
            Nombredeusuario = NUsuario;
            password = Pass;
            puesto = Puesto;
            nombre = Nombre;
            direccion = Direccion;
            numero = Numero;
        }
        //Metodo para Cerrar la Sesion, solo limpiamos las variables:
        public void CerrarSesion()
        {
            Nombredeusuario = "";
            password = "";
            puesto = "";
            nombre = "";
            direccion = "";
            numero = "";
        }
        //Metodo para desplegar la informacion cuando sea requerida por el usuario:
        //Desplegar el Nombre de Usuario:
        public string DesplegarNombreUsuario()
        {
            return Nombredeusuario;
        }
        //Desplegamos el Password:
        public string DesplegarPass()
        {
            return password;
        }
        //Desplegamos el Puesto que desempe;a:
        public string DesplegarPuesto()
        {
            return puesto;
        }
        //Desplegamos el Nombre Real Del Usuario:
        public string DesplegarNombre()
        {
            return nombre;
        }
        //Desplegamos la Direccion del Usuario:
        public string DesplegarDir()
        {
            return direccion;
        }
        //Desplegamos el numero de telefono:
        public string DesplegarNumero()
        {
            return numero;
        }
    }
}
