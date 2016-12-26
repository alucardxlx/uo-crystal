// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class PumpkinHugeAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new PumpkinHugeAddonDeed();}}
		[ Constructable ]
		public PumpkinHugeAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			AddComponent( ac, 0, -1, 0 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, -1, 0, 4 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, 0, 10 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, -1, 5 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			AddComponent( ac, -1, 0, 1 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			AddComponent( ac, -1, -1, 1 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, 0, 14 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, -1, 0, 1 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			AddComponent( ac, -1, -1, 0 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, 0, 9 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, -1, 0 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, 0, 4 );

			ac = new AddonComponent( 3391 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, -1, 8 );

			ac = new AddonComponent( 3392 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, 0, 16 );

			ac = new AddonComponent( 3392 );
			ac.Hue = 1260;
			AddComponent( ac, 0, -1, 5 );

			ac = new AddonComponent( 3392 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, -1, 0, 4 );

			ac = new AddonComponent( 3392 );
			ac.Hue = 1260;
			AddComponent( ac, 0, 0, 9 );

			ac = new AddonComponent( 3392 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, -1, 0 );

			ac = new AddonComponent( 3392 );
			ac.Hue = 1260;
			ac.Name = "pumpkin";
			AddComponent( ac, 0, 0, 0 );

			ac = new AddonComponent( 12683 );
			ac.Hue = 2712;
			ac.Name = "mouth";
			AddComponent( ac, 1, 1, 16 );

			ac = new AddonComponent( 3385 );
			ac.Hue = 2712;
			ac.Name = "eye";
			AddComponent( ac, 1, 0, 20 );

			ac = new AddonComponent( 3385 );
			ac.Hue = 2712;
			ac.Name = "eye";
			AddComponent( ac, 0, 1, 20 );

			ac = new AddonComponent( 3169 );
			ac.Name = "stem";
			AddComponent( ac, 0, 0, 24 );

			ac = new AddonComponent( 9669 );
			ac.Hue = 2712;
			ac.Name = "hairpiece";
			AddComponent( ac, 0, 0, 18 );

			ac = new AddonComponent( 3168 );
			AddComponent( ac, 1, -1, 2 );

			ac = new AddonComponent( 3168 );
			AddComponent( ac, 1, 0, 2 );

			ac = new AddonComponent( 3168 );
			AddComponent( ac, 0, 1, 2 );

			ac = new AddonComponent( 3168 );
			AddComponent( ac, 1, 1, 6 );

			ac = new AddonComponent( 3168 );
			AddComponent( ac, -1, 1, 0 );

			ac = new AddonComponent( 5443 );
			ac.Hue = 67;
			ac.Name = "stem";
			AddComponent( ac, 0, 0, 27 );


		}
		public PumpkinHugeAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class PumpkinHugeAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new PumpkinHugeAddon();}}
		[Constructable]
		public PumpkinHugeAddonDeed(){Name = "PumpkinHuge";}
		public PumpkinHugeAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}