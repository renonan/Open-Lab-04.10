using System;
using System.Linq;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            int result = nums.Sum();
            float resultfinal =(float)result/nums.Length;
            return resultfinal;
        }
    }
}
