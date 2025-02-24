using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_T2.Character
{
    internal class Character
    {
        protected double x;
        protected double y;
        protected double w; 
        protected double h;

        public Character() { }
        public Character(double x, double y) {
            this.x = x;
            this.y = y;
        }
        public bool Check_Collision(Character B)
        {
            if ((this.x >= B.x) && ((B.x + B.w) >= this.x))
            {
                if ((this.y >= B.y) && (B.y >= (this.y - this.h)))
                    return true;
                else if ((this.y < B.y) && ((B.y - B.h) <= this.y))
                    return true;
            }
            else if ((this.x < B.x) && (this.x + this.w >= B.x))
            {
                if ((this.y >= B.y) && (B.y >= (this.y - this.h)))
                    return true;
                else if ((this.y < B.y) && ((B.y - B.h <= this.y)))
                    return true;
            }
            return false;
        }
    }
}
