using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RetoSofka
{
    public partial class Form1 : Form
    {
        RetoBd consulta = new RetoBd();
        Participante jugador = new Participante();

        private string[] contenidoPregunta = new string[6];
        private int categoria = 1;
        private int ganador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpPregunta.Visible = false;
            grpOpcion.Visible = false;
            txtPuntaje.Enabled = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            jugador.Nombre1 = txtNomb.Text;

            if (string.IsNullOrEmpty(txtNomb.Text))
            {
                MessageBox.Show("Debe ingresar su nombre");
            }
            else
            {
                mostrarPregunta();
                txtNomb.Enabled = false;
                btnInicio.Enabled = false;
                grpPregunta.Visible = true;
                grpOpcion.Visible = true;
                btnNex.Enabled = false;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            obtenerRespuesta();
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            grpPregunta.Enabled = true;
            mostrarPregunta();
            btnValidar.Enabled = true;
            btnNex.Enabled = false;
        }

        public void mostrarPregunta()
        {

            MySqlDataReader read = consulta.consultarPregunta(categoria);
            while (read.Read())
            {
                for (int index = 0; index < 6; index++)
                {
                    contenidoPregunta[index] = read.GetString(index + 1);
                }

                lblPregunta.Text = contenidoPregunta[0];
                rdoRespuesta1.Text = contenidoPregunta[1];
                rdoRespuesta2.Text = contenidoPregunta[2];
                rdoRespuesta3.Text = contenidoPregunta[3];
                rdoRespuesta4.Text = contenidoPregunta[4];
            }
            categoria++;
        }

        public void obtenerRespuesta()
        {

            string respuesta = null;
            ValidacionRespuesta validacion = new ValidacionRespuesta();

            if (rdoRespuesta1.Checked == true)
            {
                respuesta = rdoRespuesta1.Text;

            }
            else
            {
                if (rdoRespuesta2.Checked == true)
                {
                    respuesta = rdoRespuesta2.Text;
                }
                else
                {
                    if (rdoRespuesta3.Checked == true)
                    {
                        respuesta = rdoRespuesta3.Text;
                    }
                    else
                    {
                        if (rdoRespuesta4.Checked == true)
                        {
                            respuesta = rdoRespuesta4.Text;
                        }
                    }
                }
            }

            Boolean resultado = validacion.comprobarRespuesta(respuesta, contenidoPregunta[5]);

            if (resultado)
            {
                ganador++;
                jugador.Puntaje1 = jugador.Puntaje1 + 100;
                txtPuntaje.Text = Convert.ToString(jugador.Puntaje1);

                grpPregunta.Enabled = false;
                btnValidar.Enabled = false;
                btnNex.Enabled = true;
                rdoRespuesta1.Checked = false;
                rdoRespuesta2.Checked = false;
                rdoRespuesta3.Checked = false;
                rdoRespuesta4.Checked = false;

                if (ganador == 5)
                {
                    MessageBox.Show("¡¡¡ Ganaste el juego !!!");
                    consulta.registrarParticipante(jugador);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Respuesta correcta, continuas a la siguiente ronda");
                }

            }
            else
            {
                MessageBox.Show("Respuesta incorrecta, perdiste");
                jugador.Puntaje1 = 0;
                Application.Exit();
                consulta.registrarParticipante(jugador);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salida = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (salida == DialogResult.Yes)
            {
                consulta.registrarParticipante(jugador);
                Application.Exit();
            }
            else if (salida == DialogResult.No)
            {
            }
        }
    }
}