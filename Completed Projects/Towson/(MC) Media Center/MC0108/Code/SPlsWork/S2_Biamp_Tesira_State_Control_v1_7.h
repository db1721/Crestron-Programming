#ifndef __S2_BIAMP_TESIRA_STATE_CONTROL_V1_7_H__
#define __S2_BIAMP_TESIRA_STATE_CONTROL_V1_7_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Biamp_Tesira_State_Control_v1_7_POLL_STATE_DIG_INPUT 0
#define __S2_Biamp_Tesira_State_Control_v1_7_STATE_ON_DIG_INPUT 1
#define __S2_Biamp_Tesira_State_Control_v1_7_STATE_OFF_DIG_INPUT 2
#define __S2_Biamp_Tesira_State_Control_v1_7_STATE_TOGGLE_DIG_INPUT 3


/*
* ANALOG_INPUT
*/


#define __S2_Biamp_Tesira_State_Control_v1_7_FROM_PROCESSOR$_BUFFER_INPUT 0
#define __S2_Biamp_Tesira_State_Control_v1_7_FROM_PROCESSOR$_BUFFER_MAX_LEN 1024
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __FROM_PROCESSOR$, __S2_Biamp_Tesira_State_Control_v1_7_FROM_PROCESSOR$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Biamp_Tesira_State_Control_v1_7_IS_INITIALIZED_DIG_OUTPUT 0
#define __S2_Biamp_Tesira_State_Control_v1_7_STATE_IS_ON_DIG_OUTPUT 1
#define __S2_Biamp_Tesira_State_Control_v1_7_STATE_IS_OFF_DIG_OUTPUT 2


/*
* ANALOG_OUTPUT
*/

#define __S2_Biamp_Tesira_State_Control_v1_7_TO_PROCESSOR$_STRING_OUTPUT 0


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_Biamp_Tesira_State_Control_v1_7_INDEX1_INTEGER_PARAMETER 12
#define __S2_Biamp_Tesira_State_Control_v1_7_INDEX2_INTEGER_PARAMETER 13
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
#define __S2_Biamp_Tesira_State_Control_v1_7_INSTANCETAG_STRING_PARAMETER 10
#define __S2_Biamp_Tesira_State_Control_v1_7_STATETYPE_STRING_PARAMETER 11
#define __S2_Biamp_Tesira_State_Control_v1_7_INSTANCETAG_PARAM_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __INSTANCETAG, __S2_Biamp_Tesira_State_Control_v1_7_INSTANCETAG_PARAM_MAX_LEN );
#define __S2_Biamp_Tesira_State_Control_v1_7_STATETYPE_PARAM_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __STATETYPE, __S2_Biamp_Tesira_State_Control_v1_7_STATETYPE_PARAM_MAX_LEN );


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
#define __S2_Biamp_Tesira_State_Control_v1_7_PARSEDMODULEMSG_STRING_MAX_LEN 254
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __PARSEDMODULEMSG, __S2_Biamp_Tesira_State_Control_v1_7_PARSEDMODULEMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_State_Control_v1_7_RESPONSEREQUESTMSG_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __RESPONSEREQUESTMSG, __S2_Biamp_Tesira_State_Control_v1_7_RESPONSEREQUESTMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_State_Control_v1_7_RESPONSEMSG_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __RESPONSEMSG, __S2_Biamp_Tesira_State_Control_v1_7_RESPONSEMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_State_Control_v1_7_PARSEVALUE_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __PARSEVALUE, __S2_Biamp_Tesira_State_Control_v1_7_PARSEVALUE_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_State_Control_v1_7_TRASH_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __TRASH, __S2_Biamp_Tesira_State_Control_v1_7_TRASH_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Biamp_Tesira_State_Control_v1_7 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __MYID;
   unsigned short __MYCLASSCODE;
   unsigned short __PARSINGMODULEBUSY;
   unsigned short __RESPONSEMODULEMSGID;
   unsigned short __HASSUBSCRIPTIONREGISTERED;
   short __MYSTATEVALUE;
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __PARSEDMODULEMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __RESPONSEREQUESTMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __RESPONSEMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __PARSEVALUE );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __TRASH );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __FROM_PROCESSOR$ );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __INSTANCETAG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_State_Control_v1_7, __STATETYPE );
};

START_NVRAM_VAR_STRUCT( S2_Biamp_Tesira_State_Control_v1_7 )
{
};



#endif //__S2_BIAMP_TESIRA_STATE_CONTROL_V1_7_H__
