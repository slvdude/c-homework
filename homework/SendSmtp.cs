using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace homework
{
	public class SendSmtp
	{
		public SendSmtp()
		{
		}

        public static void SendEmail()
        {

            Console.WriteLine("Enter email address");
            string address = Console.ReadLine();

            while (!IsValidEmail(address))
            {
                Console.WriteLine("Email address is not valid. Enter again!");
                address = Console.ReadLine();
            }

            MailAddress from = new MailAddress("", "");
            MailAddress to = new MailAddress(address);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "TESTING";
            Console.WriteLine("Enter message");
            string message = Console.ReadLine();
            m.Body = message;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("", "");
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(m);
                Console.WriteLine("Message was sent");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in SendEmail(): {0}",
                    ex.ToString());
            }
        }

        private static bool IsValidEmail(string address)
        {
            return new EmailAddressAttribute().IsValid(address);
        }
    }
}

