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

namespace UserModule_OPPO_TIME_PROCESSOR_V1_0
{
    public class UserModuleClass_OPPO_TIME_PROCESSOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput PROCESS_FROM_DEVICE;
        Crestron.Logos.SplusObjects.DigitalInput SEND_TITLE_NUMBER;
        Crestron.Logos.SplusObjects.DigitalInput SEND_TITLE_TIME;
        Crestron.Logos.SplusObjects.DigitalInput SEND_CHAPTER_NUMBER;
        Crestron.Logos.SplusObjects.DigitalInput SEND_CHAPTER_TIME;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR_TEXT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> KEY;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogOutput TITLE_NUMBER_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_NUMBER_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput AUDIO_TRACK_NUMBER_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput AUDIO_MAXIMUM_TRACKS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput SUB_TITLE_NUMBER_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput MAXIMUM_SUB_TITLE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput TOTAL_TRACKS_TITLES_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput TOTAL_CHAPTERS_ANALOG;
        Crestron.Logos.SplusObjects.StringOutput ENTERED_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TITLE_ELAPSED_TIME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TITLE_REMAINING_TIME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_CHAPTER_ELAPSED_TIME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_CHAPTER_REMAINING_TIME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TOTAL_ELAPSED_TIME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TOTAL_REMAINING_TIME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISC_TYPE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_TYPE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_LANGUAGE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_CHANNELS_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SUB_TITLE_LANGUAGE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        ushort IFLAG1 = 0;
        ushort IMARKER1 = 0;
        ushort IMARKER2 = 0;
        ushort IMARKER3 = 0;
        ushort IMARKER4 = 0;
        ushort IMARKER5 = 0;
        ushort IMARKER6 = 0;
        ushort IMARKER7 = 0;
        ushort ITEMP = 0;
        ushort ITEMPTITLE = 0;
        ushort ITEMPCHAPTER = 0;
        ushort ITEMPTRACKNUMBER = 0;
        ushort ITEMPMAXTRACKS = 0;
        ushort ITEMPSUBNUMBER = 0;
        ushort ITEMPMAXSUBS = 0;
        ushort ICURRENTTRACK = 0;
        ushort ITOTALTRACKS = 0;
        ushort ICURRENTCHAPTER = 0;
        ushort ITOTALCHAPTERS = 0;
        CrestronString SENTERED;
        CrestronString STEMP;
        CrestronString STYPE;
        CrestronString SNEWTIME;
        CrestronString SNEWDISCTYPE;
        CrestronString SNEWLANGUAGE;
        CrestronString SNEWAUDIOTYPE;
        CrestronString SNEWCHANNELS;
        CrestronString SNEWSUBLANGUAGE;
        object PROCESS_FROM_DEVICE_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 76;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 78;
                    IFLAG1 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 79;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FROM_DEVICE ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 81;
                        STEMP  .UpdateValue ( Functions.Remove ( "\u000D" , FROM_DEVICE )  ) ; 
                        __context__.SourceCodeLine = 82;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 84;
                            
