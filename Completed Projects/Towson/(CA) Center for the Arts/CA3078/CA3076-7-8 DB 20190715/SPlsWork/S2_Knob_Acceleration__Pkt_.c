#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Knob_Acceleration__Pkt_.h"

FUNCTION_MAIN( S2_Knob_Acceleration__Pkt_ );
EVENT_HANDLER( S2_Knob_Acceleration__Pkt_ );
DEFINE_ENTRYPOINT( S2_Knob_Acceleration__Pkt_ );

static unsigned short S2_Knob_Acceleration__Pkt___CHECKVALUE ( long __VALUE ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __FN_DSTINTRET_VAL__; 
    unsigned short  __NEWVALUE; 
    long  __MAXANALOG; 
    
    
    /* End local function variable declarations */
    
    __FN_DSTINTRET_VAL__ = 0;
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 35 );
    __MAXANALOG = 65535; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 37 );
    Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 22, "ENTER CheckValue:%ld\r\n", (long )( __VALUE )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 39 );
    if ( (__VALUE > __MAXANALOG)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 40 );
        __NEWVALUE = 65535; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 41 );
        if ( (__VALUE < 0)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 42 );
            __NEWVALUE = 0; 
            }
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 44 );
            __NEWVALUE = LowWord( __VALUE ); 
            }
        
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 46 );
    Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 21, "EXIT CheckValue:%ld\r\n", (long )( __NEWVALUE )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 48 );
    __FN_DSTINTRET_VAL__ = ( __NEWVALUE) ;
    goto S2_Knob_Acceleration__Pkt__Exit__CHECKVALUE ; 
    
    S2_Knob_Acceleration__Pkt__Exit__CHECKVALUE:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 51 );
    return __FN_DSTINTRET_VAL__; 
    }
    
