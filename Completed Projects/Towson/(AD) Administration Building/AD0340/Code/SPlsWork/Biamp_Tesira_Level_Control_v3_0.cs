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

namespace UserModule_BIAMP_TESIRA_LEVEL_CONTROL_V3_0
{
    public class UserModuleClass_BIAMP_TESIRA_LEVEL_CONTROL_V3_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_LEVEL;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_UP;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SEND_NEW_LEVEL_DB;
        Crestron.Logos.SplusObjects.DigitalInput SEND_NEW_LEVEL_PERCENT;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.AnalogInput NEW_LEVEL_DB;
        Crestron.Logos.SplusObjects.AnalogInput NEW_LEVEL_PERCENT;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_LEVEL_DB;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_LEVEL_PERCENT;
        Crestron.Logos.SplusObjects.StringOutput VOLUME_LEVEL_TEXT;
        StringParameter INSTANCE_TAG;
        StringParameter LEVEL_TYPE;
        UShortParameter INDEX_1;
        UShortParameter INDEX_2;
        UShortParameter LEVEL_STEP;
        UShortParameter COMMAND_PROCESSOR_ID;
        BiampTesiraLib3.LevelComponent COMPONENT;
        ushort ISREADY = 0;
        public void ONINITIALIZECHANGE ( object __sender__ /*BiampTesiraLib3.LevelComponent SENDER */, BiampTesiraLib3.UInt16EventArgs ARGS ) 
            { 
            LevelComponent  SENDER  = (LevelComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 150;
                IS_INITIALIZED  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONLEVELCHANGESIGNEDUNSCALED ( object __sender__ /*BiampTesiraLib3.LevelComponent SENDER */, BiampTesiraLib3.Int16EventArgs ARGS ) 
            { 
            LevelComponent  SENDER  = (LevelComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 155;
                VOLUME_LEVEL_DB  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONLEVELCHANGEPERCENT ( object __sender__ /*BiampTesiraLib3.LevelComponent SENDER */, BiampTesiraLib3.UInt16EventArgs ARGS ) 
            { 
            LevelComponent  SENDER  = (LevelComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 160;
                VOLUME_LEVEL_PERCENT  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONLEVELTEXTCHANGE ( object __sender__ /*BiampTesiraLib3.LevelComponent SENDER */, BiampTesiraLib3.StringEventArgs ARGS ) 
            { 
            LevelComponent  SENDER  = (LevelComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 165;
                MakeString ( VOLUME_LEVEL_TEXT , "{0}", ARGS . Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object LEVEL_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 174;
                COMPONENT . Raise ( ) ; 
                
                
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
            
            __context__.SourceCodeLine = 179;
            COMPONENT . Lower ( ) ; 
            
            
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
        
        __context__.SourceCodeLine = 184;
        COMPONENT . Stop ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEW_LEVEL_DB_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 189;
        if ( Functions.TestForTrue  ( ( SEND_NEW_LEVEL_DB  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 191;
            COMPONENT . SetLevel ( (short)( NEW_LEVEL_DB  .ShortValue )) ; 
            __context__.SourceCodeLine = 192;
            Functions.Delay (  (int) ( 30 ) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_NEW_LEVEL_DB_OnRelease_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 205;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEW_LEVEL_DB  .UshortValue != VOLUME_LEVEL_DB  .Value))  ) ) 
            {
            __context__.SourceCodeLine = 206;
            COMPONENT . SetLevel ( (short)( NEW_LEVEL_DB  .ShortValue )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEW_LEVEL_PERCENT_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 211;
        if ( Functions.TestForTrue  ( ( SEND_NEW_LEVEL_PERCENT  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 213;
            COMPONENT . SetPercent ( (ushort)( NEW_LEVEL_PERCENT  .UshortValue )) ; 
            __context__.SourceCodeLine = 214;
            Functions.Delay (  (int) ( 30 ) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_NEW_LEVEL_PERCENT_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 220;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEW_LEVEL_PERCENT  .UshortValue != VOLUME_LEVEL_PERCENT  .Value))  ) ) 
            {
            __context__.SourceCodeLine = 221;
            COMPONENT . SetPercent ( (ushort)( NEW_LEVEL_PERCENT  .UshortValue )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_LEVEL_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 226;
        COMPONENT . PollState ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 231;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            {
            __context__.SourceCodeLine = 232;
            COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), LEVEL_TYPE  .ToString(), (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value ), (ushort)( LEVEL_STEP  .Value )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 236;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            {
            __context__.SourceCodeLine = 237;
            COMPONENT . UnRegister ( ) ; 
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
        
        __context__.SourceCodeLine = 247;
        ISREADY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 249;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 250;
        // RegisterEvent( COMPONENT , ONINITIALIZECHANGE , ONINITIALIZECHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnInitializeChange  += ONINITIALIZECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 251;
        // RegisterEvent( COMPONENT , ONLEVELCHANGESIGNEDUNSCALED , ONLEVELCHANGESIGNEDUNSCALED ) 
        try { g_criticalSection.Enter(); COMPONENT .OnLevelChangeSignedUnscaled  += ONLEVELCHANGESIGNEDUNSCALED; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 252;
        // RegisterEvent( COMPONENT , ONLEVELCHANGEPERCENT , ONLEVELCHANGEPERCENT ) 
        try { g_criticalSection.Enter(); COMPONENT .OnLevelChangePercent  += ONLEVELCHANGEPERCENT; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 253;
        // RegisterEvent( COMPONENT , ONLEVELTEXTCHANGE , ONLEVELTEXTCHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnLevelTextChange  += ONLEVELTEXTCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 255;
        if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 256;
            COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), LEVEL_TYPE  .ToString(), (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value ), (ushort)( LEVEL_STEP  .Value )) ; 
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
    
    POLL_LEVEL = new Crestron.Logos.SplusObjects.DigitalInput( POLL_LEVEL__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_LEVEL__DigitalInput__, POLL_LEVEL );
    
    LEVEL_UP = new Crestron.Logos.SplusObjects.DigitalInput( LEVEL_UP__DigitalInput__, this );
    m_DigitalInputList.Add( LEVEL_UP__DigitalInput__, LEVEL_UP );
    
    LEVEL_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( LEVEL_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( LEVEL_DOWN__DigitalInput__, LEVEL_DOWN );
    
    SEND_NEW_LEVEL_DB = new Crestron.Logos.SplusObjects.DigitalInput( SEND_NEW_LEVEL_DB__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_NEW_LEVEL_DB__DigitalInput__, SEND_NEW_LEVEL_DB );
    
    SEND_NEW_LEVEL_PERCENT = new Crestron.Logos.SplusObjects.DigitalInput( SEND_NEW_LEVEL_PERCENT__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_NEW_LEVEL_PERCENT__DigitalInput__, SEND_NEW_LEVEL_PERCENT );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    NEW_LEVEL_DB = new Crestron.Logos.SplusObjects.AnalogInput( NEW_LEVEL_DB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NEW_LEVEL_DB__AnalogSerialInput__, NEW_LEVEL_DB );
    
    NEW_LEVEL_PERCENT = new Crestron.Logos.SplusObjects.AnalogInput( NEW_LEVEL_PERCENT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NEW_LEVEL_PERCENT__AnalogSerialInput__, NEW_LEVEL_PERCENT );
    
    VOLUME_LEVEL_DB = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_LEVEL_DB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_LEVEL_DB__AnalogSerialOutput__, VOLUME_LEVEL_DB );
    
    VOLUME_LEVEL_PERCENT = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_LEVEL_PERCENT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_LEVEL_PERCENT__AnalogSerialOutput__, VOLUME_LEVEL_PERCENT );
    
    VOLUME_LEVEL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VOLUME_LEVEL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( VOLUME_LEVEL_TEXT__AnalogSerialOutput__, VOLUME_LEVEL_TEXT );
    
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
    
    LEVEL_TYPE = new StringParameter( LEVEL_TYPE__Parameter__, this );
    m_ParameterList.Add( LEVEL_TYPE__Parameter__, LEVEL_TYPE );
    
    
    LEVEL_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnPush_0, true ) );
    LEVEL_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEVEL_DOWN_OnPush_1, true ) );
    LEVEL_UP.OnDigitalRelease.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnRelease_2, true ) );
    LEVEL_DOWN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( LEVEL_UP_OnRelease_2, true ) );
    NEW_LEVEL_DB.OnAnalogChange.Add( new InputChangeHandlerWrapper( NEW_LEVEL_DB_OnChange_3, true ) );
    SEND_NEW_LEVEL_DB.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SEND_NEW_LEVEL_DB_OnRelease_4, true ) );
    NEW_LEVEL_PERCENT.OnAnalogChange.Add( new InputChangeHandlerWrapper( NEW_LEVEL_PERCENT_OnChange_5, true ) );
    SEND_NEW_LEVEL_PERCENT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SEND_NEW_LEVEL_PERCENT_OnRelease_6, true ) );
    POLL_LEVEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_LEVEL_OnPush_7, true ) );
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_8, true ) );
    ENABLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_OnRelease_9, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    COMPONENT  = new BiampTesiraLib3.LevelComponent();
    
    
}

