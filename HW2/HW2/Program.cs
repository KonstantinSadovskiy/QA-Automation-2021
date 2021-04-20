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

        static void CutOffStringWithRepeatedSymbol(ref string str, ref int index)
        {
            index = 1 + str.IndexOf(str[index]);
            str = str.Substring(index);
            index = 0;
        }
        static void ResetIfCharEqual(ref string str, ref string tempArr, ref int index, ref int tempCount)
        {
            for (int j = 0; j < tempArr.Length; j++)
            {
                if (tempArr[j] == str[index])
                {
                    tempCount = 1;

                    CutOffStringWithRepeatedSymbol(ref str, ref index);

                    tempArr = "";

                    break;
                }
            }
        }
        static int Consecutive(string str)
        {
            int maxCount = 0;
            int tempCount = 1;

            for(int i = 1; i < str.Length; i++) 
            {
                tempCount++;

                if (str[i - 1] == str[i]) //reset
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

                ResetIfCharEqual(ref str, ref tempArr, ref i, ref tempCount);

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
