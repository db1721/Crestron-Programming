#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_IP_Address_Edit_with_Up_Down.h"

FUNCTION_MAIN( S2_IP_Address_Edit_with_Up_Down );
EVENT_HANDLER( S2_IP_Address_Edit_with_Up_Down );
DEFINE_ENTRYPOINT( S2_IP_Address_Edit_with_Up_Down );


static void S2_IP_Address_Edit_with_Up_Down__KNOBVALUEUP ( ) 
    { 
    /* Begin local function variable declarations */
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 108 );
    __FN_FOREND_VAL__1 = Globals->S2_IP_Address_Edit_with_Up_Down.__G_INUMBERINPUTS; 
    __FN_FORINIT_VAL__1 = 1; 
    for( Globals->S2_IP_Address_Edit_with_Up_Down.__I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)Globals->S2_IP_Address_Edit_with_Up_Down.__I  <= __FN_FOREND_VAL__1 ) : ((short)Globals->S2_IP_Address_Edit_with_Up_Down.__I  >= __FN_FOREND_VAL__1) ; Globals->S2_IP_Address_Edit_with_Up_Down.__I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 110 );
        SET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I , GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), &Globals->S2_IP_Address_Edit_with_Up_Down.__AIKNOBIN , Globals->S2_IP_Address_Edit_with_Up_Down.__I  )) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 111 );
        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), &Globals->S2_IP_Address_Edit_with_Up_Down.__DIZONEENABLE , Globals->S2_IP_Address_Edit_with_Up_Down.__I  ) == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 113 );
            if ( (GET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I  ) < 255)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 115 );
                SET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I , (GET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I  ) + 1)) ; 
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 118 );
                SET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I , 0) ; 
                }
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 119 );
            SetOutputArrayElement ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), &Globals->S2_IP_Address_Edit_with_Up_Down.__AOKNOBOUT ,Globals->S2_IP_Address_Edit_with_Up_Down.__I, GET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I  )) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 108 );
        } 
    
    
    S2_IP_Address_Edit_with_Up_Down_Exit__KNOBVALUEUP:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
static void S2_IP_Address_Edit_with_Up_Down__KNOBVALUEDOWN ( ) 
    { 
    /* Begin local function variable declarations */
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 126 );
    __FN_FOREND_VAL__1 = Globals->S2_IP_Address_Edit_with_Up_Down.__G_INUMBERINPUTS; 
    __FN_FORINIT_VAL__1 = 1; 
    for( Globals->S2_IP_Address_Edit_with_Up_Down.__I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)Globals->S2_IP_Address_Edit_with_Up_Down.__I  <= __FN_FOREND_VAL__1 ) : ((short)Globals->S2_IP_Address_Edit_with_Up_Down.__I  >= __FN_FOREND_VAL__1) ; Globals->S2_IP_Address_Edit_with_Up_Down.__I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 128 );
        SET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I , GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), &Globals->S2_IP_Address_Edit_with_Up_Down.__AIKNOBIN , Globals->S2_IP_Address_Edit_with_Up_Down.__I  )) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 129 );
        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), &Globals->S2_IP_Address_Edit_with_Up_Down.__DIZONEENABLE , Globals->S2_IP_Address_Edit_with_Up_Down.__I  ) == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 131 );
            if ( (GET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I  ) > 0)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 133 );
                SET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I , (GET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I  ) - 1)) ; 
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 136 );
                SET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I , 255) ; 
                }
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 137 );
            SetOutputArrayElement ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), &Globals->S2_IP_Address_Edit_with_Up_Down.__AOKNOBOUT ,Globals->S2_IP_Address_Edit_with_Up_Down.__I, GET_GLOBAL_INTARRAY_VALUE( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, Globals->S2_IP_Address_Edit_with_Up_Down.__I  )) ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 126 );
        } 
    
    
    S2_IP_Address_Edit_with_Up_Down_Exit__KNOBVALUEDOWN:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_IP_Address_Edit_with_Up_Down, 00000 /*diUp*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 144 );
    S2_IP_Address_Edit_with_Up_Down__KNOBVALUEUP ( ) ; 
    
    S2_IP_Address_Edit_with_Up_Down_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_IP_Address_Edit_with_Up_Down, 00001 /*diDown*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 149 );
    S2_IP_Address_Edit_with_Up_Down__KNOBVALUEDOWN ( ) ; 
    
    S2_IP_Address_Edit_with_Up_Down_Exit__Event_1:
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
        case __S2_IP_Address_Edit_with_Up_Down_DIUP_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_IP_Address_Edit_with_Up_Down, 00000 /*diUp*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
                
            }
            break;
            
        case __S2_IP_Address_Edit_with_Up_Down_DIDOWN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_IP_Address_Edit_with_Up_Down, 00001 /*diDown*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_IP_Address_Edit_with_Up_Down ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_IP_Address_Edit_with_Up_Down ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_IP_Address_Edit_with_Up_Down )
********************************************************************************/
EVENT_HANDLER( S2_IP_Address_Edit_with_Up_Down )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_IP_Address_Edit_with_Up_Down, __DIZONEENABLE ) ;
    CHECK_INPUT_ARRAY ( S2_IP_Address_Edit_with_Up_Down, __AIKNOBIN ) ;
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
  FUNCTION_MAIN( S2_IP_Address_Edit_with_Up_Down )
