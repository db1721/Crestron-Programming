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

namespace UserModule_TOWSON_ASSIGNABLE_LIST
{
    public class UserModuleClass_TOWSON_ASSIGNABLE_LIST : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput READYLATCH;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ITEMSELECTEDFB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> ITEMDISABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LISTITEMSELECT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ITEMSELECT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LISTITEMSELECTED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LISTITEMENABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LISTITEMVISIBLE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LISTITEMPOSITION;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> ITEMNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> LISTITEMNAME;
        ushort READY = 0;
        ushort [] ORGINPOS;
        private void PROCESSLIST (  SplusExecutionContext __context__ ) 
            { 
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 56;
            Functions.SetArray (  ref ORGINPOS , (ushort)0) ; 
            __context__.SourceCodeLine = 57;
            Functions.SetArray ( LISTITEMSELECTED , (ushort)0) ; 
            __context__.SourceCodeLine = 58;
            Functions.SetArray ( LISTITEMVISIBLE , (ushort)0) ; 
            __context__.SourceCodeLine = 59;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)10; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 61;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LISTITEMPOSITION[ X ] .UshortValue > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 63;
                    ORGINPOS [ LISTITEMPOSITION[ X ] .UshortValue] = (ushort) ( X ) ; 
                    __context__.SourceCodeLine = 64;
                    ITEMSELECT [ X]  .Value = (ushort) ( LISTITEMSELECT[ LISTITEMPOSITION[ X ] .UshortValue ] .Value ) ; 
                    __context__.SourceCodeLine = 65;
                    LISTITEMSELECTED [ LISTITEMPOSITION[ X ] .UshortValue]  .Value = (ushort) ( ITEMSELECTEDFB[ X ] .Value ) ; 
                    __context__.SourceCodeLine = 66;
                    if ( Functions.TestForTrue  ( ( Functions.Length( ITEMNAME[ X ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 68;
                        LISTITEMVISIBLE [ LISTITEMPOSITION[ X ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 70;
                    LISTITEMNAME [ LISTITEMPOSITION[ X ] .UshortValue]  .UpdateValue ( ITEMNAME [ X ]  ) ; 
                    __context__.SourceCodeLine = 71;
                    LISTITEMENABLE [ LISTITEMPOSITION[ X ] .UshortValue]  .Value = (ushort) ( Functions.Not( ITEMDISABLE[ X ] .Value ) ) ; 
                    } 
                
                else 
                    { 
                    } 
                
                __context__.SourceCodeLine = 59;
                } 
            
            __context__.SourceCodeLine = 78;
            READY = (ushort) ( 1 ) ; 
            
            }
            
        object ITEMDISABLE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort X = 0;
                
                
                __context__.SourceCodeLine = 83;
                X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 84;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X > 0 ) ) && Functions.TestForTrue ( READY )) ) ) && Functions.TestForTrue ( LISTITEMPOSITION[ X ] .UshortValue )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 86;
                    LISTITEMENABLE [ LISTITEMPOSITION[ X ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ITEMDISABLE_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 92;
            X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 93;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X > 0 ) ) && Functions.TestForTrue ( READY )) ) ) && Functions.TestForTrue ( LISTITEMPOSITION[ X ] .UshortValue )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 95;
                LISTITEMENABLE [ LISTITEMPOSITION[ X ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object ITEMSELECTEDFB_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 102;
        X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 103;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X > 0 ) ) && Functions.TestForTrue ( READY )) ) ) && Functions.TestForTrue ( LISTITEMPOSITION[ X ] .UshortValue )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 105;
            LISTITEMSELECTED [ LISTITEMPOSITION[ X ] .UshortValue]  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ITEMSELECTEDFB_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 111;
        X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 112;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X > 0 ) ) && Functions.TestForTrue ( READY )) ) ) && Functions.TestForTrue ( LISTITEMPOSITION[ X ] .UshortValue )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 114;
            LISTITEMSELECTED [ LISTITEMPOSITION[ X ] .UshortValue]  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LISTITEMSELECT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 120;
        X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 121;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X > 0 ) ) && Functions.TestForTrue ( READY )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 123;
            ITEMSELECT [ ORGINPOS[ X ]]  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LISTITEMSELECT_OnRelease_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        
        __context__.SourceCodeLine = 129;
        X = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 130;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( X > 0 ) ) && Functions.TestForTrue ( READY )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 132;
            ITEMSELECT [ ORGINPOS[ X ]]  .Value = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object READYLATCH_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 137;
        PROCESSLIST (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LISTITEMPOSITION_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 141;
        if ( Functions.TestForTrue  ( ( READY)  ) ) 
            { 
            __context__.SourceCodeLine = 143;
            READY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 144;
            PROCESSLIST (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ITEMNAME_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 149;
        if ( Functions.TestForTrue  ( ( READY)  ) ) 
            { 
            __context__.SourceCodeLine = 151;
            READY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 152;
            PROCESSLIST (  __context__  ) ; 
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
        
        __context__.SourceCodeLine = 157;
        READY = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    ORGINPOS  = new ushort[ 11 ];
    
    READYLATCH = new Crestron.Logos.SplusObjects.DigitalInput( READYLATCH__DigitalInput__, this );
    m_DigitalInputList.Add( READYLATCH__DigitalInput__, READYLATCH );
    
    ITEMSELECTEDFB = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        ITEMSELECTEDFB[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ITEMSELECTEDFB__DigitalInput__ + i, ITEMSELECTEDFB__DigitalInput__, this );
        m_DigitalInputList.Add( ITEMSELECTEDFB__DigitalInput__ + i, ITEMSELECTEDFB[i+1] );
    }
    
    ITEMDISABLE = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        ITEMDISABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( ITEMDISABLE__DigitalInput__ + i, ITEMDISABLE__DigitalInput__, this );
        m_DigitalInputList.Add( ITEMDISABLE__DigitalInput__ + i, ITEMDISABLE[i+1] );
    }
    
    LISTITEMSELECT = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTITEMSELECT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LISTITEMSELECT__DigitalInput__ + i, LISTITEMSELECT__DigitalInput__, this );
        m_DigitalInputList.Add( LISTITEMSELECT__DigitalInput__ + i, LISTITEMSELECT[i+1] );
    }
    
    ITEMSELECT = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        ITEMSELECT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ITEMSELECT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( ITEMSELECT__DigitalOutput__ + i, ITEMSELECT[i+1] );
    }
    
    LISTITEMSELECTED = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTITEMSELECTED[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LISTITEMSELECTED__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LISTITEMSELECTED__DigitalOutput__ + i, LISTITEMSELECTED[i+1] );
    }
    
    LISTITEMENABLE = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTITEMENABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LISTITEMENABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LISTITEMENABLE__DigitalOutput__ + i, LISTITEMENABLE[i+1] );
    }
    
    LISTITEMVISIBLE = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTITEMVISIBLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LISTITEMVISIBLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LISTITEMVISIBLE__DigitalOutput__ + i, LISTITEMVISIBLE[i+1] );
    }
    
    LISTITEMPOSITION = new InOutArray<AnalogInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTITEMPOSITION[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( LISTITEMPOSITION__AnalogSerialInput__ + i, LISTITEMPOSITION__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LISTITEMPOSITION__AnalogSerialInput__ + i, LISTITEMPOSITION[i+1] );
    }
    
    ITEMNAME = new InOutArray<StringInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        ITEMNAME[i+1] = new Crestron.Logos.SplusObjects.StringInput( ITEMNAME__AnalogSerialInput__ + i, ITEMNAME__AnalogSerialInput__, 40, this );
        m_StringInputList.Add( ITEMNAME__AnalogSerialInput__ + i, ITEMNAME[i+1] );
    }
    
    LISTITEMNAME = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LISTITEMNAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( LISTITEMNAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( LISTITEMNAME__AnalogSerialOutput__ + i, LISTITEMNAME[i+1] );
    }
    
    
    for( uint i = 0; i < 10; i++ )
        ITEMDISABLE[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ITEMDISABLE_OnPush_0, false ) );
        
    for( uint i = 0; i < 10; i++ )
        ITEMDISABLE[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( ITEMDISABLE_OnRelease_1, false ) );
        
    for( uint i = 0; i < 10; i++ )
        ITEMSELECTEDFB[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( ITEMSELECTEDFB_OnPush_2, false ) );
        
    for( uint i = 0; i < 10; i++ )
        ITEMSELECTEDFB[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( ITEMSELECTEDFB_OnRelease_3, false ) );
        
    for( uint i = 0; i < 10; i++ )
        LISTITEMSELECT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( LISTITEMSELECT_OnPush_4, false ) );
        
    for( uint i = 0; i < 10; i++ )
        LISTITEMSELECT[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( LISTITEMSELECT_OnRelease_5, false ) );
        
    READYLATCH.OnDigitalPush.Add( new InputChangeHandlerWrapper( READYLATCH_OnPush_6, false ) );
    for( uint i = 0; i < 10; i++ )
        LISTITEMPOSITION[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( LISTITEMPOSITION_OnChange_7, true ) );
        
    for( uint i = 0; i < 10; i++ )
        ITEMNAME[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( ITEMNAME_OnChange_8, true ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TOWSON_ASSIGNABLE_LIST ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint READYLATCH__DigitalInput__ = 0;
const uint ITEMSELECTEDFB__DigitalInput__ = 1;
const uint ITEMDISABLE__DigitalInput__ = 11;
const uint LISTITEMSELECT__DigitalInput__ = 21;
const uint ITEMSELECT__DigitalOutput__ = 0;
const uint LISTITEMSELECTED__DigitalOutput__ = 10;
const uint LISTITEMENABLE__DigitalOutput__ = 20;
const uint LISTITEMVISIBLE__DigitalOutput__ = 30;
const uint LISTITEMPOSITION__AnalogSerialInput__ = 0;
const uint ITEMNAME__AnalogSerialInput__ = 10;
const uint LISTITEMNAME__AnalogSerialOutput__ = 0;

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
