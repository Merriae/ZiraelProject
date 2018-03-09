using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Deck
	{
		private static int maximumSize = CardSystemConstantValues.maximumDeckSize;

		private string deckName;
		private Faction deckFaction;

		private List<Card> deckContent = new List<Card> ();

		public Deck (string deckName, Faction deckFaction, List<Card> deckContent)
		{
			this.deckName = deckName;
			this.deckFaction = deckFaction;
			this.deckContent = deckContent;
		}

		public void addCard(Card newCard){
			if(deckContent.Count < maximumSize && ( newCard.GetCardFaction().Equals(deckFaction) || newCard.GetCardFaction().GetType() == typeof(Neutral))){
				deckContent.Add (newCard);
			}
		}

		public void removeCard(Card toRemoveCard){
			if(deckContent.Count > 0 && deckContent.Contains(toRemoveCard)){
			}
		}
	}
}

