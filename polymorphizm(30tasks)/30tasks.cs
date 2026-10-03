using System;
using System.Collections.Generic;

namespace PolymorphismTasks
{
    // =========================================================
    // 1. Животные
    // =========================================================
    public class Animal
    {
        public virtual void MakeSound() => Console.WriteLine("Животное издаёт звук");
    }

    public class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Собака: Гав-гав");
    }

    public class Cat : Animal
    {
        public override void MakeSound() => Console.WriteLine("Кошка: Мяу");
    }

    public class Cow : Animal
    {
        public override void MakeSound() => Console.WriteLine("Корова: Му-у");
    }

    // =========================================================
    // 2. Транспорт
    // =========================================================
    public class Vehicle
    {
        public virtual void Move() => Console.WriteLine("Транспорт движется");
    }

    public class Car : Vehicle
    {
        public override void Move() => Console.WriteLine("Машина едет по дороге");
    }

    public class Bike : Vehicle
    {
        public override void Move() => Console.WriteLine("Велосипед едет по велодорожке");
    }

    public class Bus : Vehicle
    {
        public override void Move() => Console.WriteLine("Автобус везёт пассажиров");
    }

    // =========================================================
    // 3. Работники
    // =========================================================
    public class EmployeeBase
    {
        public virtual void Work() => Console.WriteLine("Работник работает");
    }

    public class Programmer : EmployeeBase
    {
        public override void Work() => Console.WriteLine("Программист пишет код");
    }

    public class Teacher : EmployeeBase
    {
        public override void Work() => Console.WriteLine("Учитель учит детей");
    }

    public class Doctor : EmployeeBase
    {
        public override void Work() => Console.WriteLine("Врач лечит пациентов");
    }

    // =========================================================
    // 4. Фигуры
    // =========================================================
    public class Shape
    {
        public virtual double GetArea() => 0;
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea() => Width * Height;
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea() => Math.PI * Radius * Radius;
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double GetArea() => 0.5 * Base * Height;
    }

    // =========================================================
    // 5. Банковские счета
    // =========================================================
    public class BankAccount
    {
        public virtual double CalculateInterest() => 0;
    }

    public class SavingsAccount : BankAccount
    {
        public override double CalculateInterest() => 5.0;
    }

    public class BusinessAccount : BankAccount
    {
        public override double CalculateInterest() => 2.5;
    }

    // =========================================================
    // 6. Игроки
    // =========================================================
    public class Player
    {
        public virtual void Attack() => Console.WriteLine("Игрок атакует");
    }

    public class Warrior : Player
    {
        public override void Attack() => Console.WriteLine("Воин бьёт мечом");
    }

    public class Archer : Player
    {
        public override void Attack() => Console.WriteLine("Лучник стреляет из лука");
    }

    public class Mage : Player
    {
        public override void Attack() => Console.WriteLine("Маг кастует заклинание");
    }

    // =========================================================
    // 7. Устройства
    // =========================================================
    public class Device
    {
        public virtual void TurnOn() => Console.WriteLine("Устройство включено");
    }

    public class Phone : Device
    {
        public override void TurnOn() => Console.WriteLine("Телефон включается");
    }

    public class Computer : Device
    {
        public override void TurnOn() => Console.WriteLine("Компьютер загружается");
    }

    public class Television : Device
    {
        public override void TurnOn() => Console.WriteLine("Телевизор показывает изображение");
    }

    // =========================================================
    // 8. Музыкальные инструменты
    // =========================================================
    public class Instrument
    {
        public virtual void Play() => Console.WriteLine("Инструмент играет");
    }

    public class Guitar : Instrument
    {
        public override void Play() => Console.WriteLine("Гитара: бренчание струн");
    }

    public class Piano : Instrument
    {
        public override void Play() => Console.WriteLine("Пианино: классическая мелодия");
    }

    public class Drums : Instrument
    {
        public override void Play() => Console.WriteLine("Барабаны: ритм");
    }

    // =========================================================
    // 9. Птицы
    // =========================================================
    public class Bird
    {
        public virtual void Fly() => Console.WriteLine("Птица летит");
    }

    public class Eagle : Bird
    {
        public override void Fly() => Console.WriteLine("Орёл парит высоко в небе");
    }

    public class Penguin : Bird
    {
        public override void Fly() => Console.WriteLine("Пингвин не летает, он плавает");
    }

    public class Sparrow : Bird
    {
        public override void Fly() => Console.WriteLine("Воробей быстро летает");
    }

    // =========================================================
    // 10. Сотрудники и зарплата
    // =========================================================
    public class EmployeeSalary
    {
        public virtual double CalculateSalary() => 0;
    }

    public class Manager : EmployeeSalary
    {
        public override double CalculateSalary() => 80000;
    }

    public class Developer : EmployeeSalary
    {
        public override double CalculateSalary() => 120000;
    }

    public class Intern : EmployeeSalary
    {
        public override double CalculateSalary() => 30000;
    }

    // =========================================================
    // 11. Система оплаты
    // =========================================================
    public class Payment
    {
        public virtual void Pay() => Console.WriteLine("Оплата произведена");
    }

    public class CashPayment : Payment
    {
        public override void Pay() => Console.WriteLine("Оплата наличными");
    }

    public class CardPayment : Payment
    {
        public override void Pay() => Console.WriteLine("Оплата картой");
    }

    public class CryptoPayment : Payment
    {
        public override void Pay() => Console.WriteLine("Оплата криптовалютой");
    }

    // =========================================================
    // 12. Уведомления
    // =========================================================
    public class Notification
    {
        public virtual void Send() => Console.WriteLine("Уведомление отправлено");
    }

    public class EmailNotification : Notification
    {
        public override void Send() => Console.WriteLine("Email отправлен");
    }

    public class SmsNotification : Notification
    {
        public override void Send() => Console.WriteLine("SMS отправлено");
    }

    public class PushNotification : Notification
    {
        public override void Send() => Console.WriteLine("Push-уведомление отправлено");
    }

    // =========================================================
    // 13. Доставка
    // =========================================================
    public class Delivery
    {
        public virtual double CalculatePrice() => 0;
    }

    public class CourierDelivery : Delivery
    {
        public override double CalculatePrice() => 300;
    }

    public class PostDelivery : Delivery
    {
        public override double CalculatePrice() => 150;
    }

    public class ExpressDelivery : Delivery
    {
        public override double CalculatePrice() => 600;
    }

    // =========================================================
    // 14. Система скидок
    // =========================================================
    public class Discount
    {
        public virtual decimal CalculateDiscount(decimal price) => 0;
    }

    public class StudentDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price) => price * 0.10m;
    }

    public class VipDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price) => price * 0.20m;
    }

    public class SeasonalDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price) => price * 0.15m;
    }

    // =========================================================
    // 15. Роботы
    // =========================================================
    public class Robot
    {
        public virtual void PerformTask() => Console.WriteLine("Робот выполняет задачу");
    }

    public class CleaningRobot : Robot
    {
        public override void PerformTask() => Console.WriteLine("Робот-уборщик убирает");
    }

    public class SecurityRobot : Robot
    {
        public override void PerformTask() => Console.WriteLine("Робот-охранник патрулирует");
    }

    public class DeliveryRobot : Robot
    {
        public override void PerformTask() => Console.WriteLine("Робот-доставщик везёт посылку");
    }

    // =========================================================
    // 16. Геометрические фигуры
    // =========================================================
    public abstract class Shape2
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle2 : Shape2
    {
        public double Radius { get; set; }
        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }

    public class Rectangle2 : Shape2
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => 2 * (Width + Height);
    }

    public class Square2 : Shape2
    {
        public double Side { get; set; }
        public override double GetArea() => Side * Side;
        public override double GetPerimeter() => 4 * Side;
    }

    public class Triangle2 : Shape2
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double GetPerimeter() => A + B + C;
    }

    // =========================================================
    // 17. Система транспорта
    // =========================================================
    public abstract class Transport
    {
        public abstract double GetSpeed();
    }

    public class CarT : Transport
    {
        public override double GetSpeed() => 90;
    }

    public class Train : Transport
    {
        public override double GetSpeed() => 120;
    }

    public class Airplane : Transport
    {
        public override double GetSpeed() => 800;
    }

    public class Ship : Transport
    {
        public override double GetSpeed() => 40;
    }

    // =========================================================
    // 18. Зарплата сотрудников
    // =========================================================
    public abstract class Employee2
    {
        public abstract double CalculateSalary();
    }

    public class Manager2 : Employee2
    {
        public override double CalculateSalary() => 90000;
    }

    public class Developer2 : Employee2
    {
        public override double CalculateSalary() => 130000;
    }

    public class SalesManager : Employee2
    {
        public override double CalculateSalary() => 100000;
    }

    // =========================================================
    // 19. Интернет-магазин
    // =========================================================
    public class ProductBase
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }

        public virtual decimal GetFinalPrice() => Price;
    }

    public class Electronics : ProductBase
    {
        public override decimal GetFinalPrice() => Price * 1.20m;
    }

    public class Food : ProductBase
    {
        public override decimal GetFinalPrice() => Price * 1.10m;
    }

    public class Clothing : ProductBase
    {
        public override decimal GetFinalPrice() => Price * 1.15m;
    }

    // =========================================================
    // 20. Система сообщений
    // =========================================================
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message) => Console.WriteLine($"Email: {message}");
    }

    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message) => Console.WriteLine($"SMS: {message}");
    }

    public class TelegramSender : IMessageSender
    {
        public void SendMessage(string message) => Console.WriteLine($"Telegram: {message}");
    }

    // =========================================================
    // 21. Платёжная система
    // =========================================================
    public interface IPaymentMethod
    {
        void Pay();
        void Refund();
    }

    public class BankCard : IPaymentMethod
    {
        public void Pay() => Console.WriteLine("Оплата банковской картой");
        public void Refund() => Console.WriteLine("Возврат на банковскую карту");
    }

    public class PayPal : IPaymentMethod
    {
        public void Pay() => Console.WriteLine("Оплата через PayPal");
        public void Refund() => Console.WriteLine("Возврат через PayPal");
    }

    public class CryptoWallet : IPaymentMethod
    {
        public void Pay() => Console.WriteLine("Оплата криптокошельком");
        public void Refund() => Console.WriteLine("Возврат в криптокошелёк");
    }

    // =========================================================
    // 22. Система сотрудников компании
    // =========================================================
    public abstract class Employee3
    {
        public abstract void Work();
        public abstract double CalculateSalary();
    }

    public class Developer3 : Employee3
    {
        public override void Work() => Console.WriteLine("Разработчик пишет код");
        public override double CalculateSalary() => 140000;
    }

    public class Manager3 : Employee3
    {
        public override void Work() => Console.WriteLine("Менеджер управляет проектами");
        public override double CalculateSalary() => 100000;
    }

    public class Designer : Employee3
    {
        public override void Work() => Console.WriteLine("Дизайнер рисует макеты");
        public override double CalculateSalary() => 90000;
    }

    public class Tester : Employee3
    {
        public override void Work() => Console.WriteLine("Тестировщик проверяет баги");
        public override double CalculateSalary() => 80000;
    }

    // =========================================================
    // 23. Игра — персонажи
    // =========================================================
    public abstract class Character
    {
        public abstract void Attack();
    }

    public class Warrior3 : Character
    {
        public override void Attack() => Console.WriteLine("Воин атакует мечом");
    }

    public class Mage3 : Character
    {
        public override void Attack() => Console.WriteLine("Маг атакует огненным шаром");
    }

    public class Archer3 : Character
    {
        public override void Attack() => Console.WriteLine("Лучник атакует стрелой");
    }

    public class Assassin : Character
    {
        public override void Attack() => Console.WriteLine("Ассасин атакует из-под тишка");
    }

    // =========================================================
    // 24. Больница
    // =========================================================
    public class MedicalWorker
    {
        public virtual void TreatPatient() => Console.WriteLine("Медик лечит пациента");
    }

    public class Doctor2 : MedicalWorker
    {
        public override void TreatPatient() => Console.WriteLine("Врач лечит пациента");
    }

    public class Surgeon : MedicalWorker
    {
        public override void TreatPatient() => Console.WriteLine("Хирург делает операцию");
    }

    public class Nurse : MedicalWorker
    {
        public override void TreatPatient() => Console.WriteLine("Медсестра ухаживает за пациентом");
    }

    public class Dentist : MedicalWorker
    {
        public override void TreatPatient() => Console.WriteLine("Стоматолог лечит зубы");
    }

    // =========================================================
    // 25. Файловая система
    // =========================================================
    public abstract class FileBase
    {
        public abstract void Open();
    }

    public class TextFile : FileBase
    {
        public override void Open() => Console.WriteLine("Открыт текстовый файл");
    }

    public class ImageFile : FileBase
    {
        public override void Open() => Console.WriteLine("Открыто изображение");
    }

    public class VideoFile : FileBase
    {
        public override void Open() => Console.WriteLine("Открыто видео");
    }

    public class AudioFile : FileBase
    {
        public override void Open() => Console.WriteLine("Открыт аудиофайл");
    }

    // =========================================================
    // 26. Система отчетов
    // =========================================================
    public interface IReport
    {
        void Generate();
    }

    public class SalesReport : IReport
    {
        public void Generate() => Console.WriteLine("Сгенерирован отчёт по продажам");
    }

    public class FinancialReport : IReport
    {
        public void Generate() => Console.WriteLine("Сгенерирован финансовый отчёт");
    }

    public class EmployeeReport : IReport
    {
        public void Generate() => Console.WriteLine("Сгенерирован отчёт по сотрудникам");
    }

    // =========================================================
    // 27. Умный дом
    // =========================================================
    public class SmartDevice
    {
        public virtual void TurnOn() => Console.WriteLine("Устройство включено");
        public virtual void TurnOff() => Console.WriteLine("Устройство выключено");
    }

    public class SmartLight : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Умная лампа включена");
        public override void TurnOff() => Console.WriteLine("Умная лампа выключена");
    }

    public class SmartTV : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Умный телевизор включён");
        public override void TurnOff() => Console.WriteLine("Умный телевизор выключен");
    }

    public class SmartThermostat : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Термостат включён");
        public override void TurnOff() => Console.WriteLine("Термостат выключен");
    }

    public class SecurityCamera : SmartDevice
    {
        public override void TurnOn() => Console.WriteLine("Камера наблюдения включена");
        public override void TurnOff() => Console.WriteLine("Камера наблюдения выключена");
    }

    public class SmartHomeController
    {
        private readonly List<SmartDevice> _devices = new();

        public void AddDevice(SmartDevice device) => _devices.Add(device);

        public void TurnAllOn()
        {
            foreach (var device in _devices)
                device.TurnOn();
        }

        public void TurnAllOff()
        {
            foreach (var device in _devices)
                device.TurnOff();
        }
    }

    // =========================================================
    // 28. Система заказов
    // =========================================================
    public abstract class Order
    {
        public abstract double CalculateTotal();
    }

    public class FoodOrder : Order
    {
        public override double CalculateTotal() => 500;
    }

    public class ClothingOrder : Order
    {
        public override double CalculateTotal() => 1500;
    }

    public class ElectronicsOrder : Order
    {
        public override double CalculateTotal() => 5000;
    }

    // =========================================================
    // 29. Такси-сервис
    // =========================================================
    public interface IRide
    {
        void StartRide();
        double CalculateCost();
    }

    public class EconomyRide : IRide
    {
        public void StartRide() => Console.WriteLine("Эконом-поездка началась");
        public double CalculateCost() => 200;
    }

    public class ComfortRide : IRide
    {
        public void StartRide() => Console.WriteLine("Комфорт-поездка началась");
        public double CalculateCost() => 400;
    }

    public class BusinessRide : IRide
    {
        public void StartRide() => Console.WriteLine("Бизнес-поездка началась");
        public double CalculateCost() => 800;
    }

    // =========================================================
    // 30. Мини-система интернет-магазина
    // =========================================================
    public interface IDiscount
    {
        decimal Apply(decimal price);
    }

    public class NoDiscount : IDiscount
    {
        public decimal Apply(decimal price) => price;
    }

    public class PercentDiscount : IDiscount
    {
        private readonly decimal _percent;
        public PercentDiscount(decimal percent) => _percent = percent;
        public decimal Apply(decimal price) => price - price * _percent / 100m;
    }

    public class Product30
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public IDiscount Discount { get; set; } = new NoDiscount();

        public virtual decimal GetFinalPrice() => Discount.Apply(Price);
    }

    public class Electronics30 : Product30
    {
        public override decimal GetFinalPrice() => Discount.Apply(Price * 1.20m);
    }

    public class Food30 : Product30
    {
        public override decimal GetFinalPrice() => Discount.Apply(Price * 1.10m);
    }

    public class Clothing30 : Product30
    {
        public override decimal GetFinalPrice() => Discount.Apply(Price * 1.15m);
    }

    // =========================================================
    // MAIN
    // =========================================================
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== 1. Животные ===");
            List<Animal> animals = new() { new Dog(), new Cat(), new Cow() };
            animals.ForEach(a => a.MakeSound());

            Console.WriteLine("\n=== 2. Транспорт ===");
            List<Vehicle> vehicles = new() { new Car(), new Bike(), new Bus() };
            vehicles.ForEach(v => v.Move());

            Console.WriteLine("\n=== 3. Работники ===");
            List<EmployeeBase> workers = new() { new Programmer(), new Teacher(), new Doctor() };
            workers.ForEach(w => w.Work());

            Console.WriteLine("\n=== 4. Фигуры ===");
            List<Shape> shapes = new()
            {
                new Rectangle { Width = 3, Height = 4 },
                new Circle { Radius = 2 },
                new Triangle { Base = 5, Height = 6 }
            };
            shapes.ForEach(s => Console.WriteLine($"Площадь: {s.GetArea():F2}"));

            Console.WriteLine("\n=== 5. Банковские счета ===");
            List<BankAccount> accounts = new() { new SavingsAccount(), new BusinessAccount() };
            accounts.ForEach(a => Console.WriteLine($"Процент: {a.CalculateInterest()}%"));

            Console.WriteLine("\n=== 6. Игроки ===");
            List<Player> players = new() { new Warrior(), new Archer(), new Mage() };
            players.ForEach(p => p.Attack());

            Console.WriteLine("\n=== 7. Устройства ===");
            List<Device> devices = new() { new Phone(), new Computer(), new Television() };
            devices.ForEach(d => d.TurnOn());

            Console.WriteLine("\n=== 8. Музыкальные инструменты ===");
            List<Instrument> instruments = new() { new Guitar(), new Piano(), new Drums() };
            instruments.ForEach(i => i.Play());

            Console.WriteLine("\n=== 9. Птицы ===");
            List<Bird> birds = new() { new Eagle(), new Penguin(), new Sparrow() };
            birds.ForEach(b => b.Fly());

            Console.WriteLine("\n=== 10. Сотрудники и зарплата ===");
            List<EmployeeSalary> salaries = new() { new Manager(), new Developer(), new Intern() };
            salaries.ForEach(s => Console.WriteLine($"Зарплата: {s.CalculateSalary()}"));

            Console.WriteLine("\n=== 11. Система оплаты ===");
            List<Payment> payments = new() { new CashPayment(), new CardPayment(), new CryptoPayment() };
            payments.ForEach(p => p.Pay());

            Console.WriteLine("\n=== 12. Уведомления ===");
            List<Notification> notifications = new() { new EmailNotification(), new SmsNotification(), new PushNotification() };
            notifications.ForEach(n => n.Send());

            Console.WriteLine("\n=== 13. Доставка ===");
            List<Delivery> deliveries = new() { new CourierDelivery(), new PostDelivery(), new ExpressDelivery() };
            deliveries.ForEach(d => Console.WriteLine($"Стоимость доставки: {d.CalculatePrice()}"));

            Console.WriteLine("\n=== 14. Система скидок ===");
            List<Discount> discounts = new() { new StudentDiscount(), new VipDiscount(), new SeasonalDiscount() };
            discounts.ForEach(d => Console.WriteLine($"Скидка с 1000: {d.CalculateDiscount(1000):F2}"));

            Console.WriteLine("\n=== 15. Роботы ===");
            List<Robot> robots = new() { new CleaningRobot(), new SecurityRobot(), new DeliveryRobot() };
            robots.ForEach(r => r.PerformTask());

            Console.WriteLine("\n=== 16. Геометрические фигуры ===");
            List<Shape2> shapes2 = new()
            {
                new Circle2 { Radius = 3 },
                new Rectangle2 { Width = 4, Height = 5 },
                new Square2 { Side = 4 },
                new Triangle2 { A = 3, B = 4, C = 5 }
            };
            shapes2.ForEach(s =>
                Console.WriteLine($"Площадь: {s.GetArea():F2}, Периметр: {s.GetPerimeter():F2}"));

            Console.WriteLine("\n=== 17. Система транспорта ===");
            List<Transport> transports = new() { new CarT(), new Train(), new Airplane(), new Ship() };
            transports.ForEach(t => Console.WriteLine($"Скорость: {t.GetSpeed()} км/ч"));

            Console.WriteLine("\n=== 18. Зарплата сотрудников ===");
            List<Employee2> employees2 = new() { new Manager2(), new Developer2(), new SalesManager() };
            employees2.ForEach(e => Console.WriteLine($"Зарплата: {e.CalculateSalary()}"));

            Console.WriteLine("\n=== 19. Интернет-магазин ===");
            List<ProductBase> products = new()
            {
                new Electronics { Name = "Ноутбук", Price = 1000 },
                new Food { Name = "Хлеб", Price = 50 },
                new Clothing { Name = "Куртка", Price = 300 }
            };
            products.ForEach(p => Console.WriteLine($"{p.Name}: {p.GetFinalPrice():F2}"));

            Console.WriteLine("\n=== 20. Система сообщений ===");
            List<IMessageSender> senders = new() { new EmailSender(), new SmsSender(), new TelegramSender() };
            senders.ForEach(s => s.SendMessage("Привет!"));

            Console.WriteLine("\n=== 21. Платёжная система ===");
            List<IPaymentMethod> paymentMethods = new() { new BankCard(), new PayPal(), new CryptoWallet() };
            paymentMethods.ForEach(p =>
            {
                p.Pay();
                p.Refund();
            });

            Console.WriteLine("\n=== 22. Система сотрудников компании ===");
            List<Employee3> employees3 = new() { new Developer3(), new Manager3(), new Designer(), new Tester() };
            employees3.ForEach(e =>
            {
                e.Work();
                Console.WriteLine($"Зарплата: {e.CalculateSalary()}");
            });

            Console.WriteLine("\n=== 23. Игра — персонажи ===");
            List<Character> team = new() { new Warrior3(), new Mage3(), new Archer3(), new Assassin() };
            team.ForEach(c => c.Attack());

            Console.WriteLine("\n=== 24. Больница ===");
            List<MedicalWorker> medics = new() { new Doctor2(), new Surgeon(), new Nurse(), new Dentist() };
            medics.ForEach(m => m.TreatPatient());

            Console.WriteLine("\n=== 25. Файловая система ===");
            List<FileBase> files = new() { new TextFile(), new ImageFile(), new VideoFile(), new AudioFile() };
            files.ForEach(f => f.Open());

            Console.WriteLine("\n=== 26. Система отчетов ===");
            List<IReport> reports = new() { new SalesReport(), new FinancialReport(), new EmployeeReport() };
            reports.ForEach(r => r.Generate());

            Console.WriteLine("\n=== 27. Умный дом ===");
            var controller = new SmartHomeController();
            controller.AddDevice(new SmartLight());
            controller.AddDevice(new SmartTV());
            controller.AddDevice(new SmartThermostat());
            controller.AddDevice(new SecurityCamera());
            controller.TurnAllOn();
            controller.TurnAllOff();

            Console.WriteLine("\n=== 28. Система заказов ===");
            List<Order> orders = new() { new FoodOrder(), new ClothingOrder(), new ElectronicsOrder() };
            orders.ForEach(o => Console.WriteLine($"Сумма заказа: {o.CalculateTotal()}"));

            Console.WriteLine("\n=== 29. Такси-сервис ===");
            List<IRide> rides = new() { new EconomyRide(), new ComfortRide(), new BusinessRide() };
            rides.ForEach(r =>
            {
                r.StartRide();
                Console.WriteLine($"Стоимость: {r.CalculateCost()}");
            });

            Console.WriteLine("\n=== 30. Мини-система интернет-магазина ===");
            List<Product30> shopProducts = new()
            {
                new Electronics30 { Name = "Телефон", Price = 1000, Discount = new PercentDiscount(10) },
                new Food30 { Name = "Молоко", Price = 100, Discount = new NoDiscount() },
                new Clothing30 { Name = "Футболка", Price = 200, Discount = new PercentDiscount(5) }
            };

            decimal total = 0;
            foreach (var p in shopProducts)
            {
                decimal finalPrice = p.GetFinalPrice();
                total += finalPrice;
                Console.WriteLine($"{p.Name}: {finalPrice:F2}");
            }
            Console.WriteLine($"Итоговая стоимость: {total:F2}");
        }
    }
}