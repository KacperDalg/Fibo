namespace Fibo;
class Program
{
    static int CalculateFibonacciNumber(int input)
    {
        int[] f = new int[input + 2];

        f[0] = 0;
        f[1] = 1;

        for (int i = 2; i <= input; i++)
        {
            f[i] = f[i - 1] + f[i - 2];
        }

        return f[input];
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
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"{userInput}. wyrazem ciągu Fibonacciego jest liczba: {CalculateFibonacciNumber(userInput)}");
        }
        else
        {
            Console.Clear();
            string path = "file.txt";
            StreamReader streamReader = new StreamReader(path);
            int fileContent = int.Parse(streamReader.ReadLine());
            Console.WriteLine($"Wartość wczytana z pliku: {fileContent}");
            Console.WriteLine($"{fileContent}. wyrazem ciągu Fibonacciego jest liczba: {CalculateFibonacciNumber(fileContent)}");
            streamReader.Close();
        }
    }
}