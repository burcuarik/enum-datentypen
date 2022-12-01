using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Datentyp {
    class Program {
        static void Main ( string [ ] args ) {
            Seasons jahreszeit = Seasons.WINTER;
            Seasons eineJahreszeit = Seasons.WINTER;
            Farben schulnote = Farben.GELB;

            var zahl = ( Seasons ) 3;
            Console.WriteLine ( zahl);

            int zahlFuerWinter = ( int ) eineJahreszeit;
            Console.WriteLine ( zahlFuerWinter);

            Console.ReadLine ( );
        }

    }
}
