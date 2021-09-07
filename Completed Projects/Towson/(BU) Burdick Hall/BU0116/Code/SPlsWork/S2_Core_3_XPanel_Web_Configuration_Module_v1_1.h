#ifndef __S2_CORE_3_XPANEL_WEB_CONFIGURATION_MODULE_V1_1_H__
#define __S2_CORE_3_XPANEL_WEB_CONFIGURATION_MODULE_V1_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/



/*
* Direct Socket Variables
*/

#define __S2_Core_3_XPanel_Web_Configuration_Module_v1_1_SECURITYSERVER_SOCKET 0
#define __S2_Core_3_XPanel_Web_Configuration_Module_v1_1_SECURITYSERVER_STRING_MAX_LEN 1024
START_SOCKET_DEFINITION( S2_Core_3_XPanel_Web_Configuration_Module_v1_1, __SECURITYSERVER )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_Core_3_XPanel_Web_Configuration_Module_v1_1, SocketRxBuf, __S2_Core_3_XPanel_Web_Configuration_Module_v1_1_SECURITYSERVER_STRING_MAX_LEN );
};



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

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Core_3_XPanel_Web_Configuration_Module_v1_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_SOCKET( S2_Core_3_XPanel_Web_Configuration_Module_v1_1, __SECURITYSERVER );
};

START_NVRAM_VAR_STRUCT( S2_Core_3_XPanel_Web_Configuration_Module_v1_1 )
{
};



#endif //__S2_CORE_3_XPANEL_WEB_CONFIGURATION_MODULE_V1_1_H__

