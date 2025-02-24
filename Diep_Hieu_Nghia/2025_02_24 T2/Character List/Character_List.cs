using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_T2.Character_List
{
    internal class Character_List
    {
        List<Character.Character> list;

        public int Length { get { return list.Count; } }

        public Character_List()
        {
            list = new List<Character.Character>();
        }
        public void Input()//Adjust x,y for characters in list
        {
            Console.WriteLine("Input number of character to the list.");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Input character type: " +
                    "1.Rya, 2.Armor Sword Man, 3.Banshee, 4.Bat Man, 5. Bomberhead.");
                int a=int.Parse(Console.ReadLine());
                while (true)
                {
                    if (a == 1)
                    {
                        list.Add(new Character.Rya(3,0));
                        break;
                    }
                    else if (a == 2)
                    {
                        list.Add(new Character.Armor_Sword_Man(1,1));
                        break;
                    }
                    else if (a == 3)
                    {
                        list.Add(new Character.Banshee(5,4));
                        break;
                    }
                    else if (a == 4)
                    {
                        list.Add(new Character.Bat_Man(6,3));
                        break;
                    }
                    else if (a == 5)
                    { list.Add(new Character.Bomberhead(9,7));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, try again.");
                        a = int.Parse(Console.ReadLine());
                    }    
                }
            }

        }

        public void Output()
        {
            foreach(Character.Character c in list)
            {
                Console.WriteLine(c.GetType().Name);
            }
        }

        public bool Check_Collision(int x)//x ->1...n
        {         
            Console.WriteLine($"List length is: {list.Count} ");          
            while (x > list.Count) {
                Console.WriteLine("Input invalid, try input character position in list again");
                x = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < list.Count; i++)
            {
                if ((i!=(x-1)) && (list[x - 1].Check_Collision(list[i])))
                {
                    return true;
                }
            }
            return false;
        }
        public Character_List Character_Collied_Type(bool check_collsion, int x)//x ->1...n
        {
            Character_List temp = new Character_List();
            if (check_collsion == false)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if ((list[i].GetType() == list[x - 1].GetType()) && (i != (x - 1)))
                    {
                        temp.list.Add(list[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if ((i != (x - 1)) && (list[x - 1].Check_Collision(list[i])))
                    {
                        temp.list.Add(list[i]);
                        break;
                    }
                }
                for(int i=0; i < list.Count; i++)
                {
                    if ((temp.list[0].GetType() == list[i].GetType())&&((x-1)!=i))
                        temp.list.Add(list[i]);
                }             
                temp.list.RemoveAt(0);
            }
            return temp;
        }
    }
}
