#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Extron_AV_Router.h"

FUNCTION_MAIN( S2_Extron_AV_Router );
EVENT_HANDLER( S2_Extron_AV_Router );
DEFINE_ENTRYPOINT( S2_Extron_AV_Router );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_Extron_AV_Router, 00000 /*InDecimal*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Extron_AV_Router, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "*" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Extron_AV_Router, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "!" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_Extron_AV_Router, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Extron_AV_Router, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Extron_AV_Router ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "*" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "!" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Extron_AV_Router, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Extron_AV_Router ), 101 );
    if ( (GetIntegerParameter( INSTANCE_PTR( S2_Extron_AV_Router ), __S2_Extron_AV_Router_OUTPUT_INTEGER_PARAMETER )  > 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Extron_AV_Router ), 103 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Extron_AV_Router ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Extron_AV_Router ) , GENERIC_STRING_OUTPUT( S2_Extron_AV_Router )  ,8 , "%s%s%s%s"  , Itoa ( INSTANCE_PTR( S2_Extron_AV_Router ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GetAnalogInput( INSTANCE_PTR( S2_Extron_AV_Router ), __S2_Extron_AV_Router_INDECIMAL_ANALOG_INPUT )) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   ,  Itoa ( INSTANCE_PTR( S2_Extron_AV_Router ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GetIntegerParameter( INSTANCE_PTR( S2_Extron_AV_Router ), __S2_Extron_AV_Router_OUTPUT_INTEGER_PARAMETER ) ) ,  GLOBAL_STRING_STRUCT( S2_Extron_AV_Router, __ROUTETYPE  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_Extron_AV_Router ), __S2_Extron_AV_Router_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Extron_AV_Router ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Extron_AV_Router ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Extron_AV_Router ), 107 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Extron_AV_Router ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Extron_AV_Router ) , GENERIC_STRING_OUTPUT( S2_Extron_AV_Router )  ,4 , "%s%s"  , Itoa ( INSTANCE_PTR( S2_Extron_AV_Router ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GetAnalogInput( INSTANCE_PTR( S2_Extron_AV_Router ), __S2_Extron_AV_Router_INDECIMAL_ANALOG_INPUT )) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
        SetSerial( INSTANCE_PTR( S2_Extron_AV_Router ), __S2_Extron_AV_Router_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Extron_AV_Router ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Extron_AV_Router ) ); }
        
        ; 
        } 
    
    
    S2_Extron_AV_Router_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Extron_AV_Router ) ); 
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
        case __S2_Extron_AV_Router_INDECIMAL_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Extron_AV_Router, 00000 /*InDecimal*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Extron_AV_Router ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Extron_AV_Router ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Extron_AV_Router ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Extron_AV_Router ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Extron_AV_Router ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Extron_AV_Router ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Extron_AV_Router ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Extron_AV_Router ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Extron_AV_Router )
********************************************************************************/
EVENT_HANDLER( S2_Extron_AV_Router )
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
  FUNCTION_MAIN( S2_Extron_AV_Router )
********************************************************************************/
FUNCTION_MAIN( S2_Extron_AV_Router )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_Extron_AV_Router );
    
    
    InitStringParamStruct ( INSTANCE_PTR( S2_Extron_AV_Router ), GLOBAL_STRING_STRUCT( S2_Extron_AV_Router, __ROUTETYPE ) , e_INPUT_TYPE_STRING_PARAMETER, __S2_Extron_AV_Router_ROUTETYPE_STRING_PARAMETER, __S2_Extron_AV_Router_ROUTETYPE_PARAM_MAX_LEN, NAME_AS_STRING( __ROUTETYPE ) );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Extron_AV_Router, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_Extron_AV_Router_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
