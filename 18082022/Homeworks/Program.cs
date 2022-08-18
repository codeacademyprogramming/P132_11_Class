using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -55;
            MakePositive(ref num);
            Console.WriteLine(num);

            string word = Console.ReadLine();

            DeleteSapace(ref word);
            Console.WriteLine(word);


        }

        static void DeleteSapace(ref string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]!=' ')
                    newStr += str[i];
            }

            str = newStr;
        }


        static void MakePositive(ref int num)
        {
            if (num < 0)
            {
                num *= -1; //num=num*-1
            }
        }


    }
}
