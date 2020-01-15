using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Project.Models
{
    public class Games
    {

        [Key]
        public int game_id { get; set; }
        [StringLength(33)]
        public string name { get; set; }
        [StringLength(53)]
        public string genre { get; set; }

        public int price { get; set; }

        public int age_limit { get; set; }

        [StringLength(20)]
        public string release_data { get; set; }

        [StringLength(763)]
        public string description { get; set; }

        public ICollection<Orders> orders { get; set; }





    }
}
