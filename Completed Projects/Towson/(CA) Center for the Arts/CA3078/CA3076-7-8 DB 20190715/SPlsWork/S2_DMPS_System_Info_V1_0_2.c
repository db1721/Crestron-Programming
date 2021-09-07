#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_DMPS_System_Info_V1_0_2.h"

FUNCTION_MAIN( S2_DMPS_System_Info_V1_0_2 );
EVENT_HANDLER( S2_DMPS_System_Info_V1_0_2 );
DEFINE_ENTRYPOINT( S2_DMPS_System_Info_V1_0_2 );



DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00000 /*Go*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "None Entered" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "version\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "None Entered" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "version\r\n" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 69 );
    SetDigital ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_BUSY_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 70 );
    Globals->S2_DMPS_System_Info_V1_0_2.__BUSYINT = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 71 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_DNS1$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 72 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_DNS2$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 74 );
    ClearBuffer ( GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$  )  ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 75 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 76 );
    Delay ( 100) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 77 );
    Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 78 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 79 );
    CREATE_WAIT( S2_DMPS_System_Info_V1_0_2, 800, __SPLS_TMPVAR__WAITLABEL_0__ );
    
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_WAITEVENT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__WAITLABEL_0__ )
    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 81 );
    SetDigital ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_ERROR_DIG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 82 );
    SetDigital ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_ERROR_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 83 );
    SetDigital ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_BUSY_DIG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 84 );
    Globals->S2_DMPS_System_Info_V1_0_2.__BUSYINT = 0; 
    

S2_DMPS_System_Info_V1_0_2_Exit____SPLS_TMPVAR__WAITLABEL_0__:
    
    /* Begin Free local function variables */
    /* End Free local function variables */
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00001 /*FromConsole$*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x0D""\x0A""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "Cntrl Eng [" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "]" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_3__, sizeof( "fpipaddress\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_3__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_4__, sizeof( "Device 0 IP address: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_4__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_5__, sizeof( "fpipmask\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_5__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_6__, sizeof( "Device 0 Subnet Mask: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_6__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_7__, sizeof( "fpdefrouter\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_7__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_8__, sizeof( "Default Router: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_8__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_9__, sizeof( "dhcp\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_9__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_10__, sizeof( "Current DHCP State: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_10__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_11__, sizeof( "wins\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_11__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_12__, sizeof( "Current WINS State: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_12__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_13__, sizeof( "hostname\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_13__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_14__, sizeof( "Host Name: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_14__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_15__, sizeof( "domainname\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_15__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_16__, sizeof( "Domain Name: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_16__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_17__, sizeof( "getcode\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_17__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_18__, sizeof( "Activation is :" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_18__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_19__, sizeof( "Time\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_19__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_20__, sizeof( "Current Time/Date: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_20__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_21__, sizeof( "Listdns\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_21__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_22__, sizeof( "\x09""1    " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_22__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_23__, sizeof( "\x09""2    " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_23__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_24__, sizeof( "progcomments\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_24__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_25__, sizeof( "Program File: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_25__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_26__, sizeof( " v" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_26__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_27__, sizeof( ".smw" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_27__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_28__, sizeof( "Compiled On:  " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_28__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FN_DST_STR__, 1600 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FN_DST_STR__1, 1600 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x0D""\x0A""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "Cntrl Eng [" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "]" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_3__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__, "fpipaddress\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_4__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__, "Device 0 IP address: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_5__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__, "fpipmask\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_6__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__, "Device 0 Subnet Mask: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_7__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_7__, "fpdefrouter\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_8__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_8__, "Default Router: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_9__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_9__, "dhcp\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_10__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_10__, "Current DHCP State: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_11__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_11__, "wins\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_12__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_12__, "Current WINS State: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_13__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_13__, "hostname\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_14__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_14__, "Host Name: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_15__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_15__, "domainname\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_16__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_16__, "Domain Name: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_17__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_17__, "getcode\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_18__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_18__, "Activation is :" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_19__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_19__, "Time\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_20__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_20__, "Current Time/Date: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_21__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_21__, "Listdns\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_22__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_22__, "\x09""1    " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_23__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_23__, "\x09""2    " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_24__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_24__, "progcomments\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_25__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_25__, "Program File: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_26__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_26__, " v" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_27__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_27__, ".smw" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __SPLS_TMPVAR__LOCALSTR_28__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_28__, "Compiled On:  " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 1600 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 1600 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 92 );
    if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__SEMAPHORE == 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__BUSYINT == 1))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 94 );
        Globals->S2_DMPS_System_Info_V1_0_2.__SEMAPHORE = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 95 );
        while ( (Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$  )  , 1 , 1 ) > 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 97 );
            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Remove ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$  )    , 1  )  )  ; 
            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 98 );
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ( Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER) ;
                
                    { 
                    if ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 102 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 103 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 11) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 104 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 106 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 11), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 11))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_OPS$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 107 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 2; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 108 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 113 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 114 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 21) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 115 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 117 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 21), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 21))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_IPA$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 118 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 3; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 119 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 124 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 125 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 22) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 126 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 128 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 22), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 22))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_IPM$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 129 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 4; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 130 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_7__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 135 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_8__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 136 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 16) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 137 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 139 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 16), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 16))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_DEFR$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 140 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 5; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 141 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_9__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 146 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_10__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 147 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 20) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 148 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 150 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 20), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 20))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_DHCP$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 151 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 6; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 152 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_11__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 157 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_12__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 158 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 20) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 159 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 161 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 20), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 20))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_WINS$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 162 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 7; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 163 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_13__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 168 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_14__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 169 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 11) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 170 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 172 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 11), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 11))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_HOSTNAME$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 173 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 8; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 174 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_15__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 179 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_16__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 180 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 13) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 181 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 183 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 13), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 13))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_DOMAINNAME$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 184 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 9; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 185 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_17__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 190 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_18__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 191 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 15) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 192 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 194 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 15), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 15))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_MAC$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 195 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 10; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 196 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNT = 0; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 197 );
                            ClearBuffer ( GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$  )  ) ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 198 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_19__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 203 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_20__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 204 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 19) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 205 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 207 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 19), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 19))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TIME_DATE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 208 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 11; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 209 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNT = 0; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 210 );
                            ClearBuffer ( GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$  )  ) ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 211 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_21__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 216 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__COUNT = (Globals->S2_DMPS_System_Info_V1_0_2.__COUNT + 1); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 217 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_22__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 218 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 6) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 219 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 221 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 6), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 6))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_DNS1$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 222 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNT = (Globals->S2_DMPS_System_Info_V1_0_2.__COUNT - 1); 
                            } 
                        
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 224 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_23__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 225 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 6) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 226 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 228 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 6), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 6))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_DNS2$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 229 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNT = (Globals->S2_DMPS_System_Info_V1_0_2.__COUNT - 1); 
                            } 
                        
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 231 );
                        if ( (Globals->S2_DMPS_System_Info_V1_0_2.__COUNT > 2)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 233 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 12; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 234 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_24__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 239 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_25__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 240 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 14) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 241 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 243 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 14), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 14))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_PROGRAM$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 244 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_26__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 , 1 ); 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 245 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_27__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 , 1 ); 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 246 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 2), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 2))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_VERSION$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 247 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__COUNTER = 13; 
                            } 
                        
                        } 
                    
                    else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 13) )
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 252 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_28__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , 1 , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 253 );
                        Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 14) , 1 ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 254 );
                        if ( ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 > 0) && (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 > 0))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 256 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$  )  , (Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1 + 14), ((Globals->S2_DMPS_System_Info_V1_0_2.__MARKER2 - Globals->S2_DMPS_System_Info_V1_0_2.__MARKER1) - 14))  )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_COMPILED$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 257 );
                            CancelAllWait ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 258 );
                            SetDigital ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_BUSY_DIG_OUTPUT, 0) ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 259 );
                            Globals->S2_DMPS_System_Info_V1_0_2.__BUSYINT = 0; 
                            } 
                        
                        } 
                    
                    } 
                    
                }
                
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 95 );
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 264 );
        Globals->S2_DMPS_System_Info_V1_0_2.__SEMAPHORE = 0; 
        } 
    
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_1:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_7__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_8__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_9__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_10__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_11__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_12__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_13__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_14__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_15__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_16__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_17__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_18__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_19__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_20__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_21__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_22__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_23__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_24__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_25__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_26__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_27__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_28__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00002 /*IPAin$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 270 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,10 , "ipa 0 %s\r\n"  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __IPAIN$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_2:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00003 /*IPMin$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 275 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,10 , "ipm 0 %s\r\n"  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __IPMIN$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_3:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00004 /*DefRin$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 280 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,11 , "defr 0 %s\r\n"  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __DEFRIN$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_4:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00005 /*DHCPin$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 285 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,9 , "dhcp %s\r\n"  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __DHCPIN$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_5:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00006 /*WINSin$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 290 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,9 , "wins %s\r\n"  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __WINSIN$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_6:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00007 /*HostNamein$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 295 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,13 , "hostname %s\r\n"  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __HOSTNAMEIN$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_7:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00008 /*DomainNamein$*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 300 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) , GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 )  ,15 , "domainname %s\r\n"  , GLOBAL_STRING_STRUCT( S2_DMPS_System_Info_V1_0_2, __DOMAINNAMEIN$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), __S2_DMPS_System_Info_V1_0_2_TOCONSOLE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_System_Info_V1_0_2 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); }
    
    ; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__Event_8:
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
        case __S2_DMPS_System_Info_V1_0_2_GO_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00000 /*Go*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_System_Info_V1_0_2 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_DMPS_System_Info_V1_0_2_IPAIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00002 /*IPAin$*/, 0 );
            break;
            
        case __S2_DMPS_System_Info_V1_0_2_IPMIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00003 /*IPMin$*/, 0 );
            break;
            
        case __S2_DMPS_System_Info_V1_0_2_DEFRIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00004 /*DefRin$*/, 0 );
            break;
            
        case __S2_DMPS_System_Info_V1_0_2_DHCPIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00005 /*DHCPin$*/, 0 );
            break;
            
        case __S2_DMPS_System_Info_V1_0_2_WINSIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00006 /*WINSin$*/, 0 );
            break;
            
        case __S2_DMPS_System_Info_V1_0_2_HOSTNAMEIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00007 /*HostNamein$*/, 0 );
            break;
            
        case __S2_DMPS_System_Info_V1_0_2_DOMAINNAMEIN$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00008 /*DomainNamein$*/, 0 );
            break;
            
        case __S2_DMPS_System_Info_V1_0_2_FROMCONSOLE$_BUFFER_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_System_Info_V1_0_2, 00001 /*FromConsole$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_System_Info_V1_0_2 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_DMPS_System_Info_V1_0_2 )
********************************************************************************/
EVENT_HANDLER( S2_DMPS_System_Info_V1_0_2 )
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
  FUNCTION_MAIN( S2_DMPS_System_Info_V1_0_2 )
