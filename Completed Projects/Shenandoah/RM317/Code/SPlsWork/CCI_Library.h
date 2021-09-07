namespace CCI_Library;
        // class declarations
         class CrestronSimplPlusHelper;
         class FileUtil;
         class StringUtil;
         class ByteBuffer;
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

