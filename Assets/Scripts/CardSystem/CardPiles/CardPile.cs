using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public abstract class CardPile
	{
		protected List<Card> cardPileContent = new List<Card>();

		private Random rng = new Random ();

		protected int maximumSize;

		protected void Shuffle(){
			int currentRandomIndex, n = cardPileContent.Count;
			Card tmp;

			for (int i=0; i < n; i++) {
				tmp = cardPileContent[i];
				currentRandomIndex = rng.Next(0, n);

				cardPileContent [i] = cardPileContent [currentRandomIndex];
				cardPileContent [currentRandomIndex] = tmp;
			}
		}

		public int GetSize(){
			return cardPileContent.Count;
		}

		protected void Sort(){
			cardPileContent.Sort ();
		}

		public bool Contains(Card toCheckCard){
			return cardPileContent.Contains(toCheckCard);
		}

		public void AddCard(Card newCard){
			if(cardPileContent.Count < maximumSize){
				cardPileContent.Add (newCard);
			}
		}

		public void RemoveCard(Card toRemoveCard){
			if(cardPileContent.Count > 0 && cardPileContent.Contains(toRemoveCard)){
				cardPileContent.Remove (toRemoveCard);
			}
		}
	}
}

