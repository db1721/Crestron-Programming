namespace Crestron.DeviceDrivers.Core;
        // class declarations
         class ConsoleCommandsSupport;
         class ChannelConstants;
         class ColorConstants;
         class DvrConstants;
         class KeypadConstants;
         class LetterKeyConstants;
         class MediaSourceConstants;
         class MediaTransportConstants;
         class NavigationConstants;
         class Driver;
         class DriverConfigFile;
         class WrapperUtils;
           class BasicInformation;
    static class ChannelConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ChannelDown[];
        static STRING ChannelUp[];
        static STRING Guide[];
        static STRING PageDown[];
        static STRING PageUp[];

        // class properties
    };

    static class ColorConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Blue[];
        static STRING Green[];
        static STRING Red[];
        static STRING Yellow[];

        // class properties
    };

    static class DvrConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Command[];
        static STRING Live[];
        static STRING Record[];
        static STRING SpeedSlow[];
        static STRING ThumbsUp[];
        static STRING ThumbsDown[];

        // class properties
    };

    static class KeypadConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Keypress0[];
        static STRING Keypress1[];
        static STRING Keypress2[];
        static STRING Keypress3[];
        static STRING Keypress4[];
        static STRING Keypress5[];
        static STRING Keypress6[];
        static STRING Keypress7[];
        static STRING Keypress8[];
        static STRING Keypress9[];
        static STRING KeypressDash[];
        static STRING KeypressPeriod[];
        static STRING KeypressAsterisk[];
        static STRING KeypressPound[];
        static STRING KeypressBackSpace[];
        static STRING KeypressEnter[];

        // class properties
    };

    static class LetterKeyConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING A[];
        static STRING B[];
        static STRING C[];
        static STRING D[];

        // class properties
    };

    static class MediaSourceConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Airplay[];
        static STRING Amazon[];
        static STRING AmazonVideo[];
        static STRING Bluetooth[];
        static STRING Browser[];
        static STRING Crackle[];
        static STRING Deezer[];
        static STRING DirecTv[];
        static STRING DirecTvNow[];
        static STRING Disney[];
        static STRING Dlna[];
        static STRING GoogleCast[];
        static STRING GooglePlay[];
        static STRING HboGo[];
        static STRING HdRadio[];
        static STRING Hulu[];
        static STRING InternetRadio[];
        static STRING LastFm[];
        static STRING Music[];
        static STRING Netflix[];
        static STRING OnDemand[];
        static STRING Pandora[];
        static STRING PandoraRadio[];
        static STRING PhotoVideo[];
        static STRING PlaystationVue[];
        static STRING Rhapsody[];
        static STRING Showtime[];
        static STRING Sirius[];
        static STRING SiriusXm[];
        static STRING SlingTv[];
        static STRING Spotify[];
        static STRING Tidal[];
        static STRING TvTuner[];
        static STRING Vudu[];
        static STRING Xm[];
        static STRING XmRadio[];
        static STRING XmSatelliteRadio[];
        static STRING YouTube[];
        static STRING YouTubeTv[];

        // class properties
    };

    static class MediaTransportConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING ForwardScan[];
        static STRING ReverseScan[];
        static STRING Play[];
        static STRING Pause[];
        static STRING Stop[];
        static STRING ForwardSkip[];
        static STRING ReverseSkip[];
        static STRING Repeat[];
        static STRING Return[];
        static STRING Back[];
        static STRING PlayPause[];
        static STRING Info[];
        static STRING Options[];

        // class properties
    };

    static class NavigationConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING Clear[];
        static STRING Exit[];
        static STRING Home[];
        static STRING Menu[];
        static STRING Search[];
        static STRING Select[];
        static STRING Up[];
        static STRING Down[];
        static STRING Left[];
        static STRING Right[];

        // class properties
    };

     class DriverConfigFile 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FileName[];

        // class properties
    };

     class WrapperUtils 
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

