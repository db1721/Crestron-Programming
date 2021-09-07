#ifndef __S2_TOWSON_ASSIGNABLE_LIST_H__
#define __S2_TOWSON_ASSIGNABLE_LIST_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Towson_Assignable_List_READYLATCH_DIG_INPUT 0

#define __S2_Towson_Assignable_List_ITEMSELECTEDFB_DIG_INPUT 1
#define __S2_Towson_Assignable_List_ITEMSELECTEDFB_ARRAY_LENGTH 10
#define __S2_Towson_Assignable_List_ITEMDISABLE_DIG_INPUT 11
#define __S2_Towson_Assignable_List_ITEMDISABLE_ARRAY_LENGTH 10
#define __S2_Towson_Assignable_List_LISTITEMSELECT_DIG_INPUT 21
#define __S2_Towson_Assignable_List_LISTITEMSELECT_ARRAY_LENGTH 10

/*
* ANALOG_INPUT
*/



#define __S2_Towson_Assignable_List_LISTITEMPOSITION_ANALOG_INPUT 0
#define __S2_Towson_Assignable_List_LISTITEMPOSITION_ARRAY_LENGTH 10
#define __S2_Towson_Assignable_List_ITEMNAME_STRING_INPUT 10
#define __S2_Towson_Assignable_List_ITEMNAME_ARRAY_NUM_ELEMS 10
#define __S2_Towson_Assignable_List_ITEMNAME_ARRAY_NUM_CHARS 40
CREATE_STRING_ARRAY( S2_Towson_Assignable_List, __ITEMNAME, __S2_Towson_Assignable_List_ITEMNAME_ARRAY_NUM_ELEMS, __S2_Towson_Assignable_List_ITEMNAME_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/

#define __S2_Towson_Assignable_List_ITEMSELECT_DIG_OUTPUT 0
#define __S2_Towson_Assignable_List_ITEMSELECT_ARRAY_LENGTH 10
#define __S2_Towson_Assignable_List_LISTITEMSELECTED_DIG_OUTPUT 10
#define __S2_Towson_Assignable_List_LISTITEMSELECTED_ARRAY_LENGTH 10
#define __S2_Towson_Assignable_List_LISTITEMENABLE_DIG_OUTPUT 20
#define __S2_Towson_Assignable_List_LISTITEMENABLE_ARRAY_LENGTH 10
#define __S2_Towson_Assignable_List_LISTITEMVISIBLE_DIG_OUTPUT 30
#define __S2_Towson_Assignable_List_LISTITEMVISIBLE_ARRAY_LENGTH 10

/*
* ANALOG_OUTPUT
*/


#define __S2_Towson_Assignable_List_LISTITEMNAME_STRING_OUTPUT 0
#define __S2_Towson_Assignable_List_LISTITEMNAME_ARRAY_LENGTH 10

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
CREATE_INTARRAY1D( S2_Towson_Assignable_List, __ORGINPOS, 10 );;


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

START_GLOBAL_VAR_STRUCT( S2_Towson_Assignable_List )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __ITEMSELECTEDFB );
   DECLARE_IO_ARRAY( __ITEMDISABLE );
   DECLARE_IO_ARRAY( __LISTITEMSELECT );
   DECLARE_IO_ARRAY( __ITEMSELECT );
   DECLARE_IO_ARRAY( __LISTITEMSELECTED );
   DECLARE_IO_ARRAY( __LISTITEMENABLE );
   DECLARE_IO_ARRAY( __LISTITEMVISIBLE );
   DECLARE_IO_ARRAY( __LISTITEMPOSITION );
   DECLARE_IO_ARRAY( __LISTITEMNAME );
   unsigned short __READY;
   DECLARE_INTARRAY( S2_Towson_Assignable_List, __ORGINPOS );
   DECLARE_STRING_ARRAY( S2_Towson_Assignable_List, __ITEMNAME );
};

START_NVRAM_VAR_STRUCT( S2_Towson_Assignable_List )
{
};



#endif //__S2_TOWSON_ASSIGNABLE_LIST_H__

