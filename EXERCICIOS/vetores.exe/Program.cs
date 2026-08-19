  int[] pares = new int[10];
        int[] impares = new int[10];
        int qtdPares = 0;
        int qtdImpares = 0;
        // Ler 10 números
        for (int i = 0; i < 10; i++){
            Console.Write($"Digite o {i + 1}º número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0){
                pares[qtdPares] = numero;
                qtdPares++;
            }
            else{
                impares[qtdImpares] = numero;
                qtdImpares++;
            }
        }
        // Imprimir os pares
        Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < qtdPares; i++)
        {
            Console.Write(pares[i] + " ");
        }

        // Imprimir os ímpares
        Console.WriteLine("\n\nNúmeros ímpares:");
        for (int i = 0; i < qtdImpares; i++)
        {
            Console.Write(impares[i] + " ");
        }

        Console.WriteLine();