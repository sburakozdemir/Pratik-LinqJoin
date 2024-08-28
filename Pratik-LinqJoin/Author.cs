using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_LinqJoin
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } 
        
        public Author(int _id , string _name) 
        
        { 
            AuthorId = _id ;
            Name = _name ;
            
        }
    }
}
