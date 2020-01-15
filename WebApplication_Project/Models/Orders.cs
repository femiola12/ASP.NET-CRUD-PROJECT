using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Project.Models
{
    public class Orders
    {

        [Key]
        public int order_id { get; set; }

        public virtual Games Games { get; set; }

        public virtual Users Users { get; set; }

        public int price { get; set; }
    }
}
