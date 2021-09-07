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

namespace CrestronModule_FUSION_GENERIC_TEXT_QUEUE_V1_0_0
{
    public class CrestronModuleClass_FUSION_GENERIC_TEXT_QUEUE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput RV_ONLINE;
        Crestron.Logos.SplusObjects.StringInput LOG_TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput QUE_COUNT;
        Crestron.Logos.SplusObjects.StringOutput TO_RV_LOG_TEXT__DOLLAR__;
        ushort G_ILOGTEXTCOUNT = 0;
        CrestronString G_SINITIALIZED;
        CrestronString [] G_SLOGTEXT;
        private void SENDLOGEVENTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 38;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)G_ILOGTEXTCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 40;
                TO_RV_LOG_TEXT__DOLLAR__  .UpdateValue ( G_SLOGTEXT [ I ]  ) ; 
                __context__.SourceCodeLine = 38;
                } 
            
            __context__.SourceCodeLine = 43;
            G_ILOGTEXTCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 45;
            QUE_COUNT  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void SHIFTLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 52;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 54;
                Print( "** ShiftList **\r\n") ; 
                } 
            
            __context__.SourceCodeLine = 58;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( G_ILOGTEXTCOUNT ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)1; 
            int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 60;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I < 100 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 62;
                    G_SLOGTEXT [ (I + 1) ]  .UpdateValue ( G_SLOGTEXT [ I ]  ) ; 
                    } 
                
                __context__.SourceCodeLine = 58;
                } 
            
            
            }
            
        object RV_ONLINE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 71;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ILOGTEXTCOUNT > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 73;
                    SENDLOGEVENTS (  __context__  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LOG_TEXT__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 80;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 82;
                Print( "LenLogText:{0:d}\r\n", (ushort)Functions.Length( LOG_TEXT__DOLLAR__ )) ; 
                } 
            
            __context__.SourceCodeLine = 86;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ILOGTEXTCOUNT > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 88;
                SHIFTLIST (  __context__  ) ; 
                } 
            
            __context__.SourceCodeLine = 91;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ILOGTEXTCOUNT < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 93;
                G_ILOGTEXTCOUNT = (ushort) ( (G_ILOGTEXTCOUNT + 1) ) ; 
                __context__.SourceCodeLine = 95;
                QUE_COUNT  .Value = (ushort) ( G_ILOGTEXTCOUNT ) ; 
                } 
            
            __context__.SourceCodeLine = 98;
            G_SLOGTEXT [ 1 ]  .UpdateValue ( LOG_TEXT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 100;
            if ( Functions.TestForTrue  ( ( RV_ONLINE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 102;
                SENDLOGEVENTS (  __context__  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    ushort I = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 111;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 114;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SINITIALIZED != "YES"))  ) ) 
            { 
            __context__.SourceCodeLine = 116;
            G_ILOGTEXTCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 118;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)100; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 120;
                G_SLOGTEXT [ I ]  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 118;
                } 
            
            __context__.SourceCodeLine = 123;
            G_SINITIALIZED  .UpdateValue ( "YES"  ) ; 
            } 
        
        __context__.SourceCodeLine = 126;
        QUE_COUNT  .Value = (ushort) ( G_ILOGTEXTCOUNT ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SINITIALIZED  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    G_SLOGTEXT  = new CrestronString[ 101 ];
    for( uint i = 0; i < 101; i++ )
        G_SLOGTEXT [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    RV_ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( RV_ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( RV_ONLINE__DigitalInput__, RV_ONLINE );
    
    QUE_COUNT = new Crestron.Logos.SplusObjects.AnalogOutput( QUE_COUNT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( QUE_COUNT__AnalogSerialOutput__, QUE_COUNT );
    
    LOG_TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( LOG_TEXT__DOLLAR____AnalogSerialInput__, 200, this );
    m_StringInputList.Add( LOG_TEXT__DOLLAR____AnalogSerialInput__, LOG_TEXT__DOLLAR__ );
    
    TO_RV_LOG_TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_RV_LOG_TEXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_RV_LOG_TEXT__DOLLAR____AnalogSerialOutput__, TO_RV_LOG_TEXT__DOLLAR__ );
    
    
    RV_ONLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RV_ONLINE_OnPush_0, false ) );
    LOG_TEXT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LOG_TEXT__DOLLAR___OnChange_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_FUSION_GENERIC_TEXT_QUEUE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint RV_ONLINE__DigitalInput__ = 1;
const uint LOG_TEXT__DOLLAR____AnalogSerialInput__ = 0;
const uint QUE_COUNT__AnalogSerialOutput__ = 0;
const uint TO_RV_LOG_TEXT__DOLLAR____AnalogSerialOutput__ = 1;

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
