using System.Net;
using System.Net.Mail;

namespace sendMailExampl_29_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.mail.ru");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential ("A_Fiscman@list.ru", "ittEHuHPF0TDK19ZqAT2");
            // отправка сообщения
            smtpClient.Send ("A_Fiscman@list.ru", "den9152@yandex.ru", "twrthrt", "Здрасти");
            Console.WriteLine("сообщение отправлено");
        }
    }
}