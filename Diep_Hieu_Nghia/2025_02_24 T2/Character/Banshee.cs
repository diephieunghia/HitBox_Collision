using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_T2.Character
{
    internal class Banshee : Character
    {
        public Banshee(double x, double y) : base(x, y) {
            this.w = 24;
            this.h = 32;
        }
        public Banshee() {
            this.w = 24;
            this.h = 32;
        }
    }
}
