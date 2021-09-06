using Stark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int ProductId);
        List<Product> GetAll();
        List<Product> GetByCategory(int CategoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int ProductId);


    }
}