static void S2_Knob_Acceleration__Pkt___COMPUTENEWKNOBVALUE ( short __DIRECTION , unsigned short __TIMEDIFFERENCE ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    unsigned short  __NEWVAL; 
    long  __COMPUTEDVALUE; 
    unsigned short  __READBACK; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 58 );
    __FN_FOREND_VAL__1 = Globals->S2_Knob_Acceleration__Pkt_.__G_INUMBERINPUTS; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 60 );
        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__DIZONEENABLE , __I  ) == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 62 );
            __READBACK = GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AIKNOBIN , __I  ); 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 63 );
            if ( (__TIMEDIFFERENCE <= GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIFASTTURNHSEC_ANALOG_INPUT ))) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 66 );
                __COMPUTEDVALUE = (__READBACK + (__DIRECTION * GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIFASTTURNINCR_ANALOG_INPUT ))); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 67 );
                __NEWVAL = S2_Knob_Acceleration__Pkt___CHECKVALUE( __COMPUTEDVALUE ); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 69 );
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 70 );
                Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 16, "	Readback = %u\r\n", (unsigned short )( __READBACK )) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 71 );
                Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 77, "FAST[%d]TimeDifference: %lu, aiKnobIn[i]: %ld, aoKnobOut[i]@: %ld, inc: %ld\r\n", (short)( __I ), (unsigned long )( __TIMEDIFFERENCE ), (long )( GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AIKNOBIN , __I  ) ), (long )( GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AOKNOBOUT , __I  ) ), (long )( (__DIRECTION * GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIFASTTURNINCR_ANALOG_INPUT )) )) ; 
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 74 );
                if ( ((__TIMEDIFFERENCE > GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIFASTTURNHSEC_ANALOG_INPUT )) && (__TIMEDIFFERENCE < GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AISLOWTURNHSEC_ANALOG_INPUT )))) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 76 );
                    __COMPUTEDVALUE = (__READBACK + (__DIRECTION * ((Globals->S2_Knob_Acceleration__Pkt_.__G_SLISLOPE * __TIMEDIFFERENCE) + Globals->S2_Knob_Acceleration__Pkt_.__G_SLIINTERCEPT))); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 77 );
                    __NEWVAL = S2_Knob_Acceleration__Pkt___CHECKVALUE( __COMPUTEDVALUE ); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 79 );
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 80 );
                    Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 16, "	Readback = %u\r\n", (unsigned short )( __READBACK )) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 81 );
                    Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 78, "SCALE[%d]TimeDifference: %lu, aiKnobIn[i]: %ld, aoKnobOut[i]@: %ld, inc: %ld\r\n", (short)( __I ), (unsigned long )( __TIMEDIFFERENCE ), (long )( GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AIKNOBIN , __I  ) ), (long )( GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AOKNOBOUT , __I  ) ), (long )( (__DIRECTION * ((Globals->S2_Knob_Acceleration__Pkt_.__G_SLISLOPE * __TIMEDIFFERENCE) + Globals->S2_Knob_Acceleration__Pkt_.__G_SLIINTERCEPT)) )) ; 
                    } 
                
                else 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 86 );
                    __COMPUTEDVALUE = (__READBACK + (__DIRECTION * GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AISLOWTURNINCR_ANALOG_INPUT ))); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 87 );
                    __NEWVAL = S2_Knob_Acceleration__Pkt___CHECKVALUE( __COMPUTEDVALUE ); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 89 );
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 90 );
                    Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 16, "	Readback = %u\r\n", (unsigned short )( __READBACK )) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 91 );
                    Print( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , 77, "SLOW[%d]TimeDifference: %lu, aiKnobIn[i]: %ld, aoKnobOut[i]@: %ld, inc: %ld\r\n", (short)( __I ), (unsigned long )( __TIMEDIFFERENCE ), (long )( GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AIKNOBIN , __I  ) ), (long )( GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AOKNOBOUT , __I  ) ), (long )( (__DIRECTION * GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AISLOWTURNINCR_ANALOG_INPUT )) )) ; 
                    } 
                
                }
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 95 );
            if ( (__NEWVAL != GetInOutArrayElement( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AOKNOBOUT , __I  ))) 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 96 );
                SetOutputArrayElement ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), &Globals->S2_Knob_Acceleration__Pkt_.__AOKNOBOUT ,__I, __NEWVAL) ; 
                }
            
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 58 );
        } 
    
    
    S2_Knob_Acceleration__Pkt__Exit__COMPUTENEWKNOBVALUE:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_Knob_Acceleration__Pkt_, 00000 /*trig*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __TEMP, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __TEMP );
    
    CREATE_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "*" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __TEMP );
    INITIALIZE_LOCAL_STRING_STRUCT( __TEMP, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "*" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 106 );
    if ( (Globals->S2_Knob_Acceleration__Pkt_.__G_IBUSY == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 108 );
        Globals->S2_Knob_Acceleration__Pkt_.__G_IBUSY = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 109 );
        while ( 1) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 111 );
            FormatString ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , GatherToDelimiter ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , GLOBAL_STRING_STRUCT( S2_Knob_Acceleration__Pkt_, __TRIG  )    , -1  )  )  ; 
            FormatString ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , LOCAL_STRING_STRUCT( __TEMP  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 121 );
            S2_Knob_Acceleration__Pkt___COMPUTENEWKNOBVALUE ( GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIPKTDELTA_ANALOG_INPUT ), GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIPKTTIME_ANALOG_INPUT )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 109 );
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 128 );
        Globals->S2_Knob_Acceleration__Pkt_.__G_IBUSY = 0; 
        } 
    
    
    S2_Knob_Acceleration__Pkt__Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __TEMP );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Knob_Acceleration__Pkt_ ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_Knob_Acceleration__Pkt__TRIG_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Knob_Acceleration__Pkt_, 00000 /*trig*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Knob_Acceleration__Pkt_ ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Knob_Acceleration__Pkt_ )
********************************************************************************/
EVENT_HANDLER( S2_Knob_Acceleration__Pkt_ )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_Knob_Acceleration__Pkt_, __DIZONEENABLE ) ;
    CHECK_INPUT_ARRAY ( S2_Knob_Acceleration__Pkt_, __AIKNOBIN ) ;
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
  FUNCTION_MAIN( S2_Knob_Acceleration__Pkt_ )
