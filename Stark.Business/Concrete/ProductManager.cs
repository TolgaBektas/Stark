using Stark.Business.Abstract;
using Stark.DataAccess.Abstract;
using Stark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int CategoryId)
        {
            return _productDal.GetList(p => p.CategoryId == CategoryId ||CategoryId==0);
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int ProductId)
        {
            _productDal.Delete(new Product {Id=ProductId });
        }

        

        public void Update(Product product)
        {
            _productDal.Update(product); 
        }

        public Product GetById(int ProductId)
        {
            return _productDal.Get(x=>x.Id==ProductId);
        }
    }
}
