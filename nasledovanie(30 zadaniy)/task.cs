using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Tasks
{
    // ==================== 1. Животное ====================
    class Animal1
    {
        public virtual void Speak() => Console.WriteLine("Животное издаёт звук");
    }
    class Dog1 : Animal1
    {
        public override void Speak() => Console.WriteLine("Собака: Гав-гав!");
    }
    class Cat1 : Animal1
    {
        public override void Speak() => Console.WriteLine("Кошка: Мяу!");
    }

    // ==================== 2. Транспорт ====================
    class Vehicle2
    {
        public string Brand { get; set; }
        public double Speed { get; set; }
        public Vehicle2(string brand, double speed) { Brand = brand; Speed = speed; }
        public virtual void ShowInfo() => Console.WriteLine($"Марка: {Brand}, Скорость: {Speed}");
    }
    class Car2 : Vehicle2
    {
        public int Doors { get; set; }
        public Car2(string b, double s, int d) : base(b, s) { Doors = d; }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Дверей: {Doors}");
        }
    }
    class Motorcycle2 : Vehicle2
    {
        public bool HasSidecar { get; set; }
        public Motorcycle2(string b, double s, bool side) : base(b, s) { HasSidecar = side; }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Коляска: {(HasSidecar ? "да" : "нет")}");
        }
    }

    // ==================== 3. Человек и студент ====================
    class Person3
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person3(string name, int age) { Name = name; Age = age; }
        public virtual void Print() => Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
    class Student3 : Person3
    {
        public string Specialty { get; set; }
        public int Course { get; set; }
        public Student3(string n, int a, string s, int c) : base(n, a) { Specialty = s; Course = c; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Специальность: {Specialty}, Курс: {Course}");
        }
    }

    // ==================== 4. Сотрудники ====================
    class Employee4
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee4(string n, double s) { Name = n; Salary = s; }
        public virtual void Show() => Console.WriteLine($"{Name} — {Salary}");
    }
    class Manager4 : Employee4
    {
        public int TeamSize { get; set; }
        public Manager4(string n, double s, int t) : base(n, s) { TeamSize = t; }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Команда: {TeamSize} чел.");
        }
    }
    class Developer4 : Employee4
    {
        public string Language { get; set; }
        public Developer4(string n, double s, string l) : base(n, s) { Language = l; }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Язык: {Language}");
        }
    }

    // ==================== 5. Фигуры ====================
    class Shape5
    {
        public virtual double GetArea() => 0;
    }
    class Rectangle5 : Shape5
    {
        public double W { get; set; }
        public double H { get; set; }
        public Rectangle5(double w, double h) { W = w; H = h; }
        public override double GetArea() => W * H;
    }
    class Circle5 : Shape5
    {
        public double Radius { get; set; }
        public Circle5(double r) { Radius = r; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }

    // ==================== 6. Транспорт с методом движения ====================
    class Vehicle6
    {
        public virtual void Move() => Console.WriteLine("Транспорт движется");
    }
    class Car6 : Vehicle6
    {
        public override void Move() => Console.WriteLine("Машина едет по дороге");
    }
    class Bus6 : Vehicle6
    {
        public override void Move() => Console.WriteLine("Автобус везёт пассажиров");
    }
    class Train6 : Vehicle6
    {
        public override void Move() => Console.WriteLine("Поезд едет по рельсам");
    }

    // ==================== 7. Работник магазина ====================
    class Worker7
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Worker7(string n, string p) { Name = n; Position = p; }
        public virtual void Work() => Console.WriteLine($"{Name} работает ({Position})");
    }
    class Cashier7 : Worker7
    {
        public Cashier7(string n) : base(n, "Кассир") { }
        public override void Work() => Console.WriteLine($"{Name} пробивает товары");
    }
    class Seller7 : Worker7
    {
        public Seller7(string n) : base(n, "Продавец") { }
        public override void Work() => Console.WriteLine($"{Name} консультирует покупателей");
    }

    // ==================== 8. Компьютеры ====================
    class Computer8
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public Computer8(string cpu, int ram) { Processor = cpu; RAM = ram; }
        public virtual void Info() => Console.WriteLine($"CPU: {Processor}, RAM: {RAM} ГБ");
    }
    class Laptop8 : Computer8
    {
        public double Weight { get; set; }
        public Laptop8(string c, int r, double w) : base(c, r) { Weight = w; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Вес: {Weight} кг");
        }
    }
    class Desktop8 : Computer8
    {
        public string CaseType { get; set; }
        public Desktop8(string c, int r, string ct) : base(c, r) { CaseType = ct; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Корпус: {CaseType}");
        }
    }

    // ==================== 9. Книги ====================
    class Book9
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book9(string t, string a) { Title = t; Author = a; }
        public virtual void Info() => Console.WriteLine($"{Title} — {Author}");
    }
    class PaperBook9 : Book9
    {
        public int Pages { get; set; }
        public PaperBook9(string t, string a, int p) : base(t, a) { Pages = p; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Страниц: {Pages}");
        }
    }
    class EBook9 : Book9
    {
        public double SizeMb { get; set; }
        public EBook9(string t, string a, double s) : base(t, a) { SizeMb = s; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Размер: {SizeMb} МБ");
        }
    }

    // ==================== 10. Домашние животные ====================
    class Pet10
    {
        public virtual void Eat() => Console.WriteLine("Питомец ест");
    }
    class Dog10 : Pet10
    {
        public override void Eat() => Console.WriteLine("Собака ест корм");
    }
    class Cat10 : Pet10
    {
        public override void Eat() => Console.WriteLine("Кошка ест рыбу");
    }
    class Parrot10 : Pet10
    {
        public override void Eat() => Console.WriteLine("Попугай клюёт зерно");
    }

    // ==================== 11. Банковские счета ====================
    class BankAccount11
    {
        public double Balance { get; protected set; }
        public virtual void Deposit(double amount) => Balance += amount;
        public virtual void Withdraw(double amount)
        {
            if (amount <= Balance) Balance -= amount;
            else Console.WriteLine("Недостаточно средств");
        }
        public virtual void Show() => Console.WriteLine($"Баланс: {Balance}");
    }
    class SavingsAccount11 : BankAccount11
    {
        public double InterestRate { get; set; }
        public SavingsAccount11(double rate) { InterestRate = rate; }
        public void AddInterest() => Balance += Balance * InterestRate;
    }
    class CreditAccount11 : BankAccount11
    {
        public double CreditLimit { get; set; }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -CreditLimit) Balance -= amount;
            else Console.WriteLine("Превышен кредитный лимит");
        }
    }

    // ==================== 12. Транспортная компания ====================
    class Transport12
    {
        public virtual double CalculateCost(double distance) => 0;
    }
    class Car12 : Transport12
    {
        public override double CalculateCost(double d) => d * 10;
    }
    class Truck12 : Transport12
    {
        public override double CalculateCost(double d) => d * 25;
    }
    class Bus12 : Transport12
    {
        public override double CalculateCost(double d) => d * 15;
    }

    // ==================== 13. Работники компании ====================
    class Employee13
    {
        public string Name { get; set; }
        public Employee13(string n) { Name = n; }
        public virtual double GetSalary() => 0;
    }
    class Programmer13 : Employee13
    {
        public int Hours { get; set; }
        public double Rate { get; set; }
        public Programmer13(string n, int h, double r) : base(n) { Hours = h; Rate = r; }
        public override double GetSalary() => Hours * Rate;
    }
    class Designer13 : Employee13
    {
        public int Projects { get; set; }
        public double ProjectRate { get; set; }
        public Designer13(string n, int p, double pr) : base(n) { Projects = p; ProjectRate = pr; }
        public override double GetSalary() => Projects * ProjectRate;
    }
    class Manager13 : Employee13
    {
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }
        public Manager13(string n, double b, double bonus) : base(n) { BaseSalary = b; Bonus = bonus; }
        public override double GetSalary() => BaseSalary + Bonus;
    }

    // ==================== 14. Система образования ====================
    class Person14
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person14(string n, int a) { Name = n; Age = a; }
    }
    class Student14 : Person14
    {
        public string University { get; set; }
        public Student14(string n, int a, string u) : base(n, a) { University = u; }
    }
    class GraduateStudent14 : Student14
    {
        public string Thesis { get; set; }
        public GraduateStudent14(string n, int a, string u, string t) : base(n, a, u) { Thesis = t; }
        public void PrintAll() =>
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, ВУЗ: {University}, Диссертация: {Thesis}");
    }

    // ==================== 15. Военная техника ====================
    class MilitaryVehicle15
    {
        public virtual void Attack() => Console.WriteLine("Атака");
    }
    class Tank15 : MilitaryVehicle15
    {
        public override void Attack() => Console.WriteLine("Танк стреляет из пушки");
    }
    class Helicopter15 : MilitaryVehicle15
    {
        public override void Attack() => Console.WriteLine("Вертолёт запускает ракеты");
    }
    class ArmoredCar15 : MilitaryVehicle15
    {
        public override void Attack() => Console.WriteLine("Бронемашина ведёт огонь из пулемёта");
    }

    // ==================== 16. Игровые персонажи ====================
    class Character16
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public Character16(string n, int hp, int dmg) { Name = n; Health = hp; Damage = dmg; }
        public virtual void Attack() => Console.WriteLine($"{Name} атакует на {Damage}");
    }
    class Warrior16 : Character16
    {
        public Warrior16(string n, int hp, int dmg) : base(n, hp, dmg) { }
        public override void Attack() => Console.WriteLine($"{Name} (воин) бьёт мечом на {Damage * 2}");
    }
    class Mage16 : Character16
    {
        public Mage16(string n, int hp, int dmg) : base(n, hp, dmg) { }
        public override void Attack() => Console.WriteLine($"{Name} (маг) кастует заклинание на {Damage * 3}");
    }
    class Archer16 : Character16
    {
        public Archer16(string n, int hp, int dmg) : base(n, hp, dmg) { }
        public override void Attack() => Console.WriteLine($"{Name} (лучник) стреляет из лука на {Damage}");
    }

    // ==================== 17. Электронные устройства ====================
    class Device17
    {
        public bool IsOn { get; protected set; }
        public virtual void TurnOn() { IsOn = true; Console.WriteLine("Устройство включено"); }
        public virtual void TurnOff() { IsOn = false; Console.WriteLine("Устройство выключено"); }
    }
    class Phone17 : Device17
    {
        public override void TurnOn() { IsOn = true; Console.WriteLine("Телефон включён"); }
        public override void TurnOff() { IsOn = false; Console.WriteLine("Телефон выключен"); }
    }
    class Computer17 : Device17
    {
        public override void TurnOn() { IsOn = true; Console.WriteLine("Компьютер загружается"); }
        public override void TurnOff() { IsOn = false; Console.WriteLine("Компьютер выключается"); }
    }
    class Television17 : Device17
    {
        public override void TurnOn() { IsOn = true; Console.WriteLine("Телевизор включён"); }
        public override void TurnOff() { IsOn = false; Console.WriteLine("Телевизор выключен"); }
    }

    // ==================== 18. Платежи ====================
    class Payment18
    {
        public virtual void Pay(double amount) => Console.WriteLine($"Оплата {amount}");
    }
    class CashPayment18 : Payment18
    {
        public override void Pay(double a) => Console.WriteLine($"Наличными: {a}");
    }
    class CardPayment18 : Payment18
    {
        public override void Pay(double a) => Console.WriteLine($"Картой: {a}");
    }
    class OnlinePayment18 : Payment18
    {
        public override void Pay(double a) => Console.WriteLine($"Онлайн: {a}");
    }

    // ==================== 19. Сотрудники с бонусами ====================
    class Employee19
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee19(string n, double s) { Name = n; Salary = s; }
        public virtual double GetBonus() => 0;
        public virtual double GetTotal() => Salary + GetBonus();
    }
    class Manager19 : Employee19
    {
        public Manager19(string n, double s) : base(n, s) { }
        public override double GetBonus() => Salary * 0.2;
    }
    class Developer19 : Employee19
    {
        public Developer19(string n, double s) : base(n, s) { }
        public override double GetBonus() => Salary * 0.15;
    }
    class SalesManager19 : Employee19
    {
        public SalesManager19(string n, double s) : base(n, s) { }
        public override double GetBonus() => Salary * 0.25;
    }

    // ==================== 20. Животные зоопарка ====================
    class Animal20
    {
        public string Name { get; set; }
        public Animal20(string name) { Name = name; }
        public virtual void Eat() => Console.WriteLine($"{Name} ест");
        public virtual void MakeSound() => Console.WriteLine($"{Name} издаёт звук");
    }
    class Lion20 : Animal20
    {
        public Lion20() : base("Лев") { }
        public override void Eat() => Console.WriteLine("Лев ест мясо");
        public override void MakeSound() => Console.WriteLine("Лев рычит");
    }
    class Elephant20 : Animal20
    {
        public Elephant20() : base("Слон") { }
        public override void Eat() => Console.WriteLine("Слон ест траву");
        public override void MakeSound() => Console.WriteLine("Слон трубит");
    }
    class Monkey20 : Animal20
    {
        public Monkey20() : base("Обезьяна") { }
        public override void Eat() => Console.WriteLine("Обезьяна ест бананы");
        public override void MakeSound() => Console.WriteLine("Обезьяна кричит");
    }
    class Penguin20 : Animal20
    {
        public Penguin20() : base("Пингвин") { }
        public override void Eat() => Console.WriteLine("Пингвин ест рыбу");
        public override void MakeSound() => Console.WriteLine("Пингвин крякает");
    }
    class Snake20 : Animal20
    {
        public Snake20() : base("Змея") { }
        public override void Eat() => Console.WriteLine("Змея ест грызунов");
        public override void MakeSound() => Console.WriteLine("Змея шипит");
    }

    // ==================== 21. Абстрактные фигуры ====================
    abstract class Shape21
    {
        public abstract double GetArea();
    }
    class Circle21 : Shape21
    {
        public double Radius { get; set; }
        public Circle21(double r) { Radius = r; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }
    class Rectangle21 : Shape21
    {
        public double W { get; set; }
        public double H { get; set; }
        public Rectangle21(double w, double h) { W = w; H = h; }
        public override double GetArea() => W * H;
    }
    class Triangle21 : Shape21
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle21(double b, double h) { Base = b; Height = h; }
        public override double GetArea() => 0.5 * Base * Height;
    }
    class Square21 : Shape21
    {
        public double Side { get; set; }
        public Square21(double s) { Side = s; }
        public override double GetArea() => Side * Side;
    }

    // ==================== 22. Интернет-магазин ====================
    class Product22
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product22(string n, double p) { Name = n; Price = p; }
        public virtual double GetFinalPrice() => Price;
    }
    class Electronics22 : Product22
    {
        public double Warranty { get; set; }
        public Electronics22(string n, double p, double w) : base(n, p) { Warranty = w; }
        public override double GetFinalPrice() => Price + Price * Warranty / 100;
    }
    class Clothing22 : Product22
    {
        public double Discount { get; set; }
        public Clothing22(string n, double p, double d) : base(n, p) { Discount = d; }
        public override double GetFinalPrice() => Price - Price * Discount / 100;
    }
    class Food22 : Product22
    {
        public double Tax { get; set; }
        public Food22(string n, double p, double t) : base(n, p) { Tax = t; }
        public override double GetFinalPrice() => Price + Price * Tax / 100;
    }

    // ==================== 23. Система транспорта ====================
    abstract class Transport23
    {
        public abstract void Move();
        public abstract double GetFuelConsumption();
    }
    class Car23 : Transport23
    {
        public override void Move() => Console.WriteLine("Машина едет");
        public override double GetFuelConsumption() => 7.5;
    }
    class Truck23 : Transport23
    {
        public override void Move() => Console.WriteLine("Грузовик едет");
        public override double GetFuelConsumption() => 20;
    }
    class Bus23 : Transport23
    {
        public override void Move() => Console.WriteLine("Автобус едет");
        public override double GetFuelConsumption() => 15;
    }
    class Motorcycle23 : Transport23
    {
        public override void Move() => Console.WriteLine("Мотоцикл едет");
        public override double GetFuelConsumption() => 4;
    }

    // ==================== 24. Больница ====================
    class MedicalWorker24
    {
        public string Name { get; set; }
        public MedicalWorker24(string n) { Name = n; }
        public virtual void Work() => Console.WriteLine($"{Name} работает");
    }
    class Doctor24 : MedicalWorker24
    {
        public Doctor24(string n) : base(n) { }
        public override void Work() => Console.WriteLine($"{Name} (врач) лечит пациентов");
    }
    class Nurse24 : MedicalWorker24
    {
        public Nurse24(string n) : base(n) { }
        public override void Work() => Console.WriteLine($"{Name} (медсестра) ухаживает за пациентами");
    }
    class Surgeon24 : MedicalWorker24
    {
        public Surgeon24(string n) : base(n) { }
        public override void Work() => Console.WriteLine($"{Name} (хирург) проводит операции");
    }

    // ==================== 25. Система сотрудников с уровнями ====================
    class Person25
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person25(string n, int a) { Name = n; Age = a; }
        public void Greet() => Console.WriteLine($"Привет, я {Name}");
    }
    class Employee25 : Person25
    {
        public double Salary { get; set; }
        public string Department { get; set; }
        public Employee25(string n, int a, double s, string d) : base(n, a) { Salary = s; Department = d; }
        public void ShowSalary() => Console.WriteLine($"Зарплата: {Salary}");
    }
    class Manager25 : Employee25
    {
        public int TeamSize { get; set; }
        public double Bonus { get; set; }
        public Manager25(string n, int a, double s, string d, int t, double b)
            : base(n, a, s, d) { TeamSize = t; Bonus = b; }
        public void Manage() => Console.WriteLine($"Управляю {TeamSize} людьми, бонус {Bonus}");
    }
    class Director25 : Manager25
    {
        public string Company { get; set; }
        public double StockOptions { get; set; }
        public Director25(string n, int a, double s, string d, int t, double b, string c, double so)
            : base(n, a, s, d, t, b) { Company = c; StockOptions = so; }
        public void Lead() => Console.WriteLine($"Директор {Company}, акции: {StockOptions}");
    }

    // ==================== 26. Игра: персонажи ====================
    abstract class Character26
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public Character26(string n, int hp, int dmg) { Name = n; Health = hp; Damage = dmg; }
        public abstract void Attack();
        public abstract void Defend();
        public abstract void SpecialAttack();
    }
    class Warrior26 : Character26
    {
        public Warrior26(string n) : base(n, 150, 20) { }
        public override void Attack() => Console.WriteLine($"{Name} рубит мечом ({Damage})");
        public override void Defend() => Console.WriteLine($"{Name} блокирует щитом");
        public override void SpecialAttack() => Console.WriteLine($"{Name} использует ярость ({Damage * 3})");
    }
    class Mage26 : Character26
    {
        public Mage26(string n) : base(n, 90, 30) { }
        public override void Attack() => Console.WriteLine($"{Name} бросает фаербол ({Damage})");
        public override void Defend() => Console.WriteLine($"{Name} ставит магический щит");
        public override void SpecialAttack() => Console.WriteLine($"{Name} вызывает метеор ({Damage * 4})");
    }
    class Archer26 : Character26
    {
        public Archer26(string n) : base(n, 110, 25) { }
        public override void Attack() => Console.WriteLine($"{Name} стреляет ({Damage})");
        public override void Defend() => Console.WriteLine($"{Name} уклоняется");
        public override void SpecialAttack() => Console.WriteLine($"{Name} выпускает град стрел ({Damage * 3})");
    }

    // ==================== 27. Файлы ====================
    class File27
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public File27(string n, double s) { Name = n; Size = s; }
        public virtual void Open() => Console.WriteLine($"Открыт файл {Name} ({Size} МБ)");
    }
    class TextFile27 : File27
    {
        public string Encoding { get; set; }
        public TextFile27(string n, double s, string e) : base(n, s) { Encoding = e; }
        public override void Open() => Console.WriteLine($"Текстовый файл {Name} открыт в кодировке {Encoding}");
    }
    class ImageFile27 : File27
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public ImageFile27(string n, double s, int w, int h) : base(n, s) { Width = w; Height = h; }
        public override void Open() => Console.WriteLine($"Изображение {Name} {Width}x{Height} открыто");
    }
    class VideoFile27 : File27
    {
        public int Duration { get; set; }
        public VideoFile27(string n, double s, int d) : base(n, s) { Duration = d; }
        public override void Open() => Console.WriteLine($"Видео {Name} ({Duration} сек) воспроизводится");
    }

    // ==================== 28. Система оплаты зарплаты ====================
    abstract class Employee28
    {
        public string Name { get; set; }
        public Employee28(string n) { Name = n; }
        public abstract double CalculateSalary();
    }
    class HourlyEmployee28 : Employee28
    {
        public double Rate { get; set; }
        public int Hours { get; set; }
        public HourlyEmployee28(string n, double r, int h) : base(n) { Rate = r; Hours = h; }
        public override double CalculateSalary() => Rate * Hours;
    }
    class SalariedEmployee28 : Employee28
    {
        public double MonthlySalary { get; set; }
        public SalariedEmployee28(string n, double s) : base(n) { MonthlySalary = s; }
        public override double CalculateSalary() => MonthlySalary;
    }
    class CommissionEmployee28 : Employee28
    {
        public double Sales { get; set; }
        public double Percent { get; set; }
        public CommissionEmployee28(string n, double s, double p) : base(n) { Sales = s; Percent = p; }
        public override double CalculateSalary() => Sales * Percent / 100;
    }

    // ==================== 29. Полиморфизм + наследование ====================
    class Animal29
    {
        public string Name { get; set; }
        public Animal29(string name) { Name = name; }
        public virtual void MakeSound() => Console.WriteLine($"{Name}: ...");
    }
    class Dog29 : Animal29
    {
        public Dog29() : base("Собака") { }
        public override void MakeSound() => Console.WriteLine("Собака: Гав!");
    }
    class Cat29 : Animal29
    {
        public Cat29() : base("Кошка") { }
        public override void MakeSound() => Console.WriteLine("Кошка: Мяу!");
    }
    class Cow29 : Animal29
    {
        public Cow29() : base("Корова") { }
        public override void MakeSound() => Console.WriteLine("Корова: Му!");
    }
    class Duck29 : Animal29
    {
        public Duck29() : base("Утка") { }
        public override void MakeSound() => Console.WriteLine("Утка: Кря!");
    }
    class Pig29 : Animal29
    {
        public Pig29() : base("Свинья") { }
        public override void MakeSound() => Console.WriteLine("Свинья: Хрю!");
    }

    // ==================== 30. Итоговое — система автопарка ====================
    abstract class Vehicle30
    {
        public string Brand { get; set; }
        public double Speed { get; set; }
        public double Price { get; set; }
        public double FuelConsumption { get; set; }

        protected Vehicle30(string b, double s, double p, double f)
        {
            Brand = b; Speed = s; Price = p; FuelConsumption = f;
        }

        public abstract void Move();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name}: {Brand}, {Speed} км/ч, {Price}$, расход {FuelConsumption} л/100км");
        }

        public virtual double CalculateFuel(double distance) => FuelConsumption * distance / 100;
    }
    class Car30 : Vehicle30
    {
        public int Doors { get; set; }
        public Car30(string b, double s, double p, double f, int d) : base(b, s, p, f) { Doors = d; }
        public override void Move() => Console.WriteLine($"{Brand} (авто) едет по дороге");
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"  Дверей: {Doors}");
        }
    }
    class Truck30 : Vehicle30
    {
        public double LoadCapacity { get; set; }
        public Truck30(string b, double s, double p, double f, double c) : base(b, s, p, f) { LoadCapacity = c; }
        public override void Move() => Console.WriteLine($"{Brand} (грузовик) перевозит груз");
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"  Грузоподъёмность: {LoadCapacity} т");
        }
    }
    class Bus30 : Vehicle30
    {
        public int Passengers { get; set; }
        public Bus30(string b, double s, double p, double f, int pass) : base(b, s, p, f) { Passengers = pass; }
        public override void Move() => Console.WriteLine($"{Brand} (автобус) везёт пассажиров");
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"  Пассажиров: {Passengers}");
        }
    }
    class ElectricCar30 : Vehicle30
    {
        public double BatteryCapacity { get; set; }
        public ElectricCar30(string b, double s, double p, double bat) : base(b, s, p, 0) { BatteryCapacity = bat; }
        public override void Move() => Console.WriteLine($"{Brand} (электро) едет бесшумно");
        public override double CalculateFuel(double d) => 0;
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"  Батарея: {BatteryCapacity} кВт·ч");
        }
    }
    class Motorcycle30 : Vehicle30
    {
        public bool HasSidecar { get; set; }
        public Motorcycle30(string b, double s, double p, double f, bool side) : base(b, s, p, f) { HasSidecar = side; }
        public override void Move() => Console.WriteLine($"{Brand} (мото) мчится по трассе");
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"  Коляска: {(HasSidecar ? "да" : "нет")}");
        }
    }
    class Fleet30
    {
        private List<Vehicle30> vehicles = new List<Vehicle30>();
        public void Add(Vehicle30 v) => vehicles.Add(v);
        public void Remove(Vehicle30 v) => vehicles.Remove(v);
        public void PrintAll()
        {
            Console.WriteLine("=== Автопарк ===");
            foreach (var v in vehicles)
            {
                v.PrintInfo();
                v.Move();
                Console.WriteLine();
            }
        }
        public Vehicle30 Fastest() => vehicles.OrderByDescending(v => v.Speed).FirstOrDefault();
        public Vehicle30 MostExpensive() => vehicles.OrderByDescending(v => v.Price).FirstOrDefault();
        public double TotalFuel(double dist) => vehicles.Sum(v => v.CalculateFuel(dist));
    }

    // ==================== ГЛАВНЫЙ КЛАСС ====================
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1
            Console.WriteLine("=== 1. Животное ===");
            new Animal1().Speak();
            new Dog1().Speak();
            new Cat1().Speak();
            Console.WriteLine();

            // 2
            Console.WriteLine("=== 2. Транспорт ===");
            new Car2("Toyota", 180, 4).ShowInfo();
            new Motorcycle2("Yamaha", 200, false).ShowInfo();
            Console.WriteLine();

            // 3
            Console.WriteLine("=== 3. Человек и студент ===");
            new Student3("Иван", 20, "Программирование", 3).Print();
            Console.WriteLine();

            // 4
            Console.WriteLine("=== 4. Сотрудники ===");
            new Manager4("Анна", 100000, 5).Show();
            new Developer4("Пётр", 90000, "C#").Show();
            Console.WriteLine();

            // 5
            Console.WriteLine("=== 5. Фигуры ===");
            Console.WriteLine($"Прямоугольник: {new Rectangle5(4, 5).GetArea()}");
            Console.WriteLine($"Круг: {new Circle5(3).GetArea():F2}");
            Console.WriteLine();

            // 6
            Console.WriteLine("=== 6. Транспорт с методом движения ===");
            new Car6().Move();
            new Bus6().Move();
            new Train6().Move();
            Console.WriteLine();

            // 7
            Console.WriteLine("=== 7. Работник магазина ===");
            new Cashier7("Ольга").Work();
            new Seller7("Сергей").Work();
            Console.WriteLine();

            // 8
            Console.WriteLine("=== 8. Компьютеры ===");
            new Laptop8("Intel i7", 16, 1.8).Info();
            new Desktop8("AMD Ryzen 9", 32, "Full Tower").Info();
            Console.WriteLine();

            // 9
            Console.WriteLine("=== 9. Книги ===");
            new PaperBook9("Война и мир", "Толстой", 1225).Info();
            new EBook9("C# in Depth", "Skeet", 5.2).Info();
            Console.WriteLine();

            // 10
            Console.WriteLine("=== 10. Домашние животные ===");
            new Dog10().Eat();
            new Cat10().Eat();
            new Parrot10().Eat();
            Console.WriteLine();

            // 11
            Console.WriteLine("=== 11. Банковские счета ===");
            var sa = new SavingsAccount11(0.05) { Balance = 1000 };
            sa.Deposit(500);
            sa.AddInterest();
            sa.Show();
            var ca = new CreditAccount11 { Balance = 100, CreditLimit = 500 };
            ca.Withdraw(400);
            ca.Show();
            Console.WriteLine();

            // 12
            Console.WriteLine("=== 12. Транспортная компания ===");
            Console.WriteLine($"Car: {new Car12().CalculateCost(100)}");
            Console.WriteLine($"Truck: {new Truck12().CalculateCost(100)}");
            Console.WriteLine($"Bus: {new Bus12().CalculateCost(100)}");
            Console.WriteLine();

            // 13
            Console.WriteLine("=== 13. Работники компании ===");
            Console.WriteLine($"Программист: {new Programmer13("Иван", 160, 500).GetSalary()}");
            Console.WriteLine($"Дизайнер: {new Designer13("Мария", 3, 20000).GetSalary()}");
            Console.WriteLine($"Менеджер: {new Manager13("Олег", 80000, 15000).GetSalary()}");
            Console.WriteLine();

            // 14
            Console.WriteLine("=== 14. Система образования ===");
            new GraduateStudent14("Алексей", 24, "МГУ", "ИИ в медицине").PrintAll();
            Console.WriteLine();

            // 15
            Console.WriteLine("=== 15. Военная техника ===");
            new Tank15().Attack();
            new Helicopter15().Attack();
            new ArmoredCar15().Attack();
            Console.WriteLine();

            // 16
            Console.WriteLine("=== 16. Игровые персонажи ===");
            new Warrior16("Конан", 150, 20).Attack();
            new Mage16("Гэндальф", 90, 30).Attack();
            new Archer16("Леголас", 110, 25).Attack();
            Console.WriteLine();

            // 17
            Console.WriteLine("=== 17. Электронные устройства ===");
            new Phone17().TurnOn();
            new Computer17().TurnOn();
            new Television17().TurnOff();
            Console.WriteLine();

            // 18
            Console.WriteLine("=== 18. Платежи ===");
            new CashPayment18().Pay(1000);
            new CardPayment18().Pay(2500);
            new OnlinePayment18().Pay(700);
            Console.WriteLine();

            // 19
            Console.WriteLine("=== 19. Сотрудники с бонусами ===");
            Console.WriteLine($"Manager: {new Manager19("A", 100000).GetTotal()}");
            Console.WriteLine($"Developer: {new Developer19("B", 80000).GetTotal()}");
            Console.WriteLine($"SalesManager: {new SalesManager19("C", 70000).GetTotal()}");
            Console.WriteLine();

            // 20
            Console.WriteLine("=== 20. Животные зоопарка ===");
            var zoo = new List<Animal20> { new Lion20(), new Elephant20(), new Monkey20(), new Penguin20(), new Snake20() };
            foreach (var a in zoo) { a.Eat(); a.MakeSound(); }
            Console.WriteLine();

            // 21
            Console.WriteLine("=== 21. Абстрактные фигуры ===");
            Console.WriteLine($"Круг: {new Circle21(3).GetArea():F2}");
            Console.WriteLine($"Прямоугольник: {new Rectangle21(4, 5).GetArea()}");
            Console.WriteLine($"Треугольник: {new Triangle21(6, 4).GetArea()}");
            Console.WriteLine($"Квадрат: {new Square21(5).GetArea()}");
            Console.WriteLine();

            // 22
            Console.WriteLine("=== 22. Интернет-магазин ===");
            Console.WriteLine($"Электроника: {new Electronics22("TV", 1000, 10).GetFinalPrice()}");
            Console.WriteLine($"Одежда: {new Clothing22("Футболка", 500, 20).GetFinalPrice()}");
            Console.WriteLine($"Еда: {new Food22("Хлеб", 50, 12).GetFinalPrice()}");
            Console.WriteLine();

            // 23
            Console.WriteLine("=== 23. Система транспорта ===");
            var trans = new List<Transport23> { new Car23(), new Truck23(), new Bus23(), new Motorcycle23() };
            foreach (var t in trans) { t.Move(); Console.WriteLine($"  Расход: {t.GetFuelConsumption()}"); }
            Console.WriteLine();

            // 24
            Console.WriteLine("=== 24. Больница ===");
            new Doctor24("Иванов").Work();
            new Nurse24("Петрова").Work();
            new Surgeon24("Сидоров").Work();
            Console.WriteLine();

            // 25
            Console.WriteLine("=== 25. Система сотрудников с уровнями ===");
            var dir = new Director25("Смирнов", 50, 300000, "IT", 20, 50000, "ООО Ромашка", 1000);
            dir.Greet();
            dir.ShowSalary();
            dir.Manage();
            dir.Lead();
            Console.WriteLine();

            // 26
            Console.WriteLine("=== 26. Игра: персонажи ===");
            var chars = new List<Character26> { new Warrior26("Воин"), new Mage26("Маг"), new Archer26("Лучник") };
            foreach (var c in chars)
            {
                c.Attack();
                c.Defend();
                c.SpecialAttack();
                Console.WriteLine();
            }

            // 27
            Console.WriteLine("=== 27. Файлы ===");
            new TextFile27("doc.txt", 0.1, "UTF-8").Open();
            new ImageFile27("photo.jpg", 2.5, 1920, 1080).Open();
            new VideoFile27("movie.mp4", 700, 7200).Open();
            Console.WriteLine();

            // 28
            Console.WriteLine("=== 28. Система оплаты зарплаты ===");
            var emps = new List<Employee28>
            {
                new HourlyEmployee28("Иван", 500, 160),
                new SalariedEmployee28("Мария", 80000),
                new CommissionEmployee28("Пётр", 500000, 10)
            };
            double total = 0;
            foreach (var e in emps)
            {
                double s = e.CalculateSalary();
                Console.WriteLine($"{e.Name}: {s}");
                total += s;
            }
            Console.WriteLine($"Общий фонд: {total}");
            Console.WriteLine();

            // 29
            Console.WriteLine("=== 29. Полиморфизм + наследование ===");
            var animals = new List<Animal29>
            {
                new Dog29(), new Cat29(), new Cow29(), new Duck29(), new Pig29()
            };
            foreach (var a in animals) a.MakeSound();
            Console.WriteLine();

            // 30
            Console.WriteLine("=== 30. Итоговое — система автопарка ===");
            var fleet = new Fleet30();
            fleet.Add(new Car30("Toyota", 180, 20000, 7.5, 4));
            fleet.Add(new Truck30("Volvo", 100, 80000, 25, 20));
            fleet.Add(new Bus30("Mercedes", 120, 120000, 18, 50));
            fleet.Add(new ElectricCar30("Tesla", 250, 60000, 100));
            fleet.Add(new Motorcycle30("Yamaha", 200, 15000, 4, false));

            fleet.PrintAll();

            Console.WriteLine($"Самый быстрый: {fleet.Fastest()?.Brand} ({fleet.Fastest()?.Speed} км/ч)");
            Console.WriteLine($"Самый дорогой: {fleet.MostExpensive()?.Brand} ({fleet.MostExpensive()?.Price}$)");
            Console.WriteLine($"Общий расход на 1000 км: {fleet.TotalFuel(1000):F2} л");

            Console.WriteLine("\n=== ГОТОВО ===");
            Console.ReadKey();
        }
    }
}