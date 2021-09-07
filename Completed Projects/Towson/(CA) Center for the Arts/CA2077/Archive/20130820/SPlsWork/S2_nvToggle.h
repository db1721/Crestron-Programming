#ifndef __S2_NVTOGGLE_H__
#define __S2_NVTOGGLE_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_nvToggle_SET_DIG_INPUT 0
#define __S2_nvToggle_CLOCK_DIG_INPUT 1
#define __S2_nvToggle_RESET_DIG_INPUT 2


/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/
#define __S2_nvToggle_OUT_DIG_OUTPUT 0
#define __S2_nvToggle_OUTNOT_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/



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

START_GLOBAL_VAR_STRUCT( S2_nvToggle )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

};

START_NVRAM_VAR_STRUCT( S2_nvToggle )
{
   unsigned short __HOLDSET;
   unsigned short __HOLDRESET;
};



#endif //__S2_NVTOGGLE_H__

