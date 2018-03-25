using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class UnitsRow : CardPile
	{
		public UnitsRow (List<Card> unitsRowContent)
		{
			maximumSize = CardSystemConstantValues.maximumUnitsRowSize;

			this.cardPileContent = unitsRowContent;
		}
	}
}

