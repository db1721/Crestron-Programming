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

namespace UserModule_STRINGPRESUF
{
    public class UserModuleClass_STRINGPRESUF : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.StringInput IN;
        Crestron.Logos.SplusObjects.StringOutput OUT;
        StringParameter PRE;
        StringParameter SUF;
        object IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 46;
                if ( Functions.TestForTrue  ( ( Functions.Length( IN ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 48;
                    OUT  .UpdateValue ( PRE + IN + SUF  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 52;
                    OUT  .UpdateValue ( ""  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        IN = new Crestron.Logos.SplusObjects.StringInput( IN__AnalogSerialInput__, 250, this );
        m_StringInputList.Add( IN__AnalogSerialInput__, IN );
        
        OUT = new Crestron.Logos.SplusObjects.StringOutput( OUT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( OUT__AnalogSerialOutput__, OUT );
        
        PRE = new StringParameter( PRE__Parameter__, this );
        m_ParameterList.Add( PRE__Parameter__, PRE );
        
        SUF = new StringParameter( SUF__Parameter__, this );
        m_ParameterList.Add( SUF__Parameter__, SUF );
        
        
        IN.OnSerialChange.Add( new InputChangeHandlerWrapper( IN_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_STRINGPRESUF ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint IN__AnalogSerialInput__ = 0;
    const uint OUT__AnalogSerialOutput__ = 0;
    const uint PRE__Parameter__ = 10;
    const uint SUF__Parameter__ = 11;
    
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
