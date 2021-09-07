#include "typedefs.h"

register union Globals_u *Globals asm ("%a5");
register union Nvram_u *Nvram asm ("%a4");

#include "fnctlist.h"
#include "Library.h"

#define LIB_TRUE    1
#define LIB_FALSE   0

#define TEMP_LINE_NUM   0

// Input/Output Array routines
void InitInOutArray(struct InOutArray_s *Array, int SignalType,
                    int StartInputNumber, int Length, char *NameString)
{
    if ( Array == NULL )
        return;

    Array->SignalType = SignalType;
    Array->StartInputNumber = StartInputNumber;
    Array->LastInputNumber = StartInputNumber + Length - 1;
    Array->LastModified = 0;
    Array->ArrayName = NameString;
}
void CheckInputArray(struct InOutArray_s *Array, struct Signal_s *Signal, unsigned short *GlobalLastModified)
{
    if ( (Array == NULL) || (Signal == NULL) || (GlobalLastModified == NULL) )
        return;

    if( (Signal->Type == Array->SignalType) &&
        (Signal->SignalNumber >= Array->StartInputNumber) &&
        (Signal->SignalNumber <= Array->LastInputNumber) )
    {
        Array->LastModified = Signal->SignalNumber - Array->StartInputNumber + 1;
        *GlobalLastModified = Array->LastModified;
        Signal->SignalNumber = Array->StartInputNumber;
        Signal->LastModified = Array->LastModified;
    }
}
void CheckStringInputArray(struct StringArrayHdr_s *Array, struct Signal_s *Signal, unsigned short *GlobalLastModified)
{
    if ( (Array == NULL) || (Signal == NULL) || (GlobalLastModified == NULL) )
        return;

    if( (Signal->Type == IO_TYPE_STRING_INPUT) &&
        (Signal->SignalNumber >= Array->StartInputNumber) &&
        (Signal->SignalNumber <= Array->LastInputNumber) )
    {
        Array->LastModified = Signal->SignalNumber - Array->StartInputNumber + 1;
        *GlobalLastModified = Array->LastModified;
        Signal->SignalNumber = Array->StartInputNumber;
        Signal->LastModified = Array->LastModified;
    }
}
// handled differently than SetArray because no local storage
void SetOutputArray(void *InstancePtr, struct InOutArray_s *Array, int Value)
{
    int i;
    if ( Array == NULL )
        return;

    for ( i = Array->StartInputNumber; i <= Array->LastInputNumber; i++)
    {
        if ( Array->SignalType == IO_TYPE_DIGITAL_OUTPUT)
            SetDigital(InstancePtr, i, Value);
        else if ( Array->SignalType == IO_TYPE_ANALOG_OUTPUT)
            SetAnalog(InstancePtr, i, Value);
    }
}
void SetStringOutputArray(void *InstancePtr,
                            struct InOutArray_s *Array,
                            struct StringHdr_s *String)
{
    int i;
    if ( Array == NULL )
        return;
    for ( i = Array->StartInputNumber; i <= Array->LastInputNumber; i++)
        SetSerial(InstancePtr, i, String);
}



// String Routines
void InitStringStruct(struct StringHdr_s *String, int InputType, int Length,
                        char *Name)
{
    int i;

    if ( String == NULL )
        return;

    String->InputType = InputType;
    String->MaxLen = Length;
    String->CurLen = 0;
    String->Name = Name;
    // initialize the extra four elements of the string to NULL to allow for string
    //      routines to work
    for ( i = Length; i < (Length + 4); i++)
        String->String[i] = NULL;
}


// Initialize string based on header
#define ERROR_DYN_STR_ALLOC "String %z allocation failure."
void InitDynamicStringStruct(void *InstancePtr, struct StringHdr_s *String, int InputType,
                             int Length, char *Name)
{
    int i;
    struct StringDynamicHdr_s * typeCastDynamicString;

    if ( String == NULL )
        return;

    String->InputType = InputType;
    String->MaxLen = Length;
    String->CurLen = 0;
    String->Name = Name;

    // initialize the extra four elements of the string to NULL to allow for string
    //      routines to work
    if (IsStringDynamic(InputType))
      {
        typeCastDynamicString = (struct StringDynamicHdr_s *)(String);
        typeCastDynamicString->String = Allocate(Length + 4);

        if (typeCastDynamicString->String == NULL)
          {
            Error(InstancePtr, sizeof(ERROR_DYN_STR_ALLOC)-1, ERROR_DYN_STR_ALLOC,
              String->Name);
            return NULL;
          }

        for ( i = Length; i < (Length + 4); i++)
            typeCastDynamicString->String[i] = NULL;

#ifdef MNT_RESIZE_DEBUG
        Print( InstancePtr , 29, "New String at location 0x%x\r\n", typeCastDynamicString->String );
#endif

      }
    else
      {
        for ( i = Length; i < (Length + 4); i++)
            String->String[i] = NULL;
      }
}

void InitNvramStringStruct(struct StringHdr_s *String, int InputType, int Length,
                        char *Name)
{
    int i;

    if ( String == NULL )
        return;

    String->InputType = InputType;
    String->MaxLen = Length;
    String->Name = Name;
    // initialize the extra four elements of the string to NULL to allow for string
    //      routines to work
    for ( i = Length; i < (Length + 4); i++)
        String->String[i] = NULL;

    if ( (String->MaxLen != Length) || (String->CurLen > Length))
        String->CurLen = 0;
}
void InitStringArray(struct StringArrayHdr_s *Array, int InputType, int NumElem,
                        int NumChar, char *Name, int Start)
{
    int i;

    if ( Array == NULL )
        return;

    Array->NumElem = NumElem;
    Array->Name = Name;
    Array->StartInputNumber = Start;
    Array->LastInputNumber = Start + NumElem - 1;
    Array->LastModified = 0;

    for ( i = 0; i <= NumElem; i++)
        InitStringStruct( GetStringArrayElement(NULL, Array, i), InputType, NumChar, Name);
}


void InitDynamicStringArray(void *InstancePtr, struct StringDynamicArrayHdr_s *Array, int InputType,
                            int NumElem, int NumChar, char *Name, int Start)
{
    int i;
    int error;

    if ( Array == NULL )
        return;

    Array->NumElem = NumElem | DYN_STR_ARRAY_FLAG;
    Array->Name = Name;
    Array->StartInputNumber = Start;
    Array->LastInputNumber = Start + NumElem - 1;
    Array->LastModified = 0;

    // Now Allocate memory for the String headers. Allocate one more???
    Array->Strings = Allocate((NumElem + 1)* sizeof(struct StringDynamicHdr_s));
    if ( Array->Strings == NULL )
    {
      // Assume that TerminateTask takes care of any memory allocated prior to this
      // in the task
      TerminateTask(InstancePtr, "Could not allocate local storage.  Terminating");
    }


    // if needed, use sprintf to add a numeric value to the name
    for ( i = 0; i <= NumElem; i++)
      {
        InitDynamicStringStruct( InstancePtr, GetStringArrayElement(InstancePtr, Array, i), InputType, NumChar, Name);
      }
}

//#define FOO_STRING "Start:%d, i:%d, NumElem:%d, NumChar:%d, Name:%z, AddrCurrLen: %08X, AddrName: %08X, AddrString: %08X"
void InitStringParamArray(void *InstancePtr, struct StringArrayHdr_s *Array, int InputType, int NumElem,
                        int NumChar, char *Name, int Start)
{
    int i,j;
    int NumChars;
    int Padding;
    unsigned char *Address;
    struct StringHdr_s *TempString;

    if ( Array == NULL )
        return;

    Array->NumElem = NumElem;
    Array->Name = Name;
    Array->StartInputNumber = Start;
    Array->LastInputNumber = Start + NumElem - 1;
    Array->LastModified = 0;

	Address = (unsigned char *)&(Array->Strings[0]);  // get starting address of Strings;
	NumChars = NumChar + 4;
	Padding = (NumChars % 2);           // GNU pads on a word boundary (2 bytes)
	if ( Padding != 0 )          // check for longword boundary
		NumChars = NumChars + (2 - Padding);
	NumChars += 16;                     // 16 handles (InputType, MaxLen, CurLen, Name)

    // Element 0 must be filled in so the GetStringArrayElement() routine will work later on!
    TempString = (struct StringHdr_s *)Address;
    TempString->InputType=InputType;
    TempString->MaxLen=NumChar;
    TempString->CurLen=0;
    TempString->Name=Name;
	for ( j = TempString->MaxLen; j < (TempString->MaxLen + 4); j++)
		TempString->String[j] = NULL;


    // Valid array elements are 1 through NumElem.  Element 0 is not used.
    for ( i = 1; i <= NumElem; i++)
    {
		TempString = (struct StringHdr_s *)(Address + i*NumChars);

		/*
		// test...
        Error(InstancePtr, sizeof(FOO_STRING)-1, FOO_STRING, Start, i, NumElem, NumChar, Name, &(TempString->CurLen), &(TempString->Name), &(TempString->String[0]));
		memcpy(TempString->String, "abcdefg", 7);
		TempString->InputType = InputType;
		TempString->MaxLen = NumChar;
		TempString->CurLen = 7;
		TempString->Name = Name;
		for ( j = TempString->MaxLen; j < (TempString->MaxLen + 4); j++)
			TempString->String[j] = NULL;
		*/
        InitStringParamStruct(InstancePtr, TempString, InputType, Start+i-1, NumChar, Name);
    }
}

void InitNvramStringArray(struct StringArrayHdr_s *Array, int InputType, int NumElem,
                        int NumChar, char *Name, int Start)
{
    int i;

    if ( Array == NULL )
        return;

    Array->NumElem = NumElem;
    Array->Name = Name;
    Array->StartInputNumber = Start;
    Array->LastInputNumber = Start + NumElem - 1;
    Array->LastModified = 0;

    for ( i = 0; i <= NumElem; i++)
        InitNvramStringStruct( GetStringArrayElement(NULL, Array, i), InputType, NumChar, Name);
}


// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
// This function will not work with dynamic strings - Investigate what this is being used for
// 12.04.06 - Based on what Ed said, this function is not being used by anybody - should this be
// removed?
// 12.05.06 - This will not work with dynamic string arrays
// Added dynamic array support
void SetStringArray(void *InstancePtr,
                            struct StringArrayHdr_s *Array,
                            struct StringHdr_s *String)
{
    int i;
    int NumChars;
    int Padding;
    unsigned char *Address;
    struct StringHdr_s *TempString;

    if ( (Array == NULL) || (String == NULL) )
        return;

    if (Array->NumElem & DYN_STR_ARRAY_FLAG)
      {
        // Call SetString on each element
        for (i=0; i<=(Array->NumElem & ~DYN_STR_ARRAY_FLAG); i++)
          {
              TempString = GetStringArrayElement(InstancePtr,
                Array,
                i);
              SetString(InstancePtr, String, 1, TempString);
          }

      }// Array is dynamic
    else // Array is dynamic
      {
    Address = (unsigned char *)&(Array->Strings[0]);  // get starting address of Strings;
    NumChars = Array->Strings[0].MaxLen + 4;
    Padding = (NumChars % 2);           // GNU pads on a word boundary (2 bytes)
    if ( Padding != 0 )          // check for longword boundary
        NumChars = NumChars + (2 - Padding);
    NumChars += 16;                     // 16 handles (InputType, MaxLen, CurLen, Name)
    for ( i = 0; i <= Array->NumElem; i++)
    {
        TempString = (struct StringHdr_s *)(Address + i*NumChars);
        memcpy(TempString->String, String->String, String->CurLen);
        TempString->CurLen = String->CurLen;
    }
      }// endif array is dynamic
}
void InitStructArray(struct StructArrayHdr_s *Array, int NumElem, int ElemSize, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumElements = NumElem;
    Array->ElementSize = ElemSize;
    Array->Name = Name;
}

void InitStructDynamicArray(void *InstancePtr, struct StructDynamicArrayHdr_s *Array, int NumElem, int ElemSize, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumElements = NumElem | DYN_STRUCT_ARRAY_FLAG;
    Array->ElementSize = ElemSize;
    Array->Name = Name;


    // At this point allocate memory for the structures header.
    Array->Structs = Allocate((NumElem + 1) * ElemSize);
    if ( Array->Structs == NULL )
    {
      // Assume that TerminateTask takes care of any memory allocated prior to this
      // in the task
      TerminateTask(InstancePtr, "Could not allocate local storage.  Terminating");
    }

    // Todo: call constructor at this point if needed

}


/**
 * \brief
 * Write brief comment for GetStringArrayElement here.
 *
 * \param InstancePtr
 * Description of parameter InstancePtr.
 *
 * \param Array
 * Description of parameter Array.
 *
 * \param Elem
 * Description of parameter Elem.
 *
 * \returns
 * Write description of return value here.
 *
 * \throws <exception class>
 * Description of criteria for throwing this exception.
 *
 * This function used to work on only non-dynamic strings. Modified
 * this to work with dynamic strings. Dynamic strings have the topmost
 * bit in the NumElements Field set to 1
 *
 * \remarks
 * Write remarks for GetStringArrayElement here.
 *
 * \see
 * Separate items with the '|' character.
 */
#define ERROR_FORMAT_STRING1 "String Array %z overflow.  Element = %d.  Bounds = %d"
struct StringHdr_s *GetStringArrayElement(void *InstancePtr, struct StringArrayHdr_s *Array, int Elem)
{
    int NumChars;
    int Padding;
    unsigned char *Address;
    int numElemInArray;
    struct StringDynamicArrayHdr_s *dynArray;
    int isDynamicFlag=0;

    // bounds checking
    if ( Array == NULL )
        return NULL;

    // If this is a dynamic array, we need to identify this.
    numElemInArray = (Array->NumElem & ~DYN_STR_ARRAY_FLAG);
    if (Array->NumElem & DYN_STR_ARRAY_FLAG)
      {
        isDynamicFlag = 1;
      }

    if ( (numElemInArray == 0) || (Elem < 0) || (Elem > numElemInArray) )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                Array->Name, Elem, numElemInArray);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (isDynamicFlag)
          {
            dynArray = (struct StringDynamicArrayHdr_s *) Array;
            return (struct StringHdr_s *)(dynArray->Strings);
          } //if (dynFlag)

        return NULL;
    }

    if (isDynamicFlag == 0) // non-dynamic array
      {
        Address = (unsigned char *)&(Array->Strings[0]);  // get starting address of Strings;
        NumChars = Array->Strings[0].MaxLen + 4;
        Padding = (NumChars % 2);           // GNU pads on a word boundary (2 bytes)
        if ( Padding != 0 )          // check for longword boundary
            NumChars = NumChars + (2 - Padding);

        Address = Address + (Elem * (NumChars + 16));  // 16 handles (InputType, MaxLen, CurLen, Name)
        return (struct StringHdr_s *)Address ;
      }
    else // dynamic array
      {
        dynArray = (struct StringDynamicArrayHdr_s *) Array;
        return (struct StringHdr_s *)((unsigned int)(dynArray->Strings)  +  (Elem * sizeof(struct StringDynamicHdr_s)) );
      }  // if check for dynamic array
}



