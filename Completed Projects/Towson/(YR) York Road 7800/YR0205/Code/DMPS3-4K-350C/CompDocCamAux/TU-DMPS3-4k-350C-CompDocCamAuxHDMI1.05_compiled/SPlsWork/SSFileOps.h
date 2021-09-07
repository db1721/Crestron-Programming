namespace SSFileOps;
        // class declarations
         class SimplSharpFileOps;
     class SimplSharpFileOps 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION GetApplicationPath ();
        SIGNED_INTEGER_FUNCTION GetApplicationNumber ();
        SIGNED_INTEGER_FUNCTION DeleteFile ( STRING fqFilePath );
        SIGNED_INTEGER_FUNCTION CopyFile ( STRING fqFilePathSource , STRING fqFilePathDest , SIGNED_INTEGER overwrite );
        SIGNED_INTEGER_FUNCTION RenameFile ( STRING fqFilePathSource , STRING destFilename , SIGNED_INTEGER overwrite );
        SIGNED_INTEGER_FUNCTION FileExists ( STRING fqFilePath );
        STRING_FUNCTION GetFileByExt ( STRING fqDirPath , STRING fileExt );
        STRING_FUNCTION GetFirstFileNameByExt ( STRING fqDirPath , STRING fileExt );
        SIGNED_INTEGER_FUNCTION CheckOrCreateDirectory ( STRING path );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

