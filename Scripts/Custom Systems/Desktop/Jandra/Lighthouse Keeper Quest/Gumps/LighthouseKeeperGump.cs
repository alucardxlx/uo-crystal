using System; 
using Server;
using Server.Commands; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class LighthouseKeeperGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "LighthouseKeeperGump", AccessLevel.GameMaster, new CommandEventHandler( LighthouseKeeperGump_OnCommand ) ); 
      } 

      private static void LighthouseKeeperGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new LighthouseKeeperGump( e.Mobile ) ); 
      } 

      public LighthouseKeeperGump( Mobile owner ) : base( 50,50 ) 
      { 
//----------------------------------------------------------------------------------------------------

				AddPage( 0 );
			AddImageTiled(  54, 33, 369, 400, 2624 );
			AddAlphaRegion( 54, 33, 369, 400 );

			AddImageTiled( 416, 39, 44, 389, 203 );
//--------------------------------------Window size bar--------------------------------------------
			
			AddImage( 97, 49, 9005 );
			AddImageTiled( 58, 39, 29, 390, 10460 );
			AddImageTiled( 412, 37, 31, 389, 10460 );
			AddLabel( 140, 60, 0x34, "Lighthouse Keeper Quest" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=White><I>The Lighthouse Keeper looks at you intently.</I><br><br>" +
"<BASEFONT Color=White>I see you have come to help me with my dimming light. I am unable to keep watch over this lighthouse and find the time to seek out more Light Enhancing Crystals.<br><br>" + 
"<BASEFONT COLOR=White>There is a creature that carries these crystals. It is thought that it wanders near the lighthouse, in the far north ofT2A.<br><br>" +
"<BASEFONT COLOR=White>If you can bring me a light enhancing crystal, I will reward you with a Travel Book.<br><br>" +
"<BASEFONT COLOR=White>This is not just an ordinary Travel Book. I have been able to alter the Light Enhancing Crystals to work within the pages to provide a way of travel. Though I have yet to find a way to make the amount of uses indefinate.<br><br>" +
"<BASEFONT COLOR=White>In any case, please bring me back a Light Enhancing Crystal. I will be more than happy to reward your efforts.<br><br>" +
"<BASEFONT COLOR=White>Thank you!<br>" + 
"</BODY>", false, true);
			
			AddImage( 430, 9, 10441);
			AddImageTiled( 40, 38, 17, 391, 9263 );
			AddImage( 6, 25, 10421 );
			AddImage( 34, 12, 10420 );
			AddImageTiled( 94, 25, 342, 15, 10304 );
			AddImageTiled( 40, 427, 415, 16, 10304 );
			AddImage( -10, 314, 10402 );
			AddImage( 56, 150, 10411 );
			AddImage( 155, 120, 2103 );
			AddImage( 136, 84, 96 );

			AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 ); 

//--------------------------------------------------------------------------------------------------------------
      } 

      public override void OnResponse( NetState state, RelayInfo info ) //Function for GumpButtonType.Reply Buttons 
      { 
         Mobile from = state.Mobile; 

         switch ( info.ButtonID ) 
         { 
            case 0: //Case uses the ActionIDs defenied above. Case 0 defenies the actions for the button with the action id 0 
            { 
               //Cancel 
               from.SendMessage( "May the light travel with thee on your journey." );
               break; 
            } 

         }
      }
   }
}