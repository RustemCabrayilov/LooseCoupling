using LooseCoupling_Dependency;
using LooseCoupling_InDependency;

namespace LooseCoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loose coupling example
            LooseCoupling_InDependency.MailSender sender = new();
            sender.Send(new LooseCoupling_InDependency.Gmail());
            sender.Send(new LooseCoupling_InDependency.Hotmail());
            //Tight coupling example
            LooseCoupling_Dependency.MailSender sender2 = new();
            sender2.Send();
        }
    }
}
