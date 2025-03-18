using System.Text.Json;

namespace Quien_quiere_ser_millonario
{
    public partial class Form1 : Form
    {
        private List<Pregunta> preguntas;
        private int preguntaActual = 0;
        private int dineroAcumulado = 0;

        public Form1()
        {
            InitializeComponent();
            CargarPreguntas();
            MostrarPregunta();
        }

        private void CargarPreguntas()
        {
            try
            {
                string json = File.ReadAllText("preguntas.json");
                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las preguntas: " + ex.Message);
                preguntas = new List<Pregunta>();
            }
        }

        private void MostrarPregunta()
        {
            if (preguntaActual < preguntas.Count)
            {
                var pregunta = preguntas[preguntaActual];
                lblPregunta.Text = pregunta.Enunciado;
                button1.Text = pregunta.Opciones[0];
                button2.Text = pregunta.Opciones[1];
                button3.Text = pregunta.Opciones[2];
                button4.Text = pregunta.Opciones[3];
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void VerificarRespuesta(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            var pregunta = preguntas[preguntaActual];

            if (boton.Text == pregunta.RespuestaCorrecta)
            {
                dineroAcumulado += 1000; // Monto acumulativo
                preguntaActual++;
                MostrarPregunta();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. Fin del juego.");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(sender, e);
        }
    }

    public class Pregunta
    {
        public string Enunciado { get; set; }
        public List<String> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }
    }
}
