#ifndef __S2_SMART_UX60_FEEDBACK_PROCESSOR_H__
#define __S2_SMART_UX60_FEEDBACK_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/


#define __S2_Smart_UX60_Feedback_Processor_FROM_DEVICE$_BUFFER_INPUT 0
#define __S2_Smart_UX60_Feedback_Processor_FROM_DEVICE$_BUFFER_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Smart_UX60_Feedback_Processor, __FROM_DEVICE$, __S2_Smart_UX60_Feedback_Processor_FROM_DEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Smart_UX60_Feedback_Processor_LAMP_HOURS_ANALOG_OUTPUT 0



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
#define __S2_Smart_UX60_Feedback_Processor_STEMP1_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Smart_UX60_Feedback_Processor, __STEMP1, __S2_Smart_UX60_Feedback_Processor_STEMP1_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Smart_UX60_Feedback_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Smart_UX60_Feedback_Processor, __STEMP1 );
   DECLARE_STRING_STRUCT( S2_Smart_UX60_Feedback_Processor, __FROM_DEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Smart_UX60_Feedback_Processor )
{
};



#endif //__S2_SMART_UX60_FEEDBACK_PROCESSOR_H__

