Automatizador de Envío de Correos con Reporte CSV 🚀
Este es un proyecto simple en C# y WPF que automatiza el envío de correos electrónicos. Su función principal es leer un archivo CSV, convertir los datos en una tabla HTML y enviar esta tabla como cuerpo de un correo electrónico.

✨ Características
Envío de Correos Automatizado: Inicia el proceso de envío de correos de forma automática al cargar la aplicación.

Visualización de Estado: Muestra el progreso del envío en una ventana de la aplicación.

Formato HTML: Convierte automáticamente el contenido de un archivo CSV en una tabla HTML para un formato visualmente atractivo en el cuerpo del correo.

Uso de Argumentos: Configura el envío del correo electrónico mediante argumentos de línea de comandos, lo que lo hace ideal para tareas automatizadas o scripts.

🛠️ Requisitos
Visual Studio: Se requiere para compilar y ejecutar el proyecto.

.NET Framework: El proyecto está construido sobre el .NET Framework.

Acceso a un Servidor SMTP: Necesitarás un servidor SMTP y credenciales válidas para enviar correos.

⚙️ Uso
Para utilizar esta aplicación, debes pasar cinco argumentos de línea de comandos en el siguiente orden:

emailEmisor: El correo electrónico que enviará el mensaje.

password: La contraseña del correo electrónico emisor.

emailDestinatario: El correo electrónico que recibirá el mensaje.

encabezadoCorreo: El asunto del correo electrónico.

archivoReporteCsv: La ruta al archivo CSV que se utilizará para el cuerpo del correo.

Ejemplo de cómo ejecutarlo:
EnviarCorreo.exe "tu_correo@ejemplo.com" "tu_password" "destino@ejemplo.com" "Reporte Semanal" "C:\reporte.csv"


⚠️ Advertencia

La contraseña se maneja como un argumento de texto plano.
Para una mayor seguridad en entornos de producción, se recomienda utilizar un método más seguro para manejar credenciales, como variables de entorno o un servicio de secretos.

El servidor SMTP está configurado como mail.tuDominio.com. Asegúrate de cambiar esta configuración en el archivo MainWindow.xaml.cs por el servidor SMTP que utilices.
Contribuir
Siéntete libre de clonar este repositorio y adaptarlo a tus necesidades. Si encuentras alguna mejora o bug, ¡envía un Pull Request!

Licencia
Este proyecto está bajo la licencia [MIT].

HorizonDevs - horizondevs.net