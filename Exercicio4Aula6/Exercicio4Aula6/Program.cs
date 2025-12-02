{ 
        char[] caracteres = { 'J', 'o', 'e', 'l' };

               for (int i = 0; i < caracteres.Length / 2; i++)
        {

            int j = caracteres.Length - 1 - i;
            char temp = caracteres[i];
            caracteres[i] = caracteres[j];
            caracteres[j] = temp;
        }

        string resultado = new string(caracteres);
        Console.WriteLine($"String invertida: {resultado}");
    }