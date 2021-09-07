#ifndef _FNCTLIST_H
#define _FNCTLIST_H

#include <string.h>

#include "SimplSig.h"

// Simpl+ File Access Defines
#define _O_RDONLY       0x0000          // open file for reading only
#define _O_WRONLY       0x0001          // open file for writing only
#define _O_RDWR         0x0002          // open file for reading only
#define _O_APPEND       0x0008          // writes are done at the end of the file

#define _O_CREAT        0x0100          // create an open file
#define _O_TRUNC        0x0200          // open and truncate
#define _O_EXCL         0x0400          // open only if file doesn't exist
#define _O_TEXT         0x4000          // file mode is text (tranlated)
#define _O_BINARY       0x8000          // file mode is binary (untranslated)

// Simpl+ File I/O error codes  (modified to match to Nucleus FILE codes)
#define ENOENT          -3024           // file or path not found
#define EMFILE          -3019           // no more file handles available (too many open files)
#define EEXIST          -3025           // _O_CREAT specified but filename exists
#define EACCES          -3021           // attempt to open a read-only or directory file
#define EBADF           -3020           // bad file handle

// Please add new functions to the END of the list. AKN 8/5/2003 12:19PM
struct FunctionList_s
{
    // Diab Standard C library functions
    char * (*strcpy)(char *dest, const char *src);
    void * (*memcpy)(void *dest, const void *src, size_t nbytes);
    void * (*memmove)(void *dest, const void *src, size_t nbytes);
    void * (*memset)(void *dest, int c, size_t nbytes);
    int  (*atoi) (const char *nptr);
    int  (*rand) (void);
    void (*srand) (unsigned seed);
    // Nucleus Routines
    void* (*Allocate)(unsigned long size);
    void (*Deallocate)(void *p);
    // functions within Control system
    int  (*Print)(void *InstancePtr, int formatlen, char *format,...);
    int  (*Error)(void *InstancePtr, int formatlen, char *format,...);
    unsigned (*GetDigitalInput)(void *InstancePtr, unsigned SignalNumber);
    unsigned (*GetDigitalOutput)(void *InstancePtr, unsigned SignalNumber);
    unsigned (*GetAnalogInput)(void *InstancePtr, unsigned SignalNumber);
    unsigned (*GetAnalogOutput)(void *InstancePtr, unsigned SignalNumber);
    void (*SetDigital)(void *InstancePtr, unsigned DigitalNumber, unsigned Value);
    void (*SetAnalog)(void *InstancePtr, unsigned AnalogNumber, unsigned Value);
    void (*SetSerial)(void *InstancePtr, unsigned SerialNumber, struct StringHdr_s *String);
    int  (*ObtainStringOutputSemaphore)(void *InstancePtr);
    int  (*ReleaseStringOutputSemaphore)(void *InstancePtr);
    int  (*FormatString)(void *InstancePtr, struct StringHdr_s *Dest, int FormatLen, char *FormatStr, ...);
    int  (*RegisterInputString)(void *InstancePtr, int InputNumber, struct StringHdr_s *String);
    int  (*UpdateInputString)(void *InstancePtr, struct Signal_s *Signal);
    int  (*CreateWait)(void *InstancePtr, char *WaitName,
                    unsigned long WaitTime, PF2 Routine);
    int (*CancelWait)(void *InstancePtr, char *WaitName);
    int (*PauseWait)(void *InstancePtr, char *WaitName);
    int (*ResumeWait)(void *InstancePtr, char *WaitName);
    int (*RetimeWait)(void *InstancePtr, char *WaitName, unsigned long NewTime);
    int (*GetWaitStatus)(void *InstancePtr, char *WaitName);
    unsigned long (*GetWaitTimeLeft)(void *InstancePtr, char *WaitName);
    int (*CancelAllWait)(void *InstancePtr);
    int (*PauseAllWait)(void *InstancePtr);
    int (*ResumeAllWait)(void *InstancePtr);
    void (*Delay)(unsigned long DelayTime);
    void (*ProcessLogic)(void);
    int (*CreatePulse)(void *InstancePtr, unsigned long WaitTime, int DigitalOutput);
    int (*IsDigitalInputDefined)(void *InstancePtr, unsigned SignalNumber);
    int (*IsDigitalOutputDefined)(void *InstancePtr, unsigned SignalNumber);
    int (*IsAnalogInputDefined)(void *InstancePtr, unsigned SignalNumber);
    int (*IsAnalogOutputDefined)(void *InstancePtr, unsigned SignalNumber);
    int (*IsSerialInputDefined)(void *InstancePtr, unsigned SignalNumber);
    int (*IsSerialOutputDefined)(void *InstancePtr, unsigned SignalNumber);
    int (*SpawnHandler)(void *InstancePtr, EH Handler, struct Signal_s *Signal, int ThreadSafe);
    int (*WaitOnInputString)(void *InstancePtr, struct StringHdr_s *String);
    struct StringHdr_s* (*Date)(struct StringHdr_s *DateString, int DateFormat);
    struct StringHdr_s* (*Day)(struct StringHdr_s *DayOfWeekString);
    int (*GetDateNum)(void);
    int (*GetDayOfWeekNum)(void);
    int (*GetHourNum)(void);
    int (*GetHSeconds)(void);
    int (*GetMinutesNum)(void);
    int (*GetMonthNum)(void);
    int (*GetSecondsNum)(void);
    int (*GetTicks)(void);
    int (*GetYearNum)(void);
    struct StringHdr_s* (*Month)(struct StringHdr_s *MonthString);
    void (*SetClock)(int hours, int minutes, int seconds);
    void (*SetDate)(int Month, int Day, int Year);
    struct StringHdr_s* (*Time)(struct StringHdr_s *TimeString);
    int (*WaitForNewDisk)(void);
    int (*CheckForDisk)(void);
    int (*FileOpen)(struct StringHdr_s *FileName, int AccessFlags);
    int (*FileClose)(int Handle);
    int (*FileRead)(int Handle, struct StringHdr_s* Buffer, int Count);
    void (*SendPacketToCPU)(struct StringHdr_s *String);
    void (*SendPacketToCresnet)(struct StringHdr_s *String);
    void (*SetSymbolEventStart)(void *InstancePtr);
    void (*UpdateSourceCodeLine)(void *InstancePtr, int LineNum);
    int (*GetSourceCodeLine)(void *InstancePtr);
    unsigned (*GetInOutArrayElement)(void *InstancePtr, struct InOutArray_s *Array, int Index);
    void (*SetOutputArrayElement)(void *InstancePtr, struct InOutArray_s *Array, int Index, int Value);
    void (*SetStringOutputArrayElement)(void *InstancePtr, struct InOutArray_s *Array,
                                        int Index, struct StringHdr_s *String);
    void (*TerminateTask)(void *InstancePtr, char *Message);
    void (*qsort)(void *, size_t, size_t, int (*)(const void *, const void *));
    int  (*RegisterInputStringArray)(void *InstancePtr, struct StringArrayHdr_s *Array);
    int (*StartFileOperations)(void *InstancePtr);
    int (*EndFileOperations)(void *InstancePtr);
    int (*FileWrite)(int Handle, struct StringHdr_s* Buffer, int Count);
    int (*FileBOF)(int Handle);
    int (*FileEOF)(int Handle);
    int (*FileDelete)(struct StringHdr_s* FileSpec);
    int (*FileLength)(int Handle);
    int (*FileSeek)(int Handle, int Offset, int Origin);
    struct StringHdr_s* (*GetCurrentDirectory)(void *InstancePtr, struct StringHdr_s* Path);
    int (*SetCurrentDirectory)(void *InstancePtr, struct StringHdr_s* Path);
    int (*MakeDirectory)(struct StringHdr_s* Path);
    int (*RemoveDirectory)(struct StringHdr_s* Path);
    int (*FindFirst)(void *InstancePtr, struct StringHdr_s* FileSpec, struct FileInfo_s *Info);
    int (*FindNext)(void *InstancePtr, struct FileInfo_s *Info);
    int (*FindClose)(void *InstancePtr);
    struct StringHdr_s* (*FileDate)(struct StringHdr_s *DateString, struct FileInfo_s *FileInfo, int DateFormat);
    struct StringHdr_s* (*FileDay)(struct StringHdr_s *DayOfWeekString, struct FileInfo_s *FileInfo);
    int (*FileGetDateNum)(struct FileInfo_s *FileInfo);
    int (*FileGetDayOfWeekNum)(struct FileInfo_s *FileInfo);
    int (*FileGetHourNum)(struct FileInfo_s *FileInfo);
    int (*FileGetMinutesNum)(struct FileInfo_s *FileInfo);
    int (*FileGetMonthNum)(struct FileInfo_s *FileInfo);
    int (*FileGetSecondsNum)(struct FileInfo_s *FileInfo);
    int (*FileGetYearNum)(struct FileInfo_s *FileInfo);
    struct StringHdr_s* (*FileMonth)(struct StringHdr_s *MonthString, struct FileInfo_s *FileInfo);
    struct StringHdr_s* (*FileTime)(struct StringHdr_s *TimeString, struct FileInfo_s *FileInfo);
    int  (*ExtendedError)(enum EErrorLevel eLevel, void *InstancePtr, int formatlen, char *format,...);
    unsigned long  (*fwrite)(char *buf, unsigned long size, int file);
    unsigned long  (*fread)(char *buf, unsigned long size, int file);
    int (*SendMail)(void *InstancePtr, struct StringHdr_s *Server, struct StringHdr_s *UserName, struct StringHdr_s *Password,
              struct StringHdr_s *From, struct StringHdr_s *To, struct StringHdr_s *CC, struct StringHdr_s *Subject,
              struct StringHdr_s *Message);
    int (*CreateRamp)(void *InstancePtr, unsigned AnalogNumber, struct RampInfo_s *RampData);
    int (*KillRamp)(void *InstancePtr, unsigned AnalogNumber);
    int (*IsRamping)(void *InstancePtr, unsigned InOrOut, unsigned AnalogNumber);
    int (*CompareRampsByAttribute)(void *InstancePtr, unsigned InOrOut, unsigned AnalogNumber, struct RampInfo_s *RampData);
    int (*GetRampInfo)(void *InstancePtr, unsigned InOrOut, unsigned AnalogNumber, struct RampInfo_s *RampData);
    void (*SendPacketToCresnetWithPointer)(void *InstancePtr, struct StringHdr_s *String);
    int  (*ExtendedErrorUserSpecified)(enum EErrorLevel eLevel, void *InstancePtr, int formatlen, char *format,...);
    int (*CheckForNVRAMDisk)(void);
    unsigned int (*GetLongIntegerParameter)(void *InstancePtr, unsigned ParameterNumber);
    int (*GetSignedLongIntegerParameter)(void *InstancePtr, unsigned ParameterNumber);
    short int (*GetSignedIntegerParameter)(void *InstancePtr, unsigned ParameterNumber);
    unsigned short int (*GetIntegerParameter)(void *InstancePtr, unsigned ParameterNumber);

