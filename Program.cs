using System;
using System.IO;
using System.Text;
namespace Program1
{
    class Program
    {

        private const string __NamesFile = "Strings1.txt";
        static void Main(string[] args)
        {
            
            using (StreamReader names_reader = new StreamReader(__NamesFile))
            {
                while (!names_reader.EndOfStream)
                {
                    var line = names_reader.ReadLine();

                    string[] words = line.Split(new string[] { " ", "\r\n", "\t" }, StringSplitOptions.RemoveEmptyEntries);
                    string maxl = "";
                    for (int i = 0; i < words.Length; i++)
                    {
                        //Console.WriteLine(words[i].Length);
                        if (maxl.Length < words[i].Length) maxl = words[i];
                    }
                    //Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("Самое длинное слово: ");
                    Console.WriteLine(maxl);
                    //Console.WriteLine(line);
                }
                
                //names_reader.Close();
                //names_reader.Dispose();
            }
           
            

            Console.WriteLine("Нажмите для выхода Enter");
            Console.ReadLine();

        }
    }
}

