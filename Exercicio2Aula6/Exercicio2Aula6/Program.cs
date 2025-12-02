// See https://aka.ms/new-console-template for more information
//Descrição:
//Dado um array ordenado de inteiros (positivos e negativos), retorne um novo array com os quadrados de 
//cada número, também ordenados.
// Por que usar laços:
// É necessário percorrer o array com um laço 
//for ou 
//while para calcular os quadrados.
// Depois, pode-se ordenar o resultado ou usar uma abordagem de dois ponteiros com 
//while 
{
    var numeros = new int[] {-5,-1,4,8,2,3 };
    for (int i = 0; i < numeros.Length; i++)
  
        {
            numeros[i] = numeros[i] * numeros[i];
        }
        Array.Sort(numeros);
        Console.WriteLine("Array de quadrados ordenados:");
        foreach (var n in numeros)
        {
            Console.WriteLine(n);
        }
 }