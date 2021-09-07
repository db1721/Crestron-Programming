#ifndef __S2_RVSE2_DEVICE_USAGE_QUE_V1_1A__H__
#define __S2_RVSE2_DEVICE_USAGE_QUE_V1_1A__H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_RVSE2_Device_Usage_Que_v1_1a__DEBUG_DIG_INPUT 0
#define __S2_RVSE2_Device_Usage_Que_v1_1a__RV_ONLINE_DIG_INPUT 1


/*
* ANALOG_INPUT
*/

#define __S2_RVSE2_Device_Usage_Que_v1_1a__DEVICE_USAGE$_STRING_INPUT 0
#define __S2_RVSE2_Device_Usage_Que_v1_1a__DEVICE_USAGE$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_RVSE2_Device_Usage_Que_v1_1a_, __DEVICE_USAGE$, __S2_RVSE2_Device_Usage_Que_v1_1a__DEVICE_USAGE$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_RVSE2_Device_Usage_Que_v1_1a__QUE_COUNT_ANALOG_OUTPUT 0

#define __S2_RVSE2_Device_Usage_Que_v1_1a__TO_RV_DEVICE_USAGE$_STRING_OUTPUT 1


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
#define __S2_RVSE2_Device_Usage_Que_v1_1a__G_SINITIALIZED_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_RVSE2_Device_Usage_Que_v1_1a_, __G_SINITIALIZED, __S2_RVSE2_Device_Usage_Que_v1_1a__G_SINITIALIZED_STRING_MAX_LEN );
#define __S2_RVSE2_Device_Usage_Que_v1_1a__G_SUSAGETEXT_ARRAY_NUM_ELEMS 100
#define __S2_RVSE2_Device_Usage_Que_v1_1a__G_SUSAGETEXT_ARRAY_NUM_CHARS 200
CREATE_STRING_ARRAY( S2_RVSE2_Device_Usage_Que_v1_1a_, __G_SUSAGETEXT, __S2_RVSE2_Device_Usage_Que_v1_1a__G_SUSAGETEXT_ARRAY_NUM_ELEMS, __S2_RVSE2_Device_Usage_Que_v1_1a__G_SUSAGETEXT_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_RVSE2_Device_Usage_Que_v1_1a_ )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_RVSE2_Device_Usage_Que_v1_1a_, __DEVICE_USAGE$ );
};

START_NVRAM_VAR_STRUCT( S2_RVSE2_Device_Usage_Que_v1_1a_ )
{
   DECLARE_STRING_STRUCT( S2_RVSE2_Device_Usage_Que_v1_1a_, __G_SINITIALIZED );
   DECLARE_STRING_ARRAY( S2_RVSE2_Device_Usage_Que_v1_1a_, __G_SUSAGETEXT );
   unsigned short __G_IUSAGETEXTCOUNT;
};



#endif //__S2_RVSE2_DEVICE_USAGE_QUE_V1_1A__H__

