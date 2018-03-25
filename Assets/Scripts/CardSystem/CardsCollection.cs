using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class CardsCollection
	{
		private List<Card> cardsCollectionContent = new List<Card> ();

		public CardsCollection (List<Card> cardsCollectionContent)
		{
			this.cardsCollectionContent = cardsCollectionContent;
		}

		public void AddCard(Card newCard){
			if (!cardsCollectionContent.Contains (newCard)) {
				cardsCollectionContent.Add (newCard);
			}
		}

		public void RemoveCard(Card toRemoveCard){
			if(cardsCollectionContent.Contains(toRemoveCard)){
				cardsCollectionContent.Remove(toRemoveCard);
			}
		}

		public bool Contains(Card toCheckCard){
			return cardsCollectionContent.Contains(toCheckCard);
		}
	}
}
