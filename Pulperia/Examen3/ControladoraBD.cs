using Clase9.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen3
{
    public class ControladoraBD
    {

        Adaptador adaptador = new Adaptador();

        internal void Insertar(Entidad persona)
        {
            String consulta = "insert into proveedor(empresa, cont_nombre, cont_telefono, cont_email, dias_espera) values (@empresa, @cont_nombre, @cont_telefono, @cont_email, @dias_espera);";
            //values(@empresa, @cont_nombre, @cont_telefono, @cont_email, @dias_espera); ";

            SqlCommand comando = new SqlCommand(consulta);

            SqlParameter empresa = new SqlParameter("@empresa", SqlDbType.VarChar, 30);
            SqlParameter cont_nombre = new SqlParameter("@cont_nombre", SqlDbType.VarChar, 30);
            SqlParameter cont_telefono = new SqlParameter("@cont_telefono", SqlDbType.VarChar, 12);
            SqlParameter cont_email = new SqlParameter("@cont_email", SqlDbType.VarChar, 30);
            SqlParameter dias_espera = new SqlParameter("@dias_espera", SqlDbType.VarChar, 30);

            comando.Parameters.Add("@empresa", SqlDbType.VarChar, 30).Value = persona;
            comando.Parameters.Add("@cont_nombre", SqlDbType.VarChar, 30).Value = persona;
            comando.Parameters.Add("@cont_telefono", SqlDbType.VarChar, 12).Value = persona;
            comando.Parameters.Add("@cont_email", SqlDbType.VarChar, 30).Value = persona;
            comando.Parameters.Add("@dias_espera", SqlDbType.VarChar, 30).Value = persona;

            adaptador.insertar(comando);
        }

        internal void ConsultarProveedor(Entidad persona)
        {
            String consulta = "select id, empresa, cont_nombre, cont_telefono, cont_email, dias_espera from Proveedor where empresa = 'P&G'";
            adaptador.consultar(consulta);
        }

        internal void ConsultarProducto(Entidad persona)
        {
            String consulta = "select Name as Nombre, Color as Color, StandardCost as Costo, ListPrice as Precio from [SalesLT].[Product]";
            adaptador.consultar(consulta);
        }
    }
}