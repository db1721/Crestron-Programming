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

namespace CrestronModule_EPSON_POWERLIITE_PRO_CINEMA_7500_UBASCII_PROC_V1_0
{
    public class CrestronModuleClass_EPSON_POWERLIITE_PRO_CINEMA_7500_UBASCII_PROC_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput POWER_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_UP;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput BRIGHTNESS_DONE;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_UP;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput CONTRAST_DONE;
        Crestron.Logos.SplusObjects.DigitalInput COLOR_UP;
        Crestron.Logos.SplusObjects.DigitalInput COLOR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput COLOR_DONE;
        Crestron.Logos.SplusObjects.DigitalInput TINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput TINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput TINT_DONE;
        Crestron.Logos.SplusObjects.DigitalInput SHARPNESS_UP;
        Crestron.Logos.SplusObjects.DigitalInput SHARPNESS_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SHARPNESS_DONE;
        Crestron.Logos.SplusObjects.BufferInput FROM_MODULE__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput READY;
        Crestron.Logos.SplusObjects.DigitalOutput WARMING_UP;
        Crestron.Logos.SplusObjects.AnalogOutput LAMP_HOURS;
        Crestron.Logos.SplusObjects.AnalogOutput BRIGHTNESS_FB;
        Crestron.Logos.SplusObjects.AnalogOutput CONTRAST_FB;
        Crestron.Logos.SplusObjects.AnalogOutput COLOR_FB;
        Crestron.Logos.SplusObjects.AnalogOutput TINT_FB;
        Crestron.Logos.SplusObjects.AnalogOutput SHARPNESS_FB;
        Crestron.Logos.SplusObjects.StringOutput TO_MODULE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        private void FTIMEOUT (  SplusExecutionContext __context__, ushort FTIME ) 
            { 
            
            __context__.SourceCodeLine = 65;
            CreateWait ( "WTIMEOUT" , FTIME , WTIMEOUT_Callback ) ;
            
            }
            
