using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Deck : CardPile
	{
		private static int maximumSize = CardSystemConstantValues.maximumDeckSize;

		private string deckName;
		private Faction deckFaction;

		private CardsCollection cardsCollection;

		public Deck (string deckName, Faction deckFaction, CardsCollection cardsCollection, List<Card> deckContent)
		{
			this.deckName = deckName;
			this.deckFaction = deckFaction;
			this.cardsCollection = cardsCollection;
			this.cardPileContent = deckContent;
		}

		public void addCard(Card newCard){
			if(cardPileContent.Count < maximumSize && cardsCollection.contains(newCard) && ( newCard.GetCardFaction().Equals(deckFaction) || newCard.GetCardFaction().GetType() == typeof(Neutral))){
				cardPileContent.Add (newCard);
			}
		}

		public void removeCard(Card toRemoveCard){
			if(cardPileContent.Count > 0 && cardPileContent.Contains(toRemoveCard)){
				cardPileContent.Remove (toRemoveCard);
			}
		}
	}
}

