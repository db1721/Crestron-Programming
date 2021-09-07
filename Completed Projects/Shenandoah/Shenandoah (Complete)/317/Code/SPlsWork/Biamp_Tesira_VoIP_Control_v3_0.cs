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
using BiampTesiraLib3;
using BiampTesiraLib3.Parser;
using BiampTesiraLib3.Components;
using BiampTesiraLib3.Comm;
using BiampTesiraLib3.Model;
using BiampTesiraLib3.Tesira_Support;
using BiampTesiraLib3.CCI_Support;
using CCI_Library;

namespace UserModule_BIAMP_TESIRA_VOIP_CONTROL_V3_0
{
    public class UserModuleClass_BIAMP_TESIRA_VOIP_CONTROL_V3_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL_DIALER;
        Crestron.Logos.SplusObjects.DigitalOutput IS_INITIALIZED;
        Crestron.Logos.SplusObjects.AnalogInput CALL_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput CONFERENCE;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER;
        Crestron.Logos.SplusObjects.DigitalInput FLASH;
        Crestron.Logos.SplusObjects.DigitalInput REDIAL;
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        Crestron.Logos.SplusObjects.DigitalInput END;
        Crestron.Logos.SplusObjects.DigitalInput RESUME;
        Crestron.Logos.SplusObjects.DigitalInput HOLD;
        Crestron.Logos.SplusObjects.DigitalInput ON_HOOK;
        Crestron.Logos.SplusObjects.DigitalInput OFF_HOOK;
        Crestron.Logos.SplusObjects.DigitalInput TRANSFER;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER_CALL_1;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER_CALL_2;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER_CALL_3;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER_CALL_4;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER_CALL_5;
        Crestron.Logos.SplusObjects.DigitalInput ANSWER_CALL_6;
        Crestron.Logos.SplusObjects.DigitalInput HANGUP_CALL_1;
        Crestron.Logos.SplusObjects.DigitalInput HANGUP_CALL_2;
        Crestron.Logos.SplusObjects.DigitalInput HANGUP_CALL_3;
        Crestron.Logos.SplusObjects.DigitalInput HANGUP_CALL_4;
        Crestron.Logos.SplusObjects.DigitalInput HANGUP_CALL_5;
        Crestron.Logos.SplusObjects.DigitalInput HANGUP_CALL_6;
        Crestron.Logos.SplusObjects.DigitalInput HANGUP_ALL;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTED_CALL;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_1_LED;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_2_LED;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_3_LED;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_4_LED;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_5_LED;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_6_LED;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_1_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_2_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_3_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_4_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_5_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CALL_6_STATE;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_STATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_1_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_2_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_3_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_4_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_5_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_CID_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CALL_6_CID_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_0;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_1;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_2;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_3;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_4;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_5;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_6;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_7;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_8;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_9;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_STAR;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_POUND;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_BACKSPACE;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAD_DIAL;
        Crestron.Logos.SplusObjects.StringOutput KEYPAD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LAST_NUMBER_DIALED__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput AUTOANSWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput AUTOANSWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput AUTOANSWER_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput AUTOANSWER_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput AUTOANSWER_IS_OFF;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_01;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_02;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_03;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_04;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_05;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_06;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_07;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_08;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_09;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_10;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_11;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_12;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_13;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_14;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_15;
        Crestron.Logos.SplusObjects.DigitalInput SELECT_DIRECTORY_ITEM_16;
        Crestron.Logos.SplusObjects.DigitalInput DIAL_SELECTED_DIRECTORY_ITEM;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_DIRECTORY_ENTRY;
        Crestron.Logos.SplusObjects.AnalogInput SELECT_DIRECTORY_SAVE_LOCATION;
        Crestron.Logos.SplusObjects.StringInput DIRECTORY_SAVE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput DIRECTORY_SAVE_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput SELECTED_DIRECTORY_ITEM;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_01__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_02__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_03__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_04__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_05__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_06__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_07__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_08__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_09__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_10__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_11__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_12__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_13__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_14__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_15__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NAME_16__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_01__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_02__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_03__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_04__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_05__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_06__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_07__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_08__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_09__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_10__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_11__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_12__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_13__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_14__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_15__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECTORY_NUMBER_16__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput DND_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput DND_DISABLED;
        Crestron.Logos.SplusObjects.DigitalInput DND_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput DND_RESPONSE_DND;
        Crestron.Logos.SplusObjects.DigitalInput DND_RESPONSE_BUSY;
        Crestron.Logos.SplusObjects.DigitalInput DND_RESPONSE_DECLINE;
        Crestron.Logos.SplusObjects.DigitalOutput DND_IS_ENABLED;
        Crestron.Logos.SplusObjects.DigitalOutput DND_RESPONSE_IS_DND;
        Crestron.Logos.SplusObjects.DigitalOutput DND_RESPONSE_IS_BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput DND_RESPONSE_IS_DECLINE;
        Crestron.Logos.SplusObjects.DigitalInput ALPHANUMERIC_ENTRY_DIAL;
        Crestron.Logos.SplusObjects.StringInput ALPHANUMERIC_ENTRY__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        StringParameter DIALER_INSTANCE_TAG;
        StringParameter CONTROL_STATUS_INSTANCE_TAG;
        UShortParameter LINE_NUMBER;
        UShortParameter COMMAND_PROCESSOR_ID;
        BiampTesiraLib3.VoipDialerComponent COMPONENT;
        BiampTesiraLib3.VoipDialerStatus STATUS;
        BiampTesiraLib3.VoipCallStatus MYCALLSTATUS;
        ushort ISREADY = 0;
        public void ONINITIALIZECHANGE ( object __sender__ /*BiampTesiraLib3.VoipDialerComponent SENDER */, BiampTesiraLib3.UInt16EventArgs ARGS ) 
            { 
            VoipDialerComponent  SENDER  = (VoipDialerComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 186;
                IS_INITIALIZED  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONSTATECHANGE ( object __sender__ /*BiampTesiraLib3.VoipDialerComponent SENDER */, BiampTesiraLib3.VoipDialerStatusEventArgs ARGS ) 
            { 
            VoipDialerComponent  SENDER  = (VoipDialerComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 191;
                STATUS =ARGS.Payload; 
                __context__.SourceCodeLine = 193;
                LAST_NUMBER_DIALED__DOLLAR__  .UpdateValue ( STATUS . LastNumber  ) ; 
                __context__.SourceCodeLine = 195;
                AUTOANSWER_IS_ON  .Value = (ushort) ( Functions.BoolToInt (STATUS.IsAutoAnswerOn() == 1) ) ; 
                __context__.SourceCodeLine = 196;
                AUTOANSWER_IS_OFF  .Value = (ushort) ( Functions.BoolToInt (STATUS.IsAutoAnswerOn() == 0) ) ; 
                __context__.SourceCodeLine = 198;
                DND_IS_ENABLED  .Value = (ushort) ( STATUS.IsDNDEnabled() ) ; 
                __context__.SourceCodeLine = 199;
                DND_RESPONSE_IS_DND  .Value = (ushort) ( STATUS.IsDNDResponseModeDND() ) ; 
                __context__.SourceCodeLine = 200;
                DND_RESPONSE_IS_BUSY  .Value = (ushort) ( STATUS.IsDNDResponseModeBusy() ) ; 
                __context__.SourceCodeLine = 201;
                DND_RESPONSE_IS_DECLINE  .Value = (ushort) ( STATUS.IsDNDResponseModeDecline() ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONKEYPADTEXTCHANGE ( object __sender__ /*BiampTesiraLib3.VoipDialerComponent SENDER */, BiampTesiraLib3.StringEventArgs ARGS ) 
            { 
            VoipDialerComponent  SENDER  = (VoipDialerComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 206;
                KEYPAD__DOLLAR__  .UpdateValue ( ARGS . Payload  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONSPEEDDIALSELETION ( object __sender__ /*BiampTesiraLib3.VoipDialerComponent SENDER */, BiampTesiraLib3.SpeedDialItemEventArgs ARGS ) 
            { 
            VoipDialerComponent  SENDER  = (VoipDialerComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 211;
                SELECTED_DIRECTORY_ITEM  .Value = (ushort) ( ARGS.Payload.ID ) ; 
                __context__.SourceCodeLine = 212;
                SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__  .UpdateValue ( ARGS . Payload . Label  ) ; 
                __context__.SourceCodeLine = 213;
                SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__  .UpdateValue ( ARGS . Payload . Number  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONSPEEDDIALITEMCHANGE ( object __sender__ /*BiampTesiraLib3.VoipDialerComponent SENDER */, BiampTesiraLib3.SpeedDialItemEventArgs ARGS ) 
            { 
            VoipDialerComponent  SENDER  = (VoipDialerComponent )__sender__;
            BiampTesiraLib3.SpeedDialItem ITEM;
            ITEM  = new BiampTesiraLib3.SpeedDialItem();
            
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 220;
                ITEM =ARGS.Payload; 
                __context__.SourceCodeLine = 222;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 224;
                    DIRECTORY_NAME_01__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 225;
                    DIRECTORY_NUMBER_01__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 228;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 230;
                    DIRECTORY_NAME_02__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 231;
                    DIRECTORY_NUMBER_02__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 234;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 236;
                    DIRECTORY_NAME_03__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 237;
                    DIRECTORY_NUMBER_03__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 240;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 4))  ) ) 
                    { 
                    __context__.SourceCodeLine = 242;
                    DIRECTORY_NAME_04__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 243;
                    DIRECTORY_NUMBER_04__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 246;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 5))  ) ) 
                    { 
                    __context__.SourceCodeLine = 248;
                    DIRECTORY_NAME_05__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 249;
                    DIRECTORY_NUMBER_05__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 252;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 6))  ) ) 
                    { 
                    __context__.SourceCodeLine = 254;
                    DIRECTORY_NAME_06__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 255;
                    DIRECTORY_NUMBER_06__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 258;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 260;
                    DIRECTORY_NAME_07__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 261;
                    DIRECTORY_NUMBER_07__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 264;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 8))  ) ) 
                    { 
                    __context__.SourceCodeLine = 266;
                    DIRECTORY_NAME_08__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 267;
                    DIRECTORY_NUMBER_08__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 270;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 9))  ) ) 
                    { 
                    __context__.SourceCodeLine = 272;
                    DIRECTORY_NAME_09__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 273;
                    DIRECTORY_NUMBER_09__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 276;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 10))  ) ) 
                    { 
                    __context__.SourceCodeLine = 278;
                    DIRECTORY_NAME_10__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 279;
                    DIRECTORY_NUMBER_10__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 282;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 11))  ) ) 
                    { 
                    __context__.SourceCodeLine = 284;
                    DIRECTORY_NAME_11__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 285;
                    DIRECTORY_NUMBER_11__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 288;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 12))  ) ) 
                    { 
                    __context__.SourceCodeLine = 290;
                    DIRECTORY_NAME_12__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 291;
                    DIRECTORY_NUMBER_12__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 294;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 13))  ) ) 
                    { 
                    __context__.SourceCodeLine = 296;
                    DIRECTORY_NAME_13__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 297;
                    DIRECTORY_NUMBER_13__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 300;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 14))  ) ) 
                    { 
                    __context__.SourceCodeLine = 302;
                    DIRECTORY_NAME_14__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 303;
                    DIRECTORY_NUMBER_14__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 306;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 15))  ) ) 
                    { 
                    __context__.SourceCodeLine = 308;
                    DIRECTORY_NAME_15__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 309;
                    DIRECTORY_NUMBER_15__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                __context__.SourceCodeLine = 312;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEM.ID == 16))  ) ) 
                    { 
                    __context__.SourceCodeLine = 314;
                    DIRECTORY_NAME_16__DOLLAR__  .UpdateValue ( ITEM . Label  ) ; 
                    __context__.SourceCodeLine = 315;
                    DIRECTORY_NUMBER_16__DOLLAR__  .UpdateValue ( ITEM . Number  ) ; 
                    } 
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONCALLCHANGE ( object __sender__ /*BiampTesiraLib3.VoipDialerComponent SENDER */, BiampTesiraLib3.UInt16EventArgs ARGS ) 
            { 
            VoipDialerComponent  SENDER  = (VoipDialerComponent )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 321;
                SELECTED_CALL  .Value = (ushort) ( ARGS.Payload ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void ONCALLSTATUSLISTCHANGE ( object __sender__ /*BiampTesiraLib3.VoipDialerComponent SENDER */, BiampTesiraLib3.VoipCallStatusesEventArgs ARGS ) 
            { 
            VoipDialerComponent  SENDER  = (VoipDialerComponent )__sender__;
            BiampTesiraLib3.VoipCallStatuses STATUSLIST;
            STATUSLIST  = new BiampTesiraLib3.VoipCallStatuses();
            
            BiampTesiraLib3.VoipCallStatus STATUS;
            STATUS  = new BiampTesiraLib3.VoipCallStatus();
            
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 329;
                STATUSLIST =ARGS.Payload; 
                __context__.SourceCodeLine = 331;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUSLIST.Count > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 333;
                    STATUSLIST . Get ( (ushort)( 1 ),   ref  STATUS ) ; 
                    __context__.SourceCodeLine = 335;
                    CALL_1_LED  .Value = (ushort) ( STATUS.LedStatus ) ; 
                    __context__.SourceCodeLine = 336;
                    CALL_1_STATE  .Value = (ushort) ( STATUS.State.Number ) ; 
                    __context__.SourceCodeLine = 337;
                    CALL_1_STATE__DOLLAR__  .UpdateValue ( STATUS . State . Name  ) ; 
                    __context__.SourceCodeLine = 338;
                    CALL_1_PROMPT__DOLLAR__  .UpdateValue ( STATUS . Prompt . Name  ) ; 
                    __context__.SourceCodeLine = 340;
                    CALL_1_CID_NAME__DOLLAR__  .UpdateValue ( STATUS . CidName  ) ; 
                    __context__.SourceCodeLine = 341;
                    CALL_1_CID_NUM__DOLLAR__  .UpdateValue ( STATUS . CidNumber  ) ; 
                    } 
                
                __context__.SourceCodeLine = 344;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUSLIST.Count > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 346;
                    STATUSLIST . Get ( (ushort)( 2 ),   ref  STATUS ) ; 
                    __context__.SourceCodeLine = 348;
                    CALL_2_LED  .Value = (ushort) ( STATUS.LedStatus ) ; 
                    __context__.SourceCodeLine = 349;
                    CALL_2_STATE  .Value = (ushort) ( STATUS.State.Number ) ; 
                    __context__.SourceCodeLine = 350;
                    CALL_2_STATE__DOLLAR__  .UpdateValue ( STATUS . State . Name  ) ; 
                    __context__.SourceCodeLine = 351;
                    CALL_2_PROMPT__DOLLAR__  .UpdateValue ( STATUS . Prompt . Name  ) ; 
                    __context__.SourceCodeLine = 353;
                    CALL_2_CID_NAME__DOLLAR__  .UpdateValue ( STATUS . CidName  ) ; 
                    __context__.SourceCodeLine = 354;
                    CALL_2_CID_NUM__DOLLAR__  .UpdateValue ( STATUS . CidNumber  ) ; 
                    } 
                
                __context__.SourceCodeLine = 357;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUSLIST.Count > 2 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 359;
                    STATUSLIST . Get ( (ushort)( 3 ),   ref  STATUS ) ; 
                    __context__.SourceCodeLine = 361;
                    CALL_3_LED  .Value = (ushort) ( STATUS.LedStatus ) ; 
                    __context__.SourceCodeLine = 362;
                    CALL_3_STATE  .Value = (ushort) ( STATUS.State.Number ) ; 
                    __context__.SourceCodeLine = 363;
                    CALL_3_STATE__DOLLAR__  .UpdateValue ( STATUS . State . Name  ) ; 
                    __context__.SourceCodeLine = 364;
                    CALL_3_PROMPT__DOLLAR__  .UpdateValue ( STATUS . Prompt . Name  ) ; 
                    __context__.SourceCodeLine = 366;
                    CALL_3_CID_NAME__DOLLAR__  .UpdateValue ( STATUS . CidName  ) ; 
                    __context__.SourceCodeLine = 367;
                    CALL_3_CID_NUM__DOLLAR__  .UpdateValue ( STATUS . CidNumber  ) ; 
                    } 
                
                __context__.SourceCodeLine = 370;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUSLIST.Count > 3 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 372;
                    STATUSLIST . Get ( (ushort)( 4 ),   ref  STATUS ) ; 
                    __context__.SourceCodeLine = 374;
                    CALL_4_LED  .Value = (ushort) ( STATUS.LedStatus ) ; 
                    __context__.SourceCodeLine = 375;
                    CALL_4_STATE  .Value = (ushort) ( STATUS.State.Number ) ; 
                    __context__.SourceCodeLine = 376;
                    CALL_4_STATE__DOLLAR__  .UpdateValue ( STATUS . State . Name  ) ; 
                    __context__.SourceCodeLine = 377;
                    CALL_4_PROMPT__DOLLAR__  .UpdateValue ( STATUS . Prompt . Name  ) ; 
                    __context__.SourceCodeLine = 379;
                    CALL_4_CID_NAME__DOLLAR__  .UpdateValue ( STATUS . CidName  ) ; 
                    __context__.SourceCodeLine = 380;
                    CALL_4_CID_NUM__DOLLAR__  .UpdateValue ( STATUS . CidNumber  ) ; 
                    } 
                
                __context__.SourceCodeLine = 383;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUSLIST.Count > 4 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 385;
                    STATUSLIST . Get ( (ushort)( 5 ),   ref  STATUS ) ; 
                    __context__.SourceCodeLine = 387;
                    CALL_5_LED  .Value = (ushort) ( STATUS.LedStatus ) ; 
                    __context__.SourceCodeLine = 388;
                    CALL_5_STATE  .Value = (ushort) ( STATUS.State.Number ) ; 
                    __context__.SourceCodeLine = 389;
                    CALL_5_STATE__DOLLAR__  .UpdateValue ( STATUS . State . Name  ) ; 
                    __context__.SourceCodeLine = 390;
                    CALL_5_PROMPT__DOLLAR__  .UpdateValue ( STATUS . Prompt . Name  ) ; 
                    __context__.SourceCodeLine = 392;
                    CALL_5_CID_NAME__DOLLAR__  .UpdateValue ( STATUS . CidName  ) ; 
                    __context__.SourceCodeLine = 393;
                    CALL_5_CID_NUM__DOLLAR__  .UpdateValue ( STATUS . CidNumber  ) ; 
                    } 
                
                __context__.SourceCodeLine = 396;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATUSLIST.Count > 5 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 398;
                    STATUSLIST . Get ( (ushort)( 6 ),   ref  STATUS ) ; 
                    __context__.SourceCodeLine = 400;
                    CALL_6_LED  .Value = (ushort) ( STATUS.LedStatus ) ; 
                    __context__.SourceCodeLine = 401;
                    CALL_6_STATE  .Value = (ushort) ( STATUS.State.Number ) ; 
                    __context__.SourceCodeLine = 402;
                    CALL_6_STATE__DOLLAR__  .UpdateValue ( STATUS . State . Name  ) ; 
                    __context__.SourceCodeLine = 403;
                    CALL_6_PROMPT__DOLLAR__  .UpdateValue ( STATUS . Prompt . Name  ) ; 
                    __context__.SourceCodeLine = 405;
                    CALL_6_CID_NAME__DOLLAR__  .UpdateValue ( STATUS . CidName  ) ; 
                    __context__.SourceCodeLine = 406;
                    CALL_6_CID_NUM__DOLLAR__  .UpdateValue ( STATUS . CidNumber  ) ; 
                    } 
                
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object POLL_DIALER_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 421;
                COMPONENT . Poll ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CONFERENCE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 430;
            COMPONENT . Conference ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ANSWER_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 435;
        COMPONENT . Answer ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FLASH_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 440;
        COMPONENT . Flash ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REDIAL_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 445;
        COMPONENT . Redial ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 450;
        COMPONENT . Send ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object END_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 455;
        COMPONENT . End ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RESUME_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 460;
        COMPONENT . Resume ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOLD_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 465;
        COMPONENT . Hold ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ON_HOOK_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 470;
        COMPONENT . OnHook ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OFF_HOOK_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 475;
        COMPONENT . OffHook ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TRANSFER_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 480;
        COMPONENT . Transfer ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANSWER_CALL_1_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 489;
        COMPONENT . Answer_Call ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANSWER_CALL_2_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 494;
        COMPONENT . Answer_Call ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANSWER_CALL_3_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 499;
        COMPONENT . Answer_Call ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANSWER_CALL_4_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 504;
        COMPONENT . Answer_Call ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANSWER_CALL_5_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 509;
        COMPONENT . Answer_Call ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ANSWER_CALL_6_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 514;
        COMPONENT . Answer_Call ( (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANGUP_CALL_1_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 519;
        COMPONENT . End_Call ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANGUP_CALL_2_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 524;
        COMPONENT . End_Call ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANGUP_CALL_3_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 529;
        COMPONENT . End_Call ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANGUP_CALL_4_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 534;
        COMPONENT . End_Call ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANGUP_CALL_5_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 539;
        COMPONENT . End_Call ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANGUP_CALL_6_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 544;
        COMPONENT . End_Call ( (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HANGUP_ALL_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 549;
        COMPONENT . End_All ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOANSWER_ON_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 558;
        COMPONENT . AutoAnswer ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOANSWER_OFF_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 563;
        COMPONENT . AutoAnswer ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTOANSWER_TOGGLE_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 568;
        COMPONENT . AutoAnswerToggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_ENABLED_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 576;
        COMPONENT . DNDEnable ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_DISABLED_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 581;
        COMPONENT . DNDEnable ( (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_TOGGLE_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 586;
        COMPONENT . DNDEnableToggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_RESPONSE_DND_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 591;
        COMPONENT . DNDResponseDND ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_RESPONSE_BUSY_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 596;
        COMPONENT . DNDResponseBusy ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DND_RESPONSE_DECLINE_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 601;
        COMPONENT . DNDResponseDecline ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_0_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 610;
        COMPONENT . DialDigit ( "0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_1_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 615;
        COMPONENT . DialDigit ( "1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_2_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 620;
        COMPONENT . DialDigit ( "2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_3_OnPush_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 625;
        COMPONENT . DialDigit ( "3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_4_OnPush_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 630;
        COMPONENT . DialDigit ( "4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_5_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 635;
        COMPONENT . DialDigit ( "5") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_6_OnPush_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 640;
        COMPONENT . DialDigit ( "6") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_7_OnPush_41 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 645;
        COMPONENT . DialDigit ( "7") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_8_OnPush_42 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 650;
        COMPONENT . DialDigit ( "8") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_9_OnPush_43 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 655;
        COMPONENT . DialDigit ( "9") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_STAR_OnPush_44 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 660;
        COMPONENT . DialDigit ( "*") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_POUND_OnPush_45 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 665;
        COMPONENT . DialDigit ( "#") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_CLEAR_OnPush_46 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 670;
        COMPONENT . ClearKeypadText ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_BACKSPACE_OnPush_47 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 675;
        COMPONENT . BackspaceKeypadText ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAD_DIAL_OnPush_48 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 680;
        COMPONENT . DialKeypadText ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALPHANUMERIC_ENTRY_DIAL_OnPush_49 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 688;
        COMPONENT . Dial ( ALPHANUMERIC_ENTRY__DOLLAR__ .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_01_OnPush_50 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 696;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_02_OnPush_51 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 701;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_03_OnPush_52 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 706;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_04_OnPush_53 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 711;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_05_OnPush_54 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 716;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_06_OnPush_55 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 721;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_07_OnPush_56 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 726;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_08_OnPush_57 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 731;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 8 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_09_OnPush_58 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 736;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 9 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_10_OnPush_59 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 741;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 10 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_11_OnPush_60 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 746;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 11 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_12_OnPush_61 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 751;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 12 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_13_OnPush_62 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 756;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 13 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_14_OnPush_63 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 761;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 14 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_15_OnPush_64 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 766;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 15 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_DIRECTORY_ITEM_16_OnPush_65 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 771;
        COMPONENT . SelectSpeedDialEntry ( (ushort)( 16 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIAL_SELECTED_DIRECTORY_ITEM_OnPush_66 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 776;
        COMPONENT . DialSpeedDialEntry ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_DIRECTORY_ENTRY_OnPush_67 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 784;
        COMPONENT . SaveSpeedDialEntry ( (ushort)( SELECT_DIRECTORY_SAVE_LOCATION  .UshortValue ), DIRECTORY_SAVE_NAME__DOLLAR__ .ToString(), DIRECTORY_SAVE_NUM__DOLLAR__ .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CALL_SELECT_OnChange_68 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 792;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CALL_SELECT  .UshortValue <= 6 ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 793;
            COMPONENT . CallSelect ( (ushort)( CALL_SELECT  .UshortValue )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnPush_69 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 801;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            {
            __context__.SourceCodeLine = 802;
            COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), DIALER_INSTANCE_TAG  .ToString(), CONTROL_STATUS_INSTANCE_TAG  .ToString(), (ushort)( LINE_NUMBER  .Value )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENABLE_OnRelease_70 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 806;
        if ( Functions.TestForTrue  ( ( ISREADY)  ) ) 
            {
            __context__.SourceCodeLine = 807;
            COMPONENT . UnRegister ( ) ; 
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
        
        __context__.SourceCodeLine = 817;
        ISREADY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 819;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 820;
        // RegisterEvent( COMPONENT , ONINITIALIZECHANGE , ONINITIALIZECHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnInitializeChange  += ONINITIALIZECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 821;
        // RegisterEvent( COMPONENT , ONSTATECHANGE , ONSTATECHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnStateChange  += ONSTATECHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 822;
        // RegisterEvent( COMPONENT , ONKEYPADTEXTCHANGE , ONKEYPADTEXTCHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnKeypadTextChange  += ONKEYPADTEXTCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 823;
        // RegisterEvent( COMPONENT , ONSPEEDDIALITEMCHANGE , ONSPEEDDIALITEMCHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnSpeedDialItemChange  += ONSPEEDDIALITEMCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 824;
        // RegisterEvent( COMPONENT , ONCALLCHANGE , ONCALLCHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnCallChange  += ONCALLCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 825;
        // RegisterEvent( COMPONENT , ONCALLSTATUSLISTCHANGE , ONCALLSTATUSLISTCHANGE ) 
        try { g_criticalSection.Enter(); COMPONENT .OnCallStatusListChange  += ONCALLSTATUSLISTCHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 826;
        // RegisterEvent( COMPONENT , ONSPEEDDIALSELETION , ONSPEEDDIALSELETION ) 
        try { g_criticalSection.Enter(); COMPONENT .OnSpeedDialSeletion  += ONSPEEDDIALSELETION; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 828;
        if ( Functions.TestForTrue  ( ( ENABLE  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 829;
            COMPONENT . Configure ( (ushort)( COMMAND_PROCESSOR_ID  .Value ), DIALER_INSTANCE_TAG  .ToString(), CONTROL_STATUS_INSTANCE_TAG  .ToString(), (ushort)( LINE_NUMBER  .Value )) ; 
            }
        
        __context__.SourceCodeLine = 831;
        ISREADY = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    POLL_DIALER = new Crestron.Logos.SplusObjects.DigitalInput( POLL_DIALER__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_DIALER__DigitalInput__, POLL_DIALER );
    
    CONFERENCE = new Crestron.Logos.SplusObjects.DigitalInput( CONFERENCE__DigitalInput__, this );
    m_DigitalInputList.Add( CONFERENCE__DigitalInput__, CONFERENCE );
    
    ANSWER = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER__DigitalInput__, ANSWER );
    
    FLASH = new Crestron.Logos.SplusObjects.DigitalInput( FLASH__DigitalInput__, this );
    m_DigitalInputList.Add( FLASH__DigitalInput__, FLASH );
    
    REDIAL = new Crestron.Logos.SplusObjects.DigitalInput( REDIAL__DigitalInput__, this );
    m_DigitalInputList.Add( REDIAL__DigitalInput__, REDIAL );
    
    SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
    m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
    
    END = new Crestron.Logos.SplusObjects.DigitalInput( END__DigitalInput__, this );
    m_DigitalInputList.Add( END__DigitalInput__, END );
    
    RESUME = new Crestron.Logos.SplusObjects.DigitalInput( RESUME__DigitalInput__, this );
    m_DigitalInputList.Add( RESUME__DigitalInput__, RESUME );
    
    HOLD = new Crestron.Logos.SplusObjects.DigitalInput( HOLD__DigitalInput__, this );
    m_DigitalInputList.Add( HOLD__DigitalInput__, HOLD );
    
    ON_HOOK = new Crestron.Logos.SplusObjects.DigitalInput( ON_HOOK__DigitalInput__, this );
    m_DigitalInputList.Add( ON_HOOK__DigitalInput__, ON_HOOK );
    
    OFF_HOOK = new Crestron.Logos.SplusObjects.DigitalInput( OFF_HOOK__DigitalInput__, this );
    m_DigitalInputList.Add( OFF_HOOK__DigitalInput__, OFF_HOOK );
    
    TRANSFER = new Crestron.Logos.SplusObjects.DigitalInput( TRANSFER__DigitalInput__, this );
    m_DigitalInputList.Add( TRANSFER__DigitalInput__, TRANSFER );
    
    ANSWER_CALL_1 = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER_CALL_1__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER_CALL_1__DigitalInput__, ANSWER_CALL_1 );
    
    ANSWER_CALL_2 = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER_CALL_2__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER_CALL_2__DigitalInput__, ANSWER_CALL_2 );
    
    ANSWER_CALL_3 = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER_CALL_3__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER_CALL_3__DigitalInput__, ANSWER_CALL_3 );
    
    ANSWER_CALL_4 = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER_CALL_4__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER_CALL_4__DigitalInput__, ANSWER_CALL_4 );
    
    ANSWER_CALL_5 = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER_CALL_5__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER_CALL_5__DigitalInput__, ANSWER_CALL_5 );
    
    ANSWER_CALL_6 = new Crestron.Logos.SplusObjects.DigitalInput( ANSWER_CALL_6__DigitalInput__, this );
    m_DigitalInputList.Add( ANSWER_CALL_6__DigitalInput__, ANSWER_CALL_6 );
    
    HANGUP_CALL_1 = new Crestron.Logos.SplusObjects.DigitalInput( HANGUP_CALL_1__DigitalInput__, this );
    m_DigitalInputList.Add( HANGUP_CALL_1__DigitalInput__, HANGUP_CALL_1 );
    
    HANGUP_CALL_2 = new Crestron.Logos.SplusObjects.DigitalInput( HANGUP_CALL_2__DigitalInput__, this );
    m_DigitalInputList.Add( HANGUP_CALL_2__DigitalInput__, HANGUP_CALL_2 );
    
    HANGUP_CALL_3 = new Crestron.Logos.SplusObjects.DigitalInput( HANGUP_CALL_3__DigitalInput__, this );
    m_DigitalInputList.Add( HANGUP_CALL_3__DigitalInput__, HANGUP_CALL_3 );
    
    HANGUP_CALL_4 = new Crestron.Logos.SplusObjects.DigitalInput( HANGUP_CALL_4__DigitalInput__, this );
    m_DigitalInputList.Add( HANGUP_CALL_4__DigitalInput__, HANGUP_CALL_4 );
    
    HANGUP_CALL_5 = new Crestron.Logos.SplusObjects.DigitalInput( HANGUP_CALL_5__DigitalInput__, this );
    m_DigitalInputList.Add( HANGUP_CALL_5__DigitalInput__, HANGUP_CALL_5 );
    
    HANGUP_CALL_6 = new Crestron.Logos.SplusObjects.DigitalInput( HANGUP_CALL_6__DigitalInput__, this );
    m_DigitalInputList.Add( HANGUP_CALL_6__DigitalInput__, HANGUP_CALL_6 );
    
    HANGUP_ALL = new Crestron.Logos.SplusObjects.DigitalInput( HANGUP_ALL__DigitalInput__, this );
    m_DigitalInputList.Add( HANGUP_ALL__DigitalInput__, HANGUP_ALL );
    
    KEYPAD_0 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_0__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_0__DigitalInput__, KEYPAD_0 );
    
    KEYPAD_1 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_1__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_1__DigitalInput__, KEYPAD_1 );
    
    KEYPAD_2 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_2__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_2__DigitalInput__, KEYPAD_2 );
    
    KEYPAD_3 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_3__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_3__DigitalInput__, KEYPAD_3 );
    
    KEYPAD_4 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_4__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_4__DigitalInput__, KEYPAD_4 );
    
    KEYPAD_5 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_5__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_5__DigitalInput__, KEYPAD_5 );
    
    KEYPAD_6 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_6__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_6__DigitalInput__, KEYPAD_6 );
    
    KEYPAD_7 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_7__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_7__DigitalInput__, KEYPAD_7 );
    
    KEYPAD_8 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_8__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_8__DigitalInput__, KEYPAD_8 );
    
    KEYPAD_9 = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_9__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_9__DigitalInput__, KEYPAD_9 );
    
    KEYPAD_STAR = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_STAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_STAR__DigitalInput__, KEYPAD_STAR );
    
    KEYPAD_POUND = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_POUND__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_POUND__DigitalInput__, KEYPAD_POUND );
    
    KEYPAD_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_CLEAR__DigitalInput__, KEYPAD_CLEAR );
    
    KEYPAD_BACKSPACE = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_BACKSPACE__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_BACKSPACE__DigitalInput__, KEYPAD_BACKSPACE );
    
    KEYPAD_DIAL = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAD_DIAL__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAD_DIAL__DigitalInput__, KEYPAD_DIAL );
    
    AUTOANSWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( AUTOANSWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOANSWER_ON__DigitalInput__, AUTOANSWER_ON );
    
    AUTOANSWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( AUTOANSWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOANSWER_OFF__DigitalInput__, AUTOANSWER_OFF );
    
    AUTOANSWER_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( AUTOANSWER_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( AUTOANSWER_TOGGLE__DigitalInput__, AUTOANSWER_TOGGLE );
    
    SELECT_DIRECTORY_ITEM_01 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_01__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_01__DigitalInput__, SELECT_DIRECTORY_ITEM_01 );
    
    SELECT_DIRECTORY_ITEM_02 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_02__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_02__DigitalInput__, SELECT_DIRECTORY_ITEM_02 );
    
    SELECT_DIRECTORY_ITEM_03 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_03__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_03__DigitalInput__, SELECT_DIRECTORY_ITEM_03 );
    
    SELECT_DIRECTORY_ITEM_04 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_04__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_04__DigitalInput__, SELECT_DIRECTORY_ITEM_04 );
    
    SELECT_DIRECTORY_ITEM_05 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_05__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_05__DigitalInput__, SELECT_DIRECTORY_ITEM_05 );
    
    SELECT_DIRECTORY_ITEM_06 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_06__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_06__DigitalInput__, SELECT_DIRECTORY_ITEM_06 );
    
    SELECT_DIRECTORY_ITEM_07 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_07__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_07__DigitalInput__, SELECT_DIRECTORY_ITEM_07 );
    
    SELECT_DIRECTORY_ITEM_08 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_08__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_08__DigitalInput__, SELECT_DIRECTORY_ITEM_08 );
    
    SELECT_DIRECTORY_ITEM_09 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_09__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_09__DigitalInput__, SELECT_DIRECTORY_ITEM_09 );
    
    SELECT_DIRECTORY_ITEM_10 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_10__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_10__DigitalInput__, SELECT_DIRECTORY_ITEM_10 );
    
    SELECT_DIRECTORY_ITEM_11 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_11__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_11__DigitalInput__, SELECT_DIRECTORY_ITEM_11 );
    
    SELECT_DIRECTORY_ITEM_12 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_12__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_12__DigitalInput__, SELECT_DIRECTORY_ITEM_12 );
    
    SELECT_DIRECTORY_ITEM_13 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_13__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_13__DigitalInput__, SELECT_DIRECTORY_ITEM_13 );
    
    SELECT_DIRECTORY_ITEM_14 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_14__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_14__DigitalInput__, SELECT_DIRECTORY_ITEM_14 );
    
    SELECT_DIRECTORY_ITEM_15 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_15__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_15__DigitalInput__, SELECT_DIRECTORY_ITEM_15 );
    
    SELECT_DIRECTORY_ITEM_16 = new Crestron.Logos.SplusObjects.DigitalInput( SELECT_DIRECTORY_ITEM_16__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT_DIRECTORY_ITEM_16__DigitalInput__, SELECT_DIRECTORY_ITEM_16 );
    
    DIAL_SELECTED_DIRECTORY_ITEM = new Crestron.Logos.SplusObjects.DigitalInput( DIAL_SELECTED_DIRECTORY_ITEM__DigitalInput__, this );
    m_DigitalInputList.Add( DIAL_SELECTED_DIRECTORY_ITEM__DigitalInput__, DIAL_SELECTED_DIRECTORY_ITEM );
    
    SAVE_DIRECTORY_ENTRY = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_DIRECTORY_ENTRY__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE_DIRECTORY_ENTRY__DigitalInput__, SAVE_DIRECTORY_ENTRY );
    
    DND_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( DND_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( DND_ENABLED__DigitalInput__, DND_ENABLED );
    
    DND_DISABLED = new Crestron.Logos.SplusObjects.DigitalInput( DND_DISABLED__DigitalInput__, this );
    m_DigitalInputList.Add( DND_DISABLED__DigitalInput__, DND_DISABLED );
    
    DND_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( DND_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( DND_TOGGLE__DigitalInput__, DND_TOGGLE );
    
    DND_RESPONSE_DND = new Crestron.Logos.SplusObjects.DigitalInput( DND_RESPONSE_DND__DigitalInput__, this );
    m_DigitalInputList.Add( DND_RESPONSE_DND__DigitalInput__, DND_RESPONSE_DND );
    
    DND_RESPONSE_BUSY = new Crestron.Logos.SplusObjects.DigitalInput( DND_RESPONSE_BUSY__DigitalInput__, this );
    m_DigitalInputList.Add( DND_RESPONSE_BUSY__DigitalInput__, DND_RESPONSE_BUSY );
    
    DND_RESPONSE_DECLINE = new Crestron.Logos.SplusObjects.DigitalInput( DND_RESPONSE_DECLINE__DigitalInput__, this );
    m_DigitalInputList.Add( DND_RESPONSE_DECLINE__DigitalInput__, DND_RESPONSE_DECLINE );
    
    ALPHANUMERIC_ENTRY_DIAL = new Crestron.Logos.SplusObjects.DigitalInput( ALPHANUMERIC_ENTRY_DIAL__DigitalInput__, this );
    m_DigitalInputList.Add( ALPHANUMERIC_ENTRY_DIAL__DigitalInput__, ALPHANUMERIC_ENTRY_DIAL );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    IS_INITIALIZED = new Crestron.Logos.SplusObjects.DigitalOutput( IS_INITIALIZED__DigitalOutput__, this );
    m_DigitalOutputList.Add( IS_INITIALIZED__DigitalOutput__, IS_INITIALIZED );
    
    AUTOANSWER_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( AUTOANSWER_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTOANSWER_IS_ON__DigitalOutput__, AUTOANSWER_IS_ON );
    
    AUTOANSWER_IS_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( AUTOANSWER_IS_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( AUTOANSWER_IS_OFF__DigitalOutput__, AUTOANSWER_IS_OFF );
    
    DND_IS_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DND_IS_ENABLED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_IS_ENABLED__DigitalOutput__, DND_IS_ENABLED );
    
    DND_RESPONSE_IS_DND = new Crestron.Logos.SplusObjects.DigitalOutput( DND_RESPONSE_IS_DND__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_RESPONSE_IS_DND__DigitalOutput__, DND_RESPONSE_IS_DND );
    
    DND_RESPONSE_IS_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( DND_RESPONSE_IS_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_RESPONSE_IS_BUSY__DigitalOutput__, DND_RESPONSE_IS_BUSY );
    
    DND_RESPONSE_IS_DECLINE = new Crestron.Logos.SplusObjects.DigitalOutput( DND_RESPONSE_IS_DECLINE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DND_RESPONSE_IS_DECLINE__DigitalOutput__, DND_RESPONSE_IS_DECLINE );
    
    CALL_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( CALL_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CALL_SELECT__AnalogSerialInput__, CALL_SELECT );
    
    SELECT_DIRECTORY_SAVE_LOCATION = new Crestron.Logos.SplusObjects.AnalogInput( SELECT_DIRECTORY_SAVE_LOCATION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECT_DIRECTORY_SAVE_LOCATION__AnalogSerialInput__, SELECT_DIRECTORY_SAVE_LOCATION );
    
    SELECTED_CALL = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTED_CALL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTED_CALL__AnalogSerialOutput__, SELECTED_CALL );
    
    CALL_1_LED = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_1_LED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_1_LED__AnalogSerialOutput__, CALL_1_LED );
    
    CALL_2_LED = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_2_LED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_2_LED__AnalogSerialOutput__, CALL_2_LED );
    
    CALL_3_LED = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_3_LED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_3_LED__AnalogSerialOutput__, CALL_3_LED );
    
    CALL_4_LED = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_4_LED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_4_LED__AnalogSerialOutput__, CALL_4_LED );
    
    CALL_5_LED = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_5_LED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_5_LED__AnalogSerialOutput__, CALL_5_LED );
    
    CALL_6_LED = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_6_LED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_6_LED__AnalogSerialOutput__, CALL_6_LED );
    
    CALL_1_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_1_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_1_STATE__AnalogSerialOutput__, CALL_1_STATE );
    
    CALL_2_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_2_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_2_STATE__AnalogSerialOutput__, CALL_2_STATE );
    
    CALL_3_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_3_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_3_STATE__AnalogSerialOutput__, CALL_3_STATE );
    
    CALL_4_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_4_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_4_STATE__AnalogSerialOutput__, CALL_4_STATE );
    
    CALL_5_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_5_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_5_STATE__AnalogSerialOutput__, CALL_5_STATE );
    
    CALL_6_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CALL_6_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CALL_6_STATE__AnalogSerialOutput__, CALL_6_STATE );
    
    SELECTED_DIRECTORY_ITEM = new Crestron.Logos.SplusObjects.AnalogOutput( SELECTED_DIRECTORY_ITEM__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SELECTED_DIRECTORY_ITEM__AnalogSerialOutput__, SELECTED_DIRECTORY_ITEM );
    
    DIRECTORY_SAVE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DIRECTORY_SAVE_NAME__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( DIRECTORY_SAVE_NAME__DOLLAR____AnalogSerialInput__, DIRECTORY_SAVE_NAME__DOLLAR__ );
    
    DIRECTORY_SAVE_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( DIRECTORY_SAVE_NUM__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( DIRECTORY_SAVE_NUM__DOLLAR____AnalogSerialInput__, DIRECTORY_SAVE_NUM__DOLLAR__ );
    
    ALPHANUMERIC_ENTRY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( ALPHANUMERIC_ENTRY__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( ALPHANUMERIC_ENTRY__DOLLAR____AnalogSerialInput__, ALPHANUMERIC_ENTRY__DOLLAR__ );
    
    CALL_1_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_STATE__DOLLAR____AnalogSerialOutput__, CALL_1_STATE__DOLLAR__ );
    
    CALL_2_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_STATE__DOLLAR____AnalogSerialOutput__, CALL_2_STATE__DOLLAR__ );
    
    CALL_3_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_STATE__DOLLAR____AnalogSerialOutput__, CALL_3_STATE__DOLLAR__ );
    
    CALL_4_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_STATE__DOLLAR____AnalogSerialOutput__, CALL_4_STATE__DOLLAR__ );
    
    CALL_5_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_STATE__DOLLAR____AnalogSerialOutput__, CALL_5_STATE__DOLLAR__ );
    
    CALL_6_STATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_STATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_STATE__DOLLAR____AnalogSerialOutput__, CALL_6_STATE__DOLLAR__ );
    
    CALL_1_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_1_PROMPT__DOLLAR__ );
    
    CALL_2_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_2_PROMPT__DOLLAR__ );
    
    CALL_3_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_3_PROMPT__DOLLAR__ );
    
    CALL_4_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_4_PROMPT__DOLLAR__ );
    
    CALL_5_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_5_PROMPT__DOLLAR__ );
    
    CALL_6_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_PROMPT__DOLLAR____AnalogSerialOutput__, CALL_6_PROMPT__DOLLAR__ );
    
    CALL_1_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_1_CID_NAME__DOLLAR__ );
    
    CALL_1_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_1_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_1_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_1_CID_NUM__DOLLAR__ );
    
    CALL_2_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_2_CID_NAME__DOLLAR__ );
    
    CALL_2_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_2_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_2_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_2_CID_NUM__DOLLAR__ );
    
    CALL_3_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_3_CID_NAME__DOLLAR__ );
    
    CALL_3_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_3_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_3_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_3_CID_NUM__DOLLAR__ );
    
    CALL_4_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_4_CID_NAME__DOLLAR__ );
    
    CALL_4_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_4_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_4_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_4_CID_NUM__DOLLAR__ );
    
    CALL_5_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_5_CID_NAME__DOLLAR__ );
    
    CALL_5_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_5_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_5_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_5_CID_NUM__DOLLAR__ );
    
    CALL_6_CID_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_CID_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_CID_NAME__DOLLAR____AnalogSerialOutput__, CALL_6_CID_NAME__DOLLAR__ );
    
    CALL_6_CID_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CALL_6_CID_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CALL_6_CID_NUM__DOLLAR____AnalogSerialOutput__, CALL_6_CID_NUM__DOLLAR__ );
    
    KEYPAD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( KEYPAD__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( KEYPAD__DOLLAR____AnalogSerialOutput__, KEYPAD__DOLLAR__ );
    
    LAST_NUMBER_DIALED__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LAST_NUMBER_DIALED__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LAST_NUMBER_DIALED__DOLLAR____AnalogSerialOutput__, LAST_NUMBER_DIALED__DOLLAR__ );
    
    DIRECTORY_NAME_01__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_01__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_01__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_01__DOLLAR__ );
    
    DIRECTORY_NAME_02__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_02__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_02__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_02__DOLLAR__ );
    
    DIRECTORY_NAME_03__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_03__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_03__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_03__DOLLAR__ );
    
    DIRECTORY_NAME_04__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_04__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_04__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_04__DOLLAR__ );
    
    DIRECTORY_NAME_05__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_05__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_05__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_05__DOLLAR__ );
    
    DIRECTORY_NAME_06__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_06__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_06__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_06__DOLLAR__ );
    
    DIRECTORY_NAME_07__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_07__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_07__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_07__DOLLAR__ );
    
    DIRECTORY_NAME_08__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_08__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_08__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_08__DOLLAR__ );
    
    DIRECTORY_NAME_09__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_09__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_09__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_09__DOLLAR__ );
    
    DIRECTORY_NAME_10__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_10__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_10__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_10__DOLLAR__ );
    
    DIRECTORY_NAME_11__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_11__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_11__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_11__DOLLAR__ );
    
    DIRECTORY_NAME_12__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_12__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_12__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_12__DOLLAR__ );
    
    DIRECTORY_NAME_13__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_13__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_13__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_13__DOLLAR__ );
    
    DIRECTORY_NAME_14__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_14__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_14__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_14__DOLLAR__ );
    
    DIRECTORY_NAME_15__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_15__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_15__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_15__DOLLAR__ );
    
    DIRECTORY_NAME_16__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NAME_16__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NAME_16__DOLLAR____AnalogSerialOutput__, DIRECTORY_NAME_16__DOLLAR__ );
    
    DIRECTORY_NUMBER_01__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_01__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_01__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_01__DOLLAR__ );
    
    DIRECTORY_NUMBER_02__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_02__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_02__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_02__DOLLAR__ );
    
    DIRECTORY_NUMBER_03__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_03__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_03__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_03__DOLLAR__ );
    
    DIRECTORY_NUMBER_04__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_04__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_04__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_04__DOLLAR__ );
    
    DIRECTORY_NUMBER_05__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_05__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_05__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_05__DOLLAR__ );
    
    DIRECTORY_NUMBER_06__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_06__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_06__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_06__DOLLAR__ );
    
    DIRECTORY_NUMBER_07__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_07__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_07__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_07__DOLLAR__ );
    
    DIRECTORY_NUMBER_08__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_08__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_08__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_08__DOLLAR__ );
    
    DIRECTORY_NUMBER_09__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_09__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_09__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_09__DOLLAR__ );
    
    DIRECTORY_NUMBER_10__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_10__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_10__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_10__DOLLAR__ );
    
    DIRECTORY_NUMBER_11__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_11__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_11__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_11__DOLLAR__ );
    
    DIRECTORY_NUMBER_12__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_12__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_12__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_12__DOLLAR__ );
    
    DIRECTORY_NUMBER_13__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_13__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_13__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_13__DOLLAR__ );
    
    DIRECTORY_NUMBER_14__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_14__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_14__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_14__DOLLAR__ );
    
    DIRECTORY_NUMBER_15__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_15__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_15__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_15__DOLLAR__ );
    
    DIRECTORY_NUMBER_16__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECTORY_NUMBER_16__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECTORY_NUMBER_16__DOLLAR____AnalogSerialOutput__, DIRECTORY_NUMBER_16__DOLLAR__ );
    
    SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_DIRECTORY_ITEM_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_DIRECTORY_ITEM_NAME__DOLLAR____AnalogSerialOutput__, SELECTED_DIRECTORY_ITEM_NAME__DOLLAR__ );
    
    SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SELECTED_DIRECTORY_ITEM_NUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SELECTED_DIRECTORY_ITEM_NUM__DOLLAR____AnalogSerialOutput__, SELECTED_DIRECTORY_ITEM_NUM__DOLLAR__ );
    
    LINE_NUMBER = new UShortParameter( LINE_NUMBER__Parameter__, this );
    m_ParameterList.Add( LINE_NUMBER__Parameter__, LINE_NUMBER );
    
    COMMAND_PROCESSOR_ID = new UShortParameter( COMMAND_PROCESSOR_ID__Parameter__, this );
    m_ParameterList.Add( COMMAND_PROCESSOR_ID__Parameter__, COMMAND_PROCESSOR_ID );
    
    DIALER_INSTANCE_TAG = new StringParameter( DIALER_INSTANCE_TAG__Parameter__, this );
    m_ParameterList.Add( DIALER_INSTANCE_TAG__Parameter__, DIALER_INSTANCE_TAG );
    
    CONTROL_STATUS_INSTANCE_TAG = new StringParameter( CONTROL_STATUS_INSTANCE_TAG__Parameter__, this );
    m_ParameterList.Add( CONTROL_STATUS_INSTANCE_TAG__Parameter__, CONTROL_STATUS_INSTANCE_TAG );
    
    
    POLL_DIALER.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_DIALER_OnPush_0, true ) );
    CONFERENCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONFERENCE_OnPush_1, true ) );
    ANSWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_OnPush_2, true ) );
    FLASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( FLASH_OnPush_3, true ) );
    REDIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( REDIAL_OnPush_4, true ) );
    SEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_OnPush_5, true ) );
    END.OnDigitalPush.Add( new InputChangeHandlerWrapper( END_OnPush_6, true ) );
    RESUME.OnDigitalPush.Add( new InputChangeHandlerWrapper( RESUME_OnPush_7, true ) );
    HOLD.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOLD_OnPush_8, true ) );
    ON_HOOK.OnDigitalPush.Add( new InputChangeHandlerWrapper( ON_HOOK_OnPush_9, true ) );
    OFF_HOOK.OnDigitalPush.Add( new InputChangeHandlerWrapper( OFF_HOOK_OnPush_10, true ) );
    TRANSFER.OnDigitalPush.Add( new InputChangeHandlerWrapper( TRANSFER_OnPush_11, true ) );
    ANSWER_CALL_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_CALL_1_OnPush_12, true ) );
    ANSWER_CALL_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_CALL_2_OnPush_13, true ) );
    ANSWER_CALL_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_CALL_3_OnPush_14, true ) );
    ANSWER_CALL_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_CALL_4_OnPush_15, true ) );
    ANSWER_CALL_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_CALL_5_OnPush_16, true ) );
    ANSWER_CALL_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( ANSWER_CALL_6_OnPush_17, true ) );
    HANGUP_CALL_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( HANGUP_CALL_1_OnPush_18, true ) );
    HANGUP_CALL_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( HANGUP_CALL_2_OnPush_19, true ) );
    HANGUP_CALL_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( HANGUP_CALL_3_OnPush_20, true ) );
    HANGUP_CALL_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( HANGUP_CALL_4_OnPush_21, true ) );
    HANGUP_CALL_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( HANGUP_CALL_5_OnPush_22, true ) );
    HANGUP_CALL_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( HANGUP_CALL_6_OnPush_23, true ) );
    HANGUP_ALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( HANGUP_ALL_OnPush_24, true ) );
    AUTOANSWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOANSWER_ON_OnPush_25, true ) );
    AUTOANSWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOANSWER_OFF_OnPush_26, true ) );
    AUTOANSWER_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTOANSWER_TOGGLE_OnPush_27, true ) );
    DND_ENABLED.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_ENABLED_OnPush_28, true ) );
    DND_DISABLED.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_DISABLED_OnPush_29, true ) );
    DND_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_TOGGLE_OnPush_30, true ) );
    DND_RESPONSE_DND.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_RESPONSE_DND_OnPush_31, true ) );
    DND_RESPONSE_BUSY.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_RESPONSE_BUSY_OnPush_32, true ) );
    DND_RESPONSE_DECLINE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DND_RESPONSE_DECLINE_OnPush_33, true ) );
    KEYPAD_0.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_0_OnPush_34, true ) );
    KEYPAD_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_1_OnPush_35, true ) );
    KEYPAD_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_2_OnPush_36, true ) );
    KEYPAD_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_3_OnPush_37, true ) );
    KEYPAD_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_4_OnPush_38, true ) );
    KEYPAD_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_5_OnPush_39, true ) );
    KEYPAD_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_6_OnPush_40, true ) );
    KEYPAD_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_7_OnPush_41, true ) );
    KEYPAD_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_8_OnPush_42, true ) );
    KEYPAD_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_9_OnPush_43, true ) );
    KEYPAD_STAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_STAR_OnPush_44, true ) );
    KEYPAD_POUND.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_POUND_OnPush_45, true ) );
    KEYPAD_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_CLEAR_OnPush_46, true ) );
    KEYPAD_BACKSPACE.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_BACKSPACE_OnPush_47, true ) );
    KEYPAD_DIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAD_DIAL_OnPush_48, true ) );
    ALPHANUMERIC_ENTRY_DIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( ALPHANUMERIC_ENTRY_DIAL_OnPush_49, true ) );
    SELECT_DIRECTORY_ITEM_01.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_01_OnPush_50, true ) );
    SELECT_DIRECTORY_ITEM_02.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_02_OnPush_51, true ) );
    SELECT_DIRECTORY_ITEM_03.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_03_OnPush_52, true ) );
    SELECT_DIRECTORY_ITEM_04.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_04_OnPush_53, true ) );
    SELECT_DIRECTORY_ITEM_05.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_05_OnPush_54, true ) );
    SELECT_DIRECTORY_ITEM_06.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_06_OnPush_55, true ) );
    SELECT_DIRECTORY_ITEM_07.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_07_OnPush_56, true ) );
    SELECT_DIRECTORY_ITEM_08.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_08_OnPush_57, true ) );
    SELECT_DIRECTORY_ITEM_09.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_09_OnPush_58, true ) );
    SELECT_DIRECTORY_ITEM_10.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_10_OnPush_59, true ) );
    SELECT_DIRECTORY_ITEM_11.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_11_OnPush_60, true ) );
    SELECT_DIRECTORY_ITEM_12.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_12_OnPush_61, true ) );
    SELECT_DIRECTORY_ITEM_13.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_13_OnPush_62, true ) );
    SELECT_DIRECTORY_ITEM_14.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_14_OnPush_63, true ) );
    SELECT_DIRECTORY_ITEM_15.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_15_OnPush_64, true ) );
    SELECT_DIRECTORY_ITEM_16.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_DIRECTORY_ITEM_16_OnPush_65, true ) );
    DIAL_SELECTED_DIRECTORY_ITEM.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIAL_SELECTED_DIRECTORY_ITEM_OnPush_66, true ) );
    SAVE_DIRECTORY_ENTRY.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_DIRECTORY_ENTRY_OnPush_67, true ) );
    CALL_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( CALL_SELECT_OnChange_68, true ) );
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_69, true ) );
    ENABLE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( ENABLE_OnRelease_70, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    COMPONENT  = new BiampTesiraLib3.VoipDialerComponent();
    STATUS  = new BiampTesiraLib3.VoipDialerStatus();
    MYCALLSTATUS  = new BiampTesiraLib3.VoipCallStatus();
    
    
}

