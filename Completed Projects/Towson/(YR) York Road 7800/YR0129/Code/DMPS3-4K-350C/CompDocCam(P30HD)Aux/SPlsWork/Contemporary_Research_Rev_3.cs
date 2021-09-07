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

namespace UserModule_CONTEMPORARY_RESEARCH_REV_3
{
    public class UserModuleClass_CONTEMPORARY_RESEARCH_REV_3 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput DIG_0;
        Crestron.Logos.SplusObjects.DigitalInput DIG_1;
        Crestron.Logos.SplusObjects.DigitalInput DIG_2;
        Crestron.Logos.SplusObjects.DigitalInput DIG_3;
        Crestron.Logos.SplusObjects.DigitalInput DIG_4;
        Crestron.Logos.SplusObjects.DigitalInput DIG_5;
        Crestron.Logos.SplusObjects.DigitalInput DIG_6;
        Crestron.Logos.SplusObjects.DigitalInput DIG_7;
        Crestron.Logos.SplusObjects.DigitalInput DIG_8;
        Crestron.Logos.SplusObjects.DigitalInput DIG_9;
        Crestron.Logos.SplusObjects.DigitalInput DASH;
        Crestron.Logos.SplusObjects.DigitalInput CH_UP;
        Crestron.Logos.SplusObjects.DigitalInput CH_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput ENTER;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PRESET;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> PRESET_VAL_IN__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> PRESET_FB;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_CHAN;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PRESET_NAME__DOLLAR__;
        ushort I = 0;
        ushort DIG_VAL = 0;
        ushort ACT_PRESET = 0;
        CrestronString [] PRESET_VAL__DOLLAR__;
        ushort IPRESET_SAVE = 0;
        ushort TEMP_CH_VAL = 0;
        CrestronString LAST_DIGIT;
        CrestronString CH_VAL;
        CrestronString STORED_CH_VAL;
        CrestronString RET_DATA;
        CrestronString RET_DATA2;
        CrestronString TEMP_RET_DATA1;
        CrestronString TEMP_RET_DATA2;
        object DIG_0_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 55;
                DIG_VAL = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 56;
                LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
                __context__.SourceCodeLine = 57;
                CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
                __context__.SourceCodeLine = 58;
                CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DIG_1_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 63;
            DIG_VAL = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 64;
            LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
            __context__.SourceCodeLine = 65;
            CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
            __context__.SourceCodeLine = 66;
            CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object DIG_2_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 71;
        DIG_VAL = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 72;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 73;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 74;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIG_3_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 79;
        DIG_VAL = (ushort) ( 3 ) ; 
        __context__.SourceCodeLine = 80;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 81;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 82;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIG_4_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        DIG_VAL = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 88;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 89;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 90;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIG_5_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 95;
        DIG_VAL = (ushort) ( 5 ) ; 
        __context__.SourceCodeLine = 96;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 97;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 98;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIG_6_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 103;
        DIG_VAL = (ushort) ( 6 ) ; 
        __context__.SourceCodeLine = 104;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 105;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 106;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIG_7_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 111;
        DIG_VAL = (ushort) ( 7 ) ; 
        __context__.SourceCodeLine = 112;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 113;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 114;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIG_8_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        DIG_VAL = (ushort) ( 8 ) ; 
        __context__.SourceCodeLine = 120;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 121;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 122;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIG_9_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 127;
        DIG_VAL = (ushort) ( 9 ) ; 
        __context__.SourceCodeLine = 128;
        LAST_DIGIT  .UpdateValue ( Functions.ItoA (  (int) ( DIG_VAL ) )  ) ; 
        __context__.SourceCodeLine = 129;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 130;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DASH_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        LAST_DIGIT  .UpdateValue ( "-"  ) ; 
        __context__.SourceCodeLine = 136;
        CH_VAL  .UpdateValue ( CH_VAL + LAST_DIGIT  ) ; 
        __context__.SourceCodeLine = 137;
        CURRENT_CHAN  .UpdateValue ( CH_VAL  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        TX__DOLLAR__  .UpdateValue ( ">1TC=" + CH_VAL + "\u000D"  ) ; 
        __context__.SourceCodeLine = 143;
        STORED_CH_VAL  .UpdateValue ( CH_VAL  ) ; 
        __context__.SourceCodeLine = 144;
        TEMP_CH_VAL = (ushort) ( Functions.Atoi( STORED_CH_VAL ) ) ; 
        __context__.SourceCodeLine = 145;
        CH_VAL  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        CH_VAL  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_UP_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 155;
        TX__DOLLAR__  .UpdateValue ( ">1TU\u000D"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CH_DOWN_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 161;
        TX__DOLLAR__  .UpdateValue ( ">1TD\u000D"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 166;
        ACT_PRESET = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 167;
        TX__DOLLAR__  .UpdateValue ( ">1TC=" + PRESET_VAL__DOLLAR__ [ ACT_PRESET ] + "\u000D"  ) ; 
        __context__.SourceCodeLine = 168;
        Functions.Pulse ( 25, PRESET_FB [ ACT_PRESET] ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_VAL_IN__DOLLAR___OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 174;
        I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 175;
        PRESET_VAL__DOLLAR__ [ I ]  .UpdateValue ( PRESET_VAL_IN__DOLLAR__ [ I ]  ) ; 
        __context__.SourceCodeLine = 176;
        PRESET_NAME__DOLLAR__ [ I]  .UpdateValue ( PRESET_VAL__DOLLAR__ [ I ]  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 182;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_1__" , 1000 , __SPLS_TMPVAR__WAITLABEL_1___Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    
public void __SPLS_TMPVAR__WAITLABEL_1___CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 184;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)6; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 186;
                PRESET_VAL__DOLLAR__ [ I ]  .UpdateValue ( PRESET_VAL_IN__DOLLAR__ [ I ]  ) ; 
                __context__.SourceCodeLine = 187;
                PRESET_NAME__DOLLAR__ [ I]  .UpdateValue ( PRESET_VAL__DOLLAR__ [ I ]  ) ; 
                __context__.SourceCodeLine = 184;
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    LAST_DIGIT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    CH_VAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    STORED_CH_VAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    RET_DATA  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    RET_DATA2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    TEMP_RET_DATA1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    TEMP_RET_DATA2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    PRESET_VAL__DOLLAR__  = new CrestronString[ 7 ];
    for( uint i = 0; i < 7; i++ )
        PRESET_VAL__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    
    DIG_0 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_0__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_0__DigitalInput__, DIG_0 );
    
    DIG_1 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_1__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_1__DigitalInput__, DIG_1 );
    
    DIG_2 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_2__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_2__DigitalInput__, DIG_2 );
    
    DIG_3 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_3__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_3__DigitalInput__, DIG_3 );
    
