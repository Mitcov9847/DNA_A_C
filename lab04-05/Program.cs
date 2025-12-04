
using System;

namespace Lab5
{
    struct Prices
    {
        public int Drink;
        public int First;
        public int Second;
    }

    struct Choices
    {
        public int Drink;
        public int First;
        public int Second;
    }

    class Program
    {
        static int CustomerTotal(Prices prices, Choices choices)
        {
            return choices.Drink * prices.Drink +
                   choices.First * prices.First +
                   choices.Second * prices.Second;
        }

     static void Main(string[] args)
        {
            Prices prices = new Prices { Drink = 10, First = 20, Second = 30 };

            Choices client1 = new Choices { Drink = 1, First = 0, Second = 2 };
            Choices client2 = new Choices { Drink = 0, First = 3, Second = 1 };
         
            Console.WriteLine($"Клиент 1: {CustomerTotal(prices, client1)} единиц стоимости");
            Console.WriteLine($"Клиент 2: {CustomerTotal(prices, client2)} единиц стоимости");

        }
    }
}
