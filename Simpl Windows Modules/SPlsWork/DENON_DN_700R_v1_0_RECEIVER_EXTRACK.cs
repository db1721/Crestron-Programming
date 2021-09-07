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

namespace UserModule_DENON_DN_700R_V1_0_RECEIVER_EXTRACK
{
    public class UserModuleClass_DENON_DN_700R_V1_0_RECEIVER_EXTRACK : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DATE_TIME_YEAR_MONTH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DATE_TIME_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TOTAL_TRACK_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TRACK_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TRACK_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HOT_START_PLAY_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ELAPSE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput REMAIN_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RECORD_REMAIN_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEDIA_SD1_SIZE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEDIA_SD2_SIZE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEDIA_USB_SIZE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEDIA_FOLDER_NAME_MEDIA__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_MEDIA_FOLDER_NAME_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RECORD_VOLUME_LEFT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RECORD_VOLUME_RIGHT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PITCH_ONOFF__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PITCH_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TOTAL_MARK_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MARK_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET_TITLE_NAME_NOS_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET_TITLE_NAME_NOS_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput PRESET_TITLE_NAME_NOS_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SKIP_BACK_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_DAY_OF_WEEK_WEEK__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_DAY_OF_WEEK_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_DATE_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_DATE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SERVER_IP_ADDRESS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SERVER_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SERVER_FOLDER_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DAY_OF_WEEK_WEEK__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DAY_OF_WEEK_START_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DAY_OF_WEEK_END_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DATE_AND_TIME_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DATE_AND_TIME_START_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DATE_AND_TIME_END_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_PLAY_SET_DAY_OF_WEEK_WEEK__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_PLAY_SET_DAY_OF_WEEK_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_PLAY_SET_DATE_AND_TIME_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_PLAY_SET_DATE_AND_TIME_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_REC_TIMER_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_PLAY_TIMER_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVED_REC_TIMER_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput RESERVED_PLAY_TIMER_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HOT_START_SET_FILE_INFOM_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput REC_FOLDER_FIXED_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USER_AREA_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MIC_INPUT_SENS_LEFT_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MIC_INPUT_SENS_RIGHT_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput INPUT_TRIUM_LEFT_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput INPUT_TRIUM_RIGHT_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput OUTPUT_TRIUM_LEFT_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MACHINE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IP_ADDRESS__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput IP_ADDRESS_DHCP_FB;
        Crestron.Logos.SplusObjects.StringOutput MASK_IP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput GATEWAY_IP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SERVER_IP__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IP_CONTROL_PORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NTP_SERVER_IP__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput NTP_SERVER_IP_FB;
        Crestron.Logos.SplusObjects.StringOutput SYSTEM_LOG_IP__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SYSTEM_LOG_IP_FB;
        Crestron.Logos.SplusObjects.StringOutput TIME_ZONE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DST_OFFSET_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DST_START_DATE_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DST_START_DATE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DST_END_DATE_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DST_END_DATE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TRACK_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TRACK_SIZE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TRACK_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TOTAL_FOLDER_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FOLDER_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TRACK_ARTIST_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TRACK_TITLE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TRACK_ALBUN_NAME__DOLLAR__;
        ushort I = 0;
        ushort RX_OK = 0;
        CrestronString TEMP__DOLLAR__;
        CrestronString TEMP2__DOLLAR__;
        private CrestronString IP_DOT_F (  SplusExecutionContext __context__, CrestronString DATA__DOLLAR__ ) 
            { 
            CrestronString A__DOLLAR__;
            CrestronString B__DOLLAR__;
            CrestronString C__DOLLAR__;
            CrestronString D__DOLLAR__;
            CrestronString OUT__DOLLAR__;
            A__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            B__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            C__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            D__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            OUT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 127;
            A__DOLLAR__  .UpdateValue ( Functions.Left ( DATA__DOLLAR__ ,  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 128;
            B__DOLLAR__  .UpdateValue ( Functions.Mid ( DATA__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 129;
            C__DOLLAR__  .UpdateValue ( Functions.Mid ( DATA__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 130;
            D__DOLLAR__  .UpdateValue ( Functions.Right ( DATA__DOLLAR__ ,  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 131;
            OUT__DOLLAR__  .UpdateValue ( A__DOLLAR__ + "." + B__DOLLAR__ + "." + C__DOLLAR__ + "." + D__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 132;
            return ( OUT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString HH_MM_F (  SplusExecutionContext __context__, CrestronString DATA__DOLLAR__ ) 
            { 
            CrestronString A__DOLLAR__;
            CrestronString B__DOLLAR__;
            CrestronString OUT__DOLLAR__;
            A__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            B__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            OUT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 138;
            A__DOLLAR__  .UpdateValue ( Functions.Left ( DATA__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 139;
            B__DOLLAR__  .UpdateValue ( Functions.Right ( DATA__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 140;
            OUT__DOLLAR__  .UpdateValue ( A__DOLLAR__ + ":" + B__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 141;
            return ( OUT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString HHH_MM_SS_F (  SplusExecutionContext __context__, CrestronString DATA__DOLLAR__ ) 
            { 
            CrestronString A__DOLLAR__;
            CrestronString B__DOLLAR__;
            CrestronString C__DOLLAR__;
            CrestronString OUT__DOLLAR__;
            A__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            B__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            C__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            OUT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 147;
            A__DOLLAR__  .UpdateValue ( Functions.Left ( DATA__DOLLAR__ ,  (int) ( 3 ) )  ) ; 
            __context__.SourceCodeLine = 148;
            B__DOLLAR__  .UpdateValue ( Functions.Mid ( DATA__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 149;
            C__DOLLAR__  .UpdateValue ( Functions.Right ( DATA__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 150;
            OUT__DOLLAR__  .UpdateValue ( A__DOLLAR__ + ":" + B__DOLLAR__ + ":" + C__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 151;
            return ( OUT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString YY_MM_DD_F (  SplusExecutionContext __context__, CrestronString DATA__DOLLAR__ ) 
            { 
            CrestronString A__DOLLAR__;
            CrestronString B__DOLLAR__;
            CrestronString C__DOLLAR__;
            CrestronString OUT__DOLLAR__;
            A__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            B__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            C__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            OUT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 157;
            A__DOLLAR__  .UpdateValue ( Functions.Left ( DATA__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 158;
            B__DOLLAR__  .UpdateValue ( Functions.Mid ( DATA__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 159;
            C__DOLLAR__  .UpdateValue ( Functions.Right ( DATA__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 160;
            OUT__DOLLAR__  .UpdateValue ( "20" + A__DOLLAR__ + "\u0020Month\u0020" + B__DOLLAR__ + "\u0020Day\u0020" + C__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 161;
            return ( OUT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString MM_DD_F (  SplusExecutionContext __context__, CrestronString DATA__DOLLAR__ ) 
            { 
            CrestronString A__DOLLAR__;
            CrestronString B__DOLLAR__;
            CrestronString OUT__DOLLAR__;
            A__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            B__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            OUT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 168;
            A__DOLLAR__  .UpdateValue ( Functions.Left ( DATA__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 169;
            B__DOLLAR__  .UpdateValue ( Functions.Right ( DATA__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 170;
            OUT__DOLLAR__  .UpdateValue ( "Month\u0020" + A__DOLLAR__ + "\u0020Day\u0020" + B__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 171;
            return ( OUT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString REC_LEVEL_F (  SplusExecutionContext __context__, CrestronString DATA__DOLLAR__ ) 
            { 
            CrestronString OUT__DOLLAR__;
            OUT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( Functions.Find( "+A" , DATA__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 181;
                OUT__DOLLAR__  .UpdateValue ( "+10"  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 183;
                if ( Functions.TestForTrue  ( ( Functions.Find( "+" , DATA__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 185;
                    OUT__DOLLAR__  .UpdateValue ( DATA__DOLLAR__  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 189;
                    OUT__DOLLAR__  .UpdateValue ( "-" + DATA__DOLLAR__  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 191;
            return ( OUT__DOLLAR__ ) ; 
            
            }
            
        object FROM_DEVICE__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 202;
                if ( Functions.TestForTrue  ( ( RX_OK)  ) ) 
                    { 
                    __context__.SourceCodeLine = 204;
                    RX_OK = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 205;
                    while ( Functions.TestForTrue  ( ( Functions.Length( FROM_DEVICE__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 207;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "\u000D" , FROM_DEVICE__DOLLAR__ ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 210;
                            TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROM_DEVICE__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 211;
                            TEMP__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( Functions.Find( "@" , TEMP__DOLLAR__ ) ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) + 1) ) )  ) ; 
                            __context__.SourceCodeLine = 216;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0Dt" , TEMP__DOLLAR__ ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 218;
                                DATE_TIME_YEAR_MONTH__DOLLAR__  .UpdateValue ( YY_MM_DD_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 6 ) ))  ) ; 
                                __context__.SourceCodeLine = 220;
                                DATE_TIME_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 11 ) , (int)( 4 ) ))  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 222;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0Tt" , TEMP__DOLLAR__ ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 224;
                                    TOTAL_TRACK_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 4 ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 226;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0Tr" , TEMP__DOLLAR__ ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 228;
                                        TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 4 ) )  ) ; 
                                        __context__.SourceCodeLine = 229;
                                        CURRENT_TRACK_NUMBER__DOLLAR__  .UpdateValue ( TEMP2__DOLLAR__  ) ; 
                                        __context__.SourceCodeLine = 230;
                                        TO_DEVICE__DOLLAR__  .UpdateValue ( "@0?Tn" + Functions.Right ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ) + "\r"  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 232;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0Tn" , TEMP__DOLLAR__ ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 234;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0Tn\r" , TEMP__DOLLAR__ ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 236;
                                                CURRENT_TRACK_NAME__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 240;
                                                CURRENT_TRACK_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( (Functions.ReverseFind( "/" , TEMP__DOLLAR__ ) + 1) ) ,  (int) ( ((Functions.Length( TEMP__DOLLAR__ ) - Functions.ReverseFind( "/" , TEMP__DOLLAR__ )) - 1) ) )  ) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 243;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0HP" , TEMP__DOLLAR__ ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 245;
                                                HOT_START_PLAY_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 2 ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 247;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0ET" , TEMP__DOLLAR__ ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 249;
                                                    ELAPSE_TIME__DOLLAR__  .UpdateValue ( HHH_MM_SS_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 7 ) ))  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 251;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0RM" , TEMP__DOLLAR__ ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 253;
                                                        REMAIN_TIME__DOLLAR__  .UpdateValue ( HHH_MM_SS_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 7 ) ))  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 256;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0RT" , TEMP__DOLLAR__ ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 258;
                                                            RECORD_REMAIN_TIME__DOLLAR__  .UpdateValue ( HHH_MM_SS_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 7 ) ))  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 260;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0FES1" , TEMP__DOLLAR__ ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 262;
                                                                CURRENT_MEDIA_SD1_SIZE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 7) ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 264;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0FES2" , TEMP__DOLLAR__ ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 266;
                                                                    CURRENT_MEDIA_SD2_SIZE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 7) ) )  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 268;
                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0FEUS" , TEMP__DOLLAR__ ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 270;
                                                                        CURRENT_MEDIA_USB_SIZE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 7) ) )  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 272;
                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0SF" , TEMP__DOLLAR__ ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 274;
                                                                            CURRENT_MEDIA_FOLDER_NAME_MEDIA__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 1 ) )  ) ; 
                                                                            __context__.SourceCodeLine = 275;
                                                                            CURRENT_MEDIA_FOLDER_NAME_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 6) ) )  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 277;
                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0RV" , TEMP__DOLLAR__ ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 279;
                                                                                RECORD_VOLUME_LEFT__DOLLAR__  .UpdateValue ( REC_LEVEL_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 2 ) ))  ) ; 
                                                                                __context__.SourceCodeLine = 280;
                                                                                RECORD_VOLUME_RIGHT__DOLLAR__  .UpdateValue ( REC_LEVEL_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 7 ) , (int)( 2 ) ))  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 282;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Find( "@0PTON" , TEMP__DOLLAR__ ) ) || Functions.TestForTrue ( Functions.Find( "@0PTOF" , TEMP__DOLLAR__ ) )) ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 284;
                                                                                    PITCH_ONOFF__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 2 ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 285;
                                                                                    TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 4 ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 286;
                                                                                    PITCH_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ) + "." + Functions.Right ( TEMP2__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 288;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0Tm" , TEMP__DOLLAR__ ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 290;
                                                                                        TOTAL_MARK_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 2 ) )  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 292;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0Mt" , TEMP__DOLLAR__ ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 294;
                                                                                            TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 8 ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 296;
                                                                                            MARK_TIME__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ) + ":" + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 2 ) ) + ":" + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 2 ) ) + ":" + Functions.Right ( TEMP2__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 301;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0PN1" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 303;
                                                                                                PRESET_TITLE_NAME_NOS_1__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 6) ) )  ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 305;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0PN2" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 307;
                                                                                                    PRESET_TITLE_NAME_NOS_2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 6) ) )  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 309;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0PN3" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 311;
                                                                                                        PRESET_TITLE_NAME_NOS_3__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 6) ) )  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 316;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0SB" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 318;
                                                                                                            SKIP_BACK_TIME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 3 ) )  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 322;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0asDW" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 324;
                                                                                                                SCHEDULE_DAY_OF_WEEK_WEEK__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 7 ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 325;
                                                                                                                SCHEDULE_DAY_OF_WEEK_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 14 ) , (int)( 4 ) ))  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 327;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0asDT" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 329;
                                                                                                                    SCHEDULE_DATE_DATE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 6 ) )  ) ; 
                                                                                                                    __context__.SourceCodeLine = 330;
                                                                                                                    SCHEDULE_DATE_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 13 ) , (int)( 4 ) ))  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 332;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0AI" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 334;
                                                                                                                        SERVER_IP_ADDRESS__DOLLAR__  .UpdateValue ( IP_DOT_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 12 ) ))  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 336;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0AU" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 338;
                                                                                                                            SERVER_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 5) ) )  ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 340;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0AO" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 342;
                                                                                                                                SERVER_FOLDER_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 5) ) )  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 346;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0ShDW" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 348;
                                                                                                                                    TIME_REC_SET_DAY_OF_WEEK_WEEK__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 7 ) )  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 349;
                                                                                                                                    TIME_REC_SET_DAY_OF_WEEK_START_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 14 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 350;
                                                                                                                                    TIME_REC_SET_DAY_OF_WEEK_END_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 18 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 351;
                                                                                                                                    TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR__  .UpdateValue ( " "  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 352;
                                                                                                                                    TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 22 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 22) ) )  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    {
                                                                                                                                    __context__.SourceCodeLine = 354;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0ShDT" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 356;
                                                                                                                                        TIME_REC_SET_DATE_AND_TIME_DATE__DOLLAR__  .UpdateValue ( YY_MM_DD_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 7 ) , (int)( 6 ) ))  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 357;
                                                                                                                                        TIME_REC_SET_DATE_AND_TIME_START_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 13 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 358;
                                                                                                                                        TIME_REC_SET_DATE_AND_TIME_END_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 17 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 359;
                                                                                                                                        TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR__  .UpdateValue ( " "  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 360;
                                                                                                                                        TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 21 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 21) ) )  ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    else 
                                                                                                                                        {
                                                                                                                                        __context__.SourceCodeLine = 363;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0TPDW" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                            { 
                                                                                                                                            __context__.SourceCodeLine = 365;
                                                                                                                                            TIME_PLAY_SET_DAY_OF_WEEK_WEEK__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 7 ) )  ) ; 
                                                                                                                                            __context__.SourceCodeLine = 366;
                                                                                                                                            TIME_PLAY_SET_DAY_OF_WEEK_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 14 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                            __context__.SourceCodeLine = 367;
                                                                                                                                            TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR__  .UpdateValue ( " "  ) ; 
                                                                                                                                            __context__.SourceCodeLine = 368;
                                                                                                                                            TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 18 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 18) ) )  ) ; 
                                                                                                                                            } 
                                                                                                                                        
                                                                                                                                        else 
                                                                                                                                            {
                                                                                                                                            __context__.SourceCodeLine = 371;
                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0TPDT" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                { 
                                                                                                                                                __context__.SourceCodeLine = 373;
                                                                                                                                                TIME_PLAY_SET_DATE_AND_TIME_DATE__DOLLAR__  .UpdateValue ( YY_MM_DD_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 7 ) , (int)( 6 ) ))  ) ; 
                                                                                                                                                __context__.SourceCodeLine = 374;
                                                                                                                                                TIME_PLAY_SET_DATE_AND_TIME_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 13 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                                __context__.SourceCodeLine = 375;
                                                                                                                                                TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR__  .UpdateValue ( " "  ) ; 
                                                                                                                                                __context__.SourceCodeLine = 376;
                                                                                                                                                TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 17 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 17) ) )  ) ; 
                                                                                                                                                } 
                                                                                                                                            
                                                                                                                                            else 
                                                                                                                                                {
                                                                                                                                                __context__.SourceCodeLine = 379;
                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0CtRE" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                    { 
                                                                                                                                                    __context__.SourceCodeLine = 381;
                                                                                                                                                    CURRENT_REC_TIMER_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                    } 
                                                                                                                                                
                                                                                                                                                else 
                                                                                                                                                    {
                                                                                                                                                    __context__.SourceCodeLine = 383;
                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0CtPL" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                        { 
                                                                                                                                                        __context__.SourceCodeLine = 385;
                                                                                                                                                        CURRENT_PLAY_TIMER_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                        } 
                                                                                                                                                    
                                                                                                                                                    else 
                                                                                                                                                        {
                                                                                                                                                        __context__.SourceCodeLine = 387;
                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0RtRE" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                            { 
                                                                                                                                                            __context__.SourceCodeLine = 389;
                                                                                                                                                            RESERVED_REC_TIMER_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                            } 
                                                                                                                                                        
                                                                                                                                                        else 
                                                                                                                                                            {
                                                                                                                                                            __context__.SourceCodeLine = 391;
                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0RtPL" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                { 
                                                                                                                                                                __context__.SourceCodeLine = 393;
                                                                                                                                                                RESERVED_PLAY_TIMER_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                                } 
                                                                                                                                                            
                                                                                                                                                            else 
                                                                                                                                                                {
                                                                                                                                                                __context__.SourceCodeLine = 398;
                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0Hs" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                    { 
                                                                                                                                                                    __context__.SourceCodeLine = 400;
                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMP__DOLLAR__ ) < 8 ))  ) ) 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 402;
                                                                                                                                                                        HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 403;
                                                                                                                                                                        HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 404;
                                                                                                                                                                        HOT_START_SET_FILE_INFOM_TIME__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    else 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 408;
                                                                                                                                                                        HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 409;
                                                                                                                                                                        HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( (Functions.Find( ":" , TEMP__DOLLAR__ ) + 1) ) ,  (int) ( (Functions.ReverseFind( ":" , TEMP__DOLLAR__ ) - (Functions.Find( ":" , TEMP__DOLLAR__ ) + 1)) ) )  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 410;
                                                                                                                                                                        TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( (Functions.ReverseFind( ":" , TEMP__DOLLAR__ ) + 1) ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - (Functions.ReverseFind( ":" , TEMP__DOLLAR__ ) + 1)) ) )  ) ; 
                                                                                                                                                                        __context__.SourceCodeLine = 411;
                                                                                                                                                                        HOT_START_SET_FILE_INFOM_TIME__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ) + ":" + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( 2 ) ) + ":" + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 2 ) ) + ":" + Functions.Right ( TEMP2__DOLLAR__ ,  (int) ( 3 ) )  ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    } 
                                                                                                                                                                
                                                                                                                                                                else 
                                                                                                                                                                    {
                                                                                                                                                                    __context__.SourceCodeLine = 416;
                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0RfFX" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                        { 
                                                                                                                                                                        __context__.SourceCodeLine = 418;
                                                                                                                                                                        REC_FOLDER_FIXED_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 7) ) )  ) ; 
                                                                                                                                                                        } 
                                                                                                                                                                    
                                                                                                                                                                    else 
                                                                                                                                                                        {
                                                                                                                                                                        __context__.SourceCodeLine = 420;
                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0UA" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                            { 
                                                                                                                                                                            __context__.SourceCodeLine = 422;
                                                                                                                                                                            USER_AREA_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 5) ) )  ) ; 
                                                                                                                                                                            } 
                                                                                                                                                                        
                                                                                                                                                                        else 
                                                                                                                                                                            {
                                                                                                                                                                            __context__.SourceCodeLine = 424;
                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0MsL" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                { 
                                                                                                                                                                                __context__.SourceCodeLine = 426;
                                                                                                                                                                                MIC_INPUT_SENS_LEFT_VALUE__DOLLAR__  .UpdateValue ( "-" + Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                                                } 
                                                                                                                                                                            
                                                                                                                                                                            else 
                                                                                                                                                                                {
                                                                                                                                                                                __context__.SourceCodeLine = 428;
                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0MsR" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                    { 
                                                                                                                                                                                    __context__.SourceCodeLine = 430;
                                                                                                                                                                                    MIC_INPUT_SENS_RIGHT_VALUE__DOLLAR__  .UpdateValue ( "-" + Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                                                                                                    } 
                                                                                                                                                                                
                                                                                                                                                                                else 
                                                                                                                                                                                    {
                                                                                                                                                                                    __context__.SourceCodeLine = 432;
                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0ItL" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                        { 
                                                                                                                                                                                        __context__.SourceCodeLine = 434;
                                                                                                                                                                                        TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 3 ) )  ) ; 
                                                                                                                                                                                        __context__.SourceCodeLine = 435;
                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "\u000D" , TEMP2__DOLLAR__ ))  ) ) 
                                                                                                                                                                                            { 
                                                                                                                                                                                            __context__.SourceCodeLine = 437;
                                                                                                                                                                                            INPUT_TRIUM_LEFT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 1 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                            } 
                                                                                                                                                                                        
                                                                                                                                                                                        else 
                                                                                                                                                                                            { 
                                                                                                                                                                                            __context__.SourceCodeLine = 441;
                                                                                                                                                                                            INPUT_TRIUM_LEFT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                            } 
                                                                                                                                                                                        
                                                                                                                                                                                        } 
                                                                                                                                                                                    
                                                                                                                                                                                    else 
                                                                                                                                                                                        {
                                                                                                                                                                                        __context__.SourceCodeLine = 444;
                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0ItR" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                            { 
                                                                                                                                                                                            __context__.SourceCodeLine = 446;
                                                                                                                                                                                            TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 3 ) )  ) ; 
                                                                                                                                                                                            __context__.SourceCodeLine = 447;
                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "\u000D" , TEMP2__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                { 
                                                                                                                                                                                                __context__.SourceCodeLine = 449;
                                                                                                                                                                                                INPUT_TRIUM_RIGHT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 1 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                                } 
                                                                                                                                                                                            
                                                                                                                                                                                            else 
                                                                                                                                                                                                { 
                                                                                                                                                                                                __context__.SourceCodeLine = 453;
                                                                                                                                                                                                INPUT_TRIUM_RIGHT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                                } 
                                                                                                                                                                                            
                                                                                                                                                                                            } 
                                                                                                                                                                                        
                                                                                                                                                                                        else 
                                                                                                                                                                                            {
                                                                                                                                                                                            __context__.SourceCodeLine = 456;
                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0OtL" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                { 
                                                                                                                                                                                                __context__.SourceCodeLine = 458;
                                                                                                                                                                                                TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 3 ) )  ) ; 
                                                                                                                                                                                                __context__.SourceCodeLine = 459;
                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "\u000D" , TEMP2__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                    { 
                                                                                                                                                                                                    __context__.SourceCodeLine = 461;
                                                                                                                                                                                                    OUTPUT_TRIUM_LEFT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 1 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                                    } 
                                                                                                                                                                                                
                                                                                                                                                                                                else 
                                                                                                                                                                                                    { 
                                                                                                                                                                                                    __context__.SourceCodeLine = 465;
                                                                                                                                                                                                    OUTPUT_TRIUM_LEFT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                                    } 
                                                                                                                                                                                                
                                                                                                                                                                                                } 
                                                                                                                                                                                            
                                                                                                                                                                                            else 
                                                                                                                                                                                                {
                                                                                                                                                                                                __context__.SourceCodeLine = 469;
                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0OtR" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                    { 
                                                                                                                                                                                                    __context__.SourceCodeLine = 471;
                                                                                                                                                                                                    TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 3 ) )  ) ; 
                                                                                                                                                                                                    __context__.SourceCodeLine = 472;
                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "\u000D" , TEMP2__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                        { 
                                                                                                                                                                                                        __context__.SourceCodeLine = 474;
                                                                                                                                                                                                        OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 1 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                                        } 
                                                                                                                                                                                                    
                                                                                                                                                                                                    else 
                                                                                                                                                                                                        { 
                                                                                                                                                                                                        __context__.SourceCodeLine = 478;
                                                                                                                                                                                                        OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMP2__DOLLAR__ ,  (int) ( 2 ) ) + "." + Functions.Mid ( TEMP2__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                                        } 
                                                                                                                                                                                                    
                                                                                                                                                                                                    } 
                                                                                                                                                                                                
                                                                                                                                                                                                else 
                                                                                                                                                                                                    {
                                                                                                                                                                                                    __context__.SourceCodeLine = 482;
                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0MN" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                        { 
                                                                                                                                                                                                        __context__.SourceCodeLine = 484;
                                                                                                                                                                                                        MACHINE_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 5) ) )  ) ; 
                                                                                                                                                                                                        } 
                                                                                                                                                                                                    
                                                                                                                                                                                                    else 
                                                                                                                                                                                                        {
                                                                                                                                                                                                        __context__.SourceCodeLine = 486;
                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0IP" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                            { 
                                                                                                                                                                                                            __context__.SourceCodeLine = 488;
                                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "AUTO" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                { 
                                                                                                                                                                                                                __context__.SourceCodeLine = 490;
                                                                                                                                                                                                                IP_ADDRESS_DHCP_FB  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                                                __context__.SourceCodeLine = 491;
                                                                                                                                                                                                                IP_ADDRESS__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                } 
                                                                                                                                                                                                            
                                                                                                                                                                                                            else 
                                                                                                                                                                                                                { 
                                                                                                                                                                                                                __context__.SourceCodeLine = 494;
                                                                                                                                                                                                                Print( "IP FIX") ; 
                                                                                                                                                                                                                __context__.SourceCodeLine = 495;
                                                                                                                                                                                                                IP_ADDRESS_DHCP_FB  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                                                __context__.SourceCodeLine = 496;
                                                                                                                                                                                                                IP_ADDRESS__DOLLAR__  .UpdateValue ( IP_DOT_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 12 ) ))  ) ; 
                                                                                                                                                                                                                } 
                                                                                                                                                                                                            
                                                                                                                                                                                                            } 
                                                                                                                                                                                                        
                                                                                                                                                                                                        else 
                                                                                                                                                                                                            {
                                                                                                                                                                                                            __context__.SourceCodeLine = 499;
                                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0SM" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                { 
                                                                                                                                                                                                                __context__.SourceCodeLine = 501;
                                                                                                                                                                                                                MASK_IP__DOLLAR__  .UpdateValue ( IP_DOT_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 12 ) ))  ) ; 
                                                                                                                                                                                                                } 
                                                                                                                                                                                                            
                                                                                                                                                                                                            else 
                                                                                                                                                                                                                {
                                                                                                                                                                                                                __context__.SourceCodeLine = 503;
                                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0GW" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                    __context__.SourceCodeLine = 505;
                                                                                                                                                                                                                    GATEWAY_IP__DOLLAR__  .UpdateValue ( IP_DOT_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 12 ) ))  ) ; 
                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                
                                                                                                                                                                                                                else 
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                    __context__.SourceCodeLine = 507;
                                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0DN" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                        { 
                                                                                                                                                                                                                        __context__.SourceCodeLine = 509;
                                                                                                                                                                                                                        SERVER_IP__DOLLAR__  .UpdateValue ( IP_DOT_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 12 ) ))  ) ; 
                                                                                                                                                                                                                        } 
                                                                                                                                                                                                                    
                                                                                                                                                                                                                    else 
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                        __context__.SourceCodeLine = 511;
                                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0Ip" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                            { 
                                                                                                                                                                                                                            __context__.SourceCodeLine = 513;
                                                                                                                                                                                                                            IP_CONTROL_PORT__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 5 ) )  ) ; 
                                                                                                                                                                                                                            } 
                                                                                                                                                                                                                        
                                                                                                                                                                                                                        else 
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            __context__.SourceCodeLine = 515;
                                                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0NP" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                { 
                                                                                                                                                                                                                                __context__.SourceCodeLine = 517;
                                                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "DISABLE" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                                    __context__.SourceCodeLine = 519;
                                                                                                                                                                                                                                    NTP_SERVER_IP_FB  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                                                                    __context__.SourceCodeLine = 520;
                                                                                                                                                                                                                                    NTP_SERVER_IP__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                                
                                                                                                                                                                                                                                else 
                                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                                    __context__.SourceCodeLine = 524;
                                                                                                                                                                                                                                    NTP_SERVER_IP_FB  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                                                                    __context__.SourceCodeLine = 525;
                                                                                                                                                                                                                                    NTP_SERVER_IP__DOLLAR__  .UpdateValue ( IP_DOT_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 12 ) ))  ) ; 
                                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                                
                                                                                                                                                                                                                                } 
                                                                                                                                                                                                                            
                                                                                                                                                                                                                            else 
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                __context__.SourceCodeLine = 528;
                                                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0Sl" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                                    __context__.SourceCodeLine = 530;
                                                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "DISABLE" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                        { 
                                                                                                                                                                                                                                        __context__.SourceCodeLine = 532;
                                                                                                                                                                                                                                        SYSTEM_LOG_IP_FB  .Value = (ushort) ( 0 ) ; 
                                                                                                                                                                                                                                        __context__.SourceCodeLine = 533;
                                                                                                                                                                                                                                        SYSTEM_LOG_IP__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                                                                                                                                                                                                        } 
                                                                                                                                                                                                                                    
                                                                                                                                                                                                                                    else 
                                                                                                                                                                                                                                        { 
                                                                                                                                                                                                                                        __context__.SourceCodeLine = 537;
                                                                                                                                                                                                                                        SYSTEM_LOG_IP_FB  .Value = (ushort) ( 1 ) ; 
                                                                                                                                                                                                                                        __context__.SourceCodeLine = 538;
                                                                                                                                                                                                                                        SYSTEM_LOG_IP__DOLLAR__  .UpdateValue ( IP_DOT_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 12 ) ))  ) ; 
                                                                                                                                                                                                                                        } 
                                                                                                                                                                                                                                    
                                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                                
                                                                                                                                                                                                                                else 
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                    __context__.SourceCodeLine = 542;
                                                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0TZ" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                        { 
                                                                                                                                                                                                                                        __context__.SourceCodeLine = 545;
                                                                                                                                                                                                                                        TEMP2__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 1 ) )  ) ; 
                                                                                                                                                                                                                                        __context__.SourceCodeLine = 547;
                                                                                                                                                                                                                                        TIME_ZONE__DOLLAR__  .UpdateValue ( TEMP2__DOLLAR__ + HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 6 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                                                                                                                        } 
                                                                                                                                                                                                                                    
                                                                                                                                                                                                                                    else 
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                        __context__.SourceCodeLine = 549;
                                                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0do" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                            { 
                                                                                                                                                                                                                                            __context__.SourceCodeLine = 551;
                                                                                                                                                                                                                                            DST_OFFSET_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                                                                                                                            } 
                                                                                                                                                                                                                                        
                                                                                                                                                                                                                                        else 
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                            __context__.SourceCodeLine = 553;
                                                                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0ds" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                { 
                                                                                                                                                                                                                                                __context__.SourceCodeLine = 555;
                                                                                                                                                                                                                                                DST_START_DATE_DATE__DOLLAR__  .UpdateValue ( MM_DD_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                                                                                                                                __context__.SourceCodeLine = 556;
                                                                                                                                                                                                                                                DST_START_DATE_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 9 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                                                                                                                                } 
                                                                                                                                                                                                                                            
                                                                                                                                                                                                                                            else 
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                __context__.SourceCodeLine = 558;
                                                                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0de" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                                                    __context__.SourceCodeLine = 560;
                                                                                                                                                                                                                                                    DST_END_DATE_DATE__DOLLAR__  .UpdateValue ( MM_DD_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 5 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                                                                                                                                    __context__.SourceCodeLine = 561;
                                                                                                                                                                                                                                                    DST_END_DATE_TIME__DOLLAR__  .UpdateValue ( HH_MM_F (  __context__ , Functions.Mid( TEMP__DOLLAR__ , (int)( 9 ) , (int)( 4 ) ))  ) ; 
                                                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                                                
                                                                                                                                                                                                                                                else 
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    __context__.SourceCodeLine = 567;
                                                                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0tn" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                        { 
                                                                                                                                                                                                                                                        __context__.SourceCodeLine = 569;
                                                                                                                                                                                                                                                        TRACK_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( Functions.Length( TEMP__DOLLAR__ ) ) )  ) ; 
                                                                                                                                                                                                                                                        } 
                                                                                                                                                                                                                                                    
                                                                                                                                                                                                                                                    else 
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                        __context__.SourceCodeLine = 571;
                                                                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0ts" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                            { 
                                                                                                                                                                                                                                                            __context__.SourceCodeLine = 573;
                                                                                                                                                                                                                                                            TRACK_SIZE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( Functions.Length( TEMP__DOLLAR__ ) ) )  ) ; 
                                                                                                                                                                                                                                                            } 
                                                                                                                                                                                                                                                        
                                                                                                                                                                                                                                                        else 
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                            __context__.SourceCodeLine = 576;
                                                                                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0tl" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                                { 
                                                                                                                                                                                                                                                                __context__.SourceCodeLine = 578;
                                                                                                                                                                                                                                                                CURRENT_TRACK_TIME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 7 ) )  ) ; 
                                                                                                                                                                                                                                                                } 
                                                                                                                                                                                                                                                            
                                                                                                                                                                                                                                                            else 
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                __context__.SourceCodeLine = 580;
                                                                                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0Tf" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                                                                    __context__.SourceCodeLine = 582;
                                                                                                                                                                                                                                                                    TOTAL_FOLDER_NUMBER__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( 4 ) )  ) ; 
                                                                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                                                                
                                                                                                                                                                                                                                                                else 
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                    __context__.SourceCodeLine = 584;
                                                                                                                                                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "@0Fn" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                                        { 
                                                                                                                                                                                                                                                                        __context__.SourceCodeLine = 586;
                                                                                                                                                                                                                                                                        FOLDER_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( Functions.Length( TEMP__DOLLAR__ ) ) )  ) ; 
                                                                                                                                                                                                                                                                        } 
                                                                                                                                                                                                                                                                    
                                                                                                                                                                                                                                                                    else 
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                        __context__.SourceCodeLine = 588;
                                                                                                                                                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "@0at" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                                            { 
                                                                                                                                                                                                                                                                            __context__.SourceCodeLine = 590;
                                                                                                                                                                                                                                                                            CURRENT_TRACK_ARTIST_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 5) ) )  ) ; 
                                                                                                                                                                                                                                                                            } 
                                                                                                                                                                                                                                                                        
                                                                                                                                                                                                                                                                        else 
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                            __context__.SourceCodeLine = 592;
                                                                                                                                                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "@0ti" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                                                { 
                                                                                                                                                                                                                                                                                __context__.SourceCodeLine = 594;
                                                                                                                                                                                                                                                                                CURRENT_TRACK_TITLE_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 5) ) )  ) ; 
                                                                                                                                                                                                                                                                                } 
                                                                                                                                                                                                                                                                            
                                                                                                                                                                                                                                                                            else 
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                __context__.SourceCodeLine = 596;
                                                                                                                                                                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "@0al" , TEMP__DOLLAR__ ))  ) ) 
                                                                                                                                                                                                                                                                                    { 
                                                                                                                                                                                                                                                                                    __context__.SourceCodeLine = 599;
                                                                                                                                                                                                                                                                                    CURRENT_TRACK_ALBUN_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMP__DOLLAR__ ,  (int) ( 5 ) ,  (int) ( (Functions.Length( TEMP__DOLLAR__ ) - 5) ) )  ) ; 
                                                                                                                                                                                                                                                                                    } 
                                                                                                                                                                                                                                                                                
                                                                                                                                                                                                                                                                                else 
                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                    __context__.SourceCodeLine = 605;
                                                                                                                                                                                                                                                                                    Functions.ClearBuffer ( TEMP__DOLLAR__ ) ; 
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
                        
                        __context__.SourceCodeLine = 205;
                        } 
                    
                    __context__.SourceCodeLine = 611;
                    RX_OK = (ushort) ( 1 ) ; 
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
            
            __context__.SourceCodeLine = 624;
            RX_OK = (ushort) ( 1 ) ; 
            
            
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
        TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
        TEMP2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
        
        IP_ADDRESS_DHCP_FB = new Crestron.Logos.SplusObjects.DigitalOutput( IP_ADDRESS_DHCP_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( IP_ADDRESS_DHCP_FB__DigitalOutput__, IP_ADDRESS_DHCP_FB );
        
        NTP_SERVER_IP_FB = new Crestron.Logos.SplusObjects.DigitalOutput( NTP_SERVER_IP_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( NTP_SERVER_IP_FB__DigitalOutput__, NTP_SERVER_IP_FB );
        
        SYSTEM_LOG_IP_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SYSTEM_LOG_IP_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( SYSTEM_LOG_IP_FB__DigitalOutput__, SYSTEM_LOG_IP_FB );
        
        TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
        
        DATE_TIME_YEAR_MONTH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DATE_TIME_YEAR_MONTH__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DATE_TIME_YEAR_MONTH__DOLLAR____AnalogSerialOutput__, DATE_TIME_YEAR_MONTH__DOLLAR__ );
        
        DATE_TIME_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DATE_TIME_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DATE_TIME_TIME__DOLLAR____AnalogSerialOutput__, DATE_TIME_TIME__DOLLAR__ );
        
        TOTAL_TRACK_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TOTAL_TRACK_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TOTAL_TRACK_NUMBER__DOLLAR____AnalogSerialOutput__, TOTAL_TRACK_NUMBER__DOLLAR__ );
        
        CURRENT_TRACK_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TRACK_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_TRACK_NUMBER__DOLLAR____AnalogSerialOutput__, CURRENT_TRACK_NUMBER__DOLLAR__ );
        
        CURRENT_TRACK_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TRACK_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_TRACK_NAME__DOLLAR____AnalogSerialOutput__, CURRENT_TRACK_NAME__DOLLAR__ );
        
        HOT_START_PLAY_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HOT_START_PLAY_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( HOT_START_PLAY_NUMBER__DOLLAR____AnalogSerialOutput__, HOT_START_PLAY_NUMBER__DOLLAR__ );
        
        ELAPSE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ELAPSE_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( ELAPSE_TIME__DOLLAR____AnalogSerialOutput__, ELAPSE_TIME__DOLLAR__ );
        
        REMAIN_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( REMAIN_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( REMAIN_TIME__DOLLAR____AnalogSerialOutput__, REMAIN_TIME__DOLLAR__ );
        
        RECORD_REMAIN_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RECORD_REMAIN_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( RECORD_REMAIN_TIME__DOLLAR____AnalogSerialOutput__, RECORD_REMAIN_TIME__DOLLAR__ );
        
        CURRENT_MEDIA_SD1_SIZE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEDIA_SD1_SIZE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_MEDIA_SD1_SIZE__DOLLAR____AnalogSerialOutput__, CURRENT_MEDIA_SD1_SIZE__DOLLAR__ );
        
        CURRENT_MEDIA_SD2_SIZE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEDIA_SD2_SIZE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_MEDIA_SD2_SIZE__DOLLAR____AnalogSerialOutput__, CURRENT_MEDIA_SD2_SIZE__DOLLAR__ );
        
        CURRENT_MEDIA_USB_SIZE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEDIA_USB_SIZE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_MEDIA_USB_SIZE__DOLLAR____AnalogSerialOutput__, CURRENT_MEDIA_USB_SIZE__DOLLAR__ );
        
        CURRENT_MEDIA_FOLDER_NAME_MEDIA__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEDIA_FOLDER_NAME_MEDIA__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_MEDIA_FOLDER_NAME_MEDIA__DOLLAR____AnalogSerialOutput__, CURRENT_MEDIA_FOLDER_NAME_MEDIA__DOLLAR__ );
        
        CURRENT_MEDIA_FOLDER_NAME_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_MEDIA_FOLDER_NAME_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_MEDIA_FOLDER_NAME_NAME__DOLLAR____AnalogSerialOutput__, CURRENT_MEDIA_FOLDER_NAME_NAME__DOLLAR__ );
        
        RECORD_VOLUME_LEFT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RECORD_VOLUME_LEFT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( RECORD_VOLUME_LEFT__DOLLAR____AnalogSerialOutput__, RECORD_VOLUME_LEFT__DOLLAR__ );
        
        RECORD_VOLUME_RIGHT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RECORD_VOLUME_RIGHT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( RECORD_VOLUME_RIGHT__DOLLAR____AnalogSerialOutput__, RECORD_VOLUME_RIGHT__DOLLAR__ );
        
        PITCH_ONOFF__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PITCH_ONOFF__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PITCH_ONOFF__DOLLAR____AnalogSerialOutput__, PITCH_ONOFF__DOLLAR__ );
        
        PITCH_VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PITCH_VALUE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PITCH_VALUE__DOLLAR____AnalogSerialOutput__, PITCH_VALUE__DOLLAR__ );
        
        TOTAL_MARK_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TOTAL_MARK_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TOTAL_MARK_NUMBER__DOLLAR____AnalogSerialOutput__, TOTAL_MARK_NUMBER__DOLLAR__ );
        
        MARK_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MARK_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MARK_TIME__DOLLAR____AnalogSerialOutput__, MARK_TIME__DOLLAR__ );
        
        PRESET_TITLE_NAME_NOS_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET_TITLE_NAME_NOS_1__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PRESET_TITLE_NAME_NOS_1__DOLLAR____AnalogSerialOutput__, PRESET_TITLE_NAME_NOS_1__DOLLAR__ );
        
        PRESET_TITLE_NAME_NOS_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET_TITLE_NAME_NOS_2__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PRESET_TITLE_NAME_NOS_2__DOLLAR____AnalogSerialOutput__, PRESET_TITLE_NAME_NOS_2__DOLLAR__ );
        
        PRESET_TITLE_NAME_NOS_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( PRESET_TITLE_NAME_NOS_3__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( PRESET_TITLE_NAME_NOS_3__DOLLAR____AnalogSerialOutput__, PRESET_TITLE_NAME_NOS_3__DOLLAR__ );
        
        SKIP_BACK_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SKIP_BACK_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SKIP_BACK_TIME__DOLLAR____AnalogSerialOutput__, SKIP_BACK_TIME__DOLLAR__ );
        
        SCHEDULE_DAY_OF_WEEK_WEEK__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SCHEDULE_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__, SCHEDULE_DAY_OF_WEEK_WEEK__DOLLAR__ );
        
        SCHEDULE_DAY_OF_WEEK_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_DAY_OF_WEEK_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SCHEDULE_DAY_OF_WEEK_TIME__DOLLAR____AnalogSerialOutput__, SCHEDULE_DAY_OF_WEEK_TIME__DOLLAR__ );
        
        SCHEDULE_DATE_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_DATE_DATE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SCHEDULE_DATE_DATE__DOLLAR____AnalogSerialOutput__, SCHEDULE_DATE_DATE__DOLLAR__ );
        
        SCHEDULE_DATE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_DATE_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SCHEDULE_DATE_TIME__DOLLAR____AnalogSerialOutput__, SCHEDULE_DATE_TIME__DOLLAR__ );
        
        SERVER_IP_ADDRESS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SERVER_IP_ADDRESS__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SERVER_IP_ADDRESS__DOLLAR____AnalogSerialOutput__, SERVER_IP_ADDRESS__DOLLAR__ );
        
        SERVER_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SERVER_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SERVER_NAME__DOLLAR____AnalogSerialOutput__, SERVER_NAME__DOLLAR__ );
        
        SERVER_FOLDER_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SERVER_FOLDER_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SERVER_FOLDER_NAME__DOLLAR____AnalogSerialOutput__, SERVER_FOLDER_NAME__DOLLAR__ );
        
        TIME_REC_SET_DAY_OF_WEEK_WEEK__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DAY_OF_WEEK_WEEK__DOLLAR__ );
        
        TIME_REC_SET_DAY_OF_WEEK_START_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DAY_OF_WEEK_START_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DAY_OF_WEEK_START_TIME__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DAY_OF_WEEK_START_TIME__DOLLAR__ );
        
        TIME_REC_SET_DAY_OF_WEEK_END_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DAY_OF_WEEK_END_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DAY_OF_WEEK_END_TIME__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DAY_OF_WEEK_END_TIME__DOLLAR__ );
        
        TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR__ );
        
        TIME_REC_SET_DATE_AND_TIME_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DATE_AND_TIME_DATE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DATE_AND_TIME_DATE__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DATE_AND_TIME_DATE__DOLLAR__ );
        
        TIME_REC_SET_DATE_AND_TIME_START_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DATE_AND_TIME_START_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DATE_AND_TIME_START_TIME__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DATE_AND_TIME_START_TIME__DOLLAR__ );
        
        TIME_REC_SET_DATE_AND_TIME_END_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DATE_AND_TIME_END_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DATE_AND_TIME_END_TIME__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DATE_AND_TIME_END_TIME__DOLLAR__ );
        
        TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR____AnalogSerialOutput__, TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR__ );
        
        TIME_PLAY_SET_DAY_OF_WEEK_WEEK__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_PLAY_SET_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_PLAY_SET_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__, TIME_PLAY_SET_DAY_OF_WEEK_WEEK__DOLLAR__ );
        
        TIME_PLAY_SET_DAY_OF_WEEK_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_PLAY_SET_DAY_OF_WEEK_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_PLAY_SET_DAY_OF_WEEK_TIME__DOLLAR____AnalogSerialOutput__, TIME_PLAY_SET_DAY_OF_WEEK_TIME__DOLLAR__ );
        
        TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR____AnalogSerialOutput__, TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR__ );
        
        TIME_PLAY_SET_DATE_AND_TIME_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_PLAY_SET_DATE_AND_TIME_DATE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_PLAY_SET_DATE_AND_TIME_DATE__DOLLAR____AnalogSerialOutput__, TIME_PLAY_SET_DATE_AND_TIME_DATE__DOLLAR__ );
        
        TIME_PLAY_SET_DATE_AND_TIME_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_PLAY_SET_DATE_AND_TIME_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_PLAY_SET_DATE_AND_TIME_TIME__DOLLAR____AnalogSerialOutput__, TIME_PLAY_SET_DATE_AND_TIME_TIME__DOLLAR__ );
        
        TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR____AnalogSerialOutput__, TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR__ );
        
        CURRENT_REC_TIMER_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_REC_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_REC_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, CURRENT_REC_TIMER_NUMBER__DOLLAR__ );
        
        CURRENT_PLAY_TIMER_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_PLAY_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_PLAY_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, CURRENT_PLAY_TIMER_NUMBER__DOLLAR__ );
        
        RESERVED_REC_TIMER_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVED_REC_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( RESERVED_REC_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, RESERVED_REC_TIMER_NUMBER__DOLLAR__ );
        
        RESERVED_PLAY_TIMER_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( RESERVED_PLAY_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( RESERVED_PLAY_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__, RESERVED_PLAY_TIMER_NUMBER__DOLLAR__ );
        
        HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR____AnalogSerialOutput__, HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR__ );
        
        HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR____AnalogSerialOutput__, HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR__ );
        
        HOT_START_SET_FILE_INFOM_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HOT_START_SET_FILE_INFOM_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( HOT_START_SET_FILE_INFOM_TIME__DOLLAR____AnalogSerialOutput__, HOT_START_SET_FILE_INFOM_TIME__DOLLAR__ );
        
        REC_FOLDER_FIXED_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( REC_FOLDER_FIXED_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( REC_FOLDER_FIXED_NAME__DOLLAR____AnalogSerialOutput__, REC_FOLDER_FIXED_NAME__DOLLAR__ );
        
        USER_AREA_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USER_AREA_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( USER_AREA_NAME__DOLLAR____AnalogSerialOutput__, USER_AREA_NAME__DOLLAR__ );
        
        MIC_INPUT_SENS_LEFT_VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MIC_INPUT_SENS_LEFT_VALUE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MIC_INPUT_SENS_LEFT_VALUE__DOLLAR____AnalogSerialOutput__, MIC_INPUT_SENS_LEFT_VALUE__DOLLAR__ );
        
        MIC_INPUT_SENS_RIGHT_VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MIC_INPUT_SENS_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MIC_INPUT_SENS_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__, MIC_INPUT_SENS_RIGHT_VALUE__DOLLAR__ );
        
        INPUT_TRIUM_LEFT_VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( INPUT_TRIUM_LEFT_VALUE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( INPUT_TRIUM_LEFT_VALUE__DOLLAR____AnalogSerialOutput__, INPUT_TRIUM_LEFT_VALUE__DOLLAR__ );
        
        INPUT_TRIUM_RIGHT_VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( INPUT_TRIUM_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( INPUT_TRIUM_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__, INPUT_TRIUM_RIGHT_VALUE__DOLLAR__ );
        
        OUTPUT_TRIUM_LEFT_VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OUTPUT_TRIUM_LEFT_VALUE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( OUTPUT_TRIUM_LEFT_VALUE__DOLLAR____AnalogSerialOutput__, OUTPUT_TRIUM_LEFT_VALUE__DOLLAR__ );
        
        OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__, OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR__ );
        
        MACHINE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MACHINE_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MACHINE_NAME__DOLLAR____AnalogSerialOutput__, MACHINE_NAME__DOLLAR__ );
        
        IP_ADDRESS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IP_ADDRESS__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( IP_ADDRESS__DOLLAR____AnalogSerialOutput__, IP_ADDRESS__DOLLAR__ );
        
        MASK_IP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MASK_IP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MASK_IP__DOLLAR____AnalogSerialOutput__, MASK_IP__DOLLAR__ );
        
        GATEWAY_IP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( GATEWAY_IP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( GATEWAY_IP__DOLLAR____AnalogSerialOutput__, GATEWAY_IP__DOLLAR__ );
        
        SERVER_IP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SERVER_IP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SERVER_IP__DOLLAR____AnalogSerialOutput__, SERVER_IP__DOLLAR__ );
        
        IP_CONTROL_PORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IP_CONTROL_PORT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( IP_CONTROL_PORT__DOLLAR____AnalogSerialOutput__, IP_CONTROL_PORT__DOLLAR__ );
        
        NTP_SERVER_IP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NTP_SERVER_IP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( NTP_SERVER_IP__DOLLAR____AnalogSerialOutput__, NTP_SERVER_IP__DOLLAR__ );
        
        SYSTEM_LOG_IP__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SYSTEM_LOG_IP__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( SYSTEM_LOG_IP__DOLLAR____AnalogSerialOutput__, SYSTEM_LOG_IP__DOLLAR__ );
        
        TIME_ZONE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TIME_ZONE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TIME_ZONE__DOLLAR____AnalogSerialOutput__, TIME_ZONE__DOLLAR__ );
        
        DST_OFFSET_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DST_OFFSET_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DST_OFFSET_TIME__DOLLAR____AnalogSerialOutput__, DST_OFFSET_TIME__DOLLAR__ );
        
        DST_START_DATE_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DST_START_DATE_DATE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DST_START_DATE_DATE__DOLLAR____AnalogSerialOutput__, DST_START_DATE_DATE__DOLLAR__ );
        
        DST_START_DATE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DST_START_DATE_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DST_START_DATE_TIME__DOLLAR____AnalogSerialOutput__, DST_START_DATE_TIME__DOLLAR__ );
        
        DST_END_DATE_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DST_END_DATE_DATE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DST_END_DATE_DATE__DOLLAR____AnalogSerialOutput__, DST_END_DATE_DATE__DOLLAR__ );
        
        DST_END_DATE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DST_END_DATE_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( DST_END_DATE_TIME__DOLLAR____AnalogSerialOutput__, DST_END_DATE_TIME__DOLLAR__ );
        
        TRACK_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TRACK_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TRACK_NAME__DOLLAR____AnalogSerialOutput__, TRACK_NAME__DOLLAR__ );
        
        TRACK_SIZE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TRACK_SIZE__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TRACK_SIZE__DOLLAR____AnalogSerialOutput__, TRACK_SIZE__DOLLAR__ );
        
        CURRENT_TRACK_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TRACK_TIME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_TRACK_TIME__DOLLAR____AnalogSerialOutput__, CURRENT_TRACK_TIME__DOLLAR__ );
        
        TOTAL_FOLDER_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TOTAL_FOLDER_NUMBER__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TOTAL_FOLDER_NUMBER__DOLLAR____AnalogSerialOutput__, TOTAL_FOLDER_NUMBER__DOLLAR__ );
        
        FOLDER_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FOLDER_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( FOLDER_NAME__DOLLAR____AnalogSerialOutput__, FOLDER_NAME__DOLLAR__ );
        
        CURRENT_TRACK_ARTIST_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TRACK_ARTIST_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_TRACK_ARTIST_NAME__DOLLAR____AnalogSerialOutput__, CURRENT_TRACK_ARTIST_NAME__DOLLAR__ );
        
        CURRENT_TRACK_TITLE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TRACK_TITLE_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_TRACK_TITLE_NAME__DOLLAR____AnalogSerialOutput__, CURRENT_TRACK_TITLE_NAME__DOLLAR__ );
        
        CURRENT_TRACK_ALBUN_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TRACK_ALBUN_NAME__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( CURRENT_TRACK_ALBUN_NAME__DOLLAR____AnalogSerialOutput__, CURRENT_TRACK_ALBUN_NAME__DOLLAR__ );
        
        FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 1024, this );
        m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
        
        
        FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_DENON_DN_700R_V1_0_RECEIVER_EXTRACK ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 0;
    const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 0;
    const uint DATE_TIME_YEAR_MONTH__DOLLAR____AnalogSerialOutput__ = 1;
    const uint DATE_TIME_TIME__DOLLAR____AnalogSerialOutput__ = 2;
    const uint TOTAL_TRACK_NUMBER__DOLLAR____AnalogSerialOutput__ = 3;
    const uint CURRENT_TRACK_NUMBER__DOLLAR____AnalogSerialOutput__ = 4;
    const uint CURRENT_TRACK_NAME__DOLLAR____AnalogSerialOutput__ = 5;
    const uint HOT_START_PLAY_NUMBER__DOLLAR____AnalogSerialOutput__ = 6;
    const uint ELAPSE_TIME__DOLLAR____AnalogSerialOutput__ = 7;
    const uint REMAIN_TIME__DOLLAR____AnalogSerialOutput__ = 8;
    const uint RECORD_REMAIN_TIME__DOLLAR____AnalogSerialOutput__ = 9;
    const uint CURRENT_MEDIA_SD1_SIZE__DOLLAR____AnalogSerialOutput__ = 10;
    const uint CURRENT_MEDIA_SD2_SIZE__DOLLAR____AnalogSerialOutput__ = 11;
    const uint CURRENT_MEDIA_USB_SIZE__DOLLAR____AnalogSerialOutput__ = 12;
    const uint CURRENT_MEDIA_FOLDER_NAME_MEDIA__DOLLAR____AnalogSerialOutput__ = 13;
    const uint CURRENT_MEDIA_FOLDER_NAME_NAME__DOLLAR____AnalogSerialOutput__ = 14;
    const uint RECORD_VOLUME_LEFT__DOLLAR____AnalogSerialOutput__ = 15;
    const uint RECORD_VOLUME_RIGHT__DOLLAR____AnalogSerialOutput__ = 16;
    const uint PITCH_ONOFF__DOLLAR____AnalogSerialOutput__ = 17;
    const uint PITCH_VALUE__DOLLAR____AnalogSerialOutput__ = 18;
    const uint TOTAL_MARK_NUMBER__DOLLAR____AnalogSerialOutput__ = 19;
    const uint MARK_TIME__DOLLAR____AnalogSerialOutput__ = 20;
    const uint PRESET_TITLE_NAME_NOS_1__DOLLAR____AnalogSerialOutput__ = 21;
    const uint PRESET_TITLE_NAME_NOS_2__DOLLAR____AnalogSerialOutput__ = 22;
    const uint PRESET_TITLE_NAME_NOS_3__DOLLAR____AnalogSerialOutput__ = 23;
    const uint SKIP_BACK_TIME__DOLLAR____AnalogSerialOutput__ = 24;
    const uint SCHEDULE_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__ = 25;
    const uint SCHEDULE_DAY_OF_WEEK_TIME__DOLLAR____AnalogSerialOutput__ = 26;
    const uint SCHEDULE_DATE_DATE__DOLLAR____AnalogSerialOutput__ = 27;
    const uint SCHEDULE_DATE_TIME__DOLLAR____AnalogSerialOutput__ = 28;
    const uint SERVER_IP_ADDRESS__DOLLAR____AnalogSerialOutput__ = 29;
    const uint SERVER_NAME__DOLLAR____AnalogSerialOutput__ = 30;
    const uint SERVER_FOLDER_NAME__DOLLAR____AnalogSerialOutput__ = 31;
    const uint TIME_REC_SET_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__ = 32;
    const uint TIME_REC_SET_DAY_OF_WEEK_START_TIME__DOLLAR____AnalogSerialOutput__ = 33;
    const uint TIME_REC_SET_DAY_OF_WEEK_END_TIME__DOLLAR____AnalogSerialOutput__ = 34;
    const uint TIME_REC_SET_DAY_OF_WEEK_USER_AREA__DOLLAR____AnalogSerialOutput__ = 35;
    const uint TIME_REC_SET_DATE_AND_TIME_DATE__DOLLAR____AnalogSerialOutput__ = 36;
    const uint TIME_REC_SET_DATE_AND_TIME_START_TIME__DOLLAR____AnalogSerialOutput__ = 37;
    const uint TIME_REC_SET_DATE_AND_TIME_END_TIME__DOLLAR____AnalogSerialOutput__ = 38;
    const uint TIME_REC_SET_DATE_AND_TIME_USER_AREA__DOLLAR____AnalogSerialOutput__ = 39;
    const uint TIME_PLAY_SET_DAY_OF_WEEK_WEEK__DOLLAR____AnalogSerialOutput__ = 40;
    const uint TIME_PLAY_SET_DAY_OF_WEEK_TIME__DOLLAR____AnalogSerialOutput__ = 41;
    const uint TIME_PLAY_SET_DAY_OF_WEEK_NAME__DOLLAR____AnalogSerialOutput__ = 42;
    const uint TIME_PLAY_SET_DATE_AND_TIME_DATE__DOLLAR____AnalogSerialOutput__ = 43;
    const uint TIME_PLAY_SET_DATE_AND_TIME_TIME__DOLLAR____AnalogSerialOutput__ = 44;
    const uint TIME_PLAY_SET_DATE_AND_TIME_NAME__DOLLAR____AnalogSerialOutput__ = 45;
    const uint CURRENT_REC_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__ = 46;
    const uint CURRENT_PLAY_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__ = 47;
    const uint RESERVED_REC_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__ = 48;
    const uint RESERVED_PLAY_TIMER_NUMBER__DOLLAR____AnalogSerialOutput__ = 49;
    const uint HOT_START_SET_FILE_INFOM_NUMBER__DOLLAR____AnalogSerialOutput__ = 50;
    const uint HOT_START_SET_FILE_INFOM_FILE_NAME__DOLLAR____AnalogSerialOutput__ = 51;
    const uint HOT_START_SET_FILE_INFOM_TIME__DOLLAR____AnalogSerialOutput__ = 52;
    const uint REC_FOLDER_FIXED_NAME__DOLLAR____AnalogSerialOutput__ = 53;
    const uint USER_AREA_NAME__DOLLAR____AnalogSerialOutput__ = 54;
    const uint MIC_INPUT_SENS_LEFT_VALUE__DOLLAR____AnalogSerialOutput__ = 55;
    const uint MIC_INPUT_SENS_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__ = 56;
    const uint INPUT_TRIUM_LEFT_VALUE__DOLLAR____AnalogSerialOutput__ = 57;
    const uint INPUT_TRIUM_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__ = 58;
    const uint OUTPUT_TRIUM_LEFT_VALUE__DOLLAR____AnalogSerialOutput__ = 59;
    const uint OUTPUT_TRIUM_RIGHT_VALUE__DOLLAR____AnalogSerialOutput__ = 60;
    const uint MACHINE_NAME__DOLLAR____AnalogSerialOutput__ = 61;
    const uint IP_ADDRESS__DOLLAR____AnalogSerialOutput__ = 62;
    const uint IP_ADDRESS_DHCP_FB__DigitalOutput__ = 0;
    const uint MASK_IP__DOLLAR____AnalogSerialOutput__ = 63;
    const uint GATEWAY_IP__DOLLAR____AnalogSerialOutput__ = 64;
    const uint SERVER_IP__DOLLAR____AnalogSerialOutput__ = 65;
    const uint IP_CONTROL_PORT__DOLLAR____AnalogSerialOutput__ = 66;
    const uint NTP_SERVER_IP__DOLLAR____AnalogSerialOutput__ = 67;
    const uint NTP_SERVER_IP_FB__DigitalOutput__ = 1;
    const uint SYSTEM_LOG_IP__DOLLAR____AnalogSerialOutput__ = 68;
    const uint SYSTEM_LOG_IP_FB__DigitalOutput__ = 2;
    const uint TIME_ZONE__DOLLAR____AnalogSerialOutput__ = 69;
    const uint DST_OFFSET_TIME__DOLLAR____AnalogSerialOutput__ = 70;
    const uint DST_START_DATE_DATE__DOLLAR____AnalogSerialOutput__ = 71;
    const uint DST_START_DATE_TIME__DOLLAR____AnalogSerialOutput__ = 72;
    const uint DST_END_DATE_DATE__DOLLAR____AnalogSerialOutput__ = 73;
    const uint DST_END_DATE_TIME__DOLLAR____AnalogSerialOutput__ = 74;
    const uint TRACK_NAME__DOLLAR____AnalogSerialOutput__ = 75;
    const uint TRACK_SIZE__DOLLAR____AnalogSerialOutput__ = 76;
    const uint CURRENT_TRACK_TIME__DOLLAR____AnalogSerialOutput__ = 77;
    const uint TOTAL_FOLDER_NUMBER__DOLLAR____AnalogSerialOutput__ = 78;
    const uint FOLDER_NAME__DOLLAR____AnalogSerialOutput__ = 79;
    const uint CURRENT_TRACK_ARTIST_NAME__DOLLAR____AnalogSerialOutput__ = 80;
    const uint CURRENT_TRACK_TITLE_NAME__DOLLAR____AnalogSerialOutput__ = 81;
    const uint CURRENT_TRACK_ALBUN_NAME__DOLLAR____AnalogSerialOutput__ = 82;
    
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
