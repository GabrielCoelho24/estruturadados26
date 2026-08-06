string firstName = "Gabriel";
string lastName = "Santos";

string note = lastName.ToUpper()
                 + " " + firstName;

string initials = lastName[0] + " " + firstName[0];

//Formatação de strings
string texto = string.Format(
    "{0} {1} nascido em {2}",
    firstName,
    lastName,
    "2007"
    );

Console.WriteLine(texto);

//C# é uma linguagem filha do C++
// Totalmente Orientada a Objetos
// Portanto, tudo em C é descendente
// do tipo object

int age = 19;
object ageBoxing = age;
int ageUnboxing = (int)ageBoxing;

//Console.WriteLine(ageUnboxing);