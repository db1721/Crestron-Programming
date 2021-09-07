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

namespace UserModule_NEC_RAW_COMMAND_PROCESSOR
{
    public class UserModuleClass_NEC_RAW_COMMAND_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput SETVOL;
        Crestron.Logos.SplusObjects.StringInput INPARAMSET;
        Crestron.Logos.SplusObjects.StringInput INCMDSET;
        Crestron.Logos.SplusObjects.StringInput INPARAMGET;
        Crestron.Logos.SplusObjects.StringInput INCMDGET;
        Crestron.Logos.SplusObjects.StringOutput OUT;
        private CrestronString PROCESSSEND (  SplusExecutionContext __context__, CrestronString CMD ) 
            { 
            ushort CMDLENGTH = 0;
            ushort I = 0;
            ushort RESULT = 0;
            
            
            __context__.SourceCodeLine = 82;
            CMDLENGTH = (ushort) ( Functions.Length( CMD ) ) ; 
            __context__.SourceCodeLine = 83;
            RESULT = (ushort) ( Byte( CMD , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 85;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 2 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)CMDLENGTH; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 87;
                RESULT = (ushort) ( (RESULT ^ Byte( CMD , (int)( I ) )) ) ; 
                __context__.SourceCodeLine = 85;
                } 
            
            __context__.SourceCodeLine = 90;
            OUT  .UpdateValue ( "\u0001" + CMD + Functions.Chr (  (int) ( Functions.Low( (ushort) RESULT ) ) ) + "\u000d"  ) ; 
            
            return ""; // default return value (none specified in module)
            }
            
        object INPARAMSET_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort IMSGLEN = 0;
                
                CrestronString SMSGLEN;
                CrestronString STEMP;
                SMSGLEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
                STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
                
                
                __context__.SourceCodeLine = 96;
                IMSGLEN = (ushort) ( (Functions.Length( INPARAMSET ) + 2) ) ; 
                __context__.SourceCodeLine = 97;
                MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
                __context__.SourceCodeLine = 98;
                MakeString ( STEMP , "\u0030\u0041\u0030\u0045{0}{1}\u0002{2}\u0003", Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INPARAMSET ) ; 
                __context__.SourceCodeLine = 99;
                PROCESSSEND (  __context__ , STEMP) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INCMDSET_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort IMSGLEN = 0;
            
            CrestronString SMSGLEN;
            CrestronString STEMP;
            SMSGLEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 106;
            IMSGLEN = (ushort) ( (Functions.Length( INCMDSET ) + 2) ) ; 
            __context__.SourceCodeLine = 107;
            MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
            __context__.SourceCodeLine = 108;
            MakeString ( STEMP , "\u0030\u0041\u0030\u0041{0}{1}\u0002{2}\u0003", Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INCMDSET ) ; 
            __context__.SourceCodeLine = 109;
            PROCESSSEND (  __context__ , STEMP) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object INPARAMGET_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IMSGLEN = 0;
        
        CrestronString SMSGLEN;
        CrestronString STEMP;
        SMSGLEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
        STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        
        
        __context__.SourceCodeLine = 117;
        IMSGLEN = (ushort) ( (Functions.Length( INPARAMGET ) + 2) ) ; 
        __context__.SourceCodeLine = 118;
        MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
        __context__.SourceCodeLine = 119;
        MakeString ( STEMP , "\u0030\u0041\u0030\u0043{0}{1}\u0002{2}\u0003", Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INPARAMGET ) ; 
        __context__.SourceCodeLine = 120;
        PROCESSSEND (  __context__ , STEMP) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INCMDGET_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IMSGLEN = 0;
        
        CrestronString SMSGLEN;
        CrestronString STEMP;
        SMSGLEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
        STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        
        
