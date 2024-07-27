using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling_InDependency;
class MailSender
{
    public void Send(IMailService mailService)
    {
        mailService.Send("randomemail@random.com", "blabla");
    }
}
interface IMailService
{
    void Send(string to, string body);
}
class Gmail : IMailService
{
    public void Send(string to, string body)
    {
        Console.WriteLine($"Sent {body} to {to} by Gmail");
    }
}
class Hotmail : IMailService
{
    public void Send(string to, string body)
    {
        Console.WriteLine($"Sent {body} to {to} by Hotmail");
    }
}
