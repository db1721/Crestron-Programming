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

namespace UserModule_CONSOLE_PROCESSOR_V3_
{
    public class UserModuleClass_CONSOLE_PROCESSOR_V3_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput DEBUG;
        Crestron.Logos.SplusObjects.DigitalInput EN_CREATE_NVRAMDISK;
        Crestron.Logos.SplusObjects.DigitalInput GET_OS_INFO;
        Crestron.Logos.SplusObjects.DigitalInput GET_PROGRAM_INFO;
        Crestron.Logos.SplusObjects.DigitalInput GET_ETHER_INFO;
        Crestron.Logos.SplusObjects.DigitalInput CHECK_NVRAMDISK;
        Crestron.Logos.SplusObjects.BufferInput CONSOLE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput LINK_STATUS;
        Crestron.Logos.SplusObjects.DigitalOutput NVRAMDISK_PRESENT;
        Crestron.Logos.SplusObjects.AnalogOutput MODULE_STATUS;
        Crestron.Logos.SplusObjects.StringOutput CONSOLE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput OS_VERSION__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PROGRAM_FILE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LINK_SPEED__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FULL_DUPLEX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MAC_ADDRESS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IP_ADDRESS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HOST_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NVRAMDISK_STATUS__DOLLAR__;
        ushort G_BRXOK = 0;
        ushort G_IDATAMODE = 0;
        ushort G_BNEEDTOCREATENVRAMDISK = 0;
        CrestronString G_STEMPDATA;
        private void PROCESSDATA (  SplusExecutionContext __context__, CrestronString DATA ) 
            { 
            CrestronString SLOCALCOPY;
            CrestronString STRASH;
            SLOCALCOPY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
            STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 108;
            SLOCALCOPY  .UpdateValue ( DATA  ) ; 
            __context__.SourceCodeLine = 110;
            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 111;
                Print( "Data:{0}\r\n", SLOCALCOPY ) ; 
                }
            
