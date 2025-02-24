using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_T2.Character
{
    internal class Bomberhead : Character
    {
        public Bomberhead(double x, double y) : base(x, y) {
            this.w = 46;
            this.h = 63;
        }
        public Bomberhead() {
            this.w = 46;
            this.h = 63;
        } 
    }
}
