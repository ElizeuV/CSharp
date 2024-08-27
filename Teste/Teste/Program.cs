// See https://aka.ms/new-console-template for more information


//var limite = 1000;
Console.Write("Por favor, insira um limite: ");
var limite = int.Parse(Console.ReadLine());

for (int i = 0; i < limite; i++)
{
    if (i <= 500)
    {
        Console.WriteLine($"Valor do contador atual: {i}");

        if (i == 500)
        {

            Console.WriteLine($"Valor chegou no limite de {i}");
        }

        if ((i == 100) || (i == 300))
        {
            i += 50; // i = i + 50;
        }
    }
}