#undef ERROR_FORMAT_STRING1
#define ERROR_FORMAT_STRING1 "String Output Array %z overflow.  Element = %d.  Bounds = 1 to %d"
int CheckStringOutputArrayIndex(void *InstancePtr, struct InOutArray_s *Array, int Index)
{
    if ( Array == NULL )
        return 0;

    Index--;                            // change from 1->len indexing to 0->len-1
    if ( (Index < 0) || (Index > (Array->LastInputNumber - Array->StartInputNumber)) )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                Array->ArrayName, Index+1, (Array->LastInputNumber - Array->StartInputNumber + 1));
        return 0;
    }
    else
        return 1;
}
#undef ERROR_FORMAT_STRING1
void *GetStructArrayElement(void *InstancePtr, struct StructArrayHdr_s *Array, int Elem)
{
    int ElemSize;
    int Padding;
    unsigned char *Address;
    struct StructDynamicArrayHdr_s * dynArray;
    int numElemInArray;
    int isDynamicFlag=0;

    // bounds checking
    if ( Array == NULL )
        return NULL;

    // If this is a dynamic array, we need to identify this.
    numElemInArray = (Array->NumElements & ~DYN_STRUCT_ARRAY_FLAG);
    if (Array->NumElements & DYN_STRUCT_ARRAY_FLAG)
      {
        isDynamicFlag = 1;
      }


    if(isDynamicFlag == 0) // Non-dynamic array
      {

        Address = (unsigned char *)&(Array->Structs[0]);  // get starting address of Strings;
        if ( !CheckStructArray(InstancePtr, Array, Elem) )
            return Address;

        ElemSize = Array->ElementSize;
        Padding = (ElemSize % 2);           // GNU pads on a word boundary (2 bytes)
        if ( Padding != 0 )          // check for longword boundary
            ElemSize = ElemSize + (2 - Padding);

        Address = Address + (Elem * ElemSize);
        return (void *)Address ;

      } // isdynamicflag == 0
    else
      {
        // Do range checking here as well
        dynArray = (struct StructDynamicArrayHdr_s *) Array;
        Address = (unsigned char *)(dynArray->Structs);
        ElemSize = dynArray->ElementSize;

        if ( !CheckStructArray(InstancePtr, Array, Elem) )
            return Address;

        return (void *)((unsigned int)(dynArray->Structs)  +  (Elem * ElemSize) );

      } // endif isdynamicflag == 0

}
#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
#define ERROR_FORMAT_STRING1 "Structure Array %z overflow (using element 0).  Element = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "Structure Array %z overflow (Empty Array).  Element = %d.  Bounds = %d"
int CheckStructArray(void *InstancePtr, struct StructArrayHdr_s *Array, int ElemNum)
{
    int numElemInArray;

    if ( Array == NULL )
        return 0;

    // If this is a dynamic array, we need to identify this.
    numElemInArray = (Array->NumElements & ~DYN_STRUCT_ARRAY_FLAG);

    if (numElemInArray == 0)
    {
      Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
              Array->Name, ElemNum, numElemInArray);
      return NULL;
    }

    if ( (ElemNum < 0) || (ElemNum > numElemInArray) )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                Array->Name, ElemNum, numElemInArray);
        return NULL;
    }
    else
        return 1;
}
#undef ERROR_FORMAT_STRING1
#define ERROR_FORMAT_STRING1 "String %z overflow.  Index = %d.  Current Length = %d, Bounds = %d"
unsigned short Bit(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber,
                    unsigned short BitNumber)
{
    int ActualByte, ActualBit;
    int Mask;

    if ( String == NULL )
        return 0xFFFF;

    // bounds checking
    if ( ByteNumber > String->CurLen )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                String->Name, ByteNumber, String->CurLen, String->MaxLen);
        return 0xFFFF;
    }
    ActualByte = (BitNumber / 8) + ByteNumber;
    if ( ActualByte > String->CurLen )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                String->Name, ByteNumber, String->CurLen, String->MaxLen);
        return 0xFFFF;
    }
    if ( ActualByte == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                String->Name, ByteNumber, String->CurLen, String->MaxLen);
        return 0xFFFF;
    }
    ActualByte--;                       // need to start indexing at 0, not 1
    ActualBit = BitNumber % 8;
    Mask = 0x01 << ActualBit;

    if ( GetCharFromString(String,ActualByte) & Mask )
        return 1;
    else
        return 0;

}
unsigned short Byte(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber)
{
    if ( String == NULL )
        return 0xFFFF;

    // bounds checking
    if ( ByteNumber > String->CurLen )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                String->Name, ByteNumber, String->CurLen, String->MaxLen);
        return 0xFFFF;
    }
    if ( ByteNumber == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                String->Name, ByteNumber, String->CurLen, String->MaxLen);
        return 0xFFFF;
    }
    ByteNumber--;                       // need to start indexing at 0, not 1

    return GetCharFromString(String,ByteNumber);

}

unsigned short SetByte(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber, unsigned short Value)
{
    if ( String == NULL )
        return 0xFFFF;

    // bounds checking
    if ( ByteNumber > String->CurLen )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                String->Name, ByteNumber, String->CurLen, String->MaxLen);
        return 0xFFFF;
    }
    if ( ByteNumber == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                String->Name, ByteNumber, String->CurLen, String->MaxLen);
        return 0xFFFF;
    }

    ByteNumber--;                       // need to start indexing at 0, not 1

	*(GetCharAddrFromStringOffset(String, ByteNumber)) = (unsigned char)Value;

	return(0);
}

unsigned short UNS_SetByte(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber, unsigned short Value)
{
	*(GetCharAddrFromStringOffset(String, ByteNumber-1)) = (unsigned char)Value;

	return(0);
}

#undef ERROR_FORMAT_STRING1
unsigned short High(unsigned short Value)
{
    Value >>= 8;                        // shift bits to right
    return Value & 0x00FF;
}
unsigned short Low(unsigned short Value)
{
    return Value & 0x00FF;
}
unsigned short HighWord(unsigned long Value)
{
    Value >>= 16;                        // shift bits to right
    return Value & 0x0000FFFF;
}
unsigned short LowWord(unsigned long Value)
{
    return Value & 0x0000FFFF;
}
char *FindNumericChar(char *StartPtr)
{
    // search for first alphanumeric character
    while ( !((*StartPtr >= '0') && (*StartPtr <= '9')) && (*StartPtr != NULL))
        StartPtr++;
    return StartPtr;
}

unsigned short Atoi(struct StringHdr_s *String)
{
    int Value;
    unsigned char * cPtr;

    if ( String == NULL )
        return 0;

    // put in terminating Null character
    cPtr = GetCharAddrFromString(String);
    cPtr[String->CurLen] = 0;

    Value = atoi(FindNumericChar(GetCharAddrFromString(String)));

    if ( Value < 0)
        Value = -Value;                 // only allow positive numbers

    return (unsigned short)(Value & 0xFFFF);
}

short Atosi(struct StringHdr_s *String)  // allow for signed integers
{
    int Value;

    if ( String == NULL )
        return 0;

    Value = atoi(FindNumericChar(GetCharAddrFromString(String)));

    return (short)(Value & 0xFFFF);
}

unsigned long Atol(struct StringHdr_s *String)
{
    int Value;
    unsigned char * cPtr;

    if ( String == NULL )
        return 0;

    // put in terminating Null character
    cPtr = GetCharAddrFromString(String);
    cPtr[String->CurLen] = 0;
    Value = atoi(FindNumericChar(GetCharAddrFromString(String)));

    if ( Value < 0)
        Value = -Value;                 // only allow positive numbers

    return (unsigned long)Value;
}
long Atosl(struct StringHdr_s *String)  // allow for signed integers
{
    int Value;

    if ( String == NULL )
        return 0;

    Value = atoi(FindNumericChar(GetCharAddrFromString(String)));

    return (long)Value;
}
struct StringHdr_s* Chr(struct StringHdr_s *OutString, int Code)
{
    unsigned char * cPtr;

    if ( OutString == NULL )
        return NULL;

    cPtr = GetCharAddrFromString(OutString);
    cPtr[0] = Code & 0xFF;
    OutString->CurLen = 1;

    return OutString;
}
struct StringHdr_s* Itoa(void *InstancePtr, struct StringHdr_s *OutString, int Code)
{
    if ( OutString == NULL )
        return NULL;

    if (FormatString(InstancePtr, OutString, sizeof("%d")-1, "%d", (Code & 0xFFFF)) <= 0)
    {
        // printing of error handled in FormatString
        OutString->CurLen = 0;
    }
    return OutString;
}
struct StringHdr_s* Itohex(void *InstancePtr, struct StringHdr_s *OutString, int Code)
{
    if ( OutString == NULL )
        return NULL;

    if (FormatString(InstancePtr, OutString, sizeof("%X")-1, "%X", (Code & 0xFFFF)) <= 0)
    {
        // printing of error handled in FormatString
        OutString->CurLen = 0;
    }
    return OutString;
}
struct StringHdr_s* Ltoa(void *InstancePtr, struct StringHdr_s *OutString, long Code)
{
    if ( OutString == NULL )
        return NULL;

    if (FormatString(InstancePtr, OutString, sizeof("%d")-1, "%d", Code) <= 0)
    {
        // printing of error handled in FormatString
        OutString->CurLen = 0;
    }
    return OutString;
}
struct StringHdr_s* Ltohex(void *InstancePtr, struct StringHdr_s *OutString, long Code)
{
    if ( OutString == NULL )
        return NULL;

    if (FormatString(InstancePtr, OutString, sizeof("%X")-1, "%X", Code) <= 0)
    {
        // printing of error handled in FormatString
        OutString->CurLen = 0;
    }
    return OutString;
}
unsigned short Abs(short Value)
{
    if ( Value < 0)
        return -Value;
    else
        return Value;
}
unsigned short Max(unsigned short Value1, unsigned short Value2)
{
    return (Value1 > Value2) ? Value1 : Value2;
}
unsigned short Min(unsigned short Value1, unsigned short Value2)
{
    return (Value1 < Value2) ? Value1 : Value2;
}
#define ERROR_FORMAT_STRING1 "Divide by Zero."
unsigned short Muldiv(void *InstancePtr, unsigned short Value1, unsigned short Value2, unsigned short Value3)
{
    unsigned long Result;

    if ( Value3 == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1);
        return 0;
    }
    Result = (unsigned long)Value1 * (unsigned long)Value2;
    Result = Result / ((unsigned long)Value3);

    return (unsigned short)Result;
}
unsigned long Divide(void *InstancePtr, unsigned long Numerator, unsigned long Denominator)
{
    unsigned long Result;

    if ( Denominator == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1);
        return 0;
    }
    Result = Numerator / Denominator;

    return (unsigned long)Result;
}

int CheckDenominator(void *InstancePtr, int Denominator)
{
    if ( Denominator == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1);
        return 0;
    }
    return 1;
}

short SMax(short Value1, short Value2)
{
    return (Value1 > Value2) ? Value1 : Value2;
}
short SMin(short Value1, short Value2)
{
    return (Value1 < Value2) ? Value1 : Value2;
}
short SMuldiv(void *InstancePtr, short Value1, short Value2, short Value3)
{
    long Result;

    if ( Value3 == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1);
        return 0;
    }
    Result = (long)Value1 * (long)Value2;
    Result = Result / ((long)Value3);

    return (short)Result;
}
long SDivide(void *InstancePtr, long Numerator, long Denominator)
{
    long Result;

    if ( Denominator == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1);
        return 0;
    }
    Result = Numerator / Denominator;

    return (long)Result;
}
unsigned long UMod(void *InstancePtr, unsigned long Numerator, unsigned long Denominator)
{
    unsigned long Result;

    if ( Denominator == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1);
        return 0;
    }
    Result = Numerator % Denominator;

    return (unsigned long)Result;
}

long Mod(void *InstancePtr, long Numerator, long Denominator)
{
    long Result;

    if ( Denominator == 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1);
        return 0;
    }
    Result = Numerator % Denominator;

    return (long)Result;
}

#undef ERROR_FORMAT_STRING1
unsigned short Rnd(void)
{
    unsigned long Random1, Random2;

    Random1 = (unsigned long)rand();
    Random2 = (unsigned long)rand();

    Random1 <<= 1;                      // make into 16 bit number
    Random1 |= (Random2 & 0x0001);       // OR in lsb of second random number

    return (unsigned short)Random1;
}
unsigned short Random(unsigned short LowerBound, unsigned short UpperBound)
{
    unsigned long Range;
    unsigned long RandMultiplier;
    int Round;

    Range = (UpperBound - LowerBound);
    RandMultiplier = (unsigned long)Rnd();
    Range = Range * RandMultiplier;
    if ( Range & 0x00008000)            // see if bit 15 is set for rounding
        Round = 1;
    else
        Round = 0;
    Range = (Range >> 16) + Round;

    return LowerBound + Range;
}
void Seed(unsigned short SeedValue)
{
    srand(SeedValue);
}
#define HIGH_WORD 0
#define LOW_WORD  1
unsigned short RotateLeft(unsigned short Number, unsigned short ShiftAmount)
{
    unsigned short LocalShift;
    union
    {
        unsigned long Lvalue;
        unsigned short Svalue[2];
    } Data;
    unsigned short RetValue;

    LocalShift = ShiftAmount % 16;
    Data.Svalue[HIGH_WORD] = 0;
    Data.Svalue[LOW_WORD] = Number;
    Data.Lvalue = (Data.Lvalue << LocalShift);
    RetValue = Data.Svalue[HIGH_WORD] | Data.Svalue[LOW_WORD];

    return RetValue;
}
unsigned short RotateRight(unsigned short Number, unsigned short ShiftAmount)
{
    unsigned short LocalShift;
    union
    {
        unsigned long Lvalue;
        unsigned short Svalue[2];
    } Data;
    unsigned short RetValue;

    LocalShift = ShiftAmount % 16;
    Data.Svalue[LOW_WORD] = 0;
    Data.Svalue[HIGH_WORD] = Number;
    Data.Lvalue = (Data.Lvalue >> LocalShift);
    RetValue = Data.Svalue[HIGH_WORD] | Data.Svalue[LOW_WORD];

    return RetValue;
}
unsigned long RotateLeftLong(unsigned long Number, unsigned short ShiftAmount)
{
    unsigned short LocalShift;
    unsigned long ShiftLeft,ShiftRight;
    unsigned long RetValue;

    LocalShift = ShiftAmount % 32;
    ShiftLeft = Number;
    ShiftRight = Number;
    ShiftLeft = (ShiftLeft << LocalShift);
    ShiftRight = (ShiftRight >> (32 - LocalShift));
    RetValue = ShiftLeft | ShiftRight;

    return RetValue;
}
unsigned long RotateRightLong(unsigned long Number, unsigned short ShiftAmount)
{
    unsigned short LocalShift;
    unsigned long ShiftLeft,ShiftRight;
    unsigned long RetValue;

    LocalShift = ShiftAmount % 32;
    ShiftLeft = Number;
    ShiftRight = Number;
    ShiftLeft = (ShiftLeft << (32 - LocalShift));
    ShiftRight = (ShiftRight >> LocalShift);
    RetValue = ShiftLeft | ShiftRight;

    return RetValue;
}
void ClearBuffer(struct StringHdr_s *String)
{
    String->CurLen = 0;

    CheckBufferThreshold(String);
}

//RETURNS:
// 0 if the strings are identical
//-1 if String1 is less than string2
// 1 if String1 is greater than string2

// Dynamic string comparison makes the code very ugly and slow. If this is
// a problem, we will have to convert this one function into 4 (with dynamic
// inputs for String1 and String2 independently.
int CompareStrings(struct StringHdr_s *String1,
                   struct StringHdr_s *String2,
                   int caseSensitive)
{
    unsigned int len, i;
    unsigned char ch1,ch2;

    if ( (String1 == NULL) || (String2 == NULL) )
        return -1;

    if( String1->CurLen == 0 )
    {
        if( String2->CurLen == 0 )
            return 0;
        else
            // force the string to be greater so that empty strings are at the bottom of the list.
            return 1;
    }
    if( String2->CurLen == 0 )
    {
        // force the string to be greater so that empty strings are at the bottom of the list.
        return -1;
    }

    len = String1->CurLen;
    if(String2->CurLen < len)
        len = String2->CurLen;


    for(i = 0; i < len; i++)
    {
        if ( caseSensitive )
        {
          ch1 = GetCharFromString(String1,i);
          ch2 = GetCharFromString(String2,i);
        } // if caseSensitive
        else // else if caseSensitive
        {
          ch1 = MakeUpper(GetCharFromString(String1,i));
          ch2 = MakeUpper(GetCharFromString(String2,i));
        } // endif caseSensitive

        if(ch1 > ch2)
            return 1;
        else if(ch1 < ch2)
            return -1;
    }


    //first parts were identical, see who is longer
    if(String1->CurLen < String2->CurLen)
        return -1;
    if(String1->CurLen > String2->CurLen)
        return 1;

    return 0; //they're identical
}

int Find(struct StringHdr_s *Match, struct StringHdr_s *Source,
            unsigned start, int caseSensitive)
{
    unsigned StartIndex, i, j;
    unsigned char Itest, Jtest;

    if ( (Match == NULL) || (Source == NULL) )
        return 0;

    StartIndex = 0;
    if ((Source->CurLen != 0) && (Match->CurLen != 0))
    {
        if ( (Source->CurLen < Match->CurLen) || (start > Source->CurLen) )
            return 0;

        for ( i = start-1, j = 0; i < Source->CurLen; i++)
        {
            if ( caseSensitive )
            {
              Itest = GetCharFromString(Source,i);
              Jtest = GetCharFromString(Match,j);
            } // if case Sensitive
            else // else case Sensitive
            {
              Itest = MakeUpper(GetCharFromString(Source,i));
              Jtest = MakeUpper(GetCharFromString(Match,j));
            } // end if case Sensitive

            if ( Itest == Jtest )
            {
                j++;                    // increment first so that CurLen is correct
                if ( j == 1 )
                    StartIndex = i+1;
                if ( j == Match->CurLen )
                    return StartIndex;
                }
            else
            {
                j = 0;                  // no match set back to beginning of match string.
                if ( StartIndex > 0 )   // a match was started.
                {
                    i = StartIndex-1;   // set i back to start of match so that when incremented
                }                       // it will start the search at the next possible match
                StartIndex = 0;         // i.e.  searching for "HELLO" in "HHELLO"
            }
        }
    }
    return 0; //can't find it
}



