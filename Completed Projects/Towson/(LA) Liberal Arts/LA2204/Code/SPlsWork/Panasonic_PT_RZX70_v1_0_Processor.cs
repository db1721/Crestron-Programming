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

namespace UserModule_PANASONIC_PT_RZX70_V1_0_PROCESSOR
{
    public class UserModuleClass_PANASONIC_PT_RZX70_V1_0_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput LAMP1_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput PROJRUNTIME_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput LAMP_STATUS_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_ADJUST;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_ADJUST;
        Crestron.Logos.SplusObjects.AnalogInput BRIGHTNESS_IN;
        Crestron.Logos.SplusObjects.AnalogInput CONTRAST_IN;
        Crestron.Logos.SplusObjects.StringInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP_HOURS;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP_STATUS;
        Crestron.Logos.SplusObjects.AnalogOutput BRIGHTNESS_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput CONTRAST_OUT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        object BRIGHTNESS_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 88;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BRIGHTNESS_ADJUST  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 90;
                    MakeString ( TO_DEVICE , "\u0002ADZZ;VBR:{0}\u0003", Functions.ItoA (  (int) ( (BRIGHTNESS_IN  .UshortValue + 1) ) ) ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CONTRAST_IN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 96;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONTRAST_ADJUST  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 98;
                MakeString ( TO_DEVICE , "\u0002ADZZ;VCN:{0}\u0003", Functions.ItoA (  (int) ( (CONTRAST_IN  .UshortValue + 1) ) ) ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object FROM_DEVICE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 105;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (LAMP1_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 107;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 108;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 110;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 111;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) == 6) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 113;
                    _SplusNVRAM.LAMP1_NOT_AVAILABLE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 114;
                    LAMP_HOURS  .Value = (ushort) ( Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 4 ) ) ) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 118;
                    _SplusNVRAM.LAMP1_NOT_AVAILABLE = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 108;
                } 
            
            __context__.SourceCodeLine = 121;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 124;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (PROJRUNTIME_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 126;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 127;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 129;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 130;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) > 4 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) < 9 ) )) ) ) && Functions.TestForTrue ( _SplusNVRAM.LAMP1_NOT_AVAILABLE )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 132;
                    LAMP_HOURS  .Value = (ushort) ( Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) - 2) ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 127;
                } 
            
            __context__.SourceCodeLine = 135;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 139;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (LAMP_STATUS_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 141;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 142;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 144;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 145;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) == 3) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 147;
                    LAMP_STATUS  .Value = (ushort) ( Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 1 ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 142;
                } 
            
            __context__.SourceCodeLine = 150;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 154;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (BRIGHTNESS_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 156;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 157;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 159;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 160;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) == 5) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 162;
                    BRIGHTNESS_OUT  .Value = (ushort) ( (Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 3 ) ) ) - 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 157;
                } 
            
            __context__.SourceCodeLine = 165;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 169;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (CONTRAST_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 171;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 172;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 174;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 175;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) == 5) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 177;
                    CONTRAST_OUT  .Value = (ushort) ( (Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 3 ) ) ) - 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 172;
                } 
            
            __context__.SourceCodeLine = 180;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 207;
        _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 208;
        LAMP_HOURS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 209;
        LAMP_STATUS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 210;
        BRIGHTNESS_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 211;
        CONTRAST_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 212;
        Functions.ClearBuffer ( _SplusNVRAM.STEMP__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 213;
        Functions.ClearBuffer ( FROM_DEVICE ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 254, this );
    
    LAMP1_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( LAMP1_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( LAMP1_REQUESTED__DigitalInput__, LAMP1_REQUESTED );
    
    PROJRUNTIME_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( PROJRUNTIME_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( PROJRUNTIME_REQUESTED__DigitalInput__, PROJRUNTIME_REQUESTED );
    
    LAMP_STATUS_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( LAMP_STATUS_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( LAMP_STATUS_REQUESTED__DigitalInput__, LAMP_STATUS_REQUESTED );
    
    BRIGHTNESS_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_REQUESTED__DigitalInput__, BRIGHTNESS_REQUESTED );
    
    CONTRAST_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_REQUESTED__DigitalInput__, CONTRAST_REQUESTED );
    
    BRIGHTNESS_ADJUST = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_ADJUST__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_ADJUST__DigitalInput__, BRIGHTNESS_ADJUST );
    
    CONTRAST_ADJUST = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_ADJUST__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_ADJUST__DigitalInput__, CONTRAST_ADJUST );
    
    BRIGHTNESS_IN = new Crestron.Logos.SplusObjects.AnalogInput( BRIGHTNESS_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( BRIGHTNESS_IN__AnalogSerialInput__, BRIGHTNESS_IN );
    
    CONTRAST_IN = new Crestron.Logos.SplusObjects.AnalogInput( CONTRAST_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CONTRAST_IN__AnalogSerialInput__, CONTRAST_IN );
    
    LAMP_HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP_HOURS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAMP_HOURS__AnalogSerialOutput__, LAMP_HOURS );
    
    LAMP_STATUS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP_STATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAMP_STATUS__AnalogSerialOutput__, LAMP_STATUS );
    
    BRIGHTNESS_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( BRIGHTNESS_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BRIGHTNESS_OUT__AnalogSerialOutput__, BRIGHTNESS_OUT );
    
    CONTRAST_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( CONTRAST_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONTRAST_OUT__AnalogSerialOutput__, CONTRAST_OUT );
    
    FROM_DEVICE = new Crestron.Logos.SplusObjects.StringInput( FROM_DEVICE__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    
    BRIGHTNESS_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( BRIGHTNESS_IN_OnChange_0, false ) );
    CONTRAST_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( CONTRAST_IN_OnChange_1, false ) );
    FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PANASONIC_PT_RZX70_V1_0_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint LAMP1_REQUESTED__DigitalInput__ = 0;
const uint PROJRUNTIME_REQUESTED__DigitalInput__ = 1;
const uint LAMP_STATUS_REQUESTED__DigitalInput__ = 2;
const uint BRIGHTNESS_REQUESTED__DigitalInput__ = 3;
const uint CONTRAST_REQUESTED__DigitalInput__ = 4;
const uint BRIGHTNESS_ADJUST__DigitalInput__ = 5;
const uint CONTRAST_ADJUST__DigitalInput__ = 6;
const uint BRIGHTNESS_IN__AnalogSerialInput__ = 0;
const uint CONTRAST_IN__AnalogSerialInput__ = 1;
const uint FROM_DEVICE__AnalogSerialInput__ = 2;
const uint LAMP_HOURS__AnalogSerialOutput__ = 0;
const uint LAMP_STATUS__AnalogSerialOutput__ = 1;
const uint BRIGHTNESS_OUT__AnalogSerialOutput__ = 2;
const uint CONTRAST_OUT__AnalogSerialOutput__ = 3;
const uint TO_DEVICE__AnalogSerialOutput__ = 4;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort IBUSYFLAG = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort LAMP1_NOT_AVAILABLE = 0;
            [SplusStructAttribute(2, false, true)]
            public CrestronString STEMP__DOLLAR__;
            
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
