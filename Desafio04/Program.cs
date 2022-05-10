/*4 - Construa um algoritmo que recebe do usuário 5 números. Após 
 * recebê-los, retorne a lista de números em ordem decrescente.*/

var numeros = new List<int>();
try
{
    #pragma warning disable CS8604 // Possível argumento de referência nula.
    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"Digite o {i}° número: ");
        numeros.Add(int.Parse(Console.ReadLine()));
    }
    #pragma warning restore CS8604 // Possível argumento de referência nula.
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Digite somente números inteiros!");
    numeros.Add(0);
}
Console.WriteLine($"A ordem decrescente dos números: " +
    $"{string.Join(", ", numeros.OrderByDescending(x => x).ToList())}");