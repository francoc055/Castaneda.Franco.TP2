using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        Jugador jugadorUno;
        Jugador jugadorDos;
        int puntos;
        int cartasRestantes;
        List<Carta> cartasEnMesa;
        Simulacion simularPartida;
        Mazo mazo;

        public Jugador JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public Jugador JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int CartasRestantes { get => cartasRestantes; set => cartasRestantes = value; }
        public List<Carta> CartasEnMesa { get => cartasEnMesa; set => cartasEnMesa = value; }
        public Mazo Mazo { get => mazo; set => mazo = value; }

        public Partida(Jugador j1, Jugador j2)
        {
            this.jugadorUno = j1;
            this.jugadorDos = j2;
            cartasEnMesa = new List<Carta>(); 
            simularPartida = new Simulacion();
            Mazo = new Mazo();
        }

        public void IniciarPartida()
        {
            
           
            if(jugadorUno.Mano.Count == 0 && jugadorUno.Mano.Count == 0)
            {
                simularPartida.RepartirCartas(jugadorUno, jugadorDos, Mazo.MazoCartas, this);
            }
            if (cartasEnMesa.Count == 0)
            {
                simularPartida.RepartirCartasEnMesa(Mazo.MazoCartas, this);
            }
 
            bool trancadoJ1 = simularPartida.Pensar(jugadorUno, cartasEnMesa);
            bool trancadoJ2 = simularPartida.Pensar(jugadorDos, cartasEnMesa);

            if(trancadoJ1 && trancadoJ2)
            {
                jugadorUno.Mano.Clear();
                jugadorDos.Mano.Clear();
                simularPartida.RepartirCartas(jugadorUno, jugadorDos, Mazo.MazoCartas, this);
            }
        }



    }


}
