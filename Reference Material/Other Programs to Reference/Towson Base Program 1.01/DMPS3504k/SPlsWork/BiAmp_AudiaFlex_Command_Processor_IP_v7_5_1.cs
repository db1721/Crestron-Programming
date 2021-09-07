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

namespace UserModule_BIAMP_AUDIAFLEX_COMMAND_PROCESSOR_IP_V7_5_1
{
    public class UserModuleClass_BIAMP_AUDIAFLEX_COMMAND_PROCESSOR_IP_V7_5_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput CONNECTED_F;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.BufferInput FROM_MODULES;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZE_IS_BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput INITCOMPLETE;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> TO_MODULES;
        ushort INEXTCOMMANDSTORE = 0;
        ushort INEXTCOMMANDSEND = 0;
        ushort INEXTGETSTORE = 0;
        ushort INEXTGETSEND = 0;
        ushort ITEMPID = 0;
        ushort ITEMP = 0;
        ushort A = 0;
        ushort B = 0;
        ushort NUMBEROFMODULES = 0;
        ushort _INITCOMPLETE = 0;
        ushort [] _MODULES;
        ushort COMMANDSENT = 0;
        ushort TIMEOUTCOUNTER = 0;
        ushort MAINCOMPLETE = 0;
        CrestronString [] SCOMMAND;
        CrestronString [] SGET;
        CrestronString STEMPMODULES;
        CrestronString STEMPDEVICE;
        CrestronString [] SMODULEINSTANCEID;
        private void SENDCOMMAND (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 66;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_INITCOMPLETE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 68;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CONNECTED_F  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 70;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMANDSENT == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 72;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SCOMMAND[ INEXTCOMMANDSEND ] ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 74;
                            COMMANDSENT = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 75;
                            TIMEOUTCOUNTER = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 76;
                            TO_DEVICE  .UpdateValue ( SCOMMAND [ INEXTCOMMANDSEND ]  ) ; 
                            __context__.SourceCodeLine = 77;
                            SCOMMAND [ INEXTCOMMANDSEND ]  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 78;
                            INEXTCOMMANDSEND = (ushort) ( (INEXTCOMMANDSEND + 1) ) ; 
                            __context__.SourceCodeLine = 79;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTCOMMANDSEND > 500 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 81;
                                INEXTCOMMANDSEND = (ushort) ( 1 ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 84;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SGET[ INEXTGETSEND ] ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 86;
                                COMMANDSENT = (ushort) ( 1 ) ; 
                                __context__.SourceCodeLine = 87;
                                TIMEOUTCOUNTER = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 88;
                                TO_DEVICE  .UpdateValue ( SGET [ INEXTGETSEND ]  ) ; 
                                __context__.SourceCodeLine = 89;
                                SGET [ INEXTGETSEND ]  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 90;
                                INEXTGETSEND = (ushort) ( (INEXTGETSEND + 1) ) ; 
                                __context__.SourceCodeLine = 91;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTGETSEND > 500 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 93;
                                    INEXTGETSEND = (ushort) ( 1 ) ; 
                                    } 
                                
                                } 
                            
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 99;
                        TIMEOUTCOUNTER = (ushort) ( (TIMEOUTCOUNTER + 1) ) ; 
                        __context__.SourceCodeLine = 100;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TIMEOUTCOUNTER == 10))  ) ) 
                            { 
                            __context__.SourceCodeLine = 102;
                            TIMEOUTCOUNTER = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 103;
                            COMMANDSENT = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 108;
            CreateWait ( "_SENDCOMMANDWAIT" , 20 , _SENDCOMMANDWAIT_Callback ) ;
            
            }
            
        public void _SENDCOMMANDWAIT_CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 110;
            SENDCOMMAND (  __context__  ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void CHECKINITSTATUS (  SplusExecutionContext __context__ ) 
        { 
        ushort D = 0;
        ushort EMPTYFOUND = 0;
        
        
        __context__.SourceCodeLine = 117;
        /* Trace( "checking init status") */ ; 
        __context__.SourceCodeLine = 118;
        EMPTYFOUND = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 119;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)NUMBEROFMODULES; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( D  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (D  >= __FN_FORSTART_VAL__1) && (D  <= __FN_FOREND_VAL__1) ) : ( (D  <= __FN_FORSTART_VAL__1) && (D  >= __FN_FOREND_VAL__1) ) ; D  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 121;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_MODULES[ D ] == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( SMODULEINSTANCEID[ D ] ) == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 122;
                /* Trace( "checking init status: found emtpty instance ID {0:d}", (short)D) */ ; 
                __context__.SourceCodeLine = 123;
                EMPTYFOUND = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 124;
                break ; 
                } 
            
            __context__.SourceCodeLine = 119;
            } 
        
        __context__.SourceCodeLine = 126;
        /* Trace( "checking init status: emptyFound = {0:d}", (short)EMPTYFOUND) */ ; 
        __context__.SourceCodeLine = 127;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (EMPTYFOUND == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 128;
            /* Trace( "checking init status: init complete") */ ; 
            __context__.SourceCodeLine = 129;
            INITIALIZE_IS_BUSY  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 130;
            _INITCOMPLETE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 131;
            SENDCOMMAND (  __context__  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 134;
            /* Trace( "checking init status: init not complete") */ ; 
            __context__.SourceCodeLine = 135;
            _INITCOMPLETE = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 137;
        INITCOMPLETE  .Value = (ushort) ( _INITCOMPLETE ) ; 
        
        }
        
    private void ADDMODULE (  SplusExecutionContext __context__, ushort PARAMDATA ) 
        { 
        
        __context__.SourceCodeLine = 142;
        _MODULES [ PARAMDATA] = (ushort) ( 1 ) ; 
        
        }
        
    private void INITMODULES (  SplusExecutionContext __context__ ) 
        { 
        
        __context__.SourceCodeLine = 147;
        INITIALIZE_IS_BUSY  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 148;
        _INITCOMPLETE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 149;
        INITCOMPLETE  .Value = (ushort) ( _INITCOMPLETE ) ; 
        __context__.SourceCodeLine = 150;
        COMMANDSENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 151;
        TIMEOUTCOUNTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 152;
        Functions.SetArray ( SMODULEINSTANCEID , "" ) ; 
        __context__.SourceCodeLine = 153;
        CHECKINITSTATUS (  __context__  ) ; 
        __context__.SourceCodeLine = 154;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)NUMBEROFMODULES; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 156;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_MODULES[ A ] == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 158;
                MakeString ( TO_MODULES [ A] , "{0:d} {1}", (short)A, "Send Name\u000D\u000A" ) ; 
                } 
            
            __context__.SourceCodeLine = 154;
            } 
        
        
        }
        
    object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 167;
            /* Trace( "Initialize: mainComplete = {0:d}", (short)MAINCOMPLETE) */ ; 
            __context__.SourceCodeLine = 168;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (MAINCOMPLETE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (_INITCOMPLETE == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (INITIALIZE_IS_BUSY  .Value == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 170;
                Print( "initialize is {0:d}", (short)INITIALIZE_IS_BUSY  .Value) ; 
                __context__.SourceCodeLine = 171;
                INITMODULES (  __context__  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object CONNECTED_F_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        Functions.Delay (  (int) ( 100 ) ) ; 
        __context__.SourceCodeLine = 178;
        TO_DEVICE  .UpdateValue ( "\u00FF\u00FE\u0001"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

private void ADDNAME (  SplusExecutionContext __context__, CrestronString PARAMDATA ) 
    { 
    
    __context__.SourceCodeLine = 183;
    ITEMPID = (ushort) ( Functions.Atoi( PARAMDATA ) ) ; 
    __context__.SourceCodeLine = 184;
    PARAMDATA  .UpdateValue ( Functions.Left ( PARAMDATA ,  (int) ( (Functions.Length( PARAMDATA ) - 2) ) )  ) ; 
    __context__.SourceCodeLine = 185;
    SMODULEINSTANCEID [ ITEMPID ]  .UpdateValue ( Functions.Mid ( PARAMDATA ,  (int) ( (Functions.Find( "=" , PARAMDATA ) + 1) ) ,  (int) ( (Functions.Length( PARAMDATA ) - Functions.Find( "=" , PARAMDATA )) ) ) + " "  ) ; 
    __context__.SourceCodeLine = 186;
    /* Trace( "AddName: itempId = {0:d}; sModuleInstanceID = {1}", (short)ITEMPID, SMODULEINSTANCEID [ ITEMPID ] ) */ ; 
    __context__.SourceCodeLine = 187;
    CHECKINITSTATUS (  __context__  ) ; 
    
    }
    
private void PROCESSFROMMODULES (  SplusExecutionContext __context__, CrestronString PARAMDATA ) 
    { 
    
    __context__.SourceCodeLine = 192;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "GET" , PARAMDATA ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 194;
        SGET [ INEXTGETSTORE ]  .UpdateValue ( PARAMDATA  ) ; 
        __context__.SourceCodeLine = 195;
        INEXTGETSTORE = (ushort) ( (INEXTGETSTORE + 1) ) ; 
        __context__.SourceCodeLine = 196;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTGETSTORE > 500 ))  ) ) 
            { 
            __context__.SourceCodeLine = 198;
            INEXTGETSTORE = (ushort) ( 1 ) ; 
            } 
        
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 203;
        SCOMMAND [ INEXTCOMMANDSTORE ]  .UpdateValue ( PARAMDATA  ) ; 
        __context__.SourceCodeLine = 204;
        INEXTCOMMANDSTORE = (ushort) ( (INEXTCOMMANDSTORE + 1) ) ; 
        __context__.SourceCodeLine = 205;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEXTCOMMANDSTORE > 500 ))  ) ) 
            { 
            __context__.SourceCodeLine = 207;
            INEXTCOMMANDSTORE = (ushort) ( 1 ) ; 
            } 
        
        } 
    
    
    }
    
