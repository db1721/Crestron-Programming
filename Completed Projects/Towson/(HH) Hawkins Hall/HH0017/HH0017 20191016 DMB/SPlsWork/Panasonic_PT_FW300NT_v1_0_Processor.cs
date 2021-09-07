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

namespace UserModule_PANASONIC_PT_FW300NT_V1_0_PROCESSOR
{
    public class UserModuleClass_PANASONIC_PT_FW300NT_V1_0_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput LAMP_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput LAMP_STATUS_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_REQUESTED;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_ADJUST;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_ADJUST;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_ADJUST;
        Crestron.Logos.SplusObjects.AnalogInput BRIGHTNESS_IN;
        Crestron.Logos.SplusObjects.AnalogInput CONTRAST_IN;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_IN;
        Crestron.Logos.SplusObjects.StringInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP_HOURS;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP_STATUS;
        Crestron.Logos.SplusObjects.AnalogOutput BRIGHTNESS_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput CONTRAST_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_OUT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        object BRIGHTNESS_IN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 89;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BRIGHTNESS_ADJUST  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 91;
                    MakeString ( TO_DEVICE , "\u0002VBR:{0:d}\u0003", (short)(BRIGHTNESS_IN  .UshortValue - 32)) ; 
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
            
            __context__.SourceCodeLine = 97;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONTRAST_ADJUST  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 99;
                MakeString ( TO_DEVICE , "\u0002VCN:{0:d}\u0003", (short)(CONTRAST_IN  .UshortValue - 32)) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object VOLUME_IN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 105;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUME_ADJUST  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 107;
            MakeString ( TO_DEVICE , "\u0002AVL:{0}\u0003", Functions.ItoA (  (int) ( VOLUME_IN  .UshortValue ) ) ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 114;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (LAMP_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 116;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 117;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 119;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 120;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) == 6) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 122;
                    LAMP_HOURS  .Value = (ushort) ( Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 4 ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 117;
                } 
            
