using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public class Zoogdier : IInwoner
    {
        public string Naam { get; set; }
        public Zoogdier(string naam, Eiland eiland)
        {
            Naam = naam;
            eiland.VulkaanUitbarstingGebeurt += Vluchten;
        }
        public void Vluchten(Eiland eiland)
        {
            Console.WriteLine($"{Naam} vlucht in zijn hol");
        }
    }
}
