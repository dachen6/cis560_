using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cis560_proj
{
    public class Customers
    {
        public int CustomerID {get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Tel { get; set; }


        public string FullInfo
        {
           get{
                return $"{Name} {Email} {Tel}";
            }
        } 
    }
}
