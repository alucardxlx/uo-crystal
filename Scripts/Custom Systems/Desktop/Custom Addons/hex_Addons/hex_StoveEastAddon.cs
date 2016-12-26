
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
	public class hex_StoveEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7137, 0, 1, 0}, {2495, 0, 1, 8}, {2879, 0, 1, 1}// 2	3	4	
			, {2522, 0, 1, 8}, {3133, 0, 1, 12}, {2909, 1, 1, 1}// 5	7	8	
			, {2517, 0, 1, 8}, {2541, 0, 0, 12}, {7134, 0, 0, 5}// 9	10	11	
			, {1276, 0, 0, 1}, {2416, 0, 0, 18}// 12	18	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new hex_StoveEastAddonDeed();
			}
		}

		[ Constructable ]
		public hex_StoveEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 441, -1, -1, 2, 1899, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 82, 0, 0, 3, 1899, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 82, 0, 0, 1, 1899, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1180, 0, 0, 5, 1891, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 6571, 0, 0, 8, 0, 29, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 85, 0, 0, 5, 1899, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 85, 0, 0, 8, 1899, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 82, 0, 0, 10, 1899, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 62, 0, -1, 1, 1899, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1180, 0, 0, 12, 1891, -1, "", 1);// 21

		}

		public hex_StoveEastAddon( Serial serial ) : base( serial )
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

	public class hex_StoveEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new hex_StoveEastAddon();
			}
		}

		[Constructable]
		public hex_StoveEastAddonDeed()
		{
			Name = "Stove East";
		}

		public hex_StoveEastAddonDeed( Serial serial ) : base( serial )
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