Console.Clear();

int largura, altura;

Console.WriteLine("Tamanho do retângulo: ");

Console.Write("Largura..: ");
largura = int.Parse(Console.ReadLine());

Console.Write("Altura...: ");
altura = int.Parse(Console.ReadLine());

if (largura < 1 || largura > 10 || altura < 1 || altura > 10)
{
    Console.WriteLine("As medidas devem estar entre 1 e 10.");
    return;
}

Console.WriteLine("Contorno do retângulo: ");
for (int a = 0; a < altura; a++)
{
    for (int l = 0; l < largura; l++)
    {
        if (a == 0 || a == altura - 1 || l == 0 || l == largura - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}

