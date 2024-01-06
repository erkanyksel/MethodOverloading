internal class Program
{
    private static void Main(string[] args)
    {
        // .Out parameters
        string number = "999";
        bool sonuc = int.TryParse(number, out int OutNumber);

        if (sonuc)
        {
            Console.WriteLine("Succeded!");
            Console.WriteLine(OutNumber);

        }
        else
        {
            Console.WriteLine("Error!");
        }

        Methods instance = new Methods();
        instance.Sum(4, 5, out int totalResult);

        Console.WriteLine(totalResult);

        // Method Overloading
        int ifade = 999;
        instance.writeOnScreen(Convert.ToString(ifade));
        instance.writeOnScreen(ifade);
        instance.writeOnScreen("yuksel", "erkan");



    }
}

class Methods
{
    public void Sum(int a, int b, out int SumTotal)
    {
        SumTotal = a + b;
    }

    public void writeOnScreen(string val)
    {
        Console.WriteLine(val);
    }

    public void writeOnScreen(int val)
    {
        Console.WriteLine(val);
    }

    public void writeOnScreen(string val, string val2)
    {
        Console.WriteLine(val + val2);
    }
}