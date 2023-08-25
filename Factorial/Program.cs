class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter Factorial Number");
        int FactNum = int.Parse(Console.ReadLine());
        int FactRest = 1;

        for (int i = 1; i <= FactNum; i++)
        {
            Console.WriteLine($"{FactRest = i * FactRest} That Was Flow");
        }
        Console.WriteLine($"{0} is {1}",FactNum,FactRest);
        Console.ReadLine();
    }
}