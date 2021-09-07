#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Fusion_SSI_Device_Usage_Helper_v1_1.h"

FUNCTION_MAIN( S2_Fusion_SSI_Device_Usage_Helper_v1_1 );
EVENT_HANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1 );
DEFINE_ENTRYPOINT( S2_Fusion_SSI_Device_Usage_Helper_v1_1 );



static void S2_Fusion_SSI_Device_Usage_Helper_v1_1__FNTRANSMITUSAGEDATA ( unsigned short __NINDEX , unsigned short __NMEETINGTYPE ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __NMINUTESUSED; 
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __SASSETID$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __SASSETID$ );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __SMEETINGID$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __SMEETINGID$ );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __STIME$, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __STIME$ );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__2, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__2 );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__3, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__3 );
    
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __SASSETID$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __SASSETID$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __SMEETINGID$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __SMEETINGID$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __STIME$ );
    INITIALIZE_LOCAL_STRING_STRUCT( __STIME$, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__3 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__3, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 107 );
    if ( ((GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES == 0) && (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS > 0))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 109 );
        SetOutputArrayElement ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), &Globals->S2_Fusion_SSI_Device_Usage_Helper_v1_1.__CURRENT_USAGE_MINUTES_FB ,__NINDEX, 1) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 110 );
        __NMINUTESUSED = 1; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 114 );
        SetOutputArrayElement ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), &Globals->S2_Fusion_SSI_Device_Usage_Helper_v1_1.__CURRENT_USAGE_MINUTES_FB ,__NINDEX, GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 115 );
        __NMINUTESUSED = GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 118 );
    if ( (CompareStrings( GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCOMPAREDATE$  ) , Date( LOCAL_STRING_STRUCT( __FN_DST_STR__ )  , 3 ), 1 ) != 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 120 );
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Date (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , 3)  )  ; 
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 121 );
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Date (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , 3)  )  ; 
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCOMPAREDATE$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 122 );
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__3 )    ,8 , "%s-%s-%s"  , Left ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )  , 4) , Mid ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )  , 6, 2) , Right ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )  , 2)  )  ; 
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )   ,2 , "%s"  , __FN_DST_STR__3 ) ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 124 );
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Time (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )   )  )  ; 
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , LOCAL_STRING_STRUCT( __STIME$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 128 );
    if ( (Len( (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETID$ ) > 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 130 );
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETID$ )  ; 
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , LOCAL_STRING_STRUCT( __SASSETID$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 134 );
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,1 , "-" , __FN_DST_STR__  )  ; 
        FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , LOCAL_STRING_STRUCT( __SASSETID$  )   ,2 , "%s" , __FN_DST_STR__  ) ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 137 );
    if ( (__NMEETINGTYPE == 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 139 );
        if ( (Len( GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTMEETINGID$  )  ) > 5)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 141 );
            FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTMEETINGID$  )   )  ; 
            FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , LOCAL_STRING_STRUCT( __SMEETINGID$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
            } 
        
        else 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 145 );
            FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,1 , "-" , __FN_DST_STR__  )  ; 
            FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , LOCAL_STRING_STRUCT( __SMEETINGID$  )   ,2 , "%s" , __FN_DST_STR__  ) ; 
            } 
        
        } 
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 148 );
        if ( (__NMEETINGTYPE == 2)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 150 );
            if ( (Len( GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SPREVIOUSMEETINGID$  )  ) > 5)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 152 );
                FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SPREVIOUSMEETINGID$  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , LOCAL_STRING_STRUCT( __SMEETINGID$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                } 
            
            else 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 156 );
                FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,1 , "-" , __FN_DST_STR__  )  ; 
                FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , LOCAL_STRING_STRUCT( __SMEETINGID$  )   ,2 , "%s" , __FN_DST_STR__  ) ; 
                } 
            
            } 
        
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 160 );
    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ) == 0 ) {
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GENERIC_STRING_OUTPUT( S2_Fusion_SSI_Device_Usage_Helper_v1_1 )  ,49 , "USAGE||%s||%s||TIME||%s||%s||-||%s||-||%s||%s||\r\n"  , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )  , LOCAL_STRING_STRUCT( __STIME$  )  , (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETTYPE$, (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETNAME$, Itoa ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , __NMINUTESUSED) , LOCAL_STRING_STRUCT( __SASSETID$  )  , LOCAL_STRING_STRUCT( __SMEETINGID$  )   )  ; 
    SetSerial( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), __S2_Fusion_SSI_Device_Usage_Helper_v1_1_DEVICE_USAGE_TX$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); }
    
    ; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__FNTRANSMITUSAGEDATA:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SASSETID$ );
    FREE_LOCAL_STRING_STRUCT( __SMEETINGID$ );
    FREE_LOCAL_STRING_STRUCT( __STIME$ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__3 );
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00000 /*Meeting_ID$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 170 );
    if ( GetDigitalInput( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD_DIG_INPUT )) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 172 );
        if ( (CompareStrings( GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __MEETING_ID$  ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SPREVIOUSMEETINGID$  ) , 1 ) != 0)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 174 );
            __FN_FOREND_VAL__1 = 16; 
            __FN_FORINIT_VAL__1 = 1; 
            for( __NINDEX = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__NINDEX  <= __FN_FOREND_VAL__1 ) : ((short)__NINDEX  >= __FN_FOREND_VAL__1) ; __NINDEX  += __FN_FORINIT_VAL__1) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 176 );
                if ( (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NINUSE == 1)) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 178 );
                    S2_Fusion_SSI_Device_Usage_Helper_v1_1__FNTRANSMITUSAGEDATA ( __NINDEX, 2) ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 181 );
                    GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES = 0; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 182 );
                    GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS = 0; 
                    } 
                
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 174 );
                } 
            
            } 
        
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 188 );
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __MEETING_ID$  )   )  ; 
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTMEETINGID$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 189 );
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __MEETING_ID$  )   )  ; 
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SPREVIOUSMEETINGID$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00001 /*Asset_Type$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 196 );
    __NINDEX = GetLocalLastModifiedArrayIndex ( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 198 );
    FormatString(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),LOCAL_STRING_STRUCT( __FN_DST_STR__ ) ,2,"%s", GetStringArrayElement(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),GLOBAL_STRING_ARRAY(S2_Fusion_SSI_Device_Usage_Helper_v1_1,__ASSET_TYPE$),__NINDEX) );
FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETTYPE$  ,2 , "%s"  , __FN_DST_STR__ ) ; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_1:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00002 /*Asset_Name$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 205 );
    __NINDEX = GetLocalLastModifiedArrayIndex ( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 207 );
    FormatString(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),LOCAL_STRING_STRUCT( __FN_DST_STR__ ) ,2,"%s", GetStringArrayElement(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),GLOBAL_STRING_ARRAY(S2_Fusion_SSI_Device_Usage_Helper_v1_1,__ASSET_NAME$),__NINDEX) );
FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETNAME$  ,2 , "%s"  , __FN_DST_STR__ ) ; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_2:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00003 /*Asset_Type_Direct$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 214 );
    __NINDEX = GetLocalLastModifiedArrayIndex ( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 216 );
    FormatString(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),LOCAL_STRING_STRUCT( __FN_DST_STR__ ) ,2,"%s", GetStringArrayElement(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),GLOBAL_STRING_ARRAY(S2_Fusion_SSI_Device_Usage_Helper_v1_1,__ASSET_TYPE_DIRECT$),__NINDEX) );
FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETTYPE$  ,2 , "%s"  , __FN_DST_STR__ ) ; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_3:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00004 /*Asset_Name_Direct$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 223 );
    __NINDEX = GetLocalLastModifiedArrayIndex ( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 225 );
    FormatString(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),LOCAL_STRING_STRUCT( __FN_DST_STR__ ) ,2,"%s", GetStringArrayElement(INSTANCE_PTR(S2_Fusion_SSI_Device_Usage_Helper_v1_1),GLOBAL_STRING_ARRAY(S2_Fusion_SSI_Device_Usage_Helper_v1_1,__ASSET_NAME_DIRECT$),__NINDEX) );
FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , (struct StringHdr_s* )& GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )-> STRUCTUREDEVICE__SASSETNAME$  ,2 , "%s"  , __FN_DST_STR__ ) ; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00005 /*Device_In_Use_Held*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 232 );
    __NINDEX = GetLocalLastModifiedArrayIndex ( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 234 );
    GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NINUSE = 1; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_5:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00006 /*Device_In_Use_Held*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 241 );
    __NINDEX = GetLocalLastModifiedArrayIndex ( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 243 );
    if ( (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NINUSE == 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 245 );
        GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NINUSE = 0; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 246 );
        if ( ((GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES > 0) || (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS > 0))) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 248 );
            S2_Fusion_SSI_Device_Usage_Helper_v1_1__FNTRANSMITUSAGEDATA ( __NINDEX, 1) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 249 );
            GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES = 0; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 250 );
            GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS = 0; 
            } 
        
        } 
    
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_6:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00007 /*Clock_b*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 259 );
    __FN_FOREND_VAL__1 = 16; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __NINDEX = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__NINDEX  <= __FN_FOREND_VAL__1 ) : ((short)__NINDEX  >= __FN_FOREND_VAL__1) ; __NINDEX  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 261 );
        if ( (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NINUSE == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 263 );
            GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS = (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS + 30); 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 264 );
            if ( (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS > 59)) 
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 266 );
                GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES = (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES + 1); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 267 );
                GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS = (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS - 60); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 268 );
                SetOutputArrayElement ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), &Globals->S2_Fusion_SSI_Device_Usage_Helper_v1_1.__CURRENT_USAGE_MINUTES_FB ,__NINDEX, GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES) ; 
                } 
            
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 259 );
        } 
    
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_7:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00008 /*Restart_Counters*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __NINDEX; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 278 );
    __FN_FOREND_VAL__1 = 16; 
    __FN_FORINIT_VAL__1 = 1; 
    for( __NINDEX = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__NINDEX  <= __FN_FOREND_VAL__1 ) : ((short)__NINDEX  >= __FN_FOREND_VAL__1) ; __NINDEX  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 280 );
        if ( (GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NINUSE == 1)) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 282 );
            S2_Fusion_SSI_Device_Usage_Helper_v1_1__FNTRANSMITUSAGEDATA ( __NINDEX, 2) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 285 );
            GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTMINUTES = 0; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 286 );
            GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __NINDEX )->STRUCTUREDEVICE__NCURRENTSECONDS = 0; 
            } 
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 278 );
        } 
    
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__Event_8:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}


    
    

/********************************************************************************
  Constructor
********************************************************************************/
int S2_Fusion_SSI_Device_Usage_Helper_v1_1_STRUCTUREDEVICE_Constructor ( START_STRUCTURE_DEFINITION( S2_Fusion_SSI_Device_Usage_Helper_v1_1, STRUCTUREDEVICE ) * me, int nVerbose )
{
    InitStringStruct( (struct StringHdr_s* ) &me->STRUCTUREDEVICE__SASSETTYPE$, e_INPUT_TYPE_NONE, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_1_SASSETTYPE$_STRING_MAX_LEN, "STRUCTUREDEVICE__SASSETTYPE$" );
    InitStringStruct( (struct StringHdr_s* ) &me->STRUCTUREDEVICE__SASSETNAME$, e_INPUT_TYPE_NONE, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_1_SASSETNAME$_STRING_MAX_LEN, "STRUCTUREDEVICE__SASSETNAME$" );
    InitStringStruct( (struct StringHdr_s* ) &me->STRUCTUREDEVICE__SASSETID$, e_INPUT_TYPE_NONE, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_1_SASSETID$_STRING_MAX_LEN, "STRUCTUREDEVICE__SASSETID$" );
    return 0;
}

