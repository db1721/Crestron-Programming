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

namespace UserModule_EXTRON_AV_ROUTER
{
    public class UserModuleClass_EXTRON_AV_ROUTER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput INDECIMAL;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        UShortParameter OUTPUT;
        StringParameter ROUTETYPE;
        object INDECIMAL_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 101;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( OUTPUT  .Value > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 103;
                    TX__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( INDECIMAL  .UshortValue ) ) + "*" + Functions.ItoA (  (int) ( OUTPUT  .Value ) ) + ROUTETYPE  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 107;
                    TX__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( INDECIMAL  .UshortValue ) ) + "!"  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        SocketInfo __socketinfo__ = new SocketInfo( 1, this );
        InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
        _SplusNVRAM = new SplusNVRAM( this );
        
        INDECIMAL = new Crestron.Logos.SplusObjects.AnalogInput( INDECIMAL__AnalogSerialInput__, this );
        m_AnalogInputList.Add( INDECIMAL__AnalogSerialInput__, INDECIMAL );
        
        TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
        
        OUTPUT = new UShortParameter( OUTPUT__Parameter__, this );
        m_ParameterList.Add( OUTPUT__Parameter__, OUTPUT );
        
        ROUTETYPE = new StringParameter( ROUTETYPE__Parameter__, this );
        m_ParameterList.Add( ROUTETYPE__Parameter__, ROUTETYPE );
        
        
        INDECIMAL.OnAnalogChange.Add( new InputChangeHandlerWrapper( INDECIMAL_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_EXTRON_AV_ROUTER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint INDECIMAL__AnalogSerialInput__ = 0;
    const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
    const uint OUTPUT__Parameter__ = 10;
    const uint ROUTETYPE__Parameter__ = 11;
    
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
