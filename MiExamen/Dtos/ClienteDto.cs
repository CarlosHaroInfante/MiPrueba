using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiExamen.Dtos
{
    internal class ClienteDto
    {
        long id;

        string nombre = "aaaaa";

        string apellidos = "aaaaa";

        int edad = 99;

        

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }


        public ClienteDto(long id, string nombre, string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public ClienteDto() { } 

        override
        public string ToString()
        {

            string datos = "idCliente " + this.id +
                "Nombre y Apellidos " + this.nombre + this.apellidos +
                "Edad " + this.edad;

            return datos;
        }

        public static implicit operator int(ClienteDto v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ClienteDto(int v)
        {
            throw new NotImplementedException();
        }
    }
}
