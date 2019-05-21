using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanRates
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = @"https://www.hfcu.org/rates.html";

            HtmlWeb web = new HtmlWeb();

            HtmlDocument htmlDoc = web.Load(html);

            List<string> loanList = new List<string>();

            HtmlNodeCollection table = htmlDoc.DocumentNode.SelectNodes("//table[1]//tr//td");
            //*[@id="ca_panel_1"]/table[1]/tbody/tr[2]/td[1]
         
            //HtmlNodeCollection rowsNodesList = htmlDoc.DocumentNode.SelectNodes("//table[contains(@class, 'rateprogram')]//tr");

            
            foreach (var row in table)
            {
                var cells = row.SelectNodes("td");
                Console.WriteLine("row data: " + row.InnerText);

                if (cells != null && cells.Count > 0)
                {
                    Console.WriteLine("cell 1: ", cells[0].InnerText);
                    Console.WriteLine("cell 2: ", cells[1].InnerText);

                }
                
            }
            

            Console.ReadLine();
        }
    }
}
