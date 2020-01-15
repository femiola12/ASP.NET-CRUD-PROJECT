using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication_Project.Models
{
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole() : base()
        {

        }

        public ApplicationRole(string roleName) : base(roleName)
        {

        }

        public ApplicationRole(string roleName, string description, DateTime CreationDate) : base(roleName)
        {
            this.description = description;
            this.CreationDate = CreationDate;
        }

        public string description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
