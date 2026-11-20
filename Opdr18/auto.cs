using System;
using System.Collections.Generic;
using System.Text;

namespace Opdr18
{
    internal class auto
    {
        public Auto()
        {
        }
        public Auto(string merkNaam)
        {
            merk = merkNaam;
        }
        public Auto(string merkNaam, double prijsBedrag)
        {
            merk = merkNaam;
            prijs = prijsBedrag;
        }
    }
    
}
