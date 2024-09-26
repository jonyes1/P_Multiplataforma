using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfmulti2
{
    public class Figura
    {
        public String Nome { get; set; }
        public String Altura { get; set; }
        public String Largura { get; set; }

        public override string ToString()
        {
            return Nome + "[" + Largura + ":" + Altura + "]";
        }

    }
}
