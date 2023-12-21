using System;
using System.Collections.Generic;

class food
{
    public string Name { get; set; }
    public string Description { get; set; }


    public food(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Display()
    {
        Console.WriteLine($"Блюдо: {Name}");
        Console.WriteLine($"Описание: {Description}");
    }
}



class pizza : food
{
    public pizza(string name, string description) : base(name, description)
    {
    }

    public void Nyam()
    {
        Console.WriteLine($"С эксклюзивной арбузной курочкой, ваша {Name}!");
    }
}

class borga : food
{
    public borga(string name, string description) : base(name, description)
    {
    }

    public void Nom()
    {
        Console.WriteLine($"Когда поедаете {Name} следите за своими лобными долями.");
    }
}

class dessert : food
{
    public dessert(string name, string description) : base(name, description)
    {
    }

    public void Chomp()
    {
        Console.WriteLine($"Без {Name} уже не так весело!");
    }
}

class drink : food
{
    public drink(string name, string description) : base(name, description)
    {
    }

    public void Slurp()
    {
        Console.WriteLine($"Пей {Name} до дна! (будь мужиком)");
    }
}

class Program
{
    static void Main()
    {
        List<food> menu = new List<food>
        {
            new pizza("Супер пицца 'У Чики'", "За качество не ручаемся."),
            new borga("Бургер 'Фредбер'", "Невероятный вкус в каждом УКУСЕ :DDDDDD."),
            new dessert("Десерт 'Лицо Бонни'", "МММ МЕТАЛЛ."),
            new drink("Напиток 'Фохе'", "Освежающая гармония пиратского пота.")
        };

        foreach (food item in menu)
        {
            item.Display();

            if (item is pizza pizza)
            {
                pizza.Nyam();
            }
            else if (item is borga burger)
            {
                burger.Nom();
            }
            else if (item is dessert dessert)
            {
                dessert.Chomp();
            }
            else if (item is drink drink)
            {
                drink.Slurp();
            }

            Console.WriteLine();
        }
    }
}
