using io.quind.banco.data.ClienteFabricas;
using io.quind.banco.data.Datos;
using io.quind.banco.dominio.Models;
using io.quind.banco.dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.banco.data.Repositorio
{
    public class ClienteRepositorio : IClienteServices
    {
        public string crear(Cliente cliente)
        {
           return Dato.crear(ClienteFabrica.DominioAEntidad(cliente));
        }

        public Cliente findById(int id)
        {
            return ClienteFabrica.EntidadAdominio(Dato.buscarPorId(id));
        }
    }
}
