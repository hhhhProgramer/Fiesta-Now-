using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Horario : BaseEntity
    {

        public DateTime Apertura { get; set; }
        public DateTime Cierre { get; set; }
        public string Dia { get; set; }
    }
}
