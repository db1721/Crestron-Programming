#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_MPS_Text_Centering.h"

FUNCTION_MAIN( S2_MPS_Text_Centering );
EVENT_HANDLER( S2_MPS_Text_Centering );
DEFINE_ENTRYPOINT( S2_MPS_Text_Centering );


static struct StringHdr_s* S2_MPS_Text_Centering__CENTER ( struct StringHdr_s*  __FN_DSTRET_STR__  , struct StringHdr_s* __INPUT$ ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __OFFSET; 
    unsigned short  __I; 
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __OFFSET$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __OFFSET$ );
    
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __TEMP$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __TEMP$ );
    
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__, 65535 );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__1, 65535 );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__1 );
    
    CheckStack( INSTANCE_PTR( S2_MPS_Text_Centering ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __OFFSET$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __OFFSET$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __TEMP$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __TEMP$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 65535 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 65535 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 61 );
    FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) , LOCAL_STRING_STRUCT( __OFFSET$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 62 );
    if ( (Len( LOCAL_STRING_STRUCT( __INPUT$  )  ) < 20)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 64 );
        __OFFSET = DO_DIVIDE(INSTANCE_PTR( S2_MPS_Text_Centering ), (20 - Len( LOCAL_STRING_STRUCT( __INPUT$  )  )), 2); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 65 );
        if ( (__OFFSET > 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 67 );
            __FN_FOREND_VAL__1 = __OFFSET; 
            __FN_FORINIT_VAL__1 = 1; 
            for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 69 );
                FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,4 , "%s%s"  , LOCAL_STRING_STRUCT( __OFFSET$  )  ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) , LOCAL_STRING_STRUCT( __OFFSET$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 67 );
                } 
            
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 72 );
        FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,4 , "%s%s"  , LOCAL_STRING_STRUCT( __OFFSET$  )  ,  LOCAL_STRING_STRUCT( __INPUT$  )   )  ; 
        FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) , LOCAL_STRING_STRUCT( __TEMP$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 76 );
        FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Left ( INSTANCE_PTR( S2_MPS_Text_Centering ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , LOCAL_STRING_STRUCT( __INPUT$  )  , 20)  )  ; 
        FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) , LOCAL_STRING_STRUCT( __TEMP$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 78 );
    FormatString( INSTANCE_PTR( S2_MPS_Text_Centering ),  __FN_DSTRET_STR__, 2, "%s", ( LOCAL_STRING_STRUCT( __TEMP$  )  ) );
    goto S2_MPS_Text_Centering_Exit__CENTER ; 
    
    S2_MPS_Text_Centering_Exit__CENTER:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __OFFSET$ );
    FREE_LOCAL_STRING_STRUCT( __TEMP$ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
    /* End Free local function variables */
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 81 );
    return __FN_DSTRET_STR__; 
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_MPS_Text_Centering, 00000 /*SerialIn$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __INDEX; 
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __TEMPIN$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __TEMPIN$ );
    
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_MPS_Text_Centering ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __TEMPIN$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __TEMPIN$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 86 );
    __INDEX = GetLocalLastModifiedArrayIndex ( S2_MPS_Text_Centering ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 87 );
    FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , GetStringArrayElement ( INSTANCE_PTR( S2_MPS_Text_Centering ),  GLOBAL_STRING_ARRAY( S2_MPS_Text_Centering, __SERIALIN$  )    ,  __INDEX  )  )  ; 
    FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) , LOCAL_STRING_STRUCT( __TEMPIN$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 88 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_MPS_Text_Centering ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) , GENERIC_STRING_OUTPUT( S2_MPS_Text_Centering )  ,2 , "%s"  , S2_MPS_Text_Centering__CENTER (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  (struct StringHdr_s* )  LOCAL_STRING_STRUCT( __TEMPIN$  )  )  )  ; 
    SET_STRING_OUT_ARRAY_ELEMENT( S2_MPS_Text_Centering, __SERIALOUT$ , __INDEX ) ; 
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_MPS_Text_Centering ) ); }
    
    ; 
    
    S2_MPS_Text_Centering_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __TEMPIN$ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_MPS_Text_Centering ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_MPS_Text_Centering ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_MPS_Text_Centering ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_MPS_Text_Centering_SERIALIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_MPS_Text_Centering, 00000 /*SerialIn$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_MPS_Text_Centering ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_MPS_Text_Centering ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_MPS_Text_Centering ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_MPS_Text_Centering ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_MPS_Text_Centering ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_MPS_Text_Centering ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_MPS_Text_Centering )
********************************************************************************/
EVENT_HANDLER( S2_MPS_Text_Centering )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_STRING_INPUT_ARRAY ( S2_MPS_Text_Centering, __SERIALIN$ ) ;
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
  FUNCTION_MAIN( S2_MPS_Text_Centering )
********************************************************************************/
FUNCTION_MAIN( S2_MPS_Text_Centering )
{
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_MPS_Text_Centering );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_MPS_Text_Centering, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_MPS_Text_Centering, __SERIALOUT$, IO_TYPE_STRING_OUTPUT, __S2_MPS_Text_Centering_SERIALOUT$_STRING_OUTPUT, __S2_MPS_Text_Centering_SERIALOUT$_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_MPS_Text_Centering, __SERIALIN$, e_INPUT_TYPE_STRING, __S2_MPS_Text_Centering_SERIALIN$_ARRAY_NUM_ELEMS, __S2_MPS_Text_Centering_SERIALIN$_ARRAY_NUM_CHARS, __S2_MPS_Text_Centering_SERIALIN$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_MPS_Text_Centering, __SERIALIN$ );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_MPS_Text_Centering, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 95 );
    __FN_FOREND_VAL__1 = 10; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 97 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_MPS_Text_Centering ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_MPS_Text_Centering ) , GENERIC_STRING_OUTPUT( S2_MPS_Text_Centering )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_MPS_Text_Centering, __SERIALOUT$ , __I ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_MPS_Text_Centering ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_MPS_Text_Centering ), 95 );
        } 
    
    
    S2_MPS_Text_Centering_Exit__MAIN:/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
