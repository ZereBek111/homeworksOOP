
using System;
using System.Collections.Generic;

// 1. Человек
class Person1
{
    public string Name;
    public int Age;

    public Person1()
    {
        Name = "Неизвестно";
        Age = 0;
    }
}

// 2. Автомобиль
class Car1
{
    public string Brand;
    public int Year;

    public Car1(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
}

// 3. Студент
class Student1
{
    public string FullName;
    public int Course;

    public Student1(string fullName, int course)
    {
        FullName = fullName;
        Course = course;
    }

    public void Show()
    {
        Console.WriteLine($"ФИО: {FullName}, Курс: {Course}");
    }
}

// 4. Книга
class Book1
{
    public string Title;
    public string Author;

    public Book1(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

// 5. Телефон
class Phone1
{
    public string Model;
    public double Price;

    public Phone1(string model, double price)
    {
        Model = model;
        Price = price;
    }
}

// 6. Товар
class Product1
{
    public string Name;
    public int Quantity;

    public Product1(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}

// 7. Сотрудник
class Employee1
{
    public string Name;
    public double Salary;

    public Employee1(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

// 8. Компьютер
class Computer1
{
    public string Processor;
    public int RAM;

    public Computer1(string processor, int ram)
    {
        Processor = processor;
        RAM = ram;
    }
}

// 9. Кошка
class Cat1
{
    public string Nickname;
    public int Age;

    public Cat1(string nickname, int age)
    {
        Nickname = nickname;
        Age = age;
    }

    public void Show()
    {
        Console.WriteLine($"Кличка: {Nickname}, Возраст: {Age}");
    }
}

// 10. Банк
class Bank1
{
    public string Name;

    public Bank1(string name)
    {
        Name = name;
    }
}

// 11. Прямоугольник
class Rectangle1
{
    public double Length, Width;

    public Rectangle1(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double Area() => Length * Width;
}

// 12. Круг
class Circle1
{
    public double Radius;

    public Circle1(double radius)
    {
        Radius = radius;
    }

    public double Area() => Math.PI * Radius * Radius;
}

// 13. Калькулятор
class Calculator1
{
    public double A, B;

    public Calculator1(double a, double b)
    {
        A = a;
        B = b;
    }

    public void Calculate()
    {
        Console.WriteLine($"Сложение: {A + B}");
        Console.WriteLine($"Вычитание: {A - B}");
        Console.WriteLine($"Умножение: {A * B}");

        if (B != 0)
            Console.WriteLine($"Деление: {A / B}");
        else
            Console.WriteLine("На ноль делить нельзя");
    }
}

// 14. Счёт
class Account1
{
    public string Number;
    public double Balance;

    public Account1(string number, double balance)
    {
        Number = number;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
    }
}

// 15. Самолёт
class Plane1
{
    public string Model;
    public int Passengers;
    public double MaxSpeed;

    public Plane1(string model, int passengers, double maxSpeed)
    {
        Model = model;
        Passengers = passengers;
        MaxSpeed = maxSpeed;
    }
}

// 16. Игрок
class Player1
{
    public string Name;
    public int Points;

    public Player1(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public void AddPoints(int points)
    {
        if (points > 0)
            Points += points;
    }
}

// 17. Фильм
class Film1
{
    public string Title, Genre;
    public int Duration;

    public Film1(string title, string genre, int duration)
    {
        Title = title;
        Genre = genre;
        Duration = duration;
    }
}

// 18. Ноутбук
class Laptop1
{
    public string Manufacturer, Model;
    public double Price;

    public Laptop1(string manufacturer, string model, double price)
    {
        Manufacturer = manufacturer;
        Model = model;
        Price = price;
    }
}

// 19. Университет
class University1
{
    public string Name;
    public int Students;

    public University1(string name, int students)
    {
        Name = name;
        Students = students;
    }
}

// 20. Заказ
class Order1
{
    public int Number;
    public string Product;
    public double Price;

    public Order1(int number, string product, double price)
    {
        Number = number;
        Product = product;
        Price = price;
    }
}

// 21. Перегрузка конструкторов Person
class Person21
{
    public string Name;
    public int Age;

    public Person21() : this("Неизвестно", 0) { }

    public Person21(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// 22. Автомобиль с перегрузкой
class Car22
{
    public string Brand;
    public int Year;

    public Car22(string brand) : this(brand, 2020) { }

    public Car22(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
}

// 23. Три конструктора Student
class Student23
{
    public string Name, Group;
    public int Course;

    public Student23(string name) : this(name, 1, "Не указана") { }

    public Student23(string name, int course)
        : this(name, course, "Не указана") { }

    public Student23(string name, int course, string group)
    {
        Name = name;
        Course = course;
        Group = group;
    }
}

// 24. Товар
class Product24
{
    public string Name;
    public double Price;

    public Product24(string name) : this(name, 0) { }

    public Product24(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

// 25. Книга с тремя конструкторами
class Book25
{
    public string Title, Author;
    public int Year;

    public Book25(string title) : this(title, "Неизвестен", 0) { }

    public Book25(string title, string author)
        : this(title, author, 0) { }

    public Book25(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

// 26. Игрок
class Player26
{
    public string Name;
    public int Points;

    public Player26(string name) : this(name, 0) { }

    public Player26(string name, int points)
    {
        Name = name;
        Points = points;
    }
}

// 27. Компьютер
class Computer27
{
    public string Model, Processor;
    public int RAM;

    public Computer27(string model) : this(model, "Не указан", 0) { }

    public Computer27(string model, string processor, int ram)
    {
        Model = model;
        Processor = processor;
        RAM = ram;
    }
}

// 28. Сотрудник
class Employee28
{
    public string Name, Position;
    public double Salary;

    public Employee28(string name) : this(name, "Не указана", 0) { }

    public Employee28(string name, string position)
        : this(name, position, 0) { }

    public Employee28(string name, string position, double salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }
}

// 29. Квартира
class Apartment29
{
    public string Address;
    public double Area;
    public int Rooms;

    public Apartment29(string address) : this(address, 0, 0) { }

    public Apartment29(string address, double area, int rooms)
    {
        Address = address;
        Area = area;
        Rooms = rooms;
    }
}

// 30. Заказ с перегрузкой
class Order30
{
    public int Number;
    public string Product;
    public double Price;

    public Order30(int number) : this(number, "Не указан", 0) { }

    public Order30(int number, string product)
        : this(number, product, 0) { }

    public Order30(int number, string product, double price)
    {
        Number = number;
        Product = product;
        Price = price;
    }
}

// 31. Цепочка конструкторов
class Person31
{
    public string Name;
    public int Age;

    public Person31() : this("Гость") { }

    public Person31(string name) : this(name, 18) { }

    public Person31(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// 32. Проверка баланса
class BankAccount32
{
    public double Balance;

    public BankAccount32(double balance)
    {
        if (balance < 0)
            throw new ArgumentException("Баланс не может быть отрицательным");

        Balance = balance;
    }
}

// 33. Уникальный ID студента
class Student33
{
    private static int nextId = 1;
    public int ID;
    public string Name;

    public Student33(string name)
    {
        ID = nextId++;
        Name = name;
    }
}

// 34. Расчёт стоимости
class Product34
{
    public double Price, Total;
    public int Quantity;

    public Product34(double price, int quantity)
    {
        if (price < 0 || quantity < 0)
            throw new ArgumentException("Цена и количество не могут быть отрицательными");

        Price = price;
        Quantity = quantity;
        Total = price * quantity;
    }
}

// 35. Проверка даты
class Date35
{
    public int Day, Month, Year;

    public Date35(int day, int month, int year)
    {
        DateTime date;

        try
        {
            date = new DateTime(year, month, day);
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new ArgumentException("Некорректная дата");
        }

        Day = date.Day;
        Month = date.Month;
        Year = date.Year;
    }
}

// 36. Проверка треугольника
class Triangle36
{
    public double A, B, C;

    public Triangle36(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0 ||
            a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Такой треугольник не существует");

        A = a;
        B = b;
        C = c;
    }
}

// 37. Статистика автомобилей
class Car37
{
    public static int Count = 0;
    public string Brand;

    public Car37(string brand)
    {
        Brand = brand;
        Count++;
    }
}

// 38. Наследование
class Animal38
{
    public string Name;

    public Animal38(string name)
    {
        Name = name;
    }
}

class Dog38 : Animal38
{
    public string Breed;

    public Dog38(string name, string breed) : base(name)
    {
        Breed = breed;
    }
}

// 39. Конструктор копирования
class Book39
{
    public string Title, Author;

    public Book39(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public Book39(Book39 other)
    {
        Title = other.Title;
        Author = other.Author;
    }
}

// 40. Полная система студентов
class Student40
{
    private static int nextId = 1;

    public int ID { get; }
    public string FullName { get; }
    public int Course { get; }
    public string Group { get; }
    public double AverageGrade { get; }

    public Student40(string fullName)
        : this(fullName, 1, "Не указана", 0) { }

    public Student40(string fullName, int course, string group)
        : this(fullName, course, group, 0) { }

    public Student40(string fullName, int course, string group, double grade)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("ФИО не может быть пустым");

        if (course < 1 || course > 6)
            throw new ArgumentException("Курс должен быть от 1 до 6");

        if (string.IsNullOrWhiteSpace(group))
            throw new ArgumentException("Группа не может быть пустой");

        if (grade < 0 || grade > 100)
            throw new ArgumentException("Средний балл должен быть от 0 до 100");

        ID = nextId++;
        FullName = fullName;
        Course = course;
        Group = group;
        AverageGrade = grade;
    }

    public void Show()
    {
        Console.WriteLine(
            $"ID: {ID}, ФИО: {FullName}, Курс: {Course}, " +
            $"Группа: {Group}, Средний балл: {AverageGrade}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 1–20. Основные конструкторы ===");

        Person1 p1 = new Person1();
        Console.WriteLine($"Человек: {p1.Name}, {p1.Age}");

        Car1 car = new Car1("Toyota", 2022);
        Console.WriteLine($"Автомобиль: {car.Brand}, {car.Year}");

        Student1 student = new Student1("Иван Иванов", 2);
        student.Show();

        Book1 book = new Book1("Абай жолы", "Мухтар Ауэзов");
        Console.WriteLine($"Книга: {book.Title}, автор: {book.Author}");

        Phone1 phone = new Phone1("Samsung", 150000);
        Console.WriteLine($"Телефон: {phone.Model}, цена: {phone.Price}");

        Product1 product = new Product1("Клавиатура", 5);
        Console.WriteLine($"Товар: {product.Name}, количество: {product.Quantity}");

        Employee1 employee = new Employee1("Али", 250000);
        Console.WriteLine($"Сотрудник: {employee.Name}, зарплата: {employee.Salary}");

        Computer1 computer = new Computer1("Intel Core i5", 16);
        Console.WriteLine($"Компьютер: {computer.Processor}, RAM: {computer.RAM} ГБ");

        Cat1 cat = new Cat1("Мурка", 3);
        cat.Show();

        Bank1 bank = new Bank1("Народный банк");
        Console.WriteLine($"Банк: {bank.Name}");

        Rectangle1 rectangle = new Rectangle1(5, 4);
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");

        Circle1 circle = new Circle1(3);
        Console.WriteLine($"Площадь круга: {circle.Area():F2}");

        Calculator1 calculator = new Calculator1(10, 5);
        calculator.Calculate();

        Account1 account = new Account1("KZ123", 10000);
        account.Deposit(5000);
        Console.WriteLine($"Баланс счёта: {account.Balance}");

        Plane1 plane = new Plane1("Boeing 737", 180, 850);
        Console.WriteLine($"Самолёт: {plane.Model}, пассажиров: {plane.Passengers}");

        Player1 player = new Player1("Арман", 10);
        player.AddPoints(5);
        Console.WriteLine($"Игрок: {player.Name}, очки: {player.Points}");

        Film1 film = new Film1("Аватар", "Фантастика", 162);
        Console.WriteLine($"Фильм: {film.Title}, жанр: {film.Genre}");

        Laptop1 laptop = new Laptop1("Lenovo", "IdeaPad", 300000);
        Console.WriteLine($"Ноутбук: {laptop.Manufacturer} {laptop.Model}");

        University1 university = new University1("Университет", 5000);
        Console.WriteLine($"Университет: {university.Name}, студентов: {university.Students}");

        Order1 order = new Order1(1, "Мышь", 5000);
        Console.WriteLine($"Заказ №{order.Number}: {order.Product}, {order.Price}");

        Console.WriteLine("\n=== 21–30. Перегрузка конструкторов ===");

        Person21 p21 = new Person21();
        Person21 p22 = new Person21("Али", 20);
        Console.WriteLine($"{p21.Name}; {p22.Name}, {p22.Age}");

        Car22 car22 = new Car22("BMW");
        Console.WriteLine($"{car22.Brand}, {car22.Year}");

        Student23 s23 = new Student23("Алия", 2, "ИС-22");
        Console.WriteLine($"{s23.Name}, {s23.Course}, {s23.Group}");

        Product24 p24 = new Product24("Монитор", 80000);
        Console.WriteLine($"{p24.Name}, {p24.Price}");

        Book25 b25 = new Book25("Книга", "Автор", 2024);
        Console.WriteLine($"{b25.Title}, {b25.Author}, {b25.Year}");

        Player26 pl26 = new Player26("Данияр", 100);
        Console.WriteLine($"{pl26.Name}, очки: {pl26.Points}");

        Computer27 cp27 = new Computer27("HP", "Intel i7", 16);
        Console.WriteLine($"{cp27.Model}, {cp27.Processor}, RAM: {cp27.RAM}");

        Employee28 em28 = new Employee28("Айжан", "Программист", 400000);
        Console.WriteLine($"{em28.Name}, {em28.Position}, {em28.Salary}");

        Apartment29 ap29 = new Apartment29("Алматы", 65, 3);
        Console.WriteLine($"{ap29.Address}, {ap29.Area} м², комнат: {ap29.Rooms}");

        Order30 or30 = new Order30(101, "Телефон", 150000);
        Console.WriteLine($"Заказ №{or30.Number}: {or30.Product}, {or30.Price}");

        Console.WriteLine("\n=== 31–40. Дополнительные возможности ===");

        Person31 person31 = new Person31();
        Console.WriteLine($"{person31.Name}, {person31.Age}");

        BankAccount32 bankAccount = new BankAccount32(5000);
        Console.WriteLine($"Баланс: {bankAccount.Balance}");

        Student33 st1 = new Student33("Али");
        Student33 st2 = new Student33("Алия");
        Console.WriteLine($"Студенты: ID {st1.ID}, ID {st2.ID}");

        Product34 p34 = new Product34(1000, 3);
        Console.WriteLine($"Общая стоимость: {p34.Total}");

        Date35 date = new Date35(9, 10, 2026);
        Console.WriteLine($"Дата: {date.Day}.{date.Month}.{date.Year}");

        Triangle36 triangle = new Triangle36(3, 4, 5);
        Console.WriteLine($"Треугольник: {triangle.A}, {triangle.B}, {triangle.C}");

        Car37 c37a = new Car37("Toyota");
        Car37 c37b = new Car37("BMW");
        Console.WriteLine($"Создано автомобилей: {Car37.Count}");

        Dog38 dog = new Dog38("Рекс", "Овчарка");
        Console.WriteLine($"Собака: {dog.Name}, порода: {dog.Breed}");

        Book39 original = new Book39("Абай жолы", "Мухтар Ауэзов");
        Book39 copy = new Book39(original);
        Console.WriteLine($"Копия книги: {copy.Title}, {copy.Author}");

        Student40 fullStudent = new Student40("Айбек Нурланов", 2, "ИС-22", 92.5);
        fullStudent.Show();

        Console.WriteLine("\nВсе 40 заданий выполнены!");
    }
}