namespace Crestron.DeviceDrivers.Core.SupportedFeatures;
        // class declarations
         class ArtworkSupportedFeatureInfo;
         class ArtworkSupportedFeatureInfoTypeFactory;
         class AudioSupportedFeatureInfo;
         class AudioSupportedFeatureInfoTypeFactory;
         class AudioVideoExtenderSupportedFeatureInfo;
         class AudioVideoExtenderSupportedFeatureInfoTypeFactory;
         class AudioVideoSwitchingCapabilitiesSupportedFeatureInfo;
         class AudioVideoSwitchingCapabilitiesSupportedFeatureInfoTypeFactory;
         class AuthenticationSupportedFeatureInfo;
         class AuthenticationSupportedFeatureInfoTypeFactory;
         class AvrZoneSupportedFeatureInfo;
         class AvrZoneSupportedFeatureInfoTypeFactory;
         class BasicBlurayPlayerSupportedFeatureInfo;
         class BasicBlurayPlayerSupportedFeatureInfoTypeFactory;
         class BasicCableBoxSupportedFeatureInfo;
         class BasicCableBoxSupportedFeatureInfoTypeFactory;
         class BasicCodecSupportedFeatureInfo;
         class BasicCodecSupportedFeatureInfoTypeFactory;
         class BasicInformationSupportedFeatureInfo;
         class BasicInformationSupportedFeatureInfoTypeFactory;
         class BasicVideoDisplaySupportedFeatureInfo;
         class BasicVideoDisplaySupportedFeatureInfoTypeFactory;
         class BasicVideoServerSupportedFeatureInfo;
         class BasicVideoServerSupportedFeatureInfoTypeFactory;
         class CameraControlSupportedFeatureInfo;
         class CameraControlSupportedFeatureInfoTypeFactory;
         class ChannelSupportedFeatureInfo;
         class ChannelSupportedFeatureInfoTypeFactory;
         class CodecCameraSupportedFeatureInfo;
         class CodecCameraSupportedFeatureInfoTypeFactory;
         class CodecControlSupportedFeatureInfo;
         class CodecControlSupportedFeatureInfoTypeFactory;
         class CodecMeetingControlsSupportedFeatureInfo;
         class CodecMeetingControlsSupportedFeatureInfoTypeFactory;
         class CodecVideoControlSupportedFeatureInfo;
         class CodecVideoControlSupportedFeatureInfoTypeFactory;
         class ColorKeysSupportedFeatureInfo;
         class ColorKeysSupportedFeatureInfoTypeFactory;
         class ComPortSupportedFeatureInfo;
         class ComPortSupportedFeatureInfoTypeFactory;
         class ConferenceCallSupportedFeatureInfo;
         class ConferenceCallSupportedFeatureInfoTypeFactory;
         class ConfigurableDeviceSupportedFeatureInfo;
         class ConfigurableDeviceSupportedFeatureInfoTypeFactory;
         class ConnectionSupportedFeatureInfo;
         class ConnectionSupportedFeatureInfoTypeFactory;
         class CustomCommandCollectionSupportedFeatureInfo;
         class CustomCommandCollectionSupportedFeatureInfoTypeFactory;
         class DevicePresetSupportedFeatureInfo;
         class DevicePresetSupportedFeatureInfoTypeFactory;
         class DeviceSceneSupportedFeatureInfo;
         class DeviceSceneSupportedFeatureInfoTypeFactory;
         class DeviceVersioningSupportedFeatureInfo;
         class DeviceVersioningSupportedFeatureInfoTypeFactory;
         class DvrSupportedFeatureInfo;
         class DvrSupportedFeatureInfoTypeFactory;
         class EmulatedSecuritySystemKeypadSupportedFeatureInfo;
         class EmulatedSecuritySystemKeypadSupportedFeatureInfoTypeFactory;
         class EnergyStarSupportedFeatureInfo;
         class EnergyStarSupportedFeatureInfoTypeFactory;
         class FeedbackInformationSupportedFeatureInfo;
         class FeedbackInformationSupportedFeatureInfoTypeFactory;
         class HardwareDiagnosticsSupportedFeatureInfo;
         class HardwareDiagnosticsSupportedFeatureInfoTypeFactory;
         class InputsSupportedFeatureInfo;
         class InputsSupportedFeatureInfoTypeFactory;
         class KeypadSupportedFeatureInfo;
         class KeypadSupportedFeatureInfoTypeFactory;
         class LampHoursSupportedFeatureInfo;
         class LampHoursSupportedFeatureInfoTypeFactory;
         class MediaServiceProviderSupportedFeatureInfo;
         class MediaServiceProviderSupportedFeatureInfoTypeFactory;
         class MediaSourceSupportedFeatureInfo;
         class MediaSourceSupportedFeatureInfoTypeFactory;
         class MediaTransportInfoSupportedFeatureInfo;
         class MediaTransportInfoSupportedFeatureInfoTypeFactory;
         class MediaTransportOptionsSupportedFeatureInfo;
         class MediaTransportOptionsSupportedFeatureInfoTypeFactory;
         class MediaTransportSupportedFeatureInfo;
         class MediaTransportSupportedFeatureInfoTypeFactory;
         class NavigationSupportedFeatureInfo;
         class NavigationSupportedFeatureInfoTypeFactory;
         class OutputsSupportedFeatureInfo;
         class OutputsSupportedFeatureInfoTypeFactory;
         class PowerSupportedFeatureInfo;
         class PowerSupportedFeatureInfoTypeFactory;
         class SecurityDeviceLoggingSupportedFeatureInfo;
         class SecurityDeviceLoggingSupportedFeatureInfoTypeFactory;
         class SecurityResourceControlSupportedFeatureInfo;
         class SecurityResourceControlSupportedFeatureInfoTypeFactory;
         class SpeakerProtectSupportedFeatureInfo;
         class SpeakerProtectSupportedFeatureInfoTypeFactory;
         class SurroundSupportedFeatureInfo;
         class SurroundSupportedFeatureInfoTypeFactory;
         class SwitchingSupportedFeatureInfo;
         class SwitchingSupportedFeatureInfoTypeFactory;
         class TcpSupportedFeatureInfo;
         class TcpSupportedFeatureInfoTypeFactory;
         class TunerSupportedFeatureInfo;
         class TunerSupportedFeatureInfoTypeFactory;
         class VideoConfigurationSupportedFeatureInfo;
         class VideoConfigurationSupportedFeatureInfoTypeFactory;
         class VideoMuteSupportedFeatureInfo;
         class VideoMuteSupportedFeatureInfoTypeFactory;
         class VolumeSupportedFeatureInfo;
         class VolumeSupportedFeatureInfoTypeFactory;
     class ArtworkSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class ArtworkSupportedFeatureInfoTypeFactory 
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

     class AudioSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class AudioSupportedFeatureInfoTypeFactory 
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

     class AudioVideoExtenderSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class AudioVideoExtenderSupportedFeatureInfoTypeFactory 
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

     class AudioVideoSwitchingCapabilitiesSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class AudioVideoSwitchingCapabilitiesSupportedFeatureInfoTypeFactory 
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

     class AuthenticationSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class AuthenticationSupportedFeatureInfoTypeFactory 
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

     class AvrZoneSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class AvrZoneSupportedFeatureInfoTypeFactory 
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

     class BasicBlurayPlayerSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class BasicBlurayPlayerSupportedFeatureInfoTypeFactory 
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

     class BasicCableBoxSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class BasicCableBoxSupportedFeatureInfoTypeFactory 
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

     class BasicCodecSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class BasicCodecSupportedFeatureInfoTypeFactory 
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

     class BasicInformationSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class BasicInformationSupportedFeatureInfoTypeFactory 
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

     class BasicVideoDisplaySupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class BasicVideoDisplaySupportedFeatureInfoTypeFactory 
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

     class BasicVideoServerSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class BasicVideoServerSupportedFeatureInfoTypeFactory 
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

     class CameraControlSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class CameraControlSupportedFeatureInfoTypeFactory 
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

     class ChannelSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class ChannelSupportedFeatureInfoTypeFactory 
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

     class CodecCameraSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class CodecCameraSupportedFeatureInfoTypeFactory 
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

     class CodecControlSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class CodecControlSupportedFeatureInfoTypeFactory 
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

     class CodecMeetingControlsSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class CodecMeetingControlsSupportedFeatureInfoTypeFactory 
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

     class CodecVideoControlSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class CodecVideoControlSupportedFeatureInfoTypeFactory 
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

     class ColorKeysSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class ColorKeysSupportedFeatureInfoTypeFactory 
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

     class ComPortSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class ComPortSupportedFeatureInfoTypeFactory 
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

     class ConferenceCallSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class ConferenceCallSupportedFeatureInfoTypeFactory 
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

     class ConfigurableDeviceSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class ConfigurableDeviceSupportedFeatureInfoTypeFactory 
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

     class ConnectionSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class ConnectionSupportedFeatureInfoTypeFactory 
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

     class CustomCommandCollectionSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class CustomCommandCollectionSupportedFeatureInfoTypeFactory 
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

     class DevicePresetSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class DevicePresetSupportedFeatureInfoTypeFactory 
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

     class DeviceSceneSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class DeviceSceneSupportedFeatureInfoTypeFactory 
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

     class DeviceVersioningSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class DeviceVersioningSupportedFeatureInfoTypeFactory 
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

     class DvrSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class DvrSupportedFeatureInfoTypeFactory 
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

     class EmulatedSecuritySystemKeypadSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class EmulatedSecuritySystemKeypadSupportedFeatureInfoTypeFactory 
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

     class EnergyStarSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class EnergyStarSupportedFeatureInfoTypeFactory 
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

     class FeedbackInformationSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class FeedbackInformationSupportedFeatureInfoTypeFactory 
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

     class HardwareDiagnosticsSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class HardwareDiagnosticsSupportedFeatureInfoTypeFactory 
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

     class InputsSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class InputsSupportedFeatureInfoTypeFactory 
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

     class KeypadSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class KeypadSupportedFeatureInfoTypeFactory 
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

     class LampHoursSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class LampHoursSupportedFeatureInfoTypeFactory 
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

     class MediaServiceProviderSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class MediaServiceProviderSupportedFeatureInfoTypeFactory 
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

     class MediaSourceSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class MediaSourceSupportedFeatureInfoTypeFactory 
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

     class MediaTransportInfoSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class MediaTransportInfoSupportedFeatureInfoTypeFactory 
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

     class MediaTransportOptionsSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class MediaTransportOptionsSupportedFeatureInfoTypeFactory 
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

     class MediaTransportSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class MediaTransportSupportedFeatureInfoTypeFactory 
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

     class NavigationSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class NavigationSupportedFeatureInfoTypeFactory 
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

     class OutputsSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class OutputsSupportedFeatureInfoTypeFactory 
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

     class PowerSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class PowerSupportedFeatureInfoTypeFactory 
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

     class SecurityDeviceLoggingSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class SecurityDeviceLoggingSupportedFeatureInfoTypeFactory 
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

     class SecurityResourceControlSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class SecurityResourceControlSupportedFeatureInfoTypeFactory 
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

     class SpeakerProtectSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class SpeakerProtectSupportedFeatureInfoTypeFactory 
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

     class SurroundSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class SurroundSupportedFeatureInfoTypeFactory 
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

     class SwitchingSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class SwitchingSupportedFeatureInfoTypeFactory 
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

     class TcpSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
        SIGNED_LONG_INTEGER Port;
    };

     class TcpSupportedFeatureInfoTypeFactory 
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

     class TunerSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class TunerSupportedFeatureInfoTypeFactory 
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

     class VideoConfigurationSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class VideoConfigurationSupportedFeatureInfoTypeFactory 
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

     class VideoMuteSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class VideoMuteSupportedFeatureInfoTypeFactory 
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

     class VolumeSupportedFeatureInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING FeatureName[];

        // class properties
    };

     class VolumeSupportedFeatureInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.Core.LegacyWrappers;
        // class declarations
         class CapabilityDriverWrapper;
         class DisplayWrapper;
         class TransportDriverWrapper;
         class DisplayWrapperTcp;

