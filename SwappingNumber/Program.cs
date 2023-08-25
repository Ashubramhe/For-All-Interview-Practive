class Program
{
    static void Main()
    {
        int First, Second, Ntemp;

        Console.WriteLine("Please Enter First Number Here");
        First=int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter Second Number");
        Second=int.Parse(Console.ReadLine());

        Ntemp = First;
        First = Second;
        Second = Ntemp;

        Console.WriteLine($"After Swapping First: {First}  Second: {Second}");
        Console.ReadLine();
    }
}