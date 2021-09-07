namespace BiampTesiraLib3.Tesira_Support;
        // class declarations
         class VoipCallStatusList;
         class TesiraClassCodes;
         class RequestMsg;
         class RequestMsgAttribute;
         class SystemCommands;
         class TesiraLevelAttributes;
         class MessageBundle;
         class VoipCallStatusStateMap;
         class TesiraLevelAttributeMap;
         class VoipCallStatusPromptMap;
         class SystemInstanceTags;
         class TesiraProtocolInfo;
         class SubscribedResponse;
         class TesiraStateAttributes;
         class RequestResponse;
         class ParserUtil;
         class VoipCallStatus;
         class VoipCallStatuses;
         class ProtocolUtil;
         class SubscriptionManager;
         class SubscriptionWatchdogPayload;
         class TesiraRouterAttributes;
     class VoipCallStatusList 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        BiampTesiraLib3.Tesira_Support.VoipCallStatuses Call;

        // class properties
    };

     class TesiraClassCodes 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER AEC_CLASS_CODE;
        static SIGNED_LONG_INTEGER INPUT_CLASS_CODE;
        static SIGNED_LONG_INTEGER OUTPUT_CLASS_CODE;
        static SIGNED_LONG_INTEGER CNINPUT_CLASS_CODE;
        static SIGNED_LONG_INTEGER CNOUTPUT_CLASS_CODE;
        static SIGNED_LONG_INTEGER TIRECEIVE_CLASS_CODE;
        static SIGNED_LONG_INTEGER TIXMIT_CLASS_CODE;
        static SIGNED_LONG_INTEGER VOIPRECEIVE_CLASS_CODE;
        static SIGNED_LONG_INTEGER VOIPXMIT_CLASS_CODE;
        static SIGNED_LONG_INTEGER GATEAUTOMIX_CLASS_CODE;
        static SIGNED_LONG_INTEGER GSAUTOMIX_CLASS_CODE;
        static SIGNED_LONG_INTEGER SMIX_CLASS_CODE;
        static SIGNED_LONG_INTEGER MMIX_CLASS_CODE;
        static SIGNED_LONG_INTEGER RC_CLASS_CODE;
        static SIGNED_LONG_INTEGER ROUTER_CLASS_CODE;
        static SIGNED_LONG_INTEGER SSELECT_CLASS_CODE;
        static SIGNED_LONG_INTEGER LEVEL_CLASS_CODE;
        static SIGNED_LONG_INTEGER LOGICMETER_CLASS_CODE;
        static SIGNED_LONG_INTEGER USBINPUT_CLASS_CODE;
        static SIGNED_LONG_INTEGER USBOUTPUT_CLASS_CODE;
        static SIGNED_LONG_INTEGER AVINPUT_CLASS_CODE;
        static SIGNED_LONG_INTEGER AVOUTPUT_CLASS_CODE;

        // class properties
    };

     class RequestMsg 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING InstanceTag[];
        STRING Command[];
        STRING OriginalString[];
    };

     class RequestMsgAttribute 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Attribute[];
        STRING InstanceTag[];
        STRING Command[];
        STRING OriginalString[];
    };

     class SystemCommands 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING GET[];
        static STRING SET[];
        static STRING SUBSCRIBE[];

        // class properties
    };

     class TesiraLevelAttributes 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING LEVEL[];
        static STRING INPUTLEVEL[];
        static STRING OUTPUTLEVEL[];
        static STRING CROSSPOINTLEVEL[];
        static STRING SOURCELEVEL[];
        static STRING CHANNELLEVEL[];
        static STRING LEVELIN[];
        static STRING LEVELOUT[];
        static STRING LEVELSOURCE[];
        static STRING HOSTMASTERVOL[];
        static STRING HOSTVOL[];
        static STRING AUXLEVEL[];

        // class properties
    };

     class VoipCallStatusStateMap 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap INIT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap FAULT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap IDLE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap DIAL_TONE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap SILENT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap DIALING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap RINGBACK;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap RINGING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap ANSWERING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap BUSY;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap REJECT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap INVALID_NUMBER;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap ACTIVE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap ACTIVE_MUTED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap ON_HOLD;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap WAITING_RING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap CONF_ACTIVE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap CONF_HOLD;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_INIT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_SILENT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_REQ_DIALING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_RINGBACK;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_ACTIVE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_WAIT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_DECISION;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_INIT_ERROR;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_ON_HOLD;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_REPLACES_PROCESS;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap XFER_PROCESS;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusStateMap UNKNOWN;

        // class properties
        INTEGER Number;
        STRING Name[];
    };

     class TesiraLevelAttributeMap 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap LEVEL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap INPUTLEVEL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap OUTPUTLEVEL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap LEVELOUT;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap LEVELIN;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap LEVELSOURCE;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap CHANNELLEVEL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap SOURCELEVEL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap CROSSPOINTLEVEL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap HOSTMASTERVOL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap HOSTVOL;
        static BiampTesiraLib3.Tesira_Support.TesiraLevelAttributeMap AUXLEVEL;

        // class properties
        STRING LevelAttribute[];
        STRING MinAttribute[];
        STRING MaxAttribute[];
    };

     class VoipCallStatusPromptMap 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap NONE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap STARTING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap REGISTERING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap SIP_USER_NOT_CONFIGURED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap ENTER_NUMBER;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CONNECTING;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap INCOMING_CALL_FROM;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap PEER_BUSY;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CALL_CANNOT_BE_COMPLETED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap ON_HOLD;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CALL_ON_HELD;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CONFERENCE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CONFERENCE_ON_HOLD;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CONNECTED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CONNECTED_MUTED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap AUTH_FAILURE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap PROXY_NOT_CONFIGURED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap NETWORK_INIT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap DHCP_IN_PROGRESS;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap NETWORK_LINK_DOWN;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap NETWORK_LINK_UP;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap IPADDR_CONFLICT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap NETWORK_CONFIGURED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap CODEC_NEGOTIATION_FAILURE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap UNEXPECTED_ERROR;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap AUTH_USER_NOT_CONFIGURED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap AUTH_PASSWORD_NOT_CONFIGURED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap DND;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap INVALID_NUMBER;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap TEMP_UNAVAILABLE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap DECLINED;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap SERVICE_UNAVAILABLE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap FORBIDDEN;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap BEING_XFER_TO;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap XFER_IN_PROCESS;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap XFER_TIME_OUT;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap PROXY_UNAVAILABLE;
        static BiampTesiraLib3.Tesira_Support.VoipCallStatusPromptMap UNKNOWN;

        // class properties
        SIGNED_LONG_INTEGER Number;
        STRING Name[];
    };

     class SystemInstanceTags 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING SESSION[];
        static STRING DEVICE[];

        // class properties
    };

     class TesiraProtocolInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING InstanceTag[];
        STRING Attribute[];
        INTEGER Index1;
        INTEGER Index2;
    };

     class SubscribedResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ID;
        STRING Attribute[];
        STRING Payload[];
        STRING OriginalString[];
    };

     class TesiraStateAttributes 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING MUTE[];
        static STRING CROSSPOINT[];
        static STRING INPUTMUTE[];
        static STRING OUTPUTMUTE[];
        static STRING CROSSPOINTLEVELSTATE[];
        static STRING HOSTMASTERMUTE[];
        static STRING HOSTMUTE[];
        static STRING CONNECTED[];
        static STRING STREAMING[];
        static STRING MUTEOUT[];
        static STRING MUTEIN[];
        static STRING MUTESOURCE[];
        static STRING WALLSTATE[];
        static STRING STATE[];
        static STRING EMBEDDEDAUDIOMUTE[];
        static STRING VIDEOMUTE[];
        static STRING VIDEOFREEZE[];
        static STRING AUXMUTE[];

        // class properties
    };

     class RequestResponse 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Payload[];
        STRING OriginalString[];
    };

     class ParserUtil 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class VoipCallStatus 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ID;
        VoipCallStatusStateMap State;
        VoipCallStatusPromptMap Prompt;
        STRING CidName[];
        STRING CidNumber[];
        INTEGER LedStatus;
        VoipCallStatusStateMap DefaultState;
        VoipCallStatusPromptMap DefaultPrompt;
        STRING DefaultCidName[];
        STRING DefaultCidNumber[];
    };

     class VoipCallStatuses 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Get ( INTEGER ID , BYREF VoipCallStatus item );
        FUNCTION set_Item ( SIGNED_LONG_INTEGER index , VoipCallStatus value );
        FUNCTION Add ( VoipCallStatus item );
        SIGNED_LONG_INTEGER_FUNCTION BinarySearch ( VoipCallStatus item );
        FUNCTION Clear ();
        FUNCTION CopyTo ( VoipCallStatus array[] );
        SIGNED_LONG_INTEGER_FUNCTION IndexOf ( VoipCallStatus item );
        FUNCTION Insert ( SIGNED_LONG_INTEGER index , VoipCallStatus item );
        SIGNED_LONG_INTEGER_FUNCTION LastIndexOf ( VoipCallStatus item );
        FUNCTION RemoveAt ( SIGNED_LONG_INTEGER index );
        FUNCTION RemoveRange ( SIGNED_LONG_INTEGER index , SIGNED_LONG_INTEGER count );
        FUNCTION Reverse ();
        FUNCTION Sort ();
        FUNCTION TrimExcess ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Capacity;
        SIGNED_LONG_INTEGER Count;
    };

     class ProtocolUtil 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION EscapeValue ( STRING Value );
        static STRING_FUNCTION CleanInstanceTag ( STRING InstanceTag );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SubscriptionWatchdogPayload 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ID;
        TesiraProtocolInfo Info;
    };

     class TesiraRouterAttributes 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING INPUT[];
        static STRING SOURCESELECTION[];

        // class properties
    };

