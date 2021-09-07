#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_IP_Address_Edit_Acceleration.h"

FUNCTION_MAIN( S2_IP_Address_Edit_Acceleration );
EVENT_HANDLER( S2_IP_Address_Edit_Acceleration );
DEFINE_ENTRYPOINT( S2_IP_Address_Edit_Acceleration );


static unsigned short S2_IP_Address_Edit_Acceleration__CHECKVALUE ( long __VALUE ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __FN_DSTINTRET_VAL__; 
    unsigned short  __NEWVALUE; 
    long  __MAXANALOG; 
    
    
    /* End local function variable declarations */
    
    __FN_DSTINTRET_VAL__ = 0;
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 40 );
    __MAXANALOG = 65535; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 43 );
    if ( (__VALUE > __MAXANALOG)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 44 );
        __NEWVALUE = 0; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 45 );
        if ( (__VALUE < 0)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 46 );
            __NEWVALUE = 65535; 
            }
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 48 );
            __NEWVALUE = LowWord( __VALUE ); 
            }
        
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 59 );
    __FN_DSTINTRET_VAL__ = ( __NEWVALUE) ;
    goto S2_IP_Address_Edit_Acceleration_Exit__CHECKVALUE ; 
    
    S2_IP_Address_Edit_Acceleration_Exit__CHECKVALUE:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 62 );
    return __FN_DSTINTRET_VAL__; 
    }
    
static void S2_IP_Address_Edit_Acceleration__COMPUTENEWKNOBVALUE ( short __DIRECTION , unsigned short __TIMEDIFFERENCE ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    unsigned short  __NEWVAL; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 67 );
    __FN_FOREND_VAL__1 = Globals->S2_IP_Address_Edit_Acceleration.__G_INUMBERINPUTS; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 69 );
        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), &Globals->S2_IP_Address_Edit_Acceleration.__DIZONEENABLE , __I  ) == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 71 );
            if ( (__TIMEDIFFERENCE <= GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AIFASTTURNHSEC_ANALOG_INPUT ))) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 73 );
                __NEWVAL = S2_IP_Address_Edit_Acceleration__CHECKVALUE( (GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), &Globals->S2_IP_Address_Edit_Acceleration.__AIKNOBIN , __I  ) + (__DIRECTION * GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AIFASTTURNINCR_ANALOG_INPUT ))) ); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 74 );
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 78 );
                if ( ((__TIMEDIFFERENCE > GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AIFASTTURNHSEC_ANALOG_INPUT )) && (__TIMEDIFFERENCE < GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AISLOWTURNHSEC_ANALOG_INPUT )))) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 80 );
                    __NEWVAL = S2_IP_Address_Edit_Acceleration__CHECKVALUE( (GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), &Globals->S2_IP_Address_Edit_Acceleration.__AIKNOBIN , __I  ) + (__DIRECTION * ((Globals->S2_IP_Address_Edit_Acceleration.__G_SLISLOPE * __TIMEDIFFERENCE) + Globals->S2_IP_Address_Edit_Acceleration.__G_SLIINTERCEPT))) ); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 81 );
                    } 
                
                else 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 87 );
                    __NEWVAL = S2_IP_Address_Edit_Acceleration__CHECKVALUE( (GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), &Globals->S2_IP_Address_Edit_Acceleration.__AIKNOBIN , __I  ) + (__DIRECTION * GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AISLOWTURNINCR_ANALOG_INPUT ))) ); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 88 );
                    } 
                
                }
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 93 );
            if ( (__NEWVAL != GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), &Globals->S2_IP_Address_Edit_Acceleration.__AOKNOBOUT , __I  ))) 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 94 );
                SetOutputArrayElement ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), &Globals->S2_IP_Address_Edit_Acceleration.__AOKNOBOUT ,__I, __NEWVAL) ; 
                }
            
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 67 );
        } 
    
    
    S2_IP_Address_Edit_Acceleration_Exit__COMPUTENEWKNOBVALUE:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_IP_Address_Edit_Acceleration, 00000 /*trig*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __TEMP, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __TEMP );
    
    CREATE_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "*" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __TEMP );
    INITIALIZE_LOCAL_STRING_STRUCT( __TEMP, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "*" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 152 );
    if ( (Globals->S2_IP_Address_Edit_Acceleration.__G_IBUSY == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 154 );
        Globals->S2_IP_Address_Edit_Acceleration.__G_IBUSY = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 155 );
        while ( 1) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 157 );
            FormatString ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , GatherToDelimiter ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , GLOBAL_STRING_STRUCT( S2_IP_Address_Edit_Acceleration, __TRIG  )    , -1  )  )  ; 
            FormatString ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) , LOCAL_STRING_STRUCT( __TEMP  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 167 );
            S2_IP_Address_Edit_Acceleration__COMPUTENEWKNOBVALUE ( GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AIPKTDELTA_ANALOG_INPUT ), GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AIPKTTIME_ANALOG_INPUT )) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 155 );
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 174 );
        Globals->S2_IP_Address_Edit_Acceleration.__G_IBUSY = 0; 
        } 
    
    
    S2_IP_Address_Edit_Acceleration_Exit__Event_0:
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_IP_Address_Edit_Acceleration ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_IP_Address_Edit_Acceleration_TRIG_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_IP_Address_Edit_Acceleration, 00000 /*trig*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_IP_Address_Edit_Acceleration ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_IP_Address_Edit_Acceleration )
********************************************************************************/
EVENT_HANDLER( S2_IP_Address_Edit_Acceleration )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_IP_Address_Edit_Acceleration, __DIZONEENABLE ) ;
    CHECK_INPUT_ARRAY ( S2_IP_Address_Edit_Acceleration, __AIKNOBIN ) ;
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
  FUNCTION_MAIN( S2_IP_Address_Edit_Acceleration )
