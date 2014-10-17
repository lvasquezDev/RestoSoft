using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Servicio_Restaurante
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicio : System.Web.Services.WebService
    {
        public string Datosconexion = @"Data Source=|DataDirectory|\Restaurante.mdf;Initial Catalog=Restosoft;Integrated Security=True";
        public SqlConnection conectar;
        [WebMethod]
        public void Iniciar()
        {
            conectar = new SqlConnection(Datosconexion);
            conectar.Open();
        }
        [WebMethod]
        public void Cerrar()
        {
            conectar.Close();
        }
        [WebMethod]
        public DataSet ConsultaGeneral(string Tabla)
        {
            DataSet DataSet = new DataSet();
            bool validacion = true;
            try
            {
                if (Tabla == "")
                    Tabla = null;
                Iniciar();
                string consulta = "Select * From " + Tabla;
                SqlDataAdapter Comando = new SqlDataAdapter(consulta, conectar);
                Comando.Fill(DataSet, Tabla);
                
            }
            catch (Exception e)
            {
                validacion = false;
            }
            finally
            {

            }
            if (validacion == true)
                return DataSet;
            else
                return null;
        }
        [WebMethod]
        public string ingresarServicio(string idservicio, string mesa, string horaLlegada, string horaSalida, string nombreCliente)
        {
            bool validacion;          
            try
            {
            Iniciar();
            if (mesa == "" || horaSalida == "" || horaLlegada == "" || nombreCliente == "")
                throw new System.ArgumentException();
            string consulta = "INSERT INTO servicio VALUES('"+idservicio+"','"+mesa+"','"+horaLlegada+"','"+horaSalida+"','"+nombreCliente+"')";
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente el siguiente servicio:\nCliente: " + nombreCliente + "\nMesa: " + mesa + "\nHora de Llegada: " + horaLlegada + "\nHora de Salida: " + horaSalida;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
        [WebMethod]
        public string ingresarCliente(string nombre, string telefono)
        {
            bool validacion;
            try
            {
                Iniciar();
                if (nombre == "" || telefono == "")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO clientes VALUES('" + nombre + "','" + telefono + "',0)";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente el siguiente cliente:\nNombre: " + nombre + "\nNumero de Telefono: " + telefono;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
        [WebMethod]
        public string ingresarProducto(string nombreProducto, string tipoComida, string precio, string descripcion, string costo)
        {
            bool validacion;
            try
            {
                Iniciar();
                if (nombreProducto == "" || tipoComida == "" || precio == "" || descripcion == "" || costo == "")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO producto VALUES('" + nombreProducto + "','" +tipoComida+ "','" +precio + "','" +descripcion+ "','" +costo+ "')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente el siguiente producto:\nNombre: " + nombreProducto + "\nTipo de Comida:"+tipoComida+"\nPrecio:$"+precio+"\nDescripcion:"+descripcion+"\nCosto:$"+costo;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
		[WebMethod]
        public string ingresarOrdenes(string nombreCliente, string numeroDeMesa, string numeroOrden, string hora, string nombreProducto, string cantidad, string precio, string claveEmpleado)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreCliente == "" || numeroDeMesa == "" || numeroOrden == ""|| hora == "" || nombreProducto =="" || cantidad == "" || precio == ""|| claveEmpleado == "")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO ordenes VALUES('"+nombreCliente+"','"+numeroDeMesa+"','"+numeroOrden+"','"+hora+"','"+nombreProducto+"','"+cantidad+"','"+precio+"','"+claveEmpleado+"')";	
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente la siguiente orden:\nNombre del Cliente:"+nombreCliente+"\nNumero de Mesa:"+numeroDeMesa+"\nNumero de Orden:"+numeroOrden+"\nHora:"+hora+"\nNombre del Producto:"+nombreProducto+"\nCantidad:"+cantidad+"\nPrecio:$"+precio+"\nClave Empleado:"+claveEmpleado;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
		[WebMethod]
          public string ingresarDomicilio(string NoServicio,string nombreCliente, string telefono, string domicilio,string Orden, string Cantidad,string Costo)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreCliente == "" || telefono == "" || domicilio =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO domicilio VALUES('"+NoServicio+"','"+nombreCliente+"','"+telefono+"','"+domicilio+"','"+Orden+"','"+Cantidad+"','"+Costo+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente el siguiente domicilio:\nNombre del Cliente:"+nombreCliente+"\nNumero de Telefono:"+telefono+"\nDomicilio:"+domicilio;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		[WebMethod]
          public string ingresarReceta(string nombreProducto, string ingrediente, string cantidad)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreProducto == "" || ingrediente == "" || cantidad =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO receta VALUES('"+nombreProducto+"','"+ingrediente+"','"+cantidad+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente la siguiente receta:\nNombre del Producto:"+nombreProducto+"\nIngrediente:"+ingrediente+"\nCantidad:"+cantidad;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		  [WebMethod]
          public string ingresarProveedor(string idProveedor, string nombreEmpresa, string telefono, string direccion, string email, string rfc)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idProveedor == "" || nombreEmpresa == "" || telefono =="" || direccion ==""|| email ==""|| rfc =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO proveedores VALUES('"+idProveedor+"','"+nombreEmpresa+"','"+telefono+"','"+direccion+"','"+email+"','"+rfc+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente el siguiente proveedores:\nID del Proveedor:"+idProveedor+"\nNombre de la Empresa:"+nombreEmpresa+"\nTelefono:"+telefono+"\nDireccion:"+direccion+"\nEmail:"+email+"\nRfc:"+rfc;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		  [WebMethod]
          public string ingresarCompras(string idOrden, string idProveedor, string idProducto, string fechaCompra, string importe, string cantidad)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idOrden == "" || idProveedor == "" || idProducto =="" || fechaCompra ==""|| importe ==""|| cantidad =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO compras VALUES('"+idOrden+"','"+idProducto+"','"+fechaCompra+"','"+importe+"','"+cantidad+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente la siguiente compra:\nID de la Orden:"+idOrden+"\nid del Proveedor :"+idProveedor+"\nid Producto:"+idProducto+"\nFecha de Compra:"+fechaCompra+"\nImporte:"+importe+"\nCantidad:"+cantidad;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		  [WebMethod]
          public string ingresarReservacion(string idReservacion, string nombreCliente, string mesa, string fechaHora)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idReservacion == "" || nombreCliente == "" || mesa ==""  || fechaHora =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO reservacion VALUES('"+idReservacion+"','"+nombreCliente+"','"+mesa+"','"+fechaHora+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente la siguiente compra:\nID de la Reservacion"+idReservacion+"\nNombre del Cliente:"+nombreCliente+"\nMesa:"+mesa+"\nFecha y Hora de la reservacion:"+fechaHora;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		  [WebMethod]
          public string ingresarPersonal(string idEmpleado, string nombreEmpleado, string telefono, string direccion, string email, string puesto)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idEmpleado == "" || nombreEmpleado == "" || telefono =="" || direccion ==""|| email ==""|| puesto =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO personal VALUES('"+idEmpleado+"','"+nombreEmpleado+"','"+telefono+"','"+direccion+"','"+email+"','"+puesto+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente la siguiente personal:\nID del Empleado"+idEmpleado+"\nNombre del Empleado:"+nombreEmpleado+"\nTelefono:"+telefono+"\nDireccion:"+direccion+"\nEmail:"+email+"\nPuesto"+puesto;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		  [WebMethod]
          public string ingresarPromocion(string numeroPromocion, string descripcion, string fechaInicio, string fechaFin, string nombre)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (numeroPromocion == "" || descripcion == "" || fechaInicio =="" || fechaFin ==""|| nombre =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO promocion VALUES('"+numeroPromocion+"','"+descripcion+"','"+fechaInicio+"','"+fechaFin+"','"+nombre+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente la siguiente promocion:\nNumero de Promocion"+numeroPromocion+"\nDescripcion:"+descripcion+"\nFecha Inicio:"+fechaInicio+"\nFecha Fin:"+fechaFin+"\nNombre:"+nombre;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		  [WebMethod]
          public string ingresarUsuario(string nombreUsuario, string password, string puesto,string Nombre, string Direccion, string Telefono)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreUsuario == "" || password == "" || puesto =="")
                    throw new System.ArgumentNullException();
                string consulta = "INSERT INTO usuario VALUES('"+nombreUsuario+"','"+password+"','"+puesto+"','"+Nombre+"','"+Direccion+"','"+Telefono+"')";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente el siguiente usuario n:\nNumero de Usuario"+nombreUsuario+"\nPassword:"+password+"\nPuesto:"+puesto;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		 [WebMethod]
        public string eliminarServicio(string mesa, string horaLlegada, string horaSalida, string nombreCliente)
        {
            bool validacion;          
            try
            {
            Iniciar();
            if (mesa == "" || horaSalida == "" || horaLlegada == "" || nombreCliente == "")
                throw new System.ArgumentException();
            string consulta = "DELETE FROM servicio WHERE mesa ='"+mesa+"' and horaSalida= '"+horaSalida+"' and horaLlegada='"+horaLlegada+"' and nombreCliente='"+nombreCliente+"'";
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado  el siguiente servicio:\nCliente: " + nombreCliente + "\nMesa: " + mesa + "\nHora de Llegada: " + horaLlegada + "\nHora de Salida: " + horaSalida;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
		[WebMethod]
        public string eliminarCliente(string nombre, string telefono)
        {
            bool validacion;
            try
            {
                Iniciar();
                if (nombre == "" || telefono == "")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM clientes WHERE nombreCliente = '" + nombre + "' and telefono = '" + telefono + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente el siguiente cliente:\nNombre: " + nombre + "\nNumero de Telefono: " + telefono;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
		[WebMethod]
        public string eliminarProducto(string nombreProducto, string tipoComida, string precio, string descripcion, string costo)
        {
            bool validacion;
            try
            {
                Iniciar();
                if (nombreProducto == "" || tipoComida == "" || precio == "" || descripcion == "" || costo == "")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM producto WHERE nombreProducto ='" + nombreProducto + "' and tipoComida='" + tipoComida + "'and precio ='" + precio + "' and descripcion ='" + descripcion + "' and costo ='" + costo + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente el siguiente producto:\nNombre: " + nombreProducto + "\nTipo de Comida:"+tipoComida+"\nPrecio:$"+precio+"\nDescripcion:"+descripcion+"\nCosto:$"+costo;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
		[WebMethod]
        public string eliminarOrdenes(string nombreCliente, string numeroDeMesa, string numeroOrden, string hora, string nombreProducto, string cantidad, string precio, string claveEmpleado)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreCliente == "" || numeroDeMesa == "" || numeroOrden == ""|| hora == "" || nombreProducto =="" || cantidad == "" || precio == ""|| claveEmpleado == "")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM ordenes WHERE nombreCliente = '" + nombreCliente + "' and numeroDeMesa = '" + numeroDeMesa + "' and hora='" + hora + "' and nombreProducto='" + nombreProducto + "' and cantidad = '" + cantidad + "' and precio ='" + precio + "' and claveEmpleado = '" + claveEmpleado + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente la siguiente orden:\nNombre del Cliente:"+nombreCliente+"\nNumero de Mesa:"+numeroDeMesa+"\nNumero de Orden:"+numeroOrden+"\nHora:"+hora+"\nNombre del Producto:"+nombreProducto+"\nCantidad:"+cantidad+"\nPrecio:$"+precio+"\nClave Empleado:"+claveEmpleado;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e ingreselo otra vez";
        }
		[WebMethod]
          public string eliminarDomicilio(string nombreCliente, string telefono, string domicilio)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreCliente == "" || telefono == "" || domicilio =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM domicilio WHERE nombreCliente ='" + nombreCliente + "' and telefono = '" + telefono + "' domicilio = '" + domicilio + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a agregado exitosamente el siguiente domicilio:\nNombre del Cliente:"+nombreCliente+"\nNumero de Telefono:"+telefono+"\nDomicilio:"+domicilio;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		[WebMethod]
          public string eliminarReceta(string nombreProducto, string ingrediente, string cantidad)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreProducto == "" || ingrediente == "" || cantidad =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM receta WHERE nombreProducto ='"+nombreProducto+"' and ingrediente ='"+ingrediente+"' and cantidad ='"+cantidad+"'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente la siguiente receta:\nNombre del Producto:"+nombreProducto+"\nIngrediente:"+ingrediente+"\nCantidad:"+cantidad;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		[WebMethod]
          public string eliminarProveedor(string idProveedor, string nombreEmpresa, string telefono, string direccion, string email, string rfc)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idProveedor == "" || nombreEmpresa == "" || telefono =="" || direccion ==""|| email ==""|| rfc =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM proveedores WHERE idProveedor='" + idProveedor + "' and nombreEmpresa = '" + nombreEmpresa + "' and telefono ='" + telefono + "'and direccion = '" + direccion + "' and email ='" + email + " and rfc ='" + rfc + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente el siguiente proveedores:\nID del Proveedor:"+idProveedor+"\nNombre de la Empresa:"+nombreEmpresa+"\nTelefono:"+telefono+"\nDireccion:"+direccion+"\nEmail:"+email+"\nRfc:"+rfc;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		[WebMethod]
          public string eliminarCompras(string idOrden, string idProveedor, string idProducto, string fechaCompra, string importe, string cantidad)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idOrden == "" || idProveedor == "" || idProducto =="" || fechaCompra ==""|| importe ==""|| cantidad =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM compras WHERE idOrden='" + idOrden + "' and idProducto = '" + idProducto + "' and fechaCompra = '" + fechaCompra + "' and importe = '" + importe + "' and cantidad ='" + cantidad + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente la siguiente compra:\nID de la Orden:"+idOrden+"\nid del Proveedor :"+idProveedor+"\nid Producto:"+idProducto+"\nFecha de Compra:"+fechaCompra+"\nImporte:"+importe+"\nCantidad:"+cantidad;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		[WebMethod]
          public string eliminarReservacion(string idReservacion, string nombreCliente, string mesa, string fechaHora)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idReservacion == "" || nombreCliente == "" || mesa ==""  || fechaHora =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM reservacion WHERE idReservacion='" + idReservacion + "' and nombreCliente ='" + nombreCliente + "' and mesa='" + mesa + "' and fechaHora='" + fechaHora + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente la siguiente compra:\nID de la Reservacion"+idReservacion+"\nNombre del Cliente:"+nombreCliente+"\nMesa:"+mesa+"\nFecha y Hora de la reservacion:"+fechaHora;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		[WebMethod]
          public string eliminarPersonal(string idEmpleado, string nombreEmpleado, string telefono, string direccion, string email, string puesto)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (idEmpleado == "" || nombreEmpleado == "" || telefono =="" || direccion ==""|| email ==""|| puesto =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM personal WHERE idEmpleado='"+idEmpleado+"' and nombreEmpleado = '"+nombreEmpleado+"' and telefono = '"+telefono+"' and direccion ='"+direccion+"' and email ='"+email+"' and puesto='"+puesto+"'"; 
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente la siguiente personal:\nID del Empleado"+idEmpleado+"\nNombre del Empleado:"+nombreEmpleado+"\nTelefono:"+telefono+"\nDireccion:"+direccion+"\nEmail:"+email+"\nPuesto"+puesto;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		 [WebMethod]
          public string eliminarPromocion(string numeroPromocion, string descripcion, string fechaInicio, string fechaFin, string nombre)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (numeroPromocion == "" || descripcion == "" || fechaInicio =="" || fechaFin ==""|| nombre =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM promocion WHERE numeroPromocion='"+numeroPromocion+"' and descripcion ='"+descripcion+"' and fechaInicio ='"+fechaInicio+"' and fechaFin ='"+fechaFin+"' and nombre='"+nombre+"'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente la siguiente promocion:\nNumero de Promocion"+numeroPromocion+"\nDescripcion:"+descripcion+"\nFecha Inicio:"+fechaInicio+"\nFecha Fin:"+fechaFin+"\nNombre:"+nombre;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
		 [WebMethod]
          public string eliminarUsuario(string nombreUsuario, string password, string puesto)
        {
			bool validacion;
            try
            {
                Iniciar();
                if (nombreUsuario == "" || password == "" || puesto =="")
                    throw new System.ArgumentNullException();
                string consulta = "DELETE FROM usuario WHERE nombreUsuario='"+nombreUsuario+"' and password='"+password+"' and puesto ='"+puesto+"'";
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Cerrar();
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
            }
            finally
            {
                Cerrar();
                validacion = true;
            }
            if (validacion == true)
                return "Se a eliminado exitosamente el siguiente usuario n:\nNumero de Usuario"+nombreUsuario+"\nPassword:"+password+"\nPuesto:"+puesto;
            else
                return "Uno de los datos es erroneo, por favor, corrijalo e intentelo otra vez";
        }
    }
}