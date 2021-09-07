
/* Types used by the Simpl+ GNU C code */

#ifndef _TYPEDEFS_H
#define _TYPEDEFS_H

#ifdef DEBUG_MODE_FLAG
#define INLINE_MODE     0   // 0 - disable the checking for int array access
#else // debug mode flag
#define INLINE_MODE     1   // 1 - ensable the checking for int array access
#endif // endif debug mode flag

#if INLINE_MODE
#define INLINE inline extern
#else
#define INLINE
#endif

#ifndef IN_OUT_ARRAY_STRUCT
#define IN_OUT_ARRAY_STRUCT

struct InOutArray_s
{
    int SignalType;                     // type of signal: Digital, Analog, String
    int StartInputNumber;               // starting input number of array
    int LastInputNumber;                // last input number of array
    int LastModified;                   // set during event processing to indicate
                                        //    for which element of array the event occurred
    char *ArrayName;                    // to be used in error reporting
};

#define IO_TYPE_DIGITAL_INPUT                   0x00
#define IO_TYPE_ANALOG_INPUT                    0x01
#define IO_TYPE_STRING_INPUT                    0x02
#define IO_TYPE_DIGITAL_OUTPUT                  0x03
#define IO_TYPE_ANALOG_OUTPUT                   0x04
#define IO_TYPE_STRING_OUTPUT                   0x05
#define IO_TYPE_INTEGER_PARAMETER               0x06
#define IO_TYPE_SIGNED_INTEGER_PARAMETER        0x07
#define IO_TYPE_LONG_INTEGER_PARAMETER          0x08
#define IO_TYPE_SIGNED_LONG_INTEGER_PARAMETER   0x09
#define IO_TYPE_STRING_PARAMETER                0x0A

