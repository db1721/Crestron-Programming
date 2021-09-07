#ifndef _SIGNAL_STRUCT
#define _SIGNAL_STRUCT

#define MAX_SIMPL_STRING_LEN    0x100   // maximum length of a serial string signal.

enum SignalType_e
{
    e_SIGNAL_TYPE_DIGITAL,
    e_SIGNAL_TYPE_ANALOG,
    e_SIGNAL_TYPE_STRING,
    e_SIGNAL_TYPE_DIGITAL_EXPIRED,
    e_SIGNAL_TYPE_CONNECT,
    e_SIGNAL_TYPE_DISCONNECT,
    e_SIGNAL_TYPE_RECEIVE,
    e_SIGNAL_TYPE_STATUS
};

struct Signal_s
{
    enum SignalType_e Type;
    unsigned short LastModified;        // added to allow the last modified to be passed into the
    unsigned short SignalNumber;        //    handler.
    int Value;                          // Value will be StrLen for e_SIGNAL_TYPE_STRING
    char String[MAX_SIMPL_STRING_LEN];
};

#define SIGNAL_INPUT            0x00000
#define SIGNAL_OUTPUT           0x10000

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
    unsigned char String[2];
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
struct StringDynamicHdr_s
{
    enum EInputType InputType;
    int MaxLen;
    int CurLen;
    char *Name;                             // to be used in error reporting
    unsigned char *String;
};
#endif

#ifndef MODULE_NAME_LEN
#define MODULE_NAME_LEN     256
#endif

typedef int  (*PF3) (void *, void *, void *);    // ptr to int function w/ 3 args
typedef void (*EH) (struct Signal_s *, void *, void *);  // ptr to event handler w/ 3 args
typedef int  (*PF2) (void *, void *);    // ptr to int function w/ 2 args

struct EntryPoint_s
{
    int  (*Entry)(void *MemPtr, void *NvramPtr, void *InstancePtr);
    void (*EventHandler)(struct Signal_s *Signal, void *MemPtr, void *NvramPtr);
    char ModuleName[MODULE_NAME_LEN];
    int  DataSpaceRequired;
    int  NvramRequired;
};

#endif                                  // _SIGNAL_STRUCT

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

#define IO_TYPE_DIGITAL_INPUT   0x00
#define IO_TYPE_ANALOG_INPUT    0x01
#define IO_TYPE_STRING_INPUT    0x02
#define IO_TYPE_DIGITAL_OUTPUT  0x03
#define IO_TYPE_ANALOG_OUTPUT   0x04
#define IO_TYPE_STRING_OUTPUT   0x05
#define IO_TYPE_INTEGER_PARAMETER               0x06
#define IO_TYPE_SIGNED_INTEGER_PARAMETER        0x07
#define IO_TYPE_LONG_INTEGER_PARAMETER          0x08
#define IO_TYPE_SIGNED_LONG_INTEGER_PARAMETER   0x09
#define IO_TYPE_STRING_PARAMETER                0x0A

#endif

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

#endif

// file access error codes
#define FILE_BAD_USER       -3000   // Calling task is not a file user.  Use StartFileOperations() first.
#define FILE_NO_DISK        -3004   // Disk is removed.
#define FILE_LONGPATH       -3017   // Path or directory name too long.
#define FILE_INVNAME        -3018   // Path or filename includes invalid character.
#define FILE_PEMFILE        -3019   // No file descriptors available (too many files open).
#define FILE_BADFILE        -3020   // Invalid File Descriptor
#define FILE_ACCES          -3021   // Attempt to open a read only file or a special (directory).
#define FILE_NOSPC          -3022   // No space to create file in this disk.
#define FILE_SHARE          -3023   // The access conflict from multiple tasks to a specific file.
#define FILE_NOFILE         -3024   // File not found.
#define FILE_EXIST          -3025   // Exclusive access requested but file already exists.
#define FILE_NVALFP         -3026   // Seek to negative file pointer
#define FILE_MAXFILE_SIZE   -3027   // Over the maximum file size.
#define FILE_NOEMPTY        -3028   // Directory is not empty
#define FILE_INVPARM        -3029   // Invalid Flag/Mode is specified.
#define FILE_INVPARCMB      -3030   // Invalid Flag/Mode combination.
#define FILE_NO_MEMORY      -3031   // Can't allocate internal buffer.
#define FILE_NO_BLOCK       -3032   // No block buffer available.
#define FILE_NO_FINODE      -3033   // No FINODE buffer available.
#define FILE_NO_DROBJ       -3034   // No DROBJ buffer available.
#define FILE_IO_ERROR       -3035   // Driver IO function routine returned error.
#define FILE_INTERNAL       -3036   // Internal error.

#ifndef ERROR_LEVEL_ENUM
#define ERROR_LEVEL_ENUM

enum EErrorLevel
{
    eERROR_LEVEL_OK,
    eERROR_LEVEL_NOTICE,
    eERROR_LEVEL_WARNING,
    eERROR_LEVEL_ERROR,
    eERROR_LEVEL_FATAL,
    eERROR_LEVEL_DEBUG
};

#endif


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
    struct StringHdr_s  SocketRxBuf;    // exposed to user
};

#endif
