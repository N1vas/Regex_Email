using System;
namespace EmailRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailPattern pattern = new EmailPattern();
            Console.WriteLine("Enter email id to be checked with regex");
            String mail = Console.ReadLine(); 
            bool result = pattern.ValidateEmail(mail);
            Console.WriteLine(result);
        }
    }
}
