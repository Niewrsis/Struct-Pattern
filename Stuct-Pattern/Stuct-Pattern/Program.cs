public class Program
{
    public static void Main(string[] args)
    {
        SmartHome smartHome = new SmartHome();
        smartHome.SetUpHome("Ночной");
        Console.WriteLine("--------------------");
        smartHome.SetUpHome("Вечеринка");
        Console.WriteLine("--------------------");
        smartHome.SetUpHome("Один дома");
    }
}