public UserModuleClass_BIAMP_TESIRA_VOIP_CONTROL_V3_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL_DIALER__DigitalInput__ = 0;
const uint IS_INITIALIZED__DigitalOutput__ = 0;
const uint CALL_SELECT__AnalogSerialInput__ = 0;
const uint CONFERENCE__DigitalInput__ = 1;
const uint ANSWER__DigitalInput__ = 2;
const uint FLASH__DigitalInput__ = 3;
const uint REDIAL__DigitalInput__ = 4;
const uint SEND__DigitalInput__ = 5;
const uint END__DigitalInput__ = 6;
const uint RESUME__DigitalInput__ = 7;
const uint HOLD__DigitalInput__ = 8;
const uint ON_HOOK__DigitalInput__ = 9;
const uint OFF_HOOK__DigitalInput__ = 10;
const uint TRANSFER__DigitalInput__ = 11;
const uint ANSWER_CALL_1__DigitalInput__ = 12;
const uint ANSWER_CALL_2__DigitalInput__ = 13;
const uint ANSWER_CALL_3__DigitalInput__ = 14;
const uint ANSWER_CALL_4__DigitalInput__ = 15;
const uint ANSWER_CALL_5__DigitalInput__ = 16;
const uint ANSWER_CALL_6__DigitalInput__ = 17;
const uint HANGUP_CALL_1__DigitalInput__ = 18;
const uint HANGUP_CALL_2__DigitalInput__ = 19;
const uint HANGUP_CALL_3__DigitalInput__ = 20;
const uint HANGUP_CALL_4__DigitalInput__ = 21;
const uint HANGUP_CALL_5__DigitalInput__ = 22;
const uint HANGUP_CALL_6__DigitalInput__ = 23;
const uint HANGUP_ALL__DigitalInput__ = 24;
const uint SELECTED_CALL__AnalogSerialOutput__ = 0;
const uint CALL_1_LED__AnalogSerialOutput__ = 1;
const uint CALL_2_LED__AnalogSerialOutput__ = 2;
const uint CALL_3_LED__AnalogSerialOutput__ = 3;
const uint CALL_4_LED__AnalogSerialOutput__ = 4;
const uint CALL_5_LED__AnalogSerialOutput__ = 5;
const uint CALL_6_LED__AnalogSerialOutput__ = 6;
const uint CALL_1_STATE__AnalogSerialOutput__ = 7;
const uint CALL_2_STATE__AnalogSerialOutput__ = 8;
const uint CALL_3_STATE__AnalogSerialOutput__ = 9;
const uint CALL_4_STATE__AnalogSerialOutput__ = 10;
const uint CALL_5_STATE__AnalogSerialOutput__ = 11;
const uint CALL_6_STATE__AnalogSerialOutput__ = 12;
const uint CALL_1_STATE__DOLLAR____AnalogSerialOutput__ = 13;
const uint CALL_2_STATE__DOLLAR____AnalogSerialOutput__ = 14;
const uint CALL_3_STATE__DOLLAR____AnalogSerialOutput__ = 15;
const uint CALL_4_STATE__DOLLAR____AnalogSerialOutput__ = 16;
const uint CALL_5_STATE__DOLLAR____AnalogSerialOutput__ = 17;
const uint CALL_6_STATE__DOLLAR____AnalogSerialOutput__ = 18;
const uint CALL_1_PROMPT__DOLLAR____AnalogSerialOutput__ = 19;
const uint CALL_2_PROMPT__DOLLAR____AnalogSerialOutput__ = 20;
const uint CALL_3_PROMPT__DOLLAR____AnalogSerialOutput__ = 21;
const uint CALL_4_PROMPT__DOLLAR____AnalogSerialOutput__ = 22;
const uint CALL_5_PROMPT__DOLLAR____AnalogSerialOutput__ = 23;
const uint CALL_6_PROMPT__DOLLAR____AnalogSerialOutput__ = 24;
const uint CALL_1_CID_NAME__DOLLAR____AnalogSerialOutput__ = 25;
const uint CALL_1_CID_NUM__DOLLAR____AnalogSerialOutput__ = 26;
const uint CALL_2_CID_NAME__DOLLAR____AnalogSerialOutput__ = 27;
const uint CALL_2_CID_NUM__DOLLAR____AnalogSerialOutput__ = 28;
const uint CALL_3_CID_NAME__DOLLAR____AnalogSerialOutput__ = 29;
const uint CALL_3_CID_NUM__DOLLAR____AnalogSerialOutput__ = 30;
const uint CALL_4_CID_NAME__DOLLAR____AnalogSerialOutput__ = 31;
const uint CALL_4_CID_NUM__DOLLAR____AnalogSerialOutput__ = 32;
const uint CALL_5_CID_NAME__DOLLAR____AnalogSerialOutput__ = 33;
const uint CALL_5_CID_NUM__DOLLAR____AnalogSerialOutput__ = 34;
const uint CALL_6_CID_NAME__DOLLAR____AnalogSerialOutput__ = 35;
const uint CALL_6_CID_NUM__DOLLAR____AnalogSerialOutput__ = 36;
const uint KEYPAD_0__DigitalInput__ = 25;
const uint KEYPAD_1__DigitalInput__ = 26;
const uint KEYPAD_2__DigitalInput__ = 27;
const uint KEYPAD_3__DigitalInput__ = 28;
const uint KEYPAD_4__DigitalInput__ = 29;
const uint KEYPAD_5__DigitalInput__ = 30;
const uint KEYPAD_6__DigitalInput__ = 31;
const uint KEYPAD_7__DigitalInput__ = 32;
const uint KEYPAD_8__DigitalInput__ = 33;
const uint KEYPAD_9__DigitalInput__ = 34;
const uint KEYPAD_STAR__DigitalInput__ = 35;
const uint KEYPAD_POUND__DigitalInput__ = 36;
const uint KEYPAD_CLEAR__DigitalInput__ = 37;
const uint KEYPAD_BACKSPACE__DigitalInput__ = 38;
const uint KEYPAD_DIAL__DigitalInput__ = 39;
const uint KEYPAD__DOLLAR____AnalogSerialOutput__ = 37;
const uint LAST_NUMBER_DIALED__DOLLAR____AnalogSerialOutput__ = 38;
const uint AUTOANSWER_ON__DigitalInput__ = 40;
const uint AUTOANSWER_OFF__DigitalInput__ = 41;
const uint AUTOANSWER_TOGGLE__DigitalInput__ = 42;
const uint AUTOANSWER_IS_ON__DigitalOutput__ = 1;
const uint AUTOANSWER_IS_OFF__DigitalOutput__ = 2;
const uint SELECT_DIRECTORY_ITEM_01__DigitalInput__ = 43;
const uint SELECT_DIRECTORY_ITEM_02__DigitalInput__ = 44;
const uint SELECT_DIRECTORY_ITEM_03__DigitalInput__ = 45;
const uint SELECT_DIRECTORY_ITEM_04__DigitalInput__ = 46;
const uint SELECT_DIRECTORY_ITEM_05__DigitalInput__ = 47;
const uint SELECT_DIRECTORY_ITEM_06__DigitalInput__ = 48;
const uint SELECT_DIRECTORY_ITEM_07__DigitalInput__ = 49;
const uint SELECT_DIRECTORY_ITEM_08__DigitalInput__ = 50;
const uint SELECT_DIRECTORY_ITEM_09__DigitalInput__ = 51;
const uint SELECT_DIRECTORY_ITEM_10__DigitalInput__ = 52;
const uint SELECT_DIRECTORY_ITEM_11__DigitalInput__ = 53;
const uint SELECT_DIRECTORY_ITEM_12__DigitalInput__ = 54;
const uint SELECT_DIRECTORY_ITEM_13__DigitalInput__ = 55;
const uint SELECT_DIRECTORY_ITEM_14__DigitalInput__ = 56;
const uint SELECT_DIRECTORY_ITEM_15__DigitalInput__ = 57;
const uint SELECT_DIRECTORY_ITEM_16__DigitalInput__ = 58;
const uint DIAL_SELECTED_DIRECTORY_ITEM__DigitalInput__ = 59;
const uint SAVE_DIRECTORY_ENTRY__DigitalInput__ = 60;
const uint SELECT_DIRECTORY_SAVE_LOCATION__AnalogSerialInput__ = 1;
const uint DIRECTORY_SAVE_NAME__DOLLAR____AnalogSerialInput__ = 2;
const uint DIRECTORY_SAVE_NUM__DOLLAR____AnalogSerialInput__ = 3;
const uint SELECTED_DIRECTORY_ITEM__AnalogSerialOutput__ = 39;
const uint DIRECTORY_NAME_01__DOLLAR____AnalogSerialOutput__ = 40;
const uint DIRECTORY_NAME_02__DOLLAR____AnalogSerialOutput__ = 41;
const uint DIRECTORY_NAME_03__DOLLAR____AnalogSerialOutput__ = 42;
const uint DIRECTORY_NAME_04__DOLLAR____AnalogSerialOutput__ = 43;
const uint DIRECTORY_NAME_05__DOLLAR____AnalogSerialOutput__ = 44;
const uint DIRECTORY_NAME_06__DOLLAR____AnalogSerialOutput__ = 45;
const uint DIRECTORY_NAME_07__DOLLAR____AnalogSerialOutput__ = 46;
const uint DIRECTORY_NAME_08__DOLLAR____AnalogSerialOutput__ = 47;
const uint DIRECTORY_NAME_09__DOLLAR____AnalogSerialOutput__ = 48;
const uint DIRECTORY_NAME_10__DOLLAR____AnalogSerialOutput__ = 49;
const uint DIRECTORY_NAME_11__DOLLAR____AnalogSerialOutput__ = 50;
const uint DIRECTORY_NAME_12__DOLLAR____AnalogSerialOutput__ = 51;
const uint DIRECTORY_NAME_13__DOLLAR____AnalogSerialOutput__ = 52;
const uint DIRECTORY_NAME_14__DOLLAR____AnalogSerialOutput__ = 53;
const uint DIRECTORY_NAME_15__DOLLAR____AnalogSerialOutput__ = 54;
const uint DIRECTORY_NAME_16__DOLLAR____AnalogSerialOutput__ = 55;
const uint DIRECTORY_NUMBER_01__DOLLAR____AnalogSerialOutput__ = 56;
const uint DIRECTORY_NUMBER_02__DOLLAR____AnalogSerialOutput__ = 57;
const uint DIRECTORY_NUMBER_03__DOLLAR____AnalogSerialOutput__ = 58;
const uint DIRECTORY_NUMBER_04__DOLLAR____AnalogSerialOutput__ = 59;
const uint DIRECTORY_NUMBER_05__DOLLAR____AnalogSerialOutput__ = 60;
const uint DIRECTORY_NUMBER_06__DOLLAR____AnalogSerialOutput__ = 61;
const uint DIRECTORY_NUMBER_07__DOLLAR____AnalogSerialOutput__ = 62;
const uint DIRECTORY_NUMBER_08__DOLLAR____AnalogSerialOutput__ = 63;
const uint DIRECTORY_NUMBER_09__DOLLAR____AnalogSerialOutput__ = 64;
const uint DIRECTORY_NUMBER_10__DOLLAR____AnalogSerialOutput__ = 65;
const uint DIRECTORY_NUMBER_11__DOLLAR____AnalogSerialOutput__ = 66;
const uint DIRECTORY_NUMBER_12__DOLLAR____AnalogSerialOutput__ = 67;
const uint DIRECTORY_NUMBER_13__DOLLAR____AnalogSerialOutput__ = 68;
const uint DIRECTORY_NUMBER_14__DOLLAR____AnalogSerialOutput__ = 69;
const uint DIRECTORY_NUMBER_15__DOLLAR____AnalogSerialOutput__ = 70;
const uint DIRECTORY_NUMBER_16__DOLLAR____AnalogSerialOutput__ = 71;
const uint SELECTED_DIRECTORY_ITEM_NAME__DOLLAR____AnalogSerialOutput__ = 72;
const uint SELECTED_DIRECTORY_ITEM_NUM__DOLLAR____AnalogSerialOutput__ = 73;
const uint DND_ENABLED__DigitalInput__ = 61;
const uint DND_DISABLED__DigitalInput__ = 62;
const uint DND_TOGGLE__DigitalInput__ = 63;
const uint DND_RESPONSE_DND__DigitalInput__ = 64;
const uint DND_RESPONSE_BUSY__DigitalInput__ = 65;
const uint DND_RESPONSE_DECLINE__DigitalInput__ = 66;
const uint DND_IS_ENABLED__DigitalOutput__ = 3;
const uint DND_RESPONSE_IS_DND__DigitalOutput__ = 4;
const uint DND_RESPONSE_IS_BUSY__DigitalOutput__ = 5;
const uint DND_RESPONSE_IS_DECLINE__DigitalOutput__ = 6;
const uint ALPHANUMERIC_ENTRY_DIAL__DigitalInput__ = 67;
const uint ALPHANUMERIC_ENTRY__DOLLAR____AnalogSerialInput__ = 4;
const uint ENABLE__DigitalInput__ = 68;
const uint DIALER_INSTANCE_TAG__Parameter__ = 10;
const uint CONTROL_STATUS_INSTANCE_TAG__Parameter__ = 11;
const uint LINE_NUMBER__Parameter__ = 12;
const uint COMMAND_PROCESSOR_ID__Parameter__ = 13;

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
