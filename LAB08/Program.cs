struct Book
{
    public string Title;
    public int Year;
    public bool IsBorrowed;
}

class Program
{
    // Функция для просмотра всех книг
    static void ViewAll(Book[] books)
    {
        Console.WriteLine("\nСписок книг библиотеки:");

        foreach (var book in books)
        {
            // Проверяем статус книги и выводим
            string status = book.IsBorrowed ? "взята" : "в наличии";
            Console.WriteLine($"{book.Title} ({book.Year}) - {status}");
        }

        Console.WriteLine();
    }

    // Функция для взятия книги
    static void Borrow(Book[] books, string title)
    {
        bool bookFound = false;

        for (int i = 0; i < books.Length; i++)
        {
            // Ищем книгу по названию (без учета регистра)
            if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                bookFound = true;
                if (!books[i].IsBorrowed)
                {
                    // Меняем статус на "взята"
                    books[i].IsBorrowed = true;
                    Console.WriteLine($"Книга '{books[i].Title}' успешно взята.\n");
                }
                else
                {
                    Console.WriteLine($"Книга '{books[i].Title}' уже была взята.\n");
                }
                break;
            }
        }

        if (!bookFound)
            Console.WriteLine("Ошибка: книги с таким названием нет.\n");
    }

    // Функция для возвращения книги
    static void Return(Book[] books, string title)
    {
        bool bookFound = false;

        for (int i = 0; i < books.Length; i++)
        {
            // Ищем книгу по названию
            if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                bookFound = true;
                if (books[i].IsBorrowed)
                {
                    // Меняем статус на "в наличии"
                    books[i].IsBorrowed = false;
                    Console.WriteLine($"Книга '{books[i].Title}' успешно возвращена.\n");
                }
                else
                {
                    Console.WriteLine($"Книга '{books[i].Title}' уже находится в библиотеке.\n");
                }
                break;
            }
        }

        if (!bookFound)
            Console.WriteLine("Ошибка: книги с таким названием нет.\n");
    }

    // Главное меню программы
    static void Menu(Book[] books)
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 — Показать все книги");
            Console.WriteLine("2 — Взять книгу");
            Console.WriteLine("3 — Вернуть книгу");
            Console.WriteLine("0 — Выход");
            Console.Write("Выберите опцию: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ViewAll(books); // Показать все книги
                    break;

                case "2":
                    Console.Write("Введите название книги: ");
                    Borrow(books, Console.ReadLine()); // Взять книгу по названию
                    break;

                case "3":
                    Console.Write("Введите название книги: ");
                    Return(books, Console.ReadLine()); // Вернуть книгу по названию
                    break;

                case "0":
                    Console.WriteLine("Выход...");
                    return; // Завершаем программу

                default:
                    Console.WriteLine("Неизвестная команда.\n");
                    break;
            }
        }
    }

    static void Main()
    {
        // Создаем массив из 5 книг библиотеки
        Book[] books = new Book[]
        {
            new Book { Title = "Восстание Мстителей", Year = 2015 },
            new Book { Title = "Паук-версия",        Year = 2014 },
            new Book { Title = "Секретные войны",    Year = 2015 },
            new Book { Title = "Старик Логан",       Year = 2008 },
            new Book { Title = "Железный человек: Демон в бутылке", Year = 1979 }
        };

        Menu(books); // Запускаем меню программы
    }
}
