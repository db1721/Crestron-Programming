#ifndef __S2_FUSION_TIME_SYNC_V1_1_0_H__
#define __S2_FUSION_TIME_SYNC_V1_1_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Fusion_Time_Sync_v1_1_0_SYNC_TIME_B_DIG_INPUT 0


/*
* ANALOG_INPUT
*/

#define __S2_Fusion_Time_Sync_v1_1_0_LOCAL_DATE_TIME_QUERY_RX$_STRING_INPUT 0
#define __S2_Fusion_Time_Sync_v1_1_0_LOCAL_DATE_TIME_QUERY_RX$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_Fusion_Time_Sync_v1_1_0, __LOCAL_DATE_TIME_QUERY_RX$, __S2_Fusion_Time_Sync_v1_1_0_LOCAL_DATE_TIME_QUERY_RX$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Fusion_Time_Sync_v1_1_0_LOCAL_DATE_TIME_QUERY_TX$_STRING_OUTPUT 0


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_Fusion_Time_Sync_v1_1_0_INSTANCEID_INTEGER_PARAMETER 10
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

START_GLOBAL_VAR_STRUCT( S2_Fusion_Time_Sync_v1_1_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __G_NSEMAPHORE;
   DECLARE_STRING_STRUCT( S2_Fusion_Time_Sync_v1_1_0, __LOCAL_DATE_TIME_QUERY_RX$ );
};

START_NVRAM_VAR_STRUCT( S2_Fusion_Time_Sync_v1_1_0 )
{
};



#endif //__S2_FUSION_TIME_SYNC_V1_1_0_H__

