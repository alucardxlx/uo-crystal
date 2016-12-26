
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
	public class CarpetGold7x7Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2778, -2, -2, 0}, {2778, -2, -1, 0}, {2778, -2, 0, 0}// 1	2	3	
			, {2778, -2, 1, 0}, {2778, -1, -2, 0}, {2778, -1, -1, 0}// 4	5	6	
			, {2778, -1, 0, 0}, {2778, -1, 1, 0}, {2778, 0, -2, 0}// 7	8	9	
			, {2778, 0, -1, 0}, {2778, 0, 0, 0}, {2778, 0, 1, 0}// 10	11	12	
			, {2778, 1, -2, 0}, {2778, 1, -1, 0}, {2778, 1, 0, 0}// 13	14	15	
			, {2778, 1, 1, 0}, {2778, 2, -2, 0}, {2778, 2, -1, 0}// 16	17	18	
			, {2778, 2, 0, 0}, {2778, 2, 1, 0}, {2780, -3, -3, 0}// 19	20	21	
			, {2782, 3, -3, 0}, {2783, -3, -2, 0}, {2783, -3, -1, 0}// 22	23	24	
			, {2783, -3, 0, 0}, {2783, -3, 1, 0}, {2784, -2, -3, 0}// 25	26	27	
			, {2784, -1, -3, 0}, {2784, 0, -3, 0}, {2784, 1, -3, 0}// 28	29	30	
			, {2784, 2, -3, 0}, {2785, 3, -2, 0}, {2785, 3, -1, 0}// 31	32	33	
			, {2785, 3, 0, 0}, {2785, 3, 1, 0}, {2778, -2, 2, 0}// 34	35	36	
			, {2778, -1, 2, 0}, {2778, 0, 2, 0}, {2778, 1, 2, 0}// 37	38	39	
			, {2778, 2, 2, 0}, {2779, 3, 3, 0}, {2781, -3, 3, 0}// 40	41	42	
			, {2783, -3, 2, 0}, {2785, 3, 2, 0}, {2786, -2, 3, 0}// 43	44	45	
			, {2786, -1, 3, 0}, {2786, 0, 3, 0}, {2786, 1, 3, 0}// 46	47	48	
			, {2786, 2, 3, 0}// 49	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CarpetGold7x7AddonDeed();
			}
		}

		[ Constructable ]
		public CarpetGold7x7Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CarpetGold7x7Addon( Serial serial ) : base( serial )
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

	public class CarpetGold7x7AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CarpetGold7x7Addon();
			}
		}

		[Constructable]
		public CarpetGold7x7AddonDeed()
		{
			Name = "CarpetGold7x7";
		}

		public CarpetGold7x7AddonDeed( Serial serial ) : base( serial )
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