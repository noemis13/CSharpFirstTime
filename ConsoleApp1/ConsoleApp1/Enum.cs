using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    class Enum {

        enum DaysOfWeekeend {
            Saturday,
            Sunday
        }

        public static void usingEnum() {
            //Using enum
            DaysOfWeekeend today = DaysOfWeekeend.Saturday;
            Console.WriteLine(today);
            
        }
    }
}