/**
 * \brief
 * Resizes a dynamic string to newSize characters
 *
 * \param InstancePtr
 *
 * \param dStr
 * Pointer to the dynamic string
 *
 * \param newSize
 *
 * \param verbose
 * Indicates whether error messages should be logged.
 *
 * \returns
 * Write description of return value here.
    Status	Definition
    0	      Success
    0x8001	Generic Error
    0x8002	Error – Max Resize limit reached
    0x8004	Error – Element is not dynamic
    0x8008	Warning – Truncation will occur
    0x8010	Error – Out of memory
    0x8020	Error – Out of memory
    0x8040	Error – Out of memory
 *
 *
 *  IF THIS FUNCTION IS MODIFIED HERE, IT SHOULD BE MODIFIED IN FIRMWARE AS WELL
 *  THIS FUNCTIONALITY HAS BEEN REPRODUCED HERE BECAUSE WE HAVE TO RESIZE THE STRING
 *  IN FORMATSTRING
 *
 */
#define ERROR_RESIZE_STRING1 "MAX LIMIT REACHED. String %z cannot be resized to %d."
#define ERROR_RESIZE_STRING2 "NON DYNAMIC. String %z cannot be resized to %d."
#define ERROR_RESIZE_STRING3 "TRUNCATION. String %z will be truncated to %d from %d."
#define ERROR_RESIZE_STRING4 "ALLOC FAILED. String %z could not be resized."
int ResizeString(void *InstancePtr, struct StringDynamicHdr_s *dStr, int newSize, int verbose)
  {
    unsigned int strCtr, strMax;
    unsigned char * newString;
    unsigned char * oldString;
    int retval;

    retval = DYN_RESIZE_ERROR_NOERROR; // success

    // error checking here
    if (dStr == NULL)
      {
        return DYN_RESIZE_ERROR_NULL   ;
      }
    if (newSize > MAX_STRING_SIZE)
      {
        if (verbose)
          {
            Error(InstancePtr, sizeof(ERROR_RESIZE_STRING1)-1, ERROR_RESIZE_STRING1,
              dStr->Name, newSize);
          }
        return DYN_RESIZE_ERROR_MAX_LIMIT;
      }
    if (!IsStringDynamic(dStr->InputType))
      {
        if (verbose)
          {
            Error(InstancePtr, sizeof(ERROR_RESIZE_STRING2)-1, ERROR_RESIZE_STRING2,
              dStr->Name, newSize);
          }
        return DYN_RESIZE_ERROR_NON_DYNAMIC;
      }

#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 24, "Resizing from %d to %d\r\n", dStr->MaxLen, newSize);
#endif

    // Warn about truncation if size smaller than original string
    if (newSize < dStr->MaxLen)
      {
        if (verbose)
          {
            ExtendedError(eERROR_LEVEL_WARNING,InstancePtr, sizeof(ERROR_RESIZE_STRING3)-1, ERROR_RESIZE_STRING3,
              dStr->Name, newSize, dStr->MaxLen);
          }
        strMax = newSize;

        retval = DYN_RESIZE_ERROR_TRUNCATION; // return string truncated

      }
    else
      {
        strMax = dStr->MaxLen;
      }


    // Check to see if a 0 was passed in - 0 means delete memory associated with the string
    // MNT - 9/7/2007 - newSize can now be 0 because we have one additional element
    // MNT - 9/14/2007 - We deallocate memory only if we are asked to force the deallocation
      if (newSize == -1)
        {
          dStr->CurLen = 0;
          dStr->MaxLen = 0;
          if (dStr->String)
            {
              Deallocate(dStr->String);
              dStr->String = NULL;
            } // if (dStr->String)
          return retval;
        } // if (newSize == -1)


#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 19, "Allocating memory\r\n");
#endif

    // Allocate memory for the new string
    newString = Allocate(newSize + 4);

    if (newString == NULL)
      {
        if (verbose)
          {
            Error(InstancePtr, sizeof(ERROR_RESIZE_STRING4)-1, ERROR_RESIZE_STRING4,
              dStr->Name);
          }
        return DYN_RESIZE_ERROR_ALLOC_FAILED;
      }

#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 29, "New String at location 0x%x\r\n", newString );
#endif

    oldString = (unsigned char *)(dStr->String);

#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 36, "Copying %d bytes from 0x%x to 0x%x\r\n", strMax, oldString, newString );
#endif

    // Copy the old string into the new one
    // should this copy 4 more bytes?
    // use memcpy?
    // Make sure we don't copy from an empty string
    if (dStr->String)
      {
        memcpy(newString, oldString, strMax);
      } // endif old string esists

#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 15, "Copied String\r\n" );
#endif

    // Update the string
    dStr->MaxLen = newSize;
    if (dStr->CurLen > newSize)
      {
        dStr->CurLen = newSize;
      }

#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 27, "DeAllocating Pointer 0x%x\r\n", dStr->String);
#endif

    // Let deallocate throw errors if necessary - handle if needed
    if (dStr->String)
      {
        Deallocate(dStr->String);
        dStr->String = NULL;
      }
    dStr->String = newString;

#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 16, "Dealloc String\r\n" );
#endif

    return retval;

  }





/**
 * \brief
 * Write brief comment for ResizeStringArray here.
 *
 * \param InstancePtr
 * Description of parameter InstancePtr.
 *
 * \param dStrArr
 * Description of parameter dStrArr.
 *
 * \param newSize
 * Description of parameter newSize.
 *
 * \returns
 * Write description of return value here.
 *
 * \throws <exception class>
 * Description of criteria for throwing this exception.
 *
 * We detect if the string array is dynamic or not by looking at the topmost bit.
 * This creates a restriction on the max size of the array (2^31-1 elements).
 *
 * \remarks
 * This function can completely fragment the heap - use with caution
 *
 * \see
 * Separate items with the '|' character.
 */
#define ERROR_RESIZE_STRARR_STRING1 "MAX LIMIT REACHED. String Array %z cannot be resized to %d."
#define ERROR_RESIZE_STRARR_STRING2 "NON DYNAMIC. String Array %z cannot be resized to %d."
#define ERROR_RESIZE_STRARR_STRING3 "TRUNCATION. String Array %z will be truncated to %d, %d from %d, %d."
#define ERROR_RESIZE_STRARR_STRING4 "ALLOC FAILED. String Array %z could not be resized."
#define ERROR_RESIZE_STRARR_STRING5 "ELEMENT RSZ FAILED. String Array %z could not be resized."
#define ERROR_RESIZE_STRARR_STRING6 "ELEMENT CREATE FAILED. String Array %z could not be resized."
int ResizeStringArray(void *InstancePtr, struct StringDynamicArrayHdr_s *dStrArr, int newSize, int newNumChar, int verbose)
  {
    unsigned int arrMax, charMax;
    struct StringDynamicHdr_s * newStrings;
    struct StringDynamicHdr_s * oldStrings;
    struct StringHdr_s * tempString;
    int retval;
    unsigned int numElem;
    int arrCtr;
    int error;
    int currNumChar = 0;


    retval = DYN_RESIZE_ERROR_NOERROR; // success

    // error checking here
    if (dStrArr == NULL)
      {
        return DYN_RESIZE_ERROR_NULL   ;
      }
    if (newSize > MAX_STRINGARRAY_SIZE)
      {
        Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING1)-1, ERROR_RESIZE_STRARR_STRING1,
          dStrArr->Name, newSize);
        return DYN_RESIZE_ERROR_MAX_LIMIT;
      }

    // We need to use the top most bit to find out if the array is dynamic
    if (!(dStrArr->NumElem & DYN_STR_ARRAY_FLAG))
      {
        Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING2)-1, ERROR_RESIZE_STRARR_STRING2,
          dStrArr->Name, newSize);
        return DYN_RESIZE_ERROR_NON_DYNAMIC;
      }

    // Warn about truncation if size smaller than original string

    // We need to remove the top most bit to find out the number of elements
    numElem = (dStrArr->NumElem & ~DYN_STR_ARRAY_FLAG);

    if (numElem)
      {
        // Get the first string to find out the size. This should not return
        // an error.
        tempString = GetStringArrayElement(InstancePtr, dStrArr, 0);
        currNumChar = tempString->MaxLen;
      }// get string array element only if we have elements in the array

    if (newSize < numElem)
      {
        retval = DYN_RESIZE_ERROR_TRUNCATION; // return string truncated
        arrMax = newSize;
      } // newsize is less than number of elements
    else
      {
        arrMax = numElem;
      } // newsize is greater than number of elements


    // First check to make sure that
    if (newNumChar < currNumChar)
      {
        retval = DYN_RESIZE_ERROR_TRUNCATION; // return string truncated
        charMax = newNumChar;
      }
    else
      {
        charMax = currNumChar;
      }

      if (retval & DYN_RESIZE_ERROR_TRUNCATION)
        {
        if (verbose)
          {
            ExtendedError(eERROR_LEVEL_WARNING,InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING3)-1, ERROR_RESIZE_STRARR_STRING3,
                dStrArr->Name, newSize, newNumChar, numElem,currNumChar);
          }
        }

      // First see if the user wants to deallocate space for the array. If the user passes in
      // a 0 for the newChar, but not for newSize, the next few lines will just deallocate
      // memory for strings. Check for an empty array first
      // MNT - 9/7/2007 - Do not deallocate memory if the newsize is set to 0
      // MNT - 9/14/2007 - The newsize == -1 should deallocate any memory associated
      // with the structure
      if (newSize == -1)
        {
          if (numElem != 0)
            {
              for (arrCtr = 0; arrCtr <= numElem; arrCtr++)
                {
                  error = ResizeString(InstancePtr,
                         (struct StringDynamicHdr_s *)(GetStringArrayElement(InstancePtr,dStrArr,arrCtr)),
                          -1,
                          0); // supress error reporting and force deallocate
                  if (!((error == DYN_RESIZE_ERROR_NOERROR) || (error == DYN_RESIZE_ERROR_TRUNCATION)))
                    {
                      Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING5)-1, ERROR_RESIZE_STRARR_STRING5,
                        dStrArr->Name);
                      return (retval | DYN_RESIZE_ERROR_ELMRSZ_FAILED);
                    } // error
                } //for arrCtr
            } // numElem != 0

          // Now deallocate memory created for strings
          if (dStrArr->Strings)
            {
              Deallocate(dStrArr->Strings);
              dStrArr->Strings = NULL;
            }

          // Update the string array size
          dStrArr->NumElem = DYN_STR_ARRAY_FLAG;

          return retval;

        } // newsize == -1


      // First resize each string if needed - this entire operation will be in/efficient
      // based on whether we are growing the array or reducing it. If we resize strings
      // first, the resize takes care of doing the memcpys
      if (newNumChar != currNumChar)
        {
          // There are (numElem + 1) elements in the array !!!
          for (arrCtr = 0; arrCtr < (numElem + 1); arrCtr++)
            {
              error = ResizeString(InstancePtr,
                      (struct StringDynamicHdr_s *)(GetStringArrayElement(InstancePtr,dStrArr,arrCtr)),
                      newNumChar,
                      0); // supress error reporting and don't force deallocation
              // We are not forcing deallocation because the user might resize a string array to
              // empty strings.

              // if we have a non truncation error, return
              if (!((error == DYN_RESIZE_ERROR_NOERROR) || (error == DYN_RESIZE_ERROR_TRUNCATION)))
                {
                  Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING5)-1, ERROR_RESIZE_STRARR_STRING5,
                    dStrArr->Name);
                  return (retval | DYN_RESIZE_ERROR_ELMRSZ_FAILED);
                } // error
            } //for arrCtr
        } // if numChars will change


      // At this point, the number of columns will be correct. If the new number of elements is
      // less, all we need to do is deallocate memory for each of the strings, create a new
      // memory for the strings header and copy over the correct number of string headers.
      // If the number of new elements is more, allocate new memory for the string headers, copy
      // the string headers over, allocate memory for the strings and assign them to the new block
      // of string headers created.
      // Each of the above cases will have to deal with 1-based arrays.
      if (newSize != numElem)
        {
          if (newSize < numElem) // will never be equal here
            {
              // There are (numElem + 1) elements in the array !!!
              for (arrCtr = (newSize + 1); arrCtr <= numElem; arrCtr++)
                {
                  ResizeString(InstancePtr,
                    GetStringArrayElement(InstancePtr, dStrArr, arrCtr),
                    -1,
                    0); // delete memory associated with the string and force deallocation
                  // suppress error reporting
                  // We are forcing deallocation because we need to deallocate memory for each
                  // string.
                } // for every element above newSize

              // Now create a new structure that will hold all the string headers
              // Allocate one more
              oldStrings = dStrArr->Strings;
              newStrings = Allocate((newSize + 1)* sizeof(struct StringDynamicHdr_s));
              if ( newStrings == NULL )
              {
                Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING4)-1, ERROR_RESIZE_STRARR_STRING4,
                  dStrArr->Name);
                return (retval | DYN_RESIZE_ERROR_ALLOC_FAILED);
              }

              // At this point, we need to copy the elements from 0 to newsize (newsize+1 elements)
              // to the new structure and physically delete the old string header structure.
              // Make sure that the old string array was not empty
              // MNT - 9/7/2007 - numElem == 0  now preserves one element
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
              if (numElem != 0)
                {
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM - check for numelem
                  memcpy((unsigned char *)(newStrings),   // dest
                    (unsigned char *) (oldStrings),       // src
                    (newSize + 1)* sizeof( struct StringDynamicHdr_s ) ); //size

#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
                } // numElem !=0
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM - check for numelem
              if (oldStrings)
                {
                  Deallocate(oldStrings);
                  oldStrings = NULL;
                }

              dStrArr->Strings = newStrings;

              // Update the string array size
              dStrArr->NumElem = newSize | DYN_STR_ARRAY_FLAG;

            } // if newSize < numElem
          else // => newSize > numElem
            {

              // Now create a new structure that will hold all the string headers
              // Allocate one more. Keeping the oldstrings intact, assign a new
              // set of bytes for the headers
              oldStrings = dStrArr->Strings;
              newStrings = Allocate((newSize + 1)* sizeof(struct StringDynamicHdr_s));
              if ( newStrings == NULL )
              {
                Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING4)-1, ERROR_RESIZE_STRARR_STRING4,
                  dStrArr->Name);
                return (retval | DYN_RESIZE_ERROR_ALLOC_FAILED);
              }

              dStrArr->Strings = newStrings;

              // At this point, we need to copy the elements from 0 to numElem (numElem+1 elements)
              // to the new structure, physically delete the old string header structure and create
              // new elements needed
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
              if (numElem != 0)
                {
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM - numelem=0 leaves one element
                memcpy((unsigned char *)(newStrings),   // dest
                    (unsigned char *) (oldStrings),       // src
                    (numElem + 1)* sizeof( struct StringDynamicHdr_s ) ); //size
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
                } // numElem !=0
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM - numelem=0 leaves one element
              // Update the string array size
              dStrArr->NumElem = newSize | DYN_STR_ARRAY_FLAG;

              // if needed, use sprintf to add a numeric value to the name
              // There are (numElem + 1) elements in the array !!!
              for (arrCtr = (numElem + 1); arrCtr <= newSize; arrCtr++)
                {
                  InitDynamicStringStruct( InstancePtr, GetStringArrayElement(InstancePtr, dStrArr, arrCtr), e_INPUT_TYPE_STRING_DYNAMIC, newNumChar, dStrArr->Name);
                } // for every element above newSize

              if (oldStrings)
                {
                  Deallocate(oldStrings);
                  oldStrings = NULL;
                }

            } // newsize < numElem


        } // if newsize != numElem



    return retval;

  }



