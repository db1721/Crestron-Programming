#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_UserProgCmd_Interface_Serial_To_Analog_v1_0.h"

FUNCTION_MAIN( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 );
EVENT_HANDLER( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 );
DEFINE_ENTRYPOINT( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, 00000 /*In*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __INDEX; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ), 42 );
    __INDEX = GetLocalLastModifiedArrayIndex ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ), 43 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) , GENERIC_STRING_OUTPUT( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 )  ,2 , "%u"  , (unsigned short )( GetInOutArrayElement( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ), &Globals->S2_UserProgCmd_Interface_Serial_To_Analog_v1_0.__IN , __INDEX  ) ) )  ; 
    SET_STRING_OUT_ARRAY_ELEMENT( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __OUT$ , __INDEX ) ; 
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); }
    
    ; 
    
    S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, 00001 /*In$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __INDEX; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ), 50 );
    __INDEX = GetLocalLastModifiedArrayIndex ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ), 51 );
    SetOutputArrayElement ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ), &Globals->S2_UserProgCmd_Interface_Serial_To_Analog_v1_0.__OUT ,__INDEX, Atoi( GetStringArrayElement ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ), GLOBAL_STRING_ARRAY( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __IN$  )  ,  __INDEX  ) )) ; 
    
    S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_Exit__Event_1:
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); 
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
        case __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_IN_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, 00000 /*In*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_IN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, 00001 /*In$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 )
********************************************************************************/
EVENT_HANDLER( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __IN ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __IN$ ) ;
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
  FUNCTION_MAIN( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 )
********************************************************************************/
FUNCTION_MAIN( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0 );
    INITIALIZE_IO_ARRAY ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __IN, IO_TYPE_ANALOG_INPUT, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_IN_ANALOG_INPUT, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_IN_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __OUT, IO_TYPE_ANALOG_OUTPUT, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_OUT_ANALOG_OUTPUT, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_OUT_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __OUT$, IO_TYPE_STRING_OUTPUT, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_OUT$_STRING_OUTPUT, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_OUT$_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __IN$, e_INPUT_TYPE_STRING, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_IN$_ARRAY_NUM_ELEMS, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_IN$_ARRAY_NUM_CHARS, __S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_IN$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, __IN$ );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_UserProgCmd_Interface_Serial_To_Analog_v1_0, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_UserProgCmd_Interface_Serial_To_Analog_v1_0_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
