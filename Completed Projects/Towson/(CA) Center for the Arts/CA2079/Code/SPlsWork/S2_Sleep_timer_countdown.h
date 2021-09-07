#ifndef __S2_SLEEP_TIMER_COUNTDOWN_H__
#define __S2_SLEEP_TIMER_COUNTDOWN_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Sleep_timer_countdown_START_30MIN_DIG_INPUT 0
#define __S2_Sleep_timer_countdown_START_60MIN_DIG_INPUT 1
#define __S2_Sleep_timer_countdown_START_90MIN_DIG_INPUT 2
#define __S2_Sleep_timer_countdown_CANCEL_DIG_INPUT 3


/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/
#define __S2_Sleep_timer_countdown_START_30MIN_FB_DIG_OUTPUT 0
#define __S2_Sleep_timer_countdown_START_60MIN_FB_DIG_OUTPUT 1
#define __S2_Sleep_timer_countdown_START_90MIN_FB_DIG_OUTPUT 2
#define __S2_Sleep_timer_countdown_TIMER_FINISHED_DIG_OUTPUT 3
#define __S2_Sleep_timer_countdown_WARNING_DIG_OUTPUT 4


/*
* ANALOG_OUTPUT
*/

#define __S2_Sleep_timer_countdown_COUNTDOWN$_STRING_OUTPUT 0


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

START_GLOBAL_VAR_STRUCT( S2_Sleep_timer_countdown )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __X;
   unsigned short __TIMER_GOING;
};

START_NVRAM_VAR_STRUCT( S2_Sleep_timer_countdown )
{
};



#endif //__S2_SLEEP_TIMER_COUNTDOWN_H__

