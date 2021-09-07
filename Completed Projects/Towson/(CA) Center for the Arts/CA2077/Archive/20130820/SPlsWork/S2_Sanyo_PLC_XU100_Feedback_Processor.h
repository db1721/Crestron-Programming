#ifndef __S2_SANYO_PLC_XU100_FEEDBACK_PROCESSOR_H__
#define __S2_SANYO_PLC_XU100_FEEDBACK_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_VOLUME_UP_DIG_INPUT 0
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_VOLUME_DOWN_DIG_INPUT 1


/*
* ANALOG_INPUT
*/


#define __S2_Sanyo_PLC_XU100_Feedback_Processor_FROM_MODULE$_BUFFER_INPUT 0
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_FROM_MODULE$_BUFFER_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __FROM_MODULE$, __S2_Sanyo_PLC_XU100_Feedback_Processor_FROM_MODULE$_BUFFER_MAX_LEN );
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_FROM_DEVICE$_BUFFER_INPUT 1
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_FROM_DEVICE$_BUFFER_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __FROM_DEVICE$, __S2_Sanyo_PLC_XU100_Feedback_Processor_FROM_DEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_VOLUME_RAMP_DONE_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_POWER_IN_ANALOG_OUTPUT 0
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_INPUT_IN_ANALOG_OUTPUT 1
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_VIDEO_MUTE_IN_ANALOG_OUTPUT 2
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_ASPECT_IN_ANALOG_OUTPUT 3
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_VOLUME_IN_ANALOG_OUTPUT 4
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_AUDIO_MUTE_IN_ANALOG_OUTPUT 5
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_IMAGE_IN_ANALOG_OUTPUT 6
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_FREEZE_IN_ANALOG_OUTPUT 7
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_LAMP_HOURS_IN_ANALOG_OUTPUT 8



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
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_STEMP_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __STEMP, __S2_Sanyo_PLC_XU100_Feedback_Processor_STEMP_STRING_MAX_LEN );
#define __S2_Sanyo_PLC_XU100_Feedback_Processor_STEMP1_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __STEMP1, __S2_Sanyo_PLC_XU100_Feedback_Processor_STEMP1_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __IPOLLSENT;
   unsigned short __IFLAG1;
   unsigned short __IFLAG2;
   unsigned short __ISPACEPOINTER;
   unsigned short __ITEMP;
   unsigned short __IVOLUME;
   unsigned short __IINPUT;
   DECLARE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __STEMP );
   DECLARE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __STEMP1 );
   DECLARE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __FROM_MODULE$ );
   DECLARE_STRING_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor, __FROM_DEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Sanyo_PLC_XU100_Feedback_Processor )
{
};



#endif //__S2_SANYO_PLC_XU100_FEEDBACK_PROCESSOR_H__

