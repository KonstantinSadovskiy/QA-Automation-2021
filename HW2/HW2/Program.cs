using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consecutive: " + Consecutive(args[0]));
            Console.WriteLine("NonConsecutive: " + NonConsecutive(args[0]));
        }

        static int Consecutive(string str)
        {
            int maxCount = 0;
            int tempCount = 1;

            for(int i = 1; i < str.Length; i++) //122315655458
            {
                tempCount++;

                if (str[i - 1] == str[i])
                {
                    tempCount = 1;
                }

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                }
            }

            return maxCount;
        }

        static int NonConsecutive(string str)
        {
            int maxCount = 0;
            int tempCount = 1;
            string tempArr = "";

            int i = 1;
            do
            {
                tempCount++;

                tempArr = tempArr.Insert(0, str[(i - 1)..i]);

                for (int j = 0; j < tempArr.Length; j++)
                {
                    if (tempArr[j] == str[i])
                    {
                        tempCount = 1;

                        i = 1 + str.IndexOf(str[i]);
                        str = str.Substring(i);
                        i = 0;

                        tempArr = "";

                        break;
                    }
                }

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                }

                i++;
            }
            while (i < str.Length);

            return maxCount;
        }
    }
}
