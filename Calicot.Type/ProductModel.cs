using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calicot.Type
{
    public class ProductModel
    {
        public int? ProductId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Prix { get; set; }
        public string PhotoUrl { get; set; }
    }
}
