using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Hand : CardPile
	{
		public Hand (List<Card> handContent)
		{
			maximumSize = CardSystemConstantValues.maximumHandSize;

			this.cardPileContent = handContent;
		}

		public int GetMaximumSize(){
			return maximumSize;
		}
	}
}

