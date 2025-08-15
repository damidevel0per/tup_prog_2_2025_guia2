using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion.Models
{
    internal class Servicio
    {
        Persona[] persona = new Persona[100];
        private int contadorPersona;
        public bool AgregarPersona(Persona nueva)
        {
            if (contadorPersona < persona.Length)
            {
                persona[contadorPersona] = nueva;
                contadorPersona++;
                return true;
            }
            else { return false; }
        }
        public int VerCantidadPersonas()
        {
            return contadorPersona;
        }

        public Persona VerPersona(int n)
        {
            return persona[n];
        }
        public Persona VerPersonaPorDni(int dni)
        {
            int indice = -1;
            int c = 0;

            while (indice == -1 && c < contadorPersona)
            {
                if (persona[c].DNI == dni)
                {
                    indice = c;
                }
                c++;
            }

            if (indice != -1)
            {
                return persona[indice];
            }
            else return null;
        }

        public void EliminarPersona(Persona personaEnviada)
        {
            int busq = Busqueda(personaEnviada.DNI);
            if (busq != -1)
            {
                persona[busq] = persona[contadorPersona - 1];
                contadorPersona--;
            }
        }
        private int Busqueda(int dni)
        {
            int indice = -1;
            int c = 0;

            while (indice == -1 && c < contadorPersona)
            {
                if (persona[c].DNI == dni)
                {
                    indice = c;
                }
                c++;
            }
             return indice;
        }

    }
}
