using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling_Dependency;
class MailSender
{
    public void Send()
    {
        /* Gmail gmail = new();
         gmail.Send("randomemail@random.com", "blablabla");*/
        Hotmail hotmail = new();
        hotmail.Send("randomemail@random.com", "blablabla");
    }
}
class Gmail
{
    public void Send(string to, string body)
    {
        Console.WriteLine($"Sent {body} to {to} by Gmail");
    }
}
class Hotmail
{
    public void Send(string to, string body)
    {
        Console.WriteLine($"Sent {body} to {to} by Hotmail");
    }
}