/********************************************************************************
  Destructor
********************************************************************************/
int S2_Fusion_SSI_Device_Usage_Helper_v1_1_STRUCTUREDEVICE_Destructor ( START_STRUCTURE_DEFINITION( S2_Fusion_SSI_Device_Usage_Helper_v1_1, STRUCTUREDEVICE ) * me, int nVerbose )
{
    return 0;
}

/********************************************************************************
  static void ProcessDigitalEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessDigitalEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_CLOCK_B_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00007 /*Clock_b*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
                
            }
            break;
            
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_RESTART_COUNTERS_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00008 /*Restart_Counters*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
                
            }
            break;
            
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_DEVICE_IN_USE_HELD_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00005 /*Device_In_Use_Held*/, 0 );
                
            }
            else /*Release*/
            {
                SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00006 /*Device_In_Use_Held*/, 0 );
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_MEETING_ID$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00000 /*Meeting_ID$*/, 1 );
            break;
            
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00001 /*Asset_Type$*/, 0 );
            break;
            
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00002 /*Asset_Name$*/, 0 );
            break;
            
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE_DIRECT$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00003 /*Asset_Type_Direct$*/, 0 );
            break;
            
        case __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME_DIRECT$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1, 00004 /*Asset_Name_Direct$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1 )
********************************************************************************/
EVENT_HANDLER( S2_Fusion_SSI_Device_Usage_Helper_v1_1 )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __DEVICE_IN_USE_HELD ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_ID$ ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_TYPE$ ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_NAME$ ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_TYPE_DIRECT$ ) ;
    CHECK_STRING_INPUT_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_NAME_DIRECT$ ) ;
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
  FUNCTION_MAIN( S2_Fusion_SSI_Device_Usage_Helper_v1_1 )
