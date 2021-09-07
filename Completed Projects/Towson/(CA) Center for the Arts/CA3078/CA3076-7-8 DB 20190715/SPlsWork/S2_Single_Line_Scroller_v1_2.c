#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Single_Line_Scroller_v1_2.h"

FUNCTION_MAIN( S2_Single_Line_Scroller_v1_2 );
EVENT_HANDLER( S2_Single_Line_Scroller_v1_2 );
DEFINE_ENTRYPOINT( S2_Single_Line_Scroller_v1_2 );


static void S2_Single_Line_Scroller_v1_2__DEBUGPRINT ( struct StringHdr_s* __FOO$ , struct StringHdr_s* __LABEL$ ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    unsigned short  __CHARACTER; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 52 );
    Print( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , 3, "%s:", LOCAL_STRING_STRUCT( __LABEL$  )  ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 53 );
    __FN_FOREND_VAL__1 = Len( LOCAL_STRING_STRUCT( __FOO$  )  ); 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 55 );
        __CHARACTER = Byte( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , LOCAL_STRING_STRUCT( __FOO$  )  , __I ); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 56 );
        if ( ((__CHARACTER >= 33) && (__CHARACTER <= 126))) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 57 );
            Print( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , 2, "%c", (short)( __CHARACTER )) ; 
            }
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 59 );
            Print( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , 6, "[%02X]", __CHARACTER) ; 
            }
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 53 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 61 );
    Print( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , 2, "\r\n") ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__DEBUGPRINT:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
static void S2_Single_Line_Scroller_v1_2__DISPLAYLINE ( ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __LINELENTOEXTRACT; 
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__, 22000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__1, 22000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__1 );
    
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 22000 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 22000 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 68 );
    __LINELENTOEXTRACT = (Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE - Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 70 );
    if ( (__LINELENTOEXTRACT > 130)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 71 );
        __LINELENTOEXTRACT = 130; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 74 );
    if ( (__LINELENTOEXTRACT > 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 76 );
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE, __LINELENTOEXTRACT)  )  ; 
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 77 );
        while ( (Byte( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )  , 1 ) == 32)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 79 );
            FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Right ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )  , (Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )  ) - 1))  )  ; 
            FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 77 );
            } 
        
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 84 );
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 88 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_CURRENTLINELENGTH = Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )  ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 89 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )  , Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION, GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AINUMCHARACTERSONDISPLAY_ANALOG_INPUT ))  )  ; 
    SetSerial( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_SOTODISPLAY$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); }
    
    ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__DISPLAYLINE:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    /* End Free local function variables */
    
    }
    
