namespace BiampTesiraLib3;
        // class declarations
         class TesiraStateAttributes;
         class VoIPDialerConfigInfo;
         class Component;
         class RouterComponent;
         class ProtocolUtil;
         class StringEventArgs;
         class SimplSharpStringEventArgs;
         class AVOutputConfigInfo;
         class VoipCallStatuses;
         class SpeedDialList;
         class ParserUtil;
         class VoipCallStatusesEventArgs;
         class AVInputStateEventArgs;
         class DialerConfigInfo;
         class AVInputConfigInfo;
         class PresetComponent;
         class MessageBundle;
         class AVOutputStateEventArgs;
         class VoipCallStatusStateMap;
         class BiampTesira;
         class SystemCommands;
         class TesiraClassCodes;
         class DialerStatusEventArgs;
         class LevelComponent;
         class SystemInstanceTags;
         class SpeedDialDirectory;
         class TesiraLevelAttributeMap;
         class CallerID;
         class UInt16EventArgs;
         class TesiraProtocolInfo;
         class SubscribedResponse;
         class RequestMsg;
         class RequestMsgAttribute;
         class LevelConfigInfo;
         class GenericConfigInfo;
         class RequestResponse;
         class TesiraLevelAttributes;
         class CallerIDEventArgs;
         class VoipCallStatusPromptMap;
         class StateComponent;
         class VoipDialerStatusEventArgs;
         class SpeedDialItemEventArgs;
         class Int16EventArgs;
         class VoipCallStatus;
         class VoipDialerComponent;
         class VoipDialerStatus;
         class DNDModes;
         class VoipCallStatusList;
         class DialerComponent;
         class DialerStatus;
         class BiampTesiraConfigInfo;
         class TesiraRouterAttributes;
         class ComponentUtil;
         class SpeedDialItem;
         class StateConfigInfo;
         class RouterConfigInfo;
           class AVInputState;
           class AVOutputState;
     class TesiraStateAttributes 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class VoIPDialerConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING DialerInstanceID[];
        STRING ControlStatusInstanceID[];
        INTEGER LineNumber;
    };

     class Component 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION ProcessSubscription ( SubscribedResponse msg );
        FUNCTION Poll ();
        FUNCTION Reinitialize ();
        FUNCTION Refresh ();
        FUNCTION Dispose ();
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class RouterComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( RouterComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( RouterComponent sender, UInt16EventArgs args );
        EventHandler OnOutputRoutedChange ( RouterComponent sender, UInt16EventArgs args );

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        RouterConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class ProtocolUtil 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION EscapeValue ( STRING Value );
        static STRING_FUNCTION CleanInstanceTag ( STRING InstanceTag );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class StringEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIMPLSHARPSTRING Payload[];
    };

     class AVOutputConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Capacity;
        SIGNED_LONG_INTEGER Count;
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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Capacity;
        SIGNED_LONG_INTEGER Count;
    };

     class ParserUtil 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class VoipCallStatusesEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        VoipCallStatuses Payload;
    };

     class AVInputStateEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AVInputState Payload;
    };

     class DialerConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING DialerInstanceID[];
        STRING ControlStatusInstanceID[];
    };

     class AVInputConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
    };

     class PresetComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( PresetComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( PresetComponent sender, UInt16EventArgs args );

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class AVOutputStateEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AVOutputState Payload;
    };

     class VoipCallStatusStateMap 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static VoipCallStatusStateMap INIT;
        static VoipCallStatusStateMap FAULT;
        static VoipCallStatusStateMap IDLE;
        static VoipCallStatusStateMap DIAL_TONE;
        static VoipCallStatusStateMap SILENT;
        static VoipCallStatusStateMap DIALING;
        static VoipCallStatusStateMap RINGBACK;
        static VoipCallStatusStateMap RINGING;
        static VoipCallStatusStateMap BUSY;
        static VoipCallStatusStateMap REJECT;
        static VoipCallStatusStateMap INVALID_NUMBER;
        static VoipCallStatusStateMap ACTIVE;
        static VoipCallStatusStateMap ACTIVE_MUTED;
        static VoipCallStatusStateMap ON_HOLD;
        static VoipCallStatusStateMap WAITING_RING;
        static VoipCallStatusStateMap CONF_ACTIVE;
        static VoipCallStatusStateMap CONF_HOLD;
        static VoipCallStatusStateMap XFER_INIT;
        static VoipCallStatusStateMap XFER_SILENT;
        static VoipCallStatusStateMap XFER_REQ_DIALING;
        static VoipCallStatusStateMap XFER_RINGBACK;
        static VoipCallStatusStateMap XFER_ACTIVE;
        static VoipCallStatusStateMap XFER_WAIT;
        static VoipCallStatusStateMap XFER_DECISION;
        static VoipCallStatusStateMap XFER_INIT_ERROR;
        static VoipCallStatusStateMap XFER_ON_HOLD;
        static VoipCallStatusStateMap XFER_REPLACES_PROCESS;
        static VoipCallStatusStateMap XFER_PROCESS;

        // class properties
        INTEGER Number;
        STRING Name[];
    };

     class BiampTesira 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( BiampTesira sender, StringEventArgs args );
        EventHandler OnClientSocketStatus ( BiampTesira sender, UInt16EventArgs args );
        EventHandler OnInitializeChange ( BiampTesira sender, UInt16EventArgs args );
        EventHandler OnCommunicatingChange ( BiampTesira sender, UInt16EventArgs args );
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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        BiampTesiraConfigInfo ConfigInfo;
        INTEGER ComponentListenerID;
    };

     class SystemCommands 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING GET[];
        static STRING SET[];
        static STRING SUBSCRIBE[];

        // class properties
    };

     class TesiraClassCodes 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class DialerStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DialerStatus Payload;
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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        LevelConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class SystemInstanceTags 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING SESSION[];
        static STRING DEVICE[];

        // class properties
    };

     class SpeedDialDirectory 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        SpeedDialList Directory;

        // class properties
    };

     class TesiraLevelAttributeMap 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static TesiraLevelAttributeMap LEVEL;
        static TesiraLevelAttributeMap INPUTLEVEL;
        static TesiraLevelAttributeMap OUTPUTLEVEL;
        static TesiraLevelAttributeMap LEVELOUT;
        static TesiraLevelAttributeMap LEVELIN;
        static TesiraLevelAttributeMap LEVELSOURCE;
        static TesiraLevelAttributeMap CHANNELLEVEL;
        static TesiraLevelAttributeMap SOURCELEVEL;
        static TesiraLevelAttributeMap CROSSPOINTLEVEL;
        static TesiraLevelAttributeMap HOSTMASTERVOL;
        static TesiraLevelAttributeMap HOSTVOL;
        static TesiraLevelAttributeMap AUXLEVEL;

        // class properties
        STRING LevelAttribute[];
        STRING MinAttribute[];
        STRING MaxAttribute[];
    };

     class CallerID 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIMPLSHARPSTRING Number[];
        SIMPLSHARPSTRING Name[];
    };

     class UInt16EventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Payload;
    };

     class TesiraProtocolInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ID;
        STRING Attribute[];
        STRING Payload[];
        STRING OriginalString[];
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

     class LevelConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class GenericConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class RequestResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Payload[];
        STRING OriginalString[];
    };

     class TesiraLevelAttributes 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class CallerIDEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        CallerID Payload;
    };

     class VoipCallStatusPromptMap 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static VoipCallStatusPromptMap NONE;
        static VoipCallStatusPromptMap STARTING;
        static VoipCallStatusPromptMap REGISTERING;
        static VoipCallStatusPromptMap SIP_USER_NOT_CONFIGURED;
        static VoipCallStatusPromptMap ENTER_NUMBER;
        static VoipCallStatusPromptMap CONNECTING;
        static VoipCallStatusPromptMap INCOMING_CALL_FROM;
        static VoipCallStatusPromptMap PEER_BUSY;
        static VoipCallStatusPromptMap CALL_CANNOT_BE_COMPLETED;
        static VoipCallStatusPromptMap ON_HOLD;
        static VoipCallStatusPromptMap CALL_ON_HELD;
        static VoipCallStatusPromptMap CONFERENCE;
        static VoipCallStatusPromptMap CONFERENCE_ON_HOLD;
        static VoipCallStatusPromptMap CONNECTED;
        static VoipCallStatusPromptMap CONNECTED_MUTED;
        static VoipCallStatusPromptMap AUTH_FAILURE;
        static VoipCallStatusPromptMap PROXY_NOT_CONFIGURED;
        static VoipCallStatusPromptMap NETWORK_INIT;
        static VoipCallStatusPromptMap DHCP_IN_PROGRESS;
        static VoipCallStatusPromptMap NETWORK_LINK_DOWN;
        static VoipCallStatusPromptMap NETWORK_LINK_UP;
        static VoipCallStatusPromptMap IPADDR_CONFLICT;
        static VoipCallStatusPromptMap NETWORK_CONFIGURED;
        static VoipCallStatusPromptMap CODEC_NEGOTIATION_FAILURE;
        static VoipCallStatusPromptMap UNEXPECTED_ERROR;
        static VoipCallStatusPromptMap AUTH_USER_NOT_CONFIGURED;
        static VoipCallStatusPromptMap AUTH_PASSWORD_NOT_CONFIGURED;
        static VoipCallStatusPromptMap DND;
        static VoipCallStatusPromptMap INVALID_NUMBER;
        static VoipCallStatusPromptMap TEMP_UNAVAILABLE;
        static VoipCallStatusPromptMap DECLINED;
        static VoipCallStatusPromptMap SERVICE_UNAVAILABLE;
        static VoipCallStatusPromptMap FORBIDDEN;
        static VoipCallStatusPromptMap BEING_XFER_TO;
        static VoipCallStatusPromptMap XFER_IN_PROCESS;
        static VoipCallStatusPromptMap XFER_TIME_OUT;
        static VoipCallStatusPromptMap PROXY_UNAVAILABLE;

        // class properties
        SIGNED_LONG_INTEGER Number;
        STRING Name[];
    };

     class StateComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( StateComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( StateComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( StateComponent sender, UInt16EventArgs args );

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        StateConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

     class VoipDialerStatusEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        VoipDialerStatus Payload;
    };

     class SpeedDialItemEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SpeedDialItem Payload;
    };

     class Int16EventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_INTEGER Payload;
    };

     class VoipCallStatus 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class VoipDialerComponent 
    {
        // class delegates

        // class events
        EventHandler OnInitializeChange ( VoipDialerComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( VoipDialerComponent sender, VoipDialerStatusEventArgs args );
        EventHandler OnKeypadTextChange ( VoipDialerComponent sender, StringEventArgs args );
        EventHandler OnCallerIDResponse ( VoipDialerComponent sender, CallerIDEventArgs args );
        EventHandler OnSpeedDialItemChange ( VoipDialerComponent sender, SpeedDialItemEventArgs args );
        EventHandler OnCallChange ( VoipDialerComponent sender, UInt16EventArgs args );
        EventHandler OnCallStatusListChange ( VoipDialerComponent sender, VoipCallStatusesEventArgs args );
        EventHandler OnSpeedDialSeletion ( VoipDialerComponent sender, SpeedDialItemEventArgs args );

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class VoipCallStatusList 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        VoipCallStatuses Call;

        // class properties
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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING LastNumber[];
        STRING CallerIDName[];
        STRING CallerIDNumber[];
    };

     class BiampTesiraConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER Type;
        INTEGER CommandProcessorID;
        STRING IPAddress[];
        STRING Username[];
        STRING Password[];
    };

     class TesiraRouterAttributes 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        static STRING INPUT[];
        static STRING SOURCESELECTION[];

        // class properties
    };

     class ComponentUtil 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION Register ( Component me );
        static FUNCTION UnRegister ( Component me );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SpeedDialItem 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER ID;
        STRING Label[];
        STRING Number[];
    };

     class StateConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
        STRING StateType[];
        INTEGER Index1;
        INTEGER Index2;
    };

     class RouterConfigInfo 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER CommandProcessorID;
        STRING InstanceTag[];
        STRING RouterType[];
        INTEGER Output;
    };

