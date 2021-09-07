// This is not a standalone file - this should be included by other files.
// There are no #includes in this file because the outer files should be
// responsible for doing this


#ifndef __Library_inline_c
#define __Library_inline_c


#include "typedefs.h"
#include "fnctlist.h"
#include "Library.h"




INLINE void InitIntArray(struct IntArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols;
    Array->NumRows = NumRows;
    Array->Name = Name;
}

#define ERROR_DYN_INTARR_ALLOC "Array %z allocation failure."
INLINE void InitDynamicIntArray(void *InstancePtr, struct IntDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
    Array->NumRows = NumRows | DYN_INT_ARRAY_FLAG;
    Array->Name = Name;

    Array->Data = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(unsigned short));

    if (Array->Data == NULL)
      {
        Error(InstancePtr, sizeof(ERROR_DYN_INTARR_ALLOC)-1, ERROR_DYN_INTARR_ALLOC,
          Array->Name);
        return NULL;
      }// allocation failure

    memset(Array->Data, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(unsigned short)));

}




INLINE void InitSignedIntArray(struct SignedIntArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols;
    Array->NumRows = NumRows;
    Array->Name = Name;
}

INLINE void InitSignedIntDynamicArray(void *InstancePtr, struct SignedIntDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
    Array->NumRows = NumRows | DYN_INT_ARRAY_FLAG;
    Array->Name = Name;

    Array->Data = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(short));

    if (Array->Data == NULL)
      {
        Error(InstancePtr, sizeof(ERROR_DYN_INTARR_ALLOC)-1, ERROR_DYN_INTARR_ALLOC,
          Array->Name);
        return NULL;
      }// allocation failure

    memset(Array->Data, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(short)));

}



#define ERROR_FORMAT_STRING1 "Integer Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "Integer Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
#define ERROR_FORMAT_STRING3 "Null Array Pointer"
INLINE void SetIntArrayElement(void *InstancePtr, struct IntArrayHdr_s *Array, int Row, int Col, unsigned short Value)
{
    int Index;
    int dynFlag = 0;
    int numCols, numRows;
    struct IntDynamicArrayHdr_s *dynArray;


    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return;
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

        // MNT - 9/20/2007 - Just set the zeroth element now
        if (dynFlag) // dynamic array
          {
             dynArray = (struct IntDynamicArrayHdr_s *)(Array);
             dynArray->Data[0] = Value;
          }
        return;
    }
    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
         dynArray = (struct IntDynamicArrayHdr_s *)(Array);
         dynArray->Data[Index] = Value;
      }
    else
      {
        Array->Data[Index] = Value;
      }
}
INLINE unsigned short GetIntArrayElement(void *InstancePtr, struct IntArrayHdr_s *Array, int Row, int Col)
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
        if ( numRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag) // dynamic array
          {
            dynArray = (struct IntDynamicArrayHdr_s *)(Array);
            return dynArray->Data[0];
          } // dynamic flag

        return 0;
    }
    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
        dynArray = (struct IntDynamicArrayHdr_s *)(Array);
        return dynArray->Data[Index];
      } // dynamic flag
    else // dynamic flag
      {
        return Array->Data[Index];
      }// dynamic flag
}


#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
INLINE void SetIntArray(struct IntArrayHdr_s *Array, unsigned short Value)
{
    int i, j, numRows, numCols;
    int dynFlag = 0;
    struct IntDynamicArrayHdr_s * dynArray;

    if ( Array == NULL )
        return;

    // MNT - 3/22/2007 - Instead of having a separate function, just
    // check here if the array is dynamic and access it correctly
    if (Array->NumRows & DYN_INT_ARRAY_FLAG)
    {
      dynArray = (struct IntDynamicArrayHdr_s *)(Array);
      numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

      // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
      // to zero - just return
      // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
//      if (numCols == 0)
//        return;

      for ( i = 0; i <= numRows; i++)
          for ( j = 0; j <= numCols; j++)
              dynArray->Data[(i * numCols) + j] = Value;
    } // if dynamic
    else
    {
      for ( i = 0; i <= Array->NumRows; i++)
          for ( j = 0; j <= Array->NumCols; j++)
              Array->Data[(i * Array->NumCols) + j] = Value;
    } // end if dynamic
}

