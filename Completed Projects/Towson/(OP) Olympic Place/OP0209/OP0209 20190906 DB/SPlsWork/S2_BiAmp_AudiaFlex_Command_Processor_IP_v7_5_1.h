#ifndef __S2_BIAMP_AUDIAFLEX_COMMAND_PROCESSOR_IP_V7_5_1_H__
#define __S2_BIAMP_AUDIAFLEX_COMMAND_PROCESSOR_IP_V7_5_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_INITIALIZE_DIG_INPUT 0
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_CONNECTED_F_DIG_INPUT 1


/*
* ANALOG_INPUT
*/


#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_FROM_DEVICE_BUFFER_INPUT 0
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_FROM_DEVICE_BUFFER_MAX_LEN 5000
CREATE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __FROM_DEVICE, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_FROM_DEVICE_BUFFER_MAX_LEN );
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_FROM_MODULES_BUFFER_INPUT 1
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_FROM_MODULES_BUFFER_MAX_LEN 5000
CREATE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __FROM_MODULES, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_FROM_MODULES_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_INITIALIZE_IS_BUSY_DIG_OUTPUT 0
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_INITCOMPLETE_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/

#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_TO_DEVICE_STRING_OUTPUT 0

#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_TO_MODULES_STRING_OUTPUT 1
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_TO_MODULES_ARRAY_LENGTH 500

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
CREATE_INTARRAY1D( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, ___MODULES, 500 );;


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
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_STEMPMODULES_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __STEMPMODULES, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_STEMPMODULES_STRING_MAX_LEN );
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_STEMPDEVICE_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __STEMPDEVICE, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_STEMPDEVICE_STRING_MAX_LEN );
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SCOMMAND_ARRAY_NUM_ELEMS 500
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SCOMMAND_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __SCOMMAND, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SCOMMAND_ARRAY_NUM_ELEMS, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SCOMMAND_ARRAY_NUM_CHARS );
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SGET_ARRAY_NUM_ELEMS 500
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SGET_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __SGET, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SGET_ARRAY_NUM_ELEMS, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SGET_ARRAY_NUM_CHARS );
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SMODULEINSTANCEID_ARRAY_NUM_ELEMS 500
#define __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SMODULEINSTANCEID_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __SMODULEINSTANCEID, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SMODULEINSTANCEID_ARRAY_NUM_ELEMS, __S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1_SMODULEINSTANCEID_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __TO_MODULES );
   unsigned short __INEXTCOMMANDSTORE;
   unsigned short __INEXTCOMMANDSEND;
   unsigned short __INEXTGETSTORE;
   unsigned short __INEXTGETSEND;
   unsigned short __ITEMPID;
   unsigned short __ITEMP;
   unsigned short __A;
   unsigned short __B;
   unsigned short __NUMBEROFMODULES;
   unsigned short ___INITCOMPLETE;
   unsigned short __COMMANDSENT;
   unsigned short __TIMEOUTCOUNTER;
   unsigned short __MAINCOMPLETE;
   unsigned short __BFLAG1;
   unsigned short __BFLAG2;
   DECLARE_INTARRAY( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, ___MODULES );
   DECLARE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __STEMPMODULES );
   DECLARE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __STEMPDEVICE );
   DECLARE_STRING_ARRAY( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __SCOMMAND );
   DECLARE_STRING_ARRAY( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __SGET );
   DECLARE_STRING_ARRAY( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __SMODULEINSTANCEID );
   DECLARE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __FROM_DEVICE );
   DECLARE_STRING_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, __FROM_MODULES );
};

START_NVRAM_VAR_STRUCT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1 )
{
};

DEFINE_WAITEVENT( S2_BiAmp_AudiaFlex_Command_Processor_IP_v7_5_1, _SENDCOMMANDWAIT );


#endif //__S2_BIAMP_AUDIAFLEX_COMMAND_PROCESSOR_IP_V7_5_1_H__

