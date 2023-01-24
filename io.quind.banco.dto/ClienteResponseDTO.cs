using io.quind.banco.dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.banco.dto
{
    public class ClienteResponseDTO
    {
        public string? nombre { get; set; }
        public string? descripcion { get; set; }

        public static ClienteResponseDTO of(Cliente cliente) 
        {
            return new ClienteResponseDTO
            {
                nombre = cliente.name,
                descripcion = cliente.descripcion
            };
        }
    }
}
