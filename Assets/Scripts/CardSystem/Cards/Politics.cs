using System;

namespace AssemblyCSharp
{
	public class Politics : Card
	{

		private int healthPoints;

		public Politics (string cardName, string cardDescription, Faction cardFaction, int healthPoints)
		{
			this.cardName = cardName;
			this.cardDescription = cardDescription;
			this.cardFaction = cardFaction;
			this.healthPoints = healthPoints;
		}
	}
}

