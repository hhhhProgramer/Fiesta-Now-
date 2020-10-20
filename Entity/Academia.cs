﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Academia : BaseEntity
    {

        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public int Longitud { get; set; }
        public int Latitud { get; set; }
        public string Logo { get; set; }


        public int CuentaID { get; set; }
        public Cuenta cuenta { get; set; }
        public ICollection<Clase> Clases { get; set; }
        public ICollection<CodigoBaile> CodigoBailes { get; set; }
    }
}
