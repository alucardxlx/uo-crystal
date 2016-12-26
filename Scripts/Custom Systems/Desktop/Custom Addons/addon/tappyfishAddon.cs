/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class tappyfishAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new tappyfishAddonDeed();
			}
		}

		[ Constructable ]
		public tappyfishAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 10386 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 10386 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 10383 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 10402 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1366;
			AddComponent( ac, 0, 2, 10 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1366;
			AddComponent( ac, 0, 1, 10 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1366;
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1366;
			AddComponent( ac, 0, -1, 10 );
			ac = new AddonComponent( 13566 );
			AddComponent( ac, -1, 2, 12 );
			ac = new AddonComponent( 13566 );
			AddComponent( ac, -1, 1, 12 );
			ac = new AddonComponent( 13566 );
			AddComponent( ac, -1, 0, 12 );
			ac = new AddonComponent( 13566 );
			AddComponent( ac, -1, -1, 12 );
			ac = new AddonComponent( 13596 );
			AddComponent( ac, 0, -2, 12 );
			ac = new AddonComponent( 3712 );
			AddComponent( ac, 0, 2, 12 );
			ac = new AddonComponent( 6981 );
			AddComponent( ac, 1, 2, 13 );
			ac = new AddonComponent( 6984 );
			AddComponent( ac, 0, 1, 12 );
			ac = new AddonComponent( 6986 );
			AddComponent( ac, 0, 0, 12 );
			ac = new AddonComponent( 6987 );
			AddComponent( ac, 0, -1, 12 );
			ac = new AddonComponent( 3543 );
			AddComponent( ac, 0, 0, 19 );
			ac = new AddonComponent( 3542 );
			AddComponent( ac, 0, 2, 16 );
			ac = new AddonComponent( 3219 );
			AddComponent( ac, 0, -1, 13 );
			ac = new AddonComponent( 3379 );
			AddComponent( ac, 0, 1, 14 );
			ac = new AddonComponent( 3269 );
			AddComponent( ac, 0, 2, 16 );
			ac = new AddonComponent( 3314 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 5367 );
			AddComponent( ac, 0, -1, 13 );
			ac = new AddonComponent( 5364 );
			AddComponent( ac, 0, 1, 13 );
			ac = new AddonComponent( 4037 );
			AddComponent( ac, 0, 0, 13 );
			ac = new AddonComponent( 4038 );
			AddComponent( ac, 0, 0, 13 );
			ac = new AddonComponent( 4042 );
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 7385 );
			ac.Hue = 1366;
			AddComponent( ac, 0, 2, 24 );
			ac = new AddonComponent( 7385 );
			ac.Hue = 1366;
			AddComponent( ac, 0, 1, 24 );
			ac = new AddonComponent( 7385 );
			ac.Hue = 1366;
			AddComponent( ac, 0, 0, 24 );
			ac = new AddonComponent( 7385 );
			ac.Hue = 1366;
			AddComponent( ac, 0, -1, 24 );
			ac = new AddonComponent( 3543 );
			AddComponent( ac, 0, 1, 15 );
			ac = new AddonComponent( 3542 );
			AddComponent( ac, 0, 0, 14 );
			ac = new AddonComponent( 3542 );
			AddComponent( ac, 0, -1, 13 );

		}

		public tappyfishAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class tappyfishAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new tappyfishAddon();
			}
		}

		[Constructable]
		public tappyfishAddonDeed()
		{
			Name = "tappyfish";
		}

		public tappyfishAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}