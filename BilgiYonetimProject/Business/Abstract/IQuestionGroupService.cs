using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IQuestionGroupService
    {
        IDataResult<List<QuestionGroup>> GetAll();
        IDataResult<QuestionGroup> GetById(int questionGroupId);

    }
}
