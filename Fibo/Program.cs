class Program
{
    static int fibo(int a)
    {
        int[] f = new int[a + 2];

        f[0] = 0;
        f[1] = 1;

        for (int i = 2; i <= a; i++)
        {
            f[i] = f[i - 1] + f[i - 2];
        }

        return f[a];
    }

    static void Main()
    {
        Console.WriteLine("WYBIERZ OPCJĘ: \n1 - Wczytaj z konsoli\n2 - Wczytaj z pliku txt");
        int option = int.Parse(Console.ReadLine());

        if(option != 1 && option != 2)
        {
            Console.WriteLine("Błędne dane wejściowe");
        }
        else if(option == 1)
        {
            Console.Clear();
            Console.WriteLine("Który wyraz ciągu Fibonacciego chcesz sprawdzić: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}. wyrazem ciągu Fibonacciego jest liczba: {fibo(x)}");
        }
        else
        {
            Console.Clear();
            string path = "file.txt";
            StreamReader sr = new StreamReader(path);
            int y = int.Parse(sr.ReadLine());
            Console.WriteLine($"Wartość wczytana z pliku: {y}");
            Console.WriteLine($"{y}. wyrazem ciągu Fibonacciego jest liczba: {fibo(y)}");
            sr.Close();
        }
        
    }
}