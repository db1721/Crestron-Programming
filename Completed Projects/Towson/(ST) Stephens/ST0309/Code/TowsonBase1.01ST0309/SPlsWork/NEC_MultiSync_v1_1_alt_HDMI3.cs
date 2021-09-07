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

namespace UserModule_NEC_MULTISYNC_V1_1_ALT_HDMI3
{
    public class UserModuleClass_NEC_MULTISYNC_V1_1_ALT_HDMI3 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_MAIN_INFO;
        Crestron.Logos.SplusObjects.DigitalInput POLL_MAIN_INFO_NO_VOLUME;
        Crestron.Logos.SplusObjects.DigitalInput TURN_POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput TURN_POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput TURN_MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalInput TURN_MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_CURRENT_SETTINGS;
        Crestron.Logos.SplusObjects.DigitalInput SET_TV_CHANNEL;
        Crestron.Logos.SplusObjects.DigitalInput TV_CHANNEL_UP;
        Crestron.Logos.SplusObjects.DigitalInput TV_CHANNEL_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput LOCK_CONTROL_BUTTON;
        Crestron.Logos.SplusObjects.DigitalInput UNLOCK_CONTROL_BUTTON;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLE_POWER;
        Crestron.Logos.SplusObjects.DigitalInput TOGGLE_MUTE;
        Crestron.Logos.SplusObjects.DigitalInput VOL_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOL_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput GUIDE;
        Crestron.Logos.SplusObjects.DigitalInput NUMERIC_FORMAT;
        Crestron.Logos.SplusObjects.DigitalInput NUMBERIC_ENT;
        Crestron.Logos.SplusObjects.DigitalInput DISPLAY;
        Crestron.Logos.SplusObjects.DigitalInput MENU;
        Crestron.Logos.SplusObjects.DigitalInput EXIT;
        Crestron.Logos.SplusObjects.DigitalInput AUTOSETUP;
        Crestron.Logos.SplusObjects.DigitalInput UP;
        Crestron.Logos.SplusObjects.DigitalInput DOWN;
        Crestron.Logos.SplusObjects.DigitalInput LEFT_D;
        Crestron.Logos.SplusObjects.DigitalInput RIGHT_D;
        Crestron.Logos.SplusObjects.DigitalInput SET;
        Crestron.Logos.SplusObjects.DigitalInput PICTURE_MODE;
        Crestron.Logos.SplusObjects.DigitalInput ASPECT;
        Crestron.Logos.SplusObjects.DigitalInput SOUND;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> NUMBERS;
        Crestron.Logos.SplusObjects.AnalogInput CHANGE_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput CHANGE_VOLUME_LEVEL;
        Crestron.Logos.SplusObjects.AnalogInput CHANGE_TV_CHANNEL;
        Crestron.Logos.SplusObjects.AnalogInput CHANGE_ANALOG_CLOSED_CAPTION;
        Crestron.Logos.SplusObjects.AnalogInput CHANGE_DIGITAL_CLOSED_CAPTION;
        Crestron.Logos.SplusObjects.BufferInput FROMDEVICE;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_IS_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_IS_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput CONTROL_BUTTON_IS_LOCKED;
        Crestron.Logos.SplusObjects.DigitalOutput CONTROL_BUTTON_IS_UNLOCKED;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTED_INPUT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput ANALOG_CLOSED_CAPTION_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput DIGITAL_CLOSED_CAPTION_ANALOG;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_CHANNEL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TODEVICE;
        Crestron.Logos.SplusObjects.StringOutput MESSAGE;
        UShortParameter MONITOR_ID;
        ushort RXOK = 0;
        ushort SENDING = 0;
        ushort RX_MESSAGELENGTH = 0;
        ushort RX_MESSAGETYPE = 0;
        ushort RX_MARKER1 = 0;
        ushort RX_MARKER2 = 0;
        ushort RX_MARKER3 = 0;
        ushort CURRENTTVCHANNEL = 0;
        ushort _VOLUME = 0;
        ushort _MUTED = 0;
        ushort _VOLUMEBEFOREMUTED = 0;
        CrestronString RESPONSESTRING;
        CrestronString COMMANDSTRING;
        CrestronString COMMANDTOBESEND;
        CrestronString RX_HEADER;
        CrestronString RX_MESSAGE;
        CrestronString RX_TRASH;
        private void SEND (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 139;
            COMMANDTOBESEND  .UpdateValue ( Functions.Remove ( "\u000D\u000A\u000A" , COMMANDSTRING )  ) ; 
            __context__.SourceCodeLine = 140;
            COMMANDTOBESEND  .UpdateValue ( Functions.Left ( COMMANDTOBESEND ,  (int) ( (Functions.Length( COMMANDTOBESEND ) - 3) ) )  ) ; 
            __context__.SourceCodeLine = 142;
            TODEVICE  .UpdateValue ( COMMANDTOBESEND  ) ; 
            __context__.SourceCodeLine = 149;
            /* Trace( "IO Timeout") */ ; 
            __context__.SourceCodeLine = 150;
            SENDING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 151;
            COMMANDSTRING  .UpdateValue ( ""  ) ; 
            
            }
            
