using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class ArrayInput
    {
        public static int[] TurnInputToArray(string input)
        {
         
          string[] arrString = input.Split(",");

            int[] arr = new int[arrString.Length];

            for(int i = 0; i <  arrString.Length; i++)
            {
                arr[i] = Convert.ToInt32(arrString[i]);
            }
            return arr;
        }

        public static int OperateOnArray(int[] input)
        {
            int response = 0;
            foreach(int i in input)
            {
                if(i % 2 == 0)
                {
                    response += 1;
                }
                else
                {
                    response += 3;
                }

                if(i == 8)
                {
                    response += 5;
                }


            }

            return response;
        }
       
    }
}
