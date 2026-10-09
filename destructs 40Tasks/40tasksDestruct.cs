
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32.SafeHandles;

// 1. Student
class Student
{
    public string Name;

    public Student(string name) { Name = name; }
    ~Student() { Console.WriteLine($"Student {Name} удалён"); }
}

// 2. Car
class Car
{
    public string Brand;
    public int Year;

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    ~Car() { Console.WriteLine($"Автомобиль {Brand} завершил работу"); }
}

// 3. Book
class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    ~Book() { Console.WriteLine($"Книга удалена: {Title}"); }
}

// 4. Computer
class Computer
{
    public string Model;

    public Computer(string model) { Model = model; }
    ~Computer() { Console.WriteLine($"Компьютер {Model} освобождён"); }
}

// 5. Phone
class Phone
{
    public string Brand, Model;

    public Phone(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    ~Phone() { Console.WriteLine($"Телефон {Brand} {Model} удалён"); }
}

// 7. Product
class Product
{
    public static Product CreateProduct()
    {
        Console.WriteLine("Создан Product");
        return new Product();
    }

    ~Product() { Console.WriteLine("Product удалён"); }
}

// 8. TestObject
class TestObject
{
    ~TestObject() { Console.WriteLine("TestObject удалён"); }
}

// 9. Employee
class Employee
{
    public int Id;

    public Employee(int id) { Id = id; }
    ~Employee() { Console.WriteLine($"Employee ID={Id} удалён"); }
}

// 10. Counter
class Counter
{
    public static int Count;

    public Counter()
    {
        Count++;
        Console.WriteLine($"Counter создан. Всего: {Count}");
    }

    ~Counter()
    {
        Count--;
        Console.WriteLine($"Counter удалён. Осталось: {Count}");
    }
}

// 11. FileManager
class FileManager
{
    ~FileManager() { Console.WriteLine("Файловый ресурс освобождён"); }
}

// 12. Printer
class Printer
{
    public void Print() { Console.WriteLine("Печать документа"); }
    ~Printer() { Console.WriteLine("Принтер удалён"); }
}

// 13. Device
class Device
{
    public string Name;

    public Device(string name) { Name = name; }
    ~Device() { Console.WriteLine($"Device {Name} удалён"); }
}

// 15. BankAccount
class BankAccount
{
    public string Number, Owner;
    public double Balance;

    public BankAccount(string number, string owner, double balance)
    {
        Number = number;
        Owner = owner;
        Balance = balance;
    }

    ~BankAccount() { Console.WriteLine($"Счёт {Number} удалён"); }
}

// 16. LogObject
class LogObject
{
    public string Name;

    public LogObject(string name) { Name = name; }
    ~LogObject() { Console.WriteLine($"Журнал: объект {Name} удалён"); }
}

// 17. Animal
class Animal
{
    public string Name;

    public Animal(string name) { Name = name; }
    ~Animal() { Console.WriteLine($"Animal {Name} удалён"); }
}

// 18. DataObject
class DataObject
{
    public int Id;

    public DataObject(int id) { Id = id; }
    ~DataObject() { Console.WriteLine($"DataObject {Id} удалён"); }
}

// 19. Test
class Test
{
    public int Id;

    public Test(int id) { Id = id; }
    ~Test() { Console.WriteLine($"Test {Id} удалён"); }
}

// 20. ObjectTracker
class ObjectTracker
{
    public ObjectTracker() { Console.WriteLine("ObjectTracker создан"); }
    ~ObjectTracker() { Console.WriteLine("ObjectTracker уничтожается"); }
}

// 21–22. ResourceManager
class ResourceManager : IDisposable
{
    private bool disposed;

    public ResourceManager()
    {
        Console.WriteLine("ResourceManager создан");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
            Console.WriteLine("Управляемые ресурсы освобождены");

        Console.WriteLine("Ресурс ResourceManager освобождён");
        disposed = true;
    }

    ~ResourceManager()
    {
        Dispose(false);
    }
}

// 23. DatabaseConnection
class DatabaseConnection : IDisposable
{
    private bool disposed;

