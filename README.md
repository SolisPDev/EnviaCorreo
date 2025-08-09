Reporte de Ventas por Email
Descripción del Proyecto
Este proyecto es una aplicación de escritorio desarrollada en .NET Framework 4.7.2 diseñada para automatizar el envío de reportes de ventas por correo electrónico. La aplicación se integra con sistemas legados (en los cuales tengas acceso al codigo fuente) para generar y enviar reportes diarios de forma automática, sin requerir la intervención del usuario.

La aplicación toma un archivo CSV como entrada, lo procesa para convertir su contenido en una tabla HTML, y envía esta tabla en el cuerpo de un correo electrónico. Esto garantiza que el reporte sea legible y visualmente atractivo para los destinatarios.

Características Principales
Automatización: Envío de correos electrónicos sin interacción manual.

Integración: Diseñado para ser ejecutado por aplicaciones externas a través de la línea de comandos.

Formato Profesional: Convierte datos de un archivo CSV en una tabla HTML legible dentro del cuerpo del correo.

Configuración de Correo Segura: Utiliza la librería MailKit para una conexión robusta y segura con servidores SMTP (SSL/TLS).

Tecnologías Usadas
C#

.NET Framework 4.7.2

MailKit: Librería para el envío de correos electrónicos.

Modo de Uso
La aplicación se ejecuta a través de la línea de comandos con tres argumentos:

EnviaCorreo.exe "correo_origen@ejemplo.com" "correo_destino@ejemplo.com" "ruta\al\archivo\reporte.csv"

correo_origen@ejemplo.com: Dirección de correo electrónico del remitente.

correo_destino@ejemplo.com: Dirección de correo electrónico del destinatario.

ruta\al\archivo\reporte.csv: Ruta completa al archivo CSV que contiene el reporte.

Configuración
Para su correcto funcionamiento, es necesario configurar las credenciales y el servidor SMTP en el código fuente de la clase EmailSender.cs.

C#

// Ejemplo de configuración en EmailSender.cs
await client.ConnectAsync("mail.tudominio.mx", 465, SecureSocketOptions.SslOnConnect);
await client.AuthenticateAsync("tucuenta@tudominio.mx", "tu_contraseña_real");
Contribuir
Siéntete libre de clonar este repositorio y adaptarlo a tus necesidades. Si encuentras alguna mejora o bug, ¡envía un Pull Request!

Licencia
Este proyecto está bajo la licencia [MIT].

HorizonDevs - horizondevs.net