object FROM_MODULES_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString STEMPMODULES;
        STEMPMODULES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        
        
        __context__.SourceCodeLine = 216;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 218;
            try 
                { 
                __context__.SourceCodeLine = 220;
                STEMPMODULES  .UpdateValue ( Functions.Gather ( "\u000A" , FROM_MODULES )  ) ; 
                __context__.SourceCodeLine = 221;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "hello" , STEMPMODULES ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 223;
                    ADDMODULE (  __context__ , (ushort)( Functions.Atoi( STEMPMODULES ) )) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 225;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "Send Name" , STEMPMODULES ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 227;
                        ADDNAME (  __context__ , STEMPMODULES) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 231;
                        PROCESSFROMMODULES (  __context__ , STEMPMODULES) ; 
                        } 
                    
                    }
                
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 236;
                GenerateUserNotice ( "BiAmp IP Queue: From_Modules: trouble parsing: {0}", Functions.GetExceptionMessage (  __splus_exceptionobj__ ) ) ; 
                
                }
                
                __context__.SourceCodeLine = 216;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

private void PROCESSFROMDEVICE (  SplusExecutionContext __context__, CrestronString PARAMDATA ) 
    { 
    
    __context__.SourceCodeLine = 272;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u00FF\u00FC\u0001" , PARAMDATA ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 274;
        PARAMDATA  .UpdateValue ( ""  ) ; 
        } 
    
    else 
        {
        __context__.SourceCodeLine = 276;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "RECALL" , Functions.Upper( PARAMDATA ) ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "PRESET" , Functions.Upper( PARAMDATA ) ) == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 278;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NUMBEROFMODULES; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( B  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (B  >= __FN_FORSTART_VAL__1) && (B  <= __FN_FOREND_VAL__1) ) : ( (B  <= __FN_FORSTART_VAL__1) && (B  >= __FN_FOREND_VAL__1) ) ; B  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 280;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( SMODULEINSTANCEID[ B ] ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( SMODULEINSTANCEID[ B ] , PARAMDATA ) > 0 ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 282;
                    TO_MODULES [ B]  .UpdateValue ( PARAMDATA  ) ; 
                    __context__.SourceCodeLine = 283;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 278;
                } 
            
            } 
        
        }
    
    
    }
    
