using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        
        IDataResult<List<Answer>> GetAll();
        IDataResult<Answer> GetById(int answerId);

    }
}