********************************************************************************/
FUNCTION_MAIN( S2_IP_Address_Edit_Acceleration )
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
    SET_INSTANCE_POINTER ( S2_IP_Address_Edit_Acceleration );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_IP_Address_Edit_Acceleration, __DIZONEENABLE, IO_TYPE_DIGITAL_INPUT, __S2_IP_Address_Edit_Acceleration_DIZONEENABLE_DIG_INPUT, __S2_IP_Address_Edit_Acceleration_DIZONEENABLE_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_IP_Address_Edit_Acceleration, __AIKNOBIN, IO_TYPE_ANALOG_INPUT, __S2_IP_Address_Edit_Acceleration_AIKNOBIN_ANALOG_INPUT, __S2_IP_Address_Edit_Acceleration_AIKNOBIN_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_IP_Address_Edit_Acceleration, __AOKNOBOUT, IO_TYPE_ANALOG_OUTPUT, __S2_IP_Address_Edit_Acceleration_AOKNOBOUT_ANALOG_OUTPUT, __S2_IP_Address_Edit_Acceleration_AOKNOBOUT_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_IP_Address_Edit_Acceleration, __TRIG, e_INPUT_TYPE_STRING, __S2_IP_Address_Edit_Acceleration_TRIG_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_IP_Address_Edit_Acceleration, __TRIG, __S2_IP_Address_Edit_Acceleration_TRIG_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_IP_Address_Edit_Acceleration, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    INITIALIZE_GLOBAL_INTARRAY ( S2_IP_Address_Edit_Acceleration, __G_IKNOBIN, 0, 4 );
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 187 );
    Globals->S2_IP_Address_Edit_Acceleration.__G_IBUSY = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 189 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 191 );
    __RISE = (GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AIFASTTURNINCR_ANALOG_INPUT ) - GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AISLOWTURNINCR_ANALOG_INPUT )); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 192 );
    __RUN = (GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AIFASTTURNHSEC_ANALOG_INPUT ) - GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AISLOWTURNHSEC_ANALOG_INPUT )); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 194 );
    __NFLAG = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 195 );
    if ( (__RISE < 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 197 );
        __RISE = -( __RISE ); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 198 );
        __NFLAG = 1; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 200 );
    if ( (__RUN < 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 202 );
        __RUN = -( __RUN ); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 203 );
        if ( (__NFLAG == 1)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 204 );
            __NFLAG = 0; 
            }
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 206 );
            __NFLAG = 1; 
            }
        
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 209 );
    Globals->S2_IP_Address_Edit_Acceleration.__G_SLISLOPE = DO_DIVIDE(INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __RISE, __RUN); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 210 );
    if ( (__NFLAG == 1)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 211 );
        Globals->S2_IP_Address_Edit_Acceleration.__G_SLISLOPE = -( Globals->S2_IP_Address_Edit_Acceleration.__G_SLISLOPE ); 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 215 );
    Globals->S2_IP_Address_Edit_Acceleration.__G_SLIINTERCEPT = (GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AISLOWTURNINCR_ANALOG_INPUT ) - (Globals->S2_IP_Address_Edit_Acceleration.__G_SLISLOPE * GetAnalogInput( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), __S2_IP_Address_Edit_Acceleration_AISLOWTURNHSEC_ANALOG_INPUT ))); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 217 );
    __FN_FOREND_VAL__1 = 1; 
    __FN_FORINIT_VAL__1 = -( 1 ); 
    for( __MAXKNOBIN = 4; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__MAXKNOBIN  <= __FN_FOREND_VAL__1 ) : ((short)__MAXKNOBIN  >= __FN_FOREND_VAL__1) ; __MAXKNOBIN  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 219 );
        if ( IsAnalogInputDefined(INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) , __S2_IP_Address_Edit_Acceleration_AIKNOBIN_ANALOG_INPUT - 1 + __MAXKNOBIN  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 221 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 217 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 225 );
    __FN_FOREND_VAL__2 = 1; 
    __FN_FORINIT_VAL__2 = -( 1 ); 
    for( __MAXKNOBOUT = 4; (__FN_FORINIT_VAL__2 > 0)  ? ((short)__MAXKNOBOUT  <= __FN_FOREND_VAL__2 ) : ((short)__MAXKNOBOUT  >= __FN_FOREND_VAL__2) ; __MAXKNOBOUT  += __FN_FORINIT_VAL__2) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 227 );
        if ( IsAnalogOutputDefined(INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) , __S2_IP_Address_Edit_Acceleration_AOKNOBOUT_ANALOG_OUTPUT - 1 + __MAXKNOBOUT  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 229 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 225 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 233 );
    __FN_FOREND_VAL__3 = 1; 
    __FN_FORINIT_VAL__3 = -( 1 ); 
    for( __MAXENABLE = 4; (__FN_FORINIT_VAL__3 > 0)  ? ((short)__MAXENABLE  <= __FN_FOREND_VAL__3 ) : ((short)__MAXENABLE  >= __FN_FOREND_VAL__3) ; __MAXENABLE  += __FN_FORINIT_VAL__3) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 235 );
        if ( IsDigitalInputDefined(INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ) , __S2_IP_Address_Edit_Acceleration_DIZONEENABLE_DIG_INPUT - 1 + __MAXENABLE  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 237 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 233 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_Acceleration ), 241 );
    Globals->S2_IP_Address_Edit_Acceleration.__G_INUMBERINPUTS = Min( Min( __MAXKNOBIN , __MAXKNOBOUT ) , __MAXENABLE ); 
    
    S2_IP_Address_Edit_Acceleration_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
