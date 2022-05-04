using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface IQuestionService
    {

        public BaseResult<Question> AddQuestionData(Question question);

        public BaseResult<List<Question>> RandomQuestion();

        public BaseResult<List<Question>> LoadData();

        public BaseResult<Question> GetQuestionById(int questionId);

        /*public BaseResult<Question> DeleteQuestion();*/
        public BaseResult<Question> UpdateQuestion(int questionId);
    }
}
