using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public String Email { get; set; }
        public string Password { get; set; }
        public virtual UserProfile UserProfile { get; set; } 
    }
}
