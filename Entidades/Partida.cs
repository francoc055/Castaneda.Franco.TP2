using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        static int ultimoId = 0;
        static bool flag = false;

        int id;
        Jugador jugadorUno;
        Jugador jugadorDos;
        List<Carta> cartasEnMesa;
        Simulacion simularPartida;
        Mazo mazo;
        string nombre;
        Jugador jugadorGanador;

        public Jugador JugadorUno { get => jugadorUno; set => jugadorUno = value; }
        public Jugador JugadorDos { get => jugadorDos; set => jugadorDos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; }

        [JsonIgnore]
        public List<Carta> CartasEnMesa { get => cartasEnMesa; set => cartasEnMesa = value; }

        [JsonIgnore]
        public Mazo Mazo { get => mazo; set => mazo = value; }
        public Jugador JugadorGanador { get => jugadorGanador; set => jugadorGanador = value; }


        //cosntructor para BD
        public Partida(int id, string nombreUsuario, string nombreOponente, string ganador)
        {
            this.id = id;
            this.jugadorUno = new Jugador(nombreUsuario);
            this.jugadorDos = new Jugador(nombreOponente);
            this.jugadorGanador = new Jugador(ganador);
        }

        public Partida(Jugador j1, Jugador j2)
        {
            if(!flag)
            {
                CargarUltimoId();
            }
            flag = true;
            id = GetNextId();
            this.jugadorUno = j1;
            this.jugadorDos = j2;
            cartasEnMesa = new List<Carta>(); 
            simularPartida = new Simulacion();
            Mazo = new Mazo();
        }

        private void CargarUltimoId()
        {
            try
            {
                List<Partida> partidas = AccesoDatos.LeerPartida();
                int idMayor = partidas[partidas.Count - 1].id;
                ultimoId = idMayor;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void IniciarPartida()
        {

            if (mazo.MazoCartas.Count == 40)
            {
                simularPartida.RepartirCartasEnMesa(Mazo.MazoCartas, this);
            }
            if (jugadorUno.Mano.Count == 0 && jugadorUno.Mano.Count == 0)
            {
                simularPartida.RepartirCartas(jugadorUno, jugadorDos, Mazo.MazoCartas, this);
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

        private static int GetNextId()
        {
            return Interlocked.Increment(ref ultimoId);
        }

        public override string ToString()
        {
            return $"Partida - {id}";
        }

    }


}
