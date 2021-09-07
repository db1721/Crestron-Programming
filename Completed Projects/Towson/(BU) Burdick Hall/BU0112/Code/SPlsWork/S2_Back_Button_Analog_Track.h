#ifndef __S2_BACK_BUTTON_ANALOG_TRACK_H__
#define __S2_BACK_BUTTON_ANALOG_TRACK_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Back_Button_Analog_Track_BACK_DIG_INPUT 0


/*
* ANALOG_INPUT
*/
#define __S2_Back_Button_Analog_Track_IN_ANALOG_INPUT 0




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Back_Button_Analog_Track_OUT_ANALOG_OUTPUT 0



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
CREATE_INTARRAY1D( S2_Back_Button_Analog_Track, __HISTORY, 20 );;


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

START_GLOBAL_VAR_STRUCT( S2_Back_Button_Analog_Track )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_INTARRAY( S2_Back_Button_Analog_Track, __HISTORY );
};

START_NVRAM_VAR_STRUCT( S2_Back_Button_Analog_Track )
{
};



#endif //__S2_BACK_BUTTON_ANALOG_TRACK_H__

