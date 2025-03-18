## Juego quien quiere ser millonario

![image](https://github.com/user-attachments/assets/9f90b1ec-e759-49d9-acea-cd4ed5ec1d5d)

![image](https://github.com/user-attachments/assets/3675f6eb-887a-43ec-8e02-efe3d63accb6)

¿Quién Quiere Ser Millonario? - Juego en WinForms

Este es un juego de preguntas y respuestas basado en el famoso programa de televisión ¿Quién Quiere Ser Millonario?, desarrollado en C# y WinForms en Visual Studio 2022.

Características

✅ Carga de preguntas desde un archivo JSON. ✅ Interfaz gráfica con botones y etiquetas. ✅ Verificación de respuestas y acumulación de dinero. ✅ Comodines (opcional): 50/50, llamada a un amigo, ayuda del público.

Requisitos

Visual Studio 2022

.NET 6 o superior

Instalación y Ejecución

Clonar o descargar el repositorio.

Abrir el proyecto en Visual Studio 2022.

Ejecutar el proyecto (``).

Estructura del Proyecto

📂 QuienQuiereSerMillonario
 ├── 📄 MainForm.cs (Lógica principal del juego)
 ├── 📄 Pregunta.cs (Modelo de datos para preguntas)
 ├── 📄 preguntas.json (Banco de preguntas)
 ├── 📄 Program.cs (Inicio del programa)
 ├── 📄 README.md (Este archivo)

Formato del Archivo preguntas.json

Ejemplo de preguntas:

[
  {
    "Enunciado": "¿Cuál es la capital de Francia?",
    "Opciones": ["Madrid", "Berlín", "París", "Londres"],
    "RespuestaCorrecta": "París"
  },
  {
    "Enunciado": "¿Cuántos planetas tiene el sistema solar?",
    "Opciones": ["7", "8", "9", "10"],
    "RespuestaCorrecta": "8"
  }
]

Uso

Se muestra una pregunta con 4 opciones.

El jugador selecciona una respuesta haciendo clic en un botón.

Si la respuesta es correcta, avanza a la siguiente pregunta y acumula dinero.

Si la respuesta es incorrecta, el juego termina.

Opción de utilizar comodines (si están habilitados).

Personalización

Puedes modificar preguntas.json para agregar más preguntas.

Puedes mejorar la interfaz en MainForm.cs.

📜 Licencia y Copyright

© 2025 [Tu Nombre o Nombre del Proyecto]. Todos los derechos reservados.

Este proyecto es de código abierto y se distribuye bajo la licencia MIT. Puedes modificar y distribuir el código, siempre y cuando incluyas la atribución correspondiente.

Mejoras Futuras

🔹 Agregar temporizador. 🔹 Implementar efectos de sonido. 🔹 Guardar puntuaciones más altas.

📌 ¡Disfruta el juego y pon a prueba tus conocimientos! 🚀

