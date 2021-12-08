using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkaufsprojekt {
    enum Entwicklerstatus {
        
        NEULING,
        FORTGESCHRITTENER,
        PROFI,
        EXPERTE
    }

    class EntwicklerstatusManager {

        public static Entwicklerstatus getByName(string name) {
            switch (name.ToLower()) {
                case "neuling": return Entwicklerstatus.NEULING;
                case "fortgeschrittener": return Entwicklerstatus.FORTGESCHRITTENER;
                case "profi": return Entwicklerstatus.PROFI;
                case "experte": return Entwicklerstatus.EXPERTE;

                default: return Entwicklerstatus.NEULING;
            }
        }

    }

}