    void (*InitStringParamStruct)(void *InstancePtr, struct StringHdr_s *String, int Type, int ElementNum, int ParamMaxLength, char *Name);

    void (*CheckStack)(void *InstancePtr);
    int (*CompareRampsById)(void *InstancePtr, unsigned InOrOut, unsigned AnalogNumber, unsigned int ID);
    int (*SendMailWithAttachments)(void *InstancePtr, struct StringHdr_s *Server, struct StringHdr_s *UserName, struct StringHdr_s *Password,
              struct StringHdr_s *From, struct StringHdr_s *To, struct StringHdr_s *CC, struct StringHdr_s *Subject,
              struct StringHdr_s *Message, int AttachmentCnt, struct StringHdr_s * Attachment);
    int (*WaitForInitializationComplete)(void *InstancePtr);

    void (*NotImplementedYetA)(void *InstancePtr);
    void (*NotImplementedYetB)(void *InstancePtr);
    void (*NotImplementedYetC)(void *InstancePtr);
    void (*NotImplementedYetD)(void *InstancePtr);
    void (*AlwaysNotImplementedYet)(void *InstancePtr);     // Warning: DO NOT CHANGE!! We need this to always be not implemented.
    int (*WaitOnInputStringWithTimeout)(void *InstancePtr, struct StringHdr_s *String, unsigned int Timeout);
    // GMT Offset Related Functions.
    int (*GetGmtOffset)(void *InstancePtr);
    int (*SetGmtOffset)(void *InstancePtr, int NewGmtOffset);
    int (*GetDst)(void *InstancePtr);
    int (*IsParameterDefined)(void *InstancePtr, unsigned ParameterNumber);
    struct StringHdr_s* (*GetSimplSymbolNameInfo)(void *InstancePtr, struct StringHdr_s* Name, int NameMode);
    struct StringHdr_s* (*GetSymbolReferenceName)(void *InstancePtr, struct StringHdr_s* Name);
    struct StringHdr_s* (*GetSymbolInstanceName)(void *InstancePtr, struct StringHdr_s* Name);

