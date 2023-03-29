// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Insira a sua idade: ");
float IdadeAnos = float.Parse(Console.ReadLine());

float IdadeMeses = IdadeAnos * 12;
float IdadeDias = IdadeAnos * 365;
float IdadeHoras = IdadeDias * 24;
float IdadeMinutos = IdadeHoras * 60;
float IdadeSegundos = IdadeMinutos * 60;

Console.WriteLine($"Você tem: {IdadeAnos} anos, que é igual a {IdadeMeses} meses, equivalente a {IdadeDias} dias, que se iguala a {IdadeHoras} horas, que se resulta em {IdadeMinutos} minutos, assim, sua idade em segundos é {IdadeSegundos}."
);



