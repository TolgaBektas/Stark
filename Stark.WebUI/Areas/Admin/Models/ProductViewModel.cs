using Stark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}
