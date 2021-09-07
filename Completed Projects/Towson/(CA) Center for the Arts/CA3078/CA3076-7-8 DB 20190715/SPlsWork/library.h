#ifndef _LIBRARY_H
#define _LIBRARY_H

#include "typedefs.h"
#include "SimplSig.h"

void InitInOutArray(struct InOutArray_s *Array, int SignalType,
                    int StartInputNumber, int Length, char *Name);
void CheckInputArray(struct InOutArray_s *Array, struct Signal_s *Signal, unsigned short *GlobalLastModified);
void CheckStringInputArray(struct StringArrayHdr_s *Array, struct Signal_s *Signal, unsigned short *GlobalLastModified);
void SetOutputArray(void *InstancePtr, struct InOutArray_s *Array, int Value);
void SetStringOutputArray(void *InstancePtr, struct InOutArray_s *Array,
                                struct StringHdr_s *String);
void SetStringArray(void *InstancePtr,
                            struct StringArrayHdr_s *Array,
                            struct StringHdr_s *String);

void InitStringStruct(struct StringHdr_s *String, int InputType, int Length,
                      char *Name);
void InitDynamicStringStruct(void *InstancePtr, struct StringHdr_s *String, int InputType,
                             int Length, char *Name);
void InitNvramStringStruct(struct StringHdr_s *String, int InputType, int Length,
                      char *Name);
void InitStringArray(struct StringArrayHdr_s *Array, int InputType, int NumElem,
                        int NumChar, char *Name, int Start);
// Flag to indicate that the string array is a dynamic one
#define DYN_STR_ARRAY_FLAG        (0x80000000)
#define DYN_INT_ARRAY_FLAG        (0x80000000)
#define DYN_STRUCT_ARRAY_FLAG     (0x80000000)
#define IsStringDynamic(type) ((type == e_INPUT_TYPE_STRING_DYNAMIC) || (type == e_INPUT_TYPE_STRING_DYNAMIC_AUTOGROW))
void InitDynamicStringArray(void *InstancePtr, struct StringDynamicArrayHdr_s *Array, int InputType,
                            int NumElem, int NumChar, char *Name, int Start);
void InitStringParamArray(void *InstancePtr, struct StringArrayHdr_s *Array, int InputType, int NumElem,
                        int NumChar, char *Name, int Start);
void InitNvramStringArray(struct StringArrayHdr_s *Array, int InputType, int NumElem,
                        int NumChar, char *Name, int Start);
void InitStructArray(struct StructArrayHdr_s *Array, int NumElem, int ElemSize, char *Name);
void InitStructDynamicArray(void *InstancePtr, struct StructDynamicArrayHdr_s *Array, int NumElem, int ElemSize, char *Name);
struct StringHdr_s *GetStringArrayElement(void *InstancePtr, struct StringArrayHdr_s *Array, int Elem);
void *GetStructArrayElement(void *InstancePtr, struct StructArrayHdr_s *Array, int Elem);
int CheckStructArray(void *InstancePtr, struct StructArrayHdr_s *Array, int ElemNum);
int CheckStringOutputArrayIndex(void *InstancePtr, struct InOutArray_s *Array, int Index);
unsigned short Bit(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber,
                    unsigned short BitNumber);
unsigned short Byte(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber);
unsigned short SetByte(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber, unsigned short Value);
unsigned short UNS_SetByte(void *InstancePtr, struct StringHdr_s *String, unsigned short ByteNumber, unsigned short Value);
unsigned short High(unsigned short Value);
unsigned short Low(unsigned short Value);
unsigned short HighWord(unsigned long Value);
unsigned short LowWord(unsigned long Value);
unsigned short Atoi(struct StringHdr_s *String);
short Atosi(struct StringHdr_s *String);
unsigned long Atol(struct StringHdr_s *String);
long Atosl(struct StringHdr_s *String);
struct StringHdr_s* Chr(struct StringHdr_s *OutString, int Code);
struct StringHdr_s* Itoa(void *InstancePtr, struct StringHdr_s *OutString, int Code);
struct StringHdr_s* Itohex(void *InstancePtr, struct StringHdr_s *OutString, int Code);
struct StringHdr_s* Ltoa(void *InstancePtr, struct StringHdr_s *OutString, long Code);
struct StringHdr_s* Ltohex(void *InstancePtr, struct StringHdr_s *OutString, long Code);
unsigned short Abs(short Value);
unsigned short Max(unsigned short Value1, unsigned short Value2);
unsigned short Min(unsigned short Value1, unsigned short Value2);
unsigned long Divide(void *InstancePtr, unsigned long Numerator, unsigned long Denominator);
int CheckDenominator(void *InstancePtr, int Denominator);
unsigned short Muldiv(void *InstancePtr, unsigned short Value1, unsigned short Value2, unsigned short Value3);
short SMax(short Value1, short Value2);
short SMin(short Value1, short Value2);
short SMuldiv(void *InstancePtr, short Value1, short Value2, short Value3);
long SDivide(void *InstancePtr, long Numerator, long Denominator);
unsigned long UMod(void *InstancePtr, unsigned long Numerator, unsigned long Denominator);
long Mod(void *InstancePtr, long Numerator, long Denominator);
unsigned short Random(unsigned short LowerBound, unsigned short UpperBound);
unsigned short Rnd(void);
void Seed(unsigned short SeedValue);
unsigned short RotateLeft(unsigned short Number, unsigned short ShiftAmount);
unsigned short RotateRight(unsigned short Number, unsigned short ShiftAmount);
unsigned long RotateLeftLong(unsigned long Number, unsigned short ShiftAmount);
unsigned long RotateRightLong(unsigned long Number, unsigned short ShiftAmount);
void ClearBuffer(struct StringHdr_s *String);
int CompareStrings(struct StringHdr_s *String1,
                   struct StringHdr_s *String2,
                   int caseSensitive);
