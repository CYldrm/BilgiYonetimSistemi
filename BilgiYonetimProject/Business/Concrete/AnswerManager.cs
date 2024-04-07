using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;
        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }



        public IDataResult<List<Answer>> GetAll()
        {
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll()," ");
        }

        public IDataResult<Answer> GetById(int answerId)
        {
            return new SuccessDataResult<Answer>(_answerDal.Get(a => a.AnswerId == answerId));
        }

        
    }
}