        private CrestronString CALCULATE_BCC (  SplusExecutionContext __context__, CrestronString CMD ) 
            { 
            ushort CMDLENGTH = 0;
            ushort I = 0;
            ushort RESULT = 0;
            
            
            __context__.SourceCodeLine = 170;
            CMDLENGTH = (ushort) ( Functions.Length( CMD ) ) ; 
            __context__.SourceCodeLine = 171;
            RESULT = (ushort) ( Byte( CMD , (int)( 1 ) ) ) ; 
            __context__.SourceCodeLine = 173;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 2 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)CMDLENGTH; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 175;
                RESULT = (ushort) ( (RESULT ^ Byte( CMD , (int)( I ) )) ) ; 
                __context__.SourceCodeLine = 173;
                } 
            
            __context__.SourceCodeLine = 178;
            return ( Functions.Chr (  (int) ( Functions.Low( (ushort) RESULT ) ) ) ) ; 
            
            }
            
        private void ADDCOMMAND (  SplusExecutionContext __context__, CrestronString CMD ) 
            { 
            CrestronString TEMP;
            CrestronString RESULT;
            TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            
            __context__.SourceCodeLine = 185;
            MakeString ( TEMP , "\u0001\u0030{0}{1}", Functions.Chr (  (int) ( Functions.Low( (ushort) (MONITOR_ID  .Value + 64) ) ) ) , CMD ) ; 
            __context__.SourceCodeLine = 187;
            RESULT  .UpdateValue ( CALCULATE_BCC (  __context__ , Functions.Right( TEMP , (int)( (Functions.Length( TEMP ) - 1) ) ))  ) ; 
            __context__.SourceCodeLine = 188;
            TEMP  .UpdateValue ( TEMP + RESULT + "\u000D\u000D\u000A\u000A"  ) ; 
            __context__.SourceCodeLine = 189;
            COMMANDSTRING  .UpdateValue ( COMMANDSTRING + TEMP  ) ; 
            __context__.SourceCodeLine = 191;
            if ( Functions.TestForTrue  ( ( Functions.Not( SENDING ))  ) ) 
                { 
                __context__.SourceCodeLine = 193;
                SENDING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 194;
                SEND (  __context__  ) ; 
                } 
            
            
            }
            
        private void OUTPUTSOURCERESULT (  SplusExecutionContext __context__, ushort I ) 
            { 
            
            __context__.SourceCodeLine = 200;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)I);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 204;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 208;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 212;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 2 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 216;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 3 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 220;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 4 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 224;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 5 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 228;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 6 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 232;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 7 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 236;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 8 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 240;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 9 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 17) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 244;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 10 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 18) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 248;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 11 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 19) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 252;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 12 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 15) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 256;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 13 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 130) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 260;
                        SELECTED_INPUT_ANALOG  .Value = (ushort) ( 12 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void OUTPUTANALOGCAPTIONRESULT (  SplusExecutionContext __context__, ushort I ) 
            { 
            
            __context__.SourceCodeLine = 267;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)I);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 271;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 275;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 279;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 2 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 283;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 3 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 287;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 4 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 291;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 5 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 295;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 6 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 299;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 7 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 303;
                        ANALOG_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 8 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void OUTPUTDIGITALCAPTIONRESULT (  SplusExecutionContext __context__, ushort I ) 
            { 
            
            __context__.SourceCodeLine = 310;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)I);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 314;
                        DIGITAL_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 318;
                        DIGITAL_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 322;
                        DIGITAL_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 2 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 326;
                        DIGITAL_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 3 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 330;
                        DIGITAL_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 4 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 334;
                        DIGITAL_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 5 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 338;
                        DIGITAL_CLOSED_CAPTION_ANALOG  .Value = (ushort) ( 6 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void PROCESSRESPONSE (  SplusExecutionContext __context__, CrestronString CMD ) 
            { 
            ushort RESULT = 0;
            
            
            __context__.SourceCodeLine = 348;
            RX_MESSAGETYPE = (ushort) ( Byte( CMD , (int)( 5 ) ) ) ; 
            __context__.SourceCodeLine = 350;
            RX_MESSAGELENGTH = (ushort) ( ((16 * Functions.HextoI( Functions.Mid( CMD , (int)( 6 ) , (int)( 1 ) ) )) + Functions.HextoI( Functions.Mid( CMD , (int)( 7 ) , (int)( 1 ) ) )) ) ; 
            __context__.SourceCodeLine = 351;
            MakeString ( MESSAGE , "RX Found Message Length: {0:d}", (ushort)RX_MESSAGELENGTH) ; 
            __context__.SourceCodeLine = 352;
            
                {
                int __SPLS_TMPVAR__SWTCH_4__ = ((int)RX_MESSAGETYPE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 66) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 356;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 9 ) , (int)( 2 ) ) == "02"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 358;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 2 ) ) == "00"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 360;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 13 ) , (int)( 4 ) ) == "D600"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 362;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 24 ) , (int)( 1 ) ) == "1"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 364;
                                        Functions.Pulse ( 10, POWER_IS_ON ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 368;
                                        Functions.Pulse ( 10, POWER_IS_OFF ) ; 
                                        } 
                                    
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 374;
                                /* Trace( "Error received while executing command") */ ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 377;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 9 ) , (int)( 2 ) ) == "00"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 379;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 6 ) ) == "C203D6"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 381;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 20 ) , (int)( 1 ) ) == "1"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 383;
                                        Functions.Pulse ( 10, POWER_IS_ON ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 385;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 20 ) , (int)( 1 ) ) == "4"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 387;
                                            Functions.Pulse ( 10, POWER_IS_OFF ) ; 
                                            } 
                                        
                                        }
                                    
                                    } 
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 393;
                                /* Trace( "Error received while executing command") */ ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 68) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 398;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 9 ) , (int)( 2 ) ) == "00"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 400;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "02BE"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 402;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 18 ) , (int)( 1 ) ) == "1"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 404;
                                    Functions.Pulse ( 10, POWER_IS_ON ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 406;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 18 ) , (int)( 1 ) ) == "2"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 408;
                                        Functions.Pulse ( 10, POWER_IS_OFF ) ; 
                                        } 
                                    
                                    }
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 411;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "0062"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 414;
                                    if ( Functions.TestForTrue  ( ( Functions.Not( _MUTED ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 416;
                                        _VOLUME = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 417;
                                        VOLUME_ANALOG  .Value = (ushort) ( _VOLUME ) ; 
                                        __context__.SourceCodeLine = 418;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_VOLUME == 0))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 420;
                                            _MUTED = (ushort) ( 1 ) ; 
                                            __context__.SourceCodeLine = 421;
                                            Functions.Pulse ( 10, MUTE_IS_ON ) ; 
                                            } 
                                        
                                        else 
                                            { 
                                            __context__.SourceCodeLine = 425;
                                            _MUTED = (ushort) ( 0 ) ; 
                                            __context__.SourceCodeLine = 426;
                                            Functions.Pulse ( 10, MUTE_IS_OFF ) ; 
                                            } 
                                        
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 430;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "0060"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 432;
                                        OUTPUTSOURCERESULT (  __context__ , (ushort)( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) )) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 434;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "008D"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 436;
                                            RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 437;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 0))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 439;
                                                _MUTED = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 440;
                                                Functions.Pulse ( 10, MUTE_IS_OFF ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 443;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 445;
                                                    _MUTED = (ushort) ( 1 ) ; 
                                                    __context__.SourceCodeLine = 446;
                                                    _VOLUME = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 447;
                                                    VOLUME_ANALOG  .Value = (ushort) ( 0 ) ; 
                                                    __context__.SourceCodeLine = 448;
                                                    Functions.Pulse ( 10, MUTE_IS_ON ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 450;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 2))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 452;
                                                        _MUTED = (ushort) ( 0 ) ; 
                                                        __context__.SourceCodeLine = 453;
                                                        VOLUME_ANALOG  .Value = (ushort) ( _VOLUME ) ; 
                                                        __context__.SourceCodeLine = 454;
                                                        Functions.Pulse ( 10, MUTE_IS_OFF ) ; 
                                                        } 
                                                    
                                                    }
                                                
                                                }
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 457;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "1084"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 459;
                                                RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                                __context__.SourceCodeLine = 460;
                                                OUTPUTANALOGCAPTIONRESULT (  __context__ , (ushort)( RESULT )) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 462;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "10A1"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 464;
                                                    RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                                    __context__.SourceCodeLine = 465;
                                                    OUTPUTDIGITALCAPTIONRESULT (  __context__ , (ushort)( RESULT )) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 467;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "00FB"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 469;
                                                        RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                                        __context__.SourceCodeLine = 470;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 472;
                                                            Functions.Pulse ( 10, CONTROL_BUTTON_IS_LOCKED ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 474;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 0))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 476;
                                                                Functions.Pulse ( 10, CONTROL_BUTTON_IS_UNLOCKED ) ; 
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
                            __context__.SourceCodeLine = 482;
                            /* Trace( "Error received while retrieving value") */ ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 70) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 487;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 9 ) , (int)( 2 ) ) == "00"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 489;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "0060"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 491;
                                RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                __context__.SourceCodeLine = 492;
                                OUTPUTSOURCERESULT (  __context__ , (ushort)( RESULT )) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 494;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "0062"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 496;
                                    _VOLUME = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                    __context__.SourceCodeLine = 497;
                                    VOLUME_ANALOG  .Value = (ushort) ( _VOLUME ) ; 
                                    __context__.SourceCodeLine = 498;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_VOLUME == 0))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 500;
                                        _MUTED = (ushort) ( 1 ) ; 
                                        __context__.SourceCodeLine = 501;
                                        Functions.Pulse ( 10, MUTE_IS_ON ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 505;
                                        _MUTED = (ushort) ( 0 ) ; 
                                        __context__.SourceCodeLine = 506;
                                        Functions.Pulse ( 10, MUTE_IS_OFF ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 509;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "008D"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 511;
                                        RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 512;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 1))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 514;
                                            _MUTED = (ushort) ( 1 ) ; 
                                            __context__.SourceCodeLine = 515;
                                            Functions.Pulse ( 10, MUTE_IS_ON ) ; 
                                            __context__.SourceCodeLine = 516;
                                            VOLUME_ANALOG  .Value = (ushort) ( 0 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 518;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 2))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 520;
                                                _MUTED = (ushort) ( 0 ) ; 
                                                __context__.SourceCodeLine = 521;
                                                Functions.Pulse ( 10, MUTE_IS_OFF ) ; 
                                                __context__.SourceCodeLine = 522;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_VOLUME == 0))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 524;
                                                    _VOLUME = (ushort) ( 1 ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 526;
                                                VOLUME_ANALOG  .Value = (ushort) ( _VOLUME ) ; 
                                                } 
                                            
                                            }
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 529;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "1084"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 531;
                                            RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 532;
                                            OUTPUTANALOGCAPTIONRESULT (  __context__ , (ushort)( RESULT )) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 534;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "10A1"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 536;
                                                RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                                __context__.SourceCodeLine = 537;
                                                OUTPUTDIGITALCAPTIONRESULT (  __context__ , (ushort)( RESULT )) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 539;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( CMD , (int)( 11 ) , (int)( 4 ) ) == "00FB"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 541;
                                                    RESULT = (ushort) ( Functions.HextoI( Functions.Mid( CMD , (int)( 23 ) , (int)( 2 ) ) ) ) ; 
                                                    __context__.SourceCodeLine = 542;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 544;
                                                        Functions.Pulse ( 10, CONTROL_BUTTON_IS_LOCKED ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 546;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RESULT == 0))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 548;
                                                            Functions.Pulse ( 10, CONTROL_BUTTON_IS_UNLOCKED ) ; 
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
                            __context__.SourceCodeLine = 554;
                            /* Trace( "Error received while Setting value") */ ; 
                            } 
                        
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        object POLL_MAIN_INFO_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 567;
                ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0036\u0002\u0030\u0031\u0044\u0036\u0003") ; 
                __context__.SourceCodeLine = 568;
                ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0030\u0030\u0038\u0044\u0003") ; 
                __context__.SourceCodeLine = 569;
                ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0030\u0030\u0036\u0032\u0003") ; 
                __context__.SourceCodeLine = 570;
                ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0030\u0030\u0036\u0030\u0003") ; 
                __context__.SourceCodeLine = 571;
                ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0031\u0030\u0038\u0034\u0003") ; 
                __context__.SourceCodeLine = 572;
                ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0031\u0030\u0041\u0031\u0003") ; 
                __context__.SourceCodeLine = 573;
                ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0030\u0030\u0046\u0042\u0003") ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POLL_MAIN_INFO_NO_VOLUME_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 578;
            ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0036\u0002\u0030\u0031\u0044\u0036\u0003") ; 
            __context__.SourceCodeLine = 579;
            ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0030\u0030\u0038\u0044\u0003") ; 
            __context__.SourceCodeLine = 580;
            ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0030\u0030\u0036\u0030\u0003") ; 
            __context__.SourceCodeLine = 581;
            ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0031\u0030\u0038\u0034\u0003") ; 
            __context__.SourceCodeLine = 582;
            ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0031\u0030\u0041\u0031\u0003") ; 
            __context__.SourceCodeLine = 583;
            ADDCOMMAND (  __context__ , "\u0030\u0043\u0030\u0036\u0002\u0030\u0030\u0046\u0042\u0003") ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TURN_POWER_ON_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 588;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0030\u0033\u0044\u0036\u0030\u0030\u0030\u0031\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TURN_POWER_OFF_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 593;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0030\u0033\u0044\u0036\u0030\u0030\u0030\u0034\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TURN_MUTE_ON_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 598;
        _VOLUMEBEFOREMUTED = (ushort) ( _VOLUME ) ; 
        __context__.SourceCodeLine = 599;
        ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0032\u0030\u0030\u0030\u0030\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TURN_MUTE_OFF_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP;
        CrestronString TEMP2;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        TEMP2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
        
        
        __context__.SourceCodeLine = 605;
        _VOLUME = (ushort) ( _VOLUMEBEFOREMUTED ) ; 
        __context__.SourceCodeLine = 606;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_VOLUME == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 608;
            _VOLUME = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 610;
        MakeString ( TEMP2 , "{0:X2}", _VOLUME) ; 
        __context__.SourceCodeLine = 611;
        MakeString ( TEMP , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0032\u0030\u0030{0}{1}\u0003", Functions.Mid ( TEMP2 ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( TEMP2 ,  (int) ( 2 ) ,  (int) ( 1 ) ) ) ; 
        __context__.SourceCodeLine = 612;
        ADDCOMMAND (  __context__ , TEMP) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_CURRENT_SETTINGS_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 617;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0034\u0002\u0030\u0043\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_TV_CHANNEL_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 622;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0030\u0033\u0044\u0036\u0030\u0030\u0030\u0034\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TV_CHANNEL_UP_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 627;
        ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0038\u0042\u0030\u0030\u0030\u0031\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TV_CHANNEL_DOWN_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP;
        CrestronString RESULT;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        
        
        __context__.SourceCodeLine = 634;
        ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0038\u0042\u0030\u0030\u0030\u0032\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOCK_CONTROL_BUTTON_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 639;
        ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0046\u0042\u0030\u0030\u0030\u0031\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UNLOCK_CONTROL_BUTTON_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 644;
        ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0046\u0042\u0030\u0030\u0030\u0030\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOGGLE_POWER_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 650;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0030\u0033\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOGGLE_MUTE_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 655;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0031\u0042\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOL_UP_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP;
        CrestronString TEMP2;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        TEMP2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
        
        
        __context__.SourceCodeLine = 664;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _VOLUME < 100 ) ) && Functions.TestForTrue ( Functions.Not( _MUTED ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 666;
            _VOLUME = (ushort) ( (_VOLUME + 1) ) ; 
            __context__.SourceCodeLine = 667;
            MakeString ( TEMP2 , "{0:X2}", _VOLUME) ; 
            __context__.SourceCodeLine = 668;
            MakeString ( TEMP , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0032\u0030\u0030{0}{1}\u0003", Functions.Mid ( TEMP2 ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( TEMP2 ,  (int) ( 2 ) ,  (int) ( 1 ) ) ) ; 
            __context__.SourceCodeLine = 669;
            ADDCOMMAND (  __context__ , TEMP) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOL_DOWN_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP;
        CrestronString TEMP2;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        TEMP2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
        
        
        __context__.SourceCodeLine = 679;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _VOLUME > 0 ) ) && Functions.TestForTrue ( Functions.Not( _MUTED ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 681;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_VOLUME == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 683;
                _VOLUMEBEFOREMUTED = (ushort) ( _VOLUME ) ; 
                } 
            
            __context__.SourceCodeLine = 685;
            _VOLUME = (ushort) ( (_VOLUME - 1) ) ; 
            __context__.SourceCodeLine = 686;
            MakeString ( TEMP2 , "{0:X2}", _VOLUME) ; 
            __context__.SourceCodeLine = 687;
            MakeString ( TEMP , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0032\u0030\u0030{0}{1}\u0003", Functions.Mid ( TEMP2 ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( TEMP2 ,  (int) ( 2 ) ,  (int) ( 1 ) ) ) ; 
            __context__.SourceCodeLine = 688;
            ADDCOMMAND (  __context__ , TEMP) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUIDE_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 694;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0033\u0034\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GUIDE_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 699;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0033\u0034\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NUMERIC_FORMAT_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 704;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0034\u0034\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NUMBERIC_ENT_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 709;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0034\u0035\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISPLAY_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 714;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0031\u0039\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MENU_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 719;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0032\u0030\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EXIT_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 724;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0031\u0046\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOSETUP_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 729;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0031\u0043\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UP_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 734;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0031\u0035\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOWN_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 739;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0031\u0034\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LEFT_D_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 744;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0032\u0031\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RIGHT_D_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 749;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0032\u0032\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 754;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0032\u0033\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PICTURE_MODE_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 759;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0031\u0044\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ASPECT_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 764;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0032\u0039\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOUND_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 769;
        ADDCOMMAND (  __context__ , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030\u0034\u0033\u0030\u0033\u0003") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NUMBERS_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        
        CrestronString TEMP;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        
        __context__.SourceCodeLine = 776;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 777;
        MakeString ( TEMP , "\u0030\u0041\u0030\u0043\u0002\u0043\u0032\u0031\u0030\u0030\u0030") ; 
        __context__.SourceCodeLine = 779;
        
            {
            int __SPLS_TMPVAR__SWTCH_5__ = ((int)I);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 783;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0038"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 787;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0039"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 791;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0041"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 795;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0042"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 5) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 799;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0043"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 6) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 803;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0044"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 7) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 807;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0045"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 8) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 811;
                    TEMP  .UpdateValue ( TEMP + "\u0030\u0046"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 9) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 815;
                    TEMP  .UpdateValue ( TEMP + "\u0031\u0030"  ) ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 10) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 819;
                    TEMP  .UpdateValue ( TEMP + "\u0031\u0032"  ) ; 
                    } 
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 823;
        TEMP  .UpdateValue ( TEMP + "\u0030\u0033\u0003"  ) ; 
        __context__.SourceCodeLine = 824;
        ADDCOMMAND (  __context__ , TEMP) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANGE_SOURCE_OnChange_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP;
        CrestronString RESULT;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        
        
        __context__.SourceCodeLine = 831;
        
            {
            int __SPLS_TMPVAR__SWTCH_6__ = ((int)CHANGE_SOURCE  .UshortValue);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 835;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0030\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 839;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0031\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 843;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0032\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 847;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0033\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 851;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0035\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 855;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0036\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 6) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 859;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0037\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 7) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 863;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0043\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 8) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 867;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0034\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 9) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 871;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0041\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 10) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 875;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0031\u0031\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 11) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 879;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0031\u0032\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 12) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 883;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0038\u0032\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 13) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 888;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0030\u0030\u0030\u0030\u0046\u0003") ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANGE_VOLUME_LEVEL_OnChange_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMP;
        CrestronString TEMP2;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        TEMP2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
        
        
        __context__.SourceCodeLine = 896;
        MakeString ( TEMP2 , "{0:X2}", CHANGE_VOLUME_LEVEL  .UshortValue) ; 
        __context__.SourceCodeLine = 898;
        _VOLUME = (ushort) ( CHANGE_VOLUME_LEVEL  .UshortValue ) ; 
        __context__.SourceCodeLine = 899;
        MakeString ( TEMP , "\u0030\u0045\u0030\u0041\u0002\u0030\u0030\u0036\u0032\u0030\u0030{0}{1}\u0003", Functions.Mid ( TEMP2 ,  (int) ( 1 ) ,  (int) ( 1 ) ) , Functions.Mid ( TEMP2 ,  (int) ( 2 ) ,  (int) ( 1 ) ) ) ; 
        __context__.SourceCodeLine = 900;
        ADDCOMMAND (  __context__ , TEMP) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANGE_TV_CHANNEL_OnChange_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 905;
        CURRENTTVCHANNEL = (ushort) ( CHANGE_TV_CHANNEL  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANGE_ANALOG_CLOSED_CAPTION_OnChange_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 910;
        
            {
            int __SPLS_TMPVAR__SWTCH_7__ = ((int)CHANGE_SOURCE  .UshortValue);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 914;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0031\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 918;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0032\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 922;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0033\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 926;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0034\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 930;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0035\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 5) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 934;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0036\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 6) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 938;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0031\u0037\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 7) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 942;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0038\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 8) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 946;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0038\u0034\u0030\u0030\u0030\u0039\u0003") ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANGE_DIGITAL_CLOSED_CAPTION_OnChange_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 953;
        
            {
            int __SPLS_TMPVAR__SWTCH_8__ = ((int)CHANGE_SOURCE  .UshortValue);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 0) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 957;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0041\u0031\u0030\u0030\u0030\u0031\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 1) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 961;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0041\u0031\u0030\u0030\u0030\u0032\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 965;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0041\u0031\u0030\u0030\u0030\u0033\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 969;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0041\u0031\u0030\u0030\u0030\u0034\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 4) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 973;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0041\u0031\u0030\u0030\u0030\u0035\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 5) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 977;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0041\u0031\u0030\u0030\u0030\u0036\u0003") ; 
                    } 
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 6) ) ) ) 
                    { 
                    __context__.SourceCodeLine = 981;
                    ADDCOMMAND (  __context__ , "\u0030\u0045\u0030\u0041\u0002\u0031\u0030\u0041\u0031\u0030\u0030\u0031\u0037\u0003") ; 
                    } 
                
                } 
                
            }
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROMDEVICE_OnChange_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 988;
        RESPONSESTRING  .UpdateValue ( RESPONSESTRING + FROMDEVICE  ) ; 
        __context__.SourceCodeLine = 989;
        Functions.ClearBuffer ( FROMDEVICE ) ; 
        __context__.SourceCodeLine = 991;
        if ( Functions.TestForTrue  ( ( RXOK)  ) ) 
            { 
            __context__.SourceCodeLine = 993;
            RXOK = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 994;
            while ( Functions.TestForTrue  ( ( Functions.Find( "\u000D" , RESPONSESTRING ))  ) ) 
                { 
                __context__.SourceCodeLine = 996;
                RX_MARKER3 = (ushort) ( Functions.Find( "\u000D" , RESPONSESTRING ) ) ; 
                __context__.SourceCodeLine = 997;
                if ( Functions.TestForTrue  ( ( RX_MARKER3)  ) ) 
                    { 
                    __context__.SourceCodeLine = 999;
                    RX_MESSAGE  .UpdateValue ( Functions.Remove ( RX_MARKER3, RESPONSESTRING )  ) ; 
                    __context__.SourceCodeLine = 1001;
                    PROCESSRESPONSE (  __context__ , RX_MESSAGE) ; 
                    __context__.SourceCodeLine = 1002;
                    if ( Functions.TestForTrue  ( ( Functions.Length( COMMANDSTRING ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1004;
                        SEND (  __context__  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1008;
                        SENDING = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 994;
                } 
            
            __context__.SourceCodeLine = 1012;
            RXOK = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 1025;
        RXOK = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1026;
        RX_MESSAGELENGTH = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1027;
        RX_MARKER1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1028;
        RX_MARKER2 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1029;
        SENDING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1030;
        RESPONSESTRING  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1031;
        COMMANDSTRING  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 1032;
        _VOLUME = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1033;
        _MUTED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1034;
        _VOLUMEBEFOREMUTED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1035;
        CURRENTTVCHANNEL = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    RESPONSESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
    COMMANDSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3000, this );
    COMMANDTOBESEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    RX_HEADER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 7, this );
    RX_MESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    RX_TRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    POLL_MAIN_INFO = new Crestron.Logos.SplusObjects.DigitalInput( POLL_MAIN_INFO__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_MAIN_INFO__DigitalInput__, POLL_MAIN_INFO );
    
    POLL_MAIN_INFO_NO_VOLUME = new Crestron.Logos.SplusObjects.DigitalInput( POLL_MAIN_INFO_NO_VOLUME__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_MAIN_INFO_NO_VOLUME__DigitalInput__, POLL_MAIN_INFO_NO_VOLUME );
    
    TURN_POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( TURN_POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( TURN_POWER_ON__DigitalInput__, TURN_POWER_ON );
    
    TURN_POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( TURN_POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( TURN_POWER_OFF__DigitalInput__, TURN_POWER_OFF );
    
    TURN_MUTE_ON = new Crestron.Logos.SplusObjects.DigitalInput( TURN_MUTE_ON__DigitalInput__, this );
    m_DigitalInputList.Add( TURN_MUTE_ON__DigitalInput__, TURN_MUTE_ON );
    
    TURN_MUTE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( TURN_MUTE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( TURN_MUTE_OFF__DigitalInput__, TURN_MUTE_OFF );
    
    SAVE_CURRENT_SETTINGS = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_CURRENT_SETTINGS__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_CURRENT_SETTINGS__DigitalInput__, SAVE_CURRENT_SETTINGS );
    
    SET_TV_CHANNEL = new Crestron.Logos.SplusObjects.DigitalInput( SET_TV_CHANNEL__DigitalInput__, this );
    m_DigitalInputList.Add( SET_TV_CHANNEL__DigitalInput__, SET_TV_CHANNEL );
    
    TV_CHANNEL_UP = new Crestron.Logos.SplusObjects.DigitalInput( TV_CHANNEL_UP__DigitalInput__, this );
    m_DigitalInputList.Add( TV_CHANNEL_UP__DigitalInput__, TV_CHANNEL_UP );
    
    TV_CHANNEL_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( TV_CHANNEL_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( TV_CHANNEL_DOWN__DigitalInput__, TV_CHANNEL_DOWN );
    
    LOCK_CONTROL_BUTTON = new Crestron.Logos.SplusObjects.DigitalInput( LOCK_CONTROL_BUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( LOCK_CONTROL_BUTTON__DigitalInput__, LOCK_CONTROL_BUTTON );
    
    UNLOCK_CONTROL_BUTTON = new Crestron.Logos.SplusObjects.DigitalInput( UNLOCK_CONTROL_BUTTON__DigitalInput__, this );
    m_DigitalInputList.Add( UNLOCK_CONTROL_BUTTON__DigitalInput__, UNLOCK_CONTROL_BUTTON );
    
    TOGGLE_POWER = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLE_POWER__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLE_POWER__DigitalInput__, TOGGLE_POWER );
    
    TOGGLE_MUTE = new Crestron.Logos.SplusObjects.DigitalInput( TOGGLE_MUTE__DigitalInput__, this );
    m_DigitalInputList.Add( TOGGLE_MUTE__DigitalInput__, TOGGLE_MUTE );
    
    VOL_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOL_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOL_UP__DigitalInput__, VOL_UP );
    
    VOL_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOL_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOL_DOWN__DigitalInput__, VOL_DOWN );
    
    GUIDE = new Crestron.Logos.SplusObjects.DigitalInput( GUIDE__DigitalInput__, this );
    m_DigitalInputList.Add( GUIDE__DigitalInput__, GUIDE );
    
    NUMERIC_FORMAT = new Crestron.Logos.SplusObjects.DigitalInput( NUMERIC_FORMAT__DigitalInput__, this );
    m_DigitalInputList.Add( NUMERIC_FORMAT__DigitalInput__, NUMERIC_FORMAT );
    
    NUMBERIC_ENT = new Crestron.Logos.SplusObjects.DigitalInput( NUMBERIC_ENT__DigitalInput__, this );
    m_DigitalInputList.Add( NUMBERIC_ENT__DigitalInput__, NUMBERIC_ENT );
    
    DISPLAY = new Crestron.Logos.SplusObjects.DigitalInput( DISPLAY__DigitalInput__, this );
    m_DigitalInputList.Add( DISPLAY__DigitalInput__, DISPLAY );
    
    MENU = new Crestron.Logos.SplusObjects.DigitalInput( MENU__DigitalInput__, this );
    m_DigitalInputList.Add( MENU__DigitalInput__, MENU );
    
    EXIT = new Crestron.Logos.SplusObjects.DigitalInput( EXIT__DigitalInput__, this );
    m_DigitalInputList.Add( EXIT__DigitalInput__, EXIT );
    
    AUTOSETUP = new Crestron.Logos.SplusObjects.DigitalInput( AUTOSETUP__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOSETUP__DigitalInput__, AUTOSETUP );
    
    UP = new Crestron.Logos.SplusObjects.DigitalInput( UP__DigitalInput__, this );
    m_DigitalInputList.Add( UP__DigitalInput__, UP );
    
    DOWN = new Crestron.Logos.SplusObjects.DigitalInput( DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( DOWN__DigitalInput__, DOWN );
    
    LEFT_D = new Crestron.Logos.SplusObjects.DigitalInput( LEFT_D__DigitalInput__, this );
    m_DigitalInputList.Add( LEFT_D__DigitalInput__, LEFT_D );
    
    RIGHT_D = new Crestron.Logos.SplusObjects.DigitalInput( RIGHT_D__DigitalInput__, this );
    m_DigitalInputList.Add( RIGHT_D__DigitalInput__, RIGHT_D );
    
    SET = new Crestron.Logos.SplusObjects.DigitalInput( SET__DigitalInput__, this );
    m_DigitalInputList.Add( SET__DigitalInput__, SET );
    
    PICTURE_MODE = new Crestron.Logos.SplusObjects.DigitalInput( PICTURE_MODE__DigitalInput__, this );
    m_DigitalInputList.Add( PICTURE_MODE__DigitalInput__, PICTURE_MODE );
    
    ASPECT = new Crestron.Logos.SplusObjects.DigitalInput( ASPECT__DigitalInput__, this );
    m_DigitalInputList.Add( ASPECT__DigitalInput__, ASPECT );
    
    SOUND = new Crestron.Logos.SplusObjects.DigitalInput( SOUND__DigitalInput__, this );
    m_DigitalInputList.Add( SOUND__DigitalInput__, SOUND );
    
    NUMBERS = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        NUMBERS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( NUMBERS__DigitalInput__ + i, NUMBERS__DigitalInput__, this );
        m_DigitalInputList.Add( NUMBERS__DigitalInput__ + i, NUMBERS[i+1] );
    }
    
    POWER_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_IS_ON__DigitalOutput__, POWER_IS_ON );
    
    POWER_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_IS_OFF__DigitalOutput__, POWER_IS_OFF );
    
    MUTE_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_IS_ON__DigitalOutput__, MUTE_IS_ON );
    
    MUTE_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_IS_OFF__DigitalOutput__, MUTE_IS_OFF );
    
    CONTROL_BUTTON_IS_LOCKED = new Crestron.Logos.SplusObjects.DigitalOutput( CONTROL_BUTTON_IS_LOCKED__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONTROL_BUTTON_IS_LOCKED__DigitalOutput__, CONTROL_BUTTON_IS_LOCKED );
    
    CONTROL_BUTTON_IS_UNLOCKED = new Crestron.Logos.SplusObjects.DigitalOutput( CONTROL_BUTTON_IS_UNLOCKED__DigitalOutput__, this );
    m_DigitalOutputList.Add( CONTROL_BUTTON_IS_UNLOCKED__DigitalOutput__, CONTROL_BUTTON_IS_UNLOCKED );
    
    CHANGE_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( CHANGE_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHANGE_SOURCE__AnalogSerialInput__, CHANGE_SOURCE );
    
    CHANGE_VOLUME_LEVEL = new Crestron.Logos.SplusObjects.AnalogInput( CHANGE_VOLUME_LEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHANGE_VOLUME_LEVEL__AnalogSerialInput__, CHANGE_VOLUME_LEVEL );
    
    CHANGE_TV_CHANNEL = new Crestron.Logos.SplusObjects.AnalogInput( CHANGE_TV_CHANNEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHANGE_TV_CHANNEL__AnalogSerialInput__, CHANGE_TV_CHANNEL );
    
    CHANGE_ANALOG_CLOSED_CAPTION = new Crestron.Logos.SplusObjects.AnalogInput( CHANGE_ANALOG_CLOSED_CAPTION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHANGE_ANALOG_CLOSED_CAPTION__AnalogSerialInput__, CHANGE_ANALOG_CLOSED_CAPTION );
    
    CHANGE_DIGITAL_CLOSED_CAPTION = new Crestron.Logos.SplusObjects.AnalogInput( CHANGE_DIGITAL_CLOSED_CAPTION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHANGE_DIGITAL_CLOSED_CAPTION__AnalogSerialInput__, CHANGE_DIGITAL_CLOSED_CAPTION );
    
    VOLUME_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_ANALOG__AnalogSerialOutput__, VOLUME_ANALOG );
    
    SELECTED_INPUT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTED_INPUT_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTED_INPUT_ANALOG__AnalogSerialOutput__, SELECTED_INPUT_ANALOG );
    
    ANALOG_CLOSED_CAPTION_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( ANALOG_CLOSED_CAPTION_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ANALOG_CLOSED_CAPTION_ANALOG__AnalogSerialOutput__, ANALOG_CLOSED_CAPTION_ANALOG );
    
    DIGITAL_CLOSED_CAPTION_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( DIGITAL_CLOSED_CAPTION_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DIGITAL_CLOSED_CAPTION_ANALOG__AnalogSerialOutput__, DIGITAL_CLOSED_CAPTION_ANALOG );
    
    SELECTED_CHANNEL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_CHANNEL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_CHANNEL_TEXT__AnalogSerialOutput__, SELECTED_CHANNEL_TEXT );
    
    TODEVICE = new Crestron.Logos.SplusObjects.StringOutput( TODEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVICE__AnalogSerialOutput__, TODEVICE );
    
    MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( MESSAGE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MESSAGE__AnalogSerialOutput__, MESSAGE );
    
    FROMDEVICE = new Crestron.Logos.SplusObjects.BufferInput( FROMDEVICE__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( FROMDEVICE__AnalogSerialInput__, FROMDEVICE );
    
    MONITOR_ID = new UShortParameter( MONITOR_ID__Parameter__, this );
    m_ParameterList.Add( MONITOR_ID__Parameter__, MONITOR_ID );
    
    
    POLL_MAIN_INFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_MAIN_INFO_OnPush_0, false ) );
    POLL_MAIN_INFO_NO_VOLUME.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_MAIN_INFO_NO_VOLUME_OnPush_1, false ) );
    TURN_POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( TURN_POWER_ON_OnPush_2, false ) );
    TURN_POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( TURN_POWER_OFF_OnPush_3, false ) );
    TURN_MUTE_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( TURN_MUTE_ON_OnPush_4, false ) );
    TURN_MUTE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( TURN_MUTE_OFF_OnPush_5, false ) );
    SAVE_CURRENT_SETTINGS.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_CURRENT_SETTINGS_OnPush_6, false ) );
    SET_TV_CHANNEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_TV_CHANNEL_OnPush_7, false ) );
    TV_CHANNEL_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( TV_CHANNEL_UP_OnPush_8, false ) );
    TV_CHANNEL_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( TV_CHANNEL_DOWN_OnPush_9, false ) );
    LOCK_CONTROL_BUTTON.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOCK_CONTROL_BUTTON_OnPush_10, false ) );
    UNLOCK_CONTROL_BUTTON.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNLOCK_CONTROL_BUTTON_OnPush_11, false ) );
    TOGGLE_POWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOGGLE_POWER_OnPush_12, false ) );
    TOGGLE_MUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOGGLE_MUTE_OnPush_13, false ) );
    VOL_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOL_UP_OnPush_14, false ) );
    VOL_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOL_DOWN_OnPush_15, false ) );
    GUIDE.OnDigitalPush.Add( new InputChangeHandlerWrapper( GUIDE_OnPush_16, false ) );
    GUIDE.OnDigitalPush.Add( new InputChangeHandlerWrapper( GUIDE_OnPush_17, false ) );
    NUMERIC_FORMAT.OnDigitalPush.Add( new InputChangeHandlerWrapper( NUMERIC_FORMAT_OnPush_18, false ) );
    NUMBERIC_ENT.OnDigitalPush.Add( new InputChangeHandlerWrapper( NUMBERIC_ENT_OnPush_19, false ) );
    DISPLAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISPLAY_OnPush_20, false ) );
    MENU.OnDigitalPush.Add( new InputChangeHandlerWrapper( MENU_OnPush_21, false ) );
    EXIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EXIT_OnPush_22, false ) );
    AUTOSETUP.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOSETUP_OnPush_23, false ) );
    UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( UP_OnPush_24, false ) );
    DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOWN_OnPush_25, false ) );
    LEFT_D.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEFT_D_OnPush_26, false ) );
    RIGHT_D.OnDigitalPush.Add( new InputChangeHandlerWrapper( RIGHT_D_OnPush_27, false ) );
    SET.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_OnPush_28, false ) );
    PICTURE_MODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PICTURE_MODE_OnPush_29, false ) );
    ASPECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( ASPECT_OnPush_30, false ) );
    SOUND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SOUND_OnPush_31, false ) );
    for( uint i = 0; i < 10; i++ )
        NUMBERS[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( NUMBERS_OnPush_32, false ) );
        
    CHANGE_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( CHANGE_SOURCE_OnChange_33, false ) );
    CHANGE_VOLUME_LEVEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( CHANGE_VOLUME_LEVEL_OnChange_34, false ) );
    CHANGE_TV_CHANNEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( CHANGE_TV_CHANNEL_OnChange_35, false ) );
    CHANGE_ANALOG_CLOSED_CAPTION.OnAnalogChange.Add( new InputChangeHandlerWrapper( CHANGE_ANALOG_CLOSED_CAPTION_OnChange_36, false ) );
    CHANGE_DIGITAL_CLOSED_CAPTION.OnAnalogChange.Add( new InputChangeHandlerWrapper( CHANGE_DIGITAL_CLOSED_CAPTION_OnChange_37, false ) );
    FROMDEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMDEVICE_OnChange_38, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_NEC_MULTISYNC_V1_1_ALT_HDMI3 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_MAIN_INFO__DigitalInput__ = 0;
