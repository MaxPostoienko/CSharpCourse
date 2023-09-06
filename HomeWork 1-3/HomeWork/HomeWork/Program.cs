
    // Hello + Name!
    Console.WriteLine("Whats your name");
    string? name = Console.ReadLine();
    Console.WriteLine($"Hello {name}!");

    // Reverse numbers
    int x, y;
    Console.WriteLine("Enter the first number");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    y = int.Parse(Console.ReadLine());
    Console.WriteLine($"x={x} y={y}");
    x = x + y;
    y = x - y;
    x = x - y;
    Console.WriteLine($"Swap x={x} y={y}");

    // Lenght numbers
    Console.WriteLine("Enter number");
    int Number = int.Parse(Console.ReadLine());
    Console.WriteLine(Number.ToString().Length);