INLINE void SetIntDynamicArray(struct IntDynamicArrayHdr_s *Array, unsigned short Value)
{
    int i, j, numRows, numCols;

    if ( Array == NULL )
        return;

    numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
    numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

    // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
    // to zero - just return
    // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
    //if (numCols == 0)
    //  return;

    for ( i = 0; i <= numRows; i++)
        for ( j = 0; j <= numCols; j++)
            Array->Data[(i * numCols) + j] = Value;
}

INLINE void InitLongArray(struct LongArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols;
    Array->NumRows = NumRows;
    Array->Name = Name;
}
INLINE void InitLongDynamicArray(void *InstancePtr, struct LongDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
    Array->NumRows = NumRows | DYN_INT_ARRAY_FLAG;
    Array->Name = Name;

    Array->Data = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(unsigned long));

    if (Array->Data == NULL)
      {
        Error(InstancePtr, sizeof(ERROR_DYN_INTARR_ALLOC)-1, ERROR_DYN_INTARR_ALLOC,
          Array->Name);
        return NULL;
      }// allocation failure

    memset(Array->Data, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(unsigned long)));

}
INLINE void InitSignedLongArray(struct SignedLongArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols;
    Array->NumRows = NumRows;
    Array->Name = Name;
}

INLINE void InitSignedLongDynamicArray(void *InstancePtr, struct SignedLongDynamicArrayHdr_s *Array,  int NumRows, int NumCols, char *Name)
{
    if ( Array == NULL )
        return;

    Array->NumCols = NumCols | DYN_INT_ARRAY_FLAG;
    Array->NumRows = NumRows | DYN_INT_ARRAY_FLAG;
    Array->Name = Name;

    Array->Data = Allocate((NumRows + 1) * (NumCols + 1) * sizeof(long));

    if (Array->Data == NULL)
      {
        Error(InstancePtr, sizeof(ERROR_DYN_INTARR_ALLOC)-1, ERROR_DYN_INTARR_ALLOC,
          Array->Name);
        return NULL;
      }// allocation failure

    memset(Array->Data, 0, ((NumRows + 1) * (NumCols + 1) * sizeof(long)));


}

#define ERROR_FORMAT_STRING1 "LongInteger Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "LongInteger Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
INLINE void SetLongArrayElement(void *InstancePtr, struct LongArrayHdr_s *Array, int Row, int Col, unsigned long Value)
{
    int Index;
    int dynFlag = 0;
    int numCols, numRows;
    struct LongDynamicArrayHdr_s *dynArray;

    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return;
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
        // MNT - 9/20/2007 - Just set the zeroth element now
        if (dynFlag) // dynamic array
          {
             dynArray = (struct LongDynamicArrayHdr_s *)(Array);
             dynArray->Data[0] = Value;
          }
        return;
    }
    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
         dynArray = (struct LongDynamicArrayHdr_s *)(Array);
         dynArray->Data[Index] = Value;
      }
    else
      {
        Array->Data[Index] = Value;
      }
}
INLINE unsigned long GetLongArrayElement(void *InstancePtr, struct LongArrayHdr_s *Array, int Row, int Col)
{
    int Index;
    int dynFlag = 0;
    struct LongDynamicArrayHdr_s *dynArray;
    int numCols, numRows;

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
        if ( numRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag) // dynamic array
          {
            dynArray = (struct LongDynamicArrayHdr_s *)(Array);
            return dynArray->Data[0];
          } // dynamic flag

        return 0;
    }
    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
        dynArray = (struct LongDynamicArrayHdr_s *)(Array);
        return dynArray->Data[Index];
      } // dynamic flag
    else // dynamic flag
      {
        return Array->Data[Index];
      }// dynamic flag

}


