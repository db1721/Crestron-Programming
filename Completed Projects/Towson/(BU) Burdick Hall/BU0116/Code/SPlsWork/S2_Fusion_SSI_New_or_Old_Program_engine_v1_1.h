#ifndef __S2_FUSION_SSI_NEW_OR_OLD_PROGRAM_ENGINE_V1_1_H__
#define __S2_FUSION_SSI_NEW_OR_OLD_PROGRAM_ENGINE_V1_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_TRIGGER_DIG_INPUT 0


/*
* ANALOG_INPUT
*/


#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_CONSOLE_RX$_BUFFER_INPUT 0
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_CONSOLE_RX$_BUFFER_MAX_LEN 3000
CREATE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __CONSOLE_RX$, __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_CONSOLE_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_NEWPROGRAM_DIG_OUTPUT 0
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_EXISTINGPROGRAM_DIG_OUTPUT 1
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_DIFFERENTPROGRAM_DIG_OUTPUT 2
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_DIFFERENTCOMPILEDONDATE_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/

#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_CONSOLE_TX$_STRING_OUTPUT 0


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
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_SOURCEFILE_STRING_MAX_LEN 512
CREATE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __SOURCEFILE, __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_SOURCEFILE_STRING_MAX_LEN );
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_TEMPSOURCEFILE_STRING_MAX_LEN 512
CREATE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __TEMPSOURCEFILE, __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_TEMPSOURCEFILE_STRING_MAX_LEN );
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_TEMPCOMPILEDON_STRING_MAX_LEN 60
CREATE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __TEMPCOMPILEDON, __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_TEMPCOMPILEDON_STRING_MAX_LEN );
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_COMPILEDON_ARRAY_NUM_ELEMS 1
#define __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_COMPILEDON_ARRAY_NUM_CHARS 60
CREATE_STRING_ARRAY( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __COMPILEDON, __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_COMPILEDON_ARRAY_NUM_ELEMS, __S2_Fusion_SSI_New_or_Old_Program_engine_v1_1_COMPILEDON_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __TEMPSOURCEFILE );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __TEMPCOMPILEDON );
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __CONSOLE_RX$ );
};

START_NVRAM_VAR_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1 )
{
   DECLARE_STRING_STRUCT( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __SOURCEFILE );
   DECLARE_STRING_ARRAY( S2_Fusion_SSI_New_or_Old_Program_engine_v1_1, __COMPILEDON );
};



#endif //__S2_FUSION_SSI_NEW_OR_OLD_PROGRAM_ENGINE_V1_1_H__

