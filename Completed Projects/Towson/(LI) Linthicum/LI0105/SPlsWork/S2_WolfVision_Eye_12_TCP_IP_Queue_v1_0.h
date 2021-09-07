#ifndef __S2_WOLFVISION_EYE_12_TCP_IP_QUEUE_V1_0_H__
#define __S2_WOLFVISION_EYE_12_TCP_IP_QUEUE_V1_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_CONNECTED_DIG_INPUT 0
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_SEND_NEXT_DIG_INPUT 1
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_RECEIVING_DIG_INPUT 2


/*
* ANALOG_INPUT
*/


#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_FROM_MODULE_BUFFER_INPUT 0
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_FROM_MODULE_BUFFER_MAX_LEN 500
CREATE_STRING_STRUCT( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0, __FROM_MODULE, __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_FROM_MODULE_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_CONNECT_DIG_OUTPUT 0
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_SEND_NEXT_OUT_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/

#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_TO_DEVICE_STRING_OUTPUT 0


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
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_STEMP_STRING_MAX_LEN 30
CREATE_STRING_STRUCT( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0, __STEMP, __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_STEMP_STRING_MAX_LEN );
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_SQUEUE_ARRAY_NUM_ELEMS 30
#define __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_SQUEUE_ARRAY_NUM_CHARS 30
CREATE_STRING_ARRAY( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0, __SQUEUE, __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_SQUEUE_ARRAY_NUM_ELEMS, __S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0_SQUEUE_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __INEXTSEND;
   unsigned short __INEXTSTORE;
   unsigned short __IFLAG1;
   unsigned short __IOKTOSEND;
   DECLARE_STRING_STRUCT( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0, __STEMP );
   DECLARE_STRING_ARRAY( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0, __SQUEUE );
   DECLARE_STRING_STRUCT( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0, __FROM_MODULE );
};

START_NVRAM_VAR_STRUCT( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0 )
{
};

DEFINE_WAITEVENT( S2_WolfVision_Eye_12_TCP_IP_Queue_v1_0, WTIMEOUT );


#endif //__S2_WOLFVISION_EYE_12_TCP_IP_QUEUE_V1_0_H__

