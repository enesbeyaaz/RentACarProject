﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Constrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityDal:EfEntityRepositoryBase<Rental,ReCapContext>,IRentalDal
    {
    }
}
