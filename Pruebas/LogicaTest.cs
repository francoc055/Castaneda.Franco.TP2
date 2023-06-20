using Entidades;
using System.Text.Json.Serialization;

namespace Pruebas
{
    [TestClass]
    public class LogicaTest
    {
        [TestMethod]
        public void EliminarCartaDelMazo_CuandoSePuedeEliminarLaCarta_DeberiaRetornarLaListaActualizada()
        {
            // Arrange
            int expected = 2;
            Simulacion simular = new Simulacion();
            List<Carta> mazo = new List<Carta>
            {
                new Carta("1basto", 1),
                new Carta("10espada", 10),
                new Carta("4copa", 4)
            };


            string nombreCarta = "1basto";

            // Act
            List<Carta> resultado = simular.EliminarCartaDelMazo(mazo, nombreCarta);

            // Assert
            Assert.AreEqual(expected, resultado.Count);

            foreach (Carta item in resultado)
            {
                Assert.AreNotEqual(nombreCarta, item.Nombre);
            }
        }

        [TestMethod]
        public void EliminarCartaDelMazo_CuandoElNombreOLaListaEsNulo_DeberiaAtraparLaExcepcion()
        {
            // Arrange
            Simulacion simular = new Simulacion();

            List<Carta> mazoNull = null;
            string nombreCarta = null;

            // Act
            // Assert
            Assert.ThrowsException<MiExcepcion>(() => simular.EliminarCartaDelMazo(mazoNull, nombreCarta));
        }

        [TestMethod]
        public void EliminarCartaDelMazo_CuandoNombreOLaListaMazoEsVacio_DeberiaRetornarNull()
        {
            // Arrange
            List<Carta> expected = null;
            Simulacion simular = new Simulacion();
            List<Carta> mazo = new List<Carta>
            {
                new Carta("1basto", 1),
                new Carta("10espada", 10),
                new Carta("4copa", 4)
            };


            string nombreCarta = string.Empty;

            // Act
            List<Carta> resultado = simular.EliminarCartaDelMazo(mazo, nombreCarta);

            // Assert
            Assert.AreEqual(expected, resultado);
        }

        //-------------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------//

        [TestMethod]
        public void GetCarta_CuandoPuedeDevolverLaCarta_DeberiaRetornarUnaCarta()
        {
            // Arrange
            Simulacion simular = new Simulacion();
            string nombreCarta = "10basto";

            //act
            Carta carta = simular.GetCarta(nombreCarta);

            //assert
            Assert.AreEqual(nombreCarta, carta.Nombre);
        }


        [TestMethod]
        public void GetCarta_CuandoNombreEsNulo_DeberiaAtraparLaExcepcion()
        {
            // Arrange
            Simulacion simular = new Simulacion();
            string nombreCarta = null;

            //act
            //assert
            Assert.ThrowsException<MiExcepcion>(() => simular.GetCarta(nombreCarta));
        }

        [TestMethod]
        public void GetCarta_CuandoNombreEsVacio_DeberiaRetornarNull()
        {
            // Arrange
            Simulacion simular = new Simulacion();
            string nombreCarta = string.Empty;
            Carta cartaNull = null;

            //act
            Carta carta = simular.GetCarta(nombreCarta);

            //assert
            Assert.AreEqual(cartaNull, carta);
        }

        //-------------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------//


        [TestMethod]
        public void ExisteLaCarta_CuandoExisteLaCarta_DeberiaRetornarTrue()
        {
            //arrange
            bool expected = true;
            Simulacion simular = new Simulacion();
            List<Carta> mazo = new List<Carta>
            {
                new Carta("1basto", 1),
                new Carta("10espada", 10),
                new Carta("4copa", 4),
                new Carta("5oro", 5)
            };
            string nombreCarta = "1basto";


            //act
            bool resultado = simular.ExisteLaCarta(mazo, nombreCarta);

            //assert
            Assert.AreEqual(expected, resultado);
        }