        public void WTIMEOUT_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 67;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IPOWERREQUESTSENT == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 69;
                _SplusNVRAM.IPOWERREQUESTSENT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 70;
                WARMING_UP  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 71;
                POWER_ON_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 72;
                POWER_OFF_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 73;
                _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 74;
                READY  .Value = (ushort) ( _SplusNVRAM.IREADY ) ; 
                __context__.SourceCodeLine = 75;
                _SplusNVRAM.IPOWER = (ushort) ( 0 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 79;
                _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 80;
                READY  .Value = (ushort) ( _SplusNVRAM.IREADY ) ; 
                } 
            
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void FSENDNEWCOMMAND (  SplusExecutionContext __context__, CrestronString FSCOMMAND ) 
        { 
        
        __context__.SourceCodeLine = 87;
        TO_DEVICE__DOLLAR__  .UpdateValue ( FSCOMMAND  ) ; 
        __context__.SourceCodeLine = 88;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FSCOMMAND == "PWR?\u000D"))  ) ) 
            { 
            __context__.SourceCodeLine = 90;
            _SplusNVRAM.IPOWERREQUESTSENT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 91;
            FTIMEOUT (  __context__ , (ushort)( 500 )) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 93;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FSCOMMAND == "PWR OFF\u000D"))  ) ) 
                { 
                __context__.SourceCodeLine = 95;
                POWER_ON_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 96;
                POWER_OFF_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 97;
                FTIMEOUT (  __context__ , (ushort)( 2000 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 99;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FSCOMMAND == "PWR ON\u000D"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 101;
                    POWER_OFF_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 102;
                    WARMING_UP  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 103;
                    FTIMEOUT (  __context__ , (ushort)( 4000 )) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 107;
                    FTIMEOUT (  __context__ , (ushort)( 500 )) ; 
                    } 
                
                }
            
            }
        
        __context__.SourceCodeLine = 109;
        _SplusNVRAM.IREADY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 110;
        READY  .Value = (ushort) ( _SplusNVRAM.IREADY ) ; 
        
        }
        
    private void FSENDSTOREDCOMMAND (  SplusExecutionContext __context__, CrestronString FSCOMMAND ) 
        { 
        
        __context__.SourceCodeLine = 115;
        TO_DEVICE__DOLLAR__  .UpdateValue ( FSCOMMAND  ) ; 
        __context__.SourceCodeLine = 116;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FSCOMMAND == "PWR?\u000D"))  ) ) 
            { 
            __context__.SourceCodeLine = 118;
            _SplusNVRAM.IPOWERREQUESTSENT = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 119;
            FTIMEOUT (  __context__ , (ushort)( 500 )) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 121;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FSCOMMAND == "PWR OFF\u000D"))  ) ) 
                { 
                __context__.SourceCodeLine = 123;
                POWER_ON_FB  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 124;
                POWER_OFF_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 125;
                FTIMEOUT (  __context__ , (ushort)( 2000 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 127;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FSCOMMAND == "PWR ON\u000D"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 129;
                    POWER_OFF_FB  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 130;
                    WARMING_UP  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 131;
                    FTIMEOUT (  __context__ , (ushort)( 4000 )) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 135;
                    FTIMEOUT (  __context__ , (ushort)( 500 )) ; 
                    } 
                
                }
            
            }
        
        __context__.SourceCodeLine = 137;
        _SplusNVRAM.SQUEUE [ _SplusNVRAM.INEXTSEND ]  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 138;
        _SplusNVRAM.IREADY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 139;
        READY  .Value = (ushort) ( _SplusNVRAM.IREADY ) ; 
        __context__.SourceCodeLine = 140;
        _SplusNVRAM.INEXTSEND = (ushort) ( (_SplusNVRAM.INEXTSEND + 1) ) ; 
        __context__.SourceCodeLine = 141;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.INEXTSEND > 20 ))  ) ) 
            { 
            __context__.SourceCodeLine = 143;
            _SplusNVRAM.INEXTSEND = (ushort) ( 1 ) ; 
            } 
        
        
        }
        
    private void FSTORECOMMAND (  SplusExecutionContext __context__, CrestronString FSCOMMAND ) 
        { 
        
        __context__.SourceCodeLine = 149;
        _SplusNVRAM.SQUEUE [ _SplusNVRAM.INEXTSTORE ]  .UpdateValue ( FSCOMMAND  ) ; 
        __context__.SourceCodeLine = 150;
        _SplusNVRAM.INEXTSTORE = (ushort) ( (_SplusNVRAM.INEXTSTORE + 1) ) ; 
        __context__.SourceCodeLine = 151;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.INEXTSTORE > 20 ))  ) ) 
            { 
            __context__.SourceCodeLine = 153;
            _SplusNVRAM.INEXTSTORE = (ushort) ( 1 ) ; 
            } 
        
        
        }
        
    object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 162;
            WARMING_UP  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 163;
            POWER_ON_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 164;
            POWER_OFF_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 165;
            _SplusNVRAM.IPOWER = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 166;
            FSENDNEWCOMMAND (  __context__ , "PWR?\u000D") ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object POWER_ON_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 171;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 173;
            FSENDNEWCOMMAND (  __context__ , "PWR ON\u000D") ; 
            __context__.SourceCodeLine = 174;
            FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 178;
            FSTORECOMMAND (  __context__ , "PWR ON\u000D") ; 
            __context__.SourceCodeLine = 179;
            FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_OFF_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 185;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 187;
            FSENDNEWCOMMAND (  __context__ , "PWR OFF\u000D") ; 
            __context__.SourceCodeLine = 188;
            FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 192;
            FSTORECOMMAND (  __context__ , "PWR OFF\u000D") ; 
            __context__.SourceCodeLine = 193;
            FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_TOGGLE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 199;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POWER_OFF_FB  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 201;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 203;
                FSENDNEWCOMMAND (  __context__ , "PWR ON\u000D") ; 
                __context__.SourceCodeLine = 204;
                FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 208;
                FSTORECOMMAND (  __context__ , "PWR ON\u000D") ; 
                __context__.SourceCodeLine = 209;
                FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 212;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (POWER_ON_FB  .Value == 1) ) || Functions.TestForTrue ( Functions.BoolToInt (WARMING_UP  .Value == 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 214;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 216;
                    FSENDNEWCOMMAND (  __context__ , "PWR OFF\u000D") ; 
                    __context__.SourceCodeLine = 217;
                    FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 221;
                    FSTORECOMMAND (  __context__ , "PWR OFF\u000D") ; 
                    __context__.SourceCodeLine = 222;
                    FSTORECOMMAND (  __context__ , "PWR?\u000D") ; 
                    } 
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BRIGHTNESS_UP_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 229;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 231;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.IBRIGHTSTEP < 49 ))  ) ) 
                { 
                __context__.SourceCodeLine = 233;
                _SplusNVRAM.IBRIGHTSTEP = (ushort) ( (_SplusNVRAM.IBRIGHTSTEP + 1) ) ; 
                __context__.SourceCodeLine = 234;
                _SplusNVRAM.IBRIGHT = (ushort) ( _SplusNVRAM.IBRIGHTCONTVALUES[ _SplusNVRAM.IBRIGHTSTEP ] ) ; 
                __context__.SourceCodeLine = 235;
                BRIGHTNESS_FB  .Value = (ushort) ( _SplusNVRAM.IBRIGHT ) ; 
                __context__.SourceCodeLine = 236;
                MakeString ( _SplusNVRAM.STEMP , "BRIGHT {0:d}\u000D", (short)_SplusNVRAM.IBRIGHT) ; 
                __context__.SourceCodeLine = 237;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 238;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BRIGHTNESS_DOWN_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 245;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 247;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.IBRIGHTSTEP > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 249;
                _SplusNVRAM.IBRIGHTSTEP = (ushort) ( (_SplusNVRAM.IBRIGHTSTEP - 1) ) ; 
                __context__.SourceCodeLine = 250;
                _SplusNVRAM.IBRIGHT = (ushort) ( _SplusNVRAM.IBRIGHTCONTVALUES[ _SplusNVRAM.IBRIGHTSTEP ] ) ; 
                __context__.SourceCodeLine = 251;
                BRIGHTNESS_FB  .Value = (ushort) ( _SplusNVRAM.IBRIGHT ) ; 
                __context__.SourceCodeLine = 252;
                MakeString ( _SplusNVRAM.STEMP , "BRIGHT {0:d}\u000D", (short)_SplusNVRAM.IBRIGHT) ; 
                __context__.SourceCodeLine = 253;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 254;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BRIGHTNESS_DONE_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 261;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 263;
            FSENDNEWCOMMAND (  __context__ , "BRIGHT?\u000D") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 267;
            FSTORECOMMAND (  __context__ , "BRIGHT?\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTRAST_UP_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 273;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 275;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ICONTSTEP < 49 ))  ) ) 
                { 
                __context__.SourceCodeLine = 277;
                _SplusNVRAM.ICONTSTEP = (ushort) ( (_SplusNVRAM.ICONTSTEP + 1) ) ; 
                __context__.SourceCodeLine = 278;
                _SplusNVRAM.ICONTRAST = (ushort) ( _SplusNVRAM.IBRIGHTCONTVALUES[ _SplusNVRAM.ICONTSTEP ] ) ; 
                __context__.SourceCodeLine = 279;
                CONTRAST_FB  .Value = (ushort) ( _SplusNVRAM.ICONTRAST ) ; 
                __context__.SourceCodeLine = 280;
                MakeString ( _SplusNVRAM.STEMP , "CONTRAST {0:d}\u000D", (short)_SplusNVRAM.ICONTRAST) ; 
                __context__.SourceCodeLine = 281;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 282;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTRAST_DOWN_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 289;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 291;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ICONTSTEP > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 293;
                _SplusNVRAM.ICONTSTEP = (ushort) ( (_SplusNVRAM.ICONTSTEP - 1) ) ; 
                __context__.SourceCodeLine = 294;
                _SplusNVRAM.ICONTRAST = (ushort) ( _SplusNVRAM.IBRIGHTCONTVALUES[ _SplusNVRAM.ICONTSTEP ] ) ; 
                __context__.SourceCodeLine = 295;
                CONTRAST_FB  .Value = (ushort) ( _SplusNVRAM.ICONTRAST ) ; 
                __context__.SourceCodeLine = 296;
                MakeString ( _SplusNVRAM.STEMP , "CONTRAST {0:d}\u000D", (short)_SplusNVRAM.ICONTRAST) ; 
                __context__.SourceCodeLine = 297;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 298;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTRAST_DONE_OnRelease_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 305;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 307;
            FSENDNEWCOMMAND (  __context__ , "CONTRAST?\u000D") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 311;
            FSTORECOMMAND (  __context__ , "CONTRAST?\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COLOR_UP_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 317;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 319;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ICOLORSTEP < 65 ))  ) ) 
                { 
                __context__.SourceCodeLine = 321;
                _SplusNVRAM.ICOLORSTEP = (ushort) ( (_SplusNVRAM.ICOLORSTEP + 1) ) ; 
                __context__.SourceCodeLine = 322;
                _SplusNVRAM.ICOLOR = (ushort) ( _SplusNVRAM.ICOLORTINTVALUES[ _SplusNVRAM.ICOLORSTEP ] ) ; 
                __context__.SourceCodeLine = 323;
                COLOR_FB  .Value = (ushort) ( _SplusNVRAM.ICOLOR ) ; 
                __context__.SourceCodeLine = 324;
                MakeString ( _SplusNVRAM.STEMP , "DENSITY {0:d}\u000D", (short)_SplusNVRAM.ICOLOR) ; 
                __context__.SourceCodeLine = 325;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 326;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COLOR_DOWN_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 333;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 335;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ICOLORSTEP > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 337;
                _SplusNVRAM.ICOLORSTEP = (ushort) ( (_SplusNVRAM.ICOLORSTEP - 1) ) ; 
                __context__.SourceCodeLine = 338;
                _SplusNVRAM.ICOLOR = (ushort) ( _SplusNVRAM.ICOLORTINTVALUES[ _SplusNVRAM.ICOLORSTEP ] ) ; 
                __context__.SourceCodeLine = 339;
                COLOR_FB  .Value = (ushort) ( _SplusNVRAM.ICOLOR ) ; 
                __context__.SourceCodeLine = 340;
                MakeString ( _SplusNVRAM.STEMP , "DENSITY {0:d}\u000D", (short)_SplusNVRAM.ICOLOR) ; 
                __context__.SourceCodeLine = 341;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 342;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COLOR_DONE_OnRelease_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 349;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 351;
            FSENDNEWCOMMAND (  __context__ , "DENSITY?\u000D") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 355;
            FSTORECOMMAND (  __context__ , "DENSITY?\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TINT_UP_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 361;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 363;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ITINTSTEP < 65 ))  ) ) 
                { 
                __context__.SourceCodeLine = 365;
                _SplusNVRAM.ITINTSTEP = (ushort) ( (_SplusNVRAM.ITINTSTEP + 1) ) ; 
                __context__.SourceCodeLine = 366;
                _SplusNVRAM.ITINT = (ushort) ( _SplusNVRAM.ICOLORTINTVALUES[ _SplusNVRAM.ITINTSTEP ] ) ; 
                __context__.SourceCodeLine = 367;
                TINT_FB  .Value = (ushort) ( _SplusNVRAM.ITINT ) ; 
                __context__.SourceCodeLine = 368;
                MakeString ( _SplusNVRAM.STEMP , "TINT {0:d}\u000D", (short)_SplusNVRAM.ITINT) ; 
                __context__.SourceCodeLine = 369;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 370;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TINT_DOWN_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 377;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 379;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ITINTSTEP > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 381;
                _SplusNVRAM.ITINTSTEP = (ushort) ( (_SplusNVRAM.ITINTSTEP - 1) ) ; 
                __context__.SourceCodeLine = 382;
                _SplusNVRAM.ITINT = (ushort) ( _SplusNVRAM.ICOLORTINTVALUES[ _SplusNVRAM.ITINTSTEP ] ) ; 
                __context__.SourceCodeLine = 383;
                TINT_FB  .Value = (ushort) ( _SplusNVRAM.ITINT ) ; 
                __context__.SourceCodeLine = 384;
                MakeString ( _SplusNVRAM.STEMP , "TINT {0:d}\u000D", (short)_SplusNVRAM.ITINT) ; 
                __context__.SourceCodeLine = 385;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 386;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TINT_DONE_OnRelease_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 393;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 395;
            FSENDNEWCOMMAND (  __context__ , "TINT?\u000D") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 399;
            FSTORECOMMAND (  __context__ , "TINT?\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHARPNESS_UP_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 405;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 407;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ISHARPSTEP < 11 ))  ) ) 
                { 
                __context__.SourceCodeLine = 409;
                _SplusNVRAM.ISHARPSTEP = (ushort) ( (_SplusNVRAM.ISHARPSTEP + 1) ) ; 
                __context__.SourceCodeLine = 410;
                _SplusNVRAM.ISHARP = (ushort) ( _SplusNVRAM.ISHARPVALUES[ _SplusNVRAM.ISHARPSTEP ] ) ; 
                __context__.SourceCodeLine = 411;
                SHARPNESS_FB  .Value = (ushort) ( _SplusNVRAM.ISHARP ) ; 
                __context__.SourceCodeLine = 412;
                MakeString ( _SplusNVRAM.STEMP , "SHARP {0:d}\u000D", (short)_SplusNVRAM.ISHARP) ; 
                __context__.SourceCodeLine = 413;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 414;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHARPNESS_DOWN_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 421;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 423;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.ISHARPSTEP > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 425;
                _SplusNVRAM.ISHARPSTEP = (ushort) ( (_SplusNVRAM.ISHARPSTEP - 1) ) ; 
                __context__.SourceCodeLine = 426;
                _SplusNVRAM.ISHARP = (ushort) ( _SplusNVRAM.ISHARPVALUES[ _SplusNVRAM.ISHARPSTEP ] ) ; 
                __context__.SourceCodeLine = 427;
                SHARPNESS_FB  .Value = (ushort) ( _SplusNVRAM.ISHARP ) ; 
                __context__.SourceCodeLine = 428;
                MakeString ( _SplusNVRAM.STEMP , "SHARP {0:d}\u000D", (short)_SplusNVRAM.ISHARP) ; 
                __context__.SourceCodeLine = 429;
                FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP) ; 
                __context__.SourceCodeLine = 430;
                _SplusNVRAM.STEMP  .UpdateValue ( ""  ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHARPNESS_DONE_OnRelease_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 437;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 439;
            FSENDNEWCOMMAND (  __context__ , "SHARP?\u000D") ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 443;
            FSTORECOMMAND (  __context__ , "SHARP?\u000D") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE__DOLLAR___OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 449;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 451;
            _SplusNVRAM.IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 452;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( ":" , FROM_DEVICE__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 454;
                CancelWait ( "WTIMEOUT" ) ; 
                __context__.SourceCodeLine = 455;
                _SplusNVRAM.STEMP  .UpdateValue ( Functions.Remove ( ":" , FROM_DEVICE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 456;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( _SplusNVRAM.STEMP , (int)( 1 ) ) == 58))  ) ) 
                    { 
                    __context__.SourceCodeLine = 458;
                    _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 462;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "PWR=" , _SplusNVRAM.STEMP ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 464;
                        _SplusNVRAM.IPOWER = (ushort) ( Functions.Atoi( _SplusNVRAM.STEMP ) ) ; 
                        __context__.SourceCodeLine = 465;
                        _SplusNVRAM.IPOWERREQUESTSENT = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 466;
                        _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 467;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IPOWER == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 469;
                            WARMING_UP  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 470;
                            POWER_OFF_FB  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 471;
                            POWER_ON_FB  .Value = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 473;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IPOWER == 2))  ) ) 
                                { 
                                __context__.SourceCodeLine = 475;
                                POWER_ON_FB  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 476;
                                POWER_OFF_FB  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 477;
                                WARMING_UP  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 481;
                                WARMING_UP  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 482;
                                POWER_ON_FB  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 483;
                                POWER_OFF_FB  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 486;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "LAMP=" , _SplusNVRAM.STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 488;
                            _SplusNVRAM.ILAMP = (ushort) ( Functions.Atoi( _SplusNVRAM.STEMP ) ) ; 
                            __context__.SourceCodeLine = 489;
                            LAMP_HOURS  .Value = (ushort) ( _SplusNVRAM.ILAMP ) ; 
                            __context__.SourceCodeLine = 490;
                            _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 492;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "BRIGHT=" , _SplusNVRAM.STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 494;
                                _SplusNVRAM.IBRIGHT = (ushort) ( Functions.Atoi( _SplusNVRAM.STEMP ) ) ; 
                                __context__.SourceCodeLine = 495;
                                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                                ushort __FN_FOREND_VAL__1 = (ushort)49; 
                                int __FN_FORSTEP_VAL__1 = (int)1; 
                                for ( _SplusNVRAM.A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.A  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.A  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.A  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.A  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.A  += (ushort)__FN_FORSTEP_VAL__1) 
                                    { 
                                    __context__.SourceCodeLine = 497;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IBRIGHT == _SplusNVRAM.IBRIGHTCONTVALUES[ _SplusNVRAM.A ]))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 499;
                                        _SplusNVRAM.IBRIGHTSTEP = (ushort) ( _SplusNVRAM.A ) ; 
                                        __context__.SourceCodeLine = 500;
                                        break ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 495;
                                    } 
                                
                                __context__.SourceCodeLine = 503;
                                BRIGHTNESS_FB  .Value = (ushort) ( _SplusNVRAM.IBRIGHT ) ; 
                                __context__.SourceCodeLine = 504;
                                _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 506;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "CONTRAST=" , _SplusNVRAM.STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 508;
                                    _SplusNVRAM.ICONTRAST = (ushort) ( Functions.Atoi( _SplusNVRAM.STEMP ) ) ; 
                                    __context__.SourceCodeLine = 509;
                                    ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                                    ushort __FN_FOREND_VAL__2 = (ushort)49; 
                                    int __FN_FORSTEP_VAL__2 = (int)1; 
                                    for ( _SplusNVRAM.A  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (_SplusNVRAM.A  >= __FN_FORSTART_VAL__2) && (_SplusNVRAM.A  <= __FN_FOREND_VAL__2) ) : ( (_SplusNVRAM.A  <= __FN_FORSTART_VAL__2) && (_SplusNVRAM.A  >= __FN_FOREND_VAL__2) ) ; _SplusNVRAM.A  += (ushort)__FN_FORSTEP_VAL__2) 
                                        { 
                                        __context__.SourceCodeLine = 511;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICONTRAST == _SplusNVRAM.IBRIGHTCONTVALUES[ _SplusNVRAM.A ]))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 513;
                                            _SplusNVRAM.ICONTSTEP = (ushort) ( _SplusNVRAM.A ) ; 
                                            __context__.SourceCodeLine = 514;
                                            break ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 509;
                                        } 
                                    
                                    __context__.SourceCodeLine = 517;
                                    CONTRAST_FB  .Value = (ushort) ( _SplusNVRAM.ICONTRAST ) ; 
                                    __context__.SourceCodeLine = 518;
                                    _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 520;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DENSITY=" , _SplusNVRAM.STEMP ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 522;
                                        _SplusNVRAM.ICOLOR = (ushort) ( Functions.Atoi( _SplusNVRAM.STEMP ) ) ; 
                                        __context__.SourceCodeLine = 523;
                                        ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                                        ushort __FN_FOREND_VAL__3 = (ushort)65; 
                                        int __FN_FORSTEP_VAL__3 = (int)1; 
                                        for ( _SplusNVRAM.A  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (_SplusNVRAM.A  >= __FN_FORSTART_VAL__3) && (_SplusNVRAM.A  <= __FN_FOREND_VAL__3) ) : ( (_SplusNVRAM.A  <= __FN_FORSTART_VAL__3) && (_SplusNVRAM.A  >= __FN_FOREND_VAL__3) ) ; _SplusNVRAM.A  += (ushort)__FN_FORSTEP_VAL__3) 
                                            { 
                                            __context__.SourceCodeLine = 525;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ICOLOR == _SplusNVRAM.ICOLORTINTVALUES[ _SplusNVRAM.A ]))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 527;
                                                _SplusNVRAM.ICOLORSTEP = (ushort) ( _SplusNVRAM.A ) ; 
                                                __context__.SourceCodeLine = 528;
                                                break ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 523;
                                            } 
                                        
                                        __context__.SourceCodeLine = 531;
                                        COLOR_FB  .Value = (ushort) ( _SplusNVRAM.ICOLOR ) ; 
                                        __context__.SourceCodeLine = 532;
                                        _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 534;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "TINT=" , _SplusNVRAM.STEMP ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 536;
                                            _SplusNVRAM.ITINT = (ushort) ( Functions.Atoi( _SplusNVRAM.STEMP ) ) ; 
                                            __context__.SourceCodeLine = 537;
                                            ushort __FN_FORSTART_VAL__4 = (ushort) ( 1 ) ;
                                            ushort __FN_FOREND_VAL__4 = (ushort)65; 
                                            int __FN_FORSTEP_VAL__4 = (int)1; 
                                            for ( _SplusNVRAM.A  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (_SplusNVRAM.A  >= __FN_FORSTART_VAL__4) && (_SplusNVRAM.A  <= __FN_FOREND_VAL__4) ) : ( (_SplusNVRAM.A  <= __FN_FORSTART_VAL__4) && (_SplusNVRAM.A  >= __FN_FOREND_VAL__4) ) ; _SplusNVRAM.A  += (ushort)__FN_FORSTEP_VAL__4) 
                                                { 
                                                __context__.SourceCodeLine = 539;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ITINT == _SplusNVRAM.ICOLORTINTVALUES[ _SplusNVRAM.A ]))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 541;
                                                    _SplusNVRAM.ITINTSTEP = (ushort) ( _SplusNVRAM.A ) ; 
                                                    __context__.SourceCodeLine = 542;
                                                    break ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 537;
                                                } 
                                            
                                            __context__.SourceCodeLine = 545;
                                            TINT_FB  .Value = (ushort) ( _SplusNVRAM.ITINT ) ; 
                                            __context__.SourceCodeLine = 546;
                                            _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 548;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "SHARP=" , _SplusNVRAM.STEMP ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 550;
                                                _SplusNVRAM.ISHARP = (ushort) ( Functions.Atoi( _SplusNVRAM.STEMP ) ) ; 
                                                __context__.SourceCodeLine = 551;
                                                ushort __FN_FORSTART_VAL__5 = (ushort) ( 1 ) ;
                                                ushort __FN_FOREND_VAL__5 = (ushort)11; 
                                                int __FN_FORSTEP_VAL__5 = (int)1; 
                                                for ( _SplusNVRAM.A  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (_SplusNVRAM.A  >= __FN_FORSTART_VAL__5) && (_SplusNVRAM.A  <= __FN_FOREND_VAL__5) ) : ( (_SplusNVRAM.A  <= __FN_FORSTART_VAL__5) && (_SplusNVRAM.A  >= __FN_FOREND_VAL__5) ) ; _SplusNVRAM.A  += (ushort)__FN_FORSTEP_VAL__5) 
                                                    { 
                                                    __context__.SourceCodeLine = 553;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.ISHARP == _SplusNVRAM.ISHARPVALUES[ _SplusNVRAM.A ]))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 555;
                                                        _SplusNVRAM.ISHARPSTEP = (ushort) ( _SplusNVRAM.A ) ; 
                                                        __context__.SourceCodeLine = 556;
                                                        break ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 551;
                                                    } 
                                                
                                                __context__.SourceCodeLine = 559;
                                                SHARPNESS_FB  .Value = (ushort) ( _SplusNVRAM.ISHARP ) ; 
                                                __context__.SourceCodeLine = 560;
                                                _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 564;
                                                TO_MODULE__DOLLAR__  .UpdateValue ( _SplusNVRAM.STEMP  ) ; 
                                                __context__.SourceCodeLine = 565;
                                                _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 568;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 570;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.INEXTSTORE != _SplusNVRAM.INEXTSEND))  ) ) 
                        { 
                        __context__.SourceCodeLine = 572;
                        FSENDSTOREDCOMMAND (  __context__ , _SplusNVRAM.SQUEUE[ _SplusNVRAM.INEXTSEND ]) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 577;
                        READY  .Value = (ushort) ( _SplusNVRAM.IREADY ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 452;
                } 
            
            __context__.SourceCodeLine = 581;
            _SplusNVRAM.IFLAG1 = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_MODULE__DOLLAR___OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 587;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IFLAG2 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 589;
            _SplusNVRAM.IFLAG2 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 590;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROM_MODULE__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 592;
                _SplusNVRAM.STEMP1  .UpdateValue ( Functions.Remove ( "\u000D" , FROM_MODULE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 593;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IPOWER == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.STEMP == "PWR ON\u000D") )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 595;
                    FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP1) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 597;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.IPOWER == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.STEMP != "PWR ON\u000D") )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 599;
                        FSTORECOMMAND (  __context__ , _SplusNVRAM.STEMP1) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 601;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 603;
                            FSTORECOMMAND (  __context__ , _SplusNVRAM.STEMP1) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 605;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.INEXTSTORE != _SplusNVRAM.INEXTSEND))  ) ) 
                                { 
                                __context__.SourceCodeLine = 607;
                                FSTORECOMMAND (  __context__ , _SplusNVRAM.STEMP1) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 609;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IREADY == 1))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 611;
                                    FSENDNEWCOMMAND (  __context__ , _SplusNVRAM.STEMP1) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 615;
                                    FSTORECOMMAND (  __context__ , _SplusNVRAM.STEMP1) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 617;
                _SplusNVRAM.STEMP1  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 590;
                } 
            
            __context__.SourceCodeLine = 619;
            _SplusNVRAM.IFLAG2 = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 629;
        _SplusNVRAM.IPOWERREQUESTSENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 630;
        _SplusNVRAM.IREADY = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 631;
        READY  .Value = (ushort) ( _SplusNVRAM.IREADY ) ; 
        __context__.SourceCodeLine = 632;
        _SplusNVRAM.INEXTSEND = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 633;
        _SplusNVRAM.INEXTSTORE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 634;
        _SplusNVRAM.IPOWER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 635;
        _SplusNVRAM.IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 636;
        _SplusNVRAM.IFLAG2 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 637;
        WARMING_UP  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 638;
        POWER_ON_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 639;
        POWER_OFF_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 640;
        Functions.SetArray ( _SplusNVRAM.SQUEUE , "" ) ; 
        __context__.SourceCodeLine = 641;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 1] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 642;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 2] = (ushort) ( 5 ) ; 
        __context__.SourceCodeLine = 643;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 3] = (ushort) ( 10 ) ; 
        __context__.SourceCodeLine = 644;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 4] = (ushort) ( 15 ) ; 
        __context__.SourceCodeLine = 645;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 5] = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 646;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 6] = (ushort) ( 26 ) ; 
        __context__.SourceCodeLine = 647;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 7] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 648;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 8] = (ushort) ( 36 ) ; 
        __context__.SourceCodeLine = 649;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 9] = (ushort) ( 41 ) ; 
        __context__.SourceCodeLine = 650;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 10] = (ushort) ( 47 ) ; 
        __context__.SourceCodeLine = 651;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 11] = (ushort) ( 52 ) ; 
        __context__.SourceCodeLine = 652;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 12] = (ushort) ( 57 ) ; 
        __context__.SourceCodeLine = 653;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 13] = (ushort) ( 62 ) ; 
        __context__.SourceCodeLine = 654;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 14] = (ushort) ( 67 ) ; 
        __context__.SourceCodeLine = 655;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 15] = (ushort) ( 73 ) ; 
        __context__.SourceCodeLine = 656;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 16] = (ushort) ( 78 ) ; 
        __context__.SourceCodeLine = 657;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 17] = (ushort) ( 83 ) ; 
        __context__.SourceCodeLine = 658;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 18] = (ushort) ( 88 ) ; 
        __context__.SourceCodeLine = 659;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 19] = (ushort) ( 94 ) ; 
        __context__.SourceCodeLine = 660;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 20] = (ushort) ( 99 ) ; 
        __context__.SourceCodeLine = 661;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 21] = (ushort) ( 104 ) ; 
        __context__.SourceCodeLine = 662;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 22] = (ushort) ( 109 ) ; 
        __context__.SourceCodeLine = 663;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 23] = (ushort) ( 114 ) ; 
        __context__.SourceCodeLine = 664;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 24] = (ushort) ( 120 ) ; 
        __context__.SourceCodeLine = 665;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 25] = (ushort) ( 125 ) ; 
        __context__.SourceCodeLine = 666;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 26] = (ushort) ( 130 ) ; 
        __context__.SourceCodeLine = 667;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 27] = (ushort) ( 135 ) ; 
        __context__.SourceCodeLine = 668;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 28] = (ushort) ( 141 ) ; 
        __context__.SourceCodeLine = 669;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 29] = (ushort) ( 146 ) ; 
        __context__.SourceCodeLine = 670;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 30] = (ushort) ( 151 ) ; 
        __context__.SourceCodeLine = 671;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 31] = (ushort) ( 156 ) ; 
        __context__.SourceCodeLine = 672;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 32] = (ushort) ( 161 ) ; 
        __context__.SourceCodeLine = 673;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 33] = (ushort) ( 167 ) ; 
        __context__.SourceCodeLine = 674;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 34] = (ushort) ( 172 ) ; 
        __context__.SourceCodeLine = 675;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 35] = (ushort) ( 177 ) ; 
        __context__.SourceCodeLine = 676;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 36] = (ushort) ( 182 ) ; 
        __context__.SourceCodeLine = 677;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 37] = (ushort) ( 188 ) ; 
        __context__.SourceCodeLine = 678;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 38] = (ushort) ( 193 ) ; 
        __context__.SourceCodeLine = 679;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 39] = (ushort) ( 198 ) ; 
        __context__.SourceCodeLine = 680;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 40] = (ushort) ( 203 ) ; 
        __context__.SourceCodeLine = 681;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 41] = (ushort) ( 208 ) ; 
        __context__.SourceCodeLine = 682;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 42] = (ushort) ( 214 ) ; 
        __context__.SourceCodeLine = 683;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 43] = (ushort) ( 219 ) ; 
        __context__.SourceCodeLine = 684;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 44] = (ushort) ( 224 ) ; 
        __context__.SourceCodeLine = 685;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 45] = (ushort) ( 229 ) ; 
        __context__.SourceCodeLine = 686;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 46] = (ushort) ( 235 ) ; 
        __context__.SourceCodeLine = 687;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 47] = (ushort) ( 240 ) ; 
        __context__.SourceCodeLine = 688;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 48] = (ushort) ( 245 ) ; 
        __context__.SourceCodeLine = 689;
        _SplusNVRAM.IBRIGHTCONTVALUES [ 49] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 690;
        _SplusNVRAM.ICOLORTINTVALUES [ 1] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 691;
        _SplusNVRAM.ICOLORTINTVALUES [ 2] = (ushort) ( 3 ) ; 
        __context__.SourceCodeLine = 692;
        _SplusNVRAM.ICOLORTINTVALUES [ 3] = (ushort) ( 7 ) ; 
        __context__.SourceCodeLine = 693;
        _SplusNVRAM.ICOLORTINTVALUES [ 4] = (ushort) ( 11 ) ; 
        __context__.SourceCodeLine = 694;
        _SplusNVRAM.ICOLORTINTVALUES [ 5] = (ushort) ( 15 ) ; 
        __context__.SourceCodeLine = 695;
        _SplusNVRAM.ICOLORTINTVALUES [ 6] = (ushort) ( 19 ) ; 
        __context__.SourceCodeLine = 696;
        _SplusNVRAM.ICOLORTINTVALUES [ 7] = (ushort) ( 23 ) ; 
        __context__.SourceCodeLine = 697;
        _SplusNVRAM.ICOLORTINTVALUES [ 8] = (ushort) ( 27 ) ; 
        __context__.SourceCodeLine = 698;
        _SplusNVRAM.ICOLORTINTVALUES [ 9] = (ushort) ( 31 ) ; 
        __context__.SourceCodeLine = 699;
        _SplusNVRAM.ICOLORTINTVALUES [ 10] = (ushort) ( 35 ) ; 
        __context__.SourceCodeLine = 700;
        _SplusNVRAM.ICOLORTINTVALUES [ 11] = (ushort) ( 39 ) ; 
        __context__.SourceCodeLine = 701;
        _SplusNVRAM.ICOLORTINTVALUES [ 12] = (ushort) ( 43 ) ; 
        __context__.SourceCodeLine = 702;
        _SplusNVRAM.ICOLORTINTVALUES [ 13] = (ushort) ( 47 ) ; 
        __context__.SourceCodeLine = 703;
        _SplusNVRAM.ICOLORTINTVALUES [ 14] = (ushort) ( 51 ) ; 
        __context__.SourceCodeLine = 704;
        _SplusNVRAM.ICOLORTINTVALUES [ 15] = (ushort) ( 55 ) ; 
        __context__.SourceCodeLine = 705;
        _SplusNVRAM.ICOLORTINTVALUES [ 16] = (ushort) ( 59 ) ; 
        __context__.SourceCodeLine = 706;
        _SplusNVRAM.ICOLORTINTVALUES [ 17] = (ushort) ( 63 ) ; 
        __context__.SourceCodeLine = 707;
        _SplusNVRAM.ICOLORTINTVALUES [ 18] = (ushort) ( 66 ) ; 
        __context__.SourceCodeLine = 708;
        _SplusNVRAM.ICOLORTINTVALUES [ 19] = (ushort) ( 70 ) ; 
        __context__.SourceCodeLine = 709;
        _SplusNVRAM.ICOLORTINTVALUES [ 20] = (ushort) ( 74 ) ; 
        __context__.SourceCodeLine = 710;
        _SplusNVRAM.ICOLORTINTVALUES [ 21] = (ushort) ( 78 ) ; 
        __context__.SourceCodeLine = 711;
        _SplusNVRAM.ICOLORTINTVALUES [ 22] = (ushort) ( 82 ) ; 
        __context__.SourceCodeLine = 712;
        _SplusNVRAM.ICOLORTINTVALUES [ 23] = (ushort) ( 86 ) ; 
        __context__.SourceCodeLine = 713;
        _SplusNVRAM.ICOLORTINTVALUES [ 24] = (ushort) ( 90 ) ; 
        __context__.SourceCodeLine = 714;
        _SplusNVRAM.ICOLORTINTVALUES [ 25] = (ushort) ( 94 ) ; 
        __context__.SourceCodeLine = 715;
        _SplusNVRAM.ICOLORTINTVALUES [ 26] = (ushort) ( 98 ) ; 
        __context__.SourceCodeLine = 716;
        _SplusNVRAM.ICOLORTINTVALUES [ 27] = (ushort) ( 102 ) ; 
        __context__.SourceCodeLine = 717;
        _SplusNVRAM.ICOLORTINTVALUES [ 28] = (ushort) ( 106 ) ; 
        __context__.SourceCodeLine = 718;
        _SplusNVRAM.ICOLORTINTVALUES [ 29] = (ushort) ( 110 ) ; 
        __context__.SourceCodeLine = 719;
        _SplusNVRAM.ICOLORTINTVALUES [ 30] = (ushort) ( 114 ) ; 
        __context__.SourceCodeLine = 720;
        _SplusNVRAM.ICOLORTINTVALUES [ 31] = (ushort) ( 118 ) ; 
        __context__.SourceCodeLine = 721;
        _SplusNVRAM.ICOLORTINTVALUES [ 32] = (ushort) ( 122 ) ; 
        __context__.SourceCodeLine = 722;
        _SplusNVRAM.ICOLORTINTVALUES [ 33] = (ushort) ( 126 ) ; 
        __context__.SourceCodeLine = 723;
        _SplusNVRAM.ICOLORTINTVALUES [ 34] = (ushort) ( 129 ) ; 
        __context__.SourceCodeLine = 724;
        _SplusNVRAM.ICOLORTINTVALUES [ 35] = (ushort) ( 133 ) ; 
        __context__.SourceCodeLine = 725;
        _SplusNVRAM.ICOLORTINTVALUES [ 36] = (ushort) ( 137 ) ; 
        __context__.SourceCodeLine = 726;
        _SplusNVRAM.ICOLORTINTVALUES [ 37] = (ushort) ( 141 ) ; 
        __context__.SourceCodeLine = 727;
        _SplusNVRAM.ICOLORTINTVALUES [ 38] = (ushort) ( 145 ) ; 
        __context__.SourceCodeLine = 728;
        _SplusNVRAM.ICOLORTINTVALUES [ 39] = (ushort) ( 149 ) ; 
        __context__.SourceCodeLine = 729;
        _SplusNVRAM.ICOLORTINTVALUES [ 40] = (ushort) ( 153 ) ; 
        __context__.SourceCodeLine = 730;
        _SplusNVRAM.ICOLORTINTVALUES [ 41] = (ushort) ( 157 ) ; 
        __context__.SourceCodeLine = 731;
        _SplusNVRAM.ICOLORTINTVALUES [ 42] = (ushort) ( 161 ) ; 
        __context__.SourceCodeLine = 732;
        _SplusNVRAM.ICOLORTINTVALUES [ 43] = (ushort) ( 165 ) ; 
        __context__.SourceCodeLine = 733;
        _SplusNVRAM.ICOLORTINTVALUES [ 44] = (ushort) ( 169 ) ; 
        __context__.SourceCodeLine = 734;
        _SplusNVRAM.ICOLORTINTVALUES [ 45] = (ushort) ( 173 ) ; 
        __context__.SourceCodeLine = 735;
        _SplusNVRAM.ICOLORTINTVALUES [ 46] = (ushort) ( 177 ) ; 
        __context__.SourceCodeLine = 736;
        _SplusNVRAM.ICOLORTINTVALUES [ 47] = (ushort) ( 181 ) ; 
        __context__.SourceCodeLine = 737;
        _SplusNVRAM.ICOLORTINTVALUES [ 48] = (ushort) ( 185 ) ; 
        __context__.SourceCodeLine = 738;
        _SplusNVRAM.ICOLORTINTVALUES [ 49] = (ushort) ( 189 ) ; 
        __context__.SourceCodeLine = 739;
        _SplusNVRAM.ICOLORTINTVALUES [ 50] = (ushort) ( 192 ) ; 
        __context__.SourceCodeLine = 740;
        _SplusNVRAM.ICOLORTINTVALUES [ 51] = (ushort) ( 196 ) ; 
        __context__.SourceCodeLine = 741;
        _SplusNVRAM.ICOLORTINTVALUES [ 52] = (ushort) ( 200 ) ; 
        __context__.SourceCodeLine = 742;
        _SplusNVRAM.ICOLORTINTVALUES [ 53] = (ushort) ( 204 ) ; 
        __context__.SourceCodeLine = 743;
        _SplusNVRAM.ICOLORTINTVALUES [ 54] = (ushort) ( 208 ) ; 
        __context__.SourceCodeLine = 744;
        _SplusNVRAM.ICOLORTINTVALUES [ 55] = (ushort) ( 212 ) ; 
        __context__.SourceCodeLine = 745;
        _SplusNVRAM.ICOLORTINTVALUES [ 56] = (ushort) ( 216 ) ; 
        __context__.SourceCodeLine = 746;
        _SplusNVRAM.ICOLORTINTVALUES [ 57] = (ushort) ( 220 ) ; 
        __context__.SourceCodeLine = 747;
        _SplusNVRAM.ICOLORTINTVALUES [ 58] = (ushort) ( 224 ) ; 
        __context__.SourceCodeLine = 748;
        _SplusNVRAM.ICOLORTINTVALUES [ 59] = (ushort) ( 228 ) ; 
        __context__.SourceCodeLine = 749;
        _SplusNVRAM.ICOLORTINTVALUES [ 60] = (ushort) ( 232 ) ; 
        __context__.SourceCodeLine = 750;
        _SplusNVRAM.ICOLORTINTVALUES [ 61] = (ushort) ( 236 ) ; 
        __context__.SourceCodeLine = 751;
        _SplusNVRAM.ICOLORTINTVALUES [ 62] = (ushort) ( 240 ) ; 
        __context__.SourceCodeLine = 752;
        _SplusNVRAM.ICOLORTINTVALUES [ 63] = (ushort) ( 244 ) ; 
        __context__.SourceCodeLine = 753;
        _SplusNVRAM.ICOLORTINTVALUES [ 64] = (ushort) ( 248 ) ; 
        __context__.SourceCodeLine = 754;
        _SplusNVRAM.ICOLORTINTVALUES [ 65] = (ushort) ( 252 ) ; 
        __context__.SourceCodeLine = 755;
        _SplusNVRAM.ISHARPVALUES [ 1] = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 756;
        _SplusNVRAM.ISHARPVALUES [ 2] = (ushort) ( 23 ) ; 
        __context__.SourceCodeLine = 757;
        _SplusNVRAM.ISHARPVALUES [ 3] = (ushort) ( 46 ) ; 
        __context__.SourceCodeLine = 758;
        _SplusNVRAM.ISHARPVALUES [ 4] = (ushort) ( 69 ) ; 
        __context__.SourceCodeLine = 759;
        _SplusNVRAM.ISHARPVALUES [ 5] = (ushort) ( 93 ) ; 
        __context__.SourceCodeLine = 760;
        _SplusNVRAM.ISHARPVALUES [ 6] = (ushort) ( 116 ) ; 
        __context__.SourceCodeLine = 761;
        _SplusNVRAM.ISHARPVALUES [ 7] = (ushort) ( 139 ) ; 
        __context__.SourceCodeLine = 762;
        _SplusNVRAM.ISHARPVALUES [ 8] = (ushort) ( 162 ) ; 
        __context__.SourceCodeLine = 763;
        _SplusNVRAM.ISHARPVALUES [ 9] = (ushort) ( 186 ) ; 
        __context__.SourceCodeLine = 764;
        _SplusNVRAM.ISHARPVALUES [ 10] = (ushort) ( 209 ) ; 
        __context__.SourceCodeLine = 765;
        _SplusNVRAM.ISHARPVALUES [ 11] = (ushort) ( 232 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.IBRIGHTCONTVALUES  = new ushort[ 50 ];
    _SplusNVRAM.ICOLORTINTVALUES  = new ushort[ 66 ];
    _SplusNVRAM.ISHARPVALUES  = new ushort[ 12 ];
    _SplusNVRAM.STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _SplusNVRAM.SQUEUE  = new CrestronString[ 21 ];
    for( uint i = 0; i < 21; i++ )
        _SplusNVRAM.SQUEUE [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON__DigitalInput__, POWER_ON );
    
    POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF__DigitalInput__, POWER_OFF );
    
    POWER_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( POWER_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_TOGGLE__DigitalInput__, POWER_TOGGLE );
    
    BRIGHTNESS_UP = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_UP__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_UP__DigitalInput__, BRIGHTNESS_UP );
    
    BRIGHTNESS_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_DOWN__DigitalInput__, BRIGHTNESS_DOWN );
    
    BRIGHTNESS_DONE = new Crestron.Logos.SplusObjects.DigitalInput( BRIGHTNESS_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( BRIGHTNESS_DONE__DigitalInput__, BRIGHTNESS_DONE );
    
    CONTRAST_UP = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_UP__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_UP__DigitalInput__, CONTRAST_UP );
    
    CONTRAST_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_DOWN__DigitalInput__, CONTRAST_DOWN );
    
    CONTRAST_DONE = new Crestron.Logos.SplusObjects.DigitalInput( CONTRAST_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( CONTRAST_DONE__DigitalInput__, CONTRAST_DONE );
    
    COLOR_UP = new Crestron.Logos.SplusObjects.DigitalInput( COLOR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( COLOR_UP__DigitalInput__, COLOR_UP );
    
    COLOR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( COLOR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( COLOR_DOWN__DigitalInput__, COLOR_DOWN );
    
    COLOR_DONE = new Crestron.Logos.SplusObjects.DigitalInput( COLOR_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( COLOR_DONE__DigitalInput__, COLOR_DONE );
    
    TINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( TINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( TINT_UP__DigitalInput__, TINT_UP );
    
    TINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( TINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( TINT_DOWN__DigitalInput__, TINT_DOWN );
    
    TINT_DONE = new Crestron.Logos.SplusObjects.DigitalInput( TINT_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( TINT_DONE__DigitalInput__, TINT_DONE );
    
    SHARPNESS_UP = new Crestron.Logos.SplusObjects.DigitalInput( SHARPNESS_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SHARPNESS_UP__DigitalInput__, SHARPNESS_UP );
    
    SHARPNESS_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( SHARPNESS_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SHARPNESS_DOWN__DigitalInput__, SHARPNESS_DOWN );
    
    SHARPNESS_DONE = new Crestron.Logos.SplusObjects.DigitalInput( SHARPNESS_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( SHARPNESS_DONE__DigitalInput__, SHARPNESS_DONE );
    
    POWER_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_ON_FB__DigitalOutput__, POWER_ON_FB );
    
    POWER_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_OFF_FB__DigitalOutput__, POWER_OFF_FB );
    
    READY = new Crestron.Logos.SplusObjects.DigitalOutput( READY__DigitalOutput__, this );
    m_DigitalOutputList.Add( READY__DigitalOutput__, READY );
    
    WARMING_UP = new Crestron.Logos.SplusObjects.DigitalOutput( WARMING_UP__DigitalOutput__, this );
    m_DigitalOutputList.Add( WARMING_UP__DigitalOutput__, WARMING_UP );
    
    LAMP_HOURS = new Crestron.Logos.SplusObjects.AnalogOutput( LAMP_HOURS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LAMP_HOURS__AnalogSerialOutput__, LAMP_HOURS );
    
    BRIGHTNESS_FB = new Crestron.Logos.SplusObjects.AnalogOutput( BRIGHTNESS_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( BRIGHTNESS_FB__AnalogSerialOutput__, BRIGHTNESS_FB );
    
    CONTRAST_FB = new Crestron.Logos.SplusObjects.AnalogOutput( CONTRAST_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONTRAST_FB__AnalogSerialOutput__, CONTRAST_FB );
    
    COLOR_FB = new Crestron.Logos.SplusObjects.AnalogOutput( COLOR_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( COLOR_FB__AnalogSerialOutput__, COLOR_FB );
    
    TINT_FB = new Crestron.Logos.SplusObjects.AnalogOutput( TINT_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TINT_FB__AnalogSerialOutput__, TINT_FB );
    
    SHARPNESS_FB = new Crestron.Logos.SplusObjects.AnalogOutput( SHARPNESS_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SHARPNESS_FB__AnalogSerialOutput__, SHARPNESS_FB );
    
    TO_MODULE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_MODULE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_MODULE__DOLLAR____AnalogSerialOutput__, TO_MODULE__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    FROM_MODULE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_MODULE__DOLLAR____AnalogSerialInput__, 150, this );
    m_StringInputList.Add( FROM_MODULE__DOLLAR____AnalogSerialInput__, FROM_MODULE__DOLLAR__ );
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 250, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    WTIMEOUT_Callback = new WaitFunction( WTIMEOUT_CallbackFn );
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_OnPush_1, false ) );
    POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_OnPush_2, false ) );
    POWER_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_TOGGLE_OnPush_3, false ) );
    BRIGHTNESS_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( BRIGHTNESS_UP_OnPush_4, false ) );
    BRIGHTNESS_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BRIGHTNESS_DOWN_OnPush_5, false ) );
    BRIGHTNESS_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( BRIGHTNESS_DONE_OnRelease_6, false ) );
    CONTRAST_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTRAST_UP_OnPush_7, false ) );
    CONTRAST_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONTRAST_DOWN_OnPush_8, false ) );
    CONTRAST_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CONTRAST_DONE_OnRelease_9, false ) );
    COLOR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( COLOR_UP_OnPush_10, false ) );
    COLOR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( COLOR_DOWN_OnPush_11, false ) );
    COLOR_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( COLOR_DONE_OnRelease_12, false ) );
    TINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( TINT_UP_OnPush_13, false ) );
    TINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( TINT_DOWN_OnPush_14, false ) );
    TINT_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( TINT_DONE_OnRelease_15, false ) );
    SHARPNESS_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHARPNESS_UP_OnPush_16, false ) );
    SHARPNESS_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHARPNESS_DOWN_OnPush_17, false ) );
    SHARPNESS_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SHARPNESS_DONE_OnRelease_18, false ) );
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_19, false ) );
    FROM_MODULE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_MODULE__DOLLAR___OnChange_20, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_EPSON_POWERLIITE_PRO_CINEMA_7500_UBASCII_PROC_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WTIMEOUT_Callback;


