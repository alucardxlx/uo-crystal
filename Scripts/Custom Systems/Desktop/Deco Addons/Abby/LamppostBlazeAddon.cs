
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class LamppostBlazeAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LamppostBlazeAddonDeed();
			}
		}

		[ Constructable ]
		public LamppostBlazeAddon()
		{



			AddComplexComponent( (BaseAddon) this, 2848, 0, 0, 0, 0, 1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6374, 0, 0, 9, 0, -1, "vine", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4180, 0, 0, 15, 1161, -1, "morning glories", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6376, 0, 0, 15, 0, -1, "vine", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4176, 0, 0, 12, 1161, -1, "morning glory", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6376, 1, 1, 15, 0, -1, "vine", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4179, 1, 1, 12, 1161, -1, "morning glories", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6376, 1, 1, 11, 0, -1, "vine", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4175, 1, 1, 13, 1161, -1, "morning glory", 1);// 9

		}

		public LamppostBlazeAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class LamppostBlazeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LamppostBlazeAddon();
			}
		}

		[Constructable]
		public LamppostBlazeAddonDeed()
		{
			Name = "LamppostBlaze";
		}

		public LamppostBlazeAddonDeed( Serial serial ) : base( serial )
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