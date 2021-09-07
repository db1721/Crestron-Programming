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

namespace UserModule_TASCAM_3SERIES
{
    public class UserModuleClass_TASCAM_3SERIES : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PLAY;
        Crestron.Logos.SplusObjects.DigitalInput STOP;
        Crestron.Logos.SplusObjects.DigitalInput PAUSE;
        Crestron.Logos.SplusObjects.DigitalInput TRACK_FWD;
        Crestron.Logos.SplusObjects.DigitalInput TRACK_BACK;
        Crestron.Logos.SplusObjects.DigitalInput EJECT;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_TRACK;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_TRACK;
        Crestron.Logos.SplusObjects.DigitalInput POLL;
        Crestron.Logos.SplusObjects.AnalogInput TRACK_ANA_NUMBER;
        Crestron.Logos.SplusObjects.BufferInput DEVICE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput PLAY_FB;
        Crestron.Logos.SplusObjects.DigitalOutput STOP_FB;
        Crestron.Logos.SplusObjects.DigitalOutput PAUSE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput DISC_PRESENT_FB;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TRACK_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput TRACK_MINS;
        Crestron.Logos.SplusObjects.StringOutput TRACK_SECS;
        Crestron.Logos.SplusObjects.StringOutput TRACK_FRAMES;
        Crestron.Logos.SplusObjects.StringOutput TRACK_MANUAL_ENTER;
        Crestron.Logos.SplusObjects.StringOutput DEVICE_TX__DOLLAR__;
        ushort CUR_TRACK = 0;
        ushort CUR_MIN = 0;
        ushort CUR_SEC = 0;
        ushort CUR_FRAME = 0;
        CrestronString TRACK_NUMBER_A;
        CrestronString CUR_TRACK_A;
        CrestronString CUR_MIN_A;
        CrestronString CUR_SEC_A;
        CrestronString CUR_FRAME_A;
        ushort DISC_PRESENT = 0;
        CrestronString CD_BUFFER;
        private void TRACK_TIME_PARSE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 125;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A057\u000D") ; 
            
            }
            
        private void DISC_PARSE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 131;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A056\u000D") ; 
            
            }
            
        object PLAY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 168;
                if ( Functions.TestForTrue  ( ( Functions.Not( PLAY_FB  .Value ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    MakeString ( DEVICE_TX__DOLLAR__ , "\u000A012\u000D") ; 
                    __context__.SourceCodeLine = 170;
                    PLAY_FB  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 170;
                    STOP_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 170;
                    PAUSE_FB  .Value = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STOP_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 175;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A010\u000D") ; 
            __context__.SourceCodeLine = 175;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A010\u000D") ; 
            __context__.SourceCodeLine = 175;
            PLAY_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 175;
            STOP_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 175;
            PAUSE_FB  .Value = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object PAUSE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 178;
        if ( Functions.TestForTrue  ( ( PAUSE_FB  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 180;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A01400\u000D") ; 
            __context__.SourceCodeLine = 180;
            PLAY_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 180;
            STOP_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 180;
            PAUSE_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 186;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A01401\u000D") ; 
            __context__.SourceCodeLine = 186;
            PLAY_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 186;
            STOP_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 186;
            PAUSE_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EJECT_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 189;
        MakeString ( DEVICE_TX__DOLLAR__ , "\u000A010\u000D") ; 
        __context__.SourceCodeLine = 189;
        MakeString ( DEVICE_TX__DOLLAR__ , "\u000A010\u000D") ; 
        __context__.SourceCodeLine = 189;
        MakeString ( DEVICE_TX__DOLLAR__ , "\u000A018\u000D") ; 
        __context__.SourceCodeLine = 189;
        PLAY_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 189;
        STOP_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 189;
        PAUSE_FB  .Value = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRACK_BACK_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 192;
        if ( Functions.TestForTrue  ( ( Functions.Not( STOP_FB  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 194;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A01A01\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRACK_FWD_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 200;
        if ( Functions.TestForTrue  ( ( Functions.Not( STOP_FB  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 202;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A01A00\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 209;
        if ( Functions.TestForTrue  ( ( (Functions.BoolToInt (DISC_PRESENT == 1) & PLAY_FB  .Value))  ) ) 
            { 
            __context__.SourceCodeLine = 209;
            TRACK_TIME_PARSE (  __context__  ) ; 
            } 
        
        __context__.SourceCodeLine = 211;
        if ( Functions.TestForTrue  ( ( Functions.Not( PLAY_FB  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 211;
            DISC_PARSE (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRACK_ANA_NUMBER_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 216;
        TRACK_MANUAL_ENTER  .UpdateValue ( Functions.ItoA (  (int) ( TRACK_ANA_NUMBER  .UshortValue ) )  ) ; 
        __context__.SourceCodeLine = 217;
        TRACK_NUMBER_A  .UpdateValue ( Functions.ItoA (  (int) ( TRACK_ANA_NUMBER  .UshortValue ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_TRACK_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 223;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TRACK_ANA_NUMBER  .UshortValue < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 225;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A0230{0}00\u000D", TRACK_NUMBER_A ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 229;
            MakeString ( DEVICE_TX__DOLLAR__ , "\u000A023{0}00\u000D", TRACK_NUMBER_A ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_TRACK_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 233;
        TRACK_MANUAL_ENTER  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 233;
        TRACK_NUMBER_A  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEVICE_RX__DOLLAR___OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TRACK_START = 0;
        ushort MIN_START = 0;
        ushort SEC_START = 0;
        ushort FRAME_START = 0;
        
        
        __context__.SourceCodeLine = 238;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 240;
            try 
                { 
                __context__.SourceCodeLine = 245;
                CD_BUFFER  .UpdateValue ( Functions.Gather ( "\u000A" , DEVICE_RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 247;
                TRACK_START = (ushort) ( Functions.Find( "0D7" , CD_BUFFER ) ) ; 
                __context__.SourceCodeLine = 249;
                CURRENT_TRACK_NUMBER  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 3) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 250;
                CUR_TRACK_A  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 3) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 251;
                CUR_TRACK = (ushort) ( Functions.Atoi( CUR_TRACK_A ) ) ; 
                __context__.SourceCodeLine = 253;
                TRACK_MINS  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 7) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 254;
                CUR_MIN_A  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 7) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 255;
                CUR_MIN = (ushort) ( Functions.Atoi( CUR_MIN_A ) ) ; 
                __context__.SourceCodeLine = 257;
                TRACK_SECS  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 11) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 258;
                CUR_SEC_A  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 11) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 259;
                CUR_SEC = (ushort) ( Functions.Atoi( CUR_SEC_A ) ) ; 
                __context__.SourceCodeLine = 261;
                TRACK_FRAMES  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 14) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 262;
                CUR_FRAME_A  .UpdateValue ( Functions.Mid ( CD_BUFFER ,  (int) ( (TRACK_START + 14) ) ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 263;
                CUR_FRAME = (ushort) ( Functions.Atoi( CUR_FRAME_A ) ) ; 
                __context__.SourceCodeLine = 265;
                if ( Functions.TestForTrue  ( ( Functions.Find( "0D600FF\u000D" , CD_BUFFER ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 267;
                    DISC_PRESENT = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 268;
                    DISC_PRESENT_FB  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 270;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "0D60100\u000D" , CD_BUFFER ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 272;
                        DISC_PRESENT = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 273;
                        DISC_PRESENT_FB  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    }
                
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                
                }
                
                __context__.SourceCodeLine = 238;
                } 
            
            
            
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
        
        __context__.SourceCodeLine = 335;
        DISC_PARSE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    TRACK_NUMBER_A  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    CUR_TRACK_A  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    CUR_MIN_A  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    CUR_SEC_A  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    CUR_FRAME_A  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    CD_BUFFER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
    
    PLAY = new Crestron.Logos.SplusObjects.DigitalInput( PLAY__DigitalInput__, this );
    m_DigitalInputList.Add( PLAY__DigitalInput__, PLAY );
    
    STOP = new Crestron.Logos.SplusObjects.DigitalInput( STOP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP__DigitalInput__, STOP );
    
    PAUSE = new Crestron.Logos.SplusObjects.DigitalInput( PAUSE__DigitalInput__, this );
    m_DigitalInputList.Add( PAUSE__DigitalInput__, PAUSE );
    
    TRACK_FWD = new Crestron.Logos.SplusObjects.DigitalInput( TRACK_FWD__DigitalInput__, this );
    m_DigitalInputList.Add( TRACK_FWD__DigitalInput__, TRACK_FWD );
    
    TRACK_BACK = new Crestron.Logos.SplusObjects.DigitalInput( TRACK_BACK__DigitalInput__, this );
    m_DigitalInputList.Add( TRACK_BACK__DigitalInput__, TRACK_BACK );
    
    EJECT = new Crestron.Logos.SplusObjects.DigitalInput( EJECT__DigitalInput__, this );
    m_DigitalInputList.Add( EJECT__DigitalInput__, EJECT );
    
    ENTER_TRACK = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_TRACK__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_TRACK__DigitalInput__, ENTER_TRACK );
    
    CLEAR_TRACK = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_TRACK__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_TRACK__DigitalInput__, CLEAR_TRACK );
    
    POLL = new Crestron.Logos.SplusObjects.DigitalInput( POLL__DigitalInput__, this );
    m_DigitalInputList.Add( POLL__DigitalInput__, POLL );
    
    PLAY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PLAY_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PLAY_FB__DigitalOutput__, PLAY_FB );
    
    STOP_FB = new Crestron.Logos.SplusObjects.DigitalOutput( STOP_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( STOP_FB__DigitalOutput__, STOP_FB );
    
    PAUSE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PAUSE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PAUSE_FB__DigitalOutput__, PAUSE_FB );
    
    DISC_PRESENT_FB = new Crestron.Logos.SplusObjects.DigitalOutput( DISC_PRESENT_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISC_PRESENT_FB__DigitalOutput__, DISC_PRESENT_FB );
    
    TRACK_ANA_NUMBER = new Crestron.Logos.SplusObjects.AnalogInput( TRACK_ANA_NUMBER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TRACK_ANA_NUMBER__AnalogSerialInput__, TRACK_ANA_NUMBER );
    
    CURRENT_TRACK_NUMBER = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TRACK_NUMBER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TRACK_NUMBER__AnalogSerialOutput__, CURRENT_TRACK_NUMBER );
    
    TRACK_MINS = new Crestron.Logos.SplusObjects.StringOutput( TRACK_MINS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TRACK_MINS__AnalogSerialOutput__, TRACK_MINS );
    
    TRACK_SECS = new Crestron.Logos.SplusObjects.StringOutput( TRACK_SECS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TRACK_SECS__AnalogSerialOutput__, TRACK_SECS );
    
    TRACK_FRAMES = new Crestron.Logos.SplusObjects.StringOutput( TRACK_FRAMES__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TRACK_FRAMES__AnalogSerialOutput__, TRACK_FRAMES );
    
    TRACK_MANUAL_ENTER = new Crestron.Logos.SplusObjects.StringOutput( TRACK_MANUAL_ENTER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TRACK_MANUAL_ENTER__AnalogSerialOutput__, TRACK_MANUAL_ENTER );
    
    DEVICE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DEVICE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DEVICE_TX__DOLLAR____AnalogSerialOutput__, DEVICE_TX__DOLLAR__ );
    
    DEVICE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DEVICE_RX__DOLLAR____AnalogSerialInput__, 500, this );
    m_StringInputList.Add( DEVICE_RX__DOLLAR____AnalogSerialInput__, DEVICE_RX__DOLLAR__ );
    
    
    PLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( PLAY_OnPush_0, false ) );
    STOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_OnPush_1, false ) );
    PAUSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PAUSE_OnPush_2, false ) );
    EJECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EJECT_OnPush_3, false ) );
    TRACK_BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRACK_BACK_OnPush_4, false ) );
    TRACK_FWD.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRACK_FWD_OnPush_5, false ) );
    POLL.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_OnPush_6, false ) );
    TRACK_ANA_NUMBER.OnAnalogChange.Add( new InputChangeHandlerWrapper( TRACK_ANA_NUMBER_OnChange_7, false ) );
    ENTER_TRACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_TRACK_OnPush_8, false ) );
    CLEAR_TRACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_TRACK_OnPush_9, false ) );
    DEVICE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DEVICE_RX__DOLLAR___OnChange_10, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TASCAM_3SERIES ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PLAY__DigitalInput__ = 0;
