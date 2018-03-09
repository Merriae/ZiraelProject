using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Hand
	{
		private static int maximumSize = CardSystemConstantValues.maximumHandSize;

		private List<Card> handContent = new List<Card> ();

		public Hand (List<Card> handContent)
		{
			this.handContent = handContent;
		}

		public void addCard(Card newCard){
			if(handContent.Count < maximumSize){
				handContent.Add (newCard);
			}
		}

		public void removeCard(Card toRemoveCard){
			if(handContent.Count > 0 && handContent.Contains(toRemoveCard)){
				handContent.Remove (toRemoveCard);
			}
		}
	}
}

