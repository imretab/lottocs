using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace prog2._0
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Title = "Lotto program";
            Console.CursorVisible = false;
            int[] nums = new int[5];
            Random r = new Random();
            Boolean mehet = true;
            for (int i = 0; i < nums.Length; i++)
            {
                int sorsol = r.Next(1, 91);
                int j = 0;
                while (j<i && mehet==true)
                {
                    if (nums[j]==sorsol)
                    {
                        mehet = false;
                    }
                    else
                    {
                        mehet = true;
                        j++;
                    }
                }
                if (mehet == true)
                {
                    nums[i] = sorsol;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("Numbers: ");
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write("{0} ", nums[k]);
            }
            for (int i = nums.Length-1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        int csere = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = csere;
                    }
                }
            }
            Console.WriteLine("\nSorted: ");
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
