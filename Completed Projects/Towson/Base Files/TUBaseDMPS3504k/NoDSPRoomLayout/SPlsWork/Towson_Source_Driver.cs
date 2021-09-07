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

namespace UserModule_TOWSON_SOURCE_DRIVER
{
    public class UserModuleClass_TOWSON_SOURCE_DRIVER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput SETALL;
        Crestron.Logos.SplusObjects.DigitalInput CLEARALL;
        Crestron.Logos.SplusObjects.DigitalInput SYSTEMONPRESS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> MONITORPRESS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCEPRESS;
        Crestron.Logos.SplusObjects.AnalogOutput MASTERSWVALUE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCEPRESSED;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> MONITORVAL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MONITORSOURCE;
        InOutArray<StringParameter> SOURCENAME;
        ushort X = 0;
        ushort ILOOP = 0;
        ushort ISOURCE = 0;
        ushort [] ISOURCEIN;
        object SYSTEMONPRESS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 21;
                Functions.SetArray ( SOURCEPRESSED , (ushort)0) ; 
                __context__.SourceCodeLine = 22;
                SOURCEPRESSED [ X]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 23;
                ISOURCE = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 24;
                MONITORVAL [ 1]  .Value = (ushort) ( ISOURCEIN[ ISOURCE ] ) ; 
                __context__.SourceCodeLine = 25;
                MONITORSOURCE [ 1]  .UpdateValue ( SOURCENAME [ ISOURCE ]  ) ; 
                __context__.SourceCodeLine = 26;
                MASTERSWVALUE  .Value = (ushort) ( ISOURCEIN[ ISOURCE ] ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SOURCEPRESS_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 30;
            X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 31;
            Functions.SetArray ( SOURCEPRESSED , (ushort)0) ; 
            __context__.SourceCodeLine = 32;
            SOURCEPRESSED [ X]  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 33;
            ISOURCE = (ushort) ( X ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object MONITORPRESS_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 37;
        X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 38;
        MONITORVAL [ X]  .Value = (ushort) ( ISOURCEIN[ ISOURCE ] ) ; 
        __context__.SourceCodeLine = 39;
        MONITORSOURCE [ X]  .UpdateValue ( SOURCENAME [ ISOURCE ]  ) ; 
        __context__.SourceCodeLine = 40;
        MASTERSWVALUE  .Value = (ushort) ( ISOURCEIN[ ISOURCE ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETALL_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 74;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)8; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( ILOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ILOOP  >= __FN_FORSTART_VAL__1) && (ILOOP  <= __FN_FOREND_VAL__1) ) : ( (ILOOP  <= __FN_FORSTART_VAL__1) && (ILOOP  >= __FN_FOREND_VAL__1) ) ; ILOOP  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 76;
            MONITORVAL [ ILOOP]  .Value = (ushort) ( ISOURCEIN[ ISOURCE ] ) ; 
            __context__.SourceCodeLine = 77;
            MONITORSOURCE [ ILOOP]  .UpdateValue ( SOURCENAME [ ISOURCE ]  ) ; 
            __context__.SourceCodeLine = 74;
            } 
        
        __context__.SourceCodeLine = 79;
        MASTERSWVALUE  .Value = (ushort) ( ISOURCEIN[ ISOURCE ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEARALL_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 84;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)8; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( ILOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ILOOP  >= __FN_FORSTART_VAL__1) && (ILOOP  <= __FN_FOREND_VAL__1) ) : ( (ILOOP  <= __FN_FORSTART_VAL__1) && (ILOOP  >= __FN_FOREND_VAL__1) ) ; ILOOP  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 86;
            MONITORVAL [ ILOOP]  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 87;
            MONITORSOURCE [ ILOOP]  .UpdateValue ( "Off"  ) ; 
            __context__.SourceCodeLine = 84;
            } 
        
        __context__.SourceCodeLine = 89;
        MASTERSWVALUE  .Value = (ushort) ( 0 ) ; 
        
        
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
        
