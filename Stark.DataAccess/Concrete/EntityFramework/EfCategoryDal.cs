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
    public class EfCategoryDal: EfEntityRepositoryBase<Category, StarkContext>, ICategoryDal
    {
        //IProductDal tek başına olursa implement istiyor
        //Fakat EfEntityRepositoryBase içerisinde zaten interface implement edilmiş vaziyette
        //EfEntityRepositoryBase zaten IProductDal'ın içesindeki inherit edilmiş interface'den inherit ediliyor, bu yüzden hata oluşmuyor
    }
}
