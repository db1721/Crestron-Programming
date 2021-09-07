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

namespace UserModule_INTEGER_TOGGLE
{
    public class UserModuleClass_INTEGER_TOGGLE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput TRIG;
        Crestron.Logos.SplusObjects.AnalogInput IN;
        Crestron.Logos.SplusObjects.AnalogOutput OUT;
        object TRIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 47;
                OUT  .Value = (ushort) ( Functions.Not( OUT  .Value ) ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object IN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 51;
            OUT  .Value = (ushort) ( IN  .UshortValue ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    TRIG = new Crestron.Logos.SplusObjects.DigitalInput( TRIG__DigitalInput__, this );
    m_DigitalInputList.Add( TRIG__DigitalInput__, TRIG );
    
    IN = new Crestron.Logos.SplusObjects.AnalogInput( IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( IN__AnalogSerialInput__, IN );
    
    OUT = new Crestron.Logos.SplusObjects.AnalogOutput( OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OUT__AnalogSerialOutput__, OUT );
    
    
    TRIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRIG_OnPush_0, false ) );
    IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( IN_OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_INTEGER_TOGGLE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TRIG__DigitalInput__ = 0;
const uint IN__AnalogSerialInput__ = 0;
const uint OUT__AnalogSerialOutput__ = 0;

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