const uint STOP__DigitalInput__ = 1;
const uint PAUSE__DigitalInput__ = 2;
const uint TRACK_FWD__DigitalInput__ = 3;
const uint TRACK_BACK__DigitalInput__ = 4;
const uint EJECT__DigitalInput__ = 5;
const uint ENTER_TRACK__DigitalInput__ = 6;
const uint CLEAR_TRACK__DigitalInput__ = 7;
const uint POLL__DigitalInput__ = 8;
const uint TRACK_ANA_NUMBER__AnalogSerialInput__ = 0;
const uint DEVICE_RX__DOLLAR____AnalogSerialInput__ = 1;
const uint PLAY_FB__DigitalOutput__ = 0;
const uint STOP_FB__DigitalOutput__ = 1;
const uint PAUSE_FB__DigitalOutput__ = 2;
const uint DISC_PRESENT_FB__DigitalOutput__ = 3;
const uint CURRENT_TRACK_NUMBER__AnalogSerialOutput__ = 0;
const uint TRACK_MINS__AnalogSerialOutput__ = 1;
const uint TRACK_SECS__AnalogSerialOutput__ = 2;
const uint TRACK_FRAMES__AnalogSerialOutput__ = 3;
const uint TRACK_MANUAL_ENTER__AnalogSerialOutput__ = 4;
const uint DEVICE_TX__DOLLAR____AnalogSerialOutput__ = 5;

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
