using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SherenkovIR.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int sumArray = 1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)  
                {
                   sumArray  *= array[i];
                }
            }
            return sumArray;
        }
    }
}
