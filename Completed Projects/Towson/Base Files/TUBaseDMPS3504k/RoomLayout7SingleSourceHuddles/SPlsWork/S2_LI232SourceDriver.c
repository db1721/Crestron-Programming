#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_LI232SourceDriver.h"

FUNCTION_MAIN( S2_LI232SourceDriver );
EVENT_HANDLER( S2_LI232SourceDriver );
DEFINE_ENTRYPOINT( S2_LI232SourceDriver );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_LI232SourceDriver, 00000 /*SystemOnPress*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_LI232SourceDriver ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 21 );
    SetOutputArray( INSTANCE_PTR( S2_LI232SourceDriver ) , &Globals->S2_LI232SourceDriver.__SOURCEPRESSED , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 22 );
    SetOutputArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ), &Globals->S2_LI232SourceDriver.__SOURCEPRESSED ,Globals->S2_LI232SourceDriver.__X, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 23 );
    Globals->S2_LI232SourceDriver.__ISOURCE = 2; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 24 );
    SetOutputArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ), &Globals->S2_LI232SourceDriver.__MONITORVAL ,1, GET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, Globals->S2_LI232SourceDriver.__ISOURCE  )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 25 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_LI232SourceDriver ) , GENERIC_STRING_OUTPUT( S2_LI232SourceDriver )  ,2 , "%s"  , GetStringArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ),  GLOBAL_STRING_ARRAY( S2_LI232SourceDriver, __SOURCENAME  )    ,  Globals->S2_LI232SourceDriver.__ISOURCE  )  )  ; 
    SET_STRING_OUT_ARRAY_ELEMENT( S2_LI232SourceDriver, __MONITORSOURCE , 1 ) ; 
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 26 );
    SetAnalog ( INSTANCE_PTR( S2_LI232SourceDriver ), __S2_LI232SourceDriver_MASTERSWVALUE_ANALOG_OUTPUT, GET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, Globals->S2_LI232SourceDriver.__ISOURCE  )) ; 
    
    S2_LI232SourceDriver_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_LI232SourceDriver, 00001 /*SourcePress*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_LI232SourceDriver ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 30 );
    Globals->S2_LI232SourceDriver.__X = GetLocalLastModifiedArrayIndex ( S2_LI232SourceDriver ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 31 );
    SetOutputArray( INSTANCE_PTR( S2_LI232SourceDriver ) , &Globals->S2_LI232SourceDriver.__SOURCEPRESSED , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 32 );
    SetOutputArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ), &Globals->S2_LI232SourceDriver.__SOURCEPRESSED ,Globals->S2_LI232SourceDriver.__X, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 33 );
    Globals->S2_LI232SourceDriver.__ISOURCE = Globals->S2_LI232SourceDriver.__X; 
    
    S2_LI232SourceDriver_Exit__Event_1:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_LI232SourceDriver, 00002 /*MonitorPress*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_LI232SourceDriver ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 37 );
    Globals->S2_LI232SourceDriver.__X = GetLocalLastModifiedArrayIndex ( S2_LI232SourceDriver ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 38 );
    SetOutputArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ), &Globals->S2_LI232SourceDriver.__MONITORVAL ,Globals->S2_LI232SourceDriver.__X, GET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, Globals->S2_LI232SourceDriver.__ISOURCE  )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 39 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_LI232SourceDriver ) , GENERIC_STRING_OUTPUT( S2_LI232SourceDriver )  ,2 , "%s"  , GetStringArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ),  GLOBAL_STRING_ARRAY( S2_LI232SourceDriver, __SOURCENAME  )    ,  Globals->S2_LI232SourceDriver.__ISOURCE  )  )  ; 
    SET_STRING_OUT_ARRAY_ELEMENT( S2_LI232SourceDriver, __MONITORSOURCE , Globals->S2_LI232SourceDriver.__X ) ; 
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 40 );
    SetAnalog ( INSTANCE_PTR( S2_LI232SourceDriver ), __S2_LI232SourceDriver_MASTERSWVALUE_ANALOG_OUTPUT, GET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, Globals->S2_LI232SourceDriver.__ISOURCE  )) ; 
    
    S2_LI232SourceDriver_Exit__Event_2:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_LI232SourceDriver, 00003 /*SetAll*/ )

    {
    /* Begin local function variable declarations */
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_LI232SourceDriver ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 74 );
    __FN_FOREND_VAL__1 = 8; 
    __FN_FORINIT_VAL__1 = 1; 
    for( Globals->S2_LI232SourceDriver.__ILOOP = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)Globals->S2_LI232SourceDriver.__ILOOP  <= __FN_FOREND_VAL__1 ) : ((short)Globals->S2_LI232SourceDriver.__ILOOP  >= __FN_FOREND_VAL__1) ; Globals->S2_LI232SourceDriver.__ILOOP  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 76 );
        SetOutputArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ), &Globals->S2_LI232SourceDriver.__MONITORVAL ,Globals->S2_LI232SourceDriver.__ILOOP, GET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, Globals->S2_LI232SourceDriver.__ISOURCE  )) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 77 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_LI232SourceDriver ) , GENERIC_STRING_OUTPUT( S2_LI232SourceDriver )  ,2 , "%s"  , GetStringArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ),  GLOBAL_STRING_ARRAY( S2_LI232SourceDriver, __SOURCENAME  )    ,  Globals->S2_LI232SourceDriver.__ISOURCE  )  )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_LI232SourceDriver, __MONITORSOURCE , Globals->S2_LI232SourceDriver.__ILOOP ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 74 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 79 );
    SetAnalog ( INSTANCE_PTR( S2_LI232SourceDriver ), __S2_LI232SourceDriver_MASTERSWVALUE_ANALOG_OUTPUT, GET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, Globals->S2_LI232SourceDriver.__ISOURCE  )) ; 
    
    S2_LI232SourceDriver_Exit__Event_3:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_LI232SourceDriver, 00004 /*ClearAll*/ )

    {
    /* Begin local function variable declarations */
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_LI232SourceDriver, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "Off" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_LI232SourceDriver, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_LI232SourceDriver ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_LI232SourceDriver, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "Off" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 84 );
    __FN_FOREND_VAL__1 = 8; 
    __FN_FORINIT_VAL__1 = 1; 
    for( Globals->S2_LI232SourceDriver.__ILOOP = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)Globals->S2_LI232SourceDriver.__ILOOP  <= __FN_FOREND_VAL__1 ) : ((short)Globals->S2_LI232SourceDriver.__ILOOP  >= __FN_FOREND_VAL__1) ; Globals->S2_LI232SourceDriver.__ILOOP  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 86 );
        SetOutputArrayElement ( INSTANCE_PTR( S2_LI232SourceDriver ), &Globals->S2_LI232SourceDriver.__MONITORVAL ,Globals->S2_LI232SourceDriver.__ILOOP, 0) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 87 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_LI232SourceDriver ) , GENERIC_STRING_OUTPUT( S2_LI232SourceDriver )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_LI232SourceDriver, __MONITORSOURCE , Globals->S2_LI232SourceDriver.__ILOOP ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_LI232SourceDriver ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 84 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 89 );
    SetAnalog ( INSTANCE_PTR( S2_LI232SourceDriver ), __S2_LI232SourceDriver_MASTERSWVALUE_ANALOG_OUTPUT, 0) ; 
    
    S2_LI232SourceDriver_Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
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
        case __S2_LI232SourceDriver_SETALL_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_LI232SourceDriver, 00003 /*SetAll*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
                
            }
            break;
            
        case __S2_LI232SourceDriver_CLEARALL_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_LI232SourceDriver, 00004 /*ClearAll*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
                
            }
            break;
            
        case __S2_LI232SourceDriver_SYSTEMONPRESS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_LI232SourceDriver, 00000 /*SystemOnPress*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
                
            }
            break;
            
        case __S2_LI232SourceDriver_MONITORPRESS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_LI232SourceDriver, 00002 /*MonitorPress*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
                
            }
            break;
            
        case __S2_LI232SourceDriver_SOURCEPRESS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_LI232SourceDriver, 00001 /*SourcePress*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_LI232SourceDriver ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_LI232SourceDriver ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_LI232SourceDriver ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_LI232SourceDriver )
********************************************************************************/
EVENT_HANDLER( S2_LI232SourceDriver )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_LI232SourceDriver, __MONITORPRESS ) ;
    CHECK_INPUT_ARRAY ( S2_LI232SourceDriver, __SOURCEPRESS ) ;
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
  FUNCTION_MAIN( S2_LI232SourceDriver )
