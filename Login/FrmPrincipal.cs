using Entidades;
using System;
using System.Collections;
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
    //public delegate void DelegadoActualizarDataGrid(Partida partida);
    public delegate void DelegadoActualizar(Partida partida);
    public partial class FrmPrincipal : Form
    {
        List<string> jugadores;
        List<Task> hilos;
        List<Partida> partidasDelUsuario;
        string nombreUser;


        public FrmPrincipal(string nombreUser)
        {
            InitializeComponent();
            jugadores = new List<string>();
            hilos = new List<Task>();
            partidasDelUsuario = new List<Partida>();
            this.nombreUser = nombreUser;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarJugadores();
            CargarCombobox();
        }

        private void CargarCombobox()
        {
            cbJugadorUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJugadorOponente.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (String item in jugadores)
            {
                cbJugadorOponente.Items.Add(item);
            }
            cbJugadorUser.Items.Add(nombreUser);
        }
        private void CargarJugadores()
        {
            jugadores = Sistema.DeserializarJson<string>("jugadores.json");
        }

        private async void btnCrearPartida_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cbJugadorUser.Text) && !string.IsNullOrEmpty(cbJugadorOponente.Text))
            {
                Jugador jugador = new Jugador(cbJugadorUser.Text);
                Jugador oponente = new Jugador(cbJugadorOponente.Text);
                await Task.Run(() => Jugar(jugador, oponente));
            }
            else
            {
                MessageBox.Show("Se debe seleccionar tu jugador y un oponente");
            }

        }

        private async void Jugar(Jugador jugador, Jugador oponente)
        {
            if (jugador is not null && oponente is not null)
            {
                Partida partida = new Partida(jugador, oponente);
                ActualizarListBox(partida);
                partidasDelUsuario.Add(partida);

                while (partida.Mazo.MazoCartas.Count > 0)
                {
                    int diferencia = partida.Mazo.MazoCartas.Count - 6;
                    if (diferencia > 0)
                    {
                        partida.IniciarPartida();

                        await Task.Delay(500);

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


                //--ARREGLAR--// -> El proceso no puede acceder al archivo porque está siendo utilizado por otro proceso.
                Sistema.SerializarJson<Partida>(partidasDelUsuario, "partidasDelUsuario.json");

                ActualizarDataGridHistorial(partida);

                //MessageBox.Show($"El ganador es {ConteoPuntos.Ganador(jugador, oponente)}");
            }
            
        }

        private void ActualizarDataGridHistorial(Partida partida)
        {
            if (InvokeRequired)
            {
                DelegadoActualizar delegado = ActualizarDataGridHistorial;
                object[] parametros = { partida };
                Invoke(delegado, partida);
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();

                fila.CreateCells(dataGridViewHistorial);
                fila.Cells[0].Value = partida.Id;
                fila.Cells[1].Value = partida.JugadorUno.Nombre;
                fila.Cells[2].Value = partida.JugadorDos.Nombre;
                if (ConteoPuntos.Ganador(partida.JugadorUno, partida.JugadorDos) != null)
                {
                    fila.Cells[3].Value = ConteoPuntos.Ganador(partida.JugadorUno, partida.JugadorDos).Nombre;
                }
                else
                {
                    fila.Cells[3].Value = "Empate";
                }

                dataGridViewHistorial.Rows.Add(fila);
                
                
            }
        }

        public void ActualizarListBox(Partida partida)
        {
            if (this.listBox1.InvokeRequired)
            {

                DelegadoActualizar delegado = ActualizarListBox;
                object[] parametros = { partida };

                this.pictureBox1.Invoke(delegado, parametros);
            }
            else
            {
                if(Thread.CurrentThread.ThreadState.ToString() == "Running")
                {
                    this.listBox1.Items.Add(partida.ToString() + " - en curso");
                }
                else
                {
                    this.listBox1.Items.Add(partida.ToString() + " - finalizada");

                }
                //this.listBox1.Items.Add(.ToString());
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex + 1;

            foreach (Partida item in partidasDelUsuario)
            {
                if (item.Id == indice)
                {
                    FrmPartida formPartida = new FrmPartida(item);
                    formPartida.ShowDialog();
                    break;
                }
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
