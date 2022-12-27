using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace homework.calctasks
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

            MailAddress from = new MailAddress("Sergey200127@yandex.ru");
            MailAddress to = new MailAddress(address);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "TESTING";
            Console.WriteLine("Enter message");
            string message = Console.ReadLine();
            m.Body = message;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("", "");

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

