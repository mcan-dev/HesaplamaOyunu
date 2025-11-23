using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikOyunu
{
    internal class Soru
    {
        public string SoruMetni { get; set; }
        public int DogruCevap { get; set; }
        public bool BirKezPasGecildiMi { get; set; }
    }
}
