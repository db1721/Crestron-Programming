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

namespace UserModule_NEC_RAW_COMMAND_PROCESSOR_W_ADDRESS1_2
{
    public class UserModuleClass_NEC_RAW_COMMAND_PROCESSOR_W_ADDRESS1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.AnalogInput SETVOL;
        Crestron.Logos.SplusObjects.AnalogInput ADDRESS;
        Crestron.Logos.SplusObjects.StringInput INPARAMSET;
        Crestron.Logos.SplusObjects.StringInput INCMDSET;
        Crestron.Logos.SplusObjects.StringInput INPARAMGET;
        Crestron.Logos.SplusObjects.StringInput INCMDGET;
        Crestron.Logos.SplusObjects.BufferInput FROMDEVICE;
        Crestron.Logos.SplusObjects.StringOutput OUT;
        Crestron.Logos.SplusObjects.StringOutput FROMDEVICEMATCH;
        CrestronString ADDRESSBYTES;
        CrestronString PROCESSRX__DOLLAR__;
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
            
        private void GETADDRESSBYTES (  SplusExecutionContext __context__ ) 
            { 
            ushort LARGE = 0;
            ushort SMALL = 0;
            
            
            __context__.SourceCodeLine = 95;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ADDRESS  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ADDRESS  .UshortValue < 105 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 97;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ADDRESS  .UshortValue < 27 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 99;
                    LARGE = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 100;
                    SMALL = (ushort) ( ADDRESS  .UshortValue ) ; 
                    __context__.SourceCodeLine = 101;
                    MakeString ( ADDRESSBYTES , "{0}{1}", Functions.Chr (  (int) ( (LARGE + 48) ) ) , Functions.Chr (  (int) ( (SMALL + 64) ) ) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 103;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ADDRESS  .UshortValue >= 27 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 105;
                        LARGE = (ushort) ( (ADDRESS  .UshortValue / 27) ) ; 
                        __context__.SourceCodeLine = 106;
                        SMALL = (ushort) ( Mod( ADDRESS  .UshortValue , 26 ) ) ; 
                        __context__.SourceCodeLine = 107;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SMALL == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 109;
                            SMALL = (ushort) ( 26 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 111;
                        MakeString ( ADDRESSBYTES , "{0}{1}", Functions.Chr (  (int) ( (LARGE + 48) ) ) , Functions.Chr (  (int) ( (SMALL + 64) ) ) ) ; 
                        } 
                    
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 116;
                ADDRESSBYTES  .UpdateValue ( "0*"  ) ; 
                } 
            
            
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
                
                
                __context__.SourceCodeLine = 123;
                IMSGLEN = (ushort) ( (Functions.Length( INPARAMSET ) + 2) ) ; 
                __context__.SourceCodeLine = 124;
                MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
                __context__.SourceCodeLine = 125;
                MakeString ( STEMP , "{0}\u0030\u0045{1}{2}\u0002{3}\u0003", ADDRESSBYTES , Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INPARAMSET ) ; 
                __context__.SourceCodeLine = 126;
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
            
            
            __context__.SourceCodeLine = 133;
            IMSGLEN = (ushort) ( (Functions.Length( INCMDSET ) + 2) ) ; 
            __context__.SourceCodeLine = 134;
            MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
            __context__.SourceCodeLine = 135;
            MakeString ( STEMP , "{0}\u0030\u0041{1}{2}\u0002{3}\u0003", ADDRESSBYTES , Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INCMDSET ) ; 
            __context__.SourceCodeLine = 136;
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
        
        
        __context__.SourceCodeLine = 144;
        IMSGLEN = (ushort) ( (Functions.Length( INPARAMGET ) + 2) ) ; 
        __context__.SourceCodeLine = 145;
        MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
        __context__.SourceCodeLine = 146;
        MakeString ( STEMP , "{0}\u0030\u0043{1}{2}\u0002{3}\u0003", ADDRESSBYTES , Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INPARAMGET ) ; 
        __context__.SourceCodeLine = 147;
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
        
        
        __context__.SourceCodeLine = 153;
        IMSGLEN = (ushort) ( (Functions.Length( INCMDGET ) + 2) ) ; 
        __context__.SourceCodeLine = 154;
        MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
        __context__.SourceCodeLine = 155;
        MakeString ( STEMP , "{0}\u0030\u0041{1}{2}\u0002{3}\u0003", ADDRESSBYTES , Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , INCMDGET ) ; 
        __context__.SourceCodeLine = 156;
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
        
        
        __context__.SourceCodeLine = 162;
        IVOLSCALE = (uint) ( ((SETVOL  .UintValue * 100) / 65535) ) ; 
        __context__.SourceCodeLine = 163;
        MakeString ( VOLTEMP , "{0:X2}", IVOLSCALE) ; 
        __context__.SourceCodeLine = 164;
        MakeString ( VOLTEMP2 , "{0}{1}", Functions.Mid ( VOLTEMP ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( VOLTEMP ,  (int) ( 2 ) ,  (int) ( 1 ) ) ) ; 
        __context__.SourceCodeLine = 165;
        MakeString ( MSG , "006200{0}", VOLTEMP2 ) ; 
        __context__.SourceCodeLine = 166;
        IMSGLEN = (uint) ( (Functions.Length( MSG ) + 2) ) ; 
        __context__.SourceCodeLine = 167;
        MakeString ( SMSGLEN , "{0:X2}", IMSGLEN) ; 
        __context__.SourceCodeLine = 168;
        MakeString ( STEMP , "{0}\u0030\u0045{1}{2}\u0002{3}\u0003", ADDRESSBYTES , Functions.Mid ( SMSGLEN ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( SMSGLEN ,  (int) ( 2 ) ,  (int) ( 1 ) ) , MSG ) ; 
        __context__.SourceCodeLine = 169;
        PROCESSSEND (  __context__ , STEMP) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROMDEVICE_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 174;
        PROCESSRX__DOLLAR__  .UpdateValue ( Functions.Gather ( "\u000d" , FROMDEVICE )  ) ; 
        __context__.SourceCodeLine = 175;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( PROCESSRX__DOLLAR__ , (int)( 2 ) ) == Byte( ADDRESSBYTES , (int)( 1 ) )) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( PROCESSRX__DOLLAR__ , (int)( 3 ) ) == Byte( ADDRESSBYTES , (int)( 2 ) )) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 177;
            FROMDEVICEMATCH  .UpdateValue ( PROCESSRX__DOLLAR__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ADDRESSBYTES == "0*") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( PROCESSRX__DOLLAR__ , (int)( 2 ) , (int)( 2 ) ) == "0A") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 181;
                FROMDEVICEMATCH  .UpdateValue ( PROCESSRX__DOLLAR__  ) ; 
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ADDRESS_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 186;
        GETADDRESSBYTES (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 190;
        GETADDRESSBYTES (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    ADDRESSBYTES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    PROCESSRX__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    SETVOL = new Crestron.Logos.SplusObjects.AnalogInput( SETVOL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SETVOL__AnalogSerialInput__, SETVOL );
    
    ADDRESS = new Crestron.Logos.SplusObjects.AnalogInput( ADDRESS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ADDRESS__AnalogSerialInput__, ADDRESS );
    
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
    
    FROMDEVICEMATCH = new Crestron.Logos.SplusObjects.StringOutput( FROMDEVICEMATCH__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FROMDEVICEMATCH__AnalogSerialOutput__, FROMDEVICEMATCH );
    
    FROMDEVICE = new Crestron.Logos.SplusObjects.BufferInput( FROMDEVICE__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FROMDEVICE__AnalogSerialInput__, FROMDEVICE );
    
    
    INPARAMSET.OnSerialChange.Add( new InputChangeHandlerWrapper( INPARAMSET_OnChange_0, false ) );
    INCMDSET.OnSerialChange.Add( new InputChangeHandlerWrapper( INCMDSET_OnChange_1, false ) );
    INPARAMGET.OnSerialChange.Add( new InputChangeHandlerWrapper( INPARAMGET_OnChange_2, false ) );
    INCMDGET.OnSerialChange.Add( new InputChangeHandlerWrapper( INCMDGET_OnChange_3, false ) );
    SETVOL.OnAnalogChange.Add( new InputChangeHandlerWrapper( SETVOL_OnChange_4, false ) );
    FROMDEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMDEVICE_OnChange_5, false ) );
    ADDRESS.OnAnalogChange.Add( new InputChangeHandlerWrapper( ADDRESS_OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_NEC_RAW_COMMAND_PROCESSOR_W_ADDRESS1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SETVOL__AnalogSerialInput__ = 0;
const uint ADDRESS__AnalogSerialInput__ = 1;
const uint INPARAMSET__AnalogSerialInput__ = 2;
const uint INCMDSET__AnalogSerialInput__ = 3;
const uint INPARAMGET__AnalogSerialInput__ = 4;
const uint INCMDGET__AnalogSerialInput__ = 5;
const uint FROMDEVICE__AnalogSerialInput__ = 6;
const uint OUT__AnalogSerialOutput__ = 0;
const uint FROMDEVICEMATCH__AnalogSerialOutput__ = 1;

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
