using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ISurveyService
    {
        IDataResult<List<Survey>> GetAll();
        IDataResult<Survey> GetById(int surveyId);
        IDataResult< List<SurveyDetailDto> > GetSurveyDetails();
    }
}