#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
INLINE void SetLongArray(struct LongArrayHdr_s *Array, unsigned long Value)
{
    int i, j, numRows, numCols;
    int dynFlag = 0;
    struct LongDynamicArrayHdr_s * dynArray;

    if ( Array == NULL )
        return;

    // MNT - 3/22/2007 - Instead of having a separate function, just
    // check here if the array is dynamic and access it correctly
    if (Array->NumRows & DYN_INT_ARRAY_FLAG)
    {
      dynArray = (struct LongDynamicArrayHdr_s *)(Array);
      numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

      // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
      // to zero - just return
      // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
      //if (numCols == 0)
      //  return;

      for ( i = 0; i <= numRows; i++)
          for ( j = 0; j <= numCols; j++)
              dynArray->Data[(i * numCols) + j] = Value;
    } // if dynamic
    else
    {
      if ( Array == NULL )
          return;

      for ( i = 0; i <= Array->NumRows; i++)
          for ( j = 0; j <= Array->NumCols; j++)
              Array->Data[(i * Array->NumCols) + j] = Value;
    } // end if dynamic
}

INLINE void SetLongDynamicArray(struct LongDynamicArrayHdr_s *Array, unsigned long Value)
{
    int i, j, numRows, numCols;;

    if ( Array == NULL )
        return;

    numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
    numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

      // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
      // to zero - just return
      // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
      //if (numCols == 0)
      //  return;

    for ( i = 0; i <= numRows; i++)
        for ( j = 0; j <= numCols; j++)
            Array->Data[(i * numCols) + j] = Value;
}


#define ERROR_FORMAT_STRING1 "Signed Integer Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "Signed Integer Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
INLINE void SetSignedIntArrayElement(void *InstancePtr, struct SignedIntArrayHdr_s *Array, int Row, int Col, short Value)
{
    int Index;
    int dynFlag = 0;
    struct SignedIntDynamicArrayHdr_s *dynArray;
    int numCols, numRows;

    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return;
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
        if ( numRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);
        // MNT - 9/20/2007 - Set the zeroth element
        if (dynFlag) // dynamic array
          {
            dynArray = (struct SignedIntDynamicArrayHdr_s *)(Array);
            dynArray->Data[0] = Value;
          } // dynamic flag
        return 0;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
        dynArray = (struct SignedIntDynamicArrayHdr_s *)(Array);
        dynArray->Data[Index] = Value;
      } // dynamic flag
    else // dynamic flag
      {
        Array->Data[Index] = Value;
      }// dynamic flag
}

INLINE short GetSignedIntArrayElement(void *InstancePtr, struct SignedIntArrayHdr_s *Array, int Row, int Col)
{
    int Index;
    int dynFlag = 0;
    struct SignedIntDynamicArrayHdr_s *dynArray;
    int numCols, numRows;

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
        if ( numRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag) // dynamic array
          {
            dynArray = (struct SignedIntDynamicArrayHdr_s *)(Array);
            return dynArray->Data[0];
          } // dynamic flag
        return 0;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
        dynArray = (struct SignedIntDynamicArrayHdr_s *)(Array);
        return dynArray->Data[Index];
      } // dynamic flag
    else // dynamic flag
      {
        return Array->Data[Index];
      }// dynamic flag

  }
#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2

INLINE void SetSignedIntArray(struct SignedIntArrayHdr_s *Array, short Value)
{
    int i, j, numRows, numCols;
    int dynFlag = 0;
    struct SignedIntDynamicArrayHdr_s * dynArray;

    if ( Array == NULL )
        return;

    // MNT - 3/22/2007 - Instead of having a separate function, just
    // check here if the array is dynamic and access it correctly
    if (Array->NumRows & DYN_INT_ARRAY_FLAG)
    {
      dynArray = (struct SignedIntDynamicArrayHdr_s *)(Array);
      numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

      // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
      // to zero - just return
      // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
      //if (numCols == 0)
      //  return;

      for ( i = 0; i <= numRows; i++)
          for ( j = 0; j <= numCols; j++)
              dynArray->Data[(i * numCols) + j] = Value;
    } // if dynamic
    else
    {
      for ( i = 0; i <= Array->NumRows; i++)
          for ( j = 0; j <= Array->NumCols; j++)
              Array->Data[(i * Array->NumCols) + j] = Value;
    } // end if dynamic
}


