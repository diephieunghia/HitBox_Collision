using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_T2.Character
{
    internal class Armor_Sword_Man:Character
    {
        public Armor_Sword_Man(double x, double y) : base(x, y) {
            this.w = 25;
            this.h = 39;
        }
        public Armor_Sword_Man()
        {
            this.w = 25;
            this.h = 39;
        }
    }
}
