using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public delegate void DelegadoActualizarGanador();
    public delegate Jugador DelegadoGanador(Jugador jugadorUno, Jugador jugadorDos);
    public partial class FrmPartida : Form
    {
        Partida partida;

        event DelegadoGanador EventoMostrarGanador;

        public FrmPartida(Partida partida)
        {
            InitializeComponent();
            this.partida = partida;
            this.EventoMostrarGanador += ConteoPuntos.Ganador;
        }

        private void FrmPartida_Load(object sender, EventArgs e)
        {
            Cargar();

        }



        private void ActualizarLabel()
        {
            if (InvokeRequired)
            {
                DelegadoActualizarGanador delegado = ActualizarLabel;
                Invoke(delegado);
            }
            else
            {
                if (EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos) != null)
                {
                    labelGanador.Text = $"El ganador es: {EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos).Nombre}";
                }
                else
                {
                    labelGanador.Text = "Empate";
                }
            }
        }

        private void Cargar()
        {
            nombreUser.Text = partida.JugadorUno.Nombre;
            nombreOponente.Text = partida.JugadorDos.Nombre;

            listBoxPuntosUsuario.Items.Clear();
            listBoxPuntosOponente.Items.Clear();
            foreach (Carta item in partida.JugadorUno.CartasParaPuntos)
            {
                listBoxPuntosUsuario.Items.Add(item.ToString());
            }

            foreach (Carta item in partida.JugadorDos.CartasParaPuntos)
            {
                listBoxPuntosOponente.Items.Add(item.ToString());
            }

            int diferencia = partida.Mazo.MazoCartas.Count - 6;
            if (diferencia > 0)
            {
            }
            else
            {
                if(EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos) != null)
                {
                    labelGanador.Text = $"El ganador es: {EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos).Nombre}";
                }
                else
                {
                    labelGanador.Text = "Empate";
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar();
            int diferencia = partida.Mazo.MazoCartas.Count - 6;
            if (diferencia > 0)
            {
            }
            else
            {
                if (EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos) != null)
                {
                    labelGanador.Text = $"El ganador es: {EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos).Nombre}";
                }
                else
                {
                    labelGanador.Text = "Empate";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
