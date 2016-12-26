
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
	public class vaseDaisiesYellowAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new vaseDaisiesYellowAddonDeed();
			}
		}

		[ Constructable ]
		public vaseDaisiesYellowAddon()
		{



			AddComplexComponent( (BaseAddon) this, 6094, 0, 0, 8, 1161, -1, "daisies", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6094, 0, 0, 11, 1161, -1, "daisies", 1);// 2
			AddComplexComponent( (BaseAddon) this, 12629, 0, 0, 1, 1150, -1, "vase", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2519, 0, 0, 0, 1150, -1, "", 1);// 4

		}

		public vaseDaisiesYellowAddon( Serial serial ) : base( serial )
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

	public class vaseDaisiesYellowAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new vaseDaisiesYellowAddon();
			}
		}

		[Constructable]
		public vaseDaisiesYellowAddonDeed()
		{
			Name = "vaseDaisiesYellow";
		}

		public vaseDaisiesYellowAddonDeed( Serial serial ) : base( serial )
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