using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ApiOrigin.Entities
{
    public class Retiro
    {
        [Key]
        public string id { get; set; }
        public string retiro { get; set; }
    }
}
