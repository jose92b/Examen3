using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen3
{
    public class Controladora
    {
        ControladoraBD controladoraBD = new ControladoraBD();
        internal void agregar(object[] objeto)
        {
            Entidad persona = new Entidad(objeto);
               controladoraBD.agregar(persona);
        }
    }
}