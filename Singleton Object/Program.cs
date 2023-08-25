 public class Singloton
{
    private static Singloton _instance;

    private Singloton() 
    {
    
    }

    public static Singloton OBJECT()
    {
        if (_instance == null)
        {
            _instance = new Singloton();
        }

        return _instance;
    }
}


class Program
{
    static void Main()
    {
        Singloton S1 = Singloton.OBJECT();

        Console.ReadLine();
    }
}

