using System;

class hehicle
{
    public string Name { get; set; }

    public hehicle(string name)
    {
        Name = name;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine($"Включаем транспортное средство: {Name}");
    }
}

class land : hehicle
{
    public land(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Бипбип поехали.");
    }
}

class water : hehicle
{
    public water(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Бульбуль поплыли.");
    }
}

class submarine : water
{
    public submarine(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Погрузились под воду и готовы делать подбульподбуль.");
    }
}

class air : hehicle
{
    public air(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("ВЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖ полетели.");
    }
}

class underground : hehicle
{
    public underground(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Какие звуки издаются под землей?");
    }
}

class Program
{
    static void Main(string[] args)
    {
        hehicle[] vehicles = new hehicle[]
        {
            new land("СуперМашина2281488"),
            new water("Шлюпка"),
            new submarine("СУперсегадуперсубмарина для потопления врагов"),
            new air("Истребитель"),
            new underground("Метро")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
