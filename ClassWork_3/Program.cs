    // Перевод из десятичной в двоичную
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    string dvoich = "";
    while (a > 0)
    {
        dvoich = (a % 2).ToString() + dvoich;
        a /= 2;
    }
    Console.WriteLine(dvoich);
