namespace Aula11;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        switch(idade)
        {
            case < 16:
                Console.WriteLine("Não pode votar");
                break;
            case >= 16 and < 18 or >= 65:
                Console.WriteLine("Voto facultativo");
                break;
            default:
                Console.WriteLine("Voto obrigatório!");
                break;
        }
    }
}