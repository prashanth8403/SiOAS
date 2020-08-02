using System;

namespace SiOAS
{
    public class AnswerSet
    {
        string Question, option1, option2, option3, option4;
        int Answer, Response;
        Boolean Display,Generated;

        public AnswerSet()
        {
            Question = "Not Initalized";
            option1 = "Not Initalized";
            option2 = "Not Initalized";
            option3 = "Not Initalized";
            option4 = "Not Initalized";
            Answer = 0;
            Display = false;
            Generated = false;
            Response = 0;
        }

        public Boolean DisplayQuery()
        {
            if (Display == false)
                return true;
            return false;
        }

        public Boolean GeneratorQuery()
        {
            if (Generated == false)
                return true;
            return false;
        }

        public void DisplayRegister()
        {
            Display = true;
        }

        public void GeneratorRegister()
        {
            Generated = true;
        }

        public Boolean Validation()
        {
            if (Answer == Response)
                return true;
            return false;
        }

        public void AnswerLoad(string _question, string _option1, string _option2, string _option3, string _option4, int _answer)
        {
            Question = _question;
            option1 = _option1;
            option2 = _option2;
            option3 = _option3;
            option4 = _option4;
            Answer = _answer;
        }

        public string QuestionQuery()
        {
            return Question;
        }

        public string OptionQuery1()
        {
            return option1;
        }
        public string OptionQuery2()
        {
            return option2;
        }
        public string OptionQuery3()
        {
            return option3;
        }
        public string OptionQuery4()
        {
            return option4;
        }
        public int AnswerQuery()
        {
            return Answer;
        }

        public void ResponseRegister(int _response)
        {
            Response = _response;
        }

        public int ResponseQuery()
        {
            return Response;
        }
    }
}