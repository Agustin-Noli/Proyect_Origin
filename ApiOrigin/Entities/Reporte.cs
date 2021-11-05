using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace ApiOrigin.Entities
{
    public class Reporte
    {
        [Key]
        public string cliente { get; set; }
        public string tarjeta { get; set; }
        public string fecha { get; set; }

        public string cantidad { get; set; }

        public string balance { get; set; }


    }
}
