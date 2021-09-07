#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_DMPS_Text_Router_v1_0.h"

FUNCTION_MAIN( S2_DMPS_Text_Router_v1_0 );
EVENT_HANDLER( S2_DMPS_Text_Router_v1_0 );
DEFINE_ENTRYPOINT( S2_DMPS_Text_Router_v1_0 );



static void S2_DMPS_Text_Router_v1_0__EVALUATE ( unsigned short __INDEX ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x20""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "Select  Input" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "   Select Output" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__, sizeof( "     Then Input" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x20""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "Select  Input" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "   Select Output" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__, "     Then Input" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 101 );
    if ( (__INDEX > 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 103 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,7 , "OUT: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __DESTINATIONNAMEIN$  )    ,  __INDEX  )  )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 106 );
        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__VIDEOINPUT , __INDEX  ) > 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 108 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,6 , "IN: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$  )    ,  GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__VIDEOINPUT , __INDEX  )  )  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 109 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 110 );
            Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
            } 
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 113 );
            if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__AUDIOINPUT , __INDEX  ) > 0)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 115 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,6 , "IN: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$  )    ,  GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__AUDIOINPUT , __INDEX  )  )  )  ; 
                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 116 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 117 );
                Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 125 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 126 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 127 );
                Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
                } 
            
            }
        
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 132 );
        if ( (GetDigitalInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_SYSTEMREADY_DIG_INPUT ) == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 134 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 135 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 136 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 137 );
            Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
            } 
        
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__EVALUATE:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ );
    /* End Free local function variables */
    
    }
    
static void S2_DMPS_Text_Router_v1_0__DISPLAYINFO ( unsigned short __SELECTION ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __NAME_STRING_LENGTH; 
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x20""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "DM" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "HDMI" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__, sizeof( "\x03""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __FN_DST_STR__ );
    
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x20""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "DM" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "HDMI" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__, "\x03""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 148 );
    Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION = __SELECTION; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 149 );
    if ( ((__SELECTION >= 1) && (__SELECTION <= 7))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 151 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 153 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,7 , "OUT: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __DESTINATIONNAMEIN$  )    ,  __SELECTION  )  )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 155 );
        if ( ((__SELECTION >= 1) && (__SELECTION <= (7 - 3)))) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 158 );
            __NAME_STRING_LENGTH = Len( GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __NAME_STRING  )  ,  __SELECTION  ) ); 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 159 );
            if ( (__NAME_STRING_LENGTH == 1)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 161 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,18 , "No Output Detected"  )  ; 
                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 165 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __NAME_STRING  )    ,  __SELECTION  )  )  ; 
                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                } 
            
            } 
        
        else 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 170 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,1 , " "  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 199 );
        Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE = 0; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 200 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 201 );
        Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 1; 
        } 
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 204 );
        if ( ((__SELECTION >= 8) && (__SELECTION <= 14))) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 206 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 207 );
            Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE = 1; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 208 );
            Globals->S2_DMPS_Text_Router_v1_0.__INPUTVIDEODETECTED = 1; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 209 );
            Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 1; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 210 );
            if ( ((Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION == 13) || (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION == 14))) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 212 );
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 215 );
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 218 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,6 , "IN: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$  )    ,  (__SELECTION - 7)  )  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 219 );
            if ( ((__SELECTION >= 10) && (__SELECTION <= 12))) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 222 );
                if ( (((GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_DIGITALVIDEODETECTED , (__SELECTION - 7)  ) == 0) && (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAVIDEODETECTED , (__SELECTION - 9)  ) == 0)) && (__SELECTION != 12))) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 224 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,17 , "No Video Detected"  )  ; 
                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 225 );
                    Globals->S2_DMPS_Text_Router_v1_0.__INPUTVIDEODETECTED = 0; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 226 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    } 
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 229 );
                    if ( (((GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_DIGITALVIDEODETECTED , (__SELECTION - 7)  ) == 0) && (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAVIDEODETECTED , (__SELECTION - 9)  ) == 0)) && (__SELECTION == 12))) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 231 );
                        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_BNCVIDEODETECTED , 1  ) == 0)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 233 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,17 , "No Video Detected"  )  ; 
                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 234 );
                            Globals->S2_DMPS_Text_Router_v1_0.__INPUTVIDEODETECTED = 0; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 235 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 240 );
                        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VIDEOSOURCESELECT , (__SELECTION - 9)  ) == 1)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 242 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,11 , "%s VRes: %d"  , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDMIVERTICALRESOLUTION , (__SELECTION - 7)  ) ) )  ; 
                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 243 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            } 
                        
                        else 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 248 );
                            if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VIDEOSOURCESELECT , (__SELECTION - 9)  ) == 2)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 250 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "VGA VRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAVERTICALRESOLUTION , (__SELECTION - 9)  ) ) )  ; 
                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 251 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
                                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                } 
                            
                            else 
                                {
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 254 );
                                if ( ((__SELECTION == 12) && (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VIDEOSOURCESELECT , (__SELECTION - 9)  ) == 3))) 
                                    { 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 256 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "BNC VRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_BNCVERTICALRESOLUTION , 1  ) ) )  ; 
                                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 257 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
                                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    } 
                                
                                else 
                                    { 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 263 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,17 , "No Video Detected"  )  ; 
                                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 264 );
                                    Globals->S2_DMPS_Text_Router_v1_0.__INPUTVIDEODETECTED = 0; 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 265 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 271 );
                if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_DIGITALVIDEODETECTED , (__SELECTION - 7)  ) == 1)) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 273 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,11 , "%s VRes: %d"  , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDMIVERTICALRESOLUTION , (__SELECTION - 7)  ) ) )  ; 
                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 274 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    } 
                
                else 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 282 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,17 , "No Video Detected"  )  ; 
                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 283 );
                    Globals->S2_DMPS_Text_Router_v1_0.__INPUTVIDEODETECTED = 0; 
                    } 
                
                }
            
            } 
        
        else 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 291 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,10 , "Video Info"  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 292 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,19 , "Select Input/Output"  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 293 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 294 );
            Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 0; 
            } 
        
        }
    
    
    S2_DMPS_Text_Router_v1_0_Exit__DISPLAYINFO:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ );
    /* End Free local function variables */
    
    }
    