namespace Crestron.DeviceDrivers.Core.InputOutput;
        // class declarations
         class CustomMediaServiceIdInfo;
         class CustomMediaServiceIdInfoTypeFactory;
         class MediaServiceInfoBase;
         class CustomMediaServiceInfo;
         class CustomMediaServiceInfoTypeFactory;
         class AvConnectionType;
         class AvInputOutputType;
         class StandardMediaService;
         class InputOutputUtils;
         class MediaServiceDefaultsInfo;
         class MediaServiceDefaultsInfoTypeFactory;
         class Feature;
         class MediaServiceInfo;
         class MediaServiceInfoTypeFactory;
         class PhysicalAvConnectorInfo;
         class PhysicalAvInputInfo;
         class PhysicalAvInputInfoTypeFactory;
         class PhysicalAvOutputInfo;
         class PhysicalAvOutputInfoTypeFactory;
     class CustomMediaServiceIdInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        STRING Id[];
    };

     class CustomMediaServiceIdInfoTypeFactory 
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

     class MediaServiceInfoBase 
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

     class CustomMediaServiceInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        STRING Id[];
    };

     class CustomMediaServiceInfoTypeFactory 
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

    static class AvConnectionType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Vga;
        static SIGNED_LONG_INTEGER Hdmi;
        static SIGNED_LONG_INTEGER Component;
        static SIGNED_LONG_INTEGER Composite;
        static SIGNED_LONG_INTEGER DisplayPort;
        static SIGNED_LONG_INTEGER Network;
        static SIGNED_LONG_INTEGER Antenna;
        static SIGNED_LONG_INTEGER Usb;
        static SIGNED_LONG_INTEGER Dvi;
        static SIGNED_LONG_INTEGER SVideo;
        static SIGNED_LONG_INTEGER Other;
        static SIGNED_LONG_INTEGER HdBaseT;
        static SIGNED_LONG_INTEGER Universal;
        static SIGNED_LONG_INTEGER GenericAV;
        static SIGNED_LONG_INTEGER GenericVideo;
        static SIGNED_LONG_INTEGER Optical;
        static SIGNED_LONG_INTEGER Coax;
        static SIGNED_LONG_INTEGER Analog;
        static SIGNED_LONG_INTEGER Speaker;
        static SIGNED_LONG_INTEGER GenericAudio;
    };

    static class AvInputOutputType // enum
    {
        static SIGNED_LONG_INTEGER Unknown;
        static SIGNED_LONG_INTEGER Uncontrolled;
        static SIGNED_LONG_INTEGER AnalogAudio1;
        static SIGNED_LONG_INTEGER AnalogAudio10;
        static SIGNED_LONG_INTEGER AnalogAudio2;
        static SIGNED_LONG_INTEGER AnalogAudio3;
        static SIGNED_LONG_INTEGER AnalogAudio4;
        static SIGNED_LONG_INTEGER AnalogAudio5;
        static SIGNED_LONG_INTEGER AnalogAudio6;
        static SIGNED_LONG_INTEGER AnalogAudio7;
        static SIGNED_LONG_INTEGER AnalogAudio8;
        static SIGNED_LONG_INTEGER AnalogAudio9;
        static SIGNED_LONG_INTEGER Antenna1;
        static SIGNED_LONG_INTEGER Antenna2;
        static SIGNED_LONG_INTEGER Aux1;
        static SIGNED_LONG_INTEGER Aux2;
        static SIGNED_LONG_INTEGER Bd1;
        static SIGNED_LONG_INTEGER Catv1;
        static SIGNED_LONG_INTEGER Cd1;
        static SIGNED_LONG_INTEGER Coax1;
        static SIGNED_LONG_INTEGER Coax10;
        static SIGNED_LONG_INTEGER Coax2;
        static SIGNED_LONG_INTEGER Coax3;
        static SIGNED_LONG_INTEGER Coax4;
        static SIGNED_LONG_INTEGER Coax5;
        static SIGNED_LONG_INTEGER Coax6;
        static SIGNED_LONG_INTEGER Coax7;
        static SIGNED_LONG_INTEGER Coax8;
        static SIGNED_LONG_INTEGER Coax9;
        static SIGNED_LONG_INTEGER Component1;
        static SIGNED_LONG_INTEGER Component10;
        static SIGNED_LONG_INTEGER Component2;
        static SIGNED_LONG_INTEGER Component3;
        static SIGNED_LONG_INTEGER Component4;
        static SIGNED_LONG_INTEGER Component5;
        static SIGNED_LONG_INTEGER Component6;
        static SIGNED_LONG_INTEGER Component7;
        static SIGNED_LONG_INTEGER Component8;
        static SIGNED_LONG_INTEGER Component9;
        static SIGNED_LONG_INTEGER Composite1;
        static SIGNED_LONG_INTEGER Composite10;
        static SIGNED_LONG_INTEGER Composite2;
        static SIGNED_LONG_INTEGER Composite3;
        static SIGNED_LONG_INTEGER Composite4;
        static SIGNED_LONG_INTEGER Composite5;
        static SIGNED_LONG_INTEGER Composite6;
        static SIGNED_LONG_INTEGER Composite7;
        static SIGNED_LONG_INTEGER Composite8;
        static SIGNED_LONG_INTEGER Composite9;
        static SIGNED_LONG_INTEGER DisplayPort1;
        static SIGNED_LONG_INTEGER DisplayPort10;
        static SIGNED_LONG_INTEGER DisplayPort2;
        static SIGNED_LONG_INTEGER DisplayPort3;
        static SIGNED_LONG_INTEGER DisplayPort4;
        static SIGNED_LONG_INTEGER DisplayPort5;
        static SIGNED_LONG_INTEGER DisplayPort6;
        static SIGNED_LONG_INTEGER DisplayPort7;
        static SIGNED_LONG_INTEGER DisplayPort8;
        static SIGNED_LONG_INTEGER DisplayPort9;
        static SIGNED_LONG_INTEGER Dss1;
        static SIGNED_LONG_INTEGER Dvd1;
        static SIGNED_LONG_INTEGER Dvi1;
        static SIGNED_LONG_INTEGER Dvi10;
        static SIGNED_LONG_INTEGER Dvi2;
        static SIGNED_LONG_INTEGER Dvi3;
        static SIGNED_LONG_INTEGER Dvi4;
        static SIGNED_LONG_INTEGER Dvi5;
        static SIGNED_LONG_INTEGER Dvi6;
        static SIGNED_LONG_INTEGER Dvi7;
        static SIGNED_LONG_INTEGER Dvi8;
        static SIGNED_LONG_INTEGER Dvi9;
        static SIGNED_LONG_INTEGER Game1;
        static SIGNED_LONG_INTEGER Hdmi1;
        static SIGNED_LONG_INTEGER Hdmi10;
        static SIGNED_LONG_INTEGER Hdmi2;
        static SIGNED_LONG_INTEGER Hdmi3;
        static SIGNED_LONG_INTEGER Hdmi4;
        static SIGNED_LONG_INTEGER Hdmi5;
        static SIGNED_LONG_INTEGER Hdmi6;
        static SIGNED_LONG_INTEGER Hdmi7;
        static SIGNED_LONG_INTEGER Hdmi8;
        static SIGNED_LONG_INTEGER Hdmi9;
        static SIGNED_LONG_INTEGER Input1;
        static SIGNED_LONG_INTEGER Input2;
        static SIGNED_LONG_INTEGER Input3;
        static SIGNED_LONG_INTEGER Input4;
        static SIGNED_LONG_INTEGER Input5;
        static SIGNED_LONG_INTEGER Input6;
        static SIGNED_LONG_INTEGER Input7;
        static SIGNED_LONG_INTEGER Input8;
        static SIGNED_LONG_INTEGER Input9;
        static SIGNED_LONG_INTEGER Input10;
        static SIGNED_LONG_INTEGER Input11;
        static SIGNED_LONG_INTEGER Input12;
        static SIGNED_LONG_INTEGER Input13;
        static SIGNED_LONG_INTEGER Input14;
        static SIGNED_LONG_INTEGER Input15;
        static SIGNED_LONG_INTEGER Input16;
        static SIGNED_LONG_INTEGER Input17;
        static SIGNED_LONG_INTEGER Input18;
        static SIGNED_LONG_INTEGER Input19;
        static SIGNED_LONG_INTEGER Input20;
        static SIGNED_LONG_INTEGER Input21;
        static SIGNED_LONG_INTEGER Input22;
        static SIGNED_LONG_INTEGER Input23;
        static SIGNED_LONG_INTEGER Input24;
        static SIGNED_LONG_INTEGER Input25;
        static SIGNED_LONG_INTEGER Input26;
        static SIGNED_LONG_INTEGER Input27;
        static SIGNED_LONG_INTEGER Input28;
        static SIGNED_LONG_INTEGER Input29;
        static SIGNED_LONG_INTEGER Input30;
        static SIGNED_LONG_INTEGER Input31;
        static SIGNED_LONG_INTEGER Input32;
        static SIGNED_LONG_INTEGER Input33;
        static SIGNED_LONG_INTEGER Input34;
        static SIGNED_LONG_INTEGER Input35;
        static SIGNED_LONG_INTEGER Input36;
        static SIGNED_LONG_INTEGER Input37;
        static SIGNED_LONG_INTEGER Input38;
        static SIGNED_LONG_INTEGER Input39;
        static SIGNED_LONG_INTEGER Input40;
        static SIGNED_LONG_INTEGER Input41;
        static SIGNED_LONG_INTEGER Input42;
        static SIGNED_LONG_INTEGER Input43;
        static SIGNED_LONG_INTEGER Input44;
        static SIGNED_LONG_INTEGER Input45;
        static SIGNED_LONG_INTEGER Input46;
        static SIGNED_LONG_INTEGER Input47;
        static SIGNED_LONG_INTEGER Input48;
        static SIGNED_LONG_INTEGER Input49;
        static SIGNED_LONG_INTEGER Input50;
        static SIGNED_LONG_INTEGER Ipod1;
        static SIGNED_LONG_INTEGER MediaPlayer1;
        static SIGNED_LONG_INTEGER Network1;
        static SIGNED_LONG_INTEGER Network10;
        static SIGNED_LONG_INTEGER Network2;
        static SIGNED_LONG_INTEGER Network3;
        static SIGNED_LONG_INTEGER Network4;
        static SIGNED_LONG_INTEGER Network5;
        static SIGNED_LONG_INTEGER Network6;
        static SIGNED_LONG_INTEGER Network7;
        static SIGNED_LONG_INTEGER Network8;
        static SIGNED_LONG_INTEGER Network9;
        static SIGNED_LONG_INTEGER Optical1;
        static SIGNED_LONG_INTEGER Optical10;
        static SIGNED_LONG_INTEGER Optical2;
        static SIGNED_LONG_INTEGER Optical3;
        static SIGNED_LONG_INTEGER Optical4;
        static SIGNED_LONG_INTEGER Optical5;
        static SIGNED_LONG_INTEGER Optical6;
        static SIGNED_LONG_INTEGER Optical7;
        static SIGNED_LONG_INTEGER Optical8;
        static SIGNED_LONG_INTEGER Optical9;
        static SIGNED_LONG_INTEGER Pc1;
        static SIGNED_LONG_INTEGER Phono1;
        static SIGNED_LONG_INTEGER Sat1;
        static SIGNED_LONG_INTEGER Speaker1;
        static SIGNED_LONG_INTEGER Speaker10;
        static SIGNED_LONG_INTEGER Speaker11;
        static SIGNED_LONG_INTEGER Speaker12;
        static SIGNED_LONG_INTEGER Speaker13;
        static SIGNED_LONG_INTEGER Speaker14;
        static SIGNED_LONG_INTEGER Speaker15;
        static SIGNED_LONG_INTEGER Speaker2;
        static SIGNED_LONG_INTEGER Speaker3;
        static SIGNED_LONG_INTEGER Speaker4;
        static SIGNED_LONG_INTEGER Speaker5;
        static SIGNED_LONG_INTEGER Speaker6;
        static SIGNED_LONG_INTEGER Speaker7;
        static SIGNED_LONG_INTEGER Speaker8;
        static SIGNED_LONG_INTEGER Speaker9;
        static SIGNED_LONG_INTEGER Tuner1;
        static SIGNED_LONG_INTEGER Tv1;
        static SIGNED_LONG_INTEGER Usb1;
        static SIGNED_LONG_INTEGER Usb2;
        static SIGNED_LONG_INTEGER Usb3;
        static SIGNED_LONG_INTEGER Usb4;
        static SIGNED_LONG_INTEGER Usb5;
        static SIGNED_LONG_INTEGER Vga1;
        static SIGNED_LONG_INTEGER Vga10;
        static SIGNED_LONG_INTEGER Vga2;
        static SIGNED_LONG_INTEGER Vga3;
        static SIGNED_LONG_INTEGER Vga4;
        static SIGNED_LONG_INTEGER Vga5;
        static SIGNED_LONG_INTEGER Vga6;
        static SIGNED_LONG_INTEGER Vga7;
        static SIGNED_LONG_INTEGER Vga8;
        static SIGNED_LONG_INTEGER Vga9;
    };

    static class StandardMediaService // enum
    {
        static SIGNED_LONG_INTEGER Airplay;
        static SIGNED_LONG_INTEGER Amazon;
        static SIGNED_LONG_INTEGER AmazonVideo;
        static SIGNED_LONG_INTEGER Bluetooth;
        static SIGNED_LONG_INTEGER Browser;
        static SIGNED_LONG_INTEGER Crackle;
        static SIGNED_LONG_INTEGER Deezer;
        static SIGNED_LONG_INTEGER DirecTv;
        static SIGNED_LONG_INTEGER DirecTvNow;
        static SIGNED_LONG_INTEGER Disney;
        static SIGNED_LONG_INTEGER Dlna;
        static SIGNED_LONG_INTEGER GoogleCast;
        static SIGNED_LONG_INTEGER GooglePlay;
        static SIGNED_LONG_INTEGER HboGo;
        static SIGNED_LONG_INTEGER HdRadio;
        static SIGNED_LONG_INTEGER Hulu;
        static SIGNED_LONG_INTEGER InternetRadio;
        static SIGNED_LONG_INTEGER LastFm;
        static SIGNED_LONG_INTEGER Music;
        static SIGNED_LONG_INTEGER Netflix;
        static SIGNED_LONG_INTEGER OnDemand;
        static SIGNED_LONG_INTEGER Pandora;
        static SIGNED_LONG_INTEGER PandoraRadio;
        static SIGNED_LONG_INTEGER PhotoVideo;
        static SIGNED_LONG_INTEGER PlaystationVue;
        static SIGNED_LONG_INTEGER Rhapsody;
        static SIGNED_LONG_INTEGER Showtime;
        static SIGNED_LONG_INTEGER Sirius;
        static SIGNED_LONG_INTEGER SiriusXm;
        static SIGNED_LONG_INTEGER SlingTv;
        static SIGNED_LONG_INTEGER Spotify;
        static SIGNED_LONG_INTEGER Tidal;
        static SIGNED_LONG_INTEGER TvTuner;
        static SIGNED_LONG_INTEGER Vudu;
        static SIGNED_LONG_INTEGER Xm;
        static SIGNED_LONG_INTEGER XmRadio;
        static SIGNED_LONG_INTEGER XmSatelliteRadio;
        static SIGNED_LONG_INTEGER YouTube;
        static SIGNED_LONG_INTEGER YouTubeTv;
    };

    static class InputOutputUtils 
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

     class MediaServiceDefaultsInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
    };

     class MediaServiceDefaultsInfoTypeFactory 
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

    static class Feature // enum
    {
        static SIGNED_LONG_INTEGER SupportsForwardScan;
        static SIGNED_LONG_INTEGER SupportsReverseScan;
        static SIGNED_LONG_INTEGER SupportsPlay;
        static SIGNED_LONG_INTEGER SupportsPause;
        static SIGNED_LONG_INTEGER SupportsStop;
        static SIGNED_LONG_INTEGER SupportsForwardSkip;
        static SIGNED_LONG_INTEGER SupportsReverseSkip;
        static SIGNED_LONG_INTEGER SupportsRepeat;
        static SIGNED_LONG_INTEGER SupportsReturn;
        static SIGNED_LONG_INTEGER SupportsBack;
        static SIGNED_LONG_INTEGER SupportsPlayPause;
        static SIGNED_LONG_INTEGER SupportsInfo;
        static SIGNED_LONG_INTEGER SupportsOptions;
        static SIGNED_LONG_INTEGER SupportsArrowKeys;
        static SIGNED_LONG_INTEGER SupportsSelect;
        static SIGNED_LONG_INTEGER SupportsClear;
        static SIGNED_LONG_INTEGER SupportsExit;
        static SIGNED_LONG_INTEGER SupportsHome;
        static SIGNED_LONG_INTEGER SupportsMenu;
        static SIGNED_LONG_INTEGER SupportsSearch;
        static SIGNED_LONG_INTEGER SupportsUpDown;
        static SIGNED_LONG_INTEGER SupportsLeftRight;
        static SIGNED_LONG_INTEGER SupportsChannelFeedback;
        static SIGNED_LONG_INTEGER SupportsChangeChannel;
        static SIGNED_LONG_INTEGER SupportsSetChannel;
        static SIGNED_LONG_INTEGER SupportsGuide;
        static SIGNED_LONG_INTEGER SupportsPageChange;
        static SIGNED_LONG_INTEGER SupportsKeypadNumber;
        static SIGNED_LONG_INTEGER SupportsEnter;
        static SIGNED_LONG_INTEGER SupportsPound;
        static SIGNED_LONG_INTEGER SupportsAsterisk;
        static SIGNED_LONG_INTEGER SupportsPeriod;
        static SIGNED_LONG_INTEGER SupportsDash;
        static SIGNED_LONG_INTEGER SupportsKeypadBackSpace;
        static SIGNED_LONG_INTEGER SupportsDvrCommand;
        static SIGNED_LONG_INTEGER SupportsRecord;
        static SIGNED_LONG_INTEGER SupportsSpeedSlow;
        static SIGNED_LONG_INTEGER SupportsThumbsUp;
        static SIGNED_LONG_INTEGER SupportsThumbsDown;
        static SIGNED_LONG_INTEGER SupportsTunerFeedback;
        static SIGNED_LONG_INTEGER SupportsChangeFrequency;
        static SIGNED_LONG_INTEGER SupportsSetFrequency;
        static SIGNED_LONG_INTEGER SupportsAutoFrequency;
        static SIGNED_LONG_INTEGER SupportsFrequencyBand;
        static SIGNED_LONG_INTEGER SupportsDiscreteFrequencyBand;
        static SIGNED_LONG_INTEGER SupportsChangePreset;
        static SIGNED_LONG_INTEGER SupportsPresetRecall;
        static SIGNED_LONG_INTEGER SupportsPresetStore;
        static SIGNED_LONG_INTEGER SupportsLetterKeys;
        static SIGNED_LONG_INTEGER SupportsColorButtons;
        static SIGNED_LONG_INTEGER SupportsFavorite;
        static SIGNED_LONG_INTEGER SupportsLast;
        static SIGNED_LONG_INTEGER SupportsReplay;
        static SIGNED_LONG_INTEGER SupportsOnDemand;
    };

     class MediaServiceInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        StandardMediaService Id;
    };

     class MediaServiceInfoTypeFactory 
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

     class PhysicalAvConnectorInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AvConnectionType ConnectorType;
        AvInputOutputType Id;
    };

     class PhysicalAvInputInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        AvConnectionType ConnectorType;
        AvInputOutputType Id;
    };

     class PhysicalAvInputInfoTypeFactory 
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

     class PhysicalAvOutputInfo 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING TypeName[];

        // class properties
        AvConnectionType ConnectorType;
        AvInputOutputType Id;
    };

     class PhysicalAvOutputInfoTypeFactory 
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

