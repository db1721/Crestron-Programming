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

namespace UserModule_ROBOSHOT_IP_PTZ
{
    public class UserModuleClass_ROBOSHOT_IP_PTZ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput RECALL;
        Crestron.Logos.SplusObjects.DigitalInput STORE;
        Crestron.Logos.SplusObjects.DigitalInput POWERON;
        Crestron.Logos.SplusObjects.DigitalInput POWEROFF;
        Crestron.Logos.SplusObjects.DigitalInput HOME;
        Crestron.Logos.SplusObjects.DigitalInput AUTOFOCUS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TILT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PAN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ZOOM;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> FOCUS;
        Crestron.Logos.SplusObjects.StringInput IN__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput PRESET;
        Crestron.Logos.SplusObjects.StringOutput OUT__DOLLAR__;
        ushort STORETYPE = 0;
        ushort PARAMTYPE = 0;
        short PTZ = 0;
        short [,] PRESETARRAY;
        CrestronString FILENAME;
        object STORE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 52;
                MakeString ( OUT__DOLLAR__ , "camera preset store {0:d}\r\n", (ushort)PRESET  .UshortValue) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object RECALL_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 58;
            MakeString ( OUT__DOLLAR__ , "camera preset recall {0:d}\r\n", (ushort)PRESET  .UshortValue) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TILT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 62;
        PTZ = (short) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 63;
        
            {
            int __SPLS_TMPVAR__SWTCH_1__ = ((int)PTZ);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 67;
                    OUT__DOLLAR__  .UpdateValue ( "camera tilt up\r"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 71;
                    OUT__DOLLAR__  .UpdateValue ( "camera tilt down\r"  ) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 77;
        PTZ = (short) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 78;
        
            {
            int __SPLS_TMPVAR__SWTCH_2__ = ((int)PTZ);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 82;
                    OUT__DOLLAR__  .UpdateValue ( "camera pan left\r"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 86;
                    OUT__DOLLAR__  .UpdateValue ( "camera pan right\r"  ) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOFOCUS_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 92;
        OUT__DOLLAR__  .UpdateValue ( "camera focus mode auto\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 96;
        PTZ = (short) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 97;
        
            {
            int __SPLS_TMPVAR__SWTCH_3__ = ((int)PTZ);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 101;
                    OUT__DOLLAR__  .UpdateValue ( "camera zoom in\r"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 105;
                    OUT__DOLLAR__  .UpdateValue ( "camera zoom out\r"  ) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FOCUS_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 111;
        PTZ = (short) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 112;
        
            {
            int __SPLS_TMPVAR__SWTCH_4__ = ((int)PTZ);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 116;
                    OUT__DOLLAR__  .UpdateValue ( "camera focus near\r"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 120;
                    OUT__DOLLAR__  .UpdateValue ( "camera focus far\r"  ) ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOME_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 127;
        OUT__DOLLAR__  .UpdateValue ( "camera home\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWERON_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 131;
        OUT__DOLLAR__  .UpdateValue ( "camera standby off\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWEROFF_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        OUT__DOLLAR__  .UpdateValue ( "camera standby on\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_OnRelease_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 139;
        OUT__DOLLAR__  .UpdateValue ( "camera pan stop\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TILT_OnRelease_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 141;
        OUT__DOLLAR__  .UpdateValue ( "camera tilt stop\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_OnRelease_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 143;
        OUT__DOLLAR__  .UpdateValue ( "camera zoom stop\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FOCUS_OnRelease_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 145;
        OUT__DOLLAR__  .UpdateValue ( "camera focus stop\r"  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 148;
        FILENAME  .UpdateValue ( "\\USER\\" + "Camera" + GetSymbolReferenceName ( ) + ".dat"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    PRESETARRAY  = new short[ 100,4 ];
    FILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, this );
    
    RECALL = new Crestron.Logos.SplusObjects.DigitalInput( RECALL__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL__DigitalInput__, RECALL );
    
    STORE = new Crestron.Logos.SplusObjects.DigitalInput( STORE__DigitalInput__, this );
    m_DigitalInputList.Add( STORE__DigitalInput__, STORE );
    
    POWERON = new Crestron.Logos.SplusObjects.DigitalInput( POWERON__DigitalInput__, this );
    m_DigitalInputList.Add( POWERON__DigitalInput__, POWERON );
    
    POWEROFF = new Crestron.Logos.SplusObjects.DigitalInput( POWEROFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWEROFF__DigitalInput__, POWEROFF );
    
    HOME = new Crestron.Logos.SplusObjects.DigitalInput( HOME__DigitalInput__, this );
    m_DigitalInputList.Add( HOME__DigitalInput__, HOME );
    
    AUTOFOCUS = new Crestron.Logos.SplusObjects.DigitalInput( AUTOFOCUS__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOFOCUS__DigitalInput__, AUTOFOCUS );
    
    TILT = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        TILT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TILT__DigitalInput__ + i, TILT__DigitalInput__, this );
        m_DigitalInputList.Add( TILT__DigitalInput__ + i, TILT[i+1] );
    }
    
    PAN = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        PAN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PAN__DigitalInput__ + i, PAN__DigitalInput__, this );
        m_DigitalInputList.Add( PAN__DigitalInput__ + i, PAN[i+1] );
    }
    
    ZOOM = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        ZOOM[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ZOOM__DigitalInput__ + i, ZOOM__DigitalInput__, this );
        m_DigitalInputList.Add( ZOOM__DigitalInput__ + i, ZOOM[i+1] );
    }
    
    FOCUS = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        FOCUS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( FOCUS__DigitalInput__ + i, FOCUS__DigitalInput__, this );
        m_DigitalInputList.Add( FOCUS__DigitalInput__ + i, FOCUS[i+1] );
    }
    
    PRESET = new Crestron.Logos.SplusObjects.AnalogInput( PRESET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PRESET__AnalogSerialInput__, PRESET );
    
    IN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( IN__DOLLAR____AnalogSerialInput__, 500, this );
    m_StringInputList.Add( IN__DOLLAR____AnalogSerialInput__, IN__DOLLAR__ );
    
    OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OUT__DOLLAR____AnalogSerialOutput__, OUT__DOLLAR__ );
    
    
    STORE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STORE_OnPush_0, false ) );
    RECALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_OnPush_1, false ) );
    for( uint i = 0; i < 2; i++ )
        TILT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TILT_OnPush_2, false ) );
        
    for( uint i = 0; i < 2; i++ )
        PAN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PAN_OnPush_3, false ) );
        
    AUTOFOCUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOFOCUS_OnPush_4, false ) );
    for( uint i = 0; i < 2; i++ )
        ZOOM[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ZOOM_OnPush_5, false ) );
        
    for( uint i = 0; i < 2; i++ )
        FOCUS[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( FOCUS_OnPush_6, false ) );
        
    HOME.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOME_OnPush_7, false ) );
    POWERON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWERON_OnPush_8, false ) );
    POWEROFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWEROFF_OnPush_9, false ) );
    for( uint i = 0; i < 2; i++ )
        PAN[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( PAN_OnRelease_10, false ) );
        
    for( uint i = 0; i < 2; i++ )
        TILT[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( TILT_OnRelease_11, false ) );
        
    for( uint i = 0; i < 2; i++ )
        ZOOM[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( ZOOM_OnRelease_12, false ) );
        
    for( uint i = 0; i < 2; i++ )
        FOCUS[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( FOCUS_OnRelease_13, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ROBOSHOT_IP_PTZ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint RECALL__DigitalInput__ = 0;
const uint STORE__DigitalInput__ = 1;
const uint POWERON__DigitalInput__ = 2;
const uint POWEROFF__DigitalInput__ = 3;
const uint HOME__DigitalInput__ = 4;
const uint AUTOFOCUS__DigitalInput__ = 5;
const uint TILT__DigitalInput__ = 6;
const uint PAN__DigitalInput__ = 8;
const uint ZOOM__DigitalInput__ = 10;
const uint FOCUS__DigitalInput__ = 12;
const uint IN__DOLLAR____AnalogSerialInput__ = 0;
const uint PRESET__AnalogSerialInput__ = 1;
const uint OUT__DOLLAR____AnalogSerialOutput__ = 0;

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
