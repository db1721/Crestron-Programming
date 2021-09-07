#ifndef __S2_BIAMP_TESIRA_COMMAND_PROCESSOR_V1_7_H__
#define __S2_BIAMP_TESIRA_COMMAND_PROCESSOR_V1_7_H__



/*
* STRUCTURE S2_Biamp_Tesira_Command_Processor_v1_7___MODULECOMM
*/
START_STRUCTURE_DEFINITION( S2_Biamp_Tesira_Command_Processor_v1_7, _MODULECOMM )
{
   unsigned short _MODULECOMM__ISREGISTERED;
   unsigned short _MODULECOMM__ISINITIALIZED;
};

/*
* STRUCTURE S2_Biamp_Tesira_Command_Processor_v1_7___COMMQUEUE
*/
#define _COMMQUEUE__S2_Biamp_Tesira_Command_Processor_v1_7_SLASTMESSAGE_STRING_MAX_LEN 150
START_STRUCTURE_DEFINITION( S2_Biamp_Tesira_Command_Processor_v1_7, _COMMQUEUE )
{
   CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, _COMMQUEUE__SLASTMESSAGE, _COMMQUEUE__S2_Biamp_Tesira_Command_Processor_v1_7_SLASTMESSAGE_STRING_MAX_LEN );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, _COMMQUEUE__SLASTMESSAGE );
   unsigned short _COMMQUEUE__NBUSY;
   unsigned short _COMMQUEUE__NHASITEMS;
   unsigned short _COMMQUEUE__NCOMMANDHEAD;
   unsigned short _COMMQUEUE__NCOMMANDTAIL;
   unsigned short _COMMQUEUE__NSTATUSHEAD;
   unsigned short _COMMQUEUE__NSTATUSTAIL;
   unsigned short _COMMQUEUE__NSTRIKECOUNT;
   unsigned short _COMMQUEUE__NRESENDLAST;
};


