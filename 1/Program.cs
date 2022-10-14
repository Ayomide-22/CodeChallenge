using System;

namespace Al_Ameen_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int length=int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter number at index "+ i);
                arr[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter number to check in array");
            int original = int.Parse(Console.ReadLine());
            int x= original;
            for(int j=0;j<length;j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if(original == arr[i])
                    {
                        original = original*2;
                    }
                }
            }
            if(original==x)
            {
                Console.WriteLine($"{original} is not found in the array");
            }
            else
            {
                Console.WriteLine(original+" is the final number");
            }
        }
    }
}
