namespace Aula16;

public class Program
{
    public static void Main()
    {
        List<int> numerosList = new List<int> {1,2,3,4,5,6,7,8,9,10};

        foreach (int num in numerosList)
        {
            Console.WriteLine(num);
        }
    }
}