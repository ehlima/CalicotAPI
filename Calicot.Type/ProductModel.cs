using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calicot.Type
{
    public class ProductModel
    {
        public int? productId { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public int prix { get; set; }
        public string photoUrl { get; set; }
    }
}
