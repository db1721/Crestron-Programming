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

namespace UserModule_VISCA_232_LOCAL_PRESET_OPERATOR
{
    public class UserModuleClass_VISCA_232_LOCAL_PRESET_OPERATOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput RECALL;
        Crestron.Logos.SplusObjects.DigitalInput STORE;
        Crestron.Logos.SplusObjects.DigitalInput STOREMASTER;
        Crestron.Logos.SplusObjects.DigitalInput RECALLMASTER;
        Crestron.Logos.SplusObjects.BufferInput IN__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput PRESET;
        Crestron.Logos.SplusObjects.StringOutput OUT__DOLLAR__;
        ushort STORETYPE = 0;
        ushort [,] PRESETARRAY;
        CrestronString FILENAME;
        private void READPRESETS (  SplusExecutionContext __context__ ) 
            { 
            short NFILEHANDLE = 0;
            short IERRORCODE = 0;
            
            
            __context__.SourceCodeLine = 50;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 51;
            NFILEHANDLE = (short) ( FileOpenShared( FILENAME ,(ushort) (256 | 0) ) ) ; 
            __context__.SourceCodeLine = 52;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 54;
                IERRORCODE = (short) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref PRESETARRAY ) ) ; 
                __context__.SourceCodeLine = 55;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 57;
                    Trace( "Read Preset array from file correctly. Length {0:d}\r\n", (ushort)IERRORCODE) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 61;
                    Trace( "Error code Preset {0:d}\r\n", (short)IERRORCODE) ; 
                    } 
                
                __context__.SourceCodeLine = 63;
                FileClose (  (short) ( NFILEHANDLE ) ) ; 
                } 
            
            __context__.SourceCodeLine = 65;
            EndFileOperations ( ) ; 
            
            }
            
        private void SENDPRESET (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 70;
            MakeString ( OUT__DOLLAR__ , "\u0081\u0001\u0006\u000b\u0018\u0014{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}\u00ff", Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 1 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 2 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 3 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 4 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 5 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 6 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 7 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 8 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 9 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 10 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 11 ] ) ) , Functions.Chr (  (int) ( PRESETARRAY[ PRESET  .UshortValue , 12 ] ) ) ) ; 
            
            }
            
        private void RECALL_LAYOUT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 75;
            READPRESETS (  __context__  ) ; 
            __context__.SourceCodeLine = 76;
            SENDPRESET (  __context__  ) ; 
            
            }
            
        private void WRITEARRAY (  SplusExecutionContext __context__ ) 
            { 
            short NFILEHANDLE = 0;
            short IERRORCODE = 0;
            
            
            __context__.SourceCodeLine = 81;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 82;
            NFILEHANDLE = (short) ( FileOpenShared( FILENAME ,(ushort) ((256 | 512) | 1) ) ) ; 
            __context__.SourceCodeLine = 83;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 85;
                IERRORCODE = (short) ( WriteIntegerArray( (short)( NFILEHANDLE ) , PRESETARRAY ) ) ; 
                __context__.SourceCodeLine = 86;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 88;
                    Trace( "Array written to file correctly with {0:d} bytes.\r\n", (short)IERRORCODE) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 92;
                    Trace( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                    } 
                
                __context__.SourceCodeLine = 94;
                FileClose (  (short) ( NFILEHANDLE ) ) ; 
                } 
            
            __context__.SourceCodeLine = 96;
            EndFileOperations ( ) ; 
            
            }
            
        private void STORE_LAYOUT (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 101;
            OUT__DOLLAR__  .UpdateValue ( "\u0081\u0009\u0006\u0012\u00ff"  ) ; 
            
            }
            
        object IN__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString TEMP;
                TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
                
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 107;
                TEMP  .UpdateValue ( Functions.Gather ( "\u00ff" , IN__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STORETYPE == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 110;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMP , (int)( 2 ) ) == 80) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMP ) == 11) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 112;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)8; 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 114;
                            PRESETARRAY [ PRESET  .UshortValue , I] = (ushort) ( Byte( TEMP , (int)( (I + 2) ) ) ) ; 
                            __context__.SourceCodeLine = 112;
                            } 
                        
                        __context__.SourceCodeLine = 116;
                        OUT__DOLLAR__  .UpdateValue ( "\u0081\u0009\u0004\u0047\u00ff"  ) ; 
                        __context__.SourceCodeLine = 117;
                        Trace( "Store PT Processed") ; 
                        } 
                    
                    __context__.SourceCodeLine = 119;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMP , (int)( 2 ) ) == 80) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMP ) == 7) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 121;
                        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__2 = (ushort)4; 
                        int __FN_FORSTEP_VAL__2 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                            { 
                            __context__.SourceCodeLine = 123;
                            PRESETARRAY [ PRESET  .UshortValue , (I + 8)] = (ushort) ( Byte( TEMP , (int)( (I + 2) ) ) ) ; 
                            __context__.SourceCodeLine = 121;
                            } 
                        
                        __context__.SourceCodeLine = 125;
                        Trace( "Store Zoom Processed") ; 
                        __context__.SourceCodeLine = 126;
                        WRITEARRAY (  __context__  ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 129;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STORETYPE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 131;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMP , (int)( 2 ) ) == 80) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMP ) == 11) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 133;
                        ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__3 = (ushort)8; 
                        int __FN_FORSTEP_VAL__3 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                            { 
                            __context__.SourceCodeLine = 135;
                            PRESETARRAY [ (PRESET  .UshortValue + 90) , I] = (ushort) ( Byte( TEMP , (int)( (I + 2) ) ) ) ; 
                            __context__.SourceCodeLine = 133;
                            } 
                        
                        __context__.SourceCodeLine = 137;
                        OUT__DOLLAR__  .UpdateValue ( "\u0081\u0009\u0004\u0047\u00ff"  ) ; 
                        __context__.SourceCodeLine = 138;
                        Trace( "StoreMaster PT Processed") ; 
                        } 
                    
                    __context__.SourceCodeLine = 140;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( TEMP , (int)( 2 ) ) == 80) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMP ) == 7) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 142;
                        ushort __FN_FORSTART_VAL__4 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__4 = (ushort)4; 
                        int __FN_FORSTEP_VAL__4 = (int)1; 
                        for ( I  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (I  >= __FN_FORSTART_VAL__4) && (I  <= __FN_FOREND_VAL__4) ) : ( (I  <= __FN_FORSTART_VAL__4) && (I  >= __FN_FOREND_VAL__4) ) ; I  += (ushort)__FN_FORSTEP_VAL__4) 
                            { 
                            __context__.SourceCodeLine = 144;
                            PRESETARRAY [ (PRESET  .UshortValue + 90) , (I + 8)] = (ushort) ( Byte( TEMP , (int)( (I + 2) ) ) ) ; 
                            __context__.SourceCodeLine = 142;
                            } 
                        
                        __context__.SourceCodeLine = 146;
                        Trace( "Store Zoom Processed") ; 
                        __context__.SourceCodeLine = 147;
                        WRITEARRAY (  __context__  ) ; 
                        } 
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STORE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 153;
            STORETYPE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 154;
            STORE_LAYOUT (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object STOREMASTER_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 158;
        STORETYPE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 159;
        STORE_LAYOUT (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALLMASTER_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 164;
        READPRESETS (  __context__  ) ; 
        __context__.SourceCodeLine = 165;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 167;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)12; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (X  >= __FN_FORSTART_VAL__2) && (X  <= __FN_FOREND_VAL__2) ) : ( (X  <= __FN_FORSTART_VAL__2) && (X  >= __FN_FOREND_VAL__2) ) ; X  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 169;
                PRESETARRAY [ I , X] = (ushort) ( PRESETARRAY[ (I + 90) , X ] ) ; 
                __context__.SourceCodeLine = 167;
                } 
            
            __context__.SourceCodeLine = 165;
            } 
        
        __context__.SourceCodeLine = 172;
        WRITEARRAY (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RECALL_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 176;
        RECALL_LAYOUT (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 180;
        FILENAME  .UpdateValue ( "\\USER\\" + "Camera" + GetSymbolReferenceName ( ) + ".dat"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    PRESETARRAY  = new ushort[ 100,13 ];
    FILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, this );
    
    RECALL = new Crestron.Logos.SplusObjects.DigitalInput( RECALL__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL__DigitalInput__, RECALL );
    
    STORE = new Crestron.Logos.SplusObjects.DigitalInput( STORE__DigitalInput__, this );
    m_DigitalInputList.Add( STORE__DigitalInput__, STORE );
    
    STOREMASTER = new Crestron.Logos.SplusObjects.DigitalInput( STOREMASTER__DigitalInput__, this );
    m_DigitalInputList.Add( STOREMASTER__DigitalInput__, STOREMASTER );
    
    RECALLMASTER = new Crestron.Logos.SplusObjects.DigitalInput( RECALLMASTER__DigitalInput__, this );
    m_DigitalInputList.Add( RECALLMASTER__DigitalInput__, RECALLMASTER );
    
    PRESET = new Crestron.Logos.SplusObjects.AnalogInput( PRESET__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PRESET__AnalogSerialInput__, PRESET );
    
    OUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OUT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OUT__DOLLAR____AnalogSerialOutput__, OUT__DOLLAR__ );
    
    IN__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( IN__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( IN__DOLLAR____AnalogSerialInput__, IN__DOLLAR__ );
    
    
    IN__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( IN__DOLLAR___OnChange_0, false ) );
    STORE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STORE_OnPush_1, false ) );
    STOREMASTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOREMASTER_OnPush_2, false ) );
    RECALLMASTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALLMASTER_OnPush_3, false ) );
    RECALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_OnPush_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_VISCA_232_LOCAL_PRESET_OPERATOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint RECALL__DigitalInput__ = 0;
const uint STORE__DigitalInput__ = 1;
const uint STOREMASTER__DigitalInput__ = 2;
const uint RECALLMASTER__DigitalInput__ = 3;
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
