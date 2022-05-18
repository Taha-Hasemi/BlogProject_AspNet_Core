using EntityLayer.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User : IdentityUser<int>, IEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        //[ForeignKey("Role")]
        //public int? RoleId { get; set; }
        //public Role Role { get; set; }
    }
}
