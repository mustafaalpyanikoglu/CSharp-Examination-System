using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace WinFormsApp1
{
    class QuestionManager: IQuestionService
    {
        //Neredeyse hepsini bütün işlemlerde kullandığımız için burda tanımladık.
        private SqlManager _sqlManager = new SqlManager();
        private SqlCommand _sqlCommand; //Sql komutlarını kullanıyoruz.
        private ErrorConstant _errorConstants = new ErrorConstant(); //Hatalı ifadeleri kullanıyoruz.
        private SuccessConstant _successConstant = new SuccessConstant(); //Başarılı ifadeleri kullanıyoruz.

        internal IQuestionService IQuestionService
        {
            get => default;
            set
            {
            }
        }

        public BaseResult<Question> AddQuestionData(Question question)
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection(); //Sql'i bağlıyoruz.

            if (question.UnitNo == 0) //UnitNo girilmezse soru eklenemez hata verir
            {
                return new ErrorResult<Question>(data: question, error: _errorConstants.DataNotAdded);
            }
            else
            {
                //Sorunun bilgilerini veritabanından çekiyoruz.
                _sqlCommand = new SqlCommand("Insert into Questions(UnitNo,SubjectNo,UnitName,SubjectName,OptionA,OptionB,OptionC,OptionD,RightOption,QuestionImage,QuestionTxt,QuestionStatus)Values(@UnitNo,@SubjectNo,@UnitName,@SubjectName,@OptionA,@OptionB,@OptionC,@OptionD,@RightOption,@QuestionImage,@QuestionTxt,@QuestionStatus)", sqlConnection);
                _sqlCommand.Parameters.AddWithValue("@UnitNo", question.UnitNo);
                _sqlCommand.Parameters.AddWithValue("@SubjectNo", question.SubjectNo);
                _sqlCommand.Parameters.AddWithValue("@UnitName", question.UnitName);
                _sqlCommand.Parameters.AddWithValue("@SubjectName", question.SubjectName);
                _sqlCommand.Parameters.AddWithValue("@OptionA", question.OptionA);
                _sqlCommand.Parameters.AddWithValue("@OptionB", question.OptionB);
                _sqlCommand.Parameters.AddWithValue("@OptionC", question.OptionC);
                _sqlCommand.Parameters.AddWithValue("@OptionD", question.OptionD);
                _sqlCommand.Parameters.AddWithValue("@QuestionStatus", 0);
                _sqlCommand.Parameters.AddWithValue("@QuestionTxt", question.QuestionTxt);
                _sqlCommand.Parameters.AddWithValue("QuestionImage", question.QuestionImage);
                _sqlCommand.Parameters.AddWithValue("@RightOption", question.RightOption);
                _sqlCommand.ExecuteNonQuery();
                return new SuccessResult<Question>(data: question, success: _successConstant.AddQuestion);
            }
        }

        public BaseResult<List<Question>> RandomQuestion()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();

            _sqlCommand = new SqlCommand("select top 10* from Questions order by newid()", sqlConnection); //veritabanından random 10 adet veri seçiyoruz

            List<Question> questionList = new List<Question>(); //Çektiğimiz verileri bu listeye kaydedeceğiz.
            _sqlCommand.ExecuteNonQuery();
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            while (reader.Read()) //sql veri tabanındaki soruların hepsini okuyup listeye kaydediyoruz
            {
                Question question = new Question();
                question.QuestionId = (int)reader["QuestionID"];
                question.UnitNo = (int)reader["UnitNo"];
                question.SubjectNo = (int)reader["SubjectNo"];
                question.UnitName = reader["UnitName"].ToString();
                question.SubjectName = reader["SubjectName"].ToString();
                question.OptionA = reader["OptionA"].ToString();
                question.OptionB = reader["OptionB"].ToString();
                question.OptionC = reader["OptionC"].ToString();
                question.OptionD = reader["OptionD"].ToString();
                question.RightOption = (int)reader["RightOption"];
                question.QuestionTxt = reader["QuestionTxt"].ToString();
                question.QuestionImage = (Byte[])reader["QuestionImage"];
                questionList.Add(question);
            }
            if (questionList.Count == 0) //listede eleman varlığının kontrolü yapılıyor
            {
                return new ErrorResult<List<Question>>(data: questionList, error: _errorConstants.DataNotFound);
            }
            else
            {
                return new SuccessResult<List<Question>>(data: questionList, success: _successConstant.RandomQuestionFound);
            }
        }

        public BaseResult<List<Question>> LoadData()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();

            _sqlCommand = new SqlCommand("Select * from Questions", sqlConnection); //Veritabanındaki tüm soruları seçiyoruz.

            List<Question> questionList = new List<Question>();
            _sqlCommand.ExecuteNonQuery();
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            while (reader.Read()) //sql veri tabanındaki soruların hepsini okuyup listeye kaydediyoruz
            {
                Question question = new Question();
                question.QuestionId = (int)reader["QuestionID"];
                question.UnitNo = (int)reader["UnitNo"];
                question.SubjectNo = (int)reader["SubjectNo"];
                question.UnitName = reader["UnitName"].ToString();
                question.SubjectName = reader["SubjectName"].ToString();
                question.OptionA = reader["OptionA"].ToString();
                question.OptionB = reader["OptionB"].ToString();
                question.OptionC = reader["OptionC"].ToString();
                question.OptionD = reader["OptionD"].ToString();
                question.RightOption = (int)reader["RightOption"];
                question.QuestionTxt = reader["QuestionTxt"].ToString();
                questionList.Add(question);
            }
            if (questionList.Count == 0) //listede eleman varlığının kontrolü
            {
                return new ErrorResult<List<Question>>(data: questionList, error: _errorConstants.DataNotFound);
            }
            else
            {
                return new SuccessResult<List<Question>>(data: questionList, success: _successConstant.AllQuestionFound);
            }
        }

        public BaseResult<Question> GetQuestionById(int questionId)
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand($"Select * from Questions WHERE QuestionID={questionId}", sqlConnection); //seçtiğimiz soru id'sine göre sorunun verilerini seçiyoruz.
            SqlDataReader reader = _sqlCommand.ExecuteReader();

            Question question = new Question();
            if (reader.Read()) //Sorunun bilgilerini okuyup kaydediyoruz
            {
                question.QuestionId = (int)reader["QuestionID"];
                question.UnitNo = (int)reader["UnitNo"];
                question.SubjectNo = (int)reader["SubjectNo"];
                question.UnitName = reader["UnitName"].ToString();
                question.SubjectName = reader["SubjectName"].ToString();
                question.OptionA = reader["OptionA"].ToString();
                question.OptionB = reader["OptionB"].ToString();
                question.OptionC = reader["OptionC"].ToString();
                question.OptionD = reader["OptionD"].ToString();
                question.RightOption = (int)reader["RightOption"];
                question.QuestionImage = (Byte[])reader["QuestionImage"];
                question.QuestionStatus = (int)reader["QuestionStatus"];
                question.QuestionTxt = reader["QuestionTxt"].ToString();
            }
            if (question.QuestionTxt == "") //Okuduğumuz soruda eksik bilgi olmadığının kontrolünü yapıyoruz
            {
                return new ErrorResult<Question>(data: question, error: _errorConstants.QuestionNotFound);
            }
            else
            {
                return new SuccessResult<Question>(data: question, success: _successConstant.QuestionFound);
            }
        }

        /*public BaseResult<Question> DeleteQuestion() //Soruları veritabanından siliyor
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand("Delete from Questions where QuestionID=@QuestionId", sqlConnection);
            //_sqlCommand.Parameters.AddWithValue("@QuestionId", SqlDbType.Int).Value = id1.Text;
            _sqlCommand.ExecuteNonQuery();
            _sqlManager.sqlConnection().Close();

        }*/

        public BaseResult<Question> UpdateQuestion(int questionId)
        {
            //QuestionStatus==0 ise soru onaylı değil || QuestionStatus==1 ise soru onaylı anlamına gelir
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand($"UPDATE Questions SET QuestionStatus=1 WHERE QuestionID={questionId} ", sqlConnection); //seçtiğimiz soru id'sine göre sorunun durumunu onaylı yapıyoruz yani değerini 1 yapıyoruz
            _sqlCommand.ExecuteNonQuery();
            BaseResult<Question> dataResult = GetQuestionById(questionId); //Seçtiğmiz sorunun bütün bilgilerini çekiyoruz.
            if (dataResult.data.QuestionStatus == 1) //Seçtiğimiz sorunun onaylı olduğundan emin oluyoruz.
            {
                return new SuccessResult<Question>(data: dataResult.data, success: _successConstant.QuestionApproved);
            }
            else
            {
                return new ErrorResult<Question>(data: dataResult.data, error: _errorConstants.QuestionNotUpdate);
            }
        }
    }
}
