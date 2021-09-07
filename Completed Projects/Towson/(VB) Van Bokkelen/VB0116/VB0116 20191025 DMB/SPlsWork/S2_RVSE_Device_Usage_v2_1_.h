#ifndef __S2_RVSE_DEVICE_USAGE_V2_1__H__
#define __S2_RVSE_DEVICE_USAGE_V2_1__H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_RVSE_Device_Usage_v2_1__ENABLE_LOG_ON_ID_CHANGE_DIG_INPUT 0
#define __S2_RVSE_Device_Usage_v2_1__RV_ONLINE_DIG_INPUT 1
#define __S2_RVSE_Device_Usage_v2_1__CLOCK_DIG_INPUT 2
#define __S2_RVSE_Device_Usage_v2_1__START_DIG_INPUT 3
#define __S2_RVSE_Device_Usage_v2_1__STOP_DIG_INPUT 4


/*
* ANALOG_INPUT
*/

#define __S2_RVSE_Device_Usage_v2_1__MEETING_ID$_STRING_INPUT 0
#define __S2_RVSE_Device_Usage_v2_1__MEETING_ID$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __MEETING_ID$, __S2_RVSE_Device_Usage_v2_1__MEETING_ID$_STRING_MAX_LEN );
#define __S2_RVSE_Device_Usage_v2_1__ASSET_ID$_STRING_INPUT 1
#define __S2_RVSE_Device_Usage_v2_1__ASSET_ID$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __ASSET_ID$, __S2_RVSE_Device_Usage_v2_1__ASSET_ID$_STRING_MAX_LEN );
#define __S2_RVSE_Device_Usage_v2_1__ASSET_TYPE$_STRING_INPUT 2
#define __S2_RVSE_Device_Usage_v2_1__ASSET_TYPE$_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __ASSET_TYPE$, __S2_RVSE_Device_Usage_v2_1__ASSET_TYPE$_STRING_MAX_LEN );
#define __S2_RVSE_Device_Usage_v2_1__ASSET_NAME$_STRING_INPUT 3
#define __S2_RVSE_Device_Usage_v2_1__ASSET_NAME$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __ASSET_NAME$, __S2_RVSE_Device_Usage_v2_1__ASSET_NAME$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_RVSE_Device_Usage_v2_1__LAST_USED_MINUTES_ANALOG_OUTPUT 0

#define __S2_RVSE_Device_Usage_v2_1__TO_RV_DEVICE_USAGE$_STRING_OUTPUT 1


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
#define __S2_RVSE_Device_Usage_v2_1__G_SLASTMEETINGID_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __G_SLASTMEETINGID, __S2_RVSE_Device_Usage_v2_1__G_SLASTMEETINGID_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_RVSE_Device_Usage_v2_1_ )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __G_ILASTUSEDMINUTES;
   unsigned short __G_ILASTUSEDSECONDS;
   unsigned short __G_IMODE;
   DECLARE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __G_SLASTMEETINGID );
   DECLARE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __MEETING_ID$ );
   DECLARE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __ASSET_ID$ );
   DECLARE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __ASSET_TYPE$ );
   DECLARE_STRING_STRUCT( S2_RVSE_Device_Usage_v2_1_, __ASSET_NAME$ );
};

START_NVRAM_VAR_STRUCT( S2_RVSE_Device_Usage_v2_1_ )
{
};



#endif //__S2_RVSE_DEVICE_USAGE_V2_1__H__

