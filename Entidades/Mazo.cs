using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mazo
    {
        List<Carta> mazoCartas;

        public List<Carta> MazoCartas { get => mazoCartas; set => mazoCartas = value; }

        public Mazo()
        {
            mazoCartas = new List<Carta>();
            llenarMazo();
        }


        public  void llenarMazo()
        {
            mazoCartas.Clear();
            mazoCartas.Add(new Carta("1basto", 1));
            mazoCartas.Add(new Carta("1espada", 1));
            mazoCartas.Add(new Carta("1oro", 1));
            mazoCartas.Add(new Carta("1copa", 1));

            mazoCartas.Add(new Carta("2basto", 2));
            mazoCartas.Add(new Carta("2espada", 2));
            mazoCartas.Add(new Carta("2oro", 2));
            mazoCartas.Add(new Carta("2copa", 2));

            mazoCartas.Add(new Carta("3basto", 3));
            mazoCartas.Add(new Carta("3espada", 3));
            mazoCartas.Add(new Carta("3oro", 3));
            mazoCartas.Add(new Carta("3copa", 3));

            mazoCartas.Add(new Carta("4basto", 4));
            mazoCartas.Add(new Carta("4espada", 4));
            mazoCartas.Add(new Carta("4oro", 4));
            mazoCartas.Add(new Carta("4copa", 4));

            mazoCartas.Add(new Carta("5basto", 5));
            mazoCartas.Add(new Carta("5espada", 5));
            mazoCartas.Add(new Carta("5oro", 5));
            mazoCartas.Add(new Carta("5copa", 5));

            mazoCartas.Add(new Carta("6basto", 6));
            mazoCartas.Add(new Carta("6espada", 6));
            mazoCartas.Add(new Carta("6oro", 6));
            mazoCartas.Add(new Carta("6copa", 6));

            mazoCartas.Add(new Carta("7basto", 7));
            mazoCartas.Add(new Carta("7espada", 7));
            mazoCartas.Add(new Carta("7oro", 7));
            mazoCartas.Add(new Carta("7copa", 7));

            mazoCartas.Add(new Carta("10basto", 8));
            mazoCartas.Add(new Carta("10espada", 8));
            mazoCartas.Add(new Carta("10oro", 8));
            mazoCartas.Add(new Carta("10copa", 8));

            mazoCartas.Add(new Carta("11basto", 9));
            mazoCartas.Add(new Carta("11espada", 9));
            mazoCartas.Add(new Carta("11oro", 9));
            mazoCartas.Add(new Carta("11copa", 9));

            mazoCartas.Add(new Carta("12basto", 10));
            mazoCartas.Add(new Carta("12espada", 10));
            mazoCartas.Add(new Carta("12oro", 10));
            mazoCartas.Add(new Carta("12copa", 10));
        }

    }
}
