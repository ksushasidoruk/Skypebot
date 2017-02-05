using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esheraz
{
    class Generator
    {
        private string lastMessage = "";
        private string TextChatika = "Denis: Привет!";
        
        private string[] answers = {"У меня все очень плохо :(", "Нихрена не получается с этим дурацким чатиком, но давай не будем об этом)", "Очень надеюсь, что сейчас я сплю", "Я целый день думал, как написать это все", "У меня офигенные новые керзачи!", "А вот сейчас я не понял о чем ты","Не надо со мной здороваться, я только на опросы отвечаю" };
        
        public int GenerateAnswer(string message)
        {
            lastMessage = message;
            if (message.Contains("ак дела"))
                return 0;
            if (message.Contains("очему"))
                return 1;
            if (message.Contains("делаешь"))
                return 2;
            if (message.Contains("прошел день"))
                return 3;
            if (message.Contains("нового"))
                return 4;
            if (message.Contains("ривет"))
                return 6;
            else
                return 5;
        }
        public string AddAnswer(int answerNumber)
        {
            
            return TextChatika += "\r\nТы: " + lastMessage + "\r\nDenis: " + answers[answerNumber];
            
        }
    }
}
