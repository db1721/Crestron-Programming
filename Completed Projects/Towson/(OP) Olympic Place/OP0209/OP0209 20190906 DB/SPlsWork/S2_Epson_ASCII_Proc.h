#ifndef __S2_EPSON_ASCII_PROC_H__
#define __S2_EPSON_ASCII_PROC_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Epson_ASCII_Proc_INITIALIZE_DIG_INPUT 0
#define __S2_Epson_ASCII_Proc_POWER_ON_DIG_INPUT 1
#define __S2_Epson_ASCII_Proc_POWER_OFF_DIG_INPUT 2
#define __S2_Epson_ASCII_Proc_POWER_TOGGLE_DIG_INPUT 3


/*
* ANALOG_INPUT
*/


#define __S2_Epson_ASCII_Proc_FROM_MODULE$_BUFFER_INPUT 0
#define __S2_Epson_ASCII_Proc_FROM_MODULE$_BUFFER_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Epson_ASCII_Proc, __FROM_MODULE$, __S2_Epson_ASCII_Proc_FROM_MODULE$_BUFFER_MAX_LEN );
#define __S2_Epson_ASCII_Proc_FROM_DEVICE$_BUFFER_INPUT 1
#define __S2_Epson_ASCII_Proc_FROM_DEVICE$_BUFFER_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Epson_ASCII_Proc, __FROM_DEVICE$, __S2_Epson_ASCII_Proc_FROM_DEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Epson_ASCII_Proc_POWER_ON_FB_DIG_OUTPUT 0
#define __S2_Epson_ASCII_Proc_POWER_OFF_FB_DIG_OUTPUT 1
#define __S2_Epson_ASCII_Proc_READY_DIG_OUTPUT 2


/*
* ANALOG_OUTPUT
*/
#define __S2_Epson_ASCII_Proc_LAMP_HOURS_ANALOG_OUTPUT 0
#define __S2_Epson_ASCII_Proc_BRIGHTNESS_FB_ANALOG_OUTPUT 1
#define __S2_Epson_ASCII_Proc_CONTRAST_FB_ANALOG_OUTPUT 2
#define __S2_Epson_ASCII_Proc_COLOR_FB_ANALOG_OUTPUT 3
#define __S2_Epson_ASCII_Proc_TINT_FB_ANALOG_OUTPUT 4
#define __S2_Epson_ASCII_Proc_SHARPNESS_FB_ANALOG_OUTPUT 5

#define __S2_Epson_ASCII_Proc_TO_MODULE$_STRING_OUTPUT 6
#define __S2_Epson_ASCII_Proc_TO_DEVICE$_STRING_OUTPUT 7


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
#define __S2_Epson_ASCII_Proc_STEMP_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Epson_ASCII_Proc, __STEMP, __S2_Epson_ASCII_Proc_STEMP_STRING_MAX_LEN );
#define __S2_Epson_ASCII_Proc_STEMP1_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Epson_ASCII_Proc, __STEMP1, __S2_Epson_ASCII_Proc_STEMP1_STRING_MAX_LEN );
#define __S2_Epson_ASCII_Proc_SQUEUE_ARRAY_NUM_ELEMS 20
#define __S2_Epson_ASCII_Proc_SQUEUE_ARRAY_NUM_CHARS 20
CREATE_STRING_ARRAY( S2_Epson_ASCII_Proc, __SQUEUE, __S2_Epson_ASCII_Proc_SQUEUE_ARRAY_NUM_ELEMS, __S2_Epson_ASCII_Proc_SQUEUE_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Epson_ASCII_Proc )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Epson_ASCII_Proc, __FROM_MODULE$ );
   DECLARE_STRING_STRUCT( S2_Epson_ASCII_Proc, __FROM_DEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Epson_ASCII_Proc )
{
   DECLARE_STRING_STRUCT( S2_Epson_ASCII_Proc, __STEMP );
   DECLARE_STRING_STRUCT( S2_Epson_ASCII_Proc, __STEMP1 );
   DECLARE_STRING_ARRAY( S2_Epson_ASCII_Proc, __SQUEUE );
   unsigned short __IPOWERREQUESTSENT;
   unsigned short __IREADY;
   unsigned short __INEXTSEND;
   unsigned short __INEXTSTORE;
   unsigned short __IPOWER;
   unsigned short __IFLAG1;
   unsigned short __IFLAG2;
   unsigned short __ILAMP;
   unsigned short __IBRIGHT;
   unsigned short __ICONTRAST;
   unsigned short __ICOLOR;
   unsigned short __ITINT;
   unsigned short __ISHARP;
};

DEFINE_WAITEVENT( S2_Epson_ASCII_Proc, WTIMEOUT );


#endif //__S2_EPSON_ASCII_PROC_H__

