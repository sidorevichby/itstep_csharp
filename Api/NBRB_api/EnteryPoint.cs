using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Net;

namespace NBRB_api
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("usd", 145);
            dictionary.Add("eur", 292);

            Console.WriteLine("Enter currency code (usd, eur):");
            string enter = Console.ReadLine();

            Rate currency = new Rate();
            currency.Cur_ID = dictionary[enter.ToLower()];
            string json = new WebClient().DownloadString($"https://www.nbrb.by/api/exrates/rates/{currency.Cur_ID}");

            currency = JsonSerializer.Deserialize<Rate>(json);
            Console.WriteLine($"{currency.Cur_Name} : 1 {currency.Cur_Abbreviation} = {currency.Cur_OfficialRate} BYN");
        }
    }
}
