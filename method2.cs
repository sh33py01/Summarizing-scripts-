using System;
using System.Net;
using System.Text.RegularExpressions;

namespace URLTextSummarizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if the URL is provided
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: URLTextSummarizer.exe URL");
                return;
            }

            // Download the text from the URL
            string text = new WebClient().DownloadString(args[0]);

            // Split the text into sentences
            string[] sentences = Regex.Split(text, @"(?<=[.?!])\s+(?=[a-zA-Z])");

            // Keep sentences that have more than 20 words
            int count = 0;
            foreach (string sentence in sentences)
            {
                if (sentence.Split().Length >= 20)
                {
                    Console.WriteLine(sentence);
                    count++;
                    if (count == 10) break;
                }
            }
        }
    }
}