#define ERROR_RESIZE_INTARR_STRING1 "MAX LIMIT REACHED. Integer Array %z cannot be resized to %d, %d."
#define ERROR_RESIZE_INTARR_STRING2 "NON DYNAMIC. Integer Array %z cannot be resized to %d, %d."
#define ERROR_RESIZE_INTARR_STRING3 "TRUNCATION. Integer Array %z will be truncated to %d, %d from %d, %d."
#define ERROR_RESIZE_INTARR_STRING1_1D "MAX LIMIT REACHED. Integer Array %z cannot be resized to %d."
#define ERROR_RESIZE_INTARR_STRING2_1D "NON DYNAMIC. Integer Array %z cannot be resized to %d."
#define ERROR_RESIZE_INTARR_STRING3_1D "TRUNCATION. Integer Array %z will be truncated to %d from %d."
#define ERROR_RESIZE_INTARR_STRING4 "ALLOC FAILED. Integer Array %z could not be resized."
#define ERROR_RESIZE_INTARR_STRING5 "ELEMENT RSZ FAILED. Integer Array %z could not be resized."
#define ERROR_RESIZE_INTARR_STRING6 "ELEMENT CREATE FAILED. Integer Array %z could not be resized."
#define ERROR_RESIZE_INTARR_STRING7 "ILLEGAL TYPE. Integer Array %z could not be resized."
int ResizeIntegerArray(void *InstancePtr, struct IntDynamicArrayHdr_s *dIntArr, int NumRows, int NumCols, enum EIntArrType type, int verbose)
  {
    unsigned int rowMax, colMax;
    unsigned short  * newData;
    unsigned short  * oldData;
    short           * newDataSI;
    short           * oldDataSI;
    unsigned long * newDataLI;
    unsigned long * oldDataLI;
    long          * newDataSLI;
    long          * oldDataSLI;
    int retval;
    unsigned int currCols, currRows;
    int rowCtr, colCtr;
    int error;
    int srcIndex, destIndex;
    int isOneD = 1;

    retval = DYN_RESIZE_ERROR_NOERROR; // success

    // error checking here
    if (dIntArr == NULL)
      {
        return DYN_RESIZE_ERROR_NULL   ;
      }

    // At this point we know that the array exists. Figure out if the array is 1 or 2 dimensional
    if (dIntArr->NumRows & ~DYN_INT_ARRAY_FLAG)
      {
        isOneD = 0; // since number of rows is 0
      }

    if ((NumCols > MAX_INTARRAY_SIZE) || (NumRows > MAX_INTARRAY_SIZE))
      {
        if (isOneD)
          {
            Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING1_1D)-1, ERROR_RESIZE_INTARR_STRING1_1D,
              dIntArr->Name, NumCols);
          }
        else // isOneD
          {
        Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING1)-1, ERROR_RESIZE_INTARR_STRING1,
          dIntArr->Name, NumRows, NumCols);
          } // endif isOneD
        return DYN_RESIZE_ERROR_MAX_LIMIT;
      }

    // We need to use the top most bit to find out if the array is dynamic
    if (!(dIntArr->NumCols & DYN_INT_ARRAY_FLAG))
      {
        if (isOneD)
          {
            Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING2_1D)-1, ERROR_RESIZE_INTARR_STRING2_1D,
              dIntArr->Name, NumCols);
          }
        else // isOneD
          {
        Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING2)-1, ERROR_RESIZE_INTARR_STRING2,
              dIntArr->Name, NumRows, NumCols);
          } // endif isOneD
        return DYN_RESIZE_ERROR_NON_DYNAMIC;
      }


#ifdef MNT_RESIZE_DEBUG
    Print( InstancePtr , 32, "Resizing from %d, %d to %d, %d\r\n", ((dIntArr->NumRows) & DYN_INT_ARRAY_FLAG), ((dIntArr->NumCols) & DYN_INT_ARRAY_FLAG) , numRows, numCols);
#endif

    // Warn about truncation if size smaller than original string

    // We need to remove the top most bit to find out the number of elements
    currCols = ((dIntArr->NumCols) & ~DYN_INT_ARRAY_FLAG);
    currRows = ((dIntArr->NumRows) & ~DYN_INT_ARRAY_FLAG);
    if (NumRows < currRows)
      {
        retval = DYN_RESIZE_ERROR_TRUNCATION; // return array truncation
        rowMax = NumRows;
      }
    else
      {
        rowMax = currRows;
      }


    if (NumCols < currCols)
      {
        retval = DYN_RESIZE_ERROR_TRUNCATION; // return array truncation
        colMax = NumCols;
      }
    else
      {
        colMax = currCols;
      }

      if (retval & DYN_RESIZE_ERROR_TRUNCATION)
        {
        if (verbose)
          {
            if (isOneD)
              {
                ExtendedError(eERROR_LEVEL_WARNING,InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING3_1D)-1, ERROR_RESIZE_INTARR_STRING3_1D,
                    dIntArr->Name, NumCols, currCols);
              }
            else // isOneD
              {
                ExtendedError(eERROR_LEVEL_WARNING, InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING3)-1, ERROR_RESIZE_INTARR_STRING3,
                    dIntArr->Name, NumRows, NumCols,currRows, currCols);
              } // endif isOneD
          }
        }

      // MNT - 9/7/2007 - Do not deallocate memory if we resize to zero - this way we have atleast
      // one element in the array
      // MNT - 9/14/2007 - Clear memory on forced deallocation
      // First see if the user wants to deallocate space for the array. This piece of code is destructive
      // If NumCols number is 0, no space is allocated for any integer!!
      if (NumCols == -1)
        {
          // Update the array size
          dIntArr->NumCols = DYN_INT_ARRAY_FLAG;
          dIntArr->NumRows = DYN_INT_ARRAY_FLAG;
          // Now deallocate memory created for the integers
          if (dIntArr->Data)
            {
              Deallocate(dIntArr->Data);
              dIntArr->Data = NULL;
            }
          return retval;
        } // newsize == -1

      // At this point, make sure that we do need to resize
      if ((NumCols != currCols) || (NumRows != currRows))
        {

          // Allocate space based on type. Copy data from old to new and then
          // delete old pointer
          if (type == e_INTARR_TYPE_INT)
            {
              newData = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(unsigned short));
              if (newData == NULL)
                {
                  Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING4)-1, ERROR_RESIZE_INTARR_STRING4,
                    dIntArr->Name);
                  return DYN_RESIZE_ERROR_ALLOC_FAILED;
                }
              // Initialize to 0
              memset(newData, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(unsigned short)));

              oldData = (unsigned short *)(dIntArr->Data);

              // Copy the old data into the new one - check the edge condition
              // if row/col max is 0, should this work?
              // row/col Max are based on the maximum number of items we can copy
              // because it is the minumum of the current and requested number
              // Assume arrays can be 0 or 1 based. In addition, make sure that we
              // don't copy from an empty array
              // MNT - 9/7/2007 - colMax can now be 0 because we have one additional element
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
              if (colMax != 0)
                {
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter
                  for (rowCtr=0; rowCtr<=rowMax; rowCtr++)
                    {
                      for (colCtr=0; colCtr<=colMax; colCtr++)
                        {
                          srcIndex = (rowCtr * (currCols+1)) + colCtr;
                          destIndex = (rowCtr * (NumCols+1)) + colCtr;
                          newData[destIndex] = oldData[srcIndex];
                        } //for col ctr
                    } //for row ctr
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
                } // colMax != 0
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter

              // Update the array
              dIntArr->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
              dIntArr->NumRows = NumRows | DYN_INT_ARRAY_FLAG;

              // Let deallocate throw errors if necessary - handle if needed
              if(dIntArr->Data)
                {
                  Deallocate(dIntArr->Data);
                  dIntArr->Data = NULL;
                }
              dIntArr->Data = newData;

            } // if type = e_INTARR_TYPE_INT
          else if (type == e_INTARR_TYPE_SIGNEDINT)
            {
              newDataSI = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(short));
              if (newDataSI == NULL)
                {
                  Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING4)-1, ERROR_RESIZE_INTARR_STRING4,
                    dIntArr->Name);
                  return DYN_RESIZE_ERROR_ALLOC_FAILED;
                }
              memset(newDataSI, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(short)));

              oldDataSI = (short *)(dIntArr->Data);

              // Copy the old data into the new one - check the edge condition
              // if row/col max is 0, should this work?
              // row/col Max are based on the maximum number of items we can copy
              // because it is the minumum of the current and requested number
              // Assume arrays can be 0 or 1 based. In addition, make sure that we
              // don't copy from an empty array
              // MNT - 9/7/2007 - colMax can now be 0 because we have one additional element
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
              if (colMax != 0)
                {
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter
                  for (rowCtr=0; rowCtr<=rowMax; rowCtr++)
                    {
                      for (colCtr=0; colCtr<=colMax; colCtr++)
                        {
                          srcIndex = (rowCtr * (currCols+1)) + colCtr;
                          destIndex = (rowCtr * (NumCols+1)) + colCtr;
                          newDataSI[destIndex] = oldDataSI[srcIndex];
                        } //for col ctr
                    } //for row ctr
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
                } // colMax != 0
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter

              // Update the array
              dIntArr->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
              dIntArr->NumRows = NumRows | DYN_INT_ARRAY_FLAG;

              // Let deallocate throw errors if necessary - handle if needed
              if (dIntArr->Data)
                {
                  Deallocate(dIntArr->Data);
                  dIntArr->Data = NULL;
                }
              dIntArr->Data = newDataSI;

            } // if type = e_INTARR_TYPE_SIGNEDINT
          else if (type == e_INTARR_TYPE_LONG)
            {
              newDataLI = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(unsigned long));
              if (newDataLI == NULL)
                {
                  Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING4)-1, ERROR_RESIZE_INTARR_STRING4,
                    dIntArr->Name);
                  return DYN_RESIZE_ERROR_ALLOC_FAILED;
                }
              memset(newDataLI, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(unsigned long)));

              oldDataLI = (unsigned long *)(dIntArr->Data);

              // Copy the old data into the new one - check the edge condition
              // if row/col max is 0, should this work?
              // row/col Max are based on the maximum number of items we can copy
              // because it is the minumum of the current and requested number
              // Assume arrays can be 0 or 1 based. In addition, make sure that we
              // don't copy from an empty array
              // MNT - 9/7/2007 - colMax can now be 0 because we have one additional element
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
              if (colMax != 0)
                {
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter
                  for (rowCtr=0; rowCtr<=rowMax; rowCtr++)
                    {
                      for (colCtr=0; colCtr<=colMax; colCtr++)
                        {
                          srcIndex = (rowCtr * (currCols+1)) + colCtr;
                          destIndex = (rowCtr * (NumCols+1)) + colCtr;
                          newDataLI[destIndex] = oldDataLI[srcIndex];
                        } //for col ctr
                    } //for row ctr
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
                } // colMax != 0
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter

              // Update the array
              dIntArr->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
              dIntArr->NumRows = NumRows | DYN_INT_ARRAY_FLAG;

              // Let deallocate throw errors if necessary - handle if needed
              if(dIntArr->Data)
                {
                  Deallocate(dIntArr->Data);
                  dIntArr->Data = NULL;
                }
              dIntArr->Data = newDataLI;

            } // if type = e_INTARR_TYPE_LONG
          else if (type == e_INTARR_TYPE_SIGNEDLONG)
            {
              newDataSLI = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(long));
              if (newDataSLI == NULL)
                {
                  Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING4)-1, ERROR_RESIZE_INTARR_STRING4,
                    dIntArr->Name);
                  return DYN_RESIZE_ERROR_ALLOC_FAILED;
                }
              memset(newDataSLI, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(long)));

              oldDataSLI = (long *)(dIntArr->Data);

              // Copy the old data into the new one - check the edge condition
              // if row/col max is 0, should this work?
              // row/col Max are based on the maximum number of items we can copy
              // because it is the minumum of the current and requested number
              // Assume arrays can be 0 or 1 based. In addition, make sure that we
              // don't copy from an empty array
              // MNT - 9/7/2007 - colMax can now be 0 because we have one additional element
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
              if (colMax != 0)
                {
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter
                  for (rowCtr=0; rowCtr<=rowMax; rowCtr++)
                    {
                      for (colCtr=0; colCtr<=colMax; colCtr++)
                        {
                          srcIndex = (rowCtr * (currCols+1)) + colCtr;
                          destIndex = (rowCtr * (NumCols+1)) + colCtr;
                          newDataSLI[destIndex] = oldDataSLI[srcIndex];
                        } //for col ctr
                    } //for row ctr
#ifdef DEALLOCATE_MEM_FOR_ZEROTH_ELEM
                } // colMax != 0
#endif // DEALLOCATE_MEM_FOR_ZEROTH_ELEM -- to allow 0 as a resize to parameter

              // Update the array
              dIntArr->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
              dIntArr->NumRows = NumRows | DYN_INT_ARRAY_FLAG;

              // Let deallocate throw errors if necessary - handle if needed
              if (dIntArr->Data)
                {
                  Deallocate(dIntArr->Data);
                  dIntArr->Data = NULL;
                }
              dIntArr->Data = newDataSLI;

            } // if type = e_INTARR_TYPE_SIGNEDLONG
          else
            {
              //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
              //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
              // This should never happen - we control this!!!!
              //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
              //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
              Error(InstancePtr, sizeof(ERROR_RESIZE_INTARR_STRING7)-1, ERROR_RESIZE_INTARR_STRING7,
                    dIntArr->Name);

            }//type checking catchall

        } // if array needs to be resized



    return retval;

  }







