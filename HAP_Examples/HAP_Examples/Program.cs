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
            var html =
                @"<body>
                <h1>.Net Core</h1>
                <p>
                This is <b>C#, ASP.Net</b> paragraph
                </p>
                <h1>.Net Core with Angular</h1>
                <p>
                This is <b>HTML Agility Pack</b> sample
                </p>
                </body>";


            /*
            var html = @"
                <td>
                </td>
                <td>
                <input value = 'Technology'>
                <input value = 'Crowds'>
                </td>
                <td>
                <span> Can I get this?
                </span>
                </td>";
            */

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//body/p");


            // Gets InnerHTML content present within the boundaries of opening 
            // and closing tags of the mentioned HTML object
            Console.WriteLine("InnerHtml: ");
            foreach (var node in htmlNodes)
                Console.WriteLine(node.InnerHtml);

            // InnerText gets text between the opening and closing tags of 
            // the desired HTML object
            Console.WriteLine("InnerText: ");
            foreach (var node in htmlNodes)
                Console.WriteLine(node.InnerText);

            // OuterHtml get the object as well as the contents inside
            Console.WriteLine("OuterHtml: ");
            foreach (var node in htmlNodes)
                Console.WriteLine(node.OuterHtml);


            var headerNodes = htmlDoc.DocumentNode.SelectNodes("//body/h1");
            Console.WriteLine("Header Nodes OuterHtml" +
                ": ");
            foreach (var node in headerNodes)
                Console.WriteLine(node.OuterHtml);


            // Get parent node
            var parent = htmlDoc.DocumentNode.SelectSingleNode("//body/h1");

            HtmlNode parentNode = parent.ParentNode;
            Console.WriteLine($"The name of the parent node is: {parentNode.Name}");

            /*
            // SELECT ALL NODES that match with the expressions of the type 
            var nodes = htmlDoc.DocumentNode.SelectNodes("//td/input");

            foreach (var node in nodes)
            {
                Console.WriteLine(node.Attributes["value"].Value);
            }
            */


            /*
            // SELECT FIRST NODE that matches the given XPath expression
            //var node = htmlDoc.DocumentNode.SelectNodes("//td/input").First()
            //    .Attributes["value"].Value;
            var node = htmlDoc.DocumentNode.SelectSingleNode("//td/span");
            Console.WriteLine(node.InnerText);
            */


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