const uint INITIALIZE__DigitalInput__ = 0;
const uint POWER_ON__DigitalInput__ = 1;
const uint POWER_OFF__DigitalInput__ = 2;
const uint POWER_TOGGLE__DigitalInput__ = 3;
const uint BRIGHTNESS_UP__DigitalInput__ = 4;
const uint BRIGHTNESS_DOWN__DigitalInput__ = 5;
const uint BRIGHTNESS_DONE__DigitalInput__ = 6;
const uint CONTRAST_UP__DigitalInput__ = 7;
const uint CONTRAST_DOWN__DigitalInput__ = 8;
const uint CONTRAST_DONE__DigitalInput__ = 9;
const uint COLOR_UP__DigitalInput__ = 10;
const uint COLOR_DOWN__DigitalInput__ = 11;
const uint COLOR_DONE__DigitalInput__ = 12;
const uint TINT_UP__DigitalInput__ = 13;
const uint TINT_DOWN__DigitalInput__ = 14;
const uint TINT_DONE__DigitalInput__ = 15;
const uint SHARPNESS_UP__DigitalInput__ = 16;
const uint SHARPNESS_DOWN__DigitalInput__ = 17;
const uint SHARPNESS_DONE__DigitalInput__ = 18;
const uint FROM_MODULE__DOLLAR____AnalogSerialInput__ = 0;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 1;
const uint POWER_ON_FB__DigitalOutput__ = 0;
const uint POWER_OFF_FB__DigitalOutput__ = 1;
const uint READY__DigitalOutput__ = 2;
const uint WARMING_UP__DigitalOutput__ = 3;
const uint LAMP_HOURS__AnalogSerialOutput__ = 0;
const uint BRIGHTNESS_FB__AnalogSerialOutput__ = 1;
const uint CONTRAST_FB__AnalogSerialOutput__ = 2;
const uint COLOR_FB__AnalogSerialOutput__ = 3;
const uint TINT_FB__AnalogSerialOutput__ = 4;
const uint SHARPNESS_FB__AnalogSerialOutput__ = 5;
const uint TO_MODULE__DOLLAR____AnalogSerialOutput__ = 6;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 7;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort IPOWERREQUESTSENT = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort IREADY = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort INEXTSEND = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort INEXTSTORE = 0;
            [SplusStructAttribute(4, false, true)]
            public ushort IPOWER = 0;
            [SplusStructAttribute(5, false, true)]
            public ushort IRAMPCOUNTER = 0;
            [SplusStructAttribute(6, false, true)]
            public ushort A = 0;
            [SplusStructAttribute(7, false, true)]
            public ushort IFLAG1 = 0;
            [SplusStructAttribute(8, false, true)]
            public ushort IFLAG2 = 0;
            [SplusStructAttribute(9, false, true)]
            public ushort ILAMP = 0;
            [SplusStructAttribute(10, false, true)]
            public ushort IBRIGHT = 0;
            [SplusStructAttribute(11, false, true)]
            public ushort ICONTRAST = 0;
            [SplusStructAttribute(12, false, true)]
            public ushort ICOLOR = 0;
            [SplusStructAttribute(13, false, true)]
            public ushort ITINT = 0;
            [SplusStructAttribute(14, false, true)]
            public ushort ISHARP = 0;
            [SplusStructAttribute(15, false, true)]
            public ushort [] IBRIGHTCONTVALUES;
            [SplusStructAttribute(16, false, true)]
            public ushort [] ICOLORTINTVALUES;
            [SplusStructAttribute(17, false, true)]
            public ushort [] ISHARPVALUES;
            [SplusStructAttribute(18, false, true)]
            public ushort IBRIGHTSTEP = 0;
            [SplusStructAttribute(19, false, true)]
            public ushort ICONTSTEP = 0;
            [SplusStructAttribute(20, false, true)]
            public ushort ICOLORSTEP = 0;
            [SplusStructAttribute(21, false, true)]
            public ushort ITINTSTEP = 0;
            [SplusStructAttribute(22, false, true)]
            public ushort ISHARPSTEP = 0;
            [SplusStructAttribute(23, false, true)]
            public CrestronString [] SQUEUE;
            [SplusStructAttribute(24, false, true)]
            public CrestronString STEMP;
            [SplusStructAttribute(25, false, true)]
            public CrestronString STEMP1;
            
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
