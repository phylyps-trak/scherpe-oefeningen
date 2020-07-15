using System;
using System.Linq;

namespace Demo
{
	class Program
	{
		static void Main(string[] args)
		{

			//setup dingen, TODO: later dynamisch maken
			Speler michiel = new Speler("Michiel", 0, 0, 10);
			SpelVerloop spel1 = new SpelVerloop();
			Robot robot = new Robot();

			//do while, zodat je kan herstarten als je wil  	
			do
			{
				//meer setup
				robot.RobotCodeMaken();
				spel1.Welkom();
				spel1.LaatCodeZien(robot.GetRobotCode());
				spel1.EersteBeurt();
				michiel.DoeEenGooi();
				robot.VergelijkDeGooi(michiel);
				//spel
				while (!(michiel.turnCounter < 1) &&
						!michiel.GetGokje().SequenceEqual(robot.GetRobotCode()))
				{
					michiel.Reset();
					michiel.DoeEenGooi();
					robot.VergelijkDeGooi(michiel);
				}
				//verliezen of winnen
				if (michiel.turnCounter <= 1)
				{
					Console.WriteLine(
							"Dat is jammer, je hebt alle pogingen gebruikt,");
					Console.WriteLine(
								"maar de code niet gekraakt...");
				}
				else if (michiel.goedCounter == 5)
				{
					Console.WriteLine("\n *** Dikke gefeli, ouwe, je heb gewonne! *** ");
				}
				//DOORGAAN!!
			} while (spel1.StopDoor() == ("j"));


		}//endof main
	}//endofMichielmind
}

