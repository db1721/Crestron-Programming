#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_UserProgCmd_Interface_v1_0.h"

FUNCTION_MAIN( S2_UserProgCmd_Interface_v1_0 );
EVENT_HANDLER( S2_UserProgCmd_Interface_v1_0 );
DEFINE_ENTRYPOINT( S2_UserProgCmd_Interface_v1_0 );


static unsigned short S2_UserProgCmd_Interface_v1_0__FINDTAG$ ( struct StringHdr_s* __LOOKUP$ ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __FN_DSTINTRET_VAL__; 
    unsigned short  __FOUND; 
    unsigned short  __I; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CheckStack( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    __FN_DSTINTRET_VAL__ = 0;
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 67 );
    __FOUND = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 68 );
    __FN_FOREND_VAL__1 = 100; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 70 );
        if ( (CompareStrings( LOCAL_STRING_STRUCT( __LOOKUP$  ) , GetStringArrayElement ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), GLOBAL_STRING_ARRAY( S2_UserProgCmd_Interface_v1_0, __TAGLIST$  )  ,  __I  ), 1 ) == 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 72 );
            __FOUND = __I; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 73 );
            break ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 68 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 76 );
    __FN_DSTINTRET_VAL__ = ( __FOUND) ;
    goto S2_UserProgCmd_Interface_v1_0_Exit__FINDTAG$ ; 
    
    S2_UserProgCmd_Interface_v1_0_Exit__FINDTAG$:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 79 );
    return __FN_DSTINTRET_VAL__; 
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_UserProgCmd_Interface_v1_0, 00000 /*In$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __MARKER; 
    unsigned short  __MARKER2; 
    unsigned short  __INDEX; 
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __TAG$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __TAG$ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __COMMAND$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __COMMAND$ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "pgmver" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "getparamvalue" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_3__, sizeof( "setparamvalue" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_4__, sizeof( "toolparamaccess" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_4__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_5__, sizeof( "start" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_5__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_6__, sizeof( "stop" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_6__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __FN_DST_STR__, 255 );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __FN_DST_STR__1, 255 );
    DECLARE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __TAG$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __TAG$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __COMMAND$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __COMMAND$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "pgmver" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "getparamvalue" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__, "setparamvalue" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_4__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__, "toolparamaccess" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_5__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__, "start" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __SPLS_TMPVAR__LOCALSTR_6__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__, "stop" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 255 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 255 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 87 );
    if ( (CompareStrings( GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  ) , LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ ) , 1 ) == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 89 );
        switch( GetAnalogInput( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), __S2_UserProgCmd_Interface_v1_0_SYSTEMTYPE_ANALOG_INPUT )) 
        
            { 
            case ( 0 ) : 
            
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 93 );
                Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 14, "Unknown [%s]\r\n", GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __VERSION$  )  ) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 94 );
                break ; 
                } 
            
            case ( 1 ) : 
            
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 98 );
                Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 12, "OOTBF [%s]\r\n", GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __VERSION$  )  ) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 99 );
                break ; 
                } 
            
            case ( 2 ) : 
            
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 103 );
                Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 21, "System Builder [%s]\r\n", GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __VERSION$  )  ) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 104 );
                break ; 
                } 
            
            case ( 3 ) : 
            
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 108 );
                Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 13, "Custom [%s]\r\n", GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __VERSION$  )  ) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 109 );
                break ; 
                } 
            
            } 
            
        
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 115 );
        __MARKER = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )  , GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  , 1 , 1 ); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 116 );
        if ( (__MARKER > 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 118 );
            FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Left ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  , (__MARKER - 1))  )  ; 
            FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , LOCAL_STRING_STRUCT( __COMMAND$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 119 );
            FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Lower ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , LOCAL_STRING_STRUCT( __COMMAND$  )  )  )  ; 
            FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , LOCAL_STRING_STRUCT( __COMMAND$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 120 );
            if ( (CompareStrings( LOCAL_STRING_STRUCT( __COMMAND$  ) , LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ ) , 1 ) == 0)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 122 );
                FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Right ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  , (Len( GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  ) - __MARKER))  )  ; 
                FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , LOCAL_STRING_STRUCT( __TAG$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 123 );
                __INDEX = S2_UserProgCmd_Interface_v1_0__FINDTAG$((struct StringHdr_s* ) LOCAL_STRING_STRUCT( __TAG$  )  ); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 124 );
                if ( (__INDEX > 0)) 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 125 );
                    Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 7, "%s %s\r\n", LOCAL_STRING_STRUCT( __TAG$  )  , GetStringArrayElement ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ),  GLOBAL_STRING_ARRAY( S2_UserProgCmd_Interface_v1_0, __VALUELISTIN$  )    ,  __INDEX  ) ) ; 
                    }
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 127 );
                    Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 21, "ERROR: Unknown tag.\r\n") ; 
                    }
                
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 129 );
                if ( (CompareStrings( LOCAL_STRING_STRUCT( __COMMAND$  ) , LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ ) , 1 ) == 0)) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 131 );
                    __MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )  , GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  , (__MARKER + 1) , 1 ); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 132 );
                    FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  , (__MARKER + 1), ((__MARKER2 - __MARKER) - 1))  )  ; 
                    FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , LOCAL_STRING_STRUCT( __TAG$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 133 );
                    __INDEX = S2_UserProgCmd_Interface_v1_0__FINDTAG$((struct StringHdr_s* ) LOCAL_STRING_STRUCT( __TAG$  )  ); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 134 );
                    if ( (__INDEX > 0)) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 136 );
                        Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 4, "Ok\r\n") ; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 137 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , GENERIC_STRING_OUTPUT( S2_UserProgCmd_Interface_v1_0 )  ,2 , "%s"  , Right ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  , (Len( GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  ) - __MARKER2))  )  ; 
                        SET_STRING_OUT_ARRAY_ELEMENT( S2_UserProgCmd_Interface_v1_0, __VALUELISTOUT$ , __INDEX ) ; 
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); }
                        
                        ; 
                        } 
                    
                    else 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 140 );
                        Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 21, "ERROR: Unknown tag.\r\n") ; 
                        }
                    
                    } 
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 142 );
                    if ( (CompareStrings( LOCAL_STRING_STRUCT( __COMMAND$  ) , LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__ ) , 1 ) == 0)) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 144 );
                        FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Right ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  , (Len( GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __IN$  )  ) - __MARKER))  )  ; 
                        FormatString ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , LOCAL_STRING_STRUCT( __TAG$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 145 );
                        if ( (CompareStrings( LOCAL_STRING_STRUCT( __TAG$  ) , LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__ ) , 1 ) == 0)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 147 );
                            if ( (GetDigitalInput( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), __S2_UserProgCmd_Interface_v1_0_ACCESSOK_DIG_INPUT ) == 1)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 149 );
                                Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 4, "Ok\r\n") ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 150 );
                                SetDigital ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), __S2_UserProgCmd_Interface_v1_0_TOOLBOXSTARTED_DIG_OUTPUT, 1) ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 151 );
                                SetDigital ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), __S2_UserProgCmd_Interface_v1_0_TOOLBOXSTARTED_DIG_OUTPUT, 0) ; 
                                } 
                            
                            else 
                                {
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 154 );
                                Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 11, "ERROR: %s\r\n", GLOBAL_STRING_STRUCT( S2_UserProgCmd_Interface_v1_0, __ACCESSERRORMSG$  )  ) ; 
                                }
                            
                            } 
                        
                        else 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 156 );
                            if ( (CompareStrings( LOCAL_STRING_STRUCT( __TAG$  ) , LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__ ) , 1 ) == 0)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 158 );
                                Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 4, "Ok\r\n") ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 159 );
                                SetDigital ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), __S2_UserProgCmd_Interface_v1_0_TOOLBOXENDED_DIG_OUTPUT, 1) ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 160 );
                                SetDigital ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), __S2_UserProgCmd_Interface_v1_0_TOOLBOXENDED_DIG_OUTPUT, 0) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    }
                
                }
            
            } 
        
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 165 );
    Print( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) , 4, "PGM>") ; 
    
    S2_UserProgCmd_Interface_v1_0_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __TAG$ );
FREE_LOCAL_STRING_STRUCT( __COMMAND$ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__ );
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_UserProgCmd_Interface_v1_0 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_UserProgCmd_Interface_v1_0_IN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_UserProgCmd_Interface_v1_0, 00000 /*In$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_UserProgCmd_Interface_v1_0 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_UserProgCmd_Interface_v1_0 )
********************************************************************************/
EVENT_HANDLER( S2_UserProgCmd_Interface_v1_0 )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_STRING_INPUT_ARRAY ( S2_UserProgCmd_Interface_v1_0, __TAGLIST$ ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_UserProgCmd_Interface_v1_0, __VALUELISTIN$ ) ;
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
  FUNCTION_MAIN( S2_UserProgCmd_Interface_v1_0 )
