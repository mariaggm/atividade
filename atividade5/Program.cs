// Ler dois valores (considere que não serão lidos valores iguais e escreve-los em ordem crescente
Console.WriteLine("Ordem Crescente");

Console.WriteLine("Digite o primeiro número:");
int numero1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o primeiro número:");
int numero2 = Convert.ToInt16(Console.ReadLine());

if (numero1 > numero2)
    Console.WriteLine("O maior" + numero1 + "E o menor" + numero2);

if (numero2 > numero1)
    Console.WriteLine("O maior" + numero2 + "E o menor" + numero1);