static void S2_DMPS_Text_Router_v1_0__VIEW ( unsigned short __INDEX ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x20""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "No Input" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "   Select Output" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__, sizeof( "      " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x20""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "No Input" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "   Select Output" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__, "      " );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 306 );
    if ( (__INDEX > 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 308 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,7 , "OUT: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __DESTINATIONNAMEIN$  )    ,  __INDEX  )  )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 311 );
        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__VIDEOINPUT , __INDEX  ) > 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 314 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,6 , "IN: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$  )    ,  GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__VIDEOINPUT , __INDEX  )  )  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 315 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 316 );
            Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
            } 
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 340 );
            if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__AUDIOINPUT , __INDEX  ) > 0)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 342 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,6 , "IN: %s"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$  )    ,  GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__AUDIOINPUT , __INDEX  )  )  )  ; 
                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 343 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 344 );
                Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 349 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 350 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                
                ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 351 );
                Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
                } 
            
            }
        
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 356 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 357 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 358 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 359 );
        Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 0; 
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__VIEW:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ );
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00000 /*VideoInput*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __INDEX; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 371 );
    __INDEX = GetLocalLastModifiedArrayIndex ( S2_DMPS_Text_Router_v1_0 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 372 );
    if ( ((((__INDEX == GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_DESTINATIONSELECTED_ANALOG_INPUT )) && (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 0)) && (GetDigitalInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_MODE_INSTALLER_NOT_ACTIVE_DIG_INPUT ) == 1)) && (GetDigitalInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_SYSTEMREADY_DIG_INPUT ) == 1))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 373 );
        S2_DMPS_Text_Router_v1_0__EVALUATE ( __INDEX) ; 
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00001 /*AudioInput*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __INDEX; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 382 );
    __INDEX = GetLocalLastModifiedArrayIndex ( S2_DMPS_Text_Router_v1_0 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 383 );
    if ( ((((__INDEX == GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_DESTINATIONSELECTED_ANALOG_INPUT )) && (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 0)) && (GetDigitalInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_MODE_INSTALLER_NOT_ACTIVE_DIG_INPUT ) == 1)) && (GetDigitalInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_SYSTEMREADY_DIG_INPUT ) == 1))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 384 );
        S2_DMPS_Text_Router_v1_0__EVALUATE ( __INDEX) ; 
        }
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_1:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00002 /*DestinationSelected*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 389 );
    if ( (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 391 );
        S2_DMPS_Text_Router_v1_0__EVALUATE ( GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_DESTINATIONSELECTED_ANALOG_INPUT )) ; 
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_2:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00003 /*ViewModeDestination*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 398 );
    if ( (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 400 );
        S2_DMPS_Text_Router_v1_0__VIEW ( GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_VIEWMODEDESTINATION_ANALOG_INPUT )) ; 
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_3:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00004 /*SelectedInOut*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 406 );
    if ( (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 408 );
        S2_DMPS_Text_Router_v1_0__DISPLAYINFO ( GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_SELECTEDINOUT_ANALOG_INPUT )) ; 
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_4:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00005 /*Up*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x03""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "No Video Detected" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "\x04""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__, sizeof( "\x02""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x03""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "No Video Detected" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "\x04""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_3__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__, "\x02""" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 417 );
    if ( (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 419 );
        if ( (Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY == 2)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 421 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,11 , " IN: %s-VID"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$  )    ,  GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__VIDEOINPUT , GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_DESTINATIONSELECTED_ANALOG_INPUT )  )  )  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 422 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 423 );
            Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 1; 
            } 
        
        } 
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 427 );
        if ( (Globals->S2_DMPS_Text_Router_v1_0.__INPUTVIDEODETECTED == 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 429 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            } 
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 432 );
            if ( (((GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE == 1)) && (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_DIGITALVIDEODETECTED , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) == 1))) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 434 );
                Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY - 1); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 435 );
                if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY < 1)) 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 436 );
                    Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 1; 
                    }
                
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 438 );
                if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 1)) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 440 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,11 , "%s VRes: %d"  , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDMIVERTICALRESOLUTION , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) ) )  ; 
                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 441 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    } 
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 443 );
                    if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 2)) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 446 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,11 , "%s HRes: %d"  , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDMIHORIZONTALRESOLUTION , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) ) )  ; 
                        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                        
                        ; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 447 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                        SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                        
                        ; 
                        } 
                    
                    else 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 450 );
                        if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 3)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 452 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,14 , "%s Refresh: %d"  , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDMIREFRESHRATE , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) ) )  ; 
                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 453 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            } 
                        
                        }
                    
                    }
                
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 460 );
                if ( (((((GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE == 1)) && (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VIDEOSOURCESELECT , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) == 2)) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION >= 10)) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION <= 12))) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 463 );
                    Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY - 1); 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 464 );
                    if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY < 1)) 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 465 );
                        Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 1; 
                        }
                    
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 467 );
                    if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 1)) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 469 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "VGA VRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAVERTICALRESOLUTION , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) ) )  ; 
                        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                        
                        ; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 470 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                        SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                        
                        ; 
                        } 
                    
                    else 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 472 );
                        if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 2)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 475 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "VGA HRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAHORIZONTALRESOLUTION , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) ) )  ; 
                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 476 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            } 
                        
                        else 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 479 );
                            if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 3)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 481 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,15 , "VGA Refresh: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAREFRESHRATE , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) ) )  ; 
                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 482 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
                                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                } 
                            
                            }
                        
                        }
                    
                    } 
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 486 );
                    if ( ((((GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE == 1)) && (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VIDEOSOURCESELECT , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) == 3)) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION == 12))) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 489 );
                        Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY - 1); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 490 );
                        if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY < 1)) 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 491 );
                            Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 1; 
                            }
                        
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 493 );
                        if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 1)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 495 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "BNC VRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_BNCVERTICALRESOLUTION , 1  ) ) )  ; 
                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 496 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            } 
                        
                        else 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 498 );
                            if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 2)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 501 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "BNC HRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_BNCHORIZONTALRESOLUTION , 1  ) ) )  ; 
                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 502 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                } 
                            
                            else 
                                {
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 505 );
                                if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 3)) 
                                    { 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 507 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,15 , "BNC Refresh: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_BNCREFRESHRATE , 1  ) ) )  ; 
                                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 508 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )    )  ; 
                                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    }
                
                }
            
            }
        
        }
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_5:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00006 /*Down*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x02""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "No Video Detected" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "\x04""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x02""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "No Video Detected" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "\x04""" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 526 );
    if ( (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 529 );
        if ( (Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 531 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,11 , " IN: %s-AUD"  , GetStringArrayElement ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ),  GLOBAL_STRING_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$  )    ,  GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__AUDIOINPUT , GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_DESTINATIONSELECTED_ANALOG_INPUT )  )  )  )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 532 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 533 );
            Globals->S2_DMPS_Text_Router_v1_0.__LINE2DISPLAY = 2; 
            } 
        
        } 
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 536 );
        if ( (Globals->S2_DMPS_Text_Router_v1_0.__INPUTVIDEODETECTED == 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 538 );
            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
            
            ; 
            } 
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 541 );
            if ( (((GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE == 1)) && (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_DIGITALVIDEODETECTED , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) == 1))) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 543 );
                Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY + 1); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 544 );
                if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY > 4)) 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 545 );
                    Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 4; 
                    }
                
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 549 );
                if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 2)) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 551 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,1 , " "  )  ; 
                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 552 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,11 , "%s HRes: %d"  , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDMIHORIZONTALRESOLUTION , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) ) )  ; 
                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 554 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                    
                    ; 
                    } 
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 556 );
                    if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 3)) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 558 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,14 , "%s Refresh: %d"  , GLOBAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE  )  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDMIREFRESHRATE , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) ) )  ; 
                        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                        
                        ; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 559 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                        SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                        
                        ; 
                        } 
                    
                    else 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 561 );
                        if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 4)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 563 );
                            if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDCPENABLED , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) == 0)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 565 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,18 , "HDCP: not required"  )  ; 
                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                } 
                            
                            else 
                                {
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 567 );
                                if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDCPENABLED , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) == 55)) 
                                    { 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 569 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,21 , "HDCP: Unauthenticated"  )  ; 
                                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    } 
                                
                                else 
                                    {
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 571 );
                                    if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDCPENABLED , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) == 56)) 
                                        { 
                                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 573 );
                                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                        FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,13 , "HDCP: Waiting"  )  ; 
                                        SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                        
                                        ; 
                                        } 
                                    
                                    else 
                                        {
                                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 575 );
                                        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDCPENABLED , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) == 57)) 
                                            { 
                                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 577 );
                                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,19 , "HDCP: Authenticated"  )  ; 
                                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                            
                                            ; 
                                            } 
                                        
                                        else 
                                            {
                                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 579 );
                                            if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_HDCPENABLED , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 7)  ) == 58)) 
                                                { 
                                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 581 );
                                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,15 , "HDCP: No Source"  )  ; 
                                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                                
                                                ; 
                                                } 
                                            
                                            else 
                                                { 
                                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 585 );
                                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,13 , "HDCP: Unknown"  )  ; 
                                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                                
                                                ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 588 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            } 
                        
                        }
                    
                    }
                
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 593 );
                if ( ((((GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE == 1)) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION >= 10)) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION <= 12))) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 596 );
                    if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VIDEOSOURCESELECT , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) == 2)) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 598 );
                        Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY + 1); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 599 );
                        if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY > 3)) 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 600 );
                            Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 3; 
                            }
                        
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 602 );
                        if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 2)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 604 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,1 , " "  )  ; 
                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 605 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "VGA HRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAHORIZONTALRESOLUTION , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) ) )  ; 
                            SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 607 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                            
                            ; 
                            } 
                        
                        else 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 609 );
                            if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 3)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 611 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,15 , "VGA Refresh: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VGAREFRESHRATE , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) ) )  ; 
                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 612 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                } 
                            
                            }
                        
                        } 
                    
                    } 
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 616 );
                    if ( (((GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODE == 1)) && (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION == 12))) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 618 );
                        if ( (GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_VIDEOSOURCESELECT , (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODESELECTION - 9)  ) == 3)) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 620 );
                            Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY + 1); 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 621 );
                            if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY > 3)) 
                                {
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 622 );
                                Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 3; 
                                }
                            
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 625 );
                            if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 2)) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 627 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,1 , " "  )  ; 
                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 628 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,12 , "BNC HRes: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_BNCHORIZONTALRESOLUTION , 1  ) ) )  ; 
                                SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 629 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                                SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                
                                ; 
                                } 
                            
                            else 
                                {
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 631 );
                                if ( (Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY == 3)) 
                                    { 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 633 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,15 , "BNC Refresh: %d"  , (short)( GetInOutArrayElement( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), &Globals->S2_DMPS_Text_Router_v1_0.__INPUT_BNCREFRESHRATE , 1  ) ) )  ; 
                                    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 634 );
                                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
                                    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
                                    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
                                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
                                    
                                    ; 
                                    } 
                                
                                }
                            
                            } 
                        
                        } 
                    
                    }
                
                }
            
            }
        
        }
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_6:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00007 /*ViewBtn*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __INDEX; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 645 );
    SetAnalog ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 647 );
    __INDEX = GetLocalLastModifiedArrayIndex ( S2_DMPS_Text_Router_v1_0 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 648 );
    if ( ((__INDEX == GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_DESTINATIONSELECTED_ANALOG_INPUT )) && (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 0))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 650 );
        S2_DMPS_Text_Router_v1_0__EVALUATE ( __INDEX) ; 
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_7:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00008 /*RouteBtn*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 658 );
    SetAnalog ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT, 0) ; 
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_8:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00009 /*InfoBtn*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 666 );
    SetAnalog ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT, 2) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 667 );
    Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 668 );
    S2_DMPS_Text_Router_v1_0__DISPLAYINFO ( GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_SELECTEDINOUT_ANALOG_INPUT )) ; 
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_9:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 0000A /*Front_Panel_Button_Pressed*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 675 );
    if ( (GetAnalogOutput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT ) == 2)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 677 );
        Globals->S2_DMPS_Text_Router_v1_0.__VIEWMODELINE2DISPLAY = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 678 );
        S2_DMPS_Text_Router_v1_0__DISPLAYINFO ( GetAnalogInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_SELECTEDINOUT_ANALOG_INPUT )) ; 
        } 
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_10:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 0000B /*SysPwrBtn*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 685 );
    if ( (GetDigitalInput( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_SYSTEMPOWERSTATE_DIG_INPUT ) == 0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 686 );
        SetAnalog ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT, 0) ; 
        }
    
    
    S2_DMPS_Text_Router_v1_0_Exit__Event_11:
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
        case __S2_DMPS_Text_Router_v1_0_UP_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00005 /*Up*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
                
            }
            break;
            
        case __S2_DMPS_Text_Router_v1_0_DOWN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00006 /*Down*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
                
            }
            break;
            
        case __S2_DMPS_Text_Router_v1_0_ROUTEBTN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00008 /*RouteBtn*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
                
            }
            break;
            
        case __S2_DMPS_Text_Router_v1_0_VIEWBTN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00007 /*ViewBtn*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
                
            }
            break;
            
        case __S2_DMPS_Text_Router_v1_0_INFOBTN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00009 /*InfoBtn*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
                
            }
            break;
            
        case __S2_DMPS_Text_Router_v1_0_SYSPWRBTN_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 0000B /*SysPwrBtn*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
                
            }
            break;
            
        case __S2_DMPS_Text_Router_v1_0_FRONT_PANEL_BUTTON_PRESSED_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 0000A /*Front_Panel_Button_Pressed*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
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
        case __S2_DMPS_Text_Router_v1_0_DESTINATIONSELECTED_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00002 /*DestinationSelected*/, 0 );
            break;
            
        case __S2_DMPS_Text_Router_v1_0_VIEWMODEDESTINATION_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00003 /*ViewModeDestination*/, 0 );
            break;
            
        case __S2_DMPS_Text_Router_v1_0_SELECTEDINOUT_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00004 /*SelectedInOut*/, 0 );
            break;
            
        case __S2_DMPS_Text_Router_v1_0_VIDEOINPUT_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00000 /*VideoInput*/, 0 );
            break;
            
        case __S2_DMPS_Text_Router_v1_0_AUDIOINPUT_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_DMPS_Text_Router_v1_0, 00001 /*AudioInput*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_Text_Router_v1_0 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_DMPS_Text_Router_v1_0 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_DMPS_Text_Router_v1_0 )
********************************************************************************/
EVENT_HANDLER( S2_DMPS_Text_Router_v1_0 )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_DIGITALVIDEODETECTED ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAVIDEODETECTED ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCVIDEODETECTED ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __VIDEOINPUT ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __AUDIOINPUT ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDMIVERTICALRESOLUTION ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDMIHORIZONTALRESOLUTION ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDMIREFRESHRATE ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDCPENABLED ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __OUTPUT_HDCPENABLED ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAVERTICALRESOLUTION ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAHORIZONTALRESOLUTION ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAREFRESHRATE ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCVERTICALRESOLUTION ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCHORIZONTALRESOLUTION ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCREFRESHRATE ) ;
    CHECK_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VIDEOSOURCESELECT ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$ ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __DESTINATIONNAMEIN$ ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __MANF_STRING ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_DMPS_Text_Router_v1_0, __NAME_STRING ) ;
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
  FUNCTION_MAIN( S2_DMPS_Text_Router_v1_0 )
