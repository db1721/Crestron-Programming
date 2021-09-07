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

namespace UserModule_BIAMP_ON_OFF_PROCESSOR_V7_5_1
{
    public class UserModuleClass_BIAMP_ON_OFF_PROCESSOR_V7_5_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput VOL_MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalInput VOL_MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput POLL_MUTE;
        Crestron.Logos.SplusObjects.StringInput MUTE_DEVICE_ID;
        Crestron.Logos.SplusObjects.StringInput MUTE_DEVICE_INSTANCE;
        Crestron.Logos.SplusObjects.StringInput MUTE_INDEX1;
        Crestron.Logos.SplusObjects.StringInput MUTE_INDEX2;
        Crestron.Logos.SplusObjects.StringInput MUTE_COMMAND_TYPE;
        Crestron.Logos.SplusObjects.BufferInput DEVICE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput START_UP_OUT;
        Crestron.Logos.SplusObjects.DigitalOutput ERROR;
        Crestron.Logos.SplusObjects.StringOutput DEVICE_TX__DOLLAR__;
        ushort IVOLINDEX1 = 0;
        ushort IVOLINDEX2 = 0;
        ushort IMUTEINDEX1 = 0;
        ushort IMUTEINDEX2 = 0;
        ushort ERRORRECEIVED = 0;
        CrestronString SMUTE;
        CrestronString SSENDNAME;
        CrestronString SMUTEPREFIX;
        CrestronString SMUTETYPE;
        CrestronString SINSTANCE;
        CrestronString SSENDINST;
        private void PROCESSMUTEDATA (  SplusExecutionContext __context__, CrestronString DATA ) 
            { 
            CrestronString STEMP;
            CrestronString SVAL;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            SVAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 66;
            STEMP  .UpdateValue ( Functions.Remove ( SMUTEPREFIX , DATA )  ) ; 
            __context__.SourceCodeLine = 67;
            SVAL  .UpdateValue ( Functions.Left ( DATA ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 68;
            if ( Functions.TestForTrue  ( ( Functions.Find( "1" , SVAL ))  ) ) 
                { 
                __context__.SourceCodeLine = 70;
                MUTE_OFF_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 71;
                MUTE_ON_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 75;
                MUTE_ON_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 76;
                MUTE_OFF_FB  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            }
            
        private void PROCESSMSGFROMDEVICE (  SplusExecutionContext __context__, CrestronString PARAMDATA ) 
            { 
            
            __context__.SourceCodeLine = 85;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "hello" , PARAMDATA ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 87;
                ERRORRECEIVED = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 88;
                ERROR  .Value = (ushort) ( ERRORRECEIVED ) ; 
                __context__.SourceCodeLine = 89;
                DEVICE_TX__DOLLAR__  .UpdateValue ( PARAMDATA  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 91;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Send Name\u000D\u000A" , PARAMDATA ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 93;
                    ERRORRECEIVED = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 94;
                    ERROR  .Value = (ushort) ( ERRORRECEIVED ) ; 
                    __context__.SourceCodeLine = 95;
                    START_UP_OUT  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 96;
                    SSENDNAME  .UpdateValue ( Functions.Left ( PARAMDATA ,  (int) ( (Functions.Length( PARAMDATA ) - 2) ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 98;
                    if ( Functions.TestForTrue  ( ( Functions.Find( SMUTEPREFIX , PARAMDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 100;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "-ERR" , PARAMDATA ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 102;
                            ERRORRECEIVED = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 103;
                            ERROR  .Value = (ushort) ( ERRORRECEIVED ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 107;
                            ERRORRECEIVED = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 108;
                            ERROR  .Value = (ushort) ( ERRORRECEIVED ) ; 
                            __context__.SourceCodeLine = 109;
                            PROCESSMUTEDATA (  __context__ , PARAMDATA) ; 
                            } 
                        
                        } 
                    
                    }
                
                }
            
            
            }
            
        object DEVICE_RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString STEMPDATA;
                STEMPDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
                
                
                __context__.SourceCodeLine = 117;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r\n" , DEVICE_RX__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 119;
                    try 
                        { 
                        __context__.SourceCodeLine = 121;
                        STEMPDATA  .UpdateValue ( Functions.Gather ( "\r\n" , DEVICE_RX__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 122;
                        PROCESSMSGFROMDEVICE (  __context__ , STEMPDATA) ; 
                        __context__.SourceCodeLine = 123;
                        STEMPDATA  .UpdateValue ( ""  ) ; 
                        } 
                    
                    catch (Exception __splus_exception__)
                        { 
                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                        
                        __context__.SourceCodeLine = 127;
                        GenerateUserNotice ( "BiAmp On-Off: From_SMPL$: trouble parsing: {0}", Functions.GetExceptionMessage (  __splus_exceptionobj__ ) ) ; 
                        
                        }
                        
                        __context__.SourceCodeLine = 117;
                        } 
                    
                    
                    
                }
                catch(Exception e) { ObjectCatchHandler(e); }
                finally { ObjectFinallyHandler( __SignalEventArg__ ); }
                return this;
                
            }
            
        
        object MUTE_DEVICE_INSTANCE_OnChange_1 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 152;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0020" , MUTE_DEVICE_INSTANCE ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 154;
                    MakeString ( SINSTANCE , "\u0022{0}\u0022", Functions.Left ( MUTE_DEVICE_INSTANCE ,  (int) ( 50 ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 158;
                    SINSTANCE  .UpdateValue ( Functions.Left ( MUTE_DEVICE_INSTANCE ,  (int) ( 50 ) )  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object MUTE_INDEX1_OnChange_2 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 164;
            IMUTEINDEX1 = (ushort) ( Functions.Atoi( MUTE_INDEX1 ) ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object MUTE_INDEX2_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 169;
        IMUTEINDEX2 = (ushort) ( Functions.Atoi( MUTE_INDEX2 ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_COMMAND_TYPE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 174;
        START_UP_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 175;
        SMUTETYPE  .UpdateValue ( MUTE_COMMAND_TYPE  ) ; 
        __context__.SourceCodeLine = 176;
        SMUTEPREFIX  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 177;
        SMUTE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 178;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IMUTEINDEX1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( IMUTEINDEX2 > 0 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 180;
            MakeString ( SMUTE , "{0} {1} {2} {3} {4}", MUTE_DEVICE_ID , SMUTETYPE , SINSTANCE , MUTE_INDEX1 , MUTE_INDEX2 ) ; 
            __context__.SourceCodeLine = 182;
            MakeString ( SSENDINST , "{0} {1} {2} {3}", MUTE_COMMAND_TYPE , SINSTANCE , MUTE_INDEX1 , MUTE_INDEX2 ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 185;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( IMUTEINDEX1 > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (IMUTEINDEX2 == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 187;
                MakeString ( SMUTE , "{0} {1} {2} {3}", MUTE_DEVICE_ID , SMUTETYPE , SINSTANCE , MUTE_INDEX1 ) ; 
                __context__.SourceCodeLine = 189;
                MakeString ( SSENDINST , "{0} {1} {2}", MUTE_COMMAND_TYPE , SINSTANCE , MUTE_INDEX1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 194;
                MakeString ( SMUTE , "{0} {1} {2}", MUTE_DEVICE_ID , SMUTETYPE , SINSTANCE ) ; 
                __context__.SourceCodeLine = 196;
                MakeString ( SSENDINST , "{0} {1}", MUTE_COMMAND_TYPE , SINSTANCE ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 198;
        MakeString ( DEVICE_TX__DOLLAR__ , "{0}={1}\u000D\u000A", SSENDNAME , SSENDINST ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOL_MUTE_ON_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 203;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ERRORRECEIVED == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 205;
            MakeString ( DEVICE_TX__DOLLAR__ , "SETD {0} 1\u000A", SMUTE ) ; 
            __context__.SourceCodeLine = 206;
            MakeString ( SMUTEPREFIX , "#SETD {0}\u0020", SMUTE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOL_MUTE_OFF_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 212;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ERRORRECEIVED == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 214;
            MakeString ( DEVICE_TX__DOLLAR__ , "SETD {0} 0\u000A", SMUTE ) ; 
            __context__.SourceCodeLine = 215;
            MakeString ( SMUTEPREFIX , "#SETD {0}\u0020", SMUTE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_MUTE_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 221;
        MakeString ( DEVICE_TX__DOLLAR__ , "GETD {0}\u000A", SMUTE ) ; 
        __context__.SourceCodeLine = 222;
        MakeString ( SMUTEPREFIX , "#GETD {0}\u0020", SMUTE ) ; 
        
        
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
        
        __context__.SourceCodeLine = 231;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 232;
        ERRORRECEIVED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 233;
        ERROR  .Value = (ushort) ( ERRORRECEIVED ) ; 
        __context__.SourceCodeLine = 234;
        
        __context__.SourceCodeLine = 237;
        MUTE_OFF_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 238;
        MUTE_ON_FB  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SMUTE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SSENDNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SMUTEPREFIX  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SMUTETYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    SINSTANCE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 52, this );
    SSENDINST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
    
    VOL_MUTE_ON = new Crestron.Logos.SplusObjects.DigitalInput( VOL_MUTE_ON__DigitalInput__, this );
    m_DigitalInputList.Add( VOL_MUTE_ON__DigitalInput__, VOL_MUTE_ON );
    
    VOL_MUTE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( VOL_MUTE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( VOL_MUTE_OFF__DigitalInput__, VOL_MUTE_OFF );
    
    POLL_MUTE = new Crestron.Logos.SplusObjects.DigitalInput( POLL_MUTE__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_MUTE__DigitalInput__, POLL_MUTE );
    
    MUTE_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_ON_FB__DigitalOutput__, MUTE_ON_FB );
    
    MUTE_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_OFF_FB__DigitalOutput__, MUTE_OFF_FB );
    
    START_UP_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( START_UP_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( START_UP_OUT__DigitalOutput__, START_UP_OUT );
    
    ERROR = new Crestron.Logos.SplusObjects.DigitalOutput( ERROR__DigitalOutput__, this );
    m_DigitalOutputList.Add( ERROR__DigitalOutput__, ERROR );
    
    MUTE_DEVICE_ID = new Crestron.Logos.SplusObjects.StringInput( MUTE_DEVICE_ID__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( MUTE_DEVICE_ID__AnalogSerialInput__, MUTE_DEVICE_ID );
    
    MUTE_DEVICE_INSTANCE = new Crestron.Logos.SplusObjects.StringInput( MUTE_DEVICE_INSTANCE__AnalogSerialInput__, 50, this );
    m_StringInputList.Add( MUTE_DEVICE_INSTANCE__AnalogSerialInput__, MUTE_DEVICE_INSTANCE );
    
    MUTE_INDEX1 = new Crestron.Logos.SplusObjects.StringInput( MUTE_INDEX1__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( MUTE_INDEX1__AnalogSerialInput__, MUTE_INDEX1 );
    
    MUTE_INDEX2 = new Crestron.Logos.SplusObjects.StringInput( MUTE_INDEX2__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( MUTE_INDEX2__AnalogSerialInput__, MUTE_INDEX2 );
    
    MUTE_COMMAND_TYPE = new Crestron.Logos.SplusObjects.StringInput( MUTE_COMMAND_TYPE__AnalogSerialInput__, 15, this );
    m_StringInputList.Add( MUTE_COMMAND_TYPE__AnalogSerialInput__, MUTE_COMMAND_TYPE );
    
    DEVICE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DEVICE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DEVICE_TX__DOLLAR____AnalogSerialOutput__, DEVICE_TX__DOLLAR__ );
    
    DEVICE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DEVICE_RX__DOLLAR____AnalogSerialInput__, 2000, this );
    m_StringInputList.Add( DEVICE_RX__DOLLAR____AnalogSerialInput__, DEVICE_RX__DOLLAR__ );
    
    
    DEVICE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEVICE_RX__DOLLAR___OnChange_0, true ) );
    MUTE_DEVICE_INSTANCE.OnSerialChange.Add( new InputChangeHandlerWrapper( MUTE_DEVICE_INSTANCE_OnChange_1, false ) );
    MUTE_INDEX1.OnSerialChange.Add( new InputChangeHandlerWrapper( MUTE_INDEX1_OnChange_2, false ) );
    MUTE_INDEX2.OnSerialChange.Add( new InputChangeHandlerWrapper( MUTE_INDEX2_OnChange_3, false ) );
    MUTE_COMMAND_TYPE.OnSerialChange.Add( new InputChangeHandlerWrapper( MUTE_COMMAND_TYPE_OnChange_4, false ) );
    VOL_MUTE_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOL_MUTE_ON_OnPush_5, false ) );
    VOL_MUTE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOL_MUTE_OFF_OnPush_6, false ) );
    POLL_MUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_MUTE_OnPush_7, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BIAMP_ON_OFF_PROCESSOR_V7_5_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VOL_MUTE_ON__DigitalInput__ = 0;
const uint VOL_MUTE_OFF__DigitalInput__ = 1;
const uint POLL_MUTE__DigitalInput__ = 2;
const uint MUTE_DEVICE_ID__AnalogSerialInput__ = 0;
const uint MUTE_DEVICE_INSTANCE__AnalogSerialInput__ = 1;
const uint MUTE_INDEX1__AnalogSerialInput__ = 2;
const uint MUTE_INDEX2__AnalogSerialInput__ = 3;
const uint MUTE_COMMAND_TYPE__AnalogSerialInput__ = 4;
const uint DEVICE_RX__DOLLAR____AnalogSerialInput__ = 5;
const uint MUTE_ON_FB__DigitalOutput__ = 0;
const uint MUTE_OFF_FB__DigitalOutput__ = 1;
const uint START_UP_OUT__DigitalOutput__ = 2;
const uint ERROR__DigitalOutput__ = 3;
const uint DEVICE_TX__DOLLAR____AnalogSerialOutput__ = 0;

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