#define ERROR_RESIZE_STRUCTARR_STRING1 "MAX LIMIT REACHED. Struct Array %z cannot be resized to %d."
#define ERROR_RESIZE_STRUCTARR_STRING2 "NON DYNAMIC. Struct Array %z cannot be resized to %d."
#define ERROR_RESIZE_STRUCTARR_STRING3 "TRUNCATION. Struct Array %z will be truncated to %d from %d."
#define ERROR_RESIZE_STRUCTARR_STRING4 "ALLOC FAILED. Struct Array %z could not be resized."
#define ERROR_RESIZE_STRUCTARR_STRING5 "ELEMENT RSZ FAILED. Struct Array %z could not be resized."
#define ERROR_RESIZE_STRUCTARR_STRING6 "ELEMENT CREATE FAILED. Struct Array %z could not be resized."
int ResizeStructArray(void *InstancePtr, struct StructDynamicArrayHdr_s *dStructArray, int newSize, int verbose)
  {
    unsigned int arrCtr, arrMax;
    char * newStructs;
    char * oldStructs;
    int retval;
    int numElements;
    int error = 0;
    struct StructStructHdr_s * elem;

    retval = DYN_RESIZE_ERROR_NOERROR; // success

    // error checking here
    if (dStructArray == NULL)
      {
        return DYN_RESIZE_ERROR_NULL   ;
      }
    if (newSize > MAX_STRUCTARRAY_SIZE)
      {
        Error(InstancePtr, sizeof(ERROR_RESIZE_STRUCTARR_STRING1)-1, ERROR_RESIZE_STRUCTARR_STRING1,
          dStructArray->Name, newSize);
        return DYN_RESIZE_ERROR_MAX_LIMIT;
      }
    // We need to use the top most bit in the numelements to find out if the array is dynamic
    if (!(dStructArray->NumElements & DYN_STRUCT_ARRAY_FLAG))
      {
        Error(InstancePtr, sizeof(ERROR_RESIZE_STRUCTARR_STRING2)-1, ERROR_RESIZE_STRUCTARR_STRING2,
          dStructArray->Name, newSize);
        return DYN_RESIZE_ERROR_NON_DYNAMIC;
      }


    // Warn about truncation if size smaller than original string
    numElements = dStructArray->NumElements & ~DYN_STRUCT_ARRAY_FLAG;
    if (newSize < numElements)
      {
        if (verbose)
          {
            ExtendedError(eERROR_LEVEL_WARNING,InstancePtr, sizeof(ERROR_RESIZE_STRUCTARR_STRING3)-1, ERROR_RESIZE_STRUCTARR_STRING3,
                dStructArray->Name, newSize, numElements);
          }
        arrMax = newSize;

        retval = DYN_RESIZE_ERROR_TRUNCATION; // return array truncated

      }
    else
      {
        arrMax = numElements;
      }


    // MNT - 8.23.07 - We will always have atleast 1 element in the array for out of bounds
    // access. The rest of the code will take care of allocating the memory
    // MNT - 9/14/2007 - Forced deallocation should clear memory
    // Check to see if a 0 was passed in - 0 means delete memory associated with the string
    if (newSize == -1)
      {

        // First check to see if there were any elements in the first place and call the destructor
        // on each element
        if (numElements != 0)
          {
            for (arrCtr = 0; arrCtr <= numElements; arrCtr++)
              {
                elem = (struct StructStructHdr_s *)(GetStructArrayElement(InstancePtr,dStructArray, arrCtr));
                if (elem)
                  {
                    if (dStructArray->Destructor)
                      {
                        error = dStructArray->Destructor(elem, 0);
                      }// if elem->Destructor
                  }// if elem

                // If there is an error, something serious happened. We will not be able to
                // recover properly - this could cause memory leaks because we have not
                // deallocated the old structure header yet
                if (error)
                  {
                    Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING5)-1, ERROR_RESIZE_STRARR_STRING5,
                      dStructArray->Name);
                    return (retval | DYN_RESIZE_ERROR_ELMRSZ_FAILED);
                  } // error
              } //for arrCtr

          }// if numElements!=0

        // At this point, we have deallocated all the memory associated with each struct
        dStructArray->NumElements = DYN_STRUCT_ARRAY_FLAG;
        if (dStructArray->Structs)
          {
            Deallocate(dStructArray->Structs);
            dStructArray->Structs = NULL;
          } // dStructArray->Structs
        return retval;
      } // newsize == -1



    // We need to resize

    // Allocate memory for the new structs
    newStructs = Allocate((newSize+1) * (dStructArray->ElementSize));

    if (newStructs == NULL)
      {
        Error(InstancePtr, sizeof(ERROR_RESIZE_STRUCTARR_STRING4)-1, ERROR_RESIZE_STRUCTARR_STRING4,
          dStructArray->Name);
        return DYN_RESIZE_ERROR_ALLOC_FAILED;
      } // newstructs non null


    oldStructs = (dStructArray->Structs);

    // Copy the old structs into the new one
    // Make sure we don't copy from an empty struct. Copy assuming 1 based array
    if (dStructArray->Structs)
      {
        memcpy(newStructs, oldStructs, (arrMax+1)*(dStructArray->ElementSize));
      } // endif old string esists

    if (newSize < numElements)
      {
        // Call the destructor on items greater than newSize
        for (arrCtr = newSize+1; arrCtr <= numElements; arrCtr++)
          {
            elem = (struct StructStructHdr_s *)(GetStructArrayElement(InstancePtr,dStructArray, arrCtr));
            if (elem)
              {
                if (dStructArray->Destructor)
                  {
                    error = dStructArray->Destructor(elem, 0);
                  }// if elem->Destructor
              }// if elem

            // If there is an error, something serious happened. We will not be able to
            // recover properly - this could cause memory leaks because we have not
            // deallocated the old structure header yet
            if (error)
              {
                Error(InstancePtr, sizeof(ERROR_RESIZE_STRARR_STRING5)-1, ERROR_RESIZE_STRARR_STRING5,
                  dStructArray->Name);
                return (retval | DYN_RESIZE_ERROR_ELMRSZ_FAILED);
              } // error
          } //for arrCtr

        // Update the structure
        dStructArray->NumElements = newSize | DYN_STRUCT_ARRAY_FLAG;
        dStructArray->Structs = newStructs;

      } // newsize is less than current number of elements
    else // newsize is greater than number of elements
      {
        // Call the constructor on the uninitialized elements. Update the structure
        // first. We have already saved the oldsize in numElements.
        dStructArray->NumElements = newSize | DYN_STRUCT_ARRAY_FLAG;
        dStructArray->Structs = newStructs;

        for (arrCtr = numElements+1; arrCtr <= newSize; arrCtr++)
          {
            elem = (struct StructStructHdr_s *)(GetStructArrayElement(InstancePtr,dStructArray, arrCtr));
            if (elem)
              {
                if (dStructArray->Constructor)
                  {
                    error = dStructArray->Constructor(elem);
                  }// if elem->Constructor
              }// if elem

            // If there is an error, something serious happened. We will not be able to
            // recover properly - this could cause memory leaks because we have not
            // deallocated the old structure header yet
            if (error)
              {
                Error(InstancePtr, sizeof(ERROR_RESIZE_STRUCTARR_STRING6)-1, ERROR_RESIZE_STRUCTARR_STRING6,
                  dStructArray->Name);
                return (retval | DYN_RESIZE_ERROR_ELMCRT_FAILED);
              } // error
          } //for arrCtr

      } // end if newsize < numElement


    // At this point, the structure will have the correct size and will have a pointer to the
    // new structure header.

    // Let deallocate throw errors if necessary - handle if needed
    if (oldStructs)
      {
        Deallocate(oldStructs);
        oldStructs = NULL;
      }
    return retval;

  }







// @@@@@@
// We have to fix gather in the control system code and over here. This change
// seems very extensive - Work with Ed on this.
// Can we assume that only the destination and the delimiter can be dynamic?

#define ERROR_FORMAT_STRING1 "Destination string %z overflow. CurLen = %d, MaxLen = %d."

// SIMPL Windows 2.07.XX will not use this form of Gather().  Keep it for backwards compatability.
struct StringHdr_s* Gather(void *InstancePtr, struct StringHdr_s *Dest,
            struct StringHdr_s *Delim, struct StringHdr_s *Source)
{
    int StartIndex;
    int newLength;

    if ( (Dest == NULL) || (Delim == NULL) || (Source == NULL) )
        return NULL;

    LockInputSema(InstancePtr, Source);
    StartIndex = Find(Delim, Source, 1, 1);
    while (StartIndex == 0)  // if deliminator not found
    {
        WaitOnInputString(InstancePtr, Source);
        StartIndex = Find(Delim, Source, 1, 1);
    }
    newLength = (StartIndex - 1) + Delim->CurLen;

    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Generate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, newLength, Source->MaxLen, "Gather", 1);

    Source->CurLen -= Dest->CurLen;
    memcpy(GetCharAddrFromString(Dest), GetCharAddrFromString(Source), Dest->CurLen);
    memmove(GetCharAddrFromString(Source), GetCharAddrFromStringOffset(Source,Dest->CurLen), Source->CurLen);

    CheckBufferThreshold(Source);
    UnLockInputSema(InstancePtr, Source);

    return Dest;
}

// SIMPL Windows 2.07.XX and later use these forms of Gather().
struct StringHdr_s* GatherToDelimiter(void *InstancePtr, struct StringHdr_s *Dest,
            struct StringHdr_s *Delim, struct StringHdr_s *Source, unsigned int Timeout)
{
    int StartIndex;
    int status;
    int newLength;

    if ( (Dest == NULL) || (Delim == NULL) || (Source == NULL) )
        return NULL;

    LockInputSema(InstancePtr, Source);
    StartIndex = Find(Delim, Source, 1, 1);
    while (StartIndex == 0)  // if deliminator not found
    {
        if ( Timeout == 0xFFFFFFFF )    // default value.  Assume old form.
            status = WaitOnInputString(InstancePtr, Source);
        else
            status = WaitOnInputStringWithTimeout(InstancePtr, Source, Timeout);
        if ( status < 0 )               // timeout occured
        {
            Dest->CurLen = 0;
            UnLockInputSema(InstancePtr, Source);
            return Dest;
        }
        StartIndex = Find(Delim, Source, 1, 1);
    }
    newLength = (StartIndex - 1) + Delim->CurLen;

    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Generate error even if non-dynamic 
    ResizeIfAutogrow(InstancePtr, Dest, newLength, Source->MaxLen, "GatherToDelimiter", 1);

    Source->CurLen -= Dest->CurLen;
    memcpy(GetCharAddrFromString(Dest), GetCharAddrFromString(Source), Dest->CurLen);
    memmove(GetCharAddrFromString(Source), GetCharAddrFromStringOffset(Source,Dest->CurLen), Source->CurLen);

    CheckBufferThreshold(Source);
    UnLockInputSema(InstancePtr, Source);
    return Dest;
}

#define ERROR_FORMAT_STRING2 "Number of bytes too large for string %z. MaxLen = %d, NumBytes = %d."
#define ERROR_FORMAT_STRING3 "Invalid Number of bytes for string %z. NumBytes = %d."


struct StringHdr_s* GatherByLength(void *InstancePtr, struct StringHdr_s *Dest,
            int NumBytes, struct StringHdr_s *Source, unsigned int Timeout)
{
    int status;
    int newLength;

    if ( (Dest == NULL) || (Source == NULL) )
        return NULL;

    if ( NumBytes > Dest->MaxLen )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                Dest->Name, Dest->MaxLen, NumBytes);
        return NULL;
    }
    if ( NumBytes > Source->MaxLen )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                Source->Name, Source->MaxLen, NumBytes);
        return NULL;
    }
    if ( NumBytes <= 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3,
                Dest->Name, Dest->MaxLen, NumBytes);
        return NULL;
    }

    LockInputSema(InstancePtr, Source);
    while (Source->CurLen < NumBytes )  // if deliminator not found
    {
        status = WaitOnInputStringWithTimeout(InstancePtr, Source, Timeout);
        if ( status < 0 )               // timeout occured
        {
            Dest->CurLen = 0;
            UnLockInputSema(InstancePtr, Source);
            return Dest;
        }
    }
    newLength = NumBytes;
    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Generate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, newLength, Source->MaxLen, "GatherByLength", 1);

    Source->CurLen -= Dest->CurLen;
    memcpy(GetCharAddrFromString(Dest), GetCharAddrFromString(Source), Dest->CurLen);
    memmove(GetCharAddrFromString(Source), GetCharAddrFromStringOffset(Source,Dest->CurLen), Source->CurLen);

    CheckBufferThreshold(Source);
    UnLockInputSema(InstancePtr, Source);
    return Dest;
}
#undef ERROR_FORMAT_STRING2
#undef ERROR_FORMAT_STRING3

unsigned short Getc(struct StringHdr_s *Source)
{
    unsigned short RetVal;
    unsigned char * cPtr;

    if ( Source == NULL )
        return 0xFFFF;

    if (Source->CurLen == 0)
        return 0xFFFF;

// @@@@ Do we need to resize if dynamic string?
    RetVal = GetCharFromString(Source,0);
    Source->CurLen--;

    cPtr = GetCharAddrFromString(Source);
    memmove(&(cPtr[0]), &(cPtr[1]), Source->CurLen);

    CheckBufferThreshold(Source);
    return RetVal;
}

struct StringHdr_s* Left(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source, unsigned count)
{
    if ( (Dest == NULL) || (Source == NULL) )
        return NULL;

    if(Source->CurLen == 0)
    {
        Dest->CurLen = 0;
        return Dest;
    }

    if(count > Source->CurLen)
        count = Source->CurLen;
    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Don't enerate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, count, Source->MaxLen, "Left", 0);
    if(count > Dest->MaxLen)
        count = Dest->MaxLen;

    memmove(GetCharAddrFromString(Dest), GetCharAddrFromString(Source), count);

    Dest->CurLen = count;

    return Dest;
}
unsigned short Len(struct StringHdr_s *String)
{
    if ( String == NULL )
        return 0;

    return String->CurLen;
}


struct StringHdr_s* Lower(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source)
{
    int i;
    int iLen;
    unsigned char * destCurrCh;

    if ( (Dest == NULL) || (Source == NULL) )
        return NULL;

    iLen = Source->CurLen;
    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Don't enerate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, iLen, Source->MaxLen, "Lower", 0);
    if ( iLen > Dest->MaxLen )
        iLen = Dest->MaxLen;

    for ( i = 0; i < iLen; i++)
      {
        destCurrCh = GetCharAddrFromStringOffset(Dest,i);
        *destCurrCh = MakeLower(GetCharFromString(Source,i));
      }

    Dest->CurLen = iLen;

    return Dest;
}
struct StringHdr_s* Mid(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source,
            unsigned first, unsigned count)
{
    unsigned char * sourcePtr;

    if ( (Dest == NULL) || (Source == NULL) )
        return NULL;

    if( (Source->CurLen == 0) || (first > Source->CurLen))
    {
        Dest->CurLen = 0;
        return Dest;
    }

    first--;                            // make index 0 based.
    //make sure count doesn't exceed length
    if(count >  (Source->CurLen - first))
        count = Source->CurLen - first;

    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Don't enerate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, count, Source->MaxLen, "Mid", 0);
    if(count > Dest->MaxLen)
        count = Dest->MaxLen;

    sourcePtr = GetCharAddrFromString(Source);
    memmove(GetCharAddrFromString(Dest), &(sourcePtr[first]), count);
    Dest->CurLen = count;

    return Dest;
}
struct StringHdr_s* Remove(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Delim,
            struct StringHdr_s *Source, unsigned start)
{
    int StartIndex;
    unsigned char * sourcePtr;
    int newLength;

    if ( (Dest == NULL) || (Delim == NULL) || (Source == NULL) )
        return NULL;

    if ( (Source->CurLen == 0) || (Delim->CurLen == 0) )
    {
        Dest->CurLen = 0;
        return Dest;
    }
    LockInputSema(InstancePtr, Source);
    StartIndex = Find(Delim, Source, start, 1);
    if ( StartIndex == 0)
    {
        Dest->CurLen = 0;
        UnLockInputSema(InstancePtr, Source);
        return Dest;
    }

    newLength = (StartIndex - 1) + Delim->CurLen;
    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Generate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, newLength, Source->MaxLen, "Remove", 1);

    Source->CurLen -= Dest->CurLen;
    memmove(GetCharAddrFromString(Dest), GetCharAddrFromString(Source), Dest->CurLen);
    sourcePtr = GetCharAddrFromString(Source);
    memmove(GetCharAddrFromString(Source), &(sourcePtr[Dest->CurLen]), Source->CurLen);
    CheckBufferThreshold(Source);

    UnLockInputSema(InstancePtr, Source);
          
    return Dest;
}
#define ERROR_FORMAT_STRING3 "Invalid Number of bytes for string %z. NumBytes = %d."
#define ERROR_FORMAT_STRING4 "Cannot Remove %u bytes from string %z.  Current Length = %u, Max Length = %u."
struct StringHdr_s* RemoveByLength(void *InstancePtr, struct StringHdr_s *Dest,
            int NumBytes, struct StringHdr_s *Source)
{
    int status;
    unsigned char * sourcePtr;
    int newLength;

    if ( (Dest == NULL) || (Source == NULL) )
	{
        return NULL;
    }

    // Added this HPN 8/23/2007 - if this wasn't done & the #bytes requested is > Source's Current Length, there could be problems later
    // with the memmove's.
    if( NumBytes > Source->CurLen )
    {
		Error(InstancePtr, sizeof(ERROR_FORMAT_STRING4)-1, ERROR_FORMAT_STRING4,
				NumBytes, Source->Name, Source->CurLen, Source->MaxLen);
		return NULL;
	}

    if ( NumBytes > Source->MaxLen )
    {
		Error(InstancePtr, sizeof(ERROR_FORMAT_STRING4)-1, ERROR_FORMAT_STRING4,
				Source->Name, Source->CurLen, Source->MaxLen);
        return NULL;
    }

    if ( NumBytes <= 0 )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3,
                Dest->Name, Dest->MaxLen, NumBytes);
        return NULL;
    }

    LockInputSema(InstancePtr, Source);
    newLength = NumBytes;
    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Generate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, newLength, Source->MaxLen, "RemoveByLength", 1);

    Source->CurLen -= Dest->CurLen;
    memmove(GetCharAddrFromString(Dest), GetCharAddrFromString(Source), Dest->CurLen);
    sourcePtr = GetCharAddrFromString(Source);
    memmove(GetCharAddrFromString(Source), &(sourcePtr[Dest->CurLen]), Source->CurLen);
    CheckBufferThreshold(Source);
    UnLockInputSema(InstancePtr, Source);

    return Dest;
}
#undef ERROR_FORMAT_STRING3
#undef ERROR_FORMAT_STRING4
#undef ERROR_FORMAT_STRING1

int InternalReverseFind(struct StringHdr_s *Match, struct StringHdr_s *Source,
            unsigned start, int caseSensitive)
{
    int i, j, k;
    char SrcChar, MatchChar;

    if ((Source->CurLen == 0) || (Match->CurLen == 0) ||
        (Source->CurLen < Match->CurLen) || (start > Source->CurLen) )
        return 0;

    if ( start == 0 )                   // start from end of string
        start = Source->CurLen;

    for ( i = start-1; i >= (Match->CurLen - 1); i--)
    {
        j = Match->CurLen - 1;              // start at end of match string
        if ( caseSensitive )
        {
            SrcChar = GetCharFromString(Source,i);
            MatchChar = GetCharFromString(Match,j);
        }
        else
        {
            SrcChar = MakeUpper(GetCharFromString(Source,i));
            MatchChar = MakeUpper(GetCharFromString(Match,j));
        }
        if ( SrcChar == MatchChar )     // match first character
        {
            for (k = i-1, j-- ; (k >= 0) && (j >= 0); k--, j--)
            {
                if ( caseSensitive )
                {
                    SrcChar = GetCharFromString(Source,k);
                    MatchChar = GetCharFromString(Match,j);
                }
                else
                {
                    SrcChar = MakeUpper(GetCharFromString(Source,k));
                    MatchChar = MakeUpper(GetCharFromString(Match,j));
                }
                if ( SrcChar != MatchChar )
                    break;              // entire string not found
            }  // for (k = i-1;...)
            if ( j < 0 )          // match string found
                return (k+2);           // Add 2 because index starts at 1 and
        }                               //      k has been decremented past start
    } // for(i...)
    return 0; //can't find it
}
int ReverseFind(struct StringHdr_s *Match, struct StringHdr_s *Source, unsigned Start)
{
    if ( (Match == NULL) || (Source == NULL) )
        return 0;
    return InternalReverseFind(Match, Source, Start, LIB_TRUE);
}
int ReverseFindi(struct StringHdr_s *Match, struct StringHdr_s *Source, unsigned Start)
{
    if ( (Match == NULL) || (Source == NULL) )
        return 0;
    return InternalReverseFind(Match, Source, Start, LIB_FALSE);
}
struct StringHdr_s* Right(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source, unsigned count)
{
    unsigned char * sourcePtr;

