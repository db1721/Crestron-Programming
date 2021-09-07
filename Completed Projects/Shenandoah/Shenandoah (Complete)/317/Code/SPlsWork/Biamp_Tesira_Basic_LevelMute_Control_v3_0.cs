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
using BiampTesiraLib3;
using BiampTesiraLib3.Parser;
using BiampTesiraLib3.Components;
using BiampTesiraLib3.Comm;
using BiampTesiraLib3.Model;
using BiampTesiraLib3.Tesira_Support;
using BiampTesiraLib3.CCI_Support;
using CCI_Library;

namespace UserModule_BIAMP_TESIRA_BASIC_LEVELMUTE_CONTROL_V3_0
{
    public class UserModuleClass_BIAMP_TESIRA_BASIC_LEVELMUTE_CONTROL_V3_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_UP;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalInput MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput MUTE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.DigitalInput SEND_NEW_LEVEL_PERCENT;
        Crestron.Logos.SplusObjects.AnalogInput NEW_LEVEL_PERCENT;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_IS_OFF;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_LEVEL_PERCENT;
        StringParameter INSTANCE_TAG;
        UShortParameter INDEX_1;
        UShortParameter INDEX_2;
        UShortParameter LEVEL_STEP;
        UShortParameter COMMAND_PROCESSOR_ID;
        BiampTesiraLib3.LevelComponent LEVEL;
        BiampTesiraLib3.StateComponent MUTE;
        ushort MUTEINIT = 0;
        ushort LEVELINIT = 0;
        ushort ISREADY = 0;
        public void ONINITIALIZECHANGE ( object __sender__ /*BiampTesiraLib3.Component SENDER */, BiampTesiraLib3.UInt16EventArgs ARGS ) 
            { 
            Component  SENDER  = (Component )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 141;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER == LEVEL))  ) ) 
                    {
                    __context__.SourceCodeLine = 142;
                    LEVELINIT = (ushort) ( ARGS.Payload ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 144;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SENDER == MUTE))  ) ) 
                        {
                        __context__.SourceCodeLine = 145;
                        MUTEINIT = (ushort) ( ARGS.Payload ) ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 147;
                IS_INITIALIZED  .Value = (ushort) ( Functions.BoolToInt ( (Functions.TestForTrue ( LEVELINIT ) && Functions.TestForTrue ( MUTEINIT )) ) ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONLEVELCHANGEPERCENT ( object __sender__ /*BiampTesiraLib3.LevelComponent SENDER */, BiampTesiraLib3.UInt16EventArgs ARGS ) 
            { 
            LevelComponent  SENDER  = (LevelComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 152;
                VOLUME_LEVEL_PERCENT  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONSTATECHANGE ( object __sender__ /*BiampTesiraLib3.StateComponent SENDER */, BiampTesiraLib3.UInt16EventArgs ARGS ) 
            { 
            StateComponent  SENDER  = (StateComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 157;
                MUTE_IS_ON  .Value = (ushort) ( Functions.BoolToInt (ARGS.Payload == 1) ) ; 
                __context__.SourceCodeLine = 158;
                MUTE_IS_OFF  .Value = (ushort) ( Functions.BoolToInt (ARGS.Payload == 0) ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object LEVEL_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 167;
                LEVEL . Raise ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LEVEL_DOWN_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 172;
            LEVEL . Lower ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object LEVEL_UP_OnRelease_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        LEVEL . Stop ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_ON_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 183;
        MUTE . SetState ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_OFF_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 188;
        MUTE . SetState ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_TOGGLE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 193;
        MUTE . ToggleState ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEW_LEVEL_PERCENT_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 198;
        if ( Functions.TestForTrue  ( ( SEND_NEW_LEVEL_PERCENT  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 200;
            LEVEL . SetPercent ( (ushort)( NEW_LEVEL_PERCENT  .UshortValue )) ; 
            __context__.SourceCodeLine = 201;
            Functions.Delay (  (int) ( 30 ) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_NEW_LEVEL_PERCENT_OnRelease_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 207;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEW_LEVEL_PERCENT  .UshortValue != VOLUME_LEVEL_PERCENT  .Value))  ) ) 
            {
            __context__.SourceCodeLine = 208;
            LEVEL . SetPercent ( (ushort)( NEW_LEVEL_PERCENT  .UshortValue )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 213;
        LEVEL . PollState ( ) ; 
        __context__.SourceCodeLine = 214;
        MUTE . PollState ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 219;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            { 
            __context__.SourceCodeLine = 221;
            LEVEL . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), "level", (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value ), (ushort)( LEVEL_STEP  .Value )) ; 
            __context__.SourceCodeLine = 222;
            MUTE . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), "mute", (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnRelease_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 227;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            { 
            __context__.SourceCodeLine = 229;
            LEVEL . UnRegister ( ) ; 
            __context__.SourceCodeLine = 230;
            MUTE . UnRegister ( ) ; 
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
        
        __context__.SourceCodeLine = 241;
        ISREADY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 243;
        MUTEINIT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 244;
        LEVELINIT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 246;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 247;
        // RegisterEvent( LEVEL , ONINITIALIZECHANGE , ONINITIALIZECHANGE ) 
        try { g_criticalSection.Enter(); LEVEL .OnInitializeChange  += ONINITIALIZECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 248;
        // RegisterEvent( LEVEL , ONLEVELCHANGEPERCENT , ONLEVELCHANGEPERCENT ) 
        try { g_criticalSection.Enter(); LEVEL .OnLevelChangePercent  += ONLEVELCHANGEPERCENT; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 249;
        // RegisterEvent( MUTE , ONINITIALIZECHANGE , ONINITIALIZECHANGE ) 
        try { g_criticalSection.Enter(); MUTE .OnInitializeChange  += ONINITIALIZECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 250;
        // RegisterEvent( MUTE , ONSTATECHANGE , ONSTATECHANGE ) 
        try { g_criticalSection.Enter(); MUTE .OnStateChange  += ONSTATECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 252;
        if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 254;
            LEVEL . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), "level", (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value ), (ushort)( LEVEL_STEP  .Value )) ; 
            __context__.SourceCodeLine = 255;
            MUTE . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), "mute", (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value )) ; 
            } 
        
        __context__.SourceCodeLine = 258;
        ISREADY = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    POLL = new Crestron.Logos.SplusObjects.DigitalInput( POLL__DigitalInput__, this );
    m_DigitalInputList.Add( POLL__DigitalInput__, POLL );
    
    LEVEL_UP = new Crestron.Logos.SplusObjects.DigitalInput( LEVEL_UP__DigitalInput__, this );
    m_DigitalInputList.Add( LEVEL_UP__DigitalInput__, LEVEL_UP );
    
    LEVEL_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( LEVEL_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( LEVEL_DOWN__DigitalInput__, LEVEL_DOWN );
    
    MUTE_ON = new Crestron.Logos.SplusObjects.DigitalInput( MUTE_ON__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE_ON__DigitalInput__, MUTE_ON );
    
    MUTE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( MUTE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE_OFF__DigitalInput__, MUTE_OFF );
    
    MUTE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( MUTE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE_TOGGLE__DigitalInput__, MUTE_TOGGLE );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    SEND_NEW_LEVEL_PERCENT = new Crestron.Logos.SplusObjects.DigitalInput( SEND_NEW_LEVEL_PERCENT__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_NEW_LEVEL_PERCENT__DigitalInput__, SEND_NEW_LEVEL_PERCENT );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    MUTE_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_IS_ON__DigitalOutput__, MUTE_IS_ON );
    
    MUTE_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_IS_OFF__DigitalOutput__, MUTE_IS_OFF );
    
    NEW_LEVEL_PERCENT = new Crestron.Logos.SplusObjects.AnalogInput( NEW_LEVEL_PERCENT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NEW_LEVEL_PERCENT__AnalogSerialInput__, NEW_LEVEL_PERCENT );
    
    VOLUME_LEVEL_PERCENT = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_LEVEL_PERCENT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_LEVEL_PERCENT__AnalogSerialOutput__, VOLUME_LEVEL_PERCENT );
    
    INDEX_1 = new UShortParameter( INDEX_1__Parameter__, this );
    m_ParameterList.Add( INDEX_1__Parameter__, INDEX_1 );
    
    INDEX_2 = new UShortParameter( INDEX_2__Parameter__, this );
    m_ParameterList.Add( INDEX_2__Parameter__, INDEX_2 );
    
    LEVEL_STEP = new UShortParameter( LEVEL_STEP__Parameter__, this );
    m_ParameterList.Add( LEVEL_STEP__Parameter__, LEVEL_STEP );
    
    COMMAND_PROCESSOR_ID = new UShortParameter( COMMAND_PROCESSOR_ID__Parameter__, this );
    m_ParameterList.Add( COMMAND_PROCESSOR_ID__Parameter__, COMMAND_PROCESSOR_ID );
    
    INSTANCE_TAG = new StringParameter( INSTANCE_TAG__Parameter__, this );
    m_ParameterList.Add( INSTANCE_TAG__Parameter__, INSTANCE_TAG );
    
    
    LEVEL_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnPush_0, true ) );
    LEVEL_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEVEL_DOWN_OnPush_1, true ) );
    LEVEL_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnRelease_2, true ) );
    LEVEL_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnRelease_2, true ) );
    MUTE_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE_ON_OnPush_3, true ) );
    MUTE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE_OFF_OnPush_4, true ) );
    MUTE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE_TOGGLE_OnPush_5, true ) );
    NEW_LEVEL_PERCENT.OnAnalogChange.Add( new InputChangeHandlerWrapper( NEW_LEVEL_PERCENT_OnChange_6, true ) );
    SEND_NEW_LEVEL_PERCENT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SEND_NEW_LEVEL_PERCENT_OnRelease_7, true ) );
    POLL.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_OnPush_8, true ) );
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_9, true ) );
    ENABLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_OnRelease_10, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    LEVEL  = new BiampTesiraLib3.LevelComponent();
    MUTE  = new BiampTesiraLib3.StateComponent();
    
    
}

public UserModuleClass_BIAMP_TESIRA_BASIC_LEVELMUTE_CONTROL_V3_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL__DigitalInput__ = 0;
const uint LEVEL_UP__DigitalInput__ = 1;
const uint LEVEL_DOWN__DigitalInput__ = 2;
const uint MUTE_ON__DigitalInput__ = 3;
const uint MUTE_OFF__DigitalInput__ = 4;
const uint MUTE_TOGGLE__DigitalInput__ = 5;
const uint ENABLE__DigitalInput__ = 6;
const uint SEND_NEW_LEVEL_PERCENT__DigitalInput__ = 7;
const uint NEW_LEVEL_PERCENT__AnalogSerialInput__ = 0;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint MUTE_IS_ON__DigitalOutput__ = 1;
const uint MUTE_IS_OFF__DigitalOutput__ = 2;
const uint VOLUME_LEVEL_PERCENT__AnalogSerialOutput__ = 0;
const uint INSTANCE_TAG__Parameter__ = 10;
const uint INDEX_1__Parameter__ = 11;
const uint INDEX_2__Parameter__ = 12;
const uint LEVEL_STEP__Parameter__ = 13;
const uint COMMAND_PROCESSOR_ID__Parameter__ = 14;

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
