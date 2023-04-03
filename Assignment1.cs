using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            arrayEvenOdd();
            calculator();
            validate();
            userArray();
        }

        private static void arrayEvenOdd()
        {
            Console.WriteLine("enter the size of array");
            int size=Convert.ToInt32(Console.ReadLine());
            int[] array=new int[size];
            for(int i=0; i<size; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("even elements are:");
            for (int i=0; i < size; i++)
            {
                if (array[i]%2== 0)
                {
                    Console.WriteLine(array[i]+" ");
                }
            }
            Console.WriteLine("odd elements are:");
            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
        private static void userArray()
        {
        Console.WriteLine("enter the dataype to be inserted");
         string dt=Console.ReadLine();
        Console.WriteLine("enter the size of array");
         int size = Convert.ToInt32(Console.ReadLine());
        if(dt=="int"){
                int[] arr=new int[size];
        for(int i = 0; i < size; i++)
                {
                    arr[i]=Convert.ToInt32(Console.ReadLine());
                }
        }
            if (dt == "float")
            {
                float[] arr = new float[size];
                for (int i = 0; i < size; i++)
                {
                    arr[i] = (float)Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        static void calculator()
        {
            
            int n = 0;
            Console.WriteLine("enter the no of attempts");
            int noOfAttempt = Convert.ToInt32(Console.ReadLine());
            while (n<noOfAttempt)
            {
                Console.WriteLine("enter the first number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the operation to be performed ");
                char operate = Convert.ToChar(Console.ReadLine());
                switch (operate)
                {
                    case '+':
                        Console.WriteLine(num1 + num2);
                        break;
                    case '-':
                        Console.WriteLine(num1 - num2);
                        break;
                    case '*':
                        Console.WriteLine(num1 * num2);
                        break;
                    case '/':
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("invalid operation ");
                        break;
                }
                n++;
            }
        }
        private static void validate()
        {
            Console.WriteLine("enter the date of joining in the form of dd-MM-yy");
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date.Month > 13)
            {
                Console.WriteLine("invalid");
            }
            else if (date.Month == 2 && date.Day > 28)
            {
                Console.WriteLine("invalid");
            }
            else if(date.Year< 2000 & date.Year>2050)
            {
                Console.WriteLine("invalid");
            }
            else if(date.Day > 31)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine("valid date");
            }
            
        }
    
    }
}
