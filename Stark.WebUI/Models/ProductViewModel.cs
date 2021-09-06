using Stark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}