        __context__.SourceCodeLine = 94;
        ISOURCEIN [ 1] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 95;
        ISOURCEIN [ 2] = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 96;
        ISOURCEIN [ 3] = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 97;
        ISOURCEIN [ 4] = (ushort) ( 3 ) ; 
        __context__.SourceCodeLine = 98;
        ISOURCEIN [ 5] = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 99;
        ISOURCEIN [ 6] = (ushort) ( 5 ) ; 
        __context__.SourceCodeLine = 100;
        ISOURCEIN [ 7] = (ushort) ( 6 ) ; 
        __context__.SourceCodeLine = 101;
        ISOURCEIN [ 8] = (ushort) ( 7 ) ; 
        __context__.SourceCodeLine = 102;
        ISOURCEIN [ 9] = (ushort) ( 8 ) ; 
        __context__.SourceCodeLine = 103;
        ISOURCEIN [ 10] = (ushort) ( 9 ) ; 
        __context__.SourceCodeLine = 104;
        ISOURCEIN [ 11] = (ushort) ( 10 ) ; 
        __context__.SourceCodeLine = 105;
        ISOURCEIN [ 12] = (ushort) ( 11 ) ; 
        __context__.SourceCodeLine = 106;
        ISOURCEIN [ 13] = (ushort) ( 12 ) ; 
        __context__.SourceCodeLine = 107;
        ISOURCEIN [ 14] = (ushort) ( 13 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    ISOURCEIN  = new ushort[ 15 ];
    
    SETALL = new Crestron.Logos.SplusObjects.DigitalInput( SETALL__DigitalInput__, this );
    m_DigitalInputList.Add( SETALL__DigitalInput__, SETALL );
    
    CLEARALL = new Crestron.Logos.SplusObjects.DigitalInput( CLEARALL__DigitalInput__, this );
    m_DigitalInputList.Add( CLEARALL__DigitalInput__, CLEARALL );
    
    SYSTEMONPRESS = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEMONPRESS__DigitalInput__, this );
    m_DigitalInputList.Add( SYSTEMONPRESS__DigitalInput__, SYSTEMONPRESS );
    
    MONITORPRESS = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MONITORPRESS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( MONITORPRESS__DigitalInput__ + i, MONITORPRESS__DigitalInput__, this );
        m_DigitalInputList.Add( MONITORPRESS__DigitalInput__ + i, MONITORPRESS[i+1] );
    }
    
    SOURCEPRESS = new InOutArray<DigitalInput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        SOURCEPRESS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCEPRESS__DigitalInput__ + i, SOURCEPRESS__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCEPRESS__DigitalInput__ + i, SOURCEPRESS[i+1] );
    }
    
    SOURCEPRESSED = new InOutArray<DigitalOutput>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        SOURCEPRESSED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCEPRESSED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SOURCEPRESSED__DigitalOutput__ + i, SOURCEPRESSED[i+1] );
    }
    
    MASTERSWVALUE = new Crestron.Logos.SplusObjects.AnalogOutput( MASTERSWVALUE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MASTERSWVALUE__AnalogSerialOutput__, MASTERSWVALUE );
    
    MONITORVAL = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MONITORVAL[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( MONITORVAL__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( MONITORVAL__AnalogSerialOutput__ + i, MONITORVAL[i+1] );
    }
    
    MONITORSOURCE = new InOutArray<StringOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        MONITORSOURCE[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MONITORSOURCE__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MONITORSOURCE__AnalogSerialOutput__ + i, MONITORSOURCE[i+1] );
    }
    
    SOURCENAME = new InOutArray<StringParameter>( 14, this );
    for( uint i = 0; i < 14; i++ )
    {
        SOURCENAME[i+1] = new StringParameter( SOURCENAME__Parameter__ + i, SOURCENAME__Parameter__, this );
        m_ParameterList.Add( SOURCENAME__Parameter__ + i, SOURCENAME[i+1] );
    }
    
    
    SYSTEMONPRESS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEMONPRESS_OnPush_0, false ) );
    for( uint i = 0; i < 14; i++ )
        SOURCEPRESS[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCEPRESS_OnPush_1, false ) );
        
    for( uint i = 0; i < 8; i++ )
        MONITORPRESS[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( MONITORPRESS_OnPush_2, false ) );
        
    SETALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( SETALL_OnPush_3, false ) );
    CLEARALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEARALL_OnPush_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TOWSON_SOURCE_DRIVER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SETALL__DigitalInput__ = 0;
const uint CLEARALL__DigitalInput__ = 1;
const uint SYSTEMONPRESS__DigitalInput__ = 2;
const uint MONITORPRESS__DigitalInput__ = 3;
const uint SOURCEPRESS__DigitalInput__ = 11;
const uint MASTERSWVALUE__AnalogSerialOutput__ = 0;
const uint SOURCEPRESSED__DigitalOutput__ = 0;
const uint MONITORVAL__AnalogSerialOutput__ = 1;
const uint MONITORSOURCE__AnalogSerialOutput__ = 9;
const uint SOURCENAME__Parameter__ = 10;

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
