using Core.DataAccess.Concrete;
using Core.Utilities.Results;
using Entities.Constrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByEmail(string email);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);

    }
}