    // Direct Socket call backs
	void* (*CreateSplusSocket)(void *InstancePtr, struct SocketHdr_s *pSplusSocket);
    int (*SocketConnectClient)(void *InstancePtr, struct SocketHdr_s *pSplusSocket,
                                struct StringHdr_s *pAddress, int Port, int Reconnect);
    int (*SocketDisconnect)(void *InstancePtr, struct SocketHdr_s *pSplusSocket);
    int (*SocketServerStartListen)(void *InstancePtr, struct SocketHdr_s *pSplusSocket,
                                struct StringHdr_s *pAddress, int Port);
    int (*SocketUDP_Enable)(void *InstancePtr, struct SocketHdr_s *pSplusSocket,
                                struct StringHdr_s *pAddress, int Port);
    int (*SocketUDP_Disable)(void *InstancePtr, struct SocketHdr_s *pSplusSocket);
    int (*SocketSend)(void *InstancePtr, struct SocketHdr_s *pSplusSocket, struct StringHdr_s *pTxString);
    int (*SocketGetPortNumber)(void *InstancePtr, struct SocketHdr_s *pSplusSocket);
    int (*SocketGetRemoteIPAddress)(void *InstancePtr, struct SocketHdr_s *pSplusSocket, struct StringHdr_s *pAddress);
    int (*SocketGetAddressAsRequested)(void *InstancePtr, struct SocketHdr_s *pSplusSocket, struct StringHdr_s *pAddress);
    int (*SocketIsBroadcast)(void *InstancePtr, struct SocketHdr_s *pSplusSocket);
    int (*SocketIsMulticast)(void *InstancePtr, struct SocketHdr_s *pSplusSocket);
    int (*SocketGetSenderIPAddress)(void *InstancePtr, struct SocketHdr_s *pSplusSocket, struct Signal_s *Signal, struct StringHdr_s *pAddress);
    void (*WakeSocketsCallback)(void);
    int (*SendMailAdvance)(void *InstancePtr, int PortNumber, struct StringHdr_s *Server, struct StringHdr_s *UserName, struct StringHdr_s *Password,
              struct StringHdr_s *From, struct StringHdr_s *To, struct StringHdr_s *CC, struct StringHdr_s *Subject,
              struct StringHdr_s *Message, int AttachmentCnt, struct StringHdr_s * Attachment);
    int  (*ObtainStringInputSemaphore)(void *InstancePtr, struct StringHdr_s *String);
    int  (*ReleaseStringInputSemaphore)(void *InstancePtr, struct StringHdr_s *String);

