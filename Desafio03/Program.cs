/*3 - Construa um algoritmo que instancia um array de inteiros 
 * com os seguintes valores: 1,3,35,40,85,123,121,209,200,305,350. 
 * Após, crie uma lógica que separe estes números entre pares e ímpares 
 * em outros 2 arrays.*/

var numeros = new List<int>{1,3,35,40,85,123,121,209,200,305,350};
var pares = new List<int>();
var impares = new List<int>();

foreach(int numero in numeros)
    if(numero%2 == 0)
        pares.Add(numero);
    else
        impares.Add(numero);

Console.WriteLine($"Dos números: {string.Join(", ", numeros)}");
Console.WriteLine($"Os números pares são: {string.Join(", ", pares)}");
Console.WriteLine($"Os números impares são: {string.Join(", ", impares)}");