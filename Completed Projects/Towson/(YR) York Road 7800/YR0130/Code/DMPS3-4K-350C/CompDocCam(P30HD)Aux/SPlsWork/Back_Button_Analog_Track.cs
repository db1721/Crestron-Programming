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

namespace UserModule_BACK_BUTTON_ANALOG_TRACK
{
    public class UserModuleClass_BACK_BUTTON_ANALOG_TRACK : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput BACK;
        Crestron.Logos.SplusObjects.AnalogInput IN;
        Crestron.Logos.SplusObjects.AnalogOutput OUT;
        ushort [] HISTORY;
        object IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort X = 0;
                
                
                __context__.SourceCodeLine = 49;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IN  .UshortValue != HISTORY[ 1 ]))  ) ) 
                    { 
                    __context__.SourceCodeLine = 51;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 20 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)2; 
                    int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                    for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 53;
                        HISTORY [ X] = (ushort) ( HISTORY[ (X - 1) ] ) ; 
                        __context__.SourceCodeLine = 51;
                        } 
                    
                    __context__.SourceCodeLine = 55;
                    HISTORY [ 1] = (ushort) ( IN  .UshortValue ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object BACK_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 61;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HISTORY[ 2 ] > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 63;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)19; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 65;
                    HISTORY [ X] = (ushort) ( HISTORY[ (X + 1) ] ) ; 
                    __context__.SourceCodeLine = 66;
                    HISTORY [ 20] = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 63;
                    } 
                
                __context__.SourceCodeLine = 68;
                OUT  .Value = (ushort) ( HISTORY[ 1 ] ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    HISTORY  = new ushort[ 21 ];
    
    BACK = new Crestron.Logos.SplusObjects.DigitalInput( BACK__DigitalInput__, this );
    m_DigitalInputList.Add( BACK__DigitalInput__, BACK );
    
    IN = new Crestron.Logos.SplusObjects.AnalogInput( IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( IN__AnalogSerialInput__, IN );
    
    OUT = new Crestron.Logos.SplusObjects.AnalogOutput( OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OUT__AnalogSerialOutput__, OUT );
    
    
    IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( IN_OnChange_0, false ) );
    BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( BACK_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BACK_BUTTON_ANALOG_TRACK ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint BACK__DigitalInput__ = 0;
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
