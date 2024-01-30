using MiExamen.Servicios;
using MiExamen.Dtos;

namespace MiExamen
{

    class Program
    {


        static void Main(string[] args)
        {

            MenuInterfaz menu = new MenuImplementacion();

            bool cerrarMenu = false;

            while (!cerrarMenu)
            {

                int opcion = menu.menu();
                List<ClienteDto> cliente = new List<ClienteDto>();
                NuevoClienteInterfaz cli = new NuevoClienteImplementacion();

                switch (opcion) { 
                
                    case 0:
                        Console.WriteLine("Se cerrará el menú");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se añadirá un nuevo usuario");
                        cli.añadirCliente(cliente);
                        break;
                    case 2:
                        Console.WriteLine("Se ordenará los usuarios por edad");
                        cli.ordernarCliente(cliente);
                        foreach (ClienteDto cliente1 in cliente)
                        {
                            Console.WriteLine(cliente1.ToString());
                        }
                        break;

                    default: 
                        Console.WriteLine("Ninguna opción válida");
                        break;
                
                }


            }

        }


    }


}
