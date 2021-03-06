
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
	public class ConversationPitWAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, -2, -3, 0}, {1848, -2, -2, 0}, {1848, -2, 2, 0}// 1	2	3	
			, {2758, -2, -2, 0}, {2758, -2, -1, 0}, {2758, -2, 0, 0}// 4	5	6	
			, {2758, -2, 1, 0}, {2758, -2, 2, 0}, {1848, -2, 3, 0}// 7	8	9	
			, {1848, -1, -3, 0}, {1848, 0, -3, 0}, {1848, 1, -3, 0}// 10	11	12	
			, {1848, 2, -3, 0}, {1848, 3, -3, 0}, {1848, 3, -1, 0}// 14	15	16	
			, {1848, 3, 0, 0}, {1848, 2, 2, 0}, {1848, 1, 3, 0}// 17	18	19	
			, {1848, 3, 1, 0}, {1848, 0, 3, 0}, {1848, 3, -2, 0}// 20	21	31	
			, {1848, 3, 2, 0}, {1848, 2, 3, 0}, {1848, -1, 3, 0}// 32	33	34	
			, {2758, -1, -2, 0}, {2758, -1, -1, 0}, {2758, -1, 0, 0}// 35	36	37	
			, {2758, -1, 1, 0}, {2758, -1, 2, 0}, {2758, 0, -2, 0}// 38	39	40	
			, {2758, 0, -1, 0}, {2758, 0, 0, 0}, {2758, 0, 1, 0}// 41	42	43	
			, {2758, 0, 2, 0}, {2758, 1, -2, 0}, {2758, 1, -1, 0}// 44	45	46	
			, {2758, 1, 0, 0}, {2758, 1, 1, 0}, {2758, 1, 2, 0}// 47	48	49	
			, {1848, 3, 3, 0}, {1848, 2, -2, 0}// 64	66	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ConversationPitWAddonDeed();
			}
		}

		[ Constructable ]
		public ConversationPitWAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5036, 0, -3, 5, 33, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4632, -1, -2, 0, 1031, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 4632, 0, -2, 0, 1031, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 4632, 1, -2, 0, 1031, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 4635, 2, -1, 0, 1031, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 4635, 2, 0, 0, 1031, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 4635, 2, 1, 0, 1031, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 4634, 1, 2, 0, 1031, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 4634, 0, 2, 0, 1031, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 4634, -1, 2, 0, 1031, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2723, -1, -1, 0, 0, -1, "table", 1);// 50
			AddComplexComponent( (BaseAddon) this, 2724, 1, -1, 0, 0, -1, "table", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2725, -1, 1, 0, 0, -1, "table", 1);// 52
			AddComplexComponent( (BaseAddon) this, 2840, 1, 1, 0, 0, -1, "table", 1);// 53
			AddComplexComponent( (BaseAddon) this, 2720, 0, 1, 0, 0, -1, "table", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2719, 1, 0, 0, 0, -1, "table", 1);// 55
			AddComplexComponent( (BaseAddon) this, 2721, -1, 0, 0, 0, -1, "table", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2722, 0, -1, 0, 0, -1, "table", 1);// 57
			AddComplexComponent( (BaseAddon) this, 7386, 1, 1, 8, 1150, -1, "frosted glass", 1);// 58
			AddComplexComponent( (BaseAddon) this, 7386, 0, 1, 8, 1150, -1, "frosted glass", 1);// 59
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 8, 1150, -1, "frosted glass", 1);// 60
			AddComplexComponent( (BaseAddon) this, 7386, 1, 0, 8, 1150, -1, "frosted glass", 1);// 61
			AddComplexComponent( (BaseAddon) this, 5032, 3, 0, 5, 33, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 5035, 0, 3, 5, 33, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 5018, 3, 3, 13, 1150, -1, "", 1);// 65

		}

		public ConversationPitWAddon( Serial serial ) : base( serial )
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

	public class ConversationPitWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ConversationPitWAddon();
			}
		}

		[Constructable]
		public ConversationPitWAddonDeed()
		{
			Name = "ConversationPitW";
		}

		public ConversationPitWAddonDeed( Serial serial ) : base( serial )
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