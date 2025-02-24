using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_T2.Character
{
    internal class Bat_Man : Character
    {
        public Bat_Man(double x, double y) : base(x, y) {
            this.w = 24;
            this.h = 40;
        }
        public Bat_Man() {
            this.w = 24;
            this.h = 40;
        }
    }
}
