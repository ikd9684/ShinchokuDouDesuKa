using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jp._9684.sandbox.ShinchokuDouDesuKa
{
    class ShinchokuDouDesuKa
    {
        static void Main(string[] args)
        {
            try
            {
                mainProcess();
            }
            catch (Exception e)
            {
                Exception ie = e;
                do
                {
                    Console.WriteLine(ie);
                    ie = ie.InnerException;
                }
                while (ie != null);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("何かキーを押してください。");
                Console.ReadKey();
            }
        }

        static void mainProcess()
        {
            string[] words
                = {
                      "進捗", "どう", "です", "か",
                  };

            int totalWordCount = 0;
            int matchNumber = 0;
            Random rnd = new Random();

            while (matchNumber < words.Length)
            {
                string word = words[rnd.Next(4)];
                Console.Write(word);
                totalWordCount += word.Length;
                matchNumber = (word == words[matchNumber]) ? matchNumber + 1 : 0;
            }

            Console.WriteLine("？？？");
            Console.WriteLine("{0}文字で煽られました。", totalWordCount);
        }

    }
}
