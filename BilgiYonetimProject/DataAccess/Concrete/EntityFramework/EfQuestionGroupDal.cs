﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuestionGroupDal : EfEntityRepositoryBase<QuestionGroup, NorthwindContext>, IQuestionGroupDal
    {
        
    }
}