********************************************************************************/
FUNCTION_MAIN( S2_UserProgCmd_Interface_v1_0 )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_UserProgCmd_Interface_v1_0 );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_UserProgCmd_Interface_v1_0, __VALUELISTOUT$, IO_TYPE_STRING_OUTPUT, __S2_UserProgCmd_Interface_v1_0_VALUELISTOUT$_STRING_OUTPUT, __S2_UserProgCmd_Interface_v1_0_VALUELISTOUT$_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_UserProgCmd_Interface_v1_0, __VERSION$, e_INPUT_TYPE_STRING, __S2_UserProgCmd_Interface_v1_0_VERSION$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_UserProgCmd_Interface_v1_0, __VERSION$, __S2_UserProgCmd_Interface_v1_0_VERSION$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_UserProgCmd_Interface_v1_0, __ACCESSERRORMSG$, e_INPUT_TYPE_STRING, __S2_UserProgCmd_Interface_v1_0_ACCESSERRORMSG$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_UserProgCmd_Interface_v1_0, __ACCESSERRORMSG$, __S2_UserProgCmd_Interface_v1_0_ACCESSERRORMSG$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_UserProgCmd_Interface_v1_0, __IN$, e_INPUT_TYPE_STRING, __S2_UserProgCmd_Interface_v1_0_IN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_UserProgCmd_Interface_v1_0, __IN$, __S2_UserProgCmd_Interface_v1_0_IN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_UserProgCmd_Interface_v1_0, __TAGLIST$, e_INPUT_TYPE_STRING, __S2_UserProgCmd_Interface_v1_0_TAGLIST$_ARRAY_NUM_ELEMS, __S2_UserProgCmd_Interface_v1_0_TAGLIST$_ARRAY_NUM_CHARS, __S2_UserProgCmd_Interface_v1_0_TAGLIST$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_UserProgCmd_Interface_v1_0, __TAGLIST$ );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_UserProgCmd_Interface_v1_0, __VALUELISTIN$, e_INPUT_TYPE_STRING, __S2_UserProgCmd_Interface_v1_0_VALUELISTIN$_ARRAY_NUM_ELEMS, __S2_UserProgCmd_Interface_v1_0_VALUELISTIN$_ARRAY_NUM_CHARS, __S2_UserProgCmd_Interface_v1_0_VALUELISTIN$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_UserProgCmd_Interface_v1_0, __VALUELISTIN$ );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_UserProgCmd_Interface_v1_0, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ), 170 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_UserProgCmd_Interface_v1_0 ) ) ; 
    
    S2_UserProgCmd_Interface_v1_0_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
