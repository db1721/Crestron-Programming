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

namespace UserModule_VADDIO_ROBOSHOT_30_V1_0_PROCESSOR
{
    public class UserModuleClass_VADDIO_ROBOSHOT_30_V1_0_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput CHECKZOOM;
        Crestron.Logos.SplusObjects.DigitalInput EVI_D30;
        Crestron.Logos.SplusObjects.DigitalInput EVI_D70;
        Crestron.Logos.SplusObjects.DigitalInput EVI_D100;
        Crestron.Logos.SplusObjects.DigitalInput BRC_300;
        Crestron.Logos.SplusObjects.AnalogInput ADDRESS;
        Crestron.Logos.SplusObjects.StringInput PAN_SPEED_1;
        Crestron.Logos.SplusObjects.StringInput PAN_SPEED_2;
        Crestron.Logos.SplusObjects.StringInput PAN_SPEED_3;
        Crestron.Logos.SplusObjects.StringInput TILT_SPEED_1;
        Crestron.Logos.SplusObjects.StringInput TILT_SPEED_2;
        Crestron.Logos.SplusObjects.StringInput ZOOM_SPEED_1;
        Crestron.Logos.SplusObjects.StringInput ZOOM_SPEED_2;
        Crestron.Logos.SplusObjects.BufferInput FROMDEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput ZOOMIN;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOMSCALE;
        Crestron.Logos.SplusObjects.AnalogOutput PAN_SPEED_1_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput PAN_SPEED_2_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput PAN_SPEED_3_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput TILT_SPEED_1_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput TILT_SPEED_2_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM_IN_SPEED_1_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM_IN_SPEED_2_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM_OUT_SPEED_1_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput ZOOM_OUT_SPEED_2_OUT;
        Crestron.Logos.SplusObjects.StringOutput TODEVICE__DOLLAR__;
        object CHECKZOOM_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 112;
                _SplusNVRAM.ZOOMWAITING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 113;
                TODEVICE__DOLLAR__  .UpdateValue ( Functions.Chr (  (int) ( _SplusNVRAM.OUTHEADER ) ) + "\u0009\u0004\u0047\u00FF"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object EVI_D30_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 118;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA != 1))  ) ) 
                { 
                __context__.SourceCodeLine = 120;
                _SplusNVRAM.ICAMERA = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 121;
                PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 1 ] ) ; 
                __context__.SourceCodeLine = 122;
                PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 1 ] ) ; 
                __context__.SourceCodeLine = 123;
                PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 1 ] ) ; 
                __context__.SourceCodeLine = 124;
                TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 1 ] ) ; 
                __context__.SourceCodeLine = 125;
                TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 1 ] ) ; 
                __context__.SourceCodeLine = 126;
                ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 1 ] ) ; 
                __context__.SourceCodeLine = 127;
                ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 1 ] ) ; 
                __context__.SourceCodeLine = 128;
                ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 1 ] ) ; 
                __context__.SourceCodeLine = 129;
                ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 1 ] ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object EVI_D70_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA != 2))  ) ) 
            { 
            __context__.SourceCodeLine = 137;
            _SplusNVRAM.ICAMERA = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 138;
            PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 2 ] ) ; 
            __context__.SourceCodeLine = 139;
            PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 2 ] ) ; 
            __context__.SourceCodeLine = 140;
            PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 2 ] ) ; 
            __context__.SourceCodeLine = 141;
            TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 2 ] ) ; 
            __context__.SourceCodeLine = 142;
            TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 2 ] ) ; 
            __context__.SourceCodeLine = 143;
            ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 2 ] ) ; 
            __context__.SourceCodeLine = 144;
            ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 2 ] ) ; 
            __context__.SourceCodeLine = 145;
            ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 2 ] ) ; 
            __context__.SourceCodeLine = 146;
            ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 2 ] ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EVI_D100_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 152;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA != 3))  ) ) 
            { 
            __context__.SourceCodeLine = 154;
            _SplusNVRAM.ICAMERA = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 155;
            PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 3 ] ) ; 
            __context__.SourceCodeLine = 156;
            PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 3 ] ) ; 
            __context__.SourceCodeLine = 157;
            PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 3 ] ) ; 
            __context__.SourceCodeLine = 158;
            TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 3 ] ) ; 
            __context__.SourceCodeLine = 159;
            TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 3 ] ) ; 
            __context__.SourceCodeLine = 160;
            ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 3 ] ) ; 
            __context__.SourceCodeLine = 161;
            ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 3 ] ) ; 
            __context__.SourceCodeLine = 162;
            ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 3 ] ) ; 
            __context__.SourceCodeLine = 163;
            ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 3 ] ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BRC_300_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 169;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA != 4))  ) ) 
            { 
            __context__.SourceCodeLine = 171;
            _SplusNVRAM.ICAMERA = (ushort) ( 4 ) ; 
            __context__.SourceCodeLine = 172;
            PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 4 ] ) ; 
            __context__.SourceCodeLine = 173;
            PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 4 ] ) ; 
            __context__.SourceCodeLine = 174;
            PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 4 ] ) ; 
            __context__.SourceCodeLine = 175;
            TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 4 ] ) ; 
            __context__.SourceCodeLine = 176;
            TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 4 ] ) ; 
            __context__.SourceCodeLine = 177;
            ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 4 ] ) ; 
            __context__.SourceCodeLine = 178;
            ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 4 ] ) ; 
            __context__.SourceCodeLine = 179;
            ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 4 ] ) ; 
            __context__.SourceCodeLine = 180;
            ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 4 ] ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROMDEVICE__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 187;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 189;
            _SplusNVRAM.SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 190;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u00FF" , FROMDEVICE__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 192;
                _SplusNVRAM.TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u00FF" , FROMDEVICE__DOLLAR__ , 1)  ) ; 
                __context__.SourceCodeLine = 193;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.ZOOMWAITING == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 1 ) ) == _SplusNVRAM.INHEADER) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 195;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 2 ) ) == 80))  ) ) 
                        { 
                        __context__.SourceCodeLine = 198;
                        _SplusNVRAM.ZOOMWAITING = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 199;
                        ZOOMSCALE  .Value = (ushort) ( ((((Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 3 ) ) * 4096) + (Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 4 ) ) * 256)) + (Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 5 ) ) * 16)) + Byte( _SplusNVRAM.TEMPSTRING__DOLLAR__ , (int)( 6 ) )) ) ; 
                        __context__.SourceCodeLine = 200;
                        ZOOMIN  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 201;
                        Functions.ProcessLogic ( ) ; 
                        __context__.SourceCodeLine = 202;
                        ZOOMIN  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 190;
                } 
            
            __context__.SourceCodeLine = 206;
            _SplusNVRAM.SEMAPHORE = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 212;
        _SplusNVRAM.OUTHEADER = (ushort) ( (ADDRESS  .UshortValue + 128) ) ; 
        __context__.SourceCodeLine = 213;
        _SplusNVRAM.INHEADER = (ushort) ( ((ADDRESS  .UshortValue * 16) + 128) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_SPEED_1_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 218;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( PAN_SPEED_1 ) >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( PAN_SPEED_1 ) <= 24 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 220;
            _SplusNVRAM.IPANSPEED [ 1 , 1] = (ushort) ( Functions.Atoi( PAN_SPEED_1 ) ) ; 
            __context__.SourceCodeLine = 221;
            _SplusNVRAM.IPANSPEED [ 1 , 2] = (ushort) ( Functions.Atoi( PAN_SPEED_1 ) ) ; 
            __context__.SourceCodeLine = 222;
            _SplusNVRAM.IPANSPEED [ 1 , 3] = (ushort) ( Functions.Atoi( PAN_SPEED_1 ) ) ; 
            __context__.SourceCodeLine = 223;
            _SplusNVRAM.IPANSPEED [ 1 , 4] = (ushort) ( Functions.Atoi( PAN_SPEED_1 ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 227;
            _SplusNVRAM.IPANSPEED [ 1 , 1] = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 228;
            _SplusNVRAM.IPANSPEED [ 1 , 2] = (ushort) ( 5 ) ; 
            __context__.SourceCodeLine = 229;
            _SplusNVRAM.IPANSPEED [ 1 , 3] = (ushort) ( 12 ) ; 
            __context__.SourceCodeLine = 230;
            _SplusNVRAM.IPANSPEED [ 1 , 4] = (ushort) ( 12 ) ; 
            } 
        
        __context__.SourceCodeLine = 232;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 234;
            PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 1 ] ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 236;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 238;
                PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 2 ] ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 240;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 242;
                    PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 3 ] ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 244;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 246;
                        PAN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 1 , 4 ] ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_SPEED_2_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 252;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( PAN_SPEED_2 ) >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( PAN_SPEED_2 ) <= 24 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 254;
            _SplusNVRAM.IPANSPEED [ 2 , 1] = (ushort) ( Functions.Atoi( PAN_SPEED_2 ) ) ; 
            __context__.SourceCodeLine = 255;
            _SplusNVRAM.IPANSPEED [ 2 , 2] = (ushort) ( Functions.Atoi( PAN_SPEED_2 ) ) ; 
            __context__.SourceCodeLine = 256;
            _SplusNVRAM.IPANSPEED [ 2 , 3] = (ushort) ( Functions.Atoi( PAN_SPEED_2 ) ) ; 
            __context__.SourceCodeLine = 257;
            _SplusNVRAM.IPANSPEED [ 2 , 4] = (ushort) ( Functions.Atoi( PAN_SPEED_2 ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 261;
            _SplusNVRAM.IPANSPEED [ 2 , 1] = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 262;
            _SplusNVRAM.IPANSPEED [ 2 , 2] = (ushort) ( 10 ) ; 
            __context__.SourceCodeLine = 263;
            _SplusNVRAM.IPANSPEED [ 2 , 3] = (ushort) ( 15 ) ; 
            __context__.SourceCodeLine = 264;
            _SplusNVRAM.IPANSPEED [ 2 , 4] = (ushort) ( 15 ) ; 
            } 
        
        __context__.SourceCodeLine = 266;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 268;
            PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 1 ] ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 270;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 272;
                PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 2 ] ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 274;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 276;
                    PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 3 ] ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 278;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 280;
                        PAN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 2 , 4 ] ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PAN_SPEED_3_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 286;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( PAN_SPEED_3 ) >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( PAN_SPEED_3 ) <= 24 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 288;
            _SplusNVRAM.IPANSPEED [ 3 , 1] = (ushort) ( Functions.Atoi( PAN_SPEED_3 ) ) ; 
            __context__.SourceCodeLine = 289;
            _SplusNVRAM.IPANSPEED [ 3 , 2] = (ushort) ( Functions.Atoi( PAN_SPEED_3 ) ) ; 
            __context__.SourceCodeLine = 290;
            _SplusNVRAM.IPANSPEED [ 3 , 3] = (ushort) ( Functions.Atoi( PAN_SPEED_3 ) ) ; 
            __context__.SourceCodeLine = 291;
            _SplusNVRAM.IPANSPEED [ 3 , 4] = (ushort) ( Functions.Atoi( PAN_SPEED_3 ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 295;
            _SplusNVRAM.IPANSPEED [ 3 , 1] = (ushort) ( 18 ) ; 
            __context__.SourceCodeLine = 296;
            _SplusNVRAM.IPANSPEED [ 3 , 2] = (ushort) ( 18 ) ; 
            __context__.SourceCodeLine = 297;
            _SplusNVRAM.IPANSPEED [ 3 , 3] = (ushort) ( 18 ) ; 
            __context__.SourceCodeLine = 298;
            _SplusNVRAM.IPANSPEED [ 3 , 4] = (ushort) ( 18 ) ; 
            } 
        
        __context__.SourceCodeLine = 300;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 302;
            PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 1 ] ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 304;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 306;
                PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 2 ] ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 308;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 310;
                    PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 3 ] ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 312;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 314;
                        PAN_SPEED_3_OUT  .Value = (ushort) ( _SplusNVRAM.IPANSPEED[ 3 , 4 ] ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TILT_SPEED_1_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 320;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( TILT_SPEED_1 ) >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( TILT_SPEED_1 ) <= 23 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 322;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( TILT_SPEED_1 ) > 20 ))  ) ) 
                { 
                __context__.SourceCodeLine = 324;
                _SplusNVRAM.ITILTSPEED [ 1 , 1] = (ushort) ( 14 ) ; 
                __context__.SourceCodeLine = 325;
                _SplusNVRAM.ITILTSPEED [ 1 , 3] = (ushort) ( 14 ) ; 
                __context__.SourceCodeLine = 326;
                _SplusNVRAM.ITILTSPEED [ 1 , 4] = (ushort) ( 14 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 330;
                _SplusNVRAM.ITILTSPEED [ 1 , 1] = (ushort) ( Functions.Atoi( TILT_SPEED_1 ) ) ; 
                __context__.SourceCodeLine = 331;
                _SplusNVRAM.ITILTSPEED [ 1 , 3] = (ushort) ( Functions.Atoi( TILT_SPEED_1 ) ) ; 
                __context__.SourceCodeLine = 332;
                _SplusNVRAM.ITILTSPEED [ 1 , 4] = (ushort) ( Functions.Atoi( TILT_SPEED_1 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 334;
            _SplusNVRAM.ITILTSPEED [ 1 , 2] = (ushort) ( Functions.Atoi( TILT_SPEED_1 ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 338;
            _SplusNVRAM.ITILTSPEED [ 1 , 1] = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 339;
            _SplusNVRAM.ITILTSPEED [ 1 , 2] = (ushort) ( 3 ) ; 
            __context__.SourceCodeLine = 340;
            _SplusNVRAM.ITILTSPEED [ 1 , 3] = (ushort) ( 7 ) ; 
            __context__.SourceCodeLine = 341;
            _SplusNVRAM.ITILTSPEED [ 1 , 4] = (ushort) ( 7 ) ; 
            } 
        
        __context__.SourceCodeLine = 343;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 345;
            TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 1 ] ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 347;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 349;
                TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 2 ] ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 351;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 353;
                    TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 3 ] ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 355;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 357;
                        TILT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 1 , 4 ] ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TILT_SPEED_2_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 363;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( TILT_SPEED_2 ) >= 1 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( TILT_SPEED_2 ) <= 23 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 365;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( TILT_SPEED_2 ) > 20 ))  ) ) 
                { 
                __context__.SourceCodeLine = 367;
                _SplusNVRAM.ITILTSPEED [ 2 , 1] = (ushort) ( 14 ) ; 
                __context__.SourceCodeLine = 368;
                _SplusNVRAM.ITILTSPEED [ 2 , 3] = (ushort) ( 14 ) ; 
                __context__.SourceCodeLine = 369;
                _SplusNVRAM.ITILTSPEED [ 2 , 4] = (ushort) ( 14 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 373;
                _SplusNVRAM.ITILTSPEED [ 2 , 1] = (ushort) ( Functions.Atoi( TILT_SPEED_2 ) ) ; 
                __context__.SourceCodeLine = 374;
                _SplusNVRAM.ITILTSPEED [ 2 , 3] = (ushort) ( Functions.Atoi( TILT_SPEED_2 ) ) ; 
                __context__.SourceCodeLine = 375;
                _SplusNVRAM.ITILTSPEED [ 2 , 4] = (ushort) ( Functions.Atoi( TILT_SPEED_2 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 377;
            _SplusNVRAM.ITILTSPEED [ 2 , 2] = (ushort) ( Functions.Atoi( TILT_SPEED_2 ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 381;
            _SplusNVRAM.ITILTSPEED [ 2 , 1] = (ushort) ( 9 ) ; 
            __context__.SourceCodeLine = 382;
            _SplusNVRAM.ITILTSPEED [ 2 , 2] = (ushort) ( 9 ) ; 
            __context__.SourceCodeLine = 383;
            _SplusNVRAM.ITILTSPEED [ 2 , 3] = (ushort) ( 16 ) ; 
            __context__.SourceCodeLine = 384;
            _SplusNVRAM.ITILTSPEED [ 2 , 4] = (ushort) ( 16 ) ; 
            } 
        
        __context__.SourceCodeLine = 386;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 388;
            TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 1 ] ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 390;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 392;
                TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 2 ] ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 394;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 396;
                    TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 3 ] ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 398;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 400;
                        TILT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.ITILTSPEED[ 2 , 4 ] ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_SPEED_1_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 406;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( ZOOM_SPEED_1 ) >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( ZOOM_SPEED_1 ) <= 7 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 408;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( ZOOM_SPEED_1 ) > 2 ))  ) ) 
                { 
                __context__.SourceCodeLine = 410;
                _SplusNVRAM.IZOOMINSPEED [ 1 , 1] = (ushort) ( (2 + 32) ) ; 
                __context__.SourceCodeLine = 411;
                _SplusNVRAM.IZOOMOUTSPEED [ 1 , 1] = (ushort) ( (2 + 48) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 415;
                _SplusNVRAM.IZOOMINSPEED [ 1 , 1] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 32) ) ; 
                __context__.SourceCodeLine = 416;
                _SplusNVRAM.IZOOMOUTSPEED [ 1 , 1] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 48) ) ; 
                } 
            
            __context__.SourceCodeLine = 418;
            _SplusNVRAM.IZOOMINSPEED [ 1 , 2] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 32) ) ; 
            __context__.SourceCodeLine = 419;
            _SplusNVRAM.IZOOMINSPEED [ 1 , 3] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 32) ) ; 
            __context__.SourceCodeLine = 420;
            _SplusNVRAM.IZOOMINSPEED [ 1 , 4] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 32) ) ; 
            __context__.SourceCodeLine = 421;
            _SplusNVRAM.IZOOMOUTSPEED [ 1 , 2] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 48) ) ; 
            __context__.SourceCodeLine = 422;
            _SplusNVRAM.IZOOMOUTSPEED [ 1 , 3] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 48) ) ; 
            __context__.SourceCodeLine = 423;
            _SplusNVRAM.IZOOMOUTSPEED [ 1 , 4] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_1 ) + 48) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 427;
            _SplusNVRAM.IZOOMINSPEED [ 1 , 1] = (ushort) ( (2 + 32) ) ; 
            __context__.SourceCodeLine = 428;
            _SplusNVRAM.IZOOMINSPEED [ 1 , 2] = (ushort) ( (2 + 32) ) ; 
            __context__.SourceCodeLine = 429;
            _SplusNVRAM.IZOOMINSPEED [ 1 , 3] = (ushort) ( (4 + 32) ) ; 
            __context__.SourceCodeLine = 430;
            _SplusNVRAM.IZOOMINSPEED [ 1 , 4] = (ushort) ( (4 + 32) ) ; 
            __context__.SourceCodeLine = 431;
            _SplusNVRAM.IZOOMOUTSPEED [ 1 , 1] = (ushort) ( (2 + 48) ) ; 
            __context__.SourceCodeLine = 432;
            _SplusNVRAM.IZOOMOUTSPEED [ 1 , 2] = (ushort) ( (2 + 48) ) ; 
            __context__.SourceCodeLine = 433;
            _SplusNVRAM.IZOOMOUTSPEED [ 1 , 3] = (ushort) ( (4 + 48) ) ; 
            __context__.SourceCodeLine = 434;
            _SplusNVRAM.IZOOMOUTSPEED [ 1 , 4] = (ushort) ( (4 + 48) ) ; 
            } 
        
        __context__.SourceCodeLine = 436;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 438;
            ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 1 ] ) ; 
            __context__.SourceCodeLine = 439;
            ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 1 ] ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 441;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 443;
                ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 2 ] ) ; 
                __context__.SourceCodeLine = 444;
                ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 2 ] ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 446;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 448;
                    ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 3 ] ) ; 
                    __context__.SourceCodeLine = 449;
                    ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 3 ] ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 451;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 453;
                        ZOOM_IN_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 1 , 4 ] ) ; 
                        __context__.SourceCodeLine = 454;
                        ZOOM_OUT_SPEED_1_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 1 , 4 ] ) ; 
                        } 
                    
                    }
                
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZOOM_SPEED_2_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 460;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( ZOOM_SPEED_2 ) >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Atoi( ZOOM_SPEED_2 ) <= 7 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 462;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( ZOOM_SPEED_1 ) > 2 ))  ) ) 
                { 
                __context__.SourceCodeLine = 464;
                _SplusNVRAM.IZOOMINSPEED [ 2 , 1] = (ushort) ( (2 + 32) ) ; 
                __context__.SourceCodeLine = 465;
                _SplusNVRAM.IZOOMOUTSPEED [ 2 , 1] = (ushort) ( (2 + 48) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 469;
                _SplusNVRAM.IZOOMINSPEED [ 2 , 1] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 32) ) ; 
                __context__.SourceCodeLine = 470;
                _SplusNVRAM.IZOOMOUTSPEED [ 2 , 1] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 48) ) ; 
                } 
            
            __context__.SourceCodeLine = 472;
            _SplusNVRAM.IZOOMINSPEED [ 2 , 2] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 32) ) ; 
            __context__.SourceCodeLine = 473;
            _SplusNVRAM.IZOOMINSPEED [ 2 , 3] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 32) ) ; 
            __context__.SourceCodeLine = 474;
            _SplusNVRAM.IZOOMINSPEED [ 2 , 4] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 32) ) ; 
            __context__.SourceCodeLine = 475;
            _SplusNVRAM.IZOOMOUTSPEED [ 2 , 2] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 48) ) ; 
            __context__.SourceCodeLine = 476;
            _SplusNVRAM.IZOOMOUTSPEED [ 2 , 3] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 48) ) ; 
            __context__.SourceCodeLine = 477;
            _SplusNVRAM.IZOOMOUTSPEED [ 2 , 4] = (ushort) ( (Functions.Atoi( ZOOM_SPEED_2 ) + 48) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 481;
            _SplusNVRAM.IZOOMINSPEED [ 2 , 1] = (ushort) ( (7 + 32) ) ; 
            __context__.SourceCodeLine = 482;
            _SplusNVRAM.IZOOMINSPEED [ 2 , 2] = (ushort) ( (7 + 32) ) ; 
            __context__.SourceCodeLine = 483;
            _SplusNVRAM.IZOOMINSPEED [ 2 , 3] = (ushort) ( (7 + 32) ) ; 
            __context__.SourceCodeLine = 484;
            _SplusNVRAM.IZOOMINSPEED [ 2 , 4] = (ushort) ( (7 + 32) ) ; 
            __context__.SourceCodeLine = 485;
            _SplusNVRAM.IZOOMOUTSPEED [ 2 , 1] = (ushort) ( (7 + 48) ) ; 
            __context__.SourceCodeLine = 486;
            _SplusNVRAM.IZOOMOUTSPEED [ 2 , 2] = (ushort) ( (7 + 48) ) ; 
            __context__.SourceCodeLine = 487;
            _SplusNVRAM.IZOOMOUTSPEED [ 2 , 3] = (ushort) ( (7 + 48) ) ; 
            __context__.SourceCodeLine = 488;
            _SplusNVRAM.IZOOMOUTSPEED [ 2 , 4] = (ushort) ( (7 + 48) ) ; 
            } 
        
        __context__.SourceCodeLine = 490;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 492;
            ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 1 ] ) ; 
            __context__.SourceCodeLine = 493;
            ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 1 ] ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 495;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 497;
                ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 2 ] ) ; 
                __context__.SourceCodeLine = 498;
                ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 2 ] ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 500;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 3))  ) ) 
                    { 
                    __context__.SourceCodeLine = 502;
                    ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 3 ] ) ; 
                    __context__.SourceCodeLine = 503;
                    ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 3 ] ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 505;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICAMERA == 4))  ) ) 
                        { 
                        __context__.SourceCodeLine = 507;
                        ZOOM_IN_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMINSPEED[ 2 , 4 ] ) ; 
                        __context__.SourceCodeLine = 508;
                        ZOOM_OUT_SPEED_2_OUT  .Value = (ushort) ( _SplusNVRAM.IZOOMOUTSPEED[ 2 , 4 ] ) ; 
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
        
        __context__.SourceCodeLine = 520;
        _SplusNVRAM.ZOOMWAITING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 521;
        _SplusNVRAM.SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 522;
        ZOOMSCALE  .Value = (ushort) ( 32767 ) ; 
        __context__.SourceCodeLine = 523;
        _SplusNVRAM.ICAMERA = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.IPANSPEED  = new ushort[ 4,5 ];
    _SplusNVRAM.ITILTSPEED  = new ushort[ 3,5 ];
    _SplusNVRAM.IZOOMINSPEED  = new ushort[ 3,5 ];
    _SplusNVRAM.IZOOMOUTSPEED  = new ushort[ 3,5 ];
    _SplusNVRAM.TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    CHECKZOOM = new Crestron.Logos.SplusObjects.DigitalInput( CHECKZOOM__DigitalInput__, this );
    m_DigitalInputList.Add( CHECKZOOM__DigitalInput__, CHECKZOOM );
    
    EVI_D30 = new Crestron.Logos.SplusObjects.DigitalInput( EVI_D30__DigitalInput__, this );
    m_DigitalInputList.Add( EVI_D30__DigitalInput__, EVI_D30 );
    
    EVI_D70 = new Crestron.Logos.SplusObjects.DigitalInput( EVI_D70__DigitalInput__, this );
    m_DigitalInputList.Add( EVI_D70__DigitalInput__, EVI_D70 );
    
    EVI_D100 = new Crestron.Logos.SplusObjects.DigitalInput( EVI_D100__DigitalInput__, this );
    m_DigitalInputList.Add( EVI_D100__DigitalInput__, EVI_D100 );
    
    BRC_300 = new Crestron.Logos.SplusObjects.DigitalInput( BRC_300__DigitalInput__, this );
    m_DigitalInputList.Add( BRC_300__DigitalInput__, BRC_300 );
    
    ZOOMIN = new Crestron.Logos.SplusObjects.DigitalOutput( ZOOMIN__DigitalOutput__, this );
    m_DigitalOutputList.Add( ZOOMIN__DigitalOutput__, ZOOMIN );
    
    ADDRESS = new Crestron.Logos.SplusObjects.AnalogInput( ADDRESS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ADDRESS__AnalogSerialInput__, ADDRESS );
    
    ZOOMSCALE = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOMSCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOMSCALE__AnalogSerialOutput__, ZOOMSCALE );
    
    PAN_SPEED_1_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( PAN_SPEED_1_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PAN_SPEED_1_OUT__AnalogSerialOutput__, PAN_SPEED_1_OUT );
    
    PAN_SPEED_2_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( PAN_SPEED_2_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PAN_SPEED_2_OUT__AnalogSerialOutput__, PAN_SPEED_2_OUT );
    
    PAN_SPEED_3_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( PAN_SPEED_3_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PAN_SPEED_3_OUT__AnalogSerialOutput__, PAN_SPEED_3_OUT );
    
    TILT_SPEED_1_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( TILT_SPEED_1_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TILT_SPEED_1_OUT__AnalogSerialOutput__, TILT_SPEED_1_OUT );
    
    TILT_SPEED_2_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( TILT_SPEED_2_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TILT_SPEED_2_OUT__AnalogSerialOutput__, TILT_SPEED_2_OUT );
    
    ZOOM_IN_SPEED_1_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM_IN_SPEED_1_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM_IN_SPEED_1_OUT__AnalogSerialOutput__, ZOOM_IN_SPEED_1_OUT );
    
    ZOOM_IN_SPEED_2_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM_IN_SPEED_2_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM_IN_SPEED_2_OUT__AnalogSerialOutput__, ZOOM_IN_SPEED_2_OUT );
    
    ZOOM_OUT_SPEED_1_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM_OUT_SPEED_1_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM_OUT_SPEED_1_OUT__AnalogSerialOutput__, ZOOM_OUT_SPEED_1_OUT );
    
    ZOOM_OUT_SPEED_2_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( ZOOM_OUT_SPEED_2_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZOOM_OUT_SPEED_2_OUT__AnalogSerialOutput__, ZOOM_OUT_SPEED_2_OUT );
    
    PAN_SPEED_1 = new Crestron.Logos.SplusObjects.StringInput( PAN_SPEED_1__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( PAN_SPEED_1__AnalogSerialInput__, PAN_SPEED_1 );
    
    PAN_SPEED_2 = new Crestron.Logos.SplusObjects.StringInput( PAN_SPEED_2__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( PAN_SPEED_2__AnalogSerialInput__, PAN_SPEED_2 );
    
    PAN_SPEED_3 = new Crestron.Logos.SplusObjects.StringInput( PAN_SPEED_3__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( PAN_SPEED_3__AnalogSerialInput__, PAN_SPEED_3 );
    
    TILT_SPEED_1 = new Crestron.Logos.SplusObjects.StringInput( TILT_SPEED_1__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( TILT_SPEED_1__AnalogSerialInput__, TILT_SPEED_1 );
    
    TILT_SPEED_2 = new Crestron.Logos.SplusObjects.StringInput( TILT_SPEED_2__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( TILT_SPEED_2__AnalogSerialInput__, TILT_SPEED_2 );
    
    ZOOM_SPEED_1 = new Crestron.Logos.SplusObjects.StringInput( ZOOM_SPEED_1__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( ZOOM_SPEED_1__AnalogSerialInput__, ZOOM_SPEED_1 );
    
    ZOOM_SPEED_2 = new Crestron.Logos.SplusObjects.StringInput( ZOOM_SPEED_2__AnalogSerialInput__, 2, this );
    m_StringInputList.Add( ZOOM_SPEED_2__AnalogSerialInput__, ZOOM_SPEED_2 );
    
    TODEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TODEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVICE__DOLLAR____AnalogSerialOutput__, TODEVICE__DOLLAR__ );
    
    FROMDEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROMDEVICE__DOLLAR____AnalogSerialInput__, 250, this );
    m_StringInputList.Add( FROMDEVICE__DOLLAR____AnalogSerialInput__, FROMDEVICE__DOLLAR__ );
    
    
    CHECKZOOM.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHECKZOOM_OnPush_0, false ) );
    EVI_D30.OnDigitalPush.Add( new InputChangeHandlerWrapper( EVI_D30_OnPush_1, false ) );
    EVI_D70.OnDigitalPush.Add( new InputChangeHandlerWrapper( EVI_D70_OnPush_2, false ) );
    EVI_D100.OnDigitalPush.Add( new InputChangeHandlerWrapper( EVI_D100_OnPush_3, false ) );
    BRC_300.OnDigitalPush.Add( new InputChangeHandlerWrapper( BRC_300_OnPush_4, false ) );
    FROMDEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMDEVICE__DOLLAR___OnChange_5, false ) );
    ADDRESS.OnAnalogChange.Add( new InputChangeHandlerWrapper( ADDRESS_OnChange_6, false ) );
    PAN_SPEED_1.OnSerialChange.Add( new InputChangeHandlerWrapper( PAN_SPEED_1_OnChange_7, false ) );
    PAN_SPEED_2.OnSerialChange.Add( new InputChangeHandlerWrapper( PAN_SPEED_2_OnChange_8, false ) );
    PAN_SPEED_3.OnSerialChange.Add( new InputChangeHandlerWrapper( PAN_SPEED_3_OnChange_9, false ) );
    TILT_SPEED_1.OnSerialChange.Add( new InputChangeHandlerWrapper( TILT_SPEED_1_OnChange_10, false ) );
    TILT_SPEED_2.OnSerialChange.Add( new InputChangeHandlerWrapper( TILT_SPEED_2_OnChange_11, false ) );
    ZOOM_SPEED_1.OnSerialChange.Add( new InputChangeHandlerWrapper( ZOOM_SPEED_1_OnChange_12, false ) );
    ZOOM_SPEED_2.OnSerialChange.Add( new InputChangeHandlerWrapper( ZOOM_SPEED_2_OnChange_13, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_VADDIO_ROBOSHOT_30_V1_0_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CHECKZOOM__DigitalInput__ = 0;
const uint EVI_D30__DigitalInput__ = 1;
const uint EVI_D70__DigitalInput__ = 2;
const uint EVI_D100__DigitalInput__ = 3;
const uint BRC_300__DigitalInput__ = 4;
const uint ADDRESS__AnalogSerialInput__ = 0;
const uint PAN_SPEED_1__AnalogSerialInput__ = 1;
const uint PAN_SPEED_2__AnalogSerialInput__ = 2;
const uint PAN_SPEED_3__AnalogSerialInput__ = 3;
const uint TILT_SPEED_1__AnalogSerialInput__ = 4;
const uint TILT_SPEED_2__AnalogSerialInput__ = 5;
const uint ZOOM_SPEED_1__AnalogSerialInput__ = 6;
const uint ZOOM_SPEED_2__AnalogSerialInput__ = 7;
const uint FROMDEVICE__DOLLAR____AnalogSerialInput__ = 8;
const uint ZOOMIN__DigitalOutput__ = 0;
const uint ZOOMSCALE__AnalogSerialOutput__ = 0;
const uint PAN_SPEED_1_OUT__AnalogSerialOutput__ = 1;
const uint PAN_SPEED_2_OUT__AnalogSerialOutput__ = 2;
const uint PAN_SPEED_3_OUT__AnalogSerialOutput__ = 3;
const uint TILT_SPEED_1_OUT__AnalogSerialOutput__ = 4;
const uint TILT_SPEED_2_OUT__AnalogSerialOutput__ = 5;
const uint ZOOM_IN_SPEED_1_OUT__AnalogSerialOutput__ = 6;
const uint ZOOM_IN_SPEED_2_OUT__AnalogSerialOutput__ = 7;
const uint ZOOM_OUT_SPEED_1_OUT__AnalogSerialOutput__ = 8;
const uint ZOOM_OUT_SPEED_2_OUT__AnalogSerialOutput__ = 9;
const uint TODEVICE__DOLLAR____AnalogSerialOutput__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort ZOOMWAITING = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort SEMAPHORE = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort OUTHEADER = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort INHEADER = 0;
            [SplusStructAttribute(4, false, true)]
            public ushort ICAMERA = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort [,] IPANSPEED;
            [SplusStructAttribute(6, false, true)]
            public ushort [,] ITILTSPEED;
            [SplusStructAttribute(7, false, true)]
            public ushort [,] IZOOMINSPEED;
            [SplusStructAttribute(8, false, true)]
            public ushort [,] IZOOMOUTSPEED;
            [SplusStructAttribute(9, false, true)]
            public CrestronString TEMPSTRING__DOLLAR__;
            
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
