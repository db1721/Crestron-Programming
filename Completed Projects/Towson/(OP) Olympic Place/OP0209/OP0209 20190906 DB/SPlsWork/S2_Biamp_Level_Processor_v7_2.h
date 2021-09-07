#ifndef __S2_BIAMP_LEVEL_PROCESSOR_V7_2_H__
#define __S2_BIAMP_LEVEL_PROCESSOR_V7_2_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Biamp_Level_Processor_v7_2_VOL_UP_DIG_INPUT 0
#define __S2_Biamp_Level_Processor_v7_2_VOL_DOWN_DIG_INPUT 1
#define __S2_Biamp_Level_Processor_v7_2_POLL_LEVEL_DIG_INPUT 2
#define __S2_Biamp_Level_Processor_v7_2_SEND_NEW_LEVEL_DIG_INPUT 3


/*
* ANALOG_INPUT
*/
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_MAX_LEVEL_ANALOG_INPUT 0
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_MIN_LEVEL_ANALOG_INPUT 1
#define __S2_Biamp_Level_Processor_v7_2_NEW_VOLUME_LEVEL_ANALOG_INPUT 2

#define __S2_Biamp_Level_Processor_v7_2_VOLUME_DEVICE_ID_STRING_INPUT 3
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_DEVICE_ID_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_DEVICE_ID, __S2_Biamp_Level_Processor_v7_2_VOLUME_DEVICE_ID_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_DEVICE_INSTANCE_STRING_INPUT 4
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_DEVICE_INSTANCE_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_DEVICE_INSTANCE, __S2_Biamp_Level_Processor_v7_2_VOLUME_DEVICE_INSTANCE_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_INDEX1_STRING_INPUT 5
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_INDEX1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_INDEX1, __S2_Biamp_Level_Processor_v7_2_VOLUME_INDEX1_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_INDEX2_STRING_INPUT 6
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_INDEX2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_INDEX2, __S2_Biamp_Level_Processor_v7_2_VOLUME_INDEX2_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_COMMAND_TYPE_STRING_INPUT 7
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_COMMAND_TYPE_STRING_MAX_LEN 15
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_COMMAND_TYPE, __S2_Biamp_Level_Processor_v7_2_VOLUME_COMMAND_TYPE_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_STEP_STRING_INPUT 8
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_STEP_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_STEP, __S2_Biamp_Level_Processor_v7_2_VOLUME_STEP_STRING_MAX_LEN );

#define __S2_Biamp_Level_Processor_v7_2_DEVICE_RX$_BUFFER_INPUT 9
#define __S2_Biamp_Level_Processor_v7_2_DEVICE_RX$_BUFFER_MAX_LEN 2000
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __DEVICE_RX$, __S2_Biamp_Level_Processor_v7_2_DEVICE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Biamp_Level_Processor_v7_2_START_UP_OUT_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_LEVEL_ANALOG_OUTPUT 0

#define __S2_Biamp_Level_Processor_v7_2_DEVICE_TX$_STRING_OUTPUT 1
#define __S2_Biamp_Level_Processor_v7_2_VOLUME_LEVEL_TEXT_STRING_OUTPUT 2


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
#define __S2_Biamp_Level_Processor_v7_2_STEMPDATA_STRING_MAX_LEN 255
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __STEMPDATA, __S2_Biamp_Level_Processor_v7_2_STEMPDATA_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_SVOL_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOL, __S2_Biamp_Level_Processor_v7_2_SVOL_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_SVOLTEXT_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOLTEXT, __S2_Biamp_Level_Processor_v7_2_SVOLTEXT_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_SVOLUMEPREFIX_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOLUMEPREFIX, __S2_Biamp_Level_Processor_v7_2_SVOLUMEPREFIX_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_SVOLUMETYPE_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOLUMETYPE, __S2_Biamp_Level_Processor_v7_2_SVOLUMETYPE_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_SINSTANCE_STRING_MAX_LEN 52
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SINSTANCE, __S2_Biamp_Level_Processor_v7_2_SINSTANCE_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_SSTEP_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SSTEP, __S2_Biamp_Level_Processor_v7_2_SSTEP_STRING_MAX_LEN );
#define __S2_Biamp_Level_Processor_v7_2_SSENDINST_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SSENDINST, __S2_Biamp_Level_Processor_v7_2_SSENDINST_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Biamp_Level_Processor_v7_2 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __BRXOK;
   unsigned short __ISTEP;
   unsigned short __IMAXVOL;
   unsigned short __IMINVOL;
   unsigned short __IVOLINDEX1;
   unsigned short __IVOLINDEX2;
   unsigned short __IVOLUMESIGNED;
   unsigned short __IVOLUME;
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __STEMPDATA );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOL );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOLTEXT );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOLUMEPREFIX );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SVOLUMETYPE );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SINSTANCE );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SSTEP );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __SSENDINST );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_DEVICE_ID );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_DEVICE_INSTANCE );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_INDEX1 );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_INDEX2 );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_COMMAND_TYPE );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __VOLUME_STEP );
   DECLARE_STRING_STRUCT( S2_Biamp_Level_Processor_v7_2, __DEVICE_RX$ );
};

START_NVRAM_VAR_STRUCT( S2_Biamp_Level_Processor_v7_2 )
{
};



#endif //__S2_BIAMP_LEVEL_PROCESSOR_V7_2_H__

