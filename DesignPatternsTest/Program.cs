using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace DesignPatternsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Eiland eiland = Eiland.GetInstance();
                InwonerFactory inwoners = InwonerFactory.GetInstance();
                string regel;
                using StreamReader reader = new StreamReader("inwoners.txt");
                while ((regel = reader.ReadLine()) != null)
                {
                    inwoners.maakInwoner(regel, eiland);
                }
                eiland.Uitbarsten();
            }
            catch (IOException)
            {
                Console.WriteLine("Document niet correct uitgelezen");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
