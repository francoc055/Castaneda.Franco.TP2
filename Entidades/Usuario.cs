using System.Data;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        int id;
        string nombre;
        string nombreUsuario;
        string contraseña;
        int cantidadDeVictorias = 0;
        int cantidadDeDerrotas = 0;
        float promedioDeVictorias = 0;



        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { set => contraseña = value; }
        public int CantidadDeVictorias { get => cantidadDeVictorias; set => cantidadDeVictorias = value; }
        public int CantidadDeDerrotas { get => cantidadDeDerrotas; set => cantidadDeDerrotas = value; }
        public float PromedioDeVictorias { get => promedioDeVictorias; set => promedioDeVictorias = value; }

        public Usuario(string nombre, string nombreUsuario, string contraseña)
        {
            this.nombre = nombre;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Nombre de usuario: {nombreUsuario}");

            return sb.ToString();
        }

        public static bool operator ==(Usuario j1, Usuario j2)
        {
            if(j1 is not null || j2 is not null)
            {
                return j1.nombreUsuario == j2.nombreUsuario;
            }
            return false;
        }

        public static bool operator !=(Usuario j1, Usuario j2)
        {
            return !(j1.nombreUsuario == j2.nombreUsuario);
        }
    }
}