namespace BiampTesiraLib3.Parser;
        // class declarations
         class BoolParser;
         class UInt16ArrayParser;
         class ResolutionParser;
         class DeviceConnectedEnumParser;
         class DoubleParser;
         class UInt16Parser;
         class TransitionEnumParser;
         class VideoFormatParser;
         class VideoSourceEnumParser;
         class FrameRateEnumParser;
         class TestPatternEnumParser;
         class OSDDurationParser;
         class MaxResolutionEnumParser;
         class BoolArrayParser;
     class BoolParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class UInt16ArrayParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ResolutionParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION Parse ( STRING payload );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DeviceConnectedEnumParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DoubleParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class UInt16Parser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class TransitionEnumParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class VideoFormatParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class VideoSourceEnumParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class FrameRateEnumParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class TestPatternEnumParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class OSDDurationParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class MaxResolutionEnumParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class BoolArrayParser 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace BiampTesiraLib3.Events;
        // class declarations
         class VoipCallStatusesEventArgs;
         class CallerIDEventArgs;
         class AVOutputStateEventArgs;
         class AVInputStateEventArgs;
         class DialerStatusEventArgs;
         class StringEventArgs;
         class SimplSharpStringEventArgs;
         class SpeedDialItemEventArgs;
         class VoipDialerStatusEventArgs;
         class Int16EventArgs;
         class UInt16EventArgs;
           class CallerID;
           class AVOutputState;
           class AVInputState;
           class DialerStatus;
           class SpeedDialItem;
           class VoipDialerStatus;
     class VoipCallStatusesEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        VoipCallStatuses Payload;
    };

     class CallerIDEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CallerID Payload;
    };

     class AVOutputStateEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AVOutputState Payload;
    };

     class AVInputStateEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AVInputState Payload;
    };

     class DialerStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DialerStatus Payload;
    };

     class StringEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Payload[];
    };

     class SimplSharpStringEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIMPLSHARPSTRING Payload[];
    };

     class SpeedDialItemEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SpeedDialItem Payload;
    };

     class VoipDialerStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        VoipDialerStatus Payload;
    };

     class Int16EventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER Payload;
    };

     class UInt16EventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Payload;
    };

