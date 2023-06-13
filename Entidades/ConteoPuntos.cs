using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ConteoPuntos
    {


        public static void ConteoCartas(Jugador jugadorUno, Jugador jugadorDos)
        {
            if(jugadorUno.CartasParaPuntos.Count > jugadorDos.CartasParaPuntos.Count)
            {
                jugadorUno.CantidadDePuntos++;
            }
            else
            {
                jugadorDos.CantidadDePuntos++;
            }
        }

        public static void ContieneSieteDeOro(Jugador jugadorUno, Jugador jugadorDos)
        {
            bool flag = false;
            foreach (Carta carta in jugadorUno.CartasParaPuntos)
            {
                if(carta.Nombre == "7oro")
                {
                    jugadorUno.CantidadDePuntos++;
                    flag = true;
                }
            }

            if(!flag)
            {
                foreach (Carta carta in jugadorDos.CartasParaPuntos)
                {
                    if (carta.Nombre == "7oro")
                    {
                        jugadorDos.CantidadDePuntos++;
                    }
                }
            }
        }

        public static void CantidadDeSietes(Jugador jugadorUno, Jugador jugadorDos)
        {
            int cantJugadorUno = 0;
            int cantJugadorDos = 0;

            foreach (Carta carta in jugadorUno.CartasParaPuntos)
            {
                if (carta.Valor == 7)
                {
                    cantJugadorUno++;
                }
            }

            foreach (Carta carta in jugadorDos.CartasParaPuntos)
            {
                if (carta.Valor == 7)
                {
                    cantJugadorDos++;
                }
            }

            if(cantJugadorUno > cantJugadorDos)
            {
                jugadorUno.CantidadDePuntos++;
            }
            else if(cantJugadorDos > cantJugadorUno)
            {
                jugadorDos.CantidadDePuntos++;
            }
            else
            {
                foreach (Carta carta in jugadorUno.CartasParaPuntos)
                {
                    if (carta.Valor == 6)
                    {
                        cantJugadorUno++;
                    }
                }

                foreach (Carta carta in jugadorDos.CartasParaPuntos)
                {
                    if (carta.Valor == 6)
                    {
                        cantJugadorDos++;
                    }
                }

                if (cantJugadorUno > cantJugadorDos)
                {
                    jugadorUno.CantidadDePuntos++;
                }
                else if (cantJugadorDos > cantJugadorUno)
                {
                    jugadorDos.CantidadDePuntos++;
                }
            }
        }


        public static void MayorOro(Jugador jugadorUno, Jugador jugadorDos)
        {
            int cantJugadorUno = 0;
            int cantJugadorDos = 0;
            for (int i = 0; i < jugadorUno.CartasParaPuntos.Count; i++)
            {
                if (jugadorUno.CartasParaPuntos[i].Nombre[1] == 'o' 
                    || (jugadorUno.CartasParaPuntos[i].Nombre[2] == 'o' && jugadorUno.CartasParaPuntos[i].Nombre[3] == 'r'))
                {
                    cantJugadorUno++;
                }
            }

            for (int i = 0; i < jugadorDos.CartasParaPuntos.Count; i++)
            {
                if (jugadorDos.CartasParaPuntos[i].Nombre[1] == 'o'
                    || (jugadorDos.CartasParaPuntos[i].Nombre[2] == 'o' && jugadorDos.CartasParaPuntos[i].Nombre[3] == 'r'))
                {
                    cantJugadorDos++;
                }
            }

            if (cantJugadorUno > cantJugadorDos)
            {
                jugadorUno.CantidadDePuntos++;
            }
            else
            {
                jugadorDos.CantidadDePuntos++;
            }

        }

        public static void Escobas(Jugador jugadorUno, Jugador jugadorDos)
        {
            int totalJugadorUno = 0;
            int escobasJugadorUno;
            int totalJugadorDos = 0;
            int escobasJugadorDos;

            foreach (Carta carta in jugadorUno.CartasParaPuntos)
            {
                totalJugadorUno += carta.Valor;
            }

            foreach (Carta carta in jugadorDos.CartasParaPuntos)
            {
                totalJugadorDos += carta.Valor;
            }

            escobasJugadorUno = totalJugadorUno / 15;
            escobasJugadorDos = totalJugadorDos / 15;

            if(escobasJugadorUno > escobasJugadorDos)
            {
                jugadorUno.CantidadDePuntos++;
            }
            else
            {
                jugadorDos.CantidadDePuntos++;
            }
        }

        public static string Ganador(Jugador jugadorUno, Jugador jugadorDos)
        {
            string msg = "El ganador es: ";
            if (jugadorUno.CantidadDePuntos > jugadorDos.CantidadDePuntos)
            {
                return msg + jugadorUno.Nombre;
            }
            else if (jugadorDos.CantidadDePuntos > jugadorUno.CantidadDePuntos)
            {
                return msg + jugadorDos.Nombre;
            }
            else
            {
                return "Empatte :(";
            }
        }
    }
}
