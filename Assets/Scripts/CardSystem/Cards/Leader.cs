using System;

namespace AssemblyCSharp
{
	public class Leader : Card
	{

		private int healthPoints;

		public Leader (string cardName, string cardDescription, Faction cardFaction, int healthPoints)
		{
			this.cardName = cardName;
			this.cardDescription = cardDescription;
			this.cardFaction = cardFaction;
			this.healthPoints = healthPoints;
		}
	}
}