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
    class QuestionManager
    {
        private SqlManager _sqlManager = new SqlManager();
        private SqlCommand _sqlCommand;
        
        public BaseResult<Question> AddQuestionData(Question question)
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();

            if(question.UnitNo==0)
            {
                return new ErrorResult<Question>(data: question, error: "Veritabanına veri eklenemedi.");
            }
            else
            {
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
                return new SuccessResult<Question>(data: question,success:"Soru başarıyla eklendi.");
            }
        }

        public BaseResult<List<Question>> RandomQuestion()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand("select top 10* from Questions order by newid()", sqlConnection);

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
                //MessageBox.Show(String.Format("{0}", reader["QuestionTxt"]));
            }
            if (questionList.Count == 0) //listede eleman varlığının kontrolü
            {
                return new ErrorResult<List<Question>>(data: questionList, error: "Veritabanında veri bulunamadı.");
            }
            else
            {
                return new SuccessResult<List<Question>>(data: questionList, success: "Random soru verileri çekildi.");
            }
        }

        public BaseResult<List<Question>> LoadData() //tüm sorunun verilerini çekiyor
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();

            _sqlCommand = new SqlCommand("Select * from Questions", sqlConnection);

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
                //MessageBox.Show(String.Format("{0}", reader["QuestionTxt"]));
            }
            if(questionList.Count==0) //listede eleman varlığının kontrolü
            {
                return new ErrorResult<List<Question>>(data: questionList, error: "Veritabanında veri bulunamadı.");
            }
            else
            {
                return new SuccessResult<List<Question>>(data: questionList,success:"Bütün soru verileri çekildi.");
            }
        }

        public BaseResult<Question> UploadQuestion(int questionId) //istediğimiz sorunun verilerini çekiyor
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand($"Select * from Questions WHERE QuestionID={questionId}", sqlConnection);
            SqlDataReader reader = _sqlCommand.ExecuteReader();

            Question question = new Question();
            if (reader.Read())
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
            if(question.QuestionTxt=="")
            {
                return new ErrorResult<Question>(data:question,error:"Soru bulunamadı.");
            }
            else
            {
                return new SuccessResult<Question>(data: question,success:"Soru Bulundu.");
            }
        }

        /*public BaseResult<Question> DeleteQuestion()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand("Delete from Questions where QuestionID=@QuestionId", sqlConnection);
            //_sqlCommand.Parameters.AddWithValue("@QuestionId", SqlDbType.Int).Value = id1.Text;
            _sqlCommand.ExecuteNonQuery();
            _sqlManager.sqlConnection().Close();

        }*/

        public BaseResult<Question> UpdateQuestion(int questionId)
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand($"UPDATE Questions SET QuestionStatus=1 WHERE QuestionID={questionId} ", sqlConnection);
            BaseResult<Question> dataResult = UploadQuestion(questionId);
            MessageBox.Show("değiştirilen değer:"+dataResult.data.QuestionStatus.ToString());
            if (dataResult.data.QuestionStatus==1)
            {
                return new SuccessResult<Question>(data: dataResult.data,success: "Soru onaylandı.");
            }
            else
            {
                return new ErrorResult<Question>(data: dataResult.data, error: "Soru güncellenemedi.");
            }
        }


    }
}
