using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Suscripcion : BaseEntity
    {

        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Detalles { get; set; }

    }
}
