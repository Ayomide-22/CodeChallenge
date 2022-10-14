using System;

namespace _2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check");
            double num=double.Parse(Console.ReadLine());
            double[] arr=new double[3];
            double mid=0;
            double x=Math.Pow(10,15);
            if(num>=x||num<=0)
            {
                Console.WriteLine(num+" is out of bounds");
            }
            else if(num%3==0)
            {
                mid=num/3;
                arr[0]=mid-1;
                arr[1]=mid;
                arr[2]=mid+1;
                foreach (var item in arr)
                {
                    Console.Write(item+" ");
                }
                Console.Write("add up to "+num);
            }
            else
            {
                Console.WriteLine("There aren't any three consecutive numbers that add up to "+num);
            }
        }
    }
}
