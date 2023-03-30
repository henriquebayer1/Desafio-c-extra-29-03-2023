Console.WriteLine($"Digite o seu ano de nascimento:");
int anoDeNascimento = int.Parse(Console.ReadLine());

int anoAtual = int.Parse(DateTime.UtcNow.ToString("yyyy"));

float idadeAnos = (anoAtual - anoDeNascimento);

float idadeSemanas = (idadeAnos * 52);

Console.WriteLine($"a sua idade em semanas e de: {idadeSemanas}");

