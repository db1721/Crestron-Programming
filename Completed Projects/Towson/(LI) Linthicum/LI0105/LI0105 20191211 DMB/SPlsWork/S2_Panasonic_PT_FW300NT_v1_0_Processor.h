#ifndef __S2_PANASONIC_PT_FW300NT_V1_0_PROCESSOR_H__
#define __S2_PANASONIC_PT_FW300NT_V1_0_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_LAMP_REQUESTED_DIG_INPUT 0
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_LAMP_STATUS_REQUESTED_DIG_INPUT 1
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_BRIGHTNESS_REQUESTED_DIG_INPUT 2
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_CONTRAST_REQUESTED_DIG_INPUT 3
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_VOLUME_REQUESTED_DIG_INPUT 4
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_BRIGHTNESS_ADJUST_DIG_INPUT 5
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_CONTRAST_ADJUST_DIG_INPUT 6
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_VOLUME_ADJUST_DIG_INPUT 7


/*
* ANALOG_INPUT
*/
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_BRIGHTNESS_IN_ANALOG_INPUT 0
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_CONTRAST_IN_ANALOG_INPUT 1
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_VOLUME_IN_ANALOG_INPUT 2

#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_FROM_DEVICE_STRING_INPUT 3
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_FROM_DEVICE_STRING_MAX_LEN 255
CREATE_STRING_STRUCT( S2_Panasonic_PT_FW300NT_v1_0_Processor, __FROM_DEVICE, __S2_Panasonic_PT_FW300NT_v1_0_Processor_FROM_DEVICE_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_LAMP_HOURS_ANALOG_OUTPUT 0
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_LAMP_STATUS_ANALOG_OUTPUT 1
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_BRIGHTNESS_OUT_ANALOG_OUTPUT 2
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_CONTRAST_OUT_ANALOG_OUTPUT 3
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_VOLUME_OUT_ANALOG_OUTPUT 4

#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_TO_DEVICE_STRING_OUTPUT 5


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
#define __S2_Panasonic_PT_FW300NT_v1_0_Processor_STEMP$_STRING_MAX_LEN 254
CREATE_STRING_STRUCT( S2_Panasonic_PT_FW300NT_v1_0_Processor, __STEMP$, __S2_Panasonic_PT_FW300NT_v1_0_Processor_STEMP$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Panasonic_PT_FW300NT_v1_0_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Panasonic_PT_FW300NT_v1_0_Processor, __FROM_DEVICE );
};

START_NVRAM_VAR_STRUCT( S2_Panasonic_PT_FW300NT_v1_0_Processor )
{
   DECLARE_STRING_STRUCT( S2_Panasonic_PT_FW300NT_v1_0_Processor, __STEMP$ );
   unsigned short __IBUSYFLAG;
   short __BRIGHTNESS_VALUE;
};



#endif //__S2_PANASONIC_PT_FW300NT_V1_0_PROCESSOR_H__

