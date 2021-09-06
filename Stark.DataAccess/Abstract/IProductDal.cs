using Stark.Core.DataAccess;
using Stark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //optional operations
    }
}
