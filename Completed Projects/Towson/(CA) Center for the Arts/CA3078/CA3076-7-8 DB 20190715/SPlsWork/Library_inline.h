// This is not a standalone file - this should be included by other files.
// This includes the inline c file if needed (non-debug mode)


#ifndef __Library_inline_h
#define __Library_inline_h


#ifdef DEBUG_MODE_FLAG // if We are in debug mode

INLINE void InitIntArray(struct IntArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void InitDynamicIntArray(void *InstancePtr, struct IntDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void InitSignedIntArray(struct SignedIntArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void InitSignedIntDynamicArray(void *InstancePtr, struct SignedIntDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void SetIntArrayElement(void *InstancePtr, struct IntArrayHdr_s *Array, int Row, int Col, unsigned short Value);
INLINE unsigned short GetIntArrayElement(void *InstancePtr, struct IntArrayHdr_s *Array, int Row, int Col);
INLINE void SetIntArray(struct IntArrayHdr_s *Array, unsigned short Value);
INLINE void SetIntDynamicArray(struct IntDynamicArrayHdr_s *Array, unsigned short Value);
INLINE void InitLongArray(struct LongArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void InitLongDynamicArray(void *InstancePtr, struct LongDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void InitSignedLongArray(struct SignedLongArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void InitSignedLongDynamicArray(void *InstancePtr, struct SignedLongDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name);
INLINE void SetLongArrayElement(void *InstancePtr, struct LongArrayHdr_s *Array, int Row, int Col, unsigned long Value);
INLINE unsigned long GetLongArrayElement(void *InstancePtr, struct LongArrayHdr_s *Array, int Row, int Col);
INLINE void SetLongArray(struct LongArrayHdr_s *Array, unsigned long Value);
INLINE void SetLongDynamicArray(struct LongDynamicArrayHdr_s *Array, unsigned long Value);
INLINE void SetSignedIntArrayElement(void *InstancePtr, struct SignedIntArrayHdr_s *Array, int Row, int Col, short Value);
INLINE short GetSignedIntArrayElement(void *InstancePtr, struct SignedIntArrayHdr_s *Array, int Row, int Col);
INLINE void SetSignedIntArray(struct SignedIntArrayHdr_s *Array, short Value);
INLINE void SetSignedIntDynamicArray(struct SignedIntDynamicArrayHdr_s *Array, short Value);
INLINE void SetSignedLongArrayElement(void *InstancePtr, struct SignedLongArrayHdr_s *Array, int Row, int Col, long Value);
INLINE long GetSignedLongArrayElement(void *InstancePtr, struct SignedLongArrayHdr_s *Array, int Row, int Col);
INLINE void SetSignedLongArray(struct LongArrayHdr_s *Array, long Value);
INLINE void SetSignedLongDynamicArray(struct LongDynamicArrayHdr_s *Array, long Value);
INLINE unsigned char GetCharFromString(struct StringHdr_s * String, unsigned int index);
INLINE unsigned char * GetCharAddrFromString(struct StringHdr_s * String);
INLINE unsigned char * GetCharAddrFromStringOffset(struct StringHdr_s * String, unsigned int index);
INLINE int FileOpenShared(struct StringHdr_s *FileName, int AccessFlags);
INLINE int FileDeleteShared(struct StringHdr_s* FileSpec);
INLINE int FindFirstShared(void *InstancePtr, struct StringHdr_s* FileSpec, struct FileInfo_s *Info);
INLINE int MakeDirectoryShared(struct StringHdr_s* Path);
INLINE int RemoveDirectoryShared(struct StringHdr_s* Path);
#else //DEBUG_MODE_FLAG

#include "Library_inline.c"


#endif //DEBUG_MODE_FLAG


#endif // Library_inline_h
