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
    //public delegate void DelegadoActualizarGanador();
    public delegate Jugador DelegadoGanador(Jugador jugadorUno, Jugador jugadorDos);
    //public delegate void DelegadoCargar();
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

        private void Cargar()
        {
            if (!partida.cancellation.IsCancellationRequested)
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
                    if (EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos) != null)
                    {
                        labelGanador.Text = $"El ganador es: {EventoMostrarGanador(partida.JugadorUno, partida.JugadorDos).Nombre}";
                        btnCancelarPartida.Enabled = false;
                    }
                }
            }

        }




        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarPartida_Click(object sender, EventArgs e)
        {
            int diferencia = partida.Mazo.MazoCartas.Count - 6;
            if (diferencia > 0)
            {
                partida.cancellationSource.Cancel();
                labelGanador.Text = "Partida cancelada";
            }
            else
            {
                MessageBox.Show("La partida ya termino, no se puede cancelar");
                Cargar();
            }

        }
    }
}