********************************************************************************/
FUNCTION_MAIN( S2_DMPS_Text_Router_v1_0 )
{
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\x20""" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "   Select Output" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "     Then Input" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_DMPS_Text_Router_v1_0 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\x20""" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "   Select Output" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_DMPS_Text_Router_v1_0, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "     Then Input" );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_DIGITALVIDEODETECTED, IO_TYPE_DIGITAL_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_DIGITALVIDEODETECTED_DIG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_DIGITALVIDEODETECTED_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAVIDEODETECTED, IO_TYPE_DIGITAL_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAVIDEODETECTED_DIG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAVIDEODETECTED_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCVIDEODETECTED, IO_TYPE_DIGITAL_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCVIDEODETECTED_DIG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCVIDEODETECTED_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __VIDEOINPUT, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_VIDEOINPUT_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_VIDEOINPUT_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __AUDIOINPUT, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_AUDIOINPUT_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_AUDIOINPUT_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDMIVERTICALRESOLUTION, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDMIVERTICALRESOLUTION_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDMIVERTICALRESOLUTION_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDMIHORIZONTALRESOLUTION, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDMIHORIZONTALRESOLUTION_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDMIHORIZONTALRESOLUTION_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDMIREFRESHRATE, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDMIREFRESHRATE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDMIREFRESHRATE_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_HDCPENABLED, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDCPENABLED_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_HDCPENABLED_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __OUTPUT_HDCPENABLED, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_OUTPUT_HDCPENABLED_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_OUTPUT_HDCPENABLED_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAVERTICALRESOLUTION, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAVERTICALRESOLUTION_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAVERTICALRESOLUTION_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAHORIZONTALRESOLUTION, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAHORIZONTALRESOLUTION_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAHORIZONTALRESOLUTION_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VGAREFRESHRATE, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAREFRESHRATE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VGAREFRESHRATE_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCVERTICALRESOLUTION, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCVERTICALRESOLUTION_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCVERTICALRESOLUTION_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCHORIZONTALRESOLUTION, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCHORIZONTALRESOLUTION_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCHORIZONTALRESOLUTION_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_BNCREFRESHRATE, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCREFRESHRATE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_BNCREFRESHRATE_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __INPUT_VIDEOSOURCESELECT, IO_TYPE_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VIDEOSOURCESELECT_ANALOG_INPUT, __S2_DMPS_Text_Router_v1_0_INPUT_VIDEOSOURCESELECT_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_DMPS_Text_Router_v1_0, __SERIALOUT$, IO_TYPE_STRING_OUTPUT, __S2_DMPS_Text_Router_v1_0_SERIALOUT$_STRING_OUTPUT, __S2_DMPS_Text_Router_v1_0_SERIALOUT$_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$, e_INPUT_TYPE_STRING, __S2_DMPS_Text_Router_v1_0_SOURCENAMEIN$_ARRAY_NUM_ELEMS, __S2_DMPS_Text_Router_v1_0_SOURCENAMEIN$_ARRAY_NUM_CHARS, __S2_DMPS_Text_Router_v1_0_SOURCENAMEIN$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_DMPS_Text_Router_v1_0, __SOURCENAMEIN$ );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_DMPS_Text_Router_v1_0, __DESTINATIONNAMEIN$, e_INPUT_TYPE_STRING, __S2_DMPS_Text_Router_v1_0_DESTINATIONNAMEIN$_ARRAY_NUM_ELEMS, __S2_DMPS_Text_Router_v1_0_DESTINATIONNAMEIN$_ARRAY_NUM_CHARS, __S2_DMPS_Text_Router_v1_0_DESTINATIONNAMEIN$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_DMPS_Text_Router_v1_0, __DESTINATIONNAMEIN$ );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_DMPS_Text_Router_v1_0, __MANF_STRING, e_INPUT_TYPE_STRING, __S2_DMPS_Text_Router_v1_0_MANF_STRING_ARRAY_NUM_ELEMS, __S2_DMPS_Text_Router_v1_0_MANF_STRING_ARRAY_NUM_CHARS, __S2_DMPS_Text_Router_v1_0_MANF_STRING_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_DMPS_Text_Router_v1_0, __MANF_STRING );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_DMPS_Text_Router_v1_0, __NAME_STRING, e_INPUT_TYPE_STRING, __S2_DMPS_Text_Router_v1_0_NAME_STRING_ARRAY_NUM_ELEMS, __S2_DMPS_Text_Router_v1_0_NAME_STRING_ARRAY_NUM_CHARS, __S2_DMPS_Text_Router_v1_0_NAME_STRING_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_DMPS_Text_Router_v1_0, __NAME_STRING );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_Text_Router_v1_0, __HDMIDMMODE, e_INPUT_TYPE_NONE, __S2_DMPS_Text_Router_v1_0_HDMIDMMODE_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_DMPS_Text_Router_v1_0, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 691 );
    S2_DMPS_Text_Router_v1_0__EVALUATE ( 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 692 );
    SetAnalog ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_FRONTPANELMODE_ANALOG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 693 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), __S2_DMPS_Text_Router_v1_0_LINE2SCROLLARROW$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 694 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )    )  ; 
    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 1 ) ; 
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
    
    ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ), 695 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) , GENERIC_STRING_OUTPUT( S2_DMPS_Text_Router_v1_0 )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
    SET_STRING_OUT_ARRAY_ELEMENT( S2_DMPS_Text_Router_v1_0, __SERIALOUT$ , 2 ) ; 
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_DMPS_Text_Router_v1_0 ) ); }
    
    ; 
    
    S2_DMPS_Text_Router_v1_0_Exit__MAIN:/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
