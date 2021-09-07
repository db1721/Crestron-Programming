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

namespace CrestronModule_FUSION_SSI_DEVICE_USAGE_HELPER_V1_0_0
{
    public class CrestronModuleClass_FUSION_SSI_DEVICE_USAGE_HELPER_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD;
        Crestron.Logos.SplusObjects.DigitalInput CLOCK_B;
        Crestron.Logos.SplusObjects.DigitalInput SYSTEM_POWERED_OFF_HELD;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DEVICE_IN_USE_HELD;
        Crestron.Logos.SplusObjects.StringInput MEETING_ID__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ASSET_ID__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ASSET_TYPE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ASSET_NAME__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ASSET_TYPE_DIRECT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ASSET_NAME_DIRECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DEVICE_USAGE_TX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> CURRENT_USAGE_MINUTES_FB;
        UShortParameter DEBUGMODE;
        CrestronString G_SPREVIOUSMEETINGID__DOLLAR__;
        CrestronString G_SCURRENTMEETINGID__DOLLAR__;
        CrestronString G_SCURRENTDATE__DOLLAR__;
        CrestronString G_SCOMPAREDATE__DOLLAR__;
        STRUCTUREDEVICE [] G_ODEVICES;
        private void FNTRANSMITUSAGEDATA (  SplusExecutionContext __context__, ushort NINDEX , ushort NMEETINGTYPE ) 
            { 
            ushort NMINUTESUSED = 0;
            
            CrestronString SASSETID__DOLLAR__;
            CrestronString SMEETINGID__DOLLAR__;
            CrestronString STIME__DOLLAR__;
            SASSETID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SMEETINGID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            STIME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 93;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_ODEVICES[ NINDEX ].NCURRENTMINUTES == 0) ) && Functions.TestForTrue ( Functions.BoolToInt ( G_ODEVICES[ NINDEX ].NCURRENTSECONDS > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 95;
                CURRENT_USAGE_MINUTES_FB [ NINDEX]  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 96;
                NMINUTESUSED = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 100;
                CURRENT_USAGE_MINUTES_FB [ NINDEX]  .Value = (ushort) ( G_ODEVICES[ NINDEX ].NCURRENTMINUTES ) ; 
                __context__.SourceCodeLine = 101;
                NMINUTESUSED = (ushort) ( G_ODEVICES[ NINDEX ].NCURRENTMINUTES ) ; 
                } 
            
            __context__.SourceCodeLine = 104;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCOMPAREDATE__DOLLAR__ != Functions.Date( (int)( 3 ) )))  ) ) 
                { 
                __context__.SourceCodeLine = 106;
                MakeString ( G_SCURRENTDATE__DOLLAR__ , "{0}", Functions.Date (  (int) ( 3 ) ) ) ; 
                __context__.SourceCodeLine = 107;
                MakeString ( G_SCOMPAREDATE__DOLLAR__ , "{0}", Functions.Date (  (int) ( 3 ) ) ) ; 
                __context__.SourceCodeLine = 108;
                MakeString ( G_SCURRENTDATE__DOLLAR__ , "{0}-{1}-{2}", Functions.Left ( G_SCURRENTDATE__DOLLAR__ ,  (int) ( 4 ) ) , Functions.Mid ( G_SCURRENTDATE__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 2 ) ) , Functions.Right ( G_SCURRENTDATE__DOLLAR__ ,  (int) ( 2 ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 110;
            MakeString ( STIME__DOLLAR__ , "{0}", Functions.Time ( ) ) ; 
            __context__.SourceCodeLine = 114;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_ODEVICES[ NINDEX ].SASSETID__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 116;
                MakeString ( SASSETID__DOLLAR__ , "{0}", G_ODEVICES [ NINDEX] . SASSETID__DOLLAR__ ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 120;
                MakeString ( SASSETID__DOLLAR__ , "-") ; 
                } 
            
            __context__.SourceCodeLine = 123;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NMEETINGTYPE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 125;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SCURRENTMEETINGID__DOLLAR__ ) > 5 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 127;
                    MakeString ( SMEETINGID__DOLLAR__ , "{0}", G_SCURRENTMEETINGID__DOLLAR__ ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 131;
                    MakeString ( SMEETINGID__DOLLAR__ , "-") ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 134;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NMEETINGTYPE == 2))  ) ) 
                    { 
                    __context__.SourceCodeLine = 136;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SPREVIOUSMEETINGID__DOLLAR__ ) > 5 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 138;
                        MakeString ( SMEETINGID__DOLLAR__ , "{0}", G_SPREVIOUSMEETINGID__DOLLAR__ ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 142;
                        MakeString ( SMEETINGID__DOLLAR__ , "-") ; 
                        } 
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 146;
            MakeString ( DEVICE_USAGE_TX__DOLLAR__ , "USAGE||{0}||{1}||TIME||{2}||{3}||-||{4}||-||{5}||{6}||\r\n", G_SCURRENTDATE__DOLLAR__ , STIME__DOLLAR__ , G_ODEVICES [ NINDEX] . SASSETTYPE__DOLLAR__ , G_ODEVICES [ NINDEX] . SASSETNAME__DOLLAR__ , Functions.ItoA (  (int) ( NMINUTESUSED ) ) , SASSETID__DOLLAR__ , SMEETINGID__DOLLAR__ ) ; 
            
            }
            
        object MEETING_ID__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort NINDEX = 0;
                
                
                __context__.SourceCodeLine = 156;
                if ( Functions.TestForTrue  ( ( ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 158;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MEETING_ID__DOLLAR__ != G_SPREVIOUSMEETINGID__DOLLAR__))  ) ) 
                        { 
                        __context__.SourceCodeLine = 160;
                        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                        ushort __FN_FOREND_VAL__1 = (ushort)16; 
                        int __FN_FORSTEP_VAL__1 = (int)1; 
                        for ( NINDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NINDEX  >= __FN_FORSTART_VAL__1) && (NINDEX  <= __FN_FOREND_VAL__1) ) : ( (NINDEX  <= __FN_FORSTART_VAL__1) && (NINDEX  >= __FN_FOREND_VAL__1) ) ; NINDEX  += (ushort)__FN_FORSTEP_VAL__1) 
                            { 
                            __context__.SourceCodeLine = 162;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ODEVICES[ NINDEX ].NINUSE == 1))  ) ) 
                                { 
                                __context__.SourceCodeLine = 164;
                                FNTRANSMITUSAGEDATA (  __context__ , (ushort)( NINDEX ), (ushort)( 2 )) ; 
                                __context__.SourceCodeLine = 167;
                                G_ODEVICES [ NINDEX] . NCURRENTMINUTES = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 168;
                                G_ODEVICES [ NINDEX] . NCURRENTSECONDS = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 160;
                            } 
                        
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 174;
                MakeString ( G_SCURRENTMEETINGID__DOLLAR__ , "{0}", MEETING_ID__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 175;
                MakeString ( G_SPREVIOUSMEETINGID__DOLLAR__ , "{0}", MEETING_ID__DOLLAR__ ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ASSET_TYPE__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort NINDEX = 0;
            
            
            __context__.SourceCodeLine = 182;
            NINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 184;
            MakeString ( G_ODEVICES [ NINDEX] . SASSETTYPE__DOLLAR__ , "{0}", ASSET_TYPE__DOLLAR__ [ NINDEX ] ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ASSET_NAME__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NINDEX = 0;
        
        
        __context__.SourceCodeLine = 191;
        NINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 193;
        MakeString ( G_ODEVICES [ NINDEX] . SASSETNAME__DOLLAR__ , "{0}", ASSET_NAME__DOLLAR__ [ NINDEX ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ASSET_TYPE_DIRECT__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NINDEX = 0;
        
        
        __context__.SourceCodeLine = 200;
        NINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 202;
        MakeString ( G_ODEVICES [ NINDEX] . SASSETTYPE__DOLLAR__ , "{0}", ASSET_TYPE_DIRECT__DOLLAR__ [ NINDEX ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ASSET_NAME_DIRECT__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NINDEX = 0;
        
        
        __context__.SourceCodeLine = 209;
        NINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 211;
        MakeString ( G_ODEVICES [ NINDEX] . SASSETNAME__DOLLAR__ , "{0}", ASSET_NAME_DIRECT__DOLLAR__ [ NINDEX ] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEVICE_IN_USE_HELD_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NINDEX = 0;
        
        
        __context__.SourceCodeLine = 218;
        NINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 220;
        G_ODEVICES [ NINDEX] . NINUSE = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEVICE_IN_USE_HELD_OnRelease_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NINDEX = 0;
        
        
        __context__.SourceCodeLine = 227;
        NINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 229;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ODEVICES[ NINDEX ].NINUSE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 231;
            G_ODEVICES [ NINDEX] . NINUSE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 232;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( G_ODEVICES[ NINDEX ].NCURRENTMINUTES > 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( G_ODEVICES[ NINDEX ].NCURRENTSECONDS > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 234;
                FNTRANSMITUSAGEDATA (  __context__ , (ushort)( NINDEX ), (ushort)( 1 )) ; 
                __context__.SourceCodeLine = 235;
                G_ODEVICES [ NINDEX] . NCURRENTMINUTES = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 236;
                G_ODEVICES [ NINDEX] . NCURRENTSECONDS = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLOCK_B_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NINDEX = 0;
        
        
        __context__.SourceCodeLine = 245;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)16; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( NINDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NINDEX  >= __FN_FORSTART_VAL__1) && (NINDEX  <= __FN_FOREND_VAL__1) ) : ( (NINDEX  <= __FN_FORSTART_VAL__1) && (NINDEX  >= __FN_FOREND_VAL__1) ) ; NINDEX  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 247;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ODEVICES[ NINDEX ].NINUSE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 249;
                G_ODEVICES [ NINDEX] . NCURRENTSECONDS = (ushort) ( (G_ODEVICES[ NINDEX ].NCURRENTSECONDS + 30) ) ; 
                __context__.SourceCodeLine = 250;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_ODEVICES[ NINDEX ].NCURRENTSECONDS > 59 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 252;
                    G_ODEVICES [ NINDEX] . NCURRENTMINUTES = (ushort) ( (G_ODEVICES[ NINDEX ].NCURRENTMINUTES + 1) ) ; 
                    __context__.SourceCodeLine = 253;
                    G_ODEVICES [ NINDEX] . NCURRENTSECONDS = (ushort) ( (G_ODEVICES[ NINDEX ].NCURRENTSECONDS - 60) ) ; 
                    __context__.SourceCodeLine = 254;
                    CURRENT_USAGE_MINUTES_FB [ NINDEX]  .Value = (ushort) ( G_ODEVICES[ NINDEX ].NCURRENTMINUTES ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 245;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SYSTEM_POWERED_OFF_HELD_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort NINDEX = 0;
        
        
        __context__.SourceCodeLine = 264;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)16; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( NINDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NINDEX  >= __FN_FORSTART_VAL__1) && (NINDEX  <= __FN_FOREND_VAL__1) ) : ( (NINDEX  <= __FN_FORSTART_VAL__1) && (NINDEX  >= __FN_FOREND_VAL__1) ) ; NINDEX  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 266;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ODEVICES[ NINDEX ].NINUSE == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 268;
                FNTRANSMITUSAGEDATA (  __context__ , (ushort)( NINDEX ), (ushort)( 2 )) ; 
                __context__.SourceCodeLine = 271;
                G_ODEVICES [ NINDEX] . NCURRENTMINUTES = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 272;
                G_ODEVICES [ NINDEX] . NCURRENTSECONDS = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 273;
                G_ODEVICES [ NINDEX] . NINUSE = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 264;
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
        
        __context__.SourceCodeLine = 282;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 284;
        MakeString ( G_SCURRENTDATE__DOLLAR__ , "{0}", Functions.Date (  (int) ( 3 ) ) ) ; 
        __context__.SourceCodeLine = 285;
        MakeString ( G_SCURRENTDATE__DOLLAR__ , "{0}-{1}-{2}", Functions.Left ( G_SCURRENTDATE__DOLLAR__ ,  (int) ( 4 ) ) , Functions.Mid ( G_SCURRENTDATE__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( 2 ) ) , Functions.Right ( G_SCURRENTDATE__DOLLAR__ ,  (int) ( 2 ) ) ) ; 
        __context__.SourceCodeLine = 286;
        MakeString ( G_SCOMPAREDATE__DOLLAR__ , "{0}", Functions.Date (  (int) ( 3 ) ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SPREVIOUSMEETINGID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    G_SCURRENTMEETINGID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    G_SCURRENTDATE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    G_SCOMPAREDATE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    G_ODEVICES  = new STRUCTUREDEVICE[ 17 ];
    for( uint i = 0; i < 17; i++ )
    {
        G_ODEVICES [i] = new STRUCTUREDEVICE( this, true );
        G_ODEVICES [i].PopulateCustomAttributeList( false );
        
    }
    
    ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD__DigitalInput__, ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD );
    
    CLOCK_B = new Crestron.Logos.SplusObjects.DigitalInput( CLOCK_B__DigitalInput__, this );
    m_DigitalInputList.Add( CLOCK_B__DigitalInput__, CLOCK_B );
    
    SYSTEM_POWERED_OFF_HELD = new Crestron.Logos.SplusObjects.DigitalInput( SYSTEM_POWERED_OFF_HELD__DigitalInput__, this );
    m_DigitalInputList.Add( SYSTEM_POWERED_OFF_HELD__DigitalInput__, SYSTEM_POWERED_OFF_HELD );
    
    DEVICE_IN_USE_HELD = new InOutArray<DigitalInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        DEVICE_IN_USE_HELD[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DEVICE_IN_USE_HELD__DigitalInput__ + i, DEVICE_IN_USE_HELD__DigitalInput__, this );
        m_DigitalInputList.Add( DEVICE_IN_USE_HELD__DigitalInput__ + i, DEVICE_IN_USE_HELD[i+1] );
    }
    
    CURRENT_USAGE_MINUTES_FB = new InOutArray<AnalogOutput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        CURRENT_USAGE_MINUTES_FB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_USAGE_MINUTES_FB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( CURRENT_USAGE_MINUTES_FB__AnalogSerialOutput__ + i, CURRENT_USAGE_MINUTES_FB[i+1] );
    }
    
    MEETING_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( MEETING_ID__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( MEETING_ID__DOLLAR____AnalogSerialInput__, MEETING_ID__DOLLAR__ );
    
    ASSET_ID__DOLLAR__ = new InOutArray<StringInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        ASSET_ID__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( ASSET_ID__DOLLAR____AnalogSerialInput__ + i, ASSET_ID__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( ASSET_ID__DOLLAR____AnalogSerialInput__ + i, ASSET_ID__DOLLAR__[i+1] );
    }
    
    ASSET_TYPE__DOLLAR__ = new InOutArray<StringInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        ASSET_TYPE__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( ASSET_TYPE__DOLLAR____AnalogSerialInput__ + i, ASSET_TYPE__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( ASSET_TYPE__DOLLAR____AnalogSerialInput__ + i, ASSET_TYPE__DOLLAR__[i+1] );
    }
    
    ASSET_NAME__DOLLAR__ = new InOutArray<StringInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        ASSET_NAME__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( ASSET_NAME__DOLLAR____AnalogSerialInput__ + i, ASSET_NAME__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( ASSET_NAME__DOLLAR____AnalogSerialInput__ + i, ASSET_NAME__DOLLAR__[i+1] );
    }
    
    ASSET_TYPE_DIRECT__DOLLAR__ = new InOutArray<StringInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        ASSET_TYPE_DIRECT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( ASSET_TYPE_DIRECT__DOLLAR____AnalogSerialInput__ + i, ASSET_TYPE_DIRECT__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( ASSET_TYPE_DIRECT__DOLLAR____AnalogSerialInput__ + i, ASSET_TYPE_DIRECT__DOLLAR__[i+1] );
    }
    
    ASSET_NAME_DIRECT__DOLLAR__ = new InOutArray<StringInput>( 16, this );
    for( uint i = 0; i < 16; i++ )
    {
        ASSET_NAME_DIRECT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( ASSET_NAME_DIRECT__DOLLAR____AnalogSerialInput__ + i, ASSET_NAME_DIRECT__DOLLAR____AnalogSerialInput__, 50, this );
        m_StringInputList.Add( ASSET_NAME_DIRECT__DOLLAR____AnalogSerialInput__ + i, ASSET_NAME_DIRECT__DOLLAR__[i+1] );
    }
    
    DEVICE_USAGE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DEVICE_USAGE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DEVICE_USAGE_TX__DOLLAR____AnalogSerialOutput__, DEVICE_USAGE_TX__DOLLAR__ );
    
    DEBUGMODE = new UShortParameter( DEBUGMODE__Parameter__, this );
    m_ParameterList.Add( DEBUGMODE__Parameter__, DEBUGMODE );
    
    
    MEETING_ID__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( MEETING_ID__DOLLAR___OnChange_0, true ) );
    for( uint i = 0; i < 16; i++ )
        ASSET_TYPE__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( ASSET_TYPE__DOLLAR___OnChange_1, false ) );
        
    for( uint i = 0; i < 16; i++ )
        ASSET_NAME__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( ASSET_NAME__DOLLAR___OnChange_2, false ) );
        
    for( uint i = 0; i < 16; i++ )
        ASSET_TYPE_DIRECT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( ASSET_TYPE_DIRECT__DOLLAR___OnChange_3, false ) );
        
    for( uint i = 0; i < 16; i++ )
        ASSET_NAME_DIRECT__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( ASSET_NAME_DIRECT__DOLLAR___OnChange_4, false ) );
        
    for( uint i = 0; i < 16; i++ )
        DEVICE_IN_USE_HELD[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DEVICE_IN_USE_HELD_OnPush_5, false ) );
        
    for( uint i = 0; i < 16; i++ )
        DEVICE_IN_USE_HELD[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( DEVICE_IN_USE_HELD_OnRelease_6, false ) );
        
    CLOCK_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLOCK_B_OnPush_7, false ) );
    SYSTEM_POWERED_OFF_HELD.OnDigitalPush.Add( new InputChangeHandlerWrapper( SYSTEM_POWERED_OFF_HELD_OnPush_8, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_FUSION_SSI_DEVICE_USAGE_HELPER_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint ENABLE_TRANSMIT_ON_MEETING_CHANGE_HELD__DigitalInput__ = 0;
const uint CLOCK_B__DigitalInput__ = 1;
const uint SYSTEM_POWERED_OFF_HELD__DigitalInput__ = 2;
const uint DEVICE_IN_USE_HELD__DigitalInput__ = 3;
const uint MEETING_ID__DOLLAR____AnalogSerialInput__ = 0;
const uint ASSET_ID__DOLLAR____AnalogSerialInput__ = 1;
const uint ASSET_TYPE__DOLLAR____AnalogSerialInput__ = 17;
const uint ASSET_NAME__DOLLAR____AnalogSerialInput__ = 33;
const uint ASSET_TYPE_DIRECT__DOLLAR____AnalogSerialInput__ = 49;
const uint ASSET_NAME_DIRECT__DOLLAR____AnalogSerialInput__ = 65;
const uint DEVICE_USAGE_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint CURRENT_USAGE_MINUTES_FB__AnalogSerialOutput__ = 1;
const uint DEBUGMODE__Parameter__ = 10;

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
public class STRUCTUREDEVICE : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  SASSETTYPE__DOLLAR__;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  SASSETNAME__DOLLAR__;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  SASSETID__DOLLAR__;
    
    [SplusStructAttribute(3, false, false)]
    public ushort  NINUSE = 0;
    
    [SplusStructAttribute(4, false, false)]
    public ushort  NCURRENTMINUTES = 0;
    
    [SplusStructAttribute(5, false, false)]
    public ushort  NCURRENTSECONDS = 0;
    
    
    public STRUCTUREDEVICE( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        SASSETTYPE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        SASSETNAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        SASSETID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, Owner );
        
        
    }
    
}

}
