#ifndef __S2_BIAMP_TESIRA_PRESET_CONTROL_V1_5_H__
#define __S2_BIAMP_TESIRA_PRESET_CONTROL_V1_5_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Biamp_Tesira_Preset_Control_v1_5_RECALL_PRESET_DIG_INPUT 0


/*
* ANALOG_INPUT
*/

#define __S2_Biamp_Tesira_Preset_Control_v1_5_PRESET_NAME_NUMBER_STRING_INPUT 0
#define __S2_Biamp_Tesira_Preset_Control_v1_5_PRESET_NAME_NUMBER_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __PRESET_NAME_NUMBER, __S2_Biamp_Tesira_Preset_Control_v1_5_PRESET_NAME_NUMBER_STRING_MAX_LEN );

#define __S2_Biamp_Tesira_Preset_Control_v1_5_FROM_PROCESSOR$_BUFFER_INPUT 1
#define __S2_Biamp_Tesira_Preset_Control_v1_5_FROM_PROCESSOR$_BUFFER_MAX_LEN 1024
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __FROM_PROCESSOR$, __S2_Biamp_Tesira_Preset_Control_v1_5_FROM_PROCESSOR$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Biamp_Tesira_Preset_Control_v1_5_IS_INITIALIZED_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/

#define __S2_Biamp_Tesira_Preset_Control_v1_5_TO_PROCESSOR$_STRING_OUTPUT 0


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
#define __S2_Biamp_Tesira_Preset_Control_v1_5_PARSEDMODULEMSG_STRING_MAX_LEN 254
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __PARSEDMODULEMSG, __S2_Biamp_Tesira_Preset_Control_v1_5_PARSEDMODULEMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Preset_Control_v1_5_RESPONSEREQUESTMSG_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __RESPONSEREQUESTMSG, __S2_Biamp_Tesira_Preset_Control_v1_5_RESPONSEREQUESTMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Preset_Control_v1_5_RESPONSEMSG_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __RESPONSEMSG, __S2_Biamp_Tesira_Preset_Control_v1_5_RESPONSEMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Preset_Control_v1_5_PARSEVALUE_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __PARSEVALUE, __S2_Biamp_Tesira_Preset_Control_v1_5_PARSEVALUE_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Preset_Control_v1_5_TRASH_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __TRASH, __S2_Biamp_Tesira_Preset_Control_v1_5_TRASH_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __MYID;
   unsigned short __PARSINGMODULEBUSY;
   unsigned short __RESPONSEMODULEMSGID;
   unsigned short __HASSUBSCRIPTIONREGISTERED;
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __PARSEDMODULEMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __RESPONSEREQUESTMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __RESPONSEMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __PARSEVALUE );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __TRASH );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __PRESET_NAME_NUMBER );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5, __FROM_PROCESSOR$ );
};

START_NVRAM_VAR_STRUCT( S2_Biamp_Tesira_Preset_Control_v1_5 )
{
};



#endif //__S2_BIAMP_TESIRA_PRESET_CONTROL_V1_5_H__

