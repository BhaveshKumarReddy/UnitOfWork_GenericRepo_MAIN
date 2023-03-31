using System;
using System.Collections.Generic;

namespace UnitOfWork_GenericRepo_MAIN.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Pid { get; set; }
        public string? Description { get; set; }

        public virtual Product PidNavigation { get; set; } = null!;
    }
}
