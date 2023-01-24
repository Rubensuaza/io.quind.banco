using io.quind.banco.entidad.ClienteEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.banco.data.Datos
{
    public class Dato
    {
        public static ClienteEntidad buscarPorId(int id)
        {
            return new ClienteEntidad
            {
                id = id,
                name = "Ruben",
                descripcion = "desa"
            };
        }

        public static string crear(ClienteEntidad cliente)
        {
            return "Cliente guardado";
        }
    }
}
