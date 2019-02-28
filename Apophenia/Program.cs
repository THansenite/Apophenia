using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace Apophenia
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;
            string url = "https://dmyha.pucksystems2.com/game/game_sheet/22772996";
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                result = reader.ReadToEnd();

                HtmlDocument pageDocument = new HtmlDocument();
                pageDocument.LoadHtml(result);

                Console.WriteLine("Home Team: " + pageDocument.DocumentNode.SelectSingleNode("//*[@id=\"home_team_name\"]").InnerText);
                Console.WriteLine("Away Team: " + pageDocument.DocumentNode.SelectSingleNode("//*[@id=\"away_team_name\"]").InnerText);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (response != null)
                {
                    reader.Close();
                }
            }

            //Console.Write(result);
            Console.ReadKey();
        }
    }
}
