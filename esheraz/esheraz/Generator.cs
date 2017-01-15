using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esheraz
{
    class Generator
    {
        private string poslednee = "";
        private string TextChatika = "Denis: Привет!";
        
        private string[] otvet = {"У меня все очень плохо :(", "Нихрена не получается с этим дурацким чатиком, но давай не будем об этом)", "Очень надеюсь, что сейчас я сплю", "Я целый день думал, как написать это все", "У меня офигенные новые керзачи!", "А вот сейчас я не понял о чем ты","Не надо со мной здороваться, я только на опросы отвечаю" };
        
        public int GenerateAnswer(string soobshenie)
        {
            poslednee = soobshenie;
            if (soobshenie.Contains("ак дела"))
                return 0;
            if (soobshenie.Contains("очему"))
                return 1;
            if (soobshenie.Contains("делаешь"))
                return 2;
            if (soobshenie.Contains("прошел день"))
                return 3;
            if (soobshenie.Contains("нового"))
                return 4;
            if (soobshenie.Contains("ривет"))
                return 6;
            else
                return 5;
        }
        public string AddAnswer(int NomerOtveta)
        {
            
            return TextChatika += "\r\nТы: " + poslednee + "\r\nDenis: " + otvet[NomerOtveta];
            
        }
    }
}
