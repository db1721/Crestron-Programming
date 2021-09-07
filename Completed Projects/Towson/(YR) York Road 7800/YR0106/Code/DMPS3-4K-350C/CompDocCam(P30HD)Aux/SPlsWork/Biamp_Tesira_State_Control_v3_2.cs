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
using BiampTesiraLib3.Tesira_Support;
using BiampTesiraLib3.Parser;
using BiampTesiraLib3.Events;
using BiampTesiraLib3.ConfigInfo;
using BiampTesiraLib3.CCI_Support;
using BiampTesiraLib3.Components;
using BiampTesiraLib3.Model;
using BiampTesiraLib3.Comm;
using BiampTesiraLib3;
using CCI_Library;
using CCI_Library.Network;
using CCI_Library.WebScripting;
using CCI_Library.Debugger;

namespace UserModule_BIAMP_TESIRA_STATE_CONTROL_V3_2
{
    public class UserModuleClass_BIAMP_TESIRA_STATE_CONTROL_V3_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_STATE;
        Crestron.Logos.SplusObjects.DigitalInput STATE_ON;
        Crestron.Logos.SplusObjects.DigitalInput STATE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput STATE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput STATE_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput STATE_IS_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput IS_QUARANTINED;
        StringParameter INSTANCE_TAG;
        StringParameter STATE_TYPE;
        UShortParameter INDEX_1;
        UShortParameter INDEX_2;
        UShortParameter COMMAND_PROCESSOR_ID;
        BiampTesiraLib3.Components.StateComponent COMPONENT;
        ushort ISREADY = 0;
        public void ONINITIALIZECHANGE ( object __sender__ /*BiampTesiraLib3.Components.StateComponent SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            StateComponent  SENDER  = (StateComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 120;
                IS_INITIALIZED  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONQUARANTINECHANGE ( object __sender__ /*BiampTesiraLib3.Components.StateComponent SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            StateComponent  SENDER  = (StateComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 125;
                IS_QUARANTINED  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONSTATECHANGE ( object __sender__ /*BiampTesiraLib3.Components.StateComponent SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            StateComponent  SENDER  = (StateComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 130;
                STATE_IS_ON  .Value = (ushort) ( Functions.BoolToInt (ARGS.Payload == 1) ) ; 
                __context__.SourceCodeLine = 131;
                STATE_IS_OFF  .Value = (ushort) ( Functions.BoolToInt (ARGS.Payload == 0) ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object STATE_ON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 140;
                COMPONENT . SetState ( (ushort)( 1 )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STATE_OFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 145;
            COMPONENT . SetState ( (ushort)( 0 )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object STATE_TOGGLE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        COMPONENT . ToggleState ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_STATE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 155;
        COMPONENT . PollState ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 160;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            {
            __context__.SourceCodeLine = 161;
            COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), STATE_TYPE  .ToString(), (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 165;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            {
            __context__.SourceCodeLine = 166;
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
        
        __context__.SourceCodeLine = 177;
        ISREADY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 179;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 180;
        // RegisterEvent( COMPONENT , ONINITIALIZECHANGE , ONINITIALIZECHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnInitializeChange  += ONINITIALIZECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 181;
        // RegisterEvent( COMPONENT , ONQUARANTINECHANGE , ONQUARANTINECHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnQuarantineChange  += ONQUARANTINECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 182;
        // RegisterEvent( COMPONENT , ONSTATECHANGE , ONSTATECHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnStateChange  += ONSTATECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 184;
        if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 185;
            COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), INSTANCE_TAG  .ToString(), STATE_TYPE  .ToString(), (ushort)( INDEX_1  .Value ), (ushort)( INDEX_2  .Value )) ; 
            }
        
        __context__.SourceCodeLine = 187;
        ISREADY = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    POLL_STATE = new Crestron.Logos.SplusObjects.DigitalInput( POLL_STATE__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_STATE__DigitalInput__, POLL_STATE );
    
    STATE_ON = new Crestron.Logos.SplusObjects.DigitalInput( STATE_ON__DigitalInput__, this );
    m_DigitalInputList.Add( STATE_ON__DigitalInput__, STATE_ON );
    
    STATE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( STATE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( STATE_OFF__DigitalInput__, STATE_OFF );
    
    STATE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( STATE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( STATE_TOGGLE__DigitalInput__, STATE_TOGGLE );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    STATE_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( STATE_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( STATE_IS_ON__DigitalOutput__, STATE_IS_ON );
    
    STATE_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( STATE_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( STATE_IS_OFF__DigitalOutput__, STATE_IS_OFF );
    
    IS_QUARANTINED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_QUARANTINED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_QUARANTINED__DigitalOutput__, IS_QUARANTINED );
    
    INDEX_1 = new UShortParameter( INDEX_1__Parameter__, this );
    m_ParameterList.Add( INDEX_1__Parameter__, INDEX_1 );
    
    INDEX_2 = new UShortParameter( INDEX_2__Parameter__, this );
    m_ParameterList.Add( INDEX_2__Parameter__, INDEX_2 );
    
    COMMAND_PROCESSOR_ID = new UShortParameter( COMMAND_PROCESSOR_ID__Parameter__, this );
    m_ParameterList.Add( COMMAND_PROCESSOR_ID__Parameter__, COMMAND_PROCESSOR_ID );
    
    INSTANCE_TAG = new StringParameter( INSTANCE_TAG__Parameter__, this );
    m_ParameterList.Add( INSTANCE_TAG__Parameter__, INSTANCE_TAG );
    
    STATE_TYPE = new StringParameter( STATE_TYPE__Parameter__, this );
    m_ParameterList.Add( STATE_TYPE__Parameter__, STATE_TYPE );
    
    
    STATE_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( STATE_ON_OnPush_0, false ) );
    STATE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( STATE_OFF_OnPush_1, false ) );
    STATE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STATE_TOGGLE_OnPush_2, false ) );
    POLL_STATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_STATE_OnPush_3, false ) );
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_4, false ) );
    ENABLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_OnRelease_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    COMPONENT  = new BiampTesiraLib3.Components.StateComponent();
    
    
}

public UserModuleClass_BIAMP_TESIRA_STATE_CONTROL_V3_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_STATE__DigitalInput__ = 0;
const uint STATE_ON__DigitalInput__ = 1;
const uint STATE_OFF__DigitalInput__ = 2;
const uint STATE_TOGGLE__DigitalInput__ = 3;
const uint ENABLE__DigitalInput__ = 4;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint STATE_IS_ON__DigitalOutput__ = 1;
const uint STATE_IS_OFF__DigitalOutput__ = 2;
const uint IS_QUARANTINED__DigitalOutput__ = 3;
const uint INSTANCE_TAG__Parameter__ = 10;
const uint STATE_TYPE__Parameter__ = 11;
const uint INDEX_1__Parameter__ = 12;
const uint INDEX_2__Parameter__ = 13;
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
