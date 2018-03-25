using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class PoliticsRow : CardPile
	{
		public PoliticsRow (List<Card> politicsRowContent)
		{
			maximumSize = CardSystemConstantValues.maximumPoliticsRowSize;

			this.cardPileContent = politicsRowContent;
		}
	}
}
