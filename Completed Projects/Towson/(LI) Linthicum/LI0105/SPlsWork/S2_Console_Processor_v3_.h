#ifndef __S2_CONSOLE_PROCESSOR_V3__H__
#define __S2_CONSOLE_PROCESSOR_V3__H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Console_Processor_v3__DEBUG_DIG_INPUT 0
#define __S2_Console_Processor_v3__EN_CREATE_NVRAMDISK_DIG_INPUT 1
#define __S2_Console_Processor_v3__GET_OS_INFO_DIG_INPUT 2
#define __S2_Console_Processor_v3__GET_PROGRAM_INFO_DIG_INPUT 3
#define __S2_Console_Processor_v3__GET_ETHER_INFO_DIG_INPUT 4
#define __S2_Console_Processor_v3__CHECK_NVRAMDISK_DIG_INPUT 5


/*
* ANALOG_INPUT
*/


#define __S2_Console_Processor_v3__CONSOLE_RX$_BUFFER_INPUT 0
#define __S2_Console_Processor_v3__CONSOLE_RX$_BUFFER_MAX_LEN 5000
CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$, __S2_Console_Processor_v3__CONSOLE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Console_Processor_v3__LINK_STATUS_DIG_OUTPUT 0
#define __S2_Console_Processor_v3__NVRAMDISK_PRESENT_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/
#define __S2_Console_Processor_v3__MODULE_STATUS_ANALOG_OUTPUT 0

#define __S2_Console_Processor_v3__CONSOLE_TX$_STRING_OUTPUT 1
#define __S2_Console_Processor_v3__OS_VERSION$_STRING_OUTPUT 2
#define __S2_Console_Processor_v3__PROGRAM_FILE$_STRING_OUTPUT 3
#define __S2_Console_Processor_v3__LINK_SPEED$_STRING_OUTPUT 4
#define __S2_Console_Processor_v3__FULL_DUPLEX$_STRING_OUTPUT 5
#define __S2_Console_Processor_v3__MAC_ADDRESS$_STRING_OUTPUT 6
#define __S2_Console_Processor_v3__IP_ADDRESS$_STRING_OUTPUT 7
#define __S2_Console_Processor_v3__HOST_NAME$_STRING_OUTPUT 8
#define __S2_Console_Processor_v3__NVRAMDISK_STATUS$_STRING_OUTPUT 9


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
#define __S2_Console_Processor_v3__G_STEMPDATA_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_Console_Processor_v3_, __G_STEMPDATA, __S2_Console_Processor_v3__G_STEMPDATA_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Console_Processor_v3_ )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __G_BRXOK;
   unsigned short __G_IDATAMODE;
   unsigned short __G_BNEEDTOCREATENVRAMDISK;
   DECLARE_STRING_STRUCT( S2_Console_Processor_v3_, __G_STEMPDATA );
   DECLARE_STRING_STRUCT( S2_Console_Processor_v3_, __CONSOLE_RX$ );
};

START_NVRAM_VAR_STRUCT( S2_Console_Processor_v3_ )
{
};



#endif //__S2_CONSOLE_PROCESSOR_V3__H__