********************************************************************************/
FUNCTION_MAIN( S2_Fusion_SSI_Device_Usage_Helper_v1_1 )
{
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M1 );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M2, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M2 );
    
    CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M3, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M3 );
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Fusion_SSI_Device_Usage_Helper_v1_1 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR___M, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR___M1, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR___M2, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __FN_DST_STR___M3 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR___M3, 50 );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __DEVICE_IN_USE_HELD, IO_TYPE_DIGITAL_INPUT, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_DEVICE_IN_USE_HELD_DIG_INPUT, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_DEVICE_IN_USE_HELD_ARRAY_LENGTH );
    INITIALIZE_IO_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __CURRENT_USAGE_MINUTES_FB, IO_TYPE_ANALOG_OUTPUT, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_CURRENT_USAGE_MINUTES_FB_ANALOG_OUTPUT, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_CURRENT_USAGE_MINUTES_FB_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __MEETING_ID$, e_INPUT_TYPE_STRING, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_MEETING_ID$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __MEETING_ID$, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_MEETING_ID$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_ID$, e_INPUT_TYPE_STRING, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_ID$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_ID$_ARRAY_NUM_CHARS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_ID$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_ID$ );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_TYPE$, e_INPUT_TYPE_STRING, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE$_ARRAY_NUM_CHARS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_TYPE$ );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_NAME$, e_INPUT_TYPE_STRING, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME$_ARRAY_NUM_CHARS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_NAME$ );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_TYPE_DIRECT$, e_INPUT_TYPE_STRING, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE_DIRECT$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE_DIRECT$_ARRAY_NUM_CHARS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_TYPE_DIRECT$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_TYPE_DIRECT$ );
    INITIALIZE_GLOBAL_STRING_INPUT_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_NAME_DIRECT$, e_INPUT_TYPE_STRING, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME_DIRECT$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME_DIRECT$_ARRAY_NUM_CHARS, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_ASSET_NAME_DIRECT$_STRING_INPUT );
    REGISTER_GLOBAL_INPUT_STRING_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __ASSET_NAME_DIRECT$ );
    INITIALIZE_GLOBAL_STRUCT_ARRAY ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_G_ODEVICES_STRUCT_MAX_LEN );
    
    {
        unsigned short i = 0;
        for( i = 0; i <= 16; i++ )
        {
            InitStringStruct( (struct StringHdr_s* ) & GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, i )->STRUCTUREDEVICE__SASSETTYPE$, e_INPUT_TYPE_NONE, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_1_SASSETTYPE$_STRING_MAX_LEN, "STRUCTUREDEVICE__SASSETTYPE$" );
            InitStringStruct( (struct StringHdr_s* ) & GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, i )->STRUCTUREDEVICE__SASSETNAME$, e_INPUT_TYPE_NONE, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_1_SASSETNAME$_STRING_MAX_LEN, "STRUCTUREDEVICE__SASSETNAME$" );
            InitStringStruct( (struct StringHdr_s* ) & GET_GLOBAL_STRUCTARRAY_ELEMENT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_ODEVICES, STRUCTUREDEVICE, i )->STRUCTUREDEVICE__SASSETID$, e_INPUT_TYPE_NONE, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_1_SASSETID$_STRING_MAX_LEN, "STRUCTUREDEVICE__SASSETID$" );
            
        }
    }
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SPREVIOUSMEETINGID$, e_INPUT_TYPE_NONE, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_G_SPREVIOUSMEETINGID$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTMEETINGID$, e_INPUT_TYPE_NONE, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_G_SCURRENTMEETINGID$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$, e_INPUT_TYPE_NONE, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_G_SCURRENTDATE$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCOMPAREDATE$, e_INPUT_TYPE_NONE, __S2_Fusion_SSI_Device_Usage_Helper_v1_1_G_SCOMPAREDATE$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Fusion_SSI_Device_Usage_Helper_v1_1, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 295 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 297 );
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M1 )    ,2 , "%s"  , Date (  LOCAL_STRING_STRUCT( __FN_DST_STR___M )    , 3)  )  ; 
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )   ,2 , "%s"  , __FN_DST_STR___M1 ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 298 );
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M3 )    ,8 , "%s-%s-%s"  , Left ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M )    , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )  , 4) , Mid ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M1 )    , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )  , 6, 2) , Right ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M2 )    , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )  , 2)  )  ; 
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCURRENTDATE$  )   ,2 , "%s"  , __FN_DST_STR___M3 ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ), 299 );
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR___M1 )    ,2 , "%s"  , Date (  LOCAL_STRING_STRUCT( __FN_DST_STR___M )    , 3)  )  ; 
    FormatString ( INSTANCE_PTR( S2_Fusion_SSI_Device_Usage_Helper_v1_1 ) , GLOBAL_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_1, __G_SCOMPAREDATE$  )   ,2 , "%s"  , __FN_DST_STR___M1 ) ; 
    
    S2_Fusion_SSI_Device_Usage_Helper_v1_1_Exit__MAIN:/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR___M );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR___M1 );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR___M2 );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR___M3 );
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }

