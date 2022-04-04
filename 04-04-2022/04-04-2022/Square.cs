using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_2022
{
    class Square : Figure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                    Console.WriteLine("Neynirsen side mefi niye verirsen");

                }
            }
        }
        public override void CalcArea()
        {
          Console.WriteLine($"Square-in sahesi {Side*Side}");
        }
    }
}
