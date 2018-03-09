using System;

namespace AssemblyCSharp
{
	public class Unit : Card
	{

		private int healthPoints;

		public Unit (string cardName, string cardDescription, Faction cardFaction, int healthPoints)
		{
			this.cardName = cardName;
			this.cardDescription = cardDescription;
			this.cardFaction = cardFaction;
			this.healthPoints = healthPoints;
		}
	}
}