    // This will be used as place holders to handle using new SIMPL Windows code with older firmware.  The idea
    //      is to avoid accessing outside the list when the new Simpl+ code calls a function that is not
    //      defined in the firmware.  This would crash the system.
    void (*NotImplementedYet8)(void *InstancePtr);
    void (*NotImplementedYet9)(void *InstancePtr);
    void (*NotImplementedYet10)(void *InstancePtr);
    void (*NotImplementedYet11)(void *InstancePtr);
    void (*NotImplementedYet12)(void *InstancePtr);
    void (*NotImplementedYet13)(void *InstancePtr);
    void (*NotImplementedYet14)(void *InstancePtr);
    void (*NotImplementedYet15)(void *InstancePtr);
    void (*NotImplementedYet16)(void *InstancePtr);
    void (*NotImplementedYet17)(void *InstancePtr);
    void (*NotImplementedYet18)(void *InstancePtr);

};

#ifdef __DCC__                          // this is defined for Diab Tools

#include <stdlib.h>
#include <string.h>
#include <npp/npp.h>
extern "C"
{
    #include <fal\inc\fal.h>
}
#include "CtrlSys.h"                    // needed for declaration of uart_printf()
#include "Error.h"

#ifdef GLOBALS
    struct FunctionList_s g_Functions =
    {
        &strcpy,
        &memcpy,
        &memmove,
        &memset,
        &atoi,
        &rand,
        &srand,
        &MyFreeStoreAllocate,
        &MyFreeStoreDeAllocate,
        &Print,
        &Error,
        &GetDigitalInput,
        &GetDigitalOutput,
        &GetAnalogInput,
        &GetAnalogOutput,
        &SetDigital,
        &SetAnalog,
        &SetSerial,
        &ObtainStringOutputSemaphore,
        &ReleaseStringOutputSemaphore,
        &FormatString,
        &RegisterInputString,
        &UpdateInputString,
        &CreateWait,
        &CancelWait,
        &PauseWait,
        &ResumeWait,
        &RetimeWait,
        &GetWaitStatus,
        &GetWaitTimeLeft,
        &CancelAllWait,
        &PauseAllWait,
        &ResumeAllWait,
        &Delay,
        &ProcessLogic,
        &CreatePulse,
        &IsDigitalInputDefined,
        &IsDigitalOutputDefined,
        &IsAnalogInputDefined,
        &IsAnalogOutputDefined,
        &IsSerialInputDefined,
        &IsSerialOutputDefined,
        &SpawnHandler,
        &WaitOnInputString,
        &Date,
        &Day,
        &GetDateNum,
        &GetDayOfWeekNum,
        &GetHourNum,
        &GetHSeconds,
        &GetMinutesNum,
        &GetMonthNum,
        &GetSecondsNum,
        &GetTicks,
        &GetYearNum,
        &Month,
        &SetClock,
        &SetDate,
        &Time,
        &WaitForNewDisk,
        &CheckForDisk,
        &FileOpen,
        &FileClose,
        &FileRead,
        &SendPacketToCPU,
        &SendPacketToCresnet,
        &SetSymbolEventStart,
        &UpdateSourceCodeLine,
        &GetSourceCodeLine,
        &GetInOutArrayElement,
        &SetOutputArrayElement,
        &SetStringOutputArrayElement,
        &TerminateTask,
        &qsort,
        &RegisterInputStringArray,
        &StartFileOperations,
        &EndFileOperations,
        &FileWrite,
        &FileBOF,
        &FileEOF,
        &FileDelete,
        &FileLength,
        &FileSeek,
        &GetCurrentDirectory,
        &SetCurrentDirectory,
        &MakeDirectory,
        &RemoveDirectory,
        &FindFirst,
        &FindNext,
        &FindClose,
        &FileDate,
        &FileDay,
        &FileGetDateNum,
        &FileGetDayOfWeekNum,
        &FileGetHourNum,
        &FileGetMinutesNum,
        &FileGetMonthNum,
        &FileGetSecondsNum,
        &FileGetYearNum,
        &FileMonth,
        &FileTime,
        &ExtendedError,
        &MyFwrite,
        &MyFread,
 //        &FAL_Fwrite,
 //        &FAL_Fread,
 	    &SendMail,
        &CreateRamp,
        &KillRamp,
        &IsRamping,
        &CompareRampsByAttribute,
        &GetRampInfo,
        &SendPacketToCresnetWithPointer,
        &ExtendedErrorUserSpecified,
        &CheckForNVRAMDisk,
        &GetLongIntegerParameter,
        &GetSignedLongIntegerParameter,
        &GetSignedIntegerParameter,
        &GetIntegerParameter,
        &InitStringParamStruct,
        &CheckStack,
        &CompareRampsById,
        &SendMailWithAttachments,
        &WaitForInitializationComplete,
        &NotImplementedYet,     // &_CN_CreateRamp,
        &NotImplementedYet,     // &_CN_CreateRampWithBaseValue,
        &NotImplementedYet,     // &_CN_KillRamp,
        &NotImplementedYet,     // &_CN_IsRamping,
        &NotImplementedYet,     // &_CN_GetRampInfo,
        &WaitOnInputStringWithTimeout,
        &GetGmtOffset,
        &SetGmtOffset,
        &GetDst,
        &IsParameterDefined,
        &GetSimplSymbolNameInfo,
        &GetSymbolReferenceName,
        &GetSymbolInstanceName,
        &CreateSplusSocket,
        &SocketConnectClient,
        &SocketDisconnect,
        &SocketServerStartListen,
        &SocketUDP_Enable,
        &SocketUDP_Disable,
        &SocketSend,
        &SocketGetPortNumber,
        &SocketGetRemoteIPAddress,
        &SocketGetAddressAsRequested,
        &SocketIsBroadcast,
        &SocketIsMulticast,
        &SocketGetSenderIPAddress,
        &WakeSocketsCallback,
        &SendMailAdvance,
        &ObtainStringInputSemaphore,
        &ReleaseStringInputSemaphore,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet,
        &NotImplementedYet
    };