********************************************************************************/
FUNCTION_MAIN( S2_IP_Address_Edit_with_Up_Down )
{
    /* Begin local function variable declarations */
    
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
    SET_INSTANCE_POINTER ( S2_IP_Address_Edit_with_Up_Down );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_IP_Address_Edit_with_Up_Down, __DIZONEENABLE, IO_TYPE_DIGITAL_INPUT, __S2_IP_Address_Edit_with_Up_Down_DIZONEENABLE_DIG_INPUT, __S2_IP_Address_Edit_with_Up_Down_DIZONEENABLE_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_IP_Address_Edit_with_Up_Down, __AIKNOBIN, IO_TYPE_ANALOG_INPUT, __S2_IP_Address_Edit_with_Up_Down_AIKNOBIN_ANALOG_INPUT, __S2_IP_Address_Edit_with_Up_Down_AIKNOBIN_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_IP_Address_Edit_with_Up_Down, __AOKNOBOUT, IO_TYPE_ANALOG_OUTPUT, __S2_IP_Address_Edit_with_Up_Down_AOKNOBOUT_ANALOG_OUTPUT, __S2_IP_Address_Edit_with_Up_Down_AOKNOBOUT_ARRAY_LENGTH );
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_IP_Address_Edit_with_Up_Down, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    INITIALIZE_GLOBAL_INTARRAY ( S2_IP_Address_Edit_with_Up_Down, __G_IKNOBIN, 0, 4 );
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 193 );
    Globals->S2_IP_Address_Edit_with_Up_Down.__G_IBUSY = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 195 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 223 );
    __FN_FOREND_VAL__1 = 1; 
    __FN_FORINIT_VAL__1 = -( 1 ); 
    for( __MAXKNOBIN = 4; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__MAXKNOBIN  <= __FN_FOREND_VAL__1 ) : ((short)__MAXKNOBIN  >= __FN_FOREND_VAL__1) ; __MAXKNOBIN  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 225 );
        if ( IsAnalogInputDefined(INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) , __S2_IP_Address_Edit_with_Up_Down_AIKNOBIN_ANALOG_INPUT - 1 + __MAXKNOBIN  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 227 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 223 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 231 );
    __FN_FOREND_VAL__2 = 1; 
    __FN_FORINIT_VAL__2 = -( 1 ); 
    for( __MAXKNOBOUT = 4; (__FN_FORINIT_VAL__2 > 0)  ? ((short)__MAXKNOBOUT  <= __FN_FOREND_VAL__2 ) : ((short)__MAXKNOBOUT  >= __FN_FOREND_VAL__2) ; __MAXKNOBOUT  += __FN_FORINIT_VAL__2) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 233 );
        if ( IsAnalogOutputDefined(INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) , __S2_IP_Address_Edit_with_Up_Down_AOKNOBOUT_ANALOG_OUTPUT - 1 + __MAXKNOBOUT  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 235 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 231 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 239 );
    __FN_FOREND_VAL__3 = 1; 
    __FN_FORINIT_VAL__3 = -( 1 ); 
    for( __MAXENABLE = 4; (__FN_FORINIT_VAL__3 > 0)  ? ((short)__MAXENABLE  <= __FN_FOREND_VAL__3 ) : ((short)__MAXENABLE  >= __FN_FOREND_VAL__3) ; __MAXENABLE  += __FN_FORINIT_VAL__3) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 241 );
        if ( IsDigitalInputDefined(INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ) , __S2_IP_Address_Edit_with_Up_Down_DIZONEENABLE_DIG_INPUT - 1 + __MAXENABLE  )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 243 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 239 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_IP_Address_Edit_with_Up_Down ), 247 );
    Globals->S2_IP_Address_Edit_with_Up_Down.__G_INUMBERINPUTS = Min( Min( __MAXKNOBIN , __MAXKNOBOUT ) , __MAXENABLE ); 
    
    S2_IP_Address_Edit_with_Up_Down_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
