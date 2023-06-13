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
    public partial class FrmPrincipal : Form
    {
        List<Jugador> jugadores;


        public FrmPrincipal()
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarJugadores();
            CargarCombobox();

        }

        private void CargarCombobox()
        {
            foreach (Jugador item in jugadores)
            {
                cbJugadorUser.Items.Add(item);
                cbJugadorOponente.Items.Add(item);
            }
        }
        private void CargarJugadores()
        {
            jugadores = Sistema.DeserializarJson<Jugador>("jugadores.json");
        }

        private void btnCrearPartida_Click(object sender, EventArgs e)
        {
            Jugador jugador = (Jugador)cbJugadorUser.SelectedItem;
            Jugador oponente = (Jugador)cbJugadorOponente.SelectedItem;



            if (jugador is not null && oponente is not null)
            {
                jugador.Mano.Clear();
                jugador.CartasParaPuntos.Clear();
                jugador.CantidadDePuntos = 0;
                oponente.Mano.Clear();
                oponente.CartasParaPuntos.Clear();
                oponente.CantidadDePuntos = 0;

                Partida partida = new Partida(jugador, oponente);
                while (partida.Mazo.MazoCartas.Count > 0)
                {
                    int diferencia = partida.Mazo.MazoCartas.Count - 6;
                    if (diferencia > 0)
                    {
                        Task hiloPartida = new Task(() => partida.IniciarPartida());
                        hiloPartida.Start();
                        hiloPartida.Wait();
                        //partida.IniciarPartida();
                    }
                    else
                    {
                        break;
                    }
                }
                ConteoPuntos.ConteoCartas(jugador, oponente);
                ConteoPuntos.Escobas(jugador, oponente);
                ConteoPuntos.ContieneSieteDeOro(jugador, oponente);
                ConteoPuntos.CantidadDeSietes(jugador, oponente);
                ConteoPuntos.MayorOro(jugador, oponente);


                MessageBox.Show(ConteoPuntos.Ganador(jugador, oponente));
            }
            else
            {
                MessageBox.Show("Se debe seleccionar tu jugador y un oponente");
            }
        }
    }
}
