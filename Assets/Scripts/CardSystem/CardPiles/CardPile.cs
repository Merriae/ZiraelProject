using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public abstract class CardPile
	{
		protected List<Card> cardPileContent = new List<Card>();

		private Random rng = new Random ();

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

	}
}

