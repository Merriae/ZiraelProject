using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Deck : CardPile
	{
		private string deckName;
		private Faction deckFaction;

		private Leader leaderCard;

		private CardsCollection cardsCollection;

		public Deck (string deckName, Faction deckFaction, CardsCollection cardsCollection, List<Card> deckContent, Leader leaderCard)
		{
			maximumSize = CardSystemConstantValues.maximumDeckSize;

			this.deckName = deckName;
			this.deckFaction = deckFaction;
			this.cardsCollection = cardsCollection;
			this.cardPileContent = deckContent;
			this.leaderCard = leaderCard;
		}

		public int GetMaximumSize(){
			return maximumSize;
		}

		public Card Draw(){
			if (cardPileContent.Count > 0) {
				Card toDraw = cardPileContent [0];
				cardPileContent.RemoveAt (0);
			}
			throw new Exception ("Deck.Draw() exception");
		}
	}
}
