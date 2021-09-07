#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_String_Check.h"

FUNCTION_MAIN( S2_String_Check );
EVENT_HANDLER( S2_String_Check );
DEFINE_ENTRYPOINT( S2_String_Check );

DEFINE_INDEPENDENT_EVENTHANDLER( S2_String_Check, 00000 /*SerialIn$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_String_Check ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_String_Check ), 13 );
    if ( (Len( GLOBAL_STRING_STRUCT( S2_String_Check, __SERIALIN$  )  ) > 0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_String_Check ), 14 );
        SetDigital ( INSTANCE_PTR( S2_String_Check ), __S2_String_Check_IS_NULL_DIG_OUTPUT, 0) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_String_Check ), 16 );
        SetDigital ( INSTANCE_PTR( S2_String_Check ), __S2_String_Check_IS_NULL_DIG_OUTPUT, 1) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_String_Check ), 18 );
    SetDigital ( INSTANCE_PTR( S2_String_Check ), __S2_String_Check_IS_STRING_DIG_OUTPUT, !( GetDigitalOutput( INSTANCE_PTR( S2_String_Check ), __S2_String_Check_IS_NULL_DIG_OUTPUT ) )) ; 
    
    S2_String_Check_Exit__Event_0:
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_Check ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_Check ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_String_Check ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_String_Check_SERIALIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_String_Check, 00000 /*SerialIn$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_Check ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_Check ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_Check ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_String_Check ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_Check ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_String_Check ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_String_Check )
********************************************************************************/
EVENT_HANDLER( S2_String_Check )
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
  FUNCTION_MAIN( S2_String_Check )
********************************************************************************/
FUNCTION_MAIN( S2_String_Check )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_String_Check );
    
    
    /* End local function variable declarations */
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_String_Check, __SERIALIN$, e_INPUT_TYPE_STRING, __S2_String_Check_SERIALIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_String_Check, __SERIALIN$, __S2_String_Check_SERIALIN$_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_String_Check, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_String_Check ), 23 );
    SetDigital ( INSTANCE_PTR( S2_String_Check ), __S2_String_Check_IS_NULL_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_String_Check ), 24 );
    SetDigital ( INSTANCE_PTR( S2_String_Check ), __S2_String_Check_IS_STRING_DIG_OUTPUT, 0) ; 
    
    S2_String_Check_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
