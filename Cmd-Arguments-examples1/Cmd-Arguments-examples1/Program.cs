using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd_Arguments_examples1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string param in args)
            // vis lige alle parametre
            {
                // Console.WriteLine(param);
                if (param.Contains("?"))
                {
                    // Console.WriteLine("Du har bedt om hjælp - og det skal du få...\n ? udskriver hjælp :)");
                    Console.WriteLine("Programmet modtager en fil som input parameter \n F.eks c:\\>cmdArguments c:\\h1\\user.txt");
                }
                // her vil vi læse en fil fra OS udpeget 
            }

            string sti = @"C:\Tekstfil\Tekstfil.txt";
            //jeg antager at argument[0] indeholder stien til datafilen

            List<string> Userlist = new List<string>();
            using (StreamReader sr = File.OpenText(args[0]))
            {
                string users = "";

                while ((users = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    //string[] Users = users.Split();
                    Userlist.Add(users);

                }
                foreach (string brugere in Userlist)
                {
                    Console.WriteLine(brugere);

                }
                Console.Read();
            }
        }
    }
}
