using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class CapitalCity
	{
		private Deck assignatedDeck;
		private Graveyard graveyard;
		private Hand hand;

		private int totalHealthPoints;
		private int currentHealthPoints;

		public CapitalCity (Deck assignatedDeck)
		{
			this.assignatedDeck = assignatedDeck;
			graveyard = new Graveyard (new List<Card> ());
			hand = new Hand (new List<Card> ());
			totalHealthPoints = CardSystemConstantValues.capitalCityBaseHealthPoints;
			currentHealthPoints = totalHealthPoints;
		}
	}
}

