#ifndef __S2_SERIAL_APPEND_H__
#define __S2_SERIAL_APPEND_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Serial_Append_SEND_DIG_INPUT 0


/*
* ANALOG_INPUT
*/

#define __S2_Serial_Append_INSTRING_STRING_INPUT 0
#define __S2_Serial_Append_INSTRING_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Serial_Append, __INSTRING, __S2_Serial_Append_INSTRING_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Serial_Append_OUTSTRING_STRING_OUTPUT 0


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
#define __S2_Serial_Append_PREFIX_STRING_PARAMETER 10
#define __S2_Serial_Append_SUFFIX_STRING_PARAMETER 11
#define __S2_Serial_Append_PREFIX_PARAM_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Serial_Append, __PREFIX, __S2_Serial_Append_PREFIX_PARAM_MAX_LEN );
#define __S2_Serial_Append_SUFFIX_PARAM_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Serial_Append, __SUFFIX, __S2_Serial_Append_SUFFIX_PARAM_MAX_LEN );


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

START_GLOBAL_VAR_STRUCT( S2_Serial_Append )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Serial_Append, __INSTRING );
   DECLARE_STRING_STRUCT( S2_Serial_Append, __PREFIX );
   DECLARE_STRING_STRUCT( S2_Serial_Append, __SUFFIX );
};

START_NVRAM_VAR_STRUCT( S2_Serial_Append )
{
};



#endif //__S2_SERIAL_APPEND_H__

