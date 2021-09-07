#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Panasonic_PT_EZ370RU_Processor.h"

FUNCTION_MAIN( S2_Panasonic_PT_EZ370RU_Processor );
EVENT_HANDLER( S2_Panasonic_PT_EZ370RU_Processor );
DEFINE_ENTRYPOINT( S2_Panasonic_PT_EZ370RU_Processor );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_Panasonic_PT_EZ370RU_Processor, 00000 /*From_Device*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __LAMP_HOURS$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __LAMP_HOURS$ );
    
    CREATE_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x02""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FN_DST_STR__, 255 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FN_DST_STR__1, 255 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __LAMP_HOURS$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __LAMP_HOURS$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x02""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 255 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 255 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ), 78 );
    if ( GetDigitalInput( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ), __S2_Panasonic_PT_EZ370RU_Processor_LAMP_REQUESTED_DIG_INPUT )) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ), 80 );
        if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FROM_DEVICE  )  , 1 , 1 )) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ), 81 );
            FormatString ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FROM_DEVICE  )  , 2, 5)  )  ; 
            FormatString ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) , LOCAL_STRING_STRUCT( __LAMP_HOURS$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
            }
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ), 82 );
        SetAnalog ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ), __S2_Panasonic_PT_EZ370RU_Processor_LAMP_HOURS_ANALOG_OUTPUT, Atoi( LOCAL_STRING_STRUCT( __LAMP_HOURS$  )  )) ; 
        } 
    
    
    S2_Panasonic_PT_EZ370RU_Processor_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __LAMP_HOURS$ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Panasonic_PT_EZ370RU_Processor ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_Panasonic_PT_EZ370RU_Processor_FROM_DEVICE_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Panasonic_PT_EZ370RU_Processor, 00000 /*From_Device*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Panasonic_PT_EZ370RU_Processor ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Panasonic_PT_EZ370RU_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Panasonic_PT_EZ370RU_Processor )
********************************************************************************/
EVENT_HANDLER( S2_Panasonic_PT_EZ370RU_Processor )
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
  FUNCTION_MAIN( S2_Panasonic_PT_EZ370RU_Processor )
********************************************************************************/
FUNCTION_MAIN( S2_Panasonic_PT_EZ370RU_Processor )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Panasonic_PT_EZ370RU_Processor );
    
    
    /* End local function variable declarations */
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Panasonic_PT_EZ370RU_Processor, __FROM_DEVICE, e_INPUT_TYPE_STRING, __S2_Panasonic_PT_EZ370RU_Processor_FROM_DEVICE_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Panasonic_PT_EZ370RU_Processor, __FROM_DEVICE, __S2_Panasonic_PT_EZ370RU_Processor_FROM_DEVICE_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Panasonic_PT_EZ370RU_Processor, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    
    S2_Panasonic_PT_EZ370RU_Processor_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
