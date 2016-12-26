#region AuthorHeader
//
//	SpellCrafting version 3.0, by Xanthos and TheOutkastDev
//
//  Based on original ideas and code by TheOutkastDev
//
#endregion AuthorHeader
using System;
using Server;
using Server.Items;
using Server.SpellCrafting;

namespace Server.SpellCrafting.Crafts
{
	public class BonusDex
	{
		private static readonly int m_Minimum = 1;
		private static readonly int m_Maximum = 20;

		public static void Callback( Mobile from, object target, object craftState )
		{
			string errorMessage = null;
			CraftState cs = craftState as CraftState;

			try
			{
				if ( target is BaseJewel )
					SpellCraft.ApplyAttribute( from, cs.Book, cs.Id, (BaseJewel)target, AosAttribute.BonusDex, m_Minimum, m_Maximum );
				
				else
					errorMessage = SpellCraft.AssembleMessage( SpellCraft.MsgNums.Jewelry );
			}
			catch ( SpellCraftException e )
			{
				errorMessage = e.ToString();
			}
			finally
			{
				if ( null != errorMessage )
					from.SendMessage( errorMessage );
			}
		}
	}
}