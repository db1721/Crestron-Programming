#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_DMPS_String_to_Analog_Conversion_v1_1.h"

FUNCTION_MAIN( S2_DMPS_String_to_Analog_Conversion_v1_1 );
EVENT_HANDLER( S2_DMPS_String_to_Analog_Conversion_v1_1 );
DEFINE_ENTRYPOINT( S2_DMPS_String_to_Analog_Conversion_v1_1 );

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_String_to_Analog_Conversion_v1_1, 00000 /*Go*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    unsigned short  __J; 
    unsigned short  __TEMP; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 70 );
    __J = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 71 );
    SetDigital ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), __S2_DMPS_String_to_Analog_Conversion_v1_1_COMPLETE_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 72 );
    __FN_FOREND_VAL__1 = 240; 
    __FN_FORINIT_VAL__1 = 3; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 74 );
        __TEMP = 0; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 75 );
        if ( (Len( GLOBAL_STRING_STRUCT( S2_DMPS_String_to_Analog_Conversion_v1_1, __IN$  )  ) == 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 77 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 81 );
        __TEMP = (((Byte( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) , GLOBAL_STRING_STRUCT( S2_DMPS_String_to_Analog_Conversion_v1_1, __IN$  )  , __I ) << 9) + ((Byte( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) , GLOBAL_STRING_STRUCT( S2_DMPS_String_to_Analog_Conversion_v1_1, __IN$  )  , (__I + 1) ) & 127) << 2)) + (Byte( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) , GLOBAL_STRING_STRUCT( S2_DMPS_String_to_Analog_Conversion_v1_1, __IN$  )  , (__I + 2) ) & 3)); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 82 );
        SetOutputArrayElement ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), &Globals->S2_DMPS_String_to_Analog_Conversion_v1_1.__OUT ,__J, __TEMP) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 83 );
        __J = (__J + 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 72 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), 86 );
    SetDigital ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ), __S2_DMPS_String_to_Analog_Conversion_v1_1_COMPLETE_DIG_OUTPUT, 1) ; 
    
    S2_DMPS_String_to_Analog_Conversion_v1_1_Exit__Event_0:
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
        case __S2_DMPS_String_to_Analog_Conversion_v1_1_GO_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_String_to_Analog_Conversion_v1_1, 00000 /*Go*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_String_to_Analog_Conversion_v1_1 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_String_to_Analog_Conversion_v1_1 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_String_to_Analog_Conversion_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_DMPS_String_to_Analog_Conversion_v1_1 )
********************************************************************************/
EVENT_HANDLER( S2_DMPS_String_to_Analog_Conversion_v1_1 )
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
  FUNCTION_MAIN( S2_DMPS_String_to_Analog_Conversion_v1_1 )
********************************************************************************/
FUNCTION_MAIN( S2_DMPS_String_to_Analog_Conversion_v1_1 )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_DMPS_String_to_Analog_Conversion_v1_1 );
    INITIALIZE_IO_ARRAY ( S2_DMPS_String_to_Analog_Conversion_v1_1, __OUT, IO_TYPE_ANALOG_OUTPUT, __S2_DMPS_String_to_Analog_Conversion_v1_1_OUT_ANALOG_OUTPUT, __S2_DMPS_String_to_Analog_Conversion_v1_1_OUT_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_String_to_Analog_Conversion_v1_1, __IN$, e_INPUT_TYPE_STRING, __S2_DMPS_String_to_Analog_Conversion_v1_1_IN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_String_to_Analog_Conversion_v1_1, __IN$, __S2_DMPS_String_to_Analog_Conversion_v1_1_IN$_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_String_to_Analog_Conversion_v1_1, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_DMPS_String_to_Analog_Conversion_v1_1_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
