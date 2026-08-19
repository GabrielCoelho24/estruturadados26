Console.WriteLine("Hello, World!");



// é possivel declarar o vetor e
// ja definir e atribuir

int[] number2 = 
    new int[] {100, 200, 300};

int[] number3 = 
    {1000, 2000, 3000, 4000};

//Percorrendo um vetor e adicionando
// Valores dinamicamente

Console.WriteLine("Informe o tamanho do vetor de inteiros:");

int size = Convert.ToInt32(
    Console.ReadLine());
int[] myArray = new int[size];
int total = 0; //Acumulador
int counter = 0;
for(int i =0; i< myArray.Length; i++)
{
    Console.WriteLine(
    "Digite Para [" + i + "]: "
    );
    myArray[i] = Convert.ToInt32(
    Console.ReadLine()
    );
    total += myArray[i];
    counter++;
}
Console.WriteLine("Totalizador = " + total);

Console.WriteLine("Contagem = " + counter);