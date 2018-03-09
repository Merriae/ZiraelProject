using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Hand : CardPile
	{
		private static int maximumSize = CardSystemConstantValues.maximumHandSize;

		public Hand (List<Card> handContent)
		{
			this.cardPileContent = handContent;
		}

		public void addCard(Card newCard){
			if(cardPileContent.Count < maximumSize){
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