    if ( (Dest == NULL) || (Source == NULL) )
        return NULL;

    if(Source->CurLen == 0)
    {
        Dest->CurLen = 0;
        return Dest;
    }
    if(count > Source->CurLen)
        count = Source->CurLen;
    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Don't enerate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, count, Source->MaxLen, "Right", 0);
    if(count > Dest->MaxLen)
        count = Dest->MaxLen;

    sourcePtr = GetCharAddrFromString(Source);
    memmove(GetCharAddrFromString(Dest), &(sourcePtr[Source->CurLen-count]), count);
    Dest->CurLen = count;

    return Dest;
}
#define ERROR_FORMAT_STRING1 "%z: Destination string %z overflow. CurLen = %d, MaxLen = %d."
int SetString(void *InstancePtr, struct StringHdr_s *Source, unsigned position, struct StringHdr_s *Dest)
{
    int RetVal = 0;
    int SourceLen;
    unsigned char * destPtr;
    int newLength, resizeReturn;

    if ( (Dest == NULL) || (Source == NULL) )
        return -16;

    destPtr = GetCharAddrFromString(Dest);

    SourceLen = Source->CurLen;

    // MNT - 6/4/2008 - If we have a dynamic autogrow string, the max length is the max string length
    // MNT - 6/10/2008 - Use this instead of calling ResizeIfAutogrow to make life easier
    if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)
      {
        if ( ( position > MAX_STRING_SIZE )  ||  ( position < 1 ) )
          {
            return -8;
          } //if ( position > MAX_STRING_SIZE )

        if ( (position - 1 + SourceLen) > MAX_STRING_SIZE)
        {
            SourceLen = MAX_STRING_SIZE - (position);
            RetVal += -4;
        } // if ( (position - 1 + SourceLen) > MAX_STRING_SIZE)

      } // if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)
    else
      {
        if ( ( position > Dest->MaxLen ) || ( position < 1 ) )
        {
            return -8;
        } //if ( ( position > Dest->MaxLen ) || ( position < 1 ) )

        if ( (position - 1 + SourceLen) > Dest->MaxLen)
        {
            SourceLen = Dest->MaxLen - (position - 1);
            RetVal += -4;
        } // if ( (position - 1 + SourceLen) > Dest->MaxLen)

      } // if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)

    if ( position > Dest->CurLen)
    {
        memset(&(destPtr[Dest->CurLen]), 0x20, ((position - 1) - Dest->CurLen));
        RetVal += -2;
    } // if ( position > Dest->CurLen)
    if ( (position - 1 + SourceLen) > Dest->CurLen)
    {
        Dest->CurLen = position - 1 + SourceLen;
        RetVal += -1;
    } // if ( (position - 1 + SourceLen) > Dest->CurLen)

    // MNT - 6/5/2008 - If we have a dynamic autogrow string, expand the destination
    // string length
    if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)
      {
        newLength = position + SourceLen;
        if (newLength > MAX_STRING_SIZE)
          {
            newLength = MAX_STRING_SIZE;
          }//if (newLength > MAX_STRING_SIZE)

        if (newLength > Dest->MaxLen)
          {
            resizeReturn = ResizeString(InstancePtr, Dest, newLength, LIB_TRUE);// stay verbose for now
            if (resizeReturn != 0)
              {
                Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                        "SetString", Dest->Name, newLength, Dest->MaxLen);
                newLength = Dest->MaxLen;
              } //if (resizeReturn != 0)
          } //if (newLength > Dest->MaxLen)
        
      } // if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)

    memmove(&(destPtr[position - 1]), GetCharAddrFromString(Source), SourceLen);

    if ( RetVal < 0)
        return RetVal;
    else
        return Dest->CurLen;
}
#undef ERROR_FORMAT_STRING1
struct StringHdr_s* Upper(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source)
{
    int i;
    int iLen;
    unsigned char * destPtr;

    if ( (Dest == NULL) || (Source == NULL) )
        return NULL;
    iLen = Source->CurLen;
    // MNT - 6/9/2008 - Call a generic function that will resize the destination
    // if needed and possible. Don't generate error even if non-dynamic
    ResizeIfAutogrow(InstancePtr, Dest, iLen, Source->MaxLen, "Upper", 0);
    if ( iLen > Dest->MaxLen )
        iLen = Dest->MaxLen;

    destPtr = GetCharAddrFromString(Dest);

    for ( i = 0; i < iLen; i++)
      {
        destPtr[i] = MakeUpper(GetCharFromString(Source,i));
      }
    Dest->CurLen = iLen;

    return Dest;
}
unsigned char MakeLower(unsigned char Character)
{
    //NOTE: This function can be optimized by using a 255 entry array with
    //the corresponding lowercase value for every character. Then this function
    //would become:
    //      return lowerarray[character];

    if(Character >= 'A' && Character <= 'Z')
        Character += 0x20;

    return Character;
}
unsigned char MakeUpper(unsigned char Character)
{
    //NOTE: This function can be optimized by using a 255 entry array with
    //the corresponding uppercase value for every character. Then this function
    //would become:
    //      return upperarray[character];

    if(Character >= 'a' && Character <= 'z')
        Character -= 0x20;

    return Character;
}
struct StringHdr_s* MakeProgramFilename(struct StringHdr_s *Source)
{
     return Source;
}
struct StringHdr_s* GetModelNumber()
{
     return NULL;
}
short GetSeries()
{
     return 2;
}
unsigned short GetProgramNumber()
{
     return 1;
}
/*
int  CompareIntegers(const void *Int1, const void *Int2)
{
    int Long1, Long2;

    Long1 = *(unsigned short *)Int1;
    Long2 = *(unsigned short *)Int2;

    return (Long1 - Long2);
}
int  QsortStringCompare(const void *Str1, const void *Str2)
{
    return CompareStrings((struct StringHdr_s *)Str1, (struct StringHdr_s *)Str2, LIB_FALSE);
}
void Sort1DIntegerArray(struct IntArrayHdr_s *Array)
{
    qsort(&(Array->Data[0]), Array->NumCols, sizeof(Array->Data[0]), CompareIntegers );
}
void SortStringArray(struct StringArrayHdr_s *Array)
{
    qsort(&(Array->Strings[0]), Array->NumElem,
           (Array->Strings[0].MaxLen + 16), QsortStringCompare );
}
 */
int IsDirectory(struct FileInfo_s *Info)
{
    if ( Info == NULL )
        return 0;
    return ((Info->IATTRIBUTES & ADIRENT) ? 1 : 0);
}
int IsHidden(struct FileInfo_s *Info)
{
    if ( Info == NULL )
        return 0;
    return ((Info->IATTRIBUTES & AHIDDEN) ? 1 : 0);
}
int IsSystem(struct FileInfo_s *Info)
{
    if ( Info == NULL )
        return 0;
    return ((Info->IATTRIBUTES & ASYSTEM) ? 1 : 0);
}
int IsVolume(struct FileInfo_s *Info)
{
    if ( Info == NULL )
        return 0;
    return ((Info->IATTRIBUTES & AVOLUME) ? 1 : 0);
}
int IsReadOnly(struct FileInfo_s *Info)
{
    if ( Info == NULL )
        return 0;
    return ((Info->IATTRIBUTES & ARDONLY) ? 1 : 0);
}

int WriteInteger(int FileHandle, unsigned short Value)
{
    return FwriteCallback((char *)&Value, sizeof(unsigned short), FileHandle);
}
int ReadInteger(int FileHandle, unsigned short *Value)
{
    if ( Value != 0 )
        return FreadCallback((char *)Value, sizeof(unsigned short), FileHandle);
    else
        return -1;
}
int WriteLongInteger(int FileHandle, unsigned long Value)
{
    return FwriteCallback((char *)&Value, sizeof(unsigned long), FileHandle);
}
int ReadLongInteger(int FileHandle, unsigned long *Value)
{
    if ( Value != 0 )
        return FreadCallback((char *)Value, sizeof(unsigned long), FileHandle);
    else
        return -1;
}
int WriteSignedInteger(int FileHandle, short Value)
{
    return FwriteCallback((char *)&Value, sizeof(short), FileHandle);
}
int ReadSignedInteger(int FileHandle, short *Value)
{
    if ( Value != 0 )
        return FreadCallback((char *)Value, sizeof(short), FileHandle);
    else
        return -1;
}
int WriteSignedLongInteger(int FileHandle, long Value)
{
    return FwriteCallback((char *)&Value, sizeof(long), FileHandle);
}
int ReadSignedLongInteger(int FileHandle, long *Value)
{
    if ( Value != 0 )
        return FreadCallback((char *)Value, sizeof(long), FileHandle);
    else
        return -1;
}
// Integer Array routines



#undef ERROR_FORMAT_STRING3

