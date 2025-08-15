using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion.Models
{
    internal class Persona
    {
        public int DNI { get; }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public string Describir()
        {
            return $@"{DNI} - {Nombre}";
        }
    }
}
