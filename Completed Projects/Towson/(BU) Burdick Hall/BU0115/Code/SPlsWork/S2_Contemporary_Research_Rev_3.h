#ifndef __S2_CONTEMPORARY_RESEARCH_REV_3_H__
#define __S2_CONTEMPORARY_RESEARCH_REV_3_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Contemporary_Research_Rev_3_DIG_0_DIG_INPUT 0
#define __S2_Contemporary_Research_Rev_3_DIG_1_DIG_INPUT 1
#define __S2_Contemporary_Research_Rev_3_DIG_2_DIG_INPUT 2
#define __S2_Contemporary_Research_Rev_3_DIG_3_DIG_INPUT 3
#define __S2_Contemporary_Research_Rev_3_DIG_4_DIG_INPUT 4
#define __S2_Contemporary_Research_Rev_3_DIG_5_DIG_INPUT 5
#define __S2_Contemporary_Research_Rev_3_DIG_6_DIG_INPUT 6
#define __S2_Contemporary_Research_Rev_3_DIG_7_DIG_INPUT 7
#define __S2_Contemporary_Research_Rev_3_DIG_8_DIG_INPUT 8
#define __S2_Contemporary_Research_Rev_3_DIG_9_DIG_INPUT 9
#define __S2_Contemporary_Research_Rev_3_DASH_DIG_INPUT 10
#define __S2_Contemporary_Research_Rev_3_CH_UP_DIG_INPUT 11
#define __S2_Contemporary_Research_Rev_3_CH_DOWN_DIG_INPUT 12
#define __S2_Contemporary_Research_Rev_3_ENTER_DIG_INPUT 13
#define __S2_Contemporary_Research_Rev_3_CLEAR_DIG_INPUT 14

#define __S2_Contemporary_Research_Rev_3_PRESET_DIG_INPUT 15
#define __S2_Contemporary_Research_Rev_3_PRESET_ARRAY_LENGTH 6

/*
* ANALOG_INPUT
*/



#define __S2_Contemporary_Research_Rev_3_PRESET_VAL_IN$_STRING_INPUT 0
#define __S2_Contemporary_Research_Rev_3_PRESET_VAL_IN$_ARRAY_NUM_ELEMS 6
#define __S2_Contemporary_Research_Rev_3_PRESET_VAL_IN$_ARRAY_NUM_CHARS 5
CREATE_STRING_ARRAY( S2_Contemporary_Research_Rev_3, __PRESET_VAL_IN$, __S2_Contemporary_Research_Rev_3_PRESET_VAL_IN$_ARRAY_NUM_ELEMS, __S2_Contemporary_Research_Rev_3_PRESET_VAL_IN$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/

#define __S2_Contemporary_Research_Rev_3_PRESET_FB_DIG_OUTPUT 0
#define __S2_Contemporary_Research_Rev_3_PRESET_FB_ARRAY_LENGTH 6

/*
* ANALOG_OUTPUT
*/

#define __S2_Contemporary_Research_Rev_3_CURRENT_CHAN_STRING_OUTPUT 0
#define __S2_Contemporary_Research_Rev_3_TX$_STRING_OUTPUT 1

#define __S2_Contemporary_Research_Rev_3_PRESET_NAME$_STRING_OUTPUT 2
#define __S2_Contemporary_Research_Rev_3_PRESET_NAME$_ARRAY_LENGTH 6

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
#define __S2_Contemporary_Research_Rev_3_LAST_DIGIT_STRING_MAX_LEN 1
CREATE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __LAST_DIGIT, __S2_Contemporary_Research_Rev_3_LAST_DIGIT_STRING_MAX_LEN );
#define __S2_Contemporary_Research_Rev_3_CH_VAL_STRING_MAX_LEN 5
CREATE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __CH_VAL, __S2_Contemporary_Research_Rev_3_CH_VAL_STRING_MAX_LEN );
#define __S2_Contemporary_Research_Rev_3_STORED_CH_VAL_STRING_MAX_LEN 5
CREATE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __STORED_CH_VAL, __S2_Contemporary_Research_Rev_3_STORED_CH_VAL_STRING_MAX_LEN );
#define __S2_Contemporary_Research_Rev_3_RET_DATA_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __RET_DATA, __S2_Contemporary_Research_Rev_3_RET_DATA_STRING_MAX_LEN );
#define __S2_Contemporary_Research_Rev_3_RET_DATA2_STRING_MAX_LEN 20
CREATE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __RET_DATA2, __S2_Contemporary_Research_Rev_3_RET_DATA2_STRING_MAX_LEN );
#define __S2_Contemporary_Research_Rev_3_TEMP_RET_DATA1_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __TEMP_RET_DATA1, __S2_Contemporary_Research_Rev_3_TEMP_RET_DATA1_STRING_MAX_LEN );
#define __S2_Contemporary_Research_Rev_3_TEMP_RET_DATA2_STRING_MAX_LEN 1
CREATE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __TEMP_RET_DATA2, __S2_Contemporary_Research_Rev_3_TEMP_RET_DATA2_STRING_MAX_LEN );
#define __S2_Contemporary_Research_Rev_3_PRESET_VAL$_ARRAY_NUM_ELEMS 6
#define __S2_Contemporary_Research_Rev_3_PRESET_VAL$_ARRAY_NUM_CHARS 5
CREATE_STRING_ARRAY( S2_Contemporary_Research_Rev_3, __PRESET_VAL$, __S2_Contemporary_Research_Rev_3_PRESET_VAL$_ARRAY_NUM_ELEMS, __S2_Contemporary_Research_Rev_3_PRESET_VAL$_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Contemporary_Research_Rev_3 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __PRESET );
   DECLARE_IO_ARRAY( __PRESET_FB );
   DECLARE_IO_ARRAY( __PRESET_NAME$ );
   DECLARE_STRING_ARRAY( S2_Contemporary_Research_Rev_3, __PRESET_VAL_IN$ );
};

START_NVRAM_VAR_STRUCT( S2_Contemporary_Research_Rev_3 )
{
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __LAST_DIGIT );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __CH_VAL );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __STORED_CH_VAL );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __RET_DATA );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __RET_DATA2 );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __TEMP_RET_DATA1 );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Rev_3, __TEMP_RET_DATA2 );
   DECLARE_STRING_ARRAY( S2_Contemporary_Research_Rev_3, __PRESET_VAL$ );
   unsigned short __I;
   unsigned short __DIG_VAL;
   unsigned short __ACT_PRESET;
   unsigned short __IPRESET_SAVE;
   unsigned short __TEMP_CH_VAL;
};

DEFINE_WAITEVENT( S2_Contemporary_Research_Rev_3, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_CONTEMPORARY_RESEARCH_REV_3_H__

