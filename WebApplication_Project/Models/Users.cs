using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Project.Models
{
    public class Users
    {

        [Key]
        public int user_id { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        [StringLength(20)]
        public string password { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string gender { get; set; }

        public int age { get; set; }

    }
}
