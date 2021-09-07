#ifndef __S2_BIAMP_ON_OFF_PROCESSOR_V7_5_1_H__
#define __S2_BIAMP_ON_OFF_PROCESSOR_V7_5_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Biamp_On_Off_Processor_v7_5_1_VOL_MUTE_ON_DIG_INPUT 0
#define __S2_Biamp_On_Off_Processor_v7_5_1_VOL_MUTE_OFF_DIG_INPUT 1
#define __S2_Biamp_On_Off_Processor_v7_5_1_POLL_MUTE_DIG_INPUT 2


/*
* ANALOG_INPUT
*/

#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_DEVICE_ID_STRING_INPUT 0
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_DEVICE_ID_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_DEVICE_ID, __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_DEVICE_ID_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_DEVICE_INSTANCE_STRING_INPUT 1
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_DEVICE_INSTANCE_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_DEVICE_INSTANCE, __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_DEVICE_INSTANCE_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_INDEX1_STRING_INPUT 2
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_INDEX1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_INDEX1, __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_INDEX1_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_INDEX2_STRING_INPUT 3
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_INDEX2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_INDEX2, __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_INDEX2_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_COMMAND_TYPE_STRING_INPUT 4
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_COMMAND_TYPE_STRING_MAX_LEN 15
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_COMMAND_TYPE, __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_COMMAND_TYPE_STRING_MAX_LEN );

#define __S2_Biamp_On_Off_Processor_v7_5_1_DEVICE_RX$_BUFFER_INPUT 5
#define __S2_Biamp_On_Off_Processor_v7_5_1_DEVICE_RX$_BUFFER_MAX_LEN 2000
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __DEVICE_RX$, __S2_Biamp_On_Off_Processor_v7_5_1_DEVICE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_ON_FB_DIG_OUTPUT 0
#define __S2_Biamp_On_Off_Processor_v7_5_1_MUTE_OFF_FB_DIG_OUTPUT 1
#define __S2_Biamp_On_Off_Processor_v7_5_1_START_UP_OUT_DIG_OUTPUT 2
#define __S2_Biamp_On_Off_Processor_v7_5_1_ERROR_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/

#define __S2_Biamp_On_Off_Processor_v7_5_1_DEVICE_TX$_STRING_OUTPUT 0


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
#define __S2_Biamp_On_Off_Processor_v7_5_1_SMUTE_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SMUTE, __S2_Biamp_On_Off_Processor_v7_5_1_SMUTE_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_SSENDNAME_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SSENDNAME, __S2_Biamp_On_Off_Processor_v7_5_1_SSENDNAME_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_SMUTEPREFIX_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SMUTEPREFIX, __S2_Biamp_On_Off_Processor_v7_5_1_SMUTEPREFIX_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_SMUTETYPE_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SMUTETYPE, __S2_Biamp_On_Off_Processor_v7_5_1_SMUTETYPE_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_SINSTANCE_STRING_MAX_LEN 52
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SINSTANCE, __S2_Biamp_On_Off_Processor_v7_5_1_SINSTANCE_STRING_MAX_LEN );
#define __S2_Biamp_On_Off_Processor_v7_5_1_SSENDINST_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SSENDINST, __S2_Biamp_On_Off_Processor_v7_5_1_SSENDINST_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __IVOLINDEX1;
   unsigned short __IVOLINDEX2;
   unsigned short __IMUTEINDEX1;
   unsigned short __IMUTEINDEX2;
   unsigned short __ERRORRECEIVED;
   unsigned short __BRXOK;
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SMUTE );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SSENDNAME );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SMUTEPREFIX );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SMUTETYPE );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SINSTANCE );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __SSENDINST );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_DEVICE_ID );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_DEVICE_INSTANCE );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_INDEX1 );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_INDEX2 );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __MUTE_COMMAND_TYPE );
   DECLARE_STRING_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1, __DEVICE_RX$ );
};

START_NVRAM_VAR_STRUCT( S2_Biamp_On_Off_Processor_v7_5_1 )
{
};



#endif //__S2_BIAMP_ON_OFF_PROCESSOR_V7_5_1_H__

