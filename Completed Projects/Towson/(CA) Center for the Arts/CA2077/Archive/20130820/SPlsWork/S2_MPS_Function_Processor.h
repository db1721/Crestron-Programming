#ifndef __S2_MPS_FUNCTION_PROCESSOR_H__
#define __S2_MPS_FUNCTION_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/

#define __S2_MPS_Function_Processor_FUNCTIONPRESS_DIG_INPUT 0
#define __S2_MPS_Function_Processor_FUNCTIONPRESS_ARRAY_LENGTH 5

/*
* ANALOG_INPUT
*/



#define __S2_MPS_Function_Processor_FUNCTIONNAME$_STRING_INPUT 0
#define __S2_MPS_Function_Processor_FUNCTIONNAME$_ARRAY_NUM_ELEMS 5
#define __S2_MPS_Function_Processor_FUNCTIONNAME$_ARRAY_NUM_CHARS 32
CREATE_STRING_ARRAY( S2_MPS_Function_Processor, __FUNCTIONNAME$, __S2_MPS_Function_Processor_FUNCTIONNAME$_ARRAY_NUM_ELEMS, __S2_MPS_Function_Processor_FUNCTIONNAME$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_MPS_Function_Processor_FUNCTIONLINE1$_STRING_OUTPUT 0
#define __S2_MPS_Function_Processor_FUNCTIONLINE2$_STRING_OUTPUT 1


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

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_MPS_Function_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __FUNCTIONPRESS );
   DECLARE_STRING_ARRAY( S2_MPS_Function_Processor, __FUNCTIONNAME$ );
};

START_NVRAM_VAR_STRUCT( S2_MPS_Function_Processor )
{
};



#endif //__S2_MPS_FUNCTION_PROCESSOR_H__

