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

namespace UserModule_ATOI_ITOA_WITH_HEADER
{
    public class UserModuleClass_ATOI_ITOA_WITH_HEADER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        StringParameter TXHEADER;
        StringParameter TXFOOTER;
        StringParameter MATCHHEADER;
        Crestron.Logos.SplusObjects.AnalogInput AIN;
        Crestron.Logos.SplusObjects.StringInput SIN;
        Crestron.Logos.SplusObjects.AnalogOutput AOUT;
        Crestron.Logos.SplusObjects.StringOutput SOUT;
        object AIN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 45;
                SOUT  .UpdateValue ( TXHEADER + Functions.ItoA (  (int) ( AIN  .UshortValue ) ) + TXFOOTER  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SIN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 49;
            if ( Functions.TestForTrue  ( ( Functions.Find( MATCHHEADER  , SIN ))  ) ) 
                { 
                __context__.SourceCodeLine = 51;
                AOUT  .Value = (ushort) ( Functions.Atoi( SIN ) ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    AIN = new Crestron.Logos.SplusObjects.AnalogInput( AIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AIN__AnalogSerialInput__, AIN );
    
    AOUT = new Crestron.Logos.SplusObjects.AnalogOutput( AOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AOUT__AnalogSerialOutput__, AOUT );
    
    SIN = new Crestron.Logos.SplusObjects.StringInput( SIN__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( SIN__AnalogSerialInput__, SIN );
    
    SOUT = new Crestron.Logos.SplusObjects.StringOutput( SOUT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOUT__AnalogSerialOutput__, SOUT );
    
    TXHEADER = new StringParameter( TXHEADER__Parameter__, this );
    m_ParameterList.Add( TXHEADER__Parameter__, TXHEADER );
    
    TXFOOTER = new StringParameter( TXFOOTER__Parameter__, this );
    m_ParameterList.Add( TXFOOTER__Parameter__, TXFOOTER );
    
    MATCHHEADER = new StringParameter( MATCHHEADER__Parameter__, this );
    m_ParameterList.Add( MATCHHEADER__Parameter__, MATCHHEADER );
    
    
    AIN.OnAnalogChange.Add( new InputChangeHandlerWrapper( AIN_OnChange_0, false ) );
    SIN.OnSerialChange.Add( new InputChangeHandlerWrapper( SIN_OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ATOI_ITOA_WITH_HEADER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TXHEADER__Parameter__ = 10;
const uint TXFOOTER__Parameter__ = 11;
const uint MATCHHEADER__Parameter__ = 12;
const uint AIN__AnalogSerialInput__ = 0;
const uint SIN__AnalogSerialInput__ = 1;
const uint AOUT__AnalogSerialOutput__ = 0;
const uint SOUT__AnalogSerialOutput__ = 1;

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
