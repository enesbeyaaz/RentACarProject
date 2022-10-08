using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Constrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,ReCapContext>,IBrandDal
    {
       
    }
}
