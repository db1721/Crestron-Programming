#ifndef __S2_EPSON_POWERLITE_PRO_G5650W_PROCESSOR_V1_0_H__
#define __S2_EPSON_POWERLITE_PRO_G5650W_PROCESSOR_V1_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/


#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_FROM_DEVICE$_BUFFER_INPUT 0
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_FROM_DEVICE$_BUFFER_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0, __FROM_DEVICE$, __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_FROM_DEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_CONTRAST_ANALOG_OUTPUT 0
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_BRIGHTNESS_ANALOG_OUTPUT 1
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_COLOR_ANALOG_OUTPUT 2
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_TINT_ANALOG_OUTPUT 3
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_SHARPNESS_ANALOG_OUTPUT 4
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_VOLUME_ANALOG_OUTPUT 5
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_LAMP_ANALOG_OUTPUT 6



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
#define __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_TEMP$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0, __TEMP$, __S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0_TEMP$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __SEMAPHORE;
   DECLARE_STRING_STRUCT( S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0, __TEMP$ );
   DECLARE_STRING_STRUCT( S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0, __FROM_DEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Epson_PowerLite_Pro_G5650W_Processor_v1_0 )
{
};



#endif //__S2_EPSON_POWERLITE_PRO_G5650W_PROCESSOR_V1_0_H__

