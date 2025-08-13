using System;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows;

namespace EnviarCorreo
{
    public partial class MainWindow : Window
    {
        private string _emailEmisor;
        private string _password;
        private string _emailDestinatario;
        private string _encabezadoCorreo;
        private string _archivoReporteCsv;

        public MainWindow(string[] args)
        {
            InitializeComponent();
                       

            if (args.Length != 5)
            {
                MessageBox.Show("La cantidad de argumentos es incorrecta.");
                Application.Current.Shutdown();
                return;
            }

            _emailEmisor = args[0];
            _password = args[1];
            _emailDestinatario = args[2];
            _encabezadoCorreo = args[3];
            _archivoReporteCsv = args[4];

            Loaded += MainWindow_Loaded;

        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(10000); // Retraso de 100ms
            EnviarCorreo();
        }

        private async void EnviarCorreo()
        {
            try
            {
                txtEstado.Text += $"Iniciando proceso...\r\n";

                // Leer archivo CSV
                string contenidoCsv = File.ReadAllText(_archivoReporteCsv);
                string bodyCorreo = DarFormatoBody(contenidoCsv);

                // Enviar correo electrónico
                txtEstado.Text += $"Enviando correo electrónico...\r\n";
                await EnviarCorreoElectronico(bodyCorreo);

                txtEstado.Text += $"Correo electrónico enviado correctamente.\r\n";
            }
            catch (Exception ex)
            {
                txtEstado.Text += $"Error: {ex.Message}\r\n";
            }
            finally
            {
                txtEstado.Text += $"Proceso finalizado.\r\n";
            }
        }

        private string DarFormatoBody(string contenidoCsv)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html><body>");
            sb.AppendLine($"<h2>{_encabezadoCorreo}</h2>");
            sb.AppendLine("<table border='1'>");

            string[] filas = contenidoCsv.Split('\n');
            foreach (string fila in filas)
            {
                sb.AppendLine($"<tr><td>{fila.Replace(",", "</td><td>")}</td></tr>");
            }

            sb.AppendLine("</table>");
            sb.AppendLine("</body></html>");

            return sb.ToString();
        }

        private async Task EnviarCorreoElectronico(string bodyCorreo)
        {
            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Host = "mail.chaires.mx"; // Cambiar según el proveedor de correo electrónico
                smtpClient.Port = 465;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(_emailEmisor, _password);

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(_emailEmisor);
                    mailMessage.To.Add(_emailDestinatario);
                    mailMessage.Subject = _encabezadoCorreo;
                    mailMessage.Body = bodyCorreo;
                    mailMessage.IsBodyHtml = true;

                    await smtpClient.SendMailAsync(mailMessage);
                }
            }
        }
    }
}