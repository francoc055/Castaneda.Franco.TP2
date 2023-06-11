using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carta
    {
        string nombre;
        int valor;

        public Carta(string nombre, int valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Valor { get => valor; set => valor = value; }


        public static bool operator ==(Carta cartaUno, Carta cartaDos)
        {
            if(cartaUno is not null ||  cartaDos is not null)
            {
                return cartaUno.nombre == cartaDos.nombre;
            }

            return false;
        }

        public static bool operator !=(Carta cartaUno, Carta cartaDos)
        {
            return !(cartaUno.nombre == cartaDos.nombre);
        }

        public override string ToString()
        {
            return $"{nombre} - {valor}\n";
        }
    }
}