static void S2_Single_Line_Scroller_v1_2__JUMPTOTOP ( ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __LINELENTOEXTRACT; 
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x0D""\x0A""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x0D""\x0A""" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 97 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 98 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE , 1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 101 );
    if ( (Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE == 0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 102 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE = (Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  ) + 1); 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 104 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATTOP_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 105 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATBOTTOM_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 106 );
    S2_Single_Line_Scroller_v1_2__DISPLAYLINE ( ) ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__JUMPTOTOP:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00000 /*biFromConsole$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __LASTLOC; 
    unsigned short  __FIRSTLOC; 
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( ">" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "REPORTCRESNET\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "No Network Devices Found" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__, 22000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__1, 22000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, ">" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "REPORTCRESNET\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "No Network Devices Found" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 22000 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 22000 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 114 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 115 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 116 );
    FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , GatherToDelimiter ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __BIFROMCONSOLE$  )    , -1  )  )  ; 
    FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 117 );
    __LASTLOC = Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 118 );
    __FIRSTLOC = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 122 );
    while ( ((__LASTLOC > 0) && (Byte( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , __LASTLOC ) >= 32))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 123 );
        __LASTLOC = (__LASTLOC - 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 122 );
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 126 );
    while ( ((__LASTLOC > 0) && (Byte( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , __LASTLOC ) < 32))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 127 );
        __LASTLOC = (__LASTLOC - 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 126 );
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 130 );
    __FIRSTLOC = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 131 );
    while ( ((__FIRSTLOC <= __LASTLOC) && (Byte( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , __FIRSTLOC ) < 32))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 132 );
        __FIRSTLOC = (__FIRSTLOC + 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 131 );
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 135 );
    if ( (__LASTLOC > __FIRSTLOC)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 137 );
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , __FIRSTLOC, ((__LASTLOC - __FIRSTLOC) + 1))  )  ; 
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        } 
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 139 );
        if ( ((__LASTLOC < __FIRSTLOC) && (CompareStrings( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SICONSOLECOMMAND$  ) , LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ ) , 1 ) == 0))) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 141 );
            FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
            FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 142 );
            SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATTOP_DIG_OUTPUT, 1) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 143 );
            SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATBOTTOM_DIG_OUTPUT, 1) ; 
            } 
        
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 147 );
    S2_Single_Line_Scroller_v1_2__JUMPTOTOP ( ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 149 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 150 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED = 1; 
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00001 /*diClearBuff*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "CLEARERR\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "CLEARERR\r\n" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 156 );
    if ( (Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA == 1)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 157 );
        
        goto S2_Single_Line_Scroller_v1_2_Exit__Event_1 ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 159 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 160 );
    ClearBuffer ( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 161 );
    ClearBuffer ( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __BIFROMCONSOLE$  )  ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 163 );
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 164 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_SOTOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); }
    
    ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_1:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00002 /*diScrollUp*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __CBLEN; 
    unsigned short  __LINELENTOEXTRACT; 
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x0D""\x0A""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x0D""\x0A""" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 171 );
    __CBLEN = Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 175 );
    if ( (((Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE == 1) || (Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED == 0)) || (Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA == 1))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 176 );
        
        goto S2_Single_Line_Scroller_v1_2_Exit__Event_2 ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 177 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATTOP_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 178 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATBOTTOM_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 180 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE = ReverseFind( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , (Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE - 1) ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 181 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = ReverseFind( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , (Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE - 1) ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 185 );
    if ( (Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 187 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 188 );
        SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATTOP_DIG_OUTPUT, 1) ; 
        } 
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 192 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = (Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE + 2); 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 194 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 196 );
    S2_Single_Line_Scroller_v1_2__DISPLAYLINE ( ) ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_2:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00003 /*diScrollDn*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __CBLEN; 
    unsigned short  __LINELENTOEXTRACT; 
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x0D""\x0A""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x0D""\x0A""" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 202 );
    __CBLEN = Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 205 );
    if ( ((((Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE >= __CBLEN) || (Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE >= __CBLEN)) || (Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED == 0)) || (Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA == 1))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 206 );
        
        goto S2_Single_Line_Scroller_v1_2_Exit__Event_3 ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 207 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATTOP_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 208 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATBOTTOM_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 210 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = (Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE + 2); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 211 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE , 1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 214 );
    if ( (Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 216 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE = (Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  ) + 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 217 );
        SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATBOTTOM_DIG_OUTPUT, 1) ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 220 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 222 );
    S2_Single_Line_Scroller_v1_2__DISPLAYLINE ( ) ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_3:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00004 /*diScrollLeft*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__, 130 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 130 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 228 );
    if ( ((Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED == 0) || (Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA == 1))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 229 );
        
        goto S2_Single_Line_Scroller_v1_2_Exit__Event_4 ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 231 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = (Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION - GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AISCROLLHORIZONTALBY_ANALOG_INPUT )); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 232 );
    if ( ((short)Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION < (short)0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 233 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = 1; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 235 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )  , Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION, GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AINUMCHARACTERSONDISPLAY_ANALOG_INPUT ))  )  ; 
    SetSerial( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_SOTODISPLAY$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); }
    
    ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00005 /*diScrollRight*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__, 130 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 130 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 241 );
    if ( ((Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED == 0) || (Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA == 1))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 242 );
        
        goto S2_Single_Line_Scroller_v1_2_Exit__Event_5 ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 244 );
    if ( (Globals->S2_Single_Line_Scroller_v1_2.__G_CURRENTLINELENGTH > GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AINUMCHARACTERSONDISPLAY_ANALOG_INPUT ))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 246 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = (Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION + GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AISCROLLHORIZONTALBY_ANALOG_INPUT )); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 247 );
        if ( ((Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION + GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AINUMCHARACTERSONDISPLAY_ANALOG_INPUT )) > Globals->S2_Single_Line_Scroller_v1_2.__G_CURRENTLINELENGTH)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 248 );
            Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = ((Globals->S2_Single_Line_Scroller_v1_2.__G_CURRENTLINELENGTH - GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AINUMCHARACTERSONDISPLAY_ANALOG_INPUT )) + 1); 
            }
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 250 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$  )  , Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION, GetAnalogInput( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_AINUMCHARACTERSONDISPLAY_ANALOG_INPUT ))  )  ; 
        SetSerial( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_SOTODISPLAY$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Single_Line_Scroller_v1_2 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); }
        
        ; 
        } 
    
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_5:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00006 /*diJumpToTop*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 257 );
    if ( ((Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED == 0) || (Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA == 1))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 258 );
        
        goto S2_Single_Line_Scroller_v1_2_Exit__Event_6 ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 260 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 262 );
    S2_Single_Line_Scroller_v1_2__JUMPTOTOP ( ) ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_6:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00007 /*diJumpToBottom*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x0D""\x0A""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x0D""\x0A""" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 268 );
    if ( ((Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED == 0) || (Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA == 1))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 269 );
        
        goto S2_Single_Line_Scroller_v1_2_Exit__Event_7 ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 271 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE = Len( GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 272 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = ReverseFind( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$  )  , Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 274 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE = (Globals->S2_Single_Line_Scroller_v1_2.__G_LASTCHARINLINE + 1); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 275 );
    if ( (Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE == 0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 276 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = 1; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 278 );
        Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE = (Globals->S2_Single_Line_Scroller_v1_2.__G_FIRSTCHARINLINE + 2); 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 280 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 281 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATTOP_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 282 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATBOTTOM_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 283 );
    S2_Single_Line_Scroller_v1_2__DISPLAYLINE ( ) ; 
    
    S2_Single_Line_Scroller_v1_2_Exit__Event_7:
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
        case __S2_Single_Line_Scroller_v1_2_DICLEARBUFF_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00001 /*diClearBuff*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
                
            }
            break;
            
        case __S2_Single_Line_Scroller_v1_2_DISCROLLUP_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00002 /*diScrollUp*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
                
            }
            break;
            
        case __S2_Single_Line_Scroller_v1_2_DISCROLLDN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00003 /*diScrollDn*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
                
            }
            break;
            
        case __S2_Single_Line_Scroller_v1_2_DISCROLLLEFT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00004 /*diScrollLeft*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
                
            }
            break;
            
        case __S2_Single_Line_Scroller_v1_2_DISCROLLRIGHT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00005 /*diScrollRight*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
                
            }
            break;
            
        case __S2_Single_Line_Scroller_v1_2_DIJUMPTOTOP_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00006 /*diJumpToTop*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
                
            }
            break;
            
        case __S2_Single_Line_Scroller_v1_2_DIJUMPTOBOTTOM_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00007 /*diJumpToBottom*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Single_Line_Scroller_v1_2 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_Single_Line_Scroller_v1_2_BIFROMCONSOLE$_BUFFER_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Single_Line_Scroller_v1_2, 00000 /*biFromConsole$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Single_Line_Scroller_v1_2 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Single_Line_Scroller_v1_2 )
********************************************************************************/
EVENT_HANDLER( S2_Single_Line_Scroller_v1_2 )
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
  FUNCTION_MAIN( S2_Single_Line_Scroller_v1_2 )
