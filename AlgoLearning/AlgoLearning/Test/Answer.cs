using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgoLearning.Test
{
    public class Answer
    {
        public static bool Exists(int[] ints, int k)
        {
            /*foreach(var i in ints)
            {
                if(i == k)
                    return true;
            }
            return false;*/

            int start = 0;
            int end = ints.Length;
            int tmpIndex = 0;
            while (start < end)
            {
                if (tmpIndex == (end - start) / 2 + start)
                    break;
                tmpIndex = (end - start )/ 2 + start; // TODO
                if (ints[tmpIndex] > k)
                {
                    end = tmpIndex;
                }
                else if (ints[tmpIndex] < k)
                {
                    start = tmpIndex;
                }
                else
                    return true;
            }
            return false;
        }
    }
}
