using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_2022.Utilities
{
    static class Extension
    {
        public static void Extension1(this string soz, int num)
        {
            if (num % 2 == 1)
            {
                Console.WriteLine(soz);
            }
            else
            {
                Console.WriteLine($"{soz}'s");
            }
        }
        public static void ToName(this string soz)
        {
            string temp = "";
            for (int i = 0; i < soz.Length; i++)
            {
                if (i == 0)
                {
                    temp += char.ToUpper(soz[0]);
                }
                else
                {
                    temp += char.ToLower(soz[i]);
                }
            }
            Console.WriteLine(temp);
        }

        public static void ToNamebySbuilder(this string soz)
        {
            StringBuilder temp = new StringBuilder();

            temp.Append(char.ToUpper(soz[0]));

            for (int i = 1; i < soz.Length; i++)
            {

                temp.Append(char.ToLower(soz[i]));
                    
               
            }
            Console.WriteLine(temp);
        }
    }
}