    public DatabaseConnection()
    {
        Console.WriteLine("Подключение к БД открыто");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        Console.WriteLine("Подключение к БД закрыто");
        disposed = true;
    }

    ~DatabaseConnection() { Dispose(false); }
}

// 24. FileResource
class FileResource : IDisposable
{
    private bool disposed;

    public FileResource()
    {
        Console.WriteLine("Файл условно открыт");
    }

    public void Dispose()
    {
        if (disposed) return;

        Console.WriteLine("Файл закрыт");
        disposed = true;
        GC.SuppressFinalize(this);
    }

    ~FileResource()
    {
        if (!disposed)
            Console.WriteLine("Файл освобождён финализатором");
    }
}

// 25–26. Наследование Device → Computer
class DeviceBase
{
    public DeviceBase() { Console.WriteLine("DeviceBase создан"); }
    ~DeviceBase() { Console.WriteLine("Деструктор DeviceBase"); }
}

class ComputerChild : DeviceBase
{
    public ComputerChild() { Console.WriteLine("ComputerChild создан"); }
    ~ComputerChild() { Console.WriteLine("Деструктор ComputerChild"); }
}

class Mammal : AnimalBase
{
    public Mammal() : base() { Console.WriteLine("Mammal создан"); }
    ~Mammal() { Console.WriteLine("Деструктор Mammal"); }
}

class AnimalBase
{
    public AnimalBase() { Console.WriteLine("AnimalBase создан"); }
    ~AnimalBase() { Console.WriteLine("Деструктор AnimalBase"); }
}

class Dog : Mammal
{
    public Dog() { Console.WriteLine("Dog создан"); }
    ~Dog() { Console.WriteLine("Деструктор Dog"); }
}

// 27–28. ResourceHolder
class ResourceHolder : IDisposable
{
    private bool _disposed;

    public ResourceHolder()
    {
        Console.WriteLine("Созданы условные ресурсы");
    }

    public void Dispose()
    {
        if (_disposed) return;

        Console.WriteLine("Ресурсы ResourceHolder освобождены");
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    ~ResourceHolder()
    {
        if (!_disposed)
            Console.WriteLine("Ресурсы освобождены финализатором");
    }
}

// 29–30. MyResource
class MyResource : IDisposable
{
    private bool disposed;

    public MyResource()
    {
        Console.WriteLine("MyResource создан");
    }

    public void Dispose()
    {
        if (disposed) return;

        Console.WriteLine("MyResource освобождён через Dispose");
        disposed = true;
        GC.SuppressFinalize(this);
    }

    ~MyResource()
    {
        if (!disposed)
            Console.WriteLine("MyResource освобождён финализатором");
    }
}

// 31. Собственный менеджер ресурсов
class CustomResourceManager : IDisposable
{
    private readonly List<MyResource> resources = new();
    private bool disposed;

    public void AddResource()
    {
        resources.Add(new MyResource());
        Console.WriteLine("Ресурс добавлен в список");
    }

    public void Dispose()
    {
        if (disposed) return;

        foreach (var resource in resources)
            resource.Dispose();

        resources.Clear();
        disposed = true;
        GC.SuppressFinalize(this);
        Console.WriteLine("Менеджер ресурсов закрыт");
    }

    ~CustomResourceManager()
    {
        if (!disposed)
            Console.WriteLine("Финализатор менеджера ресурсов");
    }
}

// 32. FileHandler
class FileHandler : IDisposable
{
    private FileStream stream;

    public FileHandler(string path)
    {
        stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        Console.WriteLine("FileStream открыт");
    }

    public void Dispose()
    {
        stream?.Dispose();
        stream = null;
        GC.SuppressFinalize(this);
        Console.WriteLine("FileStream закрыт");
    }

    ~FileHandler()
    {
        stream?.Dispose();
    }
}

// 33. DatabaseManager
class DatabaseManager : IDisposable
{
    private bool disposed;