namespace Crestron.DeviceDrivers.Core.InputOutput.Attributes;
        // class declarations
         class MediaServiceIdAttribute;

namespace Crestron.DeviceDrivers.Core.Capabilities;
        // class declarations
         class Artwork;
         class ArtworkFactory;
         class Authentication;
         class AuthenticationFactory;
         class BasicInformation;
         class BasicInformationFactory;
         class BasicLogger;
         class CapabilityComponentArgs;
         class CapabilityExtensions;
         class ChannelImpl;
         class ChannelImplFactory;
         class ColorKeys;
         class ColorKeysFactory;
         class Connection;
         class ConnectionFactory;
         class CustomCommand;
         class CustomCommandFactory;
         class CustomCommandCollection;
         class CustomCommandCollectionFactory;
         class DiagnosticsLogger;
         class DvrCapability;
         class DvrFactory;
         class EnergyStar;
         class EnergyStarFactory;
         class FeedbackInformation;
         class FeedbackInformationFactory;
         class Inputs;
         class InputsFactory;
         class Keypad;
         class KeypadFactory;
         class LampHoursImpl;
         class LampHoursImplFactory;
         class LetterKeysImpl;
         class LetterKeysImplFactory;
         class MediaServiceProvider;
         class MediaServiceProviderFactory;
         class MediaSource;
         class MediaSourceFactory;
         class MediaTransport;
         class MediaTransportFactory;
         class MediaTransportInfo;
         class MediaTransportInfoFactory;
         class MediaTransportOptions;
         class MediaTransportOptionsFactory;
         class ModelFileSupport;
         class ModelFileSupportFactory;
         class Navigation;
         class NavigationFactory;
         class Outputs;
         class OutputsFactory;
         class Power;
         class PowerFactory;
         class SupportedCommandsHelper;
         class SupportedCommandsHelperFactory;
         class TcpCapability;
         class TcpCapabilityFactory;
         class VideoConfiguration;
         class VideoConfigurationFactory;
         class VideoMute;
         class VideoMuteFactory;
         class VideoServerStateChange;
         class VideoServerStateChangeFactory;
         class Volume;
         class VolumeFactory;
     class ArtworkFactory 
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

     class AuthenticationFactory 
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

     class BasicInformationFactory 
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

    static class CapabilityExtensions 
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

     class ChannelImplFactory 
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

     class ColorKeysFactory 
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

     class ConnectionFactory 
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

     class CustomCommandFactory 
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

     class CustomCommandCollectionFactory 
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

     class DvrFactory 
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

     class EnergyStarFactory 
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

     class FeedbackInformationFactory 
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

     class Inputs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING VideoInputFeatureName[];
        static STRING FeatureName[];

        // class properties
    };

     class InputsFactory 
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

     class KeypadFactory 
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

     class LampHoursImplFactory 
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

     class LetterKeysImplFactory 
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

     class MediaServiceProviderFactory 
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

     class MediaSourceFactory 
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

     class MediaTransportFactory 
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

     class MediaTransportInfoFactory 
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

     class MediaTransportOptionsFactory 
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

     class ModelFileSupportFactory 
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

     class NavigationFactory 
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

     class OutputsFactory 
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

     class PowerFactory 
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

     class SupportedCommandsHelperFactory 
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

     class TcpCapabilityFactory 
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

     class VideoConfigurationFactory 
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

     class VideoMuteFactory 
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

     class VideoServerStateChangeFactory 
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

     class VolumeFactory 
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

namespace Crestron.RAD.Common.Interfaces;
        // class declarations

