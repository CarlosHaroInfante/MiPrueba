using MiExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExamen.Servicios
{
    internal interface NuevoClienteInterfaz
    {
        public void añadirCliente(List<ClienteDto> listaAntigua);

        public void ordernarCliente(List<ClienteDto> listaAntigua);
    }
}
