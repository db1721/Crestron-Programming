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

namespace UserModule_CONTEMPORARY_RESEARCH_PRESET_TEXT_V1
{
    public class UserModuleClass_CONTEMPORARY_RESEARCH_PRESET_TEXT_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput SAVE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PRESET_;
        Crestron.Logos.SplusObjects.StringInput TEXT_IN__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SAVE_ACT_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PRESET_TEXT__DOLLAR__;
        object SAVE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 23;
                _SplusNVRAM.SAVE_ACT = (ushort) ( Functions.Not( _SplusNVRAM.SAVE_ACT ) ) ; 
                __context__.SourceCodeLine = 24;
                SAVE_ACT_FB  .Value = (ushort) ( _SplusNVRAM.SAVE_ACT ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PRESET__OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 29;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SAVE_ACT_FB  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 31;
                _SplusNVRAM.I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 32;
                _SplusNVRAM.S [ _SplusNVRAM.I ]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 33;
                _SplusNVRAM.S [ _SplusNVRAM.I ]  .UpdateValue ( TEXT_IN__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 34;
                PRESET_TEXT__DOLLAR__ [ _SplusNVRAM.I]  .UpdateValue ( _SplusNVRAM.S [ _SplusNVRAM.I ]  ) ; 
                __context__.SourceCodeLine = 35;
                Functions.ClearBuffer ( TEXT_IN__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 36;
                _SplusNVRAM.SAVE_ACT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 37;
                SAVE_ACT_FB  .Value = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 45;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)6; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( _SplusNVRAM.I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.I  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.I  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.I  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 47;
            PRESET_TEXT__DOLLAR__ [ _SplusNVRAM.I]  .UpdateValue ( _SplusNVRAM.S [ _SplusNVRAM.I ]  ) ; 
            __context__.SourceCodeLine = 45;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.S  = new CrestronString[ 7 ];
    for( uint i = 0; i < 7; i++ )
        _SplusNVRAM.S [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    
    SAVE = new Crestron.Logos.SplusObjects.DigitalInput( SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE__DigitalInput__, SAVE );
    
    PRESET_ = new InOutArray<DigitalInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        PRESET_[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PRESET___DigitalInput__ + i, PRESET___DigitalInput__, this );
        m_DigitalInputList.Add( PRESET___DigitalInput__ + i, PRESET_[i+1] );
    }
    
    SAVE_ACT_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SAVE_ACT_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SAVE_ACT_FB__DigitalOutput__, SAVE_ACT_FB );
    
    TEXT_IN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TEXT_IN__DOLLAR____AnalogSerialInput__, 5, this );
    m_StringInputList.Add( TEXT_IN__DOLLAR____AnalogSerialInput__, TEXT_IN__DOLLAR__ );
    
    PRESET_TEXT__DOLLAR__ = new InOutArray<StringOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        PRESET_TEXT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PRESET_TEXT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PRESET_TEXT__DOLLAR____AnalogSerialOutput__ + i, PRESET_TEXT__DOLLAR__[i+1] );
    }
    
    
    SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_OnPush_0, false ) );
    for( uint i = 0; i < 6; i++ )
        PRESET_[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET__OnPush_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CONTEMPORARY_RESEARCH_PRESET_TEXT_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SAVE__DigitalInput__ = 0;
const uint PRESET___DigitalInput__ = 1;
const uint TEXT_IN__DOLLAR____AnalogSerialInput__ = 0;
const uint SAVE_ACT_FB__DigitalOutput__ = 0;
const uint PRESET_TEXT__DOLLAR____AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort I = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort SAVE_ACT = 0;
            [SplusStructAttribute(2, false, true)]
            public CrestronString [] S;
            
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
