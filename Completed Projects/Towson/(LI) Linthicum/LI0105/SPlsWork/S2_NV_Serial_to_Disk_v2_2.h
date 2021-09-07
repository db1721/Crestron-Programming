#ifndef __S2_NV_SERIAL_TO_DISK_V2_2_H__
#define __S2_NV_SERIAL_TO_DISK_V2_2_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/



#define __S2_NV_Serial_to_Disk_v2_2_IN_STRING_INPUT 0
#define __S2_NV_Serial_to_Disk_v2_2_IN_ARRAY_NUM_ELEMS 50
#define __S2_NV_Serial_to_Disk_v2_2_IN_ARRAY_NUM_CHARS 255
CREATE_STRING_ARRAY( S2_NV_Serial_to_Disk_v2_2, __IN, __S2_NV_Serial_to_Disk_v2_2_IN_ARRAY_NUM_ELEMS, __S2_NV_Serial_to_Disk_v2_2_IN_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/
#define __S2_NV_Serial_to_Disk_v2_2_FILEOP_BUSY_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/


#define __S2_NV_Serial_to_Disk_v2_2_OUT_STRING_OUTPUT 0
#define __S2_NV_Serial_to_Disk_v2_2_OUT_ARRAY_LENGTH 50

/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_NV_Serial_to_Disk_v2_2_INSTANCE_ID_INTEGER_PARAMETER 10
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
#define __S2_NV_Serial_to_Disk_v2_2_GFILEPATH$_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_NV_Serial_to_Disk_v2_2, __GFILEPATH$, __S2_NV_Serial_to_Disk_v2_2_GFILEPATH$_STRING_MAX_LEN );
#define __S2_NV_Serial_to_Disk_v2_2_GVALUE_ARRAY_NUM_ELEMS 50
#define __S2_NV_Serial_to_Disk_v2_2_GVALUE_ARRAY_NUM_CHARS 255
CREATE_STRING_ARRAY( S2_NV_Serial_to_Disk_v2_2, __GVALUE, __S2_NV_Serial_to_Disk_v2_2_GVALUE_ARRAY_NUM_ELEMS, __S2_NV_Serial_to_Disk_v2_2_GVALUE_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_NV_Serial_to_Disk_v2_2 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __OUT );
   unsigned short __GDEFINEDINPUTS;
   unsigned short __GSTARTUP;
   unsigned short __GTHREAD;
   DECLARE_STRING_STRUCT( S2_NV_Serial_to_Disk_v2_2, __GFILEPATH$ );
   DECLARE_STRING_ARRAY( S2_NV_Serial_to_Disk_v2_2, __GVALUE );
   DECLARE_STRING_ARRAY( S2_NV_Serial_to_Disk_v2_2, __IN );
};

START_NVRAM_VAR_STRUCT( S2_NV_Serial_to_Disk_v2_2 )
{
};



#endif //__S2_NV_SERIAL_TO_DISK_V2_2_H__

