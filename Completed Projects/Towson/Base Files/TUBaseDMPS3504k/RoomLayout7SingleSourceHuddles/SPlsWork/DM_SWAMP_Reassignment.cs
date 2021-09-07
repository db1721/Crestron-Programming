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

namespace UserModule_DM_SWAMP_REASSIGNMENT
{
    public class UserModuleClass_DM_SWAMP_REASSIGNMENT : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEVICEOFFLINE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> INVAL;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUTVAL;
        InOutArray<UShortParameter> NEWVAL;
        private void INIT (  SplusExecutionContext __context__ ) 
            { 
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 34;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)72; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 36;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INVAL[ X ] .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INVAL[ X ] .UshortValue < 51 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 38;
                    OUTVAL [ X]  .Value = (ushort) ( NEWVAL[ INVAL[ X ] .UshortValue ] .Value ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 42;
                    OUTVAL [ X]  .Value = (ushort) ( INVAL[ X ] .UshortValue ) ; 
                    } 
                
                __context__.SourceCodeLine = 34;
                } 
            
            
            }
            
        object DEVICEOFFLINE_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 48;
                INIT (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INVAL_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 53;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEVICEOFFLINE  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 55;
                X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 56;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INVAL[ X ] .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( INVAL[ X ] .UshortValue < 51 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 58;
                    OUTVAL [ X]  .Value = (ushort) ( NEWVAL[ INVAL[ X ] .UshortValue ] .Value ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 62;
                    OUTVAL [ X]  .Value = (ushort) ( INVAL[ X ] .UshortValue ) ; 
                    } 
                
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    DEVICEOFFLINE = new Crestron.Logos.SplusObjects.DigitalInput( DEVICEOFFLINE__DigitalInput__, this );
    m_DigitalInputList.Add( DEVICEOFFLINE__DigitalInput__, DEVICEOFFLINE );
    
    INVAL = new InOutArray<AnalogInput>( 72, this );
    for( uint i = 0; i < 72; i++ )
    {
        INVAL[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( INVAL__AnalogSerialInput__ + i, INVAL__AnalogSerialInput__, this );
        m_AnalogInputList.Add( INVAL__AnalogSerialInput__ + i, INVAL[i+1] );
    }
    
    OUTVAL = new InOutArray<AnalogOutput>( 72, this );
    for( uint i = 0; i < 72; i++ )
    {
        OUTVAL[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUTVAL__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( OUTVAL__AnalogSerialOutput__ + i, OUTVAL[i+1] );
    }
    
    NEWVAL = new InOutArray<UShortParameter>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        NEWVAL[i+1] = new UShortParameter( NEWVAL__Parameter__ + i, NEWVAL__Parameter__, this );
        m_ParameterList.Add( NEWVAL__Parameter__ + i, NEWVAL[i+1] );
    }
    
    
    DEVICEOFFLINE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( DEVICEOFFLINE_OnRelease_0, false ) );
    for( uint i = 0; i < 72; i++ )
        INVAL[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( INVAL_OnChange_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DM_SWAMP_REASSIGNMENT ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEVICEOFFLINE__DigitalInput__ = 0;
const uint INVAL__AnalogSerialInput__ = 0;
const uint OUTVAL__AnalogSerialOutput__ = 0;
const uint NEWVAL__Parameter__ = 10;

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