namespace BiampTesiraLib3.ConfigInfo;
        // class declarations
         class AVInputConfigInfo;
         class StateConfigInfo;
         class GenericConfigInfo;
         class VoIPDialerConfigInfo;
         class LevelConfigInfo;
         class RouterConfigInfo;
         class BiampTesiraConfigInfo;
         class DialerConfigInfo;
         class AVOutputConfigInfo;
     class AVInputConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
    };

     class StateConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
        STRING StateType[];
        INTEGER Index1;
        INTEGER Index2;
    };

     class GenericConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
        STRING AttributeCode[];
        INTEGER Index1;
        INTEGER Index2;
        INTEGER SignalType;
        INTEGER HasSubscription;
    };

     class VoIPDialerConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING DialerInstanceID[];
        STRING ControlStatusInstanceID[];
        INTEGER LineNumber;
    };

     class LevelConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
        STRING LevelType[];
        INTEGER Index1;
        INTEGER Index2;
        INTEGER LevelStep;
    };

     class RouterConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
        STRING RouterType[];
        INTEGER Output;
    };

     class BiampTesiraConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Type;
        INTEGER CommandProcessorID;
        STRING IPAddress[];
        STRING Username[];
        STRING Password[];
    };

     class DialerConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING DialerInstanceID[];
        STRING ControlStatusInstanceID[];
    };

     class AVOutputConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
    };

