#ifndef __S2_EXTRON_AV_ROUTER_H__
#define __S2_EXTRON_AV_ROUTER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_Extron_AV_Router_INDECIMAL_ANALOG_INPUT 0




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Extron_AV_Router_TX$_STRING_OUTPUT 0


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_Extron_AV_Router_OUTPUT_INTEGER_PARAMETER 10
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
#define __S2_Extron_AV_Router_ROUTETYPE_STRING_PARAMETER 11
#define __S2_Extron_AV_Router_ROUTETYPE_PARAM_MAX_LEN 1
CREATE_STRING_STRUCT( S2_Extron_AV_Router, __ROUTETYPE, __S2_Extron_AV_Router_ROUTETYPE_PARAM_MAX_LEN );


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

START_GLOBAL_VAR_STRUCT( S2_Extron_AV_Router )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Extron_AV_Router, __ROUTETYPE );
};

START_NVRAM_VAR_STRUCT( S2_Extron_AV_Router )
{
};



#endif //__S2_EXTRON_AV_ROUTER_H__