                                {
                                int __SPLS_TMPVAR__SWTCH_1__ = ((int)1);
                                
                                    { 
                                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@UTC" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 90;
                                        IMARKER1 = (ushort) ( Functions.Find( "@UTC" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 91;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 92;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 93;
                                        IMARKER4 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER3 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 94;
                                        IMARKER5 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER4 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 95;
                                        IMARKER6 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 96;
                                        ITEMPTITLE = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER2 + 1) ) , (int)( ((IMARKER3 - IMARKER2) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 97;
                                        TITLE_NUMBER_ANALOG  .Value = (ushort) ( ITEMPTITLE ) ; 
                                        __context__.SourceCodeLine = 98;
                                        ITEMPCHAPTER = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER3 + 1) ) , (int)( ((IMARKER4 - IMARKER3) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 99;
                                        CHAPTER_NUMBER_ANALOG  .Value = (ushort) ( ITEMPCHAPTER ) ; 
                                        __context__.SourceCodeLine = 100;
                                        STYPE  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER4 + 1) ) ,  (int) ( ((IMARKER5 - IMARKER4) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 101;
                                        SNEWTIME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER5 + 1) ) ,  (int) ( ((IMARKER6 - IMARKER5) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 102;
                                        IMARKER1 = (ushort) ( Functions.Find( ":" , SNEWTIME ) ) ; 
                                        __context__.SourceCodeLine = 103;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 104;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMARKER2 == (IMARKER1 + 2)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 106;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER1 ) ) , Functions.Right ( SNEWTIME ,  (int) ( (Functions.Length( SNEWTIME ) - IMARKER1) ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 108;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 109;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNEWTIME ) == (IMARKER2 + 1)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 111;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER2 ) ) , Functions.Right ( SNEWTIME ,  (int) ( 1 ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 113;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STYPE == "E"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 115;
                                            CURRENT_TOTAL_ELAPSED_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 117;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STYPE == "R"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 119;
                                                CURRENT_TOTAL_REMAINING_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 121;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STYPE == "T"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 123;
                                                    CURRENT_TITLE_ELAPSED_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 125;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STYPE == "X"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 127;
                                                        CURRENT_TITLE_REMAINING_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 129;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STYPE == "C"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 131;
                                                            CURRENT_CHAPTER_ELAPSED_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 133;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STYPE == "K"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 135;
                                                                CURRENT_TOTAL_REMAINING_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@UDT" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 142;
                                        IMARKER1 = (ushort) ( Functions.Find( "@UDT" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 143;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 144;
                                        IMARKER3 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 145;
                                        SNEWDISCTYPE  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER2 + 1) ) ,  (int) ( ((IMARKER3 - IMARKER2) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 146;
                                        DISC_TYPE_TEXT  .UpdateValue ( SNEWDISCTYPE  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@UAT" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 150;
                                        IMARKER1 = (ushort) ( Functions.Find( "@UAT" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 151;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 152;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 153;
                                        IMARKER4 = (ushort) ( Functions.Find( "/" , STEMP , (IMARKER3 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 154;
                                        IMARKER5 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER4 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 155;
                                        IMARKER6 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER5 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 156;
                                        IMARKER7 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 157;
                                        SNEWAUDIOTYPE  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER2 + 1) ) ,  (int) ( ((IMARKER3 - IMARKER2) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 158;
                                        AUDIO_TYPE_TEXT  .UpdateValue ( SNEWAUDIOTYPE  ) ; 
                                        __context__.SourceCodeLine = 159;
                                        ITEMPTRACKNUMBER = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER3 + 1) ) , (int)( ((IMARKER4 - IMARKER3) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 160;
                                        ITEMPMAXTRACKS = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER4 + 1) ) , (int)( ((IMARKER5 - IMARKER4) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 161;
                                        AUDIO_TRACK_NUMBER_ANALOG  .Value = (ushort) ( ITEMPTRACKNUMBER ) ; 
                                        __context__.SourceCodeLine = 162;
                                        AUDIO_MAXIMUM_TRACKS_ANALOG  .Value = (ushort) ( ITEMPMAXTRACKS ) ; 
                                        __context__.SourceCodeLine = 163;
                                        SNEWLANGUAGE  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER5 + 1) ) ,  (int) ( ((IMARKER6 - IMARKER5) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 164;
                                        AUDIO_LANGUAGE_TEXT  .UpdateValue ( SNEWLANGUAGE  ) ; 
                                        __context__.SourceCodeLine = 165;
                                        SNEWCHANNELS  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER6 + 1) ) ,  (int) ( ((IMARKER7 - IMARKER6) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 166;
                                        AUDIO_CHANNELS_TEXT  .UpdateValue ( SNEWCHANNELS  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@UST" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 170;
                                        IMARKER1 = (ushort) ( Functions.Find( "@UST" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 171;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 172;
                                        IMARKER3 = (ushort) ( Functions.Find( "/" , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 173;
                                        IMARKER4 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER3 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 174;
                                        IMARKER5 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 175;
                                        ITEMPSUBNUMBER = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER2 + 1) ) , (int)( ((IMARKER3 - IMARKER2) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 176;
                                        ITEMPMAXSUBS = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER3 + 1) ) , (int)( ((IMARKER4 - IMARKER3) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 177;
                                        SUB_TITLE_NUMBER_ANALOG  .Value = (ushort) ( ITEMPSUBNUMBER ) ; 
                                        __context__.SourceCodeLine = 178;
                                        MAXIMUM_SUB_TITLE_ANALOG  .Value = (ushort) ( ITEMPMAXSUBS ) ; 
                                        __context__.SourceCodeLine = 179;
                                        SNEWSUBLANGUAGE  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER4 + 1) ) ,  (int) ( ((IMARKER5 - IMARKER4) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 180;
                                        SUB_TITLE_LANGUAGE_TEXT  .UpdateValue ( SNEWSUBLANGUAGE  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QTK" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 184;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QTK" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 185;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 186;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 187;
                                        IMARKER4 = (ushort) ( Functions.Find( "/" , STEMP , (IMARKER3 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 188;
                                        IMARKER5 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 189;
                                        ICURRENTTRACK = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER3 + 1) ) , (int)( ((IMARKER4 - IMARKER3) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 190;
                                        ITOTALTRACKS = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER4 + 1) ) , (int)( ((IMARKER5 - IMARKER4) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 191;
                                        TITLE_NUMBER_ANALOG  .Value = (ushort) ( ICURRENTTRACK ) ; 
                                        __context__.SourceCodeLine = 192;
                                        TOTAL_TRACKS_TITLES_ANALOG  .Value = (ushort) ( ITOTALTRACKS ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QCH" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 196;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QCH" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 197;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 198;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 199;
                                        IMARKER4 = (ushort) ( Functions.Find( "/" , STEMP , (IMARKER3 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 200;
                                        IMARKER5 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 201;
                                        ICURRENTCHAPTER = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER3 + 1) ) , (int)( ((IMARKER4 - IMARKER3) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 202;
                                        ITOTALCHAPTERS = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( (IMARKER4 + 1) ) , (int)( ((IMARKER5 - IMARKER4) - 1) ) ) ) ) ; 
                                        __context__.SourceCodeLine = 203;
                                        CHAPTER_NUMBER_ANALOG  .Value = (ushort) ( ICURRENTCHAPTER ) ; 
                                        __context__.SourceCodeLine = 204;
                                        TOTAL_CHAPTERS_ANALOG  .Value = (ushort) ( ITOTALCHAPTERS ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QTE" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 208;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QTE" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 209;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 210;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 211;
                                        IMARKER4 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 212;
                                        SNEWTIME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( ((IMARKER4 - IMARKER3) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 213;
                                        IMARKER1 = (ushort) ( Functions.Find( ":" , SNEWTIME ) ) ; 
                                        __context__.SourceCodeLine = 214;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 215;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMARKER2 == (IMARKER1 + 2)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 217;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER1 ) ) , Functions.Right ( SNEWTIME ,  (int) ( (Functions.Length( SNEWTIME ) - IMARKER1) ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 219;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 220;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNEWTIME ) == (IMARKER2 + 1)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 222;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER2 ) ) , Functions.Right ( SNEWTIME ,  (int) ( 1 ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 224;
                                        CURRENT_TITLE_ELAPSED_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QTR" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 228;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QTR" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 229;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 230;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 231;
                                        IMARKER4 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 232;
                                        SNEWTIME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( ((IMARKER4 - IMARKER3) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 233;
                                        IMARKER1 = (ushort) ( Functions.Find( ":" , SNEWTIME ) ) ; 
                                        __context__.SourceCodeLine = 234;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 235;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMARKER2 == (IMARKER1 + 2)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 237;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER1 ) ) , Functions.Right ( SNEWTIME ,  (int) ( (Functions.Length( SNEWTIME ) - IMARKER1) ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 239;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 240;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNEWTIME ) == (IMARKER2 + 1)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 242;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER2 ) ) , Functions.Right ( SNEWTIME ,  (int) ( 1 ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 244;
                                        CURRENT_TITLE_REMAINING_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QCE" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 248;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QCE" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 249;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 250;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 251;
                                        IMARKER4 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 252;
                                        SNEWTIME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( ((IMARKER4 - IMARKER3) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 253;
                                        IMARKER1 = (ushort) ( Functions.Find( ":" , SNEWTIME ) ) ; 
                                        __context__.SourceCodeLine = 254;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 255;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMARKER2 == (IMARKER1 + 2)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 257;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER1 ) ) , Functions.Right ( SNEWTIME ,  (int) ( (Functions.Length( SNEWTIME ) - IMARKER1) ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 259;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 260;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNEWTIME ) == (IMARKER2 + 1)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 262;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER2 ) ) , Functions.Right ( SNEWTIME ,  (int) ( 1 ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 264;
                                        CURRENT_CHAPTER_ELAPSED_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QCR" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 268;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QCR" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 269;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 270;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 271;
                                        IMARKER4 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 272;
                                        SNEWTIME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( ((IMARKER4 - IMARKER3) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 273;
                                        IMARKER1 = (ushort) ( Functions.Find( ":" , SNEWTIME ) ) ; 
                                        __context__.SourceCodeLine = 274;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 275;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMARKER2 == (IMARKER1 + 2)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 277;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER1 ) ) , Functions.Right ( SNEWTIME ,  (int) ( (Functions.Length( SNEWTIME ) - IMARKER1) ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 279;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 280;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNEWTIME ) == (IMARKER2 + 1)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 282;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER2 ) ) , Functions.Right ( SNEWTIME ,  (int) ( 1 ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 284;
                                        CURRENT_CHAPTER_REMAINING_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QEL" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 288;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QEL" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 289;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 290;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 291;
                                        IMARKER4 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 292;
                                        SNEWTIME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( ((IMARKER4 - IMARKER3) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 293;
                                        IMARKER1 = (ushort) ( Functions.Find( ":" , SNEWTIME ) ) ; 
                                        __context__.SourceCodeLine = 294;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 295;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMARKER2 == (IMARKER1 + 2)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 297;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER1 ) ) , Functions.Right ( SNEWTIME ,  (int) ( (Functions.Length( SNEWTIME ) - IMARKER1) ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 299;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 300;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNEWTIME ) == (IMARKER2 + 1)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 302;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER2 ) ) , Functions.Right ( SNEWTIME ,  (int) ( 1 ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 304;
                                        CURRENT_TOTAL_ELAPSED_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QRE" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 308;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QRE" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 309;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 310;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 311;
                                        IMARKER4 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 312;
                                        SNEWTIME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( ((IMARKER4 - IMARKER3) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 313;
                                        IMARKER1 = (ushort) ( Functions.Find( ":" , SNEWTIME ) ) ; 
                                        __context__.SourceCodeLine = 314;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 315;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMARKER2 == (IMARKER1 + 2)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 317;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER1 ) ) , Functions.Right ( SNEWTIME ,  (int) ( (Functions.Length( SNEWTIME ) - IMARKER1) ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 319;
                                        IMARKER2 = (ushort) ( Functions.Find( ":" , SNEWTIME , (IMARKER1 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 320;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SNEWTIME ) == (IMARKER2 + 1)))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 322;
                                            MakeString ( SNEWTIME , "{0}0{1}", Functions.Left ( SNEWTIME ,  (int) ( IMARKER2 ) ) , Functions.Right ( SNEWTIME ,  (int) ( 1 ) ) ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 324;
                                        CURRENT_TOTAL_REMAINING_TIME_TEXT  .UpdateValue ( SNEWTIME  ) ; 
                                        } 
                                    
                                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.Find( "@QDT" , STEMP )) ) ) ) 
                                        { 
                                        __context__.SourceCodeLine = 328;
                                        IMARKER1 = (ushort) ( Functions.Find( "@QDT" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 329;
                                        IMARKER2 = (ushort) ( Functions.Find( " " , STEMP , IMARKER1 ) ) ; 
                                        __context__.SourceCodeLine = 330;
                                        IMARKER3 = (ushort) ( Functions.Find( " " , STEMP , (IMARKER2 + 1) ) ) ; 
                                        __context__.SourceCodeLine = 331;
                                        IMARKER4 = (ushort) ( Functions.Find( "\u000D" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 332;
                                        SNEWDISCTYPE  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (IMARKER3 + 1) ) ,  (int) ( ((IMARKER4 - IMARKER3) - 1) ) )  ) ; 
                                        __context__.SourceCodeLine = 333;
                                        DISC_TYPE_TEXT  .UpdateValue ( SNEWDISCTYPE  ) ; 
                                        } 
                                    
                                    } 
                                    
                                }
                                
                            
                            } 
                        
                        __context__.SourceCodeLine = 337;
                        Functions.Delay (  (int) ( 10 ) ) ; 
                        __context__.SourceCodeLine = 79;
                        } 
                    
                    __context__.SourceCodeLine = 339;
                    IFLAG1 = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SEND_TITLE_NUMBER_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 345;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( ":" , SENTERED ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 347;
                MakeString ( TO_DEVICE , "#SRH T{0}\u000D", SENTERED ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SEND_TITLE_TIME_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 353;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SENTERED ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 355;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 357;
                SENTERED  .UpdateValue ( "0:00:0" + SENTERED  ) ; 
                __context__.SourceCodeLine = 358;
                ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 360;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 362;
                    SENTERED  .UpdateValue ( "0:00:" + SENTERED  ) ; 
                    __context__.SourceCodeLine = 363;
                    ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 365;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 367;
                        SENTERED  .UpdateValue ( "0:00" + SENTERED  ) ; 
                        __context__.SourceCodeLine = 368;
                        ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 370;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 372;
                            SENTERED  .UpdateValue ( "0:0" + SENTERED  ) ; 
                            __context__.SourceCodeLine = 373;
                            ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 375;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 5))  ) ) 
                                { 
                                __context__.SourceCodeLine = 377;
                                SENTERED  .UpdateValue ( "0:" + SENTERED  ) ; 
                                __context__.SourceCodeLine = 378;
                                ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 380;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 6))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 382;
                                    SENTERED  .UpdateValue ( "0" + SENTERED  ) ; 
                                    __context__.SourceCodeLine = 383;
                                    ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 385;
            MakeString ( TO_DEVICE , "#SRH T {0}\u000D", SENTERED ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_CHAPTER_NUMBER_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 391;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( ":" , SENTERED ) == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 393;
            MakeString ( TO_DEVICE , "#SRH C{0}\u000D", SENTERED ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_CHAPTER_TIME_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 399;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SENTERED ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 401;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 403;
                SENTERED  .UpdateValue ( "0:00:0" + SENTERED  ) ; 
                __context__.SourceCodeLine = 404;
                ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 406;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 408;
                    SENTERED  .UpdateValue ( "0:00:" + SENTERED  ) ; 
                    __context__.SourceCodeLine = 409;
                    ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 411;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 3))  ) ) 
                        { 
                        __context__.SourceCodeLine = 413;
                        SENTERED  .UpdateValue ( "0:00" + SENTERED  ) ; 
                        __context__.SourceCodeLine = 414;
                        ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 416;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 418;
                            SENTERED  .UpdateValue ( "0:0" + SENTERED  ) ; 
                            __context__.SourceCodeLine = 419;
                            ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 421;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 5))  ) ) 
                                { 
                                __context__.SourceCodeLine = 423;
                                SENTERED  .UpdateValue ( "0:" + SENTERED  ) ; 
                                __context__.SourceCodeLine = 424;
                                ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 426;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SENTERED ) == 6))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 428;
                                    SENTERED  .UpdateValue ( "0" + SENTERED  ) ; 
                                    __context__.SourceCodeLine = 429;
                                    ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 431;
            MakeString ( TO_DEVICE , "#SRH C {0}\u000D", SENTERED ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_TEXT_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 437;
        TITLE_NUMBER_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 438;
        CHAPTER_NUMBER_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 439;
        AUDIO_TRACK_NUMBER_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 440;
        AUDIO_MAXIMUM_TRACKS_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 441;
        SUB_TITLE_NUMBER_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 442;
        MAXIMUM_SUB_TITLE_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 443;
        TOTAL_TRACKS_TITLES_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 444;
        TOTAL_CHAPTERS_ANALOG  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 445;
        ENTERED_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 446;
        CURRENT_TITLE_ELAPSED_TIME_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 447;
        CURRENT_TITLE_REMAINING_TIME_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 448;
        CURRENT_CHAPTER_ELAPSED_TIME_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 449;
        CURRENT_CHAPTER_REMAINING_TIME_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 450;
        CURRENT_TOTAL_ELAPSED_TIME_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 451;
        CURRENT_TOTAL_REMAINING_TIME_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 452;
        DISC_TYPE_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 453;
        AUDIO_TYPE_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 454;
        AUDIO_LANGUAGE_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 455;
        AUDIO_CHANNELS_TEXT  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 456;
        SUB_TITLE_LANGUAGE_TEXT  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 461;
        ITEMP = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 462;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
            { 
            __context__.SourceCodeLine = 464;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SENTERED ) < 8 ))  ) ) 
                { 
                __context__.SourceCodeLine = 466;
                SENTERED  .UpdateValue ( SENTERED + ":"  ) ; 
                __context__.SourceCodeLine = 467;
                ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 470;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                { 
                __context__.SourceCodeLine = 472;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SENTERED ) < 8 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 474;
                    SENTERED  .UpdateValue ( Functions.Left ( SENTERED ,  (int) ( (Functions.Length( SENTERED ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 475;
                    ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 478;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                    { 
                    __context__.SourceCodeLine = 480;
                    SENTERED  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 481;
                    ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 483;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                        { 
                        __context__.SourceCodeLine = 485;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SENTERED ) < 8 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 487;
                            SENTERED  .UpdateValue ( SENTERED + "0"  ) ; 
                            __context__.SourceCodeLine = 488;
                            ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 493;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SENTERED ) < 8 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 495;
                            MakeString ( SENTERED , "{0}{1:d}", SENTERED , (short)ITEMP) ; 
                            __context__.SourceCodeLine = 496;
                            ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
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

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 507;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 508;
        SENTERED  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 509;
        ENTERED_TEXT  .UpdateValue ( SENTERED  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SENTERED  = new CrestronString( InheritedStringEncoding, 25, this );
    STEMP  = new CrestronString( InheritedStringEncoding, 100, this );
    STYPE  = new CrestronString( InheritedStringEncoding, 5, this );
    SNEWTIME  = new CrestronString( InheritedStringEncoding, 20, this );
    SNEWDISCTYPE  = new CrestronString( InheritedStringEncoding, 20, this );
    SNEWLANGUAGE  = new CrestronString( InheritedStringEncoding, 25, this );
    SNEWAUDIOTYPE  = new CrestronString( InheritedStringEncoding, 20, this );
    SNEWCHANNELS  = new CrestronString( InheritedStringEncoding, 10, this );
    SNEWSUBLANGUAGE  = new CrestronString( InheritedStringEncoding, 20, this );
    
    PROCESS_FROM_DEVICE = new Crestron.Logos.SplusObjects.DigitalInput( PROCESS_FROM_DEVICE__DigitalInput__, this );
    m_DigitalInputList.Add( PROCESS_FROM_DEVICE__DigitalInput__, PROCESS_FROM_DEVICE );
    
    SEND_TITLE_NUMBER = new Crestron.Logos.SplusObjects.DigitalInput( SEND_TITLE_NUMBER__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_TITLE_NUMBER__DigitalInput__, SEND_TITLE_NUMBER );
    
    SEND_TITLE_TIME = new Crestron.Logos.SplusObjects.DigitalInput( SEND_TITLE_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_TITLE_TIME__DigitalInput__, SEND_TITLE_TIME );
    
    SEND_CHAPTER_NUMBER = new Crestron.Logos.SplusObjects.DigitalInput( SEND_CHAPTER_NUMBER__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_CHAPTER_NUMBER__DigitalInput__, SEND_CHAPTER_NUMBER );
    
    SEND_CHAPTER_TIME = new Crestron.Logos.SplusObjects.DigitalInput( SEND_CHAPTER_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_CHAPTER_TIME__DigitalInput__, SEND_CHAPTER_TIME );
    
    CLEAR_TEXT = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR_TEXT__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR_TEXT__DigitalInput__, CLEAR_TEXT );
    
    KEY = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        KEY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( KEY__DigitalInput__ + i, KEY__DigitalInput__, this );
        m_DigitalInputList.Add( KEY__DigitalInput__ + i, KEY[i+1] );
    }
    
    TITLE_NUMBER_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_NUMBER_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TITLE_NUMBER_ANALOG__AnalogSerialOutput__, TITLE_NUMBER_ANALOG );
    
    CHAPTER_NUMBER_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_NUMBER_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHAPTER_NUMBER_ANALOG__AnalogSerialOutput__, CHAPTER_NUMBER_ANALOG );
    
    AUDIO_TRACK_NUMBER_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( AUDIO_TRACK_NUMBER_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUDIO_TRACK_NUMBER_ANALOG__AnalogSerialOutput__, AUDIO_TRACK_NUMBER_ANALOG );
    
    AUDIO_MAXIMUM_TRACKS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( AUDIO_MAXIMUM_TRACKS_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUDIO_MAXIMUM_TRACKS_ANALOG__AnalogSerialOutput__, AUDIO_MAXIMUM_TRACKS_ANALOG );
    
    SUB_TITLE_NUMBER_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( SUB_TITLE_NUMBER_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SUB_TITLE_NUMBER_ANALOG__AnalogSerialOutput__, SUB_TITLE_NUMBER_ANALOG );
    
    MAXIMUM_SUB_TITLE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( MAXIMUM_SUB_TITLE_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAXIMUM_SUB_TITLE_ANALOG__AnalogSerialOutput__, MAXIMUM_SUB_TITLE_ANALOG );
    
    TOTAL_TRACKS_TITLES_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( TOTAL_TRACKS_TITLES_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TOTAL_TRACKS_TITLES_ANALOG__AnalogSerialOutput__, TOTAL_TRACKS_TITLES_ANALOG );
    
    TOTAL_CHAPTERS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( TOTAL_CHAPTERS_ANALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TOTAL_CHAPTERS_ANALOG__AnalogSerialOutput__, TOTAL_CHAPTERS_ANALOG );
    
    ENTERED_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ENTERED_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ENTERED_TEXT__AnalogSerialOutput__, ENTERED_TEXT );
    
    CURRENT_TITLE_ELAPSED_TIME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TITLE_ELAPSED_TIME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TITLE_ELAPSED_TIME_TEXT__AnalogSerialOutput__, CURRENT_TITLE_ELAPSED_TIME_TEXT );
    
    CURRENT_TITLE_REMAINING_TIME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TITLE_REMAINING_TIME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TITLE_REMAINING_TIME_TEXT__AnalogSerialOutput__, CURRENT_TITLE_REMAINING_TIME_TEXT );
    
    CURRENT_CHAPTER_ELAPSED_TIME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_CHAPTER_ELAPSED_TIME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_CHAPTER_ELAPSED_TIME_TEXT__AnalogSerialOutput__, CURRENT_CHAPTER_ELAPSED_TIME_TEXT );
    
    CURRENT_CHAPTER_REMAINING_TIME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_CHAPTER_REMAINING_TIME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_CHAPTER_REMAINING_TIME_TEXT__AnalogSerialOutput__, CURRENT_CHAPTER_REMAINING_TIME_TEXT );
    
    CURRENT_TOTAL_ELAPSED_TIME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TOTAL_ELAPSED_TIME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TOTAL_ELAPSED_TIME_TEXT__AnalogSerialOutput__, CURRENT_TOTAL_ELAPSED_TIME_TEXT );
    
    CURRENT_TOTAL_REMAINING_TIME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TOTAL_REMAINING_TIME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TOTAL_REMAINING_TIME_TEXT__AnalogSerialOutput__, CURRENT_TOTAL_REMAINING_TIME_TEXT );
    
    DISC_TYPE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISC_TYPE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISC_TYPE_TEXT__AnalogSerialOutput__, DISC_TYPE_TEXT );
    
    AUDIO_TYPE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_TYPE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_TYPE_TEXT__AnalogSerialOutput__, AUDIO_TYPE_TEXT );
    
    AUDIO_LANGUAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_LANGUAGE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_LANGUAGE_TEXT__AnalogSerialOutput__, AUDIO_LANGUAGE_TEXT );
    
    AUDIO_CHANNELS_TEXT = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_CHANNELS_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_CHANNELS_TEXT__AnalogSerialOutput__, AUDIO_CHANNELS_TEXT );
    
    SUB_TITLE_LANGUAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SUB_TITLE_LANGUAGE_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SUB_TITLE_LANGUAGE_TEXT__AnalogSerialOutput__, SUB_TITLE_LANGUAGE_TEXT );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    FROM_DEVICE = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__AnalogSerialInput__, 500, this );
    m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
    
    
    PROCESS_FROM_DEVICE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( PROCESS_FROM_DEVICE_OnRelease_0, false ) );
    SEND_TITLE_NUMBER.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_TITLE_NUMBER_OnPush_1, false ) );
    SEND_TITLE_TIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_TITLE_TIME_OnPush_2, false ) );
    SEND_CHAPTER_NUMBER.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_CHAPTER_NUMBER_OnPush_3, false ) );
    SEND_CHAPTER_TIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_CHAPTER_TIME_OnPush_4, false ) );
    CLEAR_TEXT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CLEAR_TEXT_OnRelease_5, false ) );
    for( uint i = 0; i < 13; i++ )
        KEY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_OnPush_6, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_OPPO_TIME_PROCESSOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PROCESS_FROM_DEVICE__DigitalInput__ = 0;
