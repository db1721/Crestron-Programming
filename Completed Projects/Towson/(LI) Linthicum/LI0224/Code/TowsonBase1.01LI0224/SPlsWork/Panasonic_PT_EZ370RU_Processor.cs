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

namespace UserModule_PANASONIC_PT_EZ370RU_PROCESSOR
{
    public class UserModuleClass_PANASONIC_PT_EZ370RU_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput LAMP_REQUESTED;
        Crestron.Logos.SplusObjects.StringInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP_HOURS;
        object FROM_DEVICE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString LAMP_HOURS__DOLLAR__;
                LAMP_HOURS__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
                
                
                __context__.SourceCodeLine = 78;
                if ( Functions.TestForTrue  ( ( LAMP_REQUESTED  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 80;
                    LAMP_HOURS__DOLLAR__  .UpdateValue ( Functions.Mid ( FROM_DEVICE ,  (int) ( 2 ) ,  (int) ( 6 ) )  ) ; 
                    __context__.SourceCodeLine = 81;
                    LAMP_HOURS  .Value = (ushort) ( Functions.Atoi( LAMP_HOURS__DOLLAR__ ) ) ; 
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
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        LAMP_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( LAMP_REQUESTED__DigitalInput__, this );
        m_DigitalInputList.Add( LAMP_REQUESTED__DigitalInput__, LAMP_REQUESTED );
        
        LAMP_HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP_HOURS__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( LAMP_HOURS__AnalogSerialOutput__, LAMP_HOURS );
        
        FROM_DEVICE = new Crestron.Logos.SplusObjects.StringInput( FROM_DEVICE__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
        
        
        FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_PANASONIC_PT_EZ370RU_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint LAMP_REQUESTED__DigitalInput__ = 0;
    const uint FROM_DEVICE__AnalogSerialInput__ = 0;
    const uint LAMP_HOURS__AnalogSerialOutput__ = 0;
    
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
