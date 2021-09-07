#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_APAD_Long_Text_Edit.h"

FUNCTION_MAIN( S2_APAD_Long_Text_Edit );
EVENT_HANDLER( S2_APAD_Long_Text_Edit );
DEFINE_ENTRYPOINT( S2_APAD_Long_Text_Edit );


static void S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( unsigned short __NEWCURSORPOSITION ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 44 );
    if ( (__NEWCURSORPOSITION > 0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 45 );
        Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = __NEWCURSORPOSITION; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 47 );
        Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = 1; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 48 );
    if ( (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION > GetAnalogInput( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_MAXCHARACTERSINDISPLAY_ANALOG_INPUT ))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 50 );
        SetAnalog ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_CURSORPOSITIONOUT_ANALOG_OUTPUT, GetAnalogInput( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_MAXCHARACTERSINDISPLAY_ANALOG_INPUT )) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 53 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , ((Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - GetAnalogInput( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_MAXCHARACTERSINDISPLAY_ANALOG_INPUT )) + 1), GetAnalogInput( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_MAXCHARACTERSINDISPLAY_ANALOG_INPUT ))  )  ; 
        SetSerial( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_TEXTEDIT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 58 );
        SetAnalog ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_CURSORPOSITIONOUT_ANALOG_OUTPUT, Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 59 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit )  ,2 , "%s"  , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_TEXTEDIT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); }
        
        ; 
        } 
    
    
    S2_APAD_Long_Text_Edit_Exit__OUTPUTTEXTANDUPDATECURSORPOSITION:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    /* End Free local function variables */
    
    }
    
static void S2_APAD_Long_Text_Edit__UPDATEDISPLAYTEXT ( ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 65 );
    SetString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , Mid ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SELECTION$  )  , Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION, 1) , Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION, GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 66 );
    S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
    
    S2_APAD_Long_Text_Edit_Exit__UPDATEDISPLAYTEXT:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    /* End Free local function variables */
    
    }
    
static void S2_APAD_Long_Text_Edit__SETNEWSELECTIONPOSITION ( ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 71 );
    Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = Find( Mid( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , LOCAL_STRING_STRUCT( __FN_DST_STR__ )  , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION , 1 ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SELECTION$  )  , 1 , 1 ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 72 );
    if ( (Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION == 0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 73 );
        Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = 1; 
        }
    
    
    S2_APAD_Long_Text_Edit_Exit__SETNEWSELECTIONPOSITION:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    /* End Free local function variables */
    
    }
    
static void S2_APAD_Long_Text_Edit__INSERTSPCTORIGHT ( ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 79 );
    if ( (Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) < Globals->S2_APAD_Long_Text_Edit.__IMAXNEWTEXTLENGTH)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 81 );
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    ,6 , "%s%s%s"  , Left ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   ,  Right ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) - Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION))  )  ; 
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__2 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 82 );
        Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION + 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 83 );
        S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
        } 
    
    
    S2_APAD_Long_Text_Edit_Exit__INSERTSPCTORIGHT:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
    /* End Free local function variables */
    
    }
    
static void S2_APAD_Long_Text_Edit__INSERTSPCTOLEFT ( ) 
    { 
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 90 );
    if ( (Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) < Globals->S2_APAD_Long_Text_Edit.__IMAXNEWTEXTLENGTH)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 92 );
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    ,6 , "%s%s%s"  , Left ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - 1)) ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )   ,  Right ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , ((Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) - Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) + 1))  )  ; 
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__2 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 93 );
        S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
        } 
    
    
    S2_APAD_Long_Text_Edit_Exit__INSERTSPCTOLEFT:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
    /* End Free local function variables */
    
    }
    
static void S2_APAD_Long_Text_Edit__SETMAXTEXTLENGTH ( ) 
    { 
    /* Begin local function variable declarations */
    
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 99 );
    if ( (GetAnalogInput( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_MAXNEWTEXTLENGTH_ANALOG_INPUT ) > 100)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 101 );
        ExtendedErrorUserSpecified( eERROR_LEVEL_ERROR, INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , 81, "MaxNewTextLength set to value greater than MAX_TEXT_LENGTH, truncating (%d > %d).", (short)( GetAnalogInput( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_MAXNEWTEXTLENGTH_ANALOG_INPUT ) ), (short)( 100 )) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 102 );
        Globals->S2_APAD_Long_Text_Edit.__IMAXNEWTEXTLENGTH = 100; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 106 );
        Globals->S2_APAD_Long_Text_Edit.__IMAXNEWTEXTLENGTH = GetAnalogInput( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_MAXNEWTEXTLENGTH_ANALOG_INPUT ); 
        } 
    
    
    S2_APAD_Long_Text_Edit_Exit__SETMAXTEXTLENGTH:
