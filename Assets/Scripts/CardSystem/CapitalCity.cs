using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class CapitalCity
	{
		private Deck assignatedDeck;
		private Graveyard graveyard;
		private Hand hand;

		private int healthPoints;

		public CapitalCity (Deck assignatedDeck)
		{
			this.assignatedDeck = assignatedDeck;
			graveyard = new Graveyard (new List<Card> ());
			hand = new Hand (new List<Card> ());
			healthPoints = CardSystemConstantValues.capitalCitiesBaseHealthPoints;
		}
	}
}

