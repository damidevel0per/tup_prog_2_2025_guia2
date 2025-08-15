using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion.Models
{
    internal class Servicio
    {
        private List<Persona> lista;

        public Servicio()
        {

        }

        public bool AgregarPersona(int dni, string nombre)
        {
            Persona nuevaPersona = new Persona(dni, nombre);
            lista.Add(nuevaPersona);
            return true;
        }

        public int VerCantidadPersonas()
        {
            int cant = lista.Count();
            return cant;
        }

        public Persona VerPersona(int a)
        {
            return lista[a] as Persona;
        }

    }
}
