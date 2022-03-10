using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using elib_mvc.Identity;
using Microsoft.AspNetCore.Identity;

namespace elib_mvc.Models
{
    public class RoleModel
    {
        [Required]
        public string name { get; set; }
    }

    public class RoleDetails
    {
        public IdentityRole Role { get; set; }

        public IEnumerable<User> Members { get; set; }
        public IEnumerable<User> NonMembers { get; set; }

    }


    public class RoleEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}