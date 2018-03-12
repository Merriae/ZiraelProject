using System;

namespace AssemblyCSharp
{
	public class Leader : Card
	{
		private Effect passiveEffect=null;

		public Leader (string cardName, string cardDescription, Faction cardFaction, int healthPoints, Effect passiveEffect)
		{
			this.cardName = cardName;
			this.cardDescription = cardDescription;
			this.cardFaction = cardFaction;
			this.passiveEffect = passiveEffect;

			typeOrder = 0;

			power = -1;
		}
	}
}