using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Graveyard : CardPile
	{
		public Graveyard (List<Card> graveyardContent)
		{
			maximumSize = CardSystemConstantValues.maximumGraveyardSize;

			this.cardPileContent = graveyardContent;
		}
	}
}

