  Console.Write("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    
    int N_1 = 1;
    int N_2 = 0;

    Console.Write($"{N_2} {N_1}");

    for (int i = 1; i < N - 1; i++)
    {
        Console.Write($" {N_2 + N_1}");
        int b = N_1;
        N_1 = N_2 + N_1;
        N_2 = b;
    }
    Console.WriteLine("\n\n");