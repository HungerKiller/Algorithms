using System;

namespace AlgoLearning.Recursive
{
    //河内塔
    public class TowerOfHanoi
    {
        public static void hanoi(int n, int p1, int p2, int p3)
        {
            if (1 == n)
                Console.WriteLine("盘子从" + p1 + "移到" + p3);
            else
            {
                hanoi(n - 1, p1, p3, p2);
                Console.WriteLine("盘子从" + p1 + "移到" + p3);
                hanoi(n - 1, p2, p1, p3);
            }
        }
    }
}
