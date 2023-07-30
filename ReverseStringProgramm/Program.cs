public class RevserString
{
    public string ReversName(string S2)
    {
        string Result = string.Empty;
        for (int i = S2.Length - 1; i >= 0; i--)
        {
            Result += S2[i];
        }
        return Result;
    }
}

class Program
{
    static void Main()
    {
        RevserString R1 = new RevserString();
        var A2=R1.ReversName("Ashutosh");
        Console.WriteLine(A2);

        Console.ReadLine();
    }
}
