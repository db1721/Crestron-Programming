#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Console_Processor_v3_.h"

FUNCTION_MAIN( S2_Console_Processor_v3_ );
EVENT_HANDLER( S2_Console_Processor_v3_ );
DEFINE_ENTRYPOINT( S2_Console_Processor_v3_ );

static void S2_Console_Processor_v3___PROCESSDATA ( struct StringHdr_s* __DATA ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SLOCALCOPY, 1000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SLOCALCOPY );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __STRASH, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __STRASH );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "Link Status:" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( "OK" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "Link Speed:" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_3__, sizeof( "Full Duplex:" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_3__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_4__, sizeof( "MAC Address(es):" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_4__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_5__, sizeof( "IP Address:" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_5__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_6__, sizeof( "Host Name:" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_6__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_7__, sizeof( "Host Name:  " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_7__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_8__, sizeof( "Program File:" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_8__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_9__, sizeof( "Program File: " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_9__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_10__, sizeof( "NOT initialized" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_10__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_11__, sizeof( "Not Initialized" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_11__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_12__, sizeof( "64K" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_12__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_13__, sizeof( "128K" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_13__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_14__, sizeof( "Initialized" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_14__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_15__, sizeof( "NVRAM filesystem successfully initialized" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_15__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__, 1000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__1, 1000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__1 );
    
    CheckStack( INSTANCE_PTR( S2_Console_Processor_v3_ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SLOCALCOPY );
    INITIALIZE_LOCAL_STRING_STRUCT( __SLOCALCOPY, 1000 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __STRASH );
    INITIALIZE_LOCAL_STRING_STRUCT( __STRASH, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "Link Status:" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, "OK" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "Link Speed:" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_3__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__, "Full Duplex:" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_4__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__, "MAC Address(es):" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_5__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__, "IP Address:" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_6__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__, "Host Name:" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_7__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_7__, "Host Name:  " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_8__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_8__, "Program File:" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_9__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_9__, "Program File: " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_10__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_10__, "NOT initialized" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_11__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_11__, "Not Initialized" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_12__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_12__, "64K" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_13__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_13__, "128K" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_14__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_14__, "Initialized" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_15__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_15__, "NVRAM filesystem successfully initialized" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 1000 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 1000 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 108 );
    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , LOCAL_STRING_STRUCT( __DATA  )   )  ; 
    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , LOCAL_STRING_STRUCT( __SLOCALCOPY  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 110 );
    if ( GetDigitalInput( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__DEBUG_DIG_INPUT )) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 111 );
        Print( INSTANCE_PTR( S2_Console_Processor_v3_ ) , 9, "Data:%s\r\n", LOCAL_STRING_STRUCT( __SLOCALCOPY  )  ) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 114 );
    if ( (Globals->S2_Console_Processor_v3_.__G_IDATAMODE == 2)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 116 );
        if ( GetDigitalInput( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__DEBUG_DIG_INPUT )) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 117 );
            Print( INSTANCE_PTR( S2_Console_Processor_v3_ ) , 23, "Parsing Ethernet Data\r\n") ; 
            }
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 119 );
        if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 121 );
            if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 122 );
                SetDigital ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__LINK_STATUS_DIG_OUTPUT, 1) ; 
                }
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 124 );
                SetDigital ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__LINK_STATUS_DIG_OUTPUT, 0) ; 
                }
            
            } 
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 126 );
            if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                { 
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 129 );
                if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                    { 
                    } 
                
                else 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 132 );
                    if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 134 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 20, 17)  )  ; 
                        SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MAC_ADDRESS$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                        
                        ; 
                        } 
                    
                    else 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 136 );
                        if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 138 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 16, 15)  )  ; 
                            SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__IP_ADDRESS$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                            
                            ; 
                            } 
                        
                        else 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 140 );
                            if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                                { 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 142 );
                                FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Remove ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_7__ )   , LOCAL_STRING_STRUCT( __SLOCALCOPY  )    , 1  )  )  ; 
                                FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , LOCAL_STRING_STRUCT( __STRASH  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 144 );
                                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                                FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  , Left ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , (Len( LOCAL_STRING_STRUCT( __SLOCALCOPY  )  ) - 2))  )  ; 
                                SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__HOST_NAME$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                                
                                ; 
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            }
        
        } 
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 147 );
        if ( (Globals->S2_Console_Processor_v3_.__G_IDATAMODE == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 149 );
            if ( GetDigitalInput( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__DEBUG_DIG_INPUT )) 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 150 );
                Print( INSTANCE_PTR( S2_Console_Processor_v3_ ) , 17, "Parsing OS Data\r\n") ; 
                }
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 152 );
            if ( (Len( LOCAL_STRING_STRUCT( __SLOCALCOPY  )  ) > 2)) 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 153 );
                if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  , Left ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , (Len( LOCAL_STRING_STRUCT( __SLOCALCOPY  )  ) - 2))  )  ; 
                SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__OS_VERSION$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                
                ; 
                }
            
            } 
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 155 );
            if ( (Globals->S2_Console_Processor_v3_.__G_IDATAMODE == 3)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 157 );
                if ( GetDigitalInput( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__DEBUG_DIG_INPUT )) 
                    {
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 158 );
                    Print( INSTANCE_PTR( S2_Console_Processor_v3_ ) , 22, "Parsing Program Data\r\n") ; 
                    }
                
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 160 );
                if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_8__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 162 );
                    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Remove ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_9__ )   , LOCAL_STRING_STRUCT( __SLOCALCOPY  )    , 1  )  )  ; 
                    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , LOCAL_STRING_STRUCT( __STRASH  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 164 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  , Left ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , (Len( LOCAL_STRING_STRUCT( __SLOCALCOPY  )  ) - 2))  )  ; 
                    SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__PROGRAM_FILE$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                    
                    ; 
                    } 
                
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 167 );
                if ( (Globals->S2_Console_Processor_v3_.__G_IDATAMODE == 4)) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 169 );
                    if ( GetDigitalInput( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__DEBUG_DIG_INPUT )) 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 170 );
                        Print( INSTANCE_PTR( S2_Console_Processor_v3_ ) , 24, "Parsing NVRamDisk Data\r\n") ; 
                        }
                    
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 172 );
                    Print( INSTANCE_PTR( S2_Console_Processor_v3_ ) , 14, "NVRamData:%s\r\n", LOCAL_STRING_STRUCT( __SLOCALCOPY  )  ) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 174 );
                    if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_10__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 177 );
                        if ( GetDigitalInput( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__EN_CREATE_NVRAMDISK_DIG_INPUT )) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 180 );
                            Globals->S2_Console_Processor_v3_.__G_BNEEDTOCREATENVRAMDISK = 1; 
                            } 
                        
                        else 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 185 );
                            SetDigital ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__NVRAMDISK_PRESENT_DIG_OUTPUT, 0) ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 186 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_11__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__NVRAMDISK_STATUS$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                            
                            ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 189 );
                        if ( (Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_12__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 ) || Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_13__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 ))) 
                            { 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 191 );
                            SetDigital ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__NVRAMDISK_PRESENT_DIG_OUTPUT, 1) ; 
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 192 );
                            if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                            FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_14__ )    )  ; 
                            SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__NVRAMDISK_STATUS$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                            ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                            
                            ; 
                            } 
                        
                        }
                    
                    } 
                
                else 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 197 );
                    if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_15__ )  , LOCAL_STRING_STRUCT( __SLOCALCOPY  )  , 1 , 1 )) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 199 );
                        SetDigital ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__NVRAMDISK_PRESENT_DIG_OUTPUT, 1) ; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 200 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_14__ )    )  ; 
                        SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__NVRAMDISK_STATUS$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                        
                        ; 
                        } 
                    
                    } 
                
                }
            
            }
        
        }
    
    
    S2_Console_Processor_v3__Exit__PROCESSDATA:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SLOCALCOPY );
    FREE_LOCAL_STRING_STRUCT( __STRASH );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_3__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_4__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_5__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_6__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_7__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_8__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_9__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_10__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_11__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_12__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_13__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_14__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_15__ );
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_Console_Processor_v3_, 00000 /*Get_OS_Info*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "ver\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Console_Processor_v3_ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "ver\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 213 );
    Globals->S2_Console_Processor_v3_.__G_IDATAMODE = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 214 );
    SetAnalog ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT, 1) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 216 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__CONSOLE_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
    
    ; 
    
    S2_Console_Processor_v3__Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Console_Processor_v3_, 00001 /*Get_Program_Info*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "progcom\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Console_Processor_v3_ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "progcom\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 221 );
    Globals->S2_Console_Processor_v3_.__G_IDATAMODE = 3; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 222 );
    SetAnalog ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT, 3) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 224 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__CONSOLE_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
    
    ; 
    
    S2_Console_Processor_v3__Exit__Event_1:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Console_Processor_v3_, 00002 /*Get_Ether_Info*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "est\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Console_Processor_v3_ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "est\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 229 );
    Globals->S2_Console_Processor_v3_.__G_IDATAMODE = 2; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 230 );
    SetAnalog ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT, 2) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 232 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__CONSOLE_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
    
    ; 
    
    S2_Console_Processor_v3__Exit__Event_2:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Console_Processor_v3_, 00003 /*Check_NVRamDisk*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "vnvramdisk\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Console_Processor_v3_ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "vnvramdisk\r" );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 237 );
    Globals->S2_Console_Processor_v3_.__G_IDATAMODE = 4; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 238 );
    SetAnalog ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT, 4) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 240 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__CONSOLE_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
    
    ; 
    
    S2_Console_Processor_v3__Exit__Event_3:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Console_Processor_v3_, 00004 /*Console_RX$*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "\r\n" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_1__, sizeof( ">" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_1__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_2__, sizeof( "vnvramdisk 128k\r" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_2__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__, 5000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__1, 5000 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Console_Processor_v3_ ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "\r\n" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_1__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__, ">" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __SPLS_TMPVAR__LOCALSTR_2__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__, "vnvramdisk 128k\r" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 5000 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Console_Processor_v3_, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 5000 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 245 );
    if ( Globals->S2_Console_Processor_v3_.__G_BRXOK) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 247 );
        Globals->S2_Console_Processor_v3_.__G_BRXOK = 0; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 249 );
        while ( (Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$  )  , 1 , 1 ) || Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )  , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$  )  , 1 , 1 ))) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 251 );
            if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$  )  , 1 , 1 )) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 253 );
                FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Remove ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$  )    , 1  )  )  ; 
                FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __G_STEMPDATA  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 254 );
                S2_Console_Processor_v3___PROCESSDATA (  (struct StringHdr_s* )  GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __G_STEMPDATA  )  ) ; 
                } 
            
            else 
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 256 );
                if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )  , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$  )  , 1 , 1 )) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 259 );
                    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Remove ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ )   , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$  )    , 1  )  )  ; 
                    FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GLOBAL_STRING_STRUCT( S2_Console_Processor_v3_, __G_STEMPDATA  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 262 );
                    SetAnalog ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT, 0) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 263 );
                    Globals->S2_Console_Processor_v3_.__G_IDATAMODE = 0; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 266 );
                    if ( Globals->S2_Console_Processor_v3_.__G_BNEEDTOCREATENVRAMDISK) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 270 );
                        Globals->S2_Console_Processor_v3_.__G_BNEEDTOCREATENVRAMDISK = 0; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 272 );
                        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ) == 0 ) {
                        FormatString ( INSTANCE_PTR( S2_Console_Processor_v3_ ) , GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ )    )  ; 
                        SetSerial( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__CONSOLE_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Console_Processor_v3_ ) );
                        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); }
                        
                        ; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 274 );
                        Globals->S2_Console_Processor_v3_.__G_IDATAMODE = 4; 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 275 );
                        SetAnalog ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT, 4) ; 
                        } 
                    
                    } 
                
                }
            
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 249 );
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 280 );
        Globals->S2_Console_Processor_v3_.__G_BRXOK = 1; 
        } 
    
    
    S2_Console_Processor_v3__Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_1__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_2__ );
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
        case __S2_Console_Processor_v3__GET_OS_INFO_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Console_Processor_v3_, 00000 /*Get_OS_Info*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
                
            }
            break;
            
        case __S2_Console_Processor_v3__GET_PROGRAM_INFO_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Console_Processor_v3_, 00001 /*Get_Program_Info*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
                
            }
            break;
            
        case __S2_Console_Processor_v3__GET_ETHER_INFO_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Console_Processor_v3_, 00002 /*Get_Ether_Info*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
                
            }
            break;
            
        case __S2_Console_Processor_v3__CHECK_NVRAMDISK_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Console_Processor_v3_, 00003 /*Check_NVRamDisk*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Console_Processor_v3_ ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_Console_Processor_v3__CONSOLE_RX$_BUFFER_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Console_Processor_v3_, 00004 /*Console_RX$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Console_Processor_v3_ ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Console_Processor_v3_ ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Console_Processor_v3_ )
********************************************************************************/
EVENT_HANDLER( S2_Console_Processor_v3_ )
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
  FUNCTION_MAIN( S2_Console_Processor_v3_ )
********************************************************************************/
FUNCTION_MAIN( S2_Console_Processor_v3_ )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Console_Processor_v3_ );
    
    
    /* End local function variable declarations */
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Console_Processor_v3_, __CONSOLE_RX$, e_INPUT_TYPE_BUFFER, __S2_Console_Processor_v3__CONSOLE_RX$_BUFFER_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Console_Processor_v3_, __CONSOLE_RX$, __S2_Console_Processor_v3__CONSOLE_RX$_BUFFER_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Console_Processor_v3_, __G_STEMPDATA, e_INPUT_TYPE_NONE, __S2_Console_Processor_v3__G_STEMPDATA_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Console_Processor_v3_, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    REGISTER_GLOBAL_INPUT_STRING ( S2_Console_Processor_v3_, __CONSOLE_RX$, __S2_Console_Processor_v3__CONSOLE_RX$_BUFFER_INPUT );
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 292 );
    Globals->S2_Console_Processor_v3_.__G_BRXOK = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 294 );
    SetAnalog ( INSTANCE_PTR( S2_Console_Processor_v3_ ), __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Console_Processor_v3_ ), 295 );
    Globals->S2_Console_Processor_v3_.__G_IDATAMODE = 0; 
    
    S2_Console_Processor_v3__Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
