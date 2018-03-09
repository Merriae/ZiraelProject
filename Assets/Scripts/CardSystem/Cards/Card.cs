﻿using System;

namespace AssemblyCSharp
{
	public abstract class Card
	{
		protected string cardName;
		protected string cardDescription;
		protected Faction cardFaction;

		public string GetCardName(){
			return cardName;
		}

		public string GetCardDescription(){
			return cardDescription;
		}

		public Faction GetCardFaction(){
			return cardFaction;
		}

		public override bool Equals ( object other )
		{
			if ( other == null )
			{
				return false;
			}

			if ( this.GetType ( ) != other.GetType ( ) )
			{
				return false;
			}

			return Equals ( ( Card ) other );
		}

		public bool Equals ( Card other )
		{
			if ( other == null )
			{
				return false;
			}

			if ( ReferenceEquals ( this, other ) )
			{
				return true;
			}

			if ( this.GetHashCode ( ) != other.GetHashCode ( ) )
			{
				return false;
			}

			System.Diagnostics.Debug.Assert (
				base.GetType ( ) != typeof ( object ) );

			if ( !base.Equals ( other ) )
			{
				return false;
			}


			return (cardName == other.GetCardName() && cardDescription.Equals(other.GetCardDescription()) && cardFaction.Equals(other.GetCardFaction()) );
		}

		public override int GetHashCode ()
		{
			return cardName.GetHashCode () * 17 + cardDescription.GetHashCode () * 5 + cardFaction.GetHashCode ();
		}
	}
}

