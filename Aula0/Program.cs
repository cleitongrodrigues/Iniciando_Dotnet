namespace Aula0;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("----- Bem vindo a calculadora em .NET -----");

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Por favor, digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a operação desejada (+ | - | * | /)");
            string op = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");
            double result;
            int c;

            if (op == "+")
            {
                result = n1 + n2;
                Console.WriteLine($"O resultado da soma é: {result}");
            }
            else if (op == "-")
            {
                result = n1 - n2;
                Console.WriteLine($"O resultado da subtração é: {result}");
            }
            else if (op == "*")
            {
                result = n1 * n2;
                Console.WriteLine($"O resultado da multiplicação é: {result}");
            }
            else if (op == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Erro: divisão por zero!");
                }
                else
                {
                    result = (double)n1 / n2;
                    Console.WriteLine($"O resultado da divisão é: {result}");
                }
            }
            else
            {
                Console.WriteLine($"Operação {op} inválida!");
            }

            Console.WriteLine("Deseja realizar outra operação? (1 = sim / 0 = não)");
            c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                continuar = true;
            } else
            {
                Console.WriteLine("----- Obrigado por usar a calculadora! -----");
                continuar = false;
            }
        }
    }
}