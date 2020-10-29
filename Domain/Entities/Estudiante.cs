using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Estudiante : BaseEntity
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int CuentaID { get; set; }
        public Cuenta cuenta { get; set; }
    }
}