/* Begin Free local function variables */
    /* End Free local function variables */
    
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00000 /*NextCharInSelection*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 113 );
    if ( (Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION < Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SELECTION$  )  ))) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 114 );
        Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = (Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION + 1); 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 116 );
        Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = 1; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 118 );
    S2_APAD_Long_Text_Edit__UPDATEDISPLAYTEXT ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_0:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00001 /*PrevCharInSelection*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 124 );
    if ( (Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION > 1)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 125 );
        Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = (Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION - 1); 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 127 );
        Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SELECTION$  )  ); 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 129 );
    S2_APAD_Long_Text_Edit__UPDATEDISPLAYTEXT ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_1:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00002 /*NextCharInText*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 134 );
    if ( (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION < Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ))) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 137 );
        Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION + 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 138 );
        S2_APAD_Long_Text_Edit__SETNEWSELECTIONPOSITION ( ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 139 );
        S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 144 );
        S2_APAD_Long_Text_Edit__INSERTSPCTORIGHT ( ) ; 
        } 
    
    
    S2_APAD_Long_Text_Edit_Exit__Event_2:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00003 /*PrevCharInText*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 150 );
    if ( (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION > 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 152 );
        Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 153 );
        S2_APAD_Long_Text_Edit__SETNEWSELECTIONPOSITION ( ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 154 );
        S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
        } 
    
    
    S2_APAD_Long_Text_Edit_Exit__Event_3:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00004 /*Text$*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __TEMP; 
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 166 );
    if ( (Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXT$  )  ) < Globals->S2_APAD_Long_Text_Edit.__IMAXNEWTEXTLENGTH)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 167 );
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,4 , "%s%s"  , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXT$  )  ,   LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 169 );
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,2 , "%s"  , Left ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXT$  )  , Globals->S2_APAD_Long_Text_Edit.__IMAXNEWTEXTLENGTH)  )  ; 
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        }
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 170 );
    __TEMP = Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 171 );
    S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( __TEMP) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 172 );
    S2_APAD_Long_Text_Edit__SETNEWSELECTIONPOSITION ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00005 /*Backspace*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 179 );
    if ( (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION > 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 181 );
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    ,4 , "%s%s"  , Left ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - 2)) ,  Right ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , ((Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) - Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) + 1))  )  ; 
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__2 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 182 );
        Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - 1); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 183 );
        S2_APAD_Long_Text_Edit__SETNEWSELECTIONPOSITION ( ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 184 );
        S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
        } 
    
    
    S2_APAD_Long_Text_Edit_Exit__Event_5:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00006 /*DeleteChar*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 100 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 192 );
    if ( (Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) == 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 194 );
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 195 );
        S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( 1) ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 199 );
        if ( (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION == Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ))) 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 201 );
            FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    ,4 , "%s%s"  , Left ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - 1)) ,  Right ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) - Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION))  )  ; 
            FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__2 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 202 );
            S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - 1)) ; 
            } 
        
        else 
            { 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 206 );
            FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    ,4 , "%s%s"  , Left ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION - 1)) ,  Right ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) - Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION))  )  ; 
            FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__2 ) ; 
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 207 );
            S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION) ; 
            } 
        
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 211 );
    S2_APAD_Long_Text_Edit__SETNEWSELECTIONPOSITION ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_6:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00007 /*Done*/ )

    {
    /* Begin local function variable declarations */
    
    unsigned short  __I; 
    unsigned short  __FIRST; 
    unsigned short  __LAST; 
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    short __FN_FOREND_VAL__2; 
    short __FN_FORINIT_VAL__2; 
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 219 );
    __FIRST = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 220 );
    __LAST = Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 222 );
    __FN_FOREND_VAL__1 = Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ); 
    __FN_FORINIT_VAL__1 = 1; 
    for( __I = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__1 ) : ((short)__I  >= __FN_FOREND_VAL__1) ; __I  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 224 );
        if ( (Byte( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , __I ) != 32)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 225 );
            break ; 
            }
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 227 );
            __FIRST = (__FIRST + 1); 
            }
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 222 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 230 );
    __FN_FOREND_VAL__2 = 1; 
    __FN_FORINIT_VAL__2 = -( 1 ); 
    for( __I = Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ); (__FN_FORINIT_VAL__2 > 0)  ? ((short)__I  <= __FN_FOREND_VAL__2 ) : ((short)__I  >= __FN_FOREND_VAL__2) ; __I  += __FN_FORINIT_VAL__2) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 232 );
        if ( (Byte( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , __I ) != 32)) 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 233 );
            break ; 
            }
        
        else 
            {
            UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 235 );
            __LAST = (__LAST - 1); 
            }
        
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 230 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 238 );
    if ( (__FIRST > __LAST)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 241 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit )  ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
        SetSerial( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_FINALTEXT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); }
        
        ; 
        } 
    
    else 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 246 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit )  ,2 , "%s"  , Mid ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , __FIRST, ((__LAST - __FIRST) + 1))  )  ; 
        SetSerial( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_FINALTEXT$_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_APAD_Long_Text_Edit ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); }
        
        ; 
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 249 );
    Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 250 );
    Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = 1; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_7:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00008 /*Cancel*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 255 );
    FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXT$  )   )  ; 
    FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 256 );
    Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 257 );
    SetAnalog ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_CURSORPOSITIONOUT_ANALOG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 258 );
    Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = 1; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_8:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00009 /*Clear*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( " " ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__, 100 );
    DECLARE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, " " );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 100 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 263 );
    FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  ,  LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )    )  ; 
    FormatString ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 264 );
    S2_APAD_Long_Text_Edit__OUTPUTTEXTANDUPDATECURSORPOSITION ( 1) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_9:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000A /*InsertSpaceToRight*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 271 );
    S2_APAD_Long_Text_Edit__INSERTSPCTORIGHT ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_10:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000B /*InsertSpaceToLeft*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 278 );
    S2_APAD_Long_Text_Edit__INSERTSPCTOLEFT ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_11:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000C /*Debug*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 283 );
    Print( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , 77, "\r\nTextIntermediate$ <%s>, %d chars. CursorPosition=%d, SelectionPosition=%d\r\n", GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  , (short)( Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$  )  ) ), (short)( Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION ), (short)( Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION )) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 284 );
    Print( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) , 50, "Selection$ <%s>, %d chars.  Text$ <%s>, %d chars\r\n", GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SELECTION$  )  , (short)( Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __SELECTION$  )  ) ), GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXT$  )  , (short)( Len( GLOBAL_STRING_STRUCT( S2_APAD_Long_Text_Edit, __TEXT$  )  ) )) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_12:
    /* Begin Free local function variables */
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000D /*MaxNewTextLength*/ )

    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 289 );
    S2_APAD_Long_Text_Edit__SETMAXTEXTLENGTH ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__Event_13:
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
        case __S2_APAD_Long_Text_Edit_NEXTCHARINSELECTION_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00000 /*NextCharInSelection*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_PREVCHARINSELECTION_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00001 /*PrevCharInSelection*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_NEXTCHARINTEXT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00002 /*NextCharInText*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_PREVCHARINTEXT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00003 /*PrevCharInText*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_BACKSPACE_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00005 /*Backspace*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_DELETECHAR_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00006 /*DeleteChar*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_DONE_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00007 /*Done*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_CANCEL_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00008 /*Cancel*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_CLEAR_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00009 /*Clear*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_INSERTSPACETORIGHT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000A /*InsertSpaceToRight*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_INSERTSPACETOLEFT_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000B /*InsertSpaceToLeft*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        case __S2_APAD_Long_Text_Edit_DEBUG_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000C /*Debug*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
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
        case __S2_APAD_Long_Text_Edit_MAXNEWTEXTLENGTH_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 0000D /*MaxNewTextLength*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_APAD_Long_Text_Edit ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_APAD_Long_Text_Edit_TEXT$_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_APAD_Long_Text_Edit, 00004 /*Text$*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_APAD_Long_Text_Edit ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
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
            SetSymbolEventStart ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_APAD_Long_Text_Edit )
********************************************************************************/
EVENT_HANDLER( S2_APAD_Long_Text_Edit )
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
  FUNCTION_MAIN( S2_APAD_Long_Text_Edit )
