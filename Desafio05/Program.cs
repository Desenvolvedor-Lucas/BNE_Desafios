/*5 - Construa um algoritmo que identifique a quantidade de vogais 
 * a partir de um texto informado pelo usuário.*/

using System.Globalization;
using System.Text;

string texto;
var vogais = new List<char>();
try
{
    #pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
    Console.Write("Digite um texto: ");
    texto = Console.ReadLine().ToString();
    if (string.IsNullOrEmpty(texto))
        throw new ArgumentNullException();
    #pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Digite um texto!");
    texto = "0";
}

var textoSemAcento = new string(texto.ToLower()
        .Normalize(NormalizationForm.FormD)
        .Where(letra => char.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
        .ToArray());

foreach (char letra in textoSemAcento.ToList<char>())
    if ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u'))
        vogais.Add(letra);

Console.WriteLine($"Vogais do texto '{texto}': {string.Join(", ", vogais)}");
Console.WriteLine($"Quantidade das vogais: {vogais.Count}");