    DIG_4 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_4__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_4__DigitalInput__, DIG_4 );
    
    DIG_5 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_5__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_5__DigitalInput__, DIG_5 );
    
    DIG_6 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_6__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_6__DigitalInput__, DIG_6 );
    
    DIG_7 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_7__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_7__DigitalInput__, DIG_7 );
    
    DIG_8 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_8__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_8__DigitalInput__, DIG_8 );
    
    DIG_9 = new Crestron.Logos.SplusObjects.DigitalInput( DIG_9__DigitalInput__, this );
    m_DigitalInputList.Add( DIG_9__DigitalInput__, DIG_9 );
    
    DASH = new Crestron.Logos.SplusObjects.DigitalInput( DASH__DigitalInput__, this );
    m_DigitalInputList.Add( DASH__DigitalInput__, DASH );
    
    CH_UP = new Crestron.Logos.SplusObjects.DigitalInput( CH_UP__DigitalInput__, this );
    m_DigitalInputList.Add( CH_UP__DigitalInput__, CH_UP );
    
    CH_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( CH_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CH_DOWN__DigitalInput__, CH_DOWN );
    
    ENTER = new Crestron.Logos.SplusObjects.DigitalInput( ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER__DigitalInput__, ENTER );
    
    CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR__DigitalInput__, CLEAR );
    
    PRESET = new InOutArray<DigitalInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        PRESET[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PRESET__DigitalInput__ + i, PRESET__DigitalInput__, this );
        m_DigitalInputList.Add( PRESET__DigitalInput__ + i, PRESET[i+1] );
    }
    
    PRESET_FB = new InOutArray<DigitalOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        PRESET_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( PRESET_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( PRESET_FB__DigitalOutput__ + i, PRESET_FB[i+1] );
    }
    
    PRESET_VAL_IN__DOLLAR__ = new InOutArray<StringInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        PRESET_VAL_IN__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( PRESET_VAL_IN__DOLLAR____AnalogSerialInput__ + i, PRESET_VAL_IN__DOLLAR____AnalogSerialInput__, 5, this );
        m_StringInputList.Add( PRESET_VAL_IN__DOLLAR____AnalogSerialInput__ + i, PRESET_VAL_IN__DOLLAR__[i+1] );
    }
    
    CURRENT_CHAN = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_CHAN__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_CHAN__AnalogSerialOutput__, CURRENT_CHAN );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    PRESET_NAME__DOLLAR__ = new InOutArray<StringOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        PRESET_NAME__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PRESET_NAME__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PRESET_NAME__DOLLAR____AnalogSerialOutput__ + i, PRESET_NAME__DOLLAR__[i+1] );
    }
    
    __SPLS_TMPVAR__WAITLABEL_1___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_1___CallbackFn );
    
    DIG_0.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_0_OnPush_0, false ) );
    DIG_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_1_OnPush_1, false ) );
    DIG_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_2_OnPush_2, false ) );
    DIG_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_3_OnPush_3, false ) );
    DIG_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_4_OnPush_4, false ) );
    DIG_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_5_OnPush_5, false ) );
    DIG_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_6_OnPush_6, false ) );
    DIG_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_7_OnPush_7, false ) );
    DIG_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_8_OnPush_8, false ) );
    DIG_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( DIG_9_OnPush_9, false ) );
    DASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( DASH_OnPush_10, false ) );
    ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_OnPush_11, false ) );
    CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_OnPush_12, false ) );
    CH_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CH_UP_OnPush_13, false ) );
    CH_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CH_DOWN_OnPush_14, false ) );
    for( uint i = 0; i < 6; i++ )
        PRESET[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_OnPush_15, false ) );
        
    for( uint i = 0; i < 6; i++ )
        PRESET_VAL_IN__DOLLAR__[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( PRESET_VAL_IN__DOLLAR___OnChange_16, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CONTEMPORARY_RESEARCH_REV_3 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_1___Callback;


const uint DIG_0__DigitalInput__ = 0;
const uint DIG_1__DigitalInput__ = 1;
const uint DIG_2__DigitalInput__ = 2;
const uint DIG_3__DigitalInput__ = 3;
const uint DIG_4__DigitalInput__ = 4;
const uint DIG_5__DigitalInput__ = 5;
const uint DIG_6__DigitalInput__ = 6;
const uint DIG_7__DigitalInput__ = 7;
const uint DIG_8__DigitalInput__ = 8;
const uint DIG_9__DigitalInput__ = 9;
const uint DASH__DigitalInput__ = 10;
const uint CH_UP__DigitalInput__ = 11;
const uint CH_DOWN__DigitalInput__ = 12;
const uint ENTER__DigitalInput__ = 13;
const uint CLEAR__DigitalInput__ = 14;
const uint PRESET__DigitalInput__ = 15;
const uint PRESET_VAL_IN__DOLLAR____AnalogSerialInput__ = 0;
const uint PRESET_FB__DigitalOutput__ = 0;
const uint CURRENT_CHAN__AnalogSerialOutput__ = 0;
const uint TX__DOLLAR____AnalogSerialOutput__ = 1;
const uint PRESET_NAME__DOLLAR____AnalogSerialOutput__ = 2;

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