********************************************************************************/
FUNCTION_MAIN( S2_APAD_Long_Text_Edit )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_APAD_Long_Text_Edit );
    
    
    /* End local function variable declarations */
    
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_APAD_Long_Text_Edit, __SELECTION$, e_INPUT_TYPE_STRING, __S2_APAD_Long_Text_Edit_SELECTION$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_APAD_Long_Text_Edit, __SELECTION$, __S2_APAD_Long_Text_Edit_SELECTION$_STRING_INPUT );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_APAD_Long_Text_Edit, __TEXT$, e_INPUT_TYPE_STRING, __S2_APAD_Long_Text_Edit_TEXT$_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_APAD_Long_Text_Edit, __TEXT$, __S2_APAD_Long_Text_Edit_TEXT$_STRING_INPUT );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_APAD_Long_Text_Edit, __TEXTINTERMEDIATE$, e_INPUT_TYPE_NONE, __S2_APAD_Long_Text_Edit_TEXTINTERMEDIATE$_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_APAD_Long_Text_Edit, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 294 );
    Globals->S2_APAD_Long_Text_Edit.__CURSORPOSITION = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 295 );
    SetAnalog ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), __S2_APAD_Long_Text_Edit_CURSORPOSITIONOUT_ANALOG_OUTPUT, 0) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 296 );
    Globals->S2_APAD_Long_Text_Edit.__SELECTIONPOSITION = 1; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 297 );
    WaitForInitializationComplete ( INSTANCE_PTR( S2_APAD_Long_Text_Edit ) ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_APAD_Long_Text_Edit ), 298 );
    S2_APAD_Long_Text_Edit__SETMAXTEXTLENGTH ( ) ; 
    
    S2_APAD_Long_Text_Edit_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
