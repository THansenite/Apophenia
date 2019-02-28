using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Apophenia.Parsers
{
    public class ScheduleParser
    {
        string result = null;
        string url = "https://dmyha.pucksystems2.com/game/game_sheet/22772996";
        WebResponse response = null;
        StreamReader reader = null;


        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //request.Method = "GET";
        //        response = request.GetResponse();
        //        reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
        //result = reader.ReadToEnd();
    }
}
