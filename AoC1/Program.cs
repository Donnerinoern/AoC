using System.Collections;

namespace AoC1
{
    class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("/home/donnan/RiderProjects/AoC/AoC1/input.txt");
            int itemCalorieCount = 0;
            int elfCalorieCount = 0;
            ArrayList itemList = new ArrayList();
            int currentMax = 0;
            int secondMax = 0;
            int thirdMax = 0;
            foreach (var line in lines)
            {
                if (line != "")
                {
                    itemCalorieCount = int.Parse(line);
                    itemList.Add(itemCalorieCount);
                }
                else
                {
                    foreach (int item in itemList)
                    {
                        elfCalorieCount += item;
                    }
                    if (elfCalorieCount > currentMax)
                    {
                        thirdMax = secondMax;
                        secondMax = currentMax;
                        currentMax = elfCalorieCount;
                        
                    } else if (elfCalorieCount > secondMax)
                    {
                        thirdMax = secondMax;
                        secondMax = elfCalorieCount;
                    } else if (elfCalorieCount > thirdMax)
                    {
                        thirdMax = elfCalorieCount;
                    }
                    elfCalorieCount = 0;
                    itemList.Clear();
                }
            }
            Console.WriteLine(currentMax);
            Console.WriteLine(secondMax);
            Console.WriteLine(thirdMax);
            Console.WriteLine(currentMax + secondMax + thirdMax);
        }
    }
}