#endif
// macro to call the InputArray initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      type - type of the input signal: digital, analog, or string
//      start - starting input number for the array
//      length - declared length of the array
#define INITIALIZE_IO_ARRAY(ModuleName, name, type, start, length)    \
InitInOutArray(&Globals->##ModuleName##.##name, type, start, length, #name)

#define DECLARE_IO_ARRAY(name)             \
    struct InOutArray_s name

// macro to insert call to CheckInputArray
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
#define CHECK_INPUT_ARRAY(ModuleName, name)    \
    CheckInputArray(&Globals->##ModuleName##.##name, Signal, &Globals->##ModuleName##.LastModifiedArrayIndex)

#define CHECK_STRING_INPUT_ARRAY(ModuleName, name)    \
    CheckStringInputArray((struct StringArrayHdr_s *)&Globals->##ModuleName##.##name, Signal, &Globals->##ModuleName##.LastModifiedArrayIndex)

// This macro accesses the global variable.  For use when no parameter is given.
#define GetGlobalLastModifiedArrayIndex(ModuleName)    \
    Globals->##ModuleName##.LastModifiedArrayIndex

// This macro accesses the  variable.  For use when no parameter is given.
#define GetLocalLastModifiedArrayIndex(ModuleName)    \
    Signal->LastModified

// This macro accesses checks the array itself. For use when array is specified as a parameter.  (FUTURE)
#define GetLastModifiedArrayIndex(ModuleName, name)    \
    Globals->##ModuleName##.##name##.LastModified

#define GET_INOUTARRAY_SIGNAL_NUM(ModuleName, name, index)    \
    (Globals->##ModuleName##.##name##.StartInputNumber + index - 1)

#ifndef STRING_BUFFER_STRUCT
#define STRING_BUFFER_STRUCT

enum EInputType
{
    e_INPUT_TYPE_NONE,
    e_INPUT_TYPE_BUFFER,
    e_INPUT_TYPE_STRING,
    e_INPUT_TYPE_STRING_PARAMETER,
    e_INPUT_TYPE_STRING_DYNAMIC,
    e_INPUT_TYPE_SOCKET_BUFFER,
    e_INPUT_TYPE_SOCKET_BUFFER_FULL,
    e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW
};

// structure to map the header of the StringBuffer type
struct StringHdr_s
{
    enum EInputType InputType;
    int MaxLen;
    int CurLen;
    char *Name;                             // to be used in error reporting
    unsigned char String[4];
};


struct StringDynamicHdr_s
{
    enum EInputType InputType;
    int MaxLen;
    int CurLen;
    char *Name;                             // to be used in error reporting
    unsigned char *String;
};

struct StringDynamicAutogrowHdr_s
{
    enum EInputType InputType;
    int MaxLen;
    int CurLen;
    char *Name;                             // to be used in error reporting
    unsigned char *String;
};


// structure to map the header of the StringArray type
struct StringArrayHdr_s
{
    int NumElem;
    int StartInputNumber;               // starting input number of array
    int LastInputNumber;                // last input number of array
    int LastModified;                   // set during event processing to indicate
                                        //    for which element of array the event occurred
    char *Name;
    struct StringHdr_s Strings[1];
};

// structure to map the header of the Dynamic StringArray type
struct StringDynamicArrayHdr_s
{
    int NumElem;
    int StartInputNumber;               // starting input number of array
    int LastInputNumber;                // last input number of array
    int LastModified;                   // set during event processing to indicate
                                        //    for which element of array the event occurred
    char *Name;
    struct StringDynamicHdr_s * Strings;
};
#endif

// create the structure for the Generic output string here.
#define GENERIC_STRING_OUTPUT_LEN   256
struct GenericOutputString_s
{
    enum EInputType InputType;
    int MaxLen;
    int CurLen;
    char *Name;                             // to be used in error reporting
    unsigned char String[GENERIC_STRING_OUTPUT_LEN + 4];
};

#define CREATE_STRING_STRUCT(ModuleName, name, length)      \
struct ModuleName##name##String_s                           \
{                                                           \
    enum EInputType InputType;                                          \
    int MaxLen;                                             \
    int CurLen;                                             \
    char *Name;                                             \
    unsigned char String[length+4];                         \
}
#define DECLARE_STRING_STRUCT(ModuleName, name)             \
    struct ModuleName##name##String_s name

#define DECLARE_LOCAL_STRING_STRUCT(ModuleName, name)       \
    struct ModuleName##name##String_s* name



#define CREATE_DYNAMIC_STRING_STRUCT(ModuleName, name, length)      \
struct ModuleName##name##DynamicString_s                           \
{                                                           \
    enum EInputType InputType;                                          \
    int MaxLen;                                             \
    int CurLen;                                             \
    char *Name;                                             \
    unsigned char *String;                         \
}
#define DECLARE_DYNAMIC_STRING_STRUCT(ModuleName, name)             \
    struct ModuleName##name##DynamicString_s name

#define DECLARE_LOCAL_DYNAMIC_STRING_STRUCT(ModuleName, name)       \
    struct ModuleName##name##DynamicString_s* name



#define CREATE_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name, length)      \
struct ModuleName##name##DynamicAutogrowString_s                           \
{                                                           \
    enum EInputType InputType;                                          \
    int MaxLen;                                             \
    int CurLen;                                             \
    char *Name;                                             \
    unsigned char *String;                         \
}
#define DECLARE_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name)             \
    struct ModuleName##name##DynamicAutogrowString_s name

#define DECLARE_LOCAL_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name)       \
    struct ModuleName##name##DynamicAutogrowString_s* name





// macro to call the string initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      type - indicates whether STRING or BUFFER variable.
//      length - declared length
#define INITIALIZE_GLOBAL_STRING_STRUCT(ModuleName, name, type, length)    \
InitStringStruct((struct StringHdr_s *)&Globals->##ModuleName##.##name##, type, length, #name)

// Move this define to somewhere meaningful
#define MAX_STRING_SIZE        ((64*1024)-1)
#define MAX_STRINGARRAY_SIZE   ((64*1024)-1)
#define MAX_INTARRAY_SIZE      ((64*1024)-1)
#define MAX_STRUCTARRAY_SIZE   ((64*1024)-1)

#define INITIALIZE_GLOBAL_DYNAMIC_STRING_STRUCT(ModuleName, name, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)&Globals->##ModuleName##.##name##, type, length, #name)

#define INITIALIZE_GLOBAL_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)&Globals->##ModuleName##.##name##, type, length, #name)

#define INITIALIZE_NVRAM_STRING_STRUCT(ModuleName, name, type, length)    \
InitNvramStringStruct((struct StringHdr_s *)&Nvram->##ModuleName##.##name##, type, length, #name)

//----
#define INITIALIZE_LOCAL_STRING_STRUCT(name, length)     \
InitStringStruct((struct StringHdr_s *)##name##, e_INPUT_TYPE_NONE, length, #name)

#define INITIALIZE_LOCAL_DYNAMIC_STRING_STRUCT(ModuleName, name, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)##name##, e_INPUT_TYPE_STRING_DYNAMIC, length, #name)

#define INITIALIZE_LOCAL_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name, length)    \
  InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)##name##, e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW, length, #name)
//----


//----
#define INITIALIZE_GLOBAL_STRUCT_STRING(ModuleName, StructName, StringName, type, length)    \
InitStringStruct((struct StringHdr_s *)&Globals->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)

#define INITIALIZE_GLOBAL_STRUCT_DYNAMIC_STRING(ModuleName, StructName, StringName, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)&Globals->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)

#define INITIALIZE_GLOBAL_STRUCT_DYNAMIC_AUTOGROW_STRING(ModuleName, StructName, StringName, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)&Globals->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)
//----


#define INITIALIZE_NVRAM_STRUCT_STRING(ModuleName, StructName, StringName, type, length)    \
InitNvramStringStruct((struct StringHdr_s *)&Nvram->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)


//----
#define INITIALIZE_LOCAL_STRUCT_STRING(StructName, StringName, type, length)    \
InitStringStruct((struct StringHdr_s *)##StructName##->##StringName##, type, length, #StringName)

#define INITIALIZE_LOCAL_STRUCT_DYNAMIC_STRING(ModuleName, StructName, StringName, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)##StructName##->##StringName##, type, length, #StringName)

#define INITIALIZE_LOCAL_STRUCT_DYNAMIC_AUTOGROW_STRING(ModuleName, StructName, StringName, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)##StructName##->##StringName##, type, length, #StringName)
//----


//----
#define INITIALIZE_GLOBAL_STRUCT_ARRAY_STRING(ModuleName, StructName, StringName, type, length)    \
InitStringStruct((struct StringHdr_s *)&Globals->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)

#define INITIALIZE_GLOBAL_STRUCT_ARRAY_DYNAMIC_STRING(ModuleName, StructName, StringName, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)&Globals->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)

#define INITIALIZE_GLOBAL_STRUCT_ARRAY_DYNAMIC_AUTOGROW_STRING(ModuleName, StructName, StringName, type, length)    \
InitDynamicStringStruct( INSTANCE_PTR( ModuleName ), (struct StringHdr_s *)&Globals->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)
//----


#define INITIALIZE_NVRAM_STRUCT_ARRAY_STRING(ModuleName, StructName, StringName, type, length)    \
InitNvramStringStruct((struct StringHdr_s *)&Nvram->##ModuleName##.##StructName##.##StringName##, type, length, #StringName)


//--
#define ALLOCATE_LOCAL_STRING_STRUCT(ModuleName, name)  \
name = (struct ModuleName##name##String_s *)Allocate(sizeof(struct ModuleName##name##String_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_STRING_STRUCT(name)    \
Deallocate(name)


#define ALLOCATE_LOCAL_DYNAMIC_STRING_STRUCT(ModuleName, name)  \
name = (struct ModuleName##name##DynamicString_s *)Allocate(sizeof(struct ModuleName##name##DynamicString_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_DYNAMIC_STRING_STRUCT(ModuleName, name)    \
{                                                             \
  ResizeString( INSTANCE_PTR(ModuleName), name, -1, 0);     \
  Deallocate(name);                                           \
}


#define ALLOCATE_LOCAL_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name)  \
name = (struct ModuleName##name##DynamicString_s *)Allocate(sizeof(struct ModuleName##name##DynamicAutogrowString_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name)    \
{                                                             \
  ResizeString( INSTANCE_PTR(ModuleName), name, -1, 0);     \
  Deallocate(name);                                           \
}







//--


// the -1 below accounts for the fact that sizeof includes the NULL character
//----
// Both these definitions will fail if the size of the target is smaller than
// the size of the source string. The second one will cause problems if memory
// has not been allocated for string
#define SET_LOCAL_STRING_STRUCT(name, setstring)    \
name##->InputType = e_INPUT_TYPE_NONE;               \
name##->MaxLen = sizeof(setstring) - 1;              \
name##->CurLen = sizeof(setstring) - 1;              \
name##->Name = #name;                                \
memcpy(&(name##->String[0]), setstring, name##->CurLen)

#define SET_LOCAL_DYNAMIC_STRING_STRUCT(name, setstring)    \
name##->InputType = e_INPUT_TYPE_STRING_DYNAMIC;               \
name##->MaxLen = sizeof(setstring) - 1;              \
name##->CurLen = sizeof(setstring) - 1;              \
name##->Name = #name;                                \
memcpy(name##->String, setstring, name##->CurLen)

#define SET_LOCAL_DYNAMIC_AUTOGROW_STRING_STRUCT(name, setstring)    \
name##->InputType = e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW;               \
name##->MaxLen = sizeof(setstring) - 1;              \
name##->CurLen = sizeof(setstring) - 1;              \
name##->Name = #name;                                \
memcpy(name##->String, setstring, name##->CurLen)


//----




// macro to register the string/buffer input with the Instance
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      number - input number for the string/buffer
#define REGISTER_GLOBAL_INPUT_STRING(ModuleName, name, number)    \
RegisterInputString(Globals->##ModuleName##.InstancePtr, number, (struct StringHdr_s *)&Globals->##ModuleName##.##name##)

#define REGISTER_NVRAM_INPUT_STRING(ModuleName, name, number)    \
RegisterInputString(Globals->##ModuleName##.InstancePtr, number, (struct StringHdr_s *)&Nvram->##ModuleName##.##name##)

// macro to update the string/buffer inputs for the Instance.  Requires Signal to be
//   declared.
//      ModuleName - name of the Simpl+ module.
#define UPDATE_INPUT_STRING(ModuleName)    \
UpdateInputString(Globals->##ModuleName##.InstancePtr, Signal)


//----
#define GLOBAL_STRING_STRUCT(ModuleName, name)    \
    ((struct StringHdr_s*)&(Globals->##ModuleName##.##name##))

#define GLOBAL_DYNAMIC_STRING_STRUCT(ModuleName, name)    \
    ((struct StringDynamicHdr_s*)&(Globals->##ModuleName##.##name##))

#define GLOBAL_DYNAMIC_AUTOGROW_STRING_STRUCT(ModuleName, name)    \
    ((struct StringDynamicAutogrowHdr_s*)&(Globals->##ModuleName##.##name##))
//----

#define NVRAM_STRING_STRUCT(ModuleName, name)    \
    ((struct StringHdr_s*)&(Nvram->##ModuleName##.##name##))

//----
#define LOCAL_STRING_STRUCT(name)    \
    ((struct StringHdr_s*)##name##)

#define LOCAL_DYNAMIC_STRING_STRUCT(name)    \
    ((struct StringDynamicHdr_s*)##name##)
#define LOCAL_DYNAMIC_STRING_STRUCT(name)    \
    ((struct StringDynamicHdr_s*)##name##)
#define LOCAL_DYNAMIC_AUTOGROW_STRING_STRUCT(name)    \
    ((struct StringDynamicAutogrowHdr_s*)##name##)
//----

//----@@@@ needs to be fixed
#define CREATE_STRING_ARRAY(ModuleName, name, numelems, numchars)   \
struct ModuleName##name##String_s               \
{                                               \
    enum EInputType InputType;                              \
    int MaxLen;                                 \
    int CurLen;                                 \
    char *Name;                                 \
    char String[numchars+4];                    \
};                                              \
struct ModuleName##name##StringArray_s          \
{                                               \
    int NumElem;                                \
    int StartInputNumber;                       \
    int LastInputNumber;                        \
    int LastModified;                           \
    char *Name;                                 \
    struct ModuleName##name##String_s Strings[numelems+1];  \
}
//----



//----@@@@ needs to be fixed
#define CREATE_DYNAMIC_STRING_ARRAY(ModuleName, name, numelems, numchars)   \
struct ModuleName##name##DynamicString_s               \
{                                               \
    enum EInputType InputType;                              \
    int MaxLen;                                 \
    int CurLen;                                 \
    char *Name;                                 \
    char *String;                    \
};                                              \
struct ModuleName##name##DynamicStringArray_s          \
{                                               \
    int NumElem;                                \
    int StartInputNumber;                       \
    int LastInputNumber;                        \
    int LastModified;                           \
    char *Name;                                 \
    struct ModuleName##name##DynamicString_s *Strings;  \
}
//----


//----@@@@ needs to be fixed
#define CREATE_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name, numelems, numchars)   \
struct ModuleName##name##DynamicAutogrowString_s               \
{                                               \
    enum EInputType InputType;                              \
    int MaxLen;                                 \
    int CurLen;                                 \
    char *Name;                                 \
    char *String;                    \
};                                              \
struct ModuleName##name##DynamicAutogrowStringArray_s          \
{                                               \
    int NumElem;                                \
    int StartInputNumber;                       \
    int LastInputNumber;                        \
    int LastModified;                           \
    char *Name;                                 \
    struct ModuleName##name##DynamicAutogrowString_s *Strings;  \
}
//----



#define DECLARE_STRING_ARRAY(ModuleName, name)  \
    struct ModuleName##name##StringArray_s name

#define DECLARE_LOCAL_STRING_ARRAY(ModuleName, name)       \
    struct ModuleName##name##StringArray_s* name

#define GLOBAL_STRING_ARRAY(ModuleName, name)    \
    ((struct StringArrayHdr_s*)&(Globals->##ModuleName##.##name##))

#define NVRAM_STRING_ARRAY(ModuleName, name)    \
    ((struct StringArrayHdr_s*)&(Nvram->##ModuleName##.##name##))

#define LOCAL_STRING_ARRAY(name)    \
    ((struct StringArrayHdr_s*)##name##)




#define DECLARE_DYNAMIC_STRING_ARRAY(ModuleName, name)  \
    struct ModuleName##name##DynamicStringArray_s name

#define DECLARE_LOCAL_DYNAMIC_STRING_ARRAY(ModuleName, name)       \
    struct ModuleName##name##DynamicStringArray_s* name

#define GLOBAL_DYNAMIC_STRING_ARRAY(ModuleName, name)    \
    ((struct StringDynamicArrayHdr_s*)&(Globals->##ModuleName##.##name##))

#define LOCAL_DYNAMIC_STRING_ARRAY(name)    \
    ((struct StringDynamicArrayHdr_s*)##name##)



#define DECLARE_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name)  \
    struct ModuleName##name##DynamicAutogrowStringArray_s name

#define DECLARE_LOCAL_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name)       \
    struct ModuleName##name##DynamicAutogrowStringArray_s* name

#define GLOBAL_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name)    \
    ((struct StringDynamicAutogrowArrayHdr_s*)&(Globals->##ModuleName##.##name##))

#define LOCAL_DYNAMIC_AUTOGROW_STRING_ARRAY(name)    \
    ((struct StringDynamicAutogrowArrayHdr_s*)##name##)





// macro to call the string initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      type - indicates whether STRING or BUFFER variable.
//      length - declared length
#define INITIALIZE_GLOBAL_STRING_ARRAY(ModuleName, name, type, numelem, numchar)    \
InitStringArray((struct StringArrayHdr_s *)&Globals->##ModuleName##.##name##, type, numelem, numchar, #name, 0)

// macro to call the string initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      type - indicates whether STRING or BUFFER variable.
//      length - declared length
#define INITIALIZE_GLOBAL_DYNAMIC_STRING_ARRAY(ModuleName, name, type, numelem, numchar)    \
InitDynamicStringArray( INSTANCE_PTR( ModuleName ), (struct StringDynamicArrayHdr_s *)&Globals->##ModuleName##.##name##, type, numelem, numchar, #name, 0)

// macro to call the string initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      type - indicates whether STRING or BUFFER variable.
//      length - declared length
#define INITIALIZE_GLOBAL_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name, type, numelem, numchar)    \
InitDynamicAutogrowStringArray( INSTANCE_PTR( ModuleName ), (struct StringDynamicAutogrowArrayHdr_s *)&Globals->##ModuleName##.##name##, type, numelem, numchar, #name, 0)


#define INITIALIZE_GLOBAL_STRING_INPUT_ARRAY(ModuleName, name, type, numelem, numchar, start)    \
InitStringArray((struct StringArrayHdr_s *)&Globals->##ModuleName##.##name##, type, numelem, numchar, #name, start)

#define INITIALIZE_GLOBAL_STRING_PARAMETER_ARRAY(ModuleName, name, type, numelem, numchar, start)    \
InitStringParamArray(Globals->##ModuleName##.InstancePtr, (struct StringArrayHdr_s *)&Globals->##ModuleName##.##name##, type, numelem, numchar, #name, start)

#define INITIALIZE_NVRAM_STRING_ARRAY(ModuleName, name, type, numelem, numchar)    \
InitNvramStringArray((struct StringArrayHdr_s *)&Nvram->##ModuleName##.##name##, type, numelem, numchar, #name, 0)

#define INITIALIZE_NVRAM_STRING_INPUT_ARRAY(ModuleName, name, type, numelem, numchar, start)    \
InitNvramStringArray((struct StringArrayHdr_s *)&Nvram->##ModuleName##.##name##, type, numelem, numchar, #name, start)

#define INITIALIZE_LOCAL_STRING_ARRAY(name, numelem, numchar)    \
InitStringArray((struct StringArrayHdr_s *)##name##, e_INPUT_TYPE_NONE, numelem, numchar, #name, 0)

#define INITIALIZE_LOCAL_DYNAMIC_STRING_ARRAY(ModuleName, name, numelem, numchar)    \
InitDynamicStringArray( INSTANCE_PTR( ModuleName ), (struct StringDynamicArrayHdr_s *)##name##, e_INPUT_TYPE_STRING_DYNAMIC, numelem, numchar, #name, 0)

#define INITIALIZE_LOCAL_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name, numelem, numchar)    \
InitDynamicAutogrowStringArray( INSTANCE_PTR( ModuleName ), (struct StringDynamicAutogrowArrayHdr_s *)##name##, e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW, numelem, numchar, #name, 0)

#define REGISTER_GLOBAL_INPUT_STRING_ARRAY(ModuleName, name)    \
RegisterInputStringArray(Globals->##ModuleName##.InstancePtr, (struct StringArrayHdr_s *)&Globals->##ModuleName##.##name##)

#define REGISTER_NVRAM_INPUT_STRING_ARRAY(ModuleName, name)    \
RegisterInputStringArray(Globals->##ModuleName##.InstancePtr, (struct StringArrayHdr_s *)&Nvram->##ModuleName##.##name##)

#define ALLOCATE_LOCAL_STRING_ARRAY(ModuleName, name)  \
name = (struct ModuleName##name##StringArray_s *)Allocate(sizeof(struct ModuleName##name##StringArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_STRING_ARRAY(name)    \
Deallocate(name)


#define ALLOCATE_LOCAL_DYNAMIC_STRING_ARRAY(ModuleName, name)  \
name = (struct ModuleName##name##DynamicStringArray_s *)Allocate(sizeof(struct ModuleName##name##DynamicStringArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}



#define FREE_LOCAL_DYNAMIC_STRING_ARRAY(ModuleName, name)    \
{                                                             \
  ResizeStringArray( INSTANCE_PTR(ModuleName), name, -1, 0, 0);     \
  Deallocate(name);                                           \
}



#define ALLOCATE_LOCAL_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name)  \
name = (struct ModuleName##name##DynamicAutogrowStringArray_s *)Allocate(sizeof(struct ModuleName##name##DynamicAutogrowStringArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}



#define FREE_LOCAL_DYNAMIC_AUTOGROW_STRING_ARRAY(ModuleName, name)    \
{                                                             \
  ResizeStringArray( INSTANCE_PTR(ModuleName), name, -1, 0, 0);      \
  Deallocate(name);                                           \
}




// structure to map the header of the IntArray type
struct IntArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    unsigned short Data[2];
};
// structure to map the header of the IntArray type
struct IntDynamicArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    unsigned short *Data;
};

#define CREATE_INTARRAY1D(ModuleName, name, cols)      \
struct ModuleName##name##IntArray_s                     \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    unsigned short Data[cols+1];            \
}
#define CREATE_DYNAMIC_INTARRAY1D(ModuleName, name, cols)      \
struct ModuleName##name##DynamicIntArray_s                     \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    unsigned short *Data;                   \
}

#define CREATE_INTARRAY2D(ModuleName, name, rows, cols)      \
struct ModuleName##name##IntArray_s                     \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    unsigned short Data[(rows+1)*(cols+1)]; \
}


#define CREATE_DYNAMIC_INTARRAY2D(ModuleName, name, rows, cols)      \
struct ModuleName##name##DynamicIntArray_s                     \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    unsigned short * Data;                  \
}


#define DECLARE_INTARRAY(ModuleName, name)             \
    struct ModuleName##name##IntArray_s name

#define DECLARE_DYNAMIC_INTARRAY(ModuleName, name)             \
    struct ModuleName##name##DynamicIntArray_s name

#define DECLARE_LOCAL_INTARRAY(ModuleName, name)       \
    struct ModuleName##name##IntArray_s* name

#define DECLARE_LOCAL_DYNAMIC_INTARRAY(ModuleName, name)       \
    struct ModuleName##name##DynamicIntArray_s* name


#define GLOBAL_DYNAMIC_INTARRAY(ModuleName, name)    \
  ((struct IntDynamicArrayHdr_s*)&(Globals->##ModuleName##.##name##))

#define LOCAL_DYNAMIC_INTARRAY(name)    \
    ((struct IntDynamicArrayHdr_s*)##name##)



// macros to call the int array initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      rows - number of rows in the array
//      cols - number of columns in the array
#define INITIALIZE_GLOBAL_INTARRAY(ModuleName, name, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_GLOBAL_DYNAMIC_INTARRAY(ModuleName, name, rows, cols)    \
InitDynamicIntArray(INSTANCE_PTR( ModuleName ), (struct IntDynamicArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_NVRAM_INTARRAY(ModuleName, name, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)&Nvram->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_INTARRAY(name, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_DYNAMIC_INTARRAY(ModuleName , name, rows, cols)    \
InitDynamicIntArray( INSTANCE_PTR( ModuleName ), (struct IntDynamicArrayHdr_s *)##name##, rows, cols, #name)

#define INITIALIZE_GLOBAL_STRUCT_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_GLOBAL_STRUCT_DYNAMIC_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitDynamicIntArray(INSTANCE_PTR( ModuleName ), (struct IntDynamicArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_NVRAM_STRUCT_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)&Nvram->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_INTARRAY(StructName, ArrayName, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_DYNAMIC_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitDynamicIntArray(INSTANCE_PTR( ModuleName ), (struct IntDynamicArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

#define ALLOCATE_LOCAL_INTARRAY(ModuleName, name)  \
name = (struct ModuleName##name##IntArray_s *)Allocate(sizeof(struct ModuleName##name##IntArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_INTARRAY(name)    \
Deallocate(name)

#define ALLOCATE_LOCAL_DYNAMIC_INTARRAY(ModuleName, name)  \
name = (struct ModuleName##name##DynamicIntArray_s *)Allocate(sizeof(struct ModuleName##name##DynamicIntArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_DYNAMIC_INTARRAY(ModuleName, name)    \
{                                                             \
  ResizeIntegerArray( INSTANCE_PTR(ModuleName), name, 0, -1, e_INTARR_TYPE_INT, 0);        \
  Deallocate(name);                                           \
}





// macros to define GetNumArrayCols
// Remove the topmost bit to allow correct numbers for dynamic arrays.
// NVRAM arrays cannot be dynamic
#define GET_GLOBAL_INTARRAY_NUMCOLS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumCols & ~DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_INTARRAY_NUMCOLS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumCols

#define GET_GLOBAL_INTARRAY_NUMROWS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumRows & ~DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_INTARRAY_NUMROWS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumRows

#define GET_LOCAL_INTARRAY_NUMCOLS(name)    \
(name##->NumCols & ~DYN_INT_ARRAY_FLAG)

#define GET_LOCAL_INTARRAY_NUMROWS(name)    \
(name##->NumRows & ~DYN_INT_ARRAY_FLAG)

#define GET_GLOBAL_STRING_NUMCOLS(ModuleName, name)    \
Globals->##ModuleName##.##name##.MaxLen

#define GET_NVRAM_STRING_NUMCOLS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.MaxLen

#define GET_LOCAL_STRING_NUMCOLS(name)    \
name##->MaxLen

#define GET_GLOBAL_STRING_NUMROWS(ModuleName, name)    0
#define GET_NVRAM_STRING_NUMROWS(ModuleName, name)    0
#define GET_LOCAL_STRING_NUMROWS(name)    0

/* Validate the string structure before accessing it */
#define GET_GLOBAL_STRING_ARRAY_NUMCOLS(ModuleName, name)    \
((Globals->##ModuleName##.##name##.Strings) ? (Globals->##ModuleName##.##name##.Strings[0].MaxLen) : 0)

#define GET_NVRAM_STRING_ARRAY_NUMCOLS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.Strings[0].MaxLen

/* Validate the string structure before accessing it */
#define GET_LOCAL_STRING_ARRAY_NUMCOLS(name)    \
((name##->Strings) ? (name##->Strings[0].MaxLen) : 0)

#define GET_GLOBAL_STRING_ARRAY_NUMROWS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumElem & ~DYN_STR_ARRAY_FLAG)

#define GET_NVRAM_STRING_ARRAY_NUMROWS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumElem

#define GET_LOCAL_STRING_ARRAY_NUMROWS(name)    \
(name##->NumElem & ~DYN_STR_ARRAY_FLAG)

#define GET_IO_ARRAY_NUMCOLS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.LastInputNumber - Globals->##ModuleName##.##name##.StartInputNumber + 1)

// macros to call SetIntArrayElement
#define SET_GLOBAL_INTARRAY_VALUE(ModuleName, name, row, col, value)    \
SetIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col, value)

#define SET_NVRAM_INTARRAY_VALUE(ModuleName, name, row, col, value)    \
SetIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col, value)

#define SET_LOCAL_INTARRAY_VALUE(ModuleName, name, row, col, value)    \
SetIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)##name##, row, col, value)

// macros to call GetIntArrayElement
#define GET_GLOBAL_INTARRAY_VALUE(ModuleName, name, row, col)    \
GetIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_INTARRAY_VALUE(ModuleName, name, row, col)    \
GetIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_INTARRAY_VALUE(ModuleName, name, row, col)    \
GetIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)##name##, row, col)

// macros to call GetIntArrayElementPtr
#define GET_GLOBAL_INTARRAY_PTR(ModuleName, name, row, col)    \
GetIntArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_INTARRAY_PTR(ModuleName, name, row, col)    \
GetIntArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_INTARRAY_PTR(ModuleName, name, row, col)    \
GetIntArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct IntArrayHdr_s *)##name##, row, col)

// macro to create the module's global variable structure
#define START_GLOBAL_VAR_STRUCT(ModuleName) \
    struct ModuleName##_Globals_s

// this macro will be used in the Globals_s union
#define GLOBAL_VAR_STRUCT(ModuleName)   \
    struct ModuleName##_Globals_s ModuleName

// macro to create the module's non-volatile variable structure
#define START_NVRAM_VAR_STRUCT(ModuleName) \
    struct ModuleName##_Nvram_s

// this macro will be used in the NonVolatiles_s union
#define NVRAM_VAR_STRUCT(ModuleName)   \
    struct ModuleName##_Nvram_s ModuleName

// this macro will define/declare the Main function.
// If macro is followed by ;, it is a declaration.
#define FUNCTION_MAIN(ModuleName)                 \
int ModuleName##_main(void *MemPtr, void *NvramPtr, void *InstancePtr)

// this macro will define the EventHandler function
// If macro is followed by ;, it is a declaration.
#define EVENT_HANDLER(ModuleName)                 \
void ModuleName##_EventHandler(struct Signal_s *Signal, void *MemPtr, void *NvramPtr)

// this macro will declare the local variables to save the contents of A5 and A4
//  upon entry so that the can be restore upon exit
#define SAVE_GLOBAL_POINTERS                    \
    union Globals_u *SavedGlobals;              \
    union Nvram_u *SavedNvram;    \
                                                \
    SavedGlobals = Globals;                     \
    Globals = (union Globals_u *)MemPtr;        \
    SavedNvram = Nvram;           \
    Nvram = (union Nvram_u *)NvramPtr  \

// this macro will restore the global pointers upon exit
#define RESTORE_GLOBAL_POINTERS                 \
    Globals = SavedGlobals;                     \
    Nvram = SavedNvram            \

// this macro will set up the module's Instance pointer & clear last modified array index
#define SET_INSTANCE_POINTER(ModuleName)        \
    Globals->##ModuleName##.InstancePtr = InstancePtr;  \
    Globals->##ModuleName##.LastModifiedArrayIndex = 0

// this macro will define the EntryPoint_s structure for the module
#define DEFINE_ENTRYPOINT(ModuleName)                                               \
struct EntryPoint_s ModuleName##_Entry __attribute__ ((section("EntryList"))) =     \
{                                                                                   \
    ModuleName##_main,                                                              \
    ModuleName##_EventHandler,                                                      \
    #ModuleName ,                                                               \
    sizeof(struct ModuleName##_Globals_s),                                          \
    sizeof(struct ModuleName##_Nvram_s)                                      \
}

// macro to reference the global data structure
#define GLOBAL(ModuleName, name) \
    (Globals->##ModuleName##.##name)

// macro to reference the global data structure
#define NVRAM(ModuleName, name) \
    (Nvram->##ModuleName##.##name)

// macro to reference the generic string output storage area
#define GENERIC_STRING_OUTPUT(ModuleName) \
    ((struct StringHdr_s*)&(Globals->##ModuleName##.sGenericOutStr))

// macro to set the value of a string output array element
#define SET_STRING_OUT_ARRAY_ELEMENT(ModuleName, ArrayName, Index) \
    if ( CheckStringOutputArrayIndex((Globals->##ModuleName##.InstancePtr),&Globals->##ModuleName##.##ArrayName, Index)  ) \
        SetSerial((Globals->##ModuleName##.InstancePtr), \
                  Globals->##ModuleName##.##ArrayName##.StartInputNumber + Index - 1, \
                  &(Globals->##ModuleName##.sGenericOutStr))


// macro to define an individual event handler based on counter string
#define DEFINE_SINGLE_EVENTHANDLER(ModuleName, CounterString)   \
    void ModuleName##EventHandler##CounterString(struct Signal_s *Signal)

// macro to call an individual event handler based on counter string
#define CALL_SINGLE_EVENTHANDLER(ModuleName, CounterString)   \
    ModuleName##EventHandler##CounterString(Signal)

// macro to define an independent event handler based on counter string
#define DEFINE_INDEPENDENT_EVENTHANDLER(ModuleName, CounterString)   \
    void ModuleName##EventHandler##CounterString(struct Signal_s *Signal, void *MemPtr, void *NvramPtr)

// macro to spawn an individual event handler as a separate task based on counter string
// *** This is here to support older SIMPL+ without the ThreadSafe parameter ***
#define SPAWN_EVENTHANDLER(ModuleName, CounterString)     \
    SpawnHandler(Globals->##ModuleName##.InstancePtr,          \
        &(##ModuleName##EventHandler##CounterString), Signal, 0)

// macro to spawn an individual event handler as a separate task based on counter string
// *** This version uses the new TreadSafe feature of the SpawnHandler ***
#define SAFESPAWN_EVENTHANDLER(ModuleName, CounterString, ThreadSafe)     \
    SpawnHandler(Globals->##ModuleName##.InstancePtr,          \
        &(##ModuleName##EventHandler##CounterString), Signal, ThreadSafe)

// macro to define a wait event routine based on name
#define DEFINE_WAITEVENT(ModuleName, name)   \
    int ModuleName##name##(void *MemPtr, void *NvramPtr)

// macro to create a wait event
#define CREATE_WAIT(ModuleName, delay, name)   \
    CreateWait(Globals->##ModuleName##.InstancePtr, #name, delay, &(ModuleName##name##))

#define PAUSE_WAIT(ModuleName, name)   \
    PauseWait(Globals->##ModuleName##.InstancePtr, #name)
#define RESUME_WAIT(ModuleName, name)   \
    ResumeWait(Globals->##ModuleName##.InstancePtr, #name)
#define RETIME_WAIT(ModuleName, delay, name)   \
    RetimeWait(Globals->##ModuleName##.InstancePtr, #name, delay)
#define WAIT_STATUS(ModuleName, name)   \
    GetWaitStatus(Globals->##ModuleName##.InstancePtr, #name)
#define WAIT_TIME_LEFT(ModuleName, name)   \
    GetWaitTimeLeft(Globals->##ModuleName##.InstancePtr, #name)

// macro to reference the global instance pointer
#define INSTANCE_PTR(ModuleName)  (Globals->##ModuleName##.InstancePtr)

// macro to convert the preprocessor variable name to a quoted string.
#define NAME_AS_STRING(name) (#name)

// Macros for user functions
#define FUNCTION(Name)    static void Name
#define INTEGER_FUNCTION(Name)    static int Name
#define STRING_FUNCTION(Name)    static struct StringHdr_s* Name

#ifndef SIMPL_PLUS_FILE_INFO
#define SIMPL_PLUS_FILE_INFO

#define MAX_SIMPL_PLUS_PATH_NAME    256

struct FileInfo_s
{
    unsigned short IATTRIBUTES;
    unsigned short ITIME;
    unsigned short IDATE;
    unsigned short padding;             // needed to longword align rest of the structure
    unsigned long  LSIZE;
    struct FileName_String_s
    {
        enum EInputType InputType;
        int MaxLen;
        int CurLen;
        char *Name;                             // to be used in error reporting
        unsigned char String[MAX_SIMPL_PLUS_PATH_NAME+2];
    } NAME;
};

#ifndef ARDONLY

#define ARDONLY     0x01        /* Read only file attributes */
#define AHIDDEN     0x02        /* Hidden file attributes */
#define ASYSTEM     0x04        /* System file attributes */
#define AVOLUME     0x08        /* Volume Label file attributes */
#define ADIRENT     0x10        /* Dirrectory file attributes */
#define ARCHIVE     0x20        /* Archives file attributes */
#endif  // ARDONLY

#endif  // SIMPL_PLUS_FILE_INFO

// STRUCTURE arrays

#define CREATE_STRUCTURE_ARRAY(ModuleName, ArrayName, StructName, Size) \
struct ModuleName##ArrayName##_s                                            \
{                                                               \
    int     NumElements;                                        \
    int     ElementSize;                                        \
    char    *Name;                                              \
    struct  ModuleName##StructName Structs[Size + 1];                        \
}

#define CREATE_STRUCTURE_DYNAMIC_ARRAY(ModuleName, ArrayName, StructName, Size) \
struct ModuleName##ArrayName##_s                                \
{                                                               \
    int     NumElements;                                        \
    int     ElementSize;                                        \
    char    *Name;                                              \
    int     (*Constructor)(struct StructStructHdr_s *me);       \
    int     (*Destructor) (struct StructStructHdr_s *me, int verbose);       \
    struct  ModuleName##StructName *Structs;                    \
}

#define DECLARE_DYNAMIC_STRUCT(ModuleName, StructType, VariableName)             \
    struct ModuleName##StructType VariableName

#define DECLARE_STRUCT_DYNAMIC_ARRAY(ModuleName, ArrayName)             \
    struct ModuleName##ArrayName##_s ArrayName

#define DECLARE_LOCAL_STRUCT_DYNAMIC_ARRAY(ModuleName, ArrayName)       \
    struct ModuleName##ArrayName##_s* ArrayName

#define DECLARE_LOCAL_DYNAMIC_STRUCT(ModuleName, StructName, VariableName)       \
    struct ModuleName##StructName* VariableName



#define CREATE_FILEINFO_ARRAY(ModuleName, ArrayName, Size) \
struct ModuleName##ArrayName##_s                                            \
{                                                               \
    int     NumElements;                                        \
    int     ElementSize;                                        \
    struct  FileInfo_s Structs[Size + 1];                        \
}
#define START_STRUCTURE_DEFINITION(ModuleName, StructName)  \
struct ModuleName##StructName

#ifndef STRUCT_ARRAY_HEADER
#define STRUCT_ARRAY_HEADER
struct StructArrayHdr_s
{
    int     NumElements;
    int     ElementSize;
    char    *Name;                             // to be used in error reporting
    char    Structs[0];                 // use char array instead of pointer
};

struct StructDynamicArrayHdr_s
{
    int     NumElements;
    int     ElementSize;
    char    *Name;                             // to be used in error reporting
    int     (*Constructor)(struct StructStructHdr_s *me);
    int     (*Destructor) (struct StructStructHdr_s *me, int verbose);
    char    *Structs;
};

struct StructStructHdr_s
{
   char    *Data;
};

#define GLOBAL_DYNAMIC_STRUCT_ARRAY_STRUCT(ModuleName, name)    \
    ((struct StructDynamicArrayHdr_s*)&(Globals->##ModuleName##.##name##))
#define LOCAL_DYNAMIC_STRUCT_ARRAY_STRUCT(name)    \
    ((struct StructDynamicArrayHdr_s*)##name##)
#define NVRAM_DYNAMIC_STRUCT_ARRAY_STRUCT(ModuleName, name)    \
    ((struct StructDynamicArrayHdr_s*)&(Nvram->##ModuleName##.##name##))

#endif

#define DECLARE_STRUCT(ModuleName, StructType, VariableName)             \
    struct ModuleName##StructType VariableName

#define DECLARE_STRUCT_ARRAY(ModuleName, ArrayName)             \
    struct ModuleName##ArrayName##_s ArrayName

#define DECLARE_LOCAL_STRUCT_ARRAY(ModuleName, ArrayName)       \
    struct ModuleName##ArrayName##_s* ArrayName

#define DECLARE_LOCAL_STRUCT(ModuleName, StructName, VariableName)       \
    struct ModuleName##StructName* VariableName

#define DECLARE_LOCAL_FILEINFO(StructName, VariableName)     \
    struct StructName* VariableName

// macro to call the structure array initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the structure array (variable name)
//      length - declared length
#define INITIALIZE_GLOBAL_STRUCT_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructArray((struct StructArrayHdr_s *)&Globals->##ModuleName##.##ArrayName##, Length, sizeof(struct ModuleName##StructName), #ArrayName)

#define INITIALIZE_GLOBAL_STRUCT_DYNAMIC_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructDynamicArray( INSTANCE_PTR( ModuleName ), (struct StructDynamicArrayHdr_s *)&Globals->##ModuleName##.##ArrayName##, Length, sizeof(struct ModuleName##StructName), #ArrayName)

#define INITIALIZE_NVRAM_STRUCT_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructArray((struct StructArrayHdr_s *)&Nvram->##ModuleName##.##ArrayName##, Length, sizeof(struct ModuleName##StructName), #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructArray((struct StructArrayHdr_s *)##ArrayName##, Length, sizeof(struct ModuleName##StructName), #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_DYNAMIC_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructDynamicArray( INSTANCE_PTR( ModuleName ), (struct StructDynamicArrayHdr_s *)##ArrayName##, Length, sizeof(struct ModuleName##StructName), #ArrayName)

#define INITIALIZE_GLOBAL_FILEINFO_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructArray((struct StructArrayHdr_s *)&Globals->##ModuleName##.##ArrayName##, Length, sizeof(struct FileInfo_s), #ArrayName)

#define INITIALIZE_NVRAM_FILEINFO_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructArray((struct StructArrayHdr_s *)&Nvram->##ModuleName##.##ArrayName##, Length, sizeof(struct FileInfo_s), #ArrayName)

#define INITIALIZE_LOCAL_FILEINFO_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitStructArray((struct StructArrayHdr_s *)##ArrayName##, Length, sizeof(struct FileInfo_s), #ArrayName)

#define ALLOCATE_LOCAL_STRUCT_ARRAY(ModuleName, ArrayName)  \
ArrayName = (struct ModuleName##ArrayName##_s *)Allocate(sizeof(struct ModuleName##ArrayName##_s));   \
if ( ArrayName == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define ALLOCATE_LOCAL_STRUCT_DYNAMIC_ARRAY(ModuleName, ArrayName)  \
ArrayName = (struct ModuleName##ArrayName##_s *)Allocate(sizeof(struct ModuleName##ArrayName##_s));   \
if ( ArrayName == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}


#define ALLOCATE_LOCAL_STRUCT(ModuleName, StructName, VariableName)  \
VariableName = (struct ModuleName##StructName *)Allocate(sizeof(struct ModuleName##StructName));   \
if ( VariableName == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define ALLOCATE_LOCAL_FILEINFO(ModuleName, StructName, VariableName)  \
VariableName = (struct StructName *)Allocate(sizeof(struct StructName));   \
if ( VariableName == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_STRUCT_ARRAY(ArrayName)    \
Deallocate(ArrayName)

#define FREE_LOCAL_STRUCT_DYNAMIC_ARRAY(ModuleName, name)    \
{                                                             \
  ResizeStructArray( INSTANCE_PTR(ModuleName), name, -1, 0);   \
  Deallocate(name);                                           \
}



#define FREE_LOCAL_STRUCT(VariableName)    \
Deallocate(VariableName)

#define GET_GLOBAL_STRUCT_ARRAY_NUMCOLS(ModuleName, name) \
(Globals->##ModuleName##.##name##.NumElements & ~DYN_STRUCT_ARRAY_FLAG)

#define GET_NVRAM_STRUCT_ARRAY_NUMCOLS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumElements

#define GET_LOCAL_STRUCT_ARRAY_NUMCOLS(name)    \
(name##->NumElements & ~DYN_STRUCT_ARRAY_FLAG)

#define GET_GLOBAL_STRUCTARRAY_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct ModuleName##StructName *)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Globals->##ModuleName##.##ArrayName##), Element))

#define GET_NVRAM_STRUCTARRAY_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct ModuleName##StructName *)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Nvram->##ModuleName##.##ArrayName##), Element))

#define GET_LOCAL_STRUCTARRAY_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct ModuleName##StructName *)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)##ArrayName##, Element))

#define CHECK_GLOBAL_STRUCTARRAY_ELEMENT(ModuleName, ArrayName, Element)    \
CheckStructArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Globals->##ModuleName##.##ArrayName##), Element)

#define CHECK_NVRAM_STRUCTARRAY_ELEMENT(ModuleName, ArrayName, Element)    \
CheckStructArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Nvram->##ModuleName##.##ArrayName##), Element)

#define CHECK_LOCAL_STRUCTARRAY_ELEMENT(ModuleName, ArrayName, Element)    \
CheckStructArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)##ArrayName##, Element)

#define GET_GLOBAL_FILEINFO_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct StructName *)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Globals->##ModuleName##.##ArrayName##), Element))

#define GET_NVRAM_FILEINFO_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct StructName *)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Nvram->##ModuleName##.##ArrayName##), Element))

#define GET_LOCAL_FILEINFO_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct StructName*)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)##ArrayName##, Element))

#define GLOBAL_STRUCT_FIELD(ModuleName, VariableName, FieldName)    \
(Globals->##ModuleName##.##VariableName##.##FieldName)

#define NVRAM_STRUCT_FIELD(ModuleName, VariableName, FieldName)    \
(Nvram->##ModuleName##.##VariableName##.##FieldName)

#define GLOBAL_STRUCT_FIELD_ADDR(ModuleName, VariableName, FieldName)    \
((struct IntDynamicArrayHdr_s*)&(Globals->##ModuleName##.##VariableName##.##FieldName))

#define NVRAM_STRUCT_FIELD_ADDR(ModuleName, VariableName, FieldName)    \
((struct IntDynamicArrayHdr_s*)&(Nvram->##ModuleName##.##VariableName##.##FieldName))

#define LOCAL_STRUCT_FIELD_ADDR(VariableName, FieldName)    \
((struct IntDynamicArrayHdr_s*)&(VariableName##->##FieldName))

// Specific Initialization for the RampInfo_s Structure.
#define INITIALIZE_GLOBAL_RAMPINFO(ModuleName, VariableName) \
InitializeRampInfoInternal(&(Globals->##ModuleName##.##VariableName))

#define INITIALIZE_LOCAL_RAMPINFO(VariableName) \
InitializeRampInfoInternal(VariableName)

#define INITIALIZE_NVRAM_RAMPINFO(ModuleName, VariableName) \
InitializeRampInfoInternal(&(Nvram->##ModuleName##.##VariableName))

#define LOCAL_STRUCT_FIELD(VariableName, FieldName)    \
(VariableName##->##FieldName)

// support for long integer arrays
struct LongArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    unsigned long Data[2];
};

struct LongDynamicArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    unsigned long *Data;
};


#define CREATE_LONGARRAY1D(ModuleName, name, cols)     \
struct ModuleName##name##LongArray_s                   \
{                                          \
    int NumCols;                           \
    int NumRows;                           \
    char *Name;                            \
    unsigned long Data[cols+1];            \
}


#define CREATE_DYNAMIC_LONGARRAY1D(ModuleName, name, cols)     \
struct ModuleName##name##DynamicLongArray_s                   \
{                                          \
    int NumCols;                           \
    int NumRows;                           \
    char *Name;                            \
    unsigned long *Data;                   \
}


#define CREATE_LONGARRAY2D(ModuleName, name, rows, cols)    \
struct ModuleName##name##LongArray_s                        \
{                                               \
    int NumCols;                                \
    int NumRows;                                \
    char *Name;                                 \
    unsigned long Data[(rows+1)*(cols+1)];      \
}

#define CREATE_DYNAMIC_LONGARRAY2D(ModuleName, name, rows, cols)    \
struct ModuleName##name##DynamicLongArray_s                        \
{                                               \
    int NumCols;                                \
    int NumRows;                                \
    char *Name;                                 \
    unsigned long *Data;                        \
}

#define DECLARE_LONGARRAY(ModuleName, name)             \
    struct ModuleName##name##LongArray_s name

#define DECLARE_DYNAMIC_LONGARRAY(ModuleName, name)             \
    struct ModuleName##name##DynamicLongArray_s name

#define DECLARE_LOCAL_LONGARRAY(ModuleName, name)       \
    struct ModuleName##name##LongArray_s* name

#define DECLARE_LOCAL_DYNAMIC_LONGARRAY(ModuleName, name)       \
    struct ModuleName##name##DynamicLongArray_s* name

#define GLOBAL_DYNAMIC_LONGARRAY(ModuleName, name)    \
  ((struct LongDynamicArrayHdr_s*)&(Globals->##ModuleName##.##name##))

#define LOCAL_DYNAMIC_LONGARRAY(name)    \
    ((struct LongDynamicArrayHdr_s*)##name##)


// macros to call the int array initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      rows - number of rows in the array
//      cols - number of columns in the array
#define INITIALIZE_GLOBAL_LONGARRAY(ModuleName, name, rows, cols)    \
InitLongArray((struct LongArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_GLOBAL_DYNAMIC_LONGARRAY(ModuleName, name, rows, cols)    \
InitLongDynamicArray( INSTANCE_PTR(ModuleName), (struct LongDynamicArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_NVRAM_LONGARRAY(ModuleName, name, rows, cols)    \
InitLongArray((struct LongArrayHdr_s *)&Nvram->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_LONGARRAY(name, rows, cols)    \
InitLongArray((struct LongArrayHdr_s *)##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_DYNAMIC_LONGARRAY(ModuleName, name, rows, cols)    \
InitLongDynamicArray( INSTANCE_PTR(ModuleName), (struct LongArrayHdr_s *)##name##, rows, cols, #name)

#define ALLOCATE_LOCAL_LONGARRAY(ModuleName, name)  \
name = (struct ModuleName##name##LongArray_s *)Allocate(sizeof(struct ModuleName##name##LongArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define ALLOCATE_LOCAL_DYNAMIC_LONGARRAY(ModuleName, name)  \
name = (struct ModuleName##name##DynamicLongArray_s *)Allocate(sizeof(struct ModuleName##name##DynamicLongArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_LONGARRAY(name)    \
Deallocate(name)

#define FREE_LOCAL_DYNAMIC_LONGARRAY(ModuleName, name)    \
{                                                             \
  ResizeIntegerArray( INSTANCE_PTR(ModuleName), name, 0, -1, e_INTARR_TYPE_LONG, 0);        \
  Deallocate(name);                                           \
}




// macros to define GetNumArrayCols
// Remove the topmost bit to allow correct numbers for dynamic arrays.
// NVRAM arrays cannot be dynamic
#define GET_GLOBAL_LONGARRAY_NUMCOLS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumCols & ~DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_LONGARRAY_NUMCOLS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumCols

#define GET_GLOBAL_LONGARRAY_NUMROWS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumRows & ~DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_LONGARRAY_NUMROWS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumRows

#define GET_LOCAL_LONGARRAY_NUMCOLS(name)    \
(name##->NumCols & ~DYN_INT_ARRAY_FLAG)

#define GET_LOCAL_LONGARRAY_NUMROWS(name)    \
(name##->NumRows & ~DYN_INT_ARRAY_FLAG)

// macros to call SetLongArrayElement
#define SET_GLOBAL_LONGARRAY_VALUE(ModuleName, name, row, col, value)    \
SetLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col, value)

#define SET_NVRAM_LONGARRAY_VALUE(ModuleName, name, row, col, value)    \
SetLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col, value)

#define SET_LOCAL_LONGARRAY_VALUE(ModuleName, name, row, col, value)    \
SetLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)##name##, row, col, value)

// macros to call GetLongArrayElement
#define GET_GLOBAL_LONGARRAY_VALUE(ModuleName, name, row, col)    \
GetLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_LONGARRAY_VALUE(ModuleName, name, row, col)    \
GetLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_LONGARRAY_VALUE(ModuleName, name, row, col)    \
GetLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)##name##, row, col)

// macros to call GetLongArrayElementPtr
#define GET_GLOBAL_LONGARRAY_PTR(ModuleName, name, row, col)    \
GetLongArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_LONGARRAY_PTR(ModuleName, name, row, col)    \
GetLongArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_LONGARRAY_PTR(ModuleName, name, row, col)    \
GetLongArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct LongArrayHdr_s *)##name##, row, col)

#define INITIALIZE_GLOBAL_STRUCT_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitLongArray((struct LongArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_GLOBAL_STRUCT_DYNAMIC_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitLongDynamicArray(INSTANCE_PTR( ModuleName ), (struct LongDynamicArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_NVRAM_STRUCT_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitLongArray((struct LongArrayHdr_s *)&Nvram->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_LONGARRAY(StructName, ArrayName, rows, cols)    \
InitLongArray((struct LongArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_DYNAMIC_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitLongDynamicArray( INSTANCE_PTR( ModuleName ), (struct DynamicLongArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

// support for signed integer arrays
struct SignedIntArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    short Data[2];
};

struct SignedIntDynamicArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    short * Data;
};



#define CREATE_SIGNED_INTARRAY1D(ModuleName, name, cols)      \
struct ModuleName##name##SignedIntArray_s   \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    short Data[cols+1];                     \
}

#define CREATE_SIGNED_DYNAMIC_INTARRAY1D(ModuleName, name, cols)      \
struct ModuleName##name##DynamicSignedIntArray_s   \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    short *Data;                            \
}


#define CREATE_SIGNED_INTARRAY2D(ModuleName, name, rows, cols)      \
struct ModuleName##name##SignedIntArray_s   \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    short Data[(rows+1)*(cols+1)];          \
}

#define CREATE_SIGNED_DYNAMIC_INTARRAY2D(ModuleName, name, rows, cols)      \
struct ModuleName##name##DynamicSignedIntArray_s   \
{                                           \
    int NumCols;                            \
    int NumRows;                            \
    char *Name;                             \
    short *Data;                            \
}

#define DECLARE_SIGNED_INTARRAY(ModuleName, name)             \
    struct ModuleName##name##SignedIntArray_s name

#define DECLARE_SIGNED_DYNAMIC_INTARRAY(ModuleName, name)             \
    struct ModuleName##name##DynamicSignedIntArray_s name

#define DECLARE_LOCAL_SIGNED_INTARRAY(ModuleName, name)       \
    struct ModuleName##name##SignedIntArray_s* name

#define DECLARE_LOCAL_SIGNED_DYNAMIC_INTARRAY(ModuleName, name)             \
    struct ModuleName##name##DynamicSignedIntArray_s *name

#define GLOBAL_SIGNED_DYNAMIC_INTARRAY(ModuleName, name)    \
    ((struct SignedIntDynamicArrayHdr_s*)&(Globals->##ModuleName##.##name##))

#define LOCAL_SIGNED_DYNAMIC_INTARRAY(name)    \
    ((struct SignedIntDynamicArrayHdr_s*)##name##)










// macros to call the int array initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      rows - number of rows in the array
//      cols - number of columns in the array
#define INITIALIZE_GLOBAL_SIGNED_INTARRAY(ModuleName, name, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_GLOBAL_SIGNED_DYNAMIC_INTARRAY(ModuleName, name, rows, cols)    \
InitSignedIntDynamicArray( INSTANCE_PTR(ModuleName), (struct IntArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_NVRAM_SIGNED_INTARRAY(ModuleName, name, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)&Nvram->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_SIGNED_INTARRAY(name, rows, cols)    \
InitIntArray((struct IntArrayHdr_s *)##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_SIGNED_DYNAMIC_INTARRAY(ModuleName, name, rows, cols)    \
InitSignedIntDynamicArray( INSTANCE_PTR(ModuleName), (struct SignedIntDynamicArrayHdr_s*)##name##, rows, cols, #name)

#define ALLOCATE_LOCAL_SIGNED_INTARRAY(ModuleName, name)  \
name = (struct ModuleName##name##SignedIntArray_s *)Allocate(sizeof(struct ModuleName##name##SignedIntArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define ALLOCATE_LOCAL_SIGNED_DYNAMIC_INTARRAY(ModuleName, name)  \
name = (struct ModuleName##name##DynamicSignedIntArray_s *)Allocate(sizeof(struct ModuleName##name##DynamicSignedIntArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}


#define FREE_LOCAL_SIGNED_INTARRAY(name)    \
Deallocate(name)

#define FREE_LOCAL_SIGNED_DYNAMIC_INTARRAY(ModuleName, name)    \
{                                                             \
  ResizeIntegerArray( INSTANCE_PTR(ModuleName), name, 0, -1, e_INTARR_TYPE_SIGNEDINT, 0);        \
  Deallocate(name);                                           \
}





// macros to define GetNumArrayCols
// Remove the topmost bit to allow correct numbers for dynamic arrays.
// NVRAM arrays cannot be dynamic
#define GET_GLOBAL_SIGNED_INTARRAY_NUMCOLS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumCols & ~DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_SIGNED_INTARRAY_NUMCOLS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumCols

#define GET_GLOBAL_SIGNED_INTARRAY_NUMROWS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumRows & ~DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_SIGNED_INTARRAY_NUMROWS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumRows

#define GET_LOCAL_SIGNED_INTARRAY_NUMCOLS(name)    \
(name##->NumCols & ~DYN_INT_ARRAY_FLAG)

#define GET_LOCAL_SIGNED_INTARRAY_NUMROWS(name)    \
(name##->NumRows & ~DYN_INT_ARRAY_FLAG)

// macros to call SetLongArrayElement
#define SET_GLOBAL_SIGNED_INTARRAY_VALUE(ModuleName, name, row, col, value)    \
SetSignedIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedIntgArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col, value)

#define SET_NVRAM_SIGNED_INTARRAY_VALUE(ModuleName, name, row, col, value)    \
SetSignedIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col, value)

#define SET_LOCAL_SIGNED_INTARRAY_VALUE(ModuleName, name, row, col, value)    \
SetSignedIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)##name##, row, col, value)

// macros to call GetSignedIntArrayElement
#define GET_GLOBAL_SIGNED_INTARRAY_VALUE(ModuleName, name, row, col)    \
GetSignedIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_SIGNED_INTARRAY_VALUE(ModuleName, name, row, col)    \
GetSignedIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_SIGNED_INTARRAY_VALUE(ModuleName, name, row, col)    \
GetSignedIntArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)##name##, row, col)

// macros to call GetSignedIntArrayElementPtr
#define GET_GLOBAL_SIGNED_INTARRAY_PTR(ModuleName, name, row, col)    \
GetSignedIntArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_SIGNED_INTARRAY_PTR(ModuleName, name, row, col)    \
GetSignedIntArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_SIGNED_INTARRAY_PTR(ModuleName, name, row, col)    \
GetSignedIntArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct SignedIntArrayHdr_s *)##name##, row, col)

// support for signed long integer arrays
struct SignedLongArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    long Data[2];
};

struct SignedLongDynamicArrayHdr_s
{
    int NumCols;                        // Number of Columns
    int NumRows;                        // number of rows (0 for 1-D arrays)
    char *Name;                         // to be used in error reporting
    long *Data;
};

#define CREATE_SIGNED_LONGARRAY1D(ModuleName, name, cols)     \
struct ModuleName##name##SignedLongArray_s                   \
{                                          \
    int NumCols;                           \
    int NumRows;                           \
    char *Name;                            \
    long Data[cols+1];                      \
}

#define CREATE_SIGNED_DYNAMIC_LONGARRAY1D(ModuleName, name, cols)     \
struct ModuleName##name##DynamicSignedLongArray_s                   \
{                                          \
    int NumCols;                           \
    int NumRows;                           \
    char *Name;                            \
    long *Data;                            \
}

#define CREATE_SIGNED_LONGARRAY2D(ModuleName, name, rows, cols)    \
struct ModuleName##name##SignedLongArray_s                        \
{                                               \
    int NumCols;                                \
    int NumRows;                                \
    char *Name;                                 \
    long Data[(rows+1)*(cols+1)];               \
}

#define CREATE_SIGNED_DYNAMIC_LONGARRAY2D(ModuleName, name, rows, cols)    \
struct ModuleName##name##DynamicSignedLongArray_s                        \
{                                               \
    int NumCols;                                \
    int NumRows;                                \
    char *Name;                                 \
    long *Data;                                 \
}

#define DECLARE_SIGNED_LONGARRAY(ModuleName, name)             \
    struct ModuleName##name##SignedLongArray_s name

#define DECLARE_SIGNED_DYNAMIC_LONGARRAY(ModuleName, name)             \
    struct ModuleName##name##DynamicSignedLongArray_s name

#define DECLARE_LOCAL_SIGNED_LONGARRAY(ModuleName, name)       \
    struct ModuleName##name##SignedLongArray_s* name

#define DECLARE_LOCAL_SIGNED_DYNAMIC_LONGARRAY(ModuleName, name)       \
    struct ModuleName##name##DynamicSignedLongArray_s* name

#define GLOBAL_SIGNED_DYNAMIC_LONGARRAY(ModuleName, name)    \
  ((struct SignedLongDynamicArrayHdr_s*)&(Globals->##ModuleName##.##name##))

#define LOCAL_SIGNED_DYNAMIC_LONGARRAY(name)    \
    ((struct SignedLongDynamicArrayHdr_s*)##name##)



// macros to call the int array initialization function
//      ModuleName - name of the Simpl+ module.
//      name - name of the variable
//      rows - number of rows in the array
//      cols - number of columns in the array
#define INITIALIZE_GLOBAL_SIGNED_LONGARRAY(ModuleName, name, rows, cols)    \
InitLongArray((struct SignedLongArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_GLOBAL_SIGNED_DYNAMIC_LONGARRAY(ModuleName, name, rows, cols)    \
InitSignedLongDynamicArray( INSTANCE_PTR(ModuleName), (struct SignedLongDynamicArrayHdr_s *)&Globals->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_NVRAM_SIGNED_LONGARRAY(ModuleName, name, rows, cols)    \
InitLongArray((struct SignedLongArrayHdr_s *)&Nvram->##ModuleName##.##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_SIGNED_LONGARRAY(name, rows, cols)    \
InitLongArray((struct SignedLongArrayHdr_s *)##name##, rows, cols, #name)

#define INITIALIZE_LOCAL_SIGNED_DYNAMIC_LONGARRAY(ModuleName, name, rows, cols)    \
InitSignedLongDynamicArray( INSTANCE_PTR(ModuleName), (struct SignedLongDynamicArrayHdr_s *)##name##, rows, cols, #name)

#define ALLOCATE_LOCAL_SIGNED_LONGARRAY(ModuleName, name)  \
name = (struct ModuleName##name##SignedLongArray_s *)Allocate(sizeof(struct ModuleName##name##SignedLongArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define ALLOCATE_LOCAL_SIGNED_DYNAMIC_LONGARRAY(ModuleName, name)  \
name = (struct ModuleName##name##DynamicSignedLongArray_s *)Allocate(sizeof(struct ModuleName##name##DynamicSignedLongArray_s));   \
if ( name == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

#define FREE_LOCAL_SIGNED_LONGARRAY(name)    \
Deallocate(name)

#define FREE_LOCAL_SIGNED_DYNAMIC_LONGARRAY(ModuleName, name)    \
{                                                             \
  ResizeIntegerArray( INSTANCE_PTR(ModuleName), name, 0, -1, e_INTARR_TYPE_SIGNEDLONG, 0);        \
  Deallocate(name);                                           \
}




// macros to define GetNumArrayCols
// Remove the topmost bit to allow correct numbers for dynamic arrays.
// NVRAM arrays cannot be dynamic
#define GET_GLOBAL_SIGNED_LONGARRAY_NUMCOLS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumCols &~ DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_SIGNED_LONGARRAY_NUMCOLS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumCols

#define GET_GLOBAL_SIGNED_LONGARRAY_NUMROWS(ModuleName, name)    \
(Globals->##ModuleName##.##name##.NumRows & ~DYN_INT_ARRAY_FLAG)

#define GET_NVRAM_SIGNED_LONGARRAY_NUMROWS(ModuleName, name)    \
Nvram->##ModuleName##.##name##.NumRows

#define GET_LOCAL_SIGNED_LONGARRAY_NUMCOLS(name)    \
(name##->NumCols & ~DYN_INT_ARRAY_FLAG)

#define GET_LOCAL_SIGNED_LONGARRAY_NUMROWS(name)    \
(name##->NumRows & ~DYN_INT_ARRAY_FLAG)

// macros to call SetLongArrayElement
#define SET_GLOBAL_SIGNED_LONGARRAY_VALUE(ModuleName, name, row, col, value)    \
SetSignedLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col, value)

#define SET_NVRAM_SIGNED_LONGARRAY_VALUE(ModuleName, name, row, col, value)    \
SetSignedLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col, value)

#define SET_LOCAL_SIGNED_LONGARRAY_VALUE(ModuleName, name, row, col, value)    \
SetSignedLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)##name##, row, col, value)

// macros to call GetSignedLongArrayElement
#define GET_GLOBAL_SIGNED_LONGARRAY_VALUE(ModuleName, name, row, col)    \
GetSignedLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_SIGNED_LONGARRAY_VALUE(ModuleName, name, row, col)    \
GetSignedLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_SIGNED_LONGARRAY_VALUE(ModuleName, name, row, col)    \
GetSignedLongArrayElement(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)##name##, row, col)

// macros to call GetSignedLongArrayElementPtr
#define GET_GLOBAL_SIGNED_LONGARRAY_PTR(ModuleName, name, row, col)    \
GetSignedLongArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)&Globals->##ModuleName##.##name##, row, col)

#define GET_NVRAM_SIGNED_LONGARRAY_PTR(ModuleName, name, row, col)    \
GetSignedLongArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)&Nvram->##ModuleName##.##name##, row, col)

#define GET_LOCAL_SIGNED_LONGARRAY_PTR(ModuleName, name, row, col)    \
GetSignedLongArrayElementPtr(Globals->##ModuleName##.InstancePtr, (struct SignedLongArrayHdr_s *)##name##, row, col)

#define INITIALIZE_GLOBAL_STRUCT_SIGNED_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitLongArray((struct Signed_LongArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_GLOBAL_STRUCT_SIGNED_DYNAMIC_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitSignedLongDynamicArray( INSTANCE_PTR(ModuleName), (struct SignedLongDynamicArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_NVRAM_STRUCT_SIGNED_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitLongArray((struct SignedLongArrayHdr_s *)&Nvram->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_SIGNED_LONGARRAY(StructName, ArrayName, rows, cols)    \
InitLongArray((struct SignedLongArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_SIGNED_DYNAMIC_LONGARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitSignedLongDynamicArray( INSTANCE_PTR(ModuleName), (struct SignedLongDynamicArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

#define INITIALIZE_GLOBAL_STRUCT_SIGNED_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitSignedIntArray((struct SignedIntArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_GLOBAL_STRUCT_SIGNED_DYNAMIC_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitSignedIntDynamicArray( INSTANCE_PTR(ModuleName), (struct SignedIntDynamicArrayHdr_s *)&Globals->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_NVRAM_STRUCT_SIGNED_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitSignedIntArray((struct SignedIntArrayHdr_s *)&Nvram->##ModuleName##.##StructName##.##ArrayName##, rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_SIGNED_INTARRAY(StructName, ArrayName, rows, cols)    \
InitSignedIntArray((struct SignedIntArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

#define INITIALIZE_LOCAL_STRUCT_SIGNED_DYNAMIC_INTARRAY(ModuleName, StructName, ArrayName, rows, cols)    \
InitSignedIntDynamicArray( INSTANCE_PTR(ModuleName), (struct SignedIntDynamicArrayHdr_s *)&(##StructName##->##ArrayName##), rows, cols, #ArrayName)

// Used for RCB access from SIMPL+
#ifndef RAMP_INFO_STRUCT
#define RAMP_INFO_STRUCT
// used to define ramp control blocks; same types as what's used for CRampControlBlockData in
// CEventScheduler.h
struct RampInfo_s
{
    int                 rampUpperBound;
    int                 rampLowerBound;
    int                 rampBaseValue;
    int                 rampTargetValue;
    unsigned int        rampBaseTime;
    unsigned int        rampTransitionTime;
    unsigned int        rampIdentifier;
    short unsigned int  rampIsSigned;
    short unsigned int  rampIsAbsolute;
    short unsigned int  rampIsRunnable;
    short unsigned int  rampIsExpired;
};

#define RAMP_ABSOLUTE   1
#define RAMP_RELATIVE   0

#endif

#define CREATE_RAMPINFO_ARRAY(ModuleName, ArrayName, Size) \
struct ModuleName##ArrayName##_s                                            \
{                                                               \
    int     NumElements;                                        \
    int     ElementSize;                                        \
    char    *Name;                                              \
    struct  RampInfo_s Structs[Size + 1];                        \
}

#define DECLARE_LOCAL_RAMPINFO(StructName, VariableName)     \
    struct StructName* VariableName

#define ALLOCATE_LOCAL_RAMPINFO(ModuleName, StructName, VariableName)  \
VariableName = (struct StructName *)Allocate(sizeof(struct StructName));   \
if ( VariableName == NULL )                                 \
{                                                   \
    TerminateTask(Globals->##ModuleName##.InstancePtr, "Could not allocate local storage.  Terminating"); \
}

// Definitions to access (for read or write) each element of an array of RampInfo_s (RAMP_INFO) structures.
#define GET_GLOBAL_RAMPINFO_ARRAY_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct StructName *)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Globals->##ModuleName##.##ArrayName##), Element))

#define GET_NVRAM_RAMPINFO_ARRAY_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct StructName *)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&(Nvram->##ModuleName##.##ArrayName##), Element))

#define GET_LOCAL_RAMPINFO_ARRAY_ELEMENT(ModuleName, ArrayName, StructName, Element)    \
((struct StructName*)GetStructArrayElement(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)##ArrayName##, Element))

// Definitions to Initialize each element of an array of RampInfo_s (RAMP_INFO) structures to it's initial state.
#define INITIALIZE_GLOBAL_RAMPINFO_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitRampInfoStructArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&Globals->##ModuleName##.##ArrayName##, Length, sizeof(struct RampInfo_s), #ArrayName)
#define INITIALIZE_NVRAM_RAMPINFO_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitRampInfoStructArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&Nvram->##ModuleName##.##ArrayName##, Length, sizeof(struct RampInfo_s), #ArrayName)
#define INITIALIZE_LOCAL_RAMPINFO_ARRAY(ModuleName, ArrayName, StructName, Length)    \
InitRampInfoStructArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)##ArrayName##, Length, sizeof(struct RampInfo_s), #ArrayName)

#define REINITIALIZE_GLOBAL_RAMPINFO_ARRAY(ModuleName, ArrayName)    \
InitializeRampInfoArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&Globals->##ModuleName##.##ArrayName##)
#define REINITIALIZE_NVRAM_RAMPINFO_ARRAY(ModuleName, ArrayName)    \
InitializeRampInfoArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)&Nvram->##ModuleName##.##ArrayName##)
#define REINITIALIZE_LOCAL_RAMPINFO_ARRAY(ModuleName, ArrayName)    \
InitializeRampInfoArray(Globals->##ModuleName##.InstancePtr, (struct StructArrayHdr_s *)##ArrayName##)

#define DO_DIVIDE(instance_ptr, n, d) (CheckDenominator(instance_ptr, d)?((n)/(d)):0)
#define DO_MOD(instance_ptr, n, d) (CheckDenominator(instance_ptr, d)?((n)%(d)):0)

// Macros for direct socket access
#ifndef SOCKET_HEADER_STRUCT
#define SOCKET_HEADER_STRUCT
enum ESplusSocketType
{
    e_SOCKET_TYPE_CLIENT,
    e_SOCKET_TYPE_SERVER,
    e_SOCKET_TYPE_UDP
};
/*-----------------1/15/2007 10:31PM----------------
 * Direct Socket Access structure header
 * --------------------------------------------------*/
struct SocketHdr_s
{
    int                 SocketStatus;   // exposed to user
    enum ESplusSocketType    eSocketType;    // hidden
    int                 SocketID;       // hidden
    void*               SocketPtr;      // hidden
    struct StringHdr_s  SocketRxBuf;          // exposed to user
};

#endif

#ifndef CLIENT_SERVER_STATUS_CODES
#define CLIENT_SERVER_STATUS_CODES

enum EClientServerDriverStatus
{
    eCLIENT_SERVER_NOT_CONNECTED,
    eCLIENT_SERVER_WAIT_FOR_CONNECTION,
    eCLIENT_SERVER_CONNECTED,
    eCLIENT_SERVER_CONNECTION_FAILED,
    eCLIENT_SERVER_CONNECTION_BROKEN_REMOTELY,
    eCLIENT_SERVER_CONNECTION_BROKEN_LOCALLY,
    eCLIENT_SERVER_DNS_LOOKUP,
    eCLIENT_SERVER_LOOKUP_FAILED,
    eCLIENT_SERVER_DNS_RESOLVED
};
#endif

#define START_SOCKET_DEFINITION(ModuleName, SocketName)  \
struct ModuleName##Socket##SocketName##_s

#define DECLARE_SOCKET(ModuleName, SocketName)             \
    struct ModuleName##Socket##SocketName##_s SocketName

#define CREATE_SOCKET_STRING(ModuleName, name, length)      \
struct                                                      \
{                                                           \
    enum EInputType InputType;                                          \
    int MaxLen;                                             \
    int CurLen;                                             \
    char *Name;                                             \
    unsigned char String[length+4];                         \
} name

#define SOCKET_PTR(ModuleName, name)    \
    ((struct SocketHdr_s*)&(Globals->##ModuleName##.##name##))

#define INITIALIZE_TCP_CLIENT(ModuleName, SocketName, RxBufSize, ID)    \
InitTcpClient(Globals->##ModuleName##.InstancePtr, \
              (struct ModuleName##Socket##SocketName##_s *)&Globals->##ModuleName##.##SocketName##, \
              RxBufSize, ID, #SocketName)

#define INITIALIZE_TCP_SERVER(ModuleName, SocketName, RxBufSize, ID)    \
InitTcpServer(Globals->##ModuleName##.InstancePtr, \
              (struct ModuleName##Socket##SocketName##_s *)&Globals->##ModuleName##.##SocketName##, \
              RxBufSize, ID, #SocketName)

#define INITIALIZE_UDP_SOCKET(ModuleName, SocketName, RxBufSize, ID)    \
InitUdpSocket(Globals->##ModuleName##.InstancePtr, \
              (struct ModuleName##Socket##SocketName##_s *)&Globals->##ModuleName##.##SocketName##, \
              RxBufSize, ID, #SocketName)

// This macro accesses the signal variable to get the current socket status.
#define SocketGetStatus()    Signal->Value

#define SPLUS_SOCKET_BUFFER_THRESHOLD(x)    ((x) * 8 / 10)  // 80%

#endif  // _TYPEDEFS_H
