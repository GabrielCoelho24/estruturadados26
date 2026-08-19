Console.Write("Digite uma palavra: ");

string? palavra = Console.ReadLine();
string invertida = "";

for (int i = palavra.Length - 1; i >= 0; i--)
{
    invertida += palavra[i];
}

if (palavra.ToLower() == invertida.ToLower())
{
    Console.WriteLine("A palavra é um palíndromo.");
}
else
{
    Console.WriteLine("A palavra não é um palíndromo.");
}