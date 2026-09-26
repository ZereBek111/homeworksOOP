using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\n=== МЕНЮ ЗАДАЧ ===");
            Console.WriteLine("1. Чётные и нечётные числа");
            Console.WriteLine("2. Второе максимальное число");
            Console.WriteLine("3. Удаление дубликатов");
            Console.WriteLine("4. Переворот массива");
            Console.WriteLine("5. Подсчёт символов");
            Console.WriteLine("6. Самое длинное слово");
            Console.WriteLine("7. Палиндром");
            Console.WriteLine("8. Простые числа");
            Console.WriteLine("9. Угадай число");
            Console.WriteLine("10. Банкомат");
            Console.WriteLine("11. Калькулятор с методами");
            Console.WriteLine("12. Статистика оценок");
            Console.WriteLine("13. Частота слов");
            Console.WriteLine("14. Телефонная книга");
            Console.WriteLine("15. Класс Student");
            Console.WriteLine("16. Класс BankAccount");
            Console.WriteLine("17. Система товаров");
            Console.WriteLine("18. Сортировка без Sort()");
            Console.WriteLine("19. Камень, ножницы, бумага");
            Console.WriteLine("20. Мини-система авторизации");
            Console.WriteLine("0. Выход");
            Console.Write("Выбор: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": Task1(); break;
                case "2": Task2(); break;
                case "3": Task3(); break;
                case "4": Task4(); break;
                case "5": Task5(); break;
                case "6": Task6(); break;
                case "7": Task7(); break;
                case "8": Task8(); break;
                case "9": Task9(); break;
                case "10": Task10(); break;
                case "11": Task11(); break;
                case "12": Task12(); break;
                case "13": Task13(); break;
                case "14": Task14(); break;
                case "15": Task15(); break;
                case "16": Task16(); break;
                case "17": Task17(); break;
                case "18": Task18(); break;
                case "19": Task19(); break;
                case "20": Task20(); break;
                case "0": return;
                default: Console.WriteLine("Неверный выбор"); break;
            }
        }
    }

    // 1. Чётные и нечётные числа
    static void Task1()
    {
        int[] nums = new int[10];
        Console.WriteLine("Введите 10 чисел:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"[{i + 1}]: ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        var even = nums.Where(n => n % 2 == 0).ToArray();
        var odd = nums.Where(n => n % 2 != 0).ToArray();
        Console.WriteLine("Чётные: " + string.Join(" ", even));
        Console.WriteLine("Нечётные: " + string.Join(" ", odd));
        Console.WriteLine($"Количество чётных: {even.Length}, нечётных: {odd.Length}");
    }

    // 2. Второе максимальное число
    static void Task2()
    {
        int[] arr = { 10, 5, 8, 20, 15, 20, 3 };
        int first = int.MinValue, second = int.MinValue;
        foreach (var n in arr)
        {
            if (n > first) { second = first; first = n; }
            else if (n > second && n != first) second = n;
        }
        Console.WriteLine("Массив: " + string.Join(" ", arr));
        Console.WriteLine("Второе максимальное: " + second);
    }

    // 3. Удаление дубликатов
    static void Task3()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
        var unique = new List<int>();
        foreach (var n in arr)
            if (!unique.Contains(n)) unique.Add(n);
        Console.WriteLine("Массив: " + string.Join(" ", arr));
        Console.WriteLine("Без дубликатов: " + string.Join(" ", unique));
    }

    // 4. Переворот массива
    static void Task4()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Исходный: " + string.Join(" ", arr));
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
        Console.WriteLine("Перевёрнутый: " + string.Join(" ", arr));
    }

    // 5. Подсчёт символов
    static void Task5()
    {
        Console.Write("Введите строку: ");
        string s = Console.ReadLine();
        int letters = 0, digits = 0, spaces = 0, others = 0;
        foreach (char c in s)
        {
            if (char.IsLetter(c)) letters++;
            else if (char.IsDigit(c)) digits++;
            else if (c == ' ') spaces++;
            else others++;
        }
        Console.WriteLine($"Букв: {letters}");
        Console.WriteLine($"Цифр: {digits}");
        Console.WriteLine($"Пробелов: {spaces}");
        Console.WriteLine($"Других: {others}");
    }

    // 6. Самое длинное слово
    static void Task6()
    {
        Console.Write("Введите предложение: ");
        string s = Console.ReadLine();
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string longest = "";
        foreach (var w in words)
            if (w.Length > longest.Length) longest = w;
        Console.WriteLine("Самое длинное слово: " + longest);
    }

    // 7. Палиндром
    static void Task7()
    {
        Console.Write("Введите строку: ");
        string s = Console.ReadLine().ToLower().Replace(" ", "");
        bool isPal = true;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i]) { isPal = false; break; }
        }
        Console.WriteLine(isPal ? "Палиндром" : "Не палиндром");
    }

    // 8. Простые числа
    static void Task8()
    {
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Простые числа: ");
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j * j <= i; j++)
                if (i % j == 0) { isPrime = false; break; }
            if (isPrime) Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // 9. Угадай число
    static void Task9()
    {
        Random rnd = new Random();
        int target = rnd.Next(1, 101);
        int attempts = 0;
        Console.WriteLine("Я загадал число от 1 до 100");
        while (true)
        {
            Console.Write("Ваш вариант: ");
            int guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess < target) Console.WriteLine("Загаданное число больше");
            else if (guess > target) Console.WriteLine("Загаданное число меньше");
            else { Console.WriteLine($"Вы угадали! Попыток: {attempts}"); break; }
        }
    }

    // 10. Банкомат
    static void Task10()
    {
        double balance = 100000;
        while (true)
        {
            Console.WriteLine("\n1. Проверить баланс");
            Console.WriteLine("2. Снять деньги");
            Console.WriteLine("3. Пополнить баланс");
            Console.WriteLine("4. Выход");
            Console.Write("Выбор: ");
            string c = Console.ReadLine();
            if (c == "1") Console.WriteLine($"Баланс: {balance}");
            else if (c == "2")
            {
                Console.Write("Сумма: ");
                double sum = double.Parse(Console.ReadLine());
                if (sum > balance) Console.WriteLine("Недостаточно средств");
                else { balance -= sum; Console.WriteLine($"Снято. Баланс: {balance}"); }
            }
            else if (c == "3")
            {
                Console.Write("Сумма: ");
                double sum = double.Parse(Console.ReadLine());
                balance += sum;
                Console.WriteLine($"Пополнено. Баланс: {balance}");
            }
            else if (c == "4") break;
        }
    }

    // 11. Калькулятор с методами
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b)
    {
        if (b == 0) { Console.WriteLine("Деление на 0!"); return 0; }
        return a / b;
    }
    static void Task11()
    {
        Console.Write("Число 1: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Число 2: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление");
        Console.Write("Выбор: ");
        string c = Console.ReadLine();
        double result = c switch
        {
            "1" => Add(a, b),
            "2" => Subtract(a, b),
            "3" => Multiply(a, b),
            "4" => Divide(a, b),
            _ => 0
        };
        Console.WriteLine("Результат: " + result);
    }

    // 12. Статистика оценок
    static void Task12()
    {
        int[] grades = new int[10];
        Console.WriteLine("Введите 10 оценок:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"[{i + 1}]: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        double avg = grades.Average();
        int max = grades.Max();
        int min = grades.Min();
        int fives = grades.Count(g => g == 5);
        int twos = grades.Count(g => g == 2);
        int passed = grades.Count(g => g >= 3);
        Console.WriteLine($"Средний: {avg}");
        Console.WriteLine($"Максимум: {max}, Минимум: {min}");
        Console.WriteLine($"Пятёрок: {fives}, Двоек: {twos}");
        Console.WriteLine($"Процент сдавших: {passed * 10}%");
    }

    // 13. Частота слов
    static void Task13()
    {
        Console.Write("Введите предложение: ");
        string s = Console.ReadLine();
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> freq = new Dictionary<string, int>();
        foreach (var w in words)
        {
            if (freq.ContainsKey(w)) freq[w]++;
            else freq[w] = 1;
        }
        foreach (var kv in freq)
            Console.WriteLine($"{kv.Key}: {kv.Value}");
    }

    // 14. Телефонная книга
    static void Task14()
    {
        Dictionary<string, string> book = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("\n1. Добавить\n2. Найти\n3. Удалить\n4. Показать все\n5. Выход");
            Console.Write("Выбор: ");
            string c = Console.ReadLine();
            if (c == "1")
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Телефон: ");
                string phone = Console.ReadLine();
                book[name] = phone;
                Console.WriteLine("Добавлено");
            }
            else if (c == "2")
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.WriteLine(book.ContainsKey(name) ? $"Телефон: {book[name]}" : "Не найден");
            }
            else if (c == "3")
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.WriteLine(book.Remove(name) ? "Удалено" : "Не найден");
            }
            else if (c == "4")
            {
                foreach (var kv in book) Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
            else if (c == "5") break;
        }
    }

    // 15. Класс Student
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public override string ToString() => $"{Name}, {Age} лет, балл: {Grade}";
    }
    static void Task15()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Иван", Age = 20, Grade = 4.5 },
            new Student { Name = "Мария", Age = 22, Grade = 5.0 },
            new Student { Name = "Пётр", Age = 19, Grade = 3.8 },
            new Student { Name = "Анна", Age = 21, Grade = 4.9 },
            new Student { Name = "Сергей", Age = 23, Grade = 4.2 }
        };
        Console.WriteLine("Все студенты:");
        foreach (var s in students) Console.WriteLine(s);
        var oldest = students.OrderByDescending(s => s.Age).First();
        var best = students.OrderByDescending(s => s.Grade).First();
        Console.WriteLine($"\nСамый старший: {oldest}");
        Console.WriteLine($"Лучший балл: {best}");
        Console.WriteLine($"Средний балл группы: {students.Average(s => s.Grade):F2}");
    }

    // 16. Класс BankAccount
    class BankAccount
    {
        public string Owner { get; set; }
        public double Balance { get; private set; }
        public BankAccount(string owner, double balance) { Owner = owner; Balance = balance; }
        public void Deposit(double amount)
        {
            if (amount <= 0) { Console.WriteLine("Неверная сумма"); return; }
            Balance += amount;
            Console.WriteLine($"Пополнено на {amount}. Баланс: {Balance}");
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance) { Console.WriteLine("Недостаточно средств"); return; }
            Balance -= amount;
            Console.WriteLine($"Снято {amount}. Баланс: {Balance}");
        }
        public void ShowBalance() => Console.WriteLine($"Owner: {Owner}, Balance: {Balance}");
    }
    static void Task16()
    {
        BankAccount acc = new BankAccount("Иван", 50000);
        acc.ShowBalance();
        acc.Deposit(10000);
        acc.Withdraw(15000);
        acc.ShowBalance();
    }

    // 17. Система товаров
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total => Price * Quantity;
        public override string ToString() => $"{Name}: {Price} x {Quantity} = {Total}";
    }
    static void Task17()
    {
        List<Product> products = new List<Product>();
        while (true)
        {
            Console.WriteLine("\n1. Добавить товар\n2. Удалить\n3. Найти\n4. Изменить количество\n5. Общая стоимость\n6. Выход");
            Console.Write("Выбор: ");
            string c = Console.ReadLine();
            if (c == "1")
            {
                Console.Write("Название: "); string name = Console.ReadLine();
                Console.Write("Цена: "); double price = double.Parse(Console.ReadLine());
                Console.Write("Количество: "); int qty = int.Parse(Console.ReadLine());
                products.Add(new Product { Name = name, Price = price, Quantity = qty });
                Console.WriteLine("Добавлено");
            }
            else if (c == "2")
            {
                Console.Write("Название: "); string name = Console.ReadLine();
                var p = products.FirstOrDefault(x => x.Name == name);
                if (p != null) { products.Remove(p); Console.WriteLine("Удалено"); }
                else Console.WriteLine("Не найдено");
            }
            else if (c == "3")
            {
                Console.Write("Название: "); string name = Console.ReadLine();
                var p = products.FirstOrDefault(x => x.Name == name);
                Console.WriteLine(p != null ? p.ToString() : "Не найдено");
            }
            else if (c == "4")
            {
                Console.Write("Название: "); string name = Console.ReadLine();
                var p = products.FirstOrDefault(x => x.Name == name);
                if (p != null)
                {
                    Console.Write("Новое количество: ");
                    p.Quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Изменено");
                }
                else Console.WriteLine("Не найдено");
            }
            else if (c == "5")
            {
                double total = products.Sum(p => p.Total);
                Console.WriteLine($"Общая стоимость: {total}");
            }
            else if (c == "6") break;
        }
    }

    // 18. Сортировка без Sort() (пузырьком)
    static void Task18()
    {
        int[] arr = { 8, 3, 1, 9, 5, 2, 7 };
        Console.WriteLine("Исходный: " + string.Join(" ", arr));
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Отсортированный: " + string.Join(" ", arr));
    }

    // 19. Камень, ножницы, бумага
    static void Task19()
    {
        Random rnd = new Random();
        int playerScore = 0, compScore = 0;
        string[] names = { "", "Камень", "Ножницы", "Бумага" };
        while (true)
        {
            Console.WriteLine("\n1. Камень\n2. Ножницы\n3. Бумага\n0. Выход");
            Console.Write("Ваш выбор: ");
            string c = Console.ReadLine();
            if (c == "0") break;
            if (c != "1" && c != "2" && c != "3") continue;
            int player = int.Parse(c);
            int comp = rnd.Next(1, 4);
            Console.WriteLine($"Игрок: {names[player]}");
            Console.WriteLine($"Компьютер: {names[comp]}");
            if (player == comp) Console.WriteLine("Ничья");
            else if ((player == 1 && comp == 2) || (player == 2 && comp == 3) || (player == 3 && comp == 1))
            { Console.WriteLine("Победил игрок!"); playerScore++; }
            else { Console.WriteLine("Победил компьютер!"); compScore++; }
            Console.WriteLine($"Счёт: Игрок {playerScore} : {compScore} Компьютер");
        }
    }

    // 20. Мини-система авторизации
    static void Task20()
    {
        Dictionary<string, string> users = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("\n1. Регистрация\n2. Вход\n3. Выход");
            Console.Write("Выбор: ");
            string c = Console.ReadLine();
            if (c == "1")
            {
                Console.Write("Логин: "); string login = Console.ReadLine();
                if (users.ContainsKey(login)) { Console.WriteLine("Логин занят"); continue; }
                Console.Write("Пароль: "); string pass = Console.ReadLine();
                users[login] = pass;
                Console.WriteLine("Зарегистрировано");
            }
            else if (c == "2")
            {
                int attempts = 3;
                bool success = false;
                while (attempts > 0)
                {
                    Console.Write("Логин: "); string login = Console.ReadLine();
                    Console.Write("Пароль: "); string pass = Console.ReadLine();
                    if (users.ContainsKey(login) && users[login] == pass)
                    {
                        Console.WriteLine("Вход выполнен успешно!");
                        success = true;
                        break;
                    }
                    attempts--;
                    Console.WriteLine($"Неверно. Осталось попыток: {attempts}");
                }
                if (!success) Console.WriteLine("Попытки исчерпаны");
            }
            else if (c == "3") break;
        }
    }
}