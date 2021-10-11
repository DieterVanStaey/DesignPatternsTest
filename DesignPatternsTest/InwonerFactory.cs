using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public class InwonerFactory
    {
        private static InwonerFactory deInwoners;

        private InwonerFactory()
        {

        }

        public static InwonerFactory GetInstance()
        {
            if (deInwoners == null)
            {
                deInwoners = new InwonerFactory();
            }

            return deInwoners;
        }
        public IInwoner maakInwoner(string regel, Eiland eiland)
        {
            char letter = Convert.ToChar(regel.Substring(0, 1).ToUpper());
            string naam = regel.Substring(2);
            return letter switch
            {
                'V' => new Vogel(naam, eiland),
                'Z' => new Zoogdier(naam, eiland),
                _ => throw new Exception("Foute soort ingegeven"),
            };
        }
    }
}
