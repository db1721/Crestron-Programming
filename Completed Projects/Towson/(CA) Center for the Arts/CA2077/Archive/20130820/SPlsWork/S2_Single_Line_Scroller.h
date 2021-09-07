#ifndef __S2_SINGLE_LINE_SCROLLER_H__
#define __S2_SINGLE_LINE_SCROLLER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Single_Line_Scroller_DICLEARBUFF_DIG_INPUT 0
#define __S2_Single_Line_Scroller_DISCROLLUP_DIG_INPUT 1
#define __S2_Single_Line_Scroller_DISCROLLDN_DIG_INPUT 2
#define __S2_Single_Line_Scroller_DISCROLLLEFT_DIG_INPUT 3
#define __S2_Single_Line_Scroller_DISCROLLRIGHT_DIG_INPUT 4
#define __S2_Single_Line_Scroller_DIJUMPTOTOP_DIG_INPUT 5
#define __S2_Single_Line_Scroller_DIJUMPTOBOTTOM_DIG_INPUT 6


/*
* ANALOG_INPUT
*/
#define __S2_Single_Line_Scroller_AISCROLLHORIZONTALBY_ANALOG_INPUT 0
#define __S2_Single_Line_Scroller_AINUMCHARACTERSONDISPLAY_ANALOG_INPUT 1

#define __S2_Single_Line_Scroller_SICONSOLECOMMAND$_STRING_INPUT 2
#define __S2_Single_Line_Scroller_SICONSOLECOMMAND$_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Single_Line_Scroller, __SICONSOLECOMMAND$, __S2_Single_Line_Scroller_SICONSOLECOMMAND$_STRING_MAX_LEN );

#define __S2_Single_Line_Scroller_BIFROMCONSOLE$_BUFFER_INPUT 3
#define __S2_Single_Line_Scroller_BIFROMCONSOLE$_BUFFER_MAX_LEN 22000
CREATE_STRING_STRUCT( S2_Single_Line_Scroller, __BIFROMCONSOLE$, __S2_Single_Line_Scroller_BIFROMCONSOLE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Single_Line_Scroller_SOTODISPLAY$_STRING_OUTPUT 0
#define __S2_Single_Line_Scroller_SOTOCONSOLE$_STRING_OUTPUT 1


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_Single_Line_Scroller_G_CURRENTLINE$_STRING_MAX_LEN 130
CREATE_STRING_STRUCT( S2_Single_Line_Scroller, __G_CURRENTLINE$, __S2_Single_Line_Scroller_G_CURRENTLINE$_STRING_MAX_LEN );
#define __S2_Single_Line_Scroller_G_BLANKS$_STRING_MAX_LEN 130
CREATE_STRING_STRUCT( S2_Single_Line_Scroller, __G_BLANKS$, __S2_Single_Line_Scroller_G_BLANKS$_STRING_MAX_LEN );
#define __S2_Single_Line_Scroller_G_CONSOLEBUFFERCOPY$_STRING_MAX_LEN 22000
CREATE_STRING_STRUCT( S2_Single_Line_Scroller, __G_CONSOLEBUFFERCOPY$, __S2_Single_Line_Scroller_G_CONSOLEBUFFERCOPY$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Single_Line_Scroller )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __G_BUSYGETTINGDATA;
   unsigned short __G_FIRSTCHARINLINE;
   unsigned short __G_LASTCHARINLINE;
   unsigned short __G_DATAINITIALIZED;
   unsigned short __G_SCROLLSTARTPOSITION;
   unsigned short __G_CURRENTLINELENGTH;
   DECLARE_STRING_STRUCT( S2_Single_Line_Scroller, __G_CURRENTLINE$ );
   DECLARE_STRING_STRUCT( S2_Single_Line_Scroller, __G_BLANKS$ );
   DECLARE_STRING_STRUCT( S2_Single_Line_Scroller, __G_CONSOLEBUFFERCOPY$ );
   DECLARE_STRING_STRUCT( S2_Single_Line_Scroller, __SICONSOLECOMMAND$ );
   DECLARE_STRING_STRUCT( S2_Single_Line_Scroller, __BIFROMCONSOLE$ );
};

START_NVRAM_VAR_STRUCT( S2_Single_Line_Scroller )
{
};



#endif //__S2_SINGLE_LINE_SCROLLER_H__

