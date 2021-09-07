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

namespace UserModule_DMP64_SINGLE_CHANNEL_PROCESSOR
{
    public class UserModuleClass_DMP64_SINGLE_CHANNEL_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput GETVAL;
        Crestron.Logos.SplusObjects.DigitalInput MUTEON;
        Crestron.Logos.SplusObjects.DigitalInput MUTEOFF;
        Crestron.Logos.SplusObjects.AnalogInput SETVAL;
        Crestron.Logos.SplusObjects.StringInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput MUTEONFB;
        Crestron.Logos.SplusObjects.DigitalOutput MUTEOFFFB;
        Crestron.Logos.SplusObjects.AnalogOutput VALFB;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        StringParameter CTLPNT;
        CrestronString CTLVAL;
        CrestronString CTLMUTE;
        object SETVAL_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 89;
                MakeString ( TX__DOLLAR__ , "\u001bG{0}*{1:d4}AU\r", CTLPNT , (short)SETVAL  .UshortValue) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object RX__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort MUTEVAL = 0;
            ushort VOLVAL = 0;
            
            CrestronString TEMP;
            TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 95;
            TEMP  .UpdateValue ( Functions.Gather ( "\r" , RX__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 96;
            if ( Functions.TestForTrue  ( ( Functions.Find( CTLVAL , TEMP ))  ) ) 
                { 
                __context__.SourceCodeLine = 98;
                VOLVAL = (ushort) ( Functions.Atoi( Functions.Mid( TEMP , (int)( (Functions.Find( "*" , TEMP ) + 1) ) , (int)( ((Functions.Find( "\r" , TEMP ) - Functions.Find( "*" , TEMP )) - 1) ) ) ) ) ; 
                __context__.SourceCodeLine = 99;
                if ( Functions.TestForTrue  ( ( Functions.Find( "-" , TEMP ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 101;
                    VALFB  .Value = (ushort) ( (VOLVAL * Functions.ToInteger( -( 1 ) )) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 105;
                    VALFB  .Value = (ushort) ( VOLVAL ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( Functions.Find( CTLMUTE , TEMP ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 110;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_1__ = ((int)Functions.Atoi( Functions.Mid( TEMP , (int)( (Functions.Find( "*" , TEMP ) + 1) ) , (int)( 1 ) ) ));
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 114;
                                MUTEONFB  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 115;
                                MUTEOFFFB  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 119;
                                MUTEONFB  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 120;
                                MUTEOFFFB  .Value = (ushort) ( 0 ) ; 
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
    
object MUTEON_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 128;
        MakeString ( TX__DOLLAR__ , "\u001bM{0}*1AU\r", CTLPNT ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTEOFF_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 132;
        MakeString ( TX__DOLLAR__ , "\u001bM{0}*0AU\r", CTLPNT ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GETVAL_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 137;
        MakeString ( TX__DOLLAR__ , "\u001b3CV\r") ; 
        __context__.SourceCodeLine = 138;
        Functions.ProcessLogic ( ) ; 
        __context__.SourceCodeLine = 139;
        MakeString ( TX__DOLLAR__ , "\u001bG{0}AU\r", CTLPNT ) ; 
        __context__.SourceCodeLine = 140;
        Functions.ProcessLogic ( ) ; 
        __context__.SourceCodeLine = 141;
        MakeString ( TX__DOLLAR__ , "\u001bM{0}AU\r", CTLPNT ) ; 
        
        
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
        
        __context__.SourceCodeLine = 146;
        CTLVAL  .UpdateValue ( "DsG" + CTLPNT  ) ; 
        __context__.SourceCodeLine = 147;
        CTLMUTE  .UpdateValue ( "DsM" + CTLPNT  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    CTLVAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    CTLMUTE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    
    GETVAL = new Crestron.Logos.SplusObjects.DigitalInput( GETVAL__DigitalInput__, this );
    m_DigitalInputList.Add( GETVAL__DigitalInput__, GETVAL );
    
    MUTEON = new Crestron.Logos.SplusObjects.DigitalInput( MUTEON__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEON__DigitalInput__, MUTEON );
    
    MUTEOFF = new Crestron.Logos.SplusObjects.DigitalInput( MUTEOFF__DigitalInput__, this );
    m_DigitalInputList.Add( MUTEOFF__DigitalInput__, MUTEOFF );
    
    MUTEONFB = new Crestron.Logos.SplusObjects.DigitalOutput( MUTEONFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTEONFB__DigitalOutput__, MUTEONFB );
    
    MUTEOFFFB = new Crestron.Logos.SplusObjects.DigitalOutput( MUTEOFFFB__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTEOFFFB__DigitalOutput__, MUTEOFFFB );
    
    SETVAL = new Crestron.Logos.SplusObjects.AnalogInput( SETVAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETVAL__AnalogSerialInput__, SETVAL );
    
    VALFB = new Crestron.Logos.SplusObjects.AnalogOutput( VALFB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VALFB__AnalogSerialOutput__, VALFB );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RX__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    CTLPNT = new StringParameter( CTLPNT__Parameter__, this );
    m_ParameterList.Add( CTLPNT__Parameter__, CTLPNT );
    
    
    SETVAL.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETVAL_OnChange_0, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_1, false ) );
    MUTEON.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEON_OnPush_2, false ) );
    MUTEOFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTEOFF_OnPush_3, false ) );
    GETVAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( GETVAL_OnPush_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DMP64_SINGLE_CHANNEL_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint GETVAL__DigitalInput__ = 0;
const uint MUTEON__DigitalInput__ = 1;
const uint MUTEOFF__DigitalInput__ = 2;
const uint SETVAL__AnalogSerialInput__ = 0;
const uint RX__DOLLAR____AnalogSerialInput__ = 1;
const uint MUTEONFB__DigitalOutput__ = 0;
const uint MUTEOFFFB__DigitalOutput__ = 1;
const uint VALFB__AnalogSerialOutput__ = 0;
const uint TX__DOLLAR____AnalogSerialOutput__ = 1;
const uint CTLPNT__Parameter__ = 10;

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
