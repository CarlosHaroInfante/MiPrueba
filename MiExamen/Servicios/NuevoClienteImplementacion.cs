using MiExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExamen.Servicios
{
    internal class NuevoClienteImplementacion : NuevoClienteInterfaz
    {

        public void añadirCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Datos del cliente");

            Console.WriteLine("Id: ");
            long id = Convert.ToInt64(Console.ReadLine());
            id = cliente.Id;
             

            Console.WriteLine("Nombre: ");
            string nom = Console.ReadLine();
            nom = cliente.Nombre;

            Console.WriteLine("Apellido: ");
            string ape = Console.ReadLine();
            ape = cliente.Apellidos;

            Console.WriteLine("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            edad = cliente.Edad;

            cliente.ToString();
            listaAntigua.Add(cliente);

            
        }
        public void ordernarCliente(List<ClienteDto> listaAntigua)
        {
            int e;
            ClienteDto cliente = new ClienteDto();

            for (int i = 0; i < listaAntigua.Count; i++)
            {
                for(int j = 0; j < listaAntigua.Count + 1; j++)
                {
                    if (listaAntigua[j - 1] > listaAntigua[j])
                    {

                        e = listaAntigua[j - 1];
                        listaAntigua[j - 1] = listaAntigua[j];
                        listaAntigua[j] = e;

                        listaAntigua.Add(cliente);
                        Console.WriteLine(cliente.ToString());
                    }

                }
            }
           
           
            


        }

    }
}
