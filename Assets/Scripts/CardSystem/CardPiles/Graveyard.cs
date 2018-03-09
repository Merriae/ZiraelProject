using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Graveyard : CardPile
	{
		public Graveyard (List<Card> graveyardContent)
		{
			this.cardPileContent = graveyardContent;
		}

		public void addCard(Card newCard){
			cardPileContent.Add (newCard);
		}

		public void removeCard(Card toRemoveCard){
			cardPileContent.Remove (toRemoveCard);
		}
	}
}