int Find(struct StringHdr_s *Match, struct StringHdr_s *Source,
            unsigned start, int caseSensitive);
void CheckBufferThreshold(struct StringHdr_s * String);

#define DYN_INT_ARRAY_FLAG        (0x80000000)


#include "Library_inline.h"



#define   DYN_RESIZE_ERROR_NOERROR             0
#define   DYN_RESIZE_ERROR_NULL           0x8001
#define   DYN_RESIZE_ERROR_MAX_LIMIT      0x8002
#define   DYN_RESIZE_ERROR_NON_DYNAMIC    0x8004
#define   DYN_RESIZE_ERROR_TRUNCATION     0x8008
#define   DYN_RESIZE_ERROR_ALLOC_FAILED   0x8010
#define   DYN_RESIZE_ERROR_ELMRSZ_FAILED  0x8020
#define   DYN_RESIZE_ERROR_ELMCRT_FAILED  0x8040


enum EIntArrType
  {
    e_INTARR_TYPE_INT,
    e_INTARR_TYPE_SIGNEDINT,
    e_INTARR_TYPE_LONG,
    e_INTARR_TYPE_SIGNEDLONG
  };

int ResizeString(void *InstancePtr, struct StringDynamicHdr_s *dStr, int newSize, int verbose);
int ResizeStringArray(void *InstancePtr, struct StringDynamicArrayHdr_s *dStrArr, int newSize, int newNumChar, int verbose);
int ResizeIntegerArray(void *InstancePtr, struct IntDynamicArrayHdr_s *dIntArr, int NumRows, int NumCols, enum EIntArrType type, int verbose);
int ResizeStructArray(void *InstancePtr, struct StructDynamicArrayHdr_s *dStructArray, int newSize, int verbose);

// SIMPL Windows 2.07.XX will not use this form of Gather().  Keep it for backwards compatability.
struct StringHdr_s* Gather(void *InstancePtr, struct StringHdr_s *Dest,
            struct StringHdr_s *Delim, struct StringHdr_s *Source);

// SIMPL Windows 2.07.XX and later use these forms of Gather().
struct StringHdr_s* GatherToDelimiter(void *InstancePtr, struct StringHdr_s *Dest,
            struct StringHdr_s *Delim, struct StringHdr_s *Source, unsigned int Timeout);
struct StringHdr_s* GatherByLength(void *InstancePtr, struct StringHdr_s *Dest,
            int NumBytes, struct StringHdr_s *Source, unsigned int Timeout);

unsigned short Getc(struct StringHdr_s *Source);
struct StringHdr_s* Left(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source, unsigned count);
unsigned short Len(struct StringHdr_s *String);
struct StringHdr_s* LowerDyn(struct StringHdr_s *Dest, struct StringDynamicHdr_s *Source);
struct StringHdr_s* Lower(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source);
struct StringHdr_s* Mid(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source,
            unsigned first, unsigned count);
struct StringHdr_s* Remove(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Delim,
            struct StringHdr_s *Source, unsigned start);
struct StringHdr_s* RemoveByLength(void *InstancePtr, struct StringHdr_s *Dest,
            int NumBytes, struct StringHdr_s *Source);
int InternalReverseFind(struct StringHdr_s *Match, struct StringHdr_s *Source,
            unsigned start, int caseSensitive);
int ReverseFind(struct StringHdr_s *Match, struct StringHdr_s *Source,
            unsigned start);
int ReverseFindi(struct StringHdr_s *Match, struct StringHdr_s *Source,
            unsigned start);
