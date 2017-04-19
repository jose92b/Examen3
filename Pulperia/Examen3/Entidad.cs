using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen3
{
    public class Entidad
    {
        String nom_empresa;
        String cont_nombre;
        String cont_telefono;
        String cont_email;
        String dias_espera;


        public Entidad(Object[] objeto)
        {
            this.nom_empresa = objeto[0].ToString();
            this.cont_nombre = objeto[1].ToString();
            this.cont_telefono = objeto[2].ToString();
            this.cont_email = objeto[3].ToString();
            this.dias_espera = objeto[4].ToString();


        }
        public String Nom_Empresa
        {
            get { return nom_empresa; }
            set { nom_empresa = value; }
        }
        public String Cont_Nombre
        {
            get { return cont_nombre; }
            set { cont_nombre = value; }
        }
        public String Cont_Telefono
        {
            get { return cont_telefono; }
            set { cont_telefono = value; }
        }
        public String Cont_Email
        {
            get { return cont_email; }
            set { cont_email = value; }
        }

        public String Dias_Espera
        {
            get { return dias_espera; }
            set { dias_espera = value; }
        }

    }
}