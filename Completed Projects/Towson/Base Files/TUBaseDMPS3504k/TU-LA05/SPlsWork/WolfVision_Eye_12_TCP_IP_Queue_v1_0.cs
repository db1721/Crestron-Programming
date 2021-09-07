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

namespace UserModule_WOLFVISION_EYE_12_TCP_IP_QUEUE_V1_0
{
    public class UserModuleClass_WOLFVISION_EYE_12_TCP_IP_QUEUE_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CONNECTED;
        Crestron.Logos.SplusObjects.DigitalInput SEND_NEXT;
        Crestron.Logos.SplusObjects.DigitalInput RECEIVING;
        Crestron.Logos.SplusObjects.BufferInput FROM_MODULE;
        Crestron.Logos.SplusObjects.DigitalOutput CONNECT;
        Crestron.Logos.SplusObjects.DigitalOutput SEND_NEXT_OUT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        ushort INEXTSEND = 0;
        ushort INEXTSTORE = 0;
        ushort IFLAG1 = 0;
        ushort IOKTOSEND = 0;
        CrestronString [] SQUEUE;
        CrestronString STEMP;
        object SEND_NEXT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 71;
                SEND_NEXT_OUT  .Value = (ushort) ( 0 ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SEND_NEXT_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 76;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SQUEUE[ INEXTSEND ] ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTED  .Value == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 78;
                TO_DEVICE  .UpdateValue ( SQUEUE [ INEXTSEND ]  ) ; 
                __context__.SourceCodeLine = 79;
                IOKTOSEND = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 80;
                SQUEUE [ INEXTSEND ]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 81;
                INEXTSEND = (ushort) ( (INEXTSEND + 1) ) ; 
                __context__.SourceCodeLine = 82;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTSEND > 30 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 84;
                    INEXTSEND = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 87;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SQUEUE[ INEXTSEND ] ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTED  .Value == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 89;
                    CONNECT  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 91;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SQUEUE[ INEXTSEND ] ) == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 94;
                        IOKTOSEND = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 98;
                        IOKTOSEND = (ushort) ( 1 ) ; 
                        } 
                    
                    }
                
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CONNECTED_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 104;
        SEND_NEXT_OUT  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECEIVING_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 114;
        SEND_NEXT_OUT  .Value = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_MODULE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 121;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 122;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\r" , FROM_MODULE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 124;
                STEMP  .UpdateValue ( Functions.Remove ( "\r" , FROM_MODULE )  ) ; 
                __context__.SourceCodeLine = 125;
                SQUEUE [ INEXTSTORE ]  .UpdateValue ( Functions.Left ( STEMP ,  (int) ( (Functions.Length( STEMP ) - Functions.Length( "\r" )) ) )  ) ; 
                __context__.SourceCodeLine = 126;
                INEXTSTORE = (ushort) ( (INEXTSTORE + 1) ) ; 
                __context__.SourceCodeLine = 127;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTSTORE > 30 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 129;
                    INEXTSTORE = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 131;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IOKTOSEND == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (CONNECTED  .Value == 1) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 133;
                    SEND_NEXT_OUT  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 135;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONNECTED  .Value == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 137;
                        CONNECT  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 122;
                } 
            
            __context__.SourceCodeLine = 140;
            IFLAG1 = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 150;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 151;
        IOKTOSEND = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 152;
        Functions.SetArray ( SQUEUE , "" ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    SQUEUE  = new CrestronString[ 31 ];
    for( uint i = 0; i < 31; i++ )
        SQUEUE [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    
    CONNECTED = new Crestron.Logos.SplusObjects.DigitalInput( CONNECTED__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECTED__DigitalInput__, CONNECTED );
    
    SEND_NEXT = new Crestron.Logos.SplusObjects.DigitalInput( SEND_NEXT__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_NEXT__DigitalInput__, SEND_NEXT );
    
    RECEIVING = new Crestron.Logos.SplusObjects.DigitalInput( RECEIVING__DigitalInput__, this );
    m_DigitalInputList.Add( RECEIVING__DigitalInput__, RECEIVING );
    
    CONNECT = new Crestron.Logos.SplusObjects.DigitalOutput( CONNECT__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONNECT__DigitalOutput__, CONNECT );
    
    SEND_NEXT_OUT = new Crestron.Logos.SplusObjects.DigitalOutput( SEND_NEXT_OUT__DigitalOutput__, this );
    m_DigitalOutputList.Add( SEND_NEXT_OUT__DigitalOutput__, SEND_NEXT_OUT );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    FROM_MODULE = new Crestron.Logos.SplusObjects.BufferInput( FROM_MODULE__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( FROM_MODULE__AnalogSerialInput__, FROM_MODULE );
    
    
    SEND_NEXT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_NEXT_OnPush_0, false ) );
    SEND_NEXT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SEND_NEXT_OnRelease_1, false ) );
    CONNECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECTED_OnPush_2, false ) );
    RECEIVING.OnDigitalRelease.Add( new InputChangeHandlerWrapper( RECEIVING_OnRelease_3, false ) );
    FROM_MODULE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_MODULE_OnChange_4, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_WOLFVISION_EYE_12_TCP_IP_QUEUE_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CONNECTED__DigitalInput__ = 0;
const uint SEND_NEXT__DigitalInput__ = 1;
const uint RECEIVING__DigitalInput__ = 2;
const uint FROM_MODULE__AnalogSerialInput__ = 0;
const uint CONNECT__DigitalOutput__ = 0;
const uint SEND_NEXT_OUT__DigitalOutput__ = 1;
const uint TO_DEVICE__AnalogSerialOutput__ = 0;

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
