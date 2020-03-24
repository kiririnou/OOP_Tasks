using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;

namespace Streams
{
    class Seeker
    {
        public static void Run()
        {
            Console.WriteLine("Task 2");

            string file_in = "regex_in.txt";
            string file_out = "regex_out.txt";
            string buffer = "";

            Console.WriteLine($"Start reading from {file_in}...");
            using (StreamReader sr = new StreamReader(file_in))
                buffer = sr.ReadToEnd();
            Console.WriteLine("Done.");

            string email = @"(\w+\d*\@\w+\.\w{2,3})";
            string url = @"((?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+)";
            string ip_addr = @"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
            string phone_number = @"([+]*\d{2}-\d{3}-\d{3}-\d{2}-\d{2})|([+]*\d{12})|([+]*\d{3}-\d{3}-\d{2,3}-\d{2,3})|(\d{10})";

            Console.WriteLine("Start searching...");
            string pattern = email + "|" + url + "|" + ip_addr + "|" + phone_number;
            MatchCollection results = Regex.Matches(buffer, pattern);
            List<string> tokens = results.Cast<Match>().Select(match => match.Value).ToList();
            Console.WriteLine("Done.");

            tokens.Sort();

            Console.WriteLine($"Start writing into {file_out}...");
            using (StreamWriter sw = new StreamWriter(file_out))
                foreach (var token in tokens)
                    sw.WriteLine(token);
            Console.WriteLine("Done.");
        }
    }
}
