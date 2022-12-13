using System.Collections;

namespace AoC1;

public class Elf
{
    public List<int> calorieList;

    public Elf()
    {
        calorieList = new List<int>();
    }

    public int GetCalorieCount()
    {
        int calorieCount = 0;
        foreach (var item in calorieList)
        {
            calorieCount += item;
        }

        return calorieCount;
    }
}