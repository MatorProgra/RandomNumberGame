// See https://aka.ms/new-console-template for more information

Random random = new Random();
int number = random.Next(101);
int iterations = 0;

Console.Write("Wpisz szukaną liczbę (od 0 do 100): ");

while (true)
{
	if (int.TryParse(Console.ReadLine(), out int input) && input >= 0 && input <= 100)
	{
		iterations++;

		if (input > number)
			Console.Write("Podana liczba jest większa od szukanej. Spróbuj jeszcze raz: ");
		else if (input < number)
			Console.Write("Podana liczba jest mniejsza od szukanej. Spróbuj jeszcze raz: ");
		else
		{
			Console.Write($"Brawo! Znalazłeś poprawną liczbę - {number} w {iterations} krokach.");
			break;
		}
	}
	else
		Console.Write("Error! błędne dane! Spróbuj jeszcze raz (liczba od 0 do 100): ");
}
Console.ReadLine();