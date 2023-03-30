Console.WriteLine($"Digite o seu ano de nascimento:");
int anoDeNascimento = int.Parse(Console.ReadLine());

float idadeAnos = (2023 - anoDeNascimento);

float idadeSemanas = (idadeAnos * 52);

Console.WriteLine($"a sua idade em semanas e de: {idadeSemanas}");

