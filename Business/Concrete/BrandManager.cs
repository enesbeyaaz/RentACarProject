﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspect.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Constrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [SecuredOperation("admin")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }
        [CacheAspect]
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id), Messages.BrandListed);
        }
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
