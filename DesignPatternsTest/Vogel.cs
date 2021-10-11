using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public class Vogel : IInwoner
    {
        public string Naam { get; set; }
        public Vogel(string naam, Eiland eiland)
        {
            Naam = naam;
            eiland.VulkaanUitbarstingGebeurt += Vluchten;
        }
        public void Vluchten(Eiland eiland)
        {
            Console.WriteLine($"{Naam} vliegt hoog weg");
        }
    }
}
