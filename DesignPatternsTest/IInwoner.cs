using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public interface IInwoner
    {
        public string Naam { get; set; }
        void Vluchten(Eiland eiland);
    }
}
