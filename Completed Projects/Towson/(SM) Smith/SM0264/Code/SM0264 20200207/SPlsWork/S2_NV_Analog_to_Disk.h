#ifndef __S2_NV_ANALOG_TO_DISK_H__
#define __S2_NV_ANALOG_TO_DISK_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_NV_Analog_to_Disk_INSTANCE_ID_ANALOG_INPUT 0



#define __S2_NV_Analog_to_Disk_IN_ANALOG_INPUT 1
#define __S2_NV_Analog_to_Disk_IN_ARRAY_LENGTH 50

/*
* DIGITAL_OUTPUT
*/
#define __S2_NV_Analog_to_Disk_FILEOP_BUSY_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/


#define __S2_NV_Analog_to_Disk_OUT_ANALOG_OUTPUT 0
#define __S2_NV_Analog_to_Disk_OUT_ARRAY_LENGTH 50

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
CREATE_INTARRAY1D( S2_NV_Analog_to_Disk, __GVALUE, 50 );;


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
#define __S2_NV_Analog_to_Disk_GFILEPATH$_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_NV_Analog_to_Disk, __GFILEPATH$, __S2_NV_Analog_to_Disk_GFILEPATH$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_NV_Analog_to_Disk )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __IN );
   DECLARE_IO_ARRAY( __OUT );
   unsigned short __GDEFINEDINPUTS;
   unsigned short __GSTARTUP;
   unsigned short __GTHREAD;
   DECLARE_INTARRAY( S2_NV_Analog_to_Disk, __GVALUE );
   DECLARE_STRING_STRUCT( S2_NV_Analog_to_Disk, __GFILEPATH$ );
};

START_NVRAM_VAR_STRUCT( S2_NV_Analog_to_Disk )
{
};



#endif //__S2_NV_ANALOG_TO_DISK_H__
