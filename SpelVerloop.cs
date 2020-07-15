using System;
namespace Demo
{
	public class SpelVerloop
	{
		string con;

		//======				
		public void LaatCodeZien(String[] codeArray)
		{
            Console.WriteLine("   [de geheime code]");
			Console.WriteLine("  -------------------");
			for (int a = 0; a < codeArray.Length; a++)
			{
				Console.Write(" | " + codeArray[a]);
			}
			Console.WriteLine(" |");
			Console.WriteLine(" ");
            Console.WriteLine("  -------------------");

		}//endof laatCodeZien
         //======

		public void EersteBeurt()
		{
			//eerste beurt

			Console.WriteLine("\n...raden maar!    (format: x,x,x,x,x)");
			Console.WriteLine("=====================================");
		}
		//======					//INTRO hahah lekker ascii klooien, heerlijk
		public void Welkom()
		{
			Console.WriteLine("######################################");
			Console.WriteLine("    Welkom bij MASTERMIND superieur");
			Console.WriteLine("  ----------------------------------- ");
			Console.WriteLine(" |   Het bekroonde spel voor de      |");
			Console.WriteLine(" |   professionele codebrekers       |");
			Console.WriteLine(" |     Le jeu champion pour les      |");
			Console.WriteLine(" |     professionels du decodage     |");
			Console.WriteLine("    -------------------------------   ");
			Console.WriteLine(" |   met 5 gaten en 8 kleuren        |");
			Console.WriteLine(" |     avec 5 cases et 8 couleurs    |");
			Console.WriteLine("  ----------------------------------- ");
			Console.WriteLine("                                      ");
			Console.WriteLine(" ------ Spel van het jaar 1975! ------");
			Console.WriteLine("######################################");
			Console.WriteLine("\n");
		}//endofwelkom

		//===========				//DOORGAAN OF STOPPEN
		public string StopDoor()
		{
			{
				Console.WriteLine("\n================");
				Console.WriteLine("Wil je nog eens spelen?\n  (type j / n)");
			}
			do
			{
				this.con = Console.ReadLine();
				if (con.Equals("n"))
				{
					Console.WriteLine("Nou, ga maar lekker iets anders doen dan...");
				}
				else if (con.Equals("j"))
				{
					Console.WriteLine("\n...here we go again!\n");
				}
				else
				{
					Console.WriteLine("Je invoer slaat nergens op, gek!");
				}
			} while (!con.Equals("j"));
			return con;
		}

	}//endofSpelVerloop
}
