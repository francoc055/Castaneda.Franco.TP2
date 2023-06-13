using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        //static List<Usuario> usuarios;
        static List<Jugador> jugadores;

        public static List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }

        //public static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        static Sistema()
        {
            jugadores = new List<Jugador>();
            HardocodearJugadores();
        }


        public static void HardocodearJugadores()
        {
            jugadores.Add(new Jugador("Valeria"));
            jugadores.Add(new Jugador("Rodrigo"));
            jugadores.Add(new Jugador("Serena"));
            jugadores.Add(new Jugador("Maximiliano"));
            jugadores.Add(new Jugador("Isabella"));
            jugadores.Add(new Jugador("Hernán"));
            jugadores.Add(new Jugador("Celeste"));
            jugadores.Add(new Jugador("Alejandro"));
            jugadores.Add(new Jugador("Camila"));
            jugadores.Add(new Jugador("Nicolás"));
        }

        public static void SerializarJson<T>(List<T> lista, string ruta)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string objJson = System.Text.Json.JsonSerializer.Serialize(lista, opciones);
                sw.WriteLine(objJson);
                Console.WriteLine(objJson);
            }
        }

        public static List<T> DeserializarJson<T>(string ruta)
        {
            if (File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string json_str = sr.ReadToEnd();
                    List<T> registro = JsonConvert.DeserializeObject<List<T>>(json_str);
                    return registro;
                }
            }
            return null;
        }
    }
}
