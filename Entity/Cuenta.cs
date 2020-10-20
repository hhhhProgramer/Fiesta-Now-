using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Cuenta : BaseEntity
    {

        public string Correo { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public bool Estatus { get; set; }

        public ICollection<Suscripcion> Suscripciones { get; set; }
    }
}
