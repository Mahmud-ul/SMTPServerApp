using System.Net;
using System.Net.Mail;

public class SMTPLetestApp
{
    static void Main(string[] args)
    {
        mailSend();
        Console.ReadKey();
    }
    static void mailSend()
    {
        try
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
            string from = "docuspeedy@ispahanibd.com";
            string to = "tipumahmudulhasan55@gmail.com";
            string password = "iTD%p5y#83";
            //Mail Prepare
            MailMessage msg = new MailMessage();
            msg.Subject = "Test Mail";
            msg.Body = "just a test mail.";
            msg.From = new MailAddress(from);
            msg.To.Add(new MailAddress(to));

            //Network Credential ready
            NetworkCredential nc = new NetworkCredential(from, password);

            //Server Prepare
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mail.ispahanibd.com";
            smtp.Port = 25;
            smtp.EnableSsl = true;
            smtp.Credentials = nc;

            smtp.Send(msg);
            Console.WriteLine("Message sent successfully!!!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