/*
* Constructor and Destructor
*/
int S2_Biamp_Tesira_Command_Processor_v1_7__MODULECOMM_Constructor ( START_STRUCTURE_DEFINITION( S2_Biamp_Tesira_Command_Processor_v1_7, _MODULECOMM ) * me, int nVerbose );
int S2_Biamp_Tesira_Command_Processor_v1_7__MODULECOMM_Destructor ( START_STRUCTURE_DEFINITION( S2_Biamp_Tesira_Command_Processor_v1_7, _MODULECOMM ) * me, int nVerbose );
int S2_Biamp_Tesira_Command_Processor_v1_7__COMMQUEUE_Constructor ( START_STRUCTURE_DEFINITION( S2_Biamp_Tesira_Command_Processor_v1_7, _COMMQUEUE ) * me, int nVerbose );
int S2_Biamp_Tesira_Command_Processor_v1_7__COMMQUEUE_Destructor ( START_STRUCTURE_DEFINITION( S2_Biamp_Tesira_Command_Processor_v1_7, _COMMQUEUE ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_Biamp_Tesira_Command_Processor_v1_7_INITIALIZE_DIG_INPUT 0
#define __S2_Biamp_Tesira_Command_Processor_v1_7_IS_RS232_DIG_INPUT 1
#define __S2_Biamp_Tesira_Command_Processor_v1_7_CONNECT_DIG_INPUT 2
#define __S2_Biamp_Tesira_Command_Processor_v1_7_DISCONNECT_DIG_INPUT 3


/*
* ANALOG_INPUT
*/


#define __S2_Biamp_Tesira_Command_Processor_v1_7_FROM_DEVICE$_BUFFER_INPUT 0
#define __S2_Biamp_Tesira_Command_Processor_v1_7_FROM_DEVICE$_BUFFER_MAX_LEN 10000
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __FROM_DEVICE$, __S2_Biamp_Tesira_Command_Processor_v1_7_FROM_DEVICE$_BUFFER_MAX_LEN );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_FROM_MODULES$_BUFFER_INPUT 1
#define __S2_Biamp_Tesira_Command_Processor_v1_7_FROM_MODULES$_BUFFER_MAX_LEN 50000
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __FROM_MODULES$, __S2_Biamp_Tesira_Command_Processor_v1_7_FROM_MODULES$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Biamp_Tesira_Command_Processor_v1_7_IS_INITIALIZED_DIG_OUTPUT 0
#define __S2_Biamp_Tesira_Command_Processor_v1_7_IS_COMMUNICATING_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/

#define __S2_Biamp_Tesira_Command_Processor_v1_7_TO_DEVICE$_STRING_OUTPUT 0

#define __S2_Biamp_Tesira_Command_Processor_v1_7_TO_MODULES$_STRING_OUTPUT 1
#define __S2_Biamp_Tesira_Command_Processor_v1_7_TO_MODULES$_ARRAY_LENGTH 100

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
#define __S2_Biamp_Tesira_Command_Processor_v1_7_PARSEDDEVICEMSG_STRING_MAX_LEN 3000
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __PARSEDDEVICEMSG, __S2_Biamp_Tesira_Command_Processor_v1_7_PARSEDDEVICEMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_ECHODEVICEMSG_STRING_MAX_LEN 3000
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __ECHODEVICEMSG, __S2_Biamp_Tesira_Command_Processor_v1_7_ECHODEVICEMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_PARSEDMODULEMSG_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __PARSEDMODULEMSG, __S2_Biamp_Tesira_Command_Processor_v1_7_PARSEDMODULEMSG_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_TRASH_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __TRASH, __S2_Biamp_Tesira_Command_Processor_v1_7_TRASH_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_MYPOTENTIALSUBSCRIPTION_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __MYPOTENTIALSUBSCRIPTION, __S2_Biamp_Tesira_Command_Processor_v1_7_MYPOTENTIALSUBSCRIPTION_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_MYSUBSCRIPTION_STRING_MAX_LEN 150
CREATE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __MYSUBSCRIPTION, __S2_Biamp_Tesira_Command_Processor_v1_7_MYSUBSCRIPTION_STRING_MAX_LEN );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_SCOMMANDQUEUE_ARRAY_NUM_ELEMS 50
#define __S2_Biamp_Tesira_Command_Processor_v1_7_SCOMMANDQUEUE_ARRAY_NUM_CHARS 150
CREATE_STRING_ARRAY( S2_Biamp_Tesira_Command_Processor_v1_7, __SCOMMANDQUEUE, __S2_Biamp_Tesira_Command_Processor_v1_7_SCOMMANDQUEUE_ARRAY_NUM_ELEMS, __S2_Biamp_Tesira_Command_Processor_v1_7_SCOMMANDQUEUE_ARRAY_NUM_CHARS );
#define __S2_Biamp_Tesira_Command_Processor_v1_7_SSTATUSQUEUE_ARRAY_NUM_ELEMS 200
#define __S2_Biamp_Tesira_Command_Processor_v1_7_SSTATUSQUEUE_ARRAY_NUM_CHARS 150
CREATE_STRING_ARRAY( S2_Biamp_Tesira_Command_Processor_v1_7, __SSTATUSQUEUE, __S2_Biamp_Tesira_Command_Processor_v1_7_SSTATUSQUEUE_ARRAY_NUM_ELEMS, __S2_Biamp_Tesira_Command_Processor_v1_7_SSTATUSQUEUE_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/
#define __S2_Biamp_Tesira_Command_Processor_v1_7_MODULECOMM_STRUCT_MAX_LEN 100
CREATE_STRUCTURE_ARRAY( S2_Biamp_Tesira_Command_Processor_v1_7, __MODULECOMM, _MODULECOMM, __S2_Biamp_Tesira_Command_Processor_v1_7_MODULECOMM_STRUCT_MAX_LEN );

START_GLOBAL_VAR_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __TO_MODULES$ );
   unsigned short __PARSINGDEVICEBUSY;
   unsigned short __RESPONSEMSGID;
   unsigned short __PARSINGMODULEBUSY;
   unsigned short __RESPONSEMODULEMSGID;
   unsigned short __INITMODULEID;
   unsigned short __REGMODULEID;
   unsigned short __ISINITIALIZING;
   unsigned short __ISREGISTERING;
   unsigned short __ISHEARTBEATING;
   unsigned short __ISRS232;
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __PARSEDDEVICEMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __ECHODEVICEMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __PARSEDMODULEMSG );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __TRASH );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __MYPOTENTIALSUBSCRIPTION );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __MYSUBSCRIPTION );
   DECLARE_STRING_ARRAY( S2_Biamp_Tesira_Command_Processor_v1_7, __SCOMMANDQUEUE );
   DECLARE_STRING_ARRAY( S2_Biamp_Tesira_Command_Processor_v1_7, __SSTATUSQUEUE );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __FROM_DEVICE$ );
   DECLARE_STRING_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, __FROM_MODULES$ );
   DECLARE_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7, _COMMQUEUE, __QUEUECOMM );
   DECLARE_STRUCT_ARRAY( S2_Biamp_Tesira_Command_Processor_v1_7, __MODULECOMM );
};

START_NVRAM_VAR_STRUCT( S2_Biamp_Tesira_Command_Processor_v1_7 )
{
};

DEFINE_WAITEVENT( S2_Biamp_Tesira_Command_Processor_v1_7, QUEUEFALSERESPONSE );
DEFINE_WAITEVENT( S2_Biamp_Tesira_Command_Processor_v1_7, HEARTBEAT );
DEFINE_WAITEVENT( S2_Biamp_Tesira_Command_Processor_v1_7, REGISTRATIONWAIT );
DEFINE_WAITEVENT( S2_Biamp_Tesira_Command_Processor_v1_7, STARTHEARTBEATPROCESS );


#endif //__S2_BIAMP_TESIRA_COMMAND_PROCESSOR_V1_7_H__

