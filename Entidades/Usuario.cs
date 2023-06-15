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
        int victorias = 0;
        int derrotas = 0;




        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Victorias { get => victorias; set => victorias = value; }
        public int Derrotas { get => derrotas; set => derrotas = value; }

        public Usuario(string nombre, string nombreUsuario, string contraseña) : this(nombre, nombreUsuario, contraseña, 0)
        {
        }
        public Usuario(string nombre, string nombreUsuario, string contraseña, int id)
        {
            this.nombre = nombre;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.id = id;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {id}");
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