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

namespace UserModule_TU_DISPLAY_CONFIG_DRIVER1_0
{
    public class UserModuleClass_TU_DISPLAY_CONFIG_DRIVER1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SYSREADY;
        Crestron.Logos.SplusObjects.DigitalInput REINIT;
        Crestron.Logos.SplusObjects.DigitalOutput PROCESSCOMPLETE;
        Crestron.Logos.SplusObjects.DigitalOutput DUALVIDEOENABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DISPLAYHASSCREEN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> DISPLAYMODEL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> DISPLAYNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> DISPLAYIP;
        CrestronString FILEDATA;
        CrestronString LINE;
        CrestronString TEMP;
        private void GETITEM (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 80;
            TEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 81;
            if ( Functions.TestForTrue  ( ( Functions.Find( "|" , LINE ))  ) ) 
                { 
                __context__.SourceCodeLine = 83;
                TEMP  .UpdateValue ( Functions.Remove ( "|" , LINE )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 85;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\r" , LINE ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 87;
                    TEMP  .UpdateValue ( Functions.Remove ( "\r" , LINE )  ) ; 
                    } 
                
                }
            
            
            }
            
        private CrestronString GETASCII (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 93;
            GETITEM (  __context__  ) ; 
            __context__.SourceCodeLine = 94;
            return ( Functions.Left ( TEMP ,  (int) ( (Functions.Length( TEMP ) - 1) ) ) ) ; 
            
            }
            
        private ushort GETINTEGER (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 98;
            GETITEM (  __context__  ) ; 
            __context__.SourceCodeLine = 99;
            return (ushort)( Functions.Atoi( TEMP )) ; 
            
            }
            
