#ifndef __S2_STRING_HEADERFOOTER_H__
#define __S2_STRING_HEADERFOOTER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/

#define __S2_String_HeaderFooter_HEADER_STRING_INPUT 0
#define __S2_String_HeaderFooter_HEADER_STRING_MAX_LEN 250
CREATE_STRING_STRUCT( S2_String_HeaderFooter, __HEADER, __S2_String_HeaderFooter_HEADER_STRING_MAX_LEN );
#define __S2_String_HeaderFooter_MIDDLE_STRING_INPUT 1
#define __S2_String_HeaderFooter_MIDDLE_STRING_MAX_LEN 250
CREATE_STRING_STRUCT( S2_String_HeaderFooter, __MIDDLE, __S2_String_HeaderFooter_MIDDLE_STRING_MAX_LEN );
#define __S2_String_HeaderFooter_FOOTER_STRING_INPUT 2
#define __S2_String_HeaderFooter_FOOTER_STRING_MAX_LEN 250
CREATE_STRING_STRUCT( S2_String_HeaderFooter, __FOOTER, __S2_String_HeaderFooter_FOOTER_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_String_HeaderFooter_TX_STRING_OUTPUT 0


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

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_String_HeaderFooter )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_String_HeaderFooter, __HEADER );
   DECLARE_STRING_STRUCT( S2_String_HeaderFooter, __MIDDLE );
   DECLARE_STRING_STRUCT( S2_String_HeaderFooter, __FOOTER );
};

START_NVRAM_VAR_STRUCT( S2_String_HeaderFooter )
{
};



#endif //__S2_STRING_HEADERFOOTER_H__

