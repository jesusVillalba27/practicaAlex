using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace alex
{
    public partial class NewPage1 : ContentPage
    {
        private readonly List<Pregunta> preguntas = new()
        {
            new Pregunta("¿Cuál es la capital de Francia?", "París", "Londres", "Berlín"),
            new Pregunta("¿Cuánto es 2 + 2?", "4", "3", "5"),
            new Pregunta("¿Quién escribió 'Cien años de soledad'?", "Gabriel García Márquez", "Pablo Neruda", "Julio Cortázar")
        };

        private int preguntaActual = 0;

        public NewPage1()
        {
            InitializeComponent();
            MostrarPregunta();
        }

        private void MostrarPregunta()
        {
            var pregunta = preguntas[preguntaActual];
            PreguntaLabel.Text = pregunta.Texto;
            RespuestaButton1.Text = pregunta.RespuestaCorrecta;
            RespuestaButton2.Text = pregunta.RespuestaIncorrecta1;
            RespuestaButton3.Text = pregunta.RespuestaIncorrecta2;
        }

        private async void OnRespuestaClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            string mensaje;

            if (button.Text == preguntas[preguntaActual].RespuestaCorrecta)
            {
                mensaje = "¡Correcto!";
            }
            else
            {
                mensaje = "Incorrecto. La respuesta correcta es: " + preguntas[preguntaActual].RespuestaCorrecta;
            }

            await DisplayAlert("Resultado", mensaje, "OK");

            preguntaActual++;
            if (preguntaActual < preguntas.Count)
            {
                MostrarPregunta();
            }
            else
            {
                await DisplayAlert("Fin del cuestionario", "Has completado el cuestionario.", "OK");
                preguntaActual = 0; // Reiniciar el cuestionario
                MostrarPregunta();
            }
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Volver a la página anterior
        }

        private class Pregunta
        {
            public string Texto { get; }
            public string RespuestaCorrecta { get; }
            public string RespuestaIncorrecta1 { get; }
            public string RespuestaIncorrecta2 { get; }

            public Pregunta(string texto, string respuestaCorrecta, string respuestaIncorrecta1, string respuestaIncorrecta2)
            {
                Texto = texto;
                RespuestaCorrecta = respuestaCorrecta;
                RespuestaIncorrecta1 = respuestaIncorrecta1;
                RespuestaIncorrecta2 = respuestaIncorrecta2;
            }
        }
    }
}
