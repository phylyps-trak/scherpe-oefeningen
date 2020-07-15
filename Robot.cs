using System;
using System.Linq;

namespace Demo
{
	public class Robot
	{
		readonly string[] kleuren = { "A", "B", "C", "D", "E", "F", "G", "H" };
		string[] geheimeCode = new String[5];

		//=============	
		public void RobotCodeMaken()
		{
			for (int x = 0; x < 5; x++)
			{
				Random r = new Random();
				int getal = r.Next(8);
				//trek vijf uit verzameling, stop in code
				geheimeCode[x] = kleuren[getal];
			}

		}//endof robotCodeMaken

		public string[] GetRobotCode()
		{
			return geheimeCode;
		}

		//======
		public void VergelijkDeGooi(Speler s)
		{
			for (int i = 0; i < GetRobotCode().Length; i++)
			{
				//aantal op de juiste plek tellen
				if (s.GetGokje()[i] == (geheimeCode[i]))
				{
					s.SetGoedCounter(1);
					//aantal juiste letter tellen	
				}
				else if (geheimeCode.Any(s.GetGokje().Contains))
				{
					s.SetBijnaCounter(1);
				}
			}
			// weergeven met fancy letters en kleurtjes
			Console.WriteLine("\n✔  " +
					s.GetGoedCounter() + "  goed, ");
			Console.WriteLine(" ~  " +
					s.GetBijnaCounter() + " bijna goed, ");
			// even de overgebleven fouten uitrekenen
			int temp = 5 - ((s.GetBijnaCounter()) + (s.GetGoedCounter()));
			Console.WriteLine(" ✗ " +
					temp + " compleet verkeerd... ");
			//beurt voorbij, print hoeveel nog te gaan
			s.turnCounter--;
			Console.WriteLine("\n(nog 9 beurten om de code te kraken!)\n");
			Console.ReadLine();

		}//endof vergelijkDeGooi
	}
}