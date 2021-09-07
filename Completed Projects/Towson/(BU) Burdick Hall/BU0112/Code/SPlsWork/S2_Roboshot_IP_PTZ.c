#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Roboshot_IP_PTZ.h"

FUNCTION_MAIN( S2_Roboshot_IP_PTZ );
EVENT_HANDLER( S2_Roboshot_IP_PTZ );
DEFINE_ENTRYPOINT( S2_Roboshot_IP_PTZ );


DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00000 /*Store*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 52 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,24 , "camera preset store %u\r\n"  , (unsigned short )( GetAnalogInput( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_PRESET_ANALOG_INPUT ) ) )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00001 /*Recall*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 58 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,25 , "camera preset recall %u\r\n"  , (unsigned short )( GetAnalogInput( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_PRESET_ANALOG_INPUT ) ) )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_1:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00002 /*Tilt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera tilt up\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "camera tilt down\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera tilt up\r" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "camera tilt down\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 62 );
    Globals->S2_Roboshot_IP_PTZ.__PTZ = GetLocalLastModifiedArrayIndex ( S2_Roboshot_IP_PTZ ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 63 );
    
        {
        int __SPLS_TMPVAR__SWTCH_1__ = ( Globals->S2_Roboshot_IP_PTZ.__PTZ) ;
        
            { 
            if ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 67 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 71 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            } 
            
        }
        
    
    
    S2_Roboshot_IP_PTZ_Exit__Event_2:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00003 /*Pan*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera pan left\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "camera pan right\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera pan left\r" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "camera pan right\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 77 );
    Globals->S2_Roboshot_IP_PTZ.__PTZ = GetLocalLastModifiedArrayIndex ( S2_Roboshot_IP_PTZ ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 78 );
    
        {
        int __SPLS_TMPVAR__SWTCH_1__ = ( Globals->S2_Roboshot_IP_PTZ.__PTZ) ;
        
            { 
            if ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 82 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 86 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            } 
            
        }
        
    
    
    S2_Roboshot_IP_PTZ_Exit__Event_3:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00004 /*AutoFocus*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera focus mode auto\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera focus mode auto\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 92 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00005 /*Zoom*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera zoom in\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "camera zoom out\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera zoom in\r" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "camera zoom out\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 96 );
    Globals->S2_Roboshot_IP_PTZ.__PTZ = GetLocalLastModifiedArrayIndex ( S2_Roboshot_IP_PTZ ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 97 );
    
        {
        int __SPLS_TMPVAR__SWTCH_1__ = ( Globals->S2_Roboshot_IP_PTZ.__PTZ) ;
        
            { 
            if ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 101 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 105 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            } 
            
        }
        
    
    
    S2_Roboshot_IP_PTZ_Exit__Event_5:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00006 /*Focus*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera focus near\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "camera focus far\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera focus near\r" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "camera focus far\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 111 );
    Globals->S2_Roboshot_IP_PTZ.__PTZ = GetLocalLastModifiedArrayIndex ( S2_Roboshot_IP_PTZ ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 112 );
    
        {
        int __SPLS_TMPVAR__SWTCH_1__ = ( Globals->S2_Roboshot_IP_PTZ.__PTZ) ;
        
            { 
            if ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 116 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 120 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
                
                ; 
                } 
            
            } 
            
        }
        
    
    
    S2_Roboshot_IP_PTZ_Exit__Event_6:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00007 /*Home*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera home\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera home\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 127 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_7:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00008 /*PowerOn*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera standby off\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera standby off\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 131 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_8:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00009 /*PowerOff*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera standby on\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera standby on\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 135 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_9:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000A /*Pan*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera pan stop\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera pan stop\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 139 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_10:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000B /*Tilt*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera tilt stop\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera tilt stop\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 141 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_11:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000C /*Zoom*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera zoom stop\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera zoom stop\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 143 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_12:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000D /*Focus*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "camera focus stop\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "camera focus stop\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 145 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Roboshot_IP_PTZ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); }
    
    ; 
    
    S2_Roboshot_IP_PTZ_Exit__Event_13:
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
        case __S2_Roboshot_IP_PTZ_RECALL_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00001 /*Recall*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_STORE_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00000 /*Store*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_POWERON_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00008 /*PowerOn*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_POWEROFF_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00009 /*PowerOff*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_HOME_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00007 /*Home*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_AUTOFOCUS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00004 /*AutoFocus*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_TILT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00002 /*Tilt*/, 0 );
                
            }
            else /*Release*/
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000B /*Tilt*/, 0 );
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_PAN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00003 /*Pan*/, 0 );
                
            }
            else /*Release*/
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000A /*Pan*/, 0 );
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_ZOOM_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00005 /*Zoom*/, 0 );
                
            }
            else /*Release*/
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000C /*Zoom*/, 0 );
                
            }
            break;
            
        case __S2_Roboshot_IP_PTZ_FOCUS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 00006 /*Focus*/, 0 );
                
            }
            else /*Release*/
            {
                SAFESPAWN_EVENTHANDLER( S2_Roboshot_IP_PTZ, 0000D /*Focus*/, 0 );
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Roboshot_IP_PTZ ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Roboshot_IP_PTZ ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Roboshot_IP_PTZ )
********************************************************************************/
EVENT_HANDLER( S2_Roboshot_IP_PTZ )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_Roboshot_IP_PTZ, __TILT ) ;
    CHECK_INPUT_ARRAY ( S2_Roboshot_IP_PTZ, __PAN ) ;
    CHECK_INPUT_ARRAY ( S2_Roboshot_IP_PTZ, __ZOOM ) ;
    CHECK_INPUT_ARRAY ( S2_Roboshot_IP_PTZ, __FOCUS ) ;
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
  FUNCTION_MAIN( S2_Roboshot_IP_PTZ )
