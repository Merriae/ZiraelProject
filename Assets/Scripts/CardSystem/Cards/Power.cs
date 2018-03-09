using System;

namespace AssemblyCSharp
{
	public class Power : Card
	{
		public Power (string cardName, string cardDescription, Faction cardFaction)
		{
			this.cardName = cardName;
			this.cardDescription = cardDescription;
			this.cardFaction = cardFaction;
		}
	}
}

