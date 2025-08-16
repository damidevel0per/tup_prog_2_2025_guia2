using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Composicion.Models
{
    internal class Servicio
    {
        private List<Persona> lista = new List<Persona>();

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
            return lista[a];
        }

        public Persona VerPersonaPorDNI(int dni)
        {
            int indice = -1;
            int c = 0;

            while (indice == -1 && c < lista.Count)
            {
                if (lista[c].DNI == dni)
                {
                    indice = c;
                }
                c++;
            }

            if (indice != -1)
            {
                return lista[indice];
            }
            else return null;
        }

        public void EliminarPersona(Persona persona)
        {
            Persona personaAEliminar = VerPersonaPorDNI(persona.DNI);

            if (personaAEliminar != null)
            {
                lista.Remove(persona);
            }
        }


    }
}
