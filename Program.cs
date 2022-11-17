using calculate;
internal class Program
{
    private static void Main(string[] args)
    {
        dortgen d = new dortgen();
        Console.WriteLine("Boy Giriniz:");
        d.Boy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("En Giriniz:");
        d.En = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Boy:" + d.Boy + " " + "En:" + d.En);
        Console.WriteLine("Alan:");
        Console.WriteLine(d.alan());
        Console.ReadKey();
    }
}