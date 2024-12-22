using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelationExample.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        // Navigation Property
        public ICollection<Post> Posts { get; set; }
    }
}