        private void PROCESSREAD (  SplusExecutionContext __context__ ) 
            { 
            ushort LINENUM = 0;
            ushort ITEMNUM = 0;
            
            
            __context__.SourceCodeLine = 106;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FILEDATA ) > 2 ))  ) ) 
                { 
                __context__.SourceCodeLine = 108;
                Trace( "File Process Loop, FileDataLen = {0:d}  FileData = {1}", (ushort)Functions.Length( FILEDATA ), FILEDATA ) ; 
                __context__.SourceCodeLine = 109;
                LINE  .UpdateValue ( Functions.Remove ( "\u000d\u000a" , FILEDATA )  ) ; 
                __context__.SourceCodeLine = 110;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( LINE , (int)( 2 ) ) != "//") ) && Functions.TestForTrue ( Functions.Find( ")" , LINE ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 112;
                    LINENUM = (ushort) ( Functions.Atoi( Functions.Remove( "." , LINE ) ) ) ; 
                    __context__.SourceCodeLine = 113;
                    ITEMNUM = (ushort) ( Functions.Atoi( Functions.Remove( ")" , LINE ) ) ) ; 
                    __context__.SourceCodeLine = 114;
                    Trace( "Processing Lineitem #{0:d}.{1:d}", (ushort)LINENUM, (ushort)ITEMNUM) ; 
                    __context__.SourceCodeLine = 115;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_1__ = ((int)LINENUM);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 119;
                                DISPLAYNAME [ ITEMNUM]  .UpdateValue ( GETASCII (  __context__  )  ) ; 
                                __context__.SourceCodeLine = 120;
                                DISPLAYMODEL [ ITEMNUM]  .Value = (ushort) ( GETINTEGER( __context__ ) ) ; 
                                __context__.SourceCodeLine = 121;
                                DISPLAYHASSCREEN [ ITEMNUM]  .Value = (ushort) ( GETINTEGER( __context__ ) ) ; 
                                __context__.SourceCodeLine = 122;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYMODEL[ ITEMNUM ] .Value > 100 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( DISPLAYMODEL[ ITEMNUM ] .Value < 200 ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 124;
                                    DISPLAYIP [ ITEMNUM]  .UpdateValue ( GETASCII (  __context__  )  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 129;
                                    DISPLAYIP [ ITEMNUM]  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 136;
                                DUALVIDEOENABLE  .Value = (ushort) ( GETINTEGER( __context__ ) ) ; 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 106;
                } 
            
            
            }
            
        private void READMAIN (  SplusExecutionContext __context__ ) 
            { 
            short HANDLE = 0;
            short ERR = 0;
            
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 147;
            ERR = (short) ( StartFileOperations() ) ; 
            __context__.SourceCodeLine = 148;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ERR < 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 150;
                Trace( "Error Starting File Operations") ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 152;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ERR >= 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 154;
                    HANDLE = (short) ( FileOpenShared( "\\USER\\DisplayConfig.txt" ,(ushort) (16384 | 0) ) ) ; 
                    __context__.SourceCodeLine = 155;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HANDLE < 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 157;
                        Trace( "Error Opening File") ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 159;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( HANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 161;
                            Trace( "Reading File") ; 
                            __context__.SourceCodeLine = 162;
                            X = (ushort) ( FileLength( (short)( HANDLE ) ) ) ; 
                            __context__.SourceCodeLine = 163;
                            ERR = (short) ( FileRead( (short)( HANDLE ) , FILEDATA , (ushort)( X ) ) ) ; 
                            __context__.SourceCodeLine = 164;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ERR < 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 166;
                                Trace( "Error Reading File") ; 
                                } 
                            
                            __context__.SourceCodeLine = 168;
                            Trace( "FileLength = {0:d}", (ushort)FileLength( (short)( HANDLE ) )) ; 
                            __context__.SourceCodeLine = 169;
                            Trace( "FileData = {0}", FILEDATA ) ; 
                            __context__.SourceCodeLine = 170;
                            Trace( "FileData Length {0:d}", (ushort)Functions.Length( FILEDATA )) ; 
                            __context__.SourceCodeLine = 171;
                            FileClose (  (short) ( HANDLE ) ) ; 
                            } 
                        
                        }
                    
                    __context__.SourceCodeLine = 173;
                    EndFileOperations ( ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 175;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (X == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 177;
                Trace( "New File Read") ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 180;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 182;
                    PROCESSREAD (  __context__  ) ; 
                    } 
                
                }
            
            
            }
            
        object REINIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 188;
                PROCESSCOMPLETE  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 189;
                READMAIN (  __context__  ) ; 
                __context__.SourceCodeLine = 190;
                PROCESSCOMPLETE  .Value = (ushort) ( 1 ) ; 
                
                
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
            
            __context__.SourceCodeLine = 195;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSREADY  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 197;
                Functions.Delay (  (int) ( 10 ) ) ; 
                __context__.SourceCodeLine = 195;
                } 
            
            __context__.SourceCodeLine = 199;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 200;
            READMAIN (  __context__  ) ; 
            __context__.SourceCodeLine = 201;
            PROCESSCOMPLETE  .Value = (ushort) ( 1 ) ; 
            
            
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
        FILEDATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50000, this );
        LINE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10000, this );
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        SYSREADY = new Crestron.Logos.SplusObjects.DigitalInput( SYSREADY__DigitalInput__, this );
        m_DigitalInputList.Add( SYSREADY__DigitalInput__, SYSREADY );
        
        REINIT = new Crestron.Logos.SplusObjects.DigitalInput( REINIT__DigitalInput__, this );
        m_DigitalInputList.Add( REINIT__DigitalInput__, REINIT );
        
        PROCESSCOMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( PROCESSCOMPLETE__DigitalOutput__, this );
        m_DigitalOutputList.Add( PROCESSCOMPLETE__DigitalOutput__, PROCESSCOMPLETE );
        
        DUALVIDEOENABLE = new Crestron.Logos.SplusObjects.DigitalOutput( DUALVIDEOENABLE__DigitalOutput__, this );
        m_DigitalOutputList.Add( DUALVIDEOENABLE__DigitalOutput__, DUALVIDEOENABLE );
        
        DISPLAYHASSCREEN = new InOutArray<DigitalOutput>( 4, this );
        for( uint i = 0; i < 4; i++ )
        {
            DISPLAYHASSCREEN[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAYHASSCREEN__DigitalOutput__ + i, this );
            m_DigitalOutputList.Add( DISPLAYHASSCREEN__DigitalOutput__ + i, DISPLAYHASSCREEN[i+1] );
        }
        
        DISPLAYMODEL = new InOutArray<AnalogOutput>( 4, this );
        for( uint i = 0; i < 4; i++ )
        {
            DISPLAYMODEL[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAYMODEL__AnalogSerialOutput__ + i, this );
            m_AnalogOutputList.Add( DISPLAYMODEL__AnalogSerialOutput__ + i, DISPLAYMODEL[i+1] );
        }
        
        DISPLAYNAME = new InOutArray<StringOutput>( 4, this );
        for( uint i = 0; i < 4; i++ )
        {
            DISPLAYNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( DISPLAYNAME__AnalogSerialOutput__ + i, this );
            m_StringOutputList.Add( DISPLAYNAME__AnalogSerialOutput__ + i, DISPLAYNAME[i+1] );
        }
        
        DISPLAYIP = new InOutArray<StringOutput>( 4, this );
        for( uint i = 0; i < 4; i++ )
        {
            DISPLAYIP[i+1] = new Crestron.Logos.SplusObjects.StringOutput( DISPLAYIP__AnalogSerialOutput__ + i, this );
            m_StringOutputList.Add( DISPLAYIP__AnalogSerialOutput__ + i, DISPLAYIP[i+1] );
        }
        
        
        REINIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( REINIT_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_TU_DISPLAY_CONFIG_DRIVER1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint SYSREADY__DigitalInput__ = 0;
    const uint REINIT__DigitalInput__ = 1;
    const uint PROCESSCOMPLETE__DigitalOutput__ = 0;
    const uint DUALVIDEOENABLE__DigitalOutput__ = 1;
    const uint DISPLAYHASSCREEN__DigitalOutput__ = 2;
    const uint DISPLAYMODEL__AnalogSerialOutput__ = 0;
    const uint DISPLAYNAME__AnalogSerialOutput__ = 4;
    const uint DISPLAYIP__AnalogSerialOutput__ = 8;
    
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