namespace BiampTesiraLib3.Parser;
        // class declarations
         class VideoFormatParser;
         class UInt16Parser;
         class OSDDurationParser;
         class BoolParser;
         class FrameRateEnumParser;
         class DeviceConnectedEnumParser;
         class UInt16ArrayParser;
         class BoolArrayParser;
         class ResolutionParser;
         class MaxResolutionEnumParser;
         class VideoSourceEnumParser;
         class TransitionEnumParser;
         class TestPatternEnumParser;
         class DoubleParser;
     class VideoFormatParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class UInt16Parser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class OSDDurationParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class BoolParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class FrameRateEnumParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DeviceConnectedEnumParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class UInt16ArrayParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class BoolArrayParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class MaxResolutionEnumParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class VideoSourceEnumParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class TransitionEnumParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class TestPatternEnumParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class DoubleParser 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace BiampTesiraLib3.Components;
        // class declarations
         class AVOutputComponent;
         class AVOutputState;
         class AVInputComponent;
         class AVInputState;
         class PassThruComponent;
         class GenericComponent;
     class AVOutputComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( AVOutputComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( AVOutputComponent sender, UInt16EventArgs args );
        EventHandler OnStateChange ( AVOutputComponent sender, AVOutputStateEventArgs args );

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

     class PassThruComponent 
    {
        // class delegates

        // class events
        EventHandler OnSendDebug ( PassThruComponent sender, StringEventArgs args );
        EventHandler OnInitializeChange ( PassThruComponent sender, UInt16EventArgs args );
        EventHandler OnResponseChange ( PassThruComponent sender, StringEventArgs args );
        EventHandler OnSubscribedResponseChange ( PassThruComponent sender, StringEventArgs args );

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
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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
        FUNCTION GetInitialized ();
        FUNCTION ProcessResponse ( RequestMsg requestMsg , RequestResponse response );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        GenericConfigInfo ConfigInfo;
        SIGNED_LONG_INTEGER ID;
        INTEGER CommandProcessorID;
    };

namespace BiampTesiraLib3.Comm;
        // class declarations
         class TelnetTransportComm;
         class RS232TransportComm;
         class SSHTransportComm;
     class TelnetTransportComm 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetIPAddress ( STRING IPAddress );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION Dispose ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SSHTransportComm 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetIPAddress ( STRING IPAddress );
        FUNCTION Connect ();
        FUNCTION Disconnect ();
        FUNCTION Dispose ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace BiampTesiraLib3.Model;
        // class declarations
         class AVCommonEnums;
         class VideoSource;
         class FrameRate;
         class MaxResolution;
         class DeviceConnected;
         class TestPattern;
         class Transition;
         class OSDDuration;
         class VideoFormat;
     class AVCommonEnums 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

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

namespace BiampTesiraLib3.Tesira_Support;
        // class declarations
         class SubscriptionManager;
         class SubscriptionWatchdogPayload;
     class SubscriptionWatchdogPayload 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER ID;
        TesiraProtocolInfo Info;
    };

namespace BiampTesiraLib3.CCI_Support;
        // class declarations

