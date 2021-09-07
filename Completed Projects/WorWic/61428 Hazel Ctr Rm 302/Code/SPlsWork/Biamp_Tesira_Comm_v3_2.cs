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

namespace UserModule_BIAMP_TESIRA_COMM_V3_2
{
    public class UserModuleClass_BIAMP_TESIRA_COMM_V3_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CONNECT;
        Crestron.Logos.SplusObjects.DigitalInput DISCONNECT;
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.StringInput IPADDRESS;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.DigitalOutput IS_COMMUNICATING;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput REGISTERED_COMPONENT_COUNT;
        Crestron.Logos.SplusObjects.AnalogOutput QUARANTINED_COMPONENT_COUNT;
        UShortParameter CONTROL_TYPE;
        UShortParameter COMMAND_PROCESSOR_ID;
        StringParameter IP_ADDRESS;
        StringParameter USERNAME;
        StringParameter PASSWORD;
        BiampTesiraLib3.BiampTesira TESIRA;
        CrestronString MYIPADDRESS;
        public void ONSENDDEBUG ( object __sender__ /*BiampTesiraLib3.BiampTesira SENDER */, BiampTesiraLib3.Events.StringEventArgs ARGS ) 
            { 
            BiampTesira  SENDER  = (BiampTesira )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 133;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 134;
                    Trace( "{0}", ARGS . Payload ) ; 
                    }
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONINITIALIZECHANGE ( object __sender__ /*BiampTesiraLib3.BiampTesira SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            BiampTesira  SENDER  = (BiampTesira )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 139;
                IS_INITIALIZED  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONCOMMUNICATINGCHANGE ( object __sender__ /*BiampTesiraLib3.BiampTesira SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            BiampTesira  SENDER  = (BiampTesira )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 144;
                IS_COMMUNICATING  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONRS232TRANSMIT ( object __sender__ /*BiampTesiraLib3.BiampTesira SENDER */, BiampTesiraLib3.Events.StringEventArgs ARGS ) 
            { 
            BiampTesira  SENDER  = (BiampTesira )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 149;
                MakeString ( TO_DEVICE__DOLLAR__ , "{0}", ARGS . Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONREGISTEREDCOMPONENTCOUNTCHANGE ( object __sender__ /*BiampTesiraLib3.BiampTesira SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            BiampTesira  SENDER  = (BiampTesira )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 154;
                REGISTERED_COMPONENT_COUNT  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONQUARANTINEDCOMPONENTCOUNTCHANGE ( object __sender__ /*BiampTesiraLib3.BiampTesira SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            BiampTesira  SENDER  = (BiampTesira )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 159;
                QUARANTINED_COMPONENT_COUNT  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 169;
                TESIRA . Initialize ( (ushort)( 1 )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INITIALIZE_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 173;
            TESIRA . Initialize ( (ushort)( 0 )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CONNECT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 178;
        TESIRA . Connect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISCONNECT_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 183;
        TESIRA . Disconnect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString MSG;
        MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
        
        
        __context__.SourceCodeLine = 190;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 192;
            try 
                { 
                __context__.SourceCodeLine = 194;
                MSG  .UpdateValue ( Functions.Gather ( 1, FROM_DEVICE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 195;
                TESIRA . RS232Response ( MSG .ToString()) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 199;
                Trace( "Issue with Device Rx message handeling\r\n") ; 
                
                }
                
                __context__.SourceCodeLine = 190;
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
        
        __context__.SourceCodeLine = 212;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 214;
        // RegisterEvent( TESIRA , ONSENDDEBUG , ONSENDDEBUG ) 
        try { g_criticalSection.Enter(); TESIRA .OnSendDebug  += ONSENDDEBUG; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 215;
        // RegisterEvent( TESIRA , ONINITIALIZECHANGE , ONINITIALIZECHANGE ) 
        try { g_criticalSection.Enter(); TESIRA .OnInitializeChange  += ONINITIALIZECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 216;
        // RegisterEvent( TESIRA , ONCOMMUNICATINGCHANGE , ONCOMMUNICATINGCHANGE ) 
        try { g_criticalSection.Enter(); TESIRA .OnCommunicatingChange  += ONCOMMUNICATINGCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 217;
        // RegisterEvent( TESIRA , ONRS232TRANSMIT , ONRS232TRANSMIT ) 
        try { g_criticalSection.Enter(); TESIRA .OnRS232Transmit  += ONRS232TRANSMIT; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 219;
        // RegisterEvent( TESIRA , ONREGISTEREDCOMPONENTCOUNTCHANGE , ONREGISTEREDCOMPONENTCOUNTCHANGE ) 
        try { g_criticalSection.Enter(); TESIRA .OnRegisteredComponentCountChange  += ONREGISTEREDCOMPONENTCOUNTCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 220;
        // RegisterEvent( TESIRA , ONQUARANTINEDCOMPONENTCOUNTCHANGE , ONQUARANTINEDCOMPONENTCOUNTCHANGE ) 
        try { g_criticalSection.Enter(); TESIRA .OnQuarantinedComponentCountChange  += ONQUARANTINEDCOMPONENTCOUNTCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 223;
        Functions.Delay (  (int) ( 2500 ) ) ; 
        __context__.SourceCodeLine = 226;
        MYIPADDRESS  .UpdateValue ( IP_ADDRESS  ) ; 
        __context__.SourceCodeLine = 228;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( IPADDRESS ) > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 229;
            MYIPADDRESS  .UpdateValue ( IPADDRESS  ) ; 
            }
        
        __context__.SourceCodeLine = 231;
        TESIRA . Configure ( (ushort)( CONTROL_TYPE  .Value ), (ushort)( COMMAND_PROCESSOR_ID  .Value ), MYIPADDRESS .ToString(), USERNAME  .ToString(), PASSWORD  .ToString()) ; 
        __context__.SourceCodeLine = 233;
        if ( Functions.TestForTrue  ( ( CONNECT  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 234;
            TESIRA . Connect ( ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    MYIPADDRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CONNECT = new Crestron.Logos.SplusObjects.DigitalInput( CONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECT__DigitalInput__, CONNECT );
    
    DISCONNECT = new Crestron.Logos.SplusObjects.DigitalInput( DISCONNECT__DigitalInput__, this );
    m_DigitalInputList.Add( DISCONNECT__DigitalInput__, DISCONNECT );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    IS_COMMUNICATING = new Crestron.Logos.SplusObjects.DigitalOutput( IS_COMMUNICATING__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_COMMUNICATING__DigitalOutput__, IS_COMMUNICATING );
    
    REGISTERED_COMPONENT_COUNT = new Crestron.Logos.SplusObjects.AnalogOutput( REGISTERED_COMPONENT_COUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( REGISTERED_COMPONENT_COUNT__AnalogSerialOutput__, REGISTERED_COMPONENT_COUNT );
    
    QUARANTINED_COMPONENT_COUNT = new Crestron.Logos.SplusObjects.AnalogOutput( QUARANTINED_COMPONENT_COUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( QUARANTINED_COMPONENT_COUNT__AnalogSerialOutput__, QUARANTINED_COMPONENT_COUNT );
    
    IPADDRESS = new Crestron.Logos.SplusObjects.StringInput( IPADDRESS__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( IPADDRESS__AnalogSerialInput__, IPADDRESS );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 10000, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    CONTROL_TYPE = new UShortParameter( CONTROL_TYPE__Parameter__, this );
    m_ParameterList.Add( CONTROL_TYPE__Parameter__, CONTROL_TYPE );
    
    COMMAND_PROCESSOR_ID = new UShortParameter( COMMAND_PROCESSOR_ID__Parameter__, this );
    m_ParameterList.Add( COMMAND_PROCESSOR_ID__Parameter__, COMMAND_PROCESSOR_ID );
    
    IP_ADDRESS = new StringParameter( IP_ADDRESS__Parameter__, this );
    m_ParameterList.Add( IP_ADDRESS__Parameter__, IP_ADDRESS );
    
    USERNAME = new StringParameter( USERNAME__Parameter__, this );
    m_ParameterList.Add( USERNAME__Parameter__, USERNAME );
    
    PASSWORD = new StringParameter( PASSWORD__Parameter__, this );
    m_ParameterList.Add( PASSWORD__Parameter__, PASSWORD );
    
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    INITIALIZE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( INITIALIZE_OnRelease_1, false ) );
    CONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECT_OnPush_2, false ) );
    DISCONNECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISCONNECT_OnPush_3, false ) );
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_4, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    TESIRA  = new BiampTesiraLib3.BiampTesira();
    
    
}

public UserModuleClass_BIAMP_TESIRA_COMM_V3_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CONNECT__DigitalInput__ = 0;
const uint DISCONNECT__DigitalInput__ = 1;
const uint INITIALIZE__DigitalInput__ = 2;
const uint DEBUG__DigitalInput__ = 3;
const uint IPADDRESS__AnalogSerialInput__ = 0;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 1;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint IS_COMMUNICATING__DigitalOutput__ = 1;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 0;
const uint REGISTERED_COMPONENT_COUNT__AnalogSerialOutput__ = 1;
const uint QUARANTINED_COMPONENT_COUNT__AnalogSerialOutput__ = 2;
const uint CONTROL_TYPE__Parameter__ = 10;
const uint COMMAND_PROCESSOR_ID__Parameter__ = 11;
const uint IP_ADDRESS__Parameter__ = 12;
const uint USERNAME__Parameter__ = 13;
const uint PASSWORD__Parameter__ = 14;

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
