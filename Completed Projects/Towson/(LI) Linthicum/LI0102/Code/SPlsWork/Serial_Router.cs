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

namespace UserModule_SERIAL_ROUTER
{
    public class UserModuleClass_SERIAL_ROUTER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SIN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> OUTPUTSOURCE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> OUTPUTSOURCESTRING;
        object OUTPUTSOURCE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort X = 0;
                
                
                __context__.SourceCodeLine = 42;
                X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 43;
                OUTPUTSOURCESTRING [ X]  .UpdateValue ( SIN [ OUTPUTSOURCE[ X ] .UshortValue ]  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        OUTPUTSOURCE = new InOutArray<AnalogInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            OUTPUTSOURCE[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( OUTPUTSOURCE__AnalogSerialInput__ + i, OUTPUTSOURCE__AnalogSerialInput__, this );
            m_AnalogInputList.Add( OUTPUTSOURCE__AnalogSerialInput__ + i, OUTPUTSOURCE[i+1] );
        }
        
        SIN = new InOutArray<StringInput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            SIN[i+1] = new Crestron.Logos.SplusObjects.StringInput( SIN__AnalogSerialInput__ + i, SIN__AnalogSerialInput__, 250, this );
            m_StringInputList.Add( SIN__AnalogSerialInput__ + i, SIN[i+1] );
        }
        
        OUTPUTSOURCESTRING = new InOutArray<StringOutput>( 50, this );
        for( uint i = 0; i < 50; i++ )
        {
            OUTPUTSOURCESTRING[i+1] = new Crestron.Logos.SplusObjects.StringOutput( OUTPUTSOURCESTRING__AnalogSerialOutput__ + i, this );
            m_StringOutputList.Add( OUTPUTSOURCESTRING__AnalogSerialOutput__ + i, OUTPUTSOURCESTRING[i+1] );
        }
        
        
        for( uint i = 0; i < 50; i++ )
            OUTPUTSOURCE[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( OUTPUTSOURCE_OnChange_0, false ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SERIAL_ROUTER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SIN__AnalogSerialInput__ = 0;
    const uint OUTPUTSOURCE__AnalogSerialInput__ = 50;
    const uint OUTPUTSOURCESTRING__AnalogSerialOutput__ = 0;
    
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
