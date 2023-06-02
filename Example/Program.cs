using DataProvider;
using Example;

internal class Program
{
    public static void Main(string[] args)
    {
        var data = new Controller<UserData>(
            new FileDataProvider<UserData>("C:\\Users\\oliso\\Desktop\\as\\data.txt"));

        Console.WriteLine(data.Data?.Name);
    }
}