#ifndef __S2_SHARP_LC_32D64U_PROCESSOR_V1_0_H__
#define __S2_SHARP_LC_32D64U_PROCESSOR_V1_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Sharp_LC_32D64U_Processor_v1_0_AIR_DIG_INPUT 0
#define __S2_Sharp_LC_32D64U_Processor_v1_0_CABLE_DIG_INPUT 1

#define __S2_Sharp_LC_32D64U_Processor_v1_0_KP_DIG_INPUT 2
#define __S2_Sharp_LC_32D64U_Processor_v1_0_KP_ARRAY_LENGTH 13

/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Sharp_LC_32D64U_Processor_v1_0_NUMBER$_STRING_OUTPUT 0
#define __S2_Sharp_LC_32D64U_Processor_v1_0_TO_DEVICE$_STRING_OUTPUT 1


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
#define __S2_Sharp_LC_32D64U_Processor_v1_0_SNUMBER_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0, __SNUMBER, __S2_Sharp_LC_32D64U_Processor_v1_0_SNUMBER_STRING_MAX_LEN );
#define __S2_Sharp_LC_32D64U_Processor_v1_0_SCHANNELF_STRING_MAX_LEN 9
CREATE_STRING_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0, __SCHANNELF, __S2_Sharp_LC_32D64U_Processor_v1_0_SCHANNELF_STRING_MAX_LEN );
#define __S2_Sharp_LC_32D64U_Processor_v1_0_SCHANNELR_STRING_MAX_LEN 9
CREATE_STRING_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0, __SCHANNELR, __S2_Sharp_LC_32D64U_Processor_v1_0_SCHANNELR_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __KP );
   unsigned short __ALOC;
   DECLARE_STRING_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0, __SNUMBER );
   DECLARE_STRING_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0, __SCHANNELF );
   DECLARE_STRING_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0, __SCHANNELR );
};

START_NVRAM_VAR_STRUCT( S2_Sharp_LC_32D64U_Processor_v1_0 )
{
};



#endif //__S2_SHARP_LC_32D64U_PROCESSOR_V1_0_H__

