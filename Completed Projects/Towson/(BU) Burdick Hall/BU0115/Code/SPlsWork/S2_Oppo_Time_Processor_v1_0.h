#ifndef __S2_OPPO_TIME_PROCESSOR_V1_0_H__
#define __S2_OPPO_TIME_PROCESSOR_V1_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Oppo_Time_Processor_v1_0_PROCESS_FROM_DEVICE_DIG_INPUT 0
#define __S2_Oppo_Time_Processor_v1_0_SEND_TITLE_NUMBER_DIG_INPUT 1
#define __S2_Oppo_Time_Processor_v1_0_SEND_TITLE_TIME_DIG_INPUT 2
#define __S2_Oppo_Time_Processor_v1_0_SEND_CHAPTER_NUMBER_DIG_INPUT 3
#define __S2_Oppo_Time_Processor_v1_0_SEND_CHAPTER_TIME_DIG_INPUT 4
#define __S2_Oppo_Time_Processor_v1_0_CLEAR_TEXT_DIG_INPUT 5

#define __S2_Oppo_Time_Processor_v1_0_KEY_DIG_INPUT 6
#define __S2_Oppo_Time_Processor_v1_0_KEY_ARRAY_LENGTH 13

/*
* ANALOG_INPUT
*/


#define __S2_Oppo_Time_Processor_v1_0_FROM_DEVICE_BUFFER_INPUT 0
#define __S2_Oppo_Time_Processor_v1_0_FROM_DEVICE_BUFFER_MAX_LEN 500
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __FROM_DEVICE, __S2_Oppo_Time_Processor_v1_0_FROM_DEVICE_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Oppo_Time_Processor_v1_0_TITLE_NUMBER_ANALOG_ANALOG_OUTPUT 0
#define __S2_Oppo_Time_Processor_v1_0_CHAPTER_NUMBER_ANALOG_ANALOG_OUTPUT 1
#define __S2_Oppo_Time_Processor_v1_0_AUDIO_TRACK_NUMBER_ANALOG_ANALOG_OUTPUT 2
#define __S2_Oppo_Time_Processor_v1_0_AUDIO_MAXIMUM_TRACKS_ANALOG_ANALOG_OUTPUT 3
#define __S2_Oppo_Time_Processor_v1_0_SUB_TITLE_NUMBER_ANALOG_ANALOG_OUTPUT 4
#define __S2_Oppo_Time_Processor_v1_0_MAXIMUM_SUB_TITLE_ANALOG_ANALOG_OUTPUT 5
#define __S2_Oppo_Time_Processor_v1_0_TOTAL_TRACKS_TITLES_ANALOG_ANALOG_OUTPUT 6
#define __S2_Oppo_Time_Processor_v1_0_TOTAL_CHAPTERS_ANALOG_ANALOG_OUTPUT 7

#define __S2_Oppo_Time_Processor_v1_0_ENTERED_TEXT_STRING_OUTPUT 8
#define __S2_Oppo_Time_Processor_v1_0_CURRENT_TITLE_ELAPSED_TIME_TEXT_STRING_OUTPUT 9
#define __S2_Oppo_Time_Processor_v1_0_CURRENT_TITLE_REMAINING_TIME_TEXT_STRING_OUTPUT 10
#define __S2_Oppo_Time_Processor_v1_0_CURRENT_CHAPTER_ELAPSED_TIME_TEXT_STRING_OUTPUT 11
#define __S2_Oppo_Time_Processor_v1_0_CURRENT_CHAPTER_REMAINING_TIME_TEXT_STRING_OUTPUT 12
#define __S2_Oppo_Time_Processor_v1_0_CURRENT_TOTAL_ELAPSED_TIME_TEXT_STRING_OUTPUT 13
#define __S2_Oppo_Time_Processor_v1_0_CURRENT_TOTAL_REMAINING_TIME_TEXT_STRING_OUTPUT 14
#define __S2_Oppo_Time_Processor_v1_0_DISC_TYPE_TEXT_STRING_OUTPUT 15
#define __S2_Oppo_Time_Processor_v1_0_AUDIO_TYPE_TEXT_STRING_OUTPUT 16
#define __S2_Oppo_Time_Processor_v1_0_AUDIO_LANGUAGE_TEXT_STRING_OUTPUT 17
#define __S2_Oppo_Time_Processor_v1_0_AUDIO_CHANNELS_TEXT_STRING_OUTPUT 18
#define __S2_Oppo_Time_Processor_v1_0_SUB_TITLE_LANGUAGE_TEXT_STRING_OUTPUT 19
#define __S2_Oppo_Time_Processor_v1_0_TO_DEVICE_STRING_OUTPUT 20


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
#define __S2_Oppo_Time_Processor_v1_0_SENTERED_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SENTERED, __S2_Oppo_Time_Processor_v1_0_SENTERED_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_STEMP_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __STEMP, __S2_Oppo_Time_Processor_v1_0_STEMP_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_STYPE_STRING_MAX_LEN 5
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __STYPE, __S2_Oppo_Time_Processor_v1_0_STYPE_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_SNEWTIME_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWTIME, __S2_Oppo_Time_Processor_v1_0_SNEWTIME_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_SNEWDISCTYPE_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWDISCTYPE, __S2_Oppo_Time_Processor_v1_0_SNEWDISCTYPE_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_SNEWLANGUAGE_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWLANGUAGE, __S2_Oppo_Time_Processor_v1_0_SNEWLANGUAGE_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_SNEWAUDIOTYPE_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWAUDIOTYPE, __S2_Oppo_Time_Processor_v1_0_SNEWAUDIOTYPE_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_SNEWCHANNELS_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWCHANNELS, __S2_Oppo_Time_Processor_v1_0_SNEWCHANNELS_STRING_MAX_LEN );
#define __S2_Oppo_Time_Processor_v1_0_SNEWSUBLANGUAGE_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWSUBLANGUAGE, __S2_Oppo_Time_Processor_v1_0_SNEWSUBLANGUAGE_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Oppo_Time_Processor_v1_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __KEY );
   unsigned short __IFLAG1;
   unsigned short __IMARKER1;
   unsigned short __IMARKER2;
   unsigned short __IMARKER3;
   unsigned short __IMARKER4;
   unsigned short __IMARKER5;
   unsigned short __IMARKER6;
   unsigned short __IMARKER7;
   unsigned short __ITEMP;
   unsigned short __ITEMPTITLE;
   unsigned short __ITEMPCHAPTER;
   unsigned short __ITEMPTRACKNUMBER;
   unsigned short __ITEMPMAXTRACKS;
   unsigned short __ITEMPSUBNUMBER;
   unsigned short __ITEMPMAXSUBS;
   unsigned short __ICURRENTTRACK;
   unsigned short __ITOTALTRACKS;
   unsigned short __ICURRENTCHAPTER;
   unsigned short __ITOTALCHAPTERS;
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SENTERED );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __STEMP );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __STYPE );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWTIME );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWDISCTYPE );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWLANGUAGE );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWAUDIOTYPE );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWCHANNELS );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __SNEWSUBLANGUAGE );
   DECLARE_STRING_STRUCT( S2_Oppo_Time_Processor_v1_0, __FROM_DEVICE );
};

START_NVRAM_VAR_STRUCT( S2_Oppo_Time_Processor_v1_0 )
{
};



#endif //__S2_OPPO_TIME_PROCESSOR_V1_0_H__

