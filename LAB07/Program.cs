/*
Алгоритм

1. Создать два списка чисел одинаковой длины — a и b.

2. Проверить, что длины списков совпадают.
   Если нет — вывести сообщение об ошибке и завершить программу.

3. Создать список result такой же длины, чтобы записывать туда суммы элементов.

4. Использовать цикл while для попарного сложения элементов.
   Пока индекс не превышает длину массива, брать элементы по одному, складывать и записывать в result.

5. После завершения цикла вывести результат, полученный через while.

6. Использовать цикл for для повторного попарного сложения.
   На каждом шаге брать элементы по индексу, складывать и записывать в result.

7. Вывести результат, полученный через for.

8. Завершить работу программы.
*/

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 5, 6, 7, 8 };

        // Проверка на равную длину
        if (a.Length != b.Length)
        {
            Console.WriteLine("Длины массивов должны совпадать");
            return;
        }

        // Массив для записи результата
        int[] result = new int[a.Length];

        // Сложение с помощью while
        SumPairwiseWhile(a, b, result);
        Console.WriteLine("Результат (while): " + string.Join(" ", result));

        // Сложение с помощью for
        SumPairwiseFor(a, b, result);
        Console.WriteLine("Результат (for): " + string.Join(" ", result));
    }

    // Алгоритм попарного сложения с while
    static void SumPairwiseWhile(int[] a, int[] b, int[] result)
    {
        int i = 0;

        while (i < a.Length)
        {
            result[i] = a[i] + b[i];
            i++;
        }
    }

    // Алгоритм попарного сложения с for
    static void SumPairwiseFor(int[] a, int[] b, int[] result)
    {
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] + b[i];
        }
    }
}