int WriteIntegerArray(int FileHandle, struct IntArrayHdr_s *Source)
{
    unsigned short Rows,Cols;
    int ArraySize;                      // needs to be a long to handle overflow
    int status;
    struct IntDynamicArrayHdr_s *dynSource;
    int dynFlag = 0;

    if ( Source == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Source->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    // write the number of rows, then cols.
    Rows = (Source->NumRows & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Rows, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    Cols = (Source->NumCols & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Cols, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    ArraySize = ((Rows+1) * (Cols+1)) * sizeof(unsigned short);

    // Use the correct pointer based on the dynFlag
    if (dynFlag == 1)
      {
        dynSource = (struct IntDynamicArrayHdr_s *) (Source);
        return FwriteCallback((char *)&(dynSource->Data[0]), ArraySize, FileHandle);
      }
    else
      {
    return FwriteCallback((char *)&(Source->Data[0]), ArraySize, FileHandle);
      }// nondynamic
}
#define ERROR_FORMAT_STRING1 "IntArray %z overflow in File Read.  File = %d,%d.  Array = %d,%d"
int ReadIntegerArray(void *InstancePtr, int FileHandle, struct IntArrayHdr_s *Dest)
{
    unsigned short Rows,Cols, destRows,destCols;
    unsigned short SkipRows,SkipCols;
    int i;
    int ArrayIndex, NumRead;
    unsigned short *ArrayPtr;
    int status;
    int DataSize;
    struct IntDynamicArrayHdr_s *dynDest;
    int dynFlag = 0;

    if ( Dest == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Dest->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    SkipRows = 0;
    SkipCols = 0;
    NumRead = 0;
    DataSize = sizeof(unsigned short);
    // read the number of rows, then cols.
    status = FreadCallback((char *)&Rows, DataSize, FileHandle);
    if ( status < 0)
        return status;
    status = FreadCallback((char *)&Cols, DataSize, FileHandle);
    if ( status < 0)
        return status;

    destRows = Dest->NumRows & ~DYN_INT_ARRAY_FLAG;
    destCols = Dest->NumCols & ~DYN_INT_ARRAY_FLAG;

    // now do bounds checking.
    if ( (Rows > destRows) || (Cols > destCols ) )
    {
        // If the array is dynamic, just resize to the size in the file
        // This will automatically catch problems with invalid numbers
        // in the file because we will not allow resizes to sizes above
        // 64K
        if (dynFlag == 1)
          {
            ResizeIntegerArray(InstancePtr,
              (struct IntDynamicArrayHdr_s *) Dest,
              Rows,
              Cols,
              e_INTARR_TYPE_INT,
              1); // don't force deallocation
          }
        else // dynFlag == 1
          {
        ExtendedError(eERROR_LEVEL_WARNING, InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1,
                    ERROR_FORMAT_STRING1, Dest->Name, Rows, Cols, destRows, destCols);
            if ( Rows > destRows )
        {
                SkipRows = Rows - destRows;
                Rows = destRows;
        }
            if ( Cols > destCols )
        {
                SkipCols = Cols - destCols;
                Cols = destCols;
        }
          } // endifdynamic flag == 1
    }// bounds check end

    // now read based on dynamic flag
    if (dynFlag == 0)
      {
    for ( i = 0; i <= Rows; i++)
    {
        ArrayIndex = i * (Dest->NumCols + 1);
        ArrayPtr = &(Dest->Data[ArrayIndex]);
        status = FreadCallback((char *)ArrayPtr, ((Cols+1) * DataSize), FileHandle);
        if ( status < 0)
            return status;
        else
            NumRead = NumRead  + status;
        if ( SkipCols > 0 )
            FileSeek(FileHandle, (SkipCols * DataSize), 1);  // 1 => SEEK_CUR
        } // for number of rows
    if ( SkipRows > 0)
    {
        ArrayIndex = SkipRows * (Cols + SkipCols + 1) * DataSize;
        FileSeek(FileHandle, ArrayIndex, 1);  // 1 => SEEK_CUR
        } // if rows were skipped
      } // if dynflag == 0
    else // if dynFlag == 0
      {
        dynDest = (struct IntDynamicArrayHdr_s *)Dest;
        ArrayPtr = &(dynDest->Data[0]);
        status = FreadCallback((char *)ArrayPtr, ((Rows+1) * (Cols+1) * DataSize), FileHandle);
        NumRead = NumRead  + status;
    }
    return NumRead;
}
#undef ERROR_FORMAT_STRING1
// Array routines
int WriteLongIntegerArray(int FileHandle, struct LongArrayHdr_s *Source)
{
    unsigned short Rows,Cols;
    int ArraySize;                      // needs to be a long to handle overflow
    int status;
    struct LongDynamicArrayHdr_s *dynSource;
    int dynFlag = 0;

    if ( Source == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Source->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    // write the number of rows, then cols.
    Rows = (Source->NumRows & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Rows, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    Cols = (Source->NumCols & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Cols, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    ArraySize = ((Rows+1) * (Cols+1)) * sizeof(unsigned long);

    // Use the correct pointer based on the dynFlag
    if (dynFlag == 1)
      {
        dynSource = (struct LongDynamicArrayHdr_s *) (Source);
        return FwriteCallback((char *)&(dynSource->Data[0]), ArraySize, FileHandle);
      }
    else
      {
    return FwriteCallback((char *)&(Source->Data[0]), ArraySize, FileHandle);
      }// nondynamic
}
#define ERROR_FORMAT_STRING1 "LongIntArray %z overflow in File Read.  File = %d,%d.  Array = %d,%d"
int ReadLongIntegerArray(void *InstancePtr, int FileHandle, struct LongArrayHdr_s *Dest)
{
    unsigned short Rows,Cols, destRows,destCols;
    unsigned short SkipRows,SkipCols;
    int i;
    int ArrayIndex, NumRead;
    unsigned long *ArrayPtr;
    int status;
    int DataSize;
    struct LongDynamicArrayHdr_s *dynDest;
    int dynFlag = 0;


    if ( Dest == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Dest->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    SkipRows = 0;
    SkipCols = 0;
    NumRead = 0;
    DataSize = sizeof(unsigned short);
    // read the number of rows, then cols.
    status = FreadCallback((char *)&Rows, DataSize, FileHandle);
    if ( status < 0)
        return status;
    status = FreadCallback((char *)&Cols, DataSize, FileHandle);
    if ( status < 0)
        return status;


    destRows = Dest->NumRows & ~DYN_INT_ARRAY_FLAG;
    destCols = Dest->NumCols & ~DYN_INT_ARRAY_FLAG;

    // now do bounds checking.
    if ( (Rows > destRows) || (Cols > destCols ) )
    {
        // If the array is dynamic, just resize to the size in the file
        // This will automatically catch problems with invalid numbers
        // in the file because we will not allow resizes to sizes above
        // 64K
        if (dynFlag == 1)
          {
            ResizeIntegerArray(InstancePtr,
              (struct LongDynamicArrayHdr_s *) Dest,
              Rows,
              Cols,
              e_INTARR_TYPE_LONG,
              1);  // don't force deallocation
          }
        else // dynFlag == 1
          {
        ExtendedError(eERROR_LEVEL_WARNING, InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1,
                    ERROR_FORMAT_STRING1, Dest->Name, Rows, Cols, destRows, destCols);
            if ( Rows > destRows )
        {
                SkipRows = Rows - destRows;
                Rows = destRows;
        }
            if ( Cols > destCols )
        {
                SkipCols = Cols - destCols;
                Cols = destCols;
        }
          } // endifdynamic flag == 1
    }// bounds check end

    DataSize = sizeof(unsigned long);
    // now read based on dynamic flag
    if (dynFlag == 0)
      {
    for ( i = 0; i <= Rows; i++)
    {
        ArrayIndex = i * (Dest->NumCols + 1);
        ArrayPtr = &(Dest->Data[ArrayIndex]);
        status = FreadCallback((char *)ArrayPtr, ((Cols+1) * DataSize), FileHandle);
        if ( status < 0)
            return status;
        else
            NumRead = NumRead  + status;
        if ( SkipCols > 0 )
            FileSeek(FileHandle, (SkipCols * DataSize), 1);  // 1 => SEEK_CUR
        } // for number of rows
    if ( SkipRows > 0)
    {
        ArrayIndex = SkipRows * (Cols + SkipCols + 1) * DataSize;
        FileSeek(FileHandle, ArrayIndex, 1);  // 1 => SEEK_CUR
        } // if rows were skipped
      } // if dynflag == 0
    else // if dynFlag == 0
      {
        dynDest = (struct LongDynamicArrayHdr_s *)Dest;
        ArrayPtr = &(dynDest->Data[0]);
        status = FreadCallback((char *)ArrayPtr, ((Rows+1) * (Cols+1) * DataSize), FileHandle);
        NumRead = NumRead  + status;
      } // endif dynflag==0
    return NumRead;
}


#undef ERROR_FORMAT_STRING1
int WriteSignedIntegerArray(int FileHandle, struct SignedIntArrayHdr_s *Source)
{
    unsigned short Rows,Cols;
    int ArraySize;                      // needs to be a long to handle overflow
    int status;
    struct SignedIntDynamicArrayHdr_s *dynSource;
    int dynFlag = 0;

    if ( Source == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Source->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    // write the number of rows, then cols.
    Rows = (Source->NumRows & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Rows, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    Cols = (Source->NumCols & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Cols, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    ArraySize = ((Rows+1) * (Cols+1)) * sizeof(short);

    // Use the correct pointer based on the dynFlag
    if (dynFlag == 1)
      {
        dynSource = (struct SignedIntDynamicArrayHdr_s *) (Source);
        return FwriteCallback((char *)&(dynSource->Data[0]), ArraySize, FileHandle);
      }
    else
      {
    return FwriteCallback((char *)&(Source->Data[0]), ArraySize, FileHandle);
      }// nondynamic
}
#define ERROR_FORMAT_STRING1 "SignedIntArray %z overflow in File Read.  File = %d,%d.  Array = %d,%d"
int ReadSignedIntegerArray(void *InstancePtr, int FileHandle, struct SignedIntArrayHdr_s *Dest)
{
    unsigned short Rows,Cols, destRows,destCols;
    unsigned short SkipRows,SkipCols;
    int i;
    int ArrayIndex, NumRead;
    short *ArrayPtr;
    int status;
    int DataSize;
    struct SignedIntDynamicArrayHdr_s *dynDest;
    int dynFlag = 0;


    if ( Dest == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Dest->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    SkipRows = 0;
    SkipCols = 0;
    NumRead = 0;
    DataSize = sizeof(unsigned short);
    // read the number of rows, then cols.
    status = FreadCallback((char *)&Rows, DataSize, FileHandle);
    if ( status < 0)
        return status;
    status = FreadCallback((char *)&Cols, DataSize, FileHandle);
    if ( status < 0)
        return status;

    destRows = Dest->NumRows & ~DYN_INT_ARRAY_FLAG;
    destCols = Dest->NumCols & ~DYN_INT_ARRAY_FLAG;

    // now do bounds checking.
    if ( (Rows > destRows) || (Cols > destCols ) )
    {
        // If the array is dynamic, just resize to the size in the file
        // This will automatically catch problems with invalid numbers
        // in the file because we will not allow resizes to sizes above
        // 64K
        if (dynFlag == 1)
          {
            ResizeIntegerArray(InstancePtr,
              (struct SignedIntDynamicArrayHdr_s *) Dest,
              Rows,
              Cols,
              e_INTARR_TYPE_SIGNEDINT,
              1);  // don't force deallocation
          }
        else // dynFlag == 1
          {
        ExtendedError(eERROR_LEVEL_WARNING, InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1,
                    ERROR_FORMAT_STRING1, Dest->Name, Rows, Cols, destRows, destCols);
            if ( Rows > destRows )
        {
                SkipRows = Rows - destRows;
                Rows = destRows;
        }
            if ( Cols > destCols )
        {
                SkipCols = Cols - destCols;
                Cols = destCols;
        }
          } // endifdynamic flag == 1
    }// bounds check end

    DataSize = sizeof(short);

    // now read based on dynamic flag
    if (dynFlag == 0)
      {
    for ( i = 0; i <= Rows; i++)
    {
        ArrayIndex = i * (Dest->NumCols + 1);
        ArrayPtr = &(Dest->Data[ArrayIndex]);
        status = FreadCallback((char *)ArrayPtr, ((Cols+1) * DataSize), FileHandle);
        if ( status < 0)
            return status;
        else
            NumRead = NumRead  + status;
        if ( SkipCols > 0 )
            FileSeek(FileHandle, (SkipCols * DataSize), 1);  // 1 => SEEK_CUR
        } // for number of rows
    if ( SkipRows > 0)
    {
        ArrayIndex = SkipRows * (Cols + SkipCols + 1) * DataSize;
        FileSeek(FileHandle, ArrayIndex, 1);  // 1 => SEEK_CUR
        } // if rows were skipped
      } // if dynflag == 0
    else // if dynFlag == 0
      {
        dynDest = (struct SignedIntDynamicArrayHdr_s *)Dest;
        ArrayPtr = &(dynDest->Data[0]);
        status = FreadCallback((char *)ArrayPtr, ((Rows+1) * (Cols+1) * DataSize), FileHandle);
        NumRead = NumRead  + status;
    }

    return NumRead;
}
#undef ERROR_FORMAT_STRING1
// Array routines
int WriteSignedLongIntegerArray(int FileHandle, struct SignedLongArrayHdr_s *Source)
{
    unsigned short Rows,Cols;
    int ArraySize;                      // needs to be a long to handle overflow
    int status;
    struct SignedLongDynamicArrayHdr_s *dynSource;
    int dynFlag = 0;

    if ( Source == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Source->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    // write the number of rows, then cols.
    Rows = (Source->NumRows & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Rows, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    Cols = (Source->NumCols & ~DYN_INT_ARRAY_FLAG);
    status = FwriteCallback((char *)&Cols, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    ArraySize = ((Rows+1) * (Cols+1)) * sizeof(long);

    // Use the correct pointer based on the dynFlag
    if (dynFlag == 1)
      {
        dynSource = (struct SignedLongDynamicArrayHdr_s *) (Source);
        return FwriteCallback((char *)&(dynSource->Data[0]), ArraySize, FileHandle);
      }
    else
      {
    return FwriteCallback((char *)&(Source->Data[0]), ArraySize, FileHandle);
      }// nondynamic
}
#define ERROR_FORMAT_STRING1 "SignedLongIntArray %z overflow in File Read.  File = %d,%d.  Array = %d,%d"
int ReadSignedLongIntegerArray(void *InstancePtr, int FileHandle, struct SignedLongArrayHdr_s *Dest)
{
    unsigned short Rows,Cols, destRows,destCols;
    unsigned short SkipRows,SkipCols;
    int i;
    int ArrayIndex, NumRead;
    unsigned long *ArrayPtr;
    int status;
    int DataSize;
    struct SignedLongDynamicArrayHdr_s *dynDest;
    int dynFlag = 0;


    if ( Dest == NULL)
        return -1;

    //Identify if we have a dynamic array
    if (Dest->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
      }

    SkipRows = 0;
    SkipCols = 0;
    NumRead = 0;
    DataSize = sizeof(unsigned short);
    // read the number of rows, then cols.
    status = FreadCallback((char *)&Rows, DataSize, FileHandle);
    if ( status < 0)
        return status;
    status = FreadCallback((char *)&Cols, DataSize, FileHandle);
    if ( status < 0)
        return status;

    destRows = Dest->NumRows & ~DYN_INT_ARRAY_FLAG;
    destCols = Dest->NumCols & ~DYN_INT_ARRAY_FLAG;

    // now do bounds checking.
    if ( (Rows > destRows) || (Cols > destCols ) )
    {
        // If the array is dynamic, just resize to the size in the file
        // This will automatically catch problems with invalid numbers
        // in the file because we will not allow resizes to sizes above
        // 64K
        if (dynFlag == 1)
          {
            ResizeIntegerArray(InstancePtr,
              (struct SignedLongDynamicArrayHdr_s *) Dest,
              Rows,
              Cols,
              e_INTARR_TYPE_SIGNEDLONG,
              1);  // don't force deallocation
          }
        else // dynFlag == 1
          {
        ExtendedError(eERROR_LEVEL_WARNING, InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1,
                    ERROR_FORMAT_STRING1, Dest->Name, Rows, Cols, destRows, destCols);
            if ( Rows > destRows )
        {
                SkipRows = Rows - destRows;
                Rows = destRows;
        }
            if ( Cols > destCols )
        {
                SkipCols = Cols - destCols;
                Cols = destCols;
        }
          } // endifdynamic flag == 1
    }// bounds check end

    DataSize = sizeof(long);

    // now read based on dynamic flag
    if (dynFlag == 0)
      {
    for ( i = 0; i <= Rows; i++)
    {
        ArrayIndex = i * (Dest->NumCols + 1);
        ArrayPtr = &(Dest->Data[ArrayIndex]);
        status = FreadCallback((char *)ArrayPtr, ((Cols+1) * DataSize), FileHandle);
        if ( status < 0)
            return status;
        else
            NumRead = NumRead  + status;
        if ( SkipCols > 0 )
            FileSeek(FileHandle, (SkipCols * DataSize), 1);  // 1 => SEEK_CUR
        } // for number of rows
    if ( SkipRows > 0)
    {
        ArrayIndex = SkipRows * (Cols + SkipCols + 1) * DataSize;
        FileSeek(FileHandle, ArrayIndex, 1);  // 1 => SEEK_CUR
        } // if rows were skipped
      } // if dynflag == 0
    else // if dynFlag == 0
      {
        dynDest = (struct SignedLongDynamicArrayHdr_s *)Dest;
        ArrayPtr = &(dynDest->Data[0]);
        status = FreadCallback((char *)ArrayPtr, ((Rows+1) * (Cols+1) * DataSize), FileHandle);
        NumRead = NumRead  + status;
      } // endif dynflag==0

    return NumRead;
}
#undef ERROR_FORMAT_STRING1
// String Routines
int WriteString(int FileHandle, struct StringHdr_s *Source)
{
    unsigned short StringCount;
    int status;

    if ( Source == NULL)
        return -1;

    StringCount = Source->CurLen;
    status = FwriteCallback((char *)&StringCount, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    return FwriteCallback((char *)GetCharAddrFromString(Source), StringCount, FileHandle);
}
#define ERROR_FORMAT_STRING1 "String %z overflow in File Read.  File String Len = %d.  MaxLen = %d"
int ReadString(void *InstancePtr, int FileHandle, struct StringHdr_s *Dest)
{
    unsigned short StringCount;
    int BytesToSkip = 0;
    int status;

    if ( Dest == NULL)
        return -1;

    status = FreadCallback((char *)&StringCount, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    else if ( StringCount > Dest->MaxLen )
    {
        // Check to see if string is dynamic
        if (IsStringDynamic(Dest->InputType))
          {
            ResizeString(InstancePtr,
              (struct StringDynamicHdr_s *) Dest,
              StringCount,
              1);  // don't force deallocation
            // no need to modify bytesToSkip - still 0
          } // if string is dynamic
        else // else if string is dynamic
          {

        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                Dest->Name, StringCount, Dest->MaxLen);
        BytesToSkip = (StringCount - Dest->MaxLen);
        StringCount = Dest->MaxLen;
          } // endif string is dynamic
    }
    status = FreadCallback((char *)GetCharAddrFromString(Dest), StringCount, FileHandle);
    if ( status >= 0 )                  // successful read
    {
        // If string is dynamic BytesToSkip should be 0
        if ( BytesToSkip > 0)
            FileSeek(FileHandle, BytesToSkip, 1);  // 1 => SEEK_CUR
        Dest->CurLen = status;
    }
    else
        Dest->CurLen = 0;

    return status;
}
#undef ERROR_FORMAT_STRING1
int WriteStringArray(int FileHandle, struct StringArrayHdr_s *Source)
{
    unsigned short NumElem; // This limits us to 64K
    int status;
    int i;
    struct StringHdr_s *ElemPtr;
    int FinalRetValue = 0;

    if ( Source == NULL)
        return -1;

    // first write the number of strings
    // The topmost bit could be set if this is a dynamic string array
    NumElem = (Source->NumElem & ~DYN_STR_ARRAY_FLAG);
    status = FwriteCallback((char *)&NumElem, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    for ( i = 0; i <= NumElem; i++ )
    {
        ElemPtr = GetStringArrayElement(NULL, Source, i);
        status = WriteString(FileHandle, ElemPtr);
        if ( status < 0)
            return status;
        else
            FinalRetValue += status;    // sum up the number of bytes written so that we can return that value
    }
    return FinalRetValue;
}
#define ERROR_FORMAT_STRING1 "String Array %z overflow in File Read.  Num. Strings in File = %d.  NumElems = %d"
int ReadStringArray(void *InstancePtr, int FileHandle, struct StringArrayHdr_s *Dest)
{
    unsigned short StringCount;
    int StringsToSkip = 0;
    int status;
    int i;
    unsigned short NumElem; // This limits us to 64K
    struct StringHdr_s *ElemPtr;
    struct StringDynamicHdr_s *tempString;
    struct StringDynamicArrayHdr_s * dStrArr;
    int currNumChar = 0;

    if ( Dest == NULL)
        return -1;

    // The topmost bit could be set if this is a dynamic string array
    NumElem = Dest->NumElem & ~DYN_STR_ARRAY_FLAG;

    status = FreadCallback((char *)&StringCount, sizeof(unsigned short), FileHandle);
    if ( status < 0)
        return status;
    else if ( StringCount > NumElem )
    {
        // if we have a dynamic array, resize the array
        if (Dest->NumElem & DYN_STR_ARRAY_FLAG)
          {
            dStrArr = (struct StringDynamicArrayHdr_s *) Dest;
            // Get the first string to find out the size. This could behave in a weird
            // way if the user resizes all the strings to 0. Write to the file and then
            // read back. See if this causes problems.
            if (dStrArr->NumElem & DYN_STR_ARRAY_FLAG)
              {
                tempString = GetStringArrayElement(InstancePtr, dStrArr, 0);
                currNumChar = tempString->MaxLen;
              }// if the array has elements
            //else currNumChar is 0

            ResizeStringArray(InstancePtr,
              dStrArr,
              StringCount,
              currNumChar,
              1);  // don't force deallocation
            // StringsToSkip will be 0

          } // if array is dynamic
        else
          {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                Dest->Name, StringCount, NumElem);
        StringsToSkip = (StringCount - NumElem);
        StringCount = NumElem;
    }
    }
    for ( i = 0; i <= StringCount; i++)
    {
        ElemPtr = GetStringArrayElement(InstancePtr, Dest, i);
        status = ReadString(InstancePtr, FileHandle, ElemPtr);
        if ( status < 0)
            return status;
    }

    // for a dynamic array, stringstoskip will be 0
    if ( (status >= 0) && (StringsToSkip > 0) )                  // successful read
    {
        for ( i = 0; i < StringsToSkip; i++)
        {
            // read the number of bytes in the string to skip.
            status = FreadCallback((char *)&StringCount, sizeof(unsigned short), FileHandle);
            if ( status < 0)
                return status;
            FileSeek(FileHandle, StringCount, 1);  // 1 => SEEK_CUR
        }
    }
    return status;
}
#undef ERROR_FORMAT_STRING1

#define ERROR_FORMAT_STRING1 "Integer Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "Integer Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
#define ERROR_FORMAT_STRING3 "Null Array Pointer"
unsigned short* GetIntArrayElementPtr(void *InstancePtr, struct IntArrayHdr_s *Array, int Row, int Col)
{
    int Index;
    int dynFlag = 0;
    int numCols, numRows;
    struct IntDynamicArrayHdr_s *dynArray;

    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return 0;
    }


    // Only check for the NumCols for dynamic flag
    if (Array->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
        numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;
        numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      }
    else
      {
        numCols = Array->NumCols;
        numRows = Array->NumRows;
      }


    // bounds checking
    if ( (Col < 0) || (Col > numCols) ||
         (Row < 0) || (Row > numRows) ||
         (numCols ==0) )
    {
        if ( Array->NumRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag)
          {
            dynArray = (struct IntDynamicArrayHdr_s *)(Array);
            return &(dynArray->Data[0]);
          } //if (dynFlag)

        return;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
         dynArray = (struct IntDynamicArrayHdr_s *)(Array);
         return &(dynArray->Data[Index]);
      }
    else
      {
        return &(Array->Data[Index]);
      }

}
#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
#define ERROR_FORMAT_STRING1 "LongInteger Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "LongInteger Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
unsigned long* GetLongArrayElementPtr(void *InstancePtr, struct LongArrayHdr_s *Array, int Row, int Col)
{
    int Index;
    int dynFlag = 0;
    int numCols, numRows;
    struct LongDynamicArrayHdr_s *dynArray;

    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return 0;
    }

    // Only check for the NumCols for dynamic flag
    if (Array->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
        numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;
        numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      }
    else
      {
        numCols = Array->NumCols;
        numRows = Array->NumRows;
      }

    // bounds checking
    if ( (Col < 0) || (Col > numCols) ||
         (Row < 0) || (Row > numRows) ||
         (numCols ==0) )
    {
        if ( Array->NumRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag)
          {
            dynArray = (struct LongDynamicArrayHdr_s *)(Array);
            return &(dynArray->Data[0]);
          } //if (dynFlag)

        return;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
         dynArray = (struct LongDynamicArrayHdr_s *)(Array);
         return &(dynArray->Data[Index]);
      }
    else
      {
        return &(Array->Data[Index]);
      }
}

#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
#define ERROR_FORMAT_STRING1 "Signed Integer Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "Signed Integer Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
short* GetSignedIntArrayElementPtr(void *InstancePtr, struct SignedIntArrayHdr_s *Array, int Row, int Col)
{
    int Index;
    int dynFlag = 0;
    int numCols, numRows;
    struct SignedIntDynamicArrayHdr_s *dynArray;

    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return 0;
    }

    // Only check for the NumCols for dynamic flag
    if (Array->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
        numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;
        numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      }
    else
      {
        numCols = Array->NumCols;
        numRows = Array->NumRows;
      }

    // bounds checking
    if ( (Col < 0) || (Col > numCols) ||
         (Row < 0) || (Row > numRows) ||
         (numCols ==0) )
    {
        if ( Array->NumRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag)
          {
            dynArray = (struct SignedIntDynamicArrayHdr_s *)(Array);
            return &(dynArray->Data[0]);
          } //if (dynFlag)

        return;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
         dynArray = (struct SignedIntDynamicArrayHdr_s *)(Array);
         return &(dynArray->Data[Index]);
      }
    else
      {
        return &(Array->Data[Index]);
      }
}
#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
#define ERROR_FORMAT_STRING1 "Signed LongInteger Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "Signed LongInteger Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
long* GetSignedLongArrayElementPtr(void *InstancePtr, struct SignedLongArrayHdr_s *Array, int Row, int Col)
{
    int Index;
    int dynFlag = 0;
    int numCols, numRows;
    struct SignedLongDynamicArrayHdr_s *dynArray;

    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return 0;
    }
    // Only check for the NumCols for dynamic flag
    if (Array->NumCols & DYN_INT_ARRAY_FLAG)
      {
        dynFlag = 1;
        numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;
        numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      }
    else
      {
        numCols = Array->NumCols;
        numRows = Array->NumRows;
      }


    // bounds checking
    if ( (Col < 0) || (Col > numCols) ||
         (Row < 0) || (Row > numRows) ||
         (numCols ==0) )
    {
        if ( Array->NumRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag)
          {
            dynArray = (struct SignedLongDynamicArrayHdr_s *)(Array);
            return &(dynArray->Data[0]);
          } //if (dynFlag)

        return;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
         dynArray = (struct SignedLongDynamicArrayHdr_s *)(Array);
         return &(dynArray->Data[Index]);
      }
    else
      {
        return &(Array->Data[Index]);
      }
}
#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
#undef ERROR_FORMAT_STRING3

#define ERROR_FORMAT_STRING1 "Input/Output Array %z overflow.  Index = %d.  Bounds = 1 to %d."
#define ERROR_FORMAT_STRING2 "Parameter Array %z overflow.  Index = %d.  Bounds = 1 to %d."
unsigned CheckIOArrayBounds(void *InstancePtr, struct InOutArray_s *Array, int Index)
{
    unsigned ReturnValue;

    if ( (Index < 1) || (Index > (Array->LastInputNumber - Array->StartInputNumber + 1)) )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                Array->ArrayName, Index, (Array->LastInputNumber - Array->StartInputNumber + 1));
        // Will return the first element.
        ReturnValue = Array->StartInputNumber;
    }
    else
    {
        ReturnValue = Array->StartInputNumber + Index - 1;
    }

    return(ReturnValue);
}

unsigned CheckIOArrayBounds2(void *InstancePtr, struct InOutArray_s *Array, int Index)
{
    unsigned ReturnValue;

    if ( (Index < 1) || (Index > (Array->LastInputNumber - Array->StartInputNumber + 1)) )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                Array->ArrayName, Index, (Array->LastInputNumber - Array->StartInputNumber + 1));

        // Return an element number that probably will never exist.  If we ever do support
        // a full 32b worth of elements, I think we can get away with restricting this.
        ReturnValue = 0xFFFFFFFF;
    }
    else
    {
        ReturnValue = Array->StartInputNumber + Index - 1;
    }

    return(ReturnValue);
}

unsigned CheckStringArrayBounds(void *InstancePtr, struct StringArrayHdr_s *Array, int Index)
{
    unsigned ReturnValue;

    if ( (Index < 1) || (Index > (Array->LastInputNumber - Array->StartInputNumber + 1)) )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                Array->Name, Index, (Array->LastInputNumber - Array->StartInputNumber + 1));

        // Return an element number that probably will never exist.  If we ever do support
        // a full 32b worth of elements, I think we can get away with restricting this.
        ReturnValue = 0xFFFFFFFF;
    }
    else
    {
        ReturnValue = Array->StartInputNumber + Index - 1;
    }

    return(ReturnValue);
}

#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2

void InitializeRampInfoInternal(struct RampInfo_s *pRampInfo)
{
    if(pRampInfo)
    {
        pRampInfo->rampUpperBound = 65535;
        pRampInfo->rampLowerBound = 0;
        pRampInfo->rampBaseValue = 100000;
        pRampInfo->rampTargetValue = 65535;
        pRampInfo->rampBaseTime = 0;
        pRampInfo->rampTransitionTime = 500;
        pRampInfo->rampIdentifier = 0;
        pRampInfo->rampIsSigned = 0;
        pRampInfo->rampIsAbsolute = 0;
        pRampInfo->rampIsRunnable = 1;
        pRampInfo->rampIsExpired = 0;
    }
}

void InitializeRampInfo(void *InstancePtr, struct RampInfo_s *pRampInfo)
{
	InitializeRampInfoInternal(pRampInfo);
}

void InitRampInfoStructArray(void *InstancePtr, struct StructArrayHdr_s *Array, int NumElem, int ElemSize, char *Name)
{
    int i;
    struct RampInfo_s *pRampInfo;

    if ( Array == NULL )
        return;

    Array->NumElements = NumElem;
    Array->ElementSize = ElemSize;
    Array->Name = Name;

    // Initialize all the elements of the structures.
    for(i = 0 ; i<= NumElem ; i++)
    {
        pRampInfo = (struct RampInfo_s *)GetStructArrayElement(InstancePtr, Array, i);
        InitializeRampInfoInternal(pRampInfo);
    }
}

void InitRampInfoArray(void *InstancePtr, struct StructArrayHdr_s *Array)
{
    int i;
    int NumElem;
    struct RampInfo_s *pRampInfo;

    if ( Array == NULL )
        return;

    NumElem = Array->NumElements;

    // Initialize all the elements of the structures.
    for(i = 0 ; i<= NumElem ; i++)
    {
        pRampInfo = (struct RampInfo_s *)GetStructArrayElement(InstancePtr, Array, i);
        InitializeRampInfoInternal(pRampInfo);
    }
}

unsigned short hextoi(struct StringHdr_s *String)
{
    return((unsigned short)hextol(String));
}

short hextosi(struct StringHdr_s *String)
{
    return((short)hextol(String));
}

long hextosl(struct StringHdr_s *String)
{
    return((long)hextol(String));
}

unsigned long hextol(struct StringHdr_s *String)
{
    int i, end, offset = 0;
    unsigned long result = 0;
    char val;

    if(String && String->CurLen > 0)
    {
        end=String->CurLen-1;
        if(String->CurLen>8)
            offset=String->CurLen-8;

        for(i = offset ; i <= end ; i++)
        {
            val = GetCharFromString(String,i);
            if(val >= 'a' && val <= 'f')
                val -= 87;
            else if(val >= 'A' && val <= 'F')
                val -= 55;
            else
                val -= 0x30;

            result += (val * (1 << ((end-i)*4)));
        }
    }

    return(result);
}

// Put in for the SIMPL+ GUI translation specifically.
unsigned short LowerChar(unsigned short Character)
{
    return((unsigned short)MakeLower((unsigned char)Character));
}

// Put in for the SIMPL+ GUI translation specifically.
unsigned short UpperChar(unsigned short Character)
{
    return((unsigned short)MakeUpper((unsigned char)Character));
}
/* Direct Socket routines */
// String Routines
void InitTcpClient(void *InstancePtr, struct SocketHdr_s *pSocket, int Length, int SocketID,
                        char *Name)
{
    // Initialize the Rx buffer string structure
    InitStringStruct(&(pSocket->SocketRxBuf), e_INPUT_TYPE_SOCKET_BUFFER, Length, Name);
    RegisterInputString(InstancePtr, SocketID, &(pSocket->SocketRxBuf));
    pSocket->SocketStatus = eCLIENT_SERVER_NOT_CONNECTED;
    pSocket->eSocketType = e_SOCKET_TYPE_CLIENT;
    pSocket->SocketID = SocketID;
    pSocket->SocketPtr = CreateSplusSocket(InstancePtr, pSocket);
}
void InitTcpServer(void *InstancePtr, struct SocketHdr_s *pSocket, int Length, int SocketID,
                        char *Name)
{
    // Initialize the Rx buffer string structure
    InitStringStruct(&(pSocket->SocketRxBuf), e_INPUT_TYPE_SOCKET_BUFFER, Length, Name);
    RegisterInputString(InstancePtr, SocketID, &(pSocket->SocketRxBuf));
    pSocket->SocketStatus = eCLIENT_SERVER_NOT_CONNECTED;
    pSocket->eSocketType = e_SOCKET_TYPE_SERVER;
    pSocket->SocketID = SocketID;
    pSocket->SocketPtr = CreateSplusSocket(InstancePtr, pSocket);
}
void InitUdpSocket(void *InstancePtr, struct SocketHdr_s *pSocket, int Length, int SocketID,
                        char *Name)
{
    // Initialize the Rx buffer string structure
    InitStringStruct(&(pSocket->SocketRxBuf), e_INPUT_TYPE_SOCKET_BUFFER, Length, Name);
    RegisterInputString(InstancePtr, SocketID, &(pSocket->SocketRxBuf));
    pSocket->SocketStatus = eCLIENT_SERVER_NOT_CONNECTED;
    pSocket->eSocketType = e_SOCKET_TYPE_UDP;
    pSocket->SocketID = SocketID;
    pSocket->SocketPtr = CreateSplusSocket(InstancePtr, pSocket);
}

void CheckBufferThreshold(struct StringHdr_s * String)
{
    if ( String->InputType == e_INPUT_TYPE_SOCKET_BUFFER_FULL )  // special check for full SOCKET buffers
    {
        int iThreshold = SPLUS_SOCKET_BUFFER_THRESHOLD(String->MaxLen);
        if ( String->CurLen <= iThreshold )
            WakeSocketsCallback();
    }
}





#define ERROR_FORMAT_STRING1 "%z: Destination string %z overflow. CurLen = %d, MaxLen = %d."
/**
 *
 * \date        06-10-2008
 * \author      mtalreja
 * \brief       ResizeIfAutogrow
 * \detail      Function to resize the string if it is autogrow
 * \return      What is returned
 * \retval      
 * \warning     
 * \note        This function checks to see if the new length expected from the string is 
 *              greater than the max length of the destination. If not, it just sets the
 *              current length of the string to the new length. 
 *              If the new length expected is greater and the string is dynamic autogrow,
 *              an attempt will be made to resize the string.
 *              If the new length expected is greater and the string is not dynamic,
 *              the destination current length will be set to the destination max length.
 *
 * \param InstancePtr   Instance Pointer
 * \param *Dest         Destination String that needs to be checked
 * \param newLength     New Length expected from the Destination String
 * \param maxLen        Max Allowable length of the source string
 * \param *errPrefix    Character pointer that is printed as a prefix to the error
 * \param genNonDynErr  Boolean to indicate if we should generate an error if Dest is non-dynamic
 * \return 
 */
int ResizeIfAutogrow(void * InstancePtr, struct StringHdr_s *Dest, unsigned int newLength, unsigned int maxLen, char *errPrefix, int genNonDynErr)
  {
    int retVal;
  
    if ( newLength > Dest->MaxLen )
    {
        // MNT - 6/3/2008 - Resize the destination string if it is autogrow
        if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)
          {
            // MNT - 6/4/2008 - Cap off the dest string upper limit to the max string size
            newLength = maxLen;
    
            retVal = ResizeString(InstancePtr, Dest, newLength, LIB_TRUE);// stay verbose for now

            if (retVal != 0)
              {
                Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                        errPrefix, Dest->Name, newLength, Dest->MaxLen);
                Dest->CurLen = Dest->MaxLen;
              } //if (retVal != 0)
            else
              {
                Dest->CurLen = newLength;
              } //if (retVal != 0)

          } //if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)
        else
          {
            // MNT - 6/9/2008 - Generate an error only if needed
            if (genNonDynErr)
              {
                Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                        errPrefix, Dest->Name, newLength, Dest->MaxLen);
              } // if (genNonDynErr)
            Dest->CurLen = Dest->MaxLen;
          } //if (Dest->InputType == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW)
    } // if ( newLength > Dest->MaxLen )
    else
    {
      Dest->CurLen = newLength;
    } // if ( newLength > Dest->MaxLen )

    return retVal;
  
  }

/**
 *
 * \date        05-25-2012
 * \author      Nick Huynh
 * \note        This function tries to lock the input string semaphore.
 * \warning     We have to make sure the firmware supports this function
 *              therefore we have to check before we call into the translated
 *              firmware function call to avoid crashing.
 *
 * \param InstancePtr   Instance Pointer
 * \param Source        The input string that has the semaphore
 */
void LockInputSema(void *InstancePtr, struct StringHdr_s *Source)
{
    if(&CreateSplusSocket != &NotImplementedYet)                // check if Socket stuff was implemented
    {
        if(&ObtainStringInputSemaphore != &NotImplementedYet    // if Socket stuff was implemented then we 
            &ObtainStringInputSemaphore != NULL)                // can check if ObtainStringInputSemaphore was implemented
        {
            ObtainStringInputSemaphore(InstancePtr, Source);
        }
    }
}

/**
 *
 * \date        05-25-2012
 * \author      Nick Huynh
 * \note        This function tries to unlock the input string semaphore.
 * \warning     We have to make sure the firmware supports this function
 *              therefore we have to check before we call into the translated
 *              firmware function call to avoid crashing.
 *
 * \param InstancePtr   Instance Pointer
 * \param Source        The input string that has the semaphore
 */
void UnLockInputSema(void *InstancePtr, struct StringHdr_s *Source)
{
    if(&CreateSplusSocket != &NotImplementedYet)                // check if Socket stuff was implemented
    {
        if(&ReleaseStringInputSemaphore != NotImplementedYet    // if Socket stuff was implemented then we
            &ReleaseStringInputSemaphore != NULL)               // can check if ReleaseStringInputSemaphorewas implemented
        {
            ReleaseStringInputSemaphore(InstancePtr, Source);
        }
    }
}

#undef ERROR_FORMAT_STRING1