            __context__.SourceCodeLine = 125;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 129;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (LAMP_STATUS_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 131;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 132;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 134;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 135;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) == 3) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 137;
                    LAMP_STATUS  .Value = (ushort) ( Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 1 ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 132;
                } 
            
            __context__.SourceCodeLine = 140;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 144;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (BRIGHTNESS_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 146;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 147;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 149;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 150;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) <= 5 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 152;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "-" , _SplusNVRAM.STEMP__DOLLAR__ ))  ) ) 
                        {
                        __context__.SourceCodeLine = 153;
                        BRIGHTNESS_OUT  .Value = (ushort) ( (32 - Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) )) ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 155;
                        BRIGHTNESS_OUT  .Value = (ushort) ( (Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 3 ) ) ) + 32) ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 147;
                } 
            
            __context__.SourceCodeLine = 158;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 162;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (CONTRAST_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 164;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 165;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 167;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 168;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) <= 5 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 170;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "-" , _SplusNVRAM.STEMP__DOLLAR__ ))  ) ) 
                        {
                        __context__.SourceCodeLine = 171;
                        CONTRAST_OUT  .Value = (ushort) ( (32 - Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) )) ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 173;
                        CONTRAST_OUT  .Value = (ushort) ( (Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 3 ) ) ) + 32) ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 165;
                } 
            
            __context__.SourceCodeLine = 176;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 180;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IBUSYFLAG == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (VOLUME_REQUESTED  .Value == 1) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 182;
            _SplusNVRAM.IBUSYFLAG = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 183;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0003" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 185;
                _SplusNVRAM.STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0003" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 186;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "ER401" , _SplusNVRAM.STEMP__DOLLAR__ ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( _SplusNVRAM.STEMP__DOLLAR__ ) == 5) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 188;
                    VOLUME_OUT  .Value = (ushort) ( Functions.Atoi( Functions.Mid( _SplusNVRAM.STEMP__DOLLAR__ , (int)( 2 ) , (int)( 3 ) ) ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 183;
                } 
            
            __context__.SourceCodeLine = 191;
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
        
        __context__.SourceCodeLine = 218;
        _SplusNVRAM.IBUSYFLAG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 219;
        LAMP_HOURS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 220;
        LAMP_STATUS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 221;
        BRIGHTNESS_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 222;
        CONTRAST_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 223;
        VOLUME_OUT  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 224;
        Functions.ClearBuffer ( _SplusNVRAM.STEMP__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 225;
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
    
    LAMP_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( LAMP_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( LAMP_REQUESTED__DigitalInput__, LAMP_REQUESTED );
    
    LAMP_STATUS_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( LAMP_STATUS_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( LAMP_STATUS_REQUESTED__DigitalInput__, LAMP_STATUS_REQUESTED );
    
    BRIGHTNESS_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_REQUESTED__DigitalInput__, BRIGHTNESS_REQUESTED );
    
    CONTRAST_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_REQUESTED__DigitalInput__, CONTRAST_REQUESTED );
    
    VOLUME_REQUESTED = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_REQUESTED__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_REQUESTED__DigitalInput__, VOLUME_REQUESTED );
    
    BRIGHTNESS_ADJUST = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_ADJUST__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_ADJUST__DigitalInput__, BRIGHTNESS_ADJUST );
    
    CONTRAST_ADJUST = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_ADJUST__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_ADJUST__DigitalInput__, CONTRAST_ADJUST );
    
    VOLUME_ADJUST = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_ADJUST__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_ADJUST__DigitalInput__, VOLUME_ADJUST );
    
    BRIGHTNESS_IN = new Crestron.Logos.SplusObjects.AnalogInput( BRIGHTNESS_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( BRIGHTNESS_IN__AnalogSerialInput__, BRIGHTNESS_IN );
    
    CONTRAST_IN = new Crestron.Logos.SplusObjects.AnalogInput( CONTRAST_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CONTRAST_IN__AnalogSerialInput__, CONTRAST_IN );
    
    VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_IN__AnalogSerialInput__, VOLUME_IN );
    
    LAMP_HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP_HOURS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAMP_HOURS__AnalogSerialOutput__, LAMP_HOURS );
    
    LAMP_STATUS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP_STATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAMP_STATUS__AnalogSerialOutput__, LAMP_STATUS );
    
    BRIGHTNESS_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( BRIGHTNESS_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BRIGHTNESS_OUT__AnalogSerialOutput__, BRIGHTNESS_OUT );
    
    CONTRAST_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( CONTRAST_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONTRAST_OUT__AnalogSerialOutput__, CONTRAST_OUT );
    
    VOLUME_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_OUT__AnalogSerialOutput__, VOLUME_OUT );
    
    FROM_DEVICE = new Crestron.Logos.SplusObjects.StringInput( FROM_DEVICE__AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    
    BRIGHTNESS_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( BRIGHTNESS_IN_OnChange_0, false ) );
    CONTRAST_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( CONTRAST_IN_OnChange_1, false ) );
    VOLUME_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_IN_OnChange_2, false ) );
    FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PANASONIC_PT_FW300NT_V1_0_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint LAMP_REQUESTED__DigitalInput__ = 0;
const uint LAMP_STATUS_REQUESTED__DigitalInput__ = 1;
const uint BRIGHTNESS_REQUESTED__DigitalInput__ = 2;
const uint CONTRAST_REQUESTED__DigitalInput__ = 3;
const uint VOLUME_REQUESTED__DigitalInput__ = 4;
const uint BRIGHTNESS_ADJUST__DigitalInput__ = 5;
const uint CONTRAST_ADJUST__DigitalInput__ = 6;
const uint VOLUME_ADJUST__DigitalInput__ = 7;
const uint BRIGHTNESS_IN__AnalogSerialInput__ = 0;
const uint CONTRAST_IN__AnalogSerialInput__ = 1;
const uint VOLUME_IN__AnalogSerialInput__ = 2;
const uint FROM_DEVICE__AnalogSerialInput__ = 3;
const uint LAMP_HOURS__AnalogSerialOutput__ = 0;
const uint LAMP_STATUS__AnalogSerialOutput__ = 1;
const uint BRIGHTNESS_OUT__AnalogSerialOutput__ = 2;
const uint CONTRAST_OUT__AnalogSerialOutput__ = 3;
const uint VOLUME_OUT__AnalogSerialOutput__ = 4;
const uint TO_DEVICE__AnalogSerialOutput__ = 5;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort IBUSYFLAG = 0;
            [SplusStructAttribute(1, false, true)]
            public short BRIGHTNESS_VALUE = 0;
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