struct StringHdr_s* Right(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source, unsigned count);
int SetString(void *InstancePtr, struct StringHdr_s *Source, unsigned position, struct StringHdr_s *Dest);
struct StringHdr_s* Upper(void *InstancePtr, struct StringHdr_s *Dest, struct StringHdr_s *Source);

unsigned char MakeLower(unsigned char Character);
unsigned char MakeUpper(unsigned char Character);

struct StringHdr_s* MakeProgramFilename(struct StringHdr_s *Source);
struct StringHdr_s* GetModelNumber();
short GetSeries();
unsigned short GetProgramNumber();




void Sort1DIntegerArray(struct IntArrayHdr_s *Array);
void SortStringArray(struct StringArrayHdr_s *Array);

int IsDirectory(struct FileInfo_s *Info);
int IsHidden(struct FileInfo_s *Info);
int IsSystem(struct FileInfo_s *Info);
int IsVolume(struct FileInfo_s *Info);
int IsReadOnly(struct FileInfo_s *Info);
int WriteInteger(int FileHandle, unsigned short Value);
int ReadInteger(int FileHandle, unsigned short *Value);
int WriteLongInteger(int FileHandle, unsigned long Value);
int ReadLongInteger(int FileHandle, unsigned long *Value);
int WriteSignedInteger(int FileHandle, short Value);
int ReadSignedInteger(int FileHandle, short *Value);
int WriteSignedLongInteger(int FileHandle, long Value);
int ReadSignedLongInteger(int FileHandle, long *Value);
int WriteIntegerArray(int FileHandle, struct IntArrayHdr_s *Source);
int ReadIntegerArray(void *InstancePtr, int FileHandle, struct IntArrayHdr_s *Dest);
int WriteLongIntegerArray(int FileHandle, struct LongArrayHdr_s *Source);
int ReadLongIntegerArray(void *InstancePtr, int FileHandle, struct LongArrayHdr_s *Dest);
int WriteSignedIntegerArray(int FileHandle, struct SignedIntArrayHdr_s *Source);
int ReadSignedIntegerArray(void *InstancePtr, int FileHandle, struct SignedIntArrayHdr_s *Dest);
int WriteSignedLongIntegerArray(int FileHandle, struct SignedLongArrayHdr_s *Source);
int ReadSignedLongIntegerArray(void *InstancePtr, int FileHandle, struct SignedLongArrayHdr_s *Dest);
int WriteString(int FileHandle, struct StringHdr_s *Source);
int ReadString(void *InstancePtr, int FileHandle, struct StringHdr_s *Dest);
int WriteStringArray(int FileHandle, struct StringArrayHdr_s *Source);
int ReadStringArray(void *InstancePtr, int FileHandle, struct StringArrayHdr_s *Dest);

unsigned short* GetIntArrayElementPtr(void *InstancePtr, struct IntArrayHdr_s *Array, int Row, int Col);
unsigned long* GetLongArrayElementPtr(void *InstancePtr, struct LongArrayHdr_s *Array, int Row, int Col);
short* GetSignedIntArrayElementPtr(void *InstancePtr, struct SignedIntArrayHdr_s *Array, int Row, int Col);
long* GetSignedLongArrayElementPtr(void *InstancePtr, struct SignedLongArrayHdr_s *Array, int Row, int Col);
unsigned CheckIOArrayBounds(void *InstancePtr, struct InOutArray_s *Array, int Index);
unsigned CheckIOArrayBounds2(void *InstancePtr, struct InOutArray_s *Array, int Index);
unsigned CheckStringArrayBounds(void *InstancePtr, struct StringArrayHdr_s *Array, int Index);

void InitializeRampInfoInternal(struct RampInfo_s *pRampInfo);
void InitializeRampInfo(void *InstancePtr, struct RampInfo_s *pRampInfo);
void InitRampInfoStructArray(void *InstancePtr, struct StructArrayHdr_s *Array, int NumElem, int ElemSize, char *Name);
void InitRampInfoArray(void *InstancePtr, struct StructArrayHdr_s *Array);

unsigned short hextoi(struct StringHdr_s *String);
short hextosi(struct StringHdr_s *String);
long hextosl(struct StringHdr_s *String);
unsigned long hextol(struct StringHdr_s *String);
unsigned short LowerChar(unsigned short Character);
unsigned short UpperChar(unsigned short Character);

int ResizeIfAutogrow(void * InstancePtr, struct StringHdr_s *Dest, unsigned int newLength, unsigned int maxLen, char *errPrefix, int genNonDynErr);

void LockInputSema(void *InstancePtr, struct StringHdr_s *Source);
void UnLockInputSema(void *InstancePtr, struct StringHdr_s *Source);
#endif // #ifdef _LIBRARY_H
