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

namespace UserModule_TOWSON_HIGH_LOW_START_UP_TIMER
{
    public class UserModuleClass_TOWSON_HIGH_LOW_START_UP_TIMER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.AnalogInput TIMER_ANA;
        Crestron.Logos.SplusObjects.AnalogInput SECONDS;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalOutput WARMING_UP;
        Crestron.Logos.SplusObjects.StringOutput TIMER_HIGH_TIME;
        Crestron.Logos.SplusObjects.StringOutput TIMER_LOW_TIME;
        CrestronString LOW_TIME__DOLLAR__;
        CrestronString HIGH_TIME__DOLLAR__;
        object TIMER_ANA_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 19;
                LOW_TIME__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( (TIMER_ANA  .UshortValue - 10) ) )  ) ; 
                __context__.SourceCodeLine = 20;
                HIGH_TIME__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( TIMER_ANA  .UshortValue ) )  ) ; 
                __context__.SourceCodeLine = 21;
                MakeString ( TIMER_HIGH_TIME , "{0}", HIGH_TIME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 22;
                MakeString ( TIMER_LOW_TIME , "{0}", LOW_TIME__DOLLAR__ ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POWER_ON_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 28;
            WARMING_UP  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 30;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , SECONDS  .UshortValue , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 30;
            WARMING_UP  .Value = (ushort) ( 0 ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    LOW_TIME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    HIGH_TIME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON__DigitalInput__, POWER_ON );
    
    WARMING_UP = new Crestron.Logos.SplusObjects.DigitalOutput( WARMING_UP__DigitalOutput__, this );
    m_DigitalOutputList.Add( WARMING_UP__DigitalOutput__, WARMING_UP );
    
    TIMER_ANA = new Crestron.Logos.SplusObjects.AnalogInput( TIMER_ANA__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TIMER_ANA__AnalogSerialInput__, TIMER_ANA );
    
    SECONDS = new Crestron.Logos.SplusObjects.AnalogInput( SECONDS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SECONDS__AnalogSerialInput__, SECONDS );
    
    TIMER_HIGH_TIME = new Crestron.Logos.SplusObjects.StringOutput( TIMER_HIGH_TIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TIMER_HIGH_TIME__AnalogSerialOutput__, TIMER_HIGH_TIME );
    
    TIMER_LOW_TIME = new Crestron.Logos.SplusObjects.StringOutput( TIMER_LOW_TIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TIMER_LOW_TIME__AnalogSerialOutput__, TIMER_LOW_TIME );
    
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    
    TIMER_ANA.OnAnalogChange.Add( new InputChangeHandlerWrapper( TIMER_ANA_OnChange_0, false ) );
    POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TOWSON_HIGH_LOW_START_UP_TIMER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;


const uint TIMER_ANA__AnalogSerialInput__ = 0;
const uint SECONDS__AnalogSerialInput__ = 1;
const uint POWER_ON__DigitalInput__ = 0;
const uint WARMING_UP__DigitalOutput__ = 0;
const uint TIMER_HIGH_TIME__AnalogSerialOutput__ = 0;
const uint TIMER_LOW_TIME__AnalogSerialOutput__ = 1;

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
