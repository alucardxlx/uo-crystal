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
	public class TveastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TveastAddonDeed();
			}
		}

		[ Constructable ]
		public TveastAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 15 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 15 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 14 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 14 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 13 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 13 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 12 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 12 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 11 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 11 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 10 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 10 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 9 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 9 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 8 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 8 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 7 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 7 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 1, 5 );
			ac = new AddonComponent( 7387 );
			ac.Hue = 1109;
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 2, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 15 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 2, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, 1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 10 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 2, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 5 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1;
			AddComponent( ac, 1, -1, 0 );

		}

		public TveastAddon( Serial serial ) : base( serial )
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

	public class TveastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TveastAddon();
			}
		}

		[Constructable]
		public TveastAddonDeed()
		{
			Name = "Tveast";
		}

		public TveastAddonDeed( Serial serial ) : base( serial )
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