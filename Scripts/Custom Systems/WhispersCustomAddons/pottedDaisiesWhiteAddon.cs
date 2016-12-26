
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
	public class pottedDaisiesWhiteAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4551, 0, 0, 2}// 3	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new pottedDaisiesWhiteAddonDeed();
			}
		}

		[ Constructable ]
		public pottedDaisiesWhiteAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4180, -1, 0, 0, 1150, -1, "daisies", 2);// 1
			AddComplexComponent( (BaseAddon) this, 4179, 0, -1, 0, 1150, -1, "Daisies", 2);// 2
			AddComplexComponent( (BaseAddon) this, 3332, 0, 0, 5, 0, -1, "leaves", 1);// 4
			AddComplexComponent( (BaseAddon) this, 6093, 1, 1, 17, 1150, -1, "daisies", 1);// 5
			AddComplexComponent( (BaseAddon) this, 6094, 0, 0, 11, 1150, -1, "daisies", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4180, 0, 0, 9, 1150, -1, "daisies", 2);// 7
			AddComplexComponent( (BaseAddon) this, 4179, 0, 0, 5, 1150, -1, "Daisies", 2);// 8
			AddComplexComponent( (BaseAddon) this, 4179, 1, 1, 12, 1150, -1, "Daisies", 1);// 9

		}

		public pottedDaisiesWhiteAddon( Serial serial ) : base( serial )
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

	public class pottedDaisiesWhiteAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new pottedDaisiesWhiteAddon();
			}
		}

		[Constructable]
		public pottedDaisiesWhiteAddonDeed()
		{
			Name = "pottedDaisiesWhite";
		}

		public pottedDaisiesWhiteAddonDeed( Serial serial ) : base( serial )
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