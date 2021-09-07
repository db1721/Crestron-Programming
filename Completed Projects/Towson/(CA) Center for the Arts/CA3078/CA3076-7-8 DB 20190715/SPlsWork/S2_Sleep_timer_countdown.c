#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Sleep_timer_countdown.h"

FUNCTION_MAIN( S2_Sleep_timer_countdown );
EVENT_HANDLER( S2_Sleep_timer_countdown );
DEFINE_ENTRYPOINT( S2_Sleep_timer_countdown );



static void S2_Sleep_timer_countdown__CANCEL_FUNC ( ) 
    { 
    /* Begin local function variable declarations */
    
    CheckStack( INSTANCE_PTR( S2_Sleep_timer_countdown ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 53 );
    Globals->S2_Sleep_timer_countdown.__TIMER_GOING = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 54 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_30MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 55 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_60MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 56 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_90MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 57 );
    Globals->S2_Sleep_timer_countdown.__X = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 58 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown )  ,15 , "Timer cancelled"  )  ; 
    SetSerial( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_COUNTDOWN$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 60 );
    Delay ( 500) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 61 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown )  ,1 , " "  )  ; 
    SetSerial( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_COUNTDOWN$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); }
    
    ; 
    
    S2_Sleep_timer_countdown_Exit__CANCEL_FUNC:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
static void S2_Sleep_timer_countdown__TIMER_FUNC ( ) 
    { 
    /* Begin local function variable declarations */
    
    CheckStack( INSTANCE_PTR( S2_Sleep_timer_countdown ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 68 );
    while ( ((Globals->S2_Sleep_timer_countdown.__X > 0) && (Globals->S2_Sleep_timer_countdown.__TIMER_GOING == 1))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 70 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown )  ,33 , "Sleep timer has %u minute(s) left"  , (unsigned short )( Globals->S2_Sleep_timer_countdown.__X ) )  ; 
        SetSerial( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_COUNTDOWN$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 71 );
        if ( (Globals->S2_Sleep_timer_countdown.__X == 2)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 73 );
            Pulse ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , 20, __S2_Sleep_timer_countdown_WARNING_DIG_OUTPUT ) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 75 );
        Globals->S2_Sleep_timer_countdown.__X = (Globals->S2_Sleep_timer_countdown.__X - 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 77 );
        Delay ( 6000) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 68 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 80 );
    if ( ((Globals->S2_Sleep_timer_countdown.__X == 0) && (Globals->S2_Sleep_timer_countdown.__TIMER_GOING == 1))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 82 );
        Pulse ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , 20, __S2_Sleep_timer_countdown_TIMER_FINISHED_DIG_OUTPUT ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 83 );
        S2_Sleep_timer_countdown__CANCEL_FUNC ( ) ; 
        } 
    
    
    S2_Sleep_timer_countdown_Exit__TIMER_FUNC:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_Sleep_timer_countdown, 00000 /*cancel*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Sleep_timer_countdown ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 95 );
    S2_Sleep_timer_countdown__CANCEL_FUNC ( ) ; 
    
    S2_Sleep_timer_countdown_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Sleep_timer_countdown, 00001 /*Start_30min*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Sleep_timer_countdown ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 100 );
    Globals->S2_Sleep_timer_countdown.__X = 30; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 101 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_30MIN_FB_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 102 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_60MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 103 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_90MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 104 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown )  ,29 , "Sleep timer reset, %u minutes"  , (unsigned short )( Globals->S2_Sleep_timer_countdown.__X ) )  ; 
    SetSerial( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_COUNTDOWN$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 106 );
    if ( (Globals->S2_Sleep_timer_countdown.__TIMER_GOING == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 108 );
        Globals->S2_Sleep_timer_countdown.__TIMER_GOING = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 109 );
        S2_Sleep_timer_countdown__TIMER_FUNC ( ) ; 
        } 
    
    
    S2_Sleep_timer_countdown_Exit__Event_1:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Sleep_timer_countdown, 00002 /*Start_60min*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Sleep_timer_countdown ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 115 );
    Globals->S2_Sleep_timer_countdown.__X = 60; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 116 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_60MIN_FB_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 117 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_30MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 118 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_90MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 119 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown )  ,29 , "Sleep timer reset, %u minutes"  , (unsigned short )( Globals->S2_Sleep_timer_countdown.__X ) )  ; 
    SetSerial( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_COUNTDOWN$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 121 );
    if ( (Globals->S2_Sleep_timer_countdown.__TIMER_GOING == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 123 );
        Globals->S2_Sleep_timer_countdown.__TIMER_GOING = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 124 );
        S2_Sleep_timer_countdown__TIMER_FUNC ( ) ; 
        } 
    
    
    S2_Sleep_timer_countdown_Exit__Event_2:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Sleep_timer_countdown, 00003 /*Start_90min*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Sleep_timer_countdown ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 130 );
    Globals->S2_Sleep_timer_countdown.__X = 90; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 131 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_90MIN_FB_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 132 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_30MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 133 );
    SetDigital ( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_START_60MIN_FB_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 134 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Sleep_timer_countdown ) , GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown )  ,29 , "Sleep timer reset, %u minutes"  , (unsigned short )( Globals->S2_Sleep_timer_countdown.__X ) )  ; 
    SetSerial( INSTANCE_PTR( S2_Sleep_timer_countdown ), __S2_Sleep_timer_countdown_COUNTDOWN$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Sleep_timer_countdown ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 136 );
    if ( (Globals->S2_Sleep_timer_countdown.__TIMER_GOING == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 138 );
        Globals->S2_Sleep_timer_countdown.__TIMER_GOING = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 139 );
        S2_Sleep_timer_countdown__TIMER_FUNC ( ) ; 
        } 
    
    
    S2_Sleep_timer_countdown_Exit__Event_3:
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
        case __S2_Sleep_timer_countdown_START_30MIN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Sleep_timer_countdown, 00001 /*Start_30min*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
                
            }
            break;
            
        case __S2_Sleep_timer_countdown_START_60MIN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Sleep_timer_countdown, 00002 /*Start_60min*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
                
            }
            break;
            
        case __S2_Sleep_timer_countdown_START_90MIN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Sleep_timer_countdown, 00003 /*Start_90min*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
                
            }
            break;
            
        case __S2_Sleep_timer_countdown_CANCEL_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Sleep_timer_countdown, 00000 /*cancel*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Sleep_timer_countdown ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Sleep_timer_countdown ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Sleep_timer_countdown ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Sleep_timer_countdown )
********************************************************************************/
EVENT_HANDLER( S2_Sleep_timer_countdown )
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
  FUNCTION_MAIN( S2_Sleep_timer_countdown )
********************************************************************************/
FUNCTION_MAIN( S2_Sleep_timer_countdown )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Sleep_timer_countdown );
    
    
    /* End local function variable declarations */
    
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Sleep_timer_countdown, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Sleep_timer_countdown ), 149 );
    S2_Sleep_timer_countdown__CANCEL_FUNC ( ) ; 
    
    S2_Sleep_timer_countdown_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
