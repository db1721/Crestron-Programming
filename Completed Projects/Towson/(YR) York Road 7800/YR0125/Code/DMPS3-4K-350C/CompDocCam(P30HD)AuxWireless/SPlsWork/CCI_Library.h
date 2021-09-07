namespace CCI_Library;
        // class declarations
         class WebResponse;
         class CrestronSimplPlusHelper;
         class WebRequest;
         class PrinterUtil;
         class DebugLevel;
         class MD5Util;
         class FileUtil;
         class DataStoreType;
         class DataStoreUtil;
         class WebService;
         class StringUtil;
         class ByteBuffer;
     class WebResponse 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER code;
        ByteBuffer data;
        STRING dataString[];
    };

     class CrestronSimplPlusHelper 
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

    static class PrinterUtil 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION Print ( DebugLevel level , STRING msg );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class DebugLevel // enum
    {
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER Error;
    };

    static class MD5Util 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION MD5Hash ( STRING source );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class FileUtil 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION ReadFile ( STRING path );
        static FUNCTION WriteFile ( STRING path , STRING str );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class DataStoreType // enum
    {
        static SIGNED_LONG_INTEGER Local;
        static SIGNED_LONG_INTEGER Global;
    };

    static class DataStoreUtil 
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

     class StringUtil 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION getBoundString ( STRING msg , STRING startChar , STRING stopChar );
        static STRING_FUNCTION convertEncodingUnicode ( STRING msg );
        static STRING_FUNCTION convertEncodingBigEndian ( STRING msg );
        static STRING_FUNCTION htmlEncoding ( STRING msg );
        static STRING_FUNCTION encode ( STRING msg , INTEGER size );
        static STRING_FUNCTION Base64UrlEncode ( STRING arg );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ByteBuffer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Clear ();
        SIGNED_LONG_INTEGER_FUNCTION Length ();
        SIGNED_LONG_INTEGER_FUNCTION IndexOf ( STRING search );
        STRING_FUNCTION Substring ( SIGNED_LONG_INTEGER startIndex , SIGNED_LONG_INTEGER count );
        STRING_FUNCTION ToString ();
        FUNCTION Delete ( SIGNED_LONG_INTEGER startIndex , SIGNED_LONG_INTEGER count );
        FUNCTION Remove ( SIGNED_LONG_INTEGER startIndex , STRING item );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace CCI_Library.Network;
        // class declarations
         class IPHelper;
     class IPHelper 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION ResolveHostName ( STRING HostName );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace CCI_Library.WebScripting;
        // class declarations
         class WSRouteHandler;
     class WSRouteHandler 
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

namespace CCI_Library.Debugger;
        // class declarations
         class DebugMode;
         class DebuggerUtil;
    static class DebugMode // enum
    {
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER Error;
    };

     class DebuggerUtil 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION PrintLine ( DebugMode mode , STRING msg );
        static FUNCTION Initialize ( STRING ProgramID );
        static FUNCTION Dispose ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

