namespace Crestron.RAD.DriverResources;
        // class declarations
         class CrestronCertifiedDriverResources;
         class MediaServiceIcon;
         class ImageHelper;
     class CrestronCertifiedDriverResources 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION PopulateMediaServiceIcons ();
        FUNCTION EnableLogging ();
        FUNCTION DisableLogging ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class MediaServiceIcon 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING MediaServiceId[];
    };

    static class ImageHelper 
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

