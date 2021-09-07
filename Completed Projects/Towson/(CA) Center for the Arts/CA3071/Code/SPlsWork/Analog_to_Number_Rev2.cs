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

namespace UserModule_ANALOG_TO_NUMBER_REV2
{
    public class UserModuleClass_ANALOG_TO_NUMBER_REV2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.AnalogInput VALUE;
        Crestron.Logos.SplusObjects.StringOutput NUM__DOLLAR__;
        object VALUE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 129;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE  .UshortValue == 59))  ) ) 
                    { 
                    __context__.SourceCodeLine = 129;
                    _SplusNVRAM.MINS = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 130;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE  .UshortValue == 119))  ) ) 
                    { 
                    __context__.SourceCodeLine = 130;
                    _SplusNVRAM.MINS = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 131;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE  .UshortValue == 179))  ) ) 
                    { 
                    __context__.SourceCodeLine = 131;
                    _SplusNVRAM.MINS = (ushort) ( 2 ) ; 
                    } 
                
                __context__.SourceCodeLine = 132;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE  .UshortValue == 239))  ) ) 
                    { 
                    __context__.SourceCodeLine = 132;
                    _SplusNVRAM.MINS = (ushort) ( 3 ) ; 
                    } 
                
                __context__.SourceCodeLine = 133;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE  .UshortValue == 299))  ) ) 
                    { 
                    __context__.SourceCodeLine = 133;
                    _SplusNVRAM.MINS = (ushort) ( 4 ) ; 
                    } 
                
                __context__.SourceCodeLine = 134;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE  .UshortValue == 300))  ) ) 
                    { 
                    __context__.SourceCodeLine = 134;
                    _SplusNVRAM.MINS = (ushort) ( 5 ) ; 
                    } 
                
                __context__.SourceCodeLine = 135;
                Print( "mins = {0:d}", (short)_SplusNVRAM.MINS) ; 
                __context__.SourceCodeLine = 140;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.MINS == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 142;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( VALUE  .UshortValue > 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 142;
                        MakeString ( NUM__DOLLAR__ , "00:{0:d}", (short)VALUE  .UshortValue) ; 
                        } 
                    
                    __context__.SourceCodeLine = 143;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VALUE  .UshortValue == 10))  ) ) 
                        { 
                        __context__.SourceCodeLine = 143;
                        MakeString ( NUM__DOLLAR__ , "00:{0:d}", (short)VALUE  .UshortValue) ; 
                        } 
                    
                    __context__.SourceCodeLine = 144;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( VALUE  .UshortValue < 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 144;
                        MakeString ( NUM__DOLLAR__ , "00:0{0:d}", (short)VALUE  .UshortValue) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 148;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.MINS == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 150;
                    _SplusNVRAM.SEC = (ushort) ( (VALUE  .UshortValue - 60) ) ; 
                    __context__.SourceCodeLine = 151;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC >= 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 151;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
                        } 
                    
                    __context__.SourceCodeLine = 152;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC < 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 152;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:0{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 154;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.MINS == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 156;
                    _SplusNVRAM.SEC = (ushort) ( (VALUE  .UshortValue - 120) ) ; 
                    __context__.SourceCodeLine = 157;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC >= 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 157;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
                        } 
                    
                    __context__.SourceCodeLine = 158;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC < 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 158;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:0{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 161;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.MINS == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 163;
                    _SplusNVRAM.SEC = (ushort) ( (VALUE  .UshortValue - 180) ) ; 
                    __context__.SourceCodeLine = 164;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC >= 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 164;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
                        } 
                    
                    __context__.SourceCodeLine = 165;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC < 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 165;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:0{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 168;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.MINS == 4))  ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    _SplusNVRAM.SEC = (ushort) ( (VALUE  .UshortValue - 240) ) ; 
                    __context__.SourceCodeLine = 171;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC >= 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 171;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
                        } 
                    
                    __context__.SourceCodeLine = 172;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.SEC < 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 172;
                        MakeString ( NUM__DOLLAR__ , "{0:d}:0{1:d}", (short)_SplusNVRAM.MINS, (short)_SplusNVRAM.SEC) ; 
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
        
        VALUE = new Crestron.Logos.SplusObjects.AnalogInput( VALUE__AnalogSerialInput__, this );
        m_AnalogInputList.Add( VALUE__AnalogSerialInput__, VALUE );
        
        NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NUM__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( NUM__DOLLAR____AnalogSerialOutput__, NUM__DOLLAR__ );
        
        
        VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( VALUE_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_ANALOG_TO_NUMBER_REV2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint VALUE__AnalogSerialInput__ = 0;
    const uint NUM__DOLLAR____AnalogSerialOutput__ = 0;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        [SplusStructAttribute(0, false, true)]
            public ushort SEC = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort MINS = 0;
            
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
