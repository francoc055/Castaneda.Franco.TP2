using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ILogica
    {
        public void IRepartirCartas(Jugador j1, Jugador j2, List<Carta> mazo, Partida partida);

        public void IRepartirCartasEnMesa(List<Carta> mazo, Partida partida);

        public bool IPensar(Jugador jugador, List<Carta> cartasEnMesa);


    }
}
