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
	public class CarpentryWorkShopAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CarpentryWorkShopAddonDeed();
			}
		}

		[ Constructable ]
		public CarpentryWorkShopAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 6647 );
			AddComponent( ac, -2, -3, 1 );
			ac = new AddonComponent( 6646 );
			AddComponent( ac, -1, -3, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -3, -3, 2 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -2, -2, 2 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -3, -2, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -2, -3, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -2, -2, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -1, -3, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -1, -2, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 0, -3, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 0, -2, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 1, -3, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 1, -2, 1 );
			ac = new AddonComponent( 7793 );
			AddComponent( ac, 2, -3, 1 );
			ac = new AddonComponent( 7801 );
			AddComponent( ac, -1, -3, 5 );
			ac = new AddonComponent( 7801 );
			AddComponent( ac, 3, -3, 1 );
			ac = new AddonComponent( 7799 );
			AddComponent( ac, -3, -3, 1 );
			ac = new AddonComponent( 7790 );
			AddComponent( ac, 1, -3, 1 );
			ac = new AddonComponent( 6643 );
			AddComponent( ac, -3, -2, 1 );
			ac = new AddonComponent( 6645 );
			AddComponent( ac, 0, -3, 1 );
			ac = new AddonComponent( 6641 );
			AddComponent( ac, -3, 0, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -3, -1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -3, 0, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -3, 1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -2, -1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -2, 0, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -2, 1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 4152 );
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 7806 );
			AddComponent( ac, -3, 3, 1 );
			ac = new AddonComponent( 6651 );
			AddComponent( ac, -1, 3, 1 );
			ac = new AddonComponent( 6652 );
			AddComponent( ac, 0, 3, 1 );
			ac = new AddonComponent( 6649 );
			AddComponent( ac, 3, 1, 1 );
			ac = new AddonComponent( 6650 );
			AddComponent( ac, 3, 0, 1 );
			ac = new AddonComponent( 7799 );
			AddComponent( ac, -3, 3, 1 );
			ac = new AddonComponent( 7799 );
			AddComponent( ac, -3, 1, 1 );
			ac = new AddonComponent( 7129 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 7134 );
			AddComponent( ac, 3, 2, 1 );
			ac = new AddonComponent( 6642 );
			AddComponent( ac, -3, -1, 1 );

		}

		public CarpentryWorkShopAddon( Serial serial ) : base( serial )
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

	public class CarpentryWorkShopAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CarpentryWorkShopAddon();
			}
		}

		[Constructable]
		public CarpentryWorkShopAddonDeed()
		{
			Name = "CarpentryWorkShop";
		}

		public CarpentryWorkShopAddonDeed( Serial serial ) : base( serial )
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