********************************************************************************/
FUNCTION_MAIN( S2_Single_Line_Scroller_v1_2 )
{
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR___M, 130 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR___M );
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Single_Line_Scroller_v1_2 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __FN_DST_STR___M );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR___M, 130 );
    
    
    /* End local function variable declarations */
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Single_Line_Scroller_v1_2, __SICONSOLECOMMAND$, e_INPUT_TYPE_STRING, __S2_Single_Line_Scroller_v1_2_SICONSOLECOMMAND$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Single_Line_Scroller_v1_2, __SICONSOLECOMMAND$, __S2_Single_Line_Scroller_v1_2_SICONSOLECOMMAND$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Single_Line_Scroller_v1_2, __BIFROMCONSOLE$, e_INPUT_TYPE_BUFFER, __S2_Single_Line_Scroller_v1_2_BIFROMCONSOLE$_BUFFER_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Single_Line_Scroller_v1_2, __BIFROMCONSOLE$, __S2_Single_Line_Scroller_v1_2_BIFROMCONSOLE$_BUFFER_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Single_Line_Scroller_v1_2, __G_CURRENTLINE$, e_INPUT_TYPE_NONE, __S2_Single_Line_Scroller_v1_2_G_CURRENTLINE$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Single_Line_Scroller_v1_2, __G_BLANKS$, e_INPUT_TYPE_NONE, __S2_Single_Line_Scroller_v1_2_G_BLANKS$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Single_Line_Scroller_v1_2, __G_CONSOLEBUFFERCOPY$, e_INPUT_TYPE_NONE, __S2_Single_Line_Scroller_v1_2_G_CONSOLEBUFFERCOPY$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Single_Line_Scroller_v1_2, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    REGISTER_GLOBAL_INPUT_STRING ( S2_Single_Line_Scroller_v1_2, __BIFROMCONSOLE$, __S2_Single_Line_Scroller_v1_2_BIFROMCONSOLE$_BUFFER_INPUT );
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 290 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_BUSYGETTINGDATA = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 291 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_DATAINITIALIZED = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 292 );
    Globals->S2_Single_Line_Scroller_v1_2.__G_SCROLLSTARTPOSITION = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 293 );
    FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_BLANKS$  )   ,2 , "%s"  , __FN_DST_STR___M ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 294 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATTOP_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 295 );
    SetDigital ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), __S2_Single_Line_Scroller_v1_2_ATBOTTOM_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 296 );
    __FN_FOREND_VAL__1 = 130; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 297 );
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M )    ,4 , "%s%s"  , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_BLANKS$  )  ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
        FormatString ( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ) , GLOBAL_STRING_STRUCT( S2_Single_Line_Scroller_v1_2, __G_BLANKS$  )   ,2 , "%s"  , __FN_DST_STR___M ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Single_Line_Scroller_v1_2 ), 296 );
        }
    
    
    S2_Single_Line_Scroller_v1_2_Exit__MAIN:/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR___M );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
