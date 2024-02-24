using System;

namespace HackerRank.Solutions
{
    public class TowerOfHanoi
    {
        public void Execute(int n, char sourceRod, char targetRod, char helperRod)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from {sourceRod} rod to {targetRod}");
                return;
            }

            Execute(n - 1, sourceRod, helperRod, targetRod);

            Console.WriteLine($"Move disk {n} from rod {sourceRod} to {targetRod}");

            Execute(n-1, helperRod, targetRod, sourceRod);
        }

    }
}
