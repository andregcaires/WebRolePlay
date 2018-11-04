using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RPG.Domain.Models
{
    public class Status : Entity
    {
        [Required]
        public string StatusDescription { get; set; }
    }
}
