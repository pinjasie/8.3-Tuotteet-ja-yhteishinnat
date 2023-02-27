class Program
{
	public static void Main(string[] args)
	{

		Console.WriteLine("Tehtävä 8.3"); //tulostaa tehtävän numeron ja alempi katkoviivan
		Console.WriteLine("------------");
		Console.WriteLine();
		Console.Write("Kuinka monta tuotetta lisätään: "); //käyttäjältä kysytään haluttu määrä tuotteita
		int kpl = int.Parse(Console.ReadLine()); //vastaus tyyppimuunnetaan string -> int
		string[] tuotteet = new string[kpl]; //alustetaan lista tuotteiden nimille...
		int[] hinta = new int[kpl]; //...hinnoille...
		int[] lukum = new int[kpl];//...sekä kappalemäärille
		for (int i = 0; i < kpl; i++) //silmukka, jonka sisällä toistetaan kysymykset käyttäjän syöttämän kappalemäärän mukaan
		{
			Console.Write("Anna tuotteen " + (i + 1) + ". nimi: "); //i+1 lisää numerojärjestykseen aina yhden arvon lisää, jolloin kysytyn kappaleen järjestysnumero selviää
			tuotteet[i] = Console.ReadLine(); //tässä tulostuu jälleen käyttäjän syöte
			Console.Write("Anna tuotteen " + (i + 1) + ". hinta: "); //samaan tapaan kuin 1. kysymys
			hinta[i] = int.Parse(Console.ReadLine());
			Console.Write("Anna tuotteen " + (i + 1) + ". lukumäärä: ");
			lukum[i] = int.Parse(Console.ReadLine());
		}
		for (int i = 0; i < kpl; i++) //toinen silmukka summan tulostamista varten
		{
			var yhteisHinta = hinta[i] * lukum[i];
			Console.WriteLine(tuotteet[i] + " " + yhteisHinta + " euroa"); //tulostaa tuotteiden hinnat
		}
	}
}