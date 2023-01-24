using io.quind.banco.dominio.Models;
using io.quind.banco.entidad.ClienteEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.banco.data.ClienteFabricas
{
    public class ClienteFabrica
    {
        public static ClienteEntidad DominioAEntidad(Cliente cliente)
        {
            return new ClienteEntidad
            {
                id = cliente.id,
                descripcion = cliente.descripcion,
                name = cliente.name,
            };
        }

        public static Cliente EntidadAdominio(ClienteEntidad cliente)
        {
            return new Cliente
            {
                id = cliente.id,
                name = cliente.name,
                descripcion = cliente.descripcion,
            };
        }
    }
}
