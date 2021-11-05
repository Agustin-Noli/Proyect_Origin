using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApiOrigin.Entities
{
    public class Balance
    {         
            [Key]
            public string tarjeta { get; set; }
            public string fecha { get; set; }
            public string codoperacion { get; set; }

            public string cantidad { get; set; }

    }

    
}

