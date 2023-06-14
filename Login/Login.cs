using Entidades;
using Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Sistema.SerializarJson(Sistema.Jugadores, "jugadores.json");
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "frankito" && txtContra.Text == "1234")
            {
                FrmPrincipal formP = new FrmPrincipal(txtUsuario.Text);
                formP.Show();

                this.Hide();
            }
           
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "frankito";
            txtContra.Text = "1234";
        }
    }
}