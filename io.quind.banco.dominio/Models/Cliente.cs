using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.banco.dominio.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? descripcion { get; set;}
    }
}
