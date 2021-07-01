using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "姜賢雨";

        char[] charArr = s.ToCharArray();

        foreach (char c in charArr)
        {
            if ((c >= 0x4E00 && c <= 0x9FFF))
            {
                Console.WriteLine("이것은 한자여!");
            }
            else
            {
                Console.WriteLine("이것은 아니여!");
            }
        }

        Console.Read();
    }
}