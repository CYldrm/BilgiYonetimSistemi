using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class QuestionGroupManager : IQuestionGroupService
    {
        IQuestionGroupDal _questionGroupDal;

        public QuestionGroupManager(IQuestionGroupDal questionGroupDal)
        {
            _questionGroupDal = questionGroupDal;
        }

        public IDataResult<List<QuestionGroup>> GetAll()
        {
            return new SuccessDataResult<List<QuestionGroup>> (_questionGroupDal.GetAll());
        }

        public IDataResult<QuestionGroup> GetById(int groupId)
        {
            return new SuccessDataResult<QuestionGroup>(_questionGroupDal.Get(qg => qg.QuestionGroupId == groupId));
        }
    }
}
