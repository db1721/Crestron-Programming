#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_String_HeaderFooter.h"

FUNCTION_MAIN( S2_String_HeaderFooter );
EVENT_HANDLER( S2_String_HeaderFooter );
DEFINE_ENTRYPOINT( S2_String_HeaderFooter );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_String_HeaderFooter, 00000 /*Middle*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_String_HeaderFooter ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_String_HeaderFooter ), 44 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_String_HeaderFooter ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_String_HeaderFooter ) , GENERIC_STRING_OUTPUT( S2_String_HeaderFooter )  ,6 , "%s%s%s"  , GLOBAL_STRING_STRUCT( S2_String_HeaderFooter, __HEADER  )  , GLOBAL_STRING_STRUCT( S2_String_HeaderFooter, __MIDDLE  )  , GLOBAL_STRING_STRUCT( S2_String_HeaderFooter, __FOOTER  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_String_HeaderFooter ), __S2_String_HeaderFooter_TX_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_String_HeaderFooter ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_String_HeaderFooter ) ); }
    
    ; 
    
    S2_String_HeaderFooter_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}


/********************************************************************************
  Constructor
********************************************************************************/

/********************************************************************************
  Destructor
********************************************************************************/

/********************************************************************************
  static void ProcessDigitalEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessDigitalEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_HeaderFooter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessAnalogEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessAnalogEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_HeaderFooter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_String_HeaderFooter ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_String_HeaderFooter_MIDDLE_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_String_HeaderFooter, 00000 /*Middle*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_HeaderFooter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketConnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketConnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_HeaderFooter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_HeaderFooter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_String_HeaderFooter ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_HeaderFooter ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketStatusEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketStatusEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_HeaderFooter ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_String_HeaderFooter )
********************************************************************************/
EVENT_HANDLER( S2_String_HeaderFooter )
    {
    SAVE_GLOBAL_POINTERS ;
    switch ( Signal->Type )
        {
        case e_SIGNAL_TYPE_DIGITAL :
            ProcessDigitalEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_ANALOG :
            ProcessAnalogEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STRING :
            ProcessStringEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_CONNECT :
            ProcessSocketConnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_DISCONNECT :
            ProcessSocketDisconnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_RECEIVE :
            ProcessSocketReceiveEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STATUS :
            ProcessSocketStatusEvent( Signal );
            break ;
        }
        
    RESTORE_GLOBAL_POINTERS ;
    
    }
    
/********************************************************************************
  FUNCTION_MAIN( S2_String_HeaderFooter )
********************************************************************************/
FUNCTION_MAIN( S2_String_HeaderFooter )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_String_HeaderFooter );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_String_HeaderFooter, __HEADER, e_INPUT_TYPE_STRING, __S2_String_HeaderFooter_HEADER_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_String_HeaderFooter, __HEADER, __S2_String_HeaderFooter_HEADER_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_String_HeaderFooter, __MIDDLE, e_INPUT_TYPE_STRING, __S2_String_HeaderFooter_MIDDLE_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_String_HeaderFooter, __MIDDLE, __S2_String_HeaderFooter_MIDDLE_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_String_HeaderFooter, __FOOTER, e_INPUT_TYPE_STRING, __S2_String_HeaderFooter_FOOTER_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_String_HeaderFooter, __FOOTER, __S2_String_HeaderFooter_FOOTER_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_String_HeaderFooter, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_String_HeaderFooter_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