const uint POLL_MAIN_INFO_NO_VOLUME__DigitalInput__ = 1;
const uint TURN_POWER_ON__DigitalInput__ = 2;
const uint TURN_POWER_OFF__DigitalInput__ = 3;
const uint TURN_MUTE_ON__DigitalInput__ = 4;
const uint TURN_MUTE_OFF__DigitalInput__ = 5;
const uint SAVE_CURRENT_SETTINGS__DigitalInput__ = 6;
const uint SET_TV_CHANNEL__DigitalInput__ = 7;
const uint TV_CHANNEL_UP__DigitalInput__ = 8;
const uint TV_CHANNEL_DOWN__DigitalInput__ = 9;
const uint LOCK_CONTROL_BUTTON__DigitalInput__ = 10;
const uint UNLOCK_CONTROL_BUTTON__DigitalInput__ = 11;
const uint TOGGLE_POWER__DigitalInput__ = 12;
const uint TOGGLE_MUTE__DigitalInput__ = 13;
const uint VOL_UP__DigitalInput__ = 14;
const uint VOL_DOWN__DigitalInput__ = 15;
const uint GUIDE__DigitalInput__ = 16;
const uint NUMERIC_FORMAT__DigitalInput__ = 17;
const uint NUMBERIC_ENT__DigitalInput__ = 18;
const uint DISPLAY__DigitalInput__ = 19;
const uint MENU__DigitalInput__ = 20;
const uint EXIT__DigitalInput__ = 21;
const uint AUTOSETUP__DigitalInput__ = 22;
const uint UP__DigitalInput__ = 23;
const uint DOWN__DigitalInput__ = 24;
const uint LEFT_D__DigitalInput__ = 25;
const uint RIGHT_D__DigitalInput__ = 26;
const uint SET__DigitalInput__ = 27;
const uint PICTURE_MODE__DigitalInput__ = 28;
const uint ASPECT__DigitalInput__ = 29;
const uint SOUND__DigitalInput__ = 30;
const uint NUMBERS__DigitalInput__ = 31;
const uint CHANGE_SOURCE__AnalogSerialInput__ = 0;
const uint CHANGE_VOLUME_LEVEL__AnalogSerialInput__ = 1;
const uint CHANGE_TV_CHANNEL__AnalogSerialInput__ = 2;
const uint CHANGE_ANALOG_CLOSED_CAPTION__AnalogSerialInput__ = 3;
const uint CHANGE_DIGITAL_CLOSED_CAPTION__AnalogSerialInput__ = 4;
const uint FROMDEVICE__AnalogSerialInput__ = 5;
const uint POWER_IS_ON__DigitalOutput__ = 0;
const uint POWER_IS_OFF__DigitalOutput__ = 1;
const uint MUTE_IS_ON__DigitalOutput__ = 2;
const uint MUTE_IS_OFF__DigitalOutput__ = 3;
const uint CONTROL_BUTTON_IS_LOCKED__DigitalOutput__ = 4;
const uint CONTROL_BUTTON_IS_UNLOCKED__DigitalOutput__ = 5;
const uint VOLUME_ANALOG__AnalogSerialOutput__ = 0;
const uint SELECTED_INPUT_ANALOG__AnalogSerialOutput__ = 1;
const uint ANALOG_CLOSED_CAPTION_ANALOG__AnalogSerialOutput__ = 2;
const uint DIGITAL_CLOSED_CAPTION_ANALOG__AnalogSerialOutput__ = 3;
const uint SELECTED_CHANNEL_TEXT__AnalogSerialOutput__ = 4;
const uint TODEVICE__AnalogSerialOutput__ = 5;
const uint MESSAGE__AnalogSerialOutput__ = 6;
const uint MONITOR_ID__Parameter__ = 10;

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
