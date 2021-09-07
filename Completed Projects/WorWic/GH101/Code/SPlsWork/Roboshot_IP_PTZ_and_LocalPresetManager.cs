using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_ROBOSHOT_IP_PTZ_AND_LOCALPRESETMANAGER
{
    public class UserModuleClass_ROBOSHOT_IP_PTZ_AND_LOCALPRESETMANAGER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput RECALL;
        Crestron.Logos.SplusObjects.DigitalInput STORE;
        Crestron.Logos.SplusObjects.DigitalInput STOREMASTER;
        Crestron.Logos.SplusObjects.DigitalInput RECALLMASTER;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TILT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PAN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ZOOM;
        Crestron.Logos.SplusObjects.DigitalOutput STORED;
        Crestron.Logos.SplusObjects.BufferInput IN__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput PRESET;
        Crestron.Logos.SplusObjects.StringOutput OUT__DOLLAR__;
        ushort STORETYPE = 0;
        ushort PARAMTYPE = 0;
        short PTZ = 0;
        short [,] PRESETARRAY;
        CrestronString FILENAME;
        private void READPRESETS (  SplusExecutionContext __context__ ) 
            { 
            short NFILEHANDLE = 0;
            short IERRORCODE = 0;
            
            
            __context__.SourceCodeLine = 52;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 53;
            NFILEHANDLE = (short) ( FileOpenShared( FILENAME ,(ushort) (256 | 0) ) ) ; 
            __context__.SourceCodeLine = 54;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 56;
                IERRORCODE = (short) ( ReadSignedIntegerArray( (short)( NFILEHANDLE ) , ref PRESETARRAY ) ) ; 
                __context__.SourceCodeLine = 57;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 59;
                    Trace( "Read Preset array from file correctly. Length {0:d}\r\n", (ushort)IERRORCODE) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 63;
                    Trace( "Error code Preset {0:d}\r\n", (short)IERRORCODE) ; 
                    } 
                
                __context__.SourceCodeLine = 65;
                FileClose (  (short) ( NFILEHANDLE ) ) ; 
                } 
            
            __context__.SourceCodeLine = 67;
            EndFileOperations ( ) ; 
            
            }
            
        private void SENDPRESET (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 72;
            MakeString ( OUT__DOLLAR__ , "camera pan set {0:d} 24\r\n", (short)PRESETARRAY[ PRESET  .UshortValue , 1 ]) ; 
            __context__.SourceCodeLine = 73;
            Functions.Delay (  (int) ( 200 ) ) ; 
            __context__.SourceCodeLine = 74;
            MakeString ( OUT__DOLLAR__ , "camera tilt set {0:d} 20\r\n", (short)PRESETARRAY[ PRESET  .UshortValue , 2 ]) ; 
            __context__.SourceCodeLine = 75;
            Functions.Delay (  (int) ( 200 ) ) ; 
            __context__.SourceCodeLine = 76;
            MakeString ( OUT__DOLLAR__ , "camera zoom set {0:d} 7\r\n", (short)PRESETARRAY[ PRESET  .UshortValue , 3 ]) ; 
            
            }
            
        private void RECALL_LAYOUT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 82;
            READPRESETS (  __context__  ) ; 
            __context__.SourceCodeLine = 83;
            SENDPRESET (  __context__  ) ; 
            
            }
            
        private void WRITEARRAY (  SplusExecutionContext __context__ ) 
            { 
            short NFILEHANDLE = 0;
            short IERRORCODE = 0;
            
            
            __context__.SourceCodeLine = 88;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 89;
            NFILEHANDLE = (short) ( FileOpenShared( FILENAME ,(ushort) ((256 | 512) | 1) ) ) ; 
            __context__.SourceCodeLine = 90;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 92;
                IERRORCODE = (short) ( WriteSignedIntegerArray( (short)( NFILEHANDLE ) , PRESETARRAY ) ) ; 
                __context__.SourceCodeLine = 93;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 95;
                    Trace( "Array written to file correctly with {0:d} bytes.\r\n", (short)IERRORCODE) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 99;
                    Trace( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                    } 
                
                __context__.SourceCodeLine = 101;
                FileClose (  (short) ( NFILEHANDLE ) ) ; 
                } 
            
            __context__.SourceCodeLine = 103;
            EndFileOperations ( ) ; 
            
            }
            
        private void STORE_LAYOUT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 108;
            PARAMTYPE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 109;
            OUT__DOLLAR__  .UpdateValue ( "camera pan get\r\n"  ) ; 
            
            }
            
        object IN__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString TEMP;
                TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
                
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 115;
                TEMP  .UpdateValue ( Functions.Gather ( ">" , IN__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 116;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)STORETYPE);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 120;
                            TEMP  .UpdateValue ( Functions.Mid ( TEMP ,  (int) ( (Functions.Find( "[0m" , TEMP ) + 3) ) ,  (int) ( ((Functions.Find( "\u001b" , TEMP ) - Functions.Find( "[0m" , TEMP )) + 3) ) )  ) ; 
                            __context__.SourceCodeLine = 121;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_2__ = ((int)PARAMTYPE);
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 125;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMP , (int)( 1 ) ) == Byte( "-" , (int)( 1 ) )))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 127;
                                            PRESETARRAY [ PRESET  .UshortValue , 1] = (short) ( (Functions.Atoi( TEMP ) * Functions.ToSignedInteger( -( 1 ) )) ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 131;
                                            PRESETARRAY [ PRESET  .UshortValue , 1] = (short) ( Functions.Atoi( TEMP ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 133;
                                        PARAMTYPE = (ushort) ( 2 ) ; 
                                        __context__.SourceCodeLine = 134;
                                        OUT__DOLLAR__  .UpdateValue ( "camera tilt get\r\n"  ) ; 
                                        __context__.SourceCodeLine = 135;
                                        Trace( "Store P Processed") ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 139;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMP , (int)( 1 ) ) == Byte( "-" , (int)( 1 ) )))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 141;
                                            PRESETARRAY [ PRESET  .UshortValue , 2] = (short) ( (Functions.Atoi( TEMP ) * Functions.ToSignedInteger( -( 1 ) )) ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 145;
                                            PRESETARRAY [ PRESET  .UshortValue , 2] = (short) ( Functions.Atoi( TEMP ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 147;
                                        PARAMTYPE = (ushort) ( 3 ) ; 
                                        __context__.SourceCodeLine = 148;
                                        OUT__DOLLAR__  .UpdateValue ( "camera zoom get\r\n"  ) ; 
                                        __context__.SourceCodeLine = 149;
                                        Trace( "Store T Processed") ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 153;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMP , (int)( 1 ) ) == Byte( "-" , (int)( 1 ) )))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 155;
                                            PRESETARRAY [ PRESET  .UshortValue , 3] = (short) ( (Functions.Atoi( TEMP ) * Functions.ToSignedInteger( -( 1 ) )) ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 159;
                                            PRESETARRAY [ PRESET  .UshortValue , 3] = (short) ( Functions.Atoi( TEMP ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 161;
                                        PARAMTYPE = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 162;
                                        STORETYPE = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 163;
                                        Trace( "Store Z Processed") ; 
                                        __context__.SourceCodeLine = 164;
                                        WRITEARRAY (  __context__  ) ; 
                                        __context__.SourceCodeLine = 165;
                                        Functions.Pulse ( 100, STORED ) ; 
                                        } 
                                    
                                    } 
                                    
                                }
                                
                            
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 171;
                            TEMP  .UpdateValue ( Functions.Mid ( TEMP ,  (int) ( (Functions.Find( "[0m" , TEMP ) + 3) ) ,  (int) ( ((Functions.Find( "\u001b" , TEMP ) - Functions.Find( "[0m" , TEMP )) + 3) ) )  ) ; 
                            __context__.SourceCodeLine = 172;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_3__ = ((int)PARAMTYPE);
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 176;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMP , (int)( 1 ) ) == Byte( "-" , (int)( 1 ) )))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 178;
                                            PRESETARRAY [ (90 + PRESET  .UshortValue) , 1] = (short) ( (Functions.Atoi( TEMP ) * Functions.ToSignedInteger( -( 1 ) )) ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 182;
                                            PRESETARRAY [ (90 + PRESET  .UshortValue) , 1] = (short) ( Functions.Atoi( TEMP ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 184;
                                        PARAMTYPE = (ushort) ( 2 ) ; 
                                        __context__.SourceCodeLine = 185;
                                        OUT__DOLLAR__  .UpdateValue ( "camera tilt get\r\n"  ) ; 
                                        __context__.SourceCodeLine = 186;
                                        Trace( "Store P Processed") ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 190;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMP , (int)( 1 ) ) == Byte( "-" , (int)( 1 ) )))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 192;
                                            PRESETARRAY [ (90 + PRESET  .UshortValue) , 2] = (short) ( (Functions.Atoi( TEMP ) * Functions.ToSignedInteger( -( 1 ) )) ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 196;
                                            PRESETARRAY [ (90 + PRESET  .UshortValue) , 2] = (short) ( Functions.Atoi( TEMP ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 198;
                                        PARAMTYPE = (ushort) ( 3 ) ; 
                                        __context__.SourceCodeLine = 199;
                                        OUT__DOLLAR__  .UpdateValue ( "camera zoom get\r\n"  ) ; 
                                        __context__.SourceCodeLine = 200;
                                        Trace( "Store T Processed") ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 204;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMP , (int)( 1 ) ) == Byte( "-" , (int)( 1 ) )))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 206;
                                            PRESETARRAY [ (90 + PRESET  .UshortValue) , 3] = (short) ( (Functions.Atoi( TEMP ) * Functions.ToSignedInteger( -( 1 ) )) ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 210;
                                            PRESETARRAY [ (90 + PRESET  .UshortValue) , 3] = (short) ( Functions.Atoi( TEMP ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 212;
                                        PARAMTYPE = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 213;
                                        STORETYPE = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 214;
                                        Trace( "Store Z Processed") ; 
                                        __context__.SourceCodeLine = 215;
                                        WRITEARRAY (  __context__  ) ; 
                                        __context__.SourceCodeLine = 216;
                                        Functions.Pulse ( 100, STORED ) ; 
                                        } 
                                    
                                    } 
                                    
                                }
                                
                            
                            } 
                        
                        } 
                        
                    }
                    
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STORE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 225;
            STORETYPE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 226;
            STORE_LAYOUT (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object STOREMASTER_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 230;
        STORETYPE = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 231;
        STORE_LAYOUT (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALLMASTER_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 236;
        READPRESETS (  __context__  ) ; 
        __context__.SourceCodeLine = 237;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 239;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)3; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (X  >= __FN_FORSTART_VAL__2) && (X  <= __FN_FOREND_VAL__2) ) : ( (X  <= __FN_FORSTART_VAL__2) && (X  >= __FN_FOREND_VAL__2) ) ; X  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 241;
                PRESETARRAY [ I , X] = (short) ( PRESETARRAY[ (I + 90) , X ] ) ; 
                __context__.SourceCodeLine = 239;
                } 
            
            __context__.SourceCodeLine = 237;
            } 
        
        __context__.SourceCodeLine = 244;
        WRITEARRAY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 248;
        RECALL_LAYOUT (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TILT_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 252;
        PTZ = (short) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 253;
        
            {
            int __SPLS_TMPVAR__SWTCH_4__ = ((int)PTZ);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 257;
                    OUT__DOLLAR__  .UpdateValue ( "camera tilt up\r"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 261;
                    OUT__DOLLAR__  .UpdateValue ( "camera tilt down\r"  ) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 267;
        PTZ = (short) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 268;
        
            {
            int __SPLS_TMPVAR__SWTCH_5__ = ((int)PTZ);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 272;
                    OUT__DOLLAR__  .UpdateValue ( "camera pan left\r"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 276;
                    OUT__DOLLAR__  .UpdateValue ( "camera pan right\r"  ) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 282;
        PTZ = (short) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 283;
        
            {
            int __SPLS_TMPVAR__SWTCH_6__ = ((int)PTZ);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 287;
                    OUT__DOLLAR__  .UpdateValue ( "camera zoom in\r"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 291;
                    OUT__DOLLAR__  .UpdateValue ( "camera zoom out\r"  ) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_OnRelease_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 296;
        OUT__DOLLAR__  .UpdateValue ( "camera pan stop\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TILT_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 298;
        OUT__DOLLAR__  .UpdateValue ( "camera tilt stop\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_OnRelease_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 300;
        OUT__DOLLAR__  .UpdateValue ( "camera zoom stop\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 303;
        FILENAME  .UpdateValue ( "\\USER\\" + "Camera" + GetSymbolReferenceName ( ) + ".dat"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    PRESETARRAY  = new short[ 100,4 ];
    FILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, this );
    
    RECALL = new Crestron.Logos.SplusObjects.DigitalInput( RECALL__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL__DigitalInput__, RECALL );
    
    STORE = new Crestron.Logos.SplusObjects.DigitalInput( STORE__DigitalInput__, this );
    m_DigitalInputList.Add( STORE__DigitalInput__, STORE );
    
    STOREMASTER = new Crestron.Logos.SplusObjects.DigitalInput( STOREMASTER__DigitalInput__, this );
    m_DigitalInputList.Add( STOREMASTER__DigitalInput__, STOREMASTER );
    
    RECALLMASTER = new Crestron.Logos.SplusObjects.DigitalInput( RECALLMASTER__DigitalInput__, this );
    m_DigitalInputList.Add( RECALLMASTER__DigitalInput__, RECALLMASTER );
    
    TILT = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        TILT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TILT__DigitalInput__ + i, TILT__DigitalInput__, this );
        m_DigitalInputList.Add( TILT__DigitalInput__ + i, TILT[i+1] );
    }
    
    PAN = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        PAN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PAN__DigitalInput__ + i, PAN__DigitalInput__, this );
        m_DigitalInputList.Add( PAN__DigitalInput__ + i, PAN[i+1] );
    }
    
    ZOOM = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        ZOOM[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ZOOM__DigitalInput__ + i, ZOOM__DigitalInput__, this );
        m_DigitalInputList.Add( ZOOM__DigitalInput__ + i, ZOOM[i+1] );
    }
    
    STORED = new Crestron.Logos.SplusObjects.DigitalOutput( STORED__DigitalOutput__, this );
    m_DigitalOutputList.Add( STORED__DigitalOutput__, STORED );
    
    PRESET = new Crestron.Logos.SplusObjects.AnalogInput( PRESET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PRESET__AnalogSerialInput__, PRESET );
    
    OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OUT__DOLLAR____AnalogSerialOutput__, OUT__DOLLAR__ );
    
    IN__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( IN__DOLLAR____AnalogSerialInput__, 500, this );
    m_StringInputList.Add( IN__DOLLAR____AnalogSerialInput__, IN__DOLLAR__ );
    
    
    IN__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( IN__DOLLAR___OnChange_0, false ) );
    STORE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STORE_OnPush_1, false ) );
    STOREMASTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOREMASTER_OnPush_2, false ) );
    RECALLMASTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALLMASTER_OnPush_3, false ) );
    RECALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_OnPush_4, false ) );
    for( uint i = 0; i < 2; i++ )
        TILT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TILT_OnPush_5, false ) );
        
    for( uint i = 0; i < 2; i++ )
        PAN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_OnPush_6, false ) );
        
    for( uint i = 0; i < 2; i++ )
        ZOOM[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ZOOM_OnPush_7, false ) );
        
    for( uint i = 0; i < 2; i++ )
        PAN[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_OnRelease_8, false ) );
        
    for( uint i = 0; i < 2; i++ )
        TILT[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( TILT_OnRelease_9, false ) );
        
    for( uint i = 0; i < 2; i++ )
        ZOOM[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( ZOOM_OnRelease_10, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ROBOSHOT_IP_PTZ_AND_LOCALPRESETMANAGER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint RECALL__DigitalInput__ = 0;
const uint STORE__DigitalInput__ = 1;
const uint STOREMASTER__DigitalInput__ = 2;
const uint RECALLMASTER__DigitalInput__ = 3;
const uint TILT__DigitalInput__ = 4;
const uint PAN__DigitalInput__ = 6;
const uint ZOOM__DigitalInput__ = 8;
const uint STORED__DigitalOutput__ = 0;
const uint IN__DOLLAR____AnalogSerialInput__ = 0;
const uint PRESET__AnalogSerialInput__ = 1;
const uint OUT__DOLLAR____AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
