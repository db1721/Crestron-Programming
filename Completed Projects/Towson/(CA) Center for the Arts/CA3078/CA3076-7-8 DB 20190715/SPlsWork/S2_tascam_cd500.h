#ifndef __S2_TASCAM_CD500_H__
#define __S2_TASCAM_CD500_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_tascam_cd500_PLAY_DIG_INPUT 0
#define __S2_tascam_cd500_STOP_DIG_INPUT 1
#define __S2_tascam_cd500_PAUSE_DIG_INPUT 2
#define __S2_tascam_cd500_TRACK_FWD_DIG_INPUT 3
#define __S2_tascam_cd500_TRACK_BACK_DIG_INPUT 4
#define __S2_tascam_cd500_EJECT_DIG_INPUT 5
#define __S2_tascam_cd500_ENTER_TRACK_DIG_INPUT 6
#define __S2_tascam_cd500_CLEAR_TRACK_DIG_INPUT 7
#define __S2_tascam_cd500_POLL_DIG_INPUT 8


/*
* ANALOG_INPUT
*/
#define __S2_tascam_cd500_TRACK_ANA_NUMBER_ANALOG_INPUT 0


#define __S2_tascam_cd500_DEVICE_RX$_BUFFER_INPUT 1
#define __S2_tascam_cd500_DEVICE_RX$_BUFFER_MAX_LEN 500
CREATE_STRING_STRUCT( S2_tascam_cd500, __DEVICE_RX$, __S2_tascam_cd500_DEVICE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_tascam_cd500_PLAY_FB_DIG_OUTPUT 0
#define __S2_tascam_cd500_STOP_FB_DIG_OUTPUT 1
#define __S2_tascam_cd500_PAUSE_FB_DIG_OUTPUT 2
#define __S2_tascam_cd500_DISC_PRESENT_FB_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/

#define __S2_tascam_cd500_CURRENT_TRACK_NUMBER_STRING_OUTPUT 0
#define __S2_tascam_cd500_TRACK_MINS_STRING_OUTPUT 1
#define __S2_tascam_cd500_TRACK_SECS_STRING_OUTPUT 2
#define __S2_tascam_cd500_TRACK_FRAMES_STRING_OUTPUT 3
#define __S2_tascam_cd500_TRACK_MANUAL_ENTER_STRING_OUTPUT 4
#define __S2_tascam_cd500_DEVICE_TX$_STRING_OUTPUT 5


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
#define __S2_tascam_cd500_TRACK_NUMBER_A_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_tascam_cd500, __TRACK_NUMBER_A, __S2_tascam_cd500_TRACK_NUMBER_A_STRING_MAX_LEN );
#define __S2_tascam_cd500_CUR_TRACK_A_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_tascam_cd500, __CUR_TRACK_A, __S2_tascam_cd500_CUR_TRACK_A_STRING_MAX_LEN );
#define __S2_tascam_cd500_CUR_MIN_A_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_tascam_cd500, __CUR_MIN_A, __S2_tascam_cd500_CUR_MIN_A_STRING_MAX_LEN );
#define __S2_tascam_cd500_CUR_SEC_A_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_tascam_cd500, __CUR_SEC_A, __S2_tascam_cd500_CUR_SEC_A_STRING_MAX_LEN );
#define __S2_tascam_cd500_CUR_FRAME_A_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_tascam_cd500, __CUR_FRAME_A, __S2_tascam_cd500_CUR_FRAME_A_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_tascam_cd500 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __CUR_TRACK;
   unsigned short __CUR_MIN;
   unsigned short __CUR_SEC;
   unsigned short __CUR_FRAME;
   unsigned short __DISC_PRESENT;
   DECLARE_STRING_STRUCT( S2_tascam_cd500, __TRACK_NUMBER_A );
   DECLARE_STRING_STRUCT( S2_tascam_cd500, __CUR_TRACK_A );
   DECLARE_STRING_STRUCT( S2_tascam_cd500, __CUR_MIN_A );
   DECLARE_STRING_STRUCT( S2_tascam_cd500, __CUR_SEC_A );
   DECLARE_STRING_STRUCT( S2_tascam_cd500, __CUR_FRAME_A );
   DECLARE_STRING_STRUCT( S2_tascam_cd500, __DEVICE_RX$ );
};

START_NVRAM_VAR_STRUCT( S2_tascam_cd500 )
{
};



#endif //__S2_TASCAM_CD500_H__

