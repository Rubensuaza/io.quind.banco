using io.quind.banco.dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.banco.dominio.Servicios
{
    public interface IClienteServices
    {
        Cliente findById(int id);
        string crear(Cliente cliente);
    }
}