const uint SEND_TITLE_NUMBER__DigitalInput__ = 1;
const uint SEND_TITLE_TIME__DigitalInput__ = 2;
const uint SEND_CHAPTER_NUMBER__DigitalInput__ = 3;
const uint SEND_CHAPTER_TIME__DigitalInput__ = 4;
const uint CLEAR_TEXT__DigitalInput__ = 5;
const uint KEY__DigitalInput__ = 6;
const uint FROM_DEVICE__AnalogSerialInput__ = 0;
const uint TITLE_NUMBER_ANALOG__AnalogSerialOutput__ = 0;
const uint CHAPTER_NUMBER_ANALOG__AnalogSerialOutput__ = 1;
const uint AUDIO_TRACK_NUMBER_ANALOG__AnalogSerialOutput__ = 2;
const uint AUDIO_MAXIMUM_TRACKS_ANALOG__AnalogSerialOutput__ = 3;
const uint SUB_TITLE_NUMBER_ANALOG__AnalogSerialOutput__ = 4;
const uint MAXIMUM_SUB_TITLE_ANALOG__AnalogSerialOutput__ = 5;
const uint TOTAL_TRACKS_TITLES_ANALOG__AnalogSerialOutput__ = 6;
const uint TOTAL_CHAPTERS_ANALOG__AnalogSerialOutput__ = 7;
const uint ENTERED_TEXT__AnalogSerialOutput__ = 8;
const uint CURRENT_TITLE_ELAPSED_TIME_TEXT__AnalogSerialOutput__ = 9;
const uint CURRENT_TITLE_REMAINING_TIME_TEXT__AnalogSerialOutput__ = 10;
const uint CURRENT_CHAPTER_ELAPSED_TIME_TEXT__AnalogSerialOutput__ = 11;
const uint CURRENT_CHAPTER_REMAINING_TIME_TEXT__AnalogSerialOutput__ = 12;
const uint CURRENT_TOTAL_ELAPSED_TIME_TEXT__AnalogSerialOutput__ = 13;
const uint CURRENT_TOTAL_REMAINING_TIME_TEXT__AnalogSerialOutput__ = 14;
const uint DISC_TYPE_TEXT__AnalogSerialOutput__ = 15;
const uint AUDIO_TYPE_TEXT__AnalogSerialOutput__ = 16;
const uint AUDIO_LANGUAGE_TEXT__AnalogSerialOutput__ = 17;
const uint AUDIO_CHANNELS_TEXT__AnalogSerialOutput__ = 18;
const uint SUB_TITLE_LANGUAGE_TEXT__AnalogSerialOutput__ = 19;
const uint TO_DEVICE__AnalogSerialOutput__ = 20;

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
