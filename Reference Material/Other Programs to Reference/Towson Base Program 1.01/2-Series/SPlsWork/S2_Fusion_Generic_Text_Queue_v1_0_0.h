#ifndef __S2_FUSION_GENERIC_TEXT_QUEUE_V1_0_0_H__
#define __S2_FUSION_GENERIC_TEXT_QUEUE_V1_0_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Fusion_Generic_Text_Queue_v1_0_0_DEBUG_DIG_INPUT 0
#define __S2_Fusion_Generic_Text_Queue_v1_0_0_RV_ONLINE_DIG_INPUT 1


/*
* ANALOG_INPUT
*/

#define __S2_Fusion_Generic_Text_Queue_v1_0_0_LOG_TEXT$_STRING_INPUT 0
#define __S2_Fusion_Generic_Text_Queue_v1_0_0_LOG_TEXT$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_Fusion_Generic_Text_Queue_v1_0_0, __LOG_TEXT$, __S2_Fusion_Generic_Text_Queue_v1_0_0_LOG_TEXT$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Fusion_Generic_Text_Queue_v1_0_0_QUE_COUNT_ANALOG_OUTPUT 0

#define __S2_Fusion_Generic_Text_Queue_v1_0_0_TO_RV_LOG_TEXT$_STRING_OUTPUT 1


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
#define __S2_Fusion_Generic_Text_Queue_v1_0_0_G_SINITIALIZED_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_Fusion_Generic_Text_Queue_v1_0_0, __G_SINITIALIZED, __S2_Fusion_Generic_Text_Queue_v1_0_0_G_SINITIALIZED_STRING_MAX_LEN );
#define __S2_Fusion_Generic_Text_Queue_v1_0_0_G_SLOGTEXT_ARRAY_NUM_ELEMS 100
#define __S2_Fusion_Generic_Text_Queue_v1_0_0_G_SLOGTEXT_ARRAY_NUM_CHARS 200
CREATE_STRING_ARRAY( S2_Fusion_Generic_Text_Queue_v1_0_0, __G_SLOGTEXT, __S2_Fusion_Generic_Text_Queue_v1_0_0_G_SLOGTEXT_ARRAY_NUM_ELEMS, __S2_Fusion_Generic_Text_Queue_v1_0_0_G_SLOGTEXT_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Fusion_Generic_Text_Queue_v1_0_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __G_ILOGTEXTCOUNT;
   DECLARE_STRING_STRUCT( S2_Fusion_Generic_Text_Queue_v1_0_0, __G_SINITIALIZED );
   DECLARE_STRING_ARRAY( S2_Fusion_Generic_Text_Queue_v1_0_0, __G_SLOGTEXT );
   DECLARE_STRING_STRUCT( S2_Fusion_Generic_Text_Queue_v1_0_0, __LOG_TEXT$ );
};

START_NVRAM_VAR_STRUCT( S2_Fusion_Generic_Text_Queue_v1_0_0 )
{
};



#endif //__S2_FUSION_GENERIC_TEXT_QUEUE_V1_0_0_H__

