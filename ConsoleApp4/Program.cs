using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {

            Money money = new Money(9);
            money.GenerateArray(money);
            money.PrintArray(money);
            money[3] = 5;
            Console.WriteLine("Changed");
            money.PrintArray(money);

            Console.ReadLine();
        }
    }

    public class Money
    {
        private  Random _random = new Random();
        public int[] Currency { get; set; }
        public int Length { get; set; }

        public Money(int length)
        {
            Currency = new int[length];
            Length = length;
            
        }
        public int this[int index]
        {
            get => Currency[index];
            set
            {
                if(index<Length)
                Currency[index] =  (int) Math.Pow(value, 2);
                else throw new IndexOutOfRangeException($"Индекс вышел за пределы листа \nРазмер листа{Length}\nВаш индекс {index}");
            }
        }
        public void GenerateArray(Money value)
        { 
            for (int i = 0; i < Length; i++)
            {
                value[i] = _random.Next(1, 10);
            }
        }
        public void PrintArray(Money array)
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        } 
    }
}
