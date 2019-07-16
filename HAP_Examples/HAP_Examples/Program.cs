using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAP_Examples
{
    class Program
    {
        static void Main(string[] args)
        {









            
            var html = @"
                <td>
                </td>
                <td>
                <input value = 'Technology'>
                <input value = 'Crowds'>
                </td>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            /*
            // SELECT ALL NODES that match with the expressions of the type 
            var nodes = htmlDoc.DocumentNode.SelectNodes("//td/input");

            foreach (var node in nodes)
            {
                Console.WriteLine(node.Attributes["value"].Value);
            }
            */

            
            // SELECT FIRST NODE that matches the given XPath expression
            var node = htmlDoc.DocumentNode.SelectNodes("//td/input").First()
                .Attributes["value"].Value;
            Console.WriteLine(node);
            
            
            /*
            // Loading html as document and getting innertext
            string url = "https://technologycrowds.com";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = new HtmlDocument();
            doc = web.Load(url);
            */
            Console.ReadLine();
        }
    }
}
