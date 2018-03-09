using System;

namespace AssemblyCSharp
{
	public abstract class Faction
	{
		protected string factionName;

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

			return Equals ( ( Faction ) other );
		}

		public bool Equals ( Faction other )
		{
			if (other == null) {
				return false;
			}

			if (ReferenceEquals (this, other)) {
				return true;
			}

			if (this.GetHashCode () != other.GetHashCode ()) {
				return false;
			}

			System.Diagnostics.Debug.Assert (
				base.GetType () != typeof(object));

			if (!base.Equals (other)) {
				return false;
			}

			return this.GetType () == other.GetType ();
		}

		public override int GetHashCode ()
		{
			return this.GetType ().GetHashCode ();
		}
	}
}