********************************************************************************/
FUNCTION_MAIN( S2_LI232SourceDriver )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_LI232SourceDriver );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_LI232SourceDriver, __MONITORPRESS, IO_TYPE_DIGITAL_INPUT, __S2_LI232SourceDriver_MONITORPRESS_DIG_INPUT, __S2_LI232SourceDriver_MONITORPRESS_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_LI232SourceDriver, __SOURCEPRESS, IO_TYPE_DIGITAL_INPUT, __S2_LI232SourceDriver_SOURCEPRESS_DIG_INPUT, __S2_LI232SourceDriver_SOURCEPRESS_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_LI232SourceDriver, __SOURCEPRESSED, IO_TYPE_DIGITAL_OUTPUT, __S2_LI232SourceDriver_SOURCEPRESSED_DIG_OUTPUT, __S2_LI232SourceDriver_SOURCEPRESSED_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_LI232SourceDriver, __MONITORVAL, IO_TYPE_ANALOG_OUTPUT, __S2_LI232SourceDriver_MONITORVAL_ANALOG_OUTPUT, __S2_LI232SourceDriver_MONITORVAL_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_LI232SourceDriver, __MONITORSOURCE, IO_TYPE_STRING_OUTPUT, __S2_LI232SourceDriver_MONITORSOURCE_STRING_OUTPUT, __S2_LI232SourceDriver_MONITORSOURCE_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_PARAMETER_ARRAY( S2_LI232SourceDriver, __SOURCENAME, e_INPUT_TYPE_STRING_PARAMETER, __S2_LI232SourceDriver_SOURCENAME_ARRAY_NUM_ELEMS, __S2_LI232SourceDriver_SOURCENAME_ARRAY_NUM_CHARS, __S2_LI232SourceDriver_SOURCENAME_STRING_PARAMETER );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_LI232SourceDriver, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    INITIALIZE_GLOBAL_INTARRAY ( S2_LI232SourceDriver, __ISOURCEIN, 0, 14 );
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 94 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 1 , 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 95 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 2 , 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 96 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 3 , 2) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 97 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 4 , 3) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 98 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 5 , 4) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 99 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 6 , 5) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 100 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 7 , 6) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 101 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 8 , 7) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 102 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 9 , 8) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 103 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 10 , 9) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 104 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 11 , 10) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 105 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 12 , 11) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 106 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 13 , 12) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_LI232SourceDriver ), 107 );
    SET_GLOBAL_INTARRAY_VALUE( S2_LI232SourceDriver, __ISOURCEIN, 0, 14 , 13) ; 
    
    S2_LI232SourceDriver_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
