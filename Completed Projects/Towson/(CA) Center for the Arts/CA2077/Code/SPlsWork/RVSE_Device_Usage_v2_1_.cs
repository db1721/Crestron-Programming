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

namespace UserModule_RVSE_DEVICE_USAGE_V2_1_
{
    public class UserModuleClass_RVSE_DEVICE_USAGE_V2_1_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_LOG_ON_ID_CHANGE;
        Crestron.Logos.SplusObjects.DigitalInput RV_ONLINE;
        Crestron.Logos.SplusObjects.DigitalInput CLOCK;
        Crestron.Logos.SplusObjects.DigitalInput START;
        Crestron.Logos.SplusObjects.DigitalInput STOP;
        Crestron.Logos.SplusObjects.StringInput MEETING_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ASSET_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ASSET_TYPE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput ASSET_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput LAST_USED_MINUTES;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_DEVICE_USAGE__DOLLAR__;
        ushort G_ILASTUSEDMINUTES = 0;
        ushort G_ILASTUSEDSECONDS = 0;
        ushort G_IMODE = 0;
        CrestronString G_SLASTMEETINGID;
        private void OUTPUTLASTUSED (  SplusExecutionContext __context__, ushort TYPE ) 
            { 
            CrestronString SASSETID;
            CrestronString SMEETINGID;
            SASSETID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 101;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_ILASTUSEDMINUTES == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_ILASTUSEDSECONDS > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 103;
                G_ILASTUSEDMINUTES = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 106;
            LAST_USED_MINUTES  .Value = (ushort) ( G_ILASTUSEDMINUTES ) ; 
            __context__.SourceCodeLine = 110;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( ASSET_ID__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 112;
                SASSETID  .UpdateValue ( ASSET_ID__DOLLAR__  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 116;
                SASSETID  .UpdateValue ( "-"  ) ; 
                } 
            
            __context__.SourceCodeLine = 119;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 123;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( MEETING_ID__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 125;
                    SMEETINGID  .UpdateValue ( MEETING_ID__DOLLAR__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 129;
                    SMEETINGID  .UpdateValue ( "-"  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 132;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TYPE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 136;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SLASTMEETINGID ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 138;
                        SMEETINGID  .UpdateValue ( G_SLASTMEETINGID  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 142;
                        SMEETINGID  .UpdateValue ( "-"  ) ; 
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 146;
            MakeString ( TO_RV_DEVICE_USAGE__DOLLAR__ , "USAGE||-||-||TIME||{0}||{1}||-||{2}||-||{3}||{4}||", ASSET_TYPE__DOLLAR__ , ASSET_NAME__DOLLAR__ , Functions.ItoA (  (int) ( G_ILASTUSEDMINUTES ) ) , SASSETID , SMEETINGID ) ; 
            
            }
            
        object MEETING_ID__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 157;
                if ( Functions.TestForTrue  ( ( ENABLE_LOG_ON_ID_CHANGE  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 160;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETING_ID__DOLLAR__ != G_SLASTMEETINGID))  ) ) 
                        { 
                        __context__.SourceCodeLine = 165;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IMODE == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 170;
                            OUTPUTLASTUSED (  __context__ , (ushort)( 2 )) ; 
                            __context__.SourceCodeLine = 173;
                            G_ILASTUSEDMINUTES = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 174;
                            G_ILASTUSEDSECONDS = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 179;
                G_SLASTMEETINGID  .UpdateValue ( MEETING_ID__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object START_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 184;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IMODE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 186;
                G_ILASTUSEDMINUTES = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 187;
                G_ILASTUSEDSECONDS = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 190;
            G_IMODE = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object STOP_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 195;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IMODE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 197;
            G_IMODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 200;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( G_ILASTUSEDMINUTES > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( G_ILASTUSEDSECONDS > 0 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 201;
                OUTPUTLASTUSED (  __context__ , (ushort)( 1 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLOCK_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 209;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IMODE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 211;
            G_ILASTUSEDSECONDS = (ushort) ( (G_ILASTUSEDSECONDS + 10) ) ; 
            __context__.SourceCodeLine = 212;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ILASTUSEDSECONDS > 59 ))  ) ) 
                { 
                __context__.SourceCodeLine = 214;
                G_ILASTUSEDMINUTES = (ushort) ( (G_ILASTUSEDMINUTES + 1) ) ; 
                __context__.SourceCodeLine = 215;
                G_ILASTUSEDSECONDS = (ushort) ( (G_ILASTUSEDSECONDS - 60) ) ; 
                } 
            
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
        
        __context__.SourceCodeLine = 228;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 230;
        G_IMODE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SLASTMEETINGID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    ENABLE_LOG_ON_ID_CHANGE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_LOG_ON_ID_CHANGE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_LOG_ON_ID_CHANGE__DigitalInput__, ENABLE_LOG_ON_ID_CHANGE );
    
    RV_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( RV_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( RV_ONLINE__DigitalInput__, RV_ONLINE );
    
    CLOCK = new Crestron.Logos.SplusObjects.DigitalInput( CLOCK__DigitalInput__, this );
    m_DigitalInputList.Add( CLOCK__DigitalInput__, CLOCK );
    
    START = new Crestron.Logos.SplusObjects.DigitalInput( START__DigitalInput__, this );
    m_DigitalInputList.Add( START__DigitalInput__, START );
    
    STOP = new Crestron.Logos.SplusObjects.DigitalInput( STOP__DigitalInput__, this );
    m_DigitalInputList.Add( STOP__DigitalInput__, STOP );
    
    LAST_USED_MINUTES = new Crestron.Logos.SplusObjects.AnalogOutput( LAST_USED_MINUTES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAST_USED_MINUTES__AnalogSerialOutput__, LAST_USED_MINUTES );
    
    MEETING_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( MEETING_ID__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( MEETING_ID__DOLLAR____AnalogSerialInput__, MEETING_ID__DOLLAR__ );
    
    ASSET_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ASSET_ID__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( ASSET_ID__DOLLAR____AnalogSerialInput__, ASSET_ID__DOLLAR__ );
    
    ASSET_TYPE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ASSET_TYPE__DOLLAR____AnalogSerialInput__, 25, this );
    m_StringInputList.Add( ASSET_TYPE__DOLLAR____AnalogSerialInput__, ASSET_TYPE__DOLLAR__ );
    
    ASSET_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ASSET_NAME__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( ASSET_NAME__DOLLAR____AnalogSerialInput__, ASSET_NAME__DOLLAR__ );
    
    TO_RV_DEVICE_USAGE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__, TO_RV_DEVICE_USAGE__DOLLAR__ );
    
    
    MEETING_ID__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MEETING_ID__DOLLAR___OnChange_0, false ) );
    START.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_OnPush_1, false ) );
    STOP.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_OnPush_2, false ) );
    CLOCK.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLOCK_OnPush_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RVSE_DEVICE_USAGE_V2_1_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE_LOG_ON_ID_CHANGE__DigitalInput__ = 0;
const uint RV_ONLINE__DigitalInput__ = 1;
const uint CLOCK__DigitalInput__ = 2;
const uint START__DigitalInput__ = 3;
const uint STOP__DigitalInput__ = 4;
const uint MEETING_ID__DOLLAR____AnalogSerialInput__ = 0;
const uint ASSET_ID__DOLLAR____AnalogSerialInput__ = 1;
const uint ASSET_TYPE__DOLLAR____AnalogSerialInput__ = 2;
const uint ASSET_NAME__DOLLAR____AnalogSerialInput__ = 3;
const uint LAST_USED_MINUTES__AnalogSerialOutput__ = 0;
const uint TO_RV_DEVICE_USAGE__DOLLAR____AnalogSerialOutput__ = 1;

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
