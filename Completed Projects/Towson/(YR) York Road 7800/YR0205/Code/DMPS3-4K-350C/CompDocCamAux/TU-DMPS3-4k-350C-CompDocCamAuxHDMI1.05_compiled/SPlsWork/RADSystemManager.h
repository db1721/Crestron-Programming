namespace Crestron.RAD.SystemManager;
        // class declarations
         class DriverManifestItem;
         class ComunicationSettings;
         class ManifestDeviceTypes;
         class RadSystemManager;
         class SMWrapper;
         class TransportType;
         class DeviceDriverManifest;
     class DriverManifestItem 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING Tag[];
        STRING Filepath[];
        Crestron.RAD.SystemManager.DriverManifestItem Communication;

        // class properties
    };

     class ComunicationSettings 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING Hostname[];
        INTEGER Port;

        // class properties
    };

    static class ManifestDeviceTypes // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER BasicVideoDisplay;
        static SIGNED_LONG_INTEGER BasicTvTuner;
        static SIGNED_LONG_INTEGER BasicVideoServer;
        static SIGNED_LONG_INTEGER BasicBlurayPlayer;
        static SIGNED_LONG_INTEGER BasicCodec;
        static SIGNED_LONG_INTEGER BasicAVReceiver;
        static SIGNED_LONG_INTEGER BasicSecuritySystem;
    };

    static class RadSystemManager 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION Initialize ();
        static FUNCTION ReloadManifest ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static INTEGER Available;
        static STRING ManifestFilepath[];

        // class properties
        STRING ManifestFilename[];
    };

     class SMWrapper 
    {
        // class delegates
        delegate FUNCTION ManifestUpdate ( SIMPLSHARPSTRING filepath , SIMPLSHARPSTRING ipAddress , INTEGER port );

        // class events

        // class functions
        FUNCTION Initialize ( STRING uniqueId , STRING driverPath , SIGNED_LONG_INTEGER deviceType , STRING ipAddress , INTEGER port , STRING transport );
        FUNCTION UpdateModule ( STRING filePath , STRING ipAddress , INTEGER port );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DriverPath[];
        STRING DeviceHostname[];
        INTEGER DevicePort;
        DelegateProperty ManifestUpdate ManifestUpdated;
    };

    static class TransportType // enum
    {
        static SIGNED_LONG_INTEGER Cec;
        static SIGNED_LONG_INTEGER Ethernet;
        static SIGNED_LONG_INTEGER Ir;
        static SIGNED_LONG_INTEGER Serial;
    };

     class DeviceDriverManifest 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Initialize ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

