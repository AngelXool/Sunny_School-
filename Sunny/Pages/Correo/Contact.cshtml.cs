using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SunnyModels;

namespace Sunny.Pages.Correo
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public Email mails { get; set; }

        public void OnGet()
        {
        }

        public async Task OnePost()
        {
            string To = mails.To;
            string Subject = mails.Subject;
            string Body = mails.Body;
            MailMessage mm = new MailMessage();
            mm.To.Add(To);
            mm.Subject = Subject;
            mm.Body = Body;
            mm.IsBodyHtml = false;
            mm.From = new MailAddress("noxplayer2211@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 465;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("Nox Player", "noxplayer2211@gmail.com", "Loslideres2211");
            await smtp.SendMailAsync(mm);
            ViewData["Message"] = "The Mail Has Been Sent To" + mails.To;
        }
    }
}