        __context__.SourceCodeLine = 126;
        IMSGLEN = (ushort) ( (Functions.Length( INCMDGET ) + 2) ) ; 
        __context__.SourceCodeLine = 127;
        MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
        __context__.SourceCodeLine = 128;
        MakeString ( STEMP , "\u0030\u0041\u0030\u0041{0}{1}\u0002{2}\u0003", Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INCMDGET ) ; 
        __context__.SourceCodeLine = 129;
        PROCESSSEND (  __context__ , STEMP) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SETVOL_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        uint IVOLSCALE = 0;
        uint IMSGLEN = 0;
        
        CrestronString MSG;
        CrestronString SMSGLEN;
        CrestronString STEMP;
        CrestronString VOLTEMP;
        CrestronString VOLTEMP2;
        MSG  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
        SMSGLEN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
        STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        VOLTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        VOLTEMP2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        
        
        __context__.SourceCodeLine = 135;
        IVOLSCALE = (uint) ( ((SETVOL  .UintValue * 100) / 65535) ) ; 
        __context__.SourceCodeLine = 136;
        MakeString ( VOLTEMP , "{0:X2}", IVOLSCALE) ; 
        __context__.SourceCodeLine = 137;
        MakeString ( VOLTEMP2 , "{0}{1}", Functions.Mid ( VOLTEMP ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( VOLTEMP ,  (int) ( 2 ) ,  (int) ( 1 ) ) ) ; 
        __context__.SourceCodeLine = 138;
        MakeString ( MSG , "006200{0}", VOLTEMP2 ) ; 
        __context__.SourceCodeLine = 139;
        IMSGLEN = (uint) ( (Functions.Length( MSG ) + 2) ) ; 
        __context__.SourceCodeLine = 140;
        MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
        __context__.SourceCodeLine = 141;
        MakeString ( STEMP , "\u0030\u0041\u0030\u0045{0}{1}\u0002{2}\u0003", Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , MSG ) ; 
        __context__.SourceCodeLine = 142;
        PROCESSSEND (  __context__ , STEMP) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SETVOL = new Crestron.Logos.SplusObjects.AnalogInput( SETVOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETVOL__AnalogSerialInput__, SETVOL );
    
    INPARAMSET = new Crestron.Logos.SplusObjects.StringInput( INPARAMSET__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( INPARAMSET__AnalogSerialInput__, INPARAMSET );
    
    INCMDSET = new Crestron.Logos.SplusObjects.StringInput( INCMDSET__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( INCMDSET__AnalogSerialInput__, INCMDSET );
    
    INPARAMGET = new Crestron.Logos.SplusObjects.StringInput( INPARAMGET__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( INPARAMGET__AnalogSerialInput__, INPARAMGET );
    
    INCMDGET = new Crestron.Logos.SplusObjects.StringInput( INCMDGET__AnalogSerialInput__, 200, this );
    m_StringInputList.Add( INCMDGET__AnalogSerialInput__, INCMDGET );
    
    OUT = new Crestron.Logos.SplusObjects.StringOutput( OUT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( OUT__AnalogSerialOutput__, OUT );
    
    
    INPARAMSET.OnSerialChange.Add( new InputChangeHandlerWrapper( INPARAMSET_OnChange_0, false ) );
    INCMDSET.OnSerialChange.Add( new InputChangeHandlerWrapper( INCMDSET_OnChange_1, false ) );
    INPARAMGET.OnSerialChange.Add( new InputChangeHandlerWrapper( INPARAMGET_OnChange_2, false ) );
    INCMDGET.OnSerialChange.Add( new InputChangeHandlerWrapper( INCMDGET_OnChange_3, false ) );
    SETVOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETVOL_OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_NEC_RAW_COMMAND_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SETVOL__AnalogSerialInput__ = 0;
const uint INPARAMSET__AnalogSerialInput__ = 1;
const uint INCMDSET__AnalogSerialInput__ = 2;
const uint INPARAMGET__AnalogSerialInput__ = 3;
const uint INCMDGET__AnalogSerialInput__ = 4;
const uint OUT__AnalogSerialOutput__ = 0;

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
