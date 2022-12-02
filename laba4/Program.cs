using System;

public class Computer
{
    protected int price;
    protected int action;
    protected string[] processor = {"intel", "amd"};
    
    public Computer()
    {
        while (true)
        {
            Console.WriteLine("Выбор сборки для ПК: ");
            Console.WriteLine("1. Сборка через процессор intel: ");
            Console.WriteLine("2. Сборка через процессор amd: ");
            action = int.Parse(Console.ReadLine());
            
            if (action == 1)
            {
                BuildPcToIntel();
            } else if (action == 2)
            {
                BulidToAmd();
            }
            else
            {
                Console.WriteLine("Ошибка!! Выберите корректный пункт: ");
                continue;
            }
            
            return;
        }
    }

    protected virtual Computer BuildPcToIntel()
    {
        Console.WriteLine("Информация о стационарном ПК: ");
        Console.WriteLine($"Процессор: {processor[0]} i5-10800H");
        Console.WriteLine("Видеокарта: AMD Radeon rx580 8gb");
        Console.WriteLine("Оперативная память: 16gb");
        Console.WriteLine("Блок питания: Cooler Master V550 на 550вт");
        Console.WriteLine("SSD: 1тб");

        while (true)
        {
            Console.WriteLine("Если вам так пк подходит, введите 1 для подтверждения покупки, если не подходит введите любое число кроме 1: ");
            action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Check();
            }
            else
            {
                return new Computer();
            }
        }
    }

    protected virtual Computer BulidToAmd()
    {
        Console.WriteLine("Информация о стационарном ПК: ");
        Console.WriteLine($"Процессор: {processor[1]} ryzen 5 3600");
        Console.WriteLine("Видеокарта: AMD Radeon rx580 8gb");
        Console.WriteLine("Оперативная память: 16gb");
        Console.WriteLine("Блок питания: Cooler Master V550 на 550вт");
        Console.WriteLine("SSD: 1тб");

        while (true)
        {
            Console.WriteLine("Если вам так пк подходит, введите 1 для подтверждения покупки, если не подходит введите любое число кроме 1: ");
            action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Check();
            }
            else
            {
                return new Computer();
            }
        }
    }
    
    protected virtual void Check()
    {
        Console.WriteLine("------------------------------------------------>");
        
        Console.WriteLine("Дополнительная информация: ");
        Console.WriteLine("Компьютер всегда должен быть под питанием, зарядки у ПК нет." + '\n' + 
                          "Системы поддержки wifi нет, подключение идёт только через LAN кабель." + '\n' +
                          "Для полной работы с ПК потребуется клавиатура + монитор + мышка."
        );
        price = 58000;
        Console.WriteLine($"Цена ПК: {price}");
        
        Environment.Exit(0);
    }
}

public class Notebook : Computer
{
    protected override Notebook BuildPcToIntel()
    {
        Console.WriteLine("Информация о ноутбуке: ");
        Console.WriteLine($"Процессор: {processor[0]} i5-10800H");
        Console.WriteLine("Видеокарта: встроенная от процессора");
        Console.WriteLine("Оперативная память: 16gb");
        Console.WriteLine("Блок питания: Cooler Master V350 на 450вт");
        Console.WriteLine("SSD: 512гб");

        while (true)
        {
            Console.WriteLine("Если вам так пк подходит, введите 1 для подтверждения покупки, если не подходит введите любое число кроме 1: ");
            action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Check();
            }
            else
            {
                return new Notebook();
            }
        }
    }

    protected override Notebook BulidToAmd()
    {
        Console.WriteLine("Информация о ноутбуке: ");
        Console.WriteLine($"Процессор: {processor[1]} ryzen 5 3600");
        Console.WriteLine("Видеокарта: встроенная от процессора");
        Console.WriteLine("Оперативная память: 16gb");
        Console.WriteLine("Блок питания: Cooler Master V350 на 450вт");
        Console.WriteLine("SSD: 512гб");

        while (true)
        {
            Console.WriteLine("Если вам так пк подходит, введите 1 для подтверждения покупки, если не подходит введите любое число кроме 1: ");
            action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Check();
            }
            else
            {
                return new Notebook();
            }
        }
    }

    protected override void Check()
    {
        Console.WriteLine("------------------------------------------------>");
        
        Console.WriteLine("Дополнительная информация: ");
        Console.WriteLine("У ноутбука есть зарядка, поэтому им можно 8 часов использовать без зарядки и спокойно использовать для эксплуатации." + '\n' +
                          "Ноутбук поддерживает wifi и кабельный интернет, есть встроенная мышка + клавиатура + монитор, есть раскладушка."
        );
        price = 78000;
        Console.WriteLine($"Цена ПК: {price}");
        Environment.Exit(0);
    }
}

public class Start
{
    public Start()
    {
        while (true)
        {
            Console.WriteLine("Выберите нужный вами пункт: ");
            Console.WriteLine("1.Станционарный ПК");
            Console.WriteLine("2.Ноутбук");
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Computer computer = new Computer();
                break;
            } else if (action == 2)
            {
                Notebook notebook = new Notebook();
                break;
            }
            else
            {
                Console.WriteLine("Ошибка!! Выберите корректный пункт!");
                continue;
            }
            return;
        }
    }
}


public class Program
{
    public static void Main()
    {
        Start start = new Start();
    }
}