namespace BiampTesiraLib3.CCI_Support;
        // class declarations
         class Component;
         class ComponentUtil;
     class Component 
    {
        // class delegates

        // class events
        EventHandler OnQuarantineChange ( Component sender, UInt16EventArgs args );

        // class functions
        FUNCTION ProcessSubscription ( SubscribedResponse msg );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class ComponentUtil 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION Register ( Component me );
        static FUNCTION UnRegister ( Component me );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace BiampTesiraLib3.Components;
        // class declarations
         class VoipDialerComponent;
         class VoipDialerStatus;
         class DNDModes;
         class StateComponent;
         class AVOutputComponent;
         class AVOutputState;
         class AVInputComponent;
         class AVInputState;
         class DialerComponent;
         class DialerStatus;
         class RouterComponent;
         class PresetComponent;
         class PassThruComponent;
         class GenericComponent;
         class LevelComponent;
     class VoipDialerComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializeChange ( VoipDialerComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( VoipDialerComponent sender, VoipDialerStatusEventArgs args );
        EventHandler OnKeypadTextChange ( VoipDialerComponent sender, StringEventArgs args );
        EventHandler OnSpeedDialItemChange ( VoipDialerComponent sender, SpeedDialItemEventArgs args );
        EventHandler OnCallChange ( VoipDialerComponent sender, UInt16EventArgs args );
        EventHandler OnCallStatusListChange ( VoipDialerComponent sender, VoipCallStatusesEventArgs args );
        EventHandler OnSpeedDialSeletion ( VoipDialerComponent sender, SpeedDialItemEventArgs args );
        EventHandler OnQuarantineChange ( VoipDialerComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING DialerInstanceID , STRING ControlStatusInstanceID , INTEGER LineNumber );
        FUNCTION UnRegister ();
        FUNCTION CallSelect ( INTEGER call );
        FUNCTION Conference ();
        FUNCTION Answer ();
        FUNCTION Answer_Call ( INTEGER Call );
        FUNCTION End_Call ( INTEGER Call );
        FUNCTION End_All ();
        FUNCTION Flash ();
        FUNCTION Redial ();
        FUNCTION Send ();
        FUNCTION End ();
        FUNCTION Resume ();
        FUNCTION Hold ();
        FUNCTION OnHook ();
        FUNCTION OffHook ();
        FUNCTION AutoAnswer ( INTEGER state );
        FUNCTION AutoAnswerToggle ();
        FUNCTION DialDigit ( STRING Digit );
        FUNCTION DialKeypadText ();
        FUNCTION Dial ( STRING alphaNumeric );
        FUNCTION Transfer ();
        FUNCTION ClearKeypadText ();
        FUNCTION BackspaceKeypadText ();
        FUNCTION DNDEnable ( INTEGER State );
        FUNCTION DNDEnableToggle ();
        FUNCTION DNDResponseDND ();
        FUNCTION DNDResponseBusy ();
        FUNCTION DNDResponseDecline ();
        FUNCTION SelectSpeedDialEntry ( INTEGER ID );
        FUNCTION DialSpeedDialEntry ();
        FUNCTION SaveSpeedDialEntry ( INTEGER ID , STRING Name , STRING Number );
        FUNCTION ProcessSubscription ( SubscribedResponse response );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        VoIPDialerConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class VoipDialerStatus 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION IsAutoAnswerOn ();
        INTEGER_FUNCTION IsDNDEnabled ();
        INTEGER_FUNCTION IsDNDResponseModeDND ();
        INTEGER_FUNCTION IsDNDResponseModeBusy ();
        INTEGER_FUNCTION IsDNDResponseModeDecline ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING LastNumber[];
        DNDModes DNDMode;
    };

    static class DNDModes // enum
    {
        static SIGNED_LONG_INTEGER DND_480;
        static SIGNED_LONG_INTEGER DND_486;
        static SIGNED_LONG_INTEGER DND_603;
        static SIGNED_LONG_INTEGER Unknown;
    };

     class StateComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( StateComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( StateComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( StateComponent sender, UInt16EventArgs args );
        EventHandler OnQuarantineChange ( StateComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING InstanceTag , STRING StateType , INTEGER Index1 , INTEGER Index2 );
        FUNCTION UnRegister ();
        FUNCTION SetState ( INTEGER state );
        FUNCTION ToggleState ();
        INTEGER_FUNCTION GetState ();
        FUNCTION PollState ();
        FUNCTION ProcessSubscription ( SubscribedResponse response );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        StateConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class AVOutputComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( AVOutputComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( AVOutputComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( AVOutputComponent sender, AVOutputStateEventArgs args );
        EventHandler OnQuarantineChange ( AVOutputComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING InstanceTag );
        FUNCTION UnRegister ();
        FUNCTION SetOutputMediaTestPattern ( INTEGER pattern );
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        FUNCTION ProcessSubscription ( SubscribedResponse msg );
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION Poll ();
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AVOutputConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class AVOutputState 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING OutputMediaResolution[];
        SIGNED_INTEGER OutputMediaFramerate;
        STRING OutputMediaFramerateText[];
        SIGNED_INTEGER OutputMediaTransition;
        STRING OutputMediaTransitionText[];
        SIGNED_INTEGER OutputMediaOSDMessages;
        STRING OutputMediaOSDMessagesText[];
        SIGNED_INTEGER OutputMediaConnectedPort;
        STRING OutputMediaConnectedPortText[];
        SIGNED_INTEGER OutputMediaOutputFormatOptions;
        STRING OutputMediaOutputFormatOptionsText[];
        SIGNED_INTEGER OutputMediaTestPattern;
        STRING OutputMediaTestPatternText[];
        SIGNED_INTEGER EmbeddedAudioPresense_L;
        SIGNED_INTEGER EmbeddedAudioPresense_R;
        SIGNED_INTEGER EmbeddedAudioPresense_LFE;
        SIGNED_INTEGER EmbeddedAudioPresense_C;
        SIGNED_INTEGER EmbeddedAudioPresense_Lr;
        SIGNED_INTEGER EmbeddedAudioPresense_Rr;
        SIGNED_INTEGER EmbeddedAudioPresense_Ls;
        SIGNED_INTEGER EmbeddedAudioPresense_Rs;
        STRING EmbeddedAudioThresholdText[];
        STRING StreamResolution[];
        SIGNED_INTEGER StreamFrameRate;
        STRING StreamBandwidthText[];
        STRING StreamConnectionText[];
    };

     class AVInputComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( AVInputComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( AVInputComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( AVInputComponent sender, AVInputStateEventArgs args );
        EventHandler OnQuarantineChange ( AVInputComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING InstanceTag );
        FUNCTION UnRegister ();
        FUNCTION SetMediaSourceInputPort ( INTEGER port );
        FUNCTION SetMediaSourceTestPattern ( INTEGER pattern );
        FUNCTION ProcessSubscription ( SubscribedResponse msg );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AVInputConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class AVInputState 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER MediaSourceInputPort;
        STRING MediaSourceInputPortText[];
        STRING MediaSourceResolution[];
        SIGNED_INTEGER MediaSourceFramerate;
        SIGNED_INTEGER MediaSourceActiveSource;
        STRING MediaSourceActiveSourceText[];
        SIGNED_INTEGER MediaSourceConnectedPort;
        STRING MediaSourceConnectedPortText[];
        SIGNED_INTEGER MediaSourceDeinterlace;
        SIGNED_INTEGER MediaSourceTestPattern;
        STRING MediaSourceTestPatternText[];
        SIGNED_INTEGER EmbeddedAudioPresense_L;
        SIGNED_INTEGER EmbeddedAudioPresense_R;
        SIGNED_INTEGER EmbeddedAudioPresense_LFE;
        SIGNED_INTEGER EmbeddedAudioPresense_C;
        SIGNED_INTEGER EmbeddedAudioPresense_Lr;
        SIGNED_INTEGER EmbeddedAudioPresense_Rr;
        SIGNED_INTEGER EmbeddedAudioPresense_Ls;
        SIGNED_INTEGER EmbeddedAudioPresense_Rs;
        STRING EmbeddedAudioThresholdText[];
        SIGNED_INTEGER BandwidthMaxResolution;
        STRING BandwidthMaxResolutionText[];
        SIGNED_INTEGER BandwidthMinFrameRate;
        STRING BandwidthMinFrameRateText[];
        SIGNED_INTEGER BandwidthMaxCompression;
        STRING BandwidthMaxBandwidthText[];
        STRING BandwidthRequiredConnectionText[];
        STRING StreamResolution[];
        SIGNED_INTEGER StreamFrameRate;
        STRING StreamBandwidthText[];
        STRING StreamConnectionText[];
    };

     class DialerComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( DialerComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( DialerComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( DialerComponent sender, DialerStatusEventArgs args );
        EventHandler OnKeypadTextChange ( DialerComponent sender, StringEventArgs args );
        EventHandler OnCallerIDResponse ( DialerComponent sender, CallerIDEventArgs args );
        EventHandler OnSpeedDialItemChange ( DialerComponent sender, SpeedDialItemEventArgs args );
        EventHandler OnSpeedDialSeletion ( DialerComponent sender, SpeedDialItemEventArgs args );
        EventHandler OnQuarantineChange ( DialerComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING DialerInstanceID , STRING ControlStatusInstanceID );
        FUNCTION UnRegister ();
        FUNCTION OnHook ();
        FUNCTION OffHook ();
        FUNCTION ToggleHook ();
        FUNCTION Answer ();
        FUNCTION Flash ();
        FUNCTION Redial ();
        FUNCTION End ();
        FUNCTION AutoAnswer ( INTEGER state );
        FUNCTION AutoAnswerToggle ();
        FUNCTION GetBasicCallerID ();
        FUNCTION GetFullCallerID ();
        FUNCTION DialDigit ( STRING Digit );
        FUNCTION DialKeypadText ();
        FUNCTION DialNumber ( STRING number );
        FUNCTION ClearKeypadText ();
        FUNCTION BackspaceKeypadText ();
        FUNCTION SelectSpeedDialEntry ( INTEGER ID );
        FUNCTION DialSpeedDialEntry ();
        FUNCTION SaveSpeedDialEntry ( INTEGER ID , STRING Name , STRING Number );
        FUNCTION ProcessSubscription ( SubscribedResponse response );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DialerConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class DialerStatus 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION IsOffHook ();
        INTEGER_FUNCTION IsAutoAnswerOn ();
        INTEGER_FUNCTION IsRinging ();
        INTEGER_FUNCTION IsDialing ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING LastNumber[];
        STRING CallerIDName[];
        STRING CallerIDNumber[];
    };

     class RouterComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( RouterComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( RouterComponent sender, UInt16EventArgs args );
        EventHandler OnOutputRoutedChange ( RouterComponent sender, UInt16EventArgs args );
        EventHandler OnQuarantineChange ( RouterComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING InstanceTag , STRING RouterType , INTEGER Output );
        FUNCTION UnRegister ();
        FUNCTION RouteInput ( INTEGER Input );
        FUNCTION DerouteInput ( INTEGER Input );
        FUNCTION ToggleInput ( INTEGER Input );
        FUNCTION PollRouter ();
        FUNCTION ProcessSubscription ( SubscribedResponse response );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        RouterConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class PresetComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( PresetComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( PresetComponent sender, UInt16EventArgs args );
        EventHandler OnQuarantineChange ( PresetComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID );
        FUNCTION UnRegister ();
        FUNCTION RecallPreset ( STRING preset );
        FUNCTION ProcessSubscription ( SubscribedResponse response );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class PassThruComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( PassThruComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( PassThruComponent sender, UInt16EventArgs args );
        EventHandler OnResponseChange ( PassThruComponent sender, StringEventArgs args );
        EventHandler OnSubscribedResponseChange ( PassThruComponent sender, StringEventArgs args );
        EventHandler OnQuarantineChange ( PassThruComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID );
        FUNCTION PollMsg ( STRING msg );
        FUNCTION CommandMsg ( STRING msg );
        FUNCTION UnRegister ();
        FUNCTION ProcessSubscription ( SubscribedResponse msg );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class GenericComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( GenericComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( GenericComponent sender, UInt16EventArgs args );
        EventHandler OnDigitalChange ( GenericComponent sender, UInt16EventArgs args );
        EventHandler OnAnalogChangeSigned ( GenericComponent sender, Int16EventArgs args );
        EventHandler OnSerialChange ( GenericComponent sender, StringEventArgs args );
        EventHandler OnQuarantineChange ( GenericComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING InstanceTag , STRING AttributeCode , INTEGER Index1 , INTEGER Index2 , INTEGER SignalType , INTEGER HasSubscription );
        FUNCTION UnRegister ();
        FUNCTION SetDigital ( INTEGER state );
        FUNCTION ToggleDigital ();
        FUNCTION SetAnalog ( SIGNED_INTEGER value );
        FUNCTION SetSerial ( STRING value );
        FUNCTION PollState ();
        FUNCTION ProcessSubscription ( SubscribedResponse response );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ( STRING ClassCode );
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        GenericConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class LevelComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( LevelComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( LevelComponent sender, UInt16EventArgs args );
        EventHandler OnLevelChangeSignedUnscaled ( LevelComponent sender, Int16EventArgs args );
        EventHandler OnLevelChangePercent ( LevelComponent sender, UInt16EventArgs args );
        EventHandler OnLevelTextChange ( LevelComponent sender, StringEventArgs args );
        EventHandler OnQuarantineChange ( LevelComponent sender, UInt16EventArgs args );

        // class functions
        FUNCTION Configure ( INTEGER CommandProcessorID , STRING InstanceTag , STRING LevelType , INTEGER Index1 , INTEGER Index2 , INTEGER LevelStep );
        FUNCTION UnRegister ();
        FUNCTION Raise ();
        FUNCTION Lower ();
        FUNCTION Stop ();
        FUNCTION SetLevel ( SIGNED_INTEGER level );
        FUNCTION SetPercent ( INTEGER percent );
        SIGNED_INTEGER_FUNCTION GetLevel ();
        FUNCTION PollState ();
        FUNCTION ProcessSubscription ( SubscribedResponse response );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LevelConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

namespace BiampTesiraLib3.Model;
        // class declarations
         class SpeedDialItem;
         class CallerID;
         class SpeedDialList;
         class AVCommonEnums;
         class VideoSource;
         class FrameRate;
         class MaxResolution;
         class DeviceConnected;
         class TestPattern;
         class Transition;
         class OSDDuration;
         class VideoFormat;
         class SpeedDialDirectory;
     class SpeedDialItem 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ID;
        STRING Label[];
        STRING Number[];
    };

     class CallerID 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIMPLSHARPSTRING Number[];
        SIMPLSHARPSTRING Name[];
    };

     class SpeedDialList 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Get ( INTEGER ID , BYREF SpeedDialItem item );
        FUNCTION set_Item ( SIGNED_LONG_INTEGER index , SpeedDialItem value );
        FUNCTION Add ( SpeedDialItem item );
        SIGNED_LONG_INTEGER_FUNCTION BinarySearch ( SpeedDialItem item );
        FUNCTION Clear ();
        FUNCTION CopyTo ( SpeedDialItem array[] );
        SIGNED_LONG_INTEGER_FUNCTION IndexOf ( SpeedDialItem item );
        FUNCTION Insert ( SIGNED_LONG_INTEGER index , SpeedDialItem item );
        SIGNED_LONG_INTEGER_FUNCTION LastIndexOf ( SpeedDialItem item );
        FUNCTION RemoveAt ( SIGNED_LONG_INTEGER index );
        FUNCTION RemoveRange ( SIGNED_LONG_INTEGER index , SIGNED_LONG_INTEGER count );
        FUNCTION Reverse ();
        FUNCTION Sort ();
        FUNCTION TrimExcess ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Capacity;
        SIGNED_LONG_INTEGER Count;
    };

     class AVCommonEnums 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class VideoSource // enum
    {
        static SIGNED_LONG_INTEGER VIDEO_SOURCE_HDMI;
        static SIGNED_LONG_INTEGER VIDEO_SOURCE_DISPLAYPORT;
    };

    static class FrameRate // enum
    {
        static SIGNED_LONG_INTEGER fr60Hz_60Hz;
        static SIGNED_LONG_INTEGER fr60Hz_30Hz;
        static SIGNED_LONG_INTEGER fr60Hz_15Hz;
        static SIGNED_LONG_INTEGER fr50Hz_50Hz;
        static SIGNED_LONG_INTEGER fr50Hz_25Hz;
        static SIGNED_LONG_INTEGER fr50Hz_10Hz;
    };

    static class MaxResolution // enum
    {
        static SIGNED_LONG_INTEGER r4096x2160;
        static SIGNED_LONG_INTEGER r3840x2160;
        static SIGNED_LONG_INTEGER r2560x1600;
        static SIGNED_LONG_INTEGER r1920x1200;
        static SIGNED_LONG_INTEGER r1920x1080;
        static SIGNED_LONG_INTEGER r1280x720;
        static SIGNED_LONG_INTEGER r800x600;
        static SIGNED_LONG_INTEGER r1280x800;
    };

    static class DeviceConnected // enum
    {
        static SIGNED_LONG_INTEGER DEVICE_CONNECTED_NONE;
        static SIGNED_LONG_INTEGER DEVICE_CONNECTED_HDMI;
        static SIGNED_LONG_INTEGER DEVICE_CONNECTED_DISPLAYPORT;
        static SIGNED_LONG_INTEGER DEVICE_CONNECTED_BOTH;
    };

    static class TestPattern // enum
    {
        static SIGNED_LONG_INTEGER Off;
        static SIGNED_LONG_INTEGER ColorBar;
        static SIGNED_LONG_INTEGER Grid;
        static SIGNED_LONG_INTEGER HDMI420;
    };

    static class Transition // enum
    {
        static SIGNED_LONG_INTEGER FreezeAndFade;
        static SIGNED_LONG_INTEGER Instant;
    };

    static class OSDDuration // enum
    {
        static SIGNED_LONG_INTEGER OSDOff;
        static SIGNED_LONG_INTEGER OSD5seconds;
        static SIGNED_LONG_INTEGER OSD15seconds;
        static SIGNED_LONG_INTEGER OSDOn;
    };

    static class VideoFormat // enum
    {
        static SIGNED_LONG_INTEGER vfEDIDPreferred;
        static SIGNED_LONG_INTEGER vf4096x2160p60;
        static SIGNED_LONG_INTEGER vf4096x2160p30;
        static SIGNED_LONG_INTEGER vf3840x2160p60;
        static SIGNED_LONG_INTEGER vf3840x2160p30;
        static SIGNED_LONG_INTEGER vf2560x1600p60;
        static SIGNED_LONG_INTEGER vf1920x1200p60;
        static SIGNED_LONG_INTEGER vf1920x1080p60;
        static SIGNED_LONG_INTEGER vf1920x1080p30;
        static SIGNED_LONG_INTEGER vf1280x720p60;
        static SIGNED_LONG_INTEGER vf800x600p60;
        static SIGNED_LONG_INTEGER vf4096x2160p50;
        static SIGNED_LONG_INTEGER vf4096x2160p25;
        static SIGNED_LONG_INTEGER vf3840x2160p50;
        static SIGNED_LONG_INTEGER vf3840x2160p25;
        static SIGNED_LONG_INTEGER vf2560x1600p50;
        static SIGNED_LONG_INTEGER vf1920x1200p50;
        static SIGNED_LONG_INTEGER vf1920x1080p50;
        static SIGNED_LONG_INTEGER vf1920x1080p25;
        static SIGNED_LONG_INTEGER vf1280x720p50;
        static SIGNED_LONG_INTEGER vf800x600p50;
        static SIGNED_LONG_INTEGER vf1280x800p60;
        static SIGNED_LONG_INTEGER vf1280x800p50;
    };

     class SpeedDialDirectory 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        BiampTesiraLib3.Model.SpeedDialList Directory;

        // class properties
    };

namespace BiampTesiraLib3.Comm;
        // class declarations
         class SSHTransportComm;
         class RS232TransportComm;
         class TelnetTransportComm;
     class SSHTransportComm 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetIPAddress ( STRING IPAddress );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class TelnetTransportComm 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetIPAddress ( STRING IPAddress );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace BiampTesiraLib3;
        // class declarations
         class BiampTesira;
     class BiampTesira 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( BiampTesira sender, StringEventArgs args );
        EventHandler OnClientSocketStatus ( BiampTesira sender, UInt16EventArgs args );
        EventHandler OnInitializeChange ( BiampTesira sender, UInt16EventArgs args );
        EventHandler OnCommunicatingChange ( BiampTesira sender, UInt16EventArgs args );
        EventHandler OnRegisteredComponentCountChange ( BiampTesira sender, UInt16EventArgs args );
        EventHandler OnQuarantinedComponentCountChange ( BiampTesira sender, UInt16EventArgs args );
        EventHandler OnRS232Transmit ( BiampTesira sender, StringEventArgs args );

        // class functions
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION Initialize ( INTEGER state );
        FUNCTION Configure ( INTEGER Type , INTEGER CommandProcessorID , STRING IPAddress , STRING Username , STRING Password );
        FUNCTION Reinit ();
        FUNCTION RS232Response ( STRING msg );
        FUNCTION ToDevice ( STRING msg );
        SIGNED_LONG_INTEGER_FUNCTION GetHeartbeatTime ();
        FUNCTION GetInitialized ();
        SIGNED_LONG_INTEGER_FUNCTION GetResponseTime ();
        FUNCTION Reconnect ();
        FUNCTION SendHeartbeat ();
        FUNCTION FailedResponse ();
        FUNCTION Strikeout ();
        FUNCTION sendTrace ( STRING msg );
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        FUNCTION Error ( STRING ErrorMessage );
        FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        BiampTesiraConfigInfo ConfigInfo;
        INTEGER ComponentListenerID;
    };

