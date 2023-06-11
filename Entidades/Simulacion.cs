using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate List<Carta> DelegadoEjecutarCombinaciones(Jugador jugador, List<Carta> cartasEnMesa, List<Carta> indices);


    public class Simulacion
    {
        public event DelegadoEjecutarCombinaciones eTodasLasComb;
        public event DelegadoEjecutarCombinaciones eTresComb;
        public event DelegadoEjecutarCombinaciones eDosComb;
        public event DelegadoEjecutarCombinaciones eUnaComb;

        public Simulacion()
        {
            ClaseManCombinaciones cmc = new ClaseManCombinaciones();
            this.eTodasLasComb += cmc.SumarPorUnaCarta;
            this.eTodasLasComb += cmc.SumarPorDosCartas;
            this.eTodasLasComb += cmc.SumarPorTresCartas;
            this.eTodasLasComb += cmc.SumarTodasLasCartas;

            this.eTresComb += cmc.SumarPorUnaCarta;
            this.eTresComb += cmc.SumarPorDosCartas;
            this.eTresComb += cmc.SumarTodasLasCartas;

            this.eDosComb += cmc.SumarPorUnaCarta;
            this.eDosComb += cmc.SumarTodasLasCartas;

            this.eUnaComb += cmc.SumarTodasLasCartas;
        }

        public void RepartirCartas(Jugador j1, Jugador j2, List<Carta> mazo, Partida partida)
        {
            Random random = new Random();
            int indice;
            if (SinCartas(j1, j2))
            {
                //jugador uno
                for (int i = 0; i < 3; i++)
                {
                    indice = random.Next(0, mazo.Count);
                    while (!ExisteLaCarta(mazo, mazo[indice].Nombre))
                    {
                        indice = random.Next(0, 11);
                    }
                    j1.Mano.Add(mazo[indice]);
                    mazo = EliminarCartaDelMazo(mazo, mazo[indice].Nombre);
                }
                //jugador dos
                for (int i = 0; i < 3; i++)
                {
                    indice = random.Next(0, mazo.Count);
                    while (!ExisteLaCarta(mazo, mazo[indice].Nombre))
                    {
                        indice = random.Next(0, 11);
                    }
                    j2.Mano.Add(mazo[indice]);
                    mazo = EliminarCartaDelMazo(mazo, mazo[indice].Nombre);
                }
                j1.CantidadDeCartas = j1.Mano.Count;
                j2.CantidadDeCartas = j2.Mano.Count;

                //cartas sobre la mesa
                for (int i = 0; i < 4; i++)
                {
                    indice = random.Next(0, mazo.Count);
                    while (!ExisteLaCarta(mazo, mazo[indice].Nombre))
                    {
                        indice = random.Next(0, 11);
                    }
                    partida.CartasEnMesa.Add(mazo[indice]);
                    mazo = EliminarCartaDelMazo(mazo, mazo[indice].Nombre);
                }
            }

        }

        public List<Carta> EliminarCartaDelMazo(List<Carta> mazo, string nombre)
        {
            Carta auxCarta = GetCarta(nombre);
            foreach (Carta carta in mazo)
            {
                if (carta == auxCarta)
                {
                    mazo.Remove(carta);
                    break;
                }
            }
            return mazo;
        }

        public bool ExisteLaCarta(List<Carta> mazo, string nombre)
        {
            Carta auxCarta = GetCarta(nombre);
            foreach (Carta carta in mazo)
            {
                if(carta == auxCarta)
                {
                    return true;
                }
            }

            return false;
        }

        public Carta GetCarta(string nombre)
        {
            
            Mazo auxMazo = new Mazo();
            
            for (int i = 0; i < auxMazo.MazoCartas.Count; i++)
            {
                if (auxMazo.MazoCartas[i].Nombre == nombre)
                {
                    return auxMazo.MazoCartas[i];
                }
            }

            return null;
        }

        public bool SinCartas(Jugador j1, Jugador j2)
        {
            bool ret = true;
            if(j1.CantidadDeCartas > 0  || j2.CantidadDeCartas > 0)
            {
                ret = false;
            }
            return ret;
        }

        public void Pensar(Jugador jugador, List<Carta> cartasEnMesa)
        {
            List<Carta> indicesDeCartas = new List<Carta>();
            if (cartasEnMesa.Count == 4)
            {
                indicesDeCartas = eTodasLasComb.Invoke(jugador, cartasEnMesa, indicesDeCartas);
            }
            else if(cartasEnMesa.Count == 3)
            {
                indicesDeCartas = eTresComb.Invoke(jugador, cartasEnMesa, indicesDeCartas);
            }
            else if(cartasEnMesa.Count == 2)
            {
                indicesDeCartas = eDosComb.Invoke(jugador, cartasEnMesa, indicesDeCartas);
            }
            else if(cartasEnMesa.Count == 1)
            {
                indicesDeCartas = eUnaComb.Invoke(jugador, cartasEnMesa, indicesDeCartas);
            }
            

            if(indicesDeCartas.Count > 0)
            {
                foreach (Carta item in indicesDeCartas)
                {
                    jugador.CartasParaPuntos.Add(item);
                    cartasEnMesa = EliminarCartaDelMazo(cartasEnMesa, item.Nombre);
                }
                if(VerificarCarta(jugador.CartasParaPuntos, jugador.Mano))
                {
                    Console.WriteLine($"se actualizo la mano de {jugador.Nombre}");
                }
            }
            else
            {
                DejarCartaEnMesa(jugador.Mano, cartasEnMesa);
                Console.WriteLine($"se dejo una carta en la mesa del jugador  {jugador.Nombre}");
            }
        }

        public bool VerificarCarta(List<Carta> cartas, List<Carta> mano)
        {
            foreach (Carta cartaMano in mano)
            {
                foreach (Carta cartaPuntos in cartas)
                {
                    if(cartaMano == cartaPuntos)
                    {
                        mano.Remove(cartaMano);
                        return true;
                    }
                }
            }
            return false;
        }

        public void DejarCartaEnMesa(List<Carta> manoDelJugador, List<Carta> cartasEnMesa)
        {
            Random random = new Random();

            int indice = random.Next(0, manoDelJugador.Count + 1);

            Carta aux = GetCarta(manoDelJugador[indice].Nombre);

            cartasEnMesa.Add(aux);

            manoDelJugador.RemoveAt(indice);
        }


        //public List<Carta> JuntarQuince(List<Carta> manoDelJugador, List<Carta> cartasEnMesa) { }

        //public List<Carta> DejarCartaEnMesa(List<Carta> manoDelJugador) { }
    }
}