    public DatabaseManager()
    {
        Console.WriteLine("DatabaseManager: подключение установлено");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        Console.WriteLine("DatabaseManager: подключение закрыто");
        disposed = true;
    }

    ~DatabaseManager() { Dispose(false); }
}

// 34. Иерархия ресурсов
class Resource : IDisposable
{
    protected bool disposed;

    public virtual void Dispose()
    {
        if (disposed) return;

        disposed = true;
        Console.WriteLine("Resource освобождён");
        GC.SuppressFinalize(this);
    }

    ~Resource()
    {
        if (!disposed)
            Console.WriteLine("Resource освобождён финализатором");
    }
}

class FileResourceChild : Resource
{
    public override void Dispose()
    {
        if (disposed) return;

        Console.WriteLine("Файловый ресурс закрыт");
        base.Dispose();
    }
}

class NetworkResource : FileResourceChild
{
    public override void Dispose()
    {
        if (disposed) return;

        Console.WriteLine("Сетевой ресурс закрыт");
        base.Dispose();
    }
}

// 37. SystemResource
class SystemResource : IDisposable
{
    private IntPtr handle;
    private bool disposed;

    public SystemResource()
    {
        handle = new IntPtr(1234); // Имитация дескриптора
        Console.WriteLine($"Системный ресурс создан: {handle}");
    }

    public void Dispose()
    {
        if (disposed) return;

        handle = IntPtr.Zero;
        disposed = true;
        GC.SuppressFinalize(this);
        Console.WriteLine("Системный ресурс освобождён");
    }

    ~SystemResource()
    {
        if (!disposed)
            Console.WriteLine("Освобождение системного ресурса финализатором");
    }
}

// 38. SafeHandle
class DemoSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
    public DemoSafeHandle() : base(true)
    {
        SetHandle(new IntPtr(5678));
        Console.WriteLine("SafeHandle создан");
    }

    protected override bool ReleaseHandle()
    {
        Console.WriteLine("SafeHandle: ресурс освобождён");
        handle = IntPtr.Zero;
        return true;
    }
}

// 39. AdvancedResource
class AdvancedResource : IDisposable
{
    private bool disposed;
    private readonly MemoryStream managedResource;
    private IntPtr unmanagedResource;

    public AdvancedResource()
    {
        managedResource = new MemoryStream();
        unmanagedResource = new IntPtr(9999);
        Console.WriteLine("AdvancedResource создан");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
            managedResource.Dispose();

        unmanagedResource = IntPtr.Zero;
        disposed = true;
        Console.WriteLine("AdvancedResource: ресурсы освобождены");
    }

    ~AdvancedResource() { Dispose(false); }
}

// 40. Главная программа
class Program
{
    static void CreateTemporaryObject()
    {
        TestObject obj = new TestObject();
    }

