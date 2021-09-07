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

namespace CrestronModule_FUSION_SSI_SYSTEM_INFORMATION_V1_2
{
    public class CrestronModuleClass_FUSION_SSI_SYSTEM_INFORMATION_V1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PROCESS;
        Crestron.Logos.SplusObjects.DigitalInput REBOOT_PROCESSOR;
        Crestron.Logos.SplusObjects.BufferInput CONSOLE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput DHCP_ON;
        Crestron.Logos.SplusObjects.StringOutput CONSOLE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PROCESSOR_MODEL;
        Crestron.Logos.SplusObjects.StringOutput PROCESSOR_FIRMWARE;
        Crestron.Logos.SplusObjects.StringOutput FIRMWARE_DATE;
        Crestron.Logos.SplusObjects.StringOutput PROCESSOR_MAC;
        Crestron.Logos.SplusObjects.StringOutput PROCESSOR_IP;
        Crestron.Logos.SplusObjects.StringOutput PROCESSOR_HOSTNAME;
        Crestron.Logos.SplusObjects.StringOutput PROCESSOR_SERIAL;
        Crestron.Logos.SplusObjects.StringOutput PROCESSOR_UPTIME;
        Crestron.Logos.SplusObjects.StringOutput PROGRAM_UPTIME;
        Crestron.Logos.SplusObjects.StringOutput PROGRAMMER_NAME;
        Crestron.Logos.SplusObjects.StringOutput SYSTEM_NAME;
        Crestron.Logos.SplusObjects.StringOutput SOURCE_FILE;
        Crestron.Logos.SplusObjects.StringOutput COMPILE_DATE;
        ushort STEPNUM = 0;
        ushort HASRAN = 0;
        SYSTEM_INFO THIS;
        private void SENDCOMMAND (  SplusExecutionContext __context__, ushort I ) 
            { 
            
            __context__.SourceCodeLine = 86;
            STEPNUM = (ushort) ( I ) ; 
            __context__.SourceCodeLine = 88;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetSeries() == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 90;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)I);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 94;
                            CONSOLE_TX__DOLLAR__  .UpdateValue ( "ver\u000d"  ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 98;
                            CONSOLE_TX__DOLLAR__  .UpdateValue ( "est\u000d"  ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 102;
                            CONSOLE_TX__DOLLAR__  .UpdateValue ( "uptime\u000d"  ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 106;
                            CONSOLE_TX__DOLLAR__  .UpdateValue ( "proguptime\u000d"  ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 110;
                            CONSOLE_TX__DOLLAR__  .UpdateValue ( "progcomments\u000d"  ) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 114;
                            CONSOLE_TX__DOLLAR__  .UpdateValue ( "hostname\u000d"  ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 118;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetSeries() == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 120;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_2__ = ((int)I);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 124;
                                CONSOLE_TX__DOLLAR__  .UpdateValue ( "ver\u000d"  ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 128;
                                CONSOLE_TX__DOLLAR__  .UpdateValue ( "ipconfig\u000d"  ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 132;
                                CONSOLE_TX__DOLLAR__  .UpdateValue ( "uptime\u000d"  ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 136;
                                CONSOLE_TX__DOLLAR__  .UpdateValue ( "proguptime:" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + "\u000d"  ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 140;
                                CONSOLE_TX__DOLLAR__  .UpdateValue ( "progcomments:" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + "\u000d"  ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 144;
                                CONSOLE_TX__DOLLAR__  .UpdateValue ( "hostname\u000d"  ) ; 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                }
            
            
            }
            
        object PROCESS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 154;
                STEPNUM = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 155;
                SENDCOMMAND (  __context__ , (ushort)( STEPNUM )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object REBOOT_PROCESSOR_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 161;
            CONSOLE_TX__DOLLAR__  .UpdateValue ( "reboot\u000d"  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
private CrestronString SFPARSE (  SplusExecutionContext __context__, CrestronString LS_TEMP ) 
    { 
    ushort LI_LOC1 = 0;
    ushort LI_LOC2 = 0;
    ushort LI_LOC3 = 0;
    
    CrestronString LS_DHCP;
    CrestronString LS_WEBSERVER;
    CrestronString LS_SERIALNUMBER;
    LS_DHCP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    LS_WEBSERVER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    LS_SERIALNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    
    uint LII_SERIALNUMBER = 0;
    
    
    __context__.SourceCodeLine = 176;
    
        {
        int __SPLS_TMPVAR__SWTCH_3__ = ((int)STEPNUM);
        
            { 
            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                { 
                __context__.SourceCodeLine = 181;
                LI_LOC1 = (ushort) ( Functions.Find( "\u005B\u0076" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 182;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 184;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u0028" , LS_TEMP , (LI_LOC1 + 2) ) ) ; 
                    __context__.SourceCodeLine = 185;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.FIRMWARE != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 2) ) , (int)( ((LI_LOC2 - LI_LOC1) - 3) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 187;
                        THIS . FIRMWARE  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 2) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 3) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 189;
                    PROCESSOR_FIRMWARE  .UpdateValue ( THIS . FIRMWARE  ) ; 
                    } 
                
                __context__.SourceCodeLine = 193;
                LI_LOC1 = (ushort) ( Functions.Find( "\u0028" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 194;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 196;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u0029" , LS_TEMP , (LI_LOC1 + 1) ) ) ; 
                    __context__.SourceCodeLine = 197;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.FIRMWARE_DATE != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 1) ) , (int)( ((LI_LOC2 - LI_LOC1) - 1) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 199;
                        THIS . FIRMWARE_DATE  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 1) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 1) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 201;
                    FIRMWARE_DATE  .UpdateValue ( THIS . FIRMWARE_DATE  ) ; 
                    } 
                
                __context__.SourceCodeLine = 205;
                LI_LOC1 = (ushort) ( Functions.Find( "\u002C\u0020\u0023" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 206;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 208;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u005D" , LS_TEMP , (LI_LOC1 + 9) ) ) ; 
                    __context__.SourceCodeLine = 209;
                    LS_SERIALNUMBER  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 3) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 3) ) )  ) ; 
                    __context__.SourceCodeLine = 210;
                    LII_SERIALNUMBER = (uint) ( Functions.HextoL( LS_SERIALNUMBER ) ) ; 
                    __context__.SourceCodeLine = 211;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.SERIAL != Functions.LtoA( (int)( LII_SERIALNUMBER ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 213;
                        THIS . SERIAL  .UpdateValue ( Functions.LtoA (  (int) ( LII_SERIALNUMBER ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 215;
                    PROCESSOR_SERIAL  .UpdateValue ( THIS . SERIAL  ) ; 
                    } 
                
                __context__.SourceCodeLine = 219;
                LI_LOC1 = (ushort) ( Functions.Find( "Cntrl" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 220;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 222;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.MODEL != Functions.Left( LS_TEMP , (int)( (LI_LOC1 - 2) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 224;
                        THIS . MODEL  .UpdateValue ( Functions.Left ( LS_TEMP ,  (int) ( (LI_LOC1 - 2) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 226;
                    PROCESSOR_MODEL  .UpdateValue ( THIS . MODEL  ) ; 
                    __context__.SourceCodeLine = 227;
                    STEPNUM = (ushort) ( (STEPNUM + 1) ) ; 
                    __context__.SourceCodeLine = 228;
                    SENDCOMMAND (  __context__ , (ushort)( STEPNUM )) ; 
                    } 
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                { 
                __context__.SourceCodeLine = 233;
                __context__.SourceCodeLine = 285;
                LI_LOC1 = (ushort) ( Functions.Find( "DHCP" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 286;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 288;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 22) ) ) ; 
                    __context__.SourceCodeLine = 289;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.DHCP != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 22) ) , (int)( ((LI_LOC2 - LI_LOC1) - 23) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 291;
                        THIS . DHCP  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 22) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 23) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 293;
                    THIS . DHCP  .UpdateValue ( Functions.Lower ( THIS . DHCP )  ) ; 
                    __context__.SourceCodeLine = 294;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.DHCP == "on"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 296;
                        DHCP_ON  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 298;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.DHCP == "off"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 300;
                            DHCP_ON  .Value = (ushort) ( 0 ) ; 
                            } 
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 305;
                LI_LOC1 = (ushort) ( Functions.Find( "IP Address" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 306;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 308;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 22) ) ) ; 
                    __context__.SourceCodeLine = 310;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.IP != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 22) ) , (int)( ((LI_LOC2 - LI_LOC1) - 23) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 312;
                        THIS . IP  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 22) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 23) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 314;
                    PROCESSOR_IP  .UpdateValue ( THIS . IP  ) ; 
                    } 
                
                __context__.SourceCodeLine = 318;
                LI_LOC1 = (ushort) ( Functions.Find( "MAC Address" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 319;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 321;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 22) ) ) ; 
                    __context__.SourceCodeLine = 322;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.MAC != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 22) ) , (int)( ((LI_LOC2 - LI_LOC1) - 23) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 324;
                        THIS . MAC  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 22) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 23) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 326;
                    PROCESSOR_MAC  .UpdateValue ( THIS . MAC  ) ; 
                    __context__.SourceCodeLine = 327;
                    STEPNUM = (ushort) ( (STEPNUM + 1) ) ; 
                    __context__.SourceCodeLine = 328;
                    SENDCOMMAND (  __context__ , (ushort)( STEPNUM )) ; 
                    } 
                
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                { 
                __context__.SourceCodeLine = 337;
                LI_LOC1 = (ushort) ( Functions.Find( "running for" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 338;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 340;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 12) ) ) ; 
                    __context__.SourceCodeLine = 341;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.PROCESSOR_UPTIME != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 12) ) , (int)( ((LI_LOC2 - LI_LOC1) - 12) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 343;
                        THIS . PROCESSOR_UPTIME  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 12) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 12) ) )  ) ; 
                        __context__.SourceCodeLine = 344;
                        PROCESSOR_UPTIME  .UpdateValue ( THIS . PROCESSOR_UPTIME  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 346;
                    STEPNUM = (ushort) ( (STEPNUM + 1) ) ; 
                    __context__.SourceCodeLine = 347;
                    SENDCOMMAND (  __context__ , (ushort)( STEPNUM )) ; 
                    } 
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                { 
                __context__.SourceCodeLine = 353;
                LI_LOC1 = (ushort) ( Functions.Find( "running for" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 354;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 356;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 12) ) ) ; 
                    __context__.SourceCodeLine = 357;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.PROGRAM_UPTIME != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 12) ) , (int)( ((LI_LOC2 - LI_LOC1) - 12) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 359;
                        THIS . PROGRAM_UPTIME  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 12) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 12) ) )  ) ; 
                        __context__.SourceCodeLine = 360;
                        PROGRAM_UPTIME  .UpdateValue ( THIS . PROGRAM_UPTIME  ) ; 
                        __context__.SourceCodeLine = 362;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HASRAN == 1))  ) ) 
                            { 
                            } 
                        
                        else 
                            { 
                            } 
                        
                        } 
                    
                    __context__.SourceCodeLine = 372;
                    STEPNUM = (ushort) ( (STEPNUM + 1) ) ; 
                    __context__.SourceCodeLine = 373;
                    SENDCOMMAND (  __context__ , (ushort)( STEPNUM )) ; 
                    } 
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                { 
                __context__.SourceCodeLine = 379;
                LI_LOC1 = (ushort) ( Functions.Find( "Program File:" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 380;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 382;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 14) ) ) ; 
                    __context__.SourceCodeLine = 383;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.FILE != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 14) ) , (int)( ((LI_LOC2 - LI_LOC1) - 14) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 385;
                        THIS . FILE  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 14) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 14) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 387;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetSeries() == 2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 389;
                        SOURCE_FILE  .UpdateValue ( THIS . FILE  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 391;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.GetSeries() == 3))  ) ) 
                            { 
                            __context__.SourceCodeLine = 393;
                            SOURCE_FILE  .UpdateValue ( "Slot " + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + THIS . FILE  ) ; 
                            } 
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 398;
                LI_LOC1 = (ushort) ( Functions.Find( "Compiled On:" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 399;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 401;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 14) ) ) ; 
                    __context__.SourceCodeLine = 402;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.COMPILE_DATE != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 14) ) , (int)( ((LI_LOC2 - LI_LOC1) - 14) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 404;
                        THIS . COMPILE_DATE  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 14) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 14) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 406;
                    COMPILE_DATE  .UpdateValue ( THIS . COMPILE_DATE  ) ; 
                    } 
                
                __context__.SourceCodeLine = 410;
                LI_LOC1 = (ushort) ( Functions.Find( "System Name:" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 411;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 413;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 14) ) ) ; 
                    __context__.SourceCodeLine = 414;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.SYSTEM != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 14) ) , (int)( ((LI_LOC2 - LI_LOC1) - 14) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 416;
                        THIS . SYSTEM  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 14) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 14) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 418;
                    SYSTEM_NAME  .UpdateValue ( THIS . SYSTEM  ) ; 
                    } 
                
                __context__.SourceCodeLine = 422;
                LI_LOC1 = (ushort) ( Functions.Find( "Programmer:" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 423;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 425;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 14) ) ) ; 
                    __context__.SourceCodeLine = 426;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.PROGRAMMER != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 14) ) , (int)( ((LI_LOC2 - LI_LOC1) - 14) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 428;
                        THIS . PROGRAMMER  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 14) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 14) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 430;
                    PROGRAMMER_NAME  .UpdateValue ( THIS . PROGRAMMER  ) ; 
                    __context__.SourceCodeLine = 431;
                    STEPNUM = (ushort) ( (STEPNUM + 1) ) ; 
                    __context__.SourceCodeLine = 432;
                    SENDCOMMAND (  __context__ , (ushort)( STEPNUM )) ; 
                    } 
                
                } 
            
            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                { 
                __context__.SourceCodeLine = 437;
                __context__.SourceCodeLine = 455;
                LI_LOC1 = (ushort) ( Functions.Find( "Host Name:" , LS_TEMP ) ) ; 
                __context__.SourceCodeLine = 456;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LI_LOC1 != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 458;
                    LI_LOC2 = (ushort) ( Functions.Find( "\u000D\u000A" , LS_TEMP , (LI_LOC1 + 11) ) ) ; 
                    __context__.SourceCodeLine = 459;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (THIS.HOSTNAME != Functions.Mid( LS_TEMP , (int)( (LI_LOC1 + 11) ) , (int)( ((LI_LOC2 - LI_LOC1) - 12) ) )))  ) ) 
                        { 
                        __context__.SourceCodeLine = 461;
                        THIS . HOSTNAME  .UpdateValue ( Functions.Mid ( LS_TEMP ,  (int) ( (LI_LOC1 + 11) ) ,  (int) ( ((LI_LOC2 - LI_LOC1) - 12) ) )  ) ; 
                        __context__.SourceCodeLine = 462;
                        HASRAN = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 464;
                    PROCESSOR_HOSTNAME  .UpdateValue ( THIS . HOSTNAME  ) ; 
                    } 
                
                
                } 
            
            } 
            
        }
        
    
    
    return ""; // default return value (none specified in module)
    }
    
