#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_DMPS_Analog_To_String_Conversion_v1_1.h"

FUNCTION_MAIN( S2_DMPS_Analog_To_String_Conversion_v1_1 );
EVENT_HANDLER( S2_DMPS_Analog_To_String_Conversion_v1_1 );
DEFINE_ENTRYPOINT( S2_DMPS_Analog_To_String_Conversion_v1_1 );

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Analog_To_String_Conversion_v1_1, 00000 /*Go*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    CREATE_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __NEW$, 240 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __NEW$ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__, 240 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__1, 240 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__2, 240 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__2 );
    
    CREATE_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__3, 240 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__3 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __NEW$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __NEW$, 240 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 240 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 240 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 240 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Analog_To_String_Conversion_v1_1, __FN_DST_STR__3 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__3, 240 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), 79 );
    FormatString ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) , LOCAL_STRING_STRUCT( __NEW$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), 80 );
    __FN_FOREND_VAL__1 = 80; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), 88 );
        FormatString ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__3 )    ,8 , "%s%s%s%s"  , LOCAL_STRING_STRUCT( __NEW$  )  ,  Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (((GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), &Globals->S2_DMPS_Analog_To_String_Conversion_v1_1.__IN , __I  ) & 65024) >> 9) | 128)) ,  Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , (((GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), &Globals->S2_DMPS_Analog_To_String_Conversion_v1_1.__IN , __I  ) & 508) >> 2) | 128)) ,  Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    , ((GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), &Globals->S2_DMPS_Analog_To_String_Conversion_v1_1.__IN , __I  ) & 3) | 128))  )  ; 
        FormatString ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) , LOCAL_STRING_STRUCT( __NEW$  )   ,2 , "%s"  , __FN_DST_STR__3 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), 80 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), 91 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Analog_To_String_Conversion_v1_1 )  ,2 , "%s"  , LOCAL_STRING_STRUCT( __NEW$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ), __S2_DMPS_Analog_To_String_Conversion_v1_1_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Analog_To_String_Conversion_v1_1 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); }
    
    ; 
    
    S2_DMPS_Analog_To_String_Conversion_v1_1_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __NEW$ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__3 );
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
        case __S2_DMPS_Analog_To_String_Conversion_v1_1_GO_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Analog_To_String_Conversion_v1_1, 00000 /*Go*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_Analog_To_String_Conversion_v1_1 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_Analog_To_String_Conversion_v1_1 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Analog_To_String_Conversion_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_DMPS_Analog_To_String_Conversion_v1_1 )
********************************************************************************/
EVENT_HANDLER( S2_DMPS_Analog_To_String_Conversion_v1_1 )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Analog_To_String_Conversion_v1_1, __IN ) ;
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
  FUNCTION_MAIN( S2_DMPS_Analog_To_String_Conversion_v1_1 )
********************************************************************************/
FUNCTION_MAIN( S2_DMPS_Analog_To_String_Conversion_v1_1 )
{
    SAVE_GLOBAL_POINTERS ;
    
    SET_INSTANCE_POINTER ( S2_DMPS_Analog_To_String_Conversion_v1_1 );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Analog_To_String_Conversion_v1_1, __IN, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Analog_To_String_Conversion_v1_1_IN_ANALOG_INPUT, __S2_DMPS_Analog_To_String_Conversion_v1_1_IN_ARRAY_LENGTH );
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_Analog_To_String_Conversion_v1_1, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    S2_DMPS_Analog_To_String_Conversion_v1_1_Exit__MAIN:
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
