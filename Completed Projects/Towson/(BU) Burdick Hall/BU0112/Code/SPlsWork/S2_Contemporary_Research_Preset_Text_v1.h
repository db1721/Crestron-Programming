#ifndef __S2_CONTEMPORARY_RESEARCH_PRESET_TEXT_V1_H__
#define __S2_CONTEMPORARY_RESEARCH_PRESET_TEXT_V1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Contemporary_Research_Preset_Text_v1_SAVE_DIG_INPUT 0

#define __S2_Contemporary_Research_Preset_Text_v1_PRESET__DIG_INPUT 1
#define __S2_Contemporary_Research_Preset_Text_v1_PRESET__ARRAY_LENGTH 6

/*
* ANALOG_INPUT
*/

#define __S2_Contemporary_Research_Preset_Text_v1_TEXT_IN$_STRING_INPUT 0
#define __S2_Contemporary_Research_Preset_Text_v1_TEXT_IN$_STRING_MAX_LEN 5
CREATE_STRING_STRUCT( S2_Contemporary_Research_Preset_Text_v1, __TEXT_IN$, __S2_Contemporary_Research_Preset_Text_v1_TEXT_IN$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_Contemporary_Research_Preset_Text_v1_SAVE_ACT_FB_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/


#define __S2_Contemporary_Research_Preset_Text_v1_PRESET_TEXT$_STRING_OUTPUT 0
#define __S2_Contemporary_Research_Preset_Text_v1_PRESET_TEXT$_ARRAY_LENGTH 6

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
#define __S2_Contemporary_Research_Preset_Text_v1_S_ARRAY_NUM_ELEMS 6
#define __S2_Contemporary_Research_Preset_Text_v1_S_ARRAY_NUM_CHARS 5
CREATE_STRING_ARRAY( S2_Contemporary_Research_Preset_Text_v1, __S, __S2_Contemporary_Research_Preset_Text_v1_S_ARRAY_NUM_ELEMS, __S2_Contemporary_Research_Preset_Text_v1_S_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Contemporary_Research_Preset_Text_v1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __PRESET_ );
   DECLARE_IO_ARRAY( __PRESET_TEXT$ );
   DECLARE_STRING_STRUCT( S2_Contemporary_Research_Preset_Text_v1, __TEXT_IN$ );
};

START_NVRAM_VAR_STRUCT( S2_Contemporary_Research_Preset_Text_v1 )
{
   DECLARE_STRING_ARRAY( S2_Contemporary_Research_Preset_Text_v1, __S );
   unsigned short __I;
   unsigned short __SAVE_ACT;
};



#endif //__S2_CONTEMPORARY_RESEARCH_PRESET_TEXT_V1_H__

