using Entidades;
using Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                Sistema.UsuariosDB.Clear();
                Sistema.UsuariosDB = AccesoDatos.Leer();
            }
            catch
            {
                throw new MiExcepcion("ocurrio un error");
            }
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario aux = VerificarUsuario();
            if (aux is not null)
            {
                FrmPrincipal formP = new FrmPrincipal(aux);
                formP.Show();

                this.Hide();
            }
            else
            {
                labelAdvertenciaLogin.Visible = true;
                labelAdvertenciaLogin.Text = "Nombre de usuario y/o contraseña incorrecta";
            }

        }

        private Usuario VerificarUsuario()
        {
            foreach (Usuario usuario in Sistema.UsuariosDB)
            {
                if (usuario.NombreUsuario == txtUsuario.Text && usuario.Contraseña == txtContra.Text)
                {
                    return usuario;
                }
            }
            return null;
        }



        private void btnRellenar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "frankito";
            txtContra.Text = "1234";
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            labelAdvertenciaNombreUser.Visible = false;
            labelCamposVacios.Visible = false;
            if (VerificarUsuarioNuevo())
            {
                try
                {
                    AccesoDatos.Guardar(new Usuario(txtNombreR.Text, txtNombreUserR.Text, txtContraR.Text));
                    MessageBox.Show("Se registro correctamente, ahora inicie sesion.");
                    Sistema.UsuariosDB.Clear();
                    Sistema.UsuariosDB = AccesoDatos.Leer();
                    LimpiarTextBoxRegistro();
                }
                catch
                {
                    throw new MiExcepcion("ocurrio un error");
                }
            }
        }

        private void LimpiarTextBoxRegistro()
        {
            txtNombreR.Clear();
            txtNombreUserR.Clear();
            txtContraR.Clear();
        }

        private bool VerificarUsuarioNuevo()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(txtNombreR.Text) || string.IsNullOrEmpty(txtNombreUserR.Text) || string.IsNullOrEmpty(txtContraR.Text))
            {
                labelCamposVacios.Visible = true;
                labelCamposVacios.Text = "Ningun campo puede estar vacio";
                ret = false;

            }
            else
            {
                foreach (Usuario usuario in Sistema.UsuariosDB)
                {
                    if (usuario.NombreUsuario == txtNombreUserR.Text)
                    {
                        labelAdvertenciaNombreUser.Visible = true;
                        labelAdvertenciaNombreUser.Text = "El nombre de usuario ya existe, elija otro";
                        ret = false;
                    }
                }
            }


            return ret;
        }


    }
}