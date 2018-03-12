using System;

namespace AssemblyCSharp
{
	public class Power : Card
	{

		private Effect onPlayEffect=null;
		private Effect onTurnEndEffect=null;
		private Effect onDrawEffect=null;

		public Power (string cardName, string cardDescription, Faction cardFaction, Effect onPlayEffect, Effect onTurnEndEffect, Effect onDrawEffect)
		{
			this.cardName = cardName;
			this.cardDescription = cardDescription;
			this.cardFaction = cardFaction;

			this.onPlayEffect = onPlayEffect;
			this.onTurnEndEffect = onTurnEndEffect;
			this.onDrawEffect = onDrawEffect;

			typeOrder = 3;

			power = -1;
		}
	}
}

