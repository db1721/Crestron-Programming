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

namespace UserModule_SHARP_FLATPANEL_DRIVER
{
    public class UserModuleClass_SHARP_FLATPANEL_DRIVER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput RESPONSE_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput AUDIOMODE;
        Crestron.Logos.SplusObjects.DigitalInput SURROUNDMODE;
        Crestron.Logos.SplusObjects.DigitalInput CLOSEDCAPTION;
        Crestron.Logos.SplusObjects.DigitalInput CHANNELUP;
        Crestron.Logos.SplusObjects.DigitalInput CHANNELDOWN;
        Crestron.Logos.SplusObjects.DigitalInput AIR;
        Crestron.Logos.SplusObjects.DigitalInput CABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> KP;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> POWER;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> INPUT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> AVMODE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ASPECT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> VOLUMEMUTE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SLEEP;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> EFFECT3D;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> POLL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> IRKEYS;
        Crestron.Logos.SplusObjects.StringInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.DigitalOutput IWAITINGFORRESPONSE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_POWER;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_INPUT;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_AVMODE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_ASPECT;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_VOLUMEMUTE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_SLEEP;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_EFFECT3D;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_VOLUME;
        Crestron.Logos.SplusObjects.StringOutput NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        ushort ICOMMAND = 0;
        ushort IVALUE = 0;
        ushort IVALUEIN = 0;
        ushort ALOC = 0;
        ushort IPOWERQUEUE = 0;
        ushort IINPUTQUEUE = 0;
        ushort IAVMODEQUEUE = 0;
        ushort IASPECTQUEUE = 0;
        ushort IVOLUMEMUTEQUEUE = 0;
        ushort ISLEEPQUEUE = 0;
        ushort IEFFECT3DQUEUE = 0;
        ushort IAUDIOMODEQUEUE = 0;
        ushort ISURROUNDMODEQUEUE = 0;
        ushort ICLOSEDCAPTIONQUEUE = 0;
        ushort ICHANNELREQQUEUE = 0;
        ushort ICHANNELUPQUEUE = 0;
        ushort ICHANNELDOWNQUEUE = 0;
        ushort IPOLLQUEUE = 0;
        ushort IPOWERSENT = 0;
        ushort IINPUTSENT = 0;
        ushort IAVMODESENT = 0;
        ushort IASPECTSENT = 0;
        ushort IVOLUMEMUTESENT = 0;
        ushort ISLEEPSENT = 0;
        ushort IEFFECT3DSENT = 0;
        ushort IPOLLSENT = 0;
        ushort IIRKEYSSENT = 0;
        ushort IIRKEYSQUEUE = 0;
        CrestronString STODEVICETEMP;
        CrestronString SNUMBER;
        CrestronString SCHANNELF;
        CrestronString SCHANNELR;
        CrestronString SCHANNELTEMP;
        private CrestronString SENDPOWER (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 102;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 105;
                        STODEVICETEMP  .UpdateValue ( "POWR1   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 107;
                        STODEVICETEMP  .UpdateValue ( "POWR0   \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 109;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDINPUT (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 116;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 119;
                        STODEVICETEMP  .UpdateValue ( "IAVD5   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 121;
                        STODEVICETEMP  .UpdateValue ( "IAVD6   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 123;
                        STODEVICETEMP  .UpdateValue ( "IAVD8   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 125;
                        STODEVICETEMP  .UpdateValue ( "IAVD1   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 127;
                        STODEVICETEMP  .UpdateValue ( "IAVD2   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 129;
                        STODEVICETEMP  .UpdateValue ( "IAVD3   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 131;
                        STODEVICETEMP  .UpdateValue ( "IAVD4   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 133;
                        STODEVICETEMP  .UpdateValue ( "ITVD0   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 9) ) ) ) 
                        {
                        __context__.SourceCodeLine = 135;
                        STODEVICETEMP  .UpdateValue ( "IAVD7   \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 137;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDAVMODE (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 143;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 146;
                        STODEVICETEMP  .UpdateValue ( "AVMD1   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 148;
                        STODEVICETEMP  .UpdateValue ( "AVMD2   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 150;
                        STODEVICETEMP  .UpdateValue ( "AVMD3   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 152;
                        STODEVICETEMP  .UpdateValue ( "AVMD4   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 154;
                        STODEVICETEMP  .UpdateValue ( "AVMD5   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 156;
                        STODEVICETEMP  .UpdateValue ( "AVMD6   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 158;
                        STODEVICETEMP  .UpdateValue ( "AVMD7   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 160;
                        STODEVICETEMP  .UpdateValue ( "AVMD8   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 9) ) ) ) 
                        {
                        __context__.SourceCodeLine = 162;
                        STODEVICETEMP  .UpdateValue ( "AVMD14  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 10) ) ) ) 
                        {
                        __context__.SourceCodeLine = 164;
                        STODEVICETEMP  .UpdateValue ( "AVMD15  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 11) ) ) ) 
                        {
                        __context__.SourceCodeLine = 166;
                        STODEVICETEMP  .UpdateValue ( "AVMD16  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 12) ) ) ) 
                        {
                        __context__.SourceCodeLine = 168;
                        STODEVICETEMP  .UpdateValue ( "AVMD100 \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 170;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDASPECT (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 176;
            
                {
                int __SPLS_TMPVAR__SWTCH_4__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 179;
                        STODEVICETEMP  .UpdateValue ( "WIDE1   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 181;
                        STODEVICETEMP  .UpdateValue ( "WIDE2   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 183;
                        STODEVICETEMP  .UpdateValue ( "WIDE3   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 185;
                        STODEVICETEMP  .UpdateValue ( "WIDE4   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 187;
                        STODEVICETEMP  .UpdateValue ( "WIDE5   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 189;
                        STODEVICETEMP  .UpdateValue ( "WIDE6   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 191;
                        STODEVICETEMP  .UpdateValue ( "WIDE7   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 193;
                        STODEVICETEMP  .UpdateValue ( "WIDE8   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 9) ) ) ) 
                        {
                        __context__.SourceCodeLine = 195;
                        STODEVICETEMP  .UpdateValue ( "WIDE9   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 10) ) ) ) 
                        {
                        __context__.SourceCodeLine = 197;
                        STODEVICETEMP  .UpdateValue ( "WIDE10  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 11) ) ) ) 
                        {
                        __context__.SourceCodeLine = 199;
                        STODEVICETEMP  .UpdateValue ( "WIDE11  \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 201;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDVOLUMEMUTE (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 207;
            
                {
                int __SPLS_TMPVAR__SWTCH_5__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 210;
                        STODEVICETEMP  .UpdateValue ( "MUTE1   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 212;
                        STODEVICETEMP  .UpdateValue ( "MUTE2   \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 214;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDSLEEP (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 220;
            
                {
                int __SPLS_TMPVAR__SWTCH_6__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 223;
                        STODEVICETEMP  .UpdateValue ( "OFTM0   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 225;
                        STODEVICETEMP  .UpdateValue ( "OFTM1   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 227;
                        STODEVICETEMP  .UpdateValue ( "OFTM2   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 229;
                        STODEVICETEMP  .UpdateValue ( "OFTM3   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 231;
                        STODEVICETEMP  .UpdateValue ( "OFTM4   \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 233;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDEFFECT3D (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 239;
            
                {
                int __SPLS_TMPVAR__SWTCH_7__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 242;
                        STODEVICETEMP  .UpdateValue ( "TDCH0   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 244;
                        STODEVICETEMP  .UpdateValue ( "TDCH1   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 246;
                        STODEVICETEMP  .UpdateValue ( "TDCH2   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 248;
                        STODEVICETEMP  .UpdateValue ( "TDCH3   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 250;
                        STODEVICETEMP  .UpdateValue ( "TDCH4   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 252;
                        STODEVICETEMP  .UpdateValue ( "TDCH5   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 254;
                        STODEVICETEMP  .UpdateValue ( "TDCH6   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 256;
                        STODEVICETEMP  .UpdateValue ( "TDCH7   \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 258;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDPOLL (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 264;
            
                {
                int __SPLS_TMPVAR__SWTCH_8__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 267;
                        STODEVICETEMP  .UpdateValue ( "POWR?   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 269;
                        STODEVICETEMP  .UpdateValue ( "IAVD?   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 271;
                        STODEVICETEMP  .UpdateValue ( "AVMD?   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 273;
                        STODEVICETEMP  .UpdateValue ( "WIDE?   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 275;
                        STODEVICETEMP  .UpdateValue ( "MUTE?   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 277;
                        STODEVICETEMP  .UpdateValue ( "OFTM?   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 279;
                        STODEVICETEMP  .UpdateValue ( "TDCH?   \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 281;
                        STODEVICETEMP  .UpdateValue ( "VOLM?   \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 283;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private CrestronString SENDIRKEYS (  SplusExecutionContext __context__, ushort IVALUE ) 
            { 
            
            __context__.SourceCodeLine = 289;
            
                {
                int __SPLS_TMPVAR__SWTCH_9__ = ((int)IVALUE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 292;
                        STODEVICETEMP  .UpdateValue ( "RCKY00  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 294;
                        STODEVICETEMP  .UpdateValue ( "RCKY01  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 296;
                        STODEVICETEMP  .UpdateValue ( "RCKY02  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 298;
                        STODEVICETEMP  .UpdateValue ( "RCKY03  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 300;
                        STODEVICETEMP  .UpdateValue ( "RCKY04  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 302;
                        STODEVICETEMP  .UpdateValue ( "RCKY05  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 304;
                        STODEVICETEMP  .UpdateValue ( "RCKY06  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 306;
                        STODEVICETEMP  .UpdateValue ( "RCKY07  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 9) ) ) ) 
                        {
                        __context__.SourceCodeLine = 308;
                        STODEVICETEMP  .UpdateValue ( "RCKY08  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 10) ) ) ) 
                        {
                        __context__.SourceCodeLine = 310;
                        STODEVICETEMP  .UpdateValue ( "RCKY09  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 11) ) ) ) 
                        {
                        __context__.SourceCodeLine = 312;
                        STODEVICETEMP  .UpdateValue ( "RCKY10  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 12) ) ) ) 
                        {
                        __context__.SourceCodeLine = 314;
                        STODEVICETEMP  .UpdateValue ( "RCKY11  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 13) ) ) ) 
                        {
                        __context__.SourceCodeLine = 316;
                        STODEVICETEMP  .UpdateValue ( "RCKY12  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 14) ) ) ) 
                        {
                        __context__.SourceCodeLine = 318;
                        STODEVICETEMP  .UpdateValue ( "RCKY13  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 15) ) ) ) 
                        {
                        __context__.SourceCodeLine = 320;
                        STODEVICETEMP  .UpdateValue ( "RCKY14  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 16) ) ) ) 
                        {
                        __context__.SourceCodeLine = 322;
                        STODEVICETEMP  .UpdateValue ( "RCKY15  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 17) ) ) ) 
                        {
                        __context__.SourceCodeLine = 324;
                        STODEVICETEMP  .UpdateValue ( "RCKY16  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 18) ) ) ) 
                        {
                        __context__.SourceCodeLine = 326;
                        STODEVICETEMP  .UpdateValue ( "RCKY17  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 19) ) ) ) 
                        {
                        __context__.SourceCodeLine = 328;
                        STODEVICETEMP  .UpdateValue ( "RCKY18  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 20) ) ) ) 
                        {
                        __context__.SourceCodeLine = 330;
                        STODEVICETEMP  .UpdateValue ( "RCKY19  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 21) ) ) ) 
                        {
                        __context__.SourceCodeLine = 332;
                        STODEVICETEMP  .UpdateValue ( "RCKY20  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 22) ) ) ) 
                        {
                        __context__.SourceCodeLine = 334;
                        STODEVICETEMP  .UpdateValue ( "RCKY21  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 23) ) ) ) 
                        {
                        __context__.SourceCodeLine = 336;
                        STODEVICETEMP  .UpdateValue ( "RCKY22  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 24) ) ) ) 
                        {
                        __context__.SourceCodeLine = 338;
                        STODEVICETEMP  .UpdateValue ( "RCKY23  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 25) ) ) ) 
                        {
                        __context__.SourceCodeLine = 340;
                        STODEVICETEMP  .UpdateValue ( "RCKY24  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 26) ) ) ) 
                        {
                        __context__.SourceCodeLine = 342;
                        STODEVICETEMP  .UpdateValue ( "RCKY27  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 27) ) ) ) 
                        {
                        __context__.SourceCodeLine = 344;
                        STODEVICETEMP  .UpdateValue ( "RCKY28  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 28) ) ) ) 
                        {
                        __context__.SourceCodeLine = 346;
                        STODEVICETEMP  .UpdateValue ( "RCKY29  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 29) ) ) ) 
                        {
                        __context__.SourceCodeLine = 348;
                        STODEVICETEMP  .UpdateValue ( "RCKY30  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 30) ) ) ) 
                        {
                        __context__.SourceCodeLine = 350;
                        STODEVICETEMP  .UpdateValue ( "RCKY34  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 31) ) ) ) 
                        {
                        __context__.SourceCodeLine = 352;
                        STODEVICETEMP  .UpdateValue ( "RCKY35  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 32) ) ) ) 
                        {
                        __context__.SourceCodeLine = 354;
                        STODEVICETEMP  .UpdateValue ( "RCKY36  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 33) ) ) ) 
                        {
                        __context__.SourceCodeLine = 356;
                        STODEVICETEMP  .UpdateValue ( "RCKY38  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 34) ) ) ) 
                        {
                        __context__.SourceCodeLine = 358;
                        STODEVICETEMP  .UpdateValue ( "RCKY39  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 35) ) ) ) 
                        {
                        __context__.SourceCodeLine = 360;
                        STODEVICETEMP  .UpdateValue ( "RCKY40  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 36) ) ) ) 
                        {
                        __context__.SourceCodeLine = 362;
                        STODEVICETEMP  .UpdateValue ( "RCKY41  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 37) ) ) ) 
                        {
                        __context__.SourceCodeLine = 364;
                        STODEVICETEMP  .UpdateValue ( "RCKY42  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 38) ) ) ) 
                        {
                        __context__.SourceCodeLine = 366;
                        STODEVICETEMP  .UpdateValue ( "RCKY43  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 39) ) ) ) 
                        {
                        __context__.SourceCodeLine = 368;
                        STODEVICETEMP  .UpdateValue ( "RCKY44  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 40) ) ) ) 
                        {
                        __context__.SourceCodeLine = 370;
                        STODEVICETEMP  .UpdateValue ( "RCKY45  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 41) ) ) ) 
                        {
                        __context__.SourceCodeLine = 372;
                        STODEVICETEMP  .UpdateValue ( "RCKY46  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 42) ) ) ) 
                        {
                        __context__.SourceCodeLine = 374;
                        STODEVICETEMP  .UpdateValue ( "RCKY47  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 43) ) ) ) 
                        {
                        __context__.SourceCodeLine = 376;
                        STODEVICETEMP  .UpdateValue ( "RCKY48  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 44) ) ) ) 
                        {
                        __context__.SourceCodeLine = 378;
                        STODEVICETEMP  .UpdateValue ( "RCKY49  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 45) ) ) ) 
                        {
                        __context__.SourceCodeLine = 380;
                        STODEVICETEMP  .UpdateValue ( "RCKY50  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 46) ) ) ) 
                        {
                        __context__.SourceCodeLine = 382;
                        STODEVICETEMP  .UpdateValue ( "RCKY51  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 47) ) ) ) 
                        {
                        __context__.SourceCodeLine = 384;
                        STODEVICETEMP  .UpdateValue ( "RCKY52  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 48) ) ) ) 
                        {
                        __context__.SourceCodeLine = 386;
                        STODEVICETEMP  .UpdateValue ( "RCKY53  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 49) ) ) ) 
                        {
                        __context__.SourceCodeLine = 388;
                        STODEVICETEMP  .UpdateValue ( "RCKY54  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 50) ) ) ) 
                        {
                        __context__.SourceCodeLine = 390;
                        STODEVICETEMP  .UpdateValue ( "RCKY55  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 51) ) ) ) 
                        {
                        __context__.SourceCodeLine = 392;
                        STODEVICETEMP  .UpdateValue ( "RCKY56  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 52) ) ) ) 
                        {
                        __context__.SourceCodeLine = 394;
                        STODEVICETEMP  .UpdateValue ( "RCKY57  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 53) ) ) ) 
                        {
                        __context__.SourceCodeLine = 396;
                        STODEVICETEMP  .UpdateValue ( "RCKY58  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 54) ) ) ) 
                        {
                        __context__.SourceCodeLine = 398;
                        STODEVICETEMP  .UpdateValue ( "RCKY59  \u000D"  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 55) ) ) ) 
                        {
                        __context__.SourceCodeLine = 400;
                        STODEVICETEMP  .UpdateValue ( "RSPW1   \u000D"  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 402;
            return ( STODEVICETEMP ) ; 
            
            }
            
        private void SENDCOMMANDQUEUED (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 407;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IPOWERQUEUE != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (IINPUTQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IAVMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IASPECTQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IVOLUMEMUTEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ISLEEPQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IEFFECT3DQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IAUDIOMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ISURROUNDMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICLOSEDCAPTIONQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELREQQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELUPQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELDOWNQUEUE != 0) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 411;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOWERQUEUE != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 413;
                    TO_DEVICE  .UpdateValue ( SENDPOWER (  __context__ , (ushort)( IPOWERQUEUE ))  ) ; 
                    __context__.SourceCodeLine = 414;
                    ICOMMAND = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 415;
                    IPOWERSENT = (ushort) ( IPOWERQUEUE ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 417;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUTQUEUE != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 419;
                        TO_DEVICE  .UpdateValue ( SENDINPUT (  __context__ , (ushort)( IINPUTQUEUE ))  ) ; 
                        __context__.SourceCodeLine = 420;
                        ICOMMAND = (ushort) ( 2 ) ; 
                        __context__.SourceCodeLine = 421;
                        IINPUTSENT = (ushort) ( IINPUTQUEUE ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 423;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IAVMODEQUEUE != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 425;
                            TO_DEVICE  .UpdateValue ( SENDAVMODE (  __context__ , (ushort)( IAVMODEQUEUE ))  ) ; 
                            __context__.SourceCodeLine = 426;
                            ICOMMAND = (ushort) ( 3 ) ; 
                            __context__.SourceCodeLine = 427;
                            IAVMODESENT = (ushort) ( IAVMODEQUEUE ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 429;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IASPECTQUEUE != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 431;
                                TO_DEVICE  .UpdateValue ( SENDASPECT (  __context__ , (ushort)( IASPECTQUEUE ))  ) ; 
                                __context__.SourceCodeLine = 432;
                                ICOMMAND = (ushort) ( 4 ) ; 
                                __context__.SourceCodeLine = 433;
                                IASPECTSENT = (ushort) ( IASPECTQUEUE ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 435;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IVOLUMEMUTEQUEUE != 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 437;
                                    TO_DEVICE  .UpdateValue ( SENDVOLUMEMUTE (  __context__ , (ushort)( IVOLUMEMUTEQUEUE ))  ) ; 
                                    __context__.SourceCodeLine = 438;
                                    ICOMMAND = (ushort) ( 5 ) ; 
                                    __context__.SourceCodeLine = 439;
                                    IVOLUMEMUTESENT = (ushort) ( IVOLUMEMUTEQUEUE ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 441;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISLEEPQUEUE != 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 443;
                                        TO_DEVICE  .UpdateValue ( SENDSLEEP (  __context__ , (ushort)( ISLEEPQUEUE ))  ) ; 
                                        __context__.SourceCodeLine = 444;
                                        ICOMMAND = (ushort) ( 6 ) ; 
                                        __context__.SourceCodeLine = 445;
                                        ISLEEPSENT = (ushort) ( ISLEEPQUEUE ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 447;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IEFFECT3DQUEUE != 0))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 449;
                                            TO_DEVICE  .UpdateValue ( SENDEFFECT3D (  __context__ , (ushort)( IEFFECT3DQUEUE ))  ) ; 
                                            __context__.SourceCodeLine = 450;
                                            ICOMMAND = (ushort) ( 7 ) ; 
                                            __context__.SourceCodeLine = 451;
                                            IEFFECT3DSENT = (ushort) ( IEFFECT3DQUEUE ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 453;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IAUDIOMODEQUEUE != 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 455;
                                                TO_DEVICE  .UpdateValue ( "ACHA1   \u000D"  ) ; 
                                                __context__.SourceCodeLine = 456;
                                                ICOMMAND = (ushort) ( 9 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 458;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISURROUNDMODEQUEUE != 0))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 460;
                                                    TO_DEVICE  .UpdateValue ( "ACSU0   \u000D"  ) ; 
                                                    __context__.SourceCodeLine = 461;
                                                    ICOMMAND = (ushort) ( 10 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 463;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICLOSEDCAPTIONQUEUE != 0))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 465;
                                                        TO_DEVICE  .UpdateValue ( "CLCP1   \u000D"  ) ; 
                                                        __context__.SourceCodeLine = 466;
                                                        ICOMMAND = (ushort) ( 11 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 468;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELREQQUEUE != 0))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 470;
                                                            TO_DEVICE  .UpdateValue ( SCHANNELTEMP  ) ; 
                                                            __context__.SourceCodeLine = 471;
                                                            ICOMMAND = (ushort) ( 12 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 473;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELUPQUEUE != 0))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 475;
                                                                TO_DEVICE  .UpdateValue ( "CHUP1   \u000D"  ) ; 
                                                                __context__.SourceCodeLine = 476;
                                                                ICOMMAND = (ushort) ( 13 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 478;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELDOWNQUEUE != 0))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 480;
                                                                    TO_DEVICE  .UpdateValue ( "CHDW1   \u000D"  ) ; 
                                                                    __context__.SourceCodeLine = 481;
                                                                    ICOMMAND = (ushort) ( 14 ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 483;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IIRKEYSQUEUE != 0))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 485;
                                                                        TO_DEVICE  .UpdateValue ( SENDIRKEYS (  __context__ , (ushort)( IIRKEYSQUEUE ))  ) ; 
                                                                        __context__.SourceCodeLine = 486;
                                                                        ICOMMAND = (ushort) ( 15 ) ; 
                                                                        __context__.SourceCodeLine = 487;
                                                                        IIRKEYSSENT = (ushort) ( IIRKEYSQUEUE ) ; 
                                                                        } 
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                } 
            
            
            }
            
        object POWER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 499;
                IPOWERQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 500;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 502;
                    TO_DEVICE  .UpdateValue ( SENDPOWER (  __context__ , (ushort)( IPOWERQUEUE ))  ) ; 
                    __context__.SourceCodeLine = 503;
                    ICOMMAND = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 504;
                    IPOWERSENT = (ushort) ( IPOWERQUEUE ) ; 
                    __context__.SourceCodeLine = 505;
                    IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object INPUT_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 511;
            IINPUTQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 512;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 514;
                TO_DEVICE  .UpdateValue ( SENDINPUT (  __context__ , (ushort)( IINPUTQUEUE ))  ) ; 
                __context__.SourceCodeLine = 515;
                ICOMMAND = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 516;
                IINPUTSENT = (ushort) ( IINPUTQUEUE ) ; 
                __context__.SourceCodeLine = 517;
                IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object AVMODE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 523;
        IAVMODEQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 524;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 526;
            TO_DEVICE  .UpdateValue ( SENDAVMODE (  __context__ , (ushort)( IAVMODEQUEUE ))  ) ; 
            __context__.SourceCodeLine = 527;
            ICOMMAND = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 528;
            IAVMODESENT = (ushort) ( IAVMODEQUEUE ) ; 
            __context__.SourceCodeLine = 529;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ASPECT_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 535;
        IASPECTQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 536;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 538;
            TO_DEVICE  .UpdateValue ( SENDASPECT (  __context__ , (ushort)( IASPECTQUEUE ))  ) ; 
            __context__.SourceCodeLine = 539;
            ICOMMAND = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 540;
            IASPECTSENT = (ushort) ( IASPECTQUEUE ) ; 
            __context__.SourceCodeLine = 541;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEMUTE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 547;
        IVOLUMEMUTEQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 548;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 550;
            TO_DEVICE  .UpdateValue ( SENDVOLUMEMUTE (  __context__ , (ushort)( IVOLUMEMUTEQUEUE ))  ) ; 
            __context__.SourceCodeLine = 551;
            ICOMMAND = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 552;
            IVOLUMEMUTESENT = (ushort) ( IVOLUMEMUTEQUEUE ) ; 
            __context__.SourceCodeLine = 553;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLEEP_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 559;
        ISLEEPQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 560;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 562;
            TO_DEVICE  .UpdateValue ( SENDSLEEP (  __context__ , (ushort)( ISLEEPQUEUE ))  ) ; 
            __context__.SourceCodeLine = 563;
            ICOMMAND = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 564;
            ISLEEPSENT = (ushort) ( ISLEEPQUEUE ) ; 
            __context__.SourceCodeLine = 565;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EFFECT3D_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 571;
        IEFFECT3DQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 572;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 574;
            TO_DEVICE  .UpdateValue ( SENDEFFECT3D (  __context__ , (ushort)( IEFFECT3DQUEUE ))  ) ; 
            __context__.SourceCodeLine = 575;
            ICOMMAND = (ushort) ( 7 ) ; 
            __context__.SourceCodeLine = 576;
            IEFFECT3DSENT = (ushort) ( IEFFECT3DQUEUE ) ; 
            __context__.SourceCodeLine = 577;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POLL_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 583;
        IPOLLQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 584;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 586;
            TO_DEVICE  .UpdateValue ( SENDPOLL (  __context__ , (ushort)( IPOLLQUEUE ))  ) ; 
            __context__.SourceCodeLine = 587;
            ICOMMAND = (ushort) ( 30 ) ; 
            __context__.SourceCodeLine = 588;
            IPOLLSENT = (ushort) ( IPOLLQUEUE ) ; 
            __context__.SourceCodeLine = 589;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUDIOMODE_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 595;
        IAUDIOMODEQUEUE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 596;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 598;
            TO_DEVICE  .UpdateValue ( "ACHA1   \u000D"  ) ; 
            __context__.SourceCodeLine = 599;
            ICOMMAND = (ushort) ( 9 ) ; 
            __context__.SourceCodeLine = 600;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SURROUNDMODE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 607;
        ISURROUNDMODEQUEUE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 608;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 610;
            TO_DEVICE  .UpdateValue ( "ACSU0   \u000D"  ) ; 
            __context__.SourceCodeLine = 611;
            ICOMMAND = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 612;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLOSEDCAPTION_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 618;
        ICLOSEDCAPTIONQUEUE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 619;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 621;
            TO_DEVICE  .UpdateValue ( "CLCP1   \u000D"  ) ; 
            __context__.SourceCodeLine = 622;
            ICOMMAND = (ushort) ( 11 ) ; 
            __context__.SourceCodeLine = 623;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNELUP_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 629;
        ICHANNELUPQUEUE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 630;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 632;
            TO_DEVICE  .UpdateValue ( "CHUP1   \u000D"  ) ; 
            __context__.SourceCodeLine = 633;
            ICOMMAND = (ushort) ( 13 ) ; 
            __context__.SourceCodeLine = 634;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNELDOWN_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 640;
        ICHANNELDOWNQUEUE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 641;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 643;
            TO_DEVICE  .UpdateValue ( "CHDW1   \u000D"  ) ; 
            __context__.SourceCodeLine = 644;
            ICOMMAND = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 645;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 651;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FROM_DEVICE == "OK\u000D"))  ) ) 
            { 
            __context__.SourceCodeLine = 653;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 655;
                CURRENT_POWER  .Value = (ushort) ( IPOWERSENT ) ; 
                __context__.SourceCodeLine = 656;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_POWER  .Value == IPOWERQUEUE))  ) ) 
                    {
                    __context__.SourceCodeLine = 657;
                    IPOWERQUEUE = (ushort) ( 0 ) ; 
                    }
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 659;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 661;
                    CURRENT_INPUT  .Value = (ushort) ( IINPUTSENT ) ; 
                    __context__.SourceCodeLine = 662;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_INPUT  .Value == IINPUTQUEUE))  ) ) 
                        {
                        __context__.SourceCodeLine = 663;
                        IINPUTQUEUE = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 665;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 667;
                        CURRENT_AVMODE  .Value = (ushort) ( IAVMODESENT ) ; 
                        __context__.SourceCodeLine = 668;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_AVMODE  .Value == IAVMODEQUEUE))  ) ) 
                            {
                            __context__.SourceCodeLine = 669;
                            IAVMODEQUEUE = (ushort) ( 0 ) ; 
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 671;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 673;
                            CURRENT_ASPECT  .Value = (ushort) ( IASPECTSENT ) ; 
                            __context__.SourceCodeLine = 674;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_ASPECT  .Value == IASPECTQUEUE))  ) ) 
                                {
                                __context__.SourceCodeLine = 675;
                                IASPECTQUEUE = (ushort) ( 0 ) ; 
                                }
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 677;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 5))  ) ) 
                                { 
                                __context__.SourceCodeLine = 679;
                                CURRENT_VOLUMEMUTE  .Value = (ushort) ( IVOLUMEMUTESENT ) ; 
                                __context__.SourceCodeLine = 680;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_VOLUMEMUTE  .Value == IVOLUMEMUTEQUEUE))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 681;
                                    IVOLUMEMUTEQUEUE = (ushort) ( 0 ) ; 
                                    }
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 683;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 6))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 685;
                                    CURRENT_SLEEP  .Value = (ushort) ( ISLEEPSENT ) ; 
                                    __context__.SourceCodeLine = 686;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_SLEEP  .Value == ISLEEPQUEUE))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 687;
                                        ISLEEPQUEUE = (ushort) ( 0 ) ; 
                                        }
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 689;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 7))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 691;
                                        CURRENT_EFFECT3D  .Value = (ushort) ( IEFFECT3DSENT ) ; 
                                        __context__.SourceCodeLine = 692;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CURRENT_EFFECT3D  .Value == IEFFECT3DQUEUE))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 693;
                                            IEFFECT3DQUEUE = (ushort) ( 0 ) ; 
                                            }
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 695;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 9))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 696;
                                            IAUDIOMODEQUEUE = (ushort) ( 0 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 697;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 10))  ) ) 
                                                {
                                                __context__.SourceCodeLine = 698;
                                                ISURROUNDMODEQUEUE = (ushort) ( 0 ) ; 
                                                }
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 699;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 11))  ) ) 
                                                    {
                                                    __context__.SourceCodeLine = 700;
                                                    ICLOSEDCAPTIONQUEUE = (ushort) ( 0 ) ; 
                                                    }
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 701;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 12))  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 702;
                                                        ICHANNELREQQUEUE = (ushort) ( 0 ) ; 
                                                        }
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 703;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 13))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 704;
                                                            ICHANNELUPQUEUE = (ushort) ( 0 ) ; 
                                                            }
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 705;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 14))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 706;
                                                                ICHANNELDOWNQUEUE = (ushort) ( 0 ) ; 
                                                                }
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 707;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 15))  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 708;
                                                                    IIRKEYSQUEUE = (ushort) ( 0 ) ; 
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 710;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (FROM_DEVICE == "ERR\u000D") ) || Functions.TestForTrue ( Functions.BoolToInt (FROM_DEVICE == "\u00FF\u00FF\u00FF") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 712;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 713;
                    IPOWERQUEUE = (ushort) ( 0 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 714;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 2))  ) ) 
                        {
                        __context__.SourceCodeLine = 715;
                        IINPUTQUEUE = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 716;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 717;
                            IAVMODEQUEUE = (ushort) ( 0 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 718;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 4))  ) ) 
                                {
                                __context__.SourceCodeLine = 719;
                                IASPECTQUEUE = (ushort) ( 0 ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 720;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 5))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 721;
                                    IVOLUMEMUTEQUEUE = (ushort) ( 0 ) ; 
                                    }
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 722;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 6))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 723;
                                        ISLEEPQUEUE = (ushort) ( 0 ) ; 
                                        }
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 724;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 7))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 725;
                                            IEFFECT3DQUEUE = (ushort) ( 0 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 726;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 9))  ) ) 
                                                {
                                                __context__.SourceCodeLine = 727;
                                                IAUDIOMODEQUEUE = (ushort) ( 0 ) ; 
                                                }
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 728;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 10))  ) ) 
                                                    {
                                                    __context__.SourceCodeLine = 729;
                                                    ISURROUNDMODEQUEUE = (ushort) ( 0 ) ; 
                                                    }
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 730;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 11))  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 731;
                                                        ICLOSEDCAPTIONQUEUE = (ushort) ( 0 ) ; 
                                                        }
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 732;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 12))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 733;
                                                            ICHANNELREQQUEUE = (ushort) ( 0 ) ; 
                                                            }
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 734;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 13))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 735;
                                                                ICHANNELUPQUEUE = (ushort) ( 0 ) ; 
                                                                }
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 736;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 14))  ) ) 
                                                                    {
                                                                    __context__.SourceCodeLine = 737;
                                                                    ICHANNELDOWNQUEUE = (ushort) ( 0 ) ; 
                                                                    }
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 738;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 15))  ) ) 
                                                                        {
                                                                        __context__.SourceCodeLine = 739;
                                                                        IIRKEYSQUEUE = (ushort) ( 0 ) ; 
                                                                        }
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 740;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICOMMAND == 30))  ) ) 
                                                                            {
                                                                            __context__.SourceCodeLine = 741;
                                                                            IPOLLQUEUE = (ushort) ( 0 ) ; 
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 742;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 2))  ) ) 
                    {
                    __context__.SourceCodeLine = 743;
                    CURRENT_INPUT  .Value = (ushort) ( 9 ) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 747;
                IVALUEIN = (ushort) ( Functions.Atoi( FROM_DEVICE ) ) ; 
                __context__.SourceCodeLine = 748;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 750;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_10__ = ((int)IVALUEIN);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 753;
                                CURRENT_POWER  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 0) ) ) ) 
                                {
                                __context__.SourceCodeLine = 755;
                                CURRENT_POWER  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 758;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 760;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_11__ = ((int)IVALUEIN);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 763;
                                CURRENT_INPUT  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 2) ) ) ) 
                                {
                                __context__.SourceCodeLine = 765;
                                CURRENT_INPUT  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 3) ) ) ) 
                                {
                                __context__.SourceCodeLine = 767;
                                CURRENT_INPUT  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 4) ) ) ) 
                                {
                                __context__.SourceCodeLine = 769;
                                CURRENT_INPUT  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 5) ) ) ) 
                                {
                                __context__.SourceCodeLine = 771;
                                CURRENT_INPUT  .Value = (ushort) ( 5 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 6) ) ) ) 
                                {
                                __context__.SourceCodeLine = 773;
                                CURRENT_INPUT  .Value = (ushort) ( 6 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 7) ) ) ) 
                                {
                                __context__.SourceCodeLine = 775;
                                CURRENT_INPUT  .Value = (ushort) ( 7 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_11__ == ( 8) ) ) ) 
                                {
                                __context__.SourceCodeLine = 777;
                                CURRENT_INPUT  .Value = (ushort) ( 8 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 780;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 782;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_12__ = ((int)IVALUEIN);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 785;
                                CURRENT_AVMODE  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 2) ) ) ) 
                                {
                                __context__.SourceCodeLine = 787;
                                CURRENT_AVMODE  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 3) ) ) ) 
                                {
                                __context__.SourceCodeLine = 789;
                                CURRENT_AVMODE  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 4) ) ) ) 
                                {
                                __context__.SourceCodeLine = 791;
                                CURRENT_AVMODE  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 5) ) ) ) 
                                {
                                __context__.SourceCodeLine = 793;
                                CURRENT_AVMODE  .Value = (ushort) ( 5 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 6) ) ) ) 
                                {
                                __context__.SourceCodeLine = 795;
                                CURRENT_AVMODE  .Value = (ushort) ( 6 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 7) ) ) ) 
                                {
                                __context__.SourceCodeLine = 797;
                                CURRENT_AVMODE  .Value = (ushort) ( 7 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 8) ) ) ) 
                                {
                                __context__.SourceCodeLine = 799;
                                CURRENT_AVMODE  .Value = (ushort) ( 8 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 14) ) ) ) 
                                {
                                __context__.SourceCodeLine = 801;
                                CURRENT_AVMODE  .Value = (ushort) ( 9 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 15) ) ) ) 
                                {
                                __context__.SourceCodeLine = 803;
                                CURRENT_AVMODE  .Value = (ushort) ( 10 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 16) ) ) ) 
                                {
                                __context__.SourceCodeLine = 805;
                                CURRENT_AVMODE  .Value = (ushort) ( 11 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_12__ == ( 100) ) ) ) 
                                {
                                __context__.SourceCodeLine = 807;
                                CURRENT_AVMODE  .Value = (ushort) ( 12 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 810;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 4))  ) ) 
                    { 
                    __context__.SourceCodeLine = 812;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_13__ = ((int)IVALUEIN);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 815;
                                CURRENT_ASPECT  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 2) ) ) ) 
                                {
                                __context__.SourceCodeLine = 817;
                                CURRENT_ASPECT  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 3) ) ) ) 
                                {
                                __context__.SourceCodeLine = 819;
                                CURRENT_ASPECT  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 4) ) ) ) 
                                {
                                __context__.SourceCodeLine = 821;
                                CURRENT_ASPECT  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 5) ) ) ) 
                                {
                                __context__.SourceCodeLine = 823;
                                CURRENT_ASPECT  .Value = (ushort) ( 5 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 6) ) ) ) 
                                {
                                __context__.SourceCodeLine = 825;
                                CURRENT_ASPECT  .Value = (ushort) ( 6 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 7) ) ) ) 
                                {
                                __context__.SourceCodeLine = 827;
                                CURRENT_ASPECT  .Value = (ushort) ( 7 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 8) ) ) ) 
                                {
                                __context__.SourceCodeLine = 829;
                                CURRENT_ASPECT  .Value = (ushort) ( 8 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_13__ == ( 9) ) ) ) 
                                {
                                __context__.SourceCodeLine = 831;
                                CURRENT_ASPECT  .Value = (ushort) ( 9 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 834;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 836;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_14__ = ((int)IVALUEIN);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_14__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 839;
                                CURRENT_VOLUMEMUTE  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_14__ == ( 2) ) ) ) 
                                {
                                __context__.SourceCodeLine = 841;
                                CURRENT_VOLUMEMUTE  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 844;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 6))  ) ) 
                    { 
                    __context__.SourceCodeLine = 846;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_15__ = ((int)IVALUEIN);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( 0) ) ) ) 
                                {
                                __context__.SourceCodeLine = 849;
                                CURRENT_SLEEP  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 851;
                                CURRENT_SLEEP  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( 2) ) ) ) 
                                {
                                __context__.SourceCodeLine = 853;
                                CURRENT_SLEEP  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( 3) ) ) ) 
                                {
                                __context__.SourceCodeLine = 855;
                                CURRENT_SLEEP  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_15__ == ( 4) ) ) ) 
                                {
                                __context__.SourceCodeLine = 857;
                                CURRENT_SLEEP  .Value = (ushort) ( 5 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 860;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 862;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_16__ = ((int)IVALUEIN);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 865;
                                CURRENT_EFFECT3D  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( 2) ) ) ) 
                                {
                                __context__.SourceCodeLine = 867;
                                CURRENT_EFFECT3D  .Value = (ushort) ( 2 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( 3) ) ) ) 
                                {
                                __context__.SourceCodeLine = 869;
                                CURRENT_EFFECT3D  .Value = (ushort) ( 3 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( 4) ) ) ) 
                                {
                                __context__.SourceCodeLine = 871;
                                CURRENT_EFFECT3D  .Value = (ushort) ( 4 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( 5) ) ) ) 
                                {
                                __context__.SourceCodeLine = 873;
                                CURRENT_EFFECT3D  .Value = (ushort) ( 5 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( 6) ) ) ) 
                                {
                                __context__.SourceCodeLine = 875;
                                CURRENT_EFFECT3D  .Value = (ushort) ( 6 ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_16__ == ( 7) ) ) ) 
                                {
                                __context__.SourceCodeLine = 877;
                                CURRENT_EFFECT3D  .Value = (ushort) ( 7 ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 880;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOLLSENT == 8))  ) ) 
                    { 
                    __context__.SourceCodeLine = 882;
                    CURRENT_VOLUME  .Value = (ushort) ( IVALUEIN ) ; 
                    } 
                
                } 
            
            }
        
        __context__.SourceCodeLine = 885;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IPOWERQUEUE != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (IINPUTQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IAVMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IASPECTQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IVOLUMEMUTEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ISLEEPQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IEFFECT3DQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IAUDIOMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ISURROUNDMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICLOSEDCAPTIONQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELREQQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELUPQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELDOWNQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IIRKEYSQUEUE != 0) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 889;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOWERQUEUE != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 891;
                TO_DEVICE  .UpdateValue ( SENDPOWER (  __context__ , (ushort)( IPOWERQUEUE ))  ) ; 
                __context__.SourceCodeLine = 892;
                ICOMMAND = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 893;
                IPOWERSENT = (ushort) ( IPOWERQUEUE ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 895;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUTQUEUE != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 897;
                    TO_DEVICE  .UpdateValue ( SENDINPUT (  __context__ , (ushort)( IINPUTQUEUE ))  ) ; 
                    __context__.SourceCodeLine = 898;
                    ICOMMAND = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 899;
                    IINPUTSENT = (ushort) ( IINPUTQUEUE ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 901;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IAVMODEQUEUE != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 903;
                        TO_DEVICE  .UpdateValue ( SENDAVMODE (  __context__ , (ushort)( IAVMODEQUEUE ))  ) ; 
                        __context__.SourceCodeLine = 904;
                        ICOMMAND = (ushort) ( 3 ) ; 
                        __context__.SourceCodeLine = 905;
                        IAVMODESENT = (ushort) ( IAVMODEQUEUE ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 907;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IASPECTQUEUE != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 909;
                            TO_DEVICE  .UpdateValue ( SENDASPECT (  __context__ , (ushort)( IASPECTQUEUE ))  ) ; 
                            __context__.SourceCodeLine = 910;
                            ICOMMAND = (ushort) ( 4 ) ; 
                            __context__.SourceCodeLine = 911;
                            IASPECTSENT = (ushort) ( IASPECTQUEUE ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 913;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IVOLUMEMUTEQUEUE != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 915;
                                TO_DEVICE  .UpdateValue ( SENDVOLUMEMUTE (  __context__ , (ushort)( IVOLUMEMUTEQUEUE ))  ) ; 
                                __context__.SourceCodeLine = 916;
                                ICOMMAND = (ushort) ( 5 ) ; 
                                __context__.SourceCodeLine = 917;
                                IVOLUMEMUTESENT = (ushort) ( IVOLUMEMUTEQUEUE ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 919;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISLEEPQUEUE != 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 921;
                                    TO_DEVICE  .UpdateValue ( SENDSLEEP (  __context__ , (ushort)( ISLEEPQUEUE ))  ) ; 
                                    __context__.SourceCodeLine = 922;
                                    ICOMMAND = (ushort) ( 6 ) ; 
                                    __context__.SourceCodeLine = 923;
                                    ISLEEPSENT = (ushort) ( ISLEEPQUEUE ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 925;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IEFFECT3DQUEUE != 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 927;
                                        TO_DEVICE  .UpdateValue ( SENDEFFECT3D (  __context__ , (ushort)( IEFFECT3DQUEUE ))  ) ; 
                                        __context__.SourceCodeLine = 928;
                                        ICOMMAND = (ushort) ( 7 ) ; 
                                        __context__.SourceCodeLine = 929;
                                        IEFFECT3DSENT = (ushort) ( IEFFECT3DQUEUE ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 931;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IAUDIOMODEQUEUE != 0))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 933;
                                            TO_DEVICE  .UpdateValue ( "ACHA1   \u000D"  ) ; 
                                            __context__.SourceCodeLine = 934;
                                            ICOMMAND = (ushort) ( 9 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 936;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISURROUNDMODEQUEUE != 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 938;
                                                TO_DEVICE  .UpdateValue ( "ACSU0   \u000D"  ) ; 
                                                __context__.SourceCodeLine = 939;
                                                ICOMMAND = (ushort) ( 10 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 941;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICLOSEDCAPTIONQUEUE != 0))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 943;
                                                    TO_DEVICE  .UpdateValue ( "CLCP1   \u000D"  ) ; 
                                                    __context__.SourceCodeLine = 944;
                                                    ICOMMAND = (ushort) ( 11 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 946;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELREQQUEUE != 0))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 948;
                                                        TO_DEVICE  .UpdateValue ( SCHANNELTEMP  ) ; 
                                                        __context__.SourceCodeLine = 949;
                                                        ICOMMAND = (ushort) ( 12 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 951;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELUPQUEUE != 0))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 953;
                                                            TO_DEVICE  .UpdateValue ( "CHUP1   \u000D"  ) ; 
                                                            __context__.SourceCodeLine = 954;
                                                            ICOMMAND = (ushort) ( 13 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 956;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELDOWNQUEUE != 0))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 958;
                                                                TO_DEVICE  .UpdateValue ( "CHDW1   \u000D"  ) ; 
                                                                __context__.SourceCodeLine = 959;
                                                                ICOMMAND = (ushort) ( 14 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 961;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IIRKEYSQUEUE != 0))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 963;
                                                                    TO_DEVICE  .UpdateValue ( SENDIRKEYS (  __context__ , (ushort)( IIRKEYSQUEUE ))  ) ; 
                                                                    __context__.SourceCodeLine = 964;
                                                                    ICOMMAND = (ushort) ( 15 ) ; 
                                                                    __context__.SourceCodeLine = 965;
                                                                    IIRKEYSSENT = (ushort) ( IIRKEYSQUEUE ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 969;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 970;
        IPOLLSENT = (ushort) ( 31 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESPONSE_TIMEOUT_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 975;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 1) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (IPOWERQUEUE != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (IINPUTQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IAVMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IASPECTQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IVOLUMEMUTEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ISLEEPQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IEFFECT3DQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (IAUDIOMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ISURROUNDMODEQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICLOSEDCAPTIONQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELREQQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELUPQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELDOWNQUEUE != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (ICHANNELDOWNQUEUE != 0) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 979;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOWERQUEUE != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 981;
                TO_DEVICE  .UpdateValue ( SENDPOWER (  __context__ , (ushort)( IPOWERQUEUE ))  ) ; 
                __context__.SourceCodeLine = 982;
                ICOMMAND = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 983;
                IPOWERSENT = (ushort) ( IPOWERQUEUE ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 985;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IINPUTQUEUE != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 987;
                    TO_DEVICE  .UpdateValue ( SENDINPUT (  __context__ , (ushort)( IINPUTQUEUE ))  ) ; 
                    __context__.SourceCodeLine = 988;
                    ICOMMAND = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 989;
                    IINPUTSENT = (ushort) ( IINPUTQUEUE ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 991;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IAVMODEQUEUE != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 993;
                        TO_DEVICE  .UpdateValue ( SENDAVMODE (  __context__ , (ushort)( IAVMODEQUEUE ))  ) ; 
                        __context__.SourceCodeLine = 994;
                        ICOMMAND = (ushort) ( 3 ) ; 
                        __context__.SourceCodeLine = 995;
                        IAVMODESENT = (ushort) ( IAVMODEQUEUE ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 997;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IASPECTQUEUE != 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 999;
                            TO_DEVICE  .UpdateValue ( SENDASPECT (  __context__ , (ushort)( IASPECTQUEUE ))  ) ; 
                            __context__.SourceCodeLine = 1000;
                            ICOMMAND = (ushort) ( 4 ) ; 
                            __context__.SourceCodeLine = 1001;
                            IASPECTSENT = (ushort) ( IASPECTQUEUE ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1003;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IVOLUMEMUTEQUEUE != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1005;
                                TO_DEVICE  .UpdateValue ( SENDVOLUMEMUTE (  __context__ , (ushort)( IVOLUMEMUTEQUEUE ))  ) ; 
                                __context__.SourceCodeLine = 1006;
                                ICOMMAND = (ushort) ( 5 ) ; 
                                __context__.SourceCodeLine = 1007;
                                IVOLUMEMUTESENT = (ushort) ( IVOLUMEMUTEQUEUE ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1009;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISLEEPQUEUE != 0))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1011;
                                    TO_DEVICE  .UpdateValue ( SENDSLEEP (  __context__ , (ushort)( ISLEEPQUEUE ))  ) ; 
                                    __context__.SourceCodeLine = 1012;
                                    ICOMMAND = (ushort) ( 6 ) ; 
                                    __context__.SourceCodeLine = 1013;
                                    ISLEEPSENT = (ushort) ( ISLEEPQUEUE ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1015;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IEFFECT3DQUEUE != 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1017;
                                        TO_DEVICE  .UpdateValue ( SENDEFFECT3D (  __context__ , (ushort)( IEFFECT3DQUEUE ))  ) ; 
                                        __context__.SourceCodeLine = 1018;
                                        ICOMMAND = (ushort) ( 7 ) ; 
                                        __context__.SourceCodeLine = 1019;
                                        IEFFECT3DSENT = (ushort) ( IEFFECT3DQUEUE ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1021;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IAUDIOMODEQUEUE != 0))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1023;
                                            TO_DEVICE  .UpdateValue ( "ACHA1   \u000D"  ) ; 
                                            __context__.SourceCodeLine = 1024;
                                            ICOMMAND = (ushort) ( 9 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1026;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ISURROUNDMODEQUEUE != 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1028;
                                                TO_DEVICE  .UpdateValue ( "ACSU0   \u000D"  ) ; 
                                                __context__.SourceCodeLine = 1029;
                                                ICOMMAND = (ushort) ( 10 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1031;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICLOSEDCAPTIONQUEUE != 0))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1033;
                                                    TO_DEVICE  .UpdateValue ( "CLCP1   \u000D"  ) ; 
                                                    __context__.SourceCodeLine = 1034;
                                                    ICOMMAND = (ushort) ( 11 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1036;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELREQQUEUE != 0))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1038;
                                                        TO_DEVICE  .UpdateValue ( SCHANNELTEMP  ) ; 
                                                        __context__.SourceCodeLine = 1039;
                                                        ICOMMAND = (ushort) ( 12 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1041;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELUPQUEUE != 0))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1043;
                                                            TO_DEVICE  .UpdateValue ( "CHUP1   \u000D"  ) ; 
                                                            __context__.SourceCodeLine = 1044;
                                                            ICOMMAND = (ushort) ( 13 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1046;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHANNELDOWNQUEUE != 0))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1048;
                                                                TO_DEVICE  .UpdateValue ( "CHDW1   \u000D"  ) ; 
                                                                __context__.SourceCodeLine = 1049;
                                                                ICOMMAND = (ushort) ( 14 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1051;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IIRKEYSQUEUE != 0))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1053;
                                                                    TO_DEVICE  .UpdateValue ( SENDIRKEYS (  __context__ , (ushort)( IIRKEYSQUEUE ))  ) ; 
                                                                    __context__.SourceCodeLine = 1054;
                                                                    ICOMMAND = (ushort) ( 15 ) ; 
                                                                    __context__.SourceCodeLine = 1055;
                                                                    IIRKEYSSENT = (ushort) ( IIRKEYSQUEUE ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1059;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 1060;
        IPOLLSENT = (ushort) ( 31 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1065;
        
            {
            int __SPLS_TMPVAR__SWTCH_17__ = ((int)Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ));
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 1) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1068;
                    MakeString ( SNUMBER , "{0}0", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 2) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1070;
                    MakeString ( SNUMBER , "{0}1", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 3) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1072;
                    MakeString ( SNUMBER , "{0}2", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 4) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1074;
                    MakeString ( SNUMBER , "{0}3", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 5) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1076;
                    MakeString ( SNUMBER , "{0}4", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 6) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1078;
                    MakeString ( SNUMBER , "{0}5", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 7) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1080;
                    MakeString ( SNUMBER , "{0}6", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 8) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1082;
                    MakeString ( SNUMBER , "{0}7", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 9) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1084;
                    MakeString ( SNUMBER , "{0}8", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 10) ) ) ) 
                    {
                    __context__.SourceCodeLine = 1086;
                    MakeString ( SNUMBER , "{0}9", SNUMBER ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 11) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1089;
                    ALOC = (ushort) ( Functions.Find( "." , SNUMBER ) ) ; 
                    __context__.SourceCodeLine = 1090;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALOC == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1092;
                        MakeString ( SNUMBER , "{0}.", SNUMBER ) ; 
                        } 
                    
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 12) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1097;
                    Functions.ClearBuffer ( SNUMBER ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_17__ == ( 13) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 1101;
                    ALOC = (ushort) ( Functions.Find( "." , SNUMBER ) ) ; 
                    __context__.SourceCodeLine = 1102;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALOC != 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1104;
                        if ( Functions.TestForTrue  ( ( AIR  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1106;
                            MakeString ( SCHANNELF , "{0:d2}", (short)Functions.Atoi( Functions.Left( SNUMBER , (int)( (ALOC - 1) ) ) )) ; 
                            __context__.SourceCodeLine = 1107;
                            MakeString ( SCHANNELR , "{0:d2}", (short)Functions.Atoi( Functions.Right( SNUMBER , (int)( (Functions.Length( SNUMBER ) - ALOC) ) ) )) ; 
                            __context__.SourceCodeLine = 1108;
                            MakeString ( SCHANNELTEMP , "DA2P{0}{1}\r", SCHANNELF , SCHANNELR ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1110;
                            if ( Functions.TestForTrue  ( ( CABLE  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1112;
                                MakeString ( SCHANNELF , "{0:d3}", (short)Functions.Atoi( Functions.Left( SNUMBER , (int)( (ALOC - 1) ) ) )) ; 
                                __context__.SourceCodeLine = 1113;
                                MakeString ( SCHANNELR , "{0:d3}", (short)Functions.Atoi( Functions.Right( SNUMBER , (int)( (Functions.Length( SNUMBER ) - ALOC) ) ) )) ; 
                                __context__.SourceCodeLine = 1114;
                                MakeString ( SCHANNELTEMP , "DC2U{0} \rDC2L{1} \r", SCHANNELF , SCHANNELR ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1119;
                        if ( Functions.TestForTrue  ( ( AIR  .Value)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1121;
                            MakeString ( SCHANNELF , "{0:d2}", (short)Functions.Atoi( SNUMBER )) ; 
                            __context__.SourceCodeLine = 1122;
                            MakeString ( SCHANNELTEMP , "DCCH{0}  \r", SCHANNELF ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1124;
                            if ( Functions.TestForTrue  ( ( CABLE  .Value)  ) ) 
                                { 
                                __context__.SourceCodeLine = 1126;
                                MakeString ( SCHANNELF , "{0:d3}", (short)Functions.Atoi( SNUMBER )) ; 
                                __context__.SourceCodeLine = 1127;
                                MakeString ( SCHANNELTEMP , "DCCH{0} \r", SCHANNELF ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 1130;
                    ICHANNELREQQUEUE = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1131;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1133;
                        TO_DEVICE  .UpdateValue ( SCHANNELTEMP  ) ; 
                        __context__.SourceCodeLine = 1134;
                        ICOMMAND = (ushort) ( 12 ) ; 
                        __context__.SourceCodeLine = 1135;
                        IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 1137;
                    Functions.ClearBuffer ( SNUMBER ) ; 
                    } 
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 1140;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IRKEYS_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1145;
        IIRKEYSQUEUE = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 1146;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IWAITINGFORRESPONSE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1148;
            TO_DEVICE  .UpdateValue ( SENDIRKEYS (  __context__ , (ushort)( IIRKEYSQUEUE ))  ) ; 
            __context__.SourceCodeLine = 1149;
            ICOMMAND = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 1150;
            IIRKEYSSENT = (ushort) ( IIRKEYSQUEUE ) ; 
            __context__.SourceCodeLine = 1151;
            IWAITINGFORRESPONSE  .Value = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 1162;
        IWAITINGFORRESPONSE  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1163;
        IPOWERQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1164;
        IINPUTQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1165;
        IAVMODEQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1166;
        IASPECTQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1167;
        IVOLUMEMUTEQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1168;
        ISLEEPQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1169;
        IEFFECT3DQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1170;
        IAUDIOMODEQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1171;
        ISURROUNDMODEQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1172;
        ICLOSEDCAPTIONQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1173;
        ICHANNELREQQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1174;
        ICHANNELUPQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1175;
        ICHANNELDOWNQUEUE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1176;
        IIRKEYSQUEUE = (ushort) ( 0 ) ; 
        
        
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
    STODEVICETEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SCHANNELF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
    SCHANNELR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
    SCHANNELTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    
    RESPONSE_TIMEOUT = new Crestron.Logos.SplusObjects.DigitalInput( RESPONSE_TIMEOUT__DigitalInput__, this );
    m_DigitalInputList.Add( RESPONSE_TIMEOUT__DigitalInput__, RESPONSE_TIMEOUT );
    
    AUDIOMODE = new Crestron.Logos.SplusObjects.DigitalInput( AUDIOMODE__DigitalInput__, this );
    m_DigitalInputList.Add( AUDIOMODE__DigitalInput__, AUDIOMODE );
    
    SURROUNDMODE = new Crestron.Logos.SplusObjects.DigitalInput( SURROUNDMODE__DigitalInput__, this );
    m_DigitalInputList.Add( SURROUNDMODE__DigitalInput__, SURROUNDMODE );
    
    CLOSEDCAPTION = new Crestron.Logos.SplusObjects.DigitalInput( CLOSEDCAPTION__DigitalInput__, this );
    m_DigitalInputList.Add( CLOSEDCAPTION__DigitalInput__, CLOSEDCAPTION );
    
    CHANNELUP = new Crestron.Logos.SplusObjects.DigitalInput( CHANNELUP__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNELUP__DigitalInput__, CHANNELUP );
    
    CHANNELDOWN = new Crestron.Logos.SplusObjects.DigitalInput( CHANNELDOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNELDOWN__DigitalInput__, CHANNELDOWN );
    
    AIR = new Crestron.Logos.SplusObjects.DigitalInput( AIR__DigitalInput__, this );
    m_DigitalInputList.Add( AIR__DigitalInput__, AIR );
    
    CABLE = new Crestron.Logos.SplusObjects.DigitalInput( CABLE__DigitalInput__, this );
    m_DigitalInputList.Add( CABLE__DigitalInput__, CABLE );
    
    KP = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        KP[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( KP__DigitalInput__ + i, KP__DigitalInput__, this );
        m_DigitalInputList.Add( KP__DigitalInput__ + i, KP[i+1] );
    }
    
    POWER = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        POWER[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( POWER__DigitalInput__ + i, POWER__DigitalInput__, this );
        m_DigitalInputList.Add( POWER__DigitalInput__ + i, POWER[i+1] );
    }
    
    INPUT = new InOutArray<DigitalInput>( 9, this );
    for( uint i = 0; i < 9; i++ )
    {
        INPUT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( INPUT__DigitalInput__ + i, INPUT__DigitalInput__, this );
        m_DigitalInputList.Add( INPUT__DigitalInput__ + i, INPUT[i+1] );
    }
    
    AVMODE = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        AVMODE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( AVMODE__DigitalInput__ + i, AVMODE__DigitalInput__, this );
        m_DigitalInputList.Add( AVMODE__DigitalInput__ + i, AVMODE[i+1] );
    }
    
    ASPECT = new InOutArray<DigitalInput>( 11, this );
    for( uint i = 0; i < 11; i++ )
    {
        ASPECT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ASPECT__DigitalInput__ + i, ASPECT__DigitalInput__, this );
        m_DigitalInputList.Add( ASPECT__DigitalInput__ + i, ASPECT[i+1] );
    }
    
    VOLUMEMUTE = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        VOLUMEMUTE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMEMUTE__DigitalInput__ + i, VOLUMEMUTE__DigitalInput__, this );
        m_DigitalInputList.Add( VOLUMEMUTE__DigitalInput__ + i, VOLUMEMUTE[i+1] );
    }
    
    SLEEP = new InOutArray<DigitalInput>( 5, this );
    for( uint i = 0; i < 5; i++ )
    {
        SLEEP[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SLEEP__DigitalInput__ + i, SLEEP__DigitalInput__, this );
        m_DigitalInputList.Add( SLEEP__DigitalInput__ + i, SLEEP[i+1] );
    }
    
    EFFECT3D = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        EFFECT3D[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( EFFECT3D__DigitalInput__ + i, EFFECT3D__DigitalInput__, this );
        m_DigitalInputList.Add( EFFECT3D__DigitalInput__ + i, EFFECT3D[i+1] );
    }
    
    POLL = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        POLL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( POLL__DigitalInput__ + i, POLL__DigitalInput__, this );
        m_DigitalInputList.Add( POLL__DigitalInput__ + i, POLL[i+1] );
    }
    
    IRKEYS = new InOutArray<DigitalInput>( 55, this );
    for( uint i = 0; i < 55; i++ )
    {
        IRKEYS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( IRKEYS__DigitalInput__ + i, IRKEYS__DigitalInput__, this );
        m_DigitalInputList.Add( IRKEYS__DigitalInput__ + i, IRKEYS[i+1] );
    }
    
    IWAITINGFORRESPONSE = new Crestron.Logos.SplusObjects.DigitalOutput( IWAITINGFORRESPONSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( IWAITINGFORRESPONSE__DigitalOutput__, IWAITINGFORRESPONSE );
    
    CURRENT_POWER = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_POWER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_POWER__AnalogSerialOutput__, CURRENT_POWER );
    
    CURRENT_INPUT = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_INPUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_INPUT__AnalogSerialOutput__, CURRENT_INPUT );
    
    CURRENT_AVMODE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_AVMODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_AVMODE__AnalogSerialOutput__, CURRENT_AVMODE );
    
    CURRENT_ASPECT = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_ASPECT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_ASPECT__AnalogSerialOutput__, CURRENT_ASPECT );
    
    CURRENT_VOLUMEMUTE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_VOLUMEMUTE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_VOLUMEMUTE__AnalogSerialOutput__, CURRENT_VOLUMEMUTE );
    
    CURRENT_SLEEP = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_SLEEP__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_SLEEP__AnalogSerialOutput__, CURRENT_SLEEP );
    
    CURRENT_EFFECT3D = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_EFFECT3D__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_EFFECT3D__AnalogSerialOutput__, CURRENT_EFFECT3D );
    
    CURRENT_VOLUME = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_VOLUME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_VOLUME__AnalogSerialOutput__, CURRENT_VOLUME );
    
    FROM_DEVICE = new Crestron.Logos.SplusObjects.StringInput( FROM_DEVICE__AnalogSerialInput__, 25, this );
    m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
    
    NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NUMBER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NUMBER__DOLLAR____AnalogSerialOutput__, NUMBER__DOLLAR__ );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    
    for( uint i = 0; i < 2; i++ )
        POWER[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OnPush_0, false ) );
        
    for( uint i = 0; i < 9; i++ )
        INPUT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_OnPush_1, false ) );
        
    for( uint i = 0; i < 12; i++ )
        AVMODE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( AVMODE_OnPush_2, false ) );
        
    for( uint i = 0; i < 11; i++ )
        ASPECT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ASPECT_OnPush_3, false ) );
        
    for( uint i = 0; i < 2; i++ )
        VOLUMEMUTE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMEMUTE_OnPush_4, false ) );
        
    for( uint i = 0; i < 5; i++ )
        SLEEP[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SLEEP_OnPush_5, false ) );
        
    for( uint i = 0; i < 8; i++ )
        EFFECT3D[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( EFFECT3D_OnPush_6, false ) );
        
    for( uint i = 0; i < 8; i++ )
        POLL[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_OnPush_7, false ) );
        
    AUDIOMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUDIOMODE_OnPush_8, false ) );
    SURROUNDMODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SURROUNDMODE_OnPush_9, false ) );
    CLOSEDCAPTION.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLOSEDCAPTION_OnPush_10, false ) );
    CHANNELUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNELUP_OnPush_11, false ) );
    CHANNELDOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNELDOWN_OnPush_12, false ) );
    FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_13, false ) );
    RESPONSE_TIMEOUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESPONSE_TIMEOUT_OnPush_14, false ) );
    for( uint i = 0; i < 13; i++ )
        KP[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( KP_OnPush_15, false ) );
        
    for( uint i = 0; i < 55; i++ )
        IRKEYS[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( IRKEYS_OnPush_16, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_SHARP_FLATPANEL_DRIVER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint RESPONSE_TIMEOUT__DigitalInput__ = 0;
const uint AUDIOMODE__DigitalInput__ = 1;
const uint SURROUNDMODE__DigitalInput__ = 2;
const uint CLOSEDCAPTION__DigitalInput__ = 3;
const uint CHANNELUP__DigitalInput__ = 4;
const uint CHANNELDOWN__DigitalInput__ = 5;
const uint AIR__DigitalInput__ = 6;
const uint CABLE__DigitalInput__ = 7;
const uint KP__DigitalInput__ = 8;
const uint POWER__DigitalInput__ = 21;
const uint INPUT__DigitalInput__ = 23;
const uint AVMODE__DigitalInput__ = 32;
const uint ASPECT__DigitalInput__ = 44;
const uint VOLUMEMUTE__DigitalInput__ = 55;
const uint SLEEP__DigitalInput__ = 57;
const uint EFFECT3D__DigitalInput__ = 62;
const uint POLL__DigitalInput__ = 70;
const uint IRKEYS__DigitalInput__ = 78;
const uint FROM_DEVICE__AnalogSerialInput__ = 0;
const uint IWAITINGFORRESPONSE__DigitalOutput__ = 0;
const uint CURRENT_POWER__AnalogSerialOutput__ = 0;
const uint CURRENT_INPUT__AnalogSerialOutput__ = 1;
const uint CURRENT_AVMODE__AnalogSerialOutput__ = 2;
const uint CURRENT_ASPECT__AnalogSerialOutput__ = 3;
const uint CURRENT_VOLUMEMUTE__AnalogSerialOutput__ = 4;
const uint CURRENT_SLEEP__AnalogSerialOutput__ = 5;
const uint CURRENT_EFFECT3D__AnalogSerialOutput__ = 6;
const uint CURRENT_VOLUME__AnalogSerialOutput__ = 7;
const uint NUMBER__DOLLAR____AnalogSerialOutput__ = 8;
const uint TO_DEVICE__AnalogSerialOutput__ = 9;

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
