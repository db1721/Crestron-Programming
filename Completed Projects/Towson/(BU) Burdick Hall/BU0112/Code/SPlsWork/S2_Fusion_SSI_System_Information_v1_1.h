#ifndef __S2_FUSION_SSI_SYSTEM_INFORMATION_V1_1_H__
#define __S2_FUSION_SSI_SYSTEM_INFORMATION_V1_1_H__



/*
* STRUCTURE S2_Fusion_SSI_System_Information_v1_1__SYSTEM_INFO
*/
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_DHCP_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_MODEL_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_FIRMWARE_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_FIRMWARE_DATE_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_MAC_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_IP_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_HOSTNAME_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_SERIAL_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_UPTIME_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_PROGRAM_UPTIME_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_PROGRAMMER_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_SYSTEM_STRING_MAX_LEN 30
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_FILE_STRING_MAX_LEN 140
#define SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_COMPILE_DATE_STRING_MAX_LEN 30
START_STRUCTURE_DEFINITION( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO )
{
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__DHCP, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_DHCP_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__DHCP );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__MODEL, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_MODEL_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__MODEL );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__FIRMWARE, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_FIRMWARE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__FIRMWARE );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__FIRMWARE_DATE, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_FIRMWARE_DATE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__FIRMWARE_DATE );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__MAC, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_MAC_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__MAC );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__IP, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_IP_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__IP );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__HOSTNAME, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_HOSTNAME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__HOSTNAME );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__SERIAL, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_SERIAL_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__SERIAL );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__PROCESSOR_UPTIME, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_UPTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__PROCESSOR_UPTIME );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__PROGRAM_UPTIME, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_PROGRAM_UPTIME_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__PROGRAM_UPTIME );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__PROGRAMMER, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_PROGRAMMER_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__PROGRAMMER );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__SYSTEM, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_SYSTEM_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__SYSTEM );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__FILE, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_FILE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__FILE );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__COMPILE_DATE, SYSTEM_INFO__S2_Fusion_SSI_System_Information_v1_1_COMPILE_DATE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO__COMPILE_DATE );
};


/*
* Constructor and Destructor
*/
int S2_Fusion_SSI_System_Information_v1_1_SYSTEM_INFO_Constructor ( START_STRUCTURE_DEFINITION( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO ) * me, int nVerbose );
int S2_Fusion_SSI_System_Information_v1_1_SYSTEM_INFO_Destructor ( START_STRUCTURE_DEFINITION( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESS_DIG_INPUT 0
#define __S2_Fusion_SSI_System_Information_v1_1_REBOOT_PROCESSOR_DIG_INPUT 1


/*
* ANALOG_INPUT
*/


#define __S2_Fusion_SSI_System_Information_v1_1_CONSOLE_RX$_BUFFER_INPUT 0
#define __S2_Fusion_SSI_System_Information_v1_1_CONSOLE_RX$_BUFFER_MAX_LEN 1500
CREATE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, __CONSOLE_RX$, __S2_Fusion_SSI_System_Information_v1_1_CONSOLE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Fusion_SSI_System_Information_v1_1_DHCP_ON_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/

#define __S2_Fusion_SSI_System_Information_v1_1_CONSOLE_TX$_STRING_OUTPUT 0
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_MODEL_STRING_OUTPUT 1
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_FIRMWARE_STRING_OUTPUT 2
#define __S2_Fusion_SSI_System_Information_v1_1_FIRMWARE_DATE_STRING_OUTPUT 3
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_MAC_STRING_OUTPUT 4
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_IP_STRING_OUTPUT 5
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_HOSTNAME_STRING_OUTPUT 6
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_SERIAL_STRING_OUTPUT 7
#define __S2_Fusion_SSI_System_Information_v1_1_PROCESSOR_UPTIME_STRING_OUTPUT 8
#define __S2_Fusion_SSI_System_Information_v1_1_PROGRAM_UPTIME_STRING_OUTPUT 9
#define __S2_Fusion_SSI_System_Information_v1_1_PROGRAMMER_NAME_STRING_OUTPUT 10
#define __S2_Fusion_SSI_System_Information_v1_1_SYSTEM_NAME_STRING_OUTPUT 11
#define __S2_Fusion_SSI_System_Information_v1_1_SOURCE_FILE_STRING_OUTPUT 12
#define __S2_Fusion_SSI_System_Information_v1_1_COMPILE_DATE_STRING_OUTPUT 13


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

START_GLOBAL_VAR_STRUCT( S2_Fusion_SSI_System_Information_v1_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __STEPNUM;
   unsigned short __HASRAN;
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_System_Information_v1_1, __CONSOLE_RX$ );
   DECLARE_STRUCT( S2_Fusion_SSI_System_Information_v1_1, SYSTEM_INFO, __THIS );
};

START_NVRAM_VAR_STRUCT( S2_Fusion_SSI_System_Information_v1_1 )
{
};



#endif //__S2_FUSION_SSI_SYSTEM_INFORMATION_V1_1_H__

