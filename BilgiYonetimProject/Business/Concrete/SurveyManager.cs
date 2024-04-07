using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SurveyManager:ISurveyService
    {
        ISurveyDal _surveyDal;
        public SurveyManager(ISurveyDal surveyDal)
        {
            _surveyDal = surveyDal;
        }

        public IDataResult<List<Survey>> GetAll()
        {
            return new SuccessDataResult < List < Survey >>(_surveyDal.GetAll());
        }

       

        public IDataResult<Survey> GetById(int surveyId)
        {
            return new SuccessDataResult<Survey>(_surveyDal.Get(s => s.SurveyId == surveyId));
        }

       

        public IDataResult<List<SurveyDetailDto>> GetSurveyDetails()
        {
            return new SuccessDataResult<List<SurveyDetailDto>>(_surveyDal.GetSurveyDetails());
        }

       
    }

}
