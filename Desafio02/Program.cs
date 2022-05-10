/*2 - Construa um algoritmo que receba do usuário 4 números. 
 * Imprima o maior, o menor e a média deles.*/

var n = new List<int>();
try
{
    #pragma warning disable CS8604 // Possível argumento de referência nula.
    for(int i = 1; i <= 4; i++)
    {
        Console.Write($"Digite o {i}° número: ");
        n.Add(int.Parse(Console.ReadLine()));
    }
    #pragma warning restore CS8604 // Possível argumento de referência nula.
} 
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Digite somente números inteiros!");
    n.Add(0);
}
Console.WriteLine($"Maior número: {n.Max()}");
Console.WriteLine($"Menor número: {n.Min()}");
Console.WriteLine($"Média deles: {decimal.Divide((n.Max() + n.Min()), 2)}");