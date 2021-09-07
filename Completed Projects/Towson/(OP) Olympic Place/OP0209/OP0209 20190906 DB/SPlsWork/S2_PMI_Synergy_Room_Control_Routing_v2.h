#ifndef __S2_PMI_SYNERGY_ROOM_CONTROL_ROUTING_V2_H__
#define __S2_PMI_SYNERGY_ROOM_CONTROL_ROUTING_V2_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_PWR_FB_DIG_INPUT 0


/*
* ANALOG_INPUT
*/
#define __S2_PMI_Synergy_Room_Control_Routing_v2_ENABLE_DISP_PWR_FB_ANALOG_INPUT 0
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_WARMUP_TIME_ANALOG_INPUT 1
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SRC_REF_VAL_ANALOG_INPUT 2
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_1_BRAND_ANALOG_INPUT 3
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_2_BRAND_ANALOG_INPUT 4
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_3_BRAND_ANALOG_INPUT 5
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_4_BRAND_ANALOG_INPUT 6
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_AUD_BRAND_ANALOG_INPUT 7



#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_RGB_DATA_ANALOG_INPUT 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_RGB_DATA_ARRAY_LENGTH 17
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_YUV_DATA_ANALOG_INPUT 25
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_YUV_DATA_ARRAY_LENGTH 17
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_SVID_DATA_ANALOG_INPUT 42
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_SVID_DATA_ARRAY_LENGTH 17
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_COMP_DATA_ANALOG_INPUT 59
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_COMP_DATA_ARRAY_LENGTH 17
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_VID_TYPE_DATA_ANALOG_INPUT 76
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_VID_TYPE_DATA_ARRAY_LENGTH 17
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_AUD_DATA_ANALOG_INPUT 93
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SOURCE_AUD_DATA_ARRAY_LENGTH 16
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_OUTPUT_VAL_ANALOG_INPUT 109
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_OUTPUT_VAL_ARRAY_LENGTH 5

/*
* DIGITAL_OUTPUT
*/
#define __S2_PMI_Synergy_Room_Control_Routing_v2_ROOM_ON_FB_DIG_OUTPUT 0
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_PWR_ON_DIG_OUTPUT 1
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_PWR_OFF_DIG_OUTPUT 2
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_RGB_IN_DIG_OUTPUT 3
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_YUV_IN_DIG_OUTPUT 4
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_SVID_IN_DIG_OUTPUT 5
#define __S2_PMI_Synergy_Room_Control_Routing_v2_DISP_COMP_IN_DIG_OUTPUT 6


/*
* ANALOG_OUTPUT
*/


#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_VAL_ANALOG_OUTPUT 5
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_VAL_ARRAY_LENGTH 5
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_TX$_STRING_OUTPUT 0
#define __S2_PMI_Synergy_Room_Control_Routing_v2_SWT_TX$_ARRAY_LENGTH 5

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
CREATE_INTARRAY1D( S2_PMI_Synergy_Room_Control_Routing_v2, __OUT_DATA, 5 );;

CREATE_INTARRAY2D( S2_PMI_Synergy_Room_Control_Routing_v2, __SRC_DATA, 17, 6 );;

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
#define __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_INPUTS$_ARRAY_NUM_ELEMS 16
#define __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_INPUTS$_ARRAY_NUM_CHARS 1
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __KRAMER_INPUTS$, __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_INPUTS$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_INPUTS$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_OUTPUTS$_ARRAY_NUM_ELEMS 16
#define __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_OUTPUTS$_ARRAY_NUM_CHARS 1
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __KRAMER_OUTPUTS$, __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_OUTPUTS$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_KRAMER_OUTPUTS$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT1$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT1$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT1$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT1$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT1$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT2$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT2$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT2$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT2$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT2$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT3$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT3$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT3$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT3$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT3$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT4$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT4$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT4$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT4$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT4$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT5$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT5$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT5$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT5$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT5$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT6$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT6$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT6$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT6$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT6$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT7$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT7$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT7$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT7$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT7$_ARRAY_NUM_CHARS );
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT8$_ARRAY_NUM_ELEMS 8
#define __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT8$_ARRAY_NUM_CHARS 3
CREATE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT8$, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT8$_ARRAY_NUM_ELEMS, __S2_PMI_Synergy_Room_Control_Routing_v2_OUTPUT8$_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_PMI_Synergy_Room_Control_Routing_v2 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SOURCE_RGB_DATA );
   DECLARE_IO_ARRAY( __SOURCE_YUV_DATA );
   DECLARE_IO_ARRAY( __SOURCE_SVID_DATA );
   DECLARE_IO_ARRAY( __SOURCE_COMP_DATA );
   DECLARE_IO_ARRAY( __SOURCE_VID_TYPE_DATA );
   DECLARE_IO_ARRAY( __SOURCE_AUD_DATA );
   DECLARE_IO_ARRAY( __SWT_OUTPUT_VAL );
   DECLARE_IO_ARRAY( __SWT_VAL );
   DECLARE_IO_ARRAY( __SWT_TX$ );
};

START_NVRAM_VAR_STRUCT( S2_PMI_Synergy_Room_Control_Routing_v2 )
{
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __KRAMER_INPUTS$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __KRAMER_OUTPUTS$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT1$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT2$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT3$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT4$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT5$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT6$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT7$ );
   DECLARE_STRING_ARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUTPUT8$ );
   unsigned short __PWR_WAIT;
   unsigned short __ISRC;
   unsigned short __LOOP;
   DECLARE_INTARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __OUT_DATA );
   DECLARE_INTARRAY( S2_PMI_Synergy_Room_Control_Routing_v2, __SRC_DATA );
};

DEFINE_WAITEVENT( S2_PMI_Synergy_Room_Control_Routing_v2, __SPLS_TMPVAR__WAITLABEL_0__ );
DEFINE_WAITEVENT( S2_PMI_Synergy_Room_Control_Routing_v2, __SPLS_TMPVAR__WAITLABEL_1__ );


#endif //__S2_PMI_SYNERGY_ROOM_CONTROL_ROUTING_V2_H__