object CONSOLE_RX__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString LS_RESPONSE;
        LS_RESPONSE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1500, this );
        
        
        __context__.SourceCodeLine = 476;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CONSOLE_RX__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 478;
            LS_RESPONSE  .UpdateValue ( Functions.Remove ( "\u003E" , CONSOLE_RX__DOLLAR__ )  ) ; 
            __context__.SourceCodeLine = 481;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( LS_RESPONSE ) > 0 ))  ) ) 
                { 
                } 
            
            __context__.SourceCodeLine = 486;
            SFPARSE (  __context__ , LS_RESPONSE) ; 
            __context__.SourceCodeLine = 476;
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
        
        __context__.SourceCodeLine = 494;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 495;
        THIS . DHCP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 496;
        THIS . MODEL  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 497;
        THIS . FIRMWARE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 498;
        THIS . FIRMWARE_DATE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 499;
        THIS . MAC  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 500;
        THIS . IP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 501;
        THIS . HOSTNAME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 502;
        THIS . SERIAL  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 503;
        THIS . PROGRAM_UPTIME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 504;
        THIS . PROCESSOR_UPTIME  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 505;
        THIS . PROGRAMMER  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 506;
        THIS . SYSTEM  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 507;
        THIS . FILE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 508;
        THIS . COMPILE_DATE  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    THIS  = new SYSTEM_INFO( this, true );
    THIS .PopulateCustomAttributeList( false );
    
    PROCESS = new Crestron.Logos.SplusObjects.DigitalInput( PROCESS__DigitalInput__, this );
    m_DigitalInputList.Add( PROCESS__DigitalInput__, PROCESS );
    
    REBOOT_PROCESSOR = new Crestron.Logos.SplusObjects.DigitalInput( REBOOT_PROCESSOR__DigitalInput__, this );
    m_DigitalInputList.Add( REBOOT_PROCESSOR__DigitalInput__, REBOOT_PROCESSOR );
    
    DHCP_ON = new Crestron.Logos.SplusObjects.DigitalOutput( DHCP_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( DHCP_ON__DigitalOutput__, DHCP_ON );
    
    CONSOLE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONSOLE_TX__DOLLAR____AnalogSerialOutput__, CONSOLE_TX__DOLLAR__ );
    
    PROCESSOR_MODEL = new Crestron.Logos.SplusObjects.StringOutput( PROCESSOR_MODEL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROCESSOR_MODEL__AnalogSerialOutput__, PROCESSOR_MODEL );
    
    PROCESSOR_FIRMWARE = new Crestron.Logos.SplusObjects.StringOutput( PROCESSOR_FIRMWARE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROCESSOR_FIRMWARE__AnalogSerialOutput__, PROCESSOR_FIRMWARE );
    
    FIRMWARE_DATE = new Crestron.Logos.SplusObjects.StringOutput( FIRMWARE_DATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FIRMWARE_DATE__AnalogSerialOutput__, FIRMWARE_DATE );
    
    PROCESSOR_MAC = new Crestron.Logos.SplusObjects.StringOutput( PROCESSOR_MAC__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROCESSOR_MAC__AnalogSerialOutput__, PROCESSOR_MAC );
    
    PROCESSOR_IP = new Crestron.Logos.SplusObjects.StringOutput( PROCESSOR_IP__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROCESSOR_IP__AnalogSerialOutput__, PROCESSOR_IP );
    
    PROCESSOR_HOSTNAME = new Crestron.Logos.SplusObjects.StringOutput( PROCESSOR_HOSTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROCESSOR_HOSTNAME__AnalogSerialOutput__, PROCESSOR_HOSTNAME );
    
    PROCESSOR_SERIAL = new Crestron.Logos.SplusObjects.StringOutput( PROCESSOR_SERIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROCESSOR_SERIAL__AnalogSerialOutput__, PROCESSOR_SERIAL );
    
    PROCESSOR_UPTIME = new Crestron.Logos.SplusObjects.StringOutput( PROCESSOR_UPTIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROCESSOR_UPTIME__AnalogSerialOutput__, PROCESSOR_UPTIME );
    
    PROGRAM_UPTIME = new Crestron.Logos.SplusObjects.StringOutput( PROGRAM_UPTIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROGRAM_UPTIME__AnalogSerialOutput__, PROGRAM_UPTIME );
    
    PROGRAMMER_NAME = new Crestron.Logos.SplusObjects.StringOutput( PROGRAMMER_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PROGRAMMER_NAME__AnalogSerialOutput__, PROGRAMMER_NAME );
    
    SYSTEM_NAME = new Crestron.Logos.SplusObjects.StringOutput( SYSTEM_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SYSTEM_NAME__AnalogSerialOutput__, SYSTEM_NAME );
    
    SOURCE_FILE = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_FILE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SOURCE_FILE__AnalogSerialOutput__, SOURCE_FILE );
    
    COMPILE_DATE = new Crestron.Logos.SplusObjects.StringOutput( COMPILE_DATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( COMPILE_DATE__AnalogSerialOutput__, COMPILE_DATE );
    
    CONSOLE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( CONSOLE_RX__DOLLAR____AnalogSerialInput__, 1500, this );
    m_StringInputList.Add( CONSOLE_RX__DOLLAR____AnalogSerialInput__, CONSOLE_RX__DOLLAR__ );
    
    
    PROCESS.OnDigitalPush.Add( new InputChangeHandlerWrapper( PROCESS_OnPush_0, false ) );
    REBOOT_PROCESSOR.OnDigitalPush.Add( new InputChangeHandlerWrapper( REBOOT_PROCESSOR_OnPush_1, false ) );
    CONSOLE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CONSOLE_RX__DOLLAR___OnChange_2, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_FUSION_SSI_SYSTEM_INFORMATION_V1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PROCESS__DigitalInput__ = 0;
const uint REBOOT_PROCESSOR__DigitalInput__ = 1;
const uint CONSOLE_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint DHCP_ON__DigitalOutput__ = 0;
const uint CONSOLE_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint PROCESSOR_MODEL__AnalogSerialOutput__ = 1;
const uint PROCESSOR_FIRMWARE__AnalogSerialOutput__ = 2;
const uint FIRMWARE_DATE__AnalogSerialOutput__ = 3;
const uint PROCESSOR_MAC__AnalogSerialOutput__ = 4;
const uint PROCESSOR_IP__AnalogSerialOutput__ = 5;
const uint PROCESSOR_HOSTNAME__AnalogSerialOutput__ = 6;
const uint PROCESSOR_SERIAL__AnalogSerialOutput__ = 7;
const uint PROCESSOR_UPTIME__AnalogSerialOutput__ = 8;
const uint PROGRAM_UPTIME__AnalogSerialOutput__ = 9;
const uint PROGRAMMER_NAME__AnalogSerialOutput__ = 10;
const uint SYSTEM_NAME__AnalogSerialOutput__ = 11;
const uint SOURCE_FILE__AnalogSerialOutput__ = 12;
const uint COMPILE_DATE__AnalogSerialOutput__ = 13;

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

[SplusStructAttribute(-1, true, false)]
public class SYSTEM_INFO : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  DHCP;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  MODEL;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  FIRMWARE;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  FIRMWARE_DATE;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  MAC;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  IP;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  HOSTNAME;
    
    [SplusStructAttribute(7, false, false)]
    public CrestronString  SERIAL;
    
    [SplusStructAttribute(8, false, false)]
    public CrestronString  PROCESSOR_UPTIME;
    
    [SplusStructAttribute(9, false, false)]
    public CrestronString  PROGRAM_UPTIME;
    
    [SplusStructAttribute(10, false, false)]
    public CrestronString  PROGRAMMER;
    
    [SplusStructAttribute(11, false, false)]
    public CrestronString  SYSTEM;
    
    [SplusStructAttribute(12, false, false)]
    public CrestronString  FILE;
    
    [SplusStructAttribute(13, false, false)]
    public CrestronString  COMPILE_DATE;
    
    
    public SYSTEM_INFO( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        DHCP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        MODEL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        FIRMWARE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        FIRMWARE_DATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        MAC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        IP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        HOSTNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        SERIAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        PROCESSOR_UPTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        PROGRAM_UPTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        PROGRAMMER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        SYSTEM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        FILE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 140, Owner );
        COMPILE_DATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, Owner );
        
        
    }
    
}

}