********************************************************************************/
FUNCTION_MAIN( S2_DMPS_System_Info_V1_0_2 )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_DMPS_System_Info_V1_0_2 );
    
    
    /* End local function variable declarations */
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __IPAIN$, e_INPUT_TYPE_STRING, __S2_DMPS_System_Info_V1_0_2_IPAIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __IPAIN$, __S2_DMPS_System_Info_V1_0_2_IPAIN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __IPMIN$, e_INPUT_TYPE_STRING, __S2_DMPS_System_Info_V1_0_2_IPMIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __IPMIN$, __S2_DMPS_System_Info_V1_0_2_IPMIN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __DEFRIN$, e_INPUT_TYPE_STRING, __S2_DMPS_System_Info_V1_0_2_DEFRIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __DEFRIN$, __S2_DMPS_System_Info_V1_0_2_DEFRIN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __DHCPIN$, e_INPUT_TYPE_STRING, __S2_DMPS_System_Info_V1_0_2_DHCPIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __DHCPIN$, __S2_DMPS_System_Info_V1_0_2_DHCPIN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __WINSIN$, e_INPUT_TYPE_STRING, __S2_DMPS_System_Info_V1_0_2_WINSIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __WINSIN$, __S2_DMPS_System_Info_V1_0_2_WINSIN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __HOSTNAMEIN$, e_INPUT_TYPE_STRING, __S2_DMPS_System_Info_V1_0_2_HOSTNAMEIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __HOSTNAMEIN$, __S2_DMPS_System_Info_V1_0_2_HOSTNAMEIN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __DOMAINNAMEIN$, e_INPUT_TYPE_STRING, __S2_DMPS_System_Info_V1_0_2_DOMAINNAMEIN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __DOMAINNAMEIN$, __S2_DMPS_System_Info_V1_0_2_DOMAINNAMEIN$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$, e_INPUT_TYPE_BUFFER, __S2_DMPS_System_Info_V1_0_2_FROMCONSOLE$_BUFFER_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$, __S2_DMPS_System_Info_V1_0_2_FROMCONSOLE$_BUFFER_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, __TEMPSTRING$, e_INPUT_TYPE_NONE, __S2_DMPS_System_Info_V1_0_2_TEMPSTRING$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_System_Info_V1_0_2, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    REGISTER_GLOBAL_INPUT_STRING ( S2_DMPS_System_Info_V1_0_2, __FROMCONSOLE$, __S2_DMPS_System_Info_V1_0_2_FROMCONSOLE$_BUFFER_INPUT );
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 305 );
    Globals->S2_DMPS_System_Info_V1_0_2.__SEMAPHORE = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_System_Info_V1_0_2 ), 306 );
    Globals->S2_DMPS_System_Info_V1_0_2.__BUSYINT = 0; 
    
    S2_DMPS_System_Info_V1_0_2_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
