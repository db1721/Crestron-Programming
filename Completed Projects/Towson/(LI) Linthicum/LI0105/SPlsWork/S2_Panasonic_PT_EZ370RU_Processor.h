#ifndef __S2_PANASONIC_PT_EZ370RU_PROCESSOR_H__
#define __S2_PANASONIC_PT_EZ370RU_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Panasonic_PT_EZ370RU_Processor_LAMP_REQUESTED_DIG_INPUT 0


/*
* ANALOG_INPUT
*/

#define __S2_Panasonic_PT_EZ370RU_Processor_FROM_DEVICE_STRING_INPUT 0
#define __S2_Panasonic_PT_EZ370RU_Processor_FROM_DEVICE_STRING_MAX_LEN 255
CREATE_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FROM_DEVICE, __S2_Panasonic_PT_EZ370RU_Processor_FROM_DEVICE_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Panasonic_PT_EZ370RU_Processor_LAMP_HOURS_ANALOG_OUTPUT 0



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

START_GLOBAL_VAR_STRUCT( S2_Panasonic_PT_EZ370RU_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Panasonic_PT_EZ370RU_Processor, __FROM_DEVICE );
};

START_NVRAM_VAR_STRUCT( S2_Panasonic_PT_EZ370RU_Processor )
{
};



#endif //__S2_PANASONIC_PT_EZ370RU_PROCESSOR_H__

