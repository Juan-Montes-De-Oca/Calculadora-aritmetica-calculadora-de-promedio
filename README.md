Calculadora & Evaluador de Promedios en C#
Proyecto de consola desarrollado en C# (.NET) que combina operaciones aritméticas básicas y un módulo para calcular promedios de estudiantes.

El objetivo principal fue aplicar Clean Code, manteniendo la lógica de negocio desacoplada de la interfaz de consola y manejando los errores de entrada del usuario de forma segura.

Funcionalidades
Operaciones básicas: Suma, resta, multiplicación y división (con validación de división entre cero).

Cálculo de promedios: Entrada continua de calificaciones (rango 0 a 100) usando -1 como valor centinela para finalizar la carga.

Evaluación de estado: Determina si el estudiante aprobó o reprobó en base a una nota mínima de 70.

Validación de entradas: Uso del patrón TryRead (double.TryParse) para evitar que el programa falle si el usuario ingresa texto o datos no válidos.

Estructura del código
El proyecto está separado en clases estáticas según su responsabilidad:

Program.cs: Controla el flujo principal del menú y la navegación.

InputReader.cs: Se encarga exclusivamente de leer y validar las entradas por teclado.

Calculator.cs: Contiene las operaciones matemáticas básicas.

StudentGrade.cs: Procesa el cálculo del promedio y la condición de aprobación.

Alerts.cs: Centraliza todos los mensajes de error, formateo de resultados y pausas.

Menu.cs: Muestra las opciones del menú principal.


Cómo ejecutarlo
Clonar el repositorio:


git clone https://github.com/tu-usuario/tu-repositorio.git
Entrar a la carpeta e iniciar la aplicación:


cd tu-repositorio
dotnet run

