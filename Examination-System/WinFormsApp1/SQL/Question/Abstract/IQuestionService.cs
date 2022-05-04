using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface IQuestionService
    {

        public BaseResult<Question> AddQuestionData(Question question); //Veri tabanına soru bilgilerini ekliyor

        public BaseResult<List<Question>> RandomQuestion(); //Veri tabanından random soru çekiyor

        public BaseResult<List<Question>> LoadData(); //Veritabanındaki tüm soruları çekiyor

        public BaseResult<Question> GetQuestionById(int questionId); //Soru id'sine göre sorunun bilgilerini çekiyor

        /*public BaseResult<Question> DeleteQuestion();*/
        public BaseResult<Question> UpdateQuestion(int questionId); //Soru onaylandığında sorunun durumunu değiştiriyoruz
    }
}