            __context__.SourceCodeLine = 114;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IDATAMODE == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 116;
                if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 117;
                    Print( "Parsing Ethernet Data\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 119;
                if ( Functions.TestForTrue  ( ( Functions.Find( "Link Status:" , SLOCALCOPY ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 121;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "OK" , SLOCALCOPY ))  ) ) 
                        {
                        __context__.SourceCodeLine = 122;
                        LINK_STATUS  .Value = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 124;
                        LINK_STATUS  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 126;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "Link Speed:" , SLOCALCOPY ))  ) ) 
                        { 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 129;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "Full Duplex:" , SLOCALCOPY ))  ) ) 
                            { 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 132;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAC Address(es):" , SLOCALCOPY ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 134;
                                MAC_ADDRESS__DOLLAR__  .UpdateValue ( Functions.Mid ( SLOCALCOPY ,  (int) ( 20 ) ,  (int) ( 17 ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 136;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "IP Address:" , SLOCALCOPY ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 138;
                                    IP_ADDRESS__DOLLAR__  .UpdateValue ( Functions.Mid ( SLOCALCOPY ,  (int) ( 16 ) ,  (int) ( 15 ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 140;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "Host Name:" , SLOCALCOPY ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 142;
                                        STRASH  .UpdateValue ( Functions.Remove ( "Host Name:  " , SLOCALCOPY )  ) ; 
                                        __context__.SourceCodeLine = 144;
                                        HOST_NAME__DOLLAR__  .UpdateValue ( Functions.Left ( SLOCALCOPY ,  (int) ( (Functions.Length( SLOCALCOPY ) - 2) ) )  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 147;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IDATAMODE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 149;
                    if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 150;
                        Print( "Parsing OS Data\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 152;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SLOCALCOPY ) > 2 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 153;
                        OS_VERSION__DOLLAR__  .UpdateValue ( Functions.Left ( SLOCALCOPY ,  (int) ( (Functions.Length( SLOCALCOPY ) - 2) ) )  ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 155;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IDATAMODE == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 157;
                        if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 158;
                            Print( "Parsing Program Data\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 160;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "Program File:" , SLOCALCOPY ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 162;
                            STRASH  .UpdateValue ( Functions.Remove ( "Program File: " , SLOCALCOPY )  ) ; 
                            __context__.SourceCodeLine = 164;
                            PROGRAM_FILE__DOLLAR__  .UpdateValue ( Functions.Left ( SLOCALCOPY ,  (int) ( (Functions.Length( SLOCALCOPY ) - 2) ) )  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 167;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_IDATAMODE == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 169;
                            if ( Functions.TestForTrue  ( ( DEBUG  .Value)  ) ) 
                                {
                                __context__.SourceCodeLine = 170;
                                Print( "Parsing NVRamDisk Data\r\n") ; 
                                }
                            
                            __context__.SourceCodeLine = 172;
                            Print( "NVRamData:{0}\r\n", SLOCALCOPY ) ; 
                            __context__.SourceCodeLine = 174;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "NOT initialized" , SLOCALCOPY ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 177;
                                if ( Functions.TestForTrue  ( ( EN_CREATE_NVRAMDISK  .Value)  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 180;
                                    G_BNEEDTOCREATENVRAMDISK = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 185;
                                    NVRAMDISK_PRESENT  .Value = (ushort) ( 0 ) ; 
                                    __context__.SourceCodeLine = 186;
                                    NVRAMDISK_STATUS__DOLLAR__  .UpdateValue ( "Not Initialized"  ) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 189;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "64K" , SLOCALCOPY ) ) || Functions.TestForTrue ( Functions.Find( "128K" , SLOCALCOPY ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 191;
                                    NVRAMDISK_PRESENT  .Value = (ushort) ( 1 ) ; 
                                    __context__.SourceCodeLine = 192;
                                    NVRAMDISK_STATUS__DOLLAR__  .UpdateValue ( "Initialized"  ) ; 
                                    } 
                                
                                }
                            
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 197;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "NVRAM filesystem successfully initialized" , SLOCALCOPY ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 199;
                                NVRAMDISK_PRESENT  .Value = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 200;
                                NVRAMDISK_STATUS__DOLLAR__  .UpdateValue ( "Initialized"  ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        object GET_OS_INFO_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 213;
                G_IDATAMODE = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 214;
                MODULE_STATUS  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 216;
                CONSOLE_TX__DOLLAR__  .UpdateValue ( "ver\r"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object GET_PROGRAM_INFO_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 221;
            G_IDATAMODE = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 222;
            MODULE_STATUS  .Value = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 224;
            CONSOLE_TX__DOLLAR__  .UpdateValue ( "progcom\r"  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object GET_ETHER_INFO_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 229;
        G_IDATAMODE = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 230;
        MODULE_STATUS  .Value = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 232;
        CONSOLE_TX__DOLLAR__  .UpdateValue ( "est\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHECK_NVRAMDISK_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 237;
        G_IDATAMODE = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 238;
        MODULE_STATUS  .Value = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 240;
        CONSOLE_TX__DOLLAR__  .UpdateValue ( "vnvramdisk\r"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONSOLE_RX__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 245;
        if ( Functions.TestForTrue  ( ( G_BRXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 247;
            G_BRXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 249;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "\r\n" , CONSOLE_RX__DOLLAR__ ) ) || Functions.TestForTrue ( Functions.Find( ">" , CONSOLE_RX__DOLLAR__ ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 251;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\r\n" , CONSOLE_RX__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 253;
                    G_STEMPDATA  .UpdateValue ( Functions.Remove ( "\r\n" , CONSOLE_RX__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 254;
                    PROCESSDATA (  __context__ , G_STEMPDATA) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 256;
                    if ( Functions.TestForTrue  ( ( Functions.Find( ">" , CONSOLE_RX__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 259;
                        G_STEMPDATA  .UpdateValue ( Functions.Remove ( ">" , CONSOLE_RX__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 262;
                        MODULE_STATUS  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 263;
                        G_IDATAMODE = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 266;
                        if ( Functions.TestForTrue  ( ( G_BNEEDTOCREATENVRAMDISK)  ) ) 
                            { 
                            __context__.SourceCodeLine = 270;
                            G_BNEEDTOCREATENVRAMDISK = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 272;
                            CONSOLE_TX__DOLLAR__  .UpdateValue ( "vnvramdisk 128k\r"  ) ; 
                            __context__.SourceCodeLine = 274;
                            G_IDATAMODE = (ushort) ( 4 ) ; 
                            __context__.SourceCodeLine = 275;
                            MODULE_STATUS  .Value = (ushort) ( 4 ) ; 
                            } 
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 249;
                } 
            
            __context__.SourceCodeLine = 280;
            G_BRXOK = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 292;
        G_BRXOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 294;
        MODULE_STATUS  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 295;
        G_IDATAMODE = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_STEMPDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1000, this );
    
    DEBUG = new Crestron.Logos.SplusObjects.DigitalInput( DEBUG__DigitalInput__, this );
    m_DigitalInputList.Add( DEBUG__DigitalInput__, DEBUG );
    
    EN_CREATE_NVRAMDISK = new Crestron.Logos.SplusObjects.DigitalInput( EN_CREATE_NVRAMDISK__DigitalInput__, this );
    m_DigitalInputList.Add( EN_CREATE_NVRAMDISK__DigitalInput__, EN_CREATE_NVRAMDISK );
    
    GET_OS_INFO = new Crestron.Logos.SplusObjects.DigitalInput( GET_OS_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( GET_OS_INFO__DigitalInput__, GET_OS_INFO );
    
    GET_PROGRAM_INFO = new Crestron.Logos.SplusObjects.DigitalInput( GET_PROGRAM_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( GET_PROGRAM_INFO__DigitalInput__, GET_PROGRAM_INFO );
    
    GET_ETHER_INFO = new Crestron.Logos.SplusObjects.DigitalInput( GET_ETHER_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( GET_ETHER_INFO__DigitalInput__, GET_ETHER_INFO );
    
    CHECK_NVRAMDISK = new Crestron.Logos.SplusObjects.DigitalInput( CHECK_NVRAMDISK__DigitalInput__, this );
    m_DigitalInputList.Add( CHECK_NVRAMDISK__DigitalInput__, CHECK_NVRAMDISK );
    
    LINK_STATUS = new Crestron.Logos.SplusObjects.DigitalOutput( LINK_STATUS__DigitalOutput__, this );
    m_DigitalOutputList.Add( LINK_STATUS__DigitalOutput__, LINK_STATUS );
    
    NVRAMDISK_PRESENT = new Crestron.Logos.SplusObjects.DigitalOutput( NVRAMDISK_PRESENT__DigitalOutput__, this );
    m_DigitalOutputList.Add( NVRAMDISK_PRESENT__DigitalOutput__, NVRAMDISK_PRESENT );
    
    MODULE_STATUS = new Crestron.Logos.SplusObjects.AnalogOutput( MODULE_STATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MODULE_STATUS__AnalogSerialOutput__, MODULE_STATUS );
    
    CONSOLE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, CONSOLE_TX__DOLLAR__ );
    
    OS_VERSION__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OS_VERSION__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( OS_VERSION__DOLLAR____AnalogSerialOutput__, OS_VERSION__DOLLAR__ );
    
    PROGRAM_FILE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PROGRAM_FILE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROGRAM_FILE__DOLLAR____AnalogSerialOutput__, PROGRAM_FILE__DOLLAR__ );
    
    LINK_SPEED__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LINK_SPEED__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LINK_SPEED__DOLLAR____AnalogSerialOutput__, LINK_SPEED__DOLLAR__ );
    
    FULL_DUPLEX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FULL_DUPLEX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FULL_DUPLEX__DOLLAR____AnalogSerialOutput__, FULL_DUPLEX__DOLLAR__ );
    
    MAC_ADDRESS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MAC_ADDRESS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAC_ADDRESS__DOLLAR____AnalogSerialOutput__, MAC_ADDRESS__DOLLAR__ );
    
    IP_ADDRESS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IP_ADDRESS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IP_ADDRESS__DOLLAR____AnalogSerialOutput__, IP_ADDRESS__DOLLAR__ );
    
    HOST_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HOST_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HOST_NAME__DOLLAR____AnalogSerialOutput__, HOST_NAME__DOLLAR__ );
    
    NVRAMDISK_STATUS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NVRAMDISK_STATUS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NVRAMDISK_STATUS__DOLLAR____AnalogSerialOutput__, NVRAMDISK_STATUS__DOLLAR__ );
    
    CONSOLE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( CONSOLE_RX__DOLLAR____AnalogSerialInput__, 5000, this );
    m_StringInputList.Add( CONSOLE_RX__DOLLAR____AnalogSerialInput__, CONSOLE_RX__DOLLAR__ );
    
    
    GET_OS_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_OS_INFO_OnPush_0, false ) );
    GET_PROGRAM_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_PROGRAM_INFO_OnPush_1, false ) );
    GET_ETHER_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_ETHER_INFO_OnPush_2, false ) );
    CHECK_NVRAMDISK.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHECK_NVRAMDISK_OnPush_3, false ) );
    CONSOLE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CONSOLE_RX__DOLLAR___OnChange_4, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CONSOLE_PROCESSOR_V3_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint DEBUG__DigitalInput__ = 0;
const uint EN_CREATE_NVRAMDISK__DigitalInput__ = 1;
const uint GET_OS_INFO__DigitalInput__ = 2;
const uint GET_PROGRAM_INFO__DigitalInput__ = 3;
const uint GET_ETHER_INFO__DigitalInput__ = 4;
const uint CHECK_NVRAMDISK__DigitalInput__ = 5;
const uint CONSOLE_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint LINK_STATUS__DigitalOutput__ = 0;
const uint NVRAMDISK_PRESENT__DigitalOutput__ = 1;
const uint MODULE_STATUS__AnalogSerialOutput__ = 0;
const uint CONSOLE_TX__DOLLAR____AnalogSerialOutput__ = 1;
const uint OS_VERSION__DOLLAR____AnalogSerialOutput__ = 2;
const uint PROGRAM_FILE__DOLLAR____AnalogSerialOutput__ = 3;
const uint LINK_SPEED__DOLLAR____AnalogSerialOutput__ = 4;
const uint FULL_DUPLEX__DOLLAR____AnalogSerialOutput__ = 5;
const uint MAC_ADDRESS__DOLLAR____AnalogSerialOutput__ = 6;
const uint IP_ADDRESS__DOLLAR____AnalogSerialOutput__ = 7;
const uint HOST_NAME__DOLLAR____AnalogSerialOutput__ = 8;
const uint NVRAMDISK_STATUS__DOLLAR____AnalogSerialOutput__ = 9;

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
