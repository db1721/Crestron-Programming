#ifndef __S2_VADDIO_ROBOSHOT_30_V1_0_PROCESSOR_H__
#define __S2_VADDIO_ROBOSHOT_30_V1_0_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_CHECKZOOM_DIG_INPUT 0
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_EVI_D30_DIG_INPUT 1
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_EVI_D70_DIG_INPUT 2
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_EVI_D100_DIG_INPUT 3
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_BRC_300_DIG_INPUT 4


/*
* ANALOG_INPUT
*/
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ADDRESS_ANALOG_INPUT 0

#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_1_STRING_INPUT 1
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __PAN_SPEED_1, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_1_STRING_MAX_LEN );
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_2_STRING_INPUT 2
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __PAN_SPEED_2, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_2_STRING_MAX_LEN );
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_3_STRING_INPUT 3
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_3_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __PAN_SPEED_3, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_3_STRING_MAX_LEN );
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_1_STRING_INPUT 4
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __TILT_SPEED_1, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_1_STRING_MAX_LEN );
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_2_STRING_INPUT 5
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __TILT_SPEED_2, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_2_STRING_MAX_LEN );
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_SPEED_1_STRING_INPUT 6
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_SPEED_1_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __ZOOM_SPEED_1, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_SPEED_1_STRING_MAX_LEN );
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_SPEED_2_STRING_INPUT 7
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_SPEED_2_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __ZOOM_SPEED_2, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_SPEED_2_STRING_MAX_LEN );

#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_FROMDEVICE$_BUFFER_INPUT 8
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_FROMDEVICE$_BUFFER_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __FROMDEVICE$, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_FROMDEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOMIN_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOMSCALE_ANALOG_OUTPUT 0
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_1_OUT_ANALOG_OUTPUT 1
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_2_OUT_ANALOG_OUTPUT 2
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_PAN_SPEED_3_OUT_ANALOG_OUTPUT 3
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_1_OUT_ANALOG_OUTPUT 4
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TILT_SPEED_2_OUT_ANALOG_OUTPUT 5
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_IN_SPEED_1_OUT_ANALOG_OUTPUT 6
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_IN_SPEED_2_OUT_ANALOG_OUTPUT 7
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_OUT_SPEED_1_OUT_ANALOG_OUTPUT 8
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_ZOOM_OUT_SPEED_2_OUT_ANALOG_OUTPUT 9

#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TODEVICE$_STRING_OUTPUT 10


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

CREATE_INTARRAY2D( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __IPANSPEED, 3, 4 );;
CREATE_INTARRAY2D( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __ITILTSPEED, 2, 4 );;
CREATE_INTARRAY2D( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __IZOOMINSPEED, 2, 4 );;
CREATE_INTARRAY2D( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __IZOOMOUTSPEED, 2, 4 );;

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
#define __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TEMPSTRING$_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __TEMPSTRING$, __S2_Vaddio_RoboSHOT_30_v1_0_Processor_TEMPSTRING$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __PAN_SPEED_1 );
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __PAN_SPEED_2 );
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __PAN_SPEED_3 );
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __TILT_SPEED_1 );
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __TILT_SPEED_2 );
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __ZOOM_SPEED_1 );
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __ZOOM_SPEED_2 );
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __FROMDEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor )
{
   DECLARE_STRING_STRUCT( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __TEMPSTRING$ );
   unsigned short __ZOOMWAITING;
   unsigned short __SEMAPHORE;
   unsigned short __OUTHEADER;
   unsigned short __INHEADER;
   unsigned short __ICAMERA;
   DECLARE_INTARRAY( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __IPANSPEED );
   DECLARE_INTARRAY( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __ITILTSPEED );
   DECLARE_INTARRAY( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __IZOOMINSPEED );
   DECLARE_INTARRAY( S2_Vaddio_RoboSHOT_30_v1_0_Processor, __IZOOMOUTSPEED );
};



#endif //__S2_VADDIO_ROBOSHOT_30_V1_0_PROCESSOR_H__

