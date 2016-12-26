
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
	public class CarpetRed7x7Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2760, -2, -2, 0}, {2760, -2, -1, 0}, {2760, -2, 0, 0}// 1	2	3	
			, {2760, -1, -2, 0}, {2760, -1, -1, 0}, {2760, -1, 0, 0}// 4	5	6	
			, {2760, 0, -2, 0}, {2760, 0, -1, 0}, {2760, 0, 0, 0}// 7	8	9	
			, {2760, 1, -2, 0}, {2760, 1, -1, 0}, {2760, 1, 0, 0}// 10	11	12	
			, {2760, 2, -2, 0}, {2760, 2, -1, 0}, {2760, 2, 0, 0}// 13	14	15	
			, {2762, -3, -3, 0}, {2764, 3, -3, 0}, {2765, -3, -2, 0}// 16	17	18	
			, {2765, -3, -1, 0}, {2765, -3, 0, 0}, {2766, -2, -3, 0}// 19	20	21	
			, {2766, -1, -3, 0}, {2766, 0, -3, 0}, {2766, 1, -3, 0}// 22	23	24	
			, {2766, 2, -3, 0}, {2767, 3, -2, 0}, {2767, 3, -1, 0}// 25	26	27	
			, {2767, 3, 0, 0}, {2761, 3, 3, 0}, {2760, -2, 1, 0}// 28	29	30	
			, {2760, -1, 1, 0}, {2760, 0, 1, 0}, {2760, 1, 1, 0}// 31	32	33	
			, {2760, 2, 1, 0}, {2760, 2, 2, 0}, {2760, 1, 2, 0}// 34	35	36	
			, {2760, 0, 2, 0}, {2760, -1, 2, 0}, {2760, -2, 2, 0}// 37	38	39	
			, {2763, -3, 3, 0}, {2765, -3, 1, 0}, {2765, -3, 2, 0}// 40	41	42	
			, {2767, 3, 1, 0}, {2767, 3, 2, 0}, {2768, -2, 3, 0}// 43	44	45	
			, {2768, -1, 3, 0}, {2768, 0, 3, 0}, {2768, 1, 3, 0}// 46	47	48	
			, {2768, 2, 3, 0}// 49	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CarpetRed7x7AddonDeed();
			}
		}

		[ Constructable ]
		public CarpetRed7x7Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CarpetRed7x7Addon( Serial serial ) : base( serial )
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

	public class CarpetRed7x7AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CarpetRed7x7Addon();
			}
		}

		[Constructable]
		public CarpetRed7x7AddonDeed()
		{
			Name = "CarpetRed7x7";
		}

		public CarpetRed7x7AddonDeed( Serial serial ) : base( serial )
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