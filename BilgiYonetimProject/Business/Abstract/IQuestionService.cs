using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IQuestionService
    {
   
        IDataResult<Question> GetById(int questionId);
        IDataResult<List<Question>> GetAll();
    }
}
