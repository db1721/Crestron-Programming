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

namespace UserModule_BIAMP_TESIRA_PRESET_CONTROL_V3_2
{
    public class UserModuleClass_BIAMP_TESIRA_PRESET_CONTROL_V3_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput RECALL_PRESET;
        Crestron.Logos.SplusObjects.StringInput PRESET_NAME_NUMBER;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        UShortParameter COMMAND_PROCESSOR_ID;
        BiampTesiraLib3.Components.PresetComponent COMPONENT;
        public void ONINITIALIZECHANGE ( object __sender__ /*BiampTesiraLib3.Components.PresetComponent SENDER */, BiampTesiraLib3.Events.UInt16EventArgs ARGS ) 
            { 
            PresetComponent  SENDER  = (PresetComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 106;
                IS_INITIALIZED  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object RECALL_PRESET_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 116;
                COMPONENT . RecallPreset ( PRESET_NAME_NUMBER .ToString()) ; 
                
                
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
            
            __context__.SourceCodeLine = 127;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 128;
            // RegisterEvent( COMPONENT , ONINITIALIZECHANGE , ONINITIALIZECHANGE ) 
            try { g_criticalSection.Enter(); COMPONENT .OnInitializeChange  += ONINITIALIZECHANGE; } finally { g_criticalSection.Leave(); }
            ; 
            __context__.SourceCodeLine = 130;
            COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        RECALL_PRESET = new Crestron.Logos.SplusObjects.DigitalInput( RECALL_PRESET__DigitalInput__, this );
        m_DigitalInputList.Add( RECALL_PRESET__DigitalInput__, RECALL_PRESET );
        
        IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
        m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
        
        PRESET_NAME_NUMBER = new Crestron.Logos.SplusObjects.StringInput( PRESET_NAME_NUMBER__AnalogSerialInput__, 50, this );
        m_StringInputList.Add( PRESET_NAME_NUMBER__AnalogSerialInput__, PRESET_NAME_NUMBER );
        
        COMMAND_PROCESSOR_ID = new UShortParameter( COMMAND_PROCESSOR_ID__Parameter__, this );
        m_ParameterList.Add( COMMAND_PROCESSOR_ID__Parameter__, COMMAND_PROCESSOR_ID );
        
        
        RECALL_PRESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_PRESET_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        COMPONENT  = new BiampTesiraLib3.Components.PresetComponent();
        
        
    }
    
    public UserModuleClass_BIAMP_TESIRA_PRESET_CONTROL_V3_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint RECALL_PRESET__DigitalInput__ = 0;
    const uint PRESET_NAME_NUMBER__AnalogSerialInput__ = 0;
    const uint IS_INITIALIZED__DigitalOutput__ = 0;
    const uint COMMAND_PROCESSOR_ID__Parameter__ = 10;
    
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