********************************************************************************/
FUNCTION_MAIN( S2_Roboshot_IP_PTZ )
{
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\\USER\\" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "Camera" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( ".dat" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FN_DST_STR___M, 250 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FN_DST_STR___M );
    
    CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FN_DST_STR___M1, 250 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FN_DST_STR___M1 );
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Roboshot_IP_PTZ );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\\USER\\" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "Camera" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, ".dat" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FN_DST_STR___M );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR___M, 250 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FN_DST_STR___M1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR___M1, 250 );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_Roboshot_IP_PTZ, __TILT, IO_TYPE_DIGITAL_INPUT, __S2_Roboshot_IP_PTZ_TILT_DIG_INPUT, __S2_Roboshot_IP_PTZ_TILT_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_Roboshot_IP_PTZ, __PAN, IO_TYPE_DIGITAL_INPUT, __S2_Roboshot_IP_PTZ_PAN_DIG_INPUT, __S2_Roboshot_IP_PTZ_PAN_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_Roboshot_IP_PTZ, __ZOOM, IO_TYPE_DIGITAL_INPUT, __S2_Roboshot_IP_PTZ_ZOOM_DIG_INPUT, __S2_Roboshot_IP_PTZ_ZOOM_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_Roboshot_IP_PTZ, __FOCUS, IO_TYPE_DIGITAL_INPUT, __S2_Roboshot_IP_PTZ_FOCUS_DIG_INPUT, __S2_Roboshot_IP_PTZ_FOCUS_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Roboshot_IP_PTZ, __IN$, e_INPUT_TYPE_STRING, __S2_Roboshot_IP_PTZ_IN$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Roboshot_IP_PTZ, __IN$, __S2_Roboshot_IP_PTZ_IN$_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Roboshot_IP_PTZ, __FILENAME, e_INPUT_TYPE_NONE, __S2_Roboshot_IP_PTZ_FILENAME_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Roboshot_IP_PTZ, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    INITIALIZE_GLOBAL_SIGNED_INTARRAY ( S2_Roboshot_IP_PTZ, __PRESETARRAY, 99, 3 );
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Roboshot_IP_PTZ ), 148 );
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M1 )    ,8 , "%s%s%s%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   ,  GetSymbolReferenceName ( INSTANCE_PTR( S2_Roboshot_IP_PTZ )  ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M )   ) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_Roboshot_IP_PTZ ) , GLOBAL_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FILENAME  )   ,2 , "%s"  , __FN_DST_STR___M1 ) ; 
    
    S2_Roboshot_IP_PTZ_Exit__MAIN:/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR___M );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR___M1 );
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
