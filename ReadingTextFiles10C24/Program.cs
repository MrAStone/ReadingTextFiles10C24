using System.IO;
using System.Text.RegularExpressions;
namespace ReadingTextFiles10C24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileToRead = new StreamReader("U:/greenEggsAndHam.txt");
            string txt =fileToRead.ReadToEnd(); // read entire contents
           
                   txt = txt.ToUpper();
            int letterCount = 0;
            int spaceCount = 1;
            foreach(char c in txt)
            {
                if(c == ' ')
                {
                    spaceCount++;
                }
                if(Convert.ToInt32(c) >= 65 && Convert.ToInt32(c) <= 90)
                {
                    letterCount++;
                }
            }
            Console.WriteLine($"{letterCount} letters in {spaceCount} words");
            //Console.WriteLine(txt);
            //do
            //{
            //    Console.WriteLine(fileToRead.ReadLine());
            //}while(!fileToRead.EndOfStream);
        }
    }
}
