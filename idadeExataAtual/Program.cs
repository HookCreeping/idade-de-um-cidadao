// Descubrir a idade de alguém em anos e semanas através do seu aniversário

Console.WriteLine($"Diga em que ano você nasceu: "); float AnoNascimento = float.Parse(Console.ReadLine());
var AnoAtual = DateTime.Now.Year;

float IdadeAnos = AnoAtual - AnoNascimento;
float IdadeSemanas = (IdadeAnos * 12) * 4;

Console.WriteLine($"Você tem {IdadeAnos} anos, equivalente a {IdadeSemanas} semanas");
