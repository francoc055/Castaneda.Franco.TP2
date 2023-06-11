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


        public Partida(Jugador j1, Jugador j2)
        {
            this.jugadorUno = j1;
            this.jugadorDos = j2;
            cartasEnMesa = new List<Carta>(); 
            simularPartida = new Simulacion();
            mazo = new Mazo();
        }

        public void IniciarPartida()
        {
            simularPartida.RepartirCartas(jugadorUno, jugadorDos, mazo.MazoCartas, this);
            foreach (Carta item in cartasEnMesa)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("--------------------------------------------------------------");
            simularPartida.Pensar(jugadorUno, cartasEnMesa);
            simularPartida.Pensar(jugadorDos, cartasEnMesa);
        }



    }


}
