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

namespace UserModule_SHARP_FLATPANEL_TRAIL_LEAD_SWAP
{
    public class UserModuleClass_SHARP_FLATPANEL_TRAIL_LEAD_SWAP : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput LEADORTRAIL;
        Crestron.Logos.SplusObjects.StringInput IN;
        Crestron.Logos.SplusObjects.StringOutput OUT;
        object IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort FIRSTSPACE = 0;
                ushort LASTSPACE = 0;
                
                
                __context__.SourceCodeLine = 63;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)LEADORTRAIL  .UshortValue);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 67;
                            FIRSTSPACE = (ushort) ( Functions.Find( "\u0020" , IN ) ) ; 
                            __context__.SourceCodeLine = 68;
                            LASTSPACE = (ushort) ( (Functions.Length( IN ) - 1) ) ; 
                            __context__.SourceCodeLine = 69;
                            MakeString ( OUT , "{0}{1}{2}\r", Functions.Left ( IN ,  (int) ( 4 ) ) , Functions.Mid ( IN ,  (int) ( FIRSTSPACE ) ,  (int) ( ((LASTSPACE - FIRSTSPACE) + 1) ) ) , Functions.Mid ( IN ,  (int) ( 5 ) ,  (int) ( (FIRSTSPACE - 5) ) ) ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 73;
                            OUT  .UpdateValue ( IN  ) ; 
                            } 
                        
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
        
        LEADORTRAIL = new Crestron.Logos.SplusObjects.AnalogInput( LEADORTRAIL__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LEADORTRAIL__AnalogSerialInput__, LEADORTRAIL );
        
        IN = new Crestron.Logos.SplusObjects.StringInput( IN__AnalogSerialInput__, 50, this );
        m_StringInputList.Add( IN__AnalogSerialInput__, IN );
        
        OUT = new Crestron.Logos.SplusObjects.StringOutput( OUT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( OUT__AnalogSerialOutput__, OUT );
        
        
        IN.OnSerialChange.Add( new InputChangeHandlerWrapper( IN_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_SHARP_FLATPANEL_TRAIL_LEAD_SWAP ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint LEADORTRAIL__AnalogSerialInput__ = 0;
    const uint IN__AnalogSerialInput__ = 1;
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
