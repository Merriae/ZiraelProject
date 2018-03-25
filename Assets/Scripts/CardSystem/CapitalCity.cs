using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class CapitalCity
	{
		private Deck deck;
		private Graveyard graveyard;
		private Hand hand;
		private PoliticsRow politicsRow;
		private UnitsRow unitsRow;

		private int totalHealthPoints;
		private int currentHealthPoints;

		public CapitalCity (Deck deck)
		{
			this.deck = deck;
			graveyard = new Graveyard (new List<Card> ());
			hand = new Hand (new List<Card> ());
			politicsRow = new PoliticsRow (new List <Card> ());
			unitsRow = new UnitsRow (new List<Card> ());
			totalHealthPoints = CardSystemConstantValues.capitalCityBaseHealthPoints;
			currentHealthPoints = totalHealthPoints;
		}

		public void Draw(){
			if (hand.GetSize () < hand.GetMaximumSize () && deck.GetSize () > 0) {
				hand.AddCard (deck.Draw ());
			}
		}

		public void Resurrect(Card toResurrect){
			if (graveyard.Contains (toResurrect) && hand.GetSize() < hand.GetMaximumSize()) {
				graveyard.RemoveCard (toResurrect);
				hand.AddCard (toResurrect);
			}
		}

		public void Kill(CardPile cardLocation, Card toKill){
			if (cardLocation.Contains (toKill)) {
				cardLocation.RemoveCard (toKill);
				graveyard.AddCard (toKill);
			}
		}

		public void Play(Card toPlay){
			if (hand.Contains (toPlay)) {
				
			}
		}
	}
}

