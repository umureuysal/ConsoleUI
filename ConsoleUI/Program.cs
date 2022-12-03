using HtmlAgilityPack;
using System;
using System.Net;
using System.Xml;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Uri url = new Uri("https://www.sahibinden.com/");
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;//Türkçe karakterler için
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);
            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//a");
            foreach (var node in nodes)
            {
                string link = node.Attributes["href"].Value;
                Console.WriteLine(node.ToString);
            }
        }

    }
}


