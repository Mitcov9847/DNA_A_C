using System;

class Program
{
    static void Main()
    {
        // Функция B
        void B()
        {
            Console.WriteLine("B");
        }

        // Функция C
        void C()
        {
            Console.WriteLine("C");
        }

        // Функция A вызывает B и C
        void A()
        {
            Console.WriteLine("A");
            B();
            C();
        }

        // Вызов функции A несколько раз
        A();
        A();
    }
}

