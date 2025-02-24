using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character_List.Character_List list = new Character_List.Character_List();
            list.Input();
            Console.WriteLine("Input x");
            int x=int.Parse(Console.ReadLine());

            bool check= list.Check_Collision(x);
            if (check)
            {
                Console.WriteLine("Character has collision.");
                Character_List.Character_List b=list.Character_Collied_Type(check,x);

                Console.WriteLine("Character Type x has collied.");
                b.Output();
                Console.WriteLine("Quantity: " + b.Length);
            }
            else
            {
                Console.WriteLine("Not collied with any characters.");
                Character_List.Character_List b = list.Character_Collied_Type(check, x);
                b.Output();
            }


        }
    }
}
