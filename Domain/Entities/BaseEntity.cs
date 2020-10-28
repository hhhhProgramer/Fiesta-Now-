using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GetDanceNow.Domain.Interfaces;

namespace Entity
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
