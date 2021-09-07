#ifndef __S2_ROBOSHOT_IP_PTZ_H__
#define __S2_ROBOSHOT_IP_PTZ_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Roboshot_IP_PTZ_RECALL_DIG_INPUT 0
#define __S2_Roboshot_IP_PTZ_STORE_DIG_INPUT 1
#define __S2_Roboshot_IP_PTZ_POWERON_DIG_INPUT 2
#define __S2_Roboshot_IP_PTZ_POWEROFF_DIG_INPUT 3
#define __S2_Roboshot_IP_PTZ_HOME_DIG_INPUT 4
#define __S2_Roboshot_IP_PTZ_AUTOFOCUS_DIG_INPUT 5

#define __S2_Roboshot_IP_PTZ_TILT_DIG_INPUT 6
#define __S2_Roboshot_IP_PTZ_TILT_ARRAY_LENGTH 2
#define __S2_Roboshot_IP_PTZ_PAN_DIG_INPUT 8
#define __S2_Roboshot_IP_PTZ_PAN_ARRAY_LENGTH 2
#define __S2_Roboshot_IP_PTZ_ZOOM_DIG_INPUT 10
#define __S2_Roboshot_IP_PTZ_ZOOM_ARRAY_LENGTH 2
#define __S2_Roboshot_IP_PTZ_FOCUS_DIG_INPUT 12
#define __S2_Roboshot_IP_PTZ_FOCUS_ARRAY_LENGTH 2

/*
* ANALOG_INPUT
*/
#define __S2_Roboshot_IP_PTZ_PRESET_ANALOG_INPUT 1

#define __S2_Roboshot_IP_PTZ_IN$_STRING_INPUT 0
#define __S2_Roboshot_IP_PTZ_IN$_STRING_MAX_LEN 500
CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __IN$, __S2_Roboshot_IP_PTZ_IN$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Roboshot_IP_PTZ_OUT$_STRING_OUTPUT 0


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

CREATE_SIGNED_INTARRAY2D( S2_Roboshot_IP_PTZ, __PRESETARRAY, 99, 3 );;

/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_Roboshot_IP_PTZ_FILENAME_STRING_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FILENAME, __S2_Roboshot_IP_PTZ_FILENAME_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Roboshot_IP_PTZ )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __TILT );
   DECLARE_IO_ARRAY( __PAN );
   DECLARE_IO_ARRAY( __ZOOM );
   DECLARE_IO_ARRAY( __FOCUS );
   unsigned short __STORETYPE;
   unsigned short __PARAMTYPE;
   short __PTZ;
   DECLARE_SIGNED_INTARRAY( S2_Roboshot_IP_PTZ, __PRESETARRAY );
   DECLARE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __FILENAME );
   DECLARE_STRING_STRUCT( S2_Roboshot_IP_PTZ, __IN$ );
};

START_NVRAM_VAR_STRUCT( S2_Roboshot_IP_PTZ )
{
};



#endif //__S2_ROBOSHOT_IP_PTZ_H__

