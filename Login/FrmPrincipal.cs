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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    //public delegate void DelegadoActualizarDataGrid(Partida partida);
    public delegate void DelegadoActualizar(Partida partida);
    public partial class FrmPrincipal : Form
    {
        List<string> jugadores;
        List<Task> hilos;
        List<Partida> partidasDelUsuario;
        //string nombreUser;
        private static object lockObject = new object();
        Usuario usuario;



        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            jugadores = new List<string>();
            hilos = new List<Task>();
            partidasDelUsuario = new List<Partida>();
            //this.nombreUser = nombreUser;
            this.usuario = usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarJugadores();
            CargarCombobox();
            dataGridViewPartidas.ClearSelection();
            CargarHistorialDelUsuario();


        }

        private void CargarHistorialDelUsuario()
        {
            try
            {
                List<Partida> partidas = AccesoDatos.LeerFiltrado(usuario);
                if(partidas.Count > 0)
                {
                    foreach (Partida item in partidas)
                    {
                        ActualizarDataGridHistorial(item);
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un error");
            }
        }

        private void CargarCombobox()
        {
            cbJugadorUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJugadorOponente.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (String item in jugadores)
            {
                cbJugadorOponente.Items.Add(item);
            }
            cbJugadorUser.Items.Add(usuario.NombreUsuario);
        }
        private void CargarJugadores()
        {
            jugadores = Sistema.DeserializarJson<string>("jugadores.json");
        }

        private async void btnCrearPartida_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbJugadorUser.Text) && !string.IsNullOrEmpty(cbJugadorOponente.Text))
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
                partida.Nombre = partida.ToString();
                //ActualizarListBox(partida);
                ActualizarDataGridPartida(partida);

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

                if (ConteoPuntos.Ganador(partida.JugadorUno, partida.JugadorDos) != null)
                {
                    partida.JugadorGanador = ConteoPuntos.Ganador(partida.JugadorUno, partida.JugadorDos);
                }

                lock (lockObject)
                {
                    Sistema.SerializarJson<Partida>(partidasDelUsuario, "partidasDelUsuario.json");
                }

                ActualizarDataGridHistorial(partida);

                //MessageBox.Show($"El ganador es {ConteoPuntos.Ganador(jugador, oponente)}");
            }

        }

        private void dataGridViewPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPartidas.Rows[e.RowIndex];

                if(filaSeleccionada.Cells["Id"].Value != null)
                {
                    int valorId = (int)filaSeleccionada.Cells["Id"].Value;

                    //MessageBox.Show(valorId.ToString());
                    foreach (Partida item in partidasDelUsuario)
                    {
                        if (item.Id == valorId)
                        {
                            FrmPartida formPartida = new FrmPartida(item);
                            formPartida.ShowDialog();
                            break;
                        }
                    }
                }
                

            }
        }

        private void ActualizarDataGridPartida(Partida partida)
        {
            if (InvokeRequired)
            {
                DelegadoActualizar delegado = ActualizarDataGridPartida;
                object[] parametros = { partida };
                Invoke(delegado, partida);
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();

                fila.CreateCells(dataGridViewPartidas);
                fila.Cells[0].Value = partida.Id;
                string nombre = $"{partida.JugadorUno.Nombre} vs {partida.JugadorDos.Nombre}";
                fila.Cells[1].Value = nombre;

                dataGridViewPartidas.Rows.Add(fila);
                dataGridViewPartidas.ClearSelection();
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

                if (partida.JugadorGanador != null)
                {
                    fila.Cells[3].Value = partida.JugadorGanador.Nombre;
                }
                else
                {
                    fila.Cells[3].Value = "Empate";
                }

                dataGridViewHistorial.Rows.Add(fila);


            }
        }

        

        

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarVictoriasDerrotas();

                foreach (Partida partida in partidasDelUsuario)
                {
                    AccesoDatos.GuardarPartida(partida);
                }

                AccesoDatos.Actualizar(usuario);

                partidasDelUsuario.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }

        }

        private void AsignarVictoriasDerrotas()
        {
            foreach (Partida partida in partidasDelUsuario)
            {
                if (partida.JugadorGanador.Nombre == partida.JugadorUno.Nombre)
                {
                    usuario.Victorias++;
                }
                else if (partida.JugadorGanador.Nombre != partida.JugadorUno.Nombre)
                {
                    usuario.Derrotas++;
                }
            }

            MessageBox.Show($"victorias: {usuario.Victorias.ToString()} - derrotas {usuario.Derrotas.ToString()}");
        }

       
    }
}