********************************************************************************/
FUNCTION_MAIN( S2_Knob_Acceleration__Pkt_ )
{
    /* Begin local function variable declarations */
    
    long  __RISE; 
    long  __RUN; 
    unsigned short  __MAXKNOBIN; 
    unsigned short  __MAXKNOBOUT; 
    unsigned short  __MAXENABLE; 
    unsigned short  __NFLAG; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    short __FN_FOREND_VAL__2; 
    short __FN_FORINIT_VAL__2; 
    short __FN_FOREND_VAL__3; 
    short __FN_FORINIT_VAL__3; 
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Knob_Acceleration__Pkt_ );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_Knob_Acceleration__Pkt_, __DIZONEENABLE, IO_TYPE_DIGITAL_INPUT, __S2_Knob_Acceleration__Pkt__DIZONEENABLE_DIG_INPUT, __S2_Knob_Acceleration__Pkt__DIZONEENABLE_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_Knob_Acceleration__Pkt_, __AIKNOBIN, IO_TYPE_ANALOG_INPUT, __S2_Knob_Acceleration__Pkt__AIKNOBIN_ANALOG_INPUT, __S2_Knob_Acceleration__Pkt__AIKNOBIN_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_Knob_Acceleration__Pkt_, __AOKNOBOUT, IO_TYPE_ANALOG_OUTPUT, __S2_Knob_Acceleration__Pkt__AOKNOBOUT_ANALOG_OUTPUT, __S2_Knob_Acceleration__Pkt__AOKNOBOUT_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Knob_Acceleration__Pkt_, __TRIG, e_INPUT_TYPE_STRING, __S2_Knob_Acceleration__Pkt__TRIG_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Knob_Acceleration__Pkt_, __TRIG, __S2_Knob_Acceleration__Pkt__TRIG_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Knob_Acceleration__Pkt_, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 141 );
    Globals->S2_Knob_Acceleration__Pkt_.__G_IBUSY = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 143 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 145 );
    __RISE = (GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIFASTTURNINCR_ANALOG_INPUT ) - GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AISLOWTURNINCR_ANALOG_INPUT )); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 146 );
    __RUN = (GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AIFASTTURNHSEC_ANALOG_INPUT ) - GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AISLOWTURNHSEC_ANALOG_INPUT )); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 148 );
    __NFLAG = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 149 );
    if ( (__RISE < 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 151 );
        __RISE = -( __RISE ); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 152 );
        __NFLAG = 1; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 154 );
    if ( (__RUN < 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 156 );
        __RUN = -( __RUN ); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 157 );
        if ( (__NFLAG == 1)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 158 );
            __NFLAG = 0; 
            }
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 160 );
            __NFLAG = 1; 
            }
        
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 163 );
    Globals->S2_Knob_Acceleration__Pkt_.__G_SLISLOPE = DO_DIVIDE(INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __RISE, __RUN); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 164 );
    if ( (__NFLAG == 1)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 165 );
        Globals->S2_Knob_Acceleration__Pkt_.__G_SLISLOPE = -( Globals->S2_Knob_Acceleration__Pkt_.__G_SLISLOPE ); 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 169 );
    Globals->S2_Knob_Acceleration__Pkt_.__G_SLIINTERCEPT = (GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AISLOWTURNINCR_ANALOG_INPUT ) - (Globals->S2_Knob_Acceleration__Pkt_.__G_SLISLOPE * GetAnalogInput( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), __S2_Knob_Acceleration__Pkt__AISLOWTURNHSEC_ANALOG_INPUT ))); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 171 );
    __FN_FOREND_VAL__1 = 1; 
    __FN_FORINIT_VAL__1 = -( 1 ); 
    for( __MAXKNOBIN = 24; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__MAXKNOBIN  <= __FN_FOREND_VAL__1 ) : ((short)__MAXKNOBIN  >= __FN_FOREND_VAL__1) ; __MAXKNOBIN  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 173 );
        if ( IsAnalogInputDefined(INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , __S2_Knob_Acceleration__Pkt__AIKNOBIN_ANALOG_INPUT - 1 + __MAXKNOBIN  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 175 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 171 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 179 );
    __FN_FOREND_VAL__2 = 1; 
    __FN_FORINIT_VAL__2 = -( 1 ); 
    for( __MAXKNOBOUT = 24; (__FN_FORINIT_VAL__2 > 0)  ? ((short)__MAXKNOBOUT  <= __FN_FOREND_VAL__2 ) : ((short)__MAXKNOBOUT  >= __FN_FOREND_VAL__2) ; __MAXKNOBOUT  += __FN_FORINIT_VAL__2) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 181 );
        if ( IsAnalogOutputDefined(INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , __S2_Knob_Acceleration__Pkt__AOKNOBOUT_ANALOG_OUTPUT - 1 + __MAXKNOBOUT  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 183 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 179 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 187 );
    __FN_FOREND_VAL__3 = 1; 
    __FN_FORINIT_VAL__3 = -( 1 ); 
    for( __MAXENABLE = 24; (__FN_FORINIT_VAL__3 > 0)  ? ((short)__MAXENABLE  <= __FN_FOREND_VAL__3 ) : ((short)__MAXENABLE  >= __FN_FOREND_VAL__3) ; __MAXENABLE  += __FN_FORINIT_VAL__3) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 189 );
        if ( IsDigitalInputDefined(INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ) , __S2_Knob_Acceleration__Pkt__DIZONEENABLE_DIG_INPUT - 1 + __MAXENABLE  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 191 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 187 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Knob_Acceleration__Pkt_ ), 195 );
    Globals->S2_Knob_Acceleration__Pkt_.__G_INUMBERINPUTS = Min( Min( __MAXKNOBIN , __MAXKNOBOUT ) , __MAXENABLE ); 
    
    S2_Knob_Acceleration__Pkt__Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
