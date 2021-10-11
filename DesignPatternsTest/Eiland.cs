using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public delegate void VulkaanUitbarsting(Eiland eiland);
    public class Eiland
    {
        private static Eiland _eiland;

        private Eiland()
        {

        }

        public static Eiland GetInstance()
        {
            if (_eiland == null)
            {
                _eiland = new Eiland();
            }

            return _eiland;
        }

        public event VulkaanUitbarsting VulkaanUitbarstingGebeurt;

        public void Uitbarsten()
        {
            if (VulkaanUitbarstingGebeurt != null)
                VulkaanUitbarstingGebeurt(this);
        }
    }
}
