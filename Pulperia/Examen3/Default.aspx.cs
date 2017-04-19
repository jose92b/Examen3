using Clase9.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen3
{
    public partial class _Default : Page
    {
        Adaptador adaptador = new Adaptador();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ConsultarProveedor(object sender, EventArgs e)
        {
            String consulta = "select id, empresa, cont_nombre, cont_telefono, cont_email, dias_espera from Proveedor where empresa = 'P&G'";
            DataTable tabla = adaptador.consultar(consulta);

            grvReporte.DataSource = tabla;
            grvReporte.DataBind();
        }

                protected void ConsultarProducto(object sender, EventArgs e)
        {
            String consulta = "select Name as Nombre, Color as Color, StandardCost as Costo, ListPrice as Precio from [SalesLT].[Product]";
            DataTable tabla = adaptador.consultar(consulta);

            grvReporte.DataSource = tabla;
            grvReporte.DataBind();
        }

        protected void Insertar(String Empresa, String ContNombre, String ContTel, String ContMail, String DiasEspera)
        {
            String consulta = "insert into proveedor(empresa, cont_nombre, cont_telefono, cont_email, dias_espera) values (@empresa, @cont_nombre, @cont_telefono, @cont_email, @dias_espera);";
            SqlCommand comando = new SqlCommand(consulta);

            SqlParameter empresa = new SqlParameter("@empresa", SqlDbType.VarChar, 30);
            empresa.Value = Empresa;

            SqlParameter cont_nombre = new SqlParameter("@cont_nombre", SqlDbType.VarChar, 30);
            empresa.Value = ContNombre;

            SqlParameter cont_telefono = new SqlParameter("@cont_telefono", SqlDbType.VarChar, 12);
            empresa.Value = ContTel;

            SqlParameter cont_email = new SqlParameter("@cont_email", SqlDbType.VarChar, 30);
            empresa.Value = ContMail;

            SqlParameter dias_espera = new SqlParameter("@dias_espera", SqlDbType.VarChar, 30);
            empresa.Value = DiasEspera;


            comando.Parameters.Add(Empresa);
            comando.Parameters.Add(ContNombre);
            comando.Parameters.Add(ContTel);
            comando.Parameters.Add(ContMail);
            comando.Parameters.Add(DiasEspera);

            adaptador.insertar(comando);
        }
    }
}