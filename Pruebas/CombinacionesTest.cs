using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    [TestClass]
    public class CombinacionesTest
    {
        [TestMethod]
        public void SumarTodasLasCartas_CuandoSumaTodasLasCartas_DeberiaRetornarUnaListaCount5()
        {
            //arrange
            int expected = 5;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("12espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("4basto", 4),
                new Carta("4espada", 4),
                new Carta("3copa", 3),
                new Carta("2oro", 2)
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarTodasLasCartas(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected ,indices.Count);
        }

        [TestMethod]
        public void SumarTodasLasCartas_CuandoNoSumaTodasLasCartas_DeberiaRetornarUnaListaCount0()
        {
            //arrange
            int expected = 0;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("12espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("4basto", 4),
                new Carta("4espada", 4),
                new Carta("3copa", 3),
                new Carta("10oro", 5)
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarTodasLasCartas(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected, indices.Count);
        }

        //-------------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------//

        [TestMethod]
        public void SumarPorUnaCarta_CuandoSumaUnaCarta_DeberiaRetornarUnaListaCount2()
        {
            //arrange
            int expected = 2;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("12espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("4basto", 4),
                new Carta("5espada", 5),
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarPorUnaCarta(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected, indices.Count); 
        }

        [TestMethod]
        public void SumarPorUnaCarta_CuandoNoSumaUnaCarta_DeberiaRetornarUnaListaCount0()
        {
            //arrange
            int expected = 0;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("2espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("4basto", 4),
                new Carta("5espada", 4),
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarPorUnaCarta(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected, indices.Count);
        }


        //-------------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------//

        [TestMethod]
        public void SumarPorDosCartas_CuandoSumaDosCartas_DeberiaRetornarUnaListaCount3()
        {
            //arrange
            int expected = 3;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("12espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("2oro", 2),
                new Carta("2espada", 2),
                new Carta("3espada", 3),
                new Carta("12copa", 10),
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarPorDosCartas(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected, indices.Count);
        }

        [TestMethod]
        public void SumarPorDosCartas_CuandoNoSumaDosCartas_DeberiaRetornarUnaListaCount0()
        {
            //arrange
            int expected = 0;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("12espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("2oro", 2),
                new Carta("11oro", 9),
                new Carta("10basto", 8),
                new Carta("12copa", 10),
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarPorDosCartas(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected, indices.Count);
        }

        //-------------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------//

        [TestMethod]
        public void SumarPorTresCartas_CuandoSumaTresCartas_DeberiaRetornarUnaListaCount4()
        {
            //arrange
            int expected = 4;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("12espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("4oro", 4),
                new Carta("4espada", 4),
                new Carta("5espada", 5),
                new Carta("12copa", 10),
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarPorTresCartas(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected, indices.Count);
        }

        [TestMethod]
        public void SumarPorTresCartas_CuandoNoSumaTresCartas_DeberiaRetornarUnaListaCount4()
        {
            //arrange
            int expected = 0;
            ClaseManCombinaciones combinaciones = new ClaseManCombinaciones();
            Jugador jugador = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("2basto", 2),
                new Carta("12espada", 10),
            };
            jugador.Mano = manoJ1;

            List<Carta> cartasEnMesa = new List<Carta>
            {
                new Carta("10oro", 8),
                new Carta("4espada", 4),
                new Carta("5espada", 5),
                new Carta("12copa", 10),
            };

            List<Carta> indices = new List<Carta>();

            //act
            combinaciones.SumarPorTresCartas(jugador, cartasEnMesa, indices);

            //assert
            Assert.AreEqual(expected, indices.Count);
        }

    }
}
