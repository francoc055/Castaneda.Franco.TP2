using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {

        //Partida partida2 = new Partida();

        Jugador j1 = new Jugador("lolo");
        Jugador j2 = new Jugador("pepe");
        //Jugador j3 = new Jugador("enzo");
        //Jugador j4 = new Jugador("pedro");

        Partida partida1 = new Partida(j1, j2);

        //Simulacion simular = new Simulacion();
        //Mazo mazoCartas = new Mazo();
        //Mazo mazoCartas2 = new Mazo();

        //Task hilo1 = Task.Run(() => simular.RepartirCartas(j1, j2, mazoCartas.MazoCartas, partida1));
        //Task hilo2 = Task.Run(() => simular.RepartirCartas(j3, j4, mazoCartas2.MazoCartas, partida2));

        //hilo1.Wait();
        //Task.WaitAll(hilo1, hilo2);

        //mostrar(j1, j2, partida1);
        //mostrar(j3, j4, partida2);


        //Sistema.Usuarios.Add(j1);
        //Sistema.Usuarios.Add(j2);

        //Sistema.SerializarJson(Sistema.Usuarios, "usuarios.json");

        //List<Usuario> user = Sistema.DeserializarJson<Usuario>("usuarios.json");

        //foreach (Usuario item in user)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //simular.DejarCartaEnMesa(j1.Mano, partida1.CartasEnMesa);

        //mostrar(j1, j2, partida1);

        //for (int i = 0; i < 6; i++)
        //{
        //    partida1.IniciarPartida();
        //    mostrar(j1, j2, partida1);
        //}
        //while(partida1.Mazo.MazoCartas.Count > 0)
        //{
        //    partida1.IniciarPartida();
        //    mostrar(j1, j2, partida1);
        //}

        //ConteoPuntos.ConteoCartas(j1, j2);
        //ConteoPuntos.Ganador(j1, j2);


        //Console.WriteLine("------------carta para punto j1-------------");
        //foreach (Carta item in j1.CartasParaPuntos)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //Console.WriteLine("------------carta para punto j2-------------");
        //foreach (Carta item in j2.CartasParaPuntos)
        //{
        //    Console.WriteLine(item.ToString());
        //}


        //List<Usuario> usuarios = AccesoDatos.Leer();

        //foreach (Usuario item in usuarios)
        //{
        //    Console.WriteLine(item.ToString());
        //}

    }

    static void mostrar(Jugador j1, Jugador j2, Partida partida)
    {
        Console.WriteLine(j1.Nombre);
        foreach (Carta item in j1.Mano)
        {

            Console.WriteLine(item.ToString());
        }

        Console.WriteLine(j2.Nombre);

        foreach (Carta item in j2.Mano)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine("CARTAS SOBRE LA MESA");
        foreach (Carta item in partida.CartasEnMesa)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("------------------------------------");
        Console.WriteLine("------------------------------------");

    }
}