using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class GameManager
	{
		private Deck deck1;
		private Deck deck2;

		private CapitalCity city1;
		private CapitalCity city2;

		public GameManager (Deck deck1, Deck deck2)
		{
			this.deck1 = deck1;
			this.deck2 = deck2;

			city1 = new CapitalCity (deck1);
			city2 = new CapitalCity (deck2);
		}
	}
}

