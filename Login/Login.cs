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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal formP = new FrmPrincipal();
            formP.Show();
            //this.Close();
        }
    }
}