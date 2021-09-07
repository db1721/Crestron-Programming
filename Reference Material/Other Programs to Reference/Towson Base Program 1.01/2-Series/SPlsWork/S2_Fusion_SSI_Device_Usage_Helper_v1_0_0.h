#ifndef __S2_FUSION_SSI_DEVICE_USAGE_HELPER_V1_0_0_H__
#define __S2_FUSION_SSI_DEVICE_USAGE_HELPER_V1_0_0_H__



/*
* STRUCTURE S2_Fusion_SSI_Device_Usage_Helper_v1_0_0__STRUCTUREDEVICE
*/
#define STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_SASSETTYPE$_STRING_MAX_LEN 50
#define STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_SASSETNAME$_STRING_MAX_LEN 50
#define STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_SASSETID$_STRING_MAX_LEN 50
START_STRUCTURE_DEFINITION( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE )
{
   CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE__SASSETTYPE$, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_SASSETTYPE$_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE__SASSETTYPE$ );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE__SASSETNAME$, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_SASSETNAME$_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE__SASSETNAME$ );
   CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE__SASSETID$, STRUCTUREDEVICE__S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_SASSETID$_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE__SASSETID$ );
   unsigned short STRUCTUREDEVICE__NINUSE;
   unsigned short STRUCTUREDEVICE__NCURRENTMINUTES;
   unsigned short STRUCTUREDEVICE__NCURRENTSECONDS;
};


/*
* Constructor and Destructor
*/
int S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_STRUCTUREDEVICE_Constructor ( START_STRUCTURE_DEFINITION( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE ) * me, int nVerbose );
int S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_STRUCTUREDEVICE_Destructor ( START_STRUCTURE_DEFINITION( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, STRUCTUREDEVICE ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD_DIG_INPUT 0
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_CLOCK_B_DIG_INPUT 1
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_SYSTEM_POWERED_OFF_HELD_DIG_INPUT 2

#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_DEVICE_IN_USE_HELD_DIG_INPUT 3
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_DEVICE_IN_USE_HELD_ARRAY_LENGTH 16

/*
* ANALOG_INPUT
*/

#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_MEETING_ID$_STRING_INPUT 0
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_MEETING_ID$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __MEETING_ID$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_MEETING_ID$_STRING_MAX_LEN );


#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_ID$_STRING_INPUT 1
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_ID$_ARRAY_NUM_ELEMS 16
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_ID$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_ID$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_ID$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_ID$_ARRAY_NUM_CHARS );
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE$_STRING_INPUT 17
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE$_ARRAY_NUM_ELEMS 16
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_TYPE$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE$_ARRAY_NUM_CHARS );
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME$_STRING_INPUT 33
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME$_ARRAY_NUM_ELEMS 16
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_NAME$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME$_ARRAY_NUM_CHARS );
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE_DIRECT$_STRING_INPUT 49
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE_DIRECT$_ARRAY_NUM_ELEMS 16
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE_DIRECT$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_TYPE_DIRECT$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE_DIRECT$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_TYPE_DIRECT$_ARRAY_NUM_CHARS );
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME_DIRECT$_STRING_INPUT 65
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME_DIRECT$_ARRAY_NUM_ELEMS 16
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME_DIRECT$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_NAME_DIRECT$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME_DIRECT$_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_ASSET_NAME_DIRECT$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_DEVICE_USAGE_TX$_STRING_OUTPUT 0

#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_CURRENT_USAGE_MINUTES_FB_ANALOG_OUTPUT 1
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_CURRENT_USAGE_MINUTES_FB_ARRAY_LENGTH 16

/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_DEBUGMODE_INTEGER_PARAMETER 10
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
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SPREVIOUSMEETINGID$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SPREVIOUSMEETINGID$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SPREVIOUSMEETINGID$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SCURRENTMEETINGID$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SCURRENTMEETINGID$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SCURRENTMEETINGID$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SCURRENTDATE$_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SCURRENTDATE$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SCURRENTDATE$_STRING_MAX_LEN );
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SCOMPAREDATE$_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SCOMPAREDATE$, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_SCOMPAREDATE$_STRING_MAX_LEN );

/*
* STRUCTURE
*/
#define __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_ODEVICES_STRUCT_MAX_LEN 16
CREATE_STRUCTURE_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_ODEVICES, STRUCTUREDEVICE, __S2_Fusion_SSI_Device_Usage_Helper_v1_0_0_G_ODEVICES_STRUCT_MAX_LEN );

START_GLOBAL_VAR_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __DEVICE_IN_USE_HELD );
   DECLARE_IO_ARRAY( __CURRENT_USAGE_MINUTES_FB );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SPREVIOUSMEETINGID$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SCURRENTMEETINGID$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SCURRENTDATE$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_SCOMPAREDATE$ );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __MEETING_ID$ );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_ID$ );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_TYPE$ );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_NAME$ );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_TYPE_DIRECT$ );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __ASSET_NAME_DIRECT$ );
   DECLARE_STRUCT_ARRAY( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0, __G_ODEVICES );
};

START_NVRAM_VAR_STRUCT( S2_Fusion_SSI_Device_Usage_Helper_v1_0_0 )
{
};



#endif //__S2_FUSION_SSI_DEVICE_USAGE_HELPER_V1_0_0_H__