object FROM_DEVICE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString STEMPDEVICE;
        STEMPDEVICE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        
        
        __context__.SourceCodeLine = 292;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 294;
            try 
                { 
                __context__.SourceCodeLine = 296;
                STEMPDEVICE  .UpdateValue ( Functions.Gather ( "\u000D\u000A" , FROM_DEVICE )  ) ; 
                __context__.SourceCodeLine = 297;
                COMMANDSENT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 298;
                TIMEOUTCOUNTER = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 299;
                PROCESSFROMDEVICE (  __context__ , STEMPDEVICE) ; 
                __context__.SourceCodeLine = 300;
                STEMPDEVICE  .UpdateValue ( ""  ) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                __context__.SourceCodeLine = 304;
                GenerateUserNotice ( "BiAmp IP Queue: From_Device: trouble parsing: {0}", Functions.GetExceptionMessage (  __splus_exceptionobj__ ) ) ; 
                
                }
                
                __context__.SourceCodeLine = 292;
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
        
        __context__.SourceCodeLine = 335;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 336;
        MAINCOMPLETE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 337;
        Functions.SetArray ( SCOMMAND , "" ) ; 
        __context__.SourceCodeLine = 338;
        Functions.SetArray ( SGET , "" ) ; 
        __context__.SourceCodeLine = 339;
        Functions.SetArray (  ref _MODULES , (ushort)0) ; 
        __context__.SourceCodeLine = 340;
        _INITCOMPLETE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 341;
        INITCOMPLETE  .Value = (ushort) ( _INITCOMPLETE ) ; 
        __context__.SourceCodeLine = 342;
        INITIALIZE_IS_BUSY  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 343;
        COMMANDSENT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 344;
        TIMEOUTCOUNTER = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 345;
        
        __context__.SourceCodeLine = 350;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 500 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1; 
        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
        for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 352;
            if ( Functions.TestForTrue  ( ( IsSignalDefined( TO_MODULES[ A ] ))  ) ) 
                { 
                __context__.SourceCodeLine = 354;
                NUMBEROFMODULES = (ushort) ( A ) ; 
                __context__.SourceCodeLine = 355;
                break ; 
                } 
            
            __context__.SourceCodeLine = 350;
            } 
        
        __context__.SourceCodeLine = 358;
        ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__2 = (ushort)NUMBEROFMODULES; 
        int __FN_FORSTEP_VAL__2 = (int)1; 
        for ( A  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (A  >= __FN_FORSTART_VAL__2) && (A  <= __FN_FOREND_VAL__2) ) : ( (A  <= __FN_FORSTART_VAL__2) && (A  >= __FN_FOREND_VAL__2) ) ; A  += (ushort)__FN_FORSTEP_VAL__2) 
            { 
            __context__.SourceCodeLine = 360;
            MakeString ( TO_MODULES [ A] , "hello {0:d}\u000D\u000A", (short)A) ; 
            __context__.SourceCodeLine = 358;
            } 
        
        __context__.SourceCodeLine = 362;
        MAINCOMPLETE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 363;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INITIALIZE  .Value == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 365;
            INITMODULES (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _MODULES  = new ushort[ 501 ];
    STEMPMODULES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    STEMPDEVICE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SCOMMAND  = new CrestronString[ 501 ];
    for( uint i = 0; i < 501; i++ )
        SCOMMAND [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SGET  = new CrestronString[ 501 ];
    for( uint i = 0; i < 501; i++ )
        SGET [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SMODULEINSTANCEID  = new CrestronString[ 501 ];
    for( uint i = 0; i < 501; i++ )
        SMODULEINSTANCEID [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    CONNECTED_F = new Crestron.Logos.SplusObjects.DigitalInput( CONNECTED_F__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECTED_F__DigitalInput__, CONNECTED_F );
    
    INITIALIZE_IS_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZE_IS_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZE_IS_BUSY__DigitalOutput__, INITIALIZE_IS_BUSY );
    
    INITCOMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( INITCOMPLETE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITCOMPLETE__DigitalOutput__, INITCOMPLETE );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    TO_MODULES = new InOutArray<StringOutput>( 500, this );
    for( uint i = 0; i < 500; i++ )
    {
        TO_MODULES[i+1] = new Crestron.Logos.SplusObjects.StringOutput( TO_MODULES__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( TO_MODULES__AnalogSerialOutput__ + i, TO_MODULES[i+1] );
    }
    
    FROM_DEVICE = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__AnalogSerialInput__, 5000, this );
    m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
    
    FROM_MODULES = new Crestron.Logos.SplusObjects.BufferInput( FROM_MODULES__AnalogSerialInput__, 5000, this );
    m_StringInputList.Add( FROM_MODULES__AnalogSerialInput__, FROM_MODULES );
    
    _SENDCOMMANDWAIT_Callback = new WaitFunction( _SENDCOMMANDWAIT_CallbackFn );
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    CONNECTED_F.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECTED_F_OnPush_1, false ) );
    FROM_MODULES.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_MODULES_OnChange_2, true ) );
    FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_3, true ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_BIAMP_AUDIAFLEX_COMMAND_PROCESSOR_IP_V7_5_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction _SENDCOMMANDWAIT_Callback;


const uint INITIALIZE__DigitalInput__ = 0;
const uint CONNECTED_F__DigitalInput__ = 1;
const uint FROM_DEVICE__AnalogSerialInput__ = 0;
const uint FROM_MODULES__AnalogSerialInput__ = 1;
const uint INITIALIZE_IS_BUSY__DigitalOutput__ = 0;
const uint INITCOMPLETE__DigitalOutput__ = 1;
const uint TO_DEVICE__AnalogSerialOutput__ = 0;
const uint TO_MODULES__AnalogSerialOutput__ = 1;

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
