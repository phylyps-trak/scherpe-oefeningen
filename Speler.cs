using System;
using System.Text.RegularExpressions;

namespace Demo
{
    public class Speler
    {
		// tellertjes
		public int goedCounter = 0;
		public int bijnaCounter = 0;
		public int turnCounter = 10;
		public string naam;

		// dit is de array waar de input in moet
		public string[] gokje;

        //========				//CONSTRRRRRUCTORRRRR --> nog dingen mee doen
        public Speler(string naam, int a, int b, int c)
		{
			this.goedCounter = a;
			this.bijnaCounter = b;
			this.turnCounter = c;
			this.naam = naam;
		}

		//======			// de speler doet een poging		
		public void DoeEenGooi()
		{
			//zet wat dingen klaar
			int inputTest = 0;
			//hieraan moet de input straks voldoen 
			string pattern = "^([a-h]{1},?[a-h]{1},?[a-h]{1},?[a-h]{1},?[a-h]{1}$)";
			// Create a Regex  
			Regex rg = new Regex(pattern);

			do
			{
				//get user input
				Console.WriteLine("-> ");
				string line = Console.ReadLine();
                //check de input


                if (rg.IsMatch(line))
				{
					//hak de input in stukjes bij de komma, maak hoofdletters van, stop in array gokje
					this.gokje = line.ToUpper().Split(",");
					//netjes weergeven		
					Console.Write("\n |");
					foreach (string s in gokje)
						Console.Write(" " + s + " |");
					Console.WriteLine(" ");
					//teller zodat je opnieuw kan als de input niet correct was		
					inputTest++;
				}
				else
				{
					Console.WriteLine("\n--- Zoiets typen werkt helaas niet...");
					Console.WriteLine("--- Probeer het nog eens?------------\n");
				}

			} while (inputTest == 0);

		}//endof doeEenGooi

		//=============			//GETTERs & SETTERs & REsetters
		public void Reset()
		{
			goedCounter = 0;
			bijnaCounter = 0;
		}
		public String[] GetGokje()
		{
			return gokje;
		}
		public int GetGoedCounter()
		{
			return goedCounter;
		}

		public void GetGoedCounter(int goedCounter)
		{
			this.goedCounter += goedCounter;
		}
		public void SetGoedCounter(int goedCounter)
		{
			this.goedCounter += goedCounter;
		}

		public int GetBijnaCounter()
		{
			return bijnaCounter;
		}

		public void SetBijnaCounter(int bijnaCounter)
		{
			this.bijnaCounter += bijnaCounter;
		}

	}//endof Speler

}