    static void Main()
    {
        Console.WriteLine("=== 1–5. Простые объекты ===");

        Student student = new Student("Diasbek");
        Car car = new Car("Toyota", 2022);
        Book book = new Book("Абай жолы", "Мухтар Ауэзов");
        Computer computer = new Computer("HP");
        Phone phone = new Phone("Samsung", "Galaxy");

        Console.WriteLine("\n=== 6. Пять студентов ===");
        Student[] students = new Student[5];

        for (int i = 0; i < students.Length; i++)
            students[i] = new Student($"Student {i + 1}");

        Console.WriteLine("\n=== 7. Создание объекта методом ===");
        Product product = Product.CreateProduct();

        Console.WriteLine("\n=== 8. Объект внутри метода ===");
        CreateTemporaryObject();

        Console.WriteLine("\n=== 9. Employee ===");
        Employee employee = new Employee(101);

        Console.WriteLine("\n=== 10. Counter ===");
        Counter c1 = new Counter();
        Counter c2 = new Counter();

        Console.WriteLine("\n=== 11–12. FileManager и Printer ===");
        FileManager fm = new FileManager();
        Printer printer = new Printer();
        printer.Print();

        Console.WriteLine("\n=== 13. Массив из 10 устройств ===");
        Device[] devices = new Device[10];

        for (int i = 0; i < devices.Length; i++)
            devices[i] = new Device($"Device {i + 1}");

        Console.WriteLine("\n=== 14. 20 объектов Person ===");
        List<LogObject> people = new List<LogObject>();

        for (int i = 1; i <= 20; i++)
            people.Add(new LogObject($"Person {i}"));

        Console.WriteLine("\n=== 15–17. Счёт, журнал и животные ===");
        BankAccount account = new BankAccount("KZ123", "Diasbek", 50000);
        LogObject log = new LogObject("Log 1");
        Animal cat = new Animal("Cat");
        Animal dog = new Animal("Dog");

        Console.WriteLine("\n=== 18. 100 объектов ===");
        List<DataObject> data = new List<DataObject>();

        for (int i = 1; i <= 100; i++)
            data.Add(new DataObject(i));

        Console.WriteLine("\n=== 19–20. GC и отслеживание ===");
        Test test1 = new Test(1);
        Test test2 = new Test(2);
        ObjectTracker tracker = new ObjectTracker();

        Console.WriteLine("\n=== 21–24. IDisposable и Dispose ===");
        using (ResourceManager rm = new ResourceManager()) { }
        using (DatabaseConnection db = new DatabaseConnection()) { }
        using (FileResource fr = new FileResource()) { }
        using (MyResource mr = new MyResource()) { }

        Console.WriteLine("\n=== 25–26. Наследование ===");
        ComputerChild child = new ComputerChild();
        Dog animal = new Dog();

        Console.WriteLine("\n=== 27–28. Несколько ресурсов ===");
        using (ResourceHolder holder = new ResourceHolder())
        {
            holder.Dispose();
        }

        Console.WriteLine("\n=== 31. Собственный менеджер ===");
        using (CustomResourceManager manager = new CustomResourceManager())
        {
            manager.AddResource();
            manager.AddResource();
        }

        Console.WriteLine("\n=== 32. Файловый поток ===");
        using (FileHandler handler = new FileHandler("test.txt")) { }

        Console.WriteLine("\n=== 33. Менеджер БД ===");
        using (DatabaseManager dbManager = new DatabaseManager()) { }

        Console.WriteLine("\n=== 34. Иерархия ресурсов ===");
        using (NetworkResource network = new NetworkResource()) { }

        Console.WriteLine("\n=== 37. Системный ресурс ===");
        using (SystemResource system = new SystemResource()) { }

        Console.WriteLine("\n=== 38. SafeHandle ===");
        using (DemoSafeHandle safe = new DemoSafeHandle()) { }

        Console.WriteLine("\n=== 39. AdvancedResource ===");
        using (AdvancedResource advanced = new AdvancedResource()) { }

        Console.WriteLine("\n=== 35–36. Сравнение производительности ===");

        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < 10000; i++)
            _ = new DataObject(i);

        GC.Collect();
        GC.WaitForPendingFinalizers();
        sw.Stop();

        Console.WriteLine($"Создание 10000 объектов с финализатором: {sw.ElapsedMilliseconds} мс");

        sw.Restart();

        for (int i = 0; i < 10000; i++)
            _ = new PlainObject();

        GC.Collect();
        sw.Stop();

        Console.WriteLine($"Создание 10000 объектов без финализатора: {sw.ElapsedMilliseconds} мс");

        Console.WriteLine("\n=== 40. Очистка объектов ===");

        // Освобождаем ссылки на созданные объекты.
        student = null;
        car = null;
        book = null;
        computer = null;
        phone = null;
        students = null;
        product = null;
        employee = null;
        c1 = null;
        c2 = null;
        fm = null;
        printer = null;
        devices = null;
        people = null;
        account = null;
        log = null;
        cat = null;
        dog = null;
        data = null;
        test1 = null;
        test2 = null;
        tracker = null;
        child = null;
        animal = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Console.WriteLine("\nПрограмма завершена.");
    }
}

// Класс без финализатора для сравнения
class PlainObject
{
}