public UserModuleClass_BIAMP_TESIRA_LEVEL_CONTROL_V3_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_LEVEL__DigitalInput__ = 0;
const uint LEVEL_UP__DigitalInput__ = 1;
const uint LEVEL_DOWN__DigitalInput__ = 2;
const uint SEND_NEW_LEVEL_DB__DigitalInput__ = 3;
const uint SEND_NEW_LEVEL_PERCENT__DigitalInput__ = 4;
const uint ENABLE__DigitalInput__ = 5;
const uint NEW_LEVEL_DB__AnalogSerialInput__ = 0;
const uint NEW_LEVEL_PERCENT__AnalogSerialInput__ = 1;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint VOLUME_LEVEL_DB__AnalogSerialOutput__ = 0;
const uint VOLUME_LEVEL_PERCENT__AnalogSerialOutput__ = 1;
const uint VOLUME_LEVEL_TEXT__AnalogSerialOutput__ = 2;
const uint INSTANCE_TAG__Parameter__ = 10;
const uint LEVEL_TYPE__Parameter__ = 11;
const uint INDEX_1__Parameter__ = 12;
const uint INDEX_2__Parameter__ = 13;
const uint LEVEL_STEP__Parameter__ = 14;
const uint COMMAND_PROCESSOR_ID__Parameter__ = 15;

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
