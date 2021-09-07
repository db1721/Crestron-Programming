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

namespace CrestronModule_LG_L32___L37___L42_PROCESSOR
{
    public class CrestronModuleClass_LG_L32___L37___L42_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DIGITALIN;
        Crestron.Logos.SplusObjects.AnalogInput ADDRESS;
        Crestron.Logos.SplusObjects.BufferInput FROMDEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TODEVICE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ANALOGOUT;
        private ushort CALCULATE (  SplusExecutionContext __context__, ushort MSB , ushort LSB ) 
            { 
            
            __context__.SourceCodeLine = 56;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MSB < 58 ))  ) ) 
                {
                __context__.SourceCodeLine = 57;
                MSB = (ushort) ( (MSB - 48) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 59;
                MSB = (ushort) ( (MSB - 87) ) ; 
                }
            
            __context__.SourceCodeLine = 60;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LSB < 58 ))  ) ) 
                {
                __context__.SourceCodeLine = 61;
                LSB = (ushort) ( (LSB - 48) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 63;
                LSB = (ushort) ( (LSB - 87) ) ; 
                }
            
            __context__.SourceCodeLine = 64;
            return (ushort)( ((MSB * 16) + LSB)) ; 
            
            }
            
        object DIGITALIN_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 73;
                _SplusNVRAM.ELEMENT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DIGITALIN_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 78;
            _SplusNVRAM.ELEMENT = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SEND_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 83;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.ELEMENT < 7 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.ELEMENT > 0 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 85;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ] < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 87;
                _SplusNVRAM.STORAGE [ _SplusNVRAM.ELEMENT] = (ushort) ( (_SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ] + 1) ) ; 
                __context__.SourceCodeLine = 88;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)_SplusNVRAM.ELEMENT);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 90;
                            MakeString ( TODEVICE__DOLLAR__ , "kg {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 91;
                            MakeString ( TODEVICE__DOLLAR__ , "kh {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 92;
                            MakeString ( TODEVICE__DOLLAR__ , "ki {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 93;
                            MakeString ( TODEVICE__DOLLAR__ , "kj {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 94;
                            MakeString ( TODEVICE__DOLLAR__ , "kk {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 95;
                            MakeString ( TODEVICE__DOLLAR__ , "kf {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ _SplusNVRAM.ELEMENT ]) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 99;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.ELEMENT > 6 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.ELEMENT < 13 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 101;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ] > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 103;
                    _SplusNVRAM.STORAGE [ (_SplusNVRAM.ELEMENT - 6)] = (ushort) ( (_SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ] - 1) ) ; 
                    __context__.SourceCodeLine = 104;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_2__ = ((int)(_SplusNVRAM.ELEMENT - 6));
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 106;
                                MakeString ( TODEVICE__DOLLAR__ , "kg {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 107;
                                MakeString ( TODEVICE__DOLLAR__ , "kh {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 108;
                                MakeString ( TODEVICE__DOLLAR__ , "ki {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 109;
                                MakeString ( TODEVICE__DOLLAR__ , "kj {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 110;
                                MakeString ( TODEVICE__DOLLAR__ , "kk {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 111;
                                MakeString ( TODEVICE__DOLLAR__ , "kf {0:X2} {1:X2}\r", ADDRESS  .UshortValue, _SplusNVRAM.STORAGE[ (_SplusNVRAM.ELEMENT - 6) ]) ; 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROMDEVICE__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 121;
            _SplusNVRAM.SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 122;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROMDEVICE__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( FROMDEVICE__DOLLAR__ ) > 8 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 124;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NG" , FROMDEVICE__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 126;
                    _SplusNVRAM.TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROMDEVICE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 127;
                    _SplusNVRAM.TEMPSTRING__DOLLAR__  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 129;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FROMDEVICE__DOLLAR__ ) > 9 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 131;
                        _SplusNVRAM.TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROMDEVICE__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 132;
                        _SplusNVRAM.IDRECEIVED = (ushort) ( CALCULATE( __context__ , (ushort)( Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 3 ) ) ) , (ushort)( Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 4 ) ) ) ) ) ; 
                        __context__.SourceCodeLine = 133;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IDRECEIVED == ADDRESS  .UshortValue))  ) ) 
                            { 
                            __context__.SourceCodeLine = 135;
                            _SplusNVRAM.PARAMETER = (ushort) ( Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 1 ) ) ) ; 
                            __context__.SourceCodeLine = 136;
                            _SplusNVRAM.VALUE = (ushort) ( CALCULATE( __context__ , (ushort)( Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 8 ) ) ) , (ushort)( Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 9 ) ) ) ) ) ; 
                            __context__.SourceCodeLine = 137;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_3__ = ((int)_SplusNVRAM.PARAMETER);
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 103) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 141;
                                        ANALOGOUT [ 1]  .Value = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        __context__.SourceCodeLine = 142;
                                        _SplusNVRAM.STORAGE [ 1] = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 104) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 146;
                                        ANALOGOUT [ 2]  .Value = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        __context__.SourceCodeLine = 147;
                                        _SplusNVRAM.STORAGE [ 2] = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 105) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 151;
                                        ANALOGOUT [ 3]  .Value = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        __context__.SourceCodeLine = 152;
                                        _SplusNVRAM.STORAGE [ 3] = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 106) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 156;
                                        ANALOGOUT [ 4]  .Value = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        __context__.SourceCodeLine = 157;
                                        _SplusNVRAM.STORAGE [ 4] = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 107) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 161;
                                        ANALOGOUT [ 5]  .Value = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        __context__.SourceCodeLine = 162;
                                        _SplusNVRAM.STORAGE [ 5] = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 102) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 166;
                                        ANALOGOUT [ 6]  .Value = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        __context__.SourceCodeLine = 167;
                                        _SplusNVRAM.STORAGE [ 6] = (ushort) ( _SplusNVRAM.VALUE ) ; 
                                        } 
                                    
                                    } 
                                    
                                }
                                
                            
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 122;
                } 
            
            __context__.SourceCodeLine = 173;
            _SplusNVRAM.SEMAPHORE = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 183;
        _SplusNVRAM.SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 184;
        _SplusNVRAM.ELEMENT = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.STORAGE  = new ushort[ 17 ];
    _SplusNVRAM.TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
    m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
    
    DIGITALIN = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        DIGITALIN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DIGITALIN__DigitalInput__ + i, DIGITALIN__DigitalInput__, this );
        m_DigitalInputList.Add( DIGITALIN__DigitalInput__ + i, DIGITALIN[i+1] );
    }
    
    ADDRESS = new Crestron.Logos.SplusObjects.AnalogInput( ADDRESS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ADDRESS__AnalogSerialInput__, ADDRESS );
    
    ANALOGOUT = new InOutArray<AnalogOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        ANALOGOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ANALOGOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ANALOGOUT__AnalogSerialOutput__ + i, ANALOGOUT[i+1] );
    }
    
    TODEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TODEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVICE__DOLLAR____AnalogSerialOutput__, TODEVICE__DOLLAR__ );
    
    FROMDEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROMDEVICE__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROMDEVICE__DOLLAR____AnalogSerialInput__, FROMDEVICE__DOLLAR__ );
    
    
    for( uint i = 0; i < 12; i++ )
        DIGITALIN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGITALIN_OnPush_0, false ) );
        
    for( uint i = 0; i < 12; i++ )
        DIGITALIN[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( DIGITALIN_OnRelease_1, false ) );
        
    SEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_OnPush_2, false ) );
    FROMDEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMDEVICE__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_LG_L32___L37___L42_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SEND__DigitalInput__ = 0;
const uint DIGITALIN__DigitalInput__ = 1;
const uint ADDRESS__AnalogSerialInput__ = 0;
const uint FROMDEVICE__DOLLAR____AnalogSerialInput__ = 1;
const uint TODEVICE__DOLLAR____AnalogSerialOutput__ = 0;
const uint ANALOGOUT__AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort SEMAPHORE = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort ELEMENT = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort IDRECEIVED = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort [] STORAGE;
            [SplusStructAttribute(4, false, true)]
            public ushort VALUE = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort PARAMETER = 0;
            [SplusStructAttribute(6, false, true)]
            public CrestronString TEMPSTRING__DOLLAR__;
            
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
