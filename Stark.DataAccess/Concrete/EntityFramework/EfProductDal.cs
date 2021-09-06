using Stark.Core.DataAccess.EntityFramework;
using Stark.DataAccess.Abstract;
using Stark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,StarkContext>,IProductDal
    {
    }
}