INLINE void SetSignedIntDynamicArray(struct SignedIntDynamicArrayHdr_s *Array, short Value)
{
    int i, j, numRows, numCols;

    if ( Array == NULL )
        return;

    numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
    numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

    // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
    // to zero - just return
    // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
    //if (numCols == 0)
    //  return;

    for ( i = 0; i <= numRows; i++)
        for ( j = 0; j <= numCols; j++)
            Array->Data[(i * numCols) + j] = Value;
}


#define ERROR_FORMAT_STRING1 "Signed LongInteger Array %z overflow.  Col = %d.  Bounds = %d"
#define ERROR_FORMAT_STRING2 "Signed LongInteger Array %z overflow.  Row,Col = %d,%d.  Bounds = %d, %d"
INLINE void SetSignedLongArrayElement(void *InstancePtr, struct SignedLongArrayHdr_s *Array, int Row, int Col, long Value)
{
    int Index;
    int dynFlag = 0;
    struct SignedLongDynamicArrayHdr_s *dynArray;
    int numCols, numRows;

    if ( Array == NULL )
    {
        Error(InstancePtr, sizeof(ERROR_FORMAT_STRING3)-1, ERROR_FORMAT_STRING3);
        return;
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
        if ( numRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Just set the zeroth element
        if (dynFlag) // dynamic array
          {
            dynArray = (struct SignedLongDynamicArrayHdr_s *)(Array);
            dynArray->Data[0] = Value;
          } // dynamic flag

        return 0;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
        dynArray = (struct SignedLongDynamicArrayHdr_s *)(Array);
        dynArray->Data[Index] = Value;
      } // dynamic flag
    else // dynamic flag
      {
        Array->Data[Index] = Value;
      }// dynamic flag
}
INLINE long GetSignedLongArrayElement(void *InstancePtr, struct SignedLongArrayHdr_s *Array, int Row, int Col)
{
    int Index;
    int dynFlag = 0;
    struct SignedLongDynamicArrayHdr_s *dynArray;
    int numCols, numRows;

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
        if ( numRows == 0)       // 1-D array
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING1)-1, ERROR_FORMAT_STRING1,
                    Array->Name, Col, numCols);
        else
            Error(InstancePtr, sizeof(ERROR_FORMAT_STRING2)-1, ERROR_FORMAT_STRING2,
                    Array->Name, Row, Col, numRows, numCols);

        // MNT - 9/20/2007 - Return the first element to be consistent with other arrays
        if (dynFlag) // dynamic array
          {
            dynArray = (struct SignedLongDynamicArrayHdr_s *)(Array);
            return dynArray->Data[0];
          } // dynamic flag
        return 0;
    }

    Index = (Row * (numCols+1)) + Col;
    if (dynFlag) // dynamic array
      {
        dynArray = (struct SignedLongDynamicArrayHdr_s *)(Array);
        return dynArray->Data[Index];
      } // dynamic flag
    else // dynamic flag
      {
        return Array->Data[Index];
      }// dynamic flag
}


#undef ERROR_FORMAT_STRING1
#undef ERROR_FORMAT_STRING2
INLINE void SetSignedLongArray(struct LongArrayHdr_s *Array, long Value)
{
    int i, j, numRows, numCols;
    int dynFlag = 0;
    struct SignedLongDynamicArrayHdr_s * dynArray;

    if ( Array == NULL )
        return;

    // MNT - 3/22/2007 - Instead of having a separate function, just
    // check here if the array is dynamic and access it correctly
    if (Array->NumRows & DYN_INT_ARRAY_FLAG)
    {
      dynArray = (struct SignedLongDynamicArrayHdr_s *)(Array);
      numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
      numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

      // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
      // to zero - just return
      // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
      //if (numCols == 0)
      //  return;

      for ( i = 0; i <= numRows; i++)
          for ( j = 0; j <= numCols; j++)
              dynArray->Data[(i * numCols) + j] = Value;
    } // if dynamic
    else
    {
      for ( i = 0; i <= Array->NumRows; i++)
          for ( j = 0; j <= Array->NumCols; j++)
              Array->Data[(i * Array->NumCols) + j] = Value;
    } // else if dynamic
}

