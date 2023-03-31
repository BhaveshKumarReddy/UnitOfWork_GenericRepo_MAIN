using System;
using System.Collections.Generic;

namespace UnitOfWork_GenericRepo_MAIN.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Pid { get; set; }
        public string? Pname { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