#else
    extern struct FunctionList_s g_Functions;
#endif  // #ifdef GLOBALS

#else // Below included only if __DCC__ is not defined (GNU only)

// need to initialize the structure so it can be assigned to a section
// only need a pointer in the GNU section.  Only defined in the GLOBALS.C file
#ifdef GLOBALS
    struct FunctionList_s *g_pFunctions __attribute__ ((section("FunctionList"))) = NULL;
#else
    extern struct FunctionList_s *g_pFunctions;
#endif  // #ifdef GLOBALS

// defines to replace standard functions with the correct pointer calls.
#define strcpy (*g_pFunctions->strcpy)
#define memcpy (*g_pFunctions->memcpy)
#define memmove (*g_pFunctions->memmove)
#define memset (*g_pFunctions->memset)
#define atoi (*g_pFunctions->atoi)
#define rand (*g_pFunctions->rand)
#define srand (*g_pFunctions->srand)
#define Allocate (*g_pFunctions->Allocate)
#define Deallocate (*g_pFunctions->Deallocate)
#define Print (*g_pFunctions->Print)
#define Error (*g_pFunctions->Error)
#define GetDigitalInput (*g_pFunctions->GetDigitalInput)
#define GetDigitalOutput (*g_pFunctions->GetDigitalOutput)
#define GetAnalogInput (*g_pFunctions->GetAnalogInput)
#define GetAnalogOutput (*g_pFunctions->GetAnalogOutput)
#define SetDigital (*g_pFunctions->SetDigital)
#define SetAnalog (*g_pFunctions->SetAnalog)
#define SetSerial (*g_pFunctions->SetSerial)
#define ObtainStringOutputSemaphore (*g_pFunctions->ObtainStringOutputSemaphore)
#define ReleaseStringOutputSemaphore (*g_pFunctions->ReleaseStringOutputSemaphore)
#define ObtainStringInputSemaphore (*g_pFunctions->ObtainStringInputSemaphore)
#define ReleaseStringInputSemaphore (*g_pFunctions->ReleaseStringInputSemaphore)
#define FormatString (*g_pFunctions->FormatString)
#define RegisterInputString (*g_pFunctions->RegisterInputString)
#define UpdateInputString (*g_pFunctions->UpdateInputString)
#define CreateWait (*g_pFunctions->CreateWait)
#define CancelWait (*g_pFunctions->CancelWait)
#define PauseWait (*g_pFunctions->PauseWait)
#define ResumeWait (*g_pFunctions->ResumeWait)
#define RetimeWait (*g_pFunctions->RetimeWait)
#define GetWaitStatus (*g_pFunctions->GetWaitStatus)
#define GetWaitTimeLeft (*g_pFunctions->GetWaitTimeLeft)
#define CancelAllWait (*g_pFunctions->CancelAllWait)
#define PauseAllWait (*g_pFunctions->PauseAllWait)
#define ResumeAllWait (*g_pFunctions->ResumeAllWait)
#define Delay (*g_pFunctions->Delay)
#define ProcessLogic (*g_pFunctions->ProcessLogic)
#define Pulse (*g_pFunctions->CreatePulse)
#define IsDigitalInputDefined (*g_pFunctions->IsDigitalInputDefined)
#define IsDigitalOutputDefined (*g_pFunctions->IsDigitalOutputDefined)
#define IsAnalogInputDefined (*g_pFunctions->IsAnalogInputDefined)
#define IsAnalogOutputDefined (*g_pFunctions->IsAnalogOutputDefined)
#define IsSerialInputDefined (*g_pFunctions->IsSerialInputDefined)
#define IsSerialOutputDefined (*g_pFunctions->IsSerialOutputDefined)
#define SpawnHandler (*g_pFunctions->SpawnHandler)
#define WaitOnInputString (*g_pFunctions->WaitOnInputString)
#define Date (*g_pFunctions->Date)
#define Day (*g_pFunctions->Day)
#define GetDateNum (*g_pFunctions->GetDateNum)
#define GetDayOfWeekNum (*g_pFunctions->GetDayOfWeekNum)
#define GetHourNum (*g_pFunctions->GetHourNum)
#define GetHSeconds (*g_pFunctions->GetHSeconds)
#define GetMinutesNum (*g_pFunctions->GetMinutesNum)
#define GetMonthNum (*g_pFunctions->GetMonthNum)
#define GetSecondsNum (*g_pFunctions->GetSecondsNum)
#define GetTicks (*g_pFunctions->GetTicks)
#define GetYearNum (*g_pFunctions->GetYearNum)
#define Month (*g_pFunctions->Month)
#define SetClock (*g_pFunctions->SetClock)
#define SetDate (*g_pFunctions->SetDate)
#define Time (*g_pFunctions->Time)
#define WaitForNewDisk (*g_pFunctions->WaitForNewDisk)
#define CheckForDisk (*g_pFunctions->CheckForDisk)
#define FileOpen (*g_pFunctions->FileOpen)
#define FileClose (*g_pFunctions->FileClose)
#define FileRead (*g_pFunctions->FileRead)
#define SendPacketToCPU (*g_pFunctions->SendPacketToCPU)
#define SendPacketToCresnet (*g_pFunctions->SendPacketToCresnet)
#define SetSymbolEventStart (*g_pFunctions->SetSymbolEventStart)
#define UpdateSourceCodeLine (*g_pFunctions->UpdateSourceCodeLine)
#define GetSourceCodeLine (*g_pFunctions->GetSourceCodeLine)
#define GetInOutArrayElement (*g_pFunctions->GetInOutArrayElement)
#define SetOutputArrayElement (*g_pFunctions->SetOutputArrayElement)
#define SetStringOutputArrayElement (*g_pFunctions->SetStringOutputArrayElement)
#define TerminateTask (*g_pFunctions->TerminateTask)
#define qsort (*g_pFunctions->qsort);
#define RegisterInputStringArray (*g_pFunctions->RegisterInputStringArray)
#define StartFileOperations (*g_pFunctions->StartFileOperations)
#define EndFileOperations (*g_pFunctions->EndFileOperations)
#define FileWrite (*g_pFunctions->FileWrite)
#define FileBOF (*g_pFunctions->FileBOF)
#define FileEOF (*g_pFunctions->FileEOF)
#define FileDelete (*g_pFunctions->FileDelete)
//#define FileDeleteShared (*g_pFunctions->FileDelete)
#define FileLength (*g_pFunctions->FileLength)
#define FileSeek (*g_pFunctions->FileSeek)
#define GetCurrentDirectory (*g_pFunctions->GetCurrentDirectory)
#define SetCurrentDirectory (*g_pFunctions->SetCurrentDirectory)
#define MakeDirectory (*g_pFunctions->MakeDirectory)
#define RemoveDirectory (*g_pFunctions->RemoveDirectory)
#define FindFirst (*g_pFunctions->FindFirst)
//#define FindFirstShared (*g_pFunctions->FindFirst)
#define FindNext (*g_pFunctions->FindNext)
#define FindClose (*g_pFunctions->FindClose)
#define FileDate (*g_pFunctions->FileDate)
#define FileDay (*g_pFunctions->FileDay)
#define FileGetDateNum (*g_pFunctions->FileGetDateNum)
#define FileGetDayOfWeekNum (*g_pFunctions->FileGetDayOfWeekNum)
#define FileGetHourNum (*g_pFunctions->FileGetHourNum)
#define FileGetMinutesNum (*g_pFunctions->FileGetMinutesNum)
#define FileGetMonthNum (*g_pFunctions->FileGetMonthNum)
#define FileGetSecondsNum (*g_pFunctions->FileGetSecondsNum)
#define FileGetYearNum (*g_pFunctions->FileGetYearNum)
#define FileMonth (*g_pFunctions->FileMonth)
#define FileTime (*g_pFunctions->FileTime)
#define ExtendedError (*g_pFunctions->ExtendedError)
#define FwriteCallback (*g_pFunctions->fwrite)
#define FreadCallback (*g_pFunctions->fread)
#define SendMail (*g_pFunctions->SendMail)
#define CreateRamp (*g_pFunctions->CreateRamp)
#define StopRamp (*g_pFunctions->KillRamp)
#define IsRamping (*g_pFunctions->IsRamping)
#define CompareRampsByAttribute (*g_pFunctions->CompareRampsByAttribute)
#define GetRampInfo (*g_pFunctions->GetRampInfo)
#define SendPacketToCresnetWithPointer (*g_pFunctions->SendPacketToCresnetWithPointer)
#define ExtendedErrorUserSpecified (*g_pFunctions->ExtendedErrorUserSpecified)
#define CheckForNVRAMDisk (*g_pFunctions->CheckForNVRAMDisk)
#define GetIntegerParameter (*g_pFunctions->GetIntegerParameter)
#define GetLongIntegerParameter (*g_pFunctions->GetLongIntegerParameter)
#define GetSignedLongIntegerParameter (*g_pFunctions->GetSignedLongIntegerParameter)
#define GetSignedIntegerParameter (*g_pFunctions->GetSignedIntegerParameter)
#define GetIntegerParameter (*g_pFunctions->GetIntegerParameter)
#define InitStringParamStruct (*g_pFunctions->InitStringParamStruct)
#define CheckStack (*g_pFunctions->CheckStack)
#define CompareRampsById (*g_pFunctions->CompareRampsById)
#define SendMailWithAttachments (*g_pFunctions->SendMailWithAttachments)
#define WaitForInitializationComplete (*g_pFunctions->WaitForInitializationComplete)
#define WaitOnInputStringWithTimeout (*g_pFunctions->WaitOnInputStringWithTimeout)
#define GetGmtOffset (*g_pFunctions->GetGmtOffset)
#define SetGmtOffset (*g_pFunctions->SetGmtOffset)
#define GetDst (*g_pFunctions->GetDst)
#define IsParameterDefined (*g_pFunctions->IsParameterDefined)
#define GetSimplSymbolNameInfo (*g_pFunctions->GetSimplSymbolNameInfo)
#define GetSymbolReferenceName (*g_pFunctions->GetSymbolReferenceName)
#define GetSymbolInstanceName (*g_pFunctions->GetSymbolInstanceName)
#define CreateSplusSocket (*g_pFunctions->CreateSplusSocket)
#define SocketConnectClient (*g_pFunctions->SocketConnectClient)
#define SocketDisconnectClient (*g_pFunctions->SocketDisconnect)
#define SocketServerStartListen (*g_pFunctions->SocketServerStartListen)
#define SocketServerStopListen (*g_pFunctions->SocketDisconnect)
#define SocketUDP_Enable (*g_pFunctions->SocketUDP_Enable)
#define SocketUDP_Disable (*g_pFunctions->SocketUDP_Disable)
#define SocketSend (*g_pFunctions->SocketSend)
#define SocketGetPortNumber (*g_pFunctions->SocketGetPortNumber)
#define SocketGetRemoteIPAddress (*g_pFunctions->SocketGetRemoteIPAddress)
#define SocketGetAddressAsRequested (*g_pFunctions->SocketGetAddressAsRequested)
#define SocketIsBroadcast (*g_pFunctions->SocketIsBroadcast)
#define SocketIsMulticast (*g_pFunctions->SocketIsMulticast)
#define SocketGetSenderIPAddress (*g_pFunctions->SocketGetSenderIPAddress)
#define WakeSocketsCallback (*g_pFunctions->WakeSocketsCallback)
#define SendMailAdvance (*g_pFunctions->SendMailAdvance)

#define NotImplementedYet (*g_pFunctions->AlwaysNotImplementedYet)

#endif  // #ifdef __DCC__

#endif  //#ifndef _FNCTLIST_H
