using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumİmplicitExplicit
{
    class MyList<T>
    {
        private T[] _arr;
        private int _count;
        public int Count { get => _count; }
        public int Capacity { get; set; } = 0;
        public MyList()
        {
            _count = 0;
            _arr = new T[0];
        }
        public MyList(int capacity)
        {
            Capacity = capacity;
            _count = Capacity;
            _arr = new T[Capacity];
        }
        public void AddItem(T item)
        {
            Resizeble(_arr.Length == _count);//_arr.Length  =2
            _arr[Count] = item;
            _count++; //1 ,2 
        }

        public void AddItems(params T[] items)
        {
            foreach(T item in items)
            {
                AddItem(item);
            }
        }

        public void Resizeble(bool a)
        {
            if (a)
            {
                Array.Resize(ref _arr, (_arr.Length == 0 ? 1 : 2)*2);
                
            }
        }
    }
}
