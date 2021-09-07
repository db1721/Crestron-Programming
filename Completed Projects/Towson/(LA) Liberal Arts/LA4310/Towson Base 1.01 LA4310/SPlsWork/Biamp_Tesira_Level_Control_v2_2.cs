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
using BiampTesiraLib;
using BiampTesiraLib.Parser;
using BiampTesiraLib.Components;
using BiampTesiraLib.Comm;
using BiampTesiraLib.Model;
using CCI_Library;

namespace UserModule_BIAMP_TESIRA_LEVEL_CONTROL_V2_2
{
    public class UserModuleClass_BIAMP_TESIRA_LEVEL_CONTROL_V2_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_LEVEL;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_UP;
        Crestron.Logos.SplusObjects.DigitalInput LEVEL_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SEND_NEW_LEVEL_DB;
        Crestron.Logos.SplusObjects.DigitalInput SEND_NEW_LEVEL_PERCENT;
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
        BiampTesiraLib.LevelComponent COMPONENT;
        public void ISINIT ( ushort STATE ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 148;
                IS_INITIALIZED  .Value = (ushort) ( STATE ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONLEVELCHANGESIGNEDUNSCALED ( short LEVEL ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 153;
                VOLUME_LEVEL_DB  .Value = (ushort) ( LEVEL ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONLEVELCHANGEPERCENT ( ushort LEVEL ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 158;
                VOLUME_LEVEL_PERCENT  .Value = (ushort) ( LEVEL ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONLEVELTEXTCHANGE ( SimplSharpString LEVEL ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 163;
                MakeString ( VOLUME_LEVEL_TEXT , "{0}", LEVEL  .ToString() ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object LEVEL_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 172;
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
            
            __context__.SourceCodeLine = 177;
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
        
        __context__.SourceCodeLine = 182;
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
        
        __context__.SourceCodeLine = 187;
        if ( Functions.TestForTrue  ( ( SEND_NEW_LEVEL_DB  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 189;
            COMPONENT . SetLevel ( (short)( NEW_LEVEL_DB  .ShortValue )) ; 
            __context__.SourceCodeLine = 190;
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
        
        __context__.SourceCodeLine = 203;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEW_LEVEL_DB  .UshortValue != VOLUME_LEVEL_DB  .Value))  ) ) 
            {
            __context__.SourceCodeLine = 204;
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
        
        __context__.SourceCodeLine = 209;
        if ( Functions.TestForTrue  ( ( SEND_NEW_LEVEL_PERCENT  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 211;
            COMPONENT . SetPercent ( (ushort)( NEW_LEVEL_PERCENT  .UshortValue )) ; 
            __context__.SourceCodeLine = 212;
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
        
        __context__.SourceCodeLine = 225;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEW_LEVEL_PERCENT  .UshortValue != VOLUME_LEVEL_PERCENT  .Value))  ) ) 
            {
            __context__.SourceCodeLine = 226;
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
        
        __context__.SourceCodeLine = 231;
        COMPONENT . PollState ( ) ; 
        
        
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
        
        __context__.SourceCodeLine = 242;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 243;
        // RegisterDelegate( COMPONENT , ONINITIALIZECHANGE , ISINIT ) 
        COMPONENT .OnInitializeChange  = ISINIT; ; 
        __context__.SourceCodeLine = 244;
        // RegisterDelegate( COMPONENT , ONLEVELCHANGESIGNEDUNSCALED , ONLEVELCHANGESIGNEDUNSCALED ) 
        COMPONENT .OnLevelChangeSignedUnscaled  = ONLEVELCHANGESIGNEDUNSCALED; ; 
        __context__.SourceCodeLine = 245;
        // RegisterDelegate( COMPONENT , ONLEVELCHANGEPERCENT , ONLEVELCHANGEPERCENT ) 
        COMPONENT .OnLevelChangePercent  = ONLEVELCHANGEPERCENT; ; 
        __context__.SourceCodeLine = 246;
        // RegisterDelegate( COMPONENT , ONLEVELTEXTCHANGE , ONLEVELTEXTCHANGE ) 
        COMPONENT .OnLevelTextChange  = ONLEVELTEXTCHANGE; ; 
        __context__.SourceCodeLine = 248;
        COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), LEVEL_TYPE  .ToString(), (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value ), (ushort)( LEVEL_STEP  .Value )) ; 
        
        
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
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    COMPONENT  = new BiampTesiraLib.LevelComponent();
    
    
}

public UserModuleClass_BIAMP_TESIRA_LEVEL_CONTROL_V2_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_LEVEL__DigitalInput__ = 0;
const uint LEVEL_UP__DigitalInput__ = 1;
const uint LEVEL_DOWN__DigitalInput__ = 2;
const uint SEND_NEW_LEVEL_DB__DigitalInput__ = 3;
const uint SEND_NEW_LEVEL_PERCENT__DigitalInput__ = 4;
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
