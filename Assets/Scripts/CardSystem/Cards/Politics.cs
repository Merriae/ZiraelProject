using System;

namespace AssemblyCSharp
{
	public class Politics : Card
	{
		private Effect onPlayEffect=null;
		private Effect onDeathEffect=null;
		private Effect onTurnEndEffect=null;
		private Effect onDrawEffect=null;

		public Politics (string cardName, string cardDescription, Faction cardFaction, int power, Effect onPlayEffect, Effect onDeathEffect, Effect onTurnEndEffect, Effect onDrawEffect)
		{
			this.cardName = cardName;
			this.cardDescription = cardDescription;
			this.cardFaction = cardFaction;
			this.power = power;

			this.onPlayEffect = onPlayEffect;
			this.onDeathEffect = onDeathEffect; 
			this.onTurnEndEffect = onTurnEndEffect;
			this.onDrawEffect = onDrawEffect;

			typeOrder = 2;
		}
	}
}

