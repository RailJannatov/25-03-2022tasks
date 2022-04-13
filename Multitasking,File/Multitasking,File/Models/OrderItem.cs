using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking_File.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public int Count { get; set; }
        public Product product { get; set; }
    }
}