        [TestMethod]
        public void ExisteLaCarta_CuandoNombreOaListaEsNulo_DeberiaAtraparLaExcepcion()
        {
            //arrange
            bool expected = true;
            Simulacion simular = new Simulacion();
            List<Carta> mazoNull = null;
            string nombreCarta = null;


            //act
            //assert
            Assert.ThrowsException<MiExcepcion>(() => simular.ExisteLaCarta(mazoNull, nombreCarta));
        }


        [TestMethod]
        public void ExisteLaCarta_CuandoNombreEsVacioONoExiste_DeberiaRetornarFalse()
        {
            //arrange
            bool expected = false;
            Simulacion simular = new Simulacion();
            List<Carta> mazo = new List<Carta>
            {
                new Carta("1basto", 1),
                new Carta("10espada", 10),
                new Carta("4copa", 4),
                new Carta("5oro", 5)
            };
            string nombreCarta = "12oro";


            //act
            bool resultado = simular.ExisteLaCarta(mazo, nombreCarta);

            //assert
            Assert.AreEqual(expected, resultado);
        }

        //-------------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------//

        [TestMethod]
        public void SinCartas_CuandoNoTieneCartas_DeberiaRetornarTrue()
        {
            //arrange
            Simulacion simular = new Simulacion();
            bool expected = true;
            Jugador j1 = new Jugador("pepe");
            Jugador j2 = new Jugador("lolo");

            //act
            bool resultado = simular.SinCartas(j1, j2);

            //assert
            Assert.AreEqual(expected, resultado);   
        }


        [TestMethod]
        public void SinCartas_CuandoTieneCartas_DeberiaRetornarFalse()
        {
            //arrange
            Simulacion simular = new Simulacion();
            bool expected = false;
            Jugador j1 = new Jugador("pepe");
            List<Carta> manoJ1 = new List<Carta>
            {
                new Carta("1basto", 1),
                new Carta("10espada", 10),
            };
            j1.Mano = manoJ1;

            Jugador j2 = new Jugador("lolo");
            List<Carta> manoJ2 = new List<Carta>
            {
                new Carta("4copa", 4),
                new Carta("5oro", 5)
            };
            j2.Mano = manoJ2;

            //act
            bool resultado = simular.SinCartas(j1, j2);

            //assert
            Assert.AreEqual(expected, resultado);
        }

        [TestMethod]
        public void SinCartas_CuandoJ1oJ2EsNulo_DeberiaAtraparExcepcion()
        {
            //arrange
            Simulacion simular = new Simulacion();
            Jugador j1 = null;
            Jugador j2 = null;

            //act
            //assert
            Assert.ThrowsException<MiExcepcion>(() => simular.SinCartas(j1, j2));
        }

        //-------------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------//

        [TestMethod]
        public void CompararManoIndices_CuandoSonIguales_DeberiaRetornarTrue()
        {
            //arrange
            Simulacion simular = new Simulacion();
            bool expected = true;
            List<Carta> mano = new List<Carta>
            {
                new Carta("1basto", 1),
                new Carta("10espada", 10),
                new Carta("11oro", 11)
            };
            List<Carta> indices = new List<Carta>
            {
                new Carta("2oro", 1),
                new Carta("10espada", 10),
                new Carta("4basto", 11)
            };

            //act 
            bool resultado = simular.CompararManoIndices(mano, indices);

            //assert
            Assert.AreEqual(expected, resultado);

        }

        [TestMethod]
        public void CompararManoIndices_CuandoNoSonIguales_DeberiaRetornarTrue()
        {
            //arrange
            Simulacion simular = new Simulacion();
            bool expected = false;
            List<Carta> mano = new List<Carta>
            {
                new Carta("1basto", 1),
                new Carta("3espada", 10),
                new Carta("11oro", 11)
            };
            List<Carta> indices = new List<Carta>
            {
                new Carta("2oro", 1),
                new Carta("10espada", 10),
                new Carta("4basto", 11)
            };

            //act 
            bool resultado = simular.CompararManoIndices(mano, indices);

            //assert
            Assert.AreEqual(expected, resultado);

        }

        
    }
}