using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulareExamen2
{
    public class Triunghi
    {
        public Triunghi(Punct A, Punct B, Punct C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Punct A { get; set; }
        public Punct B { get; set; }
        public Punct C { get; set; }
    }
}
