using HtmlAgilityPack;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Hurriyet:IAltin, IDoviz
    {
        public static List<decimal> Altin()
        {
            List<decimal> altinAlisSatis = new List<decimal>();
            WebClient client = new WebClient();
            string html = client.DownloadString("https://bigpara.hurriyet.com.tr/altin/");
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNodeCollection resultGramAlis = doc.DocumentNode.SelectNodes("//*[@id='content']/div[2]/div/div[1]/a[1]/span[2]/span[2]");
            HtmlNodeCollection resultGramSatis = doc.DocumentNode.SelectNodes("//*[@id='content']/div[2]/div/div[1]/a[1]/span[3]/span[2]");
            HtmlNodeCollection resultCeyrekAlis = doc.DocumentNode.SelectNodes("//*[@id='content']/div[2]/div/div[1]/a[2]/span[2]/span[2]");
            HtmlNodeCollection resultCeyrekSatis = doc.DocumentNode.SelectNodes("//*[@id='content']/div[2]/div/div[1]/a[2]/span[3]/span[2]");

            altinAlisSatis.Add(Convert.ToDecimal(resultGramAlis[0].InnerText));
            altinAlisSatis.Add(Convert.ToDecimal(resultGramSatis[0].InnerText));
            altinAlisSatis.Add(Convert.ToDecimal(resultCeyrekAlis[0].InnerText));
            altinAlisSatis.Add(Convert.ToDecimal(resultCeyrekSatis[0].InnerText));

            return altinAlisSatis;
        }

        public static List<decimal> Doviz
        {
            get
            {
                List<decimal> dovizAlisSatis = new List<decimal>();
                WebClient client = new WebClient();
                string html = client.DownloadString("https://bigpara.hurriyet.com.tr/doviz/");
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                HtmlNodeCollection resultDolarAlis = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div/div[1]/a[1]/span[2]/span[2]");
                HtmlNodeCollection resultDolarSatis = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div/div[1]/a[1]/span[3]/span[2]");
                HtmlNodeCollection resultEuroAlis = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div/div[1]/a[2]/span[2]/span[2]");
                HtmlNodeCollection resultEuroSatis = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div/div[1]/a[2]/span[3]/span[2]");
                HtmlNodeCollection resultSterlinAlis = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div/div[1]/a[3]/span[2]/span[2]");
                HtmlNodeCollection resultSterlinSatis = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[2]/div/div[1]/a[3]/span[3]/span[2]");


                dovizAlisSatis.Add(Convert.ToDecimal(resultDolarAlis[0].InnerText));
                dovizAlisSatis.Add(Convert.ToDecimal(resultDolarSatis[0].InnerText));
                dovizAlisSatis.Add(Convert.ToDecimal(resultEuroAlis[0].InnerText));
                dovizAlisSatis.Add(Convert.ToDecimal(resultEuroSatis[0].InnerText));
                dovizAlisSatis.Add(Convert.ToDecimal(resultSterlinAlis[0].InnerText));
                dovizAlisSatis.Add(Convert.ToDecimal(resultSterlinSatis[0].InnerText));
                return dovizAlisSatis;
            }
        }
    }
}
