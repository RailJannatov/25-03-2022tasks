using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking_File.Models
{
    class Order
    {
        public int Id { get; set; }
        public List<OrderItem> items { get; set; }
    }
}
