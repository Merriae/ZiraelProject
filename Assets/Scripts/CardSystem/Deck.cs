using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Deck
	{
		private static int maximumSize = CardSystemConstantValues.maximumDeckSize;

		private string deckName;
		private Faction deckFaction;

		private CardsCollection cardsCollection;

		private List<Card> deckContent = new List<Card> ();

		public Deck (string deckName, Faction deckFaction, CardsCollection cardsCollection, List<Card> deckContent)
		{
			this.deckName = deckName;
			this.deckFaction = deckFaction;
			this.cardsCollection = cardsCollection;
			this.deckContent = deckContent;
		}

		public void addCard(Card newCard){
			if(deckContent.Count < maximumSize && cardsCollection.contains(newCard) && ( newCard.GetCardFaction().Equals(deckFaction) || newCard.GetCardFaction().GetType() == typeof(Neutral))){
				deckContent.Add (newCard);
			}
		}

		public void removeCard(Card toRemoveCard){
			if(deckContent.Count > 0 && deckContent.Contains(toRemoveCard)){
				deckContent.Remove (toRemoveCard);
			}
		}
	}
}

