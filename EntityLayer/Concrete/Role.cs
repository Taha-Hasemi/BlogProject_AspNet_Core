using EntityLayer.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role : IdentityRole<int>, IEntity
    {
        public string RoleColor { get; set; }

        public List<Admin> Admins { get; set; }
        //public List<User> Users { get; set; }
    }
}
