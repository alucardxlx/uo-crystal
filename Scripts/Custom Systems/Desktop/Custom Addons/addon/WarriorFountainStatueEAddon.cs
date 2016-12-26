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
	public class WarriorFountainStatueEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WarriorFountainStatueEAddonDeed();
			}
		}

		[ Constructable ]
		public WarriorFountainStatueEAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 280 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 281 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 280 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 282 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1091 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1090 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1091 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 13422 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, -1, 1, 11 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, -1, 1, 21 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 0, 0, 11 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 0, 1, 11 );
			ac = new AddonComponent( 13591 );
			AddComponent( ac, 0, 1, 21 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 0, 1, 11 );
			ac = new AddonComponent( 13561 );
			AddComponent( ac, 0, 1, 21 );
			ac = new AddonComponent( 8109 );
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 1173 );
			AddComponent( ac, 0, 1, 33 );
			ac = new AddonComponent( 4824 );
			AddComponent( ac, 0, 1, 34 );

		}

		public WarriorFountainStatueEAddon( Serial serial ) : base( serial )
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

	public class WarriorFountainStatueEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WarriorFountainStatueEAddon();
			}
		}

		[Constructable]
		public WarriorFountainStatueEAddonDeed()
		{
			Name = "WarriorFountainStatueE";
		}

		public WarriorFountainStatueEAddonDeed( Serial serial ) : base( serial )
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