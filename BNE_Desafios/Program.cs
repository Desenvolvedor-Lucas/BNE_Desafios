/*1 - Construa um algoritmo que calcula o tamanho de um edifício com base na 
 * altura de cada andar e o número de andares informados pelo usuário.*/

int alturaAndar, numeroAndar;
try
{
    #pragma warning disable CS8604 // Possível argumento de referência nula.
    Console.Write("Digite a altura de cada andar em metros: ");
    alturaAndar = int.Parse(Console.ReadLine());
    Console.Write("Digite o número de andares: ");
    numeroAndar = int.Parse(Console.ReadLine());
    #pragma warning restore CS8604 // Possível argumento de referência nula.
}
catch (Exception ex) 
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Digite somente números inteiros!");
    alturaAndar = 0; 
    numeroAndar = 0;
}
Console.WriteLine($"Tamanho do edifício: {alturaAndar * numeroAndar} metros");