using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Clase_Suscripciones : BaseEntity
    {

        public Clase Clase { get; set; }
        public int ClaseID { get; set; }
        public Suscripcion Suscripcion { get; set; }
        public int SuscripcionID { get; set; }
    }
}