INLINE void SetSignedLongDynamicArray(struct LongDynamicArrayHdr_s *Array, long Value)
{
    int i, j, numRows, numCols;

    if ( Array == NULL )
        return;

    numRows = Array->NumRows & ~DYN_INT_ARRAY_FLAG;
    numCols = Array->NumCols & ~DYN_INT_ARRAY_FLAG;

    // MNT - 3/29/2007 - If number of columns is 0 - the array was resized
    // to zero - just return
    // MNT - 9/20/2007 - Don't return any more. We will overwrite the first element
    //if (numCols == 0)
    //  return;

    for ( i = 0; i <= numRows; i++)
        for ( j = 0; j <= numCols; j++)
            Array->Data[(i * numCols) + j] = Value;
}





/**
 * \brief
 * Write brief comment for GetCharFromString here.
 *
 * \param Str
 * Description of parameter Str.
 *
 * \param index
 * Description of parameter index.
 *
 * \returns
 * Write description of return value here.
 *
 * \throws <exception class>
 * Description of criteria for throwing this exception.
 *
 * Write detailed description for GetCharFromString here.
 *
 * \remarks
 * This function does not do any error checks on the index - the calling
 * function should make sure of that.
 *
 * \see
 * Separate items with the '|' character.
 */
INLINE unsigned char GetCharFromString(struct StringHdr_s * String, unsigned int index)
  {
    struct StringDynamicHdr_s *dStr;

    if ( IsStringDynamic(String->InputType) )
      {
        dStr = (struct StringDynamicHdr_s *)(String);
        return dStr->String[index];
      }
    else
      {
        return String->String[index];
      }
  }


/**
 * \brief
 * Write brief comment for GetCharAddrFromString here.
 *
 * \param Str
 * Description of parameter Str.
 *
 * \param index
 * Description of parameter index.
 *
 * \returns
 * Write description of return value here.
 *
 * \throws <exception class>
 * Description of criteria for throwing this exception.
 *
 * Write detailed description for GetCharFromString here.
 *
 * \remarks
 * This function does not do any error checks on the index - the calling
 * function should make sure of that.
 *
 * \see
 * Separate items with the '|' character.
 */
INLINE unsigned char * GetCharAddrFromString(struct StringHdr_s * String)
  {
    struct StringDynamicHdr_s *dStr;

    if ( IsStringDynamic(String->InputType) )
      {
        dStr = (struct StringDynamicHdr_s *)(String);
        return dStr->String;
      }
    else
      {
        return &(String->String[0]);
      }
  }



/**
 * \brief
 * Write brief comment for GetCharAddrFromString here.
 *
 * \param Str
 * Description of parameter Str.
 *
 * \param index
 * Description of parameter index.
 *
 * \returns
 * Write description of return value here.
 *
 * \throws <exception class>
 * Description of criteria for throwing this exception.
 *
 * Write detailed description for GetCharFromString here.
 *
 * \remarks
 * This function does not do any error checks on the index - the calling
 * function should make sure of that.
 *
 * \see
 * Separate items with the '|' character.
 */
INLINE unsigned char * GetCharAddrFromStringOffset(struct StringHdr_s * String, unsigned int index)
  {
    struct StringDynamicHdr_s *dStr;

    if ( IsStringDynamic(String->InputType) )
      {
        dStr = (struct StringDynamicHdr_s *)(String);
        return (unsigned char * )(&(dStr->String[index]));
      }
    else
      {
        return &(String->String[index]);
      }
  }

/*-----------------11/10/2010 4:59PM----------------
 * added to handle the FileOpenShared calls for 2series
 * --------------------------------------------------*/
INLINE int FileOpenShared(struct StringHdr_s *FileName, int AccessFlags)
{
    FileOpen(FileName, AccessFlags);
}
INLINE int FileDeleteShared(struct StringHdr_s* FileSpec)
{
    FileDelete(FileSpec);
}
INLINE int FindFirstShared(void *InstancePtr, struct StringHdr_s* FileSpec, struct FileInfo_s *Info)
{
    FindFirst(InstancePtr, FileSpec, Info);
}
INLINE int MakeDirectoryShared(struct StringHdr_s* Path)
{
    MakeDirectory(Path);
}
INLINE int RemoveDirectoryShared(struct StringHdr_s* Path)
{
    RemoveDirectory(Path);
}





#endif // Library_inline_c
