using Stark.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,double.MaxValue, ErrorMessage = "Please select a category.")]
        
        public int CategoryId { get; set; }
        
        public decimal Price { get; set; }
        public short Stock { get; set; }
    }
}
