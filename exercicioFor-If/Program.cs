using System.Net.Mail;

internal class Program
{
    private static void Main(string[] args)
    {
        int senha = 2002;

        while (true)
        {
            Console.WriteLine("Digite sua senha: ");
            int senha1 = int.Parse(Console.ReadLine());

            if (senha1 != senha) 
            {
                Console.WriteLine("Senha inválida");
                Console.WriteLine();
            }
            else {
                Console.WriteLine("Senha aceita com sucesso");
                break;

                    }